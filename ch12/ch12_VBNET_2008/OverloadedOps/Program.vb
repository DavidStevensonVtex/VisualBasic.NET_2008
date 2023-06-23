Imports System

Module Program
	Sub Main(args As String())
		Console.WriteLine("***** Fun with Operator Overloading ******" & vbCrLf)
		AddSubtractMyPointsWithMethodCalls()
		Console.WriteLine()
		TestMyPointsForEquality()
		Console.WriteLine()
		TestMyPointsForGreaterLessThan()
		Console.WriteLine()
	End Sub

	Sub AddSubtractMyPointsWithMethodCalls()
		Dim p1 As New MyPoint(10, 10)
		Dim p2 As New MyPoint(20, 30)

		' Add two MyPoints using Add() method
		Dim newPoint = p1 + p2
		Console.WriteLine($"p1 + p2 = {newPoint}")
		Console.WriteLine($"{p1} + {p2} = {newPoint}")

		' Subtract two MyPoints using Subtract() method.
		Console.WriteLine($"{p1} - {p2} = {p1 - p2}")
	End Sub

	' Make use of the overloaded equality operators.
	Sub TestMyPointsForEquality()
		Dim ptOne As New MyPoint(10, 2)
		Dim ptTWo As New MyPoint(10, 44)

		Console.WriteLine($"ptOne = ptTwo : {ptOne = ptTWo}")
		Console.WriteLine($"ptOne <> ptTwo : {ptOne <> ptTWo}")
	End Sub

	' Using the overloaded comparison operators.
	Sub TestMyPointsForGreaterLessThan()
		Dim ptOne As New MyPoint(5, 2)
		Dim ptTwo As New MyPoint(5, 44)

		Console.WriteLine($"{ptOne} > {ptTwo} : {ptOne > ptTwo}")
		Console.WriteLine($"{ptOne} < {ptTwo} : {ptOne < ptTwo}")
		Console.WriteLine($"{ptOne} >= {ptTwo} : {ptOne >= ptTwo}")
		Console.WriteLine($"{ptOne} <= {ptTwo} : {ptOne <= ptTwo}")
	End Sub
End Module
