Imports System

Module Program
	Sub Main()
		' Show Banner
		DisplayBanner()
		' Get user's name and say howdy.
		GreetUser()
	End Sub

	Sub DisplayBanner()
		' Get the current color of the console text.
		Dim currColor As ConsoleColor = Console.ForegroundColor

		' Set text color to yellow
		Console.ForegroundColor = ConsoleColor.Yellow
		Console.WriteLine("******* Welcome to FunWithModules *******")
		Console.WriteLine("This simple program illustrates the role")
		Console.WriteLine("of the Module type.")
		Console.WriteLine("***********************************************")

		' Reset to previous color of your console text.
		Console.ForegroundColor = currColor
		Console.WriteLine()
	End Sub

	Sub GreetUser()
		Dim userName As String
		Console.Write("Please enter your name: ")
		userName = Console.ReadLine()
		Console.WriteLine("Hello there {0}. Nice to meet ya.", userName)
	End Sub

End Module
