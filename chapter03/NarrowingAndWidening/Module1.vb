Module Module1

    Sub Main()
        Console.WriteLine("***** The Amazing Addition Program *****")
        Dim a As Short = 9
        Dim b As Short = 10
        Console.WriteLine("a + b = {0}", Add(a, b))

    End Sub

    Function Add(ByVal x As Integer, ByVal y As Integer) As Integer
        Return x + y
    End Function

End Module
