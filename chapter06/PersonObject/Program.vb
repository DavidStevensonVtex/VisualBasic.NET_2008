
Module Program

    Sub Main()
        Console.WriteLine("***** Fun with System.Object *****")
        Dim p1 As New Person("David", "Stevenson", 67)

        ' Use inherited members of System.Object
        Console.WriteLine($"ToString: {p1.ToString()}")
        Console.WriteLine($"Hash code: {p1.GetHashCode()}")
        Console.WriteLine($"Type: {p1.GetType()}")

        ' Make some other references to hc.
        Dim p2 As Person = p1
        Dim o As Object = p2

        ' Are the references pointing to the same object in memory?
        If o.Equals(p1) AndAlso p2.Equals(o) Then
            Console.WriteLine("Same instance!")
        End If

    End Sub

End Module
