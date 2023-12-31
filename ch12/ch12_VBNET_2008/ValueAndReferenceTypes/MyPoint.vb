﻿Public Class MyPoint
	Implements IComparable
	Public Property X As Integer
	Public Property Y As Integer

	Public Sub New()
	End Sub
	Public Sub New(ByVal xpos As Integer, ByVal ypos As Integer)
		X = xpos : Y = ypos
	End Sub

	Public Overrides Function ToString() As String
		Return $"[{X}, {Y}]"
	End Function

	' Overloaded Operator +
	Public Shared Operator +(ByVal p1 As MyPoint, ByVal p2 As MyPoint) As MyPoint
		Return New MyPoint(p1.X + p2.X, p1.Y + p2.Y)
	End Operator

	' Overloaded Operator -
	Public Shared Operator -(ByVal p1 As MyPoint, ByVal p2 As MyPoint) As MyPoint
		Return New MyPoint(p1.X - p2.X, p1.Y - p2.Y)
	End Operator

	' Overridden methods of System.Object
	Public Overrides Function Equals(obj As Object) As Boolean
		If TypeOf obj Is MyPoint Then
			If Me.ToString() = obj.ToString() Then
				Return True
			End If
		End If
		Return False
	End Function

	' Now let's overload the = and the <> operators.
	Public Shared Operator =(ByVal p1 As MyPoint, ByVal p2 As MyPoint) As Boolean
		Return p1.Equals(p2)
	End Operator

	Public Shared Operator <>(ByVal p1 As MyPoint, ByVal p2 As MyPoint) As Boolean
		Return Not p1.Equals(p2)
	End Operator

	' MyPoint is also comparable using comparison operators.
	Public Function CompareTo(obj As Object) As Integer Implements IComparable.CompareTo
		If TypeOf obj Is MyPoint Then
			Dim p As MyPoint = CType(obj, MyPoint)
			If Me.X > p.X AndAlso Me.Y > p.Y Then
				Return 1
			End If
			If Me.X < p.X AndAlso Me.Y < p.Y Then
				Return -1
			Else
				Return 0
			End If
		Else
			Throw New ArgumentException()
		End If
	End Function

	' The overloaded comparison ops.
	Public Shared Operator <(ByVal p1 As MyPoint, ByVal p2 As MyPoint) As Boolean
		Return (p1.CompareTo(p2) < 0)
	End Operator
	Public Shared Operator >(ByVal p1 As MyPoint, ByVal p2 As MyPoint) As Boolean
		Return (p1.CompareTo(p2) > 0)
	End Operator
	Public Shared Operator <=(ByVal p1 As MyPoint, ByVal p2 As MyPoint) As Boolean
		Return (p1.CompareTo(p2) <= 0)
	End Operator
	Public Shared Operator >=(ByVal p1 As MyPoint, ByVal p2 As MyPoint) As Boolean
		Return (p1.CompareTo(p2) >= 0)
	End Operator
End Class
