Public Class Hexagon
	Inherits Shape
	Public Sub New()
	End Sub
	Public Sub New(ByVal name As String)
		MyBase.New(name)
	End Sub

	Public Overrides Sub Draw()
		Console.WriteLine("Drawing {0} the Hexagon", shapeName)
	End Sub

End Class
