' A class named Point.
Public Class Point
	Implements ICloneable
	' Public for easy access, freel free to add properties
	' to wrap private data if you choose.
	Public Property X As Integer
	Public Property Y As Integer

	Public Sub New()
	End Sub
	Public Sub New(ByVal xpos As Integer, ByVal ypos As Integer)
		X = xpos
		Y = ypos
	End Sub

	Public Overrides Function ToString() As String
		Return $"X = {X}, Y = {Y}"
	End Function

	Public Function Clone() As Object Implements ICloneable.Clone
		Return New Point(X, Y)
	End Function
End Class
