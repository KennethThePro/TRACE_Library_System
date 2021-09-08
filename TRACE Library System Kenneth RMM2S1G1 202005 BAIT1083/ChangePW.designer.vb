<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class ChangePW
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(ChangePW))
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtNewPW = New System.Windows.Forms.TextBox()
        Me.txtCurrentPW = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtConfirmNewPW = New System.Windows.Forms.TextBox()
        Me.btnChangePassword = New System.Windows.Forms.Button()
        Me.btnCancelCode = New System.Windows.Forms.Button()
        Me.lblWrongPW = New System.Windows.Forms.Label()
        Me.StaffTableAdapter1 = New TRACE_Library_System_Kenneth_RMM2S1G1_202005_BAIT1083.TRACE_Library_SystemDataSetTableAdapters.StaffTableAdapter()
        Me.TracE_Library_SystemDataSet1 = New TRACE_Library_System_Kenneth_RMM2S1G1_202005_BAIT1083.TRACE_Library_SystemDataSet()
        CType(Me.TracE_Library_SystemDataSet1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Mongolian Baiti", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Maroon
        Me.Label1.Location = New System.Drawing.Point(35, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(121, 16)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Current Password"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Mongolian Baiti", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.Maroon
        Me.Label2.Location = New System.Drawing.Point(35, 66)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(104, 16)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "New Password"
        '
        'txtNewPW
        '
        Me.txtNewPW.Font = New System.Drawing.Font("Mongolian Baiti", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtNewPW.ForeColor = System.Drawing.SystemColors.WindowText
        Me.txtNewPW.Location = New System.Drawing.Point(31, 88)
        Me.txtNewPW.MaxLength = 40
        Me.txtNewPW.Name = "txtNewPW"
        Me.txtNewPW.PasswordChar = Global.Microsoft.VisualBasic.ChrW(9679)
        Me.txtNewPW.Size = New System.Drawing.Size(201, 23)
        Me.txtNewPW.TabIndex = 3
        '
        'txtCurrentPW
        '
        Me.txtCurrentPW.Font = New System.Drawing.Font("Mongolian Baiti", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCurrentPW.ForeColor = System.Drawing.SystemColors.WindowText
        Me.txtCurrentPW.Location = New System.Drawing.Point(31, 32)
        Me.txtCurrentPW.Name = "txtCurrentPW"
        Me.txtCurrentPW.PasswordChar = Global.Microsoft.VisualBasic.ChrW(9679)
        Me.txtCurrentPW.Size = New System.Drawing.Size(201, 23)
        Me.txtCurrentPW.TabIndex = 1
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Font = New System.Drawing.Font("Mongolian Baiti", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.Maroon
        Me.Label3.Location = New System.Drawing.Point(35, 123)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(161, 16)
        Me.Label3.TabIndex = 4
        Me.Label3.Text = "Confirm New Password"
        '
        'txtConfirmNewPW
        '
        Me.txtConfirmNewPW.Font = New System.Drawing.Font("Mongolian Baiti", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtConfirmNewPW.ForeColor = System.Drawing.SystemColors.WindowText
        Me.txtConfirmNewPW.Location = New System.Drawing.Point(31, 145)
        Me.txtConfirmNewPW.MaxLength = 40
        Me.txtConfirmNewPW.Name = "txtConfirmNewPW"
        Me.txtConfirmNewPW.PasswordChar = Global.Microsoft.VisualBasic.ChrW(9679)
        Me.txtConfirmNewPW.Size = New System.Drawing.Size(201, 23)
        Me.txtConfirmNewPW.TabIndex = 5
        '
        'btnChangePassword
        '
        Me.btnChangePassword.BackColor = System.Drawing.Color.WhiteSmoke
        Me.btnChangePassword.FlatAppearance.BorderColor = System.Drawing.Color.Black
        Me.btnChangePassword.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnChangePassword.Font = New System.Drawing.Font("Mongolian Baiti", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnChangePassword.ForeColor = System.Drawing.Color.Black
        Me.btnChangePassword.Location = New System.Drawing.Point(66, 243)
        Me.btnChangePassword.Name = "btnChangePassword"
        Me.btnChangePassword.Size = New System.Drawing.Size(130, 39)
        Me.btnChangePassword.TabIndex = 7
        Me.btnChangePassword.Text = "Change &Password"
        Me.btnChangePassword.UseVisualStyleBackColor = False
        '
        'btnCancelCode
        '
        Me.btnCancelCode.BackColor = System.Drawing.Color.WhiteSmoke
        Me.btnCancelCode.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btnCancelCode.FlatAppearance.BorderColor = System.Drawing.Color.Black
        Me.btnCancelCode.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnCancelCode.Font = New System.Drawing.Font("Mongolian Baiti", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCancelCode.ForeColor = System.Drawing.Color.Black
        Me.btnCancelCode.Location = New System.Drawing.Point(66, 288)
        Me.btnCancelCode.Name = "btnCancelCode"
        Me.btnCancelCode.Size = New System.Drawing.Size(130, 39)
        Me.btnCancelCode.TabIndex = 8
        Me.btnCancelCode.Text = "&Cancel"
        Me.btnCancelCode.UseVisualStyleBackColor = False
        '
        'lblWrongPW
        '
        Me.lblWrongPW.BackColor = System.Drawing.Color.Transparent
        Me.lblWrongPW.Cursor = System.Windows.Forms.Cursors.Hand
        Me.lblWrongPW.Font = New System.Drawing.Font("Mongolian Baiti", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblWrongPW.ForeColor = System.Drawing.Color.Red
        Me.lblWrongPW.Location = New System.Drawing.Point(28, 179)
        Me.lblWrongPW.Name = "lblWrongPW"
        Me.lblWrongPW.Size = New System.Drawing.Size(215, 56)
        Me.lblWrongPW.TabIndex = 6
        Me.lblWrongPW.Text = "New Password must have 8-40 letters with at least one capital letter, one lower c" &
    "ase letter and one digit"
        Me.lblWrongPW.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'StaffTableAdapter1
        '
        Me.StaffTableAdapter1.ClearBeforeFill = True
        '
        'TracE_Library_SystemDataSet1
        '
        Me.TracE_Library_SystemDataSet1.DataSetName = "TRACE_Library_SystemDataSet"
        Me.TracE_Library_SystemDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'ChangePW
        '
        Me.AcceptButton = Me.btnChangePassword
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.AntiqueWhite
        Me.CancelButton = Me.btnCancelCode
        Me.ClientSize = New System.Drawing.Size(262, 339)
        Me.ControlBox = False
        Me.Controls.Add(Me.lblWrongPW)
        Me.Controls.Add(Me.btnCancelCode)
        Me.Controls.Add(Me.btnChangePassword)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.txtConfirmNewPW)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.txtNewPW)
        Me.Controls.Add(Me.txtCurrentPW)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "ChangePW"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Change Password"
        CType(Me.TracE_Library_SystemDataSet1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents txtNewPW As TextBox
    Friend WithEvents txtCurrentPW As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents txtConfirmNewPW As TextBox
    Friend WithEvents btnChangePassword As Button
    Friend WithEvents btnCancelCode As Button
    Friend WithEvents lblWrongPW As Label
    Friend WithEvents StaffTableAdapter1 As TRACE_Library_SystemDataSetTableAdapters.StaffTableAdapter
    Friend WithEvents TracE_Library_SystemDataSet1 As TRACE_Library_SystemDataSet
End Class
