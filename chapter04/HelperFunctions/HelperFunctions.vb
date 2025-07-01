Module HelperFunctions
    ' In VB.NET, the default parameter passing mode is ByVal. 

    ' Subroutines have no return value
    Sub PrintMessage(ByRef msg As String)
        Console.WriteLine($"Your message is: {msg}")

        ' Caller will see this change, as "msg" is passed ByRef.
        msg = "Thank you for calling this method"
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

        ' x is still 10, and y is still 20
        Console.WriteLine($"After call x = {x} and y = {y}")

        Dim msg As String = "Hello from Main!"
        PrintMessage(msg)
        Console.WriteLine($"After call msg = {msg}")

    End Sub

End Module
