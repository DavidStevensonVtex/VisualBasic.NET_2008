Module Module1

    Sub Main()
        Console.WriteLine("***** The Amazing Addition Program *****")
        Dim a As Short = 30000
        Dim b As Short = 30000
        Dim answer As Integer = Add(a, b)
        Console.WriteLine("a + b = {0}", answer)

        Dim myByte As Byte
        Dim myInt As Integer = 200
        ' This will no longer work:
        'myByte = myInt

        myByte = CByte(myInt)
        Console.WriteLine("Value of myByte: {0}", myByte)

    End Sub

    Function Add(ByVal x As Integer, ByVal y As Integer) As Integer
        Return x + y
    End Function

End Module
