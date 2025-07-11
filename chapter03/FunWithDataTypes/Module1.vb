﻿Module Module1

    Sub Main()
        Console.WriteLine("***** Fund with Data Types *****")
        Console.WriteLine("Max of Integer: {0}", Integer.MaxValue)
        Console.WriteLine("Min of Integer: {0}", Integer.MinValue)
        Console.WriteLine("Max of Double: {0}", Double.MaxValue)
        Console.WriteLine("Min of Double: {0}", Double.MinValue)

        Console.WriteLine("Double.Epsilon: {0}", Double.Epsilon)
        Console.WriteLine("Double.PositiveInfinity: {0}", Double.PositiveInfinity)
        Console.WriteLine("Double.NegativeInfinity: {0}", Double.NegativeInfinity)

        Console.WriteLine("Boolean.FalseString: {0}", Boolean.FalseString)
        Console.WriteLine("Boolean.TrueString: {0}", Boolean.TrueString)

        ' Fun with System.Char
        Dim myChar As Char = "a"c
        Console.WriteLine("Char.IsDigit('a'): {0}", Char.IsDigit(myChar))
        Console.WriteLine("Char.IsLetter('a'): {0}", Char.IsLetter(myChar))
        Console.WriteLine("Char.IsWhiteSpace('Hello There', 5): {0}", Char.IsWhiteSpace("Hello There", 5))
        Console.WriteLine("Char.IsWhiteSpace('Hello There', 6): {0}", Char.IsWhiteSpace("Hello There", 6))
        Console.WriteLine("Char.IsPunctuation('?'): {0}", Char.IsPunctuation("?"c))

        ' Fun with parsing.
        Dim b As Boolean = Boolean.Parse("True")
        Console.WriteLine("Value of b: {0}", b)

        Dim d As Double = Double.Parse("99.884")
        Console.WriteLine("Value of d: {0}", d)

        Dim i As Integer = Integer.Parse("8")
        Console.WriteLine("Value of myInt: {0}", i)

        Dim c As Char = Char.Parse("W")
        Console.WriteLine("Value of c: {0}", c)
    End Sub

End Module
