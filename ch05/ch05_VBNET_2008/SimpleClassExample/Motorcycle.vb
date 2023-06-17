Public Class Motorcycle
	Public driverIntensity As Integer
	Public Sub PopAWheely()
		Console.WriteLine("Yeeeeeee Haaaaaaeewww!")
	End Sub

	' Put back the default constructor.
	' Remember, fields of a class automatically 
	' are set to zero on our behalf
	Public Sub New()
	End Sub

	' Our custom constructor
	Public Sub New(ByVal intensity As Integer)
		driverIntensity = intensity
	End Sub

End Class
