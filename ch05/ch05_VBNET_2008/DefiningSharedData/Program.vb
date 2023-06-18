Imports System

Module Program
	Sub Main(args As String())
		Console.WriteLine("**** Fund with Shared Data *****")
		Dim s1 As New SavingsAccount(50)
		Dim s2 As New SavingsAccount(100)

		' Get and Set interest rate at objet level.
		Console.WriteLine("Interest Rate is: {0}", s1.GetInterestRateObj())
		's2.SetInterestRateObj(0.08)

		' Make new object; this does NOT "reste" the interest rate for this object.
		Dim s3 As New SavingsAccount(10000.75)
		Console.WriteLine("Interest Rate is: {0}", SavingsAccount.GetInterestRate())
		Console.WriteLine()

		'SavingsAccount.SetInterestRate(0.09)
		Console.WriteLine("Interest Rate is: {0}", s1.GetInterestRateObj())
		Console.WriteLine("Interest Rate is: {0}", s2.GetInterestRateObj())
		Console.WriteLine("Interest Rate is: {0}", s3.GetInterestRateObj())

	End Sub
End Module
