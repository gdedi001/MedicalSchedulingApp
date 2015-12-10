Public Class PatientListForm

	Private Sub lblEdit_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles lblEdit.LinkClicked

		If lstPatients.SelectedItem IsNot Nothing Then
			' Obtain the id from the selected item in the listbox. Use it to access patient elements
			Dim i As Integer = CInt(lstPatients.SelectedItem.ToString.Substring(0, 2).Trim()) - 1

			' Create new PatientModify form object and apply values for when the form is shown to client
			Dim PatientModifyForm = New PatientModifyForm
			' Personal Information
			PatientModifyForm.lblPatientId.Text = patients.ElementAt(i).id.ToString()
			PatientModifyForm.txtFirstN.Text = patients.ElementAt(i).firstName
			PatientModifyForm.txtLastN.Text = patients.ElementAt(i).lastName
			PatientModifyForm.txtDOB.Text = patients.ElementAt(i).dob
			PatientModifyForm.txtPhone.Text = patients.ElementAt(i).phone
			PatientModifyForm.txtEmail.Text = patients.ElementAt(i).email
			' Insurance Information
			PatientModifyForm.txtInsPrvdr.Text = patients.ElementAt(i).insurance ' Insurance Provider
			PatientModifyForm.txtSubId.Text = patients.ElementAt(i).subId.ToString()
			PatientModifyForm.cmbPlan.SelectedItem = patients.ElementAt(i).plan
			PatientModifyForm.txtPlanId.Text = patients.ElementAt(i).planId.ToString()

			' Show the form with corresponding values
			PatientModifyForm.ShowDialog()

			'lstPatients.Items.Clear()

			'For Each entry As Patient In patients
			'	lstPatients.Items.Add(entry.ToString())
			'Next

			'Me.Close()

		Else
			lblStatus.Text = "Please select a patient to modify."
		End If

	End Sub

	Private Sub PatientList_Load(sender As Object, e As EventArgs) Handles MyBase.Load

		''lstPatients.Items.Clear()

		'For Each entry As Patient In patients
		'	lstPatients.Items.Add(entry.ToString())
		'Next
	End Sub
End Class