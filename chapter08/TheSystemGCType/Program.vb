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

    End Sub

End Module
