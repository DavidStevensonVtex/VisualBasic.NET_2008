Imports System

Public Delegate Function BinaryOp(ByVal x As Integer, ByVal y As Integer) As Integer

Module Program
	Sub Main(args As String())
		Console.WriteLine("***** Lambdas with Multiple Parameters! *****")

		' Register w/ delegate as a lambda expression.
		Dim b As New BinaryOp(Function(x, y) x + y)

		' What method is b pointing to?
		DisplayDelegateInfo(b)

		' This will execute the lambda expression.
		Console.WriteLine(b(10, 10))
		Console.WriteLine()

		Dim m As New SimpleMath()
		b = New BinaryOp(Function(x, y) SimpleMath.Add(x, y))
		Console.WriteLine(b(20, 30))
		Console.WriteLine()
	End Sub

	Sub DisplayDelegateInfo(ByVal delObj As System.Delegate)
		For Each d As System.Delegate In delObj.GetInvocationList()
			Console.WriteLine($"Method Name: {d.Method}")
			Console.WriteLine($"Type Name:   {d.Target}")
		Next
	End Sub
End Module
