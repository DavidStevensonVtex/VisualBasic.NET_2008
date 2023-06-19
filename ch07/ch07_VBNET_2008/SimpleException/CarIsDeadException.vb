' This custom exception describes the details of the car-is-dead condition.
Imports System.Runtime.Serialization

Public Class CarIsDeadException
	Inherits ApplicationException

	' Constructors
	Public Sub New()
		MyBase.New("Car Error")
	End Sub

	Public Sub New(ByVal msg As String)
		MyBase.New(msg)
	End Sub

	Public Sub New(ByVal message As String, ByVal inner As Exception)
		MyBase.New(message, inner)
	End Sub

	Protected Sub New(ByVal info As SerializationInfo, ByVal context As StreamingContext)
		MyBase.New(info, context)
	End Sub
End Class
