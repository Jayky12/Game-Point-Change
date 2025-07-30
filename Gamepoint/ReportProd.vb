Imports System.Data
Imports System.Data.OleDb
Imports Microsoft.Reporting.WinForms
Public Class ReportProd
    Dim conn As OleDbConnection
    Dim objAdapter As OleDbDataAdapter
    Dim strCmd As String
    Private Sub ReportProd_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        conn = connectDB()

        strCmd = "SELECT UserDetail.PlayerID, UserDetail.username, ExchangeHistory.ExchangeID, ExchangeHistory.ProductID, ExchangeHistory.Date FROM UserDetail INNER JOIN ExchangeHistory ON UserDetail.PlayerID = 
 ExchangeHistory.PlayerID "
        ' Dim cmd As New OleDbCommand(strCmd, conn)
        objAdapter = New OleDbDataAdapter(strCmd, conn)
        Dim dt As New DataTable
        objAdapter.Fill(dt)
        Dim datasource As New ReportDataSource("Dataset1", dt)
        Me.ReportViewer1.LocalReport.DataSources.Clear()
        Me.ReportViewer1.LocalReport.DataSources.Add(datasource)
        Me.ReportViewer1.RefreshReport()
    End Sub


End Class