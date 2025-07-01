Module Module1
    Function Add(ByVal x As Integer, ByVal y As Integer) As Integer
        Return x + y
    End Function

    Function Add(ByVal x As Double, ByVal y As Double) As Double
        Return x + y
    End Function
    Function Add(ByVal x As Long, ByVal y As Long) As Long
        Return x + y
    End Function

    Sub Main()
        Console.WriteLine("***** Fun with Method Overloading *****")
        ' Calls Integer version of Add
        Console.WriteLine(Add(10, 10))

        ' Calls Long Version of Add()
        Console.WriteLine(Add(900000000000000000, 900000000000000000))

        ' Calls Double version of Add()
        Console.WriteLine(Add(4.3, 4.4))
    End Sub

End Module
