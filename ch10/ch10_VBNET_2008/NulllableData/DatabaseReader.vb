Public Class DatabaseReader
	' Nullable data fields
	Public Property NumericValue As Nullable(Of Integer) = Nothing
	Public Property BoolValue As Nullable(Of Boolean) = True

	' Note the nullable return time.
	Public Function GetIntFromDatabase() As Nullable(Of Integer)
		Return NumericValue
	End Function

	' Note the nullable return type.
	Public Function GetBoolFromDatabase() As Nullable(Of Boolean)
		Return BoolValue
	End Function

End Class
