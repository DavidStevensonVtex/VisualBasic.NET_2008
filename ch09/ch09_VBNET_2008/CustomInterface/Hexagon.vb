Public Class Hexagon
	Inherits Shape
	Implements IPointy, IDraw3D

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

	Public Sub Draw3D() Implements IDraw3D.Draw3D
		Console.WriteLine("Drawing Hexagon in 3D")
	End Sub
End Class
