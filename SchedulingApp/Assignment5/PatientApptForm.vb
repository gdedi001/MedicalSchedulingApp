' Acquire necessary imports
Imports System.IO
Imports System.Xml.Serialization

Public Class PatientApptForm

	' Unique Patient ID
	Dim patientId As Integer = 1
	' Create unassigned variables to hold patient info
	Dim firstN As String
	Dim lastN As String
	Dim dob As String
	Dim phoneN As String
	Dim email As String
	Dim insurance As String
	Dim subId As Integer
	Dim plan As String
	Dim planId As Integer

	' Once the form loads, execute the following
	Private Sub PatientAppt_Load(sender As Object, e As EventArgs) Handles MyBase.Load
		' Obtain patient ID
		For Each item As Patient In patients
			patientId += 1
		Next
		' Assign patient ID

		' Display patient ID
		lblPatientId.Text = patientId.ToString()
		' Display default text for client
		txtFirstN.Text = "John"
		txtLastN.Text = "Doe"
		txtDOB.Text = "01/30/0000"
		txtPhone.Text = "0000000000"
		txtEmail.Text = "john@example.com"
		txtSubId.Text = "-"
		txtPlanId.Text = "-"

	End Sub

	' Add Button
	Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click

		Try
			' Asing variables based on client input
			firstN = txtFirstN.Text.ToString()
			lastN = txtLastN.Text.ToString()
			dob = txtDOB.Text.ToString()
			phoneN = txtPhone.Text.ToString()
			email = txtEmail.Text.ToString()
			insurance = txtInsPrvdr.Text.ToString()
			subId = CType(txtSubId.Text, Integer)
			plan = cmbPlan.SelectedItem.ToString()
			planId = CType(txtPlanId.Text, Integer)

			' Add new Patient object to the patients list
			patients.Add(New Patient(patientId, firstN, lastN, dob, phoneN, email, plan, subId, planId, insurance))

			' Automatic patientID counter
			patientId += 1

			lblStatus.Text = "Patient: " & firstN & " " & lastN & " has been added."
			' Display the new patientID
			lblPatientId.Text = CType(patientId, String)

		Catch
			lblStatus.Text = "Please provide all required information."
		End Try

	End Sub

	' Clear Button
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

	' Close Button
	Private Sub btnReturn_Click(sender As Object, e As EventArgs) Handles btnReturn.Click
		Me.Close()
	End Sub

End Class