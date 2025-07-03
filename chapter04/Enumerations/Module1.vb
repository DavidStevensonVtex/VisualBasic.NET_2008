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

    ' This method will pritn out the details of any enum.
    Sub EvaluateEnum(ByVal e As [Enum])
        Console.WriteLine("=> Information about {0}", e.GetType().Name)

        Console.WriteLine("Underlying storage type: {0}", [Enum].GetUnderlyingType(e.GetType()))

        ' Get all name/value pairs for incoming parameter
        Dim enumData As Array = [Enum].GetValues(e.GetType())
        Console.WriteLine("This enum has {0} members.", enumData.Length)

        ' Now show the string name and associated value
        For i As Integer = 0 To enumData.Length - 1
            Console.WriteLine($"{enumData.GetValue(i)}, Value: {CInt(enumData.GetValue(i))}")
        Next
        Console.WriteLine()


    End Sub

    Sub Main()
        Console.WriteLine("***** Fun with Enums *****")
        ' Make a contractor type
        Dim emp As EmpType = EmpType.Contractor
        AskForBonus(emp)

        ' Compiler error!
        Console.WriteLine("EmpType uses a {0} for storage",
            [Enum].GetUnderlyingType(emp.GetType()))

        ' Prints out "emp is a Contractor"
        Console.WriteLine("emp is a {0}.", emp.ToString())

        ' Prints out "Contractor = 2"
        Console.WriteLine($"{emp} = {CInt(emp)}")

        EvaluateEnum(emp)

        ' These two enumerations are defined in the System namespace.
        Dim day As DayOfWeek
        Dim cc As ConsoleColor

        EvaluateEnum(day)
        EvaluateEnum(cc)
    End Sub

End Module
