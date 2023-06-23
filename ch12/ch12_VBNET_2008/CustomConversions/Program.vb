Imports System

Module Program
	Sub Main(args As String())
		Console.WriteLine("***** Fun with Custom Conversions *****")
		Console.WriteLine()

		' Create a 10 x 5 Rectangle
		Dim rect As New Rectangle
		rect.Width = 10
		rect.Height = 5
		Console.WriteLine($"rect = {rect}")

		' This is all right, as the Square has a custom narrowing CType implementation.
		Dim sq As Square = CType(rect, Square)
		Console.WriteLine($"sq = {sq}")

		' Converting an Integer to a Square
		Dim sq2 As Square = CType(90, Square)
		Console.WriteLine($"sq2 = {sq2}")

		' Converting a Square to an Integer
		Dim side As Integer = CType(sq2, Integer)
		Console.WriteLine($"Side length of sq2 = {side}")

		' Attempt to make an implicit cast?
		Dim s3 As New Square
		s3.Length = 83
		Dim rect2 As Rectangle = s3
		Console.WriteLine($"rect2 = {rect2}")
		s3.Draw()

		' Explicit cast syntax till OK
		Dim s4 As New Square
		s4.Length = 3
		Dim rect3 As Rectangle = CType(s4, Rectangle)
		Console.WriteLine($"rect3 = {rect3}")

	End Sub
End Module
