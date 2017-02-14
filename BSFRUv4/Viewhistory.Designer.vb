<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Viewhistory
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Viewhistory))
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.ContextMenuStrip1 = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.ViewDetailsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.DeleteToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.FruData = New BSFRUv4.fruData()
        Me.HistContentsBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Hist_ContentsTableAdapter = New BSFRUv4.fruDataTableAdapters.Hist_ContentsTableAdapter()
        Me.IDDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CDateDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DirectoryDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.ContextMenuStrip1.SuspendLayout()
        CType(Me.FruData, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.HistContentsBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'DataGridView1
        '
        Me.DataGridView1.AllowUserToAddRows = False
        Me.DataGridView1.AllowUserToResizeRows = False
        Me.DataGridView1.AutoGenerateColumns = False
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.IDDataGridViewTextBoxColumn, Me.CDateDataGridViewTextBoxColumn, Me.DirectoryDataGridViewTextBoxColumn})
        Me.DataGridView1.ContextMenuStrip = Me.ContextMenuStrip1
        Me.DataGridView1.DataSource = Me.HistContentsBindingSource
        Me.DataGridView1.Location = New System.Drawing.Point(1, 12)
        Me.DataGridView1.MultiSelect = False
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DataGridView1.Size = New System.Drawing.Size(568, 348)
        Me.DataGridView1.TabIndex = 0
        '
        'ContextMenuStrip1
        '
        Me.ContextMenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ViewDetailsToolStripMenuItem, Me.ToolStripSeparator1, Me.DeleteToolStripMenuItem})
        Me.ContextMenuStrip1.Name = "ContextMenuStrip1"
        Me.ContextMenuStrip1.Size = New System.Drawing.Size(138, 54)
        '
        'ViewDetailsToolStripMenuItem
        '
        Me.ViewDetailsToolStripMenuItem.Name = "ViewDetailsToolStripMenuItem"
        Me.ViewDetailsToolStripMenuItem.Size = New System.Drawing.Size(137, 22)
        Me.ViewDetailsToolStripMenuItem.Text = "View Details"
        '
        'ToolStripSeparator1
        '
        Me.ToolStripSeparator1.Name = "ToolStripSeparator1"
        Me.ToolStripSeparator1.Size = New System.Drawing.Size(134, 6)
        '
        'DeleteToolStripMenuItem
        '
        Me.DeleteToolStripMenuItem.Name = "DeleteToolStripMenuItem"
        Me.DeleteToolStripMenuItem.Size = New System.Drawing.Size(137, 22)
        Me.DeleteToolStripMenuItem.Text = "&Delete"
        '
        'FruData
        '
        Me.FruData.DataSetName = "fruData"
        Me.FruData.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'HistContentsBindingSource
        '
        Me.HistContentsBindingSource.DataMember = "Hist_Contents"
        Me.HistContentsBindingSource.DataSource = Me.FruData
        '
        'Hist_ContentsTableAdapter
        '
        Me.Hist_ContentsTableAdapter.ClearBeforeFill = True
        '
        'IDDataGridViewTextBoxColumn
        '
        Me.IDDataGridViewTextBoxColumn.DataPropertyName = "ID"
        Me.IDDataGridViewTextBoxColumn.HeaderText = "ID"
        Me.IDDataGridViewTextBoxColumn.Name = "IDDataGridViewTextBoxColumn"
        Me.IDDataGridViewTextBoxColumn.Visible = False
        '
        'CDateDataGridViewTextBoxColumn
        '
        Me.CDateDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.CDateDataGridViewTextBoxColumn.DataPropertyName = "CDate"
        Me.CDateDataGridViewTextBoxColumn.HeaderText = "Date & Time Created"
        Me.CDateDataGridViewTextBoxColumn.Name = "CDateDataGridViewTextBoxColumn"
        Me.CDateDataGridViewTextBoxColumn.Width = 119
        '
        'DirectoryDataGridViewTextBoxColumn
        '
        Me.DirectoryDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.DirectoryDataGridViewTextBoxColumn.DataPropertyName = "Directory"
        Me.DirectoryDataGridViewTextBoxColumn.HeaderText = "Root Directory"
        Me.DirectoryDataGridViewTextBoxColumn.Name = "DirectoryDataGridViewTextBoxColumn"
        Me.DirectoryDataGridViewTextBoxColumn.Width = 92
        '
        'Viewhistory
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(573, 362)
        Me.Controls.Add(Me.DataGridView1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MaximumSize = New System.Drawing.Size(589, 400)
        Me.Name = "Viewhistory"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "View History"
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ContextMenuStrip1.ResumeLayout(False)
        CType(Me.FruData, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.HistContentsBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents DataGridView1 As System.Windows.Forms.DataGridView
    Friend WithEvents ContextMenuStrip1 As System.Windows.Forms.ContextMenuStrip
    Friend WithEvents DeleteToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripSeparator1 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents ViewDetailsToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents FruData As BSFRUv4.fruData
    Friend WithEvents HistContentsBindingSource As BindingSource
    Friend WithEvents Hist_ContentsTableAdapter As fruDataTableAdapters.Hist_ContentsTableAdapter
    Friend WithEvents IDDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents CDateDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents DirectoryDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
End Class
