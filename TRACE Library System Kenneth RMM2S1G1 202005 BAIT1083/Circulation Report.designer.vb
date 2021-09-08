<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Circulation_Report
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Circulation_Report))
        Dim DataGridViewCellStyle16 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle17 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle18 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.DateTimePickerCirculation = New System.Windows.Forms.DateTimePicker()
        Me.TRACE_Library_SystemDataSet = New TRACE_Library_System_Kenneth_RMM2S1G1_202005_BAIT1083.TRACE_Library_SystemDataSet()
        Me.CirculationBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.CirculationTableAdapter = New TRACE_Library_System_Kenneth_RMM2S1G1_202005_BAIT1083.TRACE_Library_SystemDataSetTableAdapters.CirculationTableAdapter()
        Me.TableAdapterManager = New TRACE_Library_System_Kenneth_RMM2S1G1_202005_BAIT1083.TRACE_Library_SystemDataSetTableAdapters.TableAdapterManager()
        Me.CirculationBindingNavigator = New System.Windows.Forms.BindingNavigator(Me.components)
        Me.BindingNavigatorAddNewItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorCountItem = New System.Windows.Forms.ToolStripLabel()
        Me.BindingNavigatorDeleteItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorMoveFirstItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorMovePreviousItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorSeparator = New System.Windows.Forms.ToolStripSeparator()
        Me.BindingNavigatorPositionItem = New System.Windows.Forms.ToolStripTextBox()
        Me.BindingNavigatorSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.BindingNavigatorMoveNextItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorMoveLastItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorSeparator2 = New System.Windows.Forms.ToolStripSeparator()
        Me.CirculationBindingNavigatorSaveItem = New System.Windows.Forms.ToolStripButton()
        Me.CirculationDataGridView = New System.Windows.Forms.DataGridView()
        Me.StudentIDDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ISBNDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.LoanDateDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn5 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn6 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn7 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.dlgPreviewCirculation = New System.Windows.Forms.PrintPreviewDialog()
        Me.docPrintCirculation = New System.Drawing.Printing.PrintDocument()
        Me.lblCount = New System.Windows.Forms.Label()
        Me.btnGenerate = New System.Windows.Forms.Button()
        Me.btnReturn = New System.Windows.Forms.Button()
        Me.btnPreviewReportandPrint = New System.Windows.Forms.Button()
        CType(Me.TRACE_Library_SystemDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CirculationBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CirculationBindingNavigator, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.CirculationBindingNavigator.SuspendLayout()
        CType(Me.CirculationDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Mongolian Baiti", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Maroon
        Me.Label1.Location = New System.Drawing.Point(76, 43)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(341, 16)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Current Books Unreturned in the Month and Year of"
        '
        'DateTimePickerCirculation
        '
        Me.DateTimePickerCirculation.CalendarForeColor = System.Drawing.Color.Black
        Me.DateTimePickerCirculation.CustomFormat = "MMMM -   yyyy"
        Me.DateTimePickerCirculation.Font = New System.Drawing.Font("Mongolian Baiti", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DateTimePickerCirculation.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.DateTimePickerCirculation.Location = New System.Drawing.Point(454, 38)
        Me.DateTimePickerCirculation.Name = "DateTimePickerCirculation"
        Me.DateTimePickerCirculation.ShowUpDown = True
        Me.DateTimePickerCirculation.Size = New System.Drawing.Size(143, 23)
        Me.DateTimePickerCirculation.TabIndex = 1
        '
        'TRACE_Library_SystemDataSet
        '
        Me.TRACE_Library_SystemDataSet.DataSetName = "TRACE_Library_SystemDataSet"
        Me.TRACE_Library_SystemDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'CirculationBindingSource
        '
        Me.CirculationBindingSource.DataMember = "Circulation"
        Me.CirculationBindingSource.DataSource = Me.TRACE_Library_SystemDataSet
        '
        'CirculationTableAdapter
        '
        Me.CirculationTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.BookTableAdapter = Nothing
        Me.TableAdapterManager.CirculationTableAdapter = Me.CirculationTableAdapter
        Me.TableAdapterManager.LoginRecordTableAdapter = Nothing
        Me.TableAdapterManager.StaffTableAdapter = Nothing
        Me.TableAdapterManager.StudentTableAdapter = Nothing
        Me.TableAdapterManager.UpdateOrder = TRACE_Library_System_Kenneth_RMM2S1G1_202005_BAIT1083.TRACE_Library_SystemDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'CirculationBindingNavigator
        '
        Me.CirculationBindingNavigator.AddNewItem = Me.BindingNavigatorAddNewItem
        Me.CirculationBindingNavigator.BindingSource = Me.CirculationBindingSource
        Me.CirculationBindingNavigator.CountItem = Me.BindingNavigatorCountItem
        Me.CirculationBindingNavigator.DeleteItem = Me.BindingNavigatorDeleteItem
        Me.CirculationBindingNavigator.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.CirculationBindingNavigator.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BindingNavigatorMoveFirstItem, Me.BindingNavigatorMovePreviousItem, Me.BindingNavigatorSeparator, Me.BindingNavigatorPositionItem, Me.BindingNavigatorCountItem, Me.BindingNavigatorSeparator1, Me.BindingNavigatorMoveNextItem, Me.BindingNavigatorMoveLastItem, Me.BindingNavigatorSeparator2, Me.BindingNavigatorAddNewItem, Me.BindingNavigatorDeleteItem, Me.CirculationBindingNavigatorSaveItem})
        Me.CirculationBindingNavigator.Location = New System.Drawing.Point(0, 0)
        Me.CirculationBindingNavigator.MoveFirstItem = Me.BindingNavigatorMoveFirstItem
        Me.CirculationBindingNavigator.MoveLastItem = Me.BindingNavigatorMoveLastItem
        Me.CirculationBindingNavigator.MoveNextItem = Me.BindingNavigatorMoveNextItem
        Me.CirculationBindingNavigator.MovePreviousItem = Me.BindingNavigatorMovePreviousItem
        Me.CirculationBindingNavigator.Name = "CirculationBindingNavigator"
        Me.CirculationBindingNavigator.PositionItem = Me.BindingNavigatorPositionItem
        Me.CirculationBindingNavigator.Size = New System.Drawing.Size(648, 22)
        Me.CirculationBindingNavigator.TabIndex = 45
        Me.CirculationBindingNavigator.Text = "BindingNavigator1"
        Me.CirculationBindingNavigator.Visible = False
        '
        'BindingNavigatorAddNewItem
        '
        Me.BindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorAddNewItem.Image = CType(resources.GetObject("BindingNavigatorAddNewItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorAddNewItem.Name = "BindingNavigatorAddNewItem"
        Me.BindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorAddNewItem.Size = New System.Drawing.Size(24, 19)
        Me.BindingNavigatorAddNewItem.Text = "Add new"
        '
        'BindingNavigatorCountItem
        '
        Me.BindingNavigatorCountItem.Name = "BindingNavigatorCountItem"
        Me.BindingNavigatorCountItem.Size = New System.Drawing.Size(35, 19)
        Me.BindingNavigatorCountItem.Text = "of {0}"
        Me.BindingNavigatorCountItem.ToolTipText = "Total number of items"
        '
        'BindingNavigatorDeleteItem
        '
        Me.BindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorDeleteItem.Image = CType(resources.GetObject("BindingNavigatorDeleteItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorDeleteItem.Name = "BindingNavigatorDeleteItem"
        Me.BindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorDeleteItem.Size = New System.Drawing.Size(24, 19)
        Me.BindingNavigatorDeleteItem.Text = "Delete"
        '
        'BindingNavigatorMoveFirstItem
        '
        Me.BindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMoveFirstItem.Image = CType(resources.GetObject("BindingNavigatorMoveFirstItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMoveFirstItem.Name = "BindingNavigatorMoveFirstItem"
        Me.BindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMoveFirstItem.Size = New System.Drawing.Size(24, 19)
        Me.BindingNavigatorMoveFirstItem.Text = "Move first"
        '
        'BindingNavigatorMovePreviousItem
        '
        Me.BindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMovePreviousItem.Image = CType(resources.GetObject("BindingNavigatorMovePreviousItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMovePreviousItem.Name = "BindingNavigatorMovePreviousItem"
        Me.BindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMovePreviousItem.Size = New System.Drawing.Size(24, 19)
        Me.BindingNavigatorMovePreviousItem.Text = "Move previous"
        '
        'BindingNavigatorSeparator
        '
        Me.BindingNavigatorSeparator.Name = "BindingNavigatorSeparator"
        Me.BindingNavigatorSeparator.Size = New System.Drawing.Size(6, 22)
        '
        'BindingNavigatorPositionItem
        '
        Me.BindingNavigatorPositionItem.AccessibleName = "Position"
        Me.BindingNavigatorPositionItem.AutoSize = False
        Me.BindingNavigatorPositionItem.Name = "BindingNavigatorPositionItem"
        Me.BindingNavigatorPositionItem.Size = New System.Drawing.Size(50, 23)
        Me.BindingNavigatorPositionItem.Text = "0"
        Me.BindingNavigatorPositionItem.ToolTipText = "Current position"
        '
        'BindingNavigatorSeparator1
        '
        Me.BindingNavigatorSeparator1.Name = "BindingNavigatorSeparator1"
        Me.BindingNavigatorSeparator1.Size = New System.Drawing.Size(6, 22)
        '
        'BindingNavigatorMoveNextItem
        '
        Me.BindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMoveNextItem.Image = CType(resources.GetObject("BindingNavigatorMoveNextItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMoveNextItem.Name = "BindingNavigatorMoveNextItem"
        Me.BindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMoveNextItem.Size = New System.Drawing.Size(24, 19)
        Me.BindingNavigatorMoveNextItem.Text = "Move next"
        '
        'BindingNavigatorMoveLastItem
        '
        Me.BindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMoveLastItem.Image = CType(resources.GetObject("BindingNavigatorMoveLastItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMoveLastItem.Name = "BindingNavigatorMoveLastItem"
        Me.BindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMoveLastItem.Size = New System.Drawing.Size(24, 19)
        Me.BindingNavigatorMoveLastItem.Text = "Move last"
        '
        'BindingNavigatorSeparator2
        '
        Me.BindingNavigatorSeparator2.Name = "BindingNavigatorSeparator2"
        Me.BindingNavigatorSeparator2.Size = New System.Drawing.Size(6, 22)
        '
        'CirculationBindingNavigatorSaveItem
        '
        Me.CirculationBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.CirculationBindingNavigatorSaveItem.Image = CType(resources.GetObject("CirculationBindingNavigatorSaveItem.Image"), System.Drawing.Image)
        Me.CirculationBindingNavigatorSaveItem.Name = "CirculationBindingNavigatorSaveItem"
        Me.CirculationBindingNavigatorSaveItem.Size = New System.Drawing.Size(24, 19)
        Me.CirculationBindingNavigatorSaveItem.Text = "Save Data"
        '
        'CirculationDataGridView
        '
        Me.CirculationDataGridView.AllowUserToAddRows = False
        Me.CirculationDataGridView.AllowUserToDeleteRows = False
        Me.CirculationDataGridView.AutoGenerateColumns = False
        Me.CirculationDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells
        Me.CirculationDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.CirculationDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.StudentIDDataGridViewTextBoxColumn, Me.ISBNDataGridViewTextBoxColumn, Me.LoanDateDataGridViewTextBoxColumn})
        Me.CirculationDataGridView.DataSource = Me.CirculationBindingSource
        Me.CirculationDataGridView.Location = New System.Drawing.Point(51, 131)
        Me.CirculationDataGridView.Name = "CirculationDataGridView"
        Me.CirculationDataGridView.ReadOnly = True
        Me.CirculationDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.CirculationDataGridView.Size = New System.Drawing.Size(546, 220)
        Me.CirculationDataGridView.TabIndex = 4
        '
        'StudentIDDataGridViewTextBoxColumn
        '
        Me.StudentIDDataGridViewTextBoxColumn.DataPropertyName = "Student ID"
        DataGridViewCellStyle16.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.StudentIDDataGridViewTextBoxColumn.DefaultCellStyle = DataGridViewCellStyle16
        Me.StudentIDDataGridViewTextBoxColumn.HeaderText = "Student ID"
        Me.StudentIDDataGridViewTextBoxColumn.Name = "StudentIDDataGridViewTextBoxColumn"
        Me.StudentIDDataGridViewTextBoxColumn.ReadOnly = True
        Me.StudentIDDataGridViewTextBoxColumn.Width = 83
        '
        'ISBNDataGridViewTextBoxColumn
        '
        Me.ISBNDataGridViewTextBoxColumn.DataPropertyName = "ISBN"
        DataGridViewCellStyle17.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ISBNDataGridViewTextBoxColumn.DefaultCellStyle = DataGridViewCellStyle17
        Me.ISBNDataGridViewTextBoxColumn.HeaderText = "ISBN"
        Me.ISBNDataGridViewTextBoxColumn.Name = "ISBNDataGridViewTextBoxColumn"
        Me.ISBNDataGridViewTextBoxColumn.ReadOnly = True
        Me.ISBNDataGridViewTextBoxColumn.Width = 57
        '
        'LoanDateDataGridViewTextBoxColumn
        '
        Me.LoanDateDataGridViewTextBoxColumn.DataPropertyName = "Loan Date"
        DataGridViewCellStyle18.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LoanDateDataGridViewTextBoxColumn.DefaultCellStyle = DataGridViewCellStyle18
        Me.LoanDateDataGridViewTextBoxColumn.HeaderText = "Loan Date"
        Me.LoanDateDataGridViewTextBoxColumn.Name = "LoanDateDataGridViewTextBoxColumn"
        Me.LoanDateDataGridViewTextBoxColumn.ReadOnly = True
        Me.LoanDateDataGridViewTextBoxColumn.Width = 82
        '
        'DataGridViewTextBoxColumn1
        '
        Me.DataGridViewTextBoxColumn1.DataPropertyName = "Student ID"
        Me.DataGridViewTextBoxColumn1.HeaderText = "Student ID"
        Me.DataGridViewTextBoxColumn1.Name = "DataGridViewTextBoxColumn1"
        '
        'DataGridViewTextBoxColumn2
        '
        Me.DataGridViewTextBoxColumn2.DataPropertyName = "ISBN"
        Me.DataGridViewTextBoxColumn2.HeaderText = "ISBN"
        Me.DataGridViewTextBoxColumn2.Name = "DataGridViewTextBoxColumn2"
        '
        'DataGridViewTextBoxColumn5
        '
        Me.DataGridViewTextBoxColumn5.DataPropertyName = "Title"
        Me.DataGridViewTextBoxColumn5.HeaderText = "Title"
        Me.DataGridViewTextBoxColumn5.Name = "DataGridViewTextBoxColumn5"
        '
        'DataGridViewTextBoxColumn3
        '
        Me.DataGridViewTextBoxColumn3.DataPropertyName = "Loan Date"
        Me.DataGridViewTextBoxColumn3.HeaderText = "Loan Date"
        Me.DataGridViewTextBoxColumn3.Name = "DataGridViewTextBoxColumn3"
        '
        'DataGridViewTextBoxColumn6
        '
        Me.DataGridViewTextBoxColumn6.DataPropertyName = "Return Due Date"
        Me.DataGridViewTextBoxColumn6.HeaderText = "Return Due Date"
        Me.DataGridViewTextBoxColumn6.Name = "DataGridViewTextBoxColumn6"
        '
        'DataGridViewTextBoxColumn7
        '
        Me.DataGridViewTextBoxColumn7.DataPropertyName = "Actual Return Date"
        Me.DataGridViewTextBoxColumn7.HeaderText = "Actual Return Date"
        Me.DataGridViewTextBoxColumn7.Name = "DataGridViewTextBoxColumn7"
        '
        'dlgPreviewCirculation
        '
        Me.dlgPreviewCirculation.AutoScrollMargin = New System.Drawing.Size(0, 0)
        Me.dlgPreviewCirculation.AutoScrollMinSize = New System.Drawing.Size(0, 0)
        Me.dlgPreviewCirculation.ClientSize = New System.Drawing.Size(400, 300)
        Me.dlgPreviewCirculation.Enabled = True
        Me.dlgPreviewCirculation.Icon = CType(resources.GetObject("dlgPreviewCirculation.Icon"), System.Drawing.Icon)
        Me.dlgPreviewCirculation.Name = "PrintPreviewDialog1"
        Me.dlgPreviewCirculation.Visible = False
        '
        'docPrintCirculation
        '
        '
        'lblCount
        '
        Me.lblCount.AutoSize = True
        Me.lblCount.Font = New System.Drawing.Font("Mongolian Baiti", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCount.ForeColor = System.Drawing.Color.Maroon
        Me.lblCount.Location = New System.Drawing.Point(58, 365)
        Me.lblCount.Name = "lblCount"
        Me.lblCount.Size = New System.Drawing.Size(210, 16)
        Me.lblCount.TabIndex = 5
        Me.lblCount.Text = "0 Number of Books Unreturned"
        '
        'btnGenerate
        '
        Me.btnGenerate.BackColor = System.Drawing.Color.WhiteSmoke
        Me.btnGenerate.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnGenerate.Font = New System.Drawing.Font("Mongolian Baiti", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnGenerate.Location = New System.Drawing.Point(51, 81)
        Me.btnGenerate.Name = "btnGenerate"
        Me.btnGenerate.Size = New System.Drawing.Size(108, 44)
        Me.btnGenerate.TabIndex = 47
        Me.btnGenerate.Text = "&Generate"
        Me.btnGenerate.UseVisualStyleBackColor = False
        '
        'btnReturn
        '
        Me.btnReturn.BackColor = System.Drawing.Color.WhiteSmoke
        Me.btnReturn.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btnReturn.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnReturn.Font = New System.Drawing.Font("Mongolian Baiti", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnReturn.Location = New System.Drawing.Point(489, 81)
        Me.btnReturn.Name = "btnReturn"
        Me.btnReturn.Size = New System.Drawing.Size(108, 44)
        Me.btnReturn.TabIndex = 49
        Me.btnReturn.Text = "R&eturn to Report Menu"
        Me.btnReturn.UseVisualStyleBackColor = False
        '
        'btnPreviewReportandPrint
        '
        Me.btnPreviewReportandPrint.BackColor = System.Drawing.Color.WhiteSmoke
        Me.btnPreviewReportandPrint.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnPreviewReportandPrint.Font = New System.Drawing.Font("Mongolian Baiti", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnPreviewReportandPrint.Location = New System.Drawing.Point(185, 81)
        Me.btnPreviewReportandPrint.Name = "btnPreviewReportandPrint"
        Me.btnPreviewReportandPrint.Size = New System.Drawing.Size(108, 44)
        Me.btnPreviewReportandPrint.TabIndex = 48
        Me.btnPreviewReportandPrint.Text = "&Preview and Print Report"
        Me.btnPreviewReportandPrint.UseVisualStyleBackColor = False
        '
        'Circulation_Report
        '
        Me.AcceptButton = Me.btnGenerate
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.AntiqueWhite
        Me.CancelButton = Me.btnReturn
        Me.ClientSize = New System.Drawing.Size(648, 425)
        Me.Controls.Add(Me.btnGenerate)
        Me.Controls.Add(Me.btnReturn)
        Me.Controls.Add(Me.btnPreviewReportandPrint)
        Me.Controls.Add(Me.lblCount)
        Me.Controls.Add(Me.CirculationDataGridView)
        Me.Controls.Add(Me.CirculationBindingNavigator)
        Me.Controls.Add(Me.DateTimePickerCirculation)
        Me.Controls.Add(Me.Label1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(2)
        Me.MaximizeBox = False
        Me.Name = "Circulation_Report"
        Me.Text = "Circulation Report"
        CType(Me.TRACE_Library_SystemDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CirculationBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CirculationBindingNavigator, System.ComponentModel.ISupportInitialize).EndInit()
        Me.CirculationBindingNavigator.ResumeLayout(False)
        Me.CirculationBindingNavigator.PerformLayout()
        CType(Me.CirculationDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As Label
    Friend WithEvents DateTimePickerCirculation As DateTimePicker
    Friend WithEvents TRACE_Library_SystemDataSet As TRACE_Library_SystemDataSet
    Friend WithEvents CirculationBindingSource As BindingSource
    Friend WithEvents CirculationTableAdapter As TRACE_Library_SystemDataSetTableAdapters.CirculationTableAdapter
    Friend WithEvents TableAdapterManager As TRACE_Library_SystemDataSetTableAdapters.TableAdapterManager
    Friend WithEvents CirculationBindingNavigator As BindingNavigator
    Friend WithEvents BindingNavigatorAddNewItem As ToolStripButton
    Friend WithEvents BindingNavigatorCountItem As ToolStripLabel
    Friend WithEvents BindingNavigatorDeleteItem As ToolStripButton
    Friend WithEvents BindingNavigatorMoveFirstItem As ToolStripButton
    Friend WithEvents BindingNavigatorMovePreviousItem As ToolStripButton
    Friend WithEvents BindingNavigatorSeparator As ToolStripSeparator
    Friend WithEvents BindingNavigatorPositionItem As ToolStripTextBox
    Friend WithEvents BindingNavigatorSeparator1 As ToolStripSeparator
    Friend WithEvents BindingNavigatorMoveNextItem As ToolStripButton
    Friend WithEvents BindingNavigatorMoveLastItem As ToolStripButton
    Friend WithEvents BindingNavigatorSeparator2 As ToolStripSeparator
    Friend WithEvents CirculationBindingNavigatorSaveItem As ToolStripButton
    Friend WithEvents CirculationDataGridView As DataGridView
    Friend WithEvents DataGridViewTextBoxColumn1 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn2 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn5 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn3 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn6 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn7 As DataGridViewTextBoxColumn
    Friend WithEvents dlgPreviewCirculation As PrintPreviewDialog
    Friend WithEvents docPrintCirculation As Printing.PrintDocument
    Friend WithEvents StudentIDDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents ISBNDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents TitleDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents LoanDateDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents ReturnDueDateDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents lblCount As Label
    Friend WithEvents btnGenerate As Button
    Friend WithEvents btnReturn As Button
    Friend WithEvents btnPreviewReportandPrint As Button
End Class
