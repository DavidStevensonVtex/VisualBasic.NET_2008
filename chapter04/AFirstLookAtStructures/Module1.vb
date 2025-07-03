Module Module1

    Sub Main()
        Console.WriteLine("***** A First Look at Structures *****")
        ' Create an initial Point.
        Dim myPoint As New Point()
        myPoint.X = 349
        myPoint.Y = 76
        myPoint.Display()

        ' Adjust the X and Y values
        myPoint.Increment()
        myPoint.Display()
        Console.WriteLine($"Point in hex: {myPoint.PointAsHexString()}")
    End Sub

End Module
