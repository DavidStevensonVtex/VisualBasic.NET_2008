Public Class Point(Of T)
	Public Property X As T
	Public Property Y As T

	Public Sub New(ByVal xpos As T, ByVal ypos As T)
		X = xpos : Y = ypos
	End Sub

	Public Overrides Function ToString() As String
		Return $"({X}, {Y})"
	End Function
End Class
