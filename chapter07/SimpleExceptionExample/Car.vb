Public Class Car
    ' Constant for maximum speed
    Public Const maxSpeed As Integer = 100
    ' Internal state data
    Private currSpeed As Integer
    Private petName As String

    ' Is the car still operational?
    Private carIsDead As Boolean

    ' A car has a radio
    Private theMusicBox As New Radio()

    ' Constructors
    Public Sub New()
    End Sub
    Public Sub New(ByVal name As String, ByVal currSp As Integer)
        currSpeed = currSp
        petName = name
    End Sub

    Public Sub CrankTunes(ByVal state As Boolean)
        theMusicBox.TurnOn(state)
    End Sub

    ' See if Car has overheated.
    Public Sub Accelerate(ByVal delta As Integer)
        If carIsDead Then
            Console.WriteLine($"{petName} is out of order...")
        Else
            currSpeed += delta
            If currSpeed > maxSpeed Then
                Console.WriteLine($"{petName} has overheated!")
                currSpeed = 0
                carIsDead = True
            Else
                Console.WriteLine($"=> CurrSpeed = {currSpeed}")
            End If
        End If
    End Sub

End Class
