' This class has a single piece of non-Shared (instance) data.

Public Class SavingsAccount
    Public currBalance As Double
    Public Shared currInterestRate As Double

    ' A shared constructor.
    Shared Sub New()
        Console.WriteLine("In Shared ctor!")
        currInterestRate = 0.04
    End Sub

    Public Sub New(ByVal balance As Double)
        currBalance = balance
        'currInterestRate = 0.04
    End Sub

    ' Shared members to get/set interest rate.
    Public Shared Sub SetInterestRate(ByVal newRate As Double)
        currInterestRate = newRate
    End Sub
    Public Shared Function GetInterestRate() As Double
        Return currInterestRate
    End Function

End Class
