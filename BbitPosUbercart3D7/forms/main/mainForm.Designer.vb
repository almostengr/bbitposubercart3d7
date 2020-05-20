<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class mainForm
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(mainForm))
        Me.openRegisterButton = New System.Windows.Forms.Button()
        Me.exitButton = New System.Windows.Forms.Button()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.AdminToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.RunEndOfDayToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator3 = New System.Windows.Forms.ToolStripSeparator()
        Me.UpdatePOSDataToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.UpdateToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.UpdateSFTPSettingsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.RunConfigurationWizardToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator2 = New System.Windows.Forms.ToolStripSeparator()
        Me.OptionsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ChangeAdministratorPasswordToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ShutDownAfterEndOfDayToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator4 = New System.Windows.Forms.ToolStripSeparator()
        Me.ExitToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.HelpToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.OnlineHelpToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.AboutBBITPOSForUbercart3ToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.mainStatusStrip = New System.Windows.Forms.StatusStrip()
        Me.mainNetStatusToolStripStatusLabel = New System.Windows.Forms.ToolStripStatusLabel()
        Me.mainTimeToolStripStatusLabel = New System.Windows.Forms.ToolStripStatusLabel()
        Me.mainMachineToolStripStatusLabel = New System.Windows.Forms.ToolStripStatusLabel()
        Me.mainTimer = New System.Windows.Forms.Timer(Me.components)
        Me.mainNotifyIcon = New System.Windows.Forms.NotifyIcon(Me.components)
        Me.loginButton = New System.Windows.Forms.Button()
        Me.loadDsBackgroundWorker = New System.ComponentModel.BackgroundWorker()
        Me.MenuStrip1.SuspendLayout()
        Me.mainStatusStrip.SuspendLayout()
        Me.SuspendLayout()
        '
        'openRegisterButton
        '
        Me.openRegisterButton.Location = New System.Drawing.Point(122, 27)
        Me.openRegisterButton.Name = "openRegisterButton"
        Me.openRegisterButton.Size = New System.Drawing.Size(306, 170)
        Me.openRegisterButton.TabIndex = 0
        Me.openRegisterButton.Text = "Open &Register"
        Me.openRegisterButton.UseVisualStyleBackColor = True
        '
        'exitButton
        '
        Me.exitButton.Location = New System.Drawing.Point(304, 247)
        Me.exitButton.Name = "exitButton"
        Me.exitButton.Size = New System.Drawing.Size(124, 73)
        Me.exitButton.TabIndex = 5
        Me.exitButton.Text = "E&xit"
        Me.exitButton.UseVisualStyleBackColor = True
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.AdminToolStripMenuItem, Me.HelpToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(572, 24)
        Me.MenuStrip1.TabIndex = 7
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'AdminToolStripMenuItem
        '
        Me.AdminToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.RunEndOfDayToolStripMenuItem, Me.ToolStripSeparator3, Me.UpdatePOSDataToolStripMenuItem, Me.UpdateToolStripMenuItem, Me.UpdateSFTPSettingsToolStripMenuItem, Me.RunConfigurationWizardToolStripMenuItem, Me.ToolStripSeparator2, Me.OptionsToolStripMenuItem, Me.ToolStripSeparator4, Me.ExitToolStripMenuItem})
        Me.AdminToolStripMenuItem.Name = "AdminToolStripMenuItem"
        Me.AdminToolStripMenuItem.Size = New System.Drawing.Size(39, 20)
        Me.AdminToolStripMenuItem.Text = "&POS"
        '
        'RunEndOfDayToolStripMenuItem
        '
        Me.RunEndOfDayToolStripMenuItem.Name = "RunEndOfDayToolStripMenuItem"
        Me.RunEndOfDayToolStripMenuItem.Size = New System.Drawing.Size(208, 22)
        Me.RunEndOfDayToolStripMenuItem.Text = "R&un End of Day"
        '
        'ToolStripSeparator3
        '
        Me.ToolStripSeparator3.Name = "ToolStripSeparator3"
        Me.ToolStripSeparator3.Size = New System.Drawing.Size(205, 6)
        '
        'UpdatePOSDataToolStripMenuItem
        '
        Me.UpdatePOSDataToolStripMenuItem.Name = "UpdatePOSDataToolStripMenuItem"
        Me.UpdatePOSDataToolStripMenuItem.Size = New System.Drawing.Size(208, 22)
        Me.UpdatePOSDataToolStripMenuItem.Text = "Update &POS Data"
        '
        'UpdateToolStripMenuItem
        '
        Me.UpdateToolStripMenuItem.Name = "UpdateToolStripMenuItem"
        Me.UpdateToolStripMenuItem.Size = New System.Drawing.Size(208, 22)
        Me.UpdateToolStripMenuItem.Text = "Update &Website Address"
        '
        'UpdateSFTPSettingsToolStripMenuItem
        '
        Me.UpdateSFTPSettingsToolStripMenuItem.Name = "UpdateSFTPSettingsToolStripMenuItem"
        Me.UpdateSFTPSettingsToolStripMenuItem.Size = New System.Drawing.Size(208, 22)
        Me.UpdateSFTPSettingsToolStripMenuItem.Text = "Update &SFTP Settings"
        '
        'RunConfigurationWizardToolStripMenuItem
        '
        Me.RunConfigurationWizardToolStripMenuItem.Name = "RunConfigurationWizardToolStripMenuItem"
        Me.RunConfigurationWizardToolStripMenuItem.Size = New System.Drawing.Size(208, 22)
        Me.RunConfigurationWizardToolStripMenuItem.Text = "Run &Configuration Wizard"
        '
        'ToolStripSeparator2
        '
        Me.ToolStripSeparator2.Name = "ToolStripSeparator2"
        Me.ToolStripSeparator2.Size = New System.Drawing.Size(205, 6)
        '
        'OptionsToolStripMenuItem
        '
        Me.OptionsToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ChangeAdministratorPasswordToolStripMenuItem, Me.ShutDownAfterEndOfDayToolStripMenuItem})
        Me.OptionsToolStripMenuItem.Name = "OptionsToolStripMenuItem"
        Me.OptionsToolStripMenuItem.Size = New System.Drawing.Size(208, 22)
        Me.OptionsToolStripMenuItem.Text = "&Options "
        '
        'ChangeAdministratorPasswordToolStripMenuItem
        '
        Me.ChangeAdministratorPasswordToolStripMenuItem.Name = "ChangeAdministratorPasswordToolStripMenuItem"
        Me.ChangeAdministratorPasswordToolStripMenuItem.Size = New System.Drawing.Size(238, 22)
        Me.ChangeAdministratorPasswordToolStripMenuItem.Text = "Change Administrator Password"
        '
        'ShutDownAfterEndOfDayToolStripMenuItem
        '
        Me.ShutDownAfterEndOfDayToolStripMenuItem.Name = "ShutDownAfterEndOfDayToolStripMenuItem"
        Me.ShutDownAfterEndOfDayToolStripMenuItem.Size = New System.Drawing.Size(238, 22)
        Me.ShutDownAfterEndOfDayToolStripMenuItem.Text = "Shut Down after End of Day"
        '
        'ToolStripSeparator4
        '
        Me.ToolStripSeparator4.Name = "ToolStripSeparator4"
        Me.ToolStripSeparator4.Size = New System.Drawing.Size(205, 6)
        '
        'ExitToolStripMenuItem
        '
        Me.ExitToolStripMenuItem.Name = "ExitToolStripMenuItem"
        Me.ExitToolStripMenuItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Alt Or System.Windows.Forms.Keys.F4), System.Windows.Forms.Keys)
        Me.ExitToolStripMenuItem.Size = New System.Drawing.Size(208, 22)
        Me.ExitToolStripMenuItem.Text = "E&xit"
        '
        'HelpToolStripMenuItem
        '
        Me.HelpToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.OnlineHelpToolStripMenuItem, Me.ToolStripSeparator1, Me.AboutBBITPOSForUbercart3ToolStripMenuItem})
        Me.HelpToolStripMenuItem.Name = "HelpToolStripMenuItem"
        Me.HelpToolStripMenuItem.Size = New System.Drawing.Size(40, 20)
        Me.HelpToolStripMenuItem.Text = "&Help"
        '
        'OnlineHelpToolStripMenuItem
        '
        Me.OnlineHelpToolStripMenuItem.Name = "OnlineHelpToolStripMenuItem"
        Me.OnlineHelpToolStripMenuItem.ShortcutKeys = System.Windows.Forms.Keys.F1
        Me.OnlineHelpToolStripMenuItem.Size = New System.Drawing.Size(233, 22)
        Me.OnlineHelpToolStripMenuItem.Text = "&Online Help"
        '
        'ToolStripSeparator1
        '
        Me.ToolStripSeparator1.Name = "ToolStripSeparator1"
        Me.ToolStripSeparator1.Size = New System.Drawing.Size(230, 6)
        '
        'AboutBBITPOSForUbercart3ToolStripMenuItem
        '
        Me.AboutBBITPOSForUbercart3ToolStripMenuItem.Name = "AboutBBITPOSForUbercart3ToolStripMenuItem"
        Me.AboutBBITPOSForUbercart3ToolStripMenuItem.Size = New System.Drawing.Size(233, 22)
        Me.AboutBBITPOSForUbercart3ToolStripMenuItem.Text = "&About BBIT POS for Ubercart 3"
        '
        'mainStatusStrip
        '
        Me.mainStatusStrip.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.mainStatusStrip.AutoSize = False
        Me.mainStatusStrip.Dock = System.Windows.Forms.DockStyle.None
        Me.mainStatusStrip.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mainNetStatusToolStripStatusLabel, Me.mainTimeToolStripStatusLabel, Me.mainMachineToolStripStatusLabel})
        Me.mainStatusStrip.Location = New System.Drawing.Point(0, 373)
        Me.mainStatusStrip.Name = "mainStatusStrip"
        Me.mainStatusStrip.Size = New System.Drawing.Size(572, 24)
        Me.mainStatusStrip.SizingGrip = False
        Me.mainStatusStrip.TabIndex = 66
        Me.mainStatusStrip.Text = "mainStatusStrip"
        '
        'mainNetStatusToolStripStatusLabel
        '
        Me.mainNetStatusToolStripStatusLabel.AutoSize = False
        Me.mainNetStatusToolStripStatusLabel.BackColor = System.Drawing.Color.Black
        Me.mainNetStatusToolStripStatusLabel.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.mainNetStatusToolStripStatusLabel.ForeColor = System.Drawing.Color.OrangeRed
        Me.mainNetStatusToolStripStatusLabel.Name = "mainNetStatusToolStripStatusLabel"
        Me.mainNetStatusToolStripStatusLabel.Size = New System.Drawing.Size(50, 19)
        Me.mainNetStatusToolStripStatusLabel.Text = "Offline"
        '
        'mainTimeToolStripStatusLabel
        '
        Me.mainTimeToolStripStatusLabel.AutoSize = False
        Me.mainTimeToolStripStatusLabel.BorderSides = CType((((System.Windows.Forms.ToolStripStatusLabelBorderSides.Left Or System.Windows.Forms.ToolStripStatusLabelBorderSides.Top) _
                    Or System.Windows.Forms.ToolStripStatusLabelBorderSides.Right) _
                    Or System.Windows.Forms.ToolStripStatusLabelBorderSides.Bottom), System.Windows.Forms.ToolStripStatusLabelBorderSides)
        Me.mainTimeToolStripStatusLabel.Name = "mainTimeToolStripStatusLabel"
        Me.mainTimeToolStripStatusLabel.Size = New System.Drawing.Size(135, 19)
        Me.mainTimeToolStripStatusLabel.Text = "00/00/0000 00:00:00 PM"
        '
        'mainMachineToolStripStatusLabel
        '
        Me.mainMachineToolStripStatusLabel.AutoSize = False
        Me.mainMachineToolStripStatusLabel.BorderSides = CType((((System.Windows.Forms.ToolStripStatusLabelBorderSides.Left Or System.Windows.Forms.ToolStripStatusLabelBorderSides.Top) _
                    Or System.Windows.Forms.ToolStripStatusLabelBorderSides.Right) _
                    Or System.Windows.Forms.ToolStripStatusLabelBorderSides.Bottom), System.Windows.Forms.ToolStripStatusLabelBorderSides)
        Me.mainMachineToolStripStatusLabel.Name = "mainMachineToolStripStatusLabel"
        Me.mainMachineToolStripStatusLabel.Size = New System.Drawing.Size(150, 19)
        Me.mainMachineToolStripStatusLabel.Text = "Reg: Dell"
        '
        'mainTimer
        '
        Me.mainTimer.Enabled = True
        Me.mainTimer.Interval = 10000
        '
        'mainNotifyIcon
        '
        Me.mainNotifyIcon.Icon = CType(resources.GetObject("mainNotifyIcon.Icon"), System.Drawing.Icon)
        Me.mainNotifyIcon.Text = "BBIT POS for Ubercart 3"
        Me.mainNotifyIcon.Visible = True
        '
        'loginButton
        '
        Me.loginButton.Enabled = False
        Me.loginButton.Location = New System.Drawing.Point(122, 247)
        Me.loginButton.Name = "loginButton"
        Me.loginButton.Size = New System.Drawing.Size(124, 73)
        Me.loginButton.TabIndex = 1
        Me.loginButton.Text = "&Log In"
        Me.loginButton.UseVisualStyleBackColor = True
        Me.loginButton.Visible = False
        '
        'loadDsBackgroundWorker
        '
        '
        'mainForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(572, 397)
        Me.Controls.Add(Me.mainStatusStrip)
        Me.Controls.Add(Me.MenuStrip1)
        Me.Controls.Add(Me.exitButton)
        Me.Controls.Add(Me.loginButton)
        Me.Controls.Add(Me.openRegisterButton)
        Me.HelpButton = True
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.MinimumSize = New System.Drawing.Size(338, 431)
        Me.Name = "mainForm"
        Me.Text = "BBIT POS for Ubercart 3"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.mainStatusStrip.ResumeLayout(False)
        Me.mainStatusStrip.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents openRegisterButton As System.Windows.Forms.Button
    Friend WithEvents exitButton As System.Windows.Forms.Button
    Friend WithEvents MenuStrip1 As System.Windows.Forms.MenuStrip
    Friend WithEvents AdminToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents OptionsToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents HelpToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents OnlineHelpToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripSeparator1 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents AboutBBITPOSForUbercart3ToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripSeparator2 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents ChangeAdministratorPasswordToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents UpdatePOSDataToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents UpdateSFTPSettingsToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents UpdateToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents RunEndOfDayToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripSeparator3 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents RunConfigurationWizardToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripSeparator4 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents ExitToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ShutDownAfterEndOfDayToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mainStatusStrip As System.Windows.Forms.StatusStrip
    Friend WithEvents mainNetStatusToolStripStatusLabel As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents mainMachineToolStripStatusLabel As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents mainTimer As System.Windows.Forms.Timer
    Friend WithEvents mainTimeToolStripStatusLabel As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents mainNotifyIcon As System.Windows.Forms.NotifyIcon
    Friend WithEvents loginButton As System.Windows.Forms.Button
    Friend WithEvents loadDsBackgroundWorker As System.ComponentModel.BackgroundWorker
End Class
