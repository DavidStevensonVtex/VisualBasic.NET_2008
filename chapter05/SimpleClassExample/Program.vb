Module Program

    Sub Main()
        Console.WriteLine("***** Fun with Class Types *****")
        ' Allocate and configure a Car object
        Dim myCar As New Car()
        myCar.petName = "Sven"
        myCar.currSpeed = 10

        ' Speed up the car a few times and print out the new state
        For i As Integer = 0 To 10
            myCar.SpeedUp(5)
            myCar.PrintState()
        Next

    End Sub

End Module
