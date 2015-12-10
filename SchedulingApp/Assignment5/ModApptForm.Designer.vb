<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ModApptForm
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
		Me.Label1 = New System.Windows.Forms.Label()
		Me.Label9 = New System.Windows.Forms.Label()
		Me.txtLength = New System.Windows.Forms.TextBox()
		Me.Label8 = New System.Windows.Forms.Label()
		Me.btnSave = New System.Windows.Forms.Button()
		Me.btnCancel = New System.Windows.Forms.Button()
		Me.txtPurpose = New System.Windows.Forms.TextBox()
		Me.Label7 = New System.Windows.Forms.Label()
		Me.dtpTime = New System.Windows.Forms.DateTimePicker()
		Me.Label6 = New System.Windows.Forms.Label()
		Me.dtpDate = New System.Windows.Forms.DateTimePicker()
		Me.Label5 = New System.Windows.Forms.Label()
		Me.lblApptID = New System.Windows.Forms.Label()
		Me.Label4 = New System.Windows.Forms.Label()
		Me.Label3 = New System.Windows.Forms.Label()
		Me.lstDoctors = New System.Windows.Forms.ListBox()
		Me.Label2 = New System.Windows.Forms.Label()
		Me.Label10 = New System.Windows.Forms.Label()
		Me.lstPatients = New System.Windows.Forms.ListBox()
		Me.errLength = New System.Windows.Forms.ErrorProvider(Me.components)
		CType(Me.errLength, System.ComponentModel.ISupportInitialize).BeginInit()
		Me.SuspendLayout()
		'
		'Label1
		'
		Me.Label1.AutoSize = True
		Me.Label1.Font = New System.Drawing.Font("Verdana", 11.25!, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.Label1.Location = New System.Drawing.Point(106, -21)
		Me.Label1.Name = "Label1"
		Me.Label1.Size = New System.Drawing.Size(195, 18)
		Me.Label1.TabIndex = 62
		Me.Label1.Text = "Edit Personal Information"
		'
		'Label9
		'
		Me.Label9.AutoSize = True
		Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.Label9.Location = New System.Drawing.Point(341, 232)
		Me.Label9.Name = "Label9"
		Me.Label9.Size = New System.Drawing.Size(32, 16)
		Me.Label9.TabIndex = 80
		Me.Label9.Text = "min."
		'
		'txtLength
		'
		Me.txtLength.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.5!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.txtLength.Location = New System.Drawing.Point(284, 231)
		Me.txtLength.Name = "txtLength"
		Me.txtLength.Size = New System.Drawing.Size(59, 22)
		Me.txtLength.TabIndex = 79
		Me.txtLength.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
		'
		'Label8
		'
		Me.Label8.AutoSize = True
		Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.5!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.Label8.Location = New System.Drawing.Point(290, 212)
		Me.Label8.Name = "Label8"
		Me.Label8.Size = New System.Drawing.Size(48, 16)
		Me.Label8.TabIndex = 78
		Me.Label8.Text = "Length"
		'
		'btnSave
		'
		Me.btnSave.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.5!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.btnSave.Location = New System.Drawing.Point(317, 349)
		Me.btnSave.Name = "btnSave"
		Me.btnSave.Size = New System.Drawing.Size(92, 31)
		Me.btnSave.TabIndex = 77
		Me.btnSave.Text = "Save"
		Me.btnSave.UseVisualStyleBackColor = True
		'
		'btnCancel
		'
		Me.btnCancel.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.5!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.btnCancel.Location = New System.Drawing.Point(215, 349)
		Me.btnCancel.Name = "btnCancel"
		Me.btnCancel.Size = New System.Drawing.Size(96, 31)
		Me.btnCancel.TabIndex = 76
		Me.btnCancel.Text = "Close"
		Me.btnCancel.UseVisualStyleBackColor = True
		'
		'txtPurpose
		'
		Me.txtPurpose.Location = New System.Drawing.Point(229, 283)
		Me.txtPurpose.Multiline = True
		Me.txtPurpose.Name = "txtPurpose"
		Me.txtPurpose.Size = New System.Drawing.Size(168, 60)
		Me.txtPurpose.TabIndex = 75
		'
		'Label7
		'
		Me.Label7.AutoSize = True
		Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.5!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.Label7.Location = New System.Drawing.Point(283, 263)
		Me.Label7.Name = "Label7"
		Me.Label7.Size = New System.Drawing.Size(61, 17)
		Me.Label7.TabIndex = 74
		Me.Label7.Text = "Purpose"
		'
		'dtpTime
		'
		Me.dtpTime.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.5!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.dtpTime.Format = System.Windows.Forms.DateTimePickerFormat.Time
		Me.dtpTime.Location = New System.Drawing.Point(260, 174)
		Me.dtpTime.Name = "dtpTime"
		Me.dtpTime.Size = New System.Drawing.Size(107, 23)
		Me.dtpTime.TabIndex = 73
		Me.dtpTime.Value = New Date(2015, 11, 12, 20, 56, 0, 0)
		'
		'Label6
		'
		Me.Label6.AutoSize = True
		Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.5!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.Label6.Location = New System.Drawing.Point(290, 154)
		Me.Label6.Name = "Label6"
		Me.Label6.Size = New System.Drawing.Size(39, 17)
		Me.Label6.TabIndex = 72
		Me.Label6.Text = "Time"
		'
		'dtpDate
		'
		Me.dtpDate.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.5!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.dtpDate.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
		Me.dtpDate.Location = New System.Drawing.Point(255, 122)
		Me.dtpDate.Name = "dtpDate"
		Me.dtpDate.Size = New System.Drawing.Size(112, 23)
		Me.dtpDate.TabIndex = 71
		'
		'Label5
		'
		Me.Label5.AutoSize = True
		Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.5!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.Label5.Location = New System.Drawing.Point(290, 102)
		Me.Label5.Name = "Label5"
		Me.Label5.Size = New System.Drawing.Size(38, 17)
		Me.Label5.TabIndex = 70
		Me.Label5.Text = "Date"
		'
		'lblApptID
		'
		Me.lblApptID.BackColor = System.Drawing.SystemColors.ActiveCaption
		Me.lblApptID.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
		Me.lblApptID.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.lblApptID.Location = New System.Drawing.Point(274, 70)
		Me.lblApptID.Name = "lblApptID"
		Me.lblApptID.Size = New System.Drawing.Size(70, 23)
		Me.lblApptID.TabIndex = 69
		Me.lblApptID.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
		'
		'Label4
		'
		Me.Label4.AutoSize = True
		Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.5!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.Label4.Location = New System.Drawing.Point(258, 50)
		Me.Label4.Name = "Label4"
		Me.Label4.Size = New System.Drawing.Size(104, 17)
		Me.Label4.TabIndex = 68
		Me.Label4.Text = "Appointment ID"
		'
		'Label3
		'
		Me.Label3.AutoSize = True
		Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.5!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.Label3.Location = New System.Drawing.Point(12, 212)
		Me.Label3.Name = "Label3"
		Me.Label3.Size = New System.Drawing.Size(57, 17)
		Me.Label3.TabIndex = 67
		Me.Label3.Text = "Doctors"
		'
		'lstDoctors
		'
		Me.lstDoctors.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.5!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.lstDoctors.FormattingEnabled = True
		Me.lstDoctors.ItemHeight = 16
		Me.lstDoctors.Location = New System.Drawing.Point(12, 232)
		Me.lstDoctors.Name = "lstDoctors"
		Me.lstDoctors.Size = New System.Drawing.Size(178, 132)
		Me.lstDoctors.TabIndex = 66
		'
		'Label2
		'
		Me.Label2.AutoSize = True
		Me.Label2.Font = New System.Drawing.Font("Trebuchet MS", 14.25!, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.Label2.Location = New System.Drawing.Point(131, 9)
		Me.Label2.Name = "Label2"
		Me.Label2.Size = New System.Drawing.Size(159, 24)
		Me.Label2.TabIndex = 65
		Me.Label2.Text = "Edit Appointment"
		'
		'Label10
		'
		Me.Label10.AutoSize = True
		Me.Label10.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.5!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.Label10.Location = New System.Drawing.Point(12, 50)
		Me.Label10.Name = "Label10"
		Me.Label10.Size = New System.Drawing.Size(59, 17)
		Me.Label10.TabIndex = 64
		Me.Label10.Text = "Patients"
		'
		'lstPatients
		'
		Me.lstPatients.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.5!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.lstPatients.FormattingEnabled = True
		Me.lstPatients.ItemHeight = 16
		Me.lstPatients.Location = New System.Drawing.Point(12, 73)
		Me.lstPatients.Name = "lstPatients"
		Me.lstPatients.Size = New System.Drawing.Size(178, 132)
		Me.lstPatients.TabIndex = 63
		'
		'errLength
		'
		Me.errLength.ContainerControl = Me
		'
		'ModApptForm
		'
		Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
		Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
		Me.BackColor = System.Drawing.SystemColors.GradientActiveCaption
		Me.ClientSize = New System.Drawing.Size(417, 384)
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
		Me.Controls.Add(Me.Label10)
		Me.Controls.Add(Me.lstPatients)
		Me.Controls.Add(Me.Label1)
		Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D
		Me.Name = "ModApptForm"
		Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
		Me.Text = "Modify Appointment"
		Me.TopMost = True
		CType(Me.errLength, System.ComponentModel.ISupportInitialize).EndInit()
		Me.ResumeLayout(False)
		Me.PerformLayout()

	End Sub
	Friend WithEvents Label1 As Label
	Friend WithEvents Label9 As Label
	Friend WithEvents txtLength As TextBox
	Friend WithEvents Label8 As Label
	Friend WithEvents btnSave As Button
	Friend WithEvents btnCancel As Button
	Friend WithEvents txtPurpose As TextBox
	Friend WithEvents Label7 As Label
	Friend WithEvents dtpTime As DateTimePicker
	Friend WithEvents Label6 As Label
	Friend WithEvents dtpDate As DateTimePicker
	Friend WithEvents Label5 As Label
	Friend WithEvents lblApptID As Label
	Friend WithEvents Label4 As Label
	Friend WithEvents Label3 As Label
	Friend WithEvents lstDoctors As ListBox
	Friend WithEvents Label2 As Label
	Friend WithEvents Label10 As Label
	Friend WithEvents lstPatients As ListBox
	Friend WithEvents errLength As ErrorProvider
End Class
