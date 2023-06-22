Imports System

' This generic delegate ca point to any method
' taking a single argument (specified at the time of creation)
Public Delegate Sub MyGenericDelegate(Of T)(ByVal arg As T)

' Simulating Generic Delegates Using System.Object
Public Delegate Sub MyDelegate(ByVal arg As Object)
Module Program
	Sub Main(args As String())

		Console.WriteLine("***** Fun with generic delegates *****")
		Console.WriteLine()

		' Make instace of delegate pointing to method taking an integer
		Dim d As New MyGenericDelegate(Of Integer)(AddressOf IntegerTarget)

		' Invoke what the delegate is pointing to.
		d(100)

		' Now pointing to a method taking a String
		Dim d2 As New MyGenericDelegate(Of String)(AddressOf StringTarget)

		' Invoke what the delegate is pointing to.
		d2("Cool!")
		Console.WriteLine()

		TestMethod()
	End Sub

	Public Sub IntegerTarget(ByVal arg As Integer)
		Console.WriteLine($"You passed me a {arg.GetType()} with the value of {arg}")
	End Sub

	Public Sub StringTarget(ByVal arg As String)
		Console.WriteLine($"You passed me a {arg.GetType()} with the value of {arg}")
	End Sub
End Module
