<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmReportBooksAddedRemoved
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
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmReportBooksAddedRemoved))
        Me.Label1 = New System.Windows.Forms.Label()
        Me.dtpMonthYear = New System.Windows.Forms.DateTimePicker()
        Me.dgvBooksAddRemove = New System.Windows.Forms.DataGridView()
        Me.ISBNDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TitleDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.AuthorDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PublisherDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DateAddedDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DateRemovedDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ReasonOfRemovalDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.BookBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.TRACE_Library_SystemDataSet = New TRACE_Library_System_Kenneth_RMM2S1G1_202005_BAIT1083.TRACE_Library_SystemDataSet()
        Me.btnClear = New System.Windows.Forms.Button()
        Me.btnPrint = New System.Windows.Forms.Button()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.btnReturnToReportGeneration = New System.Windows.Forms.Button()
        Me.btnGenerate = New System.Windows.Forms.Button()
        Me.FillByDateAddedRemovedToolStrip = New System.Windows.Forms.ToolStrip()
        Me.FillByDateAddedRemovedToolStripButton = New System.Windows.Forms.ToolStripButton()
        Me.BookTableAdapter = New TRACE_Library_System_Kenneth_RMM2S1G1_202005_BAIT1083.TRACE_Library_SystemDataSetTableAdapters.BookTableAdapter()
        Me.dlgPrintPreview = New System.Windows.Forms.PrintPreviewDialog()
        Me.docReport = New System.Drawing.Printing.PrintDocument()
        CType(Me.dgvBooksAddRemove, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BookBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TRACE_Library_SystemDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.FillByDateAddedRemovedToolStrip.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Mongolian Baiti", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Maroon
        Me.Label1.Location = New System.Drawing.Point(52, 30)
        Me.Label1.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(347, 16)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Books added and removed in the month and year of : "
        '
        'dtpMonthYear
        '
        Me.dtpMonthYear.CustomFormat = "MMMM, yyyy"
        Me.dtpMonthYear.Font = New System.Drawing.Font("Mongolian Baiti", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtpMonthYear.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtpMonthYear.Location = New System.Drawing.Point(400, 24)
        Me.dtpMonthYear.Margin = New System.Windows.Forms.Padding(2)
        Me.dtpMonthYear.MaxDate = New Date(2020, 9, 6, 0, 0, 0, 0)
        Me.dtpMonthYear.Name = "dtpMonthYear"
        Me.dtpMonthYear.ShowUpDown = True
        Me.dtpMonthYear.Size = New System.Drawing.Size(188, 26)
        Me.dtpMonthYear.TabIndex = 2
        Me.dtpMonthYear.Value = New Date(2020, 9, 6, 0, 0, 0, 0)
        '
        'dgvBooksAddRemove
        '
        Me.dgvBooksAddRemove.AllowUserToAddRows = False
        Me.dgvBooksAddRemove.AllowUserToDeleteRows = False
        Me.dgvBooksAddRemove.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.dgvBooksAddRemove.AutoGenerateColumns = False
        Me.dgvBooksAddRemove.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells
        Me.dgvBooksAddRemove.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvBooksAddRemove.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.ISBNDataGridViewTextBoxColumn, Me.TitleDataGridViewTextBoxColumn, Me.AuthorDataGridViewTextBoxColumn, Me.PublisherDataGridViewTextBoxColumn, Me.DateAddedDataGridViewTextBoxColumn, Me.DateRemovedDataGridViewTextBoxColumn, Me.ReasonOfRemovalDataGridViewTextBoxColumn})
        Me.dgvBooksAddRemove.DataSource = Me.BookBindingSource
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        DataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dgvBooksAddRemove.DefaultCellStyle = DataGridViewCellStyle1
        Me.dgvBooksAddRemove.Location = New System.Drawing.Point(37, 184)
        Me.dgvBooksAddRemove.Margin = New System.Windows.Forms.Padding(2)
        Me.dgvBooksAddRemove.Name = "dgvBooksAddRemove"
        Me.dgvBooksAddRemove.ReadOnly = True
        Me.dgvBooksAddRemove.RowTemplate.Height = 24
        Me.dgvBooksAddRemove.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvBooksAddRemove.Size = New System.Drawing.Size(644, 409)
        Me.dgvBooksAddRemove.TabIndex = 1
        '
        'ISBNDataGridViewTextBoxColumn
        '
        Me.ISBNDataGridViewTextBoxColumn.DataPropertyName = "ISBN"
        Me.ISBNDataGridViewTextBoxColumn.HeaderText = "ISBN"
        Me.ISBNDataGridViewTextBoxColumn.Name = "ISBNDataGridViewTextBoxColumn"
        Me.ISBNDataGridViewTextBoxColumn.ReadOnly = True
        Me.ISBNDataGridViewTextBoxColumn.Width = 57
        '
        'TitleDataGridViewTextBoxColumn
        '
        Me.TitleDataGridViewTextBoxColumn.DataPropertyName = "Title"
        Me.TitleDataGridViewTextBoxColumn.HeaderText = "Title"
        Me.TitleDataGridViewTextBoxColumn.Name = "TitleDataGridViewTextBoxColumn"
        Me.TitleDataGridViewTextBoxColumn.ReadOnly = True
        Me.TitleDataGridViewTextBoxColumn.Width = 52
        '
        'AuthorDataGridViewTextBoxColumn
        '
        Me.AuthorDataGridViewTextBoxColumn.DataPropertyName = "Author"
        Me.AuthorDataGridViewTextBoxColumn.HeaderText = "Author"
        Me.AuthorDataGridViewTextBoxColumn.Name = "AuthorDataGridViewTextBoxColumn"
        Me.AuthorDataGridViewTextBoxColumn.ReadOnly = True
        Me.AuthorDataGridViewTextBoxColumn.Width = 63
        '
        'PublisherDataGridViewTextBoxColumn
        '
        Me.PublisherDataGridViewTextBoxColumn.DataPropertyName = "Publisher"
        Me.PublisherDataGridViewTextBoxColumn.HeaderText = "Publisher"
        Me.PublisherDataGridViewTextBoxColumn.Name = "PublisherDataGridViewTextBoxColumn"
        Me.PublisherDataGridViewTextBoxColumn.ReadOnly = True
        Me.PublisherDataGridViewTextBoxColumn.Width = 75
        '
        'DateAddedDataGridViewTextBoxColumn
        '
        Me.DateAddedDataGridViewTextBoxColumn.DataPropertyName = "Date Added"
        Me.DateAddedDataGridViewTextBoxColumn.HeaderText = "Date Added"
        Me.DateAddedDataGridViewTextBoxColumn.Name = "DateAddedDataGridViewTextBoxColumn"
        Me.DateAddedDataGridViewTextBoxColumn.ReadOnly = True
        Me.DateAddedDataGridViewTextBoxColumn.Width = 82
        '
        'DateRemovedDataGridViewTextBoxColumn
        '
        Me.DateRemovedDataGridViewTextBoxColumn.DataPropertyName = "Date Removed"
        Me.DateRemovedDataGridViewTextBoxColumn.HeaderText = "Date Removed"
        Me.DateRemovedDataGridViewTextBoxColumn.Name = "DateRemovedDataGridViewTextBoxColumn"
        Me.DateRemovedDataGridViewTextBoxColumn.ReadOnly = True
        Me.DateRemovedDataGridViewTextBoxColumn.Width = 96
        '
        'ReasonOfRemovalDataGridViewTextBoxColumn
        '
        Me.ReasonOfRemovalDataGridViewTextBoxColumn.DataPropertyName = "Reason Of Removal"
        Me.ReasonOfRemovalDataGridViewTextBoxColumn.HeaderText = "Reason Of Removal"
        Me.ReasonOfRemovalDataGridViewTextBoxColumn.Name = "ReasonOfRemovalDataGridViewTextBoxColumn"
        Me.ReasonOfRemovalDataGridViewTextBoxColumn.ReadOnly = True
        Me.ReasonOfRemovalDataGridViewTextBoxColumn.Width = 117
        '
        'BookBindingSource
        '
        Me.BookBindingSource.DataMember = "Book"
        Me.BookBindingSource.DataSource = Me.TRACE_Library_SystemDataSet
        '
        'TRACE_Library_SystemDataSet
        '
        Me.TRACE_Library_SystemDataSet.DataSetName = "TRACE_Library_SystemDataSet"
        Me.TRACE_Library_SystemDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'btnClear
        '
        Me.btnClear.BackColor = System.Drawing.Color.WhiteSmoke
        Me.btnClear.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnClear.Font = New System.Drawing.Font("Mongolian Baiti", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnClear.Location = New System.Drawing.Point(264, 73)
        Me.btnClear.Margin = New System.Windows.Forms.Padding(2)
        Me.btnClear.Name = "btnClear"
        Me.btnClear.Size = New System.Drawing.Size(98, 55)
        Me.btnClear.TabIndex = 12
        Me.btnClear.Text = "&Clear"
        Me.btnClear.UseVisualStyleBackColor = False
        '
        'btnPrint
        '
        Me.btnPrint.BackColor = System.Drawing.Color.WhiteSmoke
        Me.btnPrint.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnPrint.Font = New System.Drawing.Font("Mongolian Baiti", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnPrint.Location = New System.Drawing.Point(132, 72)
        Me.btnPrint.Margin = New System.Windows.Forms.Padding(2)
        Me.btnPrint.Name = "btnPrint"
        Me.btnPrint.Size = New System.Drawing.Size(98, 55)
        Me.btnPrint.TabIndex = 11
        Me.btnPrint.Text = "&Print Report"
        Me.btnPrint.UseVisualStyleBackColor = False
        '
        'GroupBox1
        '
        Me.GroupBox1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GroupBox1.Controls.Add(Me.btnReturnToReportGeneration)
        Me.GroupBox1.Controls.Add(Me.btnGenerate)
        Me.GroupBox1.Controls.Add(Me.btnClear)
        Me.GroupBox1.Controls.Add(Me.btnPrint)
        Me.GroupBox1.Controls.Add(Me.dtpMonthYear)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Font = New System.Drawing.Font("Mongolian Baiti", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.Location = New System.Drawing.Point(37, 28)
        Me.GroupBox1.Margin = New System.Windows.Forms.Padding(2)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Padding = New System.Windows.Forms.Padding(2)
        Me.GroupBox1.Size = New System.Drawing.Size(644, 134)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        '
        'btnReturnToReportGeneration
        '
        Me.btnReturnToReportGeneration.BackColor = System.Drawing.Color.WhiteSmoke
        Me.btnReturnToReportGeneration.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btnReturnToReportGeneration.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnReturnToReportGeneration.Font = New System.Drawing.Font("Mongolian Baiti", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnReturnToReportGeneration.Location = New System.Drawing.Point(542, 70)
        Me.btnReturnToReportGeneration.Name = "btnReturnToReportGeneration"
        Me.btnReturnToReportGeneration.Size = New System.Drawing.Size(98, 55)
        Me.btnReturnToReportGeneration.TabIndex = 33
        Me.btnReturnToReportGeneration.Text = "R&eturn to Report Generation"
        Me.btnReturnToReportGeneration.UseVisualStyleBackColor = False
        '
        'btnGenerate
        '
        Me.btnGenerate.BackColor = System.Drawing.Color.WhiteSmoke
        Me.btnGenerate.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnGenerate.Font = New System.Drawing.Font("Mongolian Baiti", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnGenerate.Location = New System.Drawing.Point(4, 73)
        Me.btnGenerate.Margin = New System.Windows.Forms.Padding(2)
        Me.btnGenerate.Name = "btnGenerate"
        Me.btnGenerate.Size = New System.Drawing.Size(98, 55)
        Me.btnGenerate.TabIndex = 13
        Me.btnGenerate.Text = "&Generate Report"
        Me.btnGenerate.UseVisualStyleBackColor = False
        '
        'FillByDateAddedRemovedToolStrip
        '
        Me.FillByDateAddedRemovedToolStrip.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.FillByDateAddedRemovedToolStrip.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.FillByDateAddedRemovedToolStripButton})
        Me.FillByDateAddedRemovedToolStrip.Location = New System.Drawing.Point(0, 0)
        Me.FillByDateAddedRemovedToolStrip.Name = "FillByDateAddedRemovedToolStrip"
        Me.FillByDateAddedRemovedToolStrip.Size = New System.Drawing.Size(718, 22)
        Me.FillByDateAddedRemovedToolStrip.TabIndex = 14
        Me.FillByDateAddedRemovedToolStrip.Text = "FillByDateAddedRemovedToolStrip"
        Me.FillByDateAddedRemovedToolStrip.Visible = False
        '
        'FillByDateAddedRemovedToolStripButton
        '
        Me.FillByDateAddedRemovedToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
        Me.FillByDateAddedRemovedToolStripButton.Name = "FillByDateAddedRemovedToolStripButton"
        Me.FillByDateAddedRemovedToolStripButton.Size = New System.Drawing.Size(148, 19)
        Me.FillByDateAddedRemovedToolStripButton.Text = "FillByDateAddedRemoved"
        Me.FillByDateAddedRemovedToolStripButton.Visible = False
        '
        'BookTableAdapter
        '
        Me.BookTableAdapter.ClearBeforeFill = True
        '
        'dlgPrintPreview
        '
        Me.dlgPrintPreview.AutoScrollMargin = New System.Drawing.Size(0, 0)
        Me.dlgPrintPreview.AutoScrollMinSize = New System.Drawing.Size(0, 0)
        Me.dlgPrintPreview.ClientSize = New System.Drawing.Size(400, 300)
        Me.dlgPrintPreview.Enabled = True
        Me.dlgPrintPreview.Icon = CType(resources.GetObject("dlgPrintPreview.Icon"), System.Drawing.Icon)
        Me.dlgPrintPreview.Name = "PrintPreviewDialog1"
        Me.dlgPrintPreview.Visible = False
        '
        'docReport
        '
        '
        'frmReportBooksAddedRemoved
        '
        Me.AcceptButton = Me.btnGenerate
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.AntiqueWhite
        Me.CancelButton = Me.btnReturnToReportGeneration
        Me.ClientSize = New System.Drawing.Size(718, 609)
        Me.Controls.Add(Me.FillByDateAddedRemovedToolStrip)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.dgvBooksAddRemove)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(2)
        Me.MaximizeBox = False
        Me.Name = "frmReportBooksAddedRemoved"
        Me.Text = "Report of Books Added and Removed"
        CType(Me.dgvBooksAddRemove, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BookBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TRACE_Library_SystemDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.FillByDateAddedRemovedToolStrip.ResumeLayout(False)
        Me.FillByDateAddedRemovedToolStrip.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents dtpMonthYear As DateTimePicker
    Friend WithEvents dgvBooksAddRemove As DataGridView
    Friend WithEvents btnClear As Button
    Friend WithEvents btnPrint As Button
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents TRACE_Library_SystemDataSet As TRACE_Library_SystemDataSet
    Friend WithEvents BookBindingSource As BindingSource
    Friend WithEvents BookTableAdapter As TRACE_Library_SystemDataSetTableAdapters.BookTableAdapter
    Friend WithEvents btnGenerate As Button
    Friend WithEvents FillByDateAddedRemovedToolStrip As ToolStrip
    Friend WithEvents FillByDateAddedRemovedToolStripButton As ToolStripButton
    Friend WithEvents PagesDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents dlgPrintPreview As PrintPreviewDialog
    Friend WithEvents docReport As Printing.PrintDocument
    Friend WithEvents ISBNDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents TitleDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents AuthorDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents PublisherDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents DateAddedDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents DateRemovedDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents ReasonOfRemovalDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents btnReturnToReportGeneration As Button
End Class
