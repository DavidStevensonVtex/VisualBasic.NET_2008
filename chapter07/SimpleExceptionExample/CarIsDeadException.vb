Imports System.Runtime.Serialization

<Serializable()>
Public Class CarIsDeadException
    Inherits ApplicationException

    Public Sub New()
    End Sub
    Public Sub New(ByVal msg As String)
        MyBase.New(msg)
    End Sub
    Public Sub New(ByVal message As String, ByVal inner As System.Exception)
        MyBase.New(message, inner)
    End Sub
    Protected Sub New(ByVal info As SerializationInfo, ByVal context As StreamingContext)
        MyBase.New(info, context)
    End Sub
End Class
