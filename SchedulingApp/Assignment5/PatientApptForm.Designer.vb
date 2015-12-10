<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class PatientApptForm
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
		Me.Label1 = New System.Windows.Forms.Label()
		Me.Label2 = New System.Windows.Forms.Label()
		Me.Label3 = New System.Windows.Forms.Label()
		Me.Label4 = New System.Windows.Forms.Label()
		Me.Label5 = New System.Windows.Forms.Label()
		Me.Label7 = New System.Windows.Forms.Label()
		Me.Label8 = New System.Windows.Forms.Label()
		Me.lblPatientId = New System.Windows.Forms.Label()
		Me.Label11 = New System.Windows.Forms.Label()
		Me.txtFirstN = New System.Windows.Forms.TextBox()
		Me.txtLastN = New System.Windows.Forms.TextBox()
		Me.txtEmail = New System.Windows.Forms.TextBox()
		Me.Label6 = New System.Windows.Forms.Label()
		Me.Label9 = New System.Windows.Forms.Label()
		Me.Label10 = New System.Windows.Forms.Label()
		Me.Label12 = New System.Windows.Forms.Label()
		Me.txtPlanId = New System.Windows.Forms.TextBox()
		Me.txtSubId = New System.Windows.Forms.TextBox()
		Me.StatusStrip1 = New System.Windows.Forms.StatusStrip()
		Me.lblStatus = New System.Windows.Forms.ToolStripStatusLabel()
		Me.btnReturn = New System.Windows.Forms.Button()
		Me.btnClear = New System.Windows.Forms.Button()
		Me.txtInsPrvdr = New System.Windows.Forms.TextBox()
		Me.btnSave = New System.Windows.Forms.Button()
		Me.txtDOB = New System.Windows.Forms.TextBox()
		Me.cmbPlan = New System.Windows.Forms.ComboBox()
		Me.txtPhone = New System.Windows.Forms.TextBox()
		Me.StatusStrip1.SuspendLayout()
		Me.SuspendLayout()
		'
		'Label1
		'
		Me.Label1.AutoSize = True
		Me.Label1.Font = New System.Drawing.Font("Verdana", 11.25!, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.Label1.Location = New System.Drawing.Point(97, 9)
		Me.Label1.Name = "Label1"
		Me.Label1.Size = New System.Drawing.Size(163, 18)
		Me.Label1.TabIndex = 0
		Me.Label1.Text = "Personal Information"
		'
		'Label2
		'
		Me.Label2.AutoSize = True
		Me.Label2.Font = New System.Drawing.Font("Verdana", 11.25!, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.Label2.Location = New System.Drawing.Point(97, 232)
		Me.Label2.Name = "Label2"
		Me.Label2.Size = New System.Drawing.Size(172, 18)
		Me.Label2.TabIndex = 1
		Me.Label2.Text = "Insurance Information"
		'
		'Label3
		'
		Me.Label3.AutoSize = True
		Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.5!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.Label3.Location = New System.Drawing.Point(23, 42)
		Me.Label3.Name = "Label3"
		Me.Label3.Size = New System.Drawing.Size(69, 17)
		Me.Label3.TabIndex = 2
		Me.Label3.Text = "Patient ID"
		'
		'Label4
		'
		Me.Label4.AutoSize = True
		Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.5!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.Label4.Location = New System.Drawing.Point(23, 99)
		Me.Label4.Name = "Label4"
		Me.Label4.Size = New System.Drawing.Size(76, 17)
		Me.Label4.TabIndex = 3
		Me.Label4.Text = "First Name"
		'
		'Label5
		'
		Me.Label5.AutoSize = True
		Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.5!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.Label5.Location = New System.Drawing.Point(23, 163)
		Me.Label5.Name = "Label5"
		Me.Label5.Size = New System.Drawing.Size(76, 17)
		Me.Label5.TabIndex = 4
		Me.Label5.Text = "Last Name"
		'
		'Label7
		'
		Me.Label7.AutoSize = True
		Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.5!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.Label7.Location = New System.Drawing.Point(202, 99)
		Me.Label7.Name = "Label7"
		Me.Label7.Size = New System.Drawing.Size(103, 17)
		Me.Label7.TabIndex = 6
		Me.Label7.Text = "Phone Number"
		'
		'Label8
		'
		Me.Label8.AutoSize = True
		Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.5!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.Label8.Location = New System.Drawing.Point(202, 163)
		Me.Label8.Name = "Label8"
		Me.Label8.Size = New System.Drawing.Size(42, 17)
		Me.Label8.TabIndex = 7
		Me.Label8.Text = "Email"
		'
		'lblPatientId
		'
		Me.lblPatientId.BackColor = System.Drawing.SystemColors.GradientInactiveCaption
		Me.lblPatientId.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
		Me.lblPatientId.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.lblPatientId.Location = New System.Drawing.Point(26, 60)
		Me.lblPatientId.Name = "lblPatientId"
		Me.lblPatientId.Size = New System.Drawing.Size(73, 21)
		Me.lblPatientId.TabIndex = 8
		Me.lblPatientId.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
		'
		'Label11
		'
		Me.Label11.AutoSize = True
		Me.Label11.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.5!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.Label11.Location = New System.Drawing.Point(202, 42)
		Me.Label11.Name = "Label11"
		Me.Label11.Size = New System.Drawing.Size(87, 17)
		Me.Label11.TabIndex = 14
		Me.Label11.Text = "Date of Birth"
		Me.Label11.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
		'
		'txtFirstN
		'
		Me.txtFirstN.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.txtFirstN.Location = New System.Drawing.Point(26, 120)
		Me.txtFirstN.Name = "txtFirstN"
		Me.txtFirstN.Size = New System.Drawing.Size(129, 21)
		Me.txtFirstN.TabIndex = 16
		'
		'txtLastN
		'
		Me.txtLastN.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.txtLastN.Location = New System.Drawing.Point(26, 183)
		Me.txtLastN.Name = "txtLastN"
		Me.txtLastN.Size = New System.Drawing.Size(129, 21)
		Me.txtLastN.TabIndex = 18
		'
		'txtEmail
		'
		Me.txtEmail.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.txtEmail.Location = New System.Drawing.Point(205, 183)
		Me.txtEmail.Name = "txtEmail"
		Me.txtEmail.Size = New System.Drawing.Size(129, 21)
		Me.txtEmail.TabIndex = 19
		'
		'Label6
		'
		Me.Label6.AutoSize = True
		Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.5!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.Label6.Location = New System.Drawing.Point(23, 260)
		Me.Label6.Name = "Label6"
		Me.Label6.Size = New System.Drawing.Size(61, 17)
		Me.Label6.TabIndex = 21
		Me.Label6.Text = "Provider"
		'
		'Label9
		'
		Me.Label9.AutoSize = True
		Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.5!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.Label9.Location = New System.Drawing.Point(20, 315)
		Me.Label9.Name = "Label9"
		Me.Label9.Size = New System.Drawing.Size(93, 17)
		Me.Label9.TabIndex = 22
		Me.Label9.Text = "Subscriber ID"
		'
		'Label10
		'
		Me.Label10.AutoSize = True
		Me.Label10.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.5!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.Label10.Location = New System.Drawing.Point(202, 315)
		Me.Label10.Name = "Label10"
		Me.Label10.Size = New System.Drawing.Size(53, 17)
		Me.Label10.TabIndex = 23
		Me.Label10.Text = "Plan ID"
		'
		'Label12
		'
		Me.Label12.AutoSize = True
		Me.Label12.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.5!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.Label12.Location = New System.Drawing.Point(202, 260)
		Me.Label12.Name = "Label12"
		Me.Label12.Size = New System.Drawing.Size(36, 17)
		Me.Label12.TabIndex = 24
		Me.Label12.Text = "Plan"
		'
		'txtPlanId
		'
		Me.txtPlanId.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.txtPlanId.Location = New System.Drawing.Point(205, 335)
		Me.txtPlanId.Name = "txtPlanId"
		Me.txtPlanId.Size = New System.Drawing.Size(72, 21)
		Me.txtPlanId.TabIndex = 27
		'
		'txtSubId
		'
		Me.txtSubId.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.txtSubId.Location = New System.Drawing.Point(23, 335)
		Me.txtSubId.Name = "txtSubId"
		Me.txtSubId.Size = New System.Drawing.Size(73, 21)
		Me.txtSubId.TabIndex = 28
		'
		'StatusStrip1
		'
		Me.StatusStrip1.Font = New System.Drawing.Font("Segoe UI", 10.0!)
		Me.StatusStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.lblStatus})
		Me.StatusStrip1.Location = New System.Drawing.Point(0, 435)
		Me.StatusStrip1.Name = "StatusStrip1"
		Me.StatusStrip1.Size = New System.Drawing.Size(358, 22)
		Me.StatusStrip1.TabIndex = 29
		Me.StatusStrip1.Text = "StatusStrip1"
		'
		'lblStatus
		'
		Me.lblStatus.Font = New System.Drawing.Font("Segoe UI", 9.5!)
		Me.lblStatus.Name = "lblStatus"
		Me.lblStatus.Size = New System.Drawing.Size(0, 17)
		'
		'btnReturn
		'
		Me.btnReturn.FlatStyle = System.Windows.Forms.FlatStyle.System
		Me.btnReturn.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.5!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.btnReturn.Location = New System.Drawing.Point(19, 384)
		Me.btnReturn.Name = "btnReturn"
		Me.btnReturn.Size = New System.Drawing.Size(103, 33)
		Me.btnReturn.TabIndex = 31
		Me.btnReturn.Text = "Close"
		Me.btnReturn.UseVisualStyleBackColor = True
		'
		'btnClear
		'
		Me.btnClear.FlatStyle = System.Windows.Forms.FlatStyle.System
		Me.btnClear.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.5!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.btnClear.Location = New System.Drawing.Point(128, 384)
		Me.btnClear.Name = "btnClear"
		Me.btnClear.Size = New System.Drawing.Size(106, 33)
		Me.btnClear.TabIndex = 32
		Me.btnClear.Text = "Clear"
		Me.btnClear.UseVisualStyleBackColor = True
		'
		'txtInsPrvdr
		'
		Me.txtInsPrvdr.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.txtInsPrvdr.Location = New System.Drawing.Point(23, 280)
		Me.txtInsPrvdr.Name = "txtInsPrvdr"
		Me.txtInsPrvdr.Size = New System.Drawing.Size(129, 21)
		Me.txtInsPrvdr.TabIndex = 34
		'
		'btnSave
		'
		Me.btnSave.FlatStyle = System.Windows.Forms.FlatStyle.System
		Me.btnSave.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.5!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.btnSave.Location = New System.Drawing.Point(240, 384)
		Me.btnSave.Name = "btnSave"
		Me.btnSave.Size = New System.Drawing.Size(99, 33)
		Me.btnSave.TabIndex = 35
		Me.btnSave.Text = "Save"
		Me.btnSave.UseVisualStyleBackColor = True
		'
		'txtDOB
		'
		Me.txtDOB.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.txtDOB.Location = New System.Drawing.Point(205, 62)
		Me.txtDOB.Name = "txtDOB"
		Me.txtDOB.Size = New System.Drawing.Size(129, 21)
		Me.txtDOB.TabIndex = 20
		'
		'cmbPlan
		'
		Me.cmbPlan.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
		Me.cmbPlan.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.cmbPlan.FormattingEnabled = True
		Me.cmbPlan.Items.AddRange(New Object() {"HMO", "PPO"})
		Me.cmbPlan.Location = New System.Drawing.Point(205, 280)
		Me.cmbPlan.Name = "cmbPlan"
		Me.cmbPlan.Size = New System.Drawing.Size(128, 23)
		Me.cmbPlan.TabIndex = 33
		'
		'txtPhone
		'
		Me.txtPhone.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.txtPhone.Location = New System.Drawing.Point(205, 120)
		Me.txtPhone.Name = "txtPhone"
		Me.txtPhone.Size = New System.Drawing.Size(129, 21)
		Me.txtPhone.TabIndex = 36
		'
		'PatientAppt
		'
		Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
		Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
		Me.BackColor = System.Drawing.SystemColors.GradientActiveCaption
		Me.ClientSize = New System.Drawing.Size(358, 457)
		Me.Controls.Add(Me.txtPhone)
		Me.Controls.Add(Me.btnSave)
		Me.Controls.Add(Me.txtInsPrvdr)
		Me.Controls.Add(Me.cmbPlan)
		Me.Controls.Add(Me.btnClear)
		Me.Controls.Add(Me.btnReturn)
		Me.Controls.Add(Me.StatusStrip1)
		Me.Controls.Add(Me.txtSubId)
		Me.Controls.Add(Me.txtPlanId)
		Me.Controls.Add(Me.Label12)
		Me.Controls.Add(Me.Label10)
		Me.Controls.Add(Me.Label9)
		Me.Controls.Add(Me.Label6)
		Me.Controls.Add(Me.txtDOB)
		Me.Controls.Add(Me.txtEmail)
		Me.Controls.Add(Me.txtLastN)
		Me.Controls.Add(Me.txtFirstN)
		Me.Controls.Add(Me.Label11)
		Me.Controls.Add(Me.lblPatientId)
		Me.Controls.Add(Me.Label8)
		Me.Controls.Add(Me.Label7)
		Me.Controls.Add(Me.Label5)
		Me.Controls.Add(Me.Label4)
		Me.Controls.Add(Me.Label3)
		Me.Controls.Add(Me.Label2)
		Me.Controls.Add(Me.Label1)
		Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D
		Me.Name = "PatientAppt"
		Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
		Me.Text = " Patient Documentation"
		Me.StatusStrip1.ResumeLayout(False)
		Me.StatusStrip1.PerformLayout()
		Me.ResumeLayout(False)
		Me.PerformLayout()

	End Sub

	Friend WithEvents Label1 As Label
	Friend WithEvents Label2 As Label
	Friend WithEvents Label3 As Label
	Friend WithEvents Label4 As Label
	Friend WithEvents Label5 As Label
	Friend WithEvents Label7 As Label
	Friend WithEvents Label8 As Label
	Friend WithEvents lblPatientId As Label
	Friend WithEvents Label11 As Label
	Friend WithEvents txtFirstN As TextBox
	Friend WithEvents txtLastN As TextBox
	Friend WithEvents txtEmail As TextBox
	Friend WithEvents Label6 As Label
	Friend WithEvents Label9 As Label
	Friend WithEvents Label10 As Label
	Friend WithEvents Label12 As Label
	Friend WithEvents txtPlanId As TextBox
	Friend WithEvents txtSubId As TextBox
	Friend WithEvents StatusStrip1 As StatusStrip
	Friend WithEvents lblStatus As ToolStripStatusLabel
	Friend WithEvents btnReturn As Button
	Friend WithEvents btnClear As Button
	Friend WithEvents txtInsPrvdr As TextBox
	Friend WithEvents btnSave As Button
	Friend WithEvents txtDOB As TextBox
	Friend WithEvents cmbPlan As ComboBox
	Friend WithEvents txtPhone As TextBox
End Class
