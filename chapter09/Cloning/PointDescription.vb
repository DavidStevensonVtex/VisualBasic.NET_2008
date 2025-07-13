Public Class PointDescription
    Public Property PetName As String
    Public PointID As Guid

    Public Sub New()
        Me.PetName = "No-name"
        Me.PointID = Guid.NewGuid()
    End Sub

End Class
