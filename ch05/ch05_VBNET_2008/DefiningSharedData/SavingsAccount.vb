' This class has a single piece of non-Shared data.
Public Class SavingsAccount

	Public currBalance As Double

	' A Shared point of data.
	Public Shared currInterestRate As Double = 0.04

	Public Sub New(ByVal balance As Double)
		currBalance = balance
	End Sub

	' Shared members to get/set interest rate.
	Public Shared Sub SetInterestRate(ByVal newRate As Double)
		currInterestRate = newRate
	End Sub
	Public Shared Function GetInterestRate() As Double
		Return currInterestRate
	End Function

	' Instance members to get/set interest rate
	Public Sub SetInterestRateObj(ByVal newRate As Double)
		currInterestRate = newRate
	End Sub
	Public Function GetInterestRateObj() As Double
		Return currInterestRate
	End Function

End Class
