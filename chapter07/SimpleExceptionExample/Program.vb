﻿Module Program

    Sub Main()
        Console.WriteLine("**** Simple Exception Example *****")
        Console.WriteLine("=> Creating a car and stepping on it!")
        Dim myCar As New Car("Zippy", 20)
        myCar.CrankTunes(True)

        ' Try/Catch logic.
        Try
            For i As Integer = 0 To 10
                myCar.Accelerate(10)
            Next
        Catch ex As ArgumentOutOfRangeException
            ' Process bad arguments
        Catch ex As CarIsDeadException
            Console.WriteLine("*** Error! ***")
            Console.WriteLine($"Member name: {ex.TargetSite}")
            Console.WriteLine($"Class defining member: {ex.TargetSite.DeclaringType}")
            Console.WriteLine($"Message: {ex.Message}")
            Console.WriteLine($"Source: {ex.Source}")
            Console.WriteLine($"Stack: {ex.StackTrace}")
            Console.WriteLine($"Help Link: {ex.HelpLink}")

            ' By default the data field is empty, so check for Nothing.
            Console.WriteLine("-> Custom Data")
            If (ex.Data IsNot Nothing) Then
                For Each de As DictionaryEntry In ex.Data
                    Console.WriteLine($"-> {de.Key} : {de.Value}")
                Next
            End If
        Catch ex As Exception
            ' Try to catch all other exceptiones here.
        End Try

        Console.WriteLine("**** Out of exception logic *****")

    End Sub

End Module
