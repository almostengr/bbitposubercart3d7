Imports System.Configuration
Imports System
Imports xmlsettings.Settings
Imports BBIT_POS_Utilities.utils_main

Public Class admin_form

    Dim utilsMain As New BBIT_POS_Utilities.utils_main
    Dim appSettings As New xmlsettings.Settings(My.Application.Info.DirectoryPath)

    Private Function getCurrentTime()
        Return DateTime.Now.ToShortDateString() + " " + DateTime.Now.ToLongTimeString() + " - "
    End Function

    Private Sub disableButtons() 'disable the button controls
        For Each tempControl In Me.Controls
            tempControl.enabled = False
        Next
    End Sub

    Private Sub enablebuttons() 'enable the button controls
        For Each tempcontrol In Me.Controls
            tempcontrol.enabled = True
        Next
    End Sub

    Private Sub exit_Button_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles exit_Button.Click
        Me.Close()
    End Sub

    Private Sub cngFtpSettings_Button_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cngFtpSettings_Button.Click
        admin_ftp_dialog.Cancel_Button.Visible = True
        admin_ftp_dialog.ShowDialog()
    End Sub

    Private Sub updateStoreInfo_Button_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles updateStoreInfo_Button.Click
        'get the store's information from the website via ftp

        adminFormToolStripStatusLabel.Text = getCurrentTime() + "Updating store information... "
        Me.disableButtons()
        adminFormToolStripStatusLabel.Text = "Connecting to website and downloading file..."

        '        utils.downloadFileFromWeb("")

        adminFormToolStripStatusLabel.Text = "Reading information from file..."

        adminFormToolStripStatusLabel.Text = "Saving store information..."

        Me.enablebuttons()
        adminFormToolStripStatusLabel.Text = "Ready."
    End Sub

    Private Sub updateProducts_Button_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles updateProducts_Button.Click
        'connect to the website via ftp
        'get file with product info 
        'file contents: product name, product sku, product price, 
        'close ftp connection
        'read file
        'parse file
        'update the local database

        utilsMain.disableAllControls(Me)
        adminFormToolStripStatusLabel.Text = getCurrentTime() + "Updating local products database..."
        adminFormToolStripStatusLabel.Text = getCurrentTime() + "Connecting to FTP..."

        'connect to ftp server
        adminFormToolStripStatusLabel.Text = getCurrentTime() + "Done."
        'transfer file to application directory 
        'close connection
        'update settings
        'report process is done 
        're-enable buttons

        utilsMain.enableAllControls(Me)

    End Sub


End Class