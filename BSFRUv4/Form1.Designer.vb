<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmMain
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        If disposing AndAlso components IsNot Nothing Then
            components.Dispose()
        End If
        MyBase.Dispose(disposing)
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmMain))
        Me.tbOptions = New System.Windows.Forms.TabControl()
        Me.tpFile = New System.Windows.Forms.TabPage()
        Me.chkUseFolder = New System.Windows.Forms.CheckBox()
        Me.lblMoveDirectory = New System.Windows.Forms.Label()
        Me.chkMove2Dir = New System.Windows.Forms.CheckBox()
        Me.ChkResetToLast = New System.Windows.Forms.CheckBox()
        Me.btnBrowse = New System.Windows.Forms.Button()
        Me.txtBrowse = New System.Windows.Forms.TextBox()
        Me.txtFormat = New System.Windows.Forms.TextBox()
        Me.lblNumFormatSpace = New System.Windows.Forms.Label()
        Me.chkeHistory = New System.Windows.Forms.CheckBox()
        Me.rbAfter = New System.Windows.Forms.RadioButton()
        Me.rbBefore = New System.Windows.Forms.RadioButton()
        Me.rbReplace = New System.Windows.Forms.RadioButton()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtCounter = New System.Windows.Forms.TextBox()
        Me.txtName = New System.Windows.Forms.TextBox()
        Me.chkKeep = New System.Windows.Forms.CheckBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtInc = New System.Windows.Forms.NumericUpDown()
        Me.tpPicture = New System.Windows.Forms.TabPage()
        Me.cmbType2 = New System.Windows.Forms.ComboBox()
        Me.chkKeepSameJustConvertType = New System.Windows.Forms.CheckBox()
        Me.chkUseRenameOp = New System.Windows.Forms.CheckBox()
        Me.cmbType = New System.Windows.Forms.ComboBox()
        Me.chkConvertTo = New System.Windows.Forms.CheckBox()
        Me.chkKeepType = New System.Windows.Forms.CheckBox()
        Me.txtHeight = New System.Windows.Forms.TextBox()
        Me.txtWidth = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.txtCopyImgToDir = New System.Windows.Forms.TextBox()
        Me.ImageList1 = New System.Windows.Forms.ImageList(Me.components)
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.FileToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SettingsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator2 = New System.Windows.Forms.ToolStripSeparator()
        Me.ExitToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.HistoryToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ViewListToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ClearHistoryToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.HelpToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AboutToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.HelpToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator3 = New System.Windows.Forms.ToolStripSeparator()
        Me.RegisterToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.PurchaseToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator4 = New System.Windows.Forms.ToolStripSeparator()
        Me.SupportToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.BurnSoftHomeToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.lblTotal = New System.Windows.Forms.Label()
        Me.lblSelected = New System.Windows.Forms.Label()
        Me.txtFilePat = New System.Windows.Forms.TextBox()
        Me.lblSearchPattern = New System.Windows.Forms.Label()
        Me.DirListBox1 = New Microsoft.VisualBasic.Compatibility.VB6.DirListBox()
        Me.DriveListBox1 = New Microsoft.VisualBasic.Compatibility.VB6.DriveListBox()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.FileListBox1 = New Microsoft.VisualBasic.Compatibility.VB6.FileListBox()
        Me.SysTray = New System.Windows.Forms.NotifyIcon(Me.components)
        Me.SysTrayMenu = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.ExitToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.ShowToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.btnSelectAll = New System.Windows.Forms.Button()
        Me.btnClearSelected = New System.Windows.Forms.Button()
        Me.btnPreview = New System.Windows.Forms.Button()
        Me.btnAddQue = New System.Windows.Forms.Button()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.LstPreview = New System.Windows.Forms.ListBox()
        Me.btnClearQue = New System.Windows.Forms.Button()
        Me.btnRename = New System.Windows.Forms.Button()
        Me.GroupBox4 = New System.Windows.Forms.GroupBox()
        Me.lstQue = New System.Windows.Forms.ListBox()
        Me.StatusStrip1 = New System.Windows.Forms.StatusStrip()
        Me.ToolStripProgressBar1 = New System.Windows.Forms.ToolStripProgressBar()
        Me.ToolStripStatusLabel1 = New System.Windows.Forms.ToolStripStatusLabel()
        Me.FolderBrowserDialog1 = New System.Windows.Forms.FolderBrowserDialog()
        Me.btnResize = New System.Windows.Forms.Button()
        Me.tbOptions.SuspendLayout()
        Me.tpFile.SuspendLayout()
        CType(Me.txtInc, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.tpPicture.SuspendLayout()
        Me.MenuStrip1.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.SysTrayMenu.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.GroupBox4.SuspendLayout()
        Me.StatusStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'tbOptions
        '
        Me.tbOptions.Controls.Add(Me.tpFile)
        Me.tbOptions.Controls.Add(Me.tpPicture)
        resources.ApplyResources(Me.tbOptions, "tbOptions")
        Me.tbOptions.HotTrack = True
        Me.tbOptions.ImageList = Me.ImageList1
        Me.tbOptions.Name = "tbOptions"
        Me.tbOptions.SelectedIndex = 0
        '
        'tpFile
        '
        Me.tpFile.BackColor = System.Drawing.SystemColors.Control
        Me.tpFile.Controls.Add(Me.chkUseFolder)
        Me.tpFile.Controls.Add(Me.lblMoveDirectory)
        Me.tpFile.Controls.Add(Me.chkMove2Dir)
        Me.tpFile.Controls.Add(Me.ChkResetToLast)
        Me.tpFile.Controls.Add(Me.btnBrowse)
        Me.tpFile.Controls.Add(Me.txtBrowse)
        Me.tpFile.Controls.Add(Me.txtFormat)
        Me.tpFile.Controls.Add(Me.lblNumFormatSpace)
        Me.tpFile.Controls.Add(Me.chkeHistory)
        Me.tpFile.Controls.Add(Me.rbAfter)
        Me.tpFile.Controls.Add(Me.rbBefore)
        Me.tpFile.Controls.Add(Me.rbReplace)
        Me.tpFile.Controls.Add(Me.Label3)
        Me.tpFile.Controls.Add(Me.txtCounter)
        Me.tpFile.Controls.Add(Me.txtName)
        Me.tpFile.Controls.Add(Me.chkKeep)
        Me.tpFile.Controls.Add(Me.Label2)
        Me.tpFile.Controls.Add(Me.Label1)
        Me.tpFile.Controls.Add(Me.txtInc)
        resources.ApplyResources(Me.tpFile, "tpFile")
        Me.tpFile.Name = "tpFile"
        '
        'chkUseFolder
        '
        resources.ApplyResources(Me.chkUseFolder, "chkUseFolder")
        Me.chkUseFolder.Name = "chkUseFolder"
        Me.chkUseFolder.UseVisualStyleBackColor = True
        '
        'lblMoveDirectory
        '
        resources.ApplyResources(Me.lblMoveDirectory, "lblMoveDirectory")
        Me.lblMoveDirectory.Name = "lblMoveDirectory"
        '
        'chkMove2Dir
        '
        resources.ApplyResources(Me.chkMove2Dir, "chkMove2Dir")
        Me.chkMove2Dir.Name = "chkMove2Dir"
        Me.chkMove2Dir.UseVisualStyleBackColor = True
        '
        'ChkResetToLast
        '
        resources.ApplyResources(Me.ChkResetToLast, "ChkResetToLast")
        Me.ChkResetToLast.Checked = True
        Me.ChkResetToLast.CheckState = System.Windows.Forms.CheckState.Checked
        Me.ChkResetToLast.Name = "ChkResetToLast"
        Me.ChkResetToLast.UseVisualStyleBackColor = True
        '
        'btnBrowse
        '
        resources.ApplyResources(Me.btnBrowse, "btnBrowse")
        Me.btnBrowse.Name = "btnBrowse"
        Me.btnBrowse.UseVisualStyleBackColor = True
        '
        'txtBrowse
        '
        resources.ApplyResources(Me.txtBrowse, "txtBrowse")
        Me.txtBrowse.Name = "txtBrowse"
        Me.txtBrowse.ReadOnly = True
        '
        'txtFormat
        '
        resources.ApplyResources(Me.txtFormat, "txtFormat")
        Me.txtFormat.Name = "txtFormat"
        '
        'lblNumFormatSpace
        '
        resources.ApplyResources(Me.lblNumFormatSpace, "lblNumFormatSpace")
        Me.lblNumFormatSpace.Name = "lblNumFormatSpace"
        '
        'chkeHistory
        '
        resources.ApplyResources(Me.chkeHistory, "chkeHistory")
        Me.chkeHistory.Name = "chkeHistory"
        Me.chkeHistory.UseVisualStyleBackColor = True
        '
        'rbAfter
        '
        resources.ApplyResources(Me.rbAfter, "rbAfter")
        Me.rbAfter.Name = "rbAfter"
        Me.rbAfter.UseVisualStyleBackColor = True
        '
        'rbBefore
        '
        resources.ApplyResources(Me.rbBefore, "rbBefore")
        Me.rbBefore.Name = "rbBefore"
        Me.rbBefore.UseVisualStyleBackColor = True
        '
        'rbReplace
        '
        resources.ApplyResources(Me.rbReplace, "rbReplace")
        Me.rbReplace.Checked = True
        Me.rbReplace.Name = "rbReplace"
        Me.rbReplace.TabStop = True
        Me.rbReplace.UseVisualStyleBackColor = True
        '
        'Label3
        '
        resources.ApplyResources(Me.Label3, "Label3")
        Me.Label3.Name = "Label3"
        '
        'txtCounter
        '
        resources.ApplyResources(Me.txtCounter, "txtCounter")
        Me.txtCounter.Name = "txtCounter"
        '
        'txtName
        '
        resources.ApplyResources(Me.txtName, "txtName")
        Me.txtName.Name = "txtName"
        '
        'chkKeep
        '
        resources.ApplyResources(Me.chkKeep, "chkKeep")
        Me.chkKeep.Checked = True
        Me.chkKeep.CheckState = System.Windows.Forms.CheckState.Checked
        Me.chkKeep.Name = "chkKeep"
        Me.chkKeep.UseVisualStyleBackColor = True
        '
        'Label2
        '
        resources.ApplyResources(Me.Label2, "Label2")
        Me.Label2.Name = "Label2"
        '
        'Label1
        '
        resources.ApplyResources(Me.Label1, "Label1")
        Me.Label1.Name = "Label1"
        '
        'txtInc
        '
        resources.ApplyResources(Me.txtInc, "txtInc")
        Me.txtInc.Name = "txtInc"
        Me.txtInc.Value = New Decimal(New Integer() {1, 0, 0, 0})
        '
        'tpPicture
        '
        Me.tpPicture.BackColor = System.Drawing.SystemColors.Control
        Me.tpPicture.Controls.Add(Me.cmbType2)
        Me.tpPicture.Controls.Add(Me.chkKeepSameJustConvertType)
        Me.tpPicture.Controls.Add(Me.chkUseRenameOp)
        Me.tpPicture.Controls.Add(Me.cmbType)
        Me.tpPicture.Controls.Add(Me.chkConvertTo)
        Me.tpPicture.Controls.Add(Me.chkKeepType)
        Me.tpPicture.Controls.Add(Me.txtHeight)
        Me.tpPicture.Controls.Add(Me.txtWidth)
        Me.tpPicture.Controls.Add(Me.Label6)
        Me.tpPicture.Controls.Add(Me.Label5)
        Me.tpPicture.Controls.Add(Me.Label4)
        Me.tpPicture.Controls.Add(Me.Button1)
        Me.tpPicture.Controls.Add(Me.txtCopyImgToDir)
        resources.ApplyResources(Me.tpPicture, "tpPicture")
        Me.tpPicture.Name = "tpPicture"
        '
        'cmbType2
        '
        resources.ApplyResources(Me.cmbType2, "cmbType2")
        Me.cmbType2.FormattingEnabled = True
        Me.cmbType2.Items.AddRange(New Object() {resources.GetString("cmbType2.Items"), resources.GetString("cmbType2.Items1"), resources.GetString("cmbType2.Items2"), resources.GetString("cmbType2.Items3"), resources.GetString("cmbType2.Items4"), resources.GetString("cmbType2.Items5"), resources.GetString("cmbType2.Items6"), resources.GetString("cmbType2.Items7"), resources.GetString("cmbType2.Items8")})
        Me.cmbType2.Name = "cmbType2"
        '
        'chkKeepSameJustConvertType
        '
        resources.ApplyResources(Me.chkKeepSameJustConvertType, "chkKeepSameJustConvertType")
        Me.chkKeepSameJustConvertType.Name = "chkKeepSameJustConvertType"
        Me.chkKeepSameJustConvertType.UseVisualStyleBackColor = True
        '
        'chkUseRenameOp
        '
        resources.ApplyResources(Me.chkUseRenameOp, "chkUseRenameOp")
        Me.chkUseRenameOp.Name = "chkUseRenameOp"
        Me.chkUseRenameOp.UseVisualStyleBackColor = True
        '
        'cmbType
        '
        resources.ApplyResources(Me.cmbType, "cmbType")
        Me.cmbType.FormattingEnabled = True
        Me.cmbType.Items.AddRange(New Object() {resources.GetString("cmbType.Items"), resources.GetString("cmbType.Items1"), resources.GetString("cmbType.Items2"), resources.GetString("cmbType.Items3"), resources.GetString("cmbType.Items4"), resources.GetString("cmbType.Items5"), resources.GetString("cmbType.Items6"), resources.GetString("cmbType.Items7"), resources.GetString("cmbType.Items8")})
        Me.cmbType.Name = "cmbType"
        '
        'chkConvertTo
        '
        resources.ApplyResources(Me.chkConvertTo, "chkConvertTo")
        Me.chkConvertTo.Name = "chkConvertTo"
        Me.chkConvertTo.UseVisualStyleBackColor = True
        '
        'chkKeepType
        '
        resources.ApplyResources(Me.chkKeepType, "chkKeepType")
        Me.chkKeepType.Checked = True
        Me.chkKeepType.CheckState = System.Windows.Forms.CheckState.Checked
        Me.chkKeepType.Name = "chkKeepType"
        Me.chkKeepType.UseVisualStyleBackColor = True
        '
        'txtHeight
        '
        resources.ApplyResources(Me.txtHeight, "txtHeight")
        Me.txtHeight.Name = "txtHeight"
        '
        'txtWidth
        '
        resources.ApplyResources(Me.txtWidth, "txtWidth")
        Me.txtWidth.Name = "txtWidth"
        '
        'Label6
        '
        resources.ApplyResources(Me.Label6, "Label6")
        Me.Label6.Name = "Label6"
        '
        'Label5
        '
        resources.ApplyResources(Me.Label5, "Label5")
        Me.Label5.Name = "Label5"
        '
        'Label4
        '
        resources.ApplyResources(Me.Label4, "Label4")
        Me.Label4.Name = "Label4"
        '
        'Button1
        '
        resources.ApplyResources(Me.Button1, "Button1")
        Me.Button1.Name = "Button1"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'txtCopyImgToDir
        '
        resources.ApplyResources(Me.txtCopyImgToDir, "txtCopyImgToDir")
        Me.txtCopyImgToDir.Name = "txtCopyImgToDir"
        Me.txtCopyImgToDir.ReadOnly = True
        '
        'ImageList1
        '
        Me.ImageList1.ImageStream = CType(resources.GetObject("ImageList1.ImageStream"), System.Windows.Forms.ImageListStreamer)
        Me.ImageList1.TransparentColor = System.Drawing.Color.Transparent
        Me.ImageList1.Images.SetKeyName(0, "NOTE16.ICO")
        Me.ImageList1.Images.SetKeyName(1, "Winxpicons_System_16_32x32.ico")
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.FileToolStripMenuItem, Me.HistoryToolStripMenuItem, Me.HelpToolStripMenuItem})
        resources.ApplyResources(Me.MenuStrip1, "MenuStrip1")
        Me.MenuStrip1.Name = "MenuStrip1"
        '
        'FileToolStripMenuItem
        '
        Me.FileToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.SettingsToolStripMenuItem, Me.ToolStripSeparator2, Me.ExitToolStripMenuItem1})
        Me.FileToolStripMenuItem.Name = "FileToolStripMenuItem"
        resources.ApplyResources(Me.FileToolStripMenuItem, "FileToolStripMenuItem")
        '
        'SettingsToolStripMenuItem
        '
        Me.SettingsToolStripMenuItem.Name = "SettingsToolStripMenuItem"
        resources.ApplyResources(Me.SettingsToolStripMenuItem, "SettingsToolStripMenuItem")
        '
        'ToolStripSeparator2
        '
        Me.ToolStripSeparator2.Name = "ToolStripSeparator2"
        resources.ApplyResources(Me.ToolStripSeparator2, "ToolStripSeparator2")
        '
        'ExitToolStripMenuItem1
        '
        Me.ExitToolStripMenuItem1.Name = "ExitToolStripMenuItem1"
        resources.ApplyResources(Me.ExitToolStripMenuItem1, "ExitToolStripMenuItem1")
        '
        'HistoryToolStripMenuItem
        '
        Me.HistoryToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ViewListToolStripMenuItem, Me.ClearHistoryToolStripMenuItem})
        Me.HistoryToolStripMenuItem.Name = "HistoryToolStripMenuItem"
        resources.ApplyResources(Me.HistoryToolStripMenuItem, "HistoryToolStripMenuItem")
        '
        'ViewListToolStripMenuItem
        '
        Me.ViewListToolStripMenuItem.Name = "ViewListToolStripMenuItem"
        resources.ApplyResources(Me.ViewListToolStripMenuItem, "ViewListToolStripMenuItem")
        '
        'ClearHistoryToolStripMenuItem
        '
        Me.ClearHistoryToolStripMenuItem.Name = "ClearHistoryToolStripMenuItem"
        resources.ApplyResources(Me.ClearHistoryToolStripMenuItem, "ClearHistoryToolStripMenuItem")
        '
        'HelpToolStripMenuItem
        '
        Me.HelpToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.AboutToolStripMenuItem, Me.HelpToolStripMenuItem1, Me.ToolStripSeparator3, Me.RegisterToolStripMenuItem, Me.PurchaseToolStripMenuItem, Me.ToolStripSeparator4, Me.SupportToolStripMenuItem, Me.BurnSoftHomeToolStripMenuItem})
        Me.HelpToolStripMenuItem.Name = "HelpToolStripMenuItem"
        resources.ApplyResources(Me.HelpToolStripMenuItem, "HelpToolStripMenuItem")
        '
        'AboutToolStripMenuItem
        '
        Me.AboutToolStripMenuItem.Name = "AboutToolStripMenuItem"
        resources.ApplyResources(Me.AboutToolStripMenuItem, "AboutToolStripMenuItem")
        '
        'HelpToolStripMenuItem1
        '
        Me.HelpToolStripMenuItem1.Name = "HelpToolStripMenuItem1"
        resources.ApplyResources(Me.HelpToolStripMenuItem1, "HelpToolStripMenuItem1")
        '
        'ToolStripSeparator3
        '
        Me.ToolStripSeparator3.Name = "ToolStripSeparator3"
        resources.ApplyResources(Me.ToolStripSeparator3, "ToolStripSeparator3")
        '
        'RegisterToolStripMenuItem
        '
        Me.RegisterToolStripMenuItem.Name = "RegisterToolStripMenuItem"
        resources.ApplyResources(Me.RegisterToolStripMenuItem, "RegisterToolStripMenuItem")
        '
        'PurchaseToolStripMenuItem
        '
        Me.PurchaseToolStripMenuItem.Name = "PurchaseToolStripMenuItem"
        resources.ApplyResources(Me.PurchaseToolStripMenuItem, "PurchaseToolStripMenuItem")
        '
        'ToolStripSeparator4
        '
        Me.ToolStripSeparator4.Name = "ToolStripSeparator4"
        resources.ApplyResources(Me.ToolStripSeparator4, "ToolStripSeparator4")
        '
        'SupportToolStripMenuItem
        '
        Me.SupportToolStripMenuItem.Name = "SupportToolStripMenuItem"
        resources.ApplyResources(Me.SupportToolStripMenuItem, "SupportToolStripMenuItem")
        '
        'BurnSoftHomeToolStripMenuItem
        '
        Me.BurnSoftHomeToolStripMenuItem.Name = "BurnSoftHomeToolStripMenuItem"
        resources.ApplyResources(Me.BurnSoftHomeToolStripMenuItem, "BurnSoftHomeToolStripMenuItem")
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.lblTotal)
        Me.GroupBox1.Controls.Add(Me.lblSelected)
        Me.GroupBox1.Controls.Add(Me.txtFilePat)
        Me.GroupBox1.Controls.Add(Me.lblSearchPattern)
        Me.GroupBox1.Controls.Add(Me.DirListBox1)
        Me.GroupBox1.Controls.Add(Me.DriveListBox1)
        resources.ApplyResources(Me.GroupBox1, "GroupBox1")
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.TabStop = False
        '
        'lblTotal
        '
        Me.lblTotal.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        resources.ApplyResources(Me.lblTotal, "lblTotal")
        Me.lblTotal.Name = "lblTotal"
        '
        'lblSelected
        '
        Me.lblSelected.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        resources.ApplyResources(Me.lblSelected, "lblSelected")
        Me.lblSelected.Name = "lblSelected"
        '
        'txtFilePat
        '
        resources.ApplyResources(Me.txtFilePat, "txtFilePat")
        Me.txtFilePat.Name = "txtFilePat"
        '
        'lblSearchPattern
        '
        resources.ApplyResources(Me.lblSearchPattern, "lblSearchPattern")
        Me.lblSearchPattern.Name = "lblSearchPattern"
        '
        'DirListBox1
        '
        Me.DirListBox1.FormattingEnabled = True
        resources.ApplyResources(Me.DirListBox1, "DirListBox1")
        Me.DirListBox1.Name = "DirListBox1"
        '
        'DriveListBox1
        '
        Me.DriveListBox1.FormattingEnabled = True
        resources.ApplyResources(Me.DriveListBox1, "DriveListBox1")
        Me.DriveListBox1.Name = "DriveListBox1"
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.FileListBox1)
        resources.ApplyResources(Me.GroupBox2, "GroupBox2")
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.TabStop = False
        '
        'FileListBox1
        '
        Me.FileListBox1.FormattingEnabled = True
        resources.ApplyResources(Me.FileListBox1, "FileListBox1")
        Me.FileListBox1.Name = "FileListBox1"
        Me.FileListBox1.Pattern = "*.*"
        Me.FileListBox1.SelectionMode = System.Windows.Forms.SelectionMode.MultiSimple
        '
        'SysTray
        '
        Me.SysTray.BalloonTipIcon = System.Windows.Forms.ToolTipIcon.Info
        resources.ApplyResources(Me.SysTray, "SysTray")
        Me.SysTray.ContextMenuStrip = Me.SysTrayMenu
        '
        'SysTrayMenu
        '
        Me.SysTrayMenu.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ExitToolStripMenuItem, Me.ToolStripSeparator1, Me.ShowToolStripMenuItem})
        Me.SysTrayMenu.Name = "SysTrayMenu"
        resources.ApplyResources(Me.SysTrayMenu, "SysTrayMenu")
        '
        'ExitToolStripMenuItem
        '
        Me.ExitToolStripMenuItem.Name = "ExitToolStripMenuItem"
        resources.ApplyResources(Me.ExitToolStripMenuItem, "ExitToolStripMenuItem")
        '
        'ToolStripSeparator1
        '
        Me.ToolStripSeparator1.Name = "ToolStripSeparator1"
        resources.ApplyResources(Me.ToolStripSeparator1, "ToolStripSeparator1")
        '
        'ShowToolStripMenuItem
        '
        Me.ShowToolStripMenuItem.Name = "ShowToolStripMenuItem"
        resources.ApplyResources(Me.ShowToolStripMenuItem, "ShowToolStripMenuItem")
        '
        'btnSelectAll
        '
        resources.ApplyResources(Me.btnSelectAll, "btnSelectAll")
        Me.btnSelectAll.Name = "btnSelectAll"
        Me.btnSelectAll.UseVisualStyleBackColor = True
        '
        'btnClearSelected
        '
        resources.ApplyResources(Me.btnClearSelected, "btnClearSelected")
        Me.btnClearSelected.Name = "btnClearSelected"
        Me.btnClearSelected.UseVisualStyleBackColor = True
        '
        'btnPreview
        '
        resources.ApplyResources(Me.btnPreview, "btnPreview")
        Me.btnPreview.Name = "btnPreview"
        Me.btnPreview.UseVisualStyleBackColor = True
        '
        'btnAddQue
        '
        resources.ApplyResources(Me.btnAddQue, "btnAddQue")
        Me.btnAddQue.Name = "btnAddQue"
        Me.btnAddQue.UseVisualStyleBackColor = True
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.LstPreview)
        resources.ApplyResources(Me.GroupBox3, "GroupBox3")
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.TabStop = False
        '
        'LstPreview
        '
        Me.LstPreview.FormattingEnabled = True
        resources.ApplyResources(Me.LstPreview, "LstPreview")
        Me.LstPreview.Name = "LstPreview"
        '
        'btnClearQue
        '
        resources.ApplyResources(Me.btnClearQue, "btnClearQue")
        Me.btnClearQue.Name = "btnClearQue"
        Me.btnClearQue.UseVisualStyleBackColor = True
        '
        'btnRename
        '
        resources.ApplyResources(Me.btnRename, "btnRename")
        Me.btnRename.Name = "btnRename"
        Me.btnRename.UseVisualStyleBackColor = True
        '
        'GroupBox4
        '
        Me.GroupBox4.Controls.Add(Me.lstQue)
        resources.ApplyResources(Me.GroupBox4, "GroupBox4")
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.TabStop = False
        '
        'lstQue
        '
        Me.lstQue.FormattingEnabled = True
        resources.ApplyResources(Me.lstQue, "lstQue")
        Me.lstQue.Name = "lstQue"
        Me.lstQue.SelectionMode = System.Windows.Forms.SelectionMode.MultiExtended
        '
        'StatusStrip1
        '
        Me.StatusStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripProgressBar1, Me.ToolStripStatusLabel1})
        resources.ApplyResources(Me.StatusStrip1, "StatusStrip1")
        Me.StatusStrip1.Name = "StatusStrip1"
        '
        'ToolStripProgressBar1
        '
        Me.ToolStripProgressBar1.Name = "ToolStripProgressBar1"
        resources.ApplyResources(Me.ToolStripProgressBar1, "ToolStripProgressBar1")
        '
        'ToolStripStatusLabel1
        '
        Me.ToolStripStatusLabel1.Name = "ToolStripStatusLabel1"
        resources.ApplyResources(Me.ToolStripStatusLabel1, "ToolStripStatusLabel1")
        Me.ToolStripStatusLabel1.Spring = True
        '
        'btnResize
        '
        resources.ApplyResources(Me.btnResize, "btnResize")
        Me.btnResize.Name = "btnResize"
        Me.btnResize.UseVisualStyleBackColor = True
        '
        'frmMain
        '
        resources.ApplyResources(Me, "$this")
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.StatusStrip1)
        Me.Controls.Add(Me.GroupBox4)
        Me.Controls.Add(Me.btnResize)
        Me.Controls.Add(Me.btnRename)
        Me.Controls.Add(Me.btnClearQue)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.btnAddQue)
        Me.Controls.Add(Me.btnPreview)
        Me.Controls.Add(Me.btnClearSelected)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.btnSelectAll)
        Me.Controls.Add(Me.tbOptions)
        Me.Controls.Add(Me.MenuStrip1)
        Me.Controls.Add(Me.GroupBox1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D
        Me.HelpButton = True
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "frmMain"
        Me.tbOptions.ResumeLayout(False)
        Me.tpFile.ResumeLayout(False)
        Me.tpFile.PerformLayout()
        CType(Me.txtInc, System.ComponentModel.ISupportInitialize).EndInit()
        Me.tpPicture.ResumeLayout(False)
        Me.tpPicture.PerformLayout()
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.SysTrayMenu.ResumeLayout(False)
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox4.ResumeLayout(False)
        Me.StatusStrip1.ResumeLayout(False)
        Me.StatusStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents tbOptions As System.Windows.Forms.TabControl
    Friend WithEvents tpFile As System.Windows.Forms.TabPage
    Friend WithEvents tpPicture As System.Windows.Forms.TabPage
    Friend WithEvents MenuStrip1 As System.Windows.Forms.MenuStrip
    Friend WithEvents FileToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents HistoryToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents HelpToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents txtInc As System.Windows.Forms.NumericUpDown
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents DirListBox1 As Microsoft.VisualBasic.Compatibility.VB6.DirListBox
    Friend WithEvents DriveListBox1 As Microsoft.VisualBasic.Compatibility.VB6.DriveListBox
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents FileListBox1 As Microsoft.VisualBasic.Compatibility.VB6.FileListBox
    Friend WithEvents AboutToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents txtFilePat As System.Windows.Forms.TextBox
    Friend WithEvents lblSearchPattern As System.Windows.Forms.Label
    Friend WithEvents lblTotal As System.Windows.Forms.Label
    Friend WithEvents lblSelected As System.Windows.Forms.Label
    Friend WithEvents SysTray As System.Windows.Forms.NotifyIcon
    Friend WithEvents SysTrayMenu As System.Windows.Forms.ContextMenuStrip
    Friend WithEvents ExitToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripSeparator1 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents ShowToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents btnSelectAll As System.Windows.Forms.Button
    Friend WithEvents btnClearSelected As System.Windows.Forms.Button
    Friend WithEvents btnPreview As System.Windows.Forms.Button
    Friend WithEvents btnAddQue As System.Windows.Forms.Button
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
    Friend WithEvents LstPreview As System.Windows.Forms.ListBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents txtCounter As System.Windows.Forms.TextBox
    Friend WithEvents txtName As System.Windows.Forms.TextBox
    Friend WithEvents chkKeep As System.Windows.Forms.CheckBox
    Friend WithEvents rbAfter As System.Windows.Forms.RadioButton
    Friend WithEvents rbBefore As System.Windows.Forms.RadioButton
    Friend WithEvents rbReplace As System.Windows.Forms.RadioButton
    Friend WithEvents SettingsToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripSeparator2 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents ExitToolStripMenuItem1 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents btnClearQue As System.Windows.Forms.Button
    Friend WithEvents btnRename As System.Windows.Forms.Button
    Friend WithEvents GroupBox4 As System.Windows.Forms.GroupBox
    Friend WithEvents lstQue As System.Windows.Forms.ListBox
    Friend WithEvents StatusStrip1 As System.Windows.Forms.StatusStrip
    Friend WithEvents ToolStripProgressBar1 As System.Windows.Forms.ToolStripProgressBar
    Friend WithEvents ChkResetToLast As System.Windows.Forms.CheckBox
    Friend WithEvents btnBrowse As System.Windows.Forms.Button
    Friend WithEvents txtBrowse As System.Windows.Forms.TextBox
    Friend WithEvents txtFormat As System.Windows.Forms.TextBox
    Friend WithEvents lblNumFormatSpace As System.Windows.Forms.Label
    Friend WithEvents chkeHistory As System.Windows.Forms.CheckBox
    Friend WithEvents lblMoveDirectory As System.Windows.Forms.Label
    Friend WithEvents chkMove2Dir As System.Windows.Forms.CheckBox
    Friend WithEvents FolderBrowserDialog1 As System.Windows.Forms.FolderBrowserDialog
    Friend WithEvents ToolStripStatusLabel1 As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents ViewListToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ClearHistoryToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents HelpToolStripMenuItem1 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripSeparator3 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents RegisterToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents PurchaseToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripSeparator4 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents SupportToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents BurnSoftHomeToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ImageList1 As System.Windows.Forms.ImageList
    Friend WithEvents btnResize As System.Windows.Forms.Button
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents txtCopyImgToDir As System.Windows.Forms.TextBox
    Friend WithEvents txtHeight As System.Windows.Forms.TextBox
    Friend WithEvents txtWidth As System.Windows.Forms.TextBox
    Friend WithEvents cmbType As System.Windows.Forms.ComboBox
    Friend WithEvents chkConvertTo As System.Windows.Forms.CheckBox
    Friend WithEvents chkKeepType As System.Windows.Forms.CheckBox
    Friend WithEvents chkUseRenameOp As System.Windows.Forms.CheckBox
    Friend WithEvents cmbType2 As System.Windows.Forms.ComboBox
    Friend WithEvents chkKeepSameJustConvertType As System.Windows.Forms.CheckBox
    Friend WithEvents chkUseFolder As System.Windows.Forms.CheckBox

End Class
