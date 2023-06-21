Imports System

Module Program
	Sub Main(args As String())
		Console.WriteLine("**** Strongly Typed Collections")
		Console.WriteLine()

		' Add some people.
		Dim myPeople As New PeopleCollection()
		myPeople.AddPerson(New Person("Homer", "Simpson", 40))
		myPeople.AddPerson(New Person("Marge", "Simpson", 38))
		myPeople.AddPerson(New Person("Lisa", "Simpson", 9))
		myPeople.AddPerson(New Person("Bart", "Simpson", 7))
		myPeople.AddPerson(New Person("Maggie", "Simpson", 2))

		' Get person objects using For Each.
		For Each p As Person In myPeople
			Console.WriteLine(p)
		Next

		' Get/Set new Person object using type indexer.
		myPeople(5) = New Person("Waylon", "Smithers", 47)
		Console.WriteLine($"Person #5 is {myPeople(5)}")

	End Sub
End Module
