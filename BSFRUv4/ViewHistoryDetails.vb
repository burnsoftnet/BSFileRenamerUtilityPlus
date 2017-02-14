Imports BSFRUv4.MyFru
Public Class ViewHistoryDetails
    Public ReportID As String
    Sub PopData()
        Me.Text = "History Details"
        Me.Hist_ListTableAdapter.FillBy_RID(Me.FruData.Hist_List, ReportID)
    End Sub
    Private Sub ViewHistoryDetails_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Call PopData()
    End Sub

    Private Sub btnCancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCancel.Click
        Me.Close()
    End Sub
    Sub DoUndo()
        Dim MyRecID As String = CStr(DataGridView1.SelectedCells(0).Value)
        Dim MyNewName As String = CStr(DataGridView1.SelectedCells(3).Value)
        Dim MyOldName As String = CStr(DataGridView1.SelectedCells(2).Value)
        Dim ObjFS As New BurnSoft.FileSystem.FileIO
        ObjFS.MoveFile(MyNewName, MyOldName)
        Dim ObjDB As New Database
        ObjDB.ConnExec("DELETE from Hist_List where ID=" & MyRecID)
        MsgBox("The file has been renamed to it's orginal name and location.", MsgBoxStyle.OkOnly, "BurnSoft File Renamer")
        Call PopData()

    End Sub
    Private Sub btnUndo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnUndo.Click
        Call DoUndo()
    End Sub

    Private Sub UndoToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles UndoToolStripMenuItem.Click
        Call DoUndo()
    End Sub
End Class