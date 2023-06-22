Public Class Car
	' The Custom Delegate
	Public Delegate Sub CarDelegate(ByVal sender As Object, ByVal args As CarEventArgs)
	Private arConnections As New ArrayList()

	' This event has been customized!
	Public Custom Event EngineStart As CarDelegate
		AddHandler(value As CarDelegate)
			Console.WriteLine("Added connection")
			arConnections.Add(value)
		End AddHandler

		RemoveHandler(value As CarDelegate)
			Console.WriteLine("Removed connection")
			arConnections.Remove(value)
		End RemoveHandler

		RaiseEvent(sender As Object, e As EventArgs)
			For Each h As CarDelegate In arConnections
				Console.WriteLine("Raising event")
				h(sender, e)
			Next
		End RaiseEvent
	End Event

	Public Sub Start()
		RaiseEvent EngineStart(Me, New CarEventArgs("Enjoy the ride"))
	End Sub

End Class
