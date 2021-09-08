<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class LoginReport
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(LoginReport))
        Me.LoginDataGridView = New System.Windows.Forms.DataGridView()
        Me.StaffIDDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.LogInDateAndTimeDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.LogOutDateAndTimeDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.LoginRecordBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.TracE_Library_SystemDataSet1 = New TRACE_Library_System_Kenneth_RMM2S1G1_202005_BAIT1083.TRACE_Library_SystemDataSet()
        Me.btnGenerate = New System.Windows.Forms.Button()
        Me.btnReturnToReportMenu = New System.Windows.Forms.Button()
        Me.btnPreviewReportandPrint = New System.Windows.Forms.Button()
        Me.DateTimePicker = New System.Windows.Forms.DateTimePicker()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.dlgPreviewLoginReport = New System.Windows.Forms.PrintPreviewDialog()
        Me.docPrintLoginReport = New System.Drawing.Printing.PrintDocument()
        Me.LoginRecordTableAdapter1 = New TRACE_Library_System_Kenneth_RMM2S1G1_202005_BAIT1083.TRACE_Library_SystemDataSetTableAdapters.LoginRecordTableAdapter()
        Me.lblCount = New System.Windows.Forms.Label()
        CType(Me.LoginDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LoginRecordBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TracE_Library_SystemDataSet1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'LoginDataGridView
        '
        Me.LoginDataGridView.AllowUserToAddRows = False
        Me.LoginDataGridView.AllowUserToDeleteRows = False
        Me.LoginDataGridView.AllowUserToResizeColumns = False
        Me.LoginDataGridView.AllowUserToResizeRows = False
        Me.LoginDataGridView.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.LoginDataGridView.AutoGenerateColumns = False
        Me.LoginDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells
        Me.LoginDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.LoginDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.StaffIDDataGridViewTextBoxColumn, Me.DataGridViewTextBoxColumn1, Me.LogInDateAndTimeDataGridViewTextBoxColumn, Me.LogOutDateAndTimeDataGridViewTextBoxColumn})
        Me.LoginDataGridView.DataMember = "LoginRecord"
        Me.LoginDataGridView.DataSource = Me.LoginRecordBindingSource
        Me.LoginDataGridView.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically
        Me.LoginDataGridView.Location = New System.Drawing.Point(104, 143)
        Me.LoginDataGridView.Name = "LoginDataGridView"
        Me.LoginDataGridView.ReadOnly = True
        Me.LoginDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.LoginDataGridView.Size = New System.Drawing.Size(594, 237)
        Me.LoginDataGridView.TabIndex = 3
        '
        'StaffIDDataGridViewTextBoxColumn
        '
        Me.StaffIDDataGridViewTextBoxColumn.DataPropertyName = "Staff ID"
        Me.StaffIDDataGridViewTextBoxColumn.HeaderText = "Staff ID"
        Me.StaffIDDataGridViewTextBoxColumn.Name = "StaffIDDataGridViewTextBoxColumn"
        Me.StaffIDDataGridViewTextBoxColumn.ReadOnly = True
        Me.StaffIDDataGridViewTextBoxColumn.Width = 63
        '
        'DataGridViewTextBoxColumn1
        '
        Me.DataGridViewTextBoxColumn1.DataPropertyName = "Staff Name"
        Me.DataGridViewTextBoxColumn1.HeaderText = "Staff Name"
        Me.DataGridViewTextBoxColumn1.Name = "DataGridViewTextBoxColumn1"
        Me.DataGridViewTextBoxColumn1.ReadOnly = True
        Me.DataGridViewTextBoxColumn1.Width = 78
        '
        'LogInDateAndTimeDataGridViewTextBoxColumn
        '
        Me.LogInDateAndTimeDataGridViewTextBoxColumn.DataPropertyName = "Log in Date and Time"
        Me.LogInDateAndTimeDataGridViewTextBoxColumn.HeaderText = "Log in Date and Time"
        Me.LogInDateAndTimeDataGridViewTextBoxColumn.Name = "LogInDateAndTimeDataGridViewTextBoxColumn"
        Me.LogInDateAndTimeDataGridViewTextBoxColumn.ReadOnly = True
        Me.LogInDateAndTimeDataGridViewTextBoxColumn.Width = 102
        '
        'LogOutDateAndTimeDataGridViewTextBoxColumn
        '
        Me.LogOutDateAndTimeDataGridViewTextBoxColumn.DataPropertyName = "Log out Date and Time"
        Me.LogOutDateAndTimeDataGridViewTextBoxColumn.HeaderText = "Log out Date and Time"
        Me.LogOutDateAndTimeDataGridViewTextBoxColumn.Name = "LogOutDateAndTimeDataGridViewTextBoxColumn"
        Me.LogOutDateAndTimeDataGridViewTextBoxColumn.ReadOnly = True
        Me.LogOutDateAndTimeDataGridViewTextBoxColumn.Width = 108
        '
        'LoginRecordBindingSource
        '
        Me.LoginRecordBindingSource.DataSource = Me.TracE_Library_SystemDataSet1
        Me.LoginRecordBindingSource.Position = 0
        '
        'TracE_Library_SystemDataSet1
        '
        Me.TracE_Library_SystemDataSet1.DataSetName = "TRACE_Library_SystemDataSet"
        Me.TracE_Library_SystemDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'btnGenerate
        '
        Me.btnGenerate.BackColor = System.Drawing.Color.WhiteSmoke
        Me.btnGenerate.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnGenerate.Font = New System.Drawing.Font("Mongolian Baiti", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnGenerate.Location = New System.Drawing.Point(104, 93)
        Me.btnGenerate.Name = "btnGenerate"
        Me.btnGenerate.Size = New System.Drawing.Size(108, 44)
        Me.btnGenerate.TabIndex = 2
        Me.btnGenerate.Text = "&Generate"
        Me.btnGenerate.UseVisualStyleBackColor = False
        '
        'btnReturnToReportMenu
        '
        Me.btnReturnToReportMenu.BackColor = System.Drawing.Color.WhiteSmoke
        Me.btnReturnToReportMenu.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btnReturnToReportMenu.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnReturnToReportMenu.Font = New System.Drawing.Font("Mongolian Baiti", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnReturnToReportMenu.Location = New System.Drawing.Point(590, 93)
        Me.btnReturnToReportMenu.Name = "btnReturnToReportMenu"
        Me.btnReturnToReportMenu.Size = New System.Drawing.Size(108, 44)
        Me.btnReturnToReportMenu.TabIndex = 6
        Me.btnReturnToReportMenu.Text = "R&eturn to Report Menu"
        Me.btnReturnToReportMenu.UseVisualStyleBackColor = False
        '
        'btnPreviewReportandPrint
        '
        Me.btnPreviewReportandPrint.BackColor = System.Drawing.Color.WhiteSmoke
        Me.btnPreviewReportandPrint.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnPreviewReportandPrint.Font = New System.Drawing.Font("Mongolian Baiti", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnPreviewReportandPrint.Location = New System.Drawing.Point(232, 93)
        Me.btnPreviewReportandPrint.Name = "btnPreviewReportandPrint"
        Me.btnPreviewReportandPrint.Size = New System.Drawing.Size(108, 44)
        Me.btnPreviewReportandPrint.TabIndex = 5
        Me.btnPreviewReportandPrint.Text = "&Preview and Print Report"
        Me.btnPreviewReportandPrint.UseVisualStyleBackColor = False
        '
        'DateTimePicker
        '
        Me.DateTimePicker.CustomFormat = "MMMM  -   yyyy"
        Me.DateTimePicker.Font = New System.Drawing.Font("Mongolian Baiti", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.DateTimePicker.Location = New System.Drawing.Point(392, 35)
        Me.DateTimePicker.Name = "DateTimePicker"
        Me.DateTimePicker.ShowUpDown = True
        Me.DateTimePicker.Size = New System.Drawing.Size(144, 23)
        Me.DateTimePicker.TabIndex = 1
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Mongolian Baiti", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Maroon
        Me.Label1.Location = New System.Drawing.Point(101, 37)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(288, 16)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Log In Record In The Month and Year Of : "
        '
        'dlgPreviewLoginReport
        '
        Me.dlgPreviewLoginReport.AutoScrollMargin = New System.Drawing.Size(0, 0)
        Me.dlgPreviewLoginReport.AutoScrollMinSize = New System.Drawing.Size(0, 0)
        Me.dlgPreviewLoginReport.ClientSize = New System.Drawing.Size(400, 300)
        Me.dlgPreviewLoginReport.Enabled = True
        Me.dlgPreviewLoginReport.Icon = CType(resources.GetObject("dlgPreviewLoginReport.Icon"), System.Drawing.Icon)
        Me.dlgPreviewLoginReport.Name = "PrintPreviewDialog1"
        Me.dlgPreviewLoginReport.Visible = False
        '
        'docPrintLoginReport
        '
        '
        'LoginRecordTableAdapter1
        '
        Me.LoginRecordTableAdapter1.ClearBeforeFill = True
        '
        'lblCount
        '
        Me.lblCount.AutoSize = True
        Me.lblCount.Font = New System.Drawing.Font("Mongolian Baiti", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCount.ForeColor = System.Drawing.Color.Maroon
        Me.lblCount.Location = New System.Drawing.Point(101, 399)
        Me.lblCount.Name = "lblCount"
        Me.lblCount.Size = New System.Drawing.Size(184, 16)
        Me.lblCount.TabIndex = 4
        Me.lblCount.Text = "0 Logins In Selected Month"
        '
        'LoginReport
        '
        Me.AcceptButton = Me.btnGenerate
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.AntiqueWhite
        Me.CancelButton = Me.btnReturnToReportMenu
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.lblCount)
        Me.Controls.Add(Me.LoginDataGridView)
        Me.Controls.Add(Me.btnGenerate)
        Me.Controls.Add(Me.btnReturnToReportMenu)
        Me.Controls.Add(Me.btnPreviewReportandPrint)
        Me.Controls.Add(Me.DateTimePicker)
        Me.Controls.Add(Me.Label1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.Name = "LoginReport"
        Me.Text = "LoginReport"
        CType(Me.LoginDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LoginRecordBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TracE_Library_SystemDataSet1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents LoginDataGridView As DataGridView
    Friend WithEvents btnGenerate As Button
    Friend WithEvents btnReturnToReportMenu As Button
    Friend WithEvents btnPreviewReportandPrint As Button
    Friend WithEvents DateTimePicker As DateTimePicker
    Friend WithEvents Label1 As Label
    Friend WithEvents TracE_Library_SystemDataSet1 As TRACE_Library_SystemDataSet
    Friend WithEvents LoginRecordTableAdapter1 As TRACE_Library_SystemDataSetTableAdapters.LoginRecordTableAdapter
    Friend WithEvents LoginRecordBindingSource As BindingSource
    Friend WithEvents dlgPreviewLoginReport As PrintPreviewDialog
    Friend WithEvents docPrintLoginReport As Printing.PrintDocument
    Friend WithEvents StaffIDDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn1 As DataGridViewTextBoxColumn
    Friend WithEvents LogInDateAndTimeDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents LogOutDateAndTimeDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents lblCount As Label
End Class
