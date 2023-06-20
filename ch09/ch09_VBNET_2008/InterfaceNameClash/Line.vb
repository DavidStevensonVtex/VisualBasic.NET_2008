Public Class Line
	Implements IDrawToForm, IDrawToMemory, IDrawToPrinter
	Public Sub Draw() Implements IDrawToForm.Draw
		Console.WriteLine("Line Draw To Form")
	End Sub

	Private Sub RenderToMemory() Implements IDrawToMemory.Draw
		Console.WriteLine("Line Draw To Memory")
	End Sub

	Private Sub Print() Implements IDrawToPrinter.Draw
		Console.WriteLine("Line Draw To Print")
	End Sub
End Class
