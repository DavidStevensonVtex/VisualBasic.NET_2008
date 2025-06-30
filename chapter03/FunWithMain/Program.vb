Public Class Program
    Shared Sub Main(ByVal args As String())
        Console.WriteLine("***** Fun with Main() *****")
        ' Get command-line args
        Dim s As String
        For Each s In args
            Console.WriteLine("Arg: {0}", s)
        Next
    End Sub

End Class
