Imports System

Module Program
	' Declare member variables "WithEvents" to capture the events.
	Private WithEvents c As New Car("NightRider", 50)
	Sub Main(args As String())
		Console.WriteLine("***** Fun with Events ******")

		For i As Integer = 0 To 5
			c.Accelerate(10)
		Next

	End Sub

	' Event Handlers.
	Public Sub MyExplodedEventHanlder(ByVal s As String) Handles c.Exploded
		Console.WriteLine(s)
	End Sub

	Public Sub MyCarIsAboutToDieHandler(ByVal s As String) Handles c.AboutToBlow
		Console.WriteLine(s)
	End Sub

End Module
