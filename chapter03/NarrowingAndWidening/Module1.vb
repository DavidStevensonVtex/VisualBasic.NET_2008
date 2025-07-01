Module Module1

    Sub Main()
        Console.WriteLine("***** The Amazing Addition Program *****")
        Dim a As Short = 30000
        Dim b As Short = 30000
        Dim answer As Short = Add(a, b)
        ' Implicit conversion from 'Integer' to 'Short'.
        ' Option Strict On disallows implicit conversions from 'Integer' to 'Short'.
        Console.WriteLine("a + b = {0}", answer)

    End Sub

    Function Add(ByVal x As Integer, ByVal y As Integer) As Integer
        Return x + y
    End Function

End Module
