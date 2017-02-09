Module GlobalVar
    Public MyLogFile As String
    Public APPLICATION_PATH As String
    Public APPLICATION_DATA_PATH As String
    Public Const ErrLog As String = "\err.log"
    Public Const AppDB As String = "\fru.mdb"
    Public Const DATABASE_NAME As String = "\fru.mdb"

    Public Sub LogError(ByVal sForm As String, ByVal sProcedure As String, ByVal iErrNo As Long, ByVal sErrorDesc As String)
        Dim ObjFS As New BurnSoft.FileSystem.FileIO
        Dim sMessage As String = sForm & "." & sProcedure & "::" & iErrNo & "::" & sErrorDesc
        ObjFS.LogFile(MyLogFile, sMessage)
    End Sub
End Module
