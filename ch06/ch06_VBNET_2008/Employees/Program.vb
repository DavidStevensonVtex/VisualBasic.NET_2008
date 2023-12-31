Imports System

Module Program
	Sub Main(args As String())
		Console.WriteLine("***** The Employee Class Hierarchy ******")
		Console.WriteLine()

		' Make a salesperson
		Dim danny As New SalesPerson
		With danny
			.Age = 29
			.ID = 100
			.SalesNumber = 50
			.Name = "Dan McCabe"
		End With

		Dim chucky As New Manager("Chucky", 45, 101, 30000, "222-22-2222", 90)
		chucky.GiveBonus(300)
		chucky.DisplayStats()
		Console.WriteLine()

		Dim fran As New SalesPerson("Fran", 43, 93, 3000, "932-32-3232", 31)
		fran.GiveBonus(200)
		fran.DisplayStats()
		Console.WriteLine()

		' Create and use the public inner class. OK!
		Dim inner As New OuterClass.PublicInnerClass

		' Compiler error! CAnnot access the private class.
		'Dim inner2 As New OuterClass.PrivateInnerClass
		' Error BC30389   'Employees.OuterClass.PrivateInnerClass' is not accessible in this context because it is 'Private'.

	End Sub
End Module
