Public Class Car
	' Our delegate type is nested in the Car type.
	Public Delegate Sub CarDelegateHandler(ByVal msg As String)

	' Because delegates are simply classes, we can create 
	' member variables of delegate types.
	Private almostDeadList As CarDelegateHandler
	Private explodedList As CarDelegateHandler

    ' To allo the caller to pass us a delegate object.
    Public Sub RemoveAboutToBlow(ByVal clientMethod As CarDelegateHandler)
        almostDeadList = CType(System.Delegate.Remove(almostDeadList, clientMethod), CarDelegateHandler)
    End Sub
    Public Sub OnAboutToBlow(ByVal clientMethod As CarDelegateHandler)
        almostDeadList = CType(System.Delegate.Combine(almostDeadList, clientMethod), CarDelegateHandler)
    End Sub

    Public Sub RemoveExploded(ByVal clientMethod As CarDelegateHandler)
        explodedList = CType(System.Delegate.Remove(explodedList, clientMethod), CarDelegateHandler)
    End Sub

    Public Sub OnExploded(ByVal clientMethod As CarDelegateHandler)
        explodedList = CType(System.Delegate.Combine(explodedList, clientMethod), CarDelegateHandler)
    End Sub

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
            ' If the car is doomed, send out the "Exploded" notification.
            If explodedList IsNot Nothing Then
                explodedList("Sorry, this car is dead...")
            End If
        Else
            currSpeed += delta
            ' Are we almost doomed? If so, send out "AboutToBlow" notification.
            If 10 = maxSpeed - currSpeed AndAlso almostDeadList IsNot Nothing Then
                almostDeadList("Careful budy! Gonna blow!")
            End If
            If currSpeed >= maxSpeed Then
                carIsDead = True
            Else
                Console.WriteLine("=> CurrSpeed = {0} ", currSpeed)
            End If
        End If
    End Sub

End Class
