Imports System.Collections
' Garage contains a set of Car objects.
Public Class Garage
	Implements IEnumerable

	Private myCars() As Car = New Car(3) {}

	Public Sub New()
		myCars(0) = New Car("Fred", 40)
		myCars(1) = New Car("Zippy", 60)
		myCars(2) = New Car("Mabel", 0)
		myCars(3) = New Car("Max", 80)
	End Sub

	Public Function GetEnumerator() As IEnumerator Implements IEnumerable.GetEnumerator
		Return myCars.GetEnumerator()
	End Function
End Class
