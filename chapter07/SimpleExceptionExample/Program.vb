Module Program

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
        Catch ex As Exception
            Console.WriteLine("*** Error! ***")
            Console.WriteLine($"Member name: {ex.TargetSite}")
            Console.WriteLine($"Class defining member: {ex.TargetSite.DeclaringType}")
            Console.WriteLine($"Message: {ex.Message}")
            Console.WriteLine($"Source: {ex.Source}")
            Console.WriteLine($"Stack: {ex.StackTrace}")
        End Try

        Console.WriteLine("**** Out of exception logic *****")

    End Sub

End Module
