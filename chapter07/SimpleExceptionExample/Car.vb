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
                currSpeed = 0
                carIsDead = True
                ' We need to call the HelpLink property, thus we need to 
                ' create a local variable before throwing the Exception
                Dim ex As New CarIsDeadException($"{petName} has overheated!")
                ex.HelpLink = "http://www.CarsRUs.com"

                ' Stuff in custom data regarding the error.
                ex.Data.Add("TimeStamp", $"The car exploded at {DateTime.Now}")
                ex.Data.Add("Cause", "You have a lead foot.")
                Throw ex
            Else
                Console.WriteLine($"=> CurrSpeed = {currSpeed}")
            End If
        End If
    End Sub

End Class
