<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ReportGeneration
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(ReportGeneration))
        Me.btnStaffLoginReport = New System.Windows.Forms.Button()
        Me.btnLoanReport = New System.Windows.Forms.Button()
        Me.btnBooksReport = New System.Windows.Forms.Button()
        Me.btnStaffEmploymentReport = New System.Windows.Forms.Button()
        Me.btnBackToMainMenu = New System.Windows.Forms.Button()
        Me.PictureBox3 = New System.Windows.Forms.PictureBox()
        Me.PictureBox5 = New System.Windows.Forms.PictureBox()
        Me.picStaffManagement = New System.Windows.Forms.PictureBox()
        Me.picStaffEmploymentReport = New System.Windows.Forms.PictureBox()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.MenuStripReportGeneration = New System.Windows.Forms.MenuStrip()
        Me.FileToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.LogOutToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ExitToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ViewToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.DarkModeToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.LightModeToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ChangePasswordToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.LoginRecordTableAdapterReportGeneration = New TRACE_Library_System_Kenneth_RMM2S1G1_202005_BAIT1083.TRACE_Library_SystemDataSetTableAdapters.LoginRecordTableAdapter()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox5, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picStaffManagement, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picStaffEmploymentReport, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.MenuStripReportGeneration.SuspendLayout()
        Me.SuspendLayout()
        '
        'btnStaffLoginReport
        '
        Me.btnStaffLoginReport.BackColor = System.Drawing.Color.WhiteSmoke
        Me.btnStaffLoginReport.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnStaffLoginReport.Font = New System.Drawing.Font("Mongolian Baiti", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnStaffLoginReport.Location = New System.Drawing.Point(38, 115)
        Me.btnStaffLoginReport.Name = "btnStaffLoginReport"
        Me.btnStaffLoginReport.Size = New System.Drawing.Size(112, 43)
        Me.btnStaffLoginReport.TabIndex = 0
        Me.btnStaffLoginReport.Text = "Staff &Login Report"
        Me.btnStaffLoginReport.UseVisualStyleBackColor = False
        '
        'btnLoanReport
        '
        Me.btnLoanReport.BackColor = System.Drawing.Color.WhiteSmoke
        Me.btnLoanReport.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnLoanReport.Font = New System.Drawing.Font("Mongolian Baiti", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnLoanReport.Location = New System.Drawing.Point(218, 115)
        Me.btnLoanReport.Name = "btnLoanReport"
        Me.btnLoanReport.Size = New System.Drawing.Size(112, 43)
        Me.btnLoanReport.TabIndex = 1
        Me.btnLoanReport.Text = "&Circulation Report"
        Me.btnLoanReport.UseVisualStyleBackColor = False
        '
        'btnBooksReport
        '
        Me.btnBooksReport.BackColor = System.Drawing.Color.WhiteSmoke
        Me.btnBooksReport.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnBooksReport.Font = New System.Drawing.Font("Mongolian Baiti", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnBooksReport.Location = New System.Drawing.Point(405, 115)
        Me.btnBooksReport.Name = "btnBooksReport"
        Me.btnBooksReport.Size = New System.Drawing.Size(112, 43)
        Me.btnBooksReport.TabIndex = 2
        Me.btnBooksReport.Text = "&Books Report"
        Me.btnBooksReport.UseVisualStyleBackColor = False
        '
        'btnStaffEmploymentReport
        '
        Me.btnStaffEmploymentReport.BackColor = System.Drawing.Color.WhiteSmoke
        Me.btnStaffEmploymentReport.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnStaffEmploymentReport.Font = New System.Drawing.Font("Mongolian Baiti", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnStaffEmploymentReport.Location = New System.Drawing.Point(38, 240)
        Me.btnStaffEmploymentReport.Name = "btnStaffEmploymentReport"
        Me.btnStaffEmploymentReport.Size = New System.Drawing.Size(112, 43)
        Me.btnStaffEmploymentReport.TabIndex = 3
        Me.btnStaffEmploymentReport.Text = "&Staff Employment Report"
        Me.btnStaffEmploymentReport.UseVisualStyleBackColor = False
        '
        'btnBackToMainMenu
        '
        Me.btnBackToMainMenu.BackColor = System.Drawing.Color.WhiteSmoke
        Me.btnBackToMainMenu.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btnBackToMainMenu.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnBackToMainMenu.Font = New System.Drawing.Font("Mongolian Baiti", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnBackToMainMenu.Location = New System.Drawing.Point(218, 240)
        Me.btnBackToMainMenu.Name = "btnBackToMainMenu"
        Me.btnBackToMainMenu.Size = New System.Drawing.Size(112, 43)
        Me.btnBackToMainMenu.TabIndex = 4
        Me.btnBackToMainMenu.Text = "Back to &Main Menu"
        Me.btnBackToMainMenu.UseVisualStyleBackColor = False
        '
        'PictureBox3
        '
        Me.PictureBox3.Image = Global.TRACE_Library_System_Kenneth_RMM2S1G1_202005_BAIT1083.My.Resources.Resources.addbook
        Me.PictureBox3.Location = New System.Drawing.Point(430, 43)
        Me.PictureBox3.Name = "PictureBox3"
        Me.PictureBox3.Size = New System.Drawing.Size(70, 66)
        Me.PictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox3.TabIndex = 36
        Me.PictureBox3.TabStop = False
        '
        'PictureBox5
        '
        Me.PictureBox5.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox5.Image = Global.TRACE_Library_System_Kenneth_RMM2S1G1_202005_BAIT1083.My.Resources.Resources.Main_Menu_Icon
        Me.PictureBox5.Location = New System.Drawing.Point(239, 168)
        Me.PictureBox5.Name = "PictureBox5"
        Me.PictureBox5.Size = New System.Drawing.Size(70, 66)
        Me.PictureBox5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox5.TabIndex = 35
        Me.PictureBox5.TabStop = False
        '
        'picStaffManagement
        '
        Me.picStaffManagement.Image = Global.TRACE_Library_System_Kenneth_RMM2S1G1_202005_BAIT1083.My.Resources.Resources.staff_icon
        Me.picStaffManagement.Location = New System.Drawing.Point(54, 43)
        Me.picStaffManagement.Name = "picStaffManagement"
        Me.picStaffManagement.Size = New System.Drawing.Size(70, 66)
        Me.picStaffManagement.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picStaffManagement.TabIndex = 34
        Me.picStaffManagement.TabStop = False
        '
        'picStaffEmploymentReport
        '
        Me.picStaffEmploymentReport.Image = Global.TRACE_Library_System_Kenneth_RMM2S1G1_202005_BAIT1083.My.Resources.Resources.return_icon
        Me.picStaffEmploymentReport.Location = New System.Drawing.Point(54, 168)
        Me.picStaffEmploymentReport.Name = "picStaffEmploymentReport"
        Me.picStaffEmploymentReport.Size = New System.Drawing.Size(70, 66)
        Me.picStaffEmploymentReport.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picStaffEmploymentReport.TabIndex = 33
        Me.picStaffEmploymentReport.TabStop = False
        '
        'PictureBox1
        '
        Me.PictureBox1.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox1.Image = Global.TRACE_Library_System_Kenneth_RMM2S1G1_202005_BAIT1083.My.Resources.Resources.loan_icon
        Me.PictureBox1.Location = New System.Drawing.Point(239, 43)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(70, 66)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 31
        Me.PictureBox1.TabStop = False
        '
        'MenuStripReportGeneration
        '
        Me.MenuStripReportGeneration.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.FileToolStripMenuItem, Me.ViewToolStripMenuItem, Me.ChangePasswordToolStripMenuItem})
        Me.MenuStripReportGeneration.Location = New System.Drawing.Point(0, 0)
        Me.MenuStripReportGeneration.Name = "MenuStripReportGeneration"
        Me.MenuStripReportGeneration.Size = New System.Drawing.Size(560, 24)
        Me.MenuStripReportGeneration.TabIndex = 37
        Me.MenuStripReportGeneration.Text = "MenuStrip1"
        '
        'FileToolStripMenuItem
        '
        Me.FileToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.LogOutToolStripMenuItem, Me.ExitToolStripMenuItem})
        Me.FileToolStripMenuItem.Name = "FileToolStripMenuItem"
        Me.FileToolStripMenuItem.Size = New System.Drawing.Size(37, 20)
        Me.FileToolStripMenuItem.Text = "File"
        '
        'LogOutToolStripMenuItem
        '
        Me.LogOutToolStripMenuItem.Name = "LogOutToolStripMenuItem"
        Me.LogOutToolStripMenuItem.ShortcutKeys = CType(((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.Alt) _
            Or System.Windows.Forms.Keys.L), System.Windows.Forms.Keys)
        Me.LogOutToolStripMenuItem.Size = New System.Drawing.Size(180, 22)
        Me.LogOutToolStripMenuItem.Text = "Log Out"
        '
        'ExitToolStripMenuItem
        '
        Me.ExitToolStripMenuItem.Name = "ExitToolStripMenuItem"
        Me.ExitToolStripMenuItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Alt Or System.Windows.Forms.Keys.F4), System.Windows.Forms.Keys)
        Me.ExitToolStripMenuItem.Size = New System.Drawing.Size(180, 22)
        Me.ExitToolStripMenuItem.Text = "Exit"
        '
        'ViewToolStripMenuItem
        '
        Me.ViewToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.DarkModeToolStripMenuItem, Me.LightModeToolStripMenuItem})
        Me.ViewToolStripMenuItem.Name = "ViewToolStripMenuItem"
        Me.ViewToolStripMenuItem.Size = New System.Drawing.Size(44, 20)
        Me.ViewToolStripMenuItem.Text = "View"
        '
        'DarkModeToolStripMenuItem
        '
        Me.DarkModeToolStripMenuItem.Name = "DarkModeToolStripMenuItem"
        Me.DarkModeToolStripMenuItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.D), System.Windows.Forms.Keys)
        Me.DarkModeToolStripMenuItem.Size = New System.Drawing.Size(177, 22)
        Me.DarkModeToolStripMenuItem.Text = "Dark mode "
        '
        'LightModeToolStripMenuItem
        '
        Me.LightModeToolStripMenuItem.Name = "LightModeToolStripMenuItem"
        Me.LightModeToolStripMenuItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.L), System.Windows.Forms.Keys)
        Me.LightModeToolStripMenuItem.Size = New System.Drawing.Size(177, 22)
        Me.LightModeToolStripMenuItem.Text = "Light mode"
        '
        'ChangePasswordToolStripMenuItem
        '
        Me.ChangePasswordToolStripMenuItem.Name = "ChangePasswordToolStripMenuItem"
        Me.ChangePasswordToolStripMenuItem.Size = New System.Drawing.Size(113, 20)
        Me.ChangePasswordToolStripMenuItem.Text = "Change Password"
        '
        'LoginRecordTableAdapterReportGeneration
        '
        Me.LoginRecordTableAdapterReportGeneration.ClearBeforeFill = True
        '
        'ReportGeneration
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.AntiqueWhite
        Me.CancelButton = Me.btnBackToMainMenu
        Me.ClientSize = New System.Drawing.Size(560, 303)
        Me.Controls.Add(Me.MenuStripReportGeneration)
        Me.Controls.Add(Me.PictureBox3)
        Me.Controls.Add(Me.PictureBox5)
        Me.Controls.Add(Me.picStaffManagement)
        Me.Controls.Add(Me.picStaffEmploymentReport)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.btnBackToMainMenu)
        Me.Controls.Add(Me.btnStaffEmploymentReport)
        Me.Controls.Add(Me.btnBooksReport)
        Me.Controls.Add(Me.btnLoanReport)
        Me.Controls.Add(Me.btnStaffLoginReport)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.Name = "ReportGeneration"
        Me.Text = "ReportGeneration"
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox5, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picStaffManagement, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picStaffEmploymentReport, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.MenuStripReportGeneration.ResumeLayout(False)
        Me.MenuStripReportGeneration.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btnStaffLoginReport As Button
    Friend WithEvents btnLoanReport As Button
    Friend WithEvents btnBooksReport As Button
    Friend WithEvents btnStaffEmploymentReport As Button
    Friend WithEvents btnBackToMainMenu As Button
    Friend WithEvents PictureBox3 As PictureBox
    Friend WithEvents PictureBox5 As PictureBox
    Friend WithEvents picStaffManagement As PictureBox
    Friend WithEvents picStaffEmploymentReport As PictureBox
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents MenuStripReportGeneration As MenuStrip
    Friend WithEvents FileToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents LogOutToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ExitToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ViewToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents DarkModeToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents LightModeToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ChangePasswordToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents LoginRecordTableAdapterReportGeneration As TRACE_Library_SystemDataSetTableAdapters.LoginRecordTableAdapter
End Class
