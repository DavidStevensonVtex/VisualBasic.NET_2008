Imports System

Module Program
	Sub Main(args As String())
		Console.WriteLine("***** Fun with Lambdas *****")

		Console.WriteLine("Traditional Delegate Syntax")
		TraditionalDelegateSyntax()
		Console.WriteLine()

		Console.WriteLine("Lambda Expression Syntax")
		LambdaExpressionSyntax()

		Console.WriteLine()
	End Sub

	Sub LambdaExpressionSyntax()
		Dim list As New List(Of Integer)()
		list.AddRange(New Integer() {20, 1, 4, 8, 9, 44})

		' Call FindAll() passing the delegate object.
		Dim evenNumbers As List(Of Integer) = list.FindAll(Function(i) (i Mod 2) = 0)

		' Print out the result set.
		Console.WriteLine("Here are the even numbers: ")
		For Each evenNumber As Integer In evenNumbers
			Console.WriteLine(evenNumber)
		Next
	End Sub

	Sub TraditionalDelegateSyntax()
		Dim list As New List(Of Integer)()
		list.AddRange(New Integer() {20, 1, 4, 8, 9, 44})

		' Create a Predicate(Of T) object for use by
		' the List(Of T).FindAll() method.
		Dim callback As New Predicate(Of Integer)(AddressOf IsEvenNumber)

		' Call FindAll() passing the delegate object.
		Dim evenNumbers As List(Of Integer) = list.FindAll(callback)

		' Print out the result set.
		Console.WriteLine("Here are the even numbers: ")
		For Each evenNumber As Integer In evenNumbers
			Console.WriteLine(evenNumber)
		Next
	End Sub

	' Target for the Predicate(Of T) delegate.
	Function IsEvenNumber(ByVal i As Integer) As Boolean
		' Is it an even number?
		Return (i Mod 2) = 0
	End Function
End Module
