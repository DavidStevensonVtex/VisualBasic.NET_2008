Module HelperFunctions
	' Subroutines have no return value.
	Sub PrintMessage(ByRef msg As String)
		Console.WriteLine("Your message is: " & msg)

		' Caller will see this change, as "msg" is passed ByRef
		msg = "Thank you for calling this method"
	End Sub

	' Functions have a return value.
	Function Add(ByVal x As Integer, ByVal y As Integer) As Integer
		'Add = x + y
		' Try to set the params to a new value for the caller.
		x = 22 : y = 30
		Return x + y
	End Function

	' This will not compile if Option Strict is on
	Function Test() As Integer     ' As Object assumed
		Return 5
	End Function
	'Error BC30210	Option Strict On requires all Function, Property, And Operator declarations To have an 'As' clause.	

	Sub PrintFormattedMessage(ByVal msg As String,
		Optional ByVal upperCase As Boolean = False,
		Optional ByVal timesToRepeat As Integer = 0,
		Optional ByVal textColor As ConsoleColor = ConsoleColor.Green)
		' Store current console foreground color.
		Dim foreGroundColor As ConsoleColor = Console.ForegroundColor
		' Set console foreground color.
		Console.ForegroundColor = textColor
		' Print message in correct case x number of times
		For i As Integer = 0 To timesToRepeat
			Console.WriteLine(msg)
		Next
		' Reset current console foreground color
		Console.ForegroundColor = foreGroundColor
	End Sub

	Function CalculateAverage(ByVal ParamArray itemsToAvg() As Integer) As Double
		Dim itemCount As Integer = itemsToAvg.Count
		Dim result As Integer = 0
		For Each item As Integer In itemsToAvg
			result = result + item
		Next
		Return Convert.ToDouble(result) / itemCount
	End Function

	Sub PrintLocalCounter()
		' Note the Static keyword
		Static Dim localCounter As Integer

		localCounter += 1
		Console.Write("{0} ", localCounter)
	End Sub
End Module
