Module Program

    Sub Main()
        Console.WriteLine("***** Fun with Shared Data *****")
        Dim s1 As New SavingsAccount(50)
        Dim s2 As New SavingsAccount(100)

        ' Get and Set interest rate at the object level.
        Console.WriteLine($"Interest Rate is: {s1.GetInterestRate()}")
        s2.SetInterestRate(0.08)

        ' Make new object; this does NOT "reset" the interest rate for this object.
        Dim s3 As New SavingsAccount(10000.75)
        Console.WriteLine($"Interest Rate is: {s3.GetInterestRate()}")
    End Sub

    Sub Main2()
        Console.WriteLine("***** Shared Methods *****")
        For i As Integer = 0 To 5
            Console.WriteLine(Teenager.Complain())
        Next

        ' VB-ism!
        Dim bob As New Teenager()
        For i As Integer = 0 To 5
            ' Access of shared member, constant member, enum member or nested type through an instance;
            ' qualifying expression will not be evaluated.
            'Console.WriteLine(bob.Complain())
        Next

    End Sub

End Module
