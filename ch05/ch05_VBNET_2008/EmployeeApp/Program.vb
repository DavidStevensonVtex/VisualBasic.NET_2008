Imports System

Module Program
	Sub Main(args As String())
		Employee.Company = "Intertech Training"
		Dim emp As New Employee("Marvin", 456, 30000)
		emp.GiveBonus(1000)
		emp.DisplayStats()

		' Use the get / set methods to interact with the object's name.
		emp.Name = "Marv"
		Console.WriteLine("Employee is named: {0}", emp.Name)
		Console.WriteLine()

		Dim joe As New Employee()
		joe.Age = joe.Age + 1

		Console.WriteLine("These folks work at {0}", Employee.Company)
	End Sub
End Module
