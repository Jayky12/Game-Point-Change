Imports System.Data.OleDb
Imports System.Windows.Forms.VisualStyles.VisualStyleElement

Public Class PointTable
    Dim conn As OleDbConnection
    Dim objAdapter As OleDbDataAdapter
    Dim objDataset As DataSet
    Dim objRow As DataRow
    Dim objCmd As OleDbCommand
    Dim dt As DataTable
    Dim sql As String
    Dim no_record As Integer
    Private Sub PointTable_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        conn = connectDB()
        sql = "select PlayerID, username, point from UserDetail"
        objAdapter = New OleDbDataAdapter(sql, conn)
        objDataset = New DataSet()
        objAdapter.Fill(objDataset, "dtUserDetail")
        DataGridView1.DataSource = objDataset
        DataGridView1.DataMember = "dtUserDetail"


    End Sub
End Class