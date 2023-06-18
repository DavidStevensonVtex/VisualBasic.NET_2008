Public NotInheritable Class PTSalesPerson
	Inherits SalesPerson
	Public Sub New()
	End Sub
	Public Sub New(ByVal fullName As String,
				   ByVal empAge As Integer,
				   ByVal empID As Integer,
				   ByVal currPay As Single,
				   ByVal ssn As String,
				   ByVal numberOfSales As Integer)
		MyBase.New(fullName, empAge, empID, currPay, ssn, numberOfSales)
	End Sub

End Class
