<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class sftpDalog
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(sftpDalog))
        Me.server_Label = New System.Windows.Forms.Label()
        Me.server_TextBox = New System.Windows.Forms.TextBox()
        Me.username_TextBox = New System.Windows.Forms.TextBox()
        Me.username_Label = New System.Windows.Forms.Label()
        Me.password_TextBox = New System.Windows.Forms.TextBox()
        Me.password_Label = New System.Windows.Forms.Label()
        Me.portNum_TextBox = New System.Windows.Forms.TextBox()
        Me.portNum_Label = New System.Windows.Forms.Label()
        Me.sshFingerprint_TextBox = New System.Windows.Forms.TextBox()
        Me.sshFingerprint_Label = New System.Windows.Forms.Label()
        Me.testConn_Button = New System.Windows.Forms.Button()
        Me.OK_Button = New System.Windows.Forms.Button()
        Me.Cancel_Button = New System.Windows.Forms.Button()
        Me.rootFolderTextBox = New System.Windows.Forms.TextBox()
        Me.rootFolderLabel = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'server_Label
        '
        Me.server_Label.AutoSize = True
        Me.server_Label.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.server_Label.Location = New System.Drawing.Point(12, 9)
        Me.server_Label.Name = "server_Label"
        Me.server_Label.Size = New System.Drawing.Size(50, 17)
        Me.server_Label.TabIndex = 1
        Me.server_Label.Text = "Server"
        '
        'server_TextBox
        '
        Me.server_TextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.server_TextBox.Location = New System.Drawing.Point(12, 29)
        Me.server_TextBox.Name = "server_TextBox"
        Me.server_TextBox.Size = New System.Drawing.Size(314, 23)
        Me.server_TextBox.TabIndex = 1
        '
        'username_TextBox
        '
        Me.username_TextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.username_TextBox.Location = New System.Drawing.Point(12, 139)
        Me.username_TextBox.Name = "username_TextBox"
        Me.username_TextBox.Size = New System.Drawing.Size(314, 23)
        Me.username_TextBox.TabIndex = 3
        '
        'username_Label
        '
        Me.username_Label.AutoSize = True
        Me.username_Label.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.username_Label.Location = New System.Drawing.Point(12, 119)
        Me.username_Label.Name = "username_Label"
        Me.username_Label.Size = New System.Drawing.Size(79, 17)
        Me.username_Label.TabIndex = 3
        Me.username_Label.Text = "User Name"
        '
        'password_TextBox
        '
        Me.password_TextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.password_TextBox.Location = New System.Drawing.Point(12, 195)
        Me.password_TextBox.Name = "password_TextBox"
        Me.password_TextBox.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.password_TextBox.Size = New System.Drawing.Size(314, 23)
        Me.password_TextBox.TabIndex = 4
        '
        'password_Label
        '
        Me.password_Label.AutoSize = True
        Me.password_Label.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.password_Label.Location = New System.Drawing.Point(12, 175)
        Me.password_Label.Name = "password_Label"
        Me.password_Label.Size = New System.Drawing.Size(69, 17)
        Me.password_Label.TabIndex = 5
        Me.password_Label.Text = "Password"
        '
        'portNum_TextBox
        '
        Me.portNum_TextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.portNum_TextBox.Location = New System.Drawing.Point(12, 84)
        Me.portNum_TextBox.Name = "portNum_TextBox"
        Me.portNum_TextBox.Size = New System.Drawing.Size(314, 23)
        Me.portNum_TextBox.TabIndex = 2
        '
        'portNum_Label
        '
        Me.portNum_Label.AutoSize = True
        Me.portNum_Label.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.portNum_Label.Location = New System.Drawing.Point(12, 64)
        Me.portNum_Label.Name = "portNum_Label"
        Me.portNum_Label.Size = New System.Drawing.Size(88, 17)
        Me.portNum_Label.TabIndex = 7
        Me.portNum_Label.Text = "Port Number"
        '
        'sshFingerprint_TextBox
        '
        Me.sshFingerprint_TextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.sshFingerprint_TextBox.Location = New System.Drawing.Point(12, 250)
        Me.sshFingerprint_TextBox.Name = "sshFingerprint_TextBox"
        Me.sshFingerprint_TextBox.Size = New System.Drawing.Size(314, 23)
        Me.sshFingerprint_TextBox.TabIndex = 5
        '
        'sshFingerprint_Label
        '
        Me.sshFingerprint_Label.AutoSize = True
        Me.sshFingerprint_Label.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.sshFingerprint_Label.Location = New System.Drawing.Point(12, 230)
        Me.sshFingerprint_Label.Name = "sshFingerprint_Label"
        Me.sshFingerprint_Label.Size = New System.Drawing.Size(169, 17)
        Me.sshFingerprint_Label.TabIndex = 9
        Me.sshFingerprint_Label.Text = "SSH Host Key Fingerprint"
        '
        'testConn_Button
        '
        Me.testConn_Button.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.testConn_Button.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.testConn_Button.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.testConn_Button.Location = New System.Drawing.Point(12, 367)
        Me.testConn_Button.Name = "testConn_Button"
        Me.testConn_Button.Size = New System.Drawing.Size(75, 23)
        Me.testConn_Button.TabIndex = 7
        Me.testConn_Button.Text = "Test"
        Me.testConn_Button.UseVisualStyleBackColor = True
        '
        'OK_Button
        '
        Me.OK_Button.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.OK_Button.BackColor = System.Drawing.SystemColors.Control
        Me.OK_Button.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.OK_Button.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.OK_Button.Location = New System.Drawing.Point(251, 367)
        Me.OK_Button.Name = "OK_Button"
        Me.OK_Button.Size = New System.Drawing.Size(75, 23)
        Me.OK_Button.TabIndex = 9
        Me.OK_Button.Text = "OK"
        Me.OK_Button.UseVisualStyleBackColor = False
        '
        'Cancel_Button
        '
        Me.Cancel_Button.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Cancel_Button.BackColor = System.Drawing.SystemColors.Control
        Me.Cancel_Button.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.Cancel_Button.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.Cancel_Button.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.Cancel_Button.Location = New System.Drawing.Point(170, 367)
        Me.Cancel_Button.Name = "Cancel_Button"
        Me.Cancel_Button.Size = New System.Drawing.Size(75, 23)
        Me.Cancel_Button.TabIndex = 8
        Me.Cancel_Button.Text = "Cancel"
        Me.Cancel_Button.UseVisualStyleBackColor = False
        '
        'rootFolderTextBox
        '
        Me.rootFolderTextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.rootFolderTextBox.Location = New System.Drawing.Point(12, 305)
        Me.rootFolderTextBox.Name = "rootFolderTextBox"
        Me.rootFolderTextBox.Size = New System.Drawing.Size(314, 23)
        Me.rootFolderTextBox.TabIndex = 6
        '
        'rootFolderLabel
        '
        Me.rootFolderLabel.AutoSize = True
        Me.rootFolderLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.rootFolderLabel.Location = New System.Drawing.Point(9, 285)
        Me.rootFolderLabel.Name = "rootFolderLabel"
        Me.rootFolderLabel.Size = New System.Drawing.Size(82, 17)
        Me.rootFolderLabel.TabIndex = 14
        Me.rootFolderLabel.Text = "Root Folder"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Italic)
        Me.Label1.Location = New System.Drawing.Point(9, 331)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(316, 13)
        Me.Label1.TabIndex = 15
        Me.Label1.Text = "Folder where the index.php file is located on the server after login."
        '
        'ftp_dialog
        '
        Me.AcceptButton = Me.OK_Button
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.BackColor = System.Drawing.SystemColors.Control
        Me.CancelButton = Me.Cancel_Button
        Me.ClientSize = New System.Drawing.Size(338, 402)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.rootFolderTextBox)
        Me.Controls.Add(Me.rootFolderLabel)
        Me.Controls.Add(Me.OK_Button)
        Me.Controls.Add(Me.Cancel_Button)
        Me.Controls.Add(Me.testConn_Button)
        Me.Controls.Add(Me.sshFingerprint_TextBox)
        Me.Controls.Add(Me.sshFingerprint_Label)
        Me.Controls.Add(Me.portNum_TextBox)
        Me.Controls.Add(Me.portNum_Label)
        Me.Controls.Add(Me.password_TextBox)
        Me.Controls.Add(Me.password_Label)
        Me.Controls.Add(Me.username_TextBox)
        Me.Controls.Add(Me.username_Label)
        Me.Controls.Add(Me.server_TextBox)
        Me.Controls.Add(Me.server_Label)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MaximumSize = New System.Drawing.Size(441, 434)
        Me.MinimizeBox = False
        Me.Name = "ftp_dialog"
        Me.ShowInTaskbar = False
        Me.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Change FTP Settings"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents server_Label As System.Windows.Forms.Label
    Friend WithEvents server_TextBox As System.Windows.Forms.TextBox
    Friend WithEvents username_TextBox As System.Windows.Forms.TextBox
    Friend WithEvents username_Label As System.Windows.Forms.Label
    Friend WithEvents password_TextBox As System.Windows.Forms.TextBox
    Friend WithEvents password_Label As System.Windows.Forms.Label
    Friend WithEvents portNum_TextBox As System.Windows.Forms.TextBox
    Friend WithEvents portNum_Label As System.Windows.Forms.Label
    Friend WithEvents sshFingerprint_TextBox As System.Windows.Forms.TextBox
    Friend WithEvents sshFingerprint_Label As System.Windows.Forms.Label
    Friend WithEvents testConn_Button As System.Windows.Forms.Button
    Friend WithEvents OK_Button As System.Windows.Forms.Button
    Friend WithEvents Cancel_Button As System.Windows.Forms.Button
    Friend WithEvents rootFolderTextBox As System.Windows.Forms.TextBox
    Friend WithEvents rootFolderLabel As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label

End Class
