Imports System.Data.OleDb

Public Class student
    Dim dbConnection As OleDbConnection
    Dim da As OleDbDataAdapter
    Dim ds As DataSet
    Dim tables As DataTableCollection
    Dim source As New BindingSource
    Public index As Integer

    Private Sub student_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        loadtable()
        DataGridView1.Font = New Font("Tw Cen MT", 10)
    End Sub

    Private Sub txtSearch_TextChanged(sender As Object, e As EventArgs) Handles txtSearch.TextChanged
        dbConnection = New OleDbConnection
        dbConnection.ConnectionString = connString()
        ds = New DataSet
        tables = ds.Tables
        da = New OleDbDataAdapter("Select * from [students]", dbConnection)
        da.Fill(ds, "request")
        Dim view As New DataView(tables(0))
        view.RowFilter = String.Format("STUDENT_ID like '%{0}%'", txtSearch.Text)
        DataGridView1.DataSource = view
    End Sub

    Private Sub loadtable()
        dbConnection = New OleDbConnection
        dbConnection.ConnectionString = connString()
        ds = New DataSet
        tables = ds.Tables
        da = New OleDbDataAdapter("Select * from [students]", dbConnection)
        da.Fill(ds, "students")
        Dim view As New DataView(tables(0))
        source.DataSource = view
        DataGridView1.DataSource = view
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        MsgBox("SUCCESSFUL LOGGED OUT")
        End


    End Sub

    Private Sub DataGridView1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellContentClick
        index = e.RowIndex
        Dim selectedRow As New DataGridViewRow
        selectedRow = DataGridView1.Rows(index)
        txtstudentid.Text = selectedRow.Cells(0).Value.ToString()
        txtname.Text = selectedRow.Cells(1).Value.ToString()
        cmbcourse.SelectedItem = selectedRow.Cells(2).Value.ToString()
        cmbyrlvl.SelectedItem = selectedRow.Cells(3).Value.ToString()
        cmbsection.SelectedItem = selectedRow.Cells(4).Value.ToString()
        txtstatus.Text = selectedRow.Cells(5).Value.ToString()
        midtergrade.Text = selectedRow.Cells(22).Value.ToString()
        finalgrade.Text = selectedRow.Cells(23).Value.ToString()

    End Sub

    Private Sub Label3_Click(sender As Object, e As EventArgs) Handles Label3.Click

    End Sub
End Class