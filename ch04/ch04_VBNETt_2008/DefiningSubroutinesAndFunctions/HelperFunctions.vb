Module HelperFunctions
	' Subroutines have no return value.
	Sub PrintMessage(ByVal msg As String)
		Console.WriteLine(msg)
	End Sub

	' Functions have a return value.
	Function Add(ByVal x As Integer, ByVal y As Integer) As Integer
		'Add = x + y
		Return x + y
	End Function

	' This will not compile if Option Strict is on
	Function Test() As Integer     ' As Object assumed
		Return 5
	End Function
	'Error BC30210	Option Strict On requires all Function, Property, And Operator declarations To have an 'As' clause.	

End Module
