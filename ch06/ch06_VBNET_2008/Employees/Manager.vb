Public Class Manager
	Inherits Employee

	Private numberOfOptions As Integer
	Public Property StockOPtions As Integer
		Get
			Return numberOfOptions
		End Get
		Set(value As Integer)
			numberOfOptions = value
		End Set
	End Property

End Class
