<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class ViewHistoryDetails
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(ViewHistoryDetails))
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.ContextMenuStrip1 = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.UndoToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.btnUndo = New System.Windows.Forms.Button()
        Me.btnCancel = New System.Windows.Forms.Button()
        Me.FruData = New BSFRUv4.fruData()
        Me.HistListBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Hist_ListTableAdapter = New BSFRUv4.fruDataTableAdapters.Hist_ListTableAdapter()
        Me.DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.ContextMenuStrip1.SuspendLayout()
        CType(Me.FruData, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.HistListBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'DataGridView1
        '
        Me.DataGridView1.AllowUserToAddRows = False
        Me.DataGridView1.AllowUserToDeleteRows = False
        Me.DataGridView1.AllowUserToOrderColumns = True
        Me.DataGridView1.AllowUserToResizeRows = False
        Me.DataGridView1.AutoGenerateColumns = False
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn1, Me.DataGridViewTextBoxColumn2, Me.DataGridViewTextBoxColumn3, Me.DataGridViewTextBoxColumn4})
        Me.DataGridView1.ContextMenuStrip = Me.ContextMenuStrip1
        Me.DataGridView1.DataSource = Me.HistListBindingSource
        Me.DataGridView1.Location = New System.Drawing.Point(3, 3)
        Me.DataGridView1.MultiSelect = False
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.ReadOnly = True
        Me.DataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DataGridView1.Size = New System.Drawing.Size(642, 471)
        Me.DataGridView1.TabIndex = 0
        '
        'ContextMenuStrip1
        '
        Me.ContextMenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.UndoToolStripMenuItem})
        Me.ContextMenuStrip1.Name = "ContextMenuStrip1"
        Me.ContextMenuStrip1.Size = New System.Drawing.Size(104, 26)
        '
        'UndoToolStripMenuItem
        '
        Me.UndoToolStripMenuItem.Name = "UndoToolStripMenuItem"
        Me.UndoToolStripMenuItem.Size = New System.Drawing.Size(103, 22)
        Me.UndoToolStripMenuItem.Text = "&Undo"
        '
        'btnUndo
        '
        Me.btnUndo.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnUndo.Location = New System.Drawing.Point(197, 485)
        Me.btnUndo.Name = "btnUndo"
        Me.btnUndo.Size = New System.Drawing.Size(115, 23)
        Me.btnUndo.TabIndex = 1
        Me.btnUndo.Text = "&Undo"
        Me.btnUndo.UseVisualStyleBackColor = True
        '
        'btnCancel
        '
        Me.btnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnCancel.Location = New System.Drawing.Point(376, 485)
        Me.btnCancel.Name = "btnCancel"
        Me.btnCancel.Size = New System.Drawing.Size(115, 23)
        Me.btnCancel.TabIndex = 2
        Me.btnCancel.Text = "&Cancel"
        Me.btnCancel.UseVisualStyleBackColor = True
        '
        'FruData
        '
        Me.FruData.DataSetName = "fruData"
        Me.FruData.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'HistListBindingSource
        '
        Me.HistListBindingSource.DataMember = "Hist_List"
        Me.HistListBindingSource.DataSource = Me.FruData
        '
        'Hist_ListTableAdapter
        '
        Me.Hist_ListTableAdapter.ClearBeforeFill = True
        '
        'DataGridViewTextBoxColumn1
        '
        Me.DataGridViewTextBoxColumn1.DataPropertyName = "ID"
        Me.DataGridViewTextBoxColumn1.HeaderText = "ID"
        Me.DataGridViewTextBoxColumn1.Name = "DataGridViewTextBoxColumn1"
        Me.DataGridViewTextBoxColumn1.ReadOnly = True
        Me.DataGridViewTextBoxColumn1.Visible = False
        '
        'DataGridViewTextBoxColumn2
        '
        Me.DataGridViewTextBoxColumn2.DataPropertyName = "RID"
        Me.DataGridViewTextBoxColumn2.HeaderText = "RID"
        Me.DataGridViewTextBoxColumn2.Name = "DataGridViewTextBoxColumn2"
        Me.DataGridViewTextBoxColumn2.ReadOnly = True
        Me.DataGridViewTextBoxColumn2.Visible = False
        '
        'DataGridViewTextBoxColumn3
        '
        Me.DataGridViewTextBoxColumn3.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.DataGridViewTextBoxColumn3.DataPropertyName = "Before"
        Me.DataGridViewTextBoxColumn3.HeaderText = "File Before"
        Me.DataGridViewTextBoxColumn3.Name = "DataGridViewTextBoxColumn3"
        Me.DataGridViewTextBoxColumn3.ReadOnly = True
        Me.DataGridViewTextBoxColumn3.Width = 82
        '
        'DataGridViewTextBoxColumn4
        '
        Me.DataGridViewTextBoxColumn4.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.DataGridViewTextBoxColumn4.DataPropertyName = "After"
        Me.DataGridViewTextBoxColumn4.HeaderText = "File After"
        Me.DataGridViewTextBoxColumn4.Name = "DataGridViewTextBoxColumn4"
        Me.DataGridViewTextBoxColumn4.ReadOnly = True
        Me.DataGridViewTextBoxColumn4.Width = 73
        '
        'ViewHistoryDetails
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(640, 516)
        Me.Controls.Add(Me.btnCancel)
        Me.Controls.Add(Me.btnUndo)
        Me.Controls.Add(Me.DataGridView1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MaximumSize = New System.Drawing.Size(656, 554)
        Me.Name = "ViewHistoryDetails"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "History Details"
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ContextMenuStrip1.ResumeLayout(False)
        CType(Me.FruData, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.HistListBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents DataGridView1 As System.Windows.Forms.DataGridView
    Friend WithEvents btnUndo As System.Windows.Forms.Button
    Friend WithEvents btnCancel As System.Windows.Forms.Button

    Friend WithEvents IDDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents RIDDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents BeforeDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents AfterDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ContextMenuStrip1 As System.Windows.Forms.ContextMenuStrip
    Friend WithEvents UndoToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents FruData As fruData
    Friend WithEvents HistListBindingSource As BindingSource
    Friend WithEvents Hist_ListTableAdapter As fruDataTableAdapters.Hist_ListTableAdapter
    Friend WithEvents DataGridViewTextBoxColumn1 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn2 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn3 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn4 As DataGridViewTextBoxColumn
End Class
