<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ReturnSummary
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(ReturnSummary))
        Me.grpLoanDetails = New System.Windows.Forms.GroupBox()
        Me.lblPayment = New System.Windows.Forms.Label()
        Me.btnCheckout = New System.Windows.Forms.Button()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.lblOverdue = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.lblTitle = New System.Windows.Forms.Label()
        Me.lblISBN = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.grpSelectedBox = New System.Windows.Forms.GroupBox()
        Me.CirculationDataGridView = New System.Windows.Forms.DataGridView()
        Me.DataGridViewTextBoxColumn3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn8 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn6 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn9 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CirculationBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.TRACE_Library_SystemDataSet = New TRACE_Library_System_Kenneth_RMM2S1G1_202005_BAIT1083.TRACE_Library_SystemDataSet()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.lblStudentName = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.btnClear = New System.Windows.Forms.Button()
        Me.btnSearchStudentID = New System.Windows.Forms.Button()
        Me.DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn5 = New System.Windows.Forms.DataGridViewTextBoxColumn()
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
        Me.mskStudentID = New System.Windows.Forms.MaskedTextBox()
        Me.grpLoanDetails.SuspendLayout()
        Me.grpSelectedBox.SuspendLayout()
        CType(Me.CirculationDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CirculationBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TRACE_Library_SystemDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CirculationBindingNavigator, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.CirculationBindingNavigator.SuspendLayout()
        Me.SuspendLayout()
        '
        'grpLoanDetails
        '
        Me.grpLoanDetails.Controls.Add(Me.lblPayment)
        Me.grpLoanDetails.Controls.Add(Me.btnCheckout)
        Me.grpLoanDetails.Controls.Add(Me.Label10)
        Me.grpLoanDetails.Controls.Add(Me.Label1)
        Me.grpLoanDetails.Controls.Add(Me.lblOverdue)
        Me.grpLoanDetails.Controls.Add(Me.Label2)
        Me.grpLoanDetails.Controls.Add(Me.lblTitle)
        Me.grpLoanDetails.Controls.Add(Me.lblISBN)
        Me.grpLoanDetails.Controls.Add(Me.Label5)
        Me.grpLoanDetails.Controls.Add(Me.Label4)
        Me.grpLoanDetails.Enabled = False
        Me.grpLoanDetails.Font = New System.Drawing.Font("Mongolian Baiti", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.grpLoanDetails.ForeColor = System.Drawing.Color.Maroon
        Me.grpLoanDetails.Location = New System.Drawing.Point(36, 298)
        Me.grpLoanDetails.Margin = New System.Windows.Forms.Padding(2)
        Me.grpLoanDetails.Name = "grpLoanDetails"
        Me.grpLoanDetails.Padding = New System.Windows.Forms.Padding(2)
        Me.grpLoanDetails.Size = New System.Drawing.Size(837, 236)
        Me.grpLoanDetails.TabIndex = 6
        Me.grpLoanDetails.TabStop = False
        Me.grpLoanDetails.Text = "Loan's Details: "
        '
        'lblPayment
        '
        Me.lblPayment.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblPayment.Font = New System.Drawing.Font("Mongolian Baiti", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPayment.ForeColor = System.Drawing.Color.Maroon
        Me.lblPayment.Location = New System.Drawing.Point(308, 180)
        Me.lblPayment.Name = "lblPayment"
        Me.lblPayment.Size = New System.Drawing.Size(134, 28)
        Me.lblPayment.TabIndex = 59
        Me.lblPayment.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'btnCheckout
        '
        Me.btnCheckout.BackColor = System.Drawing.Color.WhiteSmoke
        Me.btnCheckout.Enabled = False
        Me.btnCheckout.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnCheckout.Font = New System.Drawing.Font("Mongolian Baiti", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCheckout.ForeColor = System.Drawing.Color.Black
        Me.btnCheckout.Location = New System.Drawing.Point(484, 180)
        Me.btnCheckout.Name = "btnCheckout"
        Me.btnCheckout.Size = New System.Drawing.Size(152, 35)
        Me.btnCheckout.TabIndex = 13
        Me.btnCheckout.Text = "&Checkout"
        Me.btnCheckout.UseVisualStyleBackColor = False
        '
        'Label10
        '
        Me.Label10.Font = New System.Drawing.Font("Mongolian Baiti", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.ForeColor = System.Drawing.Color.Maroon
        Me.Label10.Location = New System.Drawing.Point(210, 180)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(66, 23)
        Me.Label10.TabIndex = 58
        Me.Label10.Text = "Payment: "
        Me.Label10.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label1
        '
        Me.Label1.Font = New System.Drawing.Font("Mongolian Baiti", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Maroon
        Me.Label1.Location = New System.Drawing.Point(454, 134)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(108, 23)
        Me.Label1.TabIndex = 57
        Me.Label1.Text = "day(s)"
        '
        'lblOverdue
        '
        Me.lblOverdue.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblOverdue.Font = New System.Drawing.Font("Mongolian Baiti", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblOverdue.ForeColor = System.Drawing.Color.Maroon
        Me.lblOverdue.Location = New System.Drawing.Point(308, 132)
        Me.lblOverdue.Name = "lblOverdue"
        Me.lblOverdue.Size = New System.Drawing.Size(134, 28)
        Me.lblOverdue.TabIndex = 56
        Me.lblOverdue.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label2
        '
        Me.Label2.Font = New System.Drawing.Font("Mongolian Baiti", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.Maroon
        Me.Label2.Location = New System.Drawing.Point(145, 134)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(131, 23)
        Me.Label2.TabIndex = 55
        Me.Label2.Text = "Book Overdue By: "
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lblTitle
        '
        Me.lblTitle.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblTitle.Font = New System.Drawing.Font("Mongolian Baiti", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTitle.ForeColor = System.Drawing.Color.Maroon
        Me.lblTitle.Location = New System.Drawing.Point(308, 83)
        Me.lblTitle.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblTitle.Name = "lblTitle"
        Me.lblTitle.Size = New System.Drawing.Size(181, 22)
        Me.lblTitle.TabIndex = 14
        Me.lblTitle.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblISBN
        '
        Me.lblISBN.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblISBN.Font = New System.Drawing.Font("Mongolian Baiti", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblISBN.ForeColor = System.Drawing.Color.Maroon
        Me.lblISBN.Location = New System.Drawing.Point(308, 34)
        Me.lblISBN.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblISBN.Name = "lblISBN"
        Me.lblISBN.Size = New System.Drawing.Size(181, 22)
        Me.lblISBN.TabIndex = 13
        Me.lblISBN.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label5
        '
        Me.Label5.Font = New System.Drawing.Font("Mongolian Baiti", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.Maroon
        Me.Label5.Location = New System.Drawing.Point(187, 83)
        Me.Label5.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(89, 22)
        Me.Label5.TabIndex = 6
        Me.Label5.Text = "Title: "
        Me.Label5.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label4
        '
        Me.Label4.Font = New System.Drawing.Font("Mongolian Baiti", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.Maroon
        Me.Label4.Location = New System.Drawing.Point(140, 34)
        Me.Label4.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(136, 22)
        Me.Label4.TabIndex = 5
        Me.Label4.Text = "ISBN Number: "
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'grpSelectedBox
        '
        Me.grpSelectedBox.Controls.Add(Me.CirculationDataGridView)
        Me.grpSelectedBox.Enabled = False
        Me.grpSelectedBox.Font = New System.Drawing.Font("Mongolian Baiti", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.grpSelectedBox.ForeColor = System.Drawing.Color.Maroon
        Me.grpSelectedBox.Location = New System.Drawing.Point(249, 23)
        Me.grpSelectedBox.Name = "grpSelectedBox"
        Me.grpSelectedBox.Size = New System.Drawing.Size(624, 263)
        Me.grpSelectedBox.TabIndex = 5
        Me.grpSelectedBox.TabStop = False
        Me.grpSelectedBox.Text = "Selected Book(s): "
        '
        'CirculationDataGridView
        '
        Me.CirculationDataGridView.AllowUserToAddRows = False
        Me.CirculationDataGridView.AllowUserToDeleteRows = False
        Me.CirculationDataGridView.AutoGenerateColumns = False
        Me.CirculationDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells
        Me.CirculationDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.CirculationDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn3, Me.DataGridViewTextBoxColumn4, Me.DataGridViewTextBoxColumn8, Me.DataGridViewTextBoxColumn6, Me.DataGridViewTextBoxColumn9})
        Me.CirculationDataGridView.DataSource = Me.CirculationBindingSource
        Me.CirculationDataGridView.Location = New System.Drawing.Point(22, 54)
        Me.CirculationDataGridView.Margin = New System.Windows.Forms.Padding(2)
        Me.CirculationDataGridView.Name = "CirculationDataGridView"
        Me.CirculationDataGridView.ReadOnly = True
        Me.CirculationDataGridView.RowTemplate.Height = 24
        Me.CirculationDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.CirculationDataGridView.Size = New System.Drawing.Size(560, 179)
        Me.CirculationDataGridView.TabIndex = 0
        '
        'DataGridViewTextBoxColumn3
        '
        Me.DataGridViewTextBoxColumn3.DataPropertyName = "Student ID"
        Me.DataGridViewTextBoxColumn3.HeaderText = "Student ID"
        Me.DataGridViewTextBoxColumn3.Name = "DataGridViewTextBoxColumn3"
        Me.DataGridViewTextBoxColumn3.ReadOnly = True
        Me.DataGridViewTextBoxColumn3.Width = 94
        '
        'DataGridViewTextBoxColumn4
        '
        Me.DataGridViewTextBoxColumn4.DataPropertyName = "ISBN"
        Me.DataGridViewTextBoxColumn4.HeaderText = "ISBN"
        Me.DataGridViewTextBoxColumn4.Name = "DataGridViewTextBoxColumn4"
        Me.DataGridViewTextBoxColumn4.ReadOnly = True
        Me.DataGridViewTextBoxColumn4.Width = 70
        '
        'DataGridViewTextBoxColumn8
        '
        Me.DataGridViewTextBoxColumn8.DataPropertyName = "Title"
        Me.DataGridViewTextBoxColumn8.HeaderText = "Title"
        Me.DataGridViewTextBoxColumn8.Name = "DataGridViewTextBoxColumn8"
        Me.DataGridViewTextBoxColumn8.ReadOnly = True
        Me.DataGridViewTextBoxColumn8.Width = 62
        '
        'DataGridViewTextBoxColumn6
        '
        Me.DataGridViewTextBoxColumn6.DataPropertyName = "Loan Date"
        Me.DataGridViewTextBoxColumn6.HeaderText = "Loan Date"
        Me.DataGridViewTextBoxColumn6.Name = "DataGridViewTextBoxColumn6"
        Me.DataGridViewTextBoxColumn6.ReadOnly = True
        Me.DataGridViewTextBoxColumn6.Width = 92
        '
        'DataGridViewTextBoxColumn9
        '
        Me.DataGridViewTextBoxColumn9.DataPropertyName = "Return Due Date"
        Me.DataGridViewTextBoxColumn9.HeaderText = "Return Due Date"
        Me.DataGridViewTextBoxColumn9.Name = "DataGridViewTextBoxColumn9"
        Me.DataGridViewTextBoxColumn9.ReadOnly = True
        Me.DataGridViewTextBoxColumn9.Width = 102
        '
        'CirculationBindingSource
        '
        Me.CirculationBindingSource.DataMember = "Circulation"
        Me.CirculationBindingSource.DataSource = Me.TRACE_Library_SystemDataSet
        '
        'TRACE_Library_SystemDataSet
        '
        Me.TRACE_Library_SystemDataSet.DataSetName = "TRACE_Library_SystemDataSet"
        Me.TRACE_Library_SystemDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'Label8
        '
        Me.Label8.Font = New System.Drawing.Font("Mongolian Baiti", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.ForeColor = System.Drawing.Color.Maroon
        Me.Label8.Location = New System.Drawing.Point(22, 23)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(121, 23)
        Me.Label8.TabIndex = 0
        Me.Label8.Text = "Student's ID: "
        Me.Label8.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblStudentName
        '
        Me.lblStudentName.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblStudentName.Font = New System.Drawing.Font("Mongolian Baiti", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblStudentName.ForeColor = System.Drawing.Color.Maroon
        Me.lblStudentName.Location = New System.Drawing.Point(22, 102)
        Me.lblStudentName.Name = "lblStudentName"
        Me.lblStudentName.Size = New System.Drawing.Size(213, 28)
        Me.lblStudentName.TabIndex = 3
        Me.lblStudentName.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label11
        '
        Me.Label11.Font = New System.Drawing.Font("Mongolian Baiti", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.ForeColor = System.Drawing.Color.Maroon
        Me.Label11.Location = New System.Drawing.Point(22, 76)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(119, 23)
        Me.Label11.TabIndex = 2
        Me.Label11.Text = "Student's Name: "
        Me.Label11.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'btnClear
        '
        Me.btnClear.BackColor = System.Drawing.Color.WhiteSmoke
        Me.btnClear.Enabled = False
        Me.btnClear.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnClear.Font = New System.Drawing.Font("Mongolian Baiti", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnClear.ForeColor = System.Drawing.Color.Black
        Me.btnClear.Location = New System.Drawing.Point(48, 187)
        Me.btnClear.Name = "btnClear"
        Me.btnClear.Size = New System.Drawing.Size(152, 35)
        Me.btnClear.TabIndex = 7
        Me.btnClear.Text = "&Clear"
        Me.btnClear.UseVisualStyleBackColor = False
        '
        'btnSearchStudentID
        '
        Me.btnSearchStudentID.BackColor = System.Drawing.Color.WhiteSmoke
        Me.btnSearchStudentID.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnSearchStudentID.Font = New System.Drawing.Font("Mongolian Baiti", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSearchStudentID.ForeColor = System.Drawing.Color.Black
        Me.btnSearchStudentID.Location = New System.Drawing.Point(48, 147)
        Me.btnSearchStudentID.Margin = New System.Windows.Forms.Padding(2)
        Me.btnSearchStudentID.Name = "btnSearchStudentID"
        Me.btnSearchStudentID.Size = New System.Drawing.Size(152, 35)
        Me.btnSearchStudentID.TabIndex = 4
        Me.btnSearchStudentID.Text = "Search Student's ID"
        Me.btnSearchStudentID.UseVisualStyleBackColor = False
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
        Me.CirculationBindingNavigator.Size = New System.Drawing.Size(709, 22)
        Me.CirculationBindingNavigator.TabIndex = 59
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
        Me.BindingNavigatorPositionItem.Size = New System.Drawing.Size(38, 23)
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
        'mskStudentID
        '
        Me.mskStudentID.Font = New System.Drawing.Font("Mongolian Baiti", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.mskStudentID.ForeColor = System.Drawing.Color.Black
        Me.mskStudentID.Location = New System.Drawing.Point(21, 48)
        Me.mskStudentID.Margin = New System.Windows.Forms.Padding(2)
        Me.mskStudentID.Mask = "00>LLL00000"
        Me.mskStudentID.Name = "mskStudentID"
        Me.mskStudentID.Size = New System.Drawing.Size(214, 26)
        Me.mskStudentID.TabIndex = 1
        '
        'ReturnSummary
        '
        Me.AcceptButton = Me.btnSearchStudentID
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.AntiqueWhite
        Me.ClientSize = New System.Drawing.Size(894, 557)
        Me.Controls.Add(Me.mskStudentID)
        Me.Controls.Add(Me.CirculationBindingNavigator)
        Me.Controls.Add(Me.btnSearchStudentID)
        Me.Controls.Add(Me.btnClear)
        Me.Controls.Add(Me.lblStudentName)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.grpSelectedBox)
        Me.Controls.Add(Me.grpLoanDetails)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(2)
        Me.MaximizeBox = False
        Me.Name = "ReturnSummary"
        Me.Text = "Return Summary"
        Me.grpLoanDetails.ResumeLayout(False)
        Me.grpSelectedBox.ResumeLayout(False)
        CType(Me.CirculationDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CirculationBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TRACE_Library_SystemDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CirculationBindingNavigator, System.ComponentModel.ISupportInitialize).EndInit()
        Me.CirculationBindingNavigator.ResumeLayout(False)
        Me.CirculationBindingNavigator.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents grpLoanDetails As GroupBox
    Friend WithEvents lblTitle As Label
    Friend WithEvents lblISBN As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents grpSelectedBox As GroupBox
    Friend WithEvents btnCheckout As Button
    Friend WithEvents lblPayment As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents lblOverdue As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents lblStudentName As Label
    Friend WithEvents Label11 As Label
    Friend WithEvents btnClear As Button
    Friend WithEvents btnSearchStudentID As Button
    Friend WithEvents DataGridViewTextBoxColumn1 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn2 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn5 As DataGridViewTextBoxColumn
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
    Friend WithEvents DataGridViewTextBoxColumn3 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn4 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn8 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn6 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn9 As DataGridViewTextBoxColumn
    Friend WithEvents mskStudentID As MaskedTextBox
End Class
