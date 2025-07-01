Module HelperFunctions
    ' In VB.NET, the default parameter passing mode is ByVal. 

    ' Subroutines have no return value
    Sub PrintMessage(ByRef msg As String)
        Console.WriteLine($"Your message is: {msg}")

        ' Caller will see this change, as "msg" is passed ByRef.
        msg = "Thank you for calling this method"
    End Sub

    Sub PrintFormattedMessage(ByVal msg As String,
                              Optional ByVal upperCase As Boolean = False,
                              Optional ByVal timesToRepeat As Integer = 0,
                              Optional ByVal textColor As ConsoleColor = ConsoleColor.Green)
        ' Store current console foreground color.
        Dim fGroundColor As ConsoleColor = Console.ForegroundColor
        ' Set console foreground color.
        Console.ForegroundColor = textColor
        ' Print message in correct case x number of times.
        For i As Integer = 0 To timesToRepeat
            Console.WriteLine(msg)
        Next
        ' Reset current console foreground color
        Console.ForegroundColor = fGroundColor
    End Sub

    ' Functions have a return value
    Function Add(ByVal x As Integer, ByVal y As Integer) As Integer
        Dim answer As Integer = x + y
        ' Try to set the params to a new value for the caller.
        x = 22 : y = 30
        Return answer
    End Function

    Sub Main()
        Console.WriteLine("***** Fun with Methods *****")
        ' Pass two Integers by value.
        Dim x, y As Integer
        x = 10 : y = 20
        Console.WriteLine($"{x} + {y} = {Add(x, y)}")
        Dim a, b As Integer
        a = 123 : b = 345
        Console.WriteLine($"{a} + {b} = {Add(y:=b, x:=a)}")

        ' x is still 10, and y is still 20
        Console.WriteLine($"After call x = {x} and y = {y}")

        Dim msg As String = "Hello from Main!"
        ' This string is now passed by value, even though the parameter is marked ByRef.
        PrintMessage((msg))
        Console.WriteLine($"After call msg = {msg}")

        ' Accept all defaults for the optional args.
        PrintFormattedMessage("Call One")

        ' Provide each optinal argument.
        PrintFormattedMessage("Call Two", True, 5, ConsoleColor.Yellow)

        ' Print this message in current case, one time, in gray.
        PrintFormattedMessage("Call Three", , , ConsoleColor.Gray)

        ' Same as previously shown, but cleaner!
        PrintFormattedMessage("Call Four", textColor:=ConsoleColor.Gray)

    End Sub

End Module
