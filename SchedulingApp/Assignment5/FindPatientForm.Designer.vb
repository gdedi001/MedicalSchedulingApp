<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FindPatientForm
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
		Me.Label2 = New System.Windows.Forms.Label()
		Me.Label3 = New System.Windows.Forms.Label()
		Me.Label4 = New System.Windows.Forms.Label()
		Me.txtFirstN = New System.Windows.Forms.TextBox()
		Me.txtLastN = New System.Windows.Forms.TextBox()
		Me.txtDOB = New System.Windows.Forms.TextBox()
		Me.Label5 = New System.Windows.Forms.Label()
		Me.chkLastN = New System.Windows.Forms.CheckBox()
		Me.btnSearch = New System.Windows.Forms.Button()
		Me.btnClose = New System.Windows.Forms.Button()
		Me.StatusStrip1 = New System.Windows.Forms.StatusStrip()
		Me.lblStatus = New System.Windows.Forms.ToolStripStatusLabel()
		Me.errorFirstN = New System.Windows.Forms.ErrorProvider(Me.components)
		Me.errorLastN = New System.Windows.Forms.ErrorProvider(Me.components)
		Me.errorDOB = New System.Windows.Forms.ErrorProvider(Me.components)
		Me.StatusStrip1.SuspendLayout()
		CType(Me.errorFirstN, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.errorLastN, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.errorDOB, System.ComponentModel.ISupportInitialize).BeginInit()
		Me.SuspendLayout()
		'
		'Label1
		'
		Me.Label1.AutoSize = True
		Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, CType((System.Drawing.FontStyle.Italic Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.Label1.Location = New System.Drawing.Point(130, 9)
		Me.Label1.Name = "Label1"
		Me.Label1.Size = New System.Drawing.Size(153, 29)
		Me.Label1.TabIndex = 0
		Me.Label1.Text = "Find Patients"
		'
		'Label2
		'
		Me.Label2.AutoSize = True
		Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.5!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.Label2.Location = New System.Drawing.Point(43, 69)
		Me.Label2.Name = "Label2"
		Me.Label2.Size = New System.Drawing.Size(76, 16)
		Me.Label2.TabIndex = 1
		Me.Label2.Text = "First Name:"
		'
		'Label3
		'
		Me.Label3.AutoSize = True
		Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.5!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.Label3.Location = New System.Drawing.Point(43, 123)
		Me.Label3.Name = "Label3"
		Me.Label3.Size = New System.Drawing.Size(76, 16)
		Me.Label3.TabIndex = 2
		Me.Label3.Text = "Last Name:"
		'
		'Label4
		'
		Me.Label4.AutoSize = True
		Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.5!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.Label4.Location = New System.Drawing.Point(35, 178)
		Me.Label4.Name = "Label4"
		Me.Label4.Size = New System.Drawing.Size(83, 16)
		Me.Label4.TabIndex = 3
		Me.Label4.Text = "Date of Birth:"
		'
		'txtFirstN
		'
		Me.txtFirstN.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.5!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.txtFirstN.Location = New System.Drawing.Point(124, 66)
		Me.txtFirstN.Name = "txtFirstN"
		Me.txtFirstN.Size = New System.Drawing.Size(208, 22)
		Me.txtFirstN.TabIndex = 4
		'
		'txtLastN
		'
		Me.txtLastN.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.5!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.txtLastN.Location = New System.Drawing.Point(125, 120)
		Me.txtLastN.Name = "txtLastN"
		Me.txtLastN.Size = New System.Drawing.Size(208, 22)
		Me.txtLastN.TabIndex = 5
		'
		'txtDOB
		'
		Me.txtDOB.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.5!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.txtDOB.Location = New System.Drawing.Point(125, 175)
		Me.txtDOB.Name = "txtDOB"
		Me.txtDOB.Size = New System.Drawing.Size(124, 22)
		Me.txtDOB.TabIndex = 6
		'
		'Label5
		'
		Me.Label5.AutoSize = True
		Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.5!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.Label5.Location = New System.Drawing.Point(255, 178)
		Me.Label5.Name = "Label5"
		Me.Label5.Size = New System.Drawing.Size(90, 16)
		Me.Label5.TabIndex = 7
		Me.Label5.Text = "(mm/dd/yyyy)"
		'
		'chkLastN
		'
		Me.chkLastN.AutoSize = True
		Me.chkLastN.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.5!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.chkLastN.Location = New System.Drawing.Point(125, 219)
		Me.chkLastN.Name = "chkLastN"
		Me.chkLastN.Size = New System.Drawing.Size(177, 20)
		Me.chkLastN.TabIndex = 8
		Me.chkLastN.Text = "Search only by last name"
		Me.chkLastN.UseVisualStyleBackColor = True
		'
		'btnSearch
		'
		Me.btnSearch.BackColor = System.Drawing.Color.Lime
		Me.btnSearch.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.5!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.btnSearch.Location = New System.Drawing.Point(65, 260)
		Me.btnSearch.Name = "btnSearch"
		Me.btnSearch.Size = New System.Drawing.Size(95, 31)
		Me.btnSearch.TabIndex = 9
		Me.btnSearch.Text = "Search"
		Me.btnSearch.UseVisualStyleBackColor = False
		'
		'btnClose
		'
		Me.btnClose.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer))
		Me.btnClose.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.5!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.btnClose.Location = New System.Drawing.Point(250, 260)
		Me.btnClose.Name = "btnClose"
		Me.btnClose.Size = New System.Drawing.Size(95, 31)
		Me.btnClose.TabIndex = 10
		Me.btnClose.Text = "Close"
		Me.btnClose.UseVisualStyleBackColor = False
		'
		'StatusStrip1
		'
		Me.StatusStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.lblStatus})
		Me.StatusStrip1.Location = New System.Drawing.Point(0, 314)
		Me.StatusStrip1.Name = "StatusStrip1"
		Me.StatusStrip1.Size = New System.Drawing.Size(412, 22)
		Me.StatusStrip1.TabIndex = 11
		Me.StatusStrip1.Text = "StatusStrip1"
		'
		'lblStatus
		'
		Me.lblStatus.Name = "lblStatus"
		Me.lblStatus.Size = New System.Drawing.Size(0, 17)
		'
		'errorFirstN
		'
		Me.errorFirstN.ContainerControl = Me
		'
		'errorLastN
		'
		Me.errorLastN.ContainerControl = Me
		'
		'errorDOB
		'
		Me.errorDOB.ContainerControl = Me
		'
		'FindPatient
		'
		Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
		Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
		Me.BackColor = System.Drawing.SystemColors.GradientActiveCaption
		Me.ClientSize = New System.Drawing.Size(412, 336)
		Me.Controls.Add(Me.StatusStrip1)
		Me.Controls.Add(Me.btnClose)
		Me.Controls.Add(Me.btnSearch)
		Me.Controls.Add(Me.chkLastN)
		Me.Controls.Add(Me.Label5)
		Me.Controls.Add(Me.txtDOB)
		Me.Controls.Add(Me.txtLastN)
		Me.Controls.Add(Me.txtFirstN)
		Me.Controls.Add(Me.Label4)
		Me.Controls.Add(Me.Label3)
		Me.Controls.Add(Me.Label2)
		Me.Controls.Add(Me.Label1)
		Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D
		Me.Name = "FindPatient"
		Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
		Me.Text = "Find Patient"
		Me.StatusStrip1.ResumeLayout(False)
		Me.StatusStrip1.PerformLayout()
		CType(Me.errorFirstN, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.errorLastN, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.errorDOB, System.ComponentModel.ISupportInitialize).EndInit()
		Me.ResumeLayout(False)
		Me.PerformLayout()

	End Sub

	Friend WithEvents Label1 As Label
	Friend WithEvents Label2 As Label
	Friend WithEvents Label3 As Label
	Friend WithEvents Label4 As Label
	Friend WithEvents txtFirstN As TextBox
	Friend WithEvents txtLastN As TextBox
	Friend WithEvents txtDOB As TextBox
	Friend WithEvents Label5 As Label
	Friend WithEvents chkLastN As CheckBox
	Friend WithEvents btnSearch As Button
	Friend WithEvents btnClose As Button
	Friend WithEvents StatusStrip1 As StatusStrip
	Friend WithEvents lblStatus As ToolStripStatusLabel
	Friend WithEvents errorFirstN As ErrorProvider
	Friend WithEvents errorLastN As ErrorProvider
	Friend WithEvents errorDOB As ErrorProvider
End Class
