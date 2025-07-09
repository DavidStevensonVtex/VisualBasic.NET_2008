Public Class CarIsDeadException
    Inherits ApplicationException

    ' Default error message
    Private messageDetails As String = "Car Error"

    ' Constructors.
    Public Sub New()
    End Sub
    Public Sub New(ByVal msg As String)
        messageDetails = msg
    End Sub

    ' Override the Exception.Message property.
    Public Overrides ReadOnly Property Message() As String
        Get
            Return $"Car Error Message: {messageDetails}"
        End Get
    End Property

End Class
