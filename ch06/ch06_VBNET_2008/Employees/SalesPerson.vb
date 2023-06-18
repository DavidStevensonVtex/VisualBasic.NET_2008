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

End Class
