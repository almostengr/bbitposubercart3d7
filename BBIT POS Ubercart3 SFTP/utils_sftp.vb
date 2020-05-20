Imports WinSCP
Imports xmlsettings.Settings

Public Class utils_sftp
    Private appSettings As New xmlsettings.Settings()
    Private sessionOptions As New WinSCP.SessionOptions
    Private session As New WinSCP.Session

    Public Function saveSftpSettings(ByVal hostname As String, ByVal hostPort As String, ByVal username As String,
                                       ByVal password As String, ByVal sshFingerprint As String,
                                       ByVal rootFolder As String) As Boolean

        Dim saveSuccessful As Boolean = False

        If hostname = "" Or username = "" Or password = "" Or sshFingerprint = "" Then
            saveSuccessful = False 'if fields have not been entered, do not save
        Else
            If hostPort = "" Then
                hostPort = "22" 'if port number hasn't been entered, then default it to 22.
            End If

            'save settings
            appSettings.SetSetting("ftpServer", Replace(hostname, "sftp://", ""))
            appSettings.SetSetting("ftpServerPort", hostPort)
            appSettings.SetSetting("ftpUsername", username)
            appSettings.SetSetting("ftpPassword", password)
            appSettings.SetSetting("sshKey", sshFingerprint)
            appSettings.SetSetting("ftpRootFolder", rootFolder)
            saveSuccessful = True
        End If

        Return saveSuccessful
    End Function

    Public Function testSftpConnection(ByVal hostname As String, ByVal hostPort As String, ByVal username As String,
                                        ByVal password As String, ByVal sshFingerprint As String)

        Dim testSuccessful As Boolean = False

        If hostPort = "" Then
            hostPort = "22" 'if hostport is not set, then set it to the default value
        End If

        Try
            Dim ftpSessionOptions As New SessionOptions
            With sessionOptions
                .Protocol = Protocol.Sftp
                .HostName = Replace(hostname, "sftp://", "")
                .PortNumber = CInt(hostPort)
                .UserName = username
                .Password = password
                .SshHostKeyFingerprint = sshFingerprint
            End With

            Using session As Session = New Session
                session.Open(sessionOptions) 'connect to sever
                If session.Opened = True Then
                    testSuccessful = True
                Else
                    testSuccessful = False
                End If
            End Using
        Catch ex As Exception
            testSuccessful = False
        End Try
        session.Dispose() 'close connection

        Return testSuccessful
    End Function

    Public Function downloadFileFromWeb(ByVal fileName As String)
        'downloads a file via sftp from server to application directory

        Dim didSucceed As Boolean = False

        Try
            If My.Computer.FileSystem.FileExists(My.Application.Info.DirectoryPath + "\" + fileName) Then

                'if file already exists on system, delete it
                My.Computer.FileSystem.DeleteFile(My.Application.Info.DirectoryPath + "\" + fileName, _
                                                  FileIO.UIOption.OnlyErrorDialogs, FileIO.RecycleOption.SendToRecycleBin)
            End If

            Dim ftpSessionOptions As New SessionOptions
            With sessionOptions
                .Protocol = Protocol.Sftp
                .HostName = appSettings.GetSetting("ftpServer")
                .PortNumber = CInt(appSettings.GetSetting("ftpServerPort"))
                .UserName = appSettings.GetSetting("ftpUsername")
                .Password = appSettings.GetSetting("ftpPassword")
                .SshHostKeyFingerprint = appSettings.GetSetting("sshKey")
            End With

            Using session As Session = New Session
                session.Open(sessionOptions) ' Connect

                Dim transferOptions As New TransferOptions
                transferOptions.TransferMode = TransferMode.Binary 'Upload files

                Dim transferResult As TransferOperationResult
                'transferResult = session.PutFiles("d:\toupload\*", "/home/user/", False, transferOptions)
                transferResult = session.GetFiles(appSettings.GetSetting("ftpRootFolder") + "/sites/default/files/" + fileName,
                                                  My.Application.Info.DirectoryPath + "\" + fileName,
                                                  False, transferOptions)
                transferResult.Check() ' Throw on any error

                Dim transfer As TransferEventArgs
                For Each transfer In transferResult.Transfers
                    'Console.WriteLine("Upload of {0} succeeded", transfer.FileName) ' Print results
                Next
            End Using
            didSucceed = True
        Catch ex As Exception
            MsgBox("File transfer error occurred!" + vbNewLine + ex.Message,
                   Microsoft.VisualBasic.MsgBoxStyle.Critical, My.Application.Info.ProductName)
            didSucceed = False
            Throw New Exception("failed")
        End Try

        session.Dispose() 'close connection
        Return didSucceed
    End Function

    Public Sub uploadFileToWeb(ByVal fileName As String)
        'uploads a file via sftp from application directory to server

        Try
            Dim ftpSessionOptions As New SessionOptions
            With sessionOptions
                .Protocol = Protocol.Sftp
                .HostName = appSettings.GetSetting("ftpServer")
                .PortNumber = CInt(appSettings.GetSetting("ftpServerPort"))
                .UserName = appSettings.GetSetting("ftpUsername")
                .Password = appSettings.GetSetting("ftpPassword")
                .SshHostKeyFingerprint = appSettings.GetSetting("sshKey")
            End With

            Using session As Session = New Session
                session.Open(sessionOptions) 'Connect

                Dim transferOptions As New TransferOptions
                transferOptions.TransferMode = TransferMode.Binary 'Upload files

                Dim transferResult As TransferOperationResult
                transferResult = session.PutFiles(My.Application.Info.DirectoryPath + "\" + fileName,
                                                  appSettings.GetSetting("ftpRootFolder") + "/sites/default/files/" + fileName,
                                                  False, transferOptions)

                transferResult.Check() 'Throw on any error

                Dim transfer As TransferEventArgs
                For Each transfer In transferResult.Transfers
                    'Console.WriteLine("Upload of {0} succeeded", transfer.FileName) 'Print results
                Next
            End Using
        Catch ex As Exception
            MsgBox("File transfer error occurred!" + vbNewLine + ex.Message,
                   Microsoft.VisualBasic.MsgBoxStyle.Critical, My.Application.Info.ProductName)
        End Try

        session.Dispose() 'close connection
    End Sub
End Class
