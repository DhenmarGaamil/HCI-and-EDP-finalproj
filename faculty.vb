Imports System.Data.OleDb

Public Class faculty
    Dim dbConnection As OleDbConnection
    Dim dbCommand As OleDbCommand
    Private strsql As String
    Dim dbdreader As OleDbDataReader
    Dim da As OleDbDataAdapter
    Dim ds As DataSet
    Dim tables As DataTableCollection
    Dim source As New BindingSource
    Dim table As New DataTable
    Public index As Integer

    Private Sub btnsave_Click(sender As Object, e As EventArgs) Handles btnsave.Click
        Dim dbConnection As New OleDbConnection(connString)
        Dim dbCommand As New OleDbCommand
        dbConnection.Open()
        Try
            strsql = "INSERT INTO students(STUDENT_ID, STUDENT_NAME, STUDENT_COURSE, STUDENT_LVL, STUDENT_SECTION, STUDENT_STATUS, M_QUIZ1, M_QUIZ2, M_QUIZ3, M_ACT1, M_ACT2, M_ACT3, M_PROJECT, MIDTERM_RESULT, F_QUIZ1, F_QUIZ2, F_QUIZ3, F_ACT1, F_ACT2, F_ACT3, F_PROJECT, FINAL_RESULT, MIDTERM_GRADE,FINAL_GRADE) VALUES (@a0,@a1,@a2,@a3,@a4,@a5,@a6,@a7,@a8,@a9,@a10,@a11,@a12,@a13,@a14,@a15,@a16,@a17,@a18,@a19,@a20,@a21,@a22,@a23)"
            dbCommand.CommandText = strsql
            dbCommand.Connection = dbConnection
            dbCommand.Parameters.AddWithValue("@a0", txtstudentid.Text)
            dbCommand.Parameters.AddWithValue("@a1", txtname.Text)
            dbCommand.Parameters.AddWithValue("@a2", cmbcourse.SelectedItem)
            dbCommand.Parameters.AddWithValue("@a3", cmbyrlvl.SelectedItem)
            dbCommand.Parameters.AddWithValue("@a4", cmbsection.SelectedItem)
            dbCommand.Parameters.AddWithValue("@a5", txtstatus.Text)
            dbCommand.Parameters.AddWithValue("@a6", txtq1m.Text)
            dbCommand.Parameters.AddWithValue("@a7", txtq2m.Text)
            dbCommand.Parameters.AddWithValue("@a8", txtq3m.Text)
            dbCommand.Parameters.AddWithValue("@a9", txta1m.Text)
            dbCommand.Parameters.AddWithValue("@a10", txta2m.Text)
            dbCommand.Parameters.AddWithValue("@a11", txta3m.Text)
            dbCommand.Parameters.AddWithValue("@a12", txtprojm.Text)
            dbCommand.Parameters.AddWithValue("@a13", txtmresult.Text)
            dbCommand.Parameters.AddWithValue("@a14", txtq1f.Text)
            dbCommand.Parameters.AddWithValue("@a15", txtq2f.Text)
            dbCommand.Parameters.AddWithValue("@a16", txtq3f.Text)
            dbCommand.Parameters.AddWithValue("@a17", txta1f.Text)
            dbCommand.Parameters.AddWithValue("@a18", txta2f.Text)
            dbCommand.Parameters.AddWithValue("@a19", txta3f.Text)
            dbCommand.Parameters.AddWithValue("@a20", txtprojf.Text)
            dbCommand.Parameters.AddWithValue("@a21", txtfresult.Text)
            dbCommand.Parameters.AddWithValue("@a22", midtergrade.Text)
            dbCommand.Parameters.AddWithValue("@a23", finalgrade.Text)

            dbCommand.ExecuteNonQuery()
            dbCommand.Dispose()
            dbConnection.Close()
            MessageBox.Show("SAVE")
            loadtable()
            disabletextboxes()
            emptytextboxes()

        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "ERROR")
        End Try
    End Sub
    Private Sub emptytextboxes()
        txtstudentid.Clear()
        txtname.Clear()
        txtstatus.Clear()
        txtq1m.Clear()
        txtq2m.Clear()
        txtq3m.Clear()
        txta1m.Clear()
        txta2m.Clear()
        txta3m.Clear()
        txtprojm.Clear()
        txtmresult.Clear()
        txtq1f.Clear()
        txtq2f.Clear()
        txtq3f.Clear()
        txta1f.Clear()
        txta2f.Clear()
        txta3f.Clear()
        txtprojf.Clear()
        txtfresult.Clear()
        midtergrade.Clear()
        finalgrade.Clear()
        cmbcourse.SelectedItem = Nothing
        cmbsection.SelectedItem = Nothing
        cmbyrlvl.SelectedItem = Nothing
    End Sub
    Private Sub disabletextboxes()
        txtstudentid.Enabled = false
        txtname.Enabled = False
        txtstatus.Enabled = False
        txtq1m.Enabled = False
        txtq2m.Enabled = False
        txtq3m.Enabled = False
        txta1m.Enabled = False
        txta2m.Enabled = False
        txta3m.Enabled = False
        txtprojm.Enabled = False
        txtmresult.Enabled = False
        txtq1f.Enabled = False
        txtq2f.Enabled = False
        txtq3f.Enabled = False
        txta1f.Enabled = False
        txta2f.Enabled = False
        txta3f.Enabled = False
        txtprojf.Enabled = False
        txtfresult.Enabled = False
        cmbcourse.Enabled = False
        cmbsection.Enabled = False
        cmbyrlvl.Enabled = False
        midtergrade.Enabled = False
        finalgrade.Enabled = False
    End Sub

    Private Sub enabletextboxes()
        txtstudentid.Enabled = True
        txtname.Enabled = True
        txtq1m.Enabled = True
        txtq2m.Enabled = True
        txtq3m.Enabled = True
        txta1m.Enabled = True
        txta2m.Enabled = True
        txta3m.Enabled = True
        txtprojm.Enabled = True
        txtmresult.Enabled = True
        txtq1f.Enabled = True
        txtq2f.Enabled = True
        txtq3f.Enabled = True
        txta1f.Enabled = True
        txta2f.Enabled = True
        txta3f.Enabled = True
        txtprojf.Enabled = True
        txtfresult.Enabled = True
        cmbcourse.Enabled = True
        cmbsection.Enabled = True
        cmbyrlvl.Enabled = True
    End Sub

    Private Sub btnadd_Click(sender As Object, e As EventArgs) Handles btnadd.Click
        emptytextboxes()
        enabletextboxes()

    End Sub

    Private Sub faculty_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        disabletextboxes()
        loadtable()
        DataGridView1.Font = New Font("Tw Cen MT", 10)
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

    Private Sub btnedit_Click(sender As Object, e As EventArgs) Handles btnedit.Click
        enabletextboxes()

    End Sub

    Private Sub faculty_FormClosed(sender As Object, e As FormClosedEventArgs) Handles MyBase.FormClosed
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
        txtq1m.Text = selectedRow.Cells(6).Value.ToString()
        txtq2m.Text = selectedRow.Cells(7).Value.ToString()
        txtq3m.Text = selectedRow.Cells(8).Value.ToString()
        txta1m.Text = selectedRow.Cells(9).Value.ToString()
        txta2m.Text = selectedRow.Cells(10).Value.ToString()
        txta3m.Text = selectedRow.Cells(11).Value.ToString()
        txtprojm.Text = selectedRow.Cells(12).Value.ToString()
        txtmresult.Text = selectedRow.Cells(13).Value.ToString()
        txtq1f.Text = selectedRow.Cells(14).Value.ToString()
        txtq2f.Text = selectedRow.Cells(15).Value.ToString()
        txtq3f.Text = selectedRow.Cells(16).Value.ToString()
        txta1f.Text = selectedRow.Cells(17).Value.ToString()
        txta2f.Text = selectedRow.Cells(18).Value.ToString()
        txta3f.Text = selectedRow.Cells(19).Value.ToString()
        txtprojf.Text = selectedRow.Cells(20).Value.ToString()
        txtfresult.Text = selectedRow.Cells(21).Value.ToString()
        midtergrade.Text = selectedRow.Cells(22).Value.ToString()
        finalgrade.Text = selectedRow.Cells(23).Value.ToString()
    End Sub

    Private Sub GroupBox2_Enter(sender As Object, e As EventArgs) Handles GroupBox2.Enter

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim mproj, firstnumber, secondnumber, thirdnumber, fourthnumber, fifthnumber, sixthnumber As String
        Dim total, midgrade, sumOfact, sumOfquizes, sumz As Double

        firstnumber = txtq1m.Text
        secondnumber = txtq2m.Text
        thirdnumber = txtq3m.Text
        Dim number1 As Integer
        Dim number2 As Integer
        Dim number3 As Integer
        number1 = firstnumber
        number2 = secondnumber
        number3 = thirdnumber
        sumOfquizes = (number1 + number2 + number3)

        fourthnumber = txta1m.Text
        fifthnumber = txta2m.Text
        sixthnumber = txta3m.Text
        Dim number4 As Integer
        Dim number5 As Integer
        Dim number6 As Integer
        number4 = fourthnumber
        number5 = fifthnumber
        number6 = sixthnumber
        sumOfact = (number4 + number5 + number6)
        mproj = Val(txtprojm.Text) * 0.3 + Val(txtmresult.Text) * 0.2
        sumz = sumOfact * 0.3 + sumOfquizes * 0.2
        total = mproj + sumz
        midgrade = total
        midtergrade.Text = midgrade


        Dim fproj, uno, dos, tres, kwatro, sinco, sais As String
        Dim ftotal, figrade, fsumOfact, fsumOfquizes, fsumz As Double
        Dim fadd, fg As Double

        uno = txtq1f.Text
        dos = txtq2f.Text
        tres = txtq3f.Text
        Dim num1 As Integer
        Dim num2 As Integer
        Dim num3 As Integer
        num1 = uno
        num2 = dos
        num3 = tres
        fsumOfquizes = (num1 + num2 + num3)

        kwatro = txta1f.Text
        sinco = txta2f.Text
        sais = txta3f.Text
        Dim num4 As Integer
        Dim num5 As Integer
        Dim num6 As Integer
        num4 = kwatro
        num5 = sinco
        num6 = sais
        fsumOfact = (num4 + num5 + num6)
        fproj = Val(txtprojf.Text)*.30 + Val(txtfresult.Text)*.20
        fsumz = fsumOfact * 0.3 + fsumOfquizes * 0.2
        ftotal = fproj + fsumz
        figrade = ftotal
        fadd = (midgrade * 0.5) + (figrade * 0.5)
        fg = fadd

        If figrade >= 90 Then
            finalgrade.Text = fg & " Rate: A"
            txtstatus.Text = "PASSED"
            txtstatus.ForeColor = Color.Green
        ElseIf figrade >= 80 Then
            finalgrade.Text = fg & " Rate: B"
            txtstatus.Text = "PASSED"
            txtstatus.ForeColor = Color.Green
        ElseIf figrade >= 70 Then
            finalgrade.Text = fg & "Rate: C"
            txtstatus.Text = "FAILED"
            txtstatus.ForeColor = Color.Red
        ElseIf figrade >= 60 Then
            finalgrade.Text = fg & " Rate: D"
            txtstatus.Text = "FAILED"
            txtstatus.ForeColor = Color.Red
        Else
            finalgrade.Text = fg & "Rate: F"
            txtstatus.Text = "FAILED"
            txtstatus.ForeColor = Color.Red
        End If
        MessageBox.Show("GRADE HAS BEEN CALCULATED")
    End Sub

    Private Sub btnsearch_Click(sender As Object, e As EventArgs)
        Dim dbConnection As New OleDbConnection(connString)
        Dim dbCommand As New OleDbCommand
        Dim dbdreader As OleDbDataReader
        Dim sStr As String
        Dim sStudentNo As String
        sStr = InputBox("ENTER THE STUDENT NUMBER", "STUDENT_ID")
        sStudentNo = sStr
        Try
            dbCommand.CommandText = "SELECT * FROM students where STUDENT_ID = '" & sStr & "'"
            dbCommand.Connection = dbConnection
            dbConnection.Open()
            dbdreader = dbCommand.ExecuteReader
            If Not dbdreader.HasRows Then
                MsgBox("Cannot Find a Record")
            Else
                txtstudentid.Text = dbdreader("STUDENT_ID")
                txtname.Text = dbdreader("STUDENT_NAME")
                cmbcourse.SelectedItem = dbdreader("STUDENT_COURSE")
                cmbyrlvl.SelectedItem = dbdreader("STUDENT_LVL")
                cmbsection.SelectedItem = dbdreader("STUDENT_SECTION")
                txtstatus.Text = dbdreader("STUDENT_STATUS")
                txtq1m.Text = dbdreader("M_QUIZ1")
                txtq2m.Text = dbdreader("M_QUIZ2")
                txtq3m.Text = dbdreader("M_QUIZ3")
                txta1m.Text = dbdreader("M_ACT1")
                txta2m.Text = dbdreader("M_ACT2")
                txta3m.Text = dbdreader("M_ACT3")
                txtprojm.Text = dbdreader("M_PROJECT")
                txtmresult.Text = dbdreader("MIDTERM_RESULT")
                txtq1f.Text = dbdreader("F_QUIZ1")
                txtq2f.Text = dbdreader("F_QUIZ2")
                txtq3f.Text = dbdreader("F_QUIZ3")
                txta1f.Text = dbdreader("F_ACT1")
                txta2f.Text = dbdreader("F_ACT2")
                txta3f.Text = dbdreader("F_ACT3")
                txtprojf.Text = dbdreader("F_PROJECT")
                txtfresult.Text = dbdreader("FINAL_RESULT")
                midtergrade.Text = dbdreader("MIDTERM_GRADE")
                finalgrade.Text = dbdreader("FINAL_GRADE")

                dbConnection.Close()

            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub btndelete_Click(sender As Object, e As EventArgs) Handles btndelete.Click
        dbConnection = New OleDbConnection
        dbConnection.ConnectionString = connString()
        Dim str As String
        Try
            If txtstudentid.Text = "" Then
                MessageBox.Show("Select The Students You Want To Delete")
            Else
                dbConnection.Open()
                str = "DELETE * from students where STUDENT_ID ='" & txtstudentid.Text & "'"
                dbCommand = New OleDbCommand(str, dbConnection)
                dbdreader = dbCommand.ExecuteReader
                MessageBox.Show("DELETED")
                dbConnection.Dispose()
                dbConnection.Close()
                emptytextboxes()
                loadtable()
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try

    End Sub

    Private Sub btnupdate_Click(sender As Object, e As EventArgs) Handles btnupdate.Click
        Dim dbConnection As New OleDbConnection(connString)
        Dim dbCommand As New OleDbCommand
        dbConnection.Open()
        Try
            strsql = "UPDATE students SET [STUDENT_NAME]=@a1,[STUDENT_COURSE]=@a2,[STUDENT_LVL]=@a3,[STUDENT_SECTION]=@a4,[STUDENT_STATUS]=@a5,[M_QUIZ1]=@a6,[M_QUIZ2]=@a7,[M_QUIZ3]=@a8,[M_ACT1]=@a9,[M_ACT2]=@a10,[M_ACT3]=@11,[M_PROJECT]=@a12,[MIDTERM_RESULT]=@a13,[F_QUIZ1]=@a14,[F_QUIZ2]=@a15,[F_QUIZ3]=@a16,[F_ACT1]=@a17,[F_ACT2]=@a18,[F_ACT3]=@a19,[F_PROJECT]=@20,[FINAL_RESULT]=@a21,[MIDTERM_GRADE]=@a22,[FINAL_GRADE]=@a23 where [STUDENT_ID]=@a0"

            dbCommand.CommandText = strsql
            dbCommand.Connection = dbConnection
            dbCommand.Parameters.AddWithValue("@a1", txtname.Text)
            dbCommand.Parameters.AddWithValue("@a2", cmbcourse.SelectedItem)
            dbCommand.Parameters.AddWithValue("@a3", cmbyrlvl.SelectedItem)
            dbCommand.Parameters.AddWithValue("@a4", cmbsection.SelectedItem)
            dbCommand.Parameters.AddWithValue("@a5", txtstatus.Text)
            dbCommand.Parameters.AddWithValue("@a6", txtq1m.Text)
            dbCommand.Parameters.AddWithValue("@a7", txtq2m.Text)
            dbCommand.Parameters.AddWithValue("@a8", txtq3m.Text)
            dbCommand.Parameters.AddWithValue("@a9", txta1m.Text)
            dbCommand.Parameters.AddWithValue("@a10", txta2m.Text)
            dbCommand.Parameters.AddWithValue("@a11", txta3m.Text)
            dbCommand.Parameters.AddWithValue("@a12", txtprojm.Text)
            dbCommand.Parameters.AddWithValue("@a13", txtmresult.Text)
            dbCommand.Parameters.AddWithValue("@a14", txtq1f.Text)
            dbCommand.Parameters.AddWithValue("@a15", txtq2f.Text)
            dbCommand.Parameters.AddWithValue("@a16", txtq3f.Text)
            dbCommand.Parameters.AddWithValue("@a17", txta1f.Text)
            dbCommand.Parameters.AddWithValue("@a18", txta2f.Text)
            dbCommand.Parameters.AddWithValue("@a19", txta3f.Text)
            dbCommand.Parameters.AddWithValue("@a20", txtprojf.Text)
            dbCommand.Parameters.AddWithValue("@a21", txtfresult.Text)
            dbCommand.Parameters.AddWithValue("@a22", midtergrade.Text)
            dbCommand.Parameters.AddWithValue("@a23", finalgrade.Text)
            dbCommand.Parameters.AddWithValue("@a0", txtstudentid.Text)

            dbCommand.ExecuteNonQuery()
            dbCommand.Dispose()
            dbConnection.Close()

            MessageBox.Show("SAVE")
            disabletextboxes()
            loadtable()
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "ERROR")
        End Try
    End Sub

    Private Sub GroupBox1_Enter(sender As Object, e As EventArgs) Handles GroupBox1.Enter

    End Sub

    Private Sub txtSearch_TextChanged(sender As Object, e As EventArgs) Handles txtSearch.TextChanged
        dbConnection = New OleDbConnection
        dbConnection.ConnectionString = connString()
        ds = New DataSet
        tables = ds.Tables
        da = New OleDbDataAdapter("Select * from [students]", dbConnection)
        da.Fill(ds, "request")
        Dim view As New DataView(tables(0))
        view.RowFilter = String.Format("STUDENT_ID  like '%{0}%'", txtSearch.Text)
        DataGridView1.DataSource = view
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        dbConnection.Close()
        MsgBox("SUCCESSFUL LOGGED OUT")
        Me.Hide()
        Form1.Show()
    End Sub

    Private Sub cmbcourse_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbcourse.SelectedIndexChanged

    End Sub

    Private Sub cmbyrlvl_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbyrlvl.SelectedIndexChanged

    End Sub

    Private Sub GroupBox3_Enter(sender As Object, e As EventArgs) Handles GroupBox3.Enter

    End Sub
End Class