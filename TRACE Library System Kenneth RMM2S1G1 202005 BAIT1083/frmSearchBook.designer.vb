<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmBookMenu
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmBookMenu))
        Me.btnRemove = New System.Windows.Forms.Button()
        Me.btnUpdate = New System.Windows.Forms.Button()
        Me.dgvBooks = New System.Windows.Forms.DataGridView()
        Me.ISBNDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CallNumberDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TitleDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.AuthorDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PagesDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PublisherDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CategoryDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.LanguageDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.StatusDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DateAddedDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DateRemovedDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ReasonOfRemovalDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.BookBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.TRACE_Library_SystemDataSet = New TRACE_Library_System_Kenneth_RMM2S1G1_202005_BAIT1083.TRACE_Library_SystemDataSet()
        Me.btnLoan = New System.Windows.Forms.Button()
        Me.txtSearchBar = New System.Windows.Forms.TextBox()
        Me.cboSearchFilter = New System.Windows.Forms.ComboBox()
        Me.chklstLanguage = New System.Windows.Forms.CheckedListBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.txtRemovalReason = New System.Windows.Forms.TextBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.dtpDateRemoved = New System.Windows.Forms.DateTimePicker()
        Me.dtpDateAdded = New System.Windows.Forms.DateTimePicker()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.mskCallNum = New System.Windows.Forms.MaskedTextBox()
        Me.mskISBN = New System.Windows.Forms.MaskedTextBox()
        Me.lblStatus = New System.Windows.Forms.Label()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.cboLanguage = New System.Windows.Forms.ComboBox()
        Me.txtPages = New System.Windows.Forms.TextBox()
        Me.cboCategory = New System.Windows.Forms.ComboBox()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.txtPublisher = New System.Windows.Forms.TextBox()
        Me.txtAuthor = New System.Windows.Forms.TextBox()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.txtTitle = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.btnClear = New System.Windows.Forms.Button()
        Me.chklstCategory = New System.Windows.Forms.CheckedListBox()
        Me.btnSearch = New System.Windows.Forms.Button()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.cboStatus = New System.Windows.Forms.ComboBox()
        Me.BookTableAdapter = New TRACE_Library_System_Kenneth_RMM2S1G1_202005_BAIT1083.TRACE_Library_SystemDataSetTableAdapters.BookTableAdapter()
        Me.errCallNum = New System.Windows.Forms.ErrorProvider(Me.components)
        Me.err = New System.Windows.Forms.ErrorProvider(Me.components)
        Me.btnLanguage = New System.Windows.Forms.Button()
        Me.btnCategory = New System.Windows.Forms.Button()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.grpSearch = New System.Windows.Forms.GroupBox()
        CType(Me.dgvBooks, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BookBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TRACE_Library_SystemDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        CType(Me.errCallNum, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.err, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.grpSearch.SuspendLayout()
        Me.SuspendLayout()
        '
        'btnRemove
        '
        Me.btnRemove.BackColor = System.Drawing.Color.WhiteSmoke
        Me.btnRemove.FlatAppearance.BorderColor = System.Drawing.Color.Black
        Me.btnRemove.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnRemove.Font = New System.Drawing.Font("Mongolian Baiti", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnRemove.ForeColor = System.Drawing.Color.Black
        Me.btnRemove.Location = New System.Drawing.Point(166, 598)
        Me.btnRemove.Margin = New System.Windows.Forms.Padding(2)
        Me.btnRemove.Name = "btnRemove"
        Me.btnRemove.Size = New System.Drawing.Size(116, 32)
        Me.btnRemove.TabIndex = 1
        Me.btnRemove.Text = "&Remove"
        Me.btnRemove.UseVisualStyleBackColor = False
        '
        'btnUpdate
        '
        Me.btnUpdate.BackColor = System.Drawing.Color.WhiteSmoke
        Me.btnUpdate.FlatAppearance.BorderColor = System.Drawing.Color.Black
        Me.btnUpdate.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnUpdate.Font = New System.Drawing.Font("Mongolian Baiti", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnUpdate.ForeColor = System.Drawing.Color.Black
        Me.btnUpdate.Location = New System.Drawing.Point(46, 598)
        Me.btnUpdate.Margin = New System.Windows.Forms.Padding(2)
        Me.btnUpdate.Name = "btnUpdate"
        Me.btnUpdate.Size = New System.Drawing.Size(116, 32)
        Me.btnUpdate.TabIndex = 3
        Me.btnUpdate.Text = "&Update"
        Me.btnUpdate.UseVisualStyleBackColor = False
        '
        'dgvBooks
        '
        Me.dgvBooks.AllowUserToAddRows = False
        Me.dgvBooks.AllowUserToDeleteRows = False
        Me.dgvBooks.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.dgvBooks.AutoGenerateColumns = False
        Me.dgvBooks.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells
        Me.dgvBooks.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvBooks.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.ISBNDataGridViewTextBoxColumn, Me.CallNumberDataGridViewTextBoxColumn, Me.TitleDataGridViewTextBoxColumn, Me.AuthorDataGridViewTextBoxColumn, Me.PagesDataGridViewTextBoxColumn, Me.PublisherDataGridViewTextBoxColumn, Me.CategoryDataGridViewTextBoxColumn, Me.LanguageDataGridViewTextBoxColumn, Me.StatusDataGridViewTextBoxColumn, Me.DateAddedDataGridViewTextBoxColumn, Me.DateRemovedDataGridViewTextBoxColumn, Me.ReasonOfRemovalDataGridViewTextBoxColumn})
        Me.dgvBooks.DataSource = Me.BookBindingSource
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        DataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dgvBooks.DefaultCellStyle = DataGridViewCellStyle1
        Me.dgvBooks.Location = New System.Drawing.Point(471, 290)
        Me.dgvBooks.Margin = New System.Windows.Forms.Padding(2)
        Me.dgvBooks.Name = "dgvBooks"
        Me.dgvBooks.ReadOnly = True
        Me.dgvBooks.RowTemplate.Height = 24
        Me.dgvBooks.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvBooks.Size = New System.Drawing.Size(818, 331)
        Me.dgvBooks.TabIndex = 2
        '
        'ISBNDataGridViewTextBoxColumn
        '
        Me.ISBNDataGridViewTextBoxColumn.DataPropertyName = "ISBN"
        Me.ISBNDataGridViewTextBoxColumn.HeaderText = "ISBN"
        Me.ISBNDataGridViewTextBoxColumn.Name = "ISBNDataGridViewTextBoxColumn"
        Me.ISBNDataGridViewTextBoxColumn.ReadOnly = True
        Me.ISBNDataGridViewTextBoxColumn.Width = 57
        '
        'CallNumberDataGridViewTextBoxColumn
        '
        Me.CallNumberDataGridViewTextBoxColumn.DataPropertyName = "Call Number"
        Me.CallNumberDataGridViewTextBoxColumn.HeaderText = "Call Number"
        Me.CallNumberDataGridViewTextBoxColumn.Name = "CallNumberDataGridViewTextBoxColumn"
        Me.CallNumberDataGridViewTextBoxColumn.ReadOnly = True
        Me.CallNumberDataGridViewTextBoxColumn.Width = 82
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
        'PagesDataGridViewTextBoxColumn
        '
        Me.PagesDataGridViewTextBoxColumn.DataPropertyName = "Pages"
        Me.PagesDataGridViewTextBoxColumn.HeaderText = "Pages"
        Me.PagesDataGridViewTextBoxColumn.Name = "PagesDataGridViewTextBoxColumn"
        Me.PagesDataGridViewTextBoxColumn.ReadOnly = True
        Me.PagesDataGridViewTextBoxColumn.Width = 62
        '
        'PublisherDataGridViewTextBoxColumn
        '
        Me.PublisherDataGridViewTextBoxColumn.DataPropertyName = "Publisher"
        Me.PublisherDataGridViewTextBoxColumn.HeaderText = "Publisher"
        Me.PublisherDataGridViewTextBoxColumn.Name = "PublisherDataGridViewTextBoxColumn"
        Me.PublisherDataGridViewTextBoxColumn.ReadOnly = True
        Me.PublisherDataGridViewTextBoxColumn.Width = 75
        '
        'CategoryDataGridViewTextBoxColumn
        '
        Me.CategoryDataGridViewTextBoxColumn.DataPropertyName = "Category"
        Me.CategoryDataGridViewTextBoxColumn.HeaderText = "Category"
        Me.CategoryDataGridViewTextBoxColumn.Name = "CategoryDataGridViewTextBoxColumn"
        Me.CategoryDataGridViewTextBoxColumn.ReadOnly = True
        Me.CategoryDataGridViewTextBoxColumn.Width = 74
        '
        'LanguageDataGridViewTextBoxColumn
        '
        Me.LanguageDataGridViewTextBoxColumn.DataPropertyName = "Language"
        Me.LanguageDataGridViewTextBoxColumn.HeaderText = "Language"
        Me.LanguageDataGridViewTextBoxColumn.Name = "LanguageDataGridViewTextBoxColumn"
        Me.LanguageDataGridViewTextBoxColumn.ReadOnly = True
        Me.LanguageDataGridViewTextBoxColumn.Width = 80
        '
        'StatusDataGridViewTextBoxColumn
        '
        Me.StatusDataGridViewTextBoxColumn.DataPropertyName = "Status"
        Me.StatusDataGridViewTextBoxColumn.HeaderText = "Status"
        Me.StatusDataGridViewTextBoxColumn.Name = "StatusDataGridViewTextBoxColumn"
        Me.StatusDataGridViewTextBoxColumn.ReadOnly = True
        Me.StatusDataGridViewTextBoxColumn.Width = 62
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
        'btnLoan
        '
        Me.btnLoan.BackColor = System.Drawing.Color.WhiteSmoke
        Me.btnLoan.FlatAppearance.BorderColor = System.Drawing.Color.Black
        Me.btnLoan.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnLoan.Font = New System.Drawing.Font("Mongolian Baiti", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnLoan.ForeColor = System.Drawing.Color.Black
        Me.btnLoan.Location = New System.Drawing.Point(286, 598)
        Me.btnLoan.Margin = New System.Windows.Forms.Padding(2)
        Me.btnLoan.Name = "btnLoan"
        Me.btnLoan.Size = New System.Drawing.Size(116, 32)
        Me.btnLoan.TabIndex = 6
        Me.btnLoan.Text = "&Loan"
        Me.btnLoan.UseVisualStyleBackColor = False
        '
        'txtSearchBar
        '
        Me.txtSearchBar.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtSearchBar.Location = New System.Drawing.Point(361, 20)
        Me.txtSearchBar.Margin = New System.Windows.Forms.Padding(2)
        Me.txtSearchBar.Name = "txtSearchBar"
        Me.txtSearchBar.Size = New System.Drawing.Size(256, 26)
        Me.txtSearchBar.TabIndex = 1
        '
        'cboSearchFilter
        '
        Me.cboSearchFilter.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboSearchFilter.Font = New System.Drawing.Font("Mongolian Baiti", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboSearchFilter.FormattingEnabled = True
        Me.cboSearchFilter.Items.AddRange(New Object() {"Title, Author, or Publisher", "Title", "Author", "Publisher"})
        Me.cboSearchFilter.Location = New System.Drawing.Point(92, 21)
        Me.cboSearchFilter.Margin = New System.Windows.Forms.Padding(2)
        Me.cboSearchFilter.Name = "cboSearchFilter"
        Me.cboSearchFilter.Size = New System.Drawing.Size(255, 23)
        Me.cboSearchFilter.TabIndex = 0
        '
        'chklstLanguage
        '
        Me.chklstLanguage.CheckOnClick = True
        Me.chklstLanguage.Font = New System.Drawing.Font("Mongolian Baiti", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chklstLanguage.FormattingEnabled = True
        Me.chklstLanguage.Items.AddRange(New Object() {"English", "Malay", "Chinese", "French", "Spanish", "German", "Japanese"})
        Me.chklstLanguage.Location = New System.Drawing.Point(92, 112)
        Me.chklstLanguage.Margin = New System.Windows.Forms.Padding(2)
        Me.chklstLanguage.Name = "chklstLanguage"
        Me.chklstLanguage.Size = New System.Drawing.Size(144, 76)
        Me.chklstLanguage.TabIndex = 4
        Me.chklstLanguage.Visible = False
        '
        'Label2
        '
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label2.Font = New System.Drawing.Font("Mongolian Baiti", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.Maroon
        Me.Label2.Location = New System.Drawing.Point(92, 84)
        Me.Label2.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(114, 29)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Language"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.txtRemovalReason)
        Me.GroupBox1.Controls.Add(Me.Label9)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.dtpDateRemoved)
        Me.GroupBox1.Controls.Add(Me.dtpDateAdded)
        Me.GroupBox1.Controls.Add(Me.Label10)
        Me.GroupBox1.Controls.Add(Me.mskCallNum)
        Me.GroupBox1.Controls.Add(Me.mskISBN)
        Me.GroupBox1.Controls.Add(Me.lblStatus)
        Me.GroupBox1.Controls.Add(Me.Label16)
        Me.GroupBox1.Controls.Add(Me.cboLanguage)
        Me.GroupBox1.Controls.Add(Me.txtPages)
        Me.GroupBox1.Controls.Add(Me.cboCategory)
        Me.GroupBox1.Controls.Add(Me.Label15)
        Me.GroupBox1.Controls.Add(Me.txtPublisher)
        Me.GroupBox1.Controls.Add(Me.txtAuthor)
        Me.GroupBox1.Controls.Add(Me.Label13)
        Me.GroupBox1.Controls.Add(Me.Label12)
        Me.GroupBox1.Controls.Add(Me.txtTitle)
        Me.GroupBox1.Controls.Add(Me.Label8)
        Me.GroupBox1.Controls.Add(Me.Label7)
        Me.GroupBox1.Controls.Add(Me.Label6)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.btnLoan)
        Me.GroupBox1.Controls.Add(Me.btnUpdate)
        Me.GroupBox1.Controls.Add(Me.btnRemove)
        Me.GroupBox1.Font = New System.Drawing.Font("Mongolian Baiti", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.ForeColor = System.Drawing.Color.Maroon
        Me.GroupBox1.Location = New System.Drawing.Point(9, 5)
        Me.GroupBox1.Margin = New System.Windows.Forms.Padding(2)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Padding = New System.Windows.Forms.Padding(2)
        Me.GroupBox1.Size = New System.Drawing.Size(430, 740)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Book Information"
        '
        'txtRemovalReason
        '
        Me.txtRemovalReason.BackColor = System.Drawing.Color.White
        Me.txtRemovalReason.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.BookBindingSource, "Reason Of Removal", True))
        Me.txtRemovalReason.Font = New System.Drawing.Font("Mongolian Baiti", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtRemovalReason.ForeColor = System.Drawing.SystemColors.WindowText
        Me.txtRemovalReason.Location = New System.Drawing.Point(142, 503)
        Me.txtRemovalReason.Margin = New System.Windows.Forms.Padding(2)
        Me.txtRemovalReason.Name = "txtRemovalReason"
        Me.txtRemovalReason.ReadOnly = True
        Me.txtRemovalReason.Size = New System.Drawing.Size(273, 23)
        Me.txtRemovalReason.TabIndex = 21
        '
        'Label9
        '
        Me.Label9.Font = New System.Drawing.Font("Mongolian Baiti", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.ForeColor = System.Drawing.Color.Maroon
        Me.Label9.Location = New System.Drawing.Point(17, 478)
        Me.Label9.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(98, 59)
        Me.Label9.TabIndex = 20
        Me.Label9.Text = "Reason Of Removal :"
        Me.Label9.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Mongolian Baiti", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.Maroon
        Me.Label3.Location = New System.Drawing.Point(12, 448)
        Me.Label3.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(107, 16)
        Me.Label3.TabIndex = 18
        Me.Label3.Text = "Date Removed:"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'dtpDateRemoved
        '
        Me.dtpDateRemoved.CustomFormat = "dd/MM/yyyy"
        Me.dtpDateRemoved.DataBindings.Add(New System.Windows.Forms.Binding("Value", Me.BookBindingSource, "Date Removed", True))
        Me.dtpDateRemoved.Enabled = False
        Me.dtpDateRemoved.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtpDateRemoved.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpDateRemoved.Location = New System.Drawing.Point(142, 445)
        Me.dtpDateRemoved.Margin = New System.Windows.Forms.Padding(2)
        Me.dtpDateRemoved.MinDate = New Date(2020, 9, 6, 0, 0, 0, 0)
        Me.dtpDateRemoved.Name = "dtpDateRemoved"
        Me.dtpDateRemoved.Size = New System.Drawing.Size(276, 26)
        Me.dtpDateRemoved.TabIndex = 19
        '
        'dtpDateAdded
        '
        Me.dtpDateAdded.CustomFormat = "dd/MM/yyyy"
        Me.dtpDateAdded.DataBindings.Add(New System.Windows.Forms.Binding("Value", Me.BookBindingSource, "Date Added", True))
        Me.dtpDateAdded.Enabled = False
        Me.dtpDateAdded.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtpDateAdded.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpDateAdded.Location = New System.Drawing.Point(142, 399)
        Me.dtpDateAdded.Margin = New System.Windows.Forms.Padding(2)
        Me.dtpDateAdded.MaxDate = New Date(2020, 9, 6, 0, 0, 0, 0)
        Me.dtpDateAdded.Name = "dtpDateAdded"
        Me.dtpDateAdded.Size = New System.Drawing.Size(276, 26)
        Me.dtpDateAdded.TabIndex = 17
        Me.dtpDateAdded.Value = New Date(2020, 9, 6, 0, 0, 0, 0)
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Mongolian Baiti", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.ForeColor = System.Drawing.Color.Maroon
        Me.Label10.Location = New System.Drawing.Point(30, 401)
        Me.Label10.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(89, 16)
        Me.Label10.TabIndex = 16
        Me.Label10.Text = "Date Added:"
        Me.Label10.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'mskCallNum
        '
        Me.mskCallNum.BackColor = System.Drawing.Color.White
        Me.mskCallNum.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.BookBindingSource, "Call Number", True))
        Me.mskCallNum.Font = New System.Drawing.Font("Mongolian Baiti", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.mskCallNum.Location = New System.Drawing.Point(142, 50)
        Me.mskCallNum.Margin = New System.Windows.Forms.Padding(2)
        Me.mskCallNum.Mask = "000>LLL"
        Me.mskCallNum.Name = "mskCallNum"
        Me.mskCallNum.ReadOnly = True
        Me.mskCallNum.Size = New System.Drawing.Size(190, 23)
        Me.mskCallNum.TabIndex = 1
        Me.mskCallNum.ValidatingType = GetType(Integer)
        '
        'mskISBN
        '
        Me.mskISBN.BackColor = System.Drawing.Color.White
        Me.mskISBN.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.BookBindingSource, "ISBN", True))
        Me.mskISBN.Font = New System.Drawing.Font("Mongolian Baiti", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.mskISBN.ForeColor = System.Drawing.SystemColors.WindowText
        Me.mskISBN.Location = New System.Drawing.Point(142, 224)
        Me.mskISBN.Margin = New System.Windows.Forms.Padding(2)
        Me.mskISBN.Mask = "0000000000000"
        Me.mskISBN.Name = "mskISBN"
        Me.mskISBN.ReadOnly = True
        Me.mskISBN.Size = New System.Drawing.Size(276, 23)
        Me.mskISBN.TabIndex = 9
        Me.mskISBN.ValidatingType = GetType(Integer)
        '
        'lblStatus
        '
        Me.lblStatus.BackColor = System.Drawing.Color.White
        Me.lblStatus.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblStatus.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.BookBindingSource, "Status", True))
        Me.lblStatus.Font = New System.Drawing.Font("Mongolian Baiti", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblStatus.ForeColor = System.Drawing.SystemColors.WindowText
        Me.lblStatus.Location = New System.Drawing.Point(142, 544)
        Me.lblStatus.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblStatus.Name = "lblStatus"
        Me.lblStatus.Size = New System.Drawing.Size(157, 32)
        Me.lblStatus.TabIndex = 23
        Me.lblStatus.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Font = New System.Drawing.Font("Mongolian Baiti", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label16.ForeColor = System.Drawing.Color.Maroon
        Me.Label16.Location = New System.Drawing.Point(65, 550)
        Me.Label16.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(54, 16)
        Me.Label16.TabIndex = 22
        Me.Label16.Text = "Status :"
        Me.Label16.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'cboLanguage
        '
        Me.cboLanguage.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.BookBindingSource, "Language", True))
        Me.cboLanguage.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboLanguage.Enabled = False
        Me.cboLanguage.Font = New System.Drawing.Font("Mongolian Baiti", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboLanguage.FormattingEnabled = True
        Me.cboLanguage.Items.AddRange(New Object() {"Any", "English", "Malay", "Chinese", "French", "Spanish", "German", "Japanese"})
        Me.cboLanguage.Location = New System.Drawing.Point(142, 355)
        Me.cboLanguage.Margin = New System.Windows.Forms.Padding(2)
        Me.cboLanguage.Name = "cboLanguage"
        Me.cboLanguage.Size = New System.Drawing.Size(276, 23)
        Me.cboLanguage.TabIndex = 15
        '
        'txtPages
        '
        Me.txtPages.BackColor = System.Drawing.Color.White
        Me.txtPages.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.BookBindingSource, "Pages", True))
        Me.txtPages.Font = New System.Drawing.Font("Mongolian Baiti", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtPages.ForeColor = System.Drawing.SystemColors.WindowText
        Me.txtPages.Location = New System.Drawing.Point(142, 180)
        Me.txtPages.Margin = New System.Windows.Forms.Padding(2)
        Me.txtPages.Name = "txtPages"
        Me.txtPages.ReadOnly = True
        Me.txtPages.Size = New System.Drawing.Size(130, 23)
        Me.txtPages.TabIndex = 7
        '
        'cboCategory
        '
        Me.cboCategory.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.BookBindingSource, "Category", True))
        Me.cboCategory.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboCategory.Enabled = False
        Me.cboCategory.Font = New System.Drawing.Font("Mongolian Baiti", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboCategory.FormattingEnabled = True
        Me.cboCategory.Items.AddRange(New Object() {"Any", "Architecture", "Biology", "Business", "Physics", "Mathematics", "Computer Science", "Acounting", "Graphic Design", "Sports and Medicine", "Psychology", "Philosophy", "Fiction", "Miscellaneous"})
        Me.cboCategory.Location = New System.Drawing.Point(142, 312)
        Me.cboCategory.Margin = New System.Windows.Forms.Padding(2)
        Me.cboCategory.Name = "cboCategory"
        Me.cboCategory.Size = New System.Drawing.Size(274, 23)
        Me.cboCategory.TabIndex = 13
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Font = New System.Drawing.Font("Mongolian Baiti", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label15.ForeColor = System.Drawing.Color.Maroon
        Me.Label15.Location = New System.Drawing.Point(63, 181)
        Me.Label15.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(53, 16)
        Me.Label15.TabIndex = 6
        Me.Label15.Text = "Pages :"
        Me.Label15.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'txtPublisher
        '
        Me.txtPublisher.BackColor = System.Drawing.Color.White
        Me.txtPublisher.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.BookBindingSource, "Publisher", True))
        Me.txtPublisher.Font = New System.Drawing.Font("Mongolian Baiti", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtPublisher.ForeColor = System.Drawing.SystemColors.WindowText
        Me.txtPublisher.Location = New System.Drawing.Point(142, 268)
        Me.txtPublisher.Margin = New System.Windows.Forms.Padding(2)
        Me.txtPublisher.Name = "txtPublisher"
        Me.txtPublisher.ReadOnly = True
        Me.txtPublisher.Size = New System.Drawing.Size(276, 23)
        Me.txtPublisher.TabIndex = 11
        '
        'txtAuthor
        '
        Me.txtAuthor.BackColor = System.Drawing.Color.White
        Me.txtAuthor.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.BookBindingSource, "Author", True))
        Me.txtAuthor.Font = New System.Drawing.Font("Mongolian Baiti", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtAuthor.ForeColor = System.Drawing.SystemColors.WindowText
        Me.txtAuthor.Location = New System.Drawing.Point(142, 137)
        Me.txtAuthor.Margin = New System.Windows.Forms.Padding(2)
        Me.txtAuthor.Name = "txtAuthor"
        Me.txtAuthor.ReadOnly = True
        Me.txtAuthor.Size = New System.Drawing.Size(276, 23)
        Me.txtAuthor.TabIndex = 5
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Font = New System.Drawing.Font("Mongolian Baiti", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.ForeColor = System.Drawing.Color.Maroon
        Me.Label13.Location = New System.Drawing.Point(39, 312)
        Me.Label13.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(78, 16)
        Me.Label13.TabIndex = 12
        Me.Label13.Text = "Category : "
        Me.Label13.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("Mongolian Baiti", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.ForeColor = System.Drawing.Color.Maroon
        Me.Label12.Location = New System.Drawing.Point(35, 355)
        Me.Label12.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(83, 16)
        Me.Label12.TabIndex = 14
        Me.Label12.Text = "Language : "
        Me.Label12.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'txtTitle
        '
        Me.txtTitle.BackColor = System.Drawing.Color.White
        Me.txtTitle.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.BookBindingSource, "Title", True))
        Me.txtTitle.Font = New System.Drawing.Font("Mongolian Baiti", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtTitle.Location = New System.Drawing.Point(142, 93)
        Me.txtTitle.Margin = New System.Windows.Forms.Padding(2)
        Me.txtTitle.Name = "txtTitle"
        Me.txtTitle.ReadOnly = True
        Me.txtTitle.Size = New System.Drawing.Size(276, 23)
        Me.txtTitle.TabIndex = 3
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Mongolian Baiti", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.ForeColor = System.Drawing.Color.Maroon
        Me.Label8.Location = New System.Drawing.Point(52, 137)
        Me.Label8.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(65, 16)
        Me.Label8.TabIndex = 4
        Me.Label8.Text = "Author : "
        Me.Label8.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Mongolian Baiti", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.Color.Maroon
        Me.Label7.Location = New System.Drawing.Point(22, 50)
        Me.Label7.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(94, 16)
        Me.Label7.TabIndex = 0
        Me.Label7.Text = "Call number :"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Mongolian Baiti", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.Maroon
        Me.Label6.Location = New System.Drawing.Point(61, 225)
        Me.Label6.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(57, 16)
        Me.Label6.TabIndex = 8
        Me.Label6.Text = "ISBN : "
        Me.Label6.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Mongolian Baiti", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.Maroon
        Me.Label5.Location = New System.Drawing.Point(40, 269)
        Me.Label5.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(75, 16)
        Me.Label5.TabIndex = 10
        Me.Label5.Text = "Publisher :"
        Me.Label5.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Mongolian Baiti", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.Maroon
        Me.Label4.Location = New System.Drawing.Point(65, 93)
        Me.Label4.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(49, 16)
        Me.Label4.TabIndex = 2
        Me.Label4.Text = "Title : "
        '
        'btnClear
        '
        Me.btnClear.BackColor = System.Drawing.Color.Snow
        Me.btnClear.FlatAppearance.BorderColor = System.Drawing.Color.Black
        Me.btnClear.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnClear.Font = New System.Drawing.Font("Mongolian Baiti", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnClear.ForeColor = System.Drawing.Color.Black
        Me.btnClear.Location = New System.Drawing.Point(562, 148)
        Me.btnClear.Margin = New System.Windows.Forms.Padding(2)
        Me.btnClear.Name = "btnClear"
        Me.btnClear.Size = New System.Drawing.Size(116, 32)
        Me.btnClear.TabIndex = 10
        Me.btnClear.Text = "&Clear Search"
        Me.btnClear.UseVisualStyleBackColor = False
        '
        'chklstCategory
        '
        Me.chklstCategory.CheckOnClick = True
        Me.chklstCategory.Font = New System.Drawing.Font("Mongolian Baiti", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chklstCategory.FormattingEnabled = True
        Me.chklstCategory.Items.AddRange(New Object() {"Accounting", "Architecture", "Biology", "Business", "Chemistry", "Computer Science", "Fiction", "Graphic Design", "Mathematics", "Miscellaneous", "Philosophy", "Physics", "Psychology", "Sports and Medicine"})
        Me.chklstCategory.Location = New System.Drawing.Point(264, 112)
        Me.chklstCategory.Margin = New System.Windows.Forms.Padding(2)
        Me.chklstCategory.Name = "chklstCategory"
        Me.chklstCategory.Size = New System.Drawing.Size(172, 76)
        Me.chklstCategory.Sorted = True
        Me.chklstCategory.TabIndex = 7
        Me.chklstCategory.Visible = False
        '
        'btnSearch
        '
        Me.btnSearch.BackgroundImage = Global.TRACE_Library_System_Kenneth_RMM2S1G1_202005_BAIT1083.My.Resources.Resources.Search_Button_PNG_Transparent_Image
        Me.btnSearch.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnSearch.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnSearch.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSearch.Location = New System.Drawing.Point(625, 13)
        Me.btnSearch.Margin = New System.Windows.Forms.Padding(2)
        Me.btnSearch.Name = "btnSearch"
        Me.btnSearch.Size = New System.Drawing.Size(35, 37)
        Me.btnSearch.TabIndex = 7
        Me.btnSearch.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        Me.btnSearch.UseVisualStyleBackColor = True
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.Font = New System.Drawing.Font("Mongolian Baiti", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label17.Location = New System.Drawing.Point(477, 90)
        Me.Label17.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(49, 15)
        Me.Label17.TabIndex = 8
        Me.Label17.Text = "Status :"
        '
        'cboStatus
        '
        Me.cboStatus.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboStatus.Font = New System.Drawing.Font("Mongolian Baiti", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboStatus.FormattingEnabled = True
        Me.cboStatus.Items.AddRange(New Object() {"Available", "Removed", "Loaned"})
        Me.cboStatus.Location = New System.Drawing.Point(541, 88)
        Me.cboStatus.Margin = New System.Windows.Forms.Padding(2)
        Me.cboStatus.Name = "cboStatus"
        Me.cboStatus.Size = New System.Drawing.Size(138, 23)
        Me.cboStatus.TabIndex = 9
        '
        'BookTableAdapter
        '
        Me.BookTableAdapter.ClearBeforeFill = True
        '
        'errCallNum
        '
        Me.errCallNum.BlinkStyle = System.Windows.Forms.ErrorBlinkStyle.NeverBlink
        Me.errCallNum.ContainerControl = Me
        '
        'err
        '
        Me.err.BlinkStyle = System.Windows.Forms.ErrorBlinkStyle.NeverBlink
        Me.err.ContainerControl = Me
        '
        'btnLanguage
        '
        Me.btnLanguage.BackgroundImage = Global.TRACE_Library_System_Kenneth_RMM2S1G1_202005_BAIT1083.My.Resources.Resources.Arrow_down
        Me.btnLanguage.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnLanguage.Font = New System.Drawing.Font("Mongolian Baiti", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnLanguage.Location = New System.Drawing.Point(206, 84)
        Me.btnLanguage.Margin = New System.Windows.Forms.Padding(2)
        Me.btnLanguage.Name = "btnLanguage"
        Me.btnLanguage.Size = New System.Drawing.Size(30, 28)
        Me.btnLanguage.TabIndex = 3
        Me.btnLanguage.UseVisualStyleBackColor = True
        '
        'btnCategory
        '
        Me.btnCategory.BackgroundImage = Global.TRACE_Library_System_Kenneth_RMM2S1G1_202005_BAIT1083.My.Resources.Resources.Arrow_down
        Me.btnCategory.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnCategory.Font = New System.Drawing.Font("Mongolian Baiti", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCategory.Location = New System.Drawing.Point(404, 84)
        Me.btnCategory.Margin = New System.Windows.Forms.Padding(2)
        Me.btnCategory.Name = "btnCategory"
        Me.btnCategory.Size = New System.Drawing.Size(30, 28)
        Me.btnCategory.TabIndex = 6
        Me.btnCategory.UseVisualStyleBackColor = True
        '
        'Label11
        '
        Me.Label11.BackColor = System.Drawing.Color.Transparent
        Me.Label11.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label11.Font = New System.Drawing.Font("Mongolian Baiti", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.ForeColor = System.Drawing.Color.Maroon
        Me.Label11.Location = New System.Drawing.Point(264, 84)
        Me.Label11.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(142, 29)
        Me.Label11.TabIndex = 5
        Me.Label11.Text = "Category"
        Me.Label11.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'grpSearch
        '
        Me.grpSearch.Controls.Add(Me.cboSearchFilter)
        Me.grpSearch.Controls.Add(Me.Label11)
        Me.grpSearch.Controls.Add(Me.txtSearchBar)
        Me.grpSearch.Controls.Add(Me.btnCategory)
        Me.grpSearch.Controls.Add(Me.btnSearch)
        Me.grpSearch.Controls.Add(Me.btnLanguage)
        Me.grpSearch.Controls.Add(Me.Label2)
        Me.grpSearch.Controls.Add(Me.cboStatus)
        Me.grpSearch.Controls.Add(Me.chklstLanguage)
        Me.grpSearch.Controls.Add(Me.Label17)
        Me.grpSearch.Controls.Add(Me.btnClear)
        Me.grpSearch.Controls.Add(Me.chklstCategory)
        Me.grpSearch.Font = New System.Drawing.Font("Mongolian Baiti", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.grpSearch.ForeColor = System.Drawing.Color.Maroon
        Me.grpSearch.Location = New System.Drawing.Point(471, 75)
        Me.grpSearch.Name = "grpSearch"
        Me.grpSearch.Size = New System.Drawing.Size(818, 194)
        Me.grpSearch.TabIndex = 1
        Me.grpSearch.TabStop = False
        Me.grpSearch.Text = "Search Book"
        '
        'frmBookMenu
        '
        Me.AcceptButton = Me.btnSearch
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoValidate = System.Windows.Forms.AutoValidate.EnableAllowFocusChange
        Me.BackColor = System.Drawing.Color.AntiqueWhite
        Me.ClientSize = New System.Drawing.Size(1315, 646)
        Me.Controls.Add(Me.grpSearch)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.dgvBooks)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(2)
        Me.MaximizeBox = False
        Me.Name = "frmBookMenu"
        Me.Text = "Search and Update Book"
        CType(Me.dgvBooks, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BookBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TRACE_Library_SystemDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.errCallNum, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.err, System.ComponentModel.ISupportInitialize).EndInit()
        Me.grpSearch.ResumeLayout(False)
        Me.grpSearch.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents btnRemove As Button
    Friend WithEvents btnUpdate As Button
    Friend WithEvents dgvBooks As DataGridView
    Friend WithEvents btnLoan As Button
    Friend WithEvents btnSearch As Button
    Friend WithEvents txtSearchBar As TextBox
    Friend WithEvents cboSearchFilter As ComboBox
    Friend WithEvents chklstLanguage As CheckedListBox
    Friend WithEvents Label2 As Label
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents Label8 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents txtTitle As TextBox
    Friend WithEvents Label13 As Label
    Friend WithEvents Label12 As Label
    Friend WithEvents Label15 As Label
    Friend WithEvents txtPublisher As TextBox
    Friend WithEvents txtAuthor As TextBox
    Friend WithEvents btnClear As Button
    Friend WithEvents chklstCategory As CheckedListBox
    Friend WithEvents cboCategory As ComboBox
    Friend WithEvents cboLanguage As ComboBox
    Friend WithEvents txtPages As TextBox
    Friend WithEvents lblStatus As Label
    Friend WithEvents Label16 As Label
    Friend WithEvents Label17 As Label
    Friend WithEvents cboStatus As ComboBox
    Friend WithEvents TRACE_Library_SystemDataSet As TRACE_Library_SystemDataSet
    Friend WithEvents BookBindingSource As BindingSource
    Friend WithEvents BookTableAdapter As TRACE_Library_SystemDataSetTableAdapters.BookTableAdapter
    Friend WithEvents mskISBN As MaskedTextBox
    Friend WithEvents mskCallNum As MaskedTextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents dtpDateRemoved As DateTimePicker
    Friend WithEvents dtpDateAdded As DateTimePicker
    Friend WithEvents Label10 As Label
    Friend WithEvents ISBNDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents CallNumberDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents TitleDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents AuthorDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents PagesDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents PublisherDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents CategoryDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents LanguageDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents StatusDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents DateAddedDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents DateRemovedDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents ReasonOfRemovalDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents txtRemovalReason As TextBox
    Friend WithEvents Label9 As Label
    Friend WithEvents errCallNum As ErrorProvider
    Friend WithEvents err As ErrorProvider
    Friend WithEvents Label11 As Label
    Friend WithEvents btnCategory As Button
    Friend WithEvents btnLanguage As Button
    Friend WithEvents grpSearch As GroupBox
End Class
