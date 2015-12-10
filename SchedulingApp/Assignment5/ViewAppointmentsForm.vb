Public Class ViewAppointmentsForm
	Private Sub ViewAppointmentsForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
		For Each doctor As Physician In physicians
			cmbDoctors.Items.Add(doctor.firstName & " " & doctor.lastName)
		Next
		' Makes the selected item the first in the collection. Ommits breaking of program
		cmbDoctors.SelectedIndex = 0

		refresher()
	End Sub

	Private Sub cmbDoctors_SelectedIndexChanged(sender As Object, e As EventArgs) Handles chkDoctor.CheckedChanged, cmbDoctors.SelectedIndexChanged
		If chkDoctor.Checked And cmbDoctors.SelectedValue IsNot "" Then
			Dim query = From aAppt In appointments
						Where aAppt.doctor = cmbDoctors.SelectedItem.ToString()
						Select aAppt
						Order By aAppt.apptDate

			dgvAppointments.DataSource = query.ToList()
		Else
			refresher()
		End If
	End Sub

	Private Sub btnEdit_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles btnEdit.LinkClicked
		' Obtain the appointment ID for future reference
		Dim id As Integer = CInt(dgvAppointments.SelectedRows.Item(0).Cells(0).Value)
		'' Obtain patient name
		'Dim pat As String = dgvAppointments.SelectedRows.Item(0).Cells(1).Value.ToString()
		'' Obtain doctor name
		'Dim doc As String = dgvAppointments.SelectedRows.Item(0).Cells(2).Value.ToString()
		' Modify appointment ID to match 0-based index of appointment values
		Dim index As Integer = id - 1

		Dim ModApptForm = New ModApptForm
		ModApptForm.lblApptID.Text = id.ToString()
		ModApptForm.dtpDate.Text = appointments(index).apptDate
		ModApptForm.dtpTime.Text = appointments(index).apptTime
		ModApptForm.txtLength.Text = CType(appointments(index).apptLen, String)
		ModApptForm.txtPurpose.Text = appointments(index).apptPurpose

		' + 2 used to remove remaining white space after substring
		For Each patient In patients
			ModApptForm.lstPatients.Items.Add(patient.ToString().Substring(patient.ToString().IndexOf("-") + 2))
		Next
		For Each doctor In physicians
			ModApptForm.lstDoctors.Items.Add(doctor.ToString().Substring(doctor.ToString().IndexOf("-") + 2))
		Next

		' Close form
		'Me.Close()
		ModApptForm.ShowDialog()
		refresher()
	End Sub

	' Used to update the DataGridView upon certain circumstances (see above.)
	Private Sub refresher()
		Dim query = From aAppt In appointments
					Select aAppt
					Order By aAppt.patient

		dgvAppointments.DataSource = query.ToList()
	End Sub

End Class