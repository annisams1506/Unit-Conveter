<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class SatuanWaktu
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(SatuanWaktu))
        Me.cbdari = New System.Windows.Forms.ComboBox()
        Me.cbke = New System.Windows.Forms.ComboBox()
        Me.txtdari = New System.Windows.Forms.TextBox()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.definisi = New System.Windows.Forms.TextBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.GroupBox5 = New System.Windows.Forms.GroupBox()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.GroupBox4 = New System.Windows.Forms.GroupBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.hasil = New System.Windows.Forms.TextBox()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Button5 = New System.Windows.Forms.Button()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox5.SuspendLayout()
        Me.GroupBox4.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.SuspendLayout()
        '
        'cbdari
        '
        Me.cbdari.BackColor = System.Drawing.Color.White
        Me.cbdari.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbdari.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbdari.ForeColor = System.Drawing.Color.Black
        Me.cbdari.FormattingEnabled = True
        Me.cbdari.Location = New System.Drawing.Point(174, 78)
        Me.cbdari.Name = "cbdari"
        Me.cbdari.Size = New System.Drawing.Size(139, 28)
        Me.cbdari.TabIndex = 1
        '
        'cbke
        '
        Me.cbke.BackColor = System.Drawing.Color.White
        Me.cbke.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbke.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbke.ForeColor = System.Drawing.Color.Black
        Me.cbke.FormattingEnabled = True
        Me.cbke.Location = New System.Drawing.Point(174, 127)
        Me.cbke.Name = "cbke"
        Me.cbke.Size = New System.Drawing.Size(139, 28)
        Me.cbke.TabIndex = 2
        '
        'txtdari
        '
        Me.txtdari.BackColor = System.Drawing.Color.Black
        Me.txtdari.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtdari.ForeColor = System.Drawing.Color.White
        Me.txtdari.Location = New System.Drawing.Point(175, 28)
        Me.txtdari.Name = "txtdari"
        Me.txtdari.Size = New System.Drawing.Size(139, 26)
        Me.txtdari.TabIndex = 3
        '
        'Button2
        '
        Me.Button2.BackColor = System.Drawing.Color.Black
        Me.Button2.ForeColor = System.Drawing.Color.White
        Me.Button2.Location = New System.Drawing.Point(468, 381)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(78, 40)
        Me.Button2.TabIndex = 6
        Me.Button2.Text = "CLEAR"
        Me.Button2.UseVisualStyleBackColor = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Lucida Handwriting", 20.25!, System.Drawing.FontStyle.Bold)
        Me.Label1.ForeColor = System.Drawing.Color.Black
        Me.Label1.Location = New System.Drawing.Point(392, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(326, 36)
        Me.Label1.TabIndex = 17
        Me.Label1.Text = "KONVERTER WAKTU"
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox1.Controls.Add(Me.Label10)
        Me.GroupBox1.Controls.Add(Me.GroupBox2)
        Me.GroupBox1.Controls.Add(Me.definisi)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 74)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(536, 465)
        Me.GroupBox1.TabIndex = 18
        Me.GroupBox1.TabStop = False
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.Label10.ForeColor = System.Drawing.Color.Black
        Me.Label10.Location = New System.Drawing.Point(149, 185)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(164, 20)
        Me.Label10.TabIndex = 3
        Me.Label10.Text = "TANGGA KONVERSI"
        '
        'GroupBox2
        '
        Me.GroupBox2.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox2.Controls.Add(Me.PictureBox1)
        Me.GroupBox2.Location = New System.Drawing.Point(96, 187)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(288, 202)
        Me.GroupBox2.TabIndex = 3
        Me.GroupBox2.TabStop = False
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.KP_KERJA_PROJEK.My.Resources.Resources.satuan_waktu
        Me.PictureBox1.Location = New System.Drawing.Point(6, 25)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(277, 171)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 2
        Me.PictureBox1.TabStop = False
        '
        'definisi
        '
        Me.definisi.BackColor = System.Drawing.SystemColors.InactiveBorder
        Me.definisi.Enabled = False
        Me.definisi.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!)
        Me.definisi.Location = New System.Drawing.Point(20, 34)
        Me.definisi.Multiline = True
        Me.definisi.Name = "definisi"
        Me.definisi.Size = New System.Drawing.Size(472, 129)
        Me.definisi.TabIndex = 1
        Me.definisi.Text = resources.GetString("definisi.Text")
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.BackColor = System.Drawing.Color.Transparent
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold)
        Me.Label9.ForeColor = System.Drawing.Color.Black
        Me.Label9.Location = New System.Drawing.Point(201, 70)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(97, 25)
        Me.Label9.TabIndex = 15
        Me.Label9.Text = "MATERI" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        '
        'GroupBox5
        '
        Me.GroupBox5.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox5.Controls.Add(Me.Button3)
        Me.GroupBox5.Controls.Add(Me.Label7)
        Me.GroupBox5.Controls.Add(Me.Label13)
        Me.GroupBox5.Controls.Add(Me.GroupBox4)
        Me.GroupBox5.Controls.Add(Me.GroupBox3)
        Me.GroupBox5.Controls.Add(Me.Button2)
        Me.GroupBox5.Location = New System.Drawing.Point(554, 74)
        Me.GroupBox5.Name = "GroupBox5"
        Me.GroupBox5.Size = New System.Drawing.Size(570, 465)
        Me.GroupBox5.TabIndex = 19
        Me.GroupBox5.TabStop = False
        '
        'Button3
        '
        Me.Button3.BackColor = System.Drawing.Color.Black
        Me.Button3.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Bold)
        Me.Button3.ForeColor = System.Drawing.Color.White
        Me.Button3.Location = New System.Drawing.Point(408, 227)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(138, 48)
        Me.Button3.TabIndex = 15
        Me.Button3.Text = "KONVERTER"
        Me.Button3.UseVisualStyleBackColor = False
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold)
        Me.Label7.ForeColor = System.Drawing.Color.Black
        Me.Label7.Location = New System.Drawing.Point(44, 285)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(94, 20)
        Me.Label7.TabIndex = 1
        Me.Label7.Text = "OUTPUT : "
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold)
        Me.Label13.ForeColor = System.Drawing.Color.Black
        Me.Label13.Location = New System.Drawing.Point(40, 49)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(76, 20)
        Me.Label13.TabIndex = 0
        Me.Label13.Text = "INPUT : "
        '
        'GroupBox4
        '
        Me.GroupBox4.Controls.Add(Me.Label2)
        Me.GroupBox4.Controls.Add(Me.hasil)
        Me.GroupBox4.ForeColor = System.Drawing.Color.Black
        Me.GroupBox4.Location = New System.Drawing.Point(44, 281)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Size = New System.Drawing.Size(502, 94)
        Me.GroupBox4.TabIndex = 12
        Me.GroupBox4.TabStop = False
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.Black
        Me.Label2.Location = New System.Drawing.Point(14, 38)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(78, 25)
        Me.Label2.TabIndex = 20
        Me.Label2.Text = "Hasil : "
        '
        'hasil
        '
        Me.hasil.BackColor = System.Drawing.SystemColors.MenuBar
        Me.hasil.Enabled = False
        Me.hasil.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.hasil.ForeColor = System.Drawing.Color.Black
        Me.hasil.Location = New System.Drawing.Point(108, 35)
        Me.hasil.Multiline = True
        Me.hasil.Name = "hasil"
        Me.hasil.Size = New System.Drawing.Size(266, 28)
        Me.hasil.TabIndex = 21
        '
        'GroupBox3
        '
        Me.GroupBox3.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox3.Controls.Add(Me.Label11)
        Me.GroupBox3.Controls.Add(Me.Label12)
        Me.GroupBox3.Controls.Add(Me.Label14)
        Me.GroupBox3.Controls.Add(Me.cbdari)
        Me.GroupBox3.Controls.Add(Me.txtdari)
        Me.GroupBox3.Controls.Add(Me.cbke)
        Me.GroupBox3.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.GroupBox3.Location = New System.Drawing.Point(44, 46)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(502, 175)
        Me.GroupBox3.TabIndex = 13
        Me.GroupBox3.TabStop = False
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.ForeColor = System.Drawing.Color.Black
        Me.Label11.Location = New System.Drawing.Point(16, 36)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(123, 20)
        Me.Label11.TabIndex = 2
        Me.Label11.Text = "Masukkan Nilai: "
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.ForeColor = System.Drawing.Color.Black
        Me.Label12.Location = New System.Drawing.Point(16, 81)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(111, 20)
        Me.Label12.TabIndex = 3
        Me.Label12.Text = "Satuan Awal : "
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.ForeColor = System.Drawing.Color.Black
        Me.Label14.Location = New System.Drawing.Point(16, 121)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(113, 20)
        Me.Label14.TabIndex = 4
        Me.Label14.Text = "Satuan Akhir : "
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.BackColor = System.Drawing.Color.Transparent
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold)
        Me.Label8.ForeColor = System.Drawing.Color.Black
        Me.Label8.Location = New System.Drawing.Point(764, 71)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(151, 25)
        Me.Label8.TabIndex = 14
        Me.Label8.Text = "KONVERTER"
        '
        'Button5
        '
        Me.Button5.AutoSize = True
        Me.Button5.BackColor = System.Drawing.Color.Transparent
        Me.Button5.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.Button5.FlatAppearance.BorderColor = System.Drawing.Color.White
        Me.Button5.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Button5.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.Button5.ForeColor = System.Drawing.Color.Transparent
        Me.Button5.Image = Global.KP_KERJA_PROJEK.My.Resources.Resources.blue_home_icon__3_
        Me.Button5.ImageAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.Button5.Location = New System.Drawing.Point(1070, 14)
        Me.Button5.Name = "Button5"
        Me.Button5.Size = New System.Drawing.Size(54, 54)
        Me.Button5.TabIndex = 21
        Me.Button5.UseVisualStyleBackColor = False
        '
        'SatuanWaktu
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoValidate = System.Windows.Forms.AutoValidate.EnablePreventFocusChange
        Me.BackColor = System.Drawing.Color.DarkGreen
        Me.ClientSize = New System.Drawing.Size(1151, 562)
        Me.ControlBox = False
        Me.Controls.Add(Me.Button5)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.GroupBox5)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.Label1)
        Me.Name = "SatuanWaktu"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "KOVERSI SATUAN WAKTU"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox5.ResumeLayout(False)
        Me.GroupBox5.PerformLayout()
        Me.GroupBox4.ResumeLayout(False)
        Me.GroupBox4.PerformLayout()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents cbdari As System.Windows.Forms.ComboBox
    Friend WithEvents cbke As System.Windows.Forms.ComboBox
    Friend WithEvents txtdari As System.Windows.Forms.TextBox
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents definisi As System.Windows.Forms.TextBox
    Friend WithEvents GroupBox5 As System.Windows.Forms.GroupBox
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents GroupBox4 As System.Windows.Forms.GroupBox
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents Label14 As System.Windows.Forms.Label
    Friend WithEvents Button5 As System.Windows.Forms.Button
    Friend WithEvents Button3 As System.Windows.Forms.Button
    Public WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents hasil As System.Windows.Forms.TextBox
End Class
