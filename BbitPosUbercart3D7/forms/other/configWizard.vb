Imports BBIT_POS_Ubercart3_SFTP

Public NotInheritable Class configWizard
    Private appSettings As New xmlsettings.Settings()
    Private utilsSftp As New utils_sftp
    Private utilsAdmin As New utils_admin
    Private timesNextClicked As Integer = 0
    Private isFirstRun = True
    Private writeToPOSLog As New posLogger

    Private Sub firstRunStart_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        If My.Computer.FileSystem.FileExists(My.Application.Info.DirectoryPath + "\settings.xml") = True Then
            isFirstRun = False
        End If
        programLabel.Text = My.Application.Info.ProductName + " Configuration Wizard"
        configSetup()
    End Sub

    Private Sub nextButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles nextButton.Click
        timesNextClicked += 1
        configSetup()
    End Sub

    Private Sub backButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles backButton.Click
        timesNextClicked -= 1
        configSetup()
    End Sub

    Private Sub cancelButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles configCancelButton.Click
        MsgBox("Unable to complete configuration setup.", MsgBoxStyle.Exclamation, My.Application.Info.ProductName)
        'My.Computer.FileSystem.DeleteFile(My.Application.Info.DirectoryPath + "\settings.xml", FileIO.UIOption.OnlyErrorDialogs, FileIO.RecycleOption.SendToRecycleBin)
        writeToPOSLog.logError("User canceled setup.", "INFO")
        Me.DialogResult = Windows.Forms.DialogResult.No
        deleteSettingsFile()
        Me.Close()
    End Sub

    Private Sub configSetup()

        'disables back button when on the first screen
        If timesNextClicked = 0 Then
            backButton.Enabled = False
        Else
            backButton.Enabled = True
        End If

        Try
            If timesNextClicked = 0 Then
                descriptionLabel.Text = "This configuration wizard will help you get started with using " +
                My.Application.Info.ProductName + " with your store's Drupal-based ecommerce website that " +
                "uses Ubercart 3." + vbNewLine + vbNewLine + "Click NEXT to continue."
            ElseIf timesNextClicked = 1 Then
                descriptionLabel.Text = "On the next screen, you will be asked for the website's SFTP crendentials. " +
                    "This information should have been provided to you by your Black Box Innovation Technologies " +
                    "representative. After entering the information, it will be verified to ensure that it is correct." +
                    vbNewLine + vbNewLine + "Click NEXT to continue."
            ElseIf timesNextClicked = 2 Then
                Dim connSftpTestPassed As Boolean = False
                Dim connSftpTestAttempts As Integer = 1

                Do
                    sftpDalog.Cancel_Button.Visible = False 'hide cancel button
                    sftpDalog.ShowDialog() 'get FTP settings
                    sftpDalog.Cancel_Button.Visible = True 'show cancel button

                    'test ftp settings 
                    connSftpTestPassed = utilsSftp.testSftpConnection(appSettings.GetSetting("ftpServer"),
                                                                appSettings.GetSetting("ftpServerPort"),
                                                                appSettings.GetSetting("ftpUsername"),
                                                                appSettings.GetSetting("ftpPassword"),
                                                                appSettings.GetSetting("sshKey")
                                                                )

                    If connSftpTestPassed = False Then
                        'if settings don't work, alert user, then prompt again
                        MsgBox("Unable to connect to website via SFTP. Please verify your login credentials.", _
                                MsgBoxStyle.Critical, My.Application.Info.ProductName)
                        writeToPOSLog.logError("Unable to connect via SFTP.")
                    End If

                    If connSftpTestAttempts >= 3 And connSftpTestPassed = False Then
                        Throw New Exception 'exits loop if connection is not successful at least three times
                    End If

                    connSftpTestAttempts += 1 'increment attempts
                Loop While connSftpTestPassed = False

                descriptionLabel.Text = "Next, you will be asked for your store's website address. This is the " +
                    "website address that you enter in order to access your website. " +
                    "After entering the information, it will be verified to ensure that it is correct." +
                    vbNewLine + vbNewLine + "Click NEXT to continue."

            ElseIf timesNextClicked = 3 Then
                Dim connWebTestPassed As Boolean = False
                Dim connWebTestAttempts As Integer = 1

                Do
                    storeInfoDialog.Cancel_Button.Visible = False
                    storeInfoDialog.ShowDialog()
                    storeInfoDialog.Cancel_Button.Visible = True

                    connWebTestPassed = utilsAdmin.getDataFromWebsite("ping")

                    If connWebTestPassed = False Then
                        MsgBox("Unable to connect to website. Please verify the website address entered.", _
                               MsgBoxStyle.Critical, My.Application.Info.ProductName)

                    End If

                    If connWebTestAttempts >= 3 And connWebTestPassed = False Then
                        Throw New Exception 'exits loop if connection is not successful at least three times
                    End If
                    connWebTestAttempts += 1
                Loop While connWebTestPassed = False

                'If connSftpTestPassed = True And connWebTestPassed = True Then
                '    descriptionLabel.Text = "Connection to " + appSettings.GetSetting("storeName") + "'s website and SFTP " + _
                '        "were successful. " + My.Application.Info.ProductName + " will now copy the store's " + _
                '        "information, products, and customers to this application for local use. The application's " + _
                '        "progress will be displayed during this process."

                descriptionLabel.Text = "Next, please enter the administrator password that you would like to use " +
                    "for this POS system. The administrator password is required to run administrative tasks " +
                    "including end of business day reports, updating store information, and exiting the program. " +
                    "Please enter a numeric password that you will easily remember and that is not easily guessable." +
                    vbNewLine + vbNewLine + "Click NEXT to continue."

            ElseIf timesNextClicked = 4 Then
                pwdChgDialog.Cancel.Visible = False
                pwdChgDialog.ShowDialog()
                pwdChgDialog.Cancel.Visible = True
                descriptionLabel.Text = "Next, " + My.Application.Info.ProductName + " will download the store's " +
                    "information, products, and customers from the store's website. Depending on the number of products " +
                    "and customers that have been entered into the website, the process may take a while to complete." +
                    "Once it has started, the POS system may become unresponsive at times. " +
                    "Please do not force close the system during the update." +
                    vbNewLine + vbNewLine + "Click NEXT to continue."

            ElseIf timesNextClicked = 5 Then
                Dim updateDialogSuccessful As DialogResult

                updateDialogSuccessful = updatePOSStoreData.ShowDialog() 'get all the information from the website
                If updateDialogSuccessful = Windows.Forms.DialogResult.OK Then
                    descriptionLabel.Text = "Congratulations! The configuration wizard has successfully completed. " +
                        My.Application.Info.ProductName + " is now ready for use." + vbNewLine + vbNewLine +
                        "Click FINISH to close this wizard."
                    nextButton.Text = "Finish"
                Else
                    Throw New Exception
                End If

            ElseIf timesNextClicked = 6 Then
                Me.DialogResult = Windows.Forms.DialogResult.Yes
                writeToPOSLog.logError("Setup completed successfully.", "INFO")
                Me.Close()
            End If

            'Loop While timesNextClicked < 6
        Catch ex As Exception
            MsgBox("Unable to complete configuration setup.", MsgBoxStyle.Exclamation, My.Application.Info.ProductName)
            writeToPOSLog.logError("Unable to complete configuration setup. " + ex.Message, "ERROR")
            deleteSettingsFile()
            Me.DialogResult = Windows.Forms.DialogResult.No
            Me.Close()
        End Try
    End Sub

    Private Sub deleteSettingsFile()
        If isFirstRun = True And My.Computer.FileSystem.FileExists(My.Application.Info.DirectoryPath + "\settings.xml") = True Then
            'if it is the first run, then delete the settings file when canceled
            My.Computer.FileSystem.DeleteFile(My.Application.Info.DirectoryPath + "\data\settings.xml",
                                              FileIO.UIOption.OnlyErrorDialogs, FileIO.RecycleOption.SendToRecycleBin)
            writeToPOSLog.logError("Deleted settings file since setup did not complete.", "INFO")
        End If
    End Sub

    Protected Overrides ReadOnly Property CreateParams() As CreateParams
        'disables close or X button
        Get
            Dim param As CreateParams = MyBase.CreateParams
            param.ClassStyle = param.ClassStyle Or &H200
            Return param
        End Get
    End Property
End Class
