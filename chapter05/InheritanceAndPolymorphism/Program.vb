Module Program

    Sub Main()
        Dim myShapes(2) As Shape
        myShapes(0) = New Hexagon()
        myShapes(1) = New Circle()
        myShapes(2) = New Hexagon()

        For Each s As Shape In myShapes
            s.Draw()
        Next

    End Sub

End Module
