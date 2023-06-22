Imports System

Module Program
	Sub Main(args As String())
		Console.WriteLine("**** Fund with Custom Generic Types *****")
		Console.WriteLine()

		' Make a Point using Integers
		Dim intPt As New Point(Of Integer)(100, 100)
		Console.WriteLine($"intPt.ToString() = {intPt.ToString()}")

		' Point using Double
		Dim dblPt As New Point(Of Double)(5.6, 3.23)
		Console.WriteLine($"dblPt.ToString() = {dblPt.ToString()}")

		' Swap two Points
		Dim p1 As New Point(Of Integer)(10, 43)
		Dim p2 As New Point(Of Integer)(6, 987)
		Console.WriteLine($"Before swap: {p1} , {p2}")

		' Here we are swapping two points of type Integer.
		Swap(p1, p2)
		Console.WriteLine($"After swap: {p1} , {p2}")
		Console.WriteLine()

	End Sub

	Public Sub Swap(Of T)(ByRef a As T, ByRef b As T)
		Dim temp As T
		temp = a
		a = b
		b = temp
	End Sub
End Module
