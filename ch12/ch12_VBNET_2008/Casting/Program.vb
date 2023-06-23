Imports System

Module Program
	Sub Main(args As String())
		Console.WriteLine("***** Fun with CType / DirectCast / TryCast *****")
		Console.WriteLine()

		' This CType() throws an exception, as Car does not implement ITurboBoost.
		Dim myCar As New Car
		Dim iTB As ITurboBoost
		Try
			iTB = CType(myCar, ITurboBoost)
		Catch ex As InvalidCastException
			Console.WriteLine("Car does not implement ITurboBoost interface.")
		End Try

		' This CType() is A-OK, as SportsCar does implement ITurboBoost.
		Dim myViper As New SportsCar()
		iTB = DirectCast(myViper, ITurboBoost)


		' TryCast() returns Nothing if the types are not compatible.
		iTB = TryCast(myCar, ITurboBoost)
		If iTB Is Nothing Then
			Console.WriteLine("Car does not implement ITurboBoost interface.")
		End If
	End Sub
End Module
