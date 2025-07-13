Module Program

    Sub Main()
        Console.WriteLine("***** Fun with ICloneable *****")
        Dim p1 As New Point(50, 50, "Brad")

        ' If Option Strict is enabled, you must perform an explicit cast, as Clone()
        ' returns a System.Object.
        Dim p2 As Point = CType(p1.Clone(), Point)

        Console.WriteLine("Before modification:")
        Console.WriteLine(p1)
        Console.WriteLine(p2)

        p2.Desc.PetName = "This is my second point"
        p2.X = 9
        Console.WriteLine("Changed p2.Desc.PetName and p2.X")

        Console.WriteLine("After modification:")
        Console.WriteLine(p1)
        Console.WriteLine(p2)
    End Sub

End Module
