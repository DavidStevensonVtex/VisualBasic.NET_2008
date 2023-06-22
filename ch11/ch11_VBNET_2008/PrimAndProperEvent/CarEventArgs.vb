Public Class CarEventArgs
	Inherits EventArgs

	Public ReadOnly Property Message As String

	Public Sub New(ByVal msg As String)
		Message = msg
	End Sub
End Class
