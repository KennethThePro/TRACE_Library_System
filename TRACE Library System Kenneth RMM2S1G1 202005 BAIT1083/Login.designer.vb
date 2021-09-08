<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Login
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Login))
        Me.lblTitle = New System.Windows.Forms.Label()
        Me.txtID = New System.Windows.Forms.TextBox()
        Me.txtPassword = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.lblForgotPW = New System.Windows.Forms.Label()
        Me.btnSignIn = New System.Windows.Forms.Button()
        Me.StaffTableAdapterLoginPage = New TRACE_Library_System_Kenneth_RMM2S1G1_202005_BAIT1083.TRACE_Library_SystemDataSetTableAdapters.StaffTableAdapter()
        Me.TracE_Library_SystemDataSetLoginPage = New TRACE_Library_System_Kenneth_RMM2S1G1_202005_BAIT1083.TRACE_Library_SystemDataSet()
        Me.LoginRecordTableAdapterLoginPage = New TRACE_Library_System_Kenneth_RMM2S1G1_202005_BAIT1083.TRACE_Library_SystemDataSetTableAdapters.LoginRecordTableAdapter()
        Me.tipLoginPage = New System.Windows.Forms.ToolTip(Me.components)
        Me.GroupBox1.SuspendLayout()
        CType(Me.TracE_Library_SystemDataSetLoginPage, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lblTitle
        '
        Me.lblTitle.AutoSize = True
        Me.lblTitle.BackColor = System.Drawing.Color.Transparent
        Me.lblTitle.Font = New System.Drawing.Font("Mongolian Baiti", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTitle.ForeColor = System.Drawing.Color.AliceBlue
        Me.lblTitle.Location = New System.Drawing.Point(131, 25)
        Me.lblTitle.Name = "lblTitle"
        Me.lblTitle.Size = New System.Drawing.Size(54, 16)
        Me.lblTitle.TabIndex = 0
        Me.lblTitle.Text = "Sign In"
        '
        'txtID
        '
        Me.txtID.ForeColor = System.Drawing.Color.Maroon
        Me.txtID.Location = New System.Drawing.Point(15, 50)
        Me.txtID.Name = "txtID"
        Me.txtID.Size = New System.Drawing.Size(201, 20)
        Me.txtID.TabIndex = 1
        Me.tipLoginPage.SetToolTip(Me.txtID, "Please enter user ID")
        '
        'txtPassword
        '
        Me.txtPassword.ForeColor = System.Drawing.Color.Maroon
        Me.txtPassword.Location = New System.Drawing.Point(15, 112)
        Me.txtPassword.Name = "txtPassword"
        Me.txtPassword.PasswordChar = Global.Microsoft.VisualBasic.ChrW(9679)
        Me.txtPassword.Size = New System.Drawing.Size(197, 20)
        Me.txtPassword.TabIndex = 3
        Me.tipLoginPage.SetToolTip(Me.txtPassword, "Please enter user password")
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Mongolian Baiti", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Maroon
        Me.Label1.Location = New System.Drawing.Point(15, 24)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(52, 15)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "User ID"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Mongolian Baiti", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.Maroon
        Me.Label2.Location = New System.Drawing.Point(19, 88)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(60, 15)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Password"
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.Color.White
        Me.GroupBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.GroupBox1.Controls.Add(Me.lblForgotPW)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.txtPassword)
        Me.GroupBox1.Controls.Add(Me.txtID)
        Me.GroupBox1.Location = New System.Drawing.Point(41, 66)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(224, 173)
        Me.GroupBox1.TabIndex = 1
        Me.GroupBox1.TabStop = False
        '
        'lblForgotPW
        '
        Me.lblForgotPW.AutoSize = True
        Me.lblForgotPW.BackColor = System.Drawing.Color.Transparent
        Me.lblForgotPW.Cursor = System.Windows.Forms.Cursors.Hand
        Me.lblForgotPW.Font = New System.Drawing.Font("Mongolian Baiti", 9.75!, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblForgotPW.ForeColor = System.Drawing.Color.Red
        Me.lblForgotPW.Location = New System.Drawing.Point(15, 146)
        Me.lblForgotPW.Name = "lblForgotPW"
        Me.lblForgotPW.Size = New System.Drawing.Size(102, 14)
        Me.lblForgotPW.TabIndex = 4
        Me.lblForgotPW.Text = "Forgot password?"
        Me.lblForgotPW.TextAlign = System.Drawing.ContentAlignment.BottomRight
        '
        'btnSignIn
        '
        Me.btnSignIn.BackColor = System.Drawing.Color.WhiteSmoke
        Me.btnSignIn.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnSignIn.Font = New System.Drawing.Font("Mongolian Baiti", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSignIn.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.btnSignIn.Location = New System.Drawing.Point(101, 253)
        Me.btnSignIn.Name = "btnSignIn"
        Me.btnSignIn.Size = New System.Drawing.Size(104, 25)
        Me.btnSignIn.TabIndex = 2
        Me.btnSignIn.Text = "&Sign In"
        Me.btnSignIn.UseVisualStyleBackColor = False
        '
        'StaffTableAdapterLoginPage
        '
        Me.StaffTableAdapterLoginPage.ClearBeforeFill = True
        '
        'TracE_Library_SystemDataSetLoginPage
        '
        Me.TracE_Library_SystemDataSetLoginPage.DataSetName = "TRACE_Library_SystemDataSet"
        Me.TracE_Library_SystemDataSetLoginPage.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'LoginRecordTableAdapterLoginPage
        '
        Me.LoginRecordTableAdapterLoginPage.ClearBeforeFill = True
        '
        'Login
        '
        Me.AcceptButton = Me.btnSignIn
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.BackgroundImage = Global.TRACE_Library_System_Kenneth_RMM2S1G1_202005_BAIT1083.My.Resources.Resources.brownbg
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(307, 302)
        Me.Controls.Add(Me.btnSignIn)
        Me.Controls.Add(Me.lblTitle)
        Me.Controls.Add(Me.GroupBox1)
        Me.DoubleBuffered = True
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.Name = "Login"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "TRACE- Login Page"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.TracE_Library_SystemDataSetLoginPage, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lblTitle As Label
    Friend WithEvents txtID As TextBox
    Friend WithEvents txtPassword As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents lblForgotPW As Label
    Friend WithEvents btnSignIn As Button
    Friend WithEvents StaffTableAdapterLoginPage As TRACE_Library_SystemDataSetTableAdapters.StaffTableAdapter
    Friend WithEvents TracE_Library_SystemDataSetLoginPage As TRACE_Library_SystemDataSet
    Friend WithEvents LoginRecordTableAdapterLoginPage As TRACE_Library_SystemDataSetTableAdapters.LoginRecordTableAdapter
    Friend WithEvents tipLoginPage As ToolTip
End Class
