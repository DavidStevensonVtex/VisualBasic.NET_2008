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
		Catch ex As Exception
			Console.WriteLine("Car does not implement ITurboBoost interface.")
		End Try

		' This CType() is A-OK, as SportsCar does implement ITurboBoost.
		Dim myViper As New SportsCar()
		iTB = CType(myViper, ITurboBoost)

		' CType() can also be used to narrow or widen between primitive types
		Dim i As Integer = 200
		Dim b As Byte = CType(i, Byte)
	End Sub
End Module
