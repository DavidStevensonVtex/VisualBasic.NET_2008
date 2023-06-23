Imports System

Module Program
	Sub Main(args As String())
		Console.WriteLine("***** Fun with CType / DirectCast / TryCast *****")
		Console.WriteLine()

		' This CType() throws an exception, as Car does not implement ITurboBoost.
		Dim myCar As New Car
		Dim iTB As ITurboBoost
		Try
			iTB = DirectCast(myCar, ITurboBoost)
		Catch ex As Exception
			Console.WriteLine("Car does not implement ITurboBoost interface.")
		End Try

		' This CType() is A-OK, as SportsCar does implement ITurboBoost.
		Dim myViper As New SportsCar()
		iTB = DirectCast(myViper, ITurboBoost)

		' CType() can also be used to narrow or widen between primitive types
		Dim i As Integer = 200
		'Dim b As Byte = DirectCast(i, Byte)
		' Severity	Code	Description	Project	File	Line	Suppression State
		'Error BC30311	Value Of type 'Integer' cannot be converted to 'Byte'.
	End Sub
End Module
