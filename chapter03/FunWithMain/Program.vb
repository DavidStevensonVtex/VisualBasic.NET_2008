Public Class Program
    Shared Function Main(ByVal args As String()) As Integer
        Console.WriteLine("***** Fun with Main() *****")
        ' Get command-line args
        Dim s As String
        For Each s In args
            Console.WriteLine("Arg: {0}", s)
        Next

        ' List the drives on this machine
        Dim drives As String() = Environment.GetLogicalDrives()
        For Each drive In drives
            Console.WriteLine("You have a drive named {0}.", drive)
        Next
        ' Return a value to the OS.
        Return 0
    End Function

End Class
