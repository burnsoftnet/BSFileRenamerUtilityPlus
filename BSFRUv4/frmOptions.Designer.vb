<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmOptions
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmOptions))
        Me.ImageList1 = New System.Windows.Forms.ImageList(Me.components)
        Me.btnSave = New System.Windows.Forms.Button()
        Me.btnClose = New System.Windows.Forms.Button()
        Me.btnSaveClose = New System.Windows.Forms.Button()
        Me.tpImageOp = New System.Windows.Forms.TabPage()
        Me.tpOptions = New System.Windows.Forms.TabPage()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtFormat = New System.Windows.Forms.TextBox()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.chkHist = New System.Windows.Forms.CheckBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtDays = New System.Windows.Forms.TextBox()
        Me.TabControl1 = New System.Windows.Forms.TabControl()
        Me.chkSpecial = New System.Windows.Forms.CheckBox()
        Me.txtSpecial = New System.Windows.Forms.TextBox()
        Me.tpOptions.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.TabControl1.SuspendLayout()
        Me.SuspendLayout()
        '
        'ImageList1
        '
        Me.ImageList1.ImageStream = CType(resources.GetObject("ImageList1.ImageStream"), System.Windows.Forms.ImageListStreamer)
        Me.ImageList1.TransparentColor = System.Drawing.Color.Transparent
        Me.ImageList1.Images.SetKeyName(0, "Control Panel.ico")
        Me.ImageList1.Images.SetKeyName(1, "Winxpicons_Computer_9_32x32.ico")
        Me.ImageList1.Images.SetKeyName(2, "Winxpicons_System_16_32x32.ico")
        '
        'btnSave
        '
        Me.btnSave.Location = New System.Drawing.Point(13, 200)
        Me.btnSave.Name = "btnSave"
        Me.btnSave.Size = New System.Drawing.Size(75, 23)
        Me.btnSave.TabIndex = 1
        Me.btnSave.Text = "&Save"
        Me.btnSave.UseVisualStyleBackColor = True
        '
        'btnClose
        '
        Me.btnClose.Location = New System.Drawing.Point(217, 200)
        Me.btnClose.Name = "btnClose"
        Me.btnClose.Size = New System.Drawing.Size(75, 23)
        Me.btnClose.TabIndex = 2
        Me.btnClose.Text = "&Close"
        Me.btnClose.UseVisualStyleBackColor = True
        '
        'btnSaveClose
        '
        Me.btnSaveClose.Location = New System.Drawing.Point(94, 200)
        Me.btnSaveClose.Name = "btnSaveClose"
        Me.btnSaveClose.Size = New System.Drawing.Size(117, 23)
        Me.btnSaveClose.TabIndex = 3
        Me.btnSaveClose.Text = "Save && Close"
        Me.btnSaveClose.UseVisualStyleBackColor = True
        '
        'tpImageOp
        '
        Me.tpImageOp.ImageIndex = 2
        Me.tpImageOp.Location = New System.Drawing.Point(4, 23)
        Me.tpImageOp.Name = "tpImageOp"
        Me.tpImageOp.Padding = New System.Windows.Forms.Padding(3)
        Me.tpImageOp.Size = New System.Drawing.Size(297, 164)
        Me.tpImageOp.TabIndex = 2
        Me.tpImageOp.Text = "Image Options"
        Me.tpImageOp.UseVisualStyleBackColor = True
        '
        'tpOptions
        '
        Me.tpOptions.BackColor = System.Drawing.Color.Transparent
        Me.tpOptions.Controls.Add(Me.GroupBox2)
        Me.tpOptions.Controls.Add(Me.GroupBox1)
        Me.tpOptions.ImageIndex = 0
        Me.tpOptions.Location = New System.Drawing.Point(4, 23)
        Me.tpOptions.Name = "tpOptions"
        Me.tpOptions.Padding = New System.Windows.Forms.Padding(3)
        Me.tpOptions.Size = New System.Drawing.Size(297, 164)
        Me.tpOptions.TabIndex = 0
        Me.tpOptions.Text = "Options"
        Me.tpOptions.UseVisualStyleBackColor = True
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.txtSpecial)
        Me.GroupBox1.Controls.Add(Me.chkSpecial)
        Me.GroupBox1.Controls.Add(Me.txtFormat)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Location = New System.Drawing.Point(11, 11)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(283, 73)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "File Renaming Format"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(6, 25)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(197, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Number Format Spaces (Example: 0001)"
        '
        'txtFormat
        '
        Me.txtFormat.Location = New System.Drawing.Point(208, 20)
        Me.txtFormat.Name = "txtFormat"
        Me.txtFormat.Size = New System.Drawing.Size(54, 20)
        Me.txtFormat.TabIndex = 1
        Me.txtFormat.Text = "0000"
        Me.txtFormat.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'GroupBox2
        '
        Me.GroupBox2.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox2.Controls.Add(Me.txtDays)
        Me.GroupBox2.Controls.Add(Me.Label2)
        Me.GroupBox2.Controls.Add(Me.chkHist)
        Me.GroupBox2.Location = New System.Drawing.Point(8, 90)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(283, 68)
        Me.GroupBox2.TabIndex = 1
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "History Tracking"
        '
        'chkHist
        '
        Me.chkHist.AutoSize = True
        Me.chkHist.Location = New System.Drawing.Point(9, 19)
        Me.chkHist.Name = "chkHist"
        Me.chkHist.Size = New System.Drawing.Size(65, 17)
        Me.chkHist.TabIndex = 0
        Me.chkHist.Text = "Enabled"
        Me.chkHist.UseVisualStyleBackColor = True
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(6, 42)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(117, 13)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Keep History for x Days"
        '
        'txtDays
        '
        Me.txtDays.Location = New System.Drawing.Point(208, 39)
        Me.txtDays.Name = "txtDays"
        Me.txtDays.Size = New System.Drawing.Size(54, 20)
        Me.txtDays.TabIndex = 2
        Me.txtDays.Text = "30"
        Me.txtDays.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'TabControl1
        '
        Me.TabControl1.Controls.Add(Me.tpOptions)
        Me.TabControl1.Controls.Add(Me.tpImageOp)
        Me.TabControl1.ImageList = Me.ImageList1
        Me.TabControl1.Location = New System.Drawing.Point(0, 2)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(305, 191)
        Me.TabControl1.TabIndex = 0
        '
        'chkSpecial
        '
        Me.chkSpecial.AutoSize = True
        Me.chkSpecial.Location = New System.Drawing.Point(9, 50)
        Me.chkSpecial.Name = "chkSpecial"
        Me.chkSpecial.Size = New System.Drawing.Size(178, 17)
        Me.chkSpecial.TabIndex = 2
        Me.chkSpecial.Text = "Use Space or Special Character"
        Me.chkSpecial.UseVisualStyleBackColor = True
        '
        'txtSpecial
        '
        Me.txtSpecial.Location = New System.Drawing.Point(208, 47)
        Me.txtSpecial.Name = "txtSpecial"
        Me.txtSpecial.Size = New System.Drawing.Size(54, 20)
        Me.txtSpecial.TabIndex = 3
        Me.txtSpecial.Text = "_"
        '
        'frmOptions
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(304, 235)
        Me.Controls.Add(Me.btnSaveClose)
        Me.Controls.Add(Me.btnClose)
        Me.Controls.Add(Me.btnSave)
        Me.Controls.Add(Me.TabControl1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmOptions"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "File Rename Utlity Settings"
        Me.tpOptions.ResumeLayout(False)
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.TabControl1.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents ImageList1 As System.Windows.Forms.ImageList
    Friend WithEvents btnSave As System.Windows.Forms.Button
    Friend WithEvents btnClose As System.Windows.Forms.Button
    Friend WithEvents btnSaveClose As System.Windows.Forms.Button
    Friend WithEvents tpImageOp As System.Windows.Forms.TabPage
    Friend WithEvents tpOptions As System.Windows.Forms.TabPage
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents txtDays As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents chkHist As System.Windows.Forms.CheckBox
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents txtSpecial As System.Windows.Forms.TextBox
    Friend WithEvents chkSpecial As System.Windows.Forms.CheckBox
    Friend WithEvents txtFormat As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents TabControl1 As System.Windows.Forms.TabControl
End Class
