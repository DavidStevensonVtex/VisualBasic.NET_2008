Public Class Car
    ' A custom default constructor.
    Public Sub New()
        petName = "Chuck"
        currSpeed = 10
    End Sub

    ' Here, currSpeed will receive the default value of an Integer(zero).
    Public Sub New(ByVal pn As String)
        petName = pn
    End Sub

    Public Sub New(ByVal pn As String, ByVal cs As Integer)
        petName = pn
        currSpeed = cs
    End Sub

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
