Public Class Car
	' This ArrayList will hold onto the delegates
	' sent from the caller.
	Private arConnections As New ArrayList()

	' This event has been customized!
	Public Custom Event EngineStart As System.EventHandler
		AddHandler(value As EventHandler)
			Console.WriteLine("Added connection")
			arConnections.Add(value)
		End AddHandler

		RemoveHandler(value As EventHandler)
			Console.WriteLine("Removed connection")
			arConnections.Remove(value)
		End RemoveHandler

		RaiseEvent(sender As Object, e As EventArgs)
			For Each h As EventHandler In arConnections
				Console.WriteLine("Raising event")
				h(sender, e)
			Next
		End RaiseEvent
	End Event

	Public Sub Start()
		RaiseEvent EngineStart(Me, New EventArgs())
	End Sub

End Class
