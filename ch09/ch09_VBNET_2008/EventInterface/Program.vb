Imports System

Module Program
	Sub Main(args As String())
		Console.WriteLine("***** Interfaces as event enablers *****")
		Dim myCar As New Car("SlugBug", 10)

		' Make sink object
		Dim sink As New CarEventSink("MySink")

		' Register the sink with the Car
		myCar.Connect(sink)

		' Speed up (this will trigger the event notifications).
		For i As Integer = 0 To 5
			myCar.Accelerate(20)
		Next

		' Detach from event source.
		myCar.Disconnect(sink)
		Console.WriteLine()
	End Sub
End Module
