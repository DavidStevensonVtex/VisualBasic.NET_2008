Imports System

Module Program
	Sub Main(args As String())
		' Call the non-generic Swap() method.
		Dim a, b As Integer
		a = 10 : b = 40
		Console.WriteLine($"Before swap: a = {a}, b = {b}")
		NonGenericMethods.Swap(a, b)
		Console.WriteLine($"After swap: a = {a}, b = {b}")
		Console.WriteLine()

		a = 10 : b = 40
		Console.WriteLine($"Before swap: a = {a}, b = {b}")
		Program.Swap(Of Integer)(a, b)
		Console.WriteLine($"After swap: a = {a}, b = {b}")
		Console.WriteLine()

		Dim s1, s2 As String
		s1 = "Generics" : s2 = "Rock"
		Console.WriteLine($"Before swap: s1 = {s1}, s2 = {s2}")
		Program.Swap(s1, s2)
		Console.WriteLine($"After swap: s1 = {s1}, s2 = {s2}")


	End Sub

	Public Function Swap(Of T)(ByRef a As T, ByRef b As T) As T
		Console.WriteLine("T is a {0}.", GetType(T))
		Dim temp As T
		temp = a
		a = b
		b = temp
	End Function

	' Display the base class of 'T'.
	Sub DisplayBaseClass(Of T)()
		Console.WriteLine("Base class of {0} is: {1}.",
		  GetType(T), GetType(T).BaseType)
	End Sub
End Module
