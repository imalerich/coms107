<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
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
		Me.GenderInfo = New System.Windows.Forms.Label()
		Me.GPAInfo = New System.Windows.Forms.Label()
		Me.AvgGPABox = New System.Windows.Forms.GroupBox()
		Me.famelStudentsInfo = New System.Windows.Forms.Label()
		Me.maleStudentsInfo = New System.Windows.Forms.Label()
		Me.allStudentsInfo = New System.Windows.Forms.Label()
		Me.calcButton = New System.Windows.Forms.Button()
		Me.exitButton = New System.Windows.Forms.Button()
		Me.genderListBox = New System.Windows.Forms.ListBox()
		Me.gpaListBox = New System.Windows.Forms.ListBox()
		Me.allStudentsLabel = New System.Windows.Forms.Label()
		Me.maleStudentsLabel = New System.Windows.Forms.Label()
		Me.femaleStudentsLabel = New System.Windows.Forms.Label()
		Me.AvgGPABox.SuspendLayout()
		Me.SuspendLayout()
		'
		'GenderInfo
		'
		Me.GenderInfo.AutoSize = True
		Me.GenderInfo.Location = New System.Drawing.Point(13, 13)
		Me.GenderInfo.Name = "GenderInfo"
		Me.GenderInfo.Size = New System.Drawing.Size(45, 13)
		Me.GenderInfo.TabIndex = 0
		Me.GenderInfo.Text = "Gender:"
		'
		'GPAInfo
		'
		Me.GPAInfo.AutoSize = True
		Me.GPAInfo.Location = New System.Drawing.Point(98, 13)
		Me.GPAInfo.Name = "GPAInfo"
		Me.GPAInfo.Size = New System.Drawing.Size(32, 13)
		Me.GPAInfo.TabIndex = 1
		Me.GPAInfo.Text = "GPA:"
		'
		'AvgGPABox
		'
		Me.AvgGPABox.Controls.Add(Me.femaleStudentsLabel)
		Me.AvgGPABox.Controls.Add(Me.maleStudentsLabel)
		Me.AvgGPABox.Controls.Add(Me.allStudentsLabel)
		Me.AvgGPABox.Controls.Add(Me.famelStudentsInfo)
		Me.AvgGPABox.Controls.Add(Me.maleStudentsInfo)
		Me.AvgGPABox.Controls.Add(Me.allStudentsInfo)
		Me.AvgGPABox.Location = New System.Drawing.Point(16, 92)
		Me.AvgGPABox.Name = "AvgGPABox"
		Me.AvgGPABox.Size = New System.Drawing.Size(200, 106)
		Me.AvgGPABox.TabIndex = 2
		Me.AvgGPABox.TabStop = False
		Me.AvgGPABox.Text = "Average GPA"
		'
		'famelStudentsInfo
		'
		Me.famelStudentsInfo.AutoSize = True
		Me.famelStudentsInfo.Location = New System.Drawing.Point(9, 78)
		Me.famelStudentsInfo.Name = "famelStudentsInfo"
		Me.famelStudentsInfo.Size = New System.Drawing.Size(87, 13)
		Me.famelStudentsInfo.TabIndex = 2
		Me.famelStudentsInfo.Text = "Female students:"
		'
		'maleStudentsInfo
		'
		Me.maleStudentsInfo.AccessibleRole = System.Windows.Forms.AccessibleRole.None
		Me.maleStudentsInfo.AutoSize = True
		Me.maleStudentsInfo.Location = New System.Drawing.Point(20, 50)
		Me.maleStudentsInfo.Name = "maleStudentsInfo"
		Me.maleStudentsInfo.Size = New System.Drawing.Size(76, 13)
		Me.maleStudentsInfo.TabIndex = 1
		Me.maleStudentsInfo.Text = "Male students:"
		'
		'allStudentsInfo
		'
		Me.allStudentsInfo.AutoSize = True
		Me.allStudentsInfo.Location = New System.Drawing.Point(32, 22)
		Me.allStudentsInfo.Name = "allStudentsInfo"
		Me.allStudentsInfo.Size = New System.Drawing.Size(64, 13)
		Me.allStudentsInfo.TabIndex = 0
		Me.allStudentsInfo.Text = "All students:"
		'
		'calcButton
		'
		Me.calcButton.Location = New System.Drawing.Point(222, 30)
		Me.calcButton.Name = "calcButton"
		Me.calcButton.Size = New System.Drawing.Size(99, 36)
		Me.calcButton.TabIndex = 3
		Me.calcButton.Text = "Calculate"
		Me.calcButton.UseVisualStyleBackColor = True
		'
		'exitButton
		'
		Me.exitButton.Location = New System.Drawing.Point(222, 72)
		Me.exitButton.Name = "exitButton"
		Me.exitButton.Size = New System.Drawing.Size(99, 33)
		Me.exitButton.TabIndex = 4
		Me.exitButton.Text = "Exit"
		Me.exitButton.UseVisualStyleBackColor = True
		'
		'genderListBox
		'
		Me.genderListBox.FormattingEnabled = True
		Me.genderListBox.Items.AddRange(New Object() {"F", "M"})
		Me.genderListBox.Location = New System.Drawing.Point(16, 29)
		Me.genderListBox.Name = "genderListBox"
		Me.genderListBox.Size = New System.Drawing.Size(71, 30)
		Me.genderListBox.TabIndex = 5
		'
		'gpaListBox
		'
		Me.gpaListBox.FormattingEnabled = True
		Me.gpaListBox.Location = New System.Drawing.Point(94, 30)
		Me.gpaListBox.Name = "gpaListBox"
		Me.gpaListBox.Size = New System.Drawing.Size(122, 56)
		Me.gpaListBox.TabIndex = 6
		'
		'allStudentsLabel
		'
		Me.allStudentsLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
		Me.allStudentsLabel.Location = New System.Drawing.Point(102, 17)
		Me.allStudentsLabel.Name = "allStudentsLabel"
		Me.allStudentsLabel.Size = New System.Drawing.Size(92, 23)
		Me.allStudentsLabel.TabIndex = 3
		Me.allStudentsLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
		'
		'maleStudentsLabel
		'
		Me.maleStudentsLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
		Me.maleStudentsLabel.Location = New System.Drawing.Point(102, 45)
		Me.maleStudentsLabel.Name = "maleStudentsLabel"
		Me.maleStudentsLabel.Size = New System.Drawing.Size(92, 23)
		Me.maleStudentsLabel.TabIndex = 4
		Me.maleStudentsLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
		'
		'femaleStudentsLabel
		'
		Me.femaleStudentsLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
		Me.femaleStudentsLabel.Location = New System.Drawing.Point(102, 73)
		Me.femaleStudentsLabel.Name = "femaleStudentsLabel"
		Me.femaleStudentsLabel.Size = New System.Drawing.Size(92, 23)
		Me.femaleStudentsLabel.TabIndex = 5
		Me.femaleStudentsLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
		'
		'Form1
		'
		Me.AcceptButton = Me.calcButton
		Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
		Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
		Me.ClientSize = New System.Drawing.Size(330, 210)
		Me.Controls.Add(Me.gpaListBox)
		Me.Controls.Add(Me.genderListBox)
		Me.Controls.Add(Me.exitButton)
		Me.Controls.Add(Me.calcButton)
		Me.Controls.Add(Me.AvgGPABox)
		Me.Controls.Add(Me.GPAInfo)
		Me.Controls.Add(Me.GenderInfo)
		Me.Name = "Form1"
		Me.Text = "GPA Calculator"
		Me.AvgGPABox.ResumeLayout(False)
		Me.AvgGPABox.PerformLayout()
		Me.ResumeLayout(False)
		Me.PerformLayout()

	End Sub

	Friend WithEvents GenderInfo As Label
	Friend WithEvents GPAInfo As Label
	Friend WithEvents AvgGPABox As GroupBox
	Friend WithEvents famelStudentsInfo As Label
	Friend WithEvents maleStudentsInfo As Label
	Friend WithEvents allStudentsInfo As Label
	Friend WithEvents calcButton As Button
	Friend WithEvents exitButton As Button
	Friend WithEvents genderListBox As ListBox
	Friend WithEvents gpaListBox As ListBox
	Friend WithEvents femaleStudentsLabel As Label
	Friend WithEvents maleStudentsLabel As Label
	Friend WithEvents allStudentsLabel As Label
End Class
