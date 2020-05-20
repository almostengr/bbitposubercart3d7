Imports System.Windows.Forms

Public Class storeInfoDialog
    Private appSettings As New xmlsettings.Settings()

    Private Sub OK_Button_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles OK_Button.Click
        If storeWebsiteTextBox.Text.Length > 6 Then
            If storeWebsiteTextBox.Text.StartsWith("http://") = False Then
                'if it does not start with "http://" then add it
                storeWebsiteTextBox.Text = "http://" + storeWebsiteTextBox.Text
            End If

            appSettings.SetSetting("storeWebsite", storeWebsiteTextBox.Text) 'save website to settings
            Me.DialogResult = System.Windows.Forms.DialogResult.OK
            Me.Close()
        Else
            'alert if website string is too short
            MsgBox("The website entered is too short. Please try again.", MsgBoxStyle.Critical, My.Application.Info.ProductName)
        End If
    End Sub

    Private Sub Cancel_Button_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Cancel_Button.Click
        Me.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.Close()
    End Sub

    Private Sub storeInfoDialog_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        storeWebsiteTextBox.Text = appSettings.GetSetting("storeWebsite")
        storeNameTextBox.Text = appSettings.GetSetting("storeName")
        addr1TextBox.Text = appSettings.GetSetting("storeAddr1")
        addr2TextBox.Text = appSettings.GetSetting("storeAddr2")
        cityTextBox.Text = appSettings.GetSetting("storeCity")
        stateTextBox.Text = appSettings.GetSetting("storeState")
        postalTextBox.Text = appSettings.GetSetting("storeZip")
        phoneTextBox.Text = appSettings.GetSetting("storePhone")
    End Sub
End Class
