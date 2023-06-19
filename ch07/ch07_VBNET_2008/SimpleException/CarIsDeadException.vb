' This custom exception describes the details of the car-is-dead condition.
Public Class CarIsDeadException
	Inherits ApplicationException

	' Constructors
	Public Sub New()
		MyBase.New("Car Error")
	End Sub

	Public Sub New(ByVal msg As String)
		MyBase.New(msg)
	End Sub
End Class
