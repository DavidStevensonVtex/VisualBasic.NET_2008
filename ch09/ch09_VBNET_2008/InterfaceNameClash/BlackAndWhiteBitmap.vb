' Note: Each method has been defined as Private???
Public Class BlackAndWhiteBitmap
	Implements IDrawToForm, IDrawToMemory, IDrawToPrinter

	Private Sub X() Implements IDrawToForm.Draw
		Console.WriteLine("BlackAndWhiteBitmap Draw To Form")
	End Sub

	Private Sub Y() Implements IDrawToMemory.Draw
		Console.WriteLine("BlackAndWhiteBitmap Draw To Memory")
	End Sub

	Private Sub Z() Implements IDrawToPrinter.Draw
		Console.WriteLine("BlackAndWhiteBitmap Draw To Printer")
	End Sub
End Class
