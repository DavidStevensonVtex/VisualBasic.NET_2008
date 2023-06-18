Imports System

Module Program
	Sub Main(args As String())
		Console.WriteLine("The value of PI is: {0}", MyMathClass.PI)

		'MyMathClass.PI = 3.1444
		' Error BC30074	Constant cannot be the target Of an assignment.

		Dim m As New MyMathClass()
		Console.WriteLine("The value of PI is: {0}", m.PI)

		' A local constant data point.
		Const fixedStr As String = "Fixed String Data"
		Console.WriteLine(fixedStr)

		' Error!
		'fixedStr = "This will not work!"
		' Error BC30074	Constant cannot be the target Of an assignment.
	End Sub
End Module
