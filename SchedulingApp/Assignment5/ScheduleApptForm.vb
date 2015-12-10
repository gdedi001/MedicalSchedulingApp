Public Class ScheduleApptForm

	' Unique Appointment ID
	Dim apptID As Integer = 1
	' Create unassigned variables to hold info
	Dim patientName As String
	Dim doctorName As String
	Dim apptDate As String
	Dim apptTime As String
	Dim apptLength As Integer
	Dim apptPurpose As String

	Private Sub ScheduleApptForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load

		' Load proper appointment ID when form loads
		For Each appt As Appointment In appointments
			apptID += 1
		Next

		' Add each entry in patients and physicians to list box in respective form
		For Each patient As Patient In patients
			' + 2 used to remove remaining white space after substring
			lstPatients.Items.Add(patient.ToString().Substring(patient.ToString().IndexOf("-") + 2))
		Next
		For Each doctor As Physician In physicians
			lstDoctors.Items.Add(doctor.ToString().Substring(doctor.ToString().IndexOf("-") + 2))
		Next

		' Assign appointment ID
		lblApptID.Text = apptID.ToString()
	End Sub

	Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
		' obtain / assign information from the form
		'patientName = lstPatients.SelectedItem.ToString()
		'doctorName = lstDoctors.SelectedItem.ToString()
		apptDate = dtpDate.Value.ToShortDateString()
		apptTime = dtpTime.Value.ToShortTimeString()
		'apptLength = CInt(txtLength.Text)
		apptPurpose = txtPurpose.Text

		If lstPatients.Text = Nothing Then
			errPatients.SetError(lstPatients, "Please select patient")
		Else
			patientName = lstPatients.SelectedItem.ToString()
		End If

		If lstDoctors.Text = Nothing Then
			errPatients.SetError(lstDoctors, "Please select doctor")
		Else
			doctorName = lstDoctors.SelectedItem.ToString()
		End If

		If txtLength.Text = "" Then
			errLength.SetError(txtLength, "Please enter length of time")
		Else
			apptLength = CInt(txtLength.Text)
		End If

		If patientName IsNot "" And doctorName IsNot "" And txtLength.Text IsNot "" Then
			' add new appointment object to list of appointments
			appointments.Add(New Appointment(apptID, patientName, doctorName, apptDate, apptTime, apptLength, apptPurpose))
			lblStatus.Text = "New appointment created."
			' Auto-increment appointment ID and label
			apptID += 1
			lblApptID.Text = apptID.ToString()
		End If
	End Sub

	Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
		Me.Close()
	End Sub

End Class