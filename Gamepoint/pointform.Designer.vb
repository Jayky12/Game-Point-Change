<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class pointform
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
        Me.btnCanpoint = New System.Windows.Forms.Button()
        Me.btnConpoint = New System.Windows.Forms.Button()
        Me.DateTimePicker1 = New System.Windows.Forms.DateTimePicker()
        Me.cbGameID = New System.Windows.Forms.ComboBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtPoint = New System.Windows.Forms.TextBox()
        Me.txtPlayIDPoint = New System.Windows.Forms.TextBox()
        Me.btnSearch = New System.Windows.Forms.Button()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.txtPointID = New System.Windows.Forms.TextBox()
        Me.btnADD = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'btnCanpoint
        '
        Me.btnCanpoint.BackColor = System.Drawing.Color.Red
        Me.btnCanpoint.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.btnCanpoint.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.btnCanpoint.Location = New System.Drawing.Point(840, 586)
        Me.btnCanpoint.Name = "btnCanpoint"
        Me.btnCanpoint.Size = New System.Drawing.Size(157, 47)
        Me.btnCanpoint.TabIndex = 55
        Me.btnCanpoint.Text = "ยกเลิก"
        Me.btnCanpoint.UseVisualStyleBackColor = False
        '
        'btnConpoint
        '
        Me.btnConpoint.BackColor = System.Drawing.Color.LightGreen
        Me.btnConpoint.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.btnConpoint.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.btnConpoint.Location = New System.Drawing.Point(315, 586)
        Me.btnConpoint.Name = "btnConpoint"
        Me.btnConpoint.Size = New System.Drawing.Size(157, 47)
        Me.btnConpoint.TabIndex = 56
        Me.btnConpoint.Text = "ยืนยัน"
        Me.btnConpoint.UseVisualStyleBackColor = False
        '
        'DateTimePicker1
        '
        Me.DateTimePicker1.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.DateTimePicker1.Location = New System.Drawing.Point(513, 515)
        Me.DateTimePicker1.Name = "DateTimePicker1"
        Me.DateTimePicker1.Size = New System.Drawing.Size(220, 34)
        Me.DateTimePicker1.TabIndex = 4
        '
        'cbGameID
        '
        Me.cbGameID.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.cbGameID.FormattingEnabled = True
        Me.cbGameID.Location = New System.Drawing.Point(513, 325)
        Me.cbGameID.Name = "cbGameID"
        Me.cbGameID.Size = New System.Drawing.Size(220, 37)
        Me.cbGameID.TabIndex = 2
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 25.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Label2.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Label2.Location = New System.Drawing.Point(522, 9)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(197, 52)
        Me.Label2.TabIndex = 48
        Me.Label2.Text = "สะสมแต้ม"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Label5.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Label5.Location = New System.Drawing.Point(508, 473)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(48, 25)
        Me.Label5.TabIndex = 49
        Me.Label5.Text = "วันที่"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Label4.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Label4.Location = New System.Drawing.Point(512, 296)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(90, 25)
        Me.Label4.TabIndex = 50
        Me.Label4.Text = "GameID"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Label3.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Label3.Location = New System.Drawing.Point(508, 386)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(103, 25)
        Me.Label3.TabIndex = 51
        Me.Label3.Text = "แต้มที่ได้รับ"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Label1.Location = New System.Drawing.Point(508, 218)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(94, 25)
        Me.Label1.TabIndex = 52
        Me.Label1.Text = "PlayerID"
        '
        'txtPoint
        '
        Me.txtPoint.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.txtPoint.Location = New System.Drawing.Point(513, 414)
        Me.txtPoint.Name = "txtPoint"
        Me.txtPoint.Size = New System.Drawing.Size(220, 38)
        Me.txtPoint.TabIndex = 3
        '
        'txtPlayIDPoint
        '
        Me.txtPlayIDPoint.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.txtPlayIDPoint.Location = New System.Drawing.Point(513, 246)
        Me.txtPlayIDPoint.Name = "txtPlayIDPoint"
        Me.txtPlayIDPoint.Size = New System.Drawing.Size(220, 38)
        Me.txtPlayIDPoint.TabIndex = 1
        '
        'btnSearch
        '
        Me.btnSearch.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.btnSearch.Location = New System.Drawing.Point(664, 586)
        Me.btnSearch.Name = "btnSearch"
        Me.btnSearch.Size = New System.Drawing.Size(157, 47)
        Me.btnSearch.TabIndex = 56
        Me.btnSearch.Text = "ค้นหา"
        Me.btnSearch.UseVisualStyleBackColor = True
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Label6.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Label6.Location = New System.Drawing.Point(508, 124)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(82, 25)
        Me.Label6.TabIndex = 52
        Me.Label6.Text = "PointID"
        '
        'txtPointID
        '
        Me.txtPointID.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.txtPointID.Location = New System.Drawing.Point(513, 162)
        Me.txtPointID.Name = "txtPointID"
        Me.txtPointID.Size = New System.Drawing.Size(220, 38)
        Me.txtPointID.TabIndex = 5
        '
        'btnADD
        '
        Me.btnADD.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.btnADD.Location = New System.Drawing.Point(487, 586)
        Me.btnADD.Name = "btnADD"
        Me.btnADD.Size = New System.Drawing.Size(157, 47)
        Me.btnADD.TabIndex = 55
        Me.btnADD.Text = "เพิ่ม"
        Me.btnADD.UseVisualStyleBackColor = True
        '
        'pointform
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.IndianRed
        Me.ClientSize = New System.Drawing.Size(1224, 651)
        Me.Controls.Add(Me.btnADD)
        Me.Controls.Add(Me.btnCanpoint)
        Me.Controls.Add(Me.btnSearch)
        Me.Controls.Add(Me.btnConpoint)
        Me.Controls.Add(Me.DateTimePicker1)
        Me.Controls.Add(Me.cbGameID)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.txtPoint)
        Me.Controls.Add(Me.txtPointID)
        Me.Controls.Add(Me.txtPlayIDPoint)
        Me.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Name = "pointform"
        Me.Text = "point"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btnCanpoint As Button
    Friend WithEvents btnConpoint As Button
    Friend WithEvents DateTimePicker1 As DateTimePicker
    Friend WithEvents cbGameID As ComboBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents txtPoint As TextBox
    Friend WithEvents txtPlayIDPoint As TextBox
    Friend WithEvents btnSearch As Button
    Friend WithEvents Label6 As Label
    Friend WithEvents txtPointID As TextBox
    Friend WithEvents btnADD As Button
End Class
