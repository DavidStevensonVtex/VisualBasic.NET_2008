Imports System

Module Program
	Sub Main(args As String())
		Console.WriteLine("***** Fund with Arrays")
		SimpleArrays()
		SimpleArrays2()
		SimpleArrays3()
		SimpleArrays4()
		ArrayOfObjects()
		RedimPreserve()
		MultiDimArray()
	End Sub

	Sub SimpleArrays()
		Console.WriteLine("=> Simple Array Creation.")
		' An array of 11 Strings.
		Dim myStrings(10) As String

		' An array of 3 Intgers
		Dim myInts(2) As Integer

		' An Array of 5 Objects
		Dim myObjs(4) As Object

	End Sub

	Sub SimpleArrays2()
		' Create an fill an array of three Integers.
		Dim myInts(2) As Integer
		myInts(0) = 100
		myInts(1) = 200
		myInts(2) = 300

		' Now print each value.
		For Each i As Integer In myInts
			Console.WriteLine(i)
		Next
	End Sub

	Sub SimpleArrays3()
		' An array of unassigned numerical data.
		Dim myInts(2) As Integer
		For Each i As Integer In myInts
			Console.WriteLine(i)
		Next

		' String array with assigned data.
		Dim myStrs(2) As String
		myStrs(0) = "Cerebus"
		myStrs(1) = "Jaka"
		myStrs(2) = "Astoria"
		For Each s As String In myStrs
			Console.WriteLine(s)
		Next
	End Sub

	Sub SimpleArrays4()
		' An array of 3 integers
		' Don't specify upper bound when using 
		' curly bracket array initizlization syntax.
		Dim myInts() As Integer = {100, 200, 300}
		For Each i As Integer In myInts
			Console.WriteLine(i)
		Next
	End Sub

	Sub ArrayOfObjects()
		Console.WriteLine("=> Array of Objects.")
		' An array of Objects can be anything at all.
		Dim myObjects(3) As Object
		myObjects(0) = 10
		myObjects(1) = False
		myObjects(2) = New DateTime(1969, 3, 24)
		myObjects(3) = "Form & Void"

		For Each obj As Object In myObjects
			' Print the type and value for each item in array.
			Console.WriteLine("Type: {0}, Value: {1}", obj.GetType(), obj)
		Next
	End Sub

	' The Redim/Preserve Syntax
	Sub RedimPreserve()
		Console.WriteLine("=> Redim / Preserve keywords.")
		' Man an array with ten slots.
		Dim myValues(9) As Integer
		For i As Integer = 0 To 9
			myValues(i) = i
		Next
		For i As Integer = 0 To UBound(myValues)
			Console.Write("{0} ", myValues(i))
		Next
		Console.WriteLine()

		' ReDim the array with extra slots
		ReDim Preserve myValues(15)
		For i As Integer = 9 To UBound(myValues)
			myValues(i) = i
		Next
		For i As Integer = 0 To UBound(myValues)
			Console.Write("{0} ", myValues(i))
		Next
		Console.WriteLine()
	End Sub

	Sub MultiDimArray()
		Console.WriteLine("=> MultiDimensional arrays.")
		Dim myMatrix(6, 6) As Integer   ' Makes a 7x7 array
		' Populate array
		Dim k As Integer, j As Integer
		For k = 0 To 6
			For j = 0 To 6
				myMatrix(k, j) = k * j
			Next j
		Next k

		' Show array
		For k = 0 To 6
			For j = 0 To 6
				Console.Write("{0,2} ", myMatrix(k, j))
			Next j
			Console.WriteLine()
		Next k
	End Sub
End Module
