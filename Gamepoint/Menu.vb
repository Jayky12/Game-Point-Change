Imports System.Data.OleDb
Imports System.Reflection
Imports System.Reflection.Emit
Imports System.Windows.Forms.VisualStyles.VisualStyleElement

Public Class Menu
    Dim conn As OleDbConnection
    Dim objAdapter As OleDbDataAdapter
    Dim objDataset As DataSet
    Dim objRow As DataRow
    Dim objCmd As OleDbCommand
    Dim sql As String
    Dim no_record As Integer
    Dim chkInsert As Boolean = False
    Sub openForm(ByVal formToOpen As Form)

        For Each childForm As Form In Me.MdiChildren
            childForm.Close()
        Next


        formToOpen.MdiParent = Me
        formToOpen.Show()
    End Sub
    Public Sub New()
        InitializeComponent()
        Me.IsMdiContainer = True
    End Sub

    Private Sub ชอมลผใชToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ชอมลผใชToolStripMenuItem.Click
        Dim newForm As New user()
        openForm(newForm)
    End Sub

    Private Sub ดแตมToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ดแตมToolStripMenuItem.Click
        Dim newForm As New PointTable()
        openForm(newForm)
    End Sub

    Private Sub รบแตมToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles รบแตมToolStripMenuItem.Click
        Dim newForm As New pointform()
        openForm(newForm)
    End Sub

    Private Sub แลกแตมToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles แลกแตมToolStripMenuItem.Click
        Dim newForm As New Exchange()
        openForm(newForm)
    End Sub

    Private Sub รายงานToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles รายงานToolStripMenuItem.Click

    End Sub

    Private Sub รายงานประวตการรบแตมToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles รายงานประวตการรบแตมToolStripMenuItem.Click
        Dim newForm As New ReportEx()
        openForm(newForm)
    End Sub

    Private Sub รายงานประวตการแลกสนคาToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles รายงานประวตการแลกสนคาToolStripMenuItem.Click
        Dim newForm As New ReportProd()
        openForm(newForm)
    End Sub
End Class