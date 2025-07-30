Imports System.Data
Imports System.Data.OleDb
Module connection
    Public conn As OleDbConnection
    Public strCon As String = "Provider=Microsoft.Ace.OleDb.12.0;" &
                "Data Source=D:\gamepoint.accdb;User ID=; Password=;" &
                 "Persist Security Info=False"
    Public username As String
    Function connectDB() As System.Data.OleDb.OleDbConnection
        conn = New OleDbConnection()
        With conn
            If .State = ConnectionState.Closed Then
                .ConnectionString = strCon
            End If
        End With
        conn.Open()
        Return conn
    End Function
End Module
