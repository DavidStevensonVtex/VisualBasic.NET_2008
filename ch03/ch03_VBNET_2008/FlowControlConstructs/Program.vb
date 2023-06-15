Imports System

Module Program
	Sub Main(args As String())
		Dim userDone As Boolean = True

		If userDone Then
			Console.WriteLine("Thanks for running this app")
		End If

		Dim userOption As String

		' Read user option from command line
		Console.WriteLine("User option: ")
		userOption = Console.ReadLine()

		If userOption = "GodMode" Then
			Console.WriteLine("You will never die... cheater!")
		ElseIf userOption = "FullLife" Then
			Console.WriteLine("At the end, heh?")
		ElseIf userOption = "AllAmmo" Then
			Console.WriteLine("Now we can rock and roll!")
		Else
			Console.WriteLine("Unknown option...")
		End If
	End Sub
End Module
