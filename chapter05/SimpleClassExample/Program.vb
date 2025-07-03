Module Program

    Sub Main()
        ' Make a Car called Chuck going 10 MPH.
        Dim chuck As New Car()
        chuck.PrintState()

        ' Make a Car called Mary going 0 MPH.
        Dim mary As New Car("Mary")
        mary.PrintState()

        ' Make a Car called DAisy going 75 MPH.
        Dim daisy As New Car("Daisy", 75)
        daisy.PrintState()
    End Sub

    Sub MainOld()
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
