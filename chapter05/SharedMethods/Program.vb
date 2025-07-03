Module Program

    Sub Main()
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
