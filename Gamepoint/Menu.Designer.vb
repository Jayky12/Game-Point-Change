<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Menu
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
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.ชอมลผใชToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.แตมToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ดแตมToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.รบแตมToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.แลกแตมToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.รายงานToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.รายงานประวตการรบแตมToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.รายงานประวตการแลกสนคาToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'MenuStrip1
        '
        Me.MenuStrip1.BackColor = System.Drawing.Color.DarkGreen
        Me.MenuStrip1.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ชอมลผใชToolStripMenuItem, Me.แตมToolStripMenuItem, Me.รายงานToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(1160, 28)
        Me.MenuStrip1.TabIndex = 0
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'ชอมลผใชToolStripMenuItem
        '
        Me.ชอมลผใชToolStripMenuItem.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.ชอมลผใชToolStripMenuItem.Name = "ชอมลผใชToolStripMenuItem"
        Me.ชอมลผใชToolStripMenuItem.Size = New System.Drawing.Size(119, 24)
        Me.ชอมลผใชToolStripMenuItem.Text = "จัดการช้อมูลผู้ใช้"
        '
        'แตมToolStripMenuItem
        '
        Me.แตมToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ดแตมToolStripMenuItem, Me.รบแตมToolStripMenuItem, Me.แลกแตมToolStripMenuItem})
        Me.แตมToolStripMenuItem.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.แตมToolStripMenuItem.Name = "แตมToolStripMenuItem"
        Me.แตมToolStripMenuItem.Size = New System.Drawing.Size(47, 24)
        Me.แตมToolStripMenuItem.Text = "แต้ม"
        '
        'ดแตมToolStripMenuItem
        '
        Me.ดแตมToolStripMenuItem.Name = "ดแตมToolStripMenuItem"
        Me.ดแตมToolStripMenuItem.Size = New System.Drawing.Size(140, 26)
        Me.ดแตมToolStripMenuItem.Text = "ดูแต้ม"
        '
        'รบแตมToolStripMenuItem
        '
        Me.รบแตมToolStripMenuItem.Name = "รบแตมToolStripMenuItem"
        Me.รบแตมToolStripMenuItem.Size = New System.Drawing.Size(140, 26)
        Me.รบแตมToolStripMenuItem.Text = "รับแต้ม"
        '
        'แลกแตมToolStripMenuItem
        '
        Me.แลกแตมToolStripMenuItem.Name = "แลกแตมToolStripMenuItem"
        Me.แลกแตมToolStripMenuItem.Size = New System.Drawing.Size(140, 26)
        Me.แลกแตมToolStripMenuItem.Text = "แลกแต้ม"
        '
        'รายงานToolStripMenuItem
        '
        Me.รายงานToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.รายงานประวตการรบแตมToolStripMenuItem, Me.รายงานประวตการแลกสนคาToolStripMenuItem})
        Me.รายงานToolStripMenuItem.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.รายงานToolStripMenuItem.Name = "รายงานToolStripMenuItem"
        Me.รายงานToolStripMenuItem.Size = New System.Drawing.Size(94, 24)
        Me.รายงานToolStripMenuItem.Text = "พิมพ์รายงาน"
        '
        'รายงานประวตการรบแตมToolStripMenuItem
        '
        Me.รายงานประวตการรบแตมToolStripMenuItem.Name = "รายงานประวตการรบแตมToolStripMenuItem"
        Me.รายงานประวตการรบแตมToolStripMenuItem.Size = New System.Drawing.Size(250, 26)
        Me.รายงานประวตการรบแตมToolStripMenuItem.Text = "รายงานประวัติการรับแต้ม"
        '
        'รายงานประวตการแลกสนคาToolStripMenuItem
        '
        Me.รายงานประวตการแลกสนคาToolStripMenuItem.Name = "รายงานประวตการแลกสนคาToolStripMenuItem"
        Me.รายงานประวตการแลกสนคาToolStripMenuItem.Size = New System.Drawing.Size(250, 26)
        Me.รายงานประวตการแลกสนคาToolStripMenuItem.Text = "รายงานประวัติการแลกสินค้า"
        '
        'Menu
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ButtonShadow
        Me.BackgroundImage = Global.Gamepoint.My.Resources.Resources.Luxury_Resort_Phuket
        Me.ClientSize = New System.Drawing.Size(1160, 587)
        Me.Controls.Add(Me.MenuStrip1)
        Me.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "Menu"
        Me.Text = "Menu"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents ชอมลผใชToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents แตมToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ดแตมToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents รบแตมToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents แลกแตมToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents รายงานToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents รายงานประวตการรบแตมToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents รายงานประวตการแลกสนคาToolStripMenuItem As ToolStripMenuItem
End Class
