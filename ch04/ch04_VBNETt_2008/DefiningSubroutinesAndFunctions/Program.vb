Imports System

Module Program
	Sub Main(args As String())
		Console.WriteLine("***** Fun with Methods ******")
		' Pass two integers by value.
		Dim x, y As Integer
		x = 10 : y = 20
		Console.WriteLine("{0} + {1} = {2}", x, y, Add(x, y))

		' x is still 10 and y is still 20.
		Console.WriteLine("After call x = {0} and y = {1}", x, y)

		Dim msg As String = "Hello from Main!"
		PrintMessage(msg)
		Console.WriteLine("After call msg = {0}", msg)
	End Sub
End Module
