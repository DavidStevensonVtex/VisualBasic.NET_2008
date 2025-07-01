Module Module1

    Sub Main()
        Dim userOption As String

        ' Read user option from command line.
        userOption = Console.ReadLine()

        If userOption = "GodMode" Then
            Console.WriteLine("You will never die...cheater!")
        ElseIf userOption = "FullLife" Then
            Console.WriteLine("At the end, heh?")
        ElseIf userOption = "AllAmmo" Then
            Console.WriteLine("Now we can rock and roll!")
        Else
            Console.WriteLine("Unknown option...")
        End If

    End Sub

End Module
