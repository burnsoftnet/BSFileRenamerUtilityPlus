Imports BSFRUv4.MyFru
Public Class frmOptions
    'Dim DoUpdates As Boolean
    Dim NumberFormat As String
    Dim DoHistory As Boolean
    Dim MaxDays As Integer
    'Dim DoProxy As Boolean
    Dim DoSpecial As Boolean
    Dim SpecialValue As String
    Sub DoSave()
        'DoUpdates = chkUpdates.Checked
        NumberFormat = txtFormat.Text
        DoHistory = chkHist.Checked
        MaxDays = CInt(txtDays.Text)
        DoSpecial = chkSpecial.Checked
        SpecialValue = txtSpecial.Text
        'DoProxy = ChkUseProxy.Checked
        Dim Obj As New BSRegistry
        Obj.SaveSettings(NumberFormat, DoHistory, MaxDays, DoSpecial, SpecialValue)
        Obj = Nothing
    End Sub
    Private Sub btnSave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSave.Click
        Call DoSave()
    End Sub
    Sub LoadData()
        Dim Obj As New BSRegistry
        'Dim bUpdate As Boolean
        'Dim bProxy As Boolean
        'Call Obj.GetSettings(txtFormat.Text, chkHist.Checked, txtDays.Text, chkUpdates.Checked, ChkUseProxy.Checked)
        Call Obj.GetSettings(NumberFormat, DoHistory, MaxDays, DoSpecial, SpecialValue)
        'DoUpdates = bUpdate
        'DoProxy = bProxy
        Obj = Nothing
        'chkUpdates.Checked = DoUpdates
        txtFormat.Text = NumberFormat
        chkHist.Checked = DoHistory
        txtDays.Text = MaxDays
        'ChkUseProxy.Checked = DoProxy
        chkSpecial.Checked = DoSpecial
        txtSpecial.Text = SpecialValue
    End Sub
    Private Sub frmOptions_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        Call LoadData()
    End Sub

    Private Sub btnClose_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnClose.Click
        Me.Close()
    End Sub

    Private Sub btnSaveClose_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSaveClose.Click
        Call DoSave()
        Me.Close()
    End Sub
End Class