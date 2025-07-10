Module Program

    Sub Main()
        Console.WriteLine("***** Fun with System.GC *****")
        ' Print out estimated number of bytes on heap.
        Console.WriteLine("Estimated bytes on heap: {0}", GC.GetTotalMemory(False))

        ' MaxGeneration is zero based, so add 1 for display purposes.
        Console.WriteLine($"This OS has {GC.MaxGeneration + 1} generations.")

        Dim refToMyCar As New Car("Zippy", 100)
        Console.WriteLine(refToMyCar.ToString())
        ' Print out generation of refToMyCar object.
        Console.WriteLine($"Generation of refToMyCar is {GC.GetGeneration(refToMyCar)}")

        ' Make a ton of objects for testing purposes.
        Dim tonsOfObjects(5000) As Object
        For i As Integer = 0 To UBound(tonsOfObjects)
            tonsOfObjects(i) = New Object()
        Next

        ' Only collect generation 0 objects
        GC.Collect(0)
        GC.WaitForPendingFinalizers()

        ' Print out generation of refToMyCar object.
        Console.WriteLine($"Generation of refToMyCar is {GC.GetGeneration(refToMyCar)}")

        ' See if tonsOfObjects(4000) is still alive.
        If (tonsOfObjects(4000) IsNot Nothing) Then
            Console.WriteLine("Generation of tonsOfObjects(4000) is: {0}", GC.GetGeneration(tonsOfObjects(4000)))
        Else
            Console.WriteLine("tonsOfObjects(4000) is no longer alive.")
        End If

        ' Print out how may times a generation has been swept
        Console.WriteLine("Gen 0 has been swept {0} times", GC.CollectionCount(0))
        Console.WriteLine("Gen 1 has been swept {0} times", GC.CollectionCount(1))
        Console.WriteLine("Gen 2 has been swept {0} times", GC.CollectionCount(2))

    End Sub

End Module
