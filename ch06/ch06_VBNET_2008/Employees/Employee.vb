﻿''' <summary>
''' This is the employee class.
''' </summary>
Partial Public MustInherit Class Employee
	Public Class BenefitPackage

		Public Enum BenefitPackageLevel
			Standard
			Gold
			Platinum
		End Enum

		' Assume we have other members that represent
		' 401K plans, dental/health benefits, and so on.

		Public Function ComputePayDeduction() As Double
			Return 125.0
		End Function
	End Class

	' Field data.
	Protected empName As String
	Protected empAge As Integer
	Protected empSSN As String
	Protected empID As Integer
	Protected currPay As Single
	Protected Shared companyName As String
	Protected empBenefits As New BenefitPackage

	' Expose certain benefit bheaviors of object.
	Public Function GetBenefitCost() As Double
		Return empBenefits.ComputePayDeduction()
	End Function

	' Expose object through a custom property
	Public Property Benefits As BenefitPackage
		Get
			Return empBenefits
		End Get
		Set(value As BenefitPackage)
			empBenefits = value
		End Set
	End Property

	' Constructors
	Public Sub New()
	End Sub

	Public Shared Property Company() As String
		Get
			Return companyName
		End Get
		Set(value As String)
			companyName = value
		End Set
	End Property


	Public Sub New(ByVal name As String, ByVal id As Integer, ByVal pay As Single)
		empName = name
		empID = id
		currPay = pay
	End Sub

	''' <summary>
	''' This is the constructor for the Employee class.
	''' </summary>
	''' <param name="name">Employee Name.</param>
	''' <param name="age">Employee Age.</param>
	''' <param name="id">Employee ID.</param>
	''' <param name="pay">Employee Annual Pay.</param>
	Public Sub New(ByVal name As String, ByVal age As Integer, ByVal id As Integer, ByVal pay As Single, ByVal ssn As String)
		empName = name
		empAge = age
		empID = id
		currPay = pay
		empSSN = ssn
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

	Public ReadOnly Property SocialSecurityNumber() As String
		Get
			Return empSSN
		End Get
		'Set(value As String)
		'	empSSN = value
		'End Set
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

	' This method may now be "overriden" by derived classes.
	Public Overridable Sub GiveBonus(ByVal amount As Single)
		currPay += amount
	End Sub
	Public Overridable Sub DisplayStats()
		Console.WriteLine("Name: {0}", empName)
		Console.WriteLine("Age: {0}", empAge)
		Console.WriteLine("SSN: {0}", empSSN)
		Console.WriteLine("ID: {0}", empID)
		Console.WriteLine("Pay: {0}", currPay)
	End Sub

	Public Sub FireThisPerson(ByVal emp As Employee)
		If TypeOf emp Is SalesPerson Then
			Console.WriteLine("Lost a sales person named {0}", emp.Name)
			Console.WriteLine("{0} made {1} sale(s)...", emp.Name, CType(emp, SalesPerson).SalesNumber)
			Console.WriteLine()
		End If

		If TypeOf emp Is Manager Then
			Console.WriteLine("Lost a suit named {0}", emp.Name)
			Console.WriteLine("{0} had {1}stock options...", emp.Name, CType(emp, Manager).StockOptions)
			Console.WriteLine()
		End If
	End Sub

End Class
