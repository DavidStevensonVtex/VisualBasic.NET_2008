Public Class Radio
	Public Sub TurnOn(ByVal state As Boolean)
		If state Then
			Console.WriteLine("Jamming...")
		Else
			Console.WriteLine("Quiet time...")
		End If
	End Sub
End Class
