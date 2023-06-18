Imports System

Module Program
	Sub Main(args As String())
		Console.WriteLine("***** Fun with Class Types *****")
		' Allocate and configure a Car object.
		'Dim myCar As New Car()
		' An alternative manner to allocate an object.
		Dim myCar As Car = New Car()
		myCar.petName = "Sven"
		myCar.currSpeed = 10

		'' Speed up the car a few times and print out the new state.
		For i As Integer = 0 To 10
			myCar.SpeedUp(5)
			myCar.PrintState()
		Next

		' Invoking the default constructor
		' The compiler allows you to omit the empty parentheses when invoking the default constructor.
		Dim chuck As New Car
		' Prints "Chuck is going 10 MPH.
		chuck.PrintState()

		Dim mary As New Car("Mary")
		mary.PrintState()

		Dim daisy As New Car("Daisy", 75)
		daisy.PrintState()

		Dim mc As New Motorcycle
		mc.PopAWheely()

		' Make a Motorcycle named Tiny?
		Dim c As New Motorcycle(5, "Tiny")
		c.PopAWheely()
		Console.WriteLine("Rider name is {0}", c.driverName)

	End Sub
End Module
