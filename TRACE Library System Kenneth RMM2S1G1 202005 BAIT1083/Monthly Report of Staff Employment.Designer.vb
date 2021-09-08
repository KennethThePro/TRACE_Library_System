<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Monthly_Report_of_Staff_Employment
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Monthly_Report_of_Staff_Employment))
        Me.btnGenerate = New System.Windows.Forms.Button()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.btnReturnToReportGeneration = New System.Windows.Forms.Button()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.btnPreviewReportandPrint = New System.Windows.Forms.Button()
        Me.DateTimePickerForEmployed = New System.Windows.Forms.DateTimePicker()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.StaffDataGridView = New System.Windows.Forms.DataGridView()
        Me.StaffIDDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.StaffNameDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.StaffPhoneNumberDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.StaffEmailDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.UserTypeDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DateOfEmploymentDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.StaffBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.TRACE_Library_SystemDataSet = New TRACE_Library_System_Kenneth_RMM2S1G1_202005_BAIT1083.TRACE_Library_SystemDataSet()
        Me.StaffTableAdapter = New TRACE_Library_System_Kenneth_RMM2S1G1_202005_BAIT1083.TRACE_Library_SystemDataSetTableAdapters.StaffTableAdapter()
        Me.dlgPreviewReport = New System.Windows.Forms.PrintPreviewDialog()
        Me.docPrintReport = New System.Drawing.Printing.PrintDocument()
        Me.ToolTipForMonthlyReport = New System.Windows.Forms.ToolTip(Me.components)
        Me.lblCount = New System.Windows.Forms.Label()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.StaffDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.StaffBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TRACE_Library_SystemDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btnGenerate
        '
        Me.btnGenerate.BackColor = System.Drawing.Color.WhiteSmoke
        Me.btnGenerate.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnGenerate.Font = New System.Drawing.Font("Mongolian Baiti", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnGenerate.Location = New System.Drawing.Point(132, 81)
        Me.btnGenerate.Name = "btnGenerate"
        Me.btnGenerate.Size = New System.Drawing.Size(108, 54)
        Me.btnGenerate.TabIndex = 2
        Me.btnGenerate.Text = "&Generate"
        Me.ToolTipForMonthlyReport.SetToolTip(Me.btnGenerate, "Generate a report based on the Month and Year Selection")
        Me.btnGenerate.UseVisualStyleBackColor = False
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.TRACE_Library_System_Kenneth_RMM2S1G1_202005_BAIT1083.My.Resources.Resources.report_icon1
        Me.PictureBox1.Location = New System.Drawing.Point(81, 81)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(42, 37)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 33
        Me.PictureBox1.TabStop = False
        '
        'btnReturnToReportGeneration
        '
        Me.btnReturnToReportGeneration.BackColor = System.Drawing.Color.WhiteSmoke
        Me.btnReturnToReportGeneration.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btnReturnToReportGeneration.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnReturnToReportGeneration.Font = New System.Drawing.Font("Mongolian Baiti", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnReturnToReportGeneration.Location = New System.Drawing.Point(614, 85)
        Me.btnReturnToReportGeneration.Name = "btnReturnToReportGeneration"
        Me.btnReturnToReportGeneration.Size = New System.Drawing.Size(108, 54)
        Me.btnReturnToReportGeneration.TabIndex = 6
        Me.btnReturnToReportGeneration.Text = "R&eturn to Report Generation"
        Me.ToolTipForMonthlyReport.SetToolTip(Me.btnReturnToReportGeneration, "Return back to the Staff Management Menu")
        Me.btnReturnToReportGeneration.UseVisualStyleBackColor = False
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(78, 146)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(129, 13)
        Me.Label3.TabIndex = 31
        Me.Label3.Text = "Staff Currenty Employed : "
        '
        'btnPreviewReportandPrint
        '
        Me.btnPreviewReportandPrint.BackColor = System.Drawing.Color.WhiteSmoke
        Me.btnPreviewReportandPrint.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnPreviewReportandPrint.Font = New System.Drawing.Font("Mongolian Baiti", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnPreviewReportandPrint.Location = New System.Drawing.Point(261, 81)
        Me.btnPreviewReportandPrint.Name = "btnPreviewReportandPrint"
        Me.btnPreviewReportandPrint.Size = New System.Drawing.Size(108, 54)
        Me.btnPreviewReportandPrint.TabIndex = 5
        Me.btnPreviewReportandPrint.Text = "&Preview Report and Print"
        Me.ToolTipForMonthlyReport.SetToolTip(Me.btnPreviewReportandPrint, "Preview the Report and Print Out the Report")
        Me.btnPreviewReportandPrint.UseVisualStyleBackColor = False
        '
        'DateTimePickerForEmployed
        '
        Me.DateTimePickerForEmployed.CustomFormat = "MMMM -   yyyy"
        Me.DateTimePickerForEmployed.Font = New System.Drawing.Font("Mongolian Baiti", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DateTimePickerForEmployed.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.DateTimePickerForEmployed.Location = New System.Drawing.Point(417, 39)
        Me.DateTimePickerForEmployed.Name = "DateTimePickerForEmployed"
        Me.DateTimePickerForEmployed.ShowUpDown = True
        Me.DateTimePickerForEmployed.Size = New System.Drawing.Size(142, 23)
        Me.DateTimePickerForEmployed.TabIndex = 1
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Mongolian Baiti", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Maroon
        Me.Label1.Location = New System.Drawing.Point(130, 41)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(294, 16)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Staff Employed In The Month and Year Of : "
        '
        'StaffDataGridView
        '
        Me.StaffDataGridView.AllowUserToAddRows = False
        Me.StaffDataGridView.AllowUserToDeleteRows = False
        Me.StaffDataGridView.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.StaffDataGridView.AutoGenerateColumns = False
        Me.StaffDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells
        Me.StaffDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.StaffDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.StaffIDDataGridViewTextBoxColumn, Me.StaffNameDataGridViewTextBoxColumn, Me.StaffPhoneNumberDataGridViewTextBoxColumn, Me.StaffEmailDataGridViewTextBoxColumn, Me.UserTypeDataGridViewTextBoxColumn, Me.DateOfEmploymentDataGridViewTextBoxColumn})
        Me.StaffDataGridView.DataSource = Me.StaffBindingSource
        Me.StaffDataGridView.Location = New System.Drawing.Point(81, 146)
        Me.StaffDataGridView.Name = "StaffDataGridView"
        Me.StaffDataGridView.ReadOnly = True
        Me.StaffDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.StaffDataGridView.Size = New System.Drawing.Size(640, 228)
        Me.StaffDataGridView.TabIndex = 3
        '
        'StaffIDDataGridViewTextBoxColumn
        '
        Me.StaffIDDataGridViewTextBoxColumn.DataPropertyName = "Staff ID"
        Me.StaffIDDataGridViewTextBoxColumn.HeaderText = "Staff ID"
        Me.StaffIDDataGridViewTextBoxColumn.Name = "StaffIDDataGridViewTextBoxColumn"
        Me.StaffIDDataGridViewTextBoxColumn.ReadOnly = True
        Me.StaffIDDataGridViewTextBoxColumn.Width = 63
        '
        'StaffNameDataGridViewTextBoxColumn
        '
        Me.StaffNameDataGridViewTextBoxColumn.DataPropertyName = "Staff Name"
        Me.StaffNameDataGridViewTextBoxColumn.HeaderText = "Staff Name"
        Me.StaffNameDataGridViewTextBoxColumn.Name = "StaffNameDataGridViewTextBoxColumn"
        Me.StaffNameDataGridViewTextBoxColumn.ReadOnly = True
        Me.StaffNameDataGridViewTextBoxColumn.Width = 78
        '
        'StaffPhoneNumberDataGridViewTextBoxColumn
        '
        Me.StaffPhoneNumberDataGridViewTextBoxColumn.DataPropertyName = "Staff Phone Number"
        Me.StaffPhoneNumberDataGridViewTextBoxColumn.HeaderText = "Staff Phone Number"
        Me.StaffPhoneNumberDataGridViewTextBoxColumn.Name = "StaffPhoneNumberDataGridViewTextBoxColumn"
        Me.StaffPhoneNumberDataGridViewTextBoxColumn.ReadOnly = True
        Me.StaffPhoneNumberDataGridViewTextBoxColumn.Width = 117
        '
        'StaffEmailDataGridViewTextBoxColumn
        '
        Me.StaffEmailDataGridViewTextBoxColumn.DataPropertyName = "Staff Email"
        Me.StaffEmailDataGridViewTextBoxColumn.HeaderText = "Staff Email"
        Me.StaffEmailDataGridViewTextBoxColumn.Name = "StaffEmailDataGridViewTextBoxColumn"
        Me.StaffEmailDataGridViewTextBoxColumn.ReadOnly = True
        Me.StaffEmailDataGridViewTextBoxColumn.Width = 76
        '
        'UserTypeDataGridViewTextBoxColumn
        '
        Me.UserTypeDataGridViewTextBoxColumn.DataPropertyName = "User Type"
        Me.UserTypeDataGridViewTextBoxColumn.HeaderText = "User Type"
        Me.UserTypeDataGridViewTextBoxColumn.Name = "UserTypeDataGridViewTextBoxColumn"
        Me.UserTypeDataGridViewTextBoxColumn.ReadOnly = True
        Me.UserTypeDataGridViewTextBoxColumn.Width = 75
        '
        'DateOfEmploymentDataGridViewTextBoxColumn
        '
        Me.DateOfEmploymentDataGridViewTextBoxColumn.DataPropertyName = "Date Of Employment"
        Me.DateOfEmploymentDataGridViewTextBoxColumn.HeaderText = "Date Of Employment"
        Me.DateOfEmploymentDataGridViewTextBoxColumn.Name = "DateOfEmploymentDataGridViewTextBoxColumn"
        Me.DateOfEmploymentDataGridViewTextBoxColumn.ReadOnly = True
        Me.DateOfEmploymentDataGridViewTextBoxColumn.Width = 118
        '
        'StaffBindingSource
        '
        Me.StaffBindingSource.DataMember = "Staff"
        Me.StaffBindingSource.DataSource = Me.TRACE_Library_SystemDataSet
        '
        'TRACE_Library_SystemDataSet
        '
        Me.TRACE_Library_SystemDataSet.DataSetName = "TRACE_Library_SystemDataSet"
        Me.TRACE_Library_SystemDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'StaffTableAdapter
        '
        Me.StaffTableAdapter.ClearBeforeFill = True
        '
        'dlgPreviewReport
        '
        Me.dlgPreviewReport.AutoScrollMargin = New System.Drawing.Size(0, 0)
        Me.dlgPreviewReport.AutoScrollMinSize = New System.Drawing.Size(0, 0)
        Me.dlgPreviewReport.ClientSize = New System.Drawing.Size(400, 300)
        Me.dlgPreviewReport.Enabled = True
        Me.dlgPreviewReport.Icon = CType(resources.GetObject("dlgPreviewReport.Icon"), System.Drawing.Icon)
        Me.dlgPreviewReport.Name = "dlgPreviewReport"
        Me.dlgPreviewReport.Visible = False
        '
        'docPrintReport
        '
        '
        'lblCount
        '
        Me.lblCount.AutoSize = True
        Me.lblCount.Font = New System.Drawing.Font("Mongolian Baiti", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCount.ForeColor = System.Drawing.Color.Maroon
        Me.lblCount.Location = New System.Drawing.Point(81, 394)
        Me.lblCount.Name = "lblCount"
        Me.lblCount.Size = New System.Drawing.Size(364, 16)
        Me.lblCount.TabIndex = 4
        Me.lblCount.Text = "0 Employed Staff Members In Selected Month and Year"
        '
        'Monthly_Report_of_Staff_Employment
        '
        Me.AcceptButton = Me.btnGenerate
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.AntiqueWhite
        Me.CancelButton = Me.btnReturnToReportGeneration
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.lblCount)
        Me.Controls.Add(Me.StaffDataGridView)
        Me.Controls.Add(Me.btnGenerate)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.btnReturnToReportGeneration)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.btnPreviewReportandPrint)
        Me.Controls.Add(Me.DateTimePickerForEmployed)
        Me.Controls.Add(Me.Label1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MinimizeBox = False
        Me.Name = "Monthly_Report_of_Staff_Employment"
        Me.Text = "Monthly Report of Staff Employment"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.StaffDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.StaffBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TRACE_Library_SystemDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btnGenerate As Button
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents btnReturnToReportGeneration As Button
    Friend WithEvents Label3 As Label
    Friend WithEvents btnPreviewReportandPrint As Button
    Friend WithEvents DateTimePickerForEmployed As DateTimePicker
    Friend WithEvents Label1 As Label
    Friend WithEvents StaffDataGridView As DataGridView
    Friend WithEvents TRACE_Library_SystemDataSet As TRACE_Library_SystemDataSet
    Friend WithEvents StaffBindingSource As BindingSource
    Friend WithEvents StaffTableAdapter As TRACE_Library_SystemDataSetTableAdapters.StaffTableAdapter
    Friend WithEvents StaffIDDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents StaffNameDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents StaffPhoneNumberDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents StaffEmailDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents UserTypeDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents DateOfEmploymentDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents dlgPreviewReport As PrintPreviewDialog
    Friend WithEvents docPrintReport As Printing.PrintDocument
    Friend WithEvents ToolTipForMonthlyReport As ToolTip
    Friend WithEvents lblCount As Label
End Class
