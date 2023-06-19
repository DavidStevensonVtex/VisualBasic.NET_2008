Imports System

Module Program
	Sub Main(args As String())
		Console.WriteLine("***** Simple Exception Example ******")
		Console.WriteLine("=> Creating a car and stepping on it!")
		Dim myCar As New Car("Zippy", 20)
		myCar.CrankTunes(True)

		Try
			For i As Integer = 0 To 10
				myCar.Accelerate(10)
			Next
		Catch ex As Exception
			Console.WriteLine("**** Error! ****")
			Console.WriteLine($"Method: {ex.TargetSite}")
			Console.WriteLine($"Class defining member: {ex.TargetSite.DeclaringType}")
			Console.WriteLine($"Member type: {ex.TargetSite.MemberType}")
			Console.WriteLine($"Message: {ex.Message}")
			Console.WriteLine($"Source: {ex.Source}")
			Console.WriteLine($"Stack: {ex.StackTrace}")
		End Try

		' The error has been handled, processing continues with the next statement.
		Console.WriteLine("****** Out of exception logic *****")
		Console.WriteLine()
	End Sub
End Module
