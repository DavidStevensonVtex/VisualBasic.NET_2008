Imports System

Module Program
	Sub Main(args As String())
		Console.WriteLine("Welcome to the world of .NET")
		Console.WriteLine(" 1 = C#  2 = C++/CLI   3 = VB 2008")
		Console.Write("Please select your implementation language: ")
		' Get choice.
		Dim s As String = Console.ReadLine()
		Dim n As Integer = Integer.Parse(s)

		' Based on input, act accordingly
		Select Case n
			Case Is = 1
				Console.WriteLine("C# is all about managed code.")
			Case Is = 2
				Console.WriteLine("Maintaining a legacy system, are we?")
			Case Is = 3
				Console.WriteLine("VB 2008: Full OO Capabilities...")
			Case Else
				Console.WriteLine("Well... Good luck with that!")
		End Select
	End Sub
End Module
