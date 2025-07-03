Module Module1
    ' A custom enumeration.
    Enum EmpType
        Manager         ' = 0
        Grunt           ' = 1
        Contractor      ' = 2
        VicePresident   ' = 3
    End Enum

    ' Begin with 102
    Enum EmpType2
        Manager = 102
        Grunt               ' = 103
        Contractor          ' = 104
        VicePresident       ' = 105
    End Enum

    ' Elements of an enumeration need not be sequential
    Enum EmpType3
        Manager = 10
        Grunt = 1
        Contractor = 100
        VicePresident = 9
    End Enum

    ' Controlling the Underlying Storage for an Enum
    Enum EmpType4 As Byte
        Manager = 10
        Grunt = 1
        Contractor = 100
        VicePresident = 9
    End Enum

    ' Enums as parameters
    Sub AskForBonus(ByVal e As EmpType)
        Select Case (e)
            Case EmpType.Contractor
                Console.WriteLine("You already get enough cash...")
            Case EmpType.Grunt
                Console.WriteLine("You have got to be kidding...")
            Case EmpType.Manager
                Console.WriteLine("How about stock options instead?")
            Case EmpType.VicePresident
                Console.WriteLine("VERY GOOD, Sir!")
        End Select
    End Sub

    Sub Main()
        Console.WriteLine("***** Fun with Enums *****")
        ' Make a contractor type
        Dim emp As EmpType = EmpType.Contractor
        AskForBonus(emp)
    End Sub

End Module
