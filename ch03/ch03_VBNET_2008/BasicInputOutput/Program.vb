Imports System

Module Program
	Sub Main(args As String())
		' Echo some information to the console.
		Console.WriteLine("Enter your name: ")
		Dim s As String = Console.ReadLine()
		Console.WriteLine("Hello, {0}", s)

		Console.WriteLine("Enter your age: ")
		s = Console.ReadLine()
		Console.WriteLine("You are {0} years old.", s)
	End Sub
End Module
