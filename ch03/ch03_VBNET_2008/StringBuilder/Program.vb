Imports System
Imports System.Text

Module Program
	Sub Main(args As String())
		Dim sb As New System.Text.StringBuilder("***** Fantastic Games *****")
		sb.Append(vbCrLf)
		sb.AppendLine("Half Life 2")
		sb.AppendLine("Beyond Good and Evil")
		sb.AppendLine("Deus Ex 1 and 2")
		sb.Append("System Shock")
		sb.Replace("2", "Deus Ex: Invisible War")
		Console.WriteLine(sb)
		Console.WriteLine("sb has {0} chars.", sb.Length)
	End Sub
End Module
