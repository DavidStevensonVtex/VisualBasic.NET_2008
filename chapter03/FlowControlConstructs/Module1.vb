Module Module1

    Sub Main()
        Dim userOption As String
        Dim userAge As Integer

        ' Read user option from command line.
        Console.Write("User Option: ")
        userOption = Console.ReadLine()
        Console.Write("User Age: ")
        userAge = Integer.Parse(Console.ReadLine())

        If userOption = "AdultMode" And userAge >= 21 Then
            Console.WriteLine("We call this Hot Coffee Mode...")
        ElseIf userOption = "AllAmmo" Then
            Console.WriteLine("Now we can rock and roll!")
        Else
            Console.WriteLine("Unknown option...")
        End If

    End Sub

End Module
