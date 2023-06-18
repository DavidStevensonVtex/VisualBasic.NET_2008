﻿Public Class Employee
	' Field data.
	Private empName As String
	Private empAge As Integer
	Private empSSN As String
	Private empID As Integer
	Private currPay As Single

	' Constructors
	Public Sub New()
	End Sub


	Public Sub New(ByVal name As String, ByVal id As Integer, ByVal pay As Single)
		empName = name
		empID = id
		currPay = pay
	End Sub


	Public Sub New(ByVal name As String, ByVal age As Integer, ByVal id As Integer, ByVal pay As Single)
		empName = name
		empAge = age
		empID = id
		currPay = pay
	End Sub

	' Properties
	Public Property Name() As String
		Get
			Return empName
		End Get
		Set(value As String)
			empName = value
		End Set
	End Property

	Public Property Age() As Integer
		Get
			Return empAge
		End Get
		Set(value As Integer)
			empAge = value
		End Set
	End Property

	Public Property SocialSecurityNumber() As String
		Get
			Return empSSN
		End Get
		Set(value As String)
			empSSN = value
		End Set
	End Property

	Public Property ID() As Integer
		Get
			Return empID
		End Get
		Set(value As Integer)
			empID = value
		End Set
	End Property

	Public Property Pay() As Single
		Get
			Return currPay
		End Get
		Set(value As Single)
			currPay = value
		End Set
	End Property

	' Methods
	Public Sub GiveBonus(ByVal amount As Single)
		currPay += amount
	End Sub
	Public Sub DisplayStats()
		Console.WriteLine("Name: {0}", empName)
		Console.WriteLine("Age: {0}", empAge)
		Console.WriteLine("SSN: {0}", empSSN)
		Console.WriteLine("ID: {0}", empID)
		Console.WriteLine("Pay: {0}", currPay)
	End Sub

End Class
