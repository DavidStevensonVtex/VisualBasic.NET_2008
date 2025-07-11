﻿Public Structure Point
    Public X, Y As Integer

    Sub Display()
        Console.WriteLine($"X = {X}, Y = {Y}")
    End Sub

    Sub Increment()
        X += 1 : Y += 1
    End Sub

    Sub Decrement()
        X -= 1 : Y -= 1
    End Sub

    ' Recall that the "x" format flag displays data in hex format
    Function PointAsHexString() As String
        Return String.Format("X = {0:x}, Y = {1:x}", X, Y)
    End Function

End Structure
