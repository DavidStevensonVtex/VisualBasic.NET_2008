Public Class Manager
	Inherits Employee

	Private numberOfOptions As Integer
	Public Property StockOptions As Integer
		Get
			Return numberOfOptions
		End Get
		Set(value As Integer)
			numberOfOptions = value
		End Set
	End Property

	Public Sub New(ByVal fullName As String,
				   ByVal empAge As Integer,
				   ByVal empID As Integer,
				   ByVal currPay As Single,
				   ByVal ssn As String,
				   ByVal numOfOpts As Integer)
		MyBase.New(fullName, empAge, empID, currPay, ssn)
		Me.StockOptions = numOfOpts
	End Sub

End Class
