Module Program

    Sub Main()

        Console.WriteLine("***** Fun with Polymorphism")
        Console.WriteLine()

        ' Make an array of Shape objects.
        Dim myShapes() As Shape = {New Hexagon(), New Circle(),
            New Hexagon("Mick"), New Circle("Beth"), New Hexagon("Linda")}

        ' Loop over each item and interactd with the polymorphic interface
        For Each s As Shape In myShapes
            s.Draw()
        Next
        Console.WriteLine()

        ' Fun with shadowing.
        Dim o As New ThreeDCircle()
        o.Draw()
        CType(o, Circle).Draw()

    End Sub

End Module
