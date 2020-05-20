Imports BBIT_POS_Utilities.utils_admin
Public Class admin_login_form

    ' TODO: Insert code to perform custom authentication using the provided username and password 
    ' (See http://go.microsoft.com/fwlink/?LinkId=35339).  
    ' The custom principal can then be attached to the current thread's principal as follows: 
    '     My.User.CurrentPrincipal = CustomPrincipal
    ' where CustomPrincipal is the IPrincipal implementation used to perform authentication. 
    ' Subsequently, My.User will return identity information encapsulated in the CustomPrincipal object
    ' such as the username, display name, etc.

    Private Function OK_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles OK.Click
        Dim utilsAdmin As New BBIT_POS_Utilities.utils_admin
        Dim loginCorrect As Boolean = False

        loginCorrect = utilsAdmin.loginCorrect(PasswordTextBox.Text)

        Me.Close()
        Return loginCorrect
    End Function

    Private Sub login_admin_form_LostFocus(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.LostFocus
        Me.Focus()
        Me.PasswordTextBox.Focus()
    End Sub

    Private Function Cancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Cancel.Click
        Me.Close()
        Return False
    End Function

    Private Sub login_admin_form_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.PasswordTextBox.Focus()
    End Sub

    Private Sub Num1_Button_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Num1_Button.Click
        PasswordTextBox.AppendText("1")
    End Sub

    Private Sub Num2_Button_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Num2_Button.Click
        PasswordTextBox.AppendText("2")
    End Sub

    Private Sub Num3_Button_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Num3_Button.Click
        PasswordTextBox.AppendText("3")
    End Sub

    Private Sub Num4_Button_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Num4_Button.Click
        PasswordTextBox.AppendText("4")
    End Sub

    Private Sub Num5_Button_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Num5_Button.Click
        PasswordTextBox.AppendText("5")
    End Sub

    Private Sub Num6_Button_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Num6_Button.Click
        PasswordTextBox.AppendText("6")
    End Sub

    Private Sub Num7_Button_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Num7_Button.Click
        PasswordTextBox.AppendText("7")
    End Sub

    Private Sub Num8_Button_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles NUm8_Button.Click
        PasswordTextBox.AppendText("8")
    End Sub

    Private Sub Num9_Button_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Num9_Button.Click
        PasswordTextBox.AppendText("9")
    End Sub

    Private Sub Num0_Button_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Num0_Button.Click
        PasswordTextBox.AppendText("0")
    End Sub

End Class
