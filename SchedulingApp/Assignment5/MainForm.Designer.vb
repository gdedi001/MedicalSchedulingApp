<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class MainForm
	Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
	Protected Overrides Sub Dispose(ByVal disposing As Boolean)
		Try
			If disposing AndAlso components IsNot Nothing Then
				components.Dispose()
			End If
		Finally
			MyBase.Dispose(disposing)
		End Try
	End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
	Private Sub InitializeComponent()
		Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(MainForm))
		Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
		Me.FileToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
		Me.CloseToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
		Me.PatientsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
		Me.CreateAppointmentToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
		Me.ViewListToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
		Me.FindPatientToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
		Me.AppointmentsToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
		Me.ScheduleAppointmentsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
		Me.ViewAppointmentsToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
		Me.lblTitle = New System.Windows.Forms.Label()
		Me.lblTitleChild = New System.Windows.Forms.Label()
		Me.MenuStrip1.SuspendLayout()
		Me.SuspendLayout()
		'
		'MenuStrip1
		'
		Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.FileToolStripMenuItem, Me.PatientsToolStripMenuItem, Me.AppointmentsToolStripMenuItem1})
		Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
		Me.MenuStrip1.Name = "MenuStrip1"
		Me.MenuStrip1.Size = New System.Drawing.Size(571, 24)
		Me.MenuStrip1.TabIndex = 1
		Me.MenuStrip1.Text = "MenuStrip1"
		'
		'FileToolStripMenuItem
		'
		Me.FileToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.CloseToolStripMenuItem})
		Me.FileToolStripMenuItem.Name = "FileToolStripMenuItem"
		Me.FileToolStripMenuItem.Size = New System.Drawing.Size(37, 20)
		Me.FileToolStripMenuItem.Text = "File"
		'
		'CloseToolStripMenuItem
		'
		Me.CloseToolStripMenuItem.Name = "CloseToolStripMenuItem"
		Me.CloseToolStripMenuItem.Size = New System.Drawing.Size(103, 22)
		Me.CloseToolStripMenuItem.Text = "Close"
		'
		'PatientsToolStripMenuItem
		'
		Me.PatientsToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.CreateAppointmentToolStripMenuItem, Me.ViewListToolStripMenuItem, Me.FindPatientToolStripMenuItem})
		Me.PatientsToolStripMenuItem.Name = "PatientsToolStripMenuItem"
		Me.PatientsToolStripMenuItem.Size = New System.Drawing.Size(61, 20)
		Me.PatientsToolStripMenuItem.Text = "Patients"
		'
		'CreateAppointmentToolStripMenuItem
		'
		Me.CreateAppointmentToolStripMenuItem.Name = "CreateAppointmentToolStripMenuItem"
		Me.CreateAppointmentToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
		Me.CreateAppointmentToolStripMenuItem.Text = "Add Patient(s)"
		'
		'ViewListToolStripMenuItem
		'
		Me.ViewListToolStripMenuItem.Name = "ViewListToolStripMenuItem"
		Me.ViewListToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
		Me.ViewListToolStripMenuItem.Text = "View List"
		'
		'FindPatientToolStripMenuItem
		'
		Me.FindPatientToolStripMenuItem.Name = "FindPatientToolStripMenuItem"
		Me.FindPatientToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
		Me.FindPatientToolStripMenuItem.Text = "Find Patient"
		'
		'AppointmentsToolStripMenuItem1
		'
		Me.AppointmentsToolStripMenuItem1.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ScheduleAppointmentsToolStripMenuItem, Me.ViewAppointmentsToolStripMenuItem1})
		Me.AppointmentsToolStripMenuItem1.Name = "AppointmentsToolStripMenuItem1"
		Me.AppointmentsToolStripMenuItem1.Size = New System.Drawing.Size(95, 20)
		Me.AppointmentsToolStripMenuItem1.Text = "Appointments"
		'
		'ScheduleAppointmentsToolStripMenuItem
		'
		Me.ScheduleAppointmentsToolStripMenuItem.Name = "ScheduleAppointmentsToolStripMenuItem"
		Me.ScheduleAppointmentsToolStripMenuItem.Size = New System.Drawing.Size(209, 22)
		Me.ScheduleAppointmentsToolStripMenuItem.Text = "Schedule Appointment(s)"
		'
		'ViewAppointmentsToolStripMenuItem1
		'
		Me.ViewAppointmentsToolStripMenuItem1.Name = "ViewAppointmentsToolStripMenuItem1"
		Me.ViewAppointmentsToolStripMenuItem1.Size = New System.Drawing.Size(209, 22)
		Me.ViewAppointmentsToolStripMenuItem1.Text = "View Appointments"
		'
		'lblTitle
		'
		Me.lblTitle.AutoSize = True
		Me.lblTitle.Font = New System.Drawing.Font("Lucida Sans Unicode", 16.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.lblTitle.ForeColor = System.Drawing.SystemColors.ControlLightLight
		Me.lblTitle.Location = New System.Drawing.Point(12, 104)
		Me.lblTitle.Name = "lblTitle"
		Me.lblTitle.Size = New System.Drawing.Size(286, 27)
		Me.lblTitle.TabIndex = 2
		Me.lblTitle.Text = "Mercy Medical Scheduling"
		'
		'lblTitleChild
		'
		Me.lblTitleChild.AutoSize = True
		Me.lblTitleChild.Font = New System.Drawing.Font("Segoe UI", 10.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.lblTitleChild.ForeColor = System.Drawing.SystemColors.ControlLightLight
		Me.lblTitleChild.Location = New System.Drawing.Point(68, 138)
		Me.lblTitleChild.Name = "lblTitleChild"
		Me.lblTitleChild.Size = New System.Drawing.Size(211, 19)
		Me.lblTitleChild.TabIndex = 3
		Me.lblTitleChild.Text = "First-class medical professionals"
		'
		'MainForm
		'
		Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
		Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
		Me.BackColor = System.Drawing.SystemColors.ControlLight
		Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
		Me.ClientSize = New System.Drawing.Size(571, 327)
		Me.Controls.Add(Me.lblTitleChild)
		Me.Controls.Add(Me.lblTitle)
		Me.Controls.Add(Me.MenuStrip1)
		Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
		Me.MainMenuStrip = Me.MenuStrip1
		Me.MaximizeBox = False
		Me.Name = "MainForm"
		Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
		Me.Text = "Mercy Medical Services"
		Me.MenuStrip1.ResumeLayout(False)
		Me.MenuStrip1.PerformLayout()
		Me.ResumeLayout(False)
		Me.PerformLayout()

	End Sub
	Friend WithEvents MenuStrip1 As MenuStrip
	Friend WithEvents FileToolStripMenuItem As ToolStripMenuItem
	Friend WithEvents CloseToolStripMenuItem As ToolStripMenuItem
	Friend WithEvents PatientsToolStripMenuItem As ToolStripMenuItem
	Friend WithEvents lblTitle As Label
	Friend WithEvents lblTitleChild As Label
	Friend WithEvents CreateAppointmentToolStripMenuItem As ToolStripMenuItem
	Friend WithEvents ViewListToolStripMenuItem As ToolStripMenuItem
	Friend WithEvents FindPatientToolStripMenuItem As ToolStripMenuItem
	Friend WithEvents AppointmentsToolStripMenuItem1 As ToolStripMenuItem
	Friend WithEvents ScheduleAppointmentsToolStripMenuItem As ToolStripMenuItem
	Friend WithEvents ViewAppointmentsToolStripMenuItem1 As ToolStripMenuItem
End Class
