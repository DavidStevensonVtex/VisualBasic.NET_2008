Public Class Car
	' The "state" of the Car.
	Public petName As String
	Public currSpeed As Integer

	' The functionality of the Car.
	Public Sub PrintState()
		Console.WriteLine("{0} is going {1} MPH.", petName, currSpeed)
	End Sub
	Public Sub SpeedUp(ByVal delta As Integer)
		currSpeed += delta
	End Sub
End Class
