Imports System

Module Program
	Sub Main(args As String())
		Console.WriteLine("***** Fun with Interface Name Clashes *****")
		Dim o As New Octagon

		' Call IDrawToMemory.Draw()
		Dim iMem As IDrawToMemory = CType(o, IDrawToMemory)
		iMem.Draw()

		' Call IDrawToPrinter.Draw()
		Dim iPrint As IDrawToPrinter = CType(o, IDrawToPrinter)
		iPrint.Draw()

		' Call IDrawToForm.Draw()
		Dim iForm As IDrawToForm = CType(o, IDrawToForm)
		iForm.Draw()

		Dim bitmap As New BlackAndWhiteBitmap
		' The following private methods generate compile errors.
		'bitmap.X()
		'bitmap.Y()
		'bitmap.Z()
		' Call IDrawToMemory.Draw()
		iMem = CType(bitmap, IDrawToMemory)
		iMem.Draw()

		' Call IDrawToPrinter.Draw()
		iPrint = CType(bitmap, IDrawToPrinter)
		iPrint.Draw()

		' Call IDrawToForm.Draw()
		iForm = CType(bitmap, IDrawToForm)
		iForm.Draw()

	End Sub
End Module
