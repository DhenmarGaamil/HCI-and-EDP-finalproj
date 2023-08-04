Imports System.Data.OleDb

Public Class singup
    Private str As String

    Private Property dbReader As Object

    Private Sub btnreg_Click(sender As Object, e As EventArgs) Handles btnreg.Click
        Dim dbConnection As New OleDbConnection(connString)
        Dim dbCommand As New OleDbCommand
        dbConnection.Open()
        Try
            str = "INSERT INTO users(user_name, pass_word, user_role) VALUES (@a0,@a1,@a2)"
            dbCommand.CommandText = str
            dbCommand.Connection = dbConnection
            dbCommand.Parameters.AddWithValue("@a0", txtusername.Text)
            dbCommand.Parameters.AddWithValue("@a1", txtpassword.Text)
            dbCommand.Parameters.AddWithValue("@a2", cmbrole.SelectedItem)
            dbCommand.ExecuteNonQuery()
            dbCommand.Dispose()
            dbConnection.Close()
            MessageBox.Show("REGISTERED")
            emptytextboxes()
            Me.Hide()
            Form1.Show()

        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "ERROR")

        End Try
    End Sub

    Public Sub emptytextboxes()
        txtpassword.Clear()
        txtusername.Clear()

    End Sub
End Class