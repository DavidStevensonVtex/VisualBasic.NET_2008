Imports System.Text

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
        s3 = String.Concat(s1, s2)
        Console.WriteLine(s3)

        ' Use the StringBuilder
        Dim sb As New StringBuilder("**** Fantastic Games *****")
        sb.Append(vbLf)
        sb.AppendLine("Half Life 2")
        sb.AppendLine("Beyond God and Evil")
        sb.AppendLine("Deus Ex 1 and 2")
        sb.AppendLine("System Shock")
        sb.Replace("2", "Deus Ex: Invisible War")
        Console.WriteLine(sb)
        Console.WriteLine("sb has {0} chars.", sb.Length)

    End Sub

End Module
