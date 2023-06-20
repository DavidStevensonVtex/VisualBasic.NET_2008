' This iteration of the Car type maintains a list of 
' objects implementing the IEngineEvents interface.
Public Class Car
	' The set of connected clients.
	Private clientSinks As New ArrayList()
	Private carIsDead As Boolean = False
	Const MaxSpeed As Integer = 100
	Private currSpeed As Integer = 0
	Private petName As String

	' The client calls these methods to connnect
	' to, or detach from, the event notification.

	Public Sub New(ByVal name As String, ByVal currSpeed As Integer)
		petName = name
		Me.currSpeed = currSpeed
	End Sub

	Public Sub Connect(ByVal sink As IEngineEvents)
		clientSinks.Add(sink)
	End Sub

	Public Sub Disconnect(ByVal sink As IEngineEvents)
		clientSinks.Remove(sink)
	End Sub

	' The Accelerate method now fires event notifications to the caller,
	' rather than throwing a custom exception.

	Public Sub Accelerate(ByVal delta As Integer)
		' If the car is doomed, send out event to each connected client.
		If carIsDead Then
			For Each i As IEngineEvents In clientSinks
				i.Exploded("Sorry!  This car is toast!")
			Next
		Else
			currSpeed += delta
			' Send out "about to blow" event?
			If (maxSpeed - currSpeed) = 10 Then
				For Each i As IEngineEvents In clientSinks
					i.AboutToBlow("Careful! About to blow!")
				Next
			End If
		End If

		' Is the car doomed?
		If currSpeed >= MaxSpeed Then
			carIsDead = True
		Else
			' We are OK, just print out the speed.
			Console.WriteLine($"=> CurrSpeed = {currSpeed}")
		End If
	End Sub

End Class
