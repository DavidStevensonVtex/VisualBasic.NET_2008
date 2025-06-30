Module Module1

    Sub Main()
        Console.WriteLine("**** Fun with Console IO")
        ' Echo some information to the console.
        Console.Write("Enter your name: ")
        Dim s As String = Console.ReadLine()
        Console.WriteLine("Hello, {0}", s)

        Console.WriteLine("Enter your age: ")
        s = Console.ReadLine()
        Console.WriteLine("You are {0} years old", s)

        ' Specify string placeholders and values to use at runtime.
        Dim theInt As Integer = 90
        Dim theDouble As Double = 9.99
        Dim theBool As Boolean = True
        Console.WriteLine("Value of theInt: {0}", theInt)
        Console.WriteLine("theDouble is {0} and theBool is {1}.", theDouble, theBool)

    End Sub

End Module
