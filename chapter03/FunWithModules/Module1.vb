Module Module1

    Sub Main()
        ' Show banner.
        DisplayBanner()
        ' Get User's name and say howday.
        MyModule.GreetUser()

        ' Add some numbers
        Console.WriteLine("10 + 10 is {0}.", Add(10, 10))

        ' Subtract some numbers
        ' (module prefix optional).
        Console.WriteLine("10 - 10 is {0}.", MyMathModule.Subtract(10, 10))
    End Sub

    Sub DisplayBanner()
        ' Get the current color of the console text.
        Dim currColor As ConsoleColor = Console.ForegroundColor

        ' Set text color to yellow.
        Console.ForegroundColor = ConsoleColor.Yellow
        Console.WriteLine("******* Welcome to FunWithModules")
        Console.WriteLine("This simple program illustrates the role")
        Console.WriteLine("of the Module type.")

        ' Rest to previous color of your console text.
        Console.ForegroundColor = currColor
        Console.WriteLine()
    End Sub

    Sub GreetUser()
        Dim userName As String
        Console.WriteLine("Please enter your name: ")
        userName = Console.ReadLine()
        Console.WriteLine("Hello there {0}. Nice to meet you.", userName)
    End Sub

End Module
