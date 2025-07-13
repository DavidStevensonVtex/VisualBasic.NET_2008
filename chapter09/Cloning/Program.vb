Module Program

    Sub Main()
        Console.WriteLine("***** Fun with ICloneable *****")
        Dim p1 As New Point(50, 50)

        ' If Option Strict is enabled, you must perform an explicit cast, as Clone()
        ' returns a System.Object.
        Dim p2 As Point = CType(p1.Clone(), Point)
        p2.X = 0

        ' Prints X = 50; Y = 50
        Console.WriteLine(p1)

        ' Prints X = 0 ; Y = 50
        Console.WriteLine(p2)
    End Sub

End Module
