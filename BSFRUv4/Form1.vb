Imports BSFRUv4.MyFru
Imports Microsoft.VisualBasic
Imports BSFRUv4.Cyhper
Imports System.IO
Imports BurnSoft.FileSystem
'Imports BurnSoft.Messages.Balloons
'Imports BSFRUv4.Update_Services
Public Class frmMain
    Dim MyNUmberFormat As String
    Dim TrackHistory As Boolean
    Dim TrackHistoryMaxDays As Integer
    Dim strLastWorkingPath As String
    'Dim DoUpdates As Boolean
    'Dim DoProxy As Boolean
    Dim DoSpecial As Boolean
    Dim SpecialValue As String
    Public DaysLeftToTry As String
    Dim ReportID As Integer
#Region " File Renaming Functions "
    Function CountSelected(ByRef TotalFiles As Integer) As Integer
        Dim t As Integer = 0
        Dim x As Integer = 0
        TotalFiles = FileListBox1.Items.Count
        For x = 0 To TotalFiles - 1
            If FileListBox1.GetSelected(x) Then
                t = t + 1
            End If
        Next x
        Return t
    End Function
    Function CountQued() As Long
        Dim lAns As Long
        lAns = lstQue.Items.Count
        Return lAns
    End Function
#End Region
#Region " File Renaming Subs "
    Sub Selections()
        Dim MyTotal As Integer
        Dim MySelected As Integer = CountSelected(MyTotal)
        lblSelected.Text = "Selected : " & MySelected & "   "
        lblTotal.Text = "Total files : " & MyTotal & "   "
    End Sub
    Sub PopFileListing()
        FileListBox1.Path = DirListBox1.Path
        FileListBox1.Pattern = txtFilePat.Text
        Call Selections()
    End Sub
    Sub DoSelectionState(ByVal MyValue As Boolean)
        Dim MyListCount As Integer = FileListBox1.Items.Count
        Dim x As Integer
        Me.Cursor = Cursors.WaitCursor
        'FileListBox1.BeginUpdate()
        For x = 0 To MyListCount - 1 'To 0 Step -1
            Me.FileListBox1.SetSelected(x, MyValue)
        Next x
        'FileListBox1.EndUpdate()
        Call Selections()
        Me.Cursor = Cursors.Default
    End Sub
    Sub ClearQues()
        Dim ObjDB As New Database
        lstQue.Items.Clear()
        ObjDB.ClearDBQue()
        GroupBox4.Text = "Command Queue"
    End Sub
    Function UseNewFileName(sPath As String, txtFileName As String, UseLastFolderName As Boolean) As String
        Dim sAns As String = txtFileName
        If UseLastFolderName Then
            Dim sSplit() As String = Split(sPath, "\")
            sAns = sSplit(UBound(sSplit))
        End If
        Return sAns
    End Function
    Sub DoRename(ByVal strPath As String, ByVal strName As String, ByVal Counter As Long)
        Dim Obj As New MyMainFunctions
        Dim ObjDB As New Database
        Dim ObjFS As New BurnSoft.FileSystem.FileIO
        Dim strRight As String = ""
        Dim strLeft As String = ""
        Dim NewName As String = UseNewFileName(strPath, txtName.Text, chkUseFolder.Checked)
        Dim strNewResult As String = ""
        Dim strAction As String = ""
        Dim strNewPath As String = ""
        Dim strOldPath As String = ""
        Dim strTargetDir As String = txtBrowse.Text
        Dim DoTracking As Boolean = chkeHistory.Checked
        Dim DoReplace As Boolean = chkKeep.Checked
        Dim DoMove As Boolean = chkMove2Dir.Checked
        Dim DoCopy As Boolean = False
        Dim CFormat As String = txtFormat.Text
        If DoReplace And DoMove Then DoCopy = True : DoReplace = False : DoMove = False
        If rbReplace.Checked Then strAction = "REPLACE"
        If rbBefore.Checked Then strAction = "BEFORE"
        If rbAfter.Checked Then strAction = "AFTER"
        Try
            Call Obj.GetNames(strName, strRight, strLeft)
            strNewResult = Obj.PreDoAction(strAction, NewName, Counter, strRight, strLeft, CFormat, DoSpecial, SpecialValue)
            strOldPath = strPath & "\" & strName
            If Len(strTargetDir) = 0 Then
                strNewPath = strPath & "\" & strNewResult
            Else
                strNewPath = strTargetDir & "\" & strNewResult
            End If

            If DoTracking Then
                If ReportID = 0 Then ReportID = ObjDB.CreateReport(strPath)
                ObjDB.InsertLog(ReportID, strOldPath, strNewPath)
            End If

            If DoReplace Then ObjFS.RenameFile(strOldPath, strNewPath)
            If DoCopy Then ObjFS.CopyFile(strOldPath, strNewPath)
            If DoMove Then ObjFS.MoveFile(strOldPath, strNewPath)
        Catch ex As Exception
            Dim ObjBFS As New BurnSoft.FileSystem.FileIO
            Dim Msg As String = "Form1:Sub DoRename" & "::" & Err.Number & "::" & ex.Message.ToString()
            ObjBFS.LogFile(MyLogFile, Msg)
        End Try
    End Sub
    Sub RenameSelectedFiles()
        Dim intTotalCount As Integer
        Dim intCount As Integer = CountSelected(intTotalCount)
        Dim x As Integer = 0
        Dim strSelectedName As String = ""
        Dim ObjReg As New BSRegistry
        Dim Counter As Long = CLng(txtCounter.Text)
        Dim DoReplace As Boolean = chkKeep.Checked
        Dim DoMove As Boolean = chkMove2Dir.Checked
        Dim DoCopy As Boolean = False
        If DoReplace And DoMove Then DoCopy = True : DoReplace = False : DoMove = False
        Try
            If intCount = 0 Then
                MsgBox("First select 1 or more files !", vbOKOnly + vbExclamation, My.Application.Info.Title)
                Exit Sub
            End If
            If DoMove Or DoCopy Then
                If Len(txtBrowse.Text) = 0 Then
                    MsgBox("Please enter in a Target Directory to move/copy the files to!", vbOKOnly + vbExclamation, My.Application.Info.Title)
                    Exit Sub
                End If
            End If
            Me.Cursor = Cursors.WaitCursor
            ObjReg.SaveLastWorkingDir(DirListBox1.Path)
            LstPreview.Items.Clear()
            ToolStripProgressBar1.Minimum = 0
            ToolStripProgressBar1.Maximum = intCount
            For x = 0 To intTotalCount - 1
                If FileListBox1.GetSelected(x) Then
                    strSelectedName = FileListBox1.Items(x)
                    Call DoRename(FileListBox1.Path, strSelectedName, Counter)
                    Counter = Counter + Val(txtInc.Value)
                    ToolStripProgressBar1.Value = x
                    Me.Refresh()
                End If
            Next
            ReportID = 0
            If ChkResetToLast.Checked Then txtCounter.Text = Counter
            Me.Cursor = Cursors.Default
        Catch ex As Exception
            Dim ObjBFS As New BurnSoft.FileSystem.FileIO
            Dim Msg As String = "Form1:Sub RenameSelectedFiles" & "::" & Err.Number & "::" & ex.Message.ToString()
            ObjBFS.LogFile(MyLogFile, Msg)
        End Try
    End Sub
    Sub RenameSelectedFilesQue()
        Dim intTotalCount As Long = CountQued()
        Dim intCount As Integer = CountQued()
        Dim x As Integer = 0
        Dim strSelectedName As String = ""
        Dim ObjReg As New BSRegistry
        Dim objFS As New BurnSoft.FileSystem.FileIO
        Dim strPath As String = ""
        Dim strFileName As String = ""
        Dim Counter As Long = CLng(txtCounter.Text)
        Dim DoReplace As Boolean = chkKeep.Checked
        Dim DoMove As Boolean = chkMove2Dir.Checked
        Dim DoCopy As Boolean = False
        If DoReplace And DoMove Then DoCopy = True : DoReplace = False : DoMove = False
        Try
            If intCount = 0 Then
                MsgBox("First select 1 or more files !", vbOKOnly + vbExclamation, My.Application.Info.Title)
                Exit Sub
            End If
            If DoMove Or DoCopy Then
                If Len(txtBrowse.Text) = 0 Then
                    MsgBox("Please enter in a Target Directory to move/copy the files to!", vbOKOnly + vbExclamation, My.Application.Info.Title)
                    Exit Sub
                End If
            End If
            Me.Cursor = Cursors.WaitCursor
            ObjReg.SaveLastWorkingDir(DirListBox1.Path)
            LstPreview.Items.Clear()
            ToolStripProgressBar1.Minimum = 0
            ToolStripProgressBar1.Maximum = intCount
            For x = 0 To intTotalCount - 1
                strSelectedName = lstQue.Items(x)
                strFileName = objFS.GetNameOfFile(strSelectedName)
                strPath = objFS.GetPathOfFile(strSelectedName)
                Call DoRename(strPath, strFileName, Counter)
                Counter = Counter + Val(txtInc.Value)
                ToolStripProgressBar1.Value = x
                Me.Refresh()
            Next
            ReportID = 0
            If ChkResetToLast.Checked Then txtCounter.Text = Counter
            Me.Cursor = Cursors.Default
        Catch ex As Exception
            Dim ObjBFS As New BurnSoft.FileSystem.FileIO
            Dim Msg As String = "Form1:Sub RenameSelectedFilesQue" & "::" & Err.Number & "::" & ex.Message.ToString()
            ObjBFS.LogFile(MyLogFile, Msg)
        End Try
    End Sub
#End Region
#Region " File Listing Functions and Subs "
    Private Sub DriveListBox1_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DriveListBox1.SelectedIndexChanged
        On Error GoTo drivefout
        Dim temp As String = ""
        temp = DriveListBox1.Drive
        DirListBox1.Path = temp + "\"
        Exit Sub
drivefout:
        temp = MsgBox("Sorry, but the selected device is not ready or will not write!", vbOKOnly & vbCritical, My.Application.Info.Title)
    End Sub
    Private Sub DirListBox1_Change(ByVal sender As Object, ByVal e As System.EventArgs) Handles DirListBox1.Change
        Call PopFileListing()
    End Sub
    Private Sub txtFilePat_TextChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtFilePat.TextChanged
        Call PopFileListing()
    End Sub
    Private Sub FileListBox1_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles FileListBox1.SelectedIndexChanged
        Call Selections()
    End Sub
#End Region
#Region " Image Resizing Subs "
    Sub DoResizeImageSelected()
        'DONE:STA Issues while attempting to Resize Images, memory leak is present!
        'Error Message:
        'ContextSwitchDeadlock was detected
        'Message: The CLR has been unable to transition from COM context 0x196d90 to COM context 0x196c20 for 60 seconds. The thread that owns the destination context/apartment is most likely either doing a non pumping wait or processing a very long running operation without pumping Windows messages. This situation generally has a negative performance impact and may even lead to the application becoming non responsive or memory usage accumulating continually over time. To avoid this problem, all single threaded apartment (STA) threads should use pumping wait primitives (such as CoWaitForMultipleHandles) and routinely pump messages during long running operations.
        'NOTE: NOTHING DETECTED DURING QA RUN, MEMORY HANDLED GREAT!!!
        'Other Links to Help with this are:
        'http://msdn2.microsoft.com/en-us/library/ms172233.aspx
        'http://msdn2.microsoft.com/en-us/library/system.mtathreadattribute.aspx
        'http://msdn2.microsoft.com/en-us/library/ms809826.aspx
        'http://msdn2.microsoft.com/en-us/library/ms809311.aspx
        Dim intTotalCount As Integer
        Dim intCount As Integer = CountSelected(intTotalCount)
        Dim x As Integer = 0
        Dim Obj As New MyMainFunctions
        Dim ObjReg As New BSRegistry
        Dim objFS As New BurnSoft.FileSystem.FileIO
        Dim DoKeep As Boolean = chkKeepType.Checked
        Dim DoConvert As Boolean = chkConvertTo.Checked
        Dim DoConvertAndKeep As Boolean = chkKeepSameJustConvertType.Checked
        Dim DoRename As Boolean = chkUseRenameOp.Checked
        Dim lngHeight As Long = CLng(txtHeight.Text)
        Dim lngWidth As Long = CLng(txtWidth.Text)
        Dim ConvertTo1 As String = cmbType.SelectedItem
        If Len(ConvertTo1) = 0 Then ConvertTo1 = cmbType.Text
        Dim ConvertTo2 As String = cmbType2.SelectedItem
        If Len(ConvertTo2) = 0 Then ConvertTo2 = cmbType2.Text
        Dim strCopyTo As String = txtCopyImgToDir.Text
        Dim strFile As String = ""
        Dim strFileDest As String = ""
        Dim strPath As String = ""
        Dim strExt As String = ""
        Dim strNewExt As String = ""
        Dim strCopypFrom As String = ""
        Dim strFullSource As String = ""
        Dim strFullTarget As String = ""
        Dim strAction As String = ""
        Dim errCount As Long = 0
        Dim NewName As String = txtName.Text
        Dim Counter As Long = CLng(txtCounter.Text)
        Dim CFormat As String = txtFormat.Text
        If rbReplace.Checked Then strAction = "REPLACE"
        If rbBefore.Checked Then strAction = "BEFORE"
        If rbAfter.Checked Then strAction = "AFTER"
        Me.Cursor = Cursors.WaitCursor
        If DoRename And Len(NewName) = 0 Then MsgBox("Please enter in the New Name to rename these files!", MsgBoxStyle.Critical, My.Application.Info.Title) : Exit Sub
        ObjReg.SaveLastWorkingDir(DirListBox1.Path)
        LstPreview.Items.Clear()
        ToolStripProgressBar1.Minimum = 0
        ToolStripProgressBar1.Maximum = intCount
        Dim i As Long = 0
        Try
            For x = 0 To intTotalCount - 1
                If FileListBox1.GetSelected(x) Then
                    strFile = FileListBox1.Items(x)
                    i = i + 1
                    If DoRename Then
                        strFileDest = Obj.PreDoAction(strAction, NewName, Counter, objFS.GetExtOfFile(strFile), objFS.GetNameOfFileWOExt(strFile), CFormat, DoSpecial, SpecialValue)
                        Counter = Counter + Val(txtInc.Value)
                    Else
                        strFileDest = strFile
                    End If
                    strPath = FileListBox1.Path
                    strExt = "UNKNOWN"
                    If objFS.FileHasExtension(strFile) Then strExt = MatchExtType(objFS.GetExtOfFile(strFile))
                    strFullSource = strPath & "\" & strFile
                    strFullTarget = strCopyTo & "\" & strFileDest
                    If DoConvert Then strFullTarget = strCopyTo & "\" & objFS.GetNameOfFileWOExt(strFileDest) & "." & LCase(ConvertTo1)
                    If DoConvertAndKeep Then strFullTarget = strCopyTo & "\" & objFS.GetNameOfFileWOExt(strFileDest) & "." & LCase(ConvertTo2)
                    If DoKeep Then
                        If strExt <> "UNKNOWN" Then
                            If Not ResizeImage(strFullSource, strFullTarget, strExt) Then errCount = errCount + 1
                        Else
                            errCount = errCount + 1
                        End If
                    End If
                    If DoConvert Then
                        If Not ResizeImage(strFullSource, strFullTarget, ConvertTo1) Then errCount = errCount + 1
                    End If
                    If DoConvertAndKeep Then
                        If Not ConvertImage(strFullSource, strFullTarget, ConvertTo2) Then errCount = errCount + 1
                    End If
                    ToolStripProgressBar1.Value = i
                End If
                Me.Refresh()
            Next x
            If errCount = 0 Then
                MsgBox("Process Complete with no errors!", MsgBoxStyle.MsgBoxHelp, My.Application.Info.Title)
            Else
                MsgBox("Process Complete with " & errCount & " errors!", MsgBoxStyle.Critical, My.Application.Info.Title)
            End If
            ToolStripProgressBar1.Value = 0
            If ChkResetToLast.Checked Then txtCounter.Text = Counter
            Me.Cursor = Cursors.Default
        Catch ex As Exception
            Call LogError(Me.Name, "DoResizeImageSelected", Err.Number, ex.Message.ToString)
            'Call LogError(Me.Name, "", Err.Number, ex.Message.ToString)
            'Dim ObjBFS As New BurnSoft.FileSystem.FileIO
            'Dim Msg As String = "Form1:Sub DoResizeImageSelected" & "::" & Err.Number & "::" & ex.Message.ToString()
            'ObjBFS.LogFile(MyLogFile, Msg)
        End Try
    End Sub
    Sub DoResizeImageQue()
        'DONE:STA Issues while attempting to Resize Images, memory leak is present!
        'Error Message:
        'ContextSwitchDeadlock was detected
        'Message: The CLR has been unable to transition from COM context 0x196d90 to COM context 0x196c20 for 60 seconds. The thread that owns the destination context/apartment is most likely either doing a non pumping wait or processing a very long running operation without pumping Windows messages. This situation generally has a negative performance impact and may even lead to the application becoming non responsive or memory usage accumulating continually over time. To avoid this problem, all single threaded apartment (STA) threads should use pumping wait primitives (such as CoWaitForMultipleHandles) and routinely pump messages during long running operations.
        'NOTE:NO PROBLEMS PRESENT DURING ReSIZING!!
        'Other Links to Help with this are:
        'http://msdn2.microsoft.com/en-us/library/ms172233.aspx
        'http://msdn2.microsoft.com/en-us/library/system.mtathreadattribute.aspx
        'http://msdn2.microsoft.com/en-us/library/ms809826.aspx
        'http://msdn2.microsoft.com/en-us/library/ms809311.aspx
        Dim intTotalCount As Integer = CountQued()
        Dim intCount As Integer = CountQued()
        Dim x As Integer = 0
        Dim Obj As New MyMainFunctions
        Dim ObjReg As New BSRegistry
        Dim objFS As New BurnSoft.FileSystem.FileIO
        Dim strPath As String = ""
        Dim strFileName As String = ""
        Dim DoKeep As Boolean = chkKeepType.Checked
        Dim DoConvert As Boolean = chkConvertTo.Checked
        Dim DoConvertAndKeep As Boolean = chkKeepSameJustConvertType.Checked
        Dim DoRename As Boolean = chkUseRenameOp.Checked
        Dim lngHeight As Long = CLng(txtHeight.Text)
        Dim lngWidth As Long = CLng(txtWidth.Text)
        Dim ConvertTo1 As String = cmbType.SelectedItem
        If Len(ConvertTo1) = 0 Then ConvertTo1 = cmbType.Text
        Dim ConvertTo2 As String = cmbType2.SelectedItem
        If Len(ConvertTo2) = 0 Then ConvertTo2 = cmbType2.Text
        Dim strCopyTo As String = txtCopyImgToDir.Text
        Dim strFile As String = ""
        Dim strFileDest As String = ""
        Dim strExt As String = ""
        Dim strNewExt As String = ""
        Dim strCopypFrom As String = ""
        Dim strFullSource As String = ""
        Dim strFullTarget As String = ""
        Dim strAction As String = ""
        Dim errCount As Long = 0
        Dim NewName As String = txtName.Text
        Dim Counter As Long = CLng(txtCounter.Text)
        Dim CFormat As String = txtFormat.Text
        If rbReplace.Checked Then strAction = "REPLACE"
        If rbBefore.Checked Then strAction = "BEFORE"
        If rbAfter.Checked Then strAction = "AFTER"
        Me.Cursor = Cursors.WaitCursor
        If DoRename And Len(NewName) = 0 Then MsgBox("Please enter in the New Name to rename these files!", MsgBoxStyle.Critical, My.Application.Info.Title) : Exit Sub
        ObjReg.SaveLastWorkingDir(DirListBox1.Path)
        LstPreview.Items.Clear()
        ToolStripProgressBar1.Minimum = 0
        ToolStripProgressBar1.Maximum = intCount
        Try
            For x = 0 To intTotalCount - 1
                strFileName = lstQue.Items(x)
                strFile = objFS.GetNameOfFile(strFileName)
                strPath = objFS.GetPathOfFile(strFileName)
                If DoRename Then
                    strFileDest = Obj.PreDoAction(strAction, NewName, Counter, objFS.GetExtOfFile(strFile), objFS.GetNameOfFileWOExt(strFile), CFormat, DoSpecial, SpecialValue)
                    Counter = Counter + Val(txtInc.Value)
                Else
                    strFileDest = strFile
                End If
                strExt = "UNKNOWN"
                If objFS.FileHasExtension(strFile) Then strExt = MatchExtType(objFS.GetExtOfFile(strFile))
                strFullSource = strPath & "\" & strFile
                strFullTarget = strCopyTo & "\" & strFileDest
                If DoConvert Then strFullTarget = strCopyTo & "\" & objFS.GetNameOfFileWOExt(strFileDest) & "." & LCase(ConvertTo1)
                If DoConvertAndKeep Then strFullTarget = strCopyTo & "\" & objFS.GetNameOfFileWOExt(strFileDest) & "." & LCase(ConvertTo2)
                If DoKeep Then
                    If strExt <> "UNKNOWN" Then
                        If Not ResizeImage(strFullSource, strFullTarget, strExt) Then errCount = errCount + 1
                    Else
                        errCount = errCount + 1
                    End If
                End If
                If DoConvert Then
                    If Not ResizeImage(strFullSource, strFullTarget, ConvertTo1) Then errCount = errCount + 1
                End If
                If DoConvertAndKeep Then
                    If Not ConvertImage(strFullSource, strFullTarget, ConvertTo2) Then errCount = errCount + 1
                End If
                ToolStripProgressBar1.Value = x
                Me.Refresh()
            Next x
            If errCount = 0 Then
                MsgBox("Process Complete with no errors!", MsgBoxStyle.MsgBoxHelp, My.Application.Info.Title)
            Else
                MsgBox("Process Complete with " & errCount & " errors!", MsgBoxStyle.Critical, My.Application.Info.Title)
            End If
            ToolStripProgressBar1.Value = 0
            If ChkResetToLast.Checked Then txtCounter.Text = Counter
            Me.Cursor = Cursors.Default
        Catch ex As Exception
            Call LogError(Me.Name, "DoResizeImageSelectedQue", Err.Number, ex.Message.ToString)
            'Call LogError(Me.Name, "", Err.Number, ex.Message.ToString)
            'Dim ObjBFS As New BurnSoft.FileSystem.FileIO
            'Dim Msg As String = "Form1:Sub DoResizeImageSelectedQue" & "::" & Err.Number & "::" & ex.Message.ToString()
            'ObjBFS.LogFile(MyLogFile, Msg)
        End Try
    End Sub
    Private Sub btnResize_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnResize.Click
        If Len(txtCopyImgToDir.Text) = 0 Then MsgBox("Please select a place to put the new image!", MsgBoxStyle.Critical, My.Application.Info.Title) : Exit Sub
        If lstQue.Items.Count = 0 Then
            Call DoResizeImageSelected()
        Else
            Call DoResizeImageQue()
        End If
        Me.Cursor = Cursors.Arrow
        ToolStripProgressBar1.Value = 0
    End Sub
#End Region
#Region " Image Resizing Functions "
    Function ThumbnailCallback() As Boolean
        'Dummy Callback Function
        Return False
    End Function
    Function MatchExtType(ByVal strType As String) As String
        Dim sAns As String = ""
        strType = Replace(strType, ".", "")
        Select Case UCase(strType)
            Case "JPG"
                sAns = "JPG"
            Case "GIF"
                sAns = "GIF"
            Case "BMP"
                sAns = "BMP"
            Case "ICO"
                sAns = "ICO"
            Case "EMF"
                sAns = "EMF"
            Case "EXIF"
                sAns = "EXIF"
            Case "PNG"
                sAns = "PNG"
            Case "TIFF"
                sAns = "TIFF"
            Case "WMF"
                sAns = "WMF"
            Case Else
                sAns = "UNKNOWN"
        End Select
        Return sAns
    End Function
    Function ResizeImage(ByVal strSourceFile As String, ByVal strDestinationFile As String, ByVal StrType As String) As Boolean
        Dim bAns As Boolean = False
        On Error GoTo ErrHandler
        Dim img As System.Drawing.Image
        Dim ImgFormat As System.Drawing.Imaging.ImageFormat = Imaging.ImageFormat.Jpeg
        Dim oFstream As New FileStream(strSourceFile, FileMode.Open, FileAccess.Read)
        Dim dummyCallBack As System.Drawing.Image.GetThumbnailImageAbort
        Select Case UCase(StrType)
            Case "JPG"
                ImgFormat = Imaging.ImageFormat.Jpeg
            Case "GIF"
                ImgFormat = Imaging.ImageFormat.Gif
            Case "BMP"
                ImgFormat = Imaging.ImageFormat.Bmp
            Case "ICO"
                ImgFormat = Imaging.ImageFormat.Icon
            Case "EMF"
                ImgFormat = Imaging.ImageFormat.Emf
            Case "EXIF"
                ImgFormat = Imaging.ImageFormat.Exif
            Case "PNG"
                ImgFormat = Imaging.ImageFormat.Png
            Case "TIFF"
                ImgFormat = Imaging.ImageFormat.Tiff
            Case "WMF"
                ImgFormat = Imaging.ImageFormat.Wmf
        End Select

        img = System.Drawing.Image.FromStream(oFstream)
        dummyCallBack = New System.Drawing.Image.GetThumbnailImageAbort(AddressOf ThumbnailCallback)
        img = img.GetThumbnailImage(CInt(txtWidth.Text), CInt(txtHeight.Text), dummyCallBack, IntPtr.Zero)
        img.Save(strDestinationFile, ImgFormat)
        oFstream.Close()
        oFstream = Nothing
        img = Nothing
        dummyCallBack = Nothing
        ImgFormat = Nothing
        bAns = True
ErrHandler:
        Return bAns
    End Function
    Function ConvertImage(ByVal strSourceFile As String, ByVal strDestinationFile As String, ByVal StrType As String) As Boolean
        Dim bAns As Boolean = False
        On Error GoTo ErrHandler
        Dim img As System.Drawing.Image
        Dim ImgFormat As System.Drawing.Imaging.ImageFormat = Imaging.ImageFormat.Jpeg
        Dim oFstream As New FileStream(strSourceFile, FileMode.Open, FileAccess.Read)
        Dim dummyCallBack As System.Drawing.Image.GetThumbnailImageAbort
        Select Case UCase(StrType)
            Case "JPG"
                ImgFormat = Imaging.ImageFormat.Jpeg
            Case "GIF"
                ImgFormat = Imaging.ImageFormat.Gif
            Case "BMP"
                ImgFormat = Imaging.ImageFormat.Bmp
            Case "ICO"
                ImgFormat = Imaging.ImageFormat.Icon
            Case "EMF"
                ImgFormat = Imaging.ImageFormat.Emf
            Case "EXIF"
                ImgFormat = Imaging.ImageFormat.Exif
            Case "PNG"
                ImgFormat = Imaging.ImageFormat.Png
            Case "TIFF"
                ImgFormat = Imaging.ImageFormat.Tiff
            Case "WMF"
                ImgFormat = Imaging.ImageFormat.Wmf
        End Select

        img = System.Drawing.Image.FromStream(oFstream)
        dummyCallBack = New System.Drawing.Image.GetThumbnailImageAbort(AddressOf ThumbnailCallback)
        img.Save(strDestinationFile, ImgFormat)
        oFstream.Close()
        oFstream = Nothing
        img = Nothing
        dummyCallBack = Nothing
        ImgFormat = Nothing
        bAns = True
ErrHandler:
        Return bAns
    End Function
#End Region
#Region " Menu Subs "
    Private Sub AboutToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AboutToolStripMenuItem.Click
        Dim MyAbout As New AboutBox1
        MyAbout.Owner = Me
        MyAbout.Show()
    End Sub
    Private Sub ShowToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ShowToolStripMenuItem.Click
        Me.Show()
        Me.WindowState = FormWindowState.Maximized
    End Sub
    Private Sub ExitToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ExitToolStripMenuItem.Click
        Me.Close()
    End Sub
    Private Sub ViewListToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ViewListToolStripMenuItem.Click
        Dim ViewHist As New Viewhistory
        ViewHist.Owner = Me
        ViewHist.Show()
    End Sub
    Private Sub ClearHistoryToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ClearHistoryToolStripMenuItem.Click
        Dim Msg As String = MsgBox("Are you sure that you want to clear out the database?", MsgBoxStyle.YesNo, My.Application.Info.Title)
        If Msg = vbYes Then
            Dim ObjDB As New Database
            ObjDB.ClearHistory()
            MsgBox("The History was cleared!", MsgBoxStyle.OkOnly, My.Application.Info.Title)
        End If
    End Sub
    Private Sub ExitToolStripMenuItem1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ExitToolStripMenuItem1.Click
        Me.Close()
    End Sub
    Private Sub btnSelectAll_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSelectAll.Click
        Call DoSelectionState(True)
    End Sub
    Private Sub btnClearSelected_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnClearSelected.Click
        Call DoSelectionState(False)
    End Sub
    Private Sub rbReplace_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles rbReplace.Click
        rbBefore.Checked = False
        rbAfter.Checked = False
        rbReplace.Checked = True
    End Sub
    Private Sub rbBefore_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles rbBefore.Click
        rbBefore.Checked = True
        rbAfter.Checked = False
        rbReplace.Checked = False
    End Sub
    Private Sub rbAfter_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles rbAfter.Click
        rbBefore.Checked = False
        rbAfter.Checked = True
        rbReplace.Checked = False
    End Sub
    Private Sub btnBrowse_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnBrowse.Click
        FolderBrowserDialog1.ShowDialog()
        txtBrowse.Text = FolderBrowserDialog1.SelectedPath
    End Sub
    Private Sub btnClearQue_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnClearQue.Click
        Call ClearQues()
    End Sub
    Private Sub chkKeep_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chkKeep.CheckedChanged
        If chkKeep.Checked Then
            If chkMove2Dir.Checked Then
                chkMove2Dir.Text = "Copy to Directory"
                lblMoveDirectory.Text = chkMove2Dir.Text
            Else
                chkMove2Dir.Text = "Move to Directory"
                lblMoveDirectory.Text = chkMove2Dir.Text
            End If
        Else
            chkMove2Dir.Text = "Move to Directory"
            lblMoveDirectory.Text = chkMove2Dir.Text
        End If
    End Sub
    Private Sub chkMove2Dir_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chkMove2Dir.CheckedChanged
        If chkMove2Dir.Checked Then
            lblMoveDirectory.Enabled = True
            txtBrowse.Enabled = True
            btnBrowse.Enabled = True
            If chkKeep.Checked Then
                chkMove2Dir.Text = "Copy to Directory"
                lblMoveDirectory.Text = chkMove2Dir.Text
            Else
                chkMove2Dir.Text = "Move to Directory"
                lblMoveDirectory.Text = chkMove2Dir.Text
            End If
        Else
            lblMoveDirectory.Enabled = False
            txtBrowse.Enabled = False
            btnBrowse.Enabled = False
            If Not chkKeep.Checked Then
                chkKeep.Checked = True
            End If
        End If
    End Sub
    Private Sub SettingsToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SettingsToolStripMenuItem.Click
        Dim NF As New frmOptions
        NF.Owner = Me
        NF.Show()
    End Sub
    Private Sub btnPreview_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnPreview.Click
        Dim intTotalCount As Integer
        Dim Obj As New MyMainFunctions
        Dim ObjReg As New BSRegistry
        Dim intCount As Integer = CountSelected(intTotalCount)
        Dim x As Integer = 0
        Dim strSelectedName As String = ""
        Dim strRight As String = ""
        Dim strLeft As String = ""
        Dim NewName As String = UseNewFileName(FileListBox1.Path, txtName.Text, chkUseFolder.Checked)
        Dim strNewResult As String = ""
        Dim strAction As String = ""
        Dim Counter As Integer = Int(txtCounter.Text)
        Dim CFormat As String = txtFormat.Text
        If intCount = 0 Then
            MsgBox("First select 1 or more files !", vbOKOnly + vbExclamation, My.Application.Info.Title)
            Exit Sub
        End If
        Me.Cursor = Cursors.WaitCursor
        ObjReg.SaveLastWorkingDir(DirListBox1.Path)
        LstPreview.Items.Clear()
        If rbReplace.Checked Then strAction = "REPLACE"
        If rbBefore.Checked Then strAction = "BEFORE"
        If rbAfter.Checked Then strAction = "AFTER"
        ToolStripProgressBar1.Minimum = 0
        ToolStripProgressBar1.Maximum = intCount
        For x = 0 To intTotalCount - 1
            If FileListBox1.GetSelected(x) Then
                strSelectedName = FileListBox1.Items(x)
                Call Obj.GetNames(strSelectedName, strRight, strLeft)
                strNewResult = Obj.PreDoAction(strAction, NewName, Counter, strRight, strLeft, CFormat, DoSpecial, SpecialValue)
                LstPreview.Items.Add(strNewResult)
                Counter = Counter + Val(txtInc.Value)
                ToolStripProgressBar1.Value = x
            End If
        Next
        txtName.Focus()
        Me.Cursor = Cursors.Arrow
        ToolStripProgressBar1.Value = 0
    End Sub
    Private Sub btnAddQue_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAddQue.Click
        LstPreview.Items.Clear()
        Dim intTotalCount As Integer
        Dim Obj As New MyMainFunctions
        Dim ObjDB As New Database
        Dim intCount As Integer = CountSelected(intTotalCount)
        Dim x As Integer = 0
        Dim strSelectedName As String = ""
        Try
            If intCount = 0 Then
                MsgBox("First select 1 or more files !", vbOKOnly + vbExclamation, My.Application.Info.Title)
                Exit Sub
            End If
            Me.Cursor = Cursors.WaitCursor
            ToolStripProgressBar1.Minimum = 0
            ToolStripProgressBar1.Maximum = intCount
            For x = 0 To intTotalCount - 1 'intCount - 1
                If FileListBox1.GetSelected(x) Then
                    strSelectedName = DirListBox1.Path & "\" & FileListBox1.Items(x)
                    If ObjDB.ExistsInQue(strSelectedName) = False Then
                        ObjDB.InsertIntoQue(strSelectedName)
                        lstQue.Items.Add(strSelectedName)
                    End If
                    ToolStripProgressBar1.Value = x
                    Me.Refresh()
                End If
            Next
            Me.Cursor = Cursors.Arrow
            GroupBox4.Text = "Command Queue (" & lstQue.Items.Count & ")"
            ToolStripProgressBar1.Value = 0
        Catch ex As Exception
            Call LogError(Me.Name, "btnAddQue_Click", Err.Number, ex.Message.ToString)
            'Call LogError(Me.Name, "", Err.Number, ex.Message.ToString)
            'Dim ObjFS As New BurnSoft.FileSystem.FileIO
            'Dim sMessage As String = Me.Name & "::" & Err.Number & "::" & ex.Message.ToString()
            'ObjFS.LogFile(Application.StartupPath & "\err.log", sMessage)
            ToolStripProgressBar1.Value = 0
            Me.Cursor = Cursors.Arrow
            Exit Sub
        End Try
    End Sub
    Private Sub btnRename_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnRename.Click
        Dim strMegResult As String = MsgBox("You're about to change the selected filenames..." & vbCr & vbCr & vbCr & "Are you sure about this ?", vbOKCancel + vbQuestion, My.Application.Info.Title)
        If strMegResult = vbCancel Then Exit Sub
        Dim QueTotal As Integer = lstQue.Items.Count
        If QueTotal = 0 Then
            Call RenameSelectedFiles()
        Else
            Call RenameSelectedFilesQue()
            Call ClearQues()
        End If
        txtName.Focus()
        Me.Cursor = Cursors.Arrow
        ToolStripProgressBar1.Value = 0
        FileListBox1.Refresh()
    End Sub
    Private Sub RegisterToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RegisterToolStripMenuItem.Click
        BSRegistration.StatusMessage = DaysLeftToTry
        BSRegistration.MainFormUnloaded = False
        BSRegistration.Show()
    End Sub
    Private Sub PurchaseToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PurchaseToolStripMenuItem.Click
        Dim myProcess As New Process
        myProcess.StartInfo.FileName = "http://bsfrup.burnsoft.net"
        myProcess.StartInfo.WindowStyle = ProcessWindowStyle.Maximized
        myProcess.Start()
    End Sub
    Private Sub SupportToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SupportToolStripMenuItem.Click
        Dim myProcess As New Process
        myProcess.StartInfo.FileName = "http://support.burnsoft.net"
        myProcess.StartInfo.WindowStyle = ProcessWindowStyle.Maximized
        myProcess.Start()
    End Sub
    Private Sub BurnSoftHomeToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BurnSoftHomeToolStripMenuItem.Click
        Dim myProcess As New Process
        myProcess.StartInfo.FileName = "http://www.burnsoft.net"
        myProcess.StartInfo.WindowStyle = ProcessWindowStyle.Maximized
        myProcess.Start()
    End Sub
    Private Sub HelpToolStripMenuItem1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Dim myProcess As New Process
        myProcess.StartInfo.FileName = "filerenamer.chm"
        myProcess.StartInfo.WindowStyle = ProcessWindowStyle.Maximized
        myProcess.Start()
    End Sub
    Private Sub tbOptions_Selected(ByVal sender As Object, ByVal e As System.Windows.Forms.TabControlEventArgs) Handles tbOptions.Selected
        Dim MyOption As String = tbOptions.SelectedTab.Text
        Select Case MyOption
            Case "Renaming Options"
                btnRename.Visible = True
                btnResize.Visible = False
                btnPreview.Enabled = True
            Case "Picture Resize"
                btnRename.Visible = False
                btnResize.Visible = True
                btnPreview.Enabled = False
                If chkUseRenameOp.Checked Then btnPreview.Enabled = True
        End Select
    End Sub
#End Region
#Region " Image Options Interface Subs "
    Private Sub chkKeepType_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chkKeepType.CheckedChanged
        If chkKeepType.Checked Then
            chkConvertTo.Checked = False
            chkKeepSameJustConvertType.Checked = False
        End If
    End Sub
    Private Sub chkConvertTo_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chkConvertTo.CheckedChanged
        If chkConvertTo.Checked Then
            chkKeepType.Checked = False
            cmbType.Enabled = True
        Else
            cmbType.Enabled = False
        End If
    End Sub
    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        FolderBrowserDialog1.ShowDialog()
        txtCopyImgToDir.Text = FolderBrowserDialog1.SelectedPath
    End Sub
    Private Sub chkKeepSameJustConvertType_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chkKeepSameJustConvertType.CheckedChanged
        If chkKeepSameJustConvertType.Checked Then
            cmbType2.Enabled = True
            chkUseRenameOp.Checked = False
            chkKeepType.Checked = False
            chkConvertTo.Checked = False
            txtWidth.Enabled = False
            txtHeight.Enabled = False
        Else
            cmbType2.Enabled = False
            txtWidth.Enabled = True
            txtHeight.Enabled = True
        End If
    End Sub
    Private Sub chkUseRenameOp_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chkUseRenameOp.CheckedChanged
        If chkUseRenameOp.Checked Then
            chkKeepSameJustConvertType.Checked = False
            btnPreview.Enabled = True
        Else
            btnPreview.Enabled = False
        End If
    End Sub
#End Region
    Private Sub frmMain_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Dim Obj As New BSRegistry
        Me.Text = My.Application.Info.Title
        'MyLogFile = APPLICATION_DATA_PATH & ErrLog

        Try
            Obj.UpDateAppDetails()
            Dim ObjReg As New RegistrationProcess
            Dim ObjFS As New BurnSoft.FileSystem.FileIO
            Dim IsRegistered As Boolean = False
            Dim MyDaysLeft As String = ""
            Dim Has2Expired As Boolean = False
            Dim MyRegTo As String = ""
            Dim MyregPath As String = Obj.DefaultRegPath & "\Settings"
            Call ObjReg.StartRegistration(MyregPath, IsRegistered, MyDaysLeft, Has2Expired, MyRegTo)
            If Not IsRegistered Then
                If Not Has2Expired Then
                    DaysLeftToTry = "You have " & MyDaysLeft & " days left to register!"
                    ToolStripStatusLabel1.Text = "This is a shareware version that will work for " & MyDaysLeft & " days."
                Else
                    BSRegistration.MainFormUnloaded = True
                    BSRegistration.StatusMessage = "This Application has Expired!"
                    BSRegistration.Show()
                    Me.Close()
                End If
            Else
                ToolStripStatusLabel1.Text = "Registered To: " & MyRegTo
                RegisterToolStripMenuItem.Enabled = False
                RegisterToolStripMenuItem.Visible = False
                ToolStripSeparator4.Visible = False
                PurchaseToolStripMenuItem.Visible = False
            End If

            Call ClearQues()
            strLastWorkingPath = Obj.GetLastWorkingDir
            If Len(strLastWorkingPath) > 0 Then
                If ObjFS.DirectoryExists(strLastWorkingPath) Then
                    DirListBox1.Path = strLastWorkingPath
                Else
                    DirListBox1.Path = DriveListBox1.Drive
                End If
            Else
                DirListBox1.Path = DriveListBox1.Drive
            End If
            Call PopFileListing()
            Obj.GetSettings(MyNUmberFormat, TrackHistory, TrackHistoryMaxDays, DoSpecial, SpecialValue)
            txtFormat.Text = MyNUmberFormat
            chkeHistory.Checked = TrackHistory
        Catch ex As Exception
            Call LogError(Me.Name, "frmMain_Load", Err.Number, ex.Message.ToString)
            'Call LogError(Me.Name, "", Err.Number, ex.Message.ToString)
            'Dim ObjBFS As New BurnSoft.FileSystem.FileIO
            'Dim Msg As String = "frmMain_Load" & "::" & Err.Number & "::" & ex.Message.ToString()
            'ObjBFS.LogFile(MyLogFile, Msg)
        End Try
    End Sub

    Private Sub chkUseFolder_CheckedChanged(sender As System.Object, e As System.EventArgs) Handles chkUseFolder.CheckedChanged
        If chkUseFolder.Checked Then
            txtName.Enabled = False
        Else
            txtName.Enabled = True
        End If
    End Sub
End Class
