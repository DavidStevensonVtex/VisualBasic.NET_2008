Imports System
Imports System.IO

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

		Catch ex As ArgumentOutOfRangeException
			' Process bad arguments.
			Console.WriteLine("Argument Out of Range Exception")
		Catch ex As CarIsDeadException
			Console.WriteLine("**** Error! ****")
			Console.WriteLine($"Method: {ex.TargetSite}")
			Console.WriteLine($"Class defining member: {ex.TargetSite.DeclaringType}")
			Console.WriteLine($"Member type: {ex.TargetSite.MemberType}")
			Console.WriteLine($"Message: {ex.Message}")
			Console.WriteLine($"Source: {ex.Source}")
			Console.WriteLine($"HelpLink: {ex.HelpLink}")
			Console.WriteLine($"Stack: {ex.StackTrace}")

			' By default, the data field is empty, so check for Nothing.
			If (ex.Data IsNot Nothing) Then
				Console.WriteLine("-> Custom Data: ")
				For Each de As DictionaryEntry In ex.Data
					Console.WriteLine($"-> {de.Key} : {de.Value}")
				Next
			End If
			' Rethrow exception
			'Throw ex

			' Inner Exceptions
			'Try
			'	Dim fs As FileStream = File.Open("C:\carErrors.txt", FileMode.Open)
			'Catch ex2 As Exception
			'	Throw New CarIsDeadException(ex.Message, ex2)
			'End Try
		Catch ex As Exception
			' Process all other exceptions.
			Console.WriteLine($"{ex.Message}")
		Finally
			' This will always execute, error or not.
			myCar.CrankTunes(False)
		End Try

		' The error has been handled, processing continues with the next statement.
		Console.WriteLine("****** Out of exception logic *****")
		Console.WriteLine()
	End Sub
End Module
