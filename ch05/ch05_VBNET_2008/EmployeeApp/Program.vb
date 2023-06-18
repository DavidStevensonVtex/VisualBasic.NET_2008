Imports System

Module Program
	Sub Main(args As String())
		Dim emp As New Employee("Marvin", 456, 30000)
		emp.GiveBonus(1000)
		emp.DisplayStats()

		' Use the get / set methods to interact with the object's name.
		emp.SetName("Marv")
		Console.WriteLine("Employee is named: {0}", emp.GetName())
		Console.WriteLine()
	End Sub
End Module
