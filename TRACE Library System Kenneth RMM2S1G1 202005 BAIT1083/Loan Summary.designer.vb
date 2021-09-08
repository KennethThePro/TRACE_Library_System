<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class LoanSummary
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(LoanSummary))
        Me.Label8 = New System.Windows.Forms.Label()
        Me.grpLoanSummary = New System.Windows.Forms.GroupBox()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.ReturnDueDate = New System.Windows.Forms.DateTimePicker()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.LoanStartDate = New System.Windows.Forms.DateTimePicker()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.lblDuration = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btnLoan = New System.Windows.Forms.Button()
        Me.grpSelectedBooks = New System.Windows.Forms.GroupBox()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.lblCount = New System.Windows.Forms.Label()
        Me.lstSelectedBooks = New System.Windows.Forms.ListBox()
        Me.btnDelete = New System.Windows.Forms.Button()
        Me.grpBookDetails = New System.Windows.Forms.GroupBox()
        Me.mskISBN = New System.Windows.Forms.MaskedTextBox()
        Me.lblAuthor = New System.Windows.Forms.Label()
        Me.lblTitle = New System.Windows.Forms.Label()
        Me.btnSearchISBN = New System.Windows.Forms.Button()
        Me.lblCallNumber = New System.Windows.Forms.Label()
        Me.btnAddToList = New System.Windows.Forms.Button()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.lblStudentName = New System.Windows.Forms.Label()
        Me.btnSearchStudentID = New System.Windows.Forms.Button()
        Me.grpLoanHistory = New System.Windows.Forms.GroupBox()
        Me.btnClear = New System.Windows.Forms.Button()
        Me.mskStudentID = New System.Windows.Forms.MaskedTextBox()
        Me.CirculationDataGridView = New System.Windows.Forms.DataGridView()
        Me.DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CirculationBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.TRACE_Library_SystemDataSet = New TRACE_Library_System_Kenneth_RMM2S1G1_202005_BAIT1083.TRACE_Library_SystemDataSet()
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
        Me.CirculationTableAdapter = New TRACE_Library_System_Kenneth_RMM2S1G1_202005_BAIT1083.TRACE_Library_SystemDataSetTableAdapters.CirculationTableAdapter()
        Me.TableAdapterManager = New TRACE_Library_System_Kenneth_RMM2S1G1_202005_BAIT1083.TRACE_Library_SystemDataSetTableAdapters.TableAdapterManager()
        Me.grpLoanSummary.SuspendLayout()
        Me.grpSelectedBooks.SuspendLayout()
        Me.grpBookDetails.SuspendLayout()
        Me.grpLoanHistory.SuspendLayout()
        CType(Me.CirculationDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CirculationBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TRACE_Library_SystemDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CirculationBindingNavigator, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.CirculationBindingNavigator.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label8
        '
        Me.Label8.Font = New System.Drawing.Font("Mongolian Baiti", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.ForeColor = System.Drawing.Color.Maroon
        Me.Label8.Location = New System.Drawing.Point(17, 21)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(119, 23)
        Me.Label8.TabIndex = 0
        Me.Label8.Text = "Student's ID: "
        Me.Label8.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'grpLoanSummary
        '
        Me.grpLoanSummary.Controls.Add(Me.Label13)
        Me.grpLoanSummary.Controls.Add(Me.ReturnDueDate)
        Me.grpLoanSummary.Controls.Add(Me.Label2)
        Me.grpLoanSummary.Controls.Add(Me.LoanStartDate)
        Me.grpLoanSummary.Controls.Add(Me.Label5)
        Me.grpLoanSummary.Controls.Add(Me.lblDuration)
        Me.grpLoanSummary.Controls.Add(Me.Label4)
        Me.grpLoanSummary.Controls.Add(Me.Label1)
        Me.grpLoanSummary.Controls.Add(Me.btnLoan)
        Me.grpLoanSummary.Font = New System.Drawing.Font("Mongolian Baiti", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.grpLoanSummary.ForeColor = System.Drawing.Color.Maroon
        Me.grpLoanSummary.Location = New System.Drawing.Point(623, 26)
        Me.grpLoanSummary.Name = "grpLoanSummary"
        Me.grpLoanSummary.Size = New System.Drawing.Size(534, 283)
        Me.grpLoanSummary.TabIndex = 3
        Me.grpLoanSummary.TabStop = False
        Me.grpLoanSummary.Text = "Loan Summary: "
        '
        'Label13
        '
        Me.Label13.Font = New System.Drawing.Font("Mongolian Baiti", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.ForeColor = System.Drawing.Color.Maroon
        Me.Label13.Location = New System.Drawing.Point(290, 47)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(108, 23)
        Me.Label13.TabIndex = 33
        Me.Label13.Text = "(Today)"
        Me.Label13.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'ReturnDueDate
        '
        Me.ReturnDueDate.CustomFormat = " "
        Me.ReturnDueDate.Enabled = False
        Me.ReturnDueDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.ReturnDueDate.Location = New System.Drawing.Point(172, 152)
        Me.ReturnDueDate.Margin = New System.Windows.Forms.Padding(2)
        Me.ReturnDueDate.Name = "ReturnDueDate"
        Me.ReturnDueDate.ShowUpDown = True
        Me.ReturnDueDate.Size = New System.Drawing.Size(114, 23)
        Me.ReturnDueDate.TabIndex = 32
        '
        'Label2
        '
        Me.Label2.Font = New System.Drawing.Font("Mongolian Baiti", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.Maroon
        Me.Label2.Location = New System.Drawing.Point(59, 152)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(121, 23)
        Me.Label2.TabIndex = 31
        Me.Label2.Text = "Return Due Date: "
        '
        'LoanStartDate
        '
        Me.LoanStartDate.CustomFormat = " "
        Me.LoanStartDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.LoanStartDate.Location = New System.Drawing.Point(172, 48)
        Me.LoanStartDate.Margin = New System.Windows.Forms.Padding(2)
        Me.LoanStartDate.Name = "LoanStartDate"
        Me.LoanStartDate.ShowUpDown = True
        Me.LoanStartDate.Size = New System.Drawing.Size(114, 23)
        Me.LoanStartDate.TabIndex = 30
        '
        'Label5
        '
        Me.Label5.Font = New System.Drawing.Font("Mongolian Baiti", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.Maroon
        Me.Label5.Location = New System.Drawing.Point(230, 98)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(108, 23)
        Me.Label5.TabIndex = 29
        Me.Label5.Text = "day(s)"
        '
        'lblDuration
        '
        Me.lblDuration.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblDuration.Font = New System.Drawing.Font("Mongolian Baiti", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDuration.ForeColor = System.Drawing.Color.Maroon
        Me.lblDuration.Location = New System.Drawing.Point(172, 96)
        Me.lblDuration.Name = "lblDuration"
        Me.lblDuration.Size = New System.Drawing.Size(44, 28)
        Me.lblDuration.TabIndex = 28
        Me.lblDuration.Text = "14"
        Me.lblDuration.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label4
        '
        Me.Label4.Font = New System.Drawing.Font("Mongolian Baiti", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.Maroon
        Me.Label4.Location = New System.Drawing.Point(59, 98)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(108, 23)
        Me.Label4.TabIndex = 27
        Me.Label4.Text = "Duration: "
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label1
        '
        Me.Label1.Font = New System.Drawing.Font("Mongolian Baiti", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Maroon
        Me.Label1.Location = New System.Drawing.Point(59, 52)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(121, 23)
        Me.Label1.TabIndex = 24
        Me.Label1.Text = "Loan Start Date: "
        '
        'btnLoan
        '
        Me.btnLoan.BackColor = System.Drawing.Color.WhiteSmoke
        Me.btnLoan.Enabled = False
        Me.btnLoan.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnLoan.Font = New System.Drawing.Font("Mongolian Baiti", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnLoan.ForeColor = System.Drawing.Color.Black
        Me.btnLoan.Location = New System.Drawing.Point(328, 152)
        Me.btnLoan.Name = "btnLoan"
        Me.btnLoan.Size = New System.Drawing.Size(124, 35)
        Me.btnLoan.TabIndex = 16
        Me.btnLoan.Text = "&Loan"
        Me.btnLoan.UseVisualStyleBackColor = False
        '
        'grpSelectedBooks
        '
        Me.grpSelectedBooks.Controls.Add(Me.Label12)
        Me.grpSelectedBooks.Controls.Add(Me.Label3)
        Me.grpSelectedBooks.Controls.Add(Me.lblCount)
        Me.grpSelectedBooks.Controls.Add(Me.lstSelectedBooks)
        Me.grpSelectedBooks.Controls.Add(Me.btnDelete)
        Me.grpSelectedBooks.Enabled = False
        Me.grpSelectedBooks.Font = New System.Drawing.Font("Mongolian Baiti", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.grpSelectedBooks.ForeColor = System.Drawing.Color.Maroon
        Me.grpSelectedBooks.Location = New System.Drawing.Point(623, 338)
        Me.grpSelectedBooks.Name = "grpSelectedBooks"
        Me.grpSelectedBooks.Size = New System.Drawing.Size(534, 283)
        Me.grpSelectedBooks.TabIndex = 2
        Me.grpSelectedBooks.TabStop = False
        Me.grpSelectedBooks.Text = "Selected Book(s): "
        '
        'Label12
        '
        Me.Label12.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label12.Font = New System.Drawing.Font("Mongolian Baiti", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.ForeColor = System.Drawing.Color.Maroon
        Me.Label12.Location = New System.Drawing.Point(179, 18)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(308, 28)
        Me.Label12.TabIndex = 51
        Me.Label12.Text = "Book Title"
        Me.Label12.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label3
        '
        Me.Label3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label3.Font = New System.Drawing.Font("Mongolian Baiti", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.Maroon
        Me.Label3.Location = New System.Drawing.Point(44, 18)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(134, 28)
        Me.Label3.TabIndex = 50
        Me.Label3.Text = "ISBN"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblCount
        '
        Me.lblCount.Font = New System.Drawing.Font("Mongolian Baiti", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCount.ForeColor = System.Drawing.Color.Maroon
        Me.lblCount.Location = New System.Drawing.Point(58, 250)
        Me.lblCount.Name = "lblCount"
        Me.lblCount.Size = New System.Drawing.Size(162, 23)
        Me.lblCount.TabIndex = 15
        Me.lblCount.Text = "0 books to borrow"
        '
        'lstSelectedBooks
        '
        Me.lstSelectedBooks.Font = New System.Drawing.Font("Mongolian Baiti", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lstSelectedBooks.ForeColor = System.Drawing.Color.Black
        Me.lstSelectedBooks.FormattingEnabled = True
        Me.lstSelectedBooks.ItemHeight = 15
        Me.lstSelectedBooks.Location = New System.Drawing.Point(43, 48)
        Me.lstSelectedBooks.Name = "lstSelectedBooks"
        Me.lstSelectedBooks.Size = New System.Drawing.Size(446, 169)
        Me.lstSelectedBooks.TabIndex = 0
        '
        'btnDelete
        '
        Me.btnDelete.BackColor = System.Drawing.Color.WhiteSmoke
        Me.btnDelete.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnDelete.Font = New System.Drawing.Font("Mongolian Baiti", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnDelete.ForeColor = System.Drawing.Color.Black
        Me.btnDelete.Location = New System.Drawing.Point(361, 238)
        Me.btnDelete.Name = "btnDelete"
        Me.btnDelete.Size = New System.Drawing.Size(124, 35)
        Me.btnDelete.TabIndex = 0
        Me.btnDelete.Text = "&Delete"
        Me.btnDelete.UseVisualStyleBackColor = False
        '
        'grpBookDetails
        '
        Me.grpBookDetails.Controls.Add(Me.mskISBN)
        Me.grpBookDetails.Controls.Add(Me.lblAuthor)
        Me.grpBookDetails.Controls.Add(Me.lblTitle)
        Me.grpBookDetails.Controls.Add(Me.btnSearchISBN)
        Me.grpBookDetails.Controls.Add(Me.lblCallNumber)
        Me.grpBookDetails.Controls.Add(Me.btnAddToList)
        Me.grpBookDetails.Controls.Add(Me.Label10)
        Me.grpBookDetails.Controls.Add(Me.Label6)
        Me.grpBookDetails.Controls.Add(Me.Label7)
        Me.grpBookDetails.Controls.Add(Me.Label9)
        Me.grpBookDetails.Enabled = False
        Me.grpBookDetails.Font = New System.Drawing.Font("Mongolian Baiti", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.grpBookDetails.ForeColor = System.Drawing.Color.Maroon
        Me.grpBookDetails.Location = New System.Drawing.Point(11, 338)
        Me.grpBookDetails.Margin = New System.Windows.Forms.Padding(2)
        Me.grpBookDetails.Name = "grpBookDetails"
        Me.grpBookDetails.Padding = New System.Windows.Forms.Padding(2)
        Me.grpBookDetails.Size = New System.Drawing.Size(590, 283)
        Me.grpBookDetails.TabIndex = 1
        Me.grpBookDetails.TabStop = False
        Me.grpBookDetails.Text = "Book's Details: "
        '
        'mskISBN
        '
        Me.mskISBN.Font = New System.Drawing.Font("Mongolian Baiti", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.mskISBN.ForeColor = System.Drawing.Color.Black
        Me.mskISBN.Location = New System.Drawing.Point(194, 54)
        Me.mskISBN.Margin = New System.Windows.Forms.Padding(2)
        Me.mskISBN.Mask = "0000000000000"
        Me.mskISBN.Name = "mskISBN"
        Me.mskISBN.Size = New System.Drawing.Size(125, 23)
        Me.mskISBN.TabIndex = 0
        '
        'lblAuthor
        '
        Me.lblAuthor.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblAuthor.Font = New System.Drawing.Font("Mongolian Baiti", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblAuthor.ForeColor = System.Drawing.Color.Maroon
        Me.lblAuthor.Location = New System.Drawing.Point(162, 221)
        Me.lblAuthor.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblAuthor.Name = "lblAuthor"
        Me.lblAuthor.Size = New System.Drawing.Size(181, 22)
        Me.lblAuthor.TabIndex = 15
        Me.lblAuthor.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblTitle
        '
        Me.lblTitle.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblTitle.Font = New System.Drawing.Font("Mongolian Baiti", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTitle.ForeColor = System.Drawing.Color.Maroon
        Me.lblTitle.Location = New System.Drawing.Point(162, 166)
        Me.lblTitle.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblTitle.Name = "lblTitle"
        Me.lblTitle.Size = New System.Drawing.Size(181, 22)
        Me.lblTitle.TabIndex = 14
        Me.lblTitle.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'btnSearchISBN
        '
        Me.btnSearchISBN.BackColor = System.Drawing.Color.WhiteSmoke
        Me.btnSearchISBN.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnSearchISBN.Font = New System.Drawing.Font("Mongolian Baiti", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSearchISBN.ForeColor = System.Drawing.Color.Black
        Me.btnSearchISBN.Location = New System.Drawing.Point(350, 48)
        Me.btnSearchISBN.Margin = New System.Windows.Forms.Padding(2)
        Me.btnSearchISBN.Name = "btnSearchISBN"
        Me.btnSearchISBN.Size = New System.Drawing.Size(124, 35)
        Me.btnSearchISBN.TabIndex = 1
        Me.btnSearchISBN.Text = "Search I&SBN"
        Me.btnSearchISBN.UseVisualStyleBackColor = False
        '
        'lblCallNumber
        '
        Me.lblCallNumber.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblCallNumber.Font = New System.Drawing.Font("Mongolian Baiti", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCallNumber.ForeColor = System.Drawing.Color.Maroon
        Me.lblCallNumber.Location = New System.Drawing.Point(162, 117)
        Me.lblCallNumber.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblCallNumber.Name = "lblCallNumber"
        Me.lblCallNumber.Size = New System.Drawing.Size(181, 22)
        Me.lblCallNumber.TabIndex = 13
        Me.lblCallNumber.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'btnAddToList
        '
        Me.btnAddToList.BackColor = System.Drawing.Color.WhiteSmoke
        Me.btnAddToList.Enabled = False
        Me.btnAddToList.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnAddToList.Font = New System.Drawing.Font("Mongolian Baiti", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAddToList.ForeColor = System.Drawing.Color.Black
        Me.btnAddToList.Location = New System.Drawing.Point(350, 216)
        Me.btnAddToList.Margin = New System.Windows.Forms.Padding(2)
        Me.btnAddToList.Name = "btnAddToList"
        Me.btnAddToList.Size = New System.Drawing.Size(124, 35)
        Me.btnAddToList.TabIndex = 2
        Me.btnAddToList.Text = "&Add to List"
        Me.btnAddToList.UseVisualStyleBackColor = False
        '
        'Label10
        '
        Me.Label10.Font = New System.Drawing.Font("Mongolian Baiti", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.ForeColor = System.Drawing.Color.Maroon
        Me.Label10.Location = New System.Drawing.Point(64, 57)
        Me.Label10.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(130, 32)
        Me.Label10.TabIndex = 45
        Me.Label10.Text = "Insert ISBN Number: "
        '
        'Label6
        '
        Me.Label6.Font = New System.Drawing.Font("Mongolian Baiti", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.Maroon
        Me.Label6.Location = New System.Drawing.Point(68, 166)
        Me.Label6.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(89, 22)
        Me.Label6.TabIndex = 6
        Me.Label6.Text = "Title: "
        Me.Label6.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label7
        '
        Me.Label7.Font = New System.Drawing.Font("Mongolian Baiti", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.Color.Maroon
        Me.Label7.Location = New System.Drawing.Point(68, 117)
        Me.Label7.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(89, 22)
        Me.Label7.TabIndex = 5
        Me.Label7.Text = "Call Number: "
        Me.Label7.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label9
        '
        Me.Label9.Font = New System.Drawing.Font("Mongolian Baiti", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.ForeColor = System.Drawing.Color.Maroon
        Me.Label9.Location = New System.Drawing.Point(68, 223)
        Me.Label9.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(89, 20)
        Me.Label9.TabIndex = 7
        Me.Label9.Text = "Author: "
        Me.Label9.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label11
        '
        Me.Label11.Font = New System.Drawing.Font("Mongolian Baiti", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.ForeColor = System.Drawing.Color.Maroon
        Me.Label11.Location = New System.Drawing.Point(157, 18)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(119, 23)
        Me.Label11.TabIndex = 48
        Me.Label11.Text = "Student's Name: "
        Me.Label11.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblStudentName
        '
        Me.lblStudentName.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblStudentName.Font = New System.Drawing.Font("Mongolian Baiti", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblStudentName.ForeColor = System.Drawing.Color.Maroon
        Me.lblStudentName.Location = New System.Drawing.Point(149, 41)
        Me.lblStudentName.Name = "lblStudentName"
        Me.lblStudentName.Size = New System.Drawing.Size(134, 28)
        Me.lblStudentName.TabIndex = 49
        Me.lblStudentName.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'btnSearchStudentID
        '
        Me.btnSearchStudentID.BackColor = System.Drawing.Color.WhiteSmoke
        Me.btnSearchStudentID.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnSearchStudentID.Font = New System.Drawing.Font("Mongolian Baiti", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSearchStudentID.ForeColor = System.Drawing.Color.Black
        Me.btnSearchStudentID.Location = New System.Drawing.Point(292, 33)
        Me.btnSearchStudentID.Margin = New System.Windows.Forms.Padding(2)
        Me.btnSearchStudentID.Name = "btnSearchStudentID"
        Me.btnSearchStudentID.Size = New System.Drawing.Size(149, 35)
        Me.btnSearchStudentID.TabIndex = 1
        Me.btnSearchStudentID.Text = "&Search Student's ID"
        Me.btnSearchStudentID.UseVisualStyleBackColor = False
        '
        'grpLoanHistory
        '
        Me.grpLoanHistory.Controls.Add(Me.btnClear)
        Me.grpLoanHistory.Controls.Add(Me.mskStudentID)
        Me.grpLoanHistory.Controls.Add(Me.CirculationDataGridView)
        Me.grpLoanHistory.Controls.Add(Me.btnSearchStudentID)
        Me.grpLoanHistory.Controls.Add(Me.lblStudentName)
        Me.grpLoanHistory.Controls.Add(Me.Label11)
        Me.grpLoanHistory.Controls.Add(Me.Label8)
        Me.grpLoanHistory.Font = New System.Drawing.Font("Mongolian Baiti", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.grpLoanHistory.ForeColor = System.Drawing.Color.Maroon
        Me.grpLoanHistory.Location = New System.Drawing.Point(11, 26)
        Me.grpLoanHistory.Margin = New System.Windows.Forms.Padding(2)
        Me.grpLoanHistory.Name = "grpLoanHistory"
        Me.grpLoanHistory.Padding = New System.Windows.Forms.Padding(2)
        Me.grpLoanHistory.Size = New System.Drawing.Size(590, 283)
        Me.grpLoanHistory.TabIndex = 0
        Me.grpLoanHistory.TabStop = False
        Me.grpLoanHistory.Text = "Loan History"
        '
        'btnClear
        '
        Me.btnClear.BackColor = System.Drawing.Color.WhiteSmoke
        Me.btnClear.Enabled = False
        Me.btnClear.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnClear.Font = New System.Drawing.Font("Mongolian Baiti", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnClear.ForeColor = System.Drawing.Color.Black
        Me.btnClear.Location = New System.Drawing.Point(445, 33)
        Me.btnClear.Margin = New System.Windows.Forms.Padding(2)
        Me.btnClear.Name = "btnClear"
        Me.btnClear.Size = New System.Drawing.Size(124, 35)
        Me.btnClear.TabIndex = 51
        Me.btnClear.Text = "&Clear Student's ID"
        Me.btnClear.UseVisualStyleBackColor = False
        '
        'mskStudentID
        '
        Me.mskStudentID.Font = New System.Drawing.Font("Mongolian Baiti", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.mskStudentID.ForeColor = System.Drawing.Color.Black
        Me.mskStudentID.Location = New System.Drawing.Point(17, 44)
        Me.mskStudentID.Margin = New System.Windows.Forms.Padding(2)
        Me.mskStudentID.Mask = "00>LLL00000"
        Me.mskStudentID.Name = "mskStudentID"
        Me.mskStudentID.Size = New System.Drawing.Size(125, 23)
        Me.mskStudentID.TabIndex = 1
        '
        'CirculationDataGridView
        '
        Me.CirculationDataGridView.AllowUserToAddRows = False
        Me.CirculationDataGridView.AllowUserToDeleteRows = False
        Me.CirculationDataGridView.AutoGenerateColumns = False
        Me.CirculationDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells
        Me.CirculationDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.CirculationDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn1, Me.DataGridViewTextBoxColumn2, Me.DataGridViewTextBoxColumn3})
        Me.CirculationDataGridView.DataSource = Me.CirculationBindingSource
        Me.CirculationDataGridView.Location = New System.Drawing.Point(4, 82)
        Me.CirculationDataGridView.Margin = New System.Windows.Forms.Padding(2)
        Me.CirculationDataGridView.Name = "CirculationDataGridView"
        Me.CirculationDataGridView.ReadOnly = True
        Me.CirculationDataGridView.RowTemplate.Height = 24
        Me.CirculationDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.CirculationDataGridView.Size = New System.Drawing.Size(561, 179)
        Me.CirculationDataGridView.TabIndex = 50
        '
        'DataGridViewTextBoxColumn1
        '
        Me.DataGridViewTextBoxColumn1.DataPropertyName = "Student ID"
        Me.DataGridViewTextBoxColumn1.HeaderText = "Student ID"
        Me.DataGridViewTextBoxColumn1.Name = "DataGridViewTextBoxColumn1"
        Me.DataGridViewTextBoxColumn1.ReadOnly = True
        Me.DataGridViewTextBoxColumn1.Width = 94
        '
        'DataGridViewTextBoxColumn2
        '
        Me.DataGridViewTextBoxColumn2.DataPropertyName = "ISBN"
        Me.DataGridViewTextBoxColumn2.HeaderText = "ISBN"
        Me.DataGridViewTextBoxColumn2.Name = "DataGridViewTextBoxColumn2"
        Me.DataGridViewTextBoxColumn2.ReadOnly = True
        Me.DataGridViewTextBoxColumn2.Width = 64
        '
        'DataGridViewTextBoxColumn3
        '
        Me.DataGridViewTextBoxColumn3.DataPropertyName = "Loan Date"
        Me.DataGridViewTextBoxColumn3.HeaderText = "Loan Date"
        Me.DataGridViewTextBoxColumn3.Name = "DataGridViewTextBoxColumn3"
        Me.DataGridViewTextBoxColumn3.ReadOnly = True
        Me.DataGridViewTextBoxColumn3.Width = 91
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
        Me.CirculationBindingNavigator.Size = New System.Drawing.Size(974, 22)
        Me.CirculationBindingNavigator.TabIndex = 54
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
        Me.BindingNavigatorPositionItem.Font = New System.Drawing.Font("Segoe UI", 9.0!)
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
        'LoanSummary
        '
        Me.AcceptButton = Me.btnSearchStudentID
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.AntiqueWhite
        Me.ClientSize = New System.Drawing.Size(1182, 631)
        Me.Controls.Add(Me.CirculationBindingNavigator)
        Me.Controls.Add(Me.grpLoanHistory)
        Me.Controls.Add(Me.grpBookDetails)
        Me.Controls.Add(Me.grpLoanSummary)
        Me.Controls.Add(Me.grpSelectedBooks)
        Me.ForeColor = System.Drawing.Color.Maroon
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(2)
        Me.MaximizeBox = False
        Me.Name = "LoanSummary"
        Me.Text = "Loan Summary"
        Me.grpLoanSummary.ResumeLayout(False)
        Me.grpSelectedBooks.ResumeLayout(False)
        Me.grpBookDetails.ResumeLayout(False)
        Me.grpBookDetails.PerformLayout()
        Me.grpLoanHistory.ResumeLayout(False)
        Me.grpLoanHistory.PerformLayout()
        CType(Me.CirculationDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CirculationBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TRACE_Library_SystemDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CirculationBindingNavigator, System.ComponentModel.ISupportInitialize).EndInit()
        Me.CirculationBindingNavigator.ResumeLayout(False)
        Me.CirculationBindingNavigator.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label8 As Label
    Friend WithEvents grpLoanSummary As GroupBox
    Friend WithEvents Label5 As Label
    Friend WithEvents lblDuration As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents btnLoan As Button
    Friend WithEvents grpSelectedBooks As GroupBox
    Friend WithEvents lblCount As Label
    Friend WithEvents lstSelectedBooks As ListBox
    Friend WithEvents btnDelete As Button
    Friend WithEvents grpBookDetails As GroupBox
    Friend WithEvents lblAuthor As Label
    Friend WithEvents lblTitle As Label
    Friend WithEvents lblCallNumber As Label
    Friend WithEvents btnAddToList As Button
    Friend WithEvents Label6 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents Label11 As Label
    Friend WithEvents lblStudentName As Label
    Friend WithEvents LoanStartDate As DateTimePicker
    Friend WithEvents ReturnDueDate As DateTimePicker
    Friend WithEvents Label2 As Label
    Friend WithEvents btnSearchStudentID As Button
    Friend WithEvents btnSearchISBN As Button
    Friend WithEvents grpLoanHistory As GroupBox
    Friend WithEvents Label12 As Label
    Friend WithEvents Label3 As Label
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
    Friend WithEvents mskISBN As MaskedTextBox
    Friend WithEvents mskStudentID As MaskedTextBox
    Friend WithEvents btnClear As Button
    Friend WithEvents Label13 As Label
End Class
