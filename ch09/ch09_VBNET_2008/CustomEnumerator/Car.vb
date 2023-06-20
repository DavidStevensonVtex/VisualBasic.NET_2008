Public Class Car
	' Constant for mximum speed.
	Public Const maxSpeed As Integer = 100

	' The "state" of the Car.
	Public Name As String
	Public Speed As Integer

	' Is the car still operational?
	Private carIsDead As Boolean

	' Car "has-a" Radio
	'Private theMusicBox As New Radio()

	Public Sub New(ByVal pn As String, ByVal cs As Integer)
		Speed = cs
		Name = pn
	End Sub

	'Public Sub CrankTunes(ByVal state As Boolean)
	'	theMusicBox.TurnOn(state)
	'End Sub

	' See if the Car has overheated.
	Public Sub Accelerate(ByVal delta As Integer)
		If delta < 0 Then
			Throw New ArgumentOutOfRangeException()
		End If

		If carIsDead Then
			Console.WriteLine($"{Name} is out of order...")
		Else
			Speed += delta
			If Speed > maxSpeed Then
				' Throw new exception! This car is toast!
				'Dim ex As New CarIsDeadException($"{petName} has overheated!")
				'ex.HelpLink = "http://www.CarsRUs.com"
				'ex.Data.Add("TimeStamp", $"The car exploded at {DateTime.Now}")
				'ex.Data.Add("Cause", "You have a lead foot.")
				'Throw ex
				Speed = 0
				carIsDead = True
			Else
				Console.WriteLine($"=> CurrSpeed = {Speed}")
			End If
		End If
	End Sub
End Class
