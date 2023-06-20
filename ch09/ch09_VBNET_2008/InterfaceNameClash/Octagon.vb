Public Class Octagon
	Implements IDrawToForm, IDrawToMemory, IDrawToPrinter

	Public Sub Draw() Implements IDrawToForm.Draw
		Console.WriteLine("Octagon Draw To Form")
	End Sub

	Private Sub RenderToMemory() Implements IDrawToMemory.Draw
		Console.WriteLine("Octagon Draw To Memory")
	End Sub

	Private Sub Print() Implements IDrawToPrinter.Draw
		Console.WriteLine("Octagon Draw To Print")
	End Sub
End Class
