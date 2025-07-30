Imports System.Data
Imports System.Data.Common
Imports System.Data.OleDb
Imports System.Runtime.CompilerServices.RuntimeHelpers
Imports System.Windows.Forms.VisualStyles.VisualStyleElement

Public Class user
    Dim conn As OleDbConnection
    Dim objAdapter As OleDbDataAdapter
    Dim objDataset As DataSet
    Dim objRow As DataRow
    Dim objCmd As OleDbCommand
    Dim dt As DataTable
    Dim sql As String
    Dim no_record As Integer
    Dim chkInsert As Boolean = False

    Sub disableButton()
        btnAdd.Enabled = False
        btnCon.Enabled = True
        btnCan.Enabled = True
        btnDel.Enabled = False
        btnsearch.Enabled = True
    End Sub

    Sub enableButton()
        btnAdd.Enabled = True
        btnCon.Enabled = True
        btnCan.Enabled = True
        btnDel.Enabled = True
        btnsearch.Enabled = True
    End Sub

    Sub clearControl()
        txtAdd.Text = ""
        txtEmail.Text = ""
        txtFisrtn.Text = ""
        txtLastn.Text = ""
        txtPass.Text = ""
        txtPhone.Text = ""
        txtPlayID.Text = ""
        txtUser.Text = ""
    End Sub
    Sub autoid()
        Dim objDataset2 As DataSet = New DataSet
        conn = connectDB()
        sql = "select max(PlayerID) as maxid from UserDetail"
        objAdapter = New OleDbDataAdapter(sql, conn)
        objAdapter.Fill(objDataset2, "dtMaxPlayerID")
        Dim maxid As String
        maxid = objDataset2.Tables("dtMaxPlayerID").Rows(0).Item("maxid")
        MsgBox(maxid)
        Dim newid As Integer
        newid = Mid(maxid, 2, 4)
        newid = newid + 1
        If Len(CStr(newid)) = 1 Then
            txtPlayID.Text = "P00" & newid
        ElseIf Len(CStr(newid)) = 2 Then
            txtPlayID.Text = "P0" & newid
        ElseIf Len(CStr(newid)) = 3 Then
            txtPlayID.Text = "P" & newid
        End If
        txtPlayID.Enabled = False

    End Sub
    Private Sub btnAdd_Click(sender As Object, e As EventArgs) Handles btnAdd.Click
        disableButton()
        chkInsert = True
        txtPlayID.Focus()
        autoid()
    End Sub

    Private Sub user_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        conn = connectDB()
        sql = "select * from UserDetail"
        objAdapter = New OleDbDataAdapter(sql, conn)
        objDataset = New DataSet()
        objAdapter.Fill(objDataset, "dtUserDetail")

        txtPlayID.Focus()
        btnCon.Enabled = False
    End Sub


    Private Sub btnCon_Click(sender As Object, e As EventArgs) Handles btnCon.Click
        conn = connectDB()
        If chkInsert = True Then
            sql = "INSERT INTO UserDetail(PlayerID, Firstname, Lastname, Address, [telephone], Email, username, [password]) VALUES (?, ?, ?, ?, ?, ?, ?, ?)"
            objCmd = New OleDbCommand(sql, conn)
            objCmd.Parameters.AddWithValue("@PlayerID", txtPlayID.Text)
            objCmd.Parameters.AddWithValue("@Firstname", txtFisrtn.Text)
            objCmd.Parameters.AddWithValue("@Lastname", txtLastn.Text)
            objCmd.Parameters.AddWithValue("@Address", txtAdd.Text)
            objCmd.Parameters.AddWithValue("@telephone", txtPhone.Text)
            objCmd.Parameters.AddWithValue("@Email", txtEmail.Text)
            objCmd.Parameters.AddWithValue("@username", txtUser.Text)
            objCmd.Parameters.AddWithValue("@password", txtPass.Text)
            no_record = objCmd.ExecuteNonQuery()
            If no_record >= 1 Then
                MsgBox("เพิ่มข้อมูลเรียบร้อยแล้ว")
            Else
                MsgBox("ไม่สามารถเพิ่มข้อมูลได้")
            End If
        Else
            sql = "UPDATE UserDetail SET Firstname=?, Lastname=?, Address=?, [telephone], Email=?, username=?, [password]=?, WHERE PlayerID=?"
            objCmd = New OleDbCommand(sql, conn)
            objCmd.Parameters.AddWithValue("@Firstname", txtFisrtn.Text)
            objCmd.Parameters.AddWithValue("@Lastname", txtLastn.Text)
            objCmd.Parameters.AddWithValue("@Address", txtAdd.Text)
            objCmd.Parameters.AddWithValue("@telephone", txtPhone.Text)
            objCmd.Parameters.AddWithValue("@Email", txtEmail.Text)
            objCmd.Parameters.AddWithValue("@username", txtUser.Text)
            objCmd.Parameters.AddWithValue("@password", txtPass.Text)
            objCmd.Parameters.AddWithValue("@PlayerID", txtPlayID.Text)
            no_record = objCmd.ExecuteNonQuery()
            If no_record >= 1 Then
                MsgBox("แก้ไขข้อมูลเรียบร้อยแล้ว")
            Else
                MsgBox("ไม่สามารถแก้ไขข้อมูลเรียบร้อยแล้ว")
            End If
        End If
        enableButton()
        clearControl()
        btnCon.Enabled = False
    End Sub
    Private Sub btnCan_Click(sender As Object, e As EventArgs) Handles btnCan.Click
        txtPlayID.Text = ""
        txtAdd.Text = ""
        txtEmail.Text = ""
        txtFisrtn.Text = ""
        txtLastn.Text = ""
        txtPass.Text = ""
        txtPhone.Text = ""
        txtUser.Text = ""
        txtPlayID.Enabled = True
        enableButton()
    End Sub

    Private Sub btnSearch_Click(sender As Object, e As EventArgs) Handles btnsearch.Click

        userdata.Show()
        enableButton()
    End Sub

    Private Sub btnDel_Click(sender As Object, e As EventArgs) Handles btnDel.Click
        conn = connectDB()
        sql = "delete from UserDetail where PlayerID='" & txtPlayID.Text & "'"
        If MessageBox.Show("ต้องการลบข้อมูลใช่หรือไม่ ?", "ยืนยันการลบข้อมูล", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) = Windows.Forms.DialogResult.Yes Then
            objCmd = New OleDbCommand(sql, conn)
            objCmd.ExecuteNonQuery()
            MsgBox("ลบข้อมูลแล้วจำนวน 1 Record")
        End If
        conn.Close()
    End Sub

    Private Sub txtPlayID_TextChanged(sender As Object, e As EventArgs) Handles txtPlayID.TextChanged
        conn = connectDB()
        sql = "select * from UserDetail
                where PlayerID ='" & txtPlayID.Text & "'"
        objAdapter = New OleDbDataAdapter(sql, conn)
        objDataset = New DataSet()
        objAdapter.Fill(objDataset, "dtPlayer")
        For Each objRow In objDataset.Tables("dtPlayer").Rows
            txtFisrtn.Text = objRow("Firstname")
            txtLastn.Text = objRow("Lastname")
            txtAdd.Text = objRow("Address")
            txtPhone.Text = objRow("telephone")
            txtEmail.Text = objRow("Email")
            txtUser.Text = objRow("username")
            txtPass.Text = objRow("password")
        Next
    End Sub
End Class