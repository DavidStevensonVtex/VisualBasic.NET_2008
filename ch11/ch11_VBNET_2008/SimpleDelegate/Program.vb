Imports System

Module Program
	Sub Main(args As String())
		Console.WriteLine("***** Simple Delegate Example *****")

		' Make a delegate object and add a method to the invocation
		' list using the AddressOf keyword.

		Dim b As BinaryOp = New BinaryOp(AddressOf SimpleMath.Add)

		' Invoke the method "pointed to."
		Console.WriteLine($"10 + 10 is {b(10, 10)}")
		Console.WriteLine()
	End Sub
End Module
