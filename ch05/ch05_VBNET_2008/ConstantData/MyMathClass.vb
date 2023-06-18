Public Class MyMathClass
	'Public Const PI As Double = 3.14
	'Public ReadOnly PI As Double
	Public Shared ReadOnly PI As Double = 3.14
	Public Sub New()
		' Nope! Compiler error!
		'PI = 3.1444
		' This is now OK when ReadOnly is used (without Shared)
		'PI = 3.1444
	End Sub
End Class
