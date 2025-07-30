Imports System.Data
Imports System.Data.Common
Imports System.Data.OleDb
Imports System.Reflection
Imports System.Runtime.CompilerServices.RuntimeHelpers
Imports System.Windows.Forms.VisualStyles.VisualStyleElement
Public Class pointform
    Dim conn As OleDbConnection
    Dim objAdapter As OleDbDataAdapter
    Dim objDataset As DataSet
    Dim objRow As DataRow
    Dim objCmd As OleDbCommand
    Dim sql As String
    Dim no_record As Integer
    Dim total As Integer
    Dim chkInsert As Boolean = False
    Sub autoid()
        Dim objDataset2 As DataSet = New DataSet
        conn = connectDB()
        sql = "select max(PointID) as maxid from PointHistory"
        objAdapter = New OleDbDataAdapter(sql, conn)
        objAdapter.Fill(objDataset2, "dtMaxPointID")
        Dim maxid As Object = objDataset2.Tables("dtMaxPointID").Rows(0).Item("maxid")

        If Not IsDBNull(maxid) Then
            Dim newid As Integer = Integer.Parse(Mid(maxid.ToString(), 2, 4)) + 1
            txtPointID.Text = newid.ToString().PadLeft(5, "0"c)
        Else
            txtPointID.Text = "00001"
        End If

        txtPointID.Enabled = False
    End Sub
    Sub disableButton()
        btnADD.Enabled = False
        btnConpoint.Enabled = True
        btnCanpoint.Enabled = True
        btnSearch.Enabled = True
    End Sub
    Sub enableButton()
        btnADD.Enabled = True
        btnConpoint.Enabled = True
        btnCanpoint.Enabled = True
        btnSearch.Enabled = True
    End Sub
    Private Sub point_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        conn = connectDB()
        sql = "select * from GameDetail"
        objAdapter = New OleDbDataAdapter(sql, conn)
        objDataset = New DataSet()
        objAdapter.Fill(objDataset, "dtGameID")
        cbGameID.DataSource = objDataset.Tables("dtGameID")
        cbGameID.DisplayMember = "GameName"
        cbGameID.ValueMember = "GameID"

        sql = "select * from UserDetail"
        objAdapter = New OleDbDataAdapter(sql, conn)
        objDataset = New DataSet()
        objAdapter.Fill(objDataset, "dtUserDetail1")

    End Sub
    Private Sub btnADD_Click(sender As Object, e As EventArgs) Handles btnADD.Click
        disableButton()
        chkInsert = True
        txtPlayIDPoint.Focus()
        autoid()
    End Sub
    Private Sub btnSearch_Click(sender As Object, e As EventArgs) Handles btnSearch.Click
        userdata.Show()
    End Sub

    Private Sub btnConpoint_Click(sender As Object, e As EventArgs) Handles btnConpoint.Click
        conn = connectDB()
        If chkInsert = True Then
            sql = "INSERT INTO PointHistory(PointID, PlayerID, GameID, [CountPoint], [Date]) VALUES (?, ?, ?, ?, ?)"
            objCmd = New OleDbCommand(sql, conn)
            objCmd.Parameters.AddWithValue("PointID", txtPointID.Text)
            objCmd.Parameters.AddWithValue("PlayerID", txtPlayIDPoint.Text)
            objCmd.Parameters.AddWithValue("GameID", cbGameID.SelectedValue)
            objCmd.Parameters.AddWithValue("CountPoint", txtPoint.Text)
            objCmd.Parameters.AddWithValue("Date", DateTimePicker1.Value)
            no_record = objCmd.ExecuteNonQuery()

            If no_record >= 1 Then
                MsgBox("เพิ่มข้อมูลเรียบร้อยแล้ว")
            Else
                MsgBox("ไม่สามารถเพิ่มข้อมูลได้")
            End If
        Else


            sql = "UPDATE PointHistory SET PlayerID=?, GameID=?, [CountPoint]=?, [Date]=? WHERE PointID=?"
            objCmd = New OleDbCommand(sql, conn)
            objCmd.Parameters.AddWithValue("PlayerID", txtPlayIDPoint.Text)
            objCmd.Parameters.AddWithValue("GameID", cbGameID.SelectedValue)
            objCmd.Parameters.AddWithValue("CountPoint", txtPoint.Text)
            objCmd.Parameters.AddWithValue("Date", DateTimePicker1.Value)
            objCmd.Parameters.AddWithValue("PointID", txtPointID.Text)
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
        objCmd.Parameters.AddWithValue("PlayerID", txtPlayIDPoint.Text)
        currentPoint = CInt(objCmd.ExecuteScalar())

        ' ดึงค่า countpoint จากตาราง history และบวกเข้ากับค่า point ปัจจุบัน
        Dim countPointToAdd As Integer
        Dim sqlGetCountPoint As String = "SELECT SUM(CountPoint) FROM PointHistory WHERE PointID = ?"
        objCmd = New OleDbCommand(sqlGetCountPoint, conn)
        objCmd.Parameters.AddWithValue("PointID", txtPointID.Text)
        Dim sumCountPoint As Object = objCmd.ExecuteScalar()
        If Not IsDBNull(sumCountPoint) Then
            countPointToAdd = CInt(sumCountPoint)
        Else
            countPointToAdd = 0
        End If

        ' บวกค่า countpoint กับค่า point ปัจจุบัน
        Dim updatedPoint As Integer = currentPoint + countPointToAdd

        ' อัปเดตค่า point ในตาราง UserDetail
        Dim sqlUpdatePoint As String = "UPDATE UserDetail SET point = ? WHERE PlayerID = ?"
        objCmd = New OleDbCommand(sqlUpdatePoint, conn)
        objCmd.Parameters.AddWithValue("point", updatedPoint)
        objCmd.Parameters.AddWithValue("PlayerID", txtPlayIDPoint.Text)
        Dim recordsAffected As Integer = objCmd.ExecuteNonQuery()

        ' ตรวจสอบว่ามีการอัปเดตค่า point สำเร็จหรือไม่
        If recordsAffected >= 1 Then
            MsgBox("อัปเดตคะแนนเรียบร้อยแล้ว")
        Else
            MsgBox("ไม่สามารถอัปเดตคะแนนได้")
        End If

    End Sub

    Private Sub btnCanpoint_Click(sender As Object, e As EventArgs) Handles btnCanpoint.Click
        txtPointID.Text = ""
        txtPlayIDPoint.Text = ""
        cbGameID.Text = ""
        txtPoint.Text = ""
        DateTimePicker1.Text = ""
        enableButton()
    End Sub


End Class