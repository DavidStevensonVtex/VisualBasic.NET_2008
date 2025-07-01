Module HelperFunctions

    ' Subroutines have no return value
    Sub PrintMessage(ByVal msg As String)
        Console.WriteLine(msg)
    End Sub

    ' Functions have a return value
    Function Add(ByVal x As Integer, ByVal y As Integer) As Integer
        Return x + y
    End Function

    Sub Main()

    End Sub

End Module
