<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ScheduleApptForm
	Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
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
    <System.Diagnostics.DebuggerStepThrough()> _
	Private Sub InitializeComponent()
		Me.components = New System.ComponentModel.Container()
		Me.lstPatients = New System.Windows.Forms.ListBox()
		Me.Label1 = New System.Windows.Forms.Label()
		Me.Label2 = New System.Windows.Forms.Label()
		Me.Label3 = New System.Windows.Forms.Label()
		Me.lstDoctors = New System.Windows.Forms.ListBox()
		Me.Label4 = New System.Windows.Forms.Label()
		Me.lblApptID = New System.Windows.Forms.Label()
		Me.Label5 = New System.Windows.Forms.Label()
		Me.dtpDate = New System.Windows.Forms.DateTimePicker()
		Me.Label6 = New System.Windows.Forms.Label()
		Me.dtpTime = New System.Windows.Forms.DateTimePicker()
		Me.Label7 = New System.Windows.Forms.Label()
		Me.txtPurpose = New System.Windows.Forms.TextBox()
		Me.btnCancel = New System.Windows.Forms.Button()
		Me.btnSave = New System.Windows.Forms.Button()
		Me.Label8 = New System.Windows.Forms.Label()
		Me.txtLength = New System.Windows.Forms.TextBox()
		Me.Label9 = New System.Windows.Forms.Label()
		Me.StatusStrip1 = New System.Windows.Forms.StatusStrip()
		Me.lblStatus = New System.Windows.Forms.ToolStripStatusLabel()
		Me.errPatients = New System.Windows.Forms.ErrorProvider(Me.components)
		Me.errDoctor = New System.Windows.Forms.ErrorProvider(Me.components)
		Me.errLength = New System.Windows.Forms.ErrorProvider(Me.components)
		Me.StatusStrip1.SuspendLayout()
		CType(Me.errPatients, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.errDoctor, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.errLength, System.ComponentModel.ISupportInitialize).BeginInit()
		Me.SuspendLayout()
		'
		'lstPatients
		'
		Me.lstPatients.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.5!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.lstPatients.FormattingEnabled = True
		Me.lstPatients.ItemHeight = 16
		Me.lstPatients.Location = New System.Drawing.Point(12, 69)
		Me.lstPatients.Name = "lstPatients"
		Me.lstPatients.Size = New System.Drawing.Size(178, 132)
		Me.lstPatients.TabIndex = 0
		'
		'Label1
		'
		Me.Label1.AutoSize = True
		Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.5!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.Label1.Location = New System.Drawing.Point(12, 46)
		Me.Label1.Name = "Label1"
		Me.Label1.Size = New System.Drawing.Size(59, 17)
		Me.Label1.TabIndex = 1
		Me.Label1.Text = "Patients"
		'
		'Label2
		'
		Me.Label2.AutoSize = True
		Me.Label2.Font = New System.Drawing.Font("Trebuchet MS", 14.25!, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.Label2.Location = New System.Drawing.Point(110, 9)
		Me.Label2.Name = "Label2"
		Me.Label2.Size = New System.Drawing.Size(201, 24)
		Me.Label2.TabIndex = 2
		Me.Label2.Text = "Schedule Appointment"
		'
		'Label3
		'
		Me.Label3.AutoSize = True
		Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.5!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.Label3.Location = New System.Drawing.Point(12, 208)
		Me.Label3.Name = "Label3"
		Me.Label3.Size = New System.Drawing.Size(57, 17)
		Me.Label3.TabIndex = 4
		Me.Label3.Text = "Doctors"
		'
		'lstDoctors
		'
		Me.lstDoctors.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.5!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.lstDoctors.FormattingEnabled = True
		Me.lstDoctors.ItemHeight = 16
		Me.lstDoctors.Location = New System.Drawing.Point(12, 228)
		Me.lstDoctors.Name = "lstDoctors"
		Me.lstDoctors.Size = New System.Drawing.Size(178, 132)
		Me.lstDoctors.TabIndex = 3
		'
		'Label4
		'
		Me.Label4.AutoSize = True
		Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.5!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.Label4.Location = New System.Drawing.Point(258, 46)
		Me.Label4.Name = "Label4"
		Me.Label4.Size = New System.Drawing.Size(104, 17)
		Me.Label4.TabIndex = 5
		Me.Label4.Text = "Appointment ID"
		'
		'lblApptID
		'
		Me.lblApptID.BackColor = System.Drawing.SystemColors.ActiveCaption
		Me.lblApptID.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
		Me.lblApptID.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.lblApptID.Location = New System.Drawing.Point(274, 66)
		Me.lblApptID.Name = "lblApptID"
		Me.lblApptID.Size = New System.Drawing.Size(70, 23)
		Me.lblApptID.TabIndex = 6
		Me.lblApptID.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
		'
		'Label5
		'
		Me.Label5.AutoSize = True
		Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.5!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.Label5.Location = New System.Drawing.Point(290, 98)
		Me.Label5.Name = "Label5"
		Me.Label5.Size = New System.Drawing.Size(38, 17)
		Me.Label5.TabIndex = 7
		Me.Label5.Text = "Date"
		'
		'dtpDate
		'
		Me.dtpDate.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.5!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.dtpDate.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
		Me.dtpDate.Location = New System.Drawing.Point(255, 118)
		Me.dtpDate.Name = "dtpDate"
		Me.dtpDate.Size = New System.Drawing.Size(112, 23)
		Me.dtpDate.TabIndex = 8
		'
		'Label6
		'
		Me.Label6.AutoSize = True
		Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.5!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.Label6.Location = New System.Drawing.Point(290, 150)
		Me.Label6.Name = "Label6"
		Me.Label6.Size = New System.Drawing.Size(39, 17)
		Me.Label6.TabIndex = 9
		Me.Label6.Text = "Time"
		'
		'dtpTime
		'
		Me.dtpTime.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.5!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.dtpTime.Format = System.Windows.Forms.DateTimePickerFormat.Time
		Me.dtpTime.Location = New System.Drawing.Point(260, 170)
		Me.dtpTime.Name = "dtpTime"
		Me.dtpTime.Size = New System.Drawing.Size(107, 23)
		Me.dtpTime.TabIndex = 10
		Me.dtpTime.Value = New Date(2015, 11, 12, 20, 56, 0, 0)
		'
		'Label7
		'
		Me.Label7.AutoSize = True
		Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.5!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.Label7.Location = New System.Drawing.Point(283, 259)
		Me.Label7.Name = "Label7"
		Me.Label7.Size = New System.Drawing.Size(61, 17)
		Me.Label7.TabIndex = 11
		Me.Label7.Text = "Purpose"
		'
		'txtPurpose
		'
		Me.txtPurpose.Location = New System.Drawing.Point(229, 279)
		Me.txtPurpose.Multiline = True
		Me.txtPurpose.Name = "txtPurpose"
		Me.txtPurpose.Size = New System.Drawing.Size(168, 60)
		Me.txtPurpose.TabIndex = 12
		'
		'btnCancel
		'
		Me.btnCancel.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.5!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.btnCancel.Location = New System.Drawing.Point(215, 345)
		Me.btnCancel.Name = "btnCancel"
		Me.btnCancel.Size = New System.Drawing.Size(96, 31)
		Me.btnCancel.TabIndex = 13
		Me.btnCancel.Text = "Close"
		Me.btnCancel.UseVisualStyleBackColor = True
		'
		'btnSave
		'
		Me.btnSave.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.5!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.btnSave.Location = New System.Drawing.Point(317, 345)
		Me.btnSave.Name = "btnSave"
		Me.btnSave.Size = New System.Drawing.Size(92, 31)
		Me.btnSave.TabIndex = 14
		Me.btnSave.Text = "Add"
		Me.btnSave.UseVisualStyleBackColor = True
		'
		'Label8
		'
		Me.Label8.AutoSize = True
		Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.5!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.Label8.Location = New System.Drawing.Point(290, 208)
		Me.Label8.Name = "Label8"
		Me.Label8.Size = New System.Drawing.Size(48, 16)
		Me.Label8.TabIndex = 15
		Me.Label8.Text = "Length"
		'
		'txtLength
		'
		Me.txtLength.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.5!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.txtLength.Location = New System.Drawing.Point(284, 227)
		Me.txtLength.Name = "txtLength"
		Me.txtLength.Size = New System.Drawing.Size(59, 22)
		Me.txtLength.TabIndex = 16
		Me.txtLength.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
		'
		'Label9
		'
		Me.Label9.AutoSize = True
		Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.Label9.Location = New System.Drawing.Point(341, 228)
		Me.Label9.Name = "Label9"
		Me.Label9.Size = New System.Drawing.Size(32, 16)
		Me.Label9.TabIndex = 17
		Me.Label9.Text = "min."
		'
		'StatusStrip1
		'
		Me.StatusStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.lblStatus})
		Me.StatusStrip1.Location = New System.Drawing.Point(0, 388)
		Me.StatusStrip1.Name = "StatusStrip1"
		Me.StatusStrip1.Size = New System.Drawing.Size(421, 22)
		Me.StatusStrip1.TabIndex = 18
		Me.StatusStrip1.Text = "StatusStrip1"
		'
		'lblStatus
		'
		Me.lblStatus.Name = "lblStatus"
		Me.lblStatus.Size = New System.Drawing.Size(0, 17)
		'
		'errPatients
		'
		Me.errPatients.ContainerControl = Me
		'
		'errDoctor
		'
		Me.errDoctor.ContainerControl = Me
		'
		'errLength
		'
		Me.errLength.ContainerControl = Me
		'
		'ScheduleApptForm
		'
		Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
		Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
		Me.BackColor = System.Drawing.SystemColors.GradientActiveCaption
		Me.ClientSize = New System.Drawing.Size(421, 410)
		Me.Controls.Add(Me.StatusStrip1)
		Me.Controls.Add(Me.Label9)
		Me.Controls.Add(Me.txtLength)
		Me.Controls.Add(Me.Label8)
		Me.Controls.Add(Me.btnSave)
		Me.Controls.Add(Me.btnCancel)
		Me.Controls.Add(Me.txtPurpose)
		Me.Controls.Add(Me.Label7)
		Me.Controls.Add(Me.dtpTime)
		Me.Controls.Add(Me.Label6)
		Me.Controls.Add(Me.dtpDate)
		Me.Controls.Add(Me.Label5)
		Me.Controls.Add(Me.lblApptID)
		Me.Controls.Add(Me.Label4)
		Me.Controls.Add(Me.Label3)
		Me.Controls.Add(Me.lstDoctors)
		Me.Controls.Add(Me.Label2)
		Me.Controls.Add(Me.Label1)
		Me.Controls.Add(Me.lstPatients)
		Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D
		Me.Name = "ScheduleApptForm"
		Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
		Me.Text = "Mercy Medical Services."
		Me.StatusStrip1.ResumeLayout(False)
		Me.StatusStrip1.PerformLayout()
		CType(Me.errPatients, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.errDoctor, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.errLength, System.ComponentModel.ISupportInitialize).EndInit()
		Me.ResumeLayout(False)
		Me.PerformLayout()

	End Sub

	Friend WithEvents lstPatients As ListBox
	Friend WithEvents Label1 As Label
	Friend WithEvents Label2 As Label
	Friend WithEvents Label3 As Label
	Friend WithEvents lstDoctors As ListBox
	Friend WithEvents Label4 As Label
	Friend WithEvents lblApptID As Label
	Friend WithEvents Label5 As Label
	Friend WithEvents dtpDate As DateTimePicker
	Friend WithEvents Label6 As Label
	Friend WithEvents dtpTime As DateTimePicker
	Friend WithEvents Label7 As Label
	Friend WithEvents txtPurpose As TextBox
	Friend WithEvents btnCancel As Button
	Friend WithEvents btnSave As Button
	Friend WithEvents Label8 As Label
	Friend WithEvents txtLength As TextBox
	Friend WithEvents Label9 As Label
	Friend WithEvents StatusStrip1 As StatusStrip
	Friend WithEvents lblStatus As ToolStripStatusLabel
	Friend WithEvents errPatients As ErrorProvider
	Friend WithEvents errDoctor As ErrorProvider
	Friend WithEvents errLength As ErrorProvider
End Class
