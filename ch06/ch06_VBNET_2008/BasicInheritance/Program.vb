Imports System

Module Program
	Sub Main(args As String())
		Console.WriteLine("***** Basic Inheritance ******")
		' Make a Car object
		Dim myCar As New Car(80)
		myCar.Speed = 50
		Console.WriteLine("My car is going {0} MPH", myCar.Speed)
		Console.WriteLine()

		Dim myVan As New MiniVan()
		myVan.Speed = 10
		Console.WriteLine("My van is going {0} MPH", myVan.Speed)
		Console.WriteLine()

		' Error! Cannot access private data of the parent from an object.
		'myVan.currSpeed = 10
		' Error BC30389   'BasicInheritance.Car.currSpeed' is not accessible in this context because it is 'Private'.

	End Sub
End Module
