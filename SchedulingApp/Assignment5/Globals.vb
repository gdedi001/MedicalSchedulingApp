Module Globals

	' Create patients list of Type Patient and relative path to respective XML file
	Public patients As New List(Of Patient)
	Public ReadOnly PatientFileName As String = "..\..\patients.xml"

	' Create physician list of Type Physician and relative path to respective XML file
	Public physicians As New List(Of Physician)
	Public ReadOnly PhysicianFileName As String = "..\..\physician.xml"

	' Create appointment list of Type Appointment and relative path to respeective XML File
	Public appointments As New List(Of Appointment)
	Public ReadOnly ApptFileName As String = "..\..\appointments.xml"

End Module
