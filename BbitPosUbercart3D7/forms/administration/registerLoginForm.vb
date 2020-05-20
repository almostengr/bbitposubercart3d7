Imports System.Data.Objects

Public Class registerLoginForm

    ' TODO: Insert code to perform custom authentication using the provided username and password 
    ' (See http://go.microsoft.com/fwlink/?LinkId=35339).  
    ' The custom principal can then be attached to the current thread's principal as follows: 
    '     My.User.CurrentPrincipal = CustomPrincipal
    ' where CustomPrincipal is the IPrincipal implementation used to perform authentication. 
    ' Subsequently, My.User will return identity information encapsulated in the CustomPrincipal object
    ' such as the username, display name, etc.

    Private currentField As Char


    Private Sub OK_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles regLogOkButton.Click
        clearFields()
        Me.DialogResult = Windows.Forms.DialogResult.Yes
        Me.Close()
    End Sub

    Private Sub Cancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles regLogCancelButton.Click
        clearFields()
        Me.DialogResult = Windows.Forms.DialogResult.Cancel
        Me.Close()
    End Sub

    Private Sub clearFields()
        UsernameTextBox.Clear()
        PasscodeTextBox.Clear()
    End Sub

    Private Sub registerLoginForm_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        currentField = "U"
        UsernameTextBox.Focus()
    End Sub

    Private Sub Num_Button_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles regLogNum1_Button.Click,
        regLogNum2_Button.Click, regLogNum3_Button.Click, regLogNum4_Button.Click, regLogNum5_Button.Click, regLogNum6_Button.Click,
        regLogNum7_Button.Click, regLogNum8_Button.Click, regLogNum9_Button.Click, regLogNum0_Button.Click

        If currentField = "U" Then
            UsernameTextBox.AppendText(Me.ActiveControl.Text)
        ElseIf currentField = "P" Then
            PasscodeTextBox.AppendText(Me.ActiveControl.Text)
        End If

    End Sub

    Private Sub PasscodeTextBox_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PasscodeTextBox.TextChanged
        currentField = "P"
    End Sub

    Private Sub UsernameTextBox_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles UsernameTextBox.TextChanged
        currentField = "U"
    End Sub
End Class
