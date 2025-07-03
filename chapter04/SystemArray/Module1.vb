Module Module1

    Sub Main()
        SystemArrayFunctionality()
    End Sub

    Sub SystemArrayFunctionality()
        Console.WriteLine("=> Working with System.Array")
        ' Initialize items at startup
        Dim gothicBands() As String = {"Tones on Tail", "Bauhaus", "Sisters of Mercy"}
        ' Print out names in declared order.
        Console.WriteLine(" -> Here is the array: ")
        For i As Integer = 0 To gothicBands.GetUpperBound(0)
            ' Print a name
            Console.Write(gothicBands(i) & " ")
        Next
        Console.WriteLine()
        Console.WriteLine()

        ' Reverse them...
        Array.Reverse(gothicBands)
        Console.WriteLine(" -> The reversed array")
        ' ... and print them.
        For i As Integer = 0 To gothicBands.GetUpperBound(0)
            ' Print a name
            Console.Write(gothicBands(i) & " ")
        Next
        Console.WriteLine()
        Console.WriteLine()
    End Sub

End Module
