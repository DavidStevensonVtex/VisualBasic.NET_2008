Imports System

Module Program
	Sub Main(args As String())
		Console.WriteLine("***** Fun with Operator Overloading ******" & vbCrLf)
		AddSubtractMyPointsWithMethodCalls()
		Console.WriteLine()
	End Sub

	Sub AddSubtractMyPointsWithMethodCalls()
		Dim p1 As New MyPoint(10, 10)
		Dim p2 As New MyPoint(20, 30)

		' Add two MyPoints using Add() method
		Dim newPoint = MyPoint.Add(p1, p2)
		Console.WriteLine($"p1 + p2 = {newPoint}")
		Console.WriteLine($"{p1} + {p2} = {newPoint}")

		' Subtract two MyPoints using Subtract() method.
		Console.WriteLine($"{p1} - {p2} = {MyPoint.Subtract(p1, p2)}")
	End Sub
End Module
