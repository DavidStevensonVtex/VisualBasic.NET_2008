Imports System

Module Program
	Sub Main(args As String())
		Console.WriteLine("***** Fun with ICloneable *****")
		Dim p1 As New Point(50, 50, "Brad")
		Dim p2 As Point = CType(p1.Clone(), Point)
		p2.X = 0

		Console.WriteLine("Before modification: ")
		Console.WriteLine($"p1: {p1}")
		Console.WriteLine($"p2: {p2}")

		p2.Description.PetName = "This is my second point"
		p2.X = 9
		Console.WriteLine("Changed p2.Description.PetName and p2.X")

		Console.WriteLine("After modification: ")
		Console.WriteLine($"p1: {p1}")
		Console.WriteLine($"p2: {p2}")
		Console.WriteLine()
	End Sub
End Module
