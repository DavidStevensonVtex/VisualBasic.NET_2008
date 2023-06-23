Public Structure MyPoint
	Public Property X As Integer
	Public Property Y As Integer

	Public Sub New(ByVal xpos As Integer, ByVal ypos As Integer)
		X = xpos : Y = ypos
	End Sub

	Public Overrides Function ToString() As String
		Return $"[{X}, {Y}]"
	End Function

	' Adding two MyPoint objects to yield a new MyPoint.
	Public Shared Function Add(ByVal p1 As MyPoint, ByVal p2 As MyPoint)
		Return New MyPoint(p1.X + p2.X, p1.Y + p2.Y)
	End Function

	' Subtracting two MyPoint objects to yield a new MyPoint.
	Public Shared Function Subtract(ByVal p1 As MyPoint, ByVal p2 As MyPoint)
		Return New MyPoint(p1.X - p2.X, p1.Y - p2.Y)
	End Function
End Structure
