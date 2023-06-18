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

	' NotOverridable seals the method, so it can't be overriden.
	Public NotOverridable Overrides Sub GiveBonus(ByVal amount As Single)
		Dim salesBonus As Integer = 0
		If numberOfSales >= 0 AndAlso numberOfSales <= 100 Then
			salesBonus = 10
		Else
			If numberOfSales >= 101 AndAlso numberOfSales <= 200 Then
				salesBonus = 15
			Else
				salesBonus = 20
			End If
		End If

		MyBase.GiveBonus(amount * salesBonus)
	End Sub

	Public Overrides Sub DisplayStats()
		MyBase.DisplayStats()
		Console.WriteLine("Number of Sales: {0}", numberOfSales)
	End Sub
End Class
