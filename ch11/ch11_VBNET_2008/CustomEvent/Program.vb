Imports System

Module Program
	Sub Main(args As String())
		Console.WriteLine("***** Fun with Custom Events ******")
		Dim c As New Car()

		' Dynamically hook into event.
		AddHandler c.EngineStart, AddressOf EngineStartHandler
		c.Start()

		' Just to trigger out custom logic.
		RemoveHandler c.EngineStart, AddressOf EngineStartHandler
		Console.WriteLine("After RemoveHandler")

		' Just to test we are no longer sending event.
		c.Start()
	End Sub

	' OUr handler must match this signature given that 
	' EngineStart has been prototyped using the System.EventHandler delegate.
	Sub EngineStartHandler(ByVal sender As Object, ByVal e As EventArgs)
		Console.WriteLine("Car has started")
	End Sub
End Module
