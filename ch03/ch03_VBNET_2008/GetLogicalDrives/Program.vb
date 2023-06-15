Imports System

Module Program
	Function Main(args As String()) As Integer
		' OS running this app?
		Console.WriteLine("Current OS: {0}", Environment.OSVersion)

		' List the drive on this machine.
		Dim drives As String() = Environment.GetLogicalDrives()
		Dim d As String
		For Each d In drives
			Console.WriteLine("You have a drive named {0}", d)
		Next

		' Which version of the .NET platform is running this app?
		Console.WriteLine("Executing version of .NET: {0}",
						  Environment.Version)

		Return 0
	End Function
End Module
