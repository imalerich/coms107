<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Public Class MainForm
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overloads Overrides Sub Dispose(ByVal disposing As Boolean)
        If disposing AndAlso components IsNot Nothing Then
            components.Dispose()
        End If
        MyBase.Dispose(disposing)
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.exitButton = New System.Windows.Forms.Button()
        Me.createButton = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.reportTextBox = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.salesAmtTextBox = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.idListBox = New System.Windows.Forms.ListBox()
        Me.addButton = New System.Windows.Forms.Button()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'exitButton
        '
        Me.exitButton.Location = New System.Drawing.Point(197, 230)
        Me.exitButton.Margin = New System.Windows.Forms.Padding(2)
        Me.exitButton.Name = "exitButton"
        Me.exitButton.Size = New System.Drawing.Size(96, 24)
        Me.exitButton.TabIndex = 2
        Me.exitButton.Text = "E&xit"
        '
        'createButton
        '
        Me.createButton.Location = New System.Drawing.Point(197, 202)
        Me.createButton.Margin = New System.Windows.Forms.Padding(2)
        Me.createButton.Name = "createButton"
        Me.createButton.Size = New System.Drawing.Size(96, 24)
        Me.createButton.TabIndex = 1
        Me.createButton.Text = "&Create Report"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(36, 180)
        Me.Label1.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(68, 15)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "Sales totals:"
        '
        'reportTextBox
        '
        Me.reportTextBox.Font = New System.Drawing.Font("Courier New", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.reportTextBox.Location = New System.Drawing.Point(39, 202)
        Me.reportTextBox.Margin = New System.Windows.Forms.Padding(2)
        Me.reportTextBox.Multiline = True
        Me.reportTextBox.Name = "reportTextBox"
        Me.reportTextBox.ReadOnly = True
        Me.reportTextBox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.reportTextBox.Size = New System.Drawing.Size(154, 139)
        Me.reportTextBox.TabIndex = 4
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(86, 19)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(36, 15)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "&Sales:"
        '
        'salesAmtTextBox
        '
        Me.salesAmtTextBox.Location = New System.Drawing.Point(89, 37)
        Me.salesAmtTextBox.Name = "salesAmtTextBox"
        Me.salesAmtTextBox.Size = New System.Drawing.Size(69, 23)
        Me.salesAmtTextBox.TabIndex = 3
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(24, 19)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(50, 15)
        Me.Label3.TabIndex = 0
        Me.Label3.Text = "Sales &ID:"
        '
        'idListBox
        '
        Me.idListBox.FormattingEnabled = True
        Me.idListBox.ItemHeight = 15
        Me.idListBox.Location = New System.Drawing.Point(27, 37)
        Me.idListBox.Name = "idListBox"
        Me.idListBox.Size = New System.Drawing.Size(46, 79)
        Me.idListBox.TabIndex = 1
        '
        'addButton
        '
        Me.addButton.Location = New System.Drawing.Point(179, 37)
        Me.addButton.Name = "addButton"
        Me.addButton.Size = New System.Drawing.Size(96, 24)
        Me.addButton.TabIndex = 4
        Me.addButton.Text = "&Add to Totals"
        Me.addButton.UseVisualStyleBackColor = True
        '
        'Panel1
        '
        Me.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Panel1.Controls.Add(Me.Label2)
        Me.Panel1.Controls.Add(Me.addButton)
        Me.Panel1.Controls.Add(Me.salesAmtTextBox)
        Me.Panel1.Controls.Add(Me.idListBox)
        Me.Panel1.Controls.Add(Me.Label3)
        Me.Panel1.Location = New System.Drawing.Point(12, 2)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(303, 134)
        Me.Panel1.TabIndex = 0
        '
        'MainForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(329, 362)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.reportTextBox)
        Me.Controls.Add(Me.exitButton)
        Me.Controls.Add(Me.createButton)
        Me.Controls.Add(Me.Label1)
        Me.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MaximizeBox = False
        Me.Name = "MainForm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "JM Sales"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents exitButton As System.Windows.Forms.Button
    Friend WithEvents createButton As System.Windows.Forms.Button
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents reportTextBox As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents salesAmtTextBox As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents idListBox As System.Windows.Forms.ListBox
    Friend WithEvents addButton As System.Windows.Forms.Button
    Friend WithEvents Panel1 As System.Windows.Forms.Panel

End Class
