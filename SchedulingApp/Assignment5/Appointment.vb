Public Class Appointment
	Public Property apptID As Integer
	Public Property patient As String
	Public Property doctor As String
	Public Property apptDate As String
	Public Property apptTime As String
	Public Property apptLen As Integer
	Public Property apptPurpose As String

	Public Sub New(ByVal nAppID As Integer, ByVal nPatient As String, ByVal nDoc As String,
				   ByVal nApptDate As String, ByVal nApptTime As String, ByVal nApptLen As Integer,
				   ByVal nApptPur As String)

		apptID = nAppID
		patient = nPatient
		doctor = nDoc
		apptDate = nApptDate
		apptTime = nApptTime
		apptLen = nApptLen
		apptPurpose = nApptPur

	End Sub

	' Parameterless constructor used for XML serialization
	Public Sub New()

	End Sub

End Class
