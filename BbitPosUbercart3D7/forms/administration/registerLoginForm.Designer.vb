<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
<Global.System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Naming", "CA1726")> _
Partial Class registerLoginForm
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
    Friend WithEvents UsernameLabel As System.Windows.Forms.Label
    Friend WithEvents PasscodeLabel As System.Windows.Forms.Label
    Friend WithEvents UsernameTextBox As System.Windows.Forms.TextBox
    Friend WithEvents PasscodeTextBox As System.Windows.Forms.TextBox

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(registerLoginForm))
        Me.UsernameLabel = New System.Windows.Forms.Label()
        Me.PasscodeLabel = New System.Windows.Forms.Label()
        Me.UsernameTextBox = New System.Windows.Forms.TextBox()
        Me.PasscodeTextBox = New System.Windows.Forms.TextBox()
        Me.regLogNum0_Button = New System.Windows.Forms.Button()
        Me.regLogNum9_Button = New System.Windows.Forms.Button()
        Me.regLogNum8_Button = New System.Windows.Forms.Button()
        Me.regLogNum7_Button = New System.Windows.Forms.Button()
        Me.regLogNum6_Button = New System.Windows.Forms.Button()
        Me.regLogNum5_Button = New System.Windows.Forms.Button()
        Me.regLogNum4_Button = New System.Windows.Forms.Button()
        Me.regLogNum3_Button = New System.Windows.Forms.Button()
        Me.regLogNum2_Button = New System.Windows.Forms.Button()
        Me.regLogNum1_Button = New System.Windows.Forms.Button()
        Me.regLogCancelButton = New System.Windows.Forms.Button()
        Me.regLogOkButton = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'UsernameLabel
        '
        Me.UsernameLabel.Location = New System.Drawing.Point(12, 9)
        Me.UsernameLabel.Name = "UsernameLabel"
        Me.UsernameLabel.Size = New System.Drawing.Size(220, 23)
        Me.UsernameLabel.TabIndex = 0
        Me.UsernameLabel.Text = "&User ID"
        Me.UsernameLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'PasscodeLabel
        '
        Me.PasscodeLabel.Location = New System.Drawing.Point(12, 66)
        Me.PasscodeLabel.Name = "PasscodeLabel"
        Me.PasscodeLabel.Size = New System.Drawing.Size(220, 23)
        Me.PasscodeLabel.TabIndex = 2
        Me.PasscodeLabel.Text = "&Pass Code"
        Me.PasscodeLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'UsernameTextBox
        '
        Me.UsernameTextBox.Location = New System.Drawing.Point(14, 29)
        Me.UsernameTextBox.Name = "UsernameTextBox"
        Me.UsernameTextBox.Size = New System.Drawing.Size(220, 20)
        Me.UsernameTextBox.TabIndex = 1
        '
        'PasscodeTextBox
        '
        Me.PasscodeTextBox.Location = New System.Drawing.Point(14, 86)
        Me.PasscodeTextBox.Name = "PasscodeTextBox"
        Me.PasscodeTextBox.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.PasscodeTextBox.Size = New System.Drawing.Size(220, 20)
        Me.PasscodeTextBox.TabIndex = 3
        '
        'regLogNum0_Button
        '
        Me.regLogNum0_Button.BackColor = System.Drawing.SystemColors.Control
        Me.regLogNum0_Button.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.regLogNum0_Button.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.regLogNum0_Button.ForeColor = System.Drawing.Color.White
        Me.regLogNum0_Button.Location = New System.Drawing.Point(296, 180)
        Me.regLogNum0_Button.Name = "regLogNum0_Button"
        Me.regLogNum0_Button.Size = New System.Drawing.Size(50, 50)
        Me.regLogNum0_Button.TabIndex = 27
        Me.regLogNum0_Button.Text = "0"
        Me.regLogNum0_Button.UseVisualStyleBackColor = False
        '
        'regLogNum9_Button
        '
        Me.regLogNum9_Button.BackColor = System.Drawing.SystemColors.Control
        Me.regLogNum9_Button.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.regLogNum9_Button.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.regLogNum9_Button.ForeColor = System.Drawing.Color.White
        Me.regLogNum9_Button.Location = New System.Drawing.Point(352, 124)
        Me.regLogNum9_Button.Name = "regLogNum9_Button"
        Me.regLogNum9_Button.Size = New System.Drawing.Size(50, 50)
        Me.regLogNum9_Button.TabIndex = 26
        Me.regLogNum9_Button.Text = "9"
        Me.regLogNum9_Button.UseVisualStyleBackColor = False
        '
        'regLogNum8_Button
        '
        Me.regLogNum8_Button.BackColor = System.Drawing.SystemColors.Control
        Me.regLogNum8_Button.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.regLogNum8_Button.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.regLogNum8_Button.ForeColor = System.Drawing.Color.White
        Me.regLogNum8_Button.Location = New System.Drawing.Point(296, 124)
        Me.regLogNum8_Button.Name = "regLogNum8_Button"
        Me.regLogNum8_Button.Size = New System.Drawing.Size(50, 50)
        Me.regLogNum8_Button.TabIndex = 25
        Me.regLogNum8_Button.Text = "8"
        Me.regLogNum8_Button.UseVisualStyleBackColor = False
        '
        'regLogNum7_Button
        '
        Me.regLogNum7_Button.BackColor = System.Drawing.SystemColors.Control
        Me.regLogNum7_Button.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.regLogNum7_Button.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.regLogNum7_Button.ForeColor = System.Drawing.Color.White
        Me.regLogNum7_Button.Location = New System.Drawing.Point(240, 124)
        Me.regLogNum7_Button.Name = "regLogNum7_Button"
        Me.regLogNum7_Button.Size = New System.Drawing.Size(50, 50)
        Me.regLogNum7_Button.TabIndex = 24
        Me.regLogNum7_Button.Text = "7"
        Me.regLogNum7_Button.UseVisualStyleBackColor = False
        '
        'regLogNum6_Button
        '
        Me.regLogNum6_Button.BackColor = System.Drawing.SystemColors.Control
        Me.regLogNum6_Button.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.regLogNum6_Button.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.regLogNum6_Button.ForeColor = System.Drawing.Color.White
        Me.regLogNum6_Button.Location = New System.Drawing.Point(352, 68)
        Me.regLogNum6_Button.Name = "regLogNum6_Button"
        Me.regLogNum6_Button.Size = New System.Drawing.Size(50, 50)
        Me.regLogNum6_Button.TabIndex = 23
        Me.regLogNum6_Button.Text = "6"
        Me.regLogNum6_Button.UseVisualStyleBackColor = False
        '
        'regLogNum5_Button
        '
        Me.regLogNum5_Button.BackColor = System.Drawing.SystemColors.Control
        Me.regLogNum5_Button.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.regLogNum5_Button.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.regLogNum5_Button.ForeColor = System.Drawing.Color.White
        Me.regLogNum5_Button.Location = New System.Drawing.Point(296, 68)
        Me.regLogNum5_Button.Name = "regLogNum5_Button"
        Me.regLogNum5_Button.Size = New System.Drawing.Size(50, 50)
        Me.regLogNum5_Button.TabIndex = 22
        Me.regLogNum5_Button.Text = "5"
        Me.regLogNum5_Button.UseVisualStyleBackColor = False
        '
        'regLogNum4_Button
        '
        Me.regLogNum4_Button.BackColor = System.Drawing.SystemColors.Control
        Me.regLogNum4_Button.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.regLogNum4_Button.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.regLogNum4_Button.ForeColor = System.Drawing.Color.White
        Me.regLogNum4_Button.Location = New System.Drawing.Point(240, 68)
        Me.regLogNum4_Button.Name = "regLogNum4_Button"
        Me.regLogNum4_Button.Size = New System.Drawing.Size(50, 50)
        Me.regLogNum4_Button.TabIndex = 21
        Me.regLogNum4_Button.Text = "4"
        Me.regLogNum4_Button.UseVisualStyleBackColor = False
        '
        'regLogNum3_Button
        '
        Me.regLogNum3_Button.BackColor = System.Drawing.SystemColors.Control
        Me.regLogNum3_Button.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.regLogNum3_Button.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.regLogNum3_Button.ForeColor = System.Drawing.Color.White
        Me.regLogNum3_Button.Location = New System.Drawing.Point(352, 12)
        Me.regLogNum3_Button.Name = "regLogNum3_Button"
        Me.regLogNum3_Button.Size = New System.Drawing.Size(50, 50)
        Me.regLogNum3_Button.TabIndex = 20
        Me.regLogNum3_Button.Text = "3"
        Me.regLogNum3_Button.UseVisualStyleBackColor = False
        '
        'regLogNum2_Button
        '
        Me.regLogNum2_Button.BackColor = System.Drawing.SystemColors.Control
        Me.regLogNum2_Button.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.regLogNum2_Button.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.regLogNum2_Button.ForeColor = System.Drawing.Color.White
        Me.regLogNum2_Button.Location = New System.Drawing.Point(296, 12)
        Me.regLogNum2_Button.Name = "regLogNum2_Button"
        Me.regLogNum2_Button.Size = New System.Drawing.Size(50, 50)
        Me.regLogNum2_Button.TabIndex = 19
        Me.regLogNum2_Button.Text = "2"
        Me.regLogNum2_Button.UseVisualStyleBackColor = False
        '
        'regLogNum1_Button
        '
        Me.regLogNum1_Button.BackColor = System.Drawing.SystemColors.Control
        Me.regLogNum1_Button.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.regLogNum1_Button.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.regLogNum1_Button.ForeColor = System.Drawing.Color.White
        Me.regLogNum1_Button.Location = New System.Drawing.Point(240, 12)
        Me.regLogNum1_Button.Name = "regLogNum1_Button"
        Me.regLogNum1_Button.Size = New System.Drawing.Size(50, 50)
        Me.regLogNum1_Button.TabIndex = 18
        Me.regLogNum1_Button.Text = "1"
        Me.regLogNum1_Button.UseVisualStyleBackColor = False
        '
        'regLogCancelButton
        '
        Me.regLogCancelButton.BackColor = System.Drawing.Color.Red
        Me.regLogCancelButton.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.regLogCancelButton.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.regLogCancelButton.Location = New System.Drawing.Point(240, 180)
        Me.regLogCancelButton.Name = "regLogCancelButton"
        Me.regLogCancelButton.Size = New System.Drawing.Size(50, 50)
        Me.regLogCancelButton.TabIndex = 17
        Me.regLogCancelButton.Text = "Esc"
        Me.regLogCancelButton.UseVisualStyleBackColor = False
        '
        'regLogOkButton
        '
        Me.regLogOkButton.BackColor = System.Drawing.Color.DarkGreen
        Me.regLogOkButton.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.regLogOkButton.ForeColor = System.Drawing.Color.White
        Me.regLogOkButton.Location = New System.Drawing.Point(352, 180)
        Me.regLogOkButton.Name = "regLogOkButton"
        Me.regLogOkButton.Size = New System.Drawing.Size(53, 50)
        Me.regLogOkButton.TabIndex = 16
        Me.regLogOkButton.Text = "&OK"
        Me.regLogOkButton.UseVisualStyleBackColor = False
        '
        'registerLoginForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(424, 246)
        Me.Controls.Add(Me.regLogNum0_Button)
        Me.Controls.Add(Me.regLogNum9_Button)
        Me.Controls.Add(Me.regLogNum8_Button)
        Me.Controls.Add(Me.regLogNum7_Button)
        Me.Controls.Add(Me.regLogNum6_Button)
        Me.Controls.Add(Me.regLogNum5_Button)
        Me.Controls.Add(Me.regLogNum4_Button)
        Me.Controls.Add(Me.regLogNum3_Button)
        Me.Controls.Add(Me.regLogNum2_Button)
        Me.Controls.Add(Me.regLogNum1_Button)
        Me.Controls.Add(Me.regLogCancelButton)
        Me.Controls.Add(Me.regLogOkButton)
        Me.Controls.Add(Me.PasscodeTextBox)
        Me.Controls.Add(Me.UsernameTextBox)
        Me.Controls.Add(Me.PasscodeLabel)
        Me.Controls.Add(Me.UsernameLabel)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "registerLoginForm"
        Me.ShowInTaskbar = False
        Me.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Register Login"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents regLogNum0_Button As System.Windows.Forms.Button
    Friend WithEvents regLogNum9_Button As System.Windows.Forms.Button
    Friend WithEvents regLogNum8_Button As System.Windows.Forms.Button
    Friend WithEvents regLogNum7_Button As System.Windows.Forms.Button
    Friend WithEvents regLogNum6_Button As System.Windows.Forms.Button
    Friend WithEvents regLogNum5_Button As System.Windows.Forms.Button
    Friend WithEvents regLogNum4_Button As System.Windows.Forms.Button
    Friend WithEvents regLogNum3_Button As System.Windows.Forms.Button
    Friend WithEvents regLogNum2_Button As System.Windows.Forms.Button
    Friend WithEvents regLogNum1_Button As System.Windows.Forms.Button
    Friend WithEvents regLogCancelButton As System.Windows.Forms.Button
    Friend WithEvents regLogOkButton As System.Windows.Forms.Button

End Class
