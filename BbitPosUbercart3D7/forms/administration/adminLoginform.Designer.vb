<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
<Global.System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Naming", "CA1726")> _
Partial Class adminLoginform
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
    Friend WithEvents PasswordLabel As System.Windows.Forms.Label
    Friend WithEvents PasswordTextBox As System.Windows.Forms.TextBox
    Friend WithEvents adminOkButton As System.Windows.Forms.Button
    Friend WithEvents adminCancelButton As System.Windows.Forms.Button

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(adminLoginform))
        Me.PasswordLabel = New System.Windows.Forms.Label()
        Me.PasswordTextBox = New System.Windows.Forms.TextBox()
        Me.adminOkButton = New System.Windows.Forms.Button()
        Me.adminCancelButton = New System.Windows.Forms.Button()
        Me.adminNum1_Button = New System.Windows.Forms.Button()
        Me.adminNum2_Button = New System.Windows.Forms.Button()
        Me.adminNum3_Button = New System.Windows.Forms.Button()
        Me.adminNum6_Button = New System.Windows.Forms.Button()
        Me.adminNum5_Button = New System.Windows.Forms.Button()
        Me.adminNum4_Button = New System.Windows.Forms.Button()
        Me.adminNum9_Button = New System.Windows.Forms.Button()
        Me.adminNum8_Button = New System.Windows.Forms.Button()
        Me.adminNum7_Button = New System.Windows.Forms.Button()
        Me.adminNum0_Button = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'PasswordLabel
        '
        Me.PasswordLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.PasswordLabel.Location = New System.Drawing.Point(12, 9)
        Me.PasswordLabel.Name = "PasswordLabel"
        Me.PasswordLabel.Size = New System.Drawing.Size(162, 23)
        Me.PasswordLabel.TabIndex = 2
        Me.PasswordLabel.Text = "&Password"
        Me.PasswordLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'PasswordTextBox
        '
        Me.PasswordTextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.PasswordTextBox.Location = New System.Drawing.Point(15, 35)
        Me.PasswordTextBox.Name = "PasswordTextBox"
        Me.PasswordTextBox.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.PasswordTextBox.Size = New System.Drawing.Size(159, 26)
        Me.PasswordTextBox.TabIndex = 3
        '
        'adminOkButton
        '
        Me.adminOkButton.BackColor = System.Drawing.Color.DarkGreen
        Me.adminOkButton.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.adminOkButton.ForeColor = System.Drawing.Color.White
        Me.adminOkButton.Location = New System.Drawing.Point(124, 235)
        Me.adminOkButton.Name = "adminOkButton"
        Me.adminOkButton.Size = New System.Drawing.Size(53, 50)
        Me.adminOkButton.TabIndex = 4
        Me.adminOkButton.Text = "&OK"
        Me.adminOkButton.UseVisualStyleBackColor = False
        '
        'adminCancelButton
        '
        Me.adminCancelButton.BackColor = System.Drawing.Color.Red
        Me.adminCancelButton.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.adminCancelButton.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.adminCancelButton.Location = New System.Drawing.Point(12, 235)
        Me.adminCancelButton.Name = "adminCancelButton"
        Me.adminCancelButton.Size = New System.Drawing.Size(50, 50)
        Me.adminCancelButton.TabIndex = 5
        Me.adminCancelButton.Text = "Esc"
        Me.adminCancelButton.UseVisualStyleBackColor = False
        '
        'adminNum1_Button
        '
        Me.adminNum1_Button.BackColor = System.Drawing.SystemColors.Control
        Me.adminNum1_Button.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.adminNum1_Button.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.adminNum1_Button.ForeColor = System.Drawing.Color.White
        Me.adminNum1_Button.Location = New System.Drawing.Point(12, 67)
        Me.adminNum1_Button.Name = "adminNum1_Button"
        Me.adminNum1_Button.Size = New System.Drawing.Size(50, 50)
        Me.adminNum1_Button.TabIndex = 6
        Me.adminNum1_Button.Text = "1"
        Me.adminNum1_Button.UseVisualStyleBackColor = False
        '
        'adminNum2_Button
        '
        Me.adminNum2_Button.BackColor = System.Drawing.SystemColors.Control
        Me.adminNum2_Button.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.adminNum2_Button.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.adminNum2_Button.ForeColor = System.Drawing.Color.White
        Me.adminNum2_Button.Location = New System.Drawing.Point(68, 67)
        Me.adminNum2_Button.Name = "adminNum2_Button"
        Me.adminNum2_Button.Size = New System.Drawing.Size(50, 50)
        Me.adminNum2_Button.TabIndex = 7
        Me.adminNum2_Button.Text = "2"
        Me.adminNum2_Button.UseVisualStyleBackColor = False
        '
        'adminNum3_Button
        '
        Me.adminNum3_Button.BackColor = System.Drawing.SystemColors.Control
        Me.adminNum3_Button.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.adminNum3_Button.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.adminNum3_Button.ForeColor = System.Drawing.Color.White
        Me.adminNum3_Button.Location = New System.Drawing.Point(124, 67)
        Me.adminNum3_Button.Name = "adminNum3_Button"
        Me.adminNum3_Button.Size = New System.Drawing.Size(50, 50)
        Me.adminNum3_Button.TabIndex = 8
        Me.adminNum3_Button.Text = "3"
        Me.adminNum3_Button.UseVisualStyleBackColor = False
        '
        'adminNum6_Button
        '
        Me.adminNum6_Button.BackColor = System.Drawing.SystemColors.Control
        Me.adminNum6_Button.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.adminNum6_Button.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.adminNum6_Button.ForeColor = System.Drawing.Color.White
        Me.adminNum6_Button.Location = New System.Drawing.Point(124, 123)
        Me.adminNum6_Button.Name = "adminNum6_Button"
        Me.adminNum6_Button.Size = New System.Drawing.Size(50, 50)
        Me.adminNum6_Button.TabIndex = 11
        Me.adminNum6_Button.Text = "6"
        Me.adminNum6_Button.UseVisualStyleBackColor = False
        '
        'adminNum5_Button
        '
        Me.adminNum5_Button.BackColor = System.Drawing.SystemColors.Control
        Me.adminNum5_Button.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.adminNum5_Button.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.adminNum5_Button.ForeColor = System.Drawing.Color.White
        Me.adminNum5_Button.Location = New System.Drawing.Point(68, 123)
        Me.adminNum5_Button.Name = "adminNum5_Button"
        Me.adminNum5_Button.Size = New System.Drawing.Size(50, 50)
        Me.adminNum5_Button.TabIndex = 10
        Me.adminNum5_Button.Text = "5"
        Me.adminNum5_Button.UseVisualStyleBackColor = False
        '
        'adminNum4_Button
        '
        Me.adminNum4_Button.BackColor = System.Drawing.SystemColors.Control
        Me.adminNum4_Button.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.adminNum4_Button.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.adminNum4_Button.ForeColor = System.Drawing.Color.White
        Me.adminNum4_Button.Location = New System.Drawing.Point(12, 123)
        Me.adminNum4_Button.Name = "adminNum4_Button"
        Me.adminNum4_Button.Size = New System.Drawing.Size(50, 50)
        Me.adminNum4_Button.TabIndex = 9
        Me.adminNum4_Button.Text = "4"
        Me.adminNum4_Button.UseVisualStyleBackColor = False
        '
        'adminNum9_Button
        '
        Me.adminNum9_Button.BackColor = System.Drawing.SystemColors.Control
        Me.adminNum9_Button.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.adminNum9_Button.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.adminNum9_Button.ForeColor = System.Drawing.Color.White
        Me.adminNum9_Button.Location = New System.Drawing.Point(124, 179)
        Me.adminNum9_Button.Name = "adminNum9_Button"
        Me.adminNum9_Button.Size = New System.Drawing.Size(50, 50)
        Me.adminNum9_Button.TabIndex = 14
        Me.adminNum9_Button.Text = "9"
        Me.adminNum9_Button.UseVisualStyleBackColor = False
        '
        'adminNum8_Button
        '
        Me.adminNum8_Button.BackColor = System.Drawing.SystemColors.Control
        Me.adminNum8_Button.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.adminNum8_Button.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.adminNum8_Button.ForeColor = System.Drawing.Color.White
        Me.adminNum8_Button.Location = New System.Drawing.Point(68, 179)
        Me.adminNum8_Button.Name = "adminNum8_Button"
        Me.adminNum8_Button.Size = New System.Drawing.Size(50, 50)
        Me.adminNum8_Button.TabIndex = 13
        Me.adminNum8_Button.Text = "8"
        Me.adminNum8_Button.UseVisualStyleBackColor = False
        '
        'adminNum7_Button
        '
        Me.adminNum7_Button.BackColor = System.Drawing.SystemColors.Control
        Me.adminNum7_Button.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.adminNum7_Button.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.adminNum7_Button.ForeColor = System.Drawing.Color.White
        Me.adminNum7_Button.Location = New System.Drawing.Point(12, 179)
        Me.adminNum7_Button.Name = "adminNum7_Button"
        Me.adminNum7_Button.Size = New System.Drawing.Size(50, 50)
        Me.adminNum7_Button.TabIndex = 12
        Me.adminNum7_Button.Text = "7"
        Me.adminNum7_Button.UseVisualStyleBackColor = False
        '
        'adminNum0_Button
        '
        Me.adminNum0_Button.BackColor = System.Drawing.SystemColors.Control
        Me.adminNum0_Button.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.adminNum0_Button.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.adminNum0_Button.ForeColor = System.Drawing.Color.White
        Me.adminNum0_Button.Location = New System.Drawing.Point(68, 235)
        Me.adminNum0_Button.Name = "adminNum0_Button"
        Me.adminNum0_Button.Size = New System.Drawing.Size(50, 50)
        Me.adminNum0_Button.TabIndex = 15
        Me.adminNum0_Button.Text = "0"
        Me.adminNum0_Button.UseVisualStyleBackColor = False
        '
        'adminLoginform
        '
        Me.AcceptButton = Me.adminOkButton
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.CancelButton = Me.adminCancelButton
        Me.ClientSize = New System.Drawing.Size(189, 297)
        Me.ControlBox = False
        Me.Controls.Add(Me.adminNum0_Button)
        Me.Controls.Add(Me.adminNum9_Button)
        Me.Controls.Add(Me.adminNum8_Button)
        Me.Controls.Add(Me.adminNum7_Button)
        Me.Controls.Add(Me.adminNum6_Button)
        Me.Controls.Add(Me.adminNum5_Button)
        Me.Controls.Add(Me.adminNum4_Button)
        Me.Controls.Add(Me.adminNum3_Button)
        Me.Controls.Add(Me.adminNum2_Button)
        Me.Controls.Add(Me.adminNum1_Button)
        Me.Controls.Add(Me.adminCancelButton)
        Me.Controls.Add(Me.adminOkButton)
        Me.Controls.Add(Me.PasswordTextBox)
        Me.Controls.Add(Me.PasswordLabel)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "adminLoginform"
        Me.ShowInTaskbar = False
        Me.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Administrator Login"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents adminNum1_Button As System.Windows.Forms.Button
    Friend WithEvents adminNum2_Button As System.Windows.Forms.Button
    Friend WithEvents adminNum3_Button As System.Windows.Forms.Button
    Friend WithEvents adminNum6_Button As System.Windows.Forms.Button
    Friend WithEvents adminNum5_Button As System.Windows.Forms.Button
    Friend WithEvents adminNum4_Button As System.Windows.Forms.Button
    Friend WithEvents adminNum9_Button As System.Windows.Forms.Button
    Friend WithEvents adminNum8_Button As System.Windows.Forms.Button
    Friend WithEvents adminNum7_Button As System.Windows.Forms.Button
    Friend WithEvents adminNum0_Button As System.Windows.Forms.Button

End Class
