Public Class SalesPerson
	Inherits Employee

	Private numberOfSales As Integer
	Public Property SalesNumber As Integer
		Get
			Return numberOfSales
		End Get
		Set(value As Integer)
			numberOfSales = value
		End Set
	End Property

	Public Sub New()
	End Sub
	Public Sub New(ByVal fullName As String,
				   ByVal empAge As Integer,
				   ByVal empID As Integer,
				   ByVal currPay As Single,
				   ByVal ssn As String,
				   ByVal numberOfSales As Integer)
		MyBase.New(fullName, empAge, empID, currPay, ssn)
		Me.SalesNumber = numberOfSales
	End Sub

End Class
