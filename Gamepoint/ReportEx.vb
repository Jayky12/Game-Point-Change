Imports System.Data
Imports System.Data.OleDb
Imports Microsoft.Reporting.WinForms

Public Class ReportEx
    Dim conn As OleDbConnection
    Dim objAdapter As OleDbDataAdapter
    Dim strCmd As String

    Private Sub ReportEx_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        conn = connectDB()

        strCmd = "SELECT UserDetail.PlayerID, UserDetail.username, PointHistory.PointID, PointHistory.GameID, PointHistory.CountPoint, PointHistory.Date FROM UserDetail INNER JOIN PointHistory ON UserDetail.PlayerID = 
 PointHistory.PlayerID "
        ' Dim cmd As New OleDbCommand(strCmd, conn)
        objAdapter = New OleDbDataAdapter(strCmd, conn)
 Dim dt As New DataTable
 objAdapter.Fill(dt)
        Dim datasource As New ReportDataSource("ExchageDataset", dt)
        Me.ReportViewer1.LocalReport.DataSources.Clear()
 Me.ReportViewer1.LocalReport.DataSources.Add(datasource)
 Me.ReportViewer1.RefreshReport()


    End Sub


End Class