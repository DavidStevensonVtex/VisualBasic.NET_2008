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

    End Sub

End Module
