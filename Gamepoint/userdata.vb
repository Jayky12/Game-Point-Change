Imports System.Data
Imports System.Data.Common
Imports System.Data.OleDb
Public Class userdata
    Dim conn As OleDbConnection
    Dim objAdapter As OleDbDataAdapter
    Dim objDataset As DataSet
    Dim objRow As DataRow
    Dim sql As String
    Private Sub userdata_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        conn = connectDB()
        sql = "select * from UserDetail"
        objAdapter = New OleDbDataAdapter(sql, conn)
        objDataset = New DataSet()
        objAdapter.Fill(objDataset, "dtUserDetail")
        DataGridView1.DataSource = objDataset
        DataGridView1.DataMember = "dtUserDetail"
        TextBox1.Focus()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        sql = "select * from UserDetail
                where PlayerID like '%" & TextBox1.Text & "%' or Firstname like '%" & TextBox1.Text & "%' or Lastname like '%" & TextBox1.Text & "%'"
        objAdapter = New OleDbDataAdapter(sql, conn)
        objDataset = New DataSet()
        objAdapter.Fill(objDataset, "dtUserDetail1")
        DataGridView1.DataSource = objDataset
        DataGridView1.DataMember = "dtUserDetail1"
    End Sub

    Private Sub DataGridView1_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellClick
        'pointform.txtPlayIDPoint.Text = DataGridView1.SelectedCells(0).Value
        'Exchange.txtPlayIDEx.Text = DataGridView1.SelectedCells(0).Value
        user.txtPlayID.Text = DataGridView1.SelectedCells(0).Value
        MessageBox.Show(DataGridView1.SelectedCells(0).Value)
        Me.Hide()
    End Sub


End Class
