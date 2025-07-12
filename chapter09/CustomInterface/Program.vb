Module Program
    Sub Main()
        Console.WriteLine("***** Fun with Interface Name Clashes *****")
        Dim o As New Octagon()
        ' Call IDrawToMemory.Draw()
        Dim iMem As IDrawToMemory
        iMem = CType(o, IDrawToMemory)
        iMem.Draw()

        ' Call IDrawToPrinter.Draw
        Dim iPrint As IDrawToPrinter
        iPrint = CType(o, IDrawToPrinter)
        iPrint.Draw()

        ' Call IDrawToForm.Draw
        Dim iForm As IDrawToForm
        iForm = CType(o, IDrawToForm)
        iForm.Draw()

    End Sub
    Sub DrawIn3D(ByVal itf3d As IDraw3D)
        Console.WriteLine("-> Drawing IDraw3D compatible type")
        itf3d.Draw3D()
    End Sub

    Sub OldMain()
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

        ' See which objects support IPointy.
        Console.WriteLine($"Circle implements IPointy? {TypeOf c Is IPointy}")
        Console.WriteLine($"Hexagon implements IPointy?: {TypeOf hex Is IPointy}")

        ' Make an array of Shape-compatible types.
        Dim myShapes() As Shape = {New Hexagon("Fred"), New Circle("Angie"),
            New ThreeDCircle(), New Triangle("Adam")}
        ' Now figure out which ones support IPointy
        'Dim itfPointy As IPointy
        For Each s As Shape In myShapes
            If TypeOf s Is IPointy Then
                itfPointy = CType(s, IPointy)
                Console.WriteLine($"{s.PetName} has {itfPointy.Points} points.")
            Else
                Console.WriteLine($"{s} does not implement IPointy !")
            End If

            ' Is this item IDraw3D aware?
            If TypeOf s Is IDraw3D Then
                DrawIn3D(CType(s, IDraw3D))
            End If
        Next

        ' This array can only contain objects that implement the IPointy interface.
        Dim pointyThings() As IPointy = {New Hexagon(), New Knife(), New Triangle(), New Fork(), New PitchFork()}
        For Each p As IPointy In pointyThings
            Console.WriteLine($"Object has {p.Points} points.")
        Next
    End Sub

End Module
