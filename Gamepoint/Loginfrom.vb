Imports System.Data.OleDb

Public Class Loginfrom
    Dim conn As OleDbConnection
    Dim objAdapter As OleDbDataAdapter
    Dim objDataset As DataSet
    Dim objRow As DataRow
    Dim objCmd As OleDbCommand
    Dim dt As DataTable
    Dim sql As String
    Dim no_record As Integer
    Private Sub Loginfrom_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        txtPassword.UseSystemPasswordChar = True

    End Sub
    Private Sub btnLogin_Click(sender As Object, e As EventArgs) Handles btnLogin.Click
        conn = connectDB()
        sql = "select * from UserDetail where username='" & txtUser.Text.Trim & "' AND password='" & txtPassword.Text.Trim & "'"
        objAdapter = New OleDbDataAdapter(sql, conn)
        Try
            If conn.State = ConnectionState.Open Then conn.Close()
            conn.Open()
            dt = New DataTable
            objAdapter.Fill(dt)
            If dt.Rows.Count > 0 Then
                username = dt.Rows(0)("username")
                Dim frm As New Menu
                frm.Show()
                Me.Hide()
            Else
                MessageBox.Show("Username หรือ Password ไม่ถูกต้อง", "ข้อความจากระบบ", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                objAdapter.Dispose()
                txtUser.Focus()
                conn.Close()
            End If
            objAdapter.Dispose()
            conn.Close()
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)

        End Try
    End Sub

    Private Sub btnRegis_Click(sender As Object, e As EventArgs) Handles btnRegis.Click
        Regisfrom.Show()
        Me.Hide()
    End Sub
End Class