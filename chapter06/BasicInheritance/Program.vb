Module Program

    Sub Main()
        Console.WriteLine("***** Basic Inheritance *****")
        ' Make a Car object.
        Dim myCar As New Car(80)
        myCar.Speed = 50
        Console.WriteLine("My car is going {0} MPH", myCar.Speed)

        ' Now createa  MiniVan object
        Dim myVan As New MiniVan()
        myVan.Speed = 10
        Console.WriteLine("MyVan is going {0} MPH", myVan.Speed)
    End Sub

End Module
