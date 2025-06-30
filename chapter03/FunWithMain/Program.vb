Public Class Program
    Shared Sub Main()
        Console.WriteLine("***** Fun with Main() *****")
        ' Get command-line args
        Dim args As String() = Environment.GetCommandLineArgs()
        Dim s As String
        For Each s In args
            Console.WriteLine("Arg: {0}", s)
        Next
    End Sub

End Class
