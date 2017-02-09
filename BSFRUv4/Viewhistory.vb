Imports BSFRUv4.MyFru
Public Class Viewhistory
    Sub LoadData()
        'Hist_ContentsTableAdapter.Fill(Me.FruHist_Contents.Hist_Contents)
    End Sub
    Sub LoadDetails()
        Dim MyReportID As String = CStr(DataGridView1.SelectedCells(0).Value)
        Dim NF As New ViewHistoryDetails
        NF.Owner = Me
        NF.ReportID = MyReportID
        NF.Show()
    End Sub
    Private Sub Viewhistory_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'FruData.Hist_List' table. You can move, or remove it, as needed.
        Me.Hist_ListTableAdapter.Fill(Me.FruData.Hist_List)
        'TODO: This line of code loads data into the 'FruHist_Contents.Hist_Contents' table. You can move, or remove it, as needed.
        Call LoadData()
    End Sub
    Private Sub DeleteToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DeleteToolStripMenuItem.Click
        Dim MyReportID As String = CStr(DataGridView1.SelectedCells(0).Value)
        Dim ObjDB As New Database
        Dim SQL As String = "DELETE from Hist_List where RID=" & MyReportID
        ObjDB.ConnExec(SQL)
        SQL = "DELETE from Hist_Contents where ID=" & MyReportID
        ObjDB.ConnExec(SQL)
        DataGridView1.Refresh()
        Call LoadData()
        'Debug.Print(DataGridView1.SelectedCells(0).Value)
    End Sub

    Private Sub ViewDetailsToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ViewDetailsToolStripMenuItem.Click
        Call LoadDetails()
    End Sub

    Private Sub DataGridView1_CellContentDoubleClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DataGridView1.CellContentDoubleClick
        Call LoadDetails()
    End Sub

    Private Sub DataGridView1_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DataGridView1.CellContentClick
        'call LoadDetails()
    End Sub
End Class