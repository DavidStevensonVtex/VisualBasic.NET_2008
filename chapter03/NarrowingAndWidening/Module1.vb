Module Module1

    Sub Main()
        Console.WriteLine("***** The Amazing Addition Program *****")
        Dim a As Short = 30000
        Dim b As Short = 30000
        Dim answer As Integer = Add(a, b)
        Console.WriteLine("a + b = {0}", answer)

    End Sub

    Function Add(ByVal x As Integer, ByVal y As Integer) As Integer
        Return x + y
    End Function

End Module
