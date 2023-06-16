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
		' You can force the runtime to pass in a copy of the data by
		' wrapping the parameter within an extra set of parentheses.
		PrintMessage((msg))
		Console.WriteLine("After call msg = {0}", msg)

		' Accept all defaults for the optional args.
		PrintFormattedMessage("Call One")

		' Provide an optional argument.
		PrintFormattedMessage("Call Two", True, 5, ConsoleColor.Yellow)

		' Print this message in current case, one time, in gray.
		PrintFormattedMessage("Call Three", , , ConsoleColor.Gray)

		' A more elegan mannager in which to skip over select optional arguments is using named arguments.
		PrintFormattedMessage("Call Four", textColor:=ConsoleColor.Gray)


		' ParamArray data can be setnt as a cller-supplied Array
		' or a comma-delimited list of arguments.
		Console.WriteLine(CalculateAverage(10, 11, 12, 44))
		Console.WriteLine(CalculateAverage(1, 2))

		Dim data() As Integer = {22, 33, 44, 55}
		Console.WriteLine(CalculateAverage(data))
	End Sub
End Module
