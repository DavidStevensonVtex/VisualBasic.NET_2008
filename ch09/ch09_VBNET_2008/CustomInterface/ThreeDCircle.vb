Public Class ThreeDCircle
	Inherits Circle

	'Warning	BC40005	Sub 'Draw' shadows an overridable method in the base class 'Circle'.
	'           To override the base method, this method must be declared 'Overrides'.
	' Two solutions: Overrides or Shadows keywords.
	Public Shadows Sub Draw()
		Console.WriteLine("Drawing a 3D Circle")
	End Sub

End Class
