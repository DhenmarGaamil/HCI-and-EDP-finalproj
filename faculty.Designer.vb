<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class faculty
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.txtstudentid = New System.Windows.Forms.TextBox()
        Me.txtname = New System.Windows.Forms.TextBox()
        Me.cmbyrlvl = New System.Windows.Forms.ComboBox()
        Me.cmbsection = New System.Windows.Forms.ComboBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.cmbcourse = New System.Windows.Forms.ComboBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.txtstatus = New System.Windows.Forms.TextBox()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.txta1m = New System.Windows.Forms.TextBox()
        Me.txta3m = New System.Windows.Forms.TextBox()
        Me.txta2m = New System.Windows.Forms.TextBox()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.txtq1m = New System.Windows.Forms.TextBox()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.txtmresult = New System.Windows.Forms.TextBox()
        Me.txtprojm = New System.Windows.Forms.TextBox()
        Me.txtq3m = New System.Windows.Forms.TextBox()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.txtq2m = New System.Windows.Forms.TextBox()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.txtq2f = New System.Windows.Forms.TextBox()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.txtq3f = New System.Windows.Forms.TextBox()
        Me.Label18 = New System.Windows.Forms.Label()
        Me.txtq1f = New System.Windows.Forms.TextBox()
        Me.Label19 = New System.Windows.Forms.Label()
        Me.Label20 = New System.Windows.Forms.Label()
        Me.Label21 = New System.Windows.Forms.Label()
        Me.Label22 = New System.Windows.Forms.Label()
        Me.txta2f = New System.Windows.Forms.TextBox()
        Me.txta3f = New System.Windows.Forms.TextBox()
        Me.txta1f = New System.Windows.Forms.TextBox()
        Me.Label23 = New System.Windows.Forms.Label()
        Me.txtfresult = New System.Windows.Forms.TextBox()
        Me.Label24 = New System.Windows.Forms.Label()
        Me.txtprojf = New System.Windows.Forms.TextBox()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.GroupBox4 = New System.Windows.Forms.GroupBox()
        Me.Label26 = New System.Windows.Forms.Label()
        Me.finalgrade = New System.Windows.Forms.TextBox()
        Me.midtergrade = New System.Windows.Forms.TextBox()
        Me.Label25 = New System.Windows.Forms.Label()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.btnadd = New System.Windows.Forms.Button()
        Me.btnedit = New System.Windows.Forms.Button()
        Me.btndelete = New System.Windows.Forms.Button()
        Me.btnupdate = New System.Windows.Forms.Button()
        Me.btnsave = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.txtSearch = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.GroupBox4.SuspendLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'txtstudentid
        '
        Me.txtstudentid.Location = New System.Drawing.Point(111, 28)
        Me.txtstudentid.Name = "txtstudentid"
        Me.txtstudentid.Size = New System.Drawing.Size(140, 20)
        Me.txtstudentid.TabIndex = 0
        '
        'txtname
        '
        Me.txtname.Location = New System.Drawing.Point(111, 54)
        Me.txtname.Name = "txtname"
        Me.txtname.Size = New System.Drawing.Size(140, 20)
        Me.txtname.TabIndex = 1
        '
        'cmbyrlvl
        '
        Me.cmbyrlvl.FormattingEnabled = True
        Me.cmbyrlvl.Items.AddRange(New Object() {"1", "2", "3", "4"})
        Me.cmbyrlvl.Location = New System.Drawing.Point(111, 110)
        Me.cmbyrlvl.Name = "cmbyrlvl"
        Me.cmbyrlvl.Size = New System.Drawing.Size(140, 21)
        Me.cmbyrlvl.TabIndex = 3
        '
        'cmbsection
        '
        Me.cmbsection.FormattingEnabled = True
        Me.cmbsection.Items.AddRange(New Object() {"A", "B", "C", "D"})
        Me.cmbsection.Location = New System.Drawing.Point(111, 137)
        Me.cmbsection.Name = "cmbsection"
        Me.cmbsection.Size = New System.Drawing.Size(140, 21)
        Me.cmbsection.TabIndex = 4
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.Label1.Location = New System.Drawing.Point(8, 30)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(97, 18)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "STUDENT ID"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.Label2.Location = New System.Drawing.Point(8, 55)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(51, 18)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "NAME"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.Label5.Location = New System.Drawing.Point(8, 115)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(96, 18)
        Me.Label5.TabIndex = 2
        Me.Label5.Text = "YEAR LEVEL"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.Label6.Location = New System.Drawing.Point(8, 141)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(74, 18)
        Me.Label6.TabIndex = 2
        Me.Label6.Text = "SECTION"
        '
        'cmbcourse
        '
        Me.cmbcourse.FormattingEnabled = True
        Me.cmbcourse.Items.AddRange(New Object() {"English", "Mathematics", "Filipino", "P.E"})
        Me.cmbcourse.Location = New System.Drawing.Point(111, 83)
        Me.cmbcourse.Name = "cmbcourse"
        Me.cmbcourse.Size = New System.Drawing.Size(140, 21)
        Me.cmbcourse.TabIndex = 2
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.Label7.Location = New System.Drawing.Point(5, 87)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(77, 18)
        Me.Label7.TabIndex = 2
        Me.Label7.Text = "SUBJECT"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.cmbsection)
        Me.GroupBox1.Controls.Add(Me.Label6)
        Me.GroupBox1.Controls.Add(Me.txtstudentid)
        Me.GroupBox1.Controls.Add(Me.Label7)
        Me.GroupBox1.Controls.Add(Me.txtstatus)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.txtname)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.Label15)
        Me.GroupBox1.Controls.Add(Me.cmbyrlvl)
        Me.GroupBox1.Controls.Add(Me.cmbcourse)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Location = New System.Drawing.Point(7, 28)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(266, 237)
        Me.GroupBox1.TabIndex = 3
        Me.GroupBox1.TabStop = False
        '
        'txtstatus
        '
        Me.txtstatus.Location = New System.Drawing.Point(111, 164)
        Me.txtstatus.Name = "txtstatus"
        Me.txtstatus.Size = New System.Drawing.Size(140, 20)
        Me.txtstatus.TabIndex = 0
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label15.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.Label15.Location = New System.Drawing.Point(8, 167)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(66, 18)
        Me.Label15.TabIndex = 2
        Me.Label15.Text = "STATUS"
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.txta1m)
        Me.GroupBox2.Controls.Add(Me.txta3m)
        Me.GroupBox2.Controls.Add(Me.txta2m)
        Me.GroupBox2.Controls.Add(Me.Label14)
        Me.GroupBox2.Controls.Add(Me.Label8)
        Me.GroupBox2.Controls.Add(Me.txtq1m)
        Me.GroupBox2.Controls.Add(Me.Label13)
        Me.GroupBox2.Controls.Add(Me.txtmresult)
        Me.GroupBox2.Controls.Add(Me.txtprojm)
        Me.GroupBox2.Controls.Add(Me.txtq3m)
        Me.GroupBox2.Controls.Add(Me.Label12)
        Me.GroupBox2.Controls.Add(Me.Label9)
        Me.GroupBox2.Controls.Add(Me.Label16)
        Me.GroupBox2.Controls.Add(Me.Label10)
        Me.GroupBox2.Controls.Add(Me.txtq2m)
        Me.GroupBox2.Controls.Add(Me.Label11)
        Me.GroupBox2.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.GroupBox2.Location = New System.Drawing.Point(280, 28)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(262, 236)
        Me.GroupBox2.TabIndex = 4
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "MIDTERM"
        '
        'txta1m
        '
        Me.txta1m.Location = New System.Drawing.Point(112, 109)
        Me.txta1m.Name = "txta1m"
        Me.txta1m.Size = New System.Drawing.Size(140, 20)
        Me.txta1m.TabIndex = 8
        '
        'txta3m
        '
        Me.txta3m.Location = New System.Drawing.Point(112, 161)
        Me.txta3m.Name = "txta3m"
        Me.txta3m.Size = New System.Drawing.Size(140, 20)
        Me.txta3m.TabIndex = 10
        '
        'txta2m
        '
        Me.txta2m.Location = New System.Drawing.Point(112, 135)
        Me.txta2m.Name = "txta2m"
        Me.txta2m.Size = New System.Drawing.Size(140, 20)
        Me.txta2m.TabIndex = 9
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label14.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Label14.Location = New System.Drawing.Point(6, 165)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(82, 18)
        Me.Label14.TabIndex = 2
        Me.Label14.Text = "ACTIVITY 3"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Label8.Location = New System.Drawing.Point(9, 28)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(55, 18)
        Me.Label8.TabIndex = 2
        Me.Label8.Text = "QUIZ 1"
        '
        'txtq1m
        '
        Me.txtq1m.Location = New System.Drawing.Point(112, 28)
        Me.txtq1m.Name = "txtq1m"
        Me.txtq1m.Size = New System.Drawing.Size(140, 20)
        Me.txtq1m.TabIndex = 5
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Label13.Location = New System.Drawing.Point(9, 83)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(55, 18)
        Me.Label13.TabIndex = 2
        Me.Label13.Text = "QUIZ 3"
        '
        'txtmresult
        '
        Me.txtmresult.Location = New System.Drawing.Point(112, 212)
        Me.txtmresult.Name = "txtmresult"
        Me.txtmresult.Size = New System.Drawing.Size(140, 20)
        Me.txtmresult.TabIndex = 12
        '
        'txtprojm
        '
        Me.txtprojm.Location = New System.Drawing.Point(112, 187)
        Me.txtprojm.Name = "txtprojm"
        Me.txtprojm.Size = New System.Drawing.Size(140, 20)
        Me.txtprojm.TabIndex = 11
        '
        'txtq3m
        '
        Me.txtq3m.Location = New System.Drawing.Point(112, 80)
        Me.txtq3m.Name = "txtq3m"
        Me.txtq3m.Size = New System.Drawing.Size(140, 20)
        Me.txtq3m.TabIndex = 7
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Label12.Location = New System.Drawing.Point(6, 111)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(82, 18)
        Me.Label12.TabIndex = 2
        Me.Label12.Text = "ACTIVITY 1"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Label9.Location = New System.Drawing.Point(7, 214)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(127, 16)
        Me.Label9.TabIndex = 2
        Me.Label9.Text = "MIDTERM RESULT"
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label16.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Label16.Location = New System.Drawing.Point(9, 191)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(79, 18)
        Me.Label16.TabIndex = 2
        Me.Label16.Text = "PROJECT"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Label10.Location = New System.Drawing.Point(9, 54)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(55, 18)
        Me.Label10.TabIndex = 2
        Me.Label10.Text = "QUIZ 2"
        '
        'txtq2m
        '
        Me.txtq2m.Location = New System.Drawing.Point(112, 54)
        Me.txtq2m.Name = "txtq2m"
        Me.txtq2m.Size = New System.Drawing.Size(140, 20)
        Me.txtq2m.TabIndex = 6
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Label11.Location = New System.Drawing.Point(6, 139)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(82, 18)
        Me.Label11.TabIndex = 2
        Me.Label11.Text = "ACTIVITY 2"
        '
        'txtq2f
        '
        Me.txtq2f.Location = New System.Drawing.Point(116, 55)
        Me.txtq2f.Name = "txtq2f"
        Me.txtq2f.Size = New System.Drawing.Size(140, 20)
        Me.txtq2f.TabIndex = 14
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label17.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.Label17.Location = New System.Drawing.Point(13, 57)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(55, 18)
        Me.Label17.TabIndex = 2
        Me.Label17.Text = "QUIZ 2"
        '
        'txtq3f
        '
        Me.txtq3f.Location = New System.Drawing.Point(116, 81)
        Me.txtq3f.Name = "txtq3f"
        Me.txtq3f.Size = New System.Drawing.Size(140, 20)
        Me.txtq3f.TabIndex = 15
        '
        'Label18
        '
        Me.Label18.AutoSize = True
        Me.Label18.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label18.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.Label18.Location = New System.Drawing.Point(13, 84)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(55, 18)
        Me.Label18.TabIndex = 2
        Me.Label18.Text = "QUIZ 3"
        '
        'txtq1f
        '
        Me.txtq1f.Location = New System.Drawing.Point(116, 29)
        Me.txtq1f.Name = "txtq1f"
        Me.txtq1f.Size = New System.Drawing.Size(140, 20)
        Me.txtq1f.TabIndex = 13
        '
        'Label19
        '
        Me.Label19.AutoSize = True
        Me.Label19.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label19.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.Label19.Location = New System.Drawing.Point(13, 29)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(55, 18)
        Me.Label19.TabIndex = 2
        Me.Label19.Text = "QUIZ 1"
        '
        'Label20
        '
        Me.Label20.AutoSize = True
        Me.Label20.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label20.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.Label20.Location = New System.Drawing.Point(10, 140)
        Me.Label20.Name = "Label20"
        Me.Label20.Size = New System.Drawing.Size(82, 18)
        Me.Label20.TabIndex = 2
        Me.Label20.Text = "ACTIVITY 2"
        '
        'Label21
        '
        Me.Label21.AutoSize = True
        Me.Label21.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label21.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.Label21.Location = New System.Drawing.Point(10, 112)
        Me.Label21.Name = "Label21"
        Me.Label21.Size = New System.Drawing.Size(82, 18)
        Me.Label21.TabIndex = 2
        Me.Label21.Text = "ACTIVITY 1"
        '
        'Label22
        '
        Me.Label22.AutoSize = True
        Me.Label22.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label22.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.Label22.Location = New System.Drawing.Point(10, 166)
        Me.Label22.Name = "Label22"
        Me.Label22.Size = New System.Drawing.Size(82, 18)
        Me.Label22.TabIndex = 2
        Me.Label22.Text = "ACTIVITY 3"
        '
        'txta2f
        '
        Me.txta2f.Location = New System.Drawing.Point(116, 136)
        Me.txta2f.Name = "txta2f"
        Me.txta2f.Size = New System.Drawing.Size(140, 20)
        Me.txta2f.TabIndex = 17
        '
        'txta3f
        '
        Me.txta3f.Location = New System.Drawing.Point(116, 162)
        Me.txta3f.Name = "txta3f"
        Me.txta3f.Size = New System.Drawing.Size(140, 20)
        Me.txta3f.TabIndex = 18
        '
        'txta1f
        '
        Me.txta1f.Location = New System.Drawing.Point(116, 110)
        Me.txta1f.Name = "txta1f"
        Me.txta1f.Size = New System.Drawing.Size(140, 20)
        Me.txta1f.TabIndex = 16
        '
        'Label23
        '
        Me.Label23.AutoSize = True
        Me.Label23.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label23.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.Label23.Location = New System.Drawing.Point(11, 215)
        Me.Label23.Name = "Label23"
        Me.Label23.Size = New System.Drawing.Size(101, 16)
        Me.Label23.TabIndex = 2
        Me.Label23.Text = "FINAL RESULT"
        '
        'txtfresult
        '
        Me.txtfresult.Location = New System.Drawing.Point(116, 213)
        Me.txtfresult.Name = "txtfresult"
        Me.txtfresult.Size = New System.Drawing.Size(140, 20)
        Me.txtfresult.TabIndex = 20
        '
        'Label24
        '
        Me.Label24.AutoSize = True
        Me.Label24.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label24.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.Label24.Location = New System.Drawing.Point(13, 192)
        Me.Label24.Name = "Label24"
        Me.Label24.Size = New System.Drawing.Size(79, 18)
        Me.Label24.TabIndex = 2
        Me.Label24.Text = "PROJECT"
        '
        'txtprojf
        '
        Me.txtprojf.Location = New System.Drawing.Point(116, 189)
        Me.txtprojf.Name = "txtprojf"
        Me.txtprojf.Size = New System.Drawing.Size(140, 20)
        Me.txtprojf.TabIndex = 19
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.txtprojf)
        Me.GroupBox3.Controls.Add(Me.txta1f)
        Me.GroupBox3.Controls.Add(Me.Label18)
        Me.GroupBox3.Controls.Add(Me.txtq1f)
        Me.GroupBox3.Controls.Add(Me.txtq3f)
        Me.GroupBox3.Controls.Add(Me.txta3f)
        Me.GroupBox3.Controls.Add(Me.Label21)
        Me.GroupBox3.Controls.Add(Me.txtfresult)
        Me.GroupBox3.Controls.Add(Me.Label19)
        Me.GroupBox3.Controls.Add(Me.Label20)
        Me.GroupBox3.Controls.Add(Me.Label23)
        Me.GroupBox3.Controls.Add(Me.txta2f)
        Me.GroupBox3.Controls.Add(Me.Label24)
        Me.GroupBox3.Controls.Add(Me.txtq2f)
        Me.GroupBox3.Controls.Add(Me.Label17)
        Me.GroupBox3.Controls.Add(Me.Label22)
        Me.GroupBox3.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.GroupBox3.Location = New System.Drawing.Point(549, 28)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(262, 237)
        Me.GroupBox3.TabIndex = 6
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "FINAL"
        '
        'GroupBox4
        '
        Me.GroupBox4.Controls.Add(Me.Label26)
        Me.GroupBox4.Controls.Add(Me.finalgrade)
        Me.GroupBox4.Controls.Add(Me.midtergrade)
        Me.GroupBox4.Controls.Add(Me.Label25)
        Me.GroupBox4.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.GroupBox4.Location = New System.Drawing.Point(817, 30)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Size = New System.Drawing.Size(135, 132)
        Me.GroupBox4.TabIndex = 7
        Me.GroupBox4.TabStop = False
        Me.GroupBox4.Text = "GRADE"
        '
        'Label26
        '
        Me.Label26.AutoSize = True
        Me.Label26.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label26.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.Label26.Location = New System.Drawing.Point(13, 30)
        Me.Label26.Name = "Label26"
        Me.Label26.Size = New System.Drawing.Size(135, 18)
        Me.Label26.TabIndex = 2
        Me.Label26.Text = "MIDTERM GRADE"
        '
        'finalgrade
        '
        Me.finalgrade.Location = New System.Drawing.Point(12, 106)
        Me.finalgrade.Name = "finalgrade"
        Me.finalgrade.Size = New System.Drawing.Size(114, 20)
        Me.finalgrade.TabIndex = 3
        '
        'midtergrade
        '
        Me.midtergrade.Location = New System.Drawing.Point(12, 55)
        Me.midtergrade.Name = "midtergrade"
        Me.midtergrade.Size = New System.Drawing.Size(114, 20)
        Me.midtergrade.TabIndex = 5
        '
        'Label25
        '
        Me.Label25.AutoSize = True
        Me.Label25.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label25.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.Label25.Location = New System.Drawing.Point(22, 83)
        Me.Label25.Name = "Label25"
        Me.Label25.Size = New System.Drawing.Size(105, 18)
        Me.Label25.TabIndex = 2
        Me.Label25.Text = "FINAL GRADE"
        '
        'DataGridView1
        '
        Me.DataGridView1.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Location = New System.Drawing.Point(8, 270)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.ReadOnly = True
        Me.DataGridView1.Size = New System.Drawing.Size(939, 205)
        Me.DataGridView1.TabIndex = 8
        '
        'btnadd
        '
        Me.btnadd.Location = New System.Drawing.Point(450, 486)
        Me.btnadd.Name = "btnadd"
        Me.btnadd.Size = New System.Drawing.Size(92, 31)
        Me.btnadd.TabIndex = 0
        Me.btnadd.Text = "ADD"
        Me.btnadd.UseVisualStyleBackColor = True
        '
        'btnedit
        '
        Me.btnedit.Location = New System.Drawing.Point(549, 487)
        Me.btnedit.Name = "btnedit"
        Me.btnedit.Size = New System.Drawing.Size(92, 31)
        Me.btnedit.TabIndex = 24
        Me.btnedit.Text = "EDIT"
        Me.btnedit.UseVisualStyleBackColor = True
        '
        'btndelete
        '
        Me.btndelete.Location = New System.Drawing.Point(647, 487)
        Me.btndelete.Name = "btndelete"
        Me.btndelete.Size = New System.Drawing.Size(92, 31)
        Me.btndelete.TabIndex = 25
        Me.btndelete.Text = "DELETE"
        Me.btndelete.UseVisualStyleBackColor = True
        '
        'btnupdate
        '
        Me.btnupdate.Location = New System.Drawing.Point(745, 487)
        Me.btnupdate.Name = "btnupdate"
        Me.btnupdate.Size = New System.Drawing.Size(92, 31)
        Me.btnupdate.TabIndex = 26
        Me.btnupdate.Text = "UPDATE"
        Me.btnupdate.UseVisualStyleBackColor = True
        '
        'btnsave
        '
        Me.btnsave.Location = New System.Drawing.Point(843, 486)
        Me.btnsave.Name = "btnsave"
        Me.btnsave.Size = New System.Drawing.Size(92, 31)
        Me.btnsave.TabIndex = 27
        Me.btnsave.Text = "SAVE"
        Me.btnsave.UseVisualStyleBackColor = True
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(818, 164)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(128, 31)
        Me.Button1.TabIndex = 21
        Me.Button1.Text = "CALCULATE"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'txtSearch
        '
        Me.txtSearch.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtSearch.Location = New System.Drawing.Point(173, 488)
        Me.txtSearch.Name = "txtSearch"
        Me.txtSearch.Size = New System.Drawing.Size(262, 26)
        Me.txtSearch.TabIndex = 21
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.Label3.Location = New System.Drawing.Point(4, 493)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(163, 18)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "SEARCH STUDENT ID"
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(817, 199)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(128, 31)
        Me.Button2.TabIndex = 22
        Me.Button2.Text = "LOG OUT"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'faculty
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.MidnightBlue
        Me.ClientSize = New System.Drawing.Size(957, 525)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.txtSearch)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.btnsave)
        Me.Controls.Add(Me.btnupdate)
        Me.Controls.Add(Me.btndelete)
        Me.Controls.Add(Me.btnedit)
        Me.Controls.Add(Me.btnadd)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.GroupBox4)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.GroupBox1)
        Me.Name = "faculty"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "faculty"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        Me.GroupBox4.ResumeLayout(False)
        Me.GroupBox4.PerformLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents txtstudentid As System.Windows.Forms.TextBox
    Friend WithEvents txtname As System.Windows.Forms.TextBox
    Friend WithEvents cmbyrlvl As System.Windows.Forms.ComboBox
    Friend WithEvents cmbsection As System.Windows.Forms.ComboBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents cmbcourse As System.Windows.Forms.ComboBox
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents txtstatus As System.Windows.Forms.TextBox
    Friend WithEvents Label15 As System.Windows.Forms.Label
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents txta1m As System.Windows.Forms.TextBox
    Friend WithEvents txta3m As System.Windows.Forms.TextBox
    Friend WithEvents txta2m As System.Windows.Forms.TextBox
    Friend WithEvents Label14 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents txtq1m As System.Windows.Forms.TextBox
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents txtmresult As System.Windows.Forms.TextBox
    Friend WithEvents txtprojm As System.Windows.Forms.TextBox
    Friend WithEvents txtq3m As System.Windows.Forms.TextBox
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents Label16 As System.Windows.Forms.Label
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents txtq2m As System.Windows.Forms.TextBox
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents txtq2f As System.Windows.Forms.TextBox
    Friend WithEvents Label17 As System.Windows.Forms.Label
    Friend WithEvents txtq3f As System.Windows.Forms.TextBox
    Friend WithEvents Label18 As System.Windows.Forms.Label
    Friend WithEvents txtq1f As System.Windows.Forms.TextBox
    Friend WithEvents Label19 As System.Windows.Forms.Label
    Friend WithEvents Label20 As System.Windows.Forms.Label
    Friend WithEvents Label21 As System.Windows.Forms.Label
    Friend WithEvents Label22 As System.Windows.Forms.Label
    Friend WithEvents txta2f As System.Windows.Forms.TextBox
    Friend WithEvents txta3f As System.Windows.Forms.TextBox
    Friend WithEvents txta1f As System.Windows.Forms.TextBox
    Friend WithEvents Label23 As System.Windows.Forms.Label
    Friend WithEvents txtfresult As System.Windows.Forms.TextBox
    Friend WithEvents Label24 As System.Windows.Forms.Label
    Friend WithEvents txtprojf As System.Windows.Forms.TextBox
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
    Friend WithEvents GroupBox4 As System.Windows.Forms.GroupBox
    Friend WithEvents Label26 As System.Windows.Forms.Label
    Friend WithEvents finalgrade As System.Windows.Forms.TextBox
    Friend WithEvents midtergrade As System.Windows.Forms.TextBox
    Friend WithEvents Label25 As System.Windows.Forms.Label
    Friend WithEvents DataGridView1 As System.Windows.Forms.DataGridView
    Friend WithEvents btnadd As System.Windows.Forms.Button
    Friend WithEvents btnedit As System.Windows.Forms.Button
    Friend WithEvents btndelete As System.Windows.Forms.Button
    Friend WithEvents btnupdate As System.Windows.Forms.Button
    Friend WithEvents btnsave As System.Windows.Forms.Button
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents txtSearch As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Button2 As System.Windows.Forms.Button
End Class
