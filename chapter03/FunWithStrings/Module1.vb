Module Module1

    Sub Main()
        Console.WriteLine("***** Fun with Strings *****")
        Dim firstName As String = "June"
        Console.WriteLine("Value of firstName: {0}", firstName)
        Console.WriteLine("firstName has {0} characters.", firstName.Length)
        Console.WriteLine("firstName in uppercase: {0}", firstName.ToUpper())
        Console.WriteLine("firstname in lowercase: {0}", firstName.ToLower())

        Dim myValue As Integer = 3456787
        Console.WriteLine("Hex value of myValue is: {0:X}", myValue)
        Console.WriteLine("Currency value of myValue is: {0:C}", myValue)

        Dim s1 As String = "Programming the "
        Dim s2 As String = "PsychoDrill (PTP)"
        Dim s3 = s1 & s2
        Console.WriteLine(s3)

    End Sub

End Module
