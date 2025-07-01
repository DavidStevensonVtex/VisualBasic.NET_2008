Module Module1

    Sub Main()
        Dim myStuff As New ArrayList()
        myStuff.Add(100)
        myStuff.Add("Hello")
        Console.WriteLine($"Size is: {myStuff.Count}")

        myStuff = New ArrayList()
        With myStuff
            .Add(100)
            .Add("Hello")
            Console.WriteLine($"Size is: { .Count}")
        End With

    End Sub

End Module
