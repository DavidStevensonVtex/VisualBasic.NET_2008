Public Class Car
	' Constant for mximum speed.
	Public Const maxSpeed As Integer = 100

	' The "state" of the Car.
	Public petName As String
	Public currSpeed As Integer

	' Is the car still operational?
	Private carIsDead As Boolean

	' Car "has-a" Radio
	Private theMusicBox As New Radio()

	Public Sub New(ByVal pn As String, ByVal cs As Integer)
		currSpeed = cs
		petName = pn
	End Sub

	Public Sub CrankTunes(ByVal state As Boolean)
		theMusicBox.TurnOn(state)
	End Sub

	' See if the Car has overheated.
	Public Sub Accelerate(ByVal delta As Integer)
		If carIsDead Then
			Console.WriteLine($"{petName} is out of order...")
		Else
			currSpeed += delta
			If currSpeed > maxSpeed Then
				' Throw new exception! This car is toast!
				Throw New Exception($"{petName} has overheated!")
				currSpeed = 0
				carIsDead = True
			Else
				Console.WriteLine($"=> CurrSpeed = {currSpeed}")
			End If
		End If
    End Sub
End Class
