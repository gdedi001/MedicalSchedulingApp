Public Class PatientModifyForm

	Private Sub btnModify_Click(sender As Object, e As EventArgs) Handles btnSave.Click

		Try
			' Use Id as the primary indicator to access patients in XML
			Dim id As Integer = CInt(lblPatientId.Text) - 1 ' patients are on a 0 based index

			' Insurance Provider is optional. Does not need error checking
			patients(id).insurance = txtInsPrvdr.Text

			' First Name
			If txtFirstN.Text = "" Then
				errFirst.SetError(txtFirstN, "First name can not be left blank")
			Else
				patients(id).firstName = txtFirstN.Text
			End If

			' Last Name
			If txtLastN.Text = "" Then
				errLast.SetError(txtLastN, "Last name can not be left blank")
			Else
				patients(id).lastName = txtLastN.Text
			End If

			' Date of Birth
			If txtDOB.Text = "" Then
				errDOB.SetError(txtDOB, "Birth date can not be left blank")
			Else
				patients(id).dob = txtDOB.Text
			End If

			' Phone Number
			If txtPhone.Text = "" Then
				errPhone.SetError(txtPhone, "Phone can not be left blank")
			Else
				patients(id).phone = txtPhone.Text
			End If

			' Email 
			If txtEmail.Text = "" Then
				errEmail.SetError(txtEmail, "Email can not be left blank")
			Else
				patients(id).email = txtEmail.Text
			End If

			' Sub ID
			If txtSubId.Text = "" Then
				errSubID.SetError(txtSubId, "Subscriber ID can not be left blank")
			Else
				patients(id).subId = CInt(txtSubId.Text)
			End If

			' Plan
			If cmbPlan.SelectedItem.ToString() = "" Then
				errPlan.SetError(cmbPlan, "Please select a plan.")
			Else
				patients(id).plan = cmbPlan.SelectedItem.ToString()
			End If

			' Plan ID
			If txtPlanId.Text = "" Then
				errPlanID.SetError(txtPlanId, "Plan ID can not be left blank")
			Else
				patients(id).planId = CInt(txtPlanId.Text)
			End If

			' If all criteria is met and no errors are found, display the following label status
			If txtFirstN.Text IsNot "" And txtLastN.Text IsNot "" And txtDOB.Text IsNot "" And txtPhone.Text IsNot "" And
					txtEmail.Text IsNot "" And txtSubId.Text IsNot "" And txtPlanId.Text IsNot "" Then

				' Clear the list of patients in original form 
				PatientListForm.lstPatients.Items.Clear()

				For Each item As Patient In patients
					PatientListForm.lstPatients.Items.Add(item)
				Next

				'PatientList.Close()
				'PatientList.Show()

				lblStatus.Text = "Patient: " & txtFirstN.Text & " " & txtLastN.Text & " has been updated."
			End If

		Catch
			lblStatus.Text = "Please provide all required information."
		End Try

	End Sub

	Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click

		txtFirstN.Text = ""
		txtLastN.Text = ""
		txtDOB.Text = ""
		txtPhone.Text = ""
		txtEmail.Text = ""
		txtInsPrvdr.Text = ""
		txtSubId.Text = ""
		txtPlanId.Text = ""

	End Sub

	Private Sub btnClose_Click(sender As Object, e As EventArgs) Handles btnClose.Click
		Me.Close()
	End Sub

End Class