' This iteration of the Car type maintains a list of 
' objects implementing the IEngineEvents interface.
Public Class Car
    'The set of connected clients.
    Private clientSinks As New ArrayList()

    ' The client calls these methods to connect to, or detach from, the event notification.
    Public Sub Connect(ByVal sink As IEngineEvents)
        clientSinks.Add(sink)
    End Sub

    Public Sub Disconnect(ByVal sink As IEngineEvents)
        clientSinks.Remove(sink)
    End Sub

    ' Constant for maximum speed
    Public Const maxSpeed As Integer = 100
    ' Internal state data
    Private currSpeed As Integer
    Private petName As String

    ' Is the car still operational?
    Private carIsDead As Boolean

    ' Constructors
    Public Sub New()
    End Sub
    Public Sub New(ByVal name As String, ByVal currSp As Integer)
        currSpeed = currSp
        petName = name
    End Sub

    ' The Accelerate method now fires event notifications to the caller,
    ' rather than throwing a custom exception.
    Public Sub Accelerate(ByVal delta As Integer)
        If carIsDead Then
            For Each i As IEngineEvents In clientSinks
                i.Exploded("Sorry! This car is toast!")
            Next
        Else
            currSpeed += delta
            If (maxSpeed - currSpeed) = 10 Then
                For Each i As IEngineEvents In clientSinks
                    i.AboutToBlow("Careful! About to blow!")
                Next
            End If
            ' Is the car doomed?
            If currSpeed >= maxSpeed Then
                carIsDead = True
            Else
                ' We are OK, just print out the speed.
                Console.WriteLine($"=> CurrSpeed = {currSpeed}")
            End If
        End If
    End Sub

End Class
