Imports System.Data
Imports System.Data.Common
Imports System.Data.OleDb
Imports System.Runtime.CompilerServices.RuntimeHelpers
Imports System.Windows.Forms.VisualStyles.VisualStyleElement
Public Class Exchange
    Dim conn As OleDbConnection
    Dim objAdapter As OleDbDataAdapter
    Dim objDataset As DataSet
    Dim objRow As DataRow
    Dim objCmd As OleDbCommand
    Dim sql As String
    Dim no_record As Integer
    Dim chkInsert As Boolean = False
    Sub autoid()
        Dim objDataset2 As DataSet = New DataSet
        conn = connectDB()
        sql = "select max(ExchangeID) as maxid from ExchangeHistory"
        objAdapter = New OleDbDataAdapter(sql, conn)
        objAdapter.Fill(objDataset2, "dtMaxExID")
        Dim maxid As Object = objDataset2.Tables("dtMaxExID").Rows(0).Item("maxid")

        If Not IsDBNull(maxid) Then
            Dim newid As Integer = Integer.Parse(Mid(maxid.ToString(), 2, 4)) + 1
            txtExID.Text = newid.ToString().PadLeft(5, "0"c)
        Else
            txtExID.Text = "00001"
        End If

        txtExID.Enabled = False
    End Sub
    Sub disableButton()
        btnAdd.Enabled = False
        btnExchange.Enabled = True
        btnCan.Enabled = True
        btnSearch.Enabled = True
    End Sub
    Sub enableButton()
        btnAdd.Enabled = True
        btnExchange.Enabled = True
        btnCan.Enabled = True
        btnSearch.Enabled = True
    End Sub
    Private Sub Exchange_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        conn = connectDB()
        sql = "select * from Product"
        objAdapter = New OleDbDataAdapter(sql, conn)
        objDataset = New DataSet()
        objAdapter.Fill(objDataset, "dtProduct")
        cbProduct.DataSource = objDataset.Tables("dtProduct")
        cbProduct.DisplayMember = "ProductName"
        cbProduct.ValueMember = "ProductID"
    End Sub

    Private Sub btnAdd_Click(sender As Object, e As EventArgs) Handles btnAdd.Click
        disableButton()
        chkInsert = True
        txtPlayIDEx.Focus()
        autoid()
    End Sub

    Private Sub btnSearch_Click(sender As Object, e As EventArgs) Handles btnSearch.Click
        userdata.Show()
    End Sub

    Private Sub btnExchange_Click(sender As Object, e As EventArgs) Handles btnExchange.Click
        conn = connectDB()
        If chkInsert = True Then
            sql = "INSERT INTO ExchangeHistory(ExchangeID, PlayerID, ProductID, [Date]) VALUES (?, ?, ?, ?)"
            objCmd = New OleDbCommand(sql, conn)
            objCmd.Parameters.AddWithValue("ExchangeID", txtExID.Text)
            objCmd.Parameters.AddWithValue("PlayerID", txtPlayIDEx.Text)
            objCmd.Parameters.AddWithValue("ProductID", cbProduct.SelectedValue)
            objCmd.Parameters.AddWithValue("Date", DateTimePicker1.Value)
            no_record = objCmd.ExecuteNonQuery()
            If no_record >= 1 Then
                MsgBox("เพิ่มข้อมูลเรียบร้อยแล้ว")
            Else
                MsgBox("ไม่สามารถเพิ่มข้อมูลได้")
            End If
        Else
            sql = "UPDATE ExchangeHistory SET PlayerID=?, ProductID=?, [Date]=? WHERE ExchangeID=?"
            objCmd = New OleDbCommand(sql, conn)
            objCmd.Parameters.AddWithValue("PlayerID", txtPlayIDEx.Text)
            objCmd.Parameters.AddWithValue("ProductID", cbProduct.SelectedValue)
            objCmd.Parameters.AddWithValue("Date", DateTimePicker1.Value)
            objCmd.Parameters.AddWithValue("ExchangeID", txtExID.Text)
            no_record = objCmd.ExecuteNonQuery()
            If no_record >= 1 Then
                MsgBox("แก้ไขข้อมูลเรียบร้อยแล้ว")
            Else
                MsgBox("ไม่สามารถแก้ไขข้อมูลเรียบร้อยแล้ว")
            End If
        End If

        Dim currentPoint As Integer
        Dim sqlGetCurrentPoint As String = "SELECT point FROM UserDetail WHERE PlayerID = ?"
        objCmd = New OleDbCommand(sqlGetCurrentPoint, conn)
        objCmd.Parameters.AddWithValue("PlayerID", txtPlayIDEx.Text)
        currentPoint = CInt(objCmd.ExecuteScalar())

        ' ดึงค่า countpoint จากตาราง history และบวกเข้ากับค่า point ปัจจุบัน
        Dim countPointToAdd As Integer
        Dim sqlGetCountPoint As String = "SELECT SUM(Cost) FROM Product WHERE ProductID = ?"
        objCmd = New OleDbCommand(sqlGetCountPoint, conn)
        objCmd.Parameters.AddWithValue("PointID", cbProduct.Text)
        Dim sumCountPoint As Object = objCmd.ExecuteScalar()
        If Not IsDBNull(sumCountPoint) Then
            countPointToAdd = CInt(sumCountPoint)
        Else
            countPointToAdd = 0
        End If

        ' บวกค่า countpoint กับค่า point ปัจจุบัน
        Dim updatedPoint As Integer = currentPoint - countPointToAdd

        ' อัปเดตค่า point ในตาราง UserDetail
        Dim sqlUpdatePoint As String = "UPDATE UserDetail SET point = ? WHERE PlayerID = ?"
        objCmd = New OleDbCommand(sqlUpdatePoint, conn)
        objCmd.Parameters.AddWithValue("point", updatedPoint)
        objCmd.Parameters.AddWithValue("PlayerID", txtPlayIDEx.Text)
        Dim recordsAffected As Integer = objCmd.ExecuteNonQuery()

        ' ตรวจสอบว่ามีการอัปเดตค่า point สำเร็จหรือไม่
        If recordsAffected >= 1 Then
            MsgBox("อัปเดตคะแนนเรียบร้อยแล้ว")
        Else
            MsgBox("ไม่สามารถอัปเดตคะแนนได้")
        End If

    End Sub

    Private Sub btnCan_Click(sender As Object, e As EventArgs) Handles btnCan.Click
        txtExID.Text = ""
        txtPlayIDEx.Text = ""
        cbProduct.Text = ""
        DateTimePicker1.Text = ""
        enableButton()
    End Sub

    Private Sub cbProduct_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbProduct.SelectedIndexChanged

    End Sub

    Private Sub DateTimePicker1_ValueChanged(sender As Object, e As EventArgs) Handles DateTimePicker1.ValueChanged

    End Sub

    Private Sub Label5_Click(sender As Object, e As EventArgs) Handles Label5.Click

    End Sub

    Private Sub Label4_Click(sender As Object, e As EventArgs) Handles Label4.Click

    End Sub

    Private Sub Label6_Click(sender As Object, e As EventArgs) Handles Label6.Click

    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click

    End Sub

    Private Sub txtExID_TextChanged(sender As Object, e As EventArgs) Handles txtExID.TextChanged

    End Sub

    Private Sub txtPlayIDEx_TextChanged(sender As Object, e As EventArgs) Handles txtPlayIDEx.TextChanged

    End Sub
End Class