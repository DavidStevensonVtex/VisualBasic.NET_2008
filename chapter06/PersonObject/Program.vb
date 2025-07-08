
Module Program

    Sub Main()
        ' Shared members of System.Object
        Dim p3 As New Person("Sally", "Jones", 4)
        Dim p4 As New Person("Sally", "Jones", 4)
        Console.WriteLine($"P3 and P4 hae the same state: {Object.Equals(p3, p4)}")
        Console.WriteLine($"P3 and P4 are pointing to the same object: {Object.ReferenceEquals(p3, p4)}")
    End Sub

    Sub Main2()
        Console.WriteLine("***** Fun with System.Object *****")
        Dim p1 As New Person("Homer", "Simpson", 50)
        Dim p2 As New Person("Homer", "Simpson", 50)

        ' Get stringified version of objects
        Console.WriteLine($"p1.ToString() = {p1.ToString()}")
        Console.WriteLine($"p2.ToString() = {p2.ToString()}")

        ' Test Overridden Equals
        Console.WriteLine($"p1 = p2?: {p1.Equals(p2)}")

        ' Test hash codes.
        Console.WriteLine($"Same hash codes?: {p1.GetHashCode} {p2.GetHashCode}")
        Console.WriteLine()

        ' Change age of p2 and test again.
        p2.personAge = 45
        Console.WriteLine($"p1.ToString() = {p1.ToString()}")
        Console.WriteLine($"p2.ToString() = {p2.ToString()}")
        Console.WriteLine($"p1 = p2?: {p1.Equals(p2)}")
        Console.WriteLine($"Same hash codes?: {p1.GetHashCode = p2.GetHashCode}")

    End Sub

    Sub OldMain()
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
