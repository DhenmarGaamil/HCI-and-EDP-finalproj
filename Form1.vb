Imports System.Data.OleDb

Public Class Form1

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        singup.Show()
        Me.Hide()

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim dbConnection As New OleDbConnection(connString)
        Dim dbCommand As New OleDbCommand
        Dim dbReader As OleDbDataReader

        Try
            dbCommand.CommandText = "SELECT * FROM users WHERE user_name = '" & txtusername.Text & "' AND pass_word = '" & txtpassword.Text & "'"
            dbCommand.Connection = dbConnection
            dbConnection.Open()
            dbReader = dbCommand.ExecuteReader
            If Not dbReader.HasRows Then
                MsgBox("USERNAME OR PASSWORD NOT FOUND")
                txtpassword.Clear()
                txtusername.Clear()

            Else
                dbReader.Read()
                If (dbReader("user_role") = "student") Then
                    MsgBox(" You are now Logged in as student")
                    student.Show()
                    Me.Hide()
                    txtpassword.Clear()
                    txtusername.Clear()
                ElseIf (dbReader("user_role") = "faculty") Then
                    MsgBox("You are now Logged in as Teacher")
                    txtpassword.Clear()
                    txtusername.Clear()
                    faculty.Show()
                    Me.Hide()

                End If
            End If

            dbConnection.Close()

        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "ERROR")
        End Try
    End Sub

    Private Sub CheckBox1_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox1.CheckedChanged
        If CheckBox1.Checked = True Then
            txtpassword.UseSystemPasswordChar = False

        Else

            txtpassword.UseSystemPasswordChar = True

        End If
    End Sub

    Private Sub txtusername_TextChanged(sender As Object, e As EventArgs) Handles txtusername.TextChanged

    End Sub
End Class
