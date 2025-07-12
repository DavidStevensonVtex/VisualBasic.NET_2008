Module Program

    Sub Main()
        Console.WriteLine("***** Fun with Interfaces *****")
        Dim hex As New Hexagon()
        Console.WriteLine($"Number of Point: {hex.Points}")

        ' Recall, Circle does not support IPointy
        Dim c As New Circle()
        Dim itfPointy As IPointy
        Try
            itfPointy = CType(c, IPointy)
            Console.WriteLine($"Number of Points: {itfPointy.Points}")
        Catch ex As Exception
            Console.WriteLine($"{c} does not implement IPointy!")
        End Try

    End Sub

End Module
