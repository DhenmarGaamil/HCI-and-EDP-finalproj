<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class student
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
        Me.GroupBox4 = New System.Windows.Forms.GroupBox()
        Me.Label26 = New System.Windows.Forms.Label()
        Me.finalgrade = New System.Windows.Forms.TextBox()
        Me.midtergrade = New System.Windows.Forms.TextBox()
        Me.Label25 = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.cmbsection = New System.Windows.Forms.ComboBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.txtstudentid = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.txtstatus = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txtname = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.cmbyrlvl = New System.Windows.Forms.ComboBox()
        Me.cmbcourse = New System.Windows.Forms.ComboBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtSearch = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.GroupBox4.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GroupBox4
        '
        Me.GroupBox4.Controls.Add(Me.Label26)
        Me.GroupBox4.Controls.Add(Me.finalgrade)
        Me.GroupBox4.Controls.Add(Me.midtergrade)
        Me.GroupBox4.Controls.Add(Me.Label25)
        Me.GroupBox4.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.GroupBox4.Location = New System.Drawing.Point(287, 62)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Size = New System.Drawing.Size(135, 157)
        Me.GroupBox4.TabIndex = 11
        Me.GroupBox4.TabStop = False
        Me.GroupBox4.Text = "GRADE"
        '
        'Label26
        '
        Me.Label26.AutoSize = True
        Me.Label26.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label26.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.Label26.Location = New System.Drawing.Point(11, 48)
        Me.Label26.Name = "Label26"
        Me.Label26.Size = New System.Drawing.Size(135, 18)
        Me.Label26.TabIndex = 2
        Me.Label26.Text = "MIDTERM GRADE"
        '
        'finalgrade
        '
        Me.finalgrade.Enabled = False
        Me.finalgrade.Location = New System.Drawing.Point(10, 124)
        Me.finalgrade.Name = "finalgrade"
        Me.finalgrade.Size = New System.Drawing.Size(114, 20)
        Me.finalgrade.TabIndex = 3
        '
        'midtergrade
        '
        Me.midtergrade.Enabled = False
        Me.midtergrade.Location = New System.Drawing.Point(10, 73)
        Me.midtergrade.Name = "midtergrade"
        Me.midtergrade.Size = New System.Drawing.Size(114, 20)
        Me.midtergrade.TabIndex = 5
        '
        'Label25
        '
        Me.Label25.AutoSize = True
        Me.Label25.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label25.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.Label25.Location = New System.Drawing.Point(20, 101)
        Me.Label25.Name = "Label25"
        Me.Label25.Size = New System.Drawing.Size(105, 18)
        Me.Label25.TabIndex = 2
        Me.Label25.Text = "FINAL GRADE"
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
        Me.GroupBox1.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.GroupBox1.Location = New System.Drawing.Point(6, 30)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(266, 232)
        Me.GroupBox1.TabIndex = 8
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "STUDENT PROFILE"
        '
        'cmbsection
        '
        Me.cmbsection.Enabled = False
        Me.cmbsection.FormattingEnabled = True
        Me.cmbsection.Items.AddRange(New Object() {"A", "B", "C", "D", ""})
        Me.cmbsection.Location = New System.Drawing.Point(109, 155)
        Me.cmbsection.Name = "cmbsection"
        Me.cmbsection.Size = New System.Drawing.Size(140, 21)
        Me.cmbsection.TabIndex = 1
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.Label6.Location = New System.Drawing.Point(6, 159)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(74, 18)
        Me.Label6.TabIndex = 2
        Me.Label6.Text = "SECTION"
        '
        'txtstudentid
        '
        Me.txtstudentid.Enabled = False
        Me.txtstudentid.Location = New System.Drawing.Point(109, 46)
        Me.txtstudentid.Name = "txtstudentid"
        Me.txtstudentid.Size = New System.Drawing.Size(140, 20)
        Me.txtstudentid.TabIndex = 0
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.Label7.Location = New System.Drawing.Point(3, 105)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(77, 18)
        Me.Label7.TabIndex = 2
        Me.Label7.Text = "SUBJECT"
        '
        'txtstatus
        '
        Me.txtstatus.Enabled = False
        Me.txtstatus.Location = New System.Drawing.Point(109, 182)
        Me.txtstatus.Name = "txtstatus"
        Me.txtstatus.Size = New System.Drawing.Size(140, 20)
        Me.txtstatus.TabIndex = 0
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.Label5.Location = New System.Drawing.Point(6, 133)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(96, 18)
        Me.Label5.TabIndex = 2
        Me.Label5.Text = "YEAR LEVEL"
        '
        'txtname
        '
        Me.txtname.Enabled = False
        Me.txtname.Location = New System.Drawing.Point(109, 72)
        Me.txtname.Name = "txtname"
        Me.txtname.Size = New System.Drawing.Size(140, 20)
        Me.txtname.TabIndex = 0
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.Label2.Location = New System.Drawing.Point(6, 75)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(51, 18)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "NAME"
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label15.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.Label15.Location = New System.Drawing.Point(6, 185)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(66, 18)
        Me.Label15.TabIndex = 2
        Me.Label15.Text = "STATUS"
        '
        'cmbyrlvl
        '
        Me.cmbyrlvl.Enabled = False
        Me.cmbyrlvl.FormattingEnabled = True
        Me.cmbyrlvl.Items.AddRange(New Object() {"1", "2", "3", "4"})
        Me.cmbyrlvl.Location = New System.Drawing.Point(109, 128)
        Me.cmbyrlvl.Name = "cmbyrlvl"
        Me.cmbyrlvl.Size = New System.Drawing.Size(140, 21)
        Me.cmbyrlvl.TabIndex = 1
        '
        'cmbcourse
        '
        Me.cmbcourse.Enabled = False
        Me.cmbcourse.FormattingEnabled = True
        Me.cmbcourse.Items.AddRange(New Object() {"English", "Mathematics", "Filipino", "P.E"})
        Me.cmbcourse.Location = New System.Drawing.Point(109, 101)
        Me.cmbcourse.Name = "cmbcourse"
        Me.cmbcourse.Size = New System.Drawing.Size(140, 21)
        Me.cmbcourse.TabIndex = 1
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.Label1.Location = New System.Drawing.Point(6, 48)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(97, 18)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "STUDENT ID"
        '
        'txtSearch
        '
        Me.txtSearch.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtSearch.Location = New System.Drawing.Point(175, 444)
        Me.txtSearch.Name = "txtSearch"
        Me.txtSearch.Size = New System.Drawing.Size(157, 26)
        Me.txtSearch.TabIndex = 14
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.Label3.Location = New System.Drawing.Point(3, 448)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(163, 18)
        Me.Label3.TabIndex = 13
        Me.Label3.Text = "SEARCH STUDENT ID"
        '
        'DataGridView1
        '
        Me.DataGridView1.BackgroundColor = System.Drawing.SystemColors.ControlLightLight
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Location = New System.Drawing.Point(6, 268)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.ReadOnly = True
        Me.DataGridView1.Size = New System.Drawing.Size(416, 166)
        Me.DataGridView1.TabIndex = 15
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(338, 440)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(106, 29)
        Me.Button1.TabIndex = 16
        Me.Button1.Text = "LOG OUT"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'student
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.MidnightBlue
        Me.ClientSize = New System.Drawing.Size(473, 475)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.txtSearch)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.GroupBox4)
        Me.Controls.Add(Me.GroupBox1)
        Me.Name = "student"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "student"
        Me.GroupBox4.ResumeLayout(False)
        Me.GroupBox4.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents GroupBox4 As System.Windows.Forms.GroupBox
    Friend WithEvents Label26 As System.Windows.Forms.Label
    Friend WithEvents finalgrade As System.Windows.Forms.TextBox
    Friend WithEvents midtergrade As System.Windows.Forms.TextBox
    Friend WithEvents Label25 As System.Windows.Forms.Label
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents cmbsection As System.Windows.Forms.ComboBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents txtstudentid As System.Windows.Forms.TextBox
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents txtstatus As System.Windows.Forms.TextBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents txtname As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label15 As System.Windows.Forms.Label
    Friend WithEvents cmbyrlvl As System.Windows.Forms.ComboBox
    Friend WithEvents cmbcourse As System.Windows.Forms.ComboBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents txtSearch As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents DataGridView1 As System.Windows.Forms.DataGridView
    Friend WithEvents Button1 As System.Windows.Forms.Button
End Class
