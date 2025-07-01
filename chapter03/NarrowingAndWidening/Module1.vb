' OPtion directives  must be the very first code statements in a .vb file!
Option Strict On

Module Module1

    Sub Main()
        Console.WriteLine("***** The Amazing Addition Program *****")
        Dim a As Short = 30000
        Dim b As Short = 30000
        Dim answer As Short = Add(a, b)     ' error BC30512: Option Strict On disallows implicit conversions from 'Integer' to 'Short'.
        Console.WriteLine("a + b = {0}", answer)

    End Sub

    Function Add(ByVal x As Integer, ByVal y As Integer) As Integer
        Return x + y
    End Function

End Module
