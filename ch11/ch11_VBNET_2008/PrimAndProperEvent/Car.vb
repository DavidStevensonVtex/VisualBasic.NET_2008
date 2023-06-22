Public Class Car
    ' This car can send these events.
    Public Event Exploded(ByVal sender As Object, ByVal e As CarEventArgs)
    Public Event AboutToBlow(ByVal sender As Object, ByVal e As CarEventArgs)

    ' Constant for maximum speed.
    Public Const maxSpeed As Integer = 100

    'Internal state data.
    Private currSpeed As Integer
    Private petName As String

    'Is the car still operational?
    Private carIsDead As Boolean

    ' Properties.
    Public Property Name() As String
        Get
            Return petName
        End Get
        Set(ByVal value As String)
            petName = value
        End Set
    End Property
    Public Property Speed() As Integer
        Get
            Return currSpeed
        End Get
        Set(ByVal value As Integer)
            currSpeed = value
        End Set
    End Property

    ' Constructors.
    Public Sub New()
    End Sub
    Public Sub New(ByVal name As String, ByVal currSp As Integer)
        currSpeed = currSp
        petName = name
    End Sub

    ' See if Car has overheated.
    Public Sub Accelerate(ByVal delta As Integer)
        If carIsDead Then
            ' If the car is doomed, raise Exploded event.
            RaiseEvent Exploded(Me, New CarEventArgs("Sorry, this car is doomed..."))
        Else
            currSpeed += delta
            ' Are we almost doomed? If so, send out "AboutToBlow" notification.
            If 10 = maxSpeed - currSpeed Then
                RaiseEvent AboutToBlow(Me, New CarEventArgs("Slow down!"))
            End If
            If currSpeed >= maxSpeed Then
                carIsDead = True
            Else
                Console.WriteLine("=> CurrSpeed = {0} ", currSpeed)
            End If
        End If
    End Sub

End Class
