Imports System

Module Program
	Sub Main(args As String())
		Console.WriteLine("***** Fun with Value and the Assignment Operator *****")
		Console.WriteLine("-> Creating p1")
		Dim p1 As New MyPoint(100, 100)

		Console.WriteLine("-> Assigning p2 to p1")
		Dim p2 As MyPoint = p1

		' Here is p1
		Console.WriteLine($"p1: {p1}")
		Console.WriteLine($"p2: {p2}")

		' change p2.x. This will not change p1.x
		Console.WriteLine("-> Changing p2.x to 900")
		p2.X = 900

		' Print again.
		Console.WriteLine("-> Here are the values again...")
		Console.WriteLine($"p1: {p1}")
		Console.WriteLine($"p2: {p2}")
		Console.WriteLine()

		SomeMethod()
		SomeOtherMethod()
		CreateValueTypes()
	End Sub

	' Integers are value types!
	Public Sub SomeMethod()
		Dim i As Integer = 0
		Console.WriteLine($"Value of i is: {i}")
	End Sub

	' Assigning two intrinsic value types results in 
	' two independent variables on the stack.
	Public Sub SomeOtherMethod()
		Dim i As Integer = 99
		Dim k As Integer = i

		' After the following assignment, "i" is still 99
		k = 8732
		Console.WriteLine($"Value of k: {k}. Value of i is: {i} (still 99)")
	End Sub

	Sub CreateValueTypes()
		' Allocated on the stack!
		Dim p As New MyPoint()

		' Note lack of New keyword
		Dim p1 As MyPoint
		p1.X = 100
		p1.Y = 100
	End Sub
End Module
