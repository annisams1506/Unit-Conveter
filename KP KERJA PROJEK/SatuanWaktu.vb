Public Class SatuanWaktu
    Sub combo()
        With cbdari
            .Items.Add("Abad")
            .Items.Add("Dasawarsa")
            .Items.Add("Windu")
            .Items.Add("Lustrum")
            .Items.Add("Tahun")
            .Items.Add("Bulan")
            .Items.Add("Minggu")
            .Items.Add("Hari")
            .Items.Add("Jam")
            .Items.Add("Menit")
            .Items.Add("Detik")
        End With
        With cbke()
            .Items.Add("Abad")
            .Items.Add("Dasawarsa")
            .Items.Add("Windu")
            .Items.Add("Lustrum")
            .Items.Add("Tahun")
            .Items.Add("Bulan")
            .Items.Add("Minggu")
            .Items.Add("Hari")
            .Items.Add("Jam")
            .Items.Add("Menit")
            .Items.Add("Detik")
        End With
    End Sub

    Private Sub Form4_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.ResizeRedraw = True
        Call combo()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        txtdari.Text = ""
        hasil.text = ""
        Me.cbke.SelectedItem = Nothing
        Me.cbdari.SelectedItem = Nothing
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        home.Show()
        Me.Hide()

    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs)
        End
    End Sub
    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        If txtdari.Text = "" Then
            MsgBox("MASUKKAN ANGKA", MsgBoxStyle.Information, "INVALID")
        End If
        If cbdari.Text = "Detik" And cbke.Text = "Detik" Then
            hasil.Text = txtdari.Text & " " & cbke.Text
        ElseIf cbdari.Text = "Detik" And cbke.Text = "Menit" Then
            hasil.Text = Val(txtdari.Text) / 60 & " " & cbke.Text
        ElseIf cbdari.Text = "Detik" And cbke.Text = "Jam" Then
            hasil.Text = Val(txtdari.Text) / 360 & " " & cbke.Text

        ElseIf cbdari.Text = "Detik" And cbke.Text = "Hari" Then
            hasil.Text = Val(txtdari.Text) / 86400 & " " & cbke.Text

        ElseIf cbdari.Text = "Detik" And cbke.Text = "Minggu" Then
            hasil.Text = Val(txtdari.Text) / 604800 & " " & cbke.Text

        ElseIf cbdari.Text = "Detik" And cbke.Text = "Bulan" Then
            hasil.Text = Val(txtdari.Text) / 2419200 & " " & cbke.Text

        ElseIf cbdari.Text = "Detik" And cbke.Text = "Tahun" Then
            hasil.Text = Val(txtdari.Text) / 31536000 & " " & cbke.Text

        ElseIf cbdari.Text = "Detik" And cbke.Text = "Lustrum" Then
            hasil.Text = txtdari.Text / 157680000 & " " & cbke.Text

        ElseIf cbdari.Text = "Detik" And cbke.Text = "Windu" Then
            hasil.Text = Val(txtdari.Text) / 252288000 & " " & cbke.Text

        ElseIf cbdari.Text = "Detik" And cbke.Text = "Dasawarsa" Then
            hasil.Text = txtdari.Text / 315360000 & " " & cbke.Text

        ElseIf cbdari.Text = "Menit" And cbke.Text = "Detik" Then
            hasil.Text = Val(txtdari.Text) * 60 & " " & cbke.Text

        ElseIf cbdari.Text = "Menit" And cbke.Text = "Menit" Then
            hasil.Text = Val(txtdari.Text) & " " & cbke.Text

        ElseIf cbdari.Text = "Menit" And cbke.Text = "Jam" Then
            hasil.Text = Val(txtdari.Text) / 60 & " " & cbke.Text

        ElseIf cbdari.Text = "Menit" And cbke.Text = "Hari" Then
            hasil.Text = Val(txtdari.Text) / 1440 & " " & cbke.Text

        ElseIf cbdari.Text = "Menit" And cbke.Text = "Minggu" Then
            hasil.Text = Val(txtdari.Text) / 10080 & " " & cbke.Text

        ElseIf cbdari.Text = "Menit" And cbke.Text = "Bulan" Then
            hasil.Text = Val(txtdari.Text) / 40320 & " " & cbke.Text

        ElseIf cbdari.Text = "Menit" And cbke.Text = "Tahun" Then
            hasil.Text = Val(txtdari.Text) / 525600 & " " & cbke.Text

        ElseIf txtdari.Text = "Menit" And cbke.Text = "Lustrum" Then
            hasil.Text = txtdari.Text / 2628000 & " " & cbke.Text

        ElseIf cbdari.Text = "Menit" And cbke.Text = "Windu" Then
            hasil.Text = Val(txtdari.Text) / 4204800 & " " & cbke.Text

        ElseIf cbdari.Text = "Menit" And cbke.Text = "Dasawarsa" Then
            hasil.Text = txtdari.Text / 5256000 & " " & cbke.Text

        ElseIf cbdari.Text = "Jam" And cbke.Text = "Jam" Then
            hasil.Text = Val(txtdari.Text) & " " & cbke.Text

        ElseIf cbdari.Text = "Jam" And cbke.Text = "Menit" Then
            hasil.Text = Val(txtdari.Text) * 60 & " " & cbke.Text

        ElseIf cbdari.Text = "Jam" And cbke.Text = "Detik" Then
            hasil.Text = Val(txtdari.Text) * 360 & " " & cbke.Text

        ElseIf cbdari.Text = "Jam" And cbke.Text = "Hari" Then
            hasil.Text = Val(txtdari.Text) / 24 & " " & cbke.Text

        ElseIf cbdari.Text = "Jam" And cbke.Text = "Minggu" Then
            hasil.Text = Val(txtdari.Text) / 168 & " " & cbke.Text

        ElseIf cbdari.Text = "Jam" And cbke.Text = "Bulan" Then
            hasil.Text = Val(txtdari.Text) / 672 & " " & cbke.Text

        ElseIf cbdari.Text = "Jam" And cbke.Text = "Tahun" Then
            hasil.Text = Val(txtdari.Text) / 8760 & " " & cbke.Text

        ElseIf cbdari.Text = "Jam" And cbke.Text = "Lustrum" Then
            hasil.Text = txtdari.Text / 43800 & " " & cbke.Text

        ElseIf cbdari.Text = "Jam" And cbke.Text = "Windu" Then
            hasil.Text = Val(txtdari.Text) / 70080 & " " & cbke.Text

        ElseIf cbdari.Text = "Jam" And cbke.Text = "Dasawarsa" Then
            hasil.Text = txtdari.Text / 87600 & " " & cbke.Text

        ElseIf cbdari.Text = "Hari" And cbke.Text = "Detik" Then
            hasil.Text = Val(txtdari.Text) * 86400 & " " & cbke.Text

        ElseIf cbdari.Text = "Hari" And cbke.Text = "Menit" Then
            hasil.Text = Val(txtdari.Text) * 1440 & " " & cbke.Text

        ElseIf cbdari.Text = "Hari" And cbke.Text = "Jam" Then
            hasil.Text = Val(txtdari.Text) * 24 & " " & cbke.Text

        ElseIf cbdari.Text = "Hari" And cbke.Text = "Hari" Then
            hasil.Text = Val(txtdari.Text) & " " & cbke.Text

        ElseIf cbdari.Text = "Hari" And cbke.Text = "Minggu" Then
            hasil.Text = Val(txtdari.Text) / 7 & " " & cbke.Text

        ElseIf cbdari.Text = "Hari" And cbke.Text = "Bulan" Then
            hasil.Text = Val(txtdari.Text) / 24 & " " & cbke.Text

        ElseIf cbdari.Text = "Hari" And cbke.Text = "Tahun" Then
            hasil.Text = Val(txtdari.Text) / 365 & " " & cbke.Text

        ElseIf cbdari.Text = "Hari" And cbke.Text = "Lustrum" Then
            hasil.Text = txtdari.Text / 1825 & " " & cbke.Text

        ElseIf cbdari.Text = "Hari" And cbke.Text = "Windu" Then
            hasil.Text = Val(txtdari.Text) / 2920 & " " & cbke.Text

        ElseIf cbdari.Text = "Hari" And cbke.Text = "Dasawarsa" Then
            hasil.Text = txtdari.Text / 3650 & " " & cbke.Text

        ElseIf cbdari.Text = "Minggu" And cbke.Text = "Minggu" Then
            hasil.Text = Val(txtdari.Text) & " " & cbke.Text

        ElseIf cbdari.Text = "Minggu" And cbke.Text = "Hari" Then
            hasil.Text = Val(txtdari.Text) * 7 & " " & cbke.Text

        ElseIf cbdari.Text = "Minggu" And cbke.Text = "Jam" Then
            hasil.Text = Val(txtdari.Text) * 168 & " " & cbke.Text

        ElseIf cbdari.Text = "Minggu" And cbke.Text = "Menit" Then
            hasil.Text = Val(txtdari.Text) * 10080 & " " & cbke.Text

        ElseIf cbdari.Text = "Minggu" And cbke.Text = "Detik" Then
            hasil.Text = Val(txtdari.Text) * 604800 & " " & cbke.Text

        ElseIf cbdari.Text = "Minggu" And cbke.Text = "Bulan" Then
            hasil.Text = Val(txtdari.Text) / 4 & " " & cbke.Text

        ElseIf cbdari.Text = "Minggu" And cbke.Text = "Tahun" Then
            hasil.Text = Val(txtdari.Text) / 48 & " " & cbke.Text

        ElseIf cbdari.Text = "Minggu" And cbke.Text = "Lustrum" Then
            hasil.Text = txtdari.Text / 240 & " " & cbke.Text

        ElseIf cbdari.Text = "Minggu" And cbke.Text = "Windu" Then
            hasil.Text = Val(txtdari.Text) / 384 & " " & cbke.Text

        ElseIf cbdari.Text = "Minggu" And cbke.Text = "Dasawarsa" Then
            hasil.Text = txtdari.Text / 480 & " " & cbke.Text

        ElseIf cbdari.Text = "Bulan" And cbke.Text = "Bulan" Then
            hasil.Text = Val(txtdari.Text) & " " & cbke.Text

        ElseIf cbdari.Text = "Bulan" And cbke.Text = "Minggu" Then
            hasil.Text = Val(txtdari.Text) * 4 & " " & cbke.Text

        ElseIf cbdari.Text = "Bulan" And cbke.Text = "Hari" Then
            hasil.Text = Val(txtdari.Text) * 24 & " " & cbke.Text

        ElseIf cbdari.Text = "Bulan" And cbke.Text = "Jam" Then
            hasil.Text = Val(txtdari.Text) * 672 & " " & cbke.Text

        ElseIf cbdari.Text = "Bulan" And cbke.Text = "Menit" Then
            hasil.Text = Val(txtdari.Text) * 40320 & " " & cbke.Text

        ElseIf cbdari.Text = "Bulan" And cbke.Text = "Detik" Then
            hasil.Text = Val(txtdari.Text) * 2419200 & " " & cbke.Text

        ElseIf cbdari.Text = "Bulan" And cbke.Text = "Tahun" Then
            hasil.Text = Val(txtdari.Text) / 12 & " " & cbke.Text

        ElseIf cbdari.Text = "Bulan" And cbke.Text = "Lustrum" Then
            hasil.Text = txtdari.Text / 60 & " " & cbke.Text

        ElseIf cbdari.Text = "Bulan" And cbke.Text = "Windu" Then
            hasil.Text = Val(txtdari.Text) / 96 & " " & cbke.Text

        ElseIf cbdari.Text = "Bulan" And cbke.Text = "Dasawarsa" Then
            hasil.Text = txtdari.Text / 120 & " " & cbke.Text

        ElseIf cbdari.Text = "Tahun" And cbke.Text = "Tahun" Then
            hasil.Text = Val(txtdari.Text) & " " & cbke.Text

        ElseIf cbdari.Text = "Tahun" And cbke.Text = "Lustrum" Then
            hasil.Text = txtdari.Text / 5 & " " & cbke.Text

        ElseIf cbdari.Text = "Tahun" And cbke.Text = "Bulan" Then
            hasil.Text = Val(txtdari.Text) * 12 & " " & cbke.Text

        ElseIf cbdari.Text = "Tahun" And cbke.Text = "Minggu" Then
            hasil.Text = Val(txtdari.Text) * 48 & " " & cbke.Text

        ElseIf cbdari.Text = "Tahun" And cbke.Text = "Hari" Then
            hasil.Text = Val(txtdari.Text) * 8760 & " " & cbke.Text

        ElseIf cbdari.Text = "Tahun" And cbke.Text = "Jam" Then
            hasil.Text = Val(txtdari.Text) * 8760 & " " & cbke.Text

        ElseIf cbdari.Text = "Tahun" And cbke.Text = "Menit" Then
            hasil.Text = Val(txtdari.Text) * 525600 & " " & cbke.Text

        ElseIf cbdari.Text = "Tahun" And cbke.Text = "Detik" Then
            hasil.Text = Val(txtdari.Text) * 31536000 & " " & cbke.Text

        ElseIf cbdari.Text = "Tahun" And cbke.Text = "Windu" Then
            hasil.Text = Val(txtdari.Text) / 8 & " " & cbke.Text

        ElseIf cbdari.Text = "Tahun" And cbke.Text = "Dasawarsa" Then
            hasil.Text = txtdari.Text / 10 & " " & cbke.Text

        ElseIf cbdari.Text = "Lustrum" And cbke.Text = "Dasawarsa" Then
            hasil.Text = txtdari.Text / 10 & " " & cbke.Text

        ElseIf cbdari.Text = "Lustrum" And cbke.Text = "Lustrum" Then
            hasil.Text = txtdari.Text & " " & cbke.Text

        ElseIf cbdari.Text = "Lustrum" And cbke.Text = "Windu" Then
            hasil.Text = txtdari.Text / (16 / 10) & " " & cbke.Text

        ElseIf cbdari.Text = "Lustrum" And cbke.Text = "Tahun" Then
            hasil.Text = txtdari.Text * 5 & " " & cbke.Text

        ElseIf cbdari.Text = "Lustrum" And cbke.Text = "Bulan" Then
            hasil.Text = txtdari.Text * 60 & " " & cbke.Text

        ElseIf cbdari.Text = "Lustrum" And cbke.Text = "Minggu" Then
            hasil.Text = txtdari.Text * 240 & " " & cbke.Text

        ElseIf cbdari.Text = "Lustrum" And cbke.Text = "Hari" Then
            hasil.Text = txtdari.Text * 1825 & " " & cbke.Text

        ElseIf cbdari.Text = "Lustrum" And cbke.Text = "Jam" Then
            hasil.Text = txtdari.Text * 43800 & " " & cbke.Text

        ElseIf cbdari.Text = "Lustrum" And cbke.Text = "Menit" Then
            hasil.Text = txtdari.Text * 2628000 & " " & cbke.Text

        ElseIf cbdari.Text = "Lustrum" And cbke.Text = "Detik" Then
            hasil.Text = Val(txtdari.Text) * 157680000 & " " & cbke.Text

        ElseIf cbdari.Text = "Windu" And cbke.Text = "Dasawarsa" Then
            hasil.Text = txtdari.Text / (125 / 100) & " " & cbke.Text

        ElseIf cbdari.Text = "Windu" And cbke.Text = "Windu" Then
            hasil.Text = txtdari.Text & " " & cbke.Text

        ElseIf cbdari.Text = "Windu" And cbke.Text = "Lustrum" Then
            hasil.Text = txtdari.Text * (16 / 10) & " " & cbke.Text

        ElseIf cbdari.Text = "Windu" And cbke.Text = "Tahun" Then
            hasil.Text = Val(txtdari.Text) * 8 & " " & cbke.Text

        ElseIf cbdari.Text = "Windu" And cbke.Text = "Bulan" Then
            hasil.Text = Val(txtdari.Text) * 96 & " " & cbke.Text

        ElseIf cbdari.Text = "Windu" And cbke.Text = "Minggu" Then
            hasil.Text = Val(txtdari.Text) * 384 & " " & cbke.Text

        ElseIf cbdari.Text = "Windu" And cbke.Text = "Hari" Then
            hasil.Text = Val(txtdari.Text) * 2920 & " " & cbke.Text

        ElseIf cbdari.Text = "Windu" And cbke.Text = "Jam" Then
            hasil.Text = Val(txtdari.Text) * 70080 & " " & cbke.Text

        ElseIf cbdari.Text = "Windu" And cbke.Text = "Menit" Then
            hasil.Text = Val(txtdari.Text) * 4204800 & " " & cbke.Text

        ElseIf cbdari.Text = "Windu" And cbke.Text = "Detik" Then
            hasil.Text = Val(txtdari.Text) * 252288000 & " " & cbke.Text

        ElseIf cbdari.Text = "Dasawarsa" And cbke.Text = "Dasawarsa" Then
            hasil.Text = txtdari.Text & " " & cbke.Text

        ElseIf cbdari.Text = "Dasawarsa" And cbke.Text = "Windu" Then
            hasil.Text = txtdari.Text * (125 / 100) & " " & cbke.Text

        ElseIf cbdari.Text = "Dasawarsa" And cbke.Text = "Lustrum" Then
            hasil.Text = txtdari.Text * 5 & " " & cbke.Text

        ElseIf cbdari.Text = "Dasawarsa" And cbke.Text = "Tahun" Then
            hasil.Text = txtdari.Text * 10 & " " & cbke.Text

        ElseIf cbdari.Text = "Dasawarsa" And cbke.Text = "Bulan" Then
            hasil.Text = txtdari.Text * 120 & " " & cbke.Text

        ElseIf cbdari.Text = "Dasawarsa" And cbke.Text = "Minggu" Then
            hasil.Text = txtdari.Text * 480 & " " & cbke.Text

        ElseIf cbdari.Text = "Dasawarsa" And cbke.Text = "Hari" Then
            hasil.Text = txtdari.Text * 3650 & " " & cbke.Text

        ElseIf cbdari.Text = "Dasawarsa" And cbke.Text = "Jam" Then
            hasil.Text = txtdari.Text * 87600 & " " & cbke.Text

        ElseIf cbdari.Text = "Dasawarsa" And cbke.Text = "Menit" Then
            hasil.Text = txtdari.Text * 525600 & " " & cbke.Text

        ElseIf cbdari.Text = "Dasawarsa" And cbke.Text = "Detik" Then
            hasil.Text = txtdari.Text * 315360000 & " " & cbke.Text

        ElseIf cbdari.Text = "Abad" And cbke.Text = "Abad" Then
            hasil.Text = txtdari.Text & " " & cbke.Text
        ElseIf cbdari.Text = "Abad" And cbke.Text = "Dasawarsa" Then
            hasil.Text = txtdari.Text * 10 & " " & cbke.Text
        ElseIf cbdari.Text = "Dasawarsa" And cbke.Text = "Abad" Then
            hasil.Text = txtdari.Text / 10 & " " & cbke.Text
        ElseIf cbdari.Text = "Abad" And cbke.Text = "Lustrum" Then
            hasil.Text = txtdari.Text * 20 & " " & cbke.Text
        ElseIf cbdari.Text = "Lustrum" And cbke.Text = "Abad" Then
            hasil.Text = txtdari.Text / 20 & " " & cbke.Text
        ElseIf cbdari.Text = "Abad" And cbke.Text = "Windu" Then
            hasil.Text = txtdari.Text * (125 / 10) & " " & cbke.Text
        ElseIf cbdari.Text = "Windu" And cbke.Text = "Abad" Then
            hasil.Text = txtdari.Text / (125 / 10) & " " & cbke.Text
        ElseIf cbdari.Text = "Abad" And cbke.Text = "Tahun" Then
            hasil.Text = txtdari.Text * 100 & " " & cbke.Text
        ElseIf cbdari.Text = "Tahun" And cbke.Text = "Abad" Then
            hasil.Text = txtdari.Text / 100 & " " & cbke.Text
        ElseIf cbdari.Text = "Abad" And cbke.Text = "Bulan" Then
            hasil.Text = txtdari.Text * 1200 & " " & cbke.Text
        ElseIf cbdari.Text = "Bulan" And cbke.Text = "Abad" Then
            hasil.Text = txtdari.Text / 1200 & " " & cbke.Text
        ElseIf cbdari.Text = "Abad" And cbke.Text = "Minggu" Then
            hasil.Text = txtdari.Text * 4800 & " " & cbke.Text
        ElseIf cbdari.Text = "Minggu" And cbke.Text = "Abad" Then
            hasil.Text = txtdari.Text / 4800 & " " & cbke.Text
        ElseIf cbdari.Text = "Abad" And cbke.Text = "Hari" Then
            hasil.Text = txtdari.Text * 36500 & " " & cbke.Text
        ElseIf cbdari.Text = "Hari" And cbke.Text = "Abad" Then
            hasil.Text = txtdari.Text / 36500 & " " & cbke.Text
        ElseIf cbdari.Text = "Abad" And cbke.Text = "Jam" Then
            hasil.Text = txtdari.Text * 876000 & " " & cbke.Text
        ElseIf cbdari.Text = "Jam" And cbke.Text = "Abad" Then
            hasil.Text = txtdari.Text / 876000 & " " & cbke.Text
        ElseIf cbdari.Text = "Abad" And cbke.Text = "Menit" Then
            hasil.Text = txtdari.Text * 52560000 & " " & cbke.Text
        ElseIf cbdari.Text = "Menit" And cbke.Text = "Abad" Then
            hasil.Text = txtdari.Text / 52560000 & " " & cbke.Text
        ElseIf cbdari.Text = "Abad" And cbke.Text = "Detik" Then
            hasil.Text = txtdari.Text * 3153600000 & " " & cbke.Text
        ElseIf cbdari.Text = "Detik" And cbke.Text = "Abad" Then
            hasil.Text = txtdari.Text / 3153600000 & " " & cbke.Text
        ElseIf MsgBox("MASUKAN SATUAN NILAI", MsgBoxStyle.Information, "INVALID") Then
        End If
    End Sub

    Private Sub txtdari_KeyDown(sender As Object, e As KeyEventArgs) Handles txtdari.KeyDown
        If e.KeyCode = Keys.Enter Then
            Button3.Show()

        End If
    End Sub

    Private Sub txtdari_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtdari.KeyPress
        If Not ((e.KeyChar >= "0" And e.KeyChar <= "9") Or e.KeyChar = vbBack) Then e.Handled = True
    End Sub

    Private Sub Label8_Click(sender As Object, e As EventArgs) Handles Label8.Click

    End Sub

    Private Sub SatuanWaktu_Paint(sender As Object, e As PaintEventArgs) Handles Me.Paint
        Dim d As New System.Drawing.Drawing2D.LinearGradientBrush(Me.ClientRectangle, Color.FromArgb(76, 161, 175), Color.FromArgb(196, 224, 229), Drawing2D.LinearGradientMode.Vertical)
        e.Graphics.FillRectangle(d, Me.ClientRectangle)

    End Sub
End Class