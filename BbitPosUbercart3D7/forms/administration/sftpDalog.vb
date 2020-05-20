Imports System.Windows.Forms

Public Class sftpDalog
    Private utils As New BbitPosUbercart3D7.utilities
    Private utilsSftp As New BBIT_POS_Ubercart3_SFTP.utils_sftp
    Private appSettings As xmlsettings.Settings = New xmlsettings.Settings()

    Private Sub OK_Button_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles OK_Button.Click
        Dim didSave As Boolean
        didSave = utilsSftp.saveSftpSettings(server_TextBox.Text, portNum_TextBox.Text, username_TextBox.Text,
                                        password_TextBox.Text, sshFingerprint_TextBox.Text, rootFolderTextBox.Text)
        If didSave = True Then
            Me.DialogResult = System.Windows.Forms.DialogResult.OK
            Me.Close()
        Else
            'if fields were left blank, prompt user, do not save 
            MsgBox("All fields are required. Please enter all the requested information.", _
                   MsgBoxStyle.Exclamation, My.Application.Info.ProductName)
        End If
    End Sub

    Private Sub Cancel_Button_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Cancel_Button.Click
        Me.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.Close()
    End Sub

    Private Sub readSettings()
        'if settings already exist, load them into the form.
        server_TextBox.Text = appSettings.GetSetting("ftpServer")
        portNum_TextBox.Text = appSettings.GetSetting("ftpServerPort")
        username_TextBox.Text = appSettings.GetSetting("ftpUsername")
        password_TextBox.Text = appSettings.GetSetting("ftpPassword")
        sshFingerprint_TextBox.Text = appSettings.GetSetting("sshKey")
        rootFolderTextBox.Text = appSettings.GetSetting("ftpRootFolder")
    End Sub

    Private Sub admin_ftp_dialog_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        readSettings()
    End Sub

    Private Sub testConn_Button_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles testConn_Button.Click
        Dim connectionResult As Boolean

        utils.disableAllControls(Me)
        connectionResult = utilsSftp.testSftpConnection(server_TextBox.Text, portNum_TextBox.Text, username_TextBox.Text,
                                                   password_TextBox.Text, sshFingerprint_TextBox.Text)
        If connectionResult = True Then
            MsgBox("Connection successful!", MsgBoxStyle.Information, My.Application.Info.ProductName)
        Else
            MsgBox("Unable to connect. Please try again.", MsgBoxStyle.Critical, My.Application.Info.ProductName)
        End If
        testConn_Button.Enabled = True
        utils.enableAllControls(Me)
    End Sub
End Class
