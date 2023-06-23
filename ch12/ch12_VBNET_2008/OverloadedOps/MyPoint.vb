Public Structure MyPoint
	Public Property X As Integer
	Public Property Y As Integer

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
End Structure
