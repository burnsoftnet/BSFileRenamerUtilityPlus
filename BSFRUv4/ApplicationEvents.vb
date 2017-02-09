Imports BurnSoft.FileSystem
Imports System.Configuration
Imports System.Security.Principal
Namespace My

    ' The following events are availble for MyApplication:
    ' 
    ' Startup: Raised when the application starts, before the startup form is created.
    ' Shutdown: Raised after all application forms are closed.  This event is not raised if the application terminates abnormally.
    ' UnhandledException: Raised if the application encounters an unhandled exception.
    ' StartupNextInstance: Raised when launching a single-instance application and the application is already active. 
    ' NetworkAvailabilityChanged: Raised when the network connection is connected or disconnected.
    Partial Friend Class MyApplication
        Protected Overrides Function OnInitialize(ByVal commandLineArgs As System.Collections.ObjectModel.ReadOnlyCollection(Of String)) As Boolean
            Dim Objf As New FileIO
            Try
                Dim AppDataPath As String = System.Environment.GetFolderPath(System.Environment.SpecialFolder.ApplicationData) & "\BurnSoft\FileRenamer"
                Dim APPDATAPATH_EXISTS As Boolean = Objf.DirectoryExists(AppDataPath)
                APPLICATION_PATH = System.Windows.Forms.Application.StartupPath
                APPLICATION_DATA_PATH = APPLICATION_PATH
                If APPDATAPATH_EXISTS Then
                    If Objf.FileExists(AppDataPath & DATABASE_NAME) Then
                        APPLICATION_DATA_PATH = AppDataPath
                    End If
                End If
                AppDomain.CurrentDomain.SetData("DataDirectory", APPLICATION_DATA_PATH)
                MyLogFile = APPLICATION_DATA_PATH & ErrLog
                Return MyBase.OnInitialize(commandLineArgs)
            Catch ex As Exception
                Dim strProcedure As String = "OnInitialize"
                Call LogError("My.MyApplication", strProcedure, Err.Number, ex.Message.ToString)
            End Try
        End Function
    End Class

End Namespace

