<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class ViewAppointmentsForm
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
		Me.dgvAppointments = New System.Windows.Forms.DataGridView()
		Me.btnEdit = New System.Windows.Forms.LinkLabel()
		Me.chkDoctor = New System.Windows.Forms.CheckBox()
		Me.cmbDoctors = New System.Windows.Forms.ComboBox()
		CType(Me.dgvAppointments, System.ComponentModel.ISupportInitialize).BeginInit()
		Me.SuspendLayout()
		'
		'dgvAppointments
		'
		Me.dgvAppointments.AllowUserToAddRows = False
		Me.dgvAppointments.AllowUserToDeleteRows = False
		Me.dgvAppointments.AllowUserToResizeColumns = False
		Me.dgvAppointments.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
		Me.dgvAppointments.Location = New System.Drawing.Point(1, 66)
		Me.dgvAppointments.Name = "dgvAppointments"
		Me.dgvAppointments.ReadOnly = True
		Me.dgvAppointments.RowHeadersVisible = False
		Me.dgvAppointments.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
		Me.dgvAppointments.Size = New System.Drawing.Size(721, 150)
		Me.dgvAppointments.TabIndex = 0
		'
		'btnEdit
		'
		Me.btnEdit.AutoSize = True
		Me.btnEdit.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.5!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.btnEdit.Location = New System.Drawing.Point(305, 231)
		Me.btnEdit.Name = "btnEdit"
		Me.btnEdit.Size = New System.Drawing.Size(115, 17)
		Me.btnEdit.TabIndex = 1
		Me.btnEdit.TabStop = True
		Me.btnEdit.Text = "Edit Appointment"
		'
		'chkDoctor
		'
		Me.chkDoctor.AutoSize = True
		Me.chkDoctor.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.5!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.chkDoctor.Location = New System.Drawing.Point(12, 12)
		Me.chkDoctor.Name = "chkDoctor"
		Me.chkDoctor.Size = New System.Drawing.Size(113, 20)
		Me.chkDoctor.TabIndex = 2
		Me.chkDoctor.Text = "Search Doctor"
		Me.chkDoctor.UseVisualStyleBackColor = True
		'
		'cmbDoctors
		'
		Me.cmbDoctors.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
		Me.cmbDoctors.FormattingEnabled = True
		Me.cmbDoctors.Location = New System.Drawing.Point(132, 10)
		Me.cmbDoctors.Name = "cmbDoctors"
		Me.cmbDoctors.Size = New System.Drawing.Size(151, 21)
		Me.cmbDoctors.TabIndex = 3
		'
		'ViewAppointmentsForm
		'
		Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
		Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
		Me.ClientSize = New System.Drawing.Size(721, 257)
		Me.Controls.Add(Me.cmbDoctors)
		Me.Controls.Add(Me.chkDoctor)
		Me.Controls.Add(Me.btnEdit)
		Me.Controls.Add(Me.dgvAppointments)
		Me.Name = "ViewAppointmentsForm"
		Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
		Me.Text = "View Appointments"
		CType(Me.dgvAppointments, System.ComponentModel.ISupportInitialize).EndInit()
		Me.ResumeLayout(False)
		Me.PerformLayout()

	End Sub

	Friend WithEvents dgvAppointments As DataGridView
	Friend WithEvents btnEdit As LinkLabel
	Friend WithEvents chkDoctor As CheckBox
	Friend WithEvents cmbDoctors As ComboBox
End Class
