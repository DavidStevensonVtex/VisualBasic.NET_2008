Imports System

Module Program
	Sub Main(args As String())
		Console.WriteLine("***** Basic Inheritance ******")
		' Make a Car object
		Dim myCar As New Car(80)
		myCar.Speed = 50
		Console.WriteLine("My car is going {0} MPH", myCar.Speed)
		Console.WriteLine()
	End Sub
End Module
