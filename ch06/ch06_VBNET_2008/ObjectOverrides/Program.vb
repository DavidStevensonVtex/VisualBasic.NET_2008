Imports System

Module Program
	Sub Main(args As String())
		Console.WriteLine("***** Fun with System.Object ******")
		Console.WriteLine()

		' NOTE: We want these to be identical to test
		' the Equals() and GetHashCode() methods.

		Dim p1 As New Person("Homer", "Simpson", 50)
		Dim p2 As New Person("Homer", "Simpson", 50)

		' Get stringified version of objects.
		Console.WriteLine("p1.ToString() = {0}", p1.ToString())
		Console.WriteLine("p2.ToString() = {0}", p2.ToString())

		' Test Overridden Equals()
		Console.WriteLine("p1 = p2? {0}", p1.Equals(p2))

		' Test Hash codes.
		Console.WriteLine("Same hash codes?: {0}", p1.GetHashCode() = p2.GetHashCode())
		Console.WriteLine()

		' Change age of p2 and test again.
		p2.personAge = 45
		Console.WriteLine("p1.ToString() = {0}", p1.ToString())
		Console.WriteLine("p2.ToString() = {0}", p2.ToString())
		Console.WriteLine("p1 = p2? {0}", p1.Equals(p2))
		Console.WriteLine("Same hash codes?: {0}", p1.GetHashCode() = p2.GetHashCode())
		Console.WriteLine()

		SharedMembersOfObject()
		Console.WriteLine()
	End Sub

	Sub SharedMembersOfObject()
		' Shared members of System.Object
		Dim p3 As New Person("Sally", "Jones", 4)
		Dim p4 As New Person("Sally", "Jones", 4)
		Console.WriteLine("P3 and P4 have same state: {0}", Object.Equals(p3, p4))
		Console.WriteLine("P3 and P4 are pointing to same object: {0}", Object.ReferenceEquals(p3, p4))
	End Sub
End Module
