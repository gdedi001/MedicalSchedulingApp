' Acquire necessary imports
Imports System.IO
Imports System.Xml.Serialization

Public Class MainForm

	' Once the form loads, make the labels transparent
	Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

		lblTitle.BackColor = Color.Transparent
		lblTitleChild.BackColor = Color.Transparent

		' CODE BELOW USED TO SERIALIZE PHYSICIAN(S) TO XML 
		'' Add Physician(s) to physician list
		'physicians.Add(New Physician(1, "Hector", "Salamanca", 1))
		'physicians.Add(New Physician(2, "Walter", "White", 2))
		'physicians.Add(New Physician(3, "Jessie", "Pinkman", 3))
		'physicians.Add(New Physician(4, "Hank", "Schrader", 0))
		'physicians.Add(New Physician(5, "Gus", "Fring", 1))

		'' Pass Physician objects into list and serialize data
		'Dim sw As New StreamWriter(PhysicianFileName)
		'Dim serial As New XmlSerializer(physicians.GetType())
		'serial.Serialize(sw, physicians)
		'sw.Close()

		' Deserialize patients.XML Data
		Dim patientStreamReader As New StreamReader(PatientFileName)
		Dim patient As New XmlSerializer(patients.GetType)
		patients = CType(patient.Deserialize(patientStreamReader), List(Of Patient))
		patientStreamReader.Close()

		' Deserialize physician.XML Data
		Dim phyStreamReader As New StreamReader(PhysicianFileName)
		Dim physician As New XmlSerializer(physicians.GetType)
		physicians = CType(physician.Deserialize(phyStreamReader), List(Of Physician))
		phyStreamReader.Close()

		' Deserialize appointments.XML Data
		Dim apptStreamReader As New StreamReader(ApptFileName)
		Dim appointment As New XmlSerializer(appointments.GetType)
		appointments = CType(appointment.Deserialize(apptStreamReader), List(Of Appointment))
		apptStreamReader.Close()

	End Sub

	Private Sub CreateAppointmentToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CreateAppointmentToolStripMenuItem.Click

		' Create new PatientAppt form and show it when the client clicks respective button
		Dim PatientApptForm = New PatientApptForm
		PatientApptForm.Show()

	End Sub

	Private Sub ViewListToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ViewListToolStripMenuItem.Click

		' Create new PatientList form and show it when the client clicks the respective button
		Dim PatientListForm As New PatientListForm

		' Add each entry in patients to the list of patients
		For Each entry As Patient In patients
			PatientListForm.lstPatients.Items.Add(entry.ToString())
		Next

		PatientListForm.ShowDialog()

	End Sub

	Private Sub FindPatientToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles FindPatientToolStripMenuItem.Click
		Dim FindPatientForm = New FindPatientForm
		FindPatientForm.ShowDialog()
	End Sub

	' Schedule Appointments
	Private Sub ScheduleAppointmentsToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ScheduleAppointmentsToolStripMenuItem.Click
		Dim ScheduleApptForm = New ScheduleApptForm
		ScheduleApptForm.ShowDialog()
	End Sub

	' View Appointments
	Private Sub ViewAppointmentsToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles ViewAppointmentsToolStripMenuItem1.Click
		Dim ViewAppointmentsForm = New ViewAppointmentsForm
		ViewAppointmentsForm.ShowDialog()
	End Sub


	Private Sub CloseToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CloseToolStripMenuItem.Click

		' Save the list of patients in the XML File
		Dim swPatient As New StreamWriter(PatientFileName)
		Dim serialPatient As New XmlSerializer(patients.GetType())
		serialPatient.Serialize(swPatient, patients)
		swPatient.Close()

		' Save the list of physicians in the XML File
		Dim swPhysician As New StreamWriter(PhysicianFileName)
		Dim serialPhysician As New XmlSerializer(physicians.GetType)
		serialPhysician.Serialize(swPhysician, physicians)
		swPhysician.Close()

		' Save the list of appointments in the XML File
		Dim swAppt As New StreamWriter(ApptFileName)
		Dim serialAppt As New XmlSerializer(appointments.GetType())
		serialAppt.Serialize(swAppt, appointments)
		swAppt.Close()

		Me.Close()

	End Sub

	Private Sub topRightX() Handles Me.Closing

		' Save the list of patients in the XML File
		Dim sw As New StreamWriter(PatientFileName)
		Dim serial As New XmlSerializer(patients.GetType())
		serial.Serialize(sw, patients)
		sw.Close()

		' Save the list of appointments in the XML File
		Dim swAppt As New StreamWriter(ApptFileName)
		Dim serialAppt As New XmlSerializer(appointments.GetType())
		serialAppt.Serialize(swAppt, appointments)
		swAppt.Close()

	End Sub

	Private Sub ComingSoonToolStripMenuItem_Click(sender As Object, e As EventArgs) 
		MessageBox.Show("Feature coming soon!")
	End Sub

End Class
