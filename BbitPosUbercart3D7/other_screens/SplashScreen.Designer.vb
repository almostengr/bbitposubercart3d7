<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class SplashScreen
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
        Me.splash_PictureBox = New System.Windows.Forms.PictureBox()
        Me.ApplicationTitle = New System.Windows.Forms.Label()
        Me.Version = New System.Windows.Forms.Label()
        Me.Copyright = New System.Windows.Forms.Label()
        Me.websiteUrl = New System.Windows.Forms.Label()
        Me.startupStatusLabel = New System.Windows.Forms.Label()
        Me.splashBackgroundWorker = New System.ComponentModel.BackgroundWorker()
        CType(Me.splash_PictureBox, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'splash_PictureBox
        '
        Me.splash_PictureBox.Image = Global.BbitPosUbercart3D7.My.Resources.Resources.companylogo
        Me.splash_PictureBox.Location = New System.Drawing.Point(179, 58)
        Me.splash_PictureBox.Name = "splash_PictureBox"
        Me.splash_PictureBox.Size = New System.Drawing.Size(291, 120)
        Me.splash_PictureBox.TabIndex = 0
        Me.splash_PictureBox.TabStop = False
        '
        'ApplicationTitle
        '
        Me.ApplicationTitle.AutoSize = True
        Me.ApplicationTitle.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ApplicationTitle.Location = New System.Drawing.Point(12, 9)
        Me.ApplicationTitle.Name = "ApplicationTitle"
        Me.ApplicationTitle.Size = New System.Drawing.Size(199, 31)
        Me.ApplicationTitle.TabIndex = 1
        Me.ApplicationTitle.Text = "ApplicationTitle"
        '
        'Version
        '
        Me.Version.AutoSize = True
        Me.Version.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Version.Location = New System.Drawing.Point(12, 206)
        Me.Version.Name = "Version"
        Me.Version.Size = New System.Drawing.Size(63, 20)
        Me.Version.TabIndex = 2
        Me.Version.Text = "Version"
        '
        'Copyright
        '
        Me.Copyright.AutoSize = True
        Me.Copyright.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Copyright.Location = New System.Drawing.Point(12, 186)
        Me.Copyright.Name = "Copyright"
        Me.Copyright.Size = New System.Drawing.Size(76, 20)
        Me.Copyright.TabIndex = 3
        Me.Copyright.Text = "Copyright"
        '
        'websiteUrl
        '
        Me.websiteUrl.AutoSize = True
        Me.websiteUrl.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.websiteUrl.Location = New System.Drawing.Point(12, 226)
        Me.websiteUrl.Name = "websiteUrl"
        Me.websiteUrl.Size = New System.Drawing.Size(176, 20)
        Me.websiteUrl.TabIndex = 4
        Me.websiteUrl.Text = "www.blackboxitech.com"
        '
        'startupStatusLabel
        '
        Me.startupStatusLabel.AutoSize = True
        Me.startupStatusLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.startupStatusLabel.Location = New System.Drawing.Point(12, 274)
        Me.startupStatusLabel.Name = "startupStatusLabel"
        Me.startupStatusLabel.Size = New System.Drawing.Size(102, 20)
        Me.startupStatusLabel.TabIndex = 5
        Me.startupStatusLabel.Text = "Starting Up..." & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        '
        'splashBackgroundWorker
        '
        Me.splashBackgroundWorker.WorkerReportsProgress = True
        '
        'SplashScreen
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(496, 303)
        Me.ControlBox = False
        Me.Controls.Add(Me.startupStatusLabel)
        Me.Controls.Add(Me.websiteUrl)
        Me.Controls.Add(Me.Copyright)
        Me.Controls.Add(Me.Version)
        Me.Controls.Add(Me.ApplicationTitle)
        Me.Controls.Add(Me.splash_PictureBox)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "SplashScreen"
        Me.ShowInTaskbar = False
        Me.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        CType(Me.splash_PictureBox, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents splash_PictureBox As System.Windows.Forms.PictureBox
    Friend WithEvents ApplicationTitle As System.Windows.Forms.Label
    Friend WithEvents Version As System.Windows.Forms.Label
    Friend WithEvents Copyright As System.Windows.Forms.Label
    Friend WithEvents websiteUrl As System.Windows.Forms.Label
    Friend WithEvents startupStatusLabel As System.Windows.Forms.Label
    Friend WithEvents splashBackgroundWorker As System.ComponentModel.BackgroundWorker

End Class
