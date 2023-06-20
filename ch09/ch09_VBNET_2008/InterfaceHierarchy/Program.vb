Imports System

Module Program
	Sub Main(args As String())
		Console.WriteLine("***** The SuperShape *****")

		' Call from object level.
		Dim myShape As New SuperShape
		myShape.Draw()

		' Get IPrintable explicitly.
		' (and IDrawable implicitly!)
		Dim iPrint As IPrintable
		iPrint = CType(myShape, IPrintable)
		iPrint.Draw()
		iPrint.Print()

		Dim iRender As IRenderToMemory = CType(myShape, IRenderToMemory)
		iRender.Render()
	End Sub
End Module
