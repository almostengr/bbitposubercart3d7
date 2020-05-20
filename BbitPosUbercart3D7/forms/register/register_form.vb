Imports BBIT_POS_Utilities
Imports System.ComponentModel

Public Class register_form

    Private PrevResizeX As Integer
    Private PrevResizeY As Integer
    Dim appSettings As New xmlsettings.Settings(My.Application.Info.DirectoryPath)
    Dim utilsMain As New BBIT_POS_Utilities.utils_main
    Dim utilsSftp As New BBIT_POS_Utilities.utils_sftp
    Dim utilsReg As New BBIT_POS_Utilities.utils_register
    Dim bw As BackgroundWorker = New BackgroundWorker
    Private subtotalAmt As Double = 0
    Private taxAmt As Double = 0
    Private totalAmt As Double = 0

    Private isFirstRun As Boolean = False

    Private Sub Me_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        My.Settings.bbitBuildNumber += 1
        Me.Text = My.Settings.storeName + " - " + My.Application.Info.ProductName
        Me.itemTextBox.Clear()
        Me.regSubtotalTextBox.Text = utilsReg.regFormatCurrency(subtotalAmt)
        Me.regTaxTextBox.Text = utilsReg.regFormatCurrency(taxAmt)
        Me.regTotalTextBox.Text = utilsReg.regFormatCurrency(totalAmt)
        Me.regQtyTextBox.Text = "1"

        utilsMain.disableAllControls(Me) 'disable all controls

        'Me.Width = My.Computer.Screen.WorkingArea.Width
        'Me.Height = My.Computer.Screen.WorkingArea.Height

        'background worker thread example 
        'http://msdn.microsoft.com/en-us/library/cc221403%28v=vs.95%29.aspx?cs-save-lang=1&cs-lang=vb#code-snippet-1
    End Sub

    Private Sub registerFormShown(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Shown
        SplashScreen.Show()
        bw.WorkerSupportsCancellation = False
        bw.WorkerReportsProgress = True
        AddHandler bw.DoWork, AddressOf bw_DoWork
        AddHandler bw.ProgressChanged, AddressOf bw_ProgressChanged
        AddHandler bw.RunWorkerCompleted, AddressOf bw_RunWorkerCompleted
        bw.RunWorkerAsync() 'DISABLED FOR DEVELOPMENT PURPOSES
        Me.enterSKUTextBox.Focus() 'sets the focus to the Enter SKU textbox
    End Sub

    Private Sub register_form_resizeBegin(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.ResizeBegin
        PrevResizeX = Me.Size.Width
        PrevResizeY = Me.Size.Height
    End Sub

    Private Sub Me_resize(ByVal sender As System.Object, ByVal e As System.EventArgs)


        Dim increaseX As Integer = Me.Size.Width - PrevResizeX
        Dim increaseY As Integer = Me.Size.Height - PrevResizeY

        If Me.Size.Width > PrevResizeX Or Me.Size.Height > PrevResizeY Then
            'if form size is increased 
            For Each tempControl In Me.Controls
                tempControl.location.x = tempControl.location.x + increaseX
                tempControl.location.y = tempControl.location.y + increaseY

                tempControl.size.x = tempControl.size.x + increaseX
                tempControl.size.y = tempControl.size.y + increaseY
            Next

        ElseIf Me.Size.Width < PrevResizeX Or Me.Size.Height < PrevResizeY Then
            'if form size is decreased 
            For Each tempControl In Me.Controls
                tempControl.location.x = tempControl.location.x - increaseX
                tempControl.location.y = tempControl.location.y - increaseY

                tempControl.size.x = tempControl.size.x - increaseX
                tempControl.size.y = tempControl.size.y - increaseY
            Next

        End If

        'payment_GroupBox.Left = payment_GroupBox /
        'credit_Button.Width = MyBase.Size.Width * 0.10857
        'credit_Button.Left = credit_Button.Left /
        'credit_Button.Height = MyBase.Size.Height * 0.10571


        'http://www.vbforums.com/showthread.php?376702-Classic-VB-Resizing-Controls-on-Form
        'For Each tmpControl In Me.Controls

        '    tmpControl.Left = tmpControl.Left / PrevResizeX * Me.AutoScaleFactor
        '    tmpControl.Top = tmpControl.Top / PrevResizeY * Me.AutoScaleFactor
        '    tmpControl.Width = tmpControl.Width / PrevResizeX * Me.AutoScaleFactor
        '    tmpControl.Height = tmpControl.Height / PrevResizeY * Me.AutoScaleFactor

        'Next tmpControl
    End Sub

    Private Sub enterSKU_TextBox_Enter(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles enterSKUTextBox.Enter
        'search sku
        addItem(enterSKUTextBox.Text)
    End Sub

    Private Sub enterSkuSearch_Button_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles regAddProductButton.Click
        'search SKU
        addItem(enterSKUTextBox.Text)
    End Sub

    Private Sub addItem(ByVal enteredSKU As String)
        'search sku, if found add item, if not found, return error


        statusTextBox.Text = "Searching for item..."

        'query product database for item 

        If False Then
            'if item is found, add to data set, update item display
            itemTextBox.ForeColor = Color.Yellow
            itemTextBox.Text = "ITEM"

            'recalculate subtotal
            'recalculate sales tax
            'recalculate total
        ElseIf False Then
            'if item is not found, display error message 
            itemTextBox.ForeColor = Color.Red
            itemTextBox.Text = "SKU NOT FOUND"
        End If

        enterSKUTextBox.Clear()
        enterSKUTextBox.Focus()
        statusTextBox.Text = "Ready."
    End Sub

    Private Sub enterSKU_TextBox_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles enterSKUTextBox.Click
        clearEnterSku()
    End Sub

    Private Sub clearEnterSku()
        If enterSKUTextBox.Text = "Enter SKU" Then
            enterSKUTextBox.Clear()
        End If
    End Sub

    Private Sub regNum1Button_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles regNum1Button.Click
        clearEnterSku()
        enterSKUTextBox.AppendText("1")
    End Sub

    Private Sub regNum2Button_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles regNum2Button.Click
        clearEnterSku()
        enterSKUTextBox.AppendText("2")
    End Sub

    Private Sub regNum3Button_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles regNum3Button.Click
        clearEnterSku()
        enterSKUTextBox.AppendText("3")
    End Sub

    Private Sub regNum4Button_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles regNum4Button.Click
        clearEnterSku()
        enterSKUTextBox.AppendText("4")
    End Sub

    Private Sub regNum5Button_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles regNum5Button.Click
        clearEnterSku()
        enterSKUTextBox.AppendText("5")
    End Sub

    Private Sub regNum6Button_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles regNum6Button.Click
        clearEnterSku()
        enterSKUTextBox.AppendText("6")
    End Sub

    Private Sub regNum7Button_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles regNum7Button.Click
        clearEnterSku()
        enterSKUTextBox.AppendText("7")
    End Sub

    Private Sub regNum8Button_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles regNum8Button.Click
        clearEnterSku()
        enterSKUTextBox.AppendText("8")
    End Sub

    Private Sub regNum9Button_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles regNum9Button.Click
        clearEnterSku()
        enterSKUTextBox.AppendText("9")
    End Sub

    Private Sub regNum0Button_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles regNum0Button.Click
        clearEnterSku()
        enterSKUTextBox.AppendText("0")
    End Sub

    Private Sub regBkspButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles regBkspButton.Click
        enterSKUTextBox.Clear()
    End Sub

    Private Sub regTimer_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles regTimer.Tick
        regTimeTextBox.Text = DateTime.Now.ToShortDateString() + " " + DateTime.Now.ToLongTimeString
    End Sub

    Private Sub ExitToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ExitToolStripMenuItem.Click
        admin_login_form.ShowDialog()

        admin_login_form.PasswordTextBox.Clear()

        If admin_login_form.getPwdSuccess() = True Then
            Me.Close()
        Else
            MsgBox("Incorrect password!", MsgBoxStyle.Critical, My.Application.Info.ProductName)
        End If
    End Sub

    Private Sub UpdateFTPSettingsToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles UpdateFTPSettingsToolStripMenuItem.Click
        admin_login_form.ShowDialog()

        admin_login_form.PasswordTextBox.Clear()

        If admin_login_form.getPwdSuccess() = True Then
            admin_ftp_dialog.ShowDialog()
        Else
            MsgBox("Incorrect password!", MsgBoxStyle.Critical, My.Application.Info.ProductName)
        End If
    End Sub

    Private Sub AboutBBITPOSForUbercart3ToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AboutBBITPOSForUbercart3ToolStripMenuItem.Click
        AboutBox.Show()
    End Sub

    ''background worker thread example 
    ''http://msdn.microsoft.com/en-us/library/cc221403%28v=vs.95%29.aspx?cs-save-lang=1&cs-lang=vb#code-snippet-1

    Private Sub bw_DoWork(ByVal sender As Object, ByVal e As DoWorkEventArgs)
        'Dim worker As BackgroundWorker = CType(sender, BackgroundWorker)

        If bw.CancellationPending = True Then
            'do nothing
        Else
            Dim connTestPassed As Boolean = False
            Dim connTestAttempts As Integer = 1

            If My.Computer.FileSystem.FileExists(My.Application.Info.DirectoryPath + "\Settings.xml") = False Then
                'run initial setup for application
                'Me.regStatusTextBox.Text = "Preparing for first-time use..." + vbNewLine
                bw.ReportProgress(5, "Preparing for first-time use...")
                isFirstRun = True
            End If

            Do
                appSettings.SetSetting("ranEndOfDayReport", "N")
                'Me.regStatusTextBox.Text = "Verifying connection to website..."

                bw.ReportProgress(10, "Verifying connection to website...")

                'test ftp settings 
                connTestPassed = utilsSftp.testSftpConnection(appSettings.GetSetting("ftpServer"),
                                                            appSettings.GetSetting("ftpServerPort"),
                                                            appSettings.GetSetting("ftpUsername"),
                                                            appSettings.GetSetting("ftpPassword"),
                                                            appSettings.GetSetting("sshKey")
                                                            )

                If connTestPassed = False And connTestAttempts > 1 Then
                    'if settings don't work, alert user, then prompt again
                    MsgBox("Unable to connect to website. Please try again.", MsgBoxStyle.Critical, My.Application.Info.ProductName)
                End If

                If connTestPassed = False Then
                    admin_ftp_dialog.Cancel_Button.Visible = False 'hide cancel button
                    admin_ftp_dialog.ShowDialog() 'get FTP settings

                ElseIf connTestPassed = True Then
                    'Me.regStatusTextBox.Text += "Done."
                    bw.ReportProgress(20, "Verifying connection to website...done.")

                End If

                If connTestAttempts >= 3 And connTestPassed = False Then
                    Exit Do 'exits loop if connection is not successful at least three times
                End If

                connTestAttempts += 1
            Loop While connTestPassed = False

            If connTestPassed = True Then
                'MsgBox(My.Settings.bbitBuildNumber)

                'Me.regStatusTextBox.Text = "Getting store settings from website..." 'connect to ftp
                bw.ReportProgress(30, "Getting store settings from website...")

                'downloadFileFromWeb("bbitpos.settings.ini") 'download file

                'Me.regStatusTextBox.Text += "Done."
                bw.ReportProgress(40, "Getting store settings from website...done.")

                'Me.regStatusTextBox.Text = "Reading settings from file..."
                bw.ReportProgress(50, "Reading settings from file...")
                'parse file

                'Me.regStatusTextBox.Text += "Done."
                bw.ReportProgress(60, "Reading settings from file...done.")

                'Me.regStatusTextBox.Text = "Updating store settings in BBIT POS..."
                bw.ReportProgress(70, "Updating store settings in BBIT POS...")
                'save settings from file to xml file

                'Me.regStatusTextBox.Text += "Done."
                bw.ReportProgress(80, "Updating store settings in BBIT POS...done.")

                'Me.regStatusTextBox.Text = "Opening register..."
                'bw.ReportProgress(30, "Getting store settings from website...done.")

                'CLOSING STEP DOES NOT NEED TO BE UPDATED, DONE IN bw_runworkercompleted
            Else
                MsgBox("Unable to connect to website via SFTP. " + My.Application.Info.ProductName + " will now close.",
                        MsgBoxStyle.Exclamation, My.Application.Info.ProductName)
                SplashScreen.Close()
                Me.Close()
            End If
        End If
    End Sub

    Private Sub bw_ProgressChanged(ByVal sender As Object, ByVal e As ProgressChangedEventArgs)
        'Me.regStatusTextBox.Text = e.ProgressPercentage.ToString() & "%"
        SplashScreen.startupStatusLabel.Text = e.ProgressPercentage.ToString() & "% - " & e.UserState
    End Sub

    Private Sub bw_RunWorkerCompleted(ByVal sender As Object, ByVal e As RunWorkerCompletedEventArgs)
        If e.Cancelled = True Then
            SplashScreen.startupStatusLabel.Text = "Canceled!"
        ElseIf e.Error IsNot Nothing Then
            SplashScreen.startupStatusLabel.Text = "Error: " & e.Error.Message
        Else

            If isFirstRun = True Then

            End If

            'Me.regStatusTextBox.Text = "Done!"
            SplashScreen.startupStatusLabel.Text = "Opening register..."

            SplashScreen.Close() 'close splash screen

            're-enable form controls
            utilsMain.enableAllControls(Me)

            'register is now open.
            Me.statusTextBox.Text = "Ready."
        End If
    End Sub

    Private Sub regPayButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles regPayButton.Click
        itemTextBox.Clear() 'clears item textbox
        enterSKUTextBox.Text = "Enter SKU"
        register_amt.ShowDialog()
        'display remaining balance if not paid in full
        'print receipt
        'save order to xml file
    End Sub

    Private Sub regQtyTextBox_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles regQtyTextBox.Click
        If regQtyTextBox.Text >= 5 Then
            regQtyTextBox.Text = "1"
        Else
            regQtyTextBox.Text = CInt(regQtyTextBox.Text) + 1
        End If
    End Sub

    Private Sub regDiscountButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles regDiscountButton.Click
        'create a function for the dealing with logins

    End Sub

    Private Sub regVoidButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles regVoidButton.Click
        'create a function for the dealing with logins
    End Sub

    Private Sub regAdjPriceButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles regAdjPriceButton.Click
        'create a function for the dealing with logins
    End Sub

    Private Sub adjTaxButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles adjTaxButton.Click
        'create a function for the dealing with logins
    End Sub

    Private Sub OnlineHelpToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles OnlineHelpToolStripMenuItem.Click
        utilsMain.onlineHelp()
    End Sub
End Class