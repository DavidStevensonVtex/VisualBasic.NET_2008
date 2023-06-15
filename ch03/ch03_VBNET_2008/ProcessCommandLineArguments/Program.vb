Imports System

Module Program
	Function Main(args As String()) As Integer
		Console.WriteLine("Hello World!")
		For Each s In args
			Console.WriteLine("Arg: {0}", s)
		Next
		' Return a value to the OS
		Return 0
	End Function
End Module
