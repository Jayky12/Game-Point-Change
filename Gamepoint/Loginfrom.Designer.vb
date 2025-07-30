<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Loginfrom
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Loginfrom))
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtUser = New System.Windows.Forms.TextBox()
        Me.txtPassword = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.btnLogin = New System.Windows.Forms.Button()
        Me.btnRegis = New System.Windows.Forms.Button()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Label1.Location = New System.Drawing.Point(154, 89)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(132, 29)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Username"
        '
        'txtUser
        '
        Me.txtUser.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.txtUser.Location = New System.Drawing.Point(288, 86)
        Me.txtUser.Name = "txtUser"
        Me.txtUser.Size = New System.Drawing.Size(326, 34)
        Me.txtUser.TabIndex = 1
        '
        'txtPassword
        '
        Me.txtPassword.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.txtPassword.Location = New System.Drawing.Point(288, 173)
        Me.txtPassword.Name = "txtPassword"
        Me.txtPassword.Size = New System.Drawing.Size(326, 34)
        Me.txtPassword.TabIndex = 2
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Label2.Location = New System.Drawing.Point(158, 176)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(128, 29)
        Me.Label2.TabIndex = 0
        Me.Label2.Text = "Password"
        '
        'btnLogin
        '
        Me.btnLogin.BackColor = System.Drawing.Color.SpringGreen
        Me.btnLogin.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.btnLogin.ForeColor = System.Drawing.Color.Honeydew
        Me.btnLogin.Location = New System.Drawing.Point(251, 261)
        Me.btnLogin.Name = "btnLogin"
        Me.btnLogin.Size = New System.Drawing.Size(146, 47)
        Me.btnLogin.TabIndex = 3
        Me.btnLogin.Text = "Login"
        Me.btnLogin.UseVisualStyleBackColor = False
        '
        'btnRegis
        '
        Me.btnRegis.BackColor = System.Drawing.Color.Indigo
        Me.btnRegis.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.btnRegis.ForeColor = System.Drawing.Color.Plum
        Me.btnRegis.Location = New System.Drawing.Point(429, 261)
        Me.btnRegis.Name = "btnRegis"
        Me.btnRegis.Size = New System.Drawing.Size(146, 47)
        Me.btnRegis.TabIndex = 3
        Me.btnRegis.Text = "Register"
        Me.btnRegis.UseVisualStyleBackColor = False
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Label3.Location = New System.Drawing.Point(328, 36)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(162, 29)
        Me.Label3.TabIndex = 4
        Me.Label3.Text = "CRM System"
        '
        'Loginfrom
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ButtonFace
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.ClientSize = New System.Drawing.Size(788, 395)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.btnRegis)
        Me.Controls.Add(Me.btnLogin)
        Me.Controls.Add(Me.txtPassword)
        Me.Controls.Add(Me.txtUser)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.ForeColor = System.Drawing.Color.Crimson
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Name = "Loginfrom"
        Me.Text = "Loginfrom"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents txtUser As TextBox
    Friend WithEvents txtPassword As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents btnLogin As Button
    Friend WithEvents btnRegis As Button
    Friend WithEvents Label3 As Label
End Class
