Imports System.Data.Odbc
Imports Microsoft.Win32
Namespace MyFru
    Public Class MyMainFunctions
        Public Sub GetNames(ByVal strName As String, ByRef strRight As String, ByRef strLeft As String)
            'This can be moved to GlobalFunctions
            Dim tel As Integer = 0
            Dim y As Integer
            For y = Len(strName) To 1 Step -1
                tel = tel + 1
                If Mid(strName, y, 1) = "." Then
                    strRight = Microsoft.VisualBasic.Right(strName, tel)
                    strLeft = Microsoft.VisualBasic.Left(strName, Len(strName) - tel)
                    Exit For
                End If
            Next y
        End Sub
        Function PreDoAction(ByVal strAction As String, ByVal NewName As String, ByVal intCounter As Integer, ByVal strRight As String, ByVal strLeft As String, ByVal cFormat As String, UseSpace As Boolean, SpecialSpace As String) As String
            Dim sAns As String = ""
            Dim strNewNumber As String = Format(intCounter, cFormat)
            Select Case UCase(strAction)
                Case "REPLACE"
                    If UseSpace Then
                        sAns = NewName & SpecialSpace & strNewNumber & strRight
                    Else
                        sAns = NewName & strNewNumber & strRight
                    End If
                Case "BEFORE"
                    If UseSpace Then
                        sAns = NewName & strLeft & SpecialSpace & strNewNumber & strRight
                    Else
                        sAns = NewName & strLeft & strNewNumber & strRight
                    End If

                Case "AFTER"
                    If UseSpace Then
                        sAns = strLeft & NewName & SpecialSpace & strNewNumber & strRight
                    Else
                        sAns = strLeft & NewName & strNewNumber & strRight
                    End If
            End Select
            Return sAns
        End Function
    End Class
    Public Class BSRegistry
        Private _RegPath As String
        Public Property DefaultRegPath() As String
            Get
                Return "Software\\BurnSoft\\FileRenamer4"
            End Get
            Set(ByVal value As String)
                _RegPath = value
            End Set
        End Property
        Public Sub UpDateAppDetails()
            Dim MyReg As RegistryKey
            Dim strValue As String = DefaultRegPath
            MyReg = Microsoft.Win32.Registry.CurrentUser.OpenSubKey(strValue, True)
            If MyReg Is Nothing Then
                MyReg = Microsoft.Win32.Registry.CurrentUser.CreateSubKey(strValue)
            End If
            MyReg.SetValue("Version", Application.ProductVersion)
            MyReg.SetValue("AppName", Application.ProductName)
            MyReg.SetValue("AppEXE", Application.ExecutablePath())
            MyReg.SetValue("LogPath", MyLogFile)
            MyReg.SetValue("Path", Application.StartupPath)
            MyReg.SetValue("DataBase", APPLICATION_DATA_PATH & DATABASE_NAME)
            MyReg.Close()
        End Sub
        Public Sub GetSettings(ByRef NumberFormat As String, ByRef TrackHistory As Boolean, ByRef TrackHistoryDays As Integer, ByRef UseSpecial As Boolean, ByRef SpecialValue As String)
            Dim MyReg As RegistryKey
            Dim strValue As String = DefaultRegPath & "\Settings"
            MyReg = Microsoft.Win32.Registry.CurrentUser.OpenSubKey(strValue, True)
            If MyReg Is Nothing Then
                MyReg = Microsoft.Win32.Registry.CurrentUser.CreateSubKey(strValue)
                MyReg.SetValue("TrackHistoryDays", 30)
                MyReg.SetValue("TrackHistory", False)
                MyReg.SetValue("NumberFormat", "0000")
                MyReg.SetValue("AutoUpdate", False)
                'MyReg.SetValue("UseProxy", False)
                MyReg.SetValue("UseSpecial", True)
                MyReg.SetValue("SpecialValue", "_")
                MyReg.Close()
            End If
            If (Not MyReg Is Nothing) Then
                TrackHistoryDays = CInt(MyReg.GetValue("TrackHistoryDays", "1"))
                TrackHistory = CBool(MyReg.GetValue("TrackHistory", "true"))
                NumberFormat = CStr(MyReg.GetValue("NumberFormat", ""))
                UseSpecial = CBool(MyReg.GetValue("UseSpecial", "true"))
                SpecialValue = CStr(MyReg.GetValue("SpecialValue", "_"))
                'AutoUpdate = CBool(MyReg.GetValue("AutoUpdate", ""))
                'UseProxy = CBool(MyReg.GetValue("UseProxy", ""))
            Else
                TrackHistoryDays = 30
                TrackHistory = False
                NumberFormat = "0000"
                SpecialValue = "_"
                UseSpecial = True
                ' AutoUpdate = False
                'UseProxy = False
            End If
        End Sub
        Public Sub SaveSettings(ByVal NumberFormat As String, ByVal TrackHistory As Boolean, ByVal TrackHistoryDays As Integer, ByVal UseSpecial As Boolean, ByVal SpecialValue As String)
            Dim MyReg As RegistryKey
            Dim strValue As String = DefaultRegPath & "\Settings"
            MyReg = Microsoft.Win32.Registry.CurrentUser.OpenSubKey(strValue, True)
            If MyReg Is Nothing Then
                MyReg = Microsoft.Win32.Registry.CurrentUser.CreateSubKey(strValue)
            End If
            MyReg.SetValue("TrackHistoryDays", TrackHistoryDays)
            MyReg.SetValue("TrackHistory", TrackHistory)
            MyReg.SetValue("NumberFormat", NumberFormat)
            MyReg.SetValue("UseSpecial", UseSpecial)
            MyReg.SetValue("SpecialValue", SpecialValue)
            'MyReg.SetValue("AutoUpdate", AutoUpdate)
            'MyReg.SetValue("UseProxy", UseProxy)
            MyReg.Close()
        End Sub
        Public Sub SaveLastWorkingDir(ByVal strPath As String)
            Dim MyReg As RegistryKey
            Dim strValue As String = DefaultRegPath & "\Settings"
            MyReg = Microsoft.Win32.Registry.CurrentUser.CreateSubKey(strValue, RegistryKeyPermissionCheck.Default)
            If MyReg Is Nothing Then
                MyReg = Microsoft.Win32.Registry.CurrentUser.CreateSubKey(strValue)
            End If
            MyReg.SetValue("LastWorkingPath", strPath)
            MyReg.Close()
        End Sub
        Public Function GetLastWorkingDir() As String
            Dim sAns As String = ""
            Dim myReg As RegistryKey
            Dim strValue As String = DefaultRegPath & "\Settings"
            myReg = Microsoft.Win32.Registry.CurrentUser.CreateSubKey(strValue, RegistryKeyPermissionCheck.Default)
            If myReg Is Nothing Then
                myReg = Microsoft.Win32.Registry.CurrentUser.CreateSubKey(strValue)
                myReg.SetValue("LastWorkingPath", "")
            End If
            sAns = myReg.GetValue("LastWorkingPath", "")
            myReg.Close()
            Return sAns
        End Function
    End Class
    Public Class Database
        Public Conn As Odbc.OdbcConnection
        Private Function sConnect() As String
            Dim sAns As String = ""
            Dim sPath As String = APPLICATION_DATA_PATH & DATABASE_NAME
            sAns = "Driver={Microsoft Access Driver (*.mdb)};dbq=" & sPath & ";"
            Return sAns
        End Function
        Private Sub ConnectDB()
            Try
                Conn = New Odbc.OdbcConnection(sConnect)
                Conn.Open()
            Catch ex As Exception
                Call LogError("MyGobalFunctions.Database", "ConnectDB", Err.Number, ex.Message.ToString)
            End Try
        End Sub
        Private Sub CloseDB()
            Try
                Conn.Close()
                Conn = Nothing
            Catch ex As Exception
                Call LogError("MyGobalFunctions.Database", "CloseDB", Err.Number, ex.Message.ToString)
            End Try
        End Sub
        Public Sub ConnExec(ByVal strSQL As String)
            Try
                Call ConnectDB()
                Dim CMD As New OdbcCommand
                CMD.Connection = Conn
                CMD.CommandText = strSQL
                CMD.ExecuteNonQuery()
                CMD.Connection.Close()
                CMD = Nothing
                Conn = Nothing
            Catch ex As Exception
                Call LogError("MyGobalFunctions.Database", "ConnExec", Err.Number, ex.Message.ToString)
            End Try
        End Sub
        Public Sub InsertIntoQue(ByVal strPath As String)
            Dim SQL As String = "INSERT INTO Queue_Files(FilePath) Values('" & strPath & "')"
            Call ConnExec(SQL)
        End Sub
        Public Sub ClearDBQue()
            Dim SQL As String = "Delete from Queue_Files"
            Call ConnExec(SQL)
        End Sub
        Public Function ExistsInQue(ByVal strFile As String) As Boolean
            Dim bAns As Boolean = False
            Try
                Call ConnectDB()
                Dim SQL As String = "SELECT * from Queue_Files where FilePath ='" & strFile & "'"
                Dim CMD As New OdbcCommand(SQL, Conn)
                Dim RS As OdbcDataReader
                RS = CMD.ExecuteReader
                If RS.HasRows Then
                    bAns = True
                Else
                    bAns = False
                End If
                CMD = Nothing
                RS = Nothing
                CloseDB()
            Catch ex As Exception
                Call LogError("MyGobalFunctions.Database", "ExistsInQue", Err.Number, ex.Message.ToString)
            End Try
            Return bAns
        End Function
        Public Sub InsertLog(ByVal ReportID As Integer, ByVal strOld As String, ByVal strNew As String)
            Dim SQL As String = "INSERT INTO Hist_list(rid,before,after) Values(" & ReportID & ",'" & strOld & "','" & strNew & "')"
            Call ConnExec(SQL)
        End Sub
        Public Function CreateReport(ByVal strDir As String) As Integer
            Dim iAns As Integer = 0
            Try
                Dim SQL As String = "INSERT INTO Hist_Contents(CDate,Directory) VALUES('" & Now & "','" & strDir & "')"
                Call ConnExec(SQL)
                Call ConnectDB()
                SQL = "SELECT MAX(ID) as last from Hist_Contents"
                Dim CMD As New OdbcCommand(SQL, Conn)
                Dim RS As OdbcDataReader
                RS = CMD.ExecuteReader
                If RS.HasRows Then iAns = CInt(RS("Last"))
                CMD = Nothing
                RS = Nothing
                Call CloseDB()
            Catch ex As Exception
                Call LogError("MyGobalFunctions.Database", "CreateReport", Err.Number, ex.Message.ToString)
            End Try
            Return iAns
        End Function
        Public Sub ClearHistory()
            Dim SQL As String = "DELETE from Hist_List"
            ConnExec(SQL)
            SQL = "DELETE from Hist_Contents"
            ConnExec(SQL)
        End Sub
    End Class
End Namespace
