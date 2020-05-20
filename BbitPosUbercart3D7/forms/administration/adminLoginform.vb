Public Class adminLoginform
    ' TODO: Insert code to perform custom authentication using the provided username and password 
    ' (See http://go.microsoft.com/fwlink/?LinkId=35339).  
    ' The custom principal can then be attached to the current thread's principal as follows: 
    '     My.User.CurrentPrincipal = CustomPrincipal
    ' where CustomPrincipal is the IPrincipal implementation used to perform authentication. 
    ' Subsequently, My.User will return identity information encapsulated in the CustomPrincipal object
    ' such as the username, display name, etc.

    Dim utilsAdmin As New utils_admin

    Private Sub admin_form_closing(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.FormClosing
        Me.PasswordTextBox.Clear()
    End Sub

    Private Sub OK_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles adminOkButton.Click
        If utilsAdmin.loginCorrect(PasswordTextBox.Text) = True Then
            Me.DialogResult = Windows.Forms.DialogResult.Yes
        Else
            Me.DialogResult = Windows.Forms.DialogResult.No
        End If
        Me.Close()
    End Sub

    Private Sub login_admin_form_LostFocus(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.LostFocus
        Me.PasswordTextBox.Focus()
    End Sub

    Private Sub Cancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles adminCancelButton.Click
        Me.DialogResult = Windows.Forms.DialogResult.Cancel
        Me.Close()
    End Sub

    Private Sub login_admin_form_shown(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Shown
        Me.PasswordTextBox.Focus()
    End Sub

    Private Sub Num_Button_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles adminNum1_Button.Click,
        adminNum2_Button.Click, adminNum3_Button.Click, adminNum4_Button.Click, adminNum5_Button.Click, adminNum6_Button.Click, adminNum7_Button.Click,
        adminNum8_Button.Click, adminNum9_Button.Click, adminNum0_Button.Click

        PasswordTextBox.AppendText(Me.ActiveControl.Text) 'enter the value of the button clicked in the password textbox
    End Sub

End Class
