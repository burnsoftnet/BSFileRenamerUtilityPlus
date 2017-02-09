Imports BSFRUv4.Cyhper
Imports BSFRUv4.MyFru
Public Class BSRegistration
    Public StatusMessage As String
    Public MainFormUnloaded As Boolean
    Private Sub BSRegistration_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        lblApplicationStatus.Text = StatusMessage
    End Sub

    Private Sub btnRegister_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnRegister.Click
        Dim sKey As String
        Dim oReg As New CGenericRegistration
        Dim oRP As New RegistrationProcess
        Dim oBSR As New BSRegistry

        Dim sMessage As String = ""
        sKey = Replace(txtRegKey.Text, "-", "")
        If oReg.IsKeyOK(sKey, oRP.RegistrationKeyValue) Then
            oRP.JustSave(oBSR.DefaultRegPath & "\Settings", txtRegName.Text, txtRegKey.Text)
            sMessage = "This is a valid Key!" & Chr(10)
            sMessage &= "Thank you for you purchase and we hope" & Chr(10)
            sMessage &= "you enjoy this application."
            MsgBox(sMessage, MsgBoxStyle.Information, "BurnSoft Registration")
            If MainFormUnloaded Then
                Dim NF As New frmMain
                NF.Show()
                'frmMain.Show()
                Me.Close()
            End If
        Else
            sMessage = "This is a invalid Key!" & Chr(10)
            sMessage &= "Please try again, or contact" & Chr(10)
            sMessage &= "Customer support to make sure that you have a vaild" & Chr(10)
            sMessage &= "registration key." & Chr(10)
            MsgBox(sMessage, MsgBoxStyle.Critical, "BurnSoft Registration")
        End If
        oReg = Nothing
    End Sub

    Private Sub btnCancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCancel.Click
        Me.Close()
    End Sub
End Class