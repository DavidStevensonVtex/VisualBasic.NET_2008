Imports System

Module Program
	Sub Main(args As String())
		' Passing ref types by value.
		Console.WriteLine("***** Passing Person object by value *****" & vbCrLf)
		Dim fred As New Person("Fred", 12)
		Console.WriteLine("Before by value call, Person is: ")
		Console.WriteLine(fred)

		SendAPersonByValue(fred)
		Console.WriteLine("After a value call, Person is: ")
		Console.WriteLine(fred)
		Console.WriteLine()

		' Passing ref types by reference.
		Dim mel As New Person("Mel", 23)
		Console.WriteLine("Before by ref call, Person is:")
		Console.WriteLine(mel)

		SendAPersonByReference(mel)
		Console.WriteLine("After a ref call, Person is: ")
		Console.WriteLine(mel)
		Console.WriteLine()
	End Sub

	Sub SendAPersonByValue(ByVal p As Person)
		' Change the age of "p"?
		p.Age = 99

		' Will the caller see this reassignment?
		p = New Person("Nikki", 999)
	End Sub

	Sub SendAPersonByReference(ByRef p As Person)
		' Change the age of "p"?
		p.Age = 99

		' Will the caller see this reassignment?
		p = New Person("Nikki", 999)
	End Sub

End Module
