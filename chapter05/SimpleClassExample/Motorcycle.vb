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

    ' Constructors
    Public Sub New()
        Console.WriteLine("In default c-tor")
    End Sub

    ' Out custom constructor.
    Public Sub New(ByVal intensity As Integer)
        Me.New(intensity, "")
        Console.WriteLine("In c-tor taking an integer")
    End Sub

    Public Sub New(ByVal name As String)
        Me.New(5, name)
        Console.WriteLine("In c-tor taking a String")
    End Sub

    ' This is the "master" constructor that does all the real work.
    Public Sub New(ByVal intensity As Integer, ByVal name As String)
        Console.WriteLine("In master c-tor")
        If intensity > 10 Then
            intensity = 10
        End If
        driverIntensity = intensity
        driverName = name
    End Sub

End Class
