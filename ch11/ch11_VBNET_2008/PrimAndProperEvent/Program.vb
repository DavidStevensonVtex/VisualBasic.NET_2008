Imports System

Module Program
	Sub Main(args As String())
		Console.WriteLine("***** Fun with Prim and Proper Events *****")
		' Note lack of WithEvents keyword.
		Dim c As New Car("Nightrider", 50)

		' Dynamically ook into event using AddHandler.
		AddHandler c.Exploded, AddressOf CarEventHandler
		AddHandler c.AboutToBlow, AddressOf CarEventHandler

		For i As Integer = 0 To 5
			c.Accelerate(10)
		Next

		' Dynamically unhook a handler using RemoveHandler
		RemoveHandler c.Exploded, AddressOf CarEventHandler
	End Sub

	Sub CarEventHandler(ByVal sender As Object, ByVal args As CarEventArgs)
		Console.WriteLine(args.Message)
	End Sub
End Module
