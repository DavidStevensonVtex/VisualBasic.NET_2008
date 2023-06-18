Public Class Motorcycle
	Public driverIntensity As Integer
	Public driverName As String
	Public Sub PopAWheely()
		Console.WriteLine("Yeeeeeee Haaaaaaeewww!")
	End Sub

	' Put back the default constructor.
	' Remember, fields of a class automatically 
	' are set to zero on our behalf
	Public Sub New()
		Console.WriteLine("In default constructor")
	End Sub

	' Our custom constructor
	Public Sub New(ByVal intensity As Integer)
		Me.New(intensity, "")
		Console.WriteLine("In constructor taking an integer")
	End Sub

	Public Sub New(ByVal name As String)
		Me.New(5, name)
		Console.WriteLine("In constructor taking an String")
	End Sub

	Public Sub New(ByVal intensity As Integer, ByVal name As String)
		Console.WriteLine("In master constructor")
		If intensity > 10 Then
			intensity = 10
		End If
		driverIntensity = intensity
		driverName = name
	End Sub
End Class
