Public Class Car
    Private currSpeed As Integer
    Private petName As String

    Public Sub New()
    End Sub
    Public Sub New(ByVal name As String, ByVal speed As Integer)
        petName = name
        currSpeed = speed
    End Sub

    Public Overrides Function ToString() As String
        Return $"{petName} is going {currSpeed} MPH"
    End Function

    Public ReadOnly Property Name As String
        Get
            Return petName
        End Get
    End Property

    Public ReadOnly Property Speed As Integer
        Get
            Return currSpeed
        End Get
    End Property

End Class
