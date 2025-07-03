Module Module1

    Sub Main()
        MultiDimArray()
    End Sub

    Sub MultiDimArray()
        Console.WriteLine("=> Multidimensional arrays.")
        Dim myMatrix(6, 6) As Integer ' Makes a 7x7 array
        ' Populate array.
        Dim k As Integer, j As Integer
        For k = 0 To 6
            For j = 0 To 6
                myMatrix(k, j) = k * j
            Next
        Next

        ' Show array
        For k = 0 To 6
            For j = 0 To 6
                Console.Write($"{myMatrix(k, j),3}")
            Next
            Console.WriteLine()
        Next
        Console.WriteLine()
    End Sub

End Module
