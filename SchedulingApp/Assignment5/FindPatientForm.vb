Public Class FindPatientForm

	Dim firstN As String
	Dim lastN As String
	Dim dob As String

	Private Sub btnSearch_Click(sender As Object, e As EventArgs) Handles btnSearch.Click

		firstN = txtFirstN.Text.ToLower() ' Use for case insensitivity
		lastN = txtLastN.Text.ToLower() ' Use for case insensitivity
		dob = txtDOB.Text

		Dim PatientListForm As New PatientListForm

		' Determine which actions to take based on if checkbox is selected
		If chkLastN.Checked Then
			If txtLastN.Text IsNot "" Then
				Dim queryLast = From aPatient In patients
								Select aPatient
								Where aPatient.lastName.ToLower() = lastN
								Order By aPatient.id

				PatientListForm.lstPatients.DataSource = queryLast.ToList
				PatientListForm.ShowDialog()

			Else
				errorLastN.SetError(txtLastN, "Last name can not be left blank")
			End If

		Else

			If (txtFirstN.Text IsNot "" And txtLastN.Text IsNot "" And txtDOB.Text IsNot "") Then
				Dim query = From aPatient In patients
							Select aPatient
							Where aPatient.firstName.ToLower() = firstN And aPatient.lastName.ToLower() = lastN And aPatient.dob = dob
							Order By aPatient.id

				PatientListForm.lstPatients.DataSource = query.ToList
				PatientListForm.ShowDialog()
			Else
				If txtFirstN.Text = "" Then
					errorFirstN.SetError(txtFirstN, "First name can not be left blank")
				End If

				If txtLastN.Text = "" Then
					errorLastN.SetError(txtLastN, "Last name can not be left blank")
				End If

				If txtDOB.Text = "" Then
					errorDOB.SetError(txtDOB, "Field can not be left blank")
				End If

			End If
		End If

	End Sub

	Private Sub chkLastN_CheckedChanged(sender As Object, e As EventArgs) Handles chkLastN.CheckedChanged

		If chkLastN.Checked Then
			lblStatus.Text = "Last name filter enabled. Only last name required."
		Else
			lblStatus.Text = "Last name filter disabled. Please fill in all required fields."
		End If

	End Sub

	Private Sub btnClose_Click(sender As Object, e As EventArgs) Handles btnClose.Click
		Me.Close()
	End Sub
End Class