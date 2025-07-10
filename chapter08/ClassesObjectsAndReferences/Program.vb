Module Program

    Sub Main()
        ' Createa new Car object on the managed heap. 
        ' We are returned a reference to this object that
        ' we store in the 'refToMyCar" local variable.
        Dim refToMyCar As New Car("Zippy", 50)

        ' The VB 2008 dot operator (.) is used to invoke 
        ' members on the object using our reference variable.
        Console.WriteLine(refToMyCar.ToString())

    End Sub

End Module
