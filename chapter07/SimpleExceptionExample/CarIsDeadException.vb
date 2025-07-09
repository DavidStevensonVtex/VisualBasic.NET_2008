Public Class CarIsDeadException
    Inherits ApplicationException

    Public Sub New()
    End Sub
    Public Sub New(ByVal msg As String)
        MyBase.New(msg)
    End Sub
End Class
