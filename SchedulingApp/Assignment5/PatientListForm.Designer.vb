<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class PatientListForm
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
		Me.lblEdit = New System.Windows.Forms.LinkLabel()
		Me.lstPatients = New System.Windows.Forms.ListBox()
		Me.Label2 = New System.Windows.Forms.Label()
		Me.ToolStrip = New System.Windows.Forms.StatusStrip()
		Me.lblStatus = New System.Windows.Forms.ToolStripStatusLabel()
		Me.ToolStrip.SuspendLayout()
		Me.SuspendLayout()
		'
		'Label1
		'
		Me.Label1.AutoSize = True
		Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, CType((System.Drawing.FontStyle.Italic Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.Label1.Location = New System.Drawing.Point(56, 9)
		Me.Label1.Name = "Label1"
		Me.Label1.Size = New System.Drawing.Size(254, 29)
		Me.Label1.TabIndex = 0
		Me.Label1.Text = "Medical Patient Listing"
		'
		'lblEdit
		'
		Me.lblEdit.AutoSize = True
		Me.lblEdit.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.lblEdit.Location = New System.Drawing.Point(134, 297)
		Me.lblEdit.Name = "lblEdit"
		Me.lblEdit.Size = New System.Drawing.Size(106, 17)
		Me.lblEdit.TabIndex = 1
		Me.lblEdit.TabStop = True
		Me.lblEdit.Text = "Edit patient info"
		'
		'lstPatients
		'
		Me.lstPatients.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.lstPatients.FormattingEnabled = True
		Me.lstPatients.ItemHeight = 16
		Me.lstPatients.Location = New System.Drawing.Point(81, 89)
		Me.lstPatients.Name = "lstPatients"
		Me.lstPatients.Size = New System.Drawing.Size(210, 180)
		Me.lstPatients.TabIndex = 2
		'
		'Label2
		'
		Me.Label2.AutoSize = True
		Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.Label2.Location = New System.Drawing.Point(21, 48)
		Me.Label2.Name = "Label2"
		Me.Label2.Size = New System.Drawing.Size(333, 17)
		Me.Label2.TabIndex = 3
		Me.Label2.Text = "View current patients or select to modify information"
		'
		'ToolStrip
		'
		Me.ToolStrip.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.lblStatus})
		Me.ToolStrip.Location = New System.Drawing.Point(0, 324)
		Me.ToolStrip.Name = "ToolStrip"
		Me.ToolStrip.Size = New System.Drawing.Size(382, 22)
		Me.ToolStrip.TabIndex = 4
		'
		'lblStatus
		'
		Me.lblStatus.Name = "lblStatus"
		Me.lblStatus.Size = New System.Drawing.Size(0, 17)
		'
		'PatientList
		'
		Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
		Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
		Me.BackColor = System.Drawing.SystemColors.GradientActiveCaption
		Me.ClientSize = New System.Drawing.Size(382, 346)
		Me.Controls.Add(Me.ToolStrip)
		Me.Controls.Add(Me.Label2)
		Me.Controls.Add(Me.lstPatients)
		Me.Controls.Add(Me.lblEdit)
		Me.Controls.Add(Me.Label1)
		Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D
		Me.Name = "PatientList"
		Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
		Me.Text = "Patient Listings"
		Me.ToolStrip.ResumeLayout(False)
		Me.ToolStrip.PerformLayout()
		Me.ResumeLayout(False)
		Me.PerformLayout()

	End Sub

	Friend WithEvents Label1 As Label
	Friend WithEvents lblEdit As LinkLabel
	Friend WithEvents lstPatients As ListBox
	Friend WithEvents Label2 As Label
	Friend WithEvents ToolStrip As StatusStrip
	Friend WithEvents lblStatus As ToolStripStatusLabel
End Class
