Public Class Motorcycle
    Public driverIntensity As Integer
    Public driverName As String

    Public Sub SetDriverName(ByVal name As String)
        Me.driverName = name
    End Sub

    Public Sub PopAWheely()
        For i As Integer = 0 To driverIntensity
            Console.WriteLine("Yeeeeee Haaaaaeewww!")
        Next
    End Sub

    ' Put back the default constructor.
    ' Remember, fields of a class automatically are set to a default value, 
    ' so driverIntensity is set to zero on our behalf.

    Public Sub New()
    End Sub

    ' Out custom constructor.
    Public Sub New(ByVal intensity As Integer)
        driverIntensity = intensity
    End Sub

End Class
