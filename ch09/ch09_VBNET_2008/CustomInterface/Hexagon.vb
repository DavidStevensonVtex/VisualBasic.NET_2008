Public Class Hexagon
	Inherits Shape
	Implements IPointy

	Public Sub New()
	End Sub
	Public Sub New(ByVal name As String)
		MyBase.New(name)
	End Sub

	Public ReadOnly Property Points As Byte Implements IPointy.Points
		Get
			Return 6
		End Get
	End Property

	Public Overrides Sub Draw()
		Console.WriteLine("Drawing {0} the Hexagon", shapeName)
	End Sub

End Class
