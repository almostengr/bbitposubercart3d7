Imports System.ComponentModel

Public Class mainForm
    Private internetConnected As Boolean = False 'false when not able to connect to the website
    Private internetConnectedNotified As Boolean = False 'alerts of no connection when false
    Private utils As New BbitPosUbercart3D7.utilities
    Private utilsAdmin As New BbitPosUbercart3D7.utils_admin
    Private bw As New BackgroundWorker
    Private writeToPOSLog As New posLogger

    Private Sub mainForm_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.Text = My.Application.Info.ProductName
        mainMachineToolStripStatusLabel.Text = "Reg: " + My.Computer.Name
        registerForm.machineToolStripStatusLabel.Text = "Reg: " + My.Computer.Name
        'loginButton.Enabled = False 'True
    End Sub

    Private Sub mainForm_Shown(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Shown
        'if first run, get settings
        'download data from website
        'update database, settings file
        'enable all controls

        'if not first run, enable all controls


        Dim configSuccess As System.Windows.Forms.DialogResult = Windows.Forms.DialogResult.No

        utils.disableAllControls(Me)
        'splashScreen.Show()
        bw.WorkerSupportsCancellation = False
        bw.WorkerReportsProgress = True
        AddHandler bw.DoWork, AddressOf bw_DoWork
        AddHandler bw.ProgressChanged, AddressOf bw_ProgressChanged
        AddHandler bw.RunWorkerCompleted, AddressOf bw_RunWorkerCompleted

        If My.Computer.FileSystem.FileExists(My.Application.Info.DirectoryPath + "\settings.xml") = False Then
            'if settings file doesn't exist, then run config wizard
            configSuccess = configWizard.ShowDialog()
            configWizard.Dispose() 'get rid of the class when done
        Else
            ''check if necessary files exist, if not download them
            'If My.Computer.FileSystem.FileExists(My.Application.Info.DirectoryPath + "\customers.txt") = False Or
            '    My.Computer.FileSystem.FileExists(My.Application.Info.DirectoryPath + "\products.txt") = False Then
            '    'if customers file doesn't exist, then try to get it 

            '    configSuccess = Windows.Forms.DialogResult.No
            'Else
            configSuccess = Windows.Forms.DialogResult.Yes 'bypass config wizard, if settings exist
            'End If
        End If

        If configSuccess = Windows.Forms.DialogResult.Yes Then
            loadDsBackgroundWorker.RunWorkerAsync()
            isInternetConnected() 'checks internet connection 
            loginButton.Enabled = True
            utils.enableAllControls(Me)
        Else
            MsgBox("The configuration wizard did not complete the initial setup successfully. " + _
                   My.Application.Info.ProductName + " will now exit.", MsgBoxStyle.Critical, My.Application.Info.ProductName)
            writeToPOSLog.logError("Configuration wizard did not complete initial setup.", "INFO")
            Me.Close()
        End If
    End Sub

    'MAIN MENU BUTTONS
    Private Sub openRegister_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles openRegisterButton.Click
        openRegisterButton.Enabled = False 'disable button
        openRegisterButton.Text = "Opening..."
        registerForm.ShowDialog()
        openRegisterButton.Enabled = True 'enable button
        openRegisterButton.Text = "Open &Register"
    End Sub

    Private Sub exitButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles exitButton.Click, ExitToolStripMenuItem.Click
        Dim dialogResult As DialogResult
        dialogResult = MsgBox("Are you sure you want to exit " + My.Application.Info.ProductName + "?", _
                              MsgBoxStyle.YesNo, My.Application.Info.ProductName)
        If dialogResult = Windows.Forms.DialogResult.Yes Then
            If loginButton.Text = "Log Out" Then
                loginButton.PerformClick() 'log out before closing program
            End If
            'writeToPOSLog.logError("INFO: Exiting " + My.Application.Info.ProductName)
            Me.Close()
        End If
    End Sub


    'HELP MENU LINKS
    Private Sub OnlineHelpToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles OnlineHelpToolStripMenuItem.Click
        System.Diagnostics.Process.Start("http://www.blackboxitech.com/bbitpos")
    End Sub

    Private Sub AboutBBITPOSForUbercart3ToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AboutBBITPOSForUbercart3ToolStripMenuItem.Click
        AboutBox.ShowDialog()
    End Sub
    'END HELP MENU LINKS


    'POS MENU LINKS
    Private Sub RunConfigurationWizardToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RunConfigurationWizardToolStripMenuItem.Click
        Dim dialogResult As Windows.Forms.DialogResult
        dialogResult = adminLoginform.ShowDialog()

        If dialogResult = Windows.Forms.DialogResult.Yes Then
            configWizard.ShowDialog()
        ElseIf dialogResult = Windows.Forms.DialogResult.No Then
            utilsAdmin.invalidPassword()
        End If
        configWizard.Dispose()
    End Sub

    Private Sub UpdateToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles UpdateToolStripMenuItem.Click
        Dim dialogResult As Windows.Forms.DialogResult
        dialogResult = adminLoginform.ShowDialog()

        If dialogResult = Windows.Forms.DialogResult.Yes Then
            storeInfoDialog.ShowDialog()
        ElseIf dialogResult = Windows.Forms.DialogResult.No Then
            utilsAdmin.invalidPassword()
        End If
    End Sub

    Private Sub UpdatePOSDataToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles UpdatePOSDataToolStripMenuItem.Click
        Dim dialogResult As Windows.Forms.DialogResult
        dialogResult = adminLoginform.ShowDialog()

        If dialogResult = Windows.Forms.DialogResult.Yes Then
            Dim continueResult As DialogResult
            Dim continueWarning As String = "Update store data process should not be ran during business hours due to the " + _
                "amount of time required to complete the update process.  Are you sure you want to continue?"
            continueResult = MsgBox(continueWarning, MsgBoxStyle.YesNo, My.Application.Info.ProductName)

            If continueResult = Windows.Forms.DialogResult.Yes Then
                updatePOSStoreData.ShowDialog()
            End If
        ElseIf dialogResult = Windows.Forms.DialogResult.No Then
            utilsAdmin.invalidPassword()
        End If
    End Sub

    Private Sub UpdateSFTPSettingsToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles UpdateSFTPSettingsToolStripMenuItem.Click
        Dim dialogResult As Windows.Forms.DialogResult
        dialogResult = adminLoginform.ShowDialog()

        If dialogResult = Windows.Forms.DialogResult.Yes Then
            sftpDalog.ShowDialog()
        ElseIf dialogResult = Windows.Forms.DialogResult.No Then
            utilsAdmin.invalidPassword()
        End If
    End Sub

    Private Sub ChangeAdministratorPasswordToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ChangeAdministratorPasswordToolStripMenuItem.Click
        Dim dialogResult As Windows.Forms.DialogResult
        dialogResult = adminLoginform.ShowDialog()

        If dialogResult = Windows.Forms.DialogResult.Yes Then
            pwdChgDialog.ShowDialog()
        ElseIf dialogResult = Windows.Forms.DialogResult.No Then
            utilsAdmin.invalidPassword()
        End If
    End Sub

    Private Sub RunEndOfDayToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RunEndOfDayToolStripMenuItem.Click
        Dim dialogResult As Windows.Forms.DialogResult
        Dim dialogResult2 As Windows.Forms.DialogResult
        dialogResult = adminLoginform.ShowDialog()

        If dialogResult = Windows.Forms.DialogResult.Yes Then
            Dim endOfBusDayMsg As String = "End of Business Day report takes a long time to complete. This " + _
                "process, as the name implies, should be ran after business hours. Are you sure that you want to continue?"
            dialogResult2 = MsgBox(endOfBusDayMsg, MsgBoxStyle.YesNo, My.Application.Info.ProductName)

            If dialogResult2 = Windows.Forms.DialogResult.Yes Then
                'endOfBusDay.ShowDialog()
                'updateStoreInfo.ShowDialog()
                'updateProductDb.ShowDialog()
                If utilsAdmin.getShutDownEndOfBusDay() = True Then
                    System.Diagnostics.Process.Start("c:\windows\system32\shutdown.exe", "-t 10 -s -f")
                End If
            End If
        ElseIf dialogResult = Windows.Forms.DialogResult.No Then
            utilsAdmin.invalidPassword()
        End If
    End Sub

    Private Sub ShutDownAfterEndOfBusinessDayProcessingToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Dim dialogResult As Windows.Forms.DialogResult
        dialogResult = adminLoginform.ShowDialog()

        If dialogResult = Windows.Forms.DialogResult.Yes Then
            If ShutDownAfterEndOfDayToolStripMenuItem.Checked = False Then
                utilsAdmin.updateShutDownEndOfBusDay(True)
                ShutDownAfterEndOfDayToolStripMenuItem.Checked = True
            Else
                utilsAdmin.updateShutDownEndOfBusDay(False)
                ShutDownAfterEndOfDayToolStripMenuItem.Checked = False
            End If
        ElseIf dialogResult = Windows.Forms.DialogResult.No Then
            utilsAdmin.invalidPassword()
        End If
    End Sub
    'END POS MENU LINKS

    Public Sub setInternetConnStatus(ByVal currentlyConnected As Boolean)

    End Sub

    Public Sub isInternetConnected()
        internetConnected = utilsAdmin.getDataFromWebsite("ping")

        If internetConnected = True Then
            'if can connect to website, show online
            mainNetStatusToolStripStatusLabel.ForeColor = Color.Lime
            mainNetStatusToolStripStatusLabel.Text = "Online"
            registerForm.netStatusToolStripStatusLabel.ForeColor = Color.Lime
            registerForm.netStatusToolStripStatusLabel.Text = "Online"
            internetConnectedNotified = False 'reset notification
        Else
            'if can't connect to the internet, then show offline
            mainNetStatusToolStripStatusLabel.ForeColor = Color.OrangeRed
            mainNetStatusToolStripStatusLabel.Text = "Offline"
            registerForm.netStatusToolStripStatusLabel.ForeColor = Color.OrangeRed
            registerForm.netStatusToolStripStatusLabel.Text = "Offline"

            If internetConnectedNotified = False Then
                Dim ballonText As String = My.Application.Info.ProductName + " is not connected to the internet. " +
                    "Orders can still be created, but will be saved on this computer. When the connection is restored, " +
                    "saved orders will be sent to the store's website for processing."
                mainNotifyIcon.ShowBalloonTip(20000, "Not Connected", ballonText, System.Windows.Forms.ToolTipIcon.Warning)
                internetConnectedNotified = True
            End If
        End If
    End Sub

    Private Sub mainTimer_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mainTimer.Tick
        'ticks every 10 seconds
        mainTimeToolStripStatusLabel.Text = Date.Now.ToShortDateString + " " + Date.Now.ToShortTimeString
        registerForm.regTimeToolStripStatusLabel.Text = Date.Now.ToShortDateString + " " + Date.Now.ToShortTimeString

        'If DateTime.Now.Second = 15 Or DateTime.Now.Second = 45 Then
        '    'check the internet connection every 30 seconds
        '    isInternetConnected()
        'End If
    End Sub

    Protected Overrides ReadOnly Property CreateParams() As CreateParams
        'disables close or X button
        Get
            Dim param As CreateParams = MyBase.CreateParams
            param.ClassStyle = param.ClassStyle Or &H200
            Return param
        End Get
    End Property

    ''ACTIONS DONE BASED ON FORM CONTROLS AND BUTTONS
    'Private Sub registerFormShown(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Shown
    '    splashScreen.Show()
    '    bw.WorkerSupportsCancellation = False
    '    bw.WorkerReportsProgress = True
    '    AddHandler bw.DoWork, AddressOf bw_DoWork
    '    AddHandler bw.ProgressChanged, AddressOf bw_ProgressChanged
    '    AddHandler bw.RunWorkerCompleted, AddressOf bw_RunWorkerCompleted
    'End Sub




    'BACKGROUND WORKER STUFF DONE ON STARTUP
    Private Sub bw_DoWork(ByVal sender As Object, ByVal e As DoWorkEventArgs)
        ''background worker thread example 
        ''http://msdn.microsoft.com/en-us/library/cc221403%28v=vs.95%29.aspx?cs-save-lang=1&cs-lang=vb#code-snippet-1

        If bw.CancellationPending = True Then
            'do nothing
        Else
            Try
                'STARTUP PROCESS 

                bw.ReportProgress(80, "Updating store settings in BBIT POS...done.")

                'CLOSING STEP DOES NOT NEED TO BE UPDATED, DONE IN bw_runworkercompleted
            Catch ex As Exception
                MsgBox("An error occurred when trying to start the application. BBIT POS will now close.", MsgBoxStyle.Critical, My.Application.Info.ProductName)
                Me.Close()
            End Try
        End If
    End Sub

    Private Sub bw_ProgressChanged(ByVal sender As Object, ByVal e As ProgressChangedEventArgs)
        splashScreen.startupStatusLabel.Text = e.ProgressPercentage.ToString() & "% - " & e.UserState
    End Sub

    Private Sub bw_RunWorkerCompleted(ByVal sender As Object, ByVal e As RunWorkerCompletedEventArgs)
        If e.Cancelled = True Then
            splashScreen.startupStatusLabel.Text = "Canceled!"
        ElseIf e.Error IsNot Nothing Then
            splashScreen.startupStatusLabel.Text = "Error: " & e.Error.Message
        Else
            splashScreen.Close() 'close splash screen
            utils.enableAllControls(Me) 're-enable form controls
        End If
    End Sub
    'END OF BACKGROUND WORKER STUFF DONE ON STARTUP 

    Private Sub loadDsBackgroundWorker_DoWork(ByVal sender As System.Object, ByVal e As System.ComponentModel.DoWorkEventArgs) Handles loadDsBackgroundWorker.DoWork
        'Dim posDatabase As posdbDataSet

        'ucProductsDT = utils.BuildDataTable("products.txt", "|")
        'ucCustomersDT = utils.BuildDataTable("customers.txt", "|")
    End Sub

End Class