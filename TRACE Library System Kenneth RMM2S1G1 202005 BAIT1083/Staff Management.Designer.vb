<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Staff_Management
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Staff_Management))
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.PictureBox4 = New System.Windows.Forms.PictureBox()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.btnReturnToMainMenu = New System.Windows.Forms.Button()
        Me.btnSearchStaff = New System.Windows.Forms.Button()
        Me.btnRegisterNewStaff = New System.Windows.Forms.Button()
        Me.ToolTipForStaffManagementButtons = New System.Windows.Forms.ToolTip(Me.components)
        Me.MenuStripStaffManagement = New System.Windows.Forms.MenuStrip()
        Me.FileToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.LogOutToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ExitToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ViewToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.DarkModeToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.LightModeToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ChangePasswordToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.LoginRecordTableAdapterStaffManagement = New TRACE_Library_System_Kenneth_RMM2S1G1_202005_BAIT1083.TRACE_Library_SystemDataSetTableAdapters.LoginRecordTableAdapter()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.MenuStripStaffManagement.SuspendLayout()
        Me.SuspendLayout()
        '
        'PictureBox2
        '
        Me.PictureBox2.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.PictureBox2.BackColor = System.Drawing.Color.White
        Me.PictureBox2.Image = Global.TRACE_Library_System_Kenneth_RMM2S1G1_202005_BAIT1083.My.Resources.Resources.Search_Icon1
        Me.PictureBox2.Location = New System.Drawing.Point(270, 48)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(70, 66)
        Me.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox2.TabIndex = 27
        Me.PictureBox2.TabStop = False
        '
        'PictureBox4
        '
        Me.PictureBox4.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.PictureBox4.Image = Global.TRACE_Library_System_Kenneth_RMM2S1G1_202005_BAIT1083.My.Resources.Resources.Main_Menu_Icon
        Me.PictureBox4.Location = New System.Drawing.Point(453, 46)
        Me.PictureBox4.Name = "PictureBox4"
        Me.PictureBox4.Size = New System.Drawing.Size(70, 66)
        Me.PictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox4.TabIndex = 26
        Me.PictureBox4.TabStop = False
        '
        'PictureBox1
        '
        Me.PictureBox1.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.PictureBox1.BackColor = System.Drawing.Color.White
        Me.PictureBox1.Image = Global.TRACE_Library_System_Kenneth_RMM2S1G1_202005_BAIT1083.My.Resources.Resources.Register_New_Staff_Icon
        Me.PictureBox1.Location = New System.Drawing.Point(92, 48)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(70, 66)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 25
        Me.PictureBox1.TabStop = False
        '
        'btnReturnToMainMenu
        '
        Me.btnReturnToMainMenu.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.btnReturnToMainMenu.BackColor = System.Drawing.Color.WhiteSmoke
        Me.btnReturnToMainMenu.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btnReturnToMainMenu.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnReturnToMainMenu.Location = New System.Drawing.Point(428, 118)
        Me.btnReturnToMainMenu.Name = "btnReturnToMainMenu"
        Me.btnReturnToMainMenu.Size = New System.Drawing.Size(112, 42)
        Me.btnReturnToMainMenu.TabIndex = 23
        Me.btnReturnToMainMenu.Text = "R&eturn To Main Menu"
        Me.ToolTipForStaffManagementButtons.SetToolTip(Me.btnReturnToMainMenu, "R&eturn to the Main Menu")
        Me.btnReturnToMainMenu.UseVisualStyleBackColor = False
        '
        'btnSearchStaff
        '
        Me.btnSearchStaff.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.btnSearchStaff.BackColor = System.Drawing.Color.WhiteSmoke
        Me.btnSearchStaff.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnSearchStaff.Location = New System.Drawing.Point(249, 120)
        Me.btnSearchStaff.Name = "btnSearchStaff"
        Me.btnSearchStaff.Size = New System.Drawing.Size(112, 38)
        Me.btnSearchStaff.TabIndex = 21
        Me.btnSearchStaff.Text = "&Search Staff and Update Staff Details"
        Me.ToolTipForStaffManagementButtons.SetToolTip(Me.btnSearchStaff, "Perform a Search and Update Staff Information")
        Me.btnSearchStaff.UseVisualStyleBackColor = False
        '
        'btnRegisterNewStaff
        '
        Me.btnRegisterNewStaff.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.btnRegisterNewStaff.BackColor = System.Drawing.Color.WhiteSmoke
        Me.btnRegisterNewStaff.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnRegisterNewStaff.Location = New System.Drawing.Point(67, 120)
        Me.btnRegisterNewStaff.Name = "btnRegisterNewStaff"
        Me.btnRegisterNewStaff.Size = New System.Drawing.Size(112, 40)
        Me.btnRegisterNewStaff.TabIndex = 20
        Me.btnRegisterNewStaff.Text = "&Register New Staff"
        Me.ToolTipForStaffManagementButtons.SetToolTip(Me.btnRegisterNewStaff, "Register a New Staff")
        Me.btnRegisterNewStaff.UseVisualStyleBackColor = False
        '
        'MenuStripStaffManagement
        '
        Me.MenuStripStaffManagement.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.FileToolStripMenuItem, Me.ViewToolStripMenuItem, Me.ChangePasswordToolStripMenuItem})
        Me.MenuStripStaffManagement.Location = New System.Drawing.Point(0, 0)
        Me.MenuStripStaffManagement.Name = "MenuStripStaffManagement"
        Me.MenuStripStaffManagement.Size = New System.Drawing.Size(607, 24)
        Me.MenuStripStaffManagement.TabIndex = 38
        Me.MenuStripStaffManagement.Text = "MenuStrip1"
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
        'LoginRecordTableAdapterStaffManagement
        '
        Me.LoginRecordTableAdapterStaffManagement.ClearBeforeFill = True
        '
        'Staff_Management
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.AntiqueWhite
        Me.CancelButton = Me.btnReturnToMainMenu
        Me.ClientSize = New System.Drawing.Size(607, 207)
        Me.Controls.Add(Me.MenuStripStaffManagement)
        Me.Controls.Add(Me.PictureBox2)
        Me.Controls.Add(Me.PictureBox4)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.btnReturnToMainMenu)
        Me.Controls.Add(Me.btnSearchStaff)
        Me.Controls.Add(Me.btnRegisterNewStaff)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.Name = "Staff_Management"
        Me.Text = "Staff Management"
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.MenuStripStaffManagement.ResumeLayout(False)
        Me.MenuStripStaffManagement.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents PictureBox4 As PictureBox
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents btnReturnToMainMenu As Button
    Friend WithEvents btnSearchStaff As Button
    Friend WithEvents btnRegisterNewStaff As Button
    Friend WithEvents ToolTipForStaffManagementButtons As ToolTip
    Friend WithEvents MenuStripStaffManagement As MenuStrip
    Friend WithEvents FileToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents LogOutToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ExitToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ViewToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents DarkModeToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents LightModeToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ChangePasswordToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents LoginRecordTableAdapterStaffManagement As TRACE_Library_SystemDataSetTableAdapters.LoginRecordTableAdapter
End Class
