Public Class ModApptForm
	' Create unassigned variables to hold info
	Dim patientName As String
	Dim doctorName As String
	Dim apptDate As String
	Dim apptTime As String
	Dim apptLength As Integer
	Dim apptPurpose As String

	Private Sub ModApptForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
		lstPatients.SelectedIndex = 0
		lstDoctors.SelectedIndex = 0
	End Sub

	Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
		' Once the Save button has been selected, edit all appointment info based on corresponding appointmentID
		Dim index As Integer = CInt(lblApptID.Text) - 1 ' Appointment objects are 0-based index
		' Assign values to corresponding variables
		patientName = lstPatients.SelectedItem.ToString()
		doctorName = lstDoctors.SelectedItem.ToString()
		apptDate = dtpDate.Value.ToShortDateString()
		apptTime = dtpTime.Value.ToShortTimeString()
		apptPurpose = txtPurpose.Text

		If txtLength.Text = "" Then
			errLength.SetError(txtLength, "Please enter length of time")
		Else
			apptLength = CInt(txtLength.Text)
		End If

		' Edit the information within proper appointment object
		appointments(index).patient = patientName
		appointments(index).doctor = doctorName
		appointments(index).apptDate = apptDate
		appointments(index).apptTime = apptTime
		appointments(index).apptLen = apptLength
		appointments(index).apptPurpose = apptPurpose
		' Alert client and close form
		MessageBox.Show("Patient information saved!")

		Me.Close()
	End Sub

	Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
		Me.Close()
	End Sub

End Class