Public Class Car
    ' The "state" of a Car.
    Public petName As String
    Public currSpeed As Integer

    ' The functionality of the Car.
    Public Sub PrintState()
        Console.WriteLine($"{petName} is going {currSpeed} MPH.")
    End Sub

    Public Sub SpeedUp(ByVal delta As Integer)
        currSpeed += delta
    End Sub

End Class
