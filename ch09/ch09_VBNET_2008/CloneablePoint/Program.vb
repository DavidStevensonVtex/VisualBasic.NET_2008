Imports System

Module Program
	Sub Main(args As String())
		Console.WriteLine("***** Fun with ICloneable *****")
		' Two references to the same object!
		Dim p1 As New Point(50, 50)
		Dim p2 As Point = CType(p1.Clone(), Point)
		p2.X = 0

		' Prints out X = 50 ; Y = 50
		Console.WriteLine(p1)

		' Prints out X = 0 ; Y = 50
		Console.WriteLine(p2)
		Console.WriteLine()
	End Sub
End Module
