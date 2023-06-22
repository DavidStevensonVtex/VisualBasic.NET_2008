Imports System

Module Program
	Sub Main(args As String())
		Console.WriteLine("***** Simple Delegate Example *****")

		' Make a delegate object and add a method to the invocation
		' list using the AddressOf keyword.

		' Make a new SimpleMath object.
		Dim myMath As New SimpleMath()

		Dim b As BinaryOp = New BinaryOp(AddressOf myMath.Add)

		' Invoke the method "pointed to."
		Console.WriteLine($"10 + 10 is {b(10, 10)}")
		Console.WriteLine()

		' Display details about "b"
		DisplayDelegateINfo(b)
	End Sub

	Sub DisplayDelegateINfo(ByVal delObj As System.Delegate)
		For Each d As System.Delegate In delObj.GetInvocationList()
			Console.WriteLine($"Method Name: {d.Method}")
			Console.WriteLine($"Type Name:   {d.Target}")
		Next
	End Sub
End Module
