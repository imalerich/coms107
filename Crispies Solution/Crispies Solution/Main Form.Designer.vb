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
        Me.bagelLabel = New System.Windows.Forms.Label()
        Me.bagelTextBox = New System.Windows.Forms.TextBox()
        Me.donutTextBox = New System.Windows.Forms.TextBox()
        Me.donutLabel = New System.Windows.Forms.Label()
        Me.coffeeTextBox = New System.Windows.Forms.TextBox()
        Me.coffeeLabel = New System.Windows.Forms.Label()
        Me.calcLabel = New System.Windows.Forms.Label()
        Me.priceLabel = New System.Windows.Forms.Label()
        Me.calcBtn = New System.Windows.Forms.Button()
        Me.colorBtn = New System.Windows.Forms.Button()
        Me.fontBtn = New System.Windows.Forms.Button()
        Me.exitBtn = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'bagelLabel
        '
        Me.bagelLabel.AutoSize = True
        Me.bagelLabel.Location = New System.Drawing.Point(12, 21)
        Me.bagelLabel.Name = "bagelLabel"
        Me.bagelLabel.Size = New System.Drawing.Size(42, 13)
        Me.bagelLabel.TabIndex = 0
        Me.bagelLabel.Text = "Bagels:"
        Me.bagelLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'bagelTextBox
        '
        Me.bagelTextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.bagelTextBox.Location = New System.Drawing.Point(62, 13)
        Me.bagelTextBox.Name = "bagelTextBox"
        Me.bagelTextBox.Size = New System.Drawing.Size(245, 26)
        Me.bagelTextBox.TabIndex = 1
        '
        'donutTextBox
        '
        Me.donutTextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.donutTextBox.Location = New System.Drawing.Point(62, 45)
        Me.donutTextBox.Name = "donutTextBox"
        Me.donutTextBox.Size = New System.Drawing.Size(245, 26)
        Me.donutTextBox.TabIndex = 3
        '
        'donutLabel
        '
        Me.donutLabel.AutoSize = True
        Me.donutLabel.Location = New System.Drawing.Point(12, 53)
        Me.donutLabel.Name = "donutLabel"
        Me.donutLabel.Size = New System.Drawing.Size(44, 13)
        Me.donutLabel.TabIndex = 2
        Me.donutLabel.Text = "Donuts:"
        Me.donutLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'coffeeTextBox
        '
        Me.coffeeTextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.coffeeTextBox.Location = New System.Drawing.Point(62, 77)
        Me.coffeeTextBox.Name = "coffeeTextBox"
        Me.coffeeTextBox.Size = New System.Drawing.Size(245, 26)
        Me.coffeeTextBox.TabIndex = 5
        '
        'coffeeLabel
        '
        Me.coffeeLabel.AutoSize = True
        Me.coffeeLabel.Location = New System.Drawing.Point(12, 85)
        Me.coffeeLabel.Name = "coffeeLabel"
        Me.coffeeLabel.Size = New System.Drawing.Size(41, 13)
        Me.coffeeLabel.TabIndex = 4
        Me.coffeeLabel.Text = "Coffee:"
        Me.coffeeLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'calcLabel
        '
        Me.calcLabel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.calcLabel.Location = New System.Drawing.Point(62, 110)
        Me.calcLabel.Name = "calcLabel"
        Me.calcLabel.Size = New System.Drawing.Size(245, 46)
        Me.calcLabel.TabIndex = 6
        Me.calcLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'priceLabel
        '
        Me.priceLabel.AutoSize = True
        Me.priceLabel.Location = New System.Drawing.Point(15, 125)
        Me.priceLabel.Name = "priceLabel"
        Me.priceLabel.Size = New System.Drawing.Size(34, 13)
        Me.priceLabel.TabIndex = 7
        Me.priceLabel.Text = "Price:"
        Me.priceLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'calcBtn
        '
        Me.calcBtn.Location = New System.Drawing.Point(314, 13)
        Me.calcBtn.Name = "calcBtn"
        Me.calcBtn.Size = New System.Drawing.Size(96, 26)
        Me.calcBtn.TabIndex = 8
        Me.calcBtn.Text = "Calculate Price"
        Me.calcBtn.UseVisualStyleBackColor = True
        '
        'colorBtn
        '
        Me.colorBtn.Location = New System.Drawing.Point(314, 45)
        Me.colorBtn.Name = "colorBtn"
        Me.colorBtn.Size = New System.Drawing.Size(96, 26)
        Me.colorBtn.TabIndex = 9
        Me.colorBtn.Text = "Color"
        Me.colorBtn.UseVisualStyleBackColor = True
        '
        'fontBtn
        '
        Me.fontBtn.Location = New System.Drawing.Point(314, 77)
        Me.fontBtn.Name = "fontBtn"
        Me.fontBtn.Size = New System.Drawing.Size(96, 26)
        Me.fontBtn.TabIndex = 10
        Me.fontBtn.Text = "Font"
        Me.fontBtn.UseVisualStyleBackColor = True
        '
        'exitBtn
        '
        Me.exitBtn.Location = New System.Drawing.Point(314, 110)
        Me.exitBtn.Name = "exitBtn"
        Me.exitBtn.Size = New System.Drawing.Size(96, 26)
        Me.exitBtn.TabIndex = 11
        Me.exitBtn.Text = "Exit"
        Me.exitBtn.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(420, 175)
        Me.Controls.Add(Me.exitBtn)
        Me.Controls.Add(Me.fontBtn)
        Me.Controls.Add(Me.colorBtn)
        Me.Controls.Add(Me.calcBtn)
        Me.Controls.Add(Me.priceLabel)
        Me.Controls.Add(Me.calcLabel)
        Me.Controls.Add(Me.coffeeTextBox)
        Me.Controls.Add(Me.coffeeLabel)
        Me.Controls.Add(Me.donutTextBox)
        Me.Controls.Add(Me.donutLabel)
        Me.Controls.Add(Me.bagelTextBox)
        Me.Controls.Add(Me.bagelLabel)
        Me.Name = "Form1"
        Me.Text = "Crispies Bagels and Bites"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents bagelLabel As Label
    Friend WithEvents bagelTextBox As TextBox
    Friend WithEvents donutTextBox As TextBox
    Friend WithEvents donutLabel As Label
    Friend WithEvents coffeeTextBox As TextBox
    Friend WithEvents coffeeLabel As Label
    Friend WithEvents calcLabel As Label
    Friend WithEvents priceLabel As Label
    Friend WithEvents calcBtn As Button
    Friend WithEvents colorBtn As Button
    Friend WithEvents fontBtn As Button
    Friend WithEvents exitBtn As Button
End Class
