<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Exchange
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
        Me.Label2 = New System.Windows.Forms.Label()
        Me.btnCan = New System.Windows.Forms.Button()
        Me.btnExchange = New System.Windows.Forms.Button()
        Me.DateTimePicker1 = New System.Windows.Forms.DateTimePicker()
        Me.cbProduct = New System.Windows.Forms.ComboBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtPlayIDEx = New System.Windows.Forms.TextBox()
        Me.txtExID = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.btnSearch = New System.Windows.Forms.Button()
        Me.btnAdd = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Label2.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Label2.Location = New System.Drawing.Point(539, 18)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(179, 32)
        Me.Label2.TabIndex = 67
        Me.Label2.Text = "แลกของรางวัล"
        '
        'btnCan
        '
        Me.btnCan.BackColor = System.Drawing.Color.Red
        Me.btnCan.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.btnCan.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.btnCan.Location = New System.Drawing.Point(808, 462)
        Me.btnCan.Name = "btnCan"
        Me.btnCan.Size = New System.Drawing.Size(157, 47)
        Me.btnCan.TabIndex = 65
        Me.btnCan.Text = "ยกเลิก"
        Me.btnCan.UseVisualStyleBackColor = False
        '
        'btnExchange
        '
        Me.btnExchange.BackColor = System.Drawing.Color.LightGreen
        Me.btnExchange.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.btnExchange.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.btnExchange.Location = New System.Drawing.Point(319, 462)
        Me.btnExchange.Name = "btnExchange"
        Me.btnExchange.Size = New System.Drawing.Size(157, 47)
        Me.btnExchange.TabIndex = 66
        Me.btnExchange.Text = "แลกเปลี่ยน"
        Me.btnExchange.UseVisualStyleBackColor = False
        '
        'DateTimePicker1
        '
        Me.DateTimePicker1.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.DateTimePicker1.Location = New System.Drawing.Point(526, 386)
        Me.DateTimePicker1.Name = "DateTimePicker1"
        Me.DateTimePicker1.Size = New System.Drawing.Size(220, 34)
        Me.DateTimePicker1.TabIndex = 64
        '
        'cbProduct
        '
        Me.cbProduct.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.cbProduct.FormattingEnabled = True
        Me.cbProduct.Location = New System.Drawing.Point(526, 286)
        Me.cbProduct.Name = "cbProduct"
        Me.cbProduct.Size = New System.Drawing.Size(220, 37)
        Me.cbProduct.TabIndex = 2
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Label5.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Label5.Location = New System.Drawing.Point(521, 344)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(48, 25)
        Me.Label5.TabIndex = 59
        Me.Label5.Text = "วันที่"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Label4.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Label4.Location = New System.Drawing.Point(525, 257)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(107, 25)
        Me.Label4.TabIndex = 60
        Me.Label4.Text = "ProductID"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Label1.Location = New System.Drawing.Point(521, 179)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(94, 25)
        Me.Label1.TabIndex = 62
        Me.Label1.Text = "PlayerID"
        '
        'txtPlayIDEx
        '
        Me.txtPlayIDEx.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.txtPlayIDEx.Location = New System.Drawing.Point(526, 207)
        Me.txtPlayIDEx.Name = "txtPlayIDEx"
        Me.txtPlayIDEx.Size = New System.Drawing.Size(220, 38)
        Me.txtPlayIDEx.TabIndex = 1
        '
        'txtExID
        '
        Me.txtExID.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.txtExID.Location = New System.Drawing.Point(526, 128)
        Me.txtExID.Name = "txtExID"
        Me.txtExID.Size = New System.Drawing.Size(220, 38)
        Me.txtExID.TabIndex = 5
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Label6.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Label6.Location = New System.Drawing.Point(521, 100)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(129, 25)
        Me.Label6.TabIndex = 62
        Me.Label6.Text = "ExchangeID"
        '
        'btnSearch
        '
        Me.btnSearch.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.btnSearch.Location = New System.Drawing.Point(645, 462)
        Me.btnSearch.Name = "btnSearch"
        Me.btnSearch.Size = New System.Drawing.Size(157, 47)
        Me.btnSearch.TabIndex = 66
        Me.btnSearch.Text = "ค้นหา"
        Me.btnSearch.UseVisualStyleBackColor = True
        '
        'btnAdd
        '
        Me.btnAdd.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.btnAdd.Location = New System.Drawing.Point(482, 462)
        Me.btnAdd.Name = "btnAdd"
        Me.btnAdd.Size = New System.Drawing.Size(157, 47)
        Me.btnAdd.TabIndex = 66
        Me.btnAdd.Text = "เพิ่ม"
        Me.btnAdd.UseVisualStyleBackColor = True
        '
        'Exchange
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Tomato
        Me.ClientSize = New System.Drawing.Size(1197, 577)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.btnCan)
        Me.Controls.Add(Me.btnAdd)
        Me.Controls.Add(Me.btnSearch)
        Me.Controls.Add(Me.btnExchange)
        Me.Controls.Add(Me.DateTimePicker1)
        Me.Controls.Add(Me.cbProduct)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.txtExID)
        Me.Controls.Add(Me.txtPlayIDEx)
        Me.Name = "Exchange"
        Me.Text = "Exchange"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label2 As Label
    Friend WithEvents btnCan As Button
    Friend WithEvents btnExchange As Button
    Friend WithEvents DateTimePicker1 As DateTimePicker
    Friend WithEvents cbProduct As ComboBox
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents txtPlayIDEx As TextBox
    Friend WithEvents txtExID As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents btnSearch As Button
    Friend WithEvents btnAdd As Button
End Class
