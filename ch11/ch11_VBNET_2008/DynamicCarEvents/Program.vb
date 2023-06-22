Imports System

Module Program
	Sub Main(args As String())
		Console.WriteLine("***** Fund with AddHandler/RemoveHandler ******")

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

	' Event handler for both events
	' Note lack of Handles keyword.
	Sub CarEventHandler(ByVal msg As String)
		Console.WriteLine(msg)
	End Sub
End Module
