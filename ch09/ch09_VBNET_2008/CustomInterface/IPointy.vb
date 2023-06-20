

' This interface defines the behavior of "having points."
Public Interface IPointy
	' Implicitly public and abstract.
	Function GetNumberOfPoints() As Byte
	ReadOnly Property Points() As Byte
End Interface
