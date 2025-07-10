Module Program

    Sub Main()
        Console.WriteLine("***** Fun with Dispose ******")
        'Dim rw As New MyResourceWrapper()
        'Try
        '    ' Call members of rw.
        'Finally
        '    rw.Dispose()
        'End Try

        Using rw As New MyResourceWrapper(),
                rw2 As New MyResourceWrapper(),
                myCar As New Car()
            ' Use the objects, Dispose() automatically called!
        End Using

    End Sub

End Module
