Public Class Teenager
	Public Shared r As New Random()

	Public Shared Function GetRandomNumber(ByVal upperLimit As Short) As Integer
		Return r.Next(upperLimit)
	End Function

	Public Shared Function Complain() As String
		Dim messages As String() = {"Do I have to?", "He started it!", "I'm too tired...", "I hate school!", "You are sooo wrong."}
		Return messages(GetRandomNumber(5))
	End Function

End Class
