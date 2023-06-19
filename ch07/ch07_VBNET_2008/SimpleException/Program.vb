Imports System

Module Program
	Sub Main(args As String())
		Console.WriteLine("***** Simple Exception Example ******")
		Console.WriteLine("=> Creating a car and stepping on it!")
		Dim myCar As New Car("Zippy", 20)
		myCar.CrankTunes(True)

		For i As Integer = 0 To 10
			myCar.Accelerate(10)
		Next
		Console.WriteLine()
	End Sub
End Module
