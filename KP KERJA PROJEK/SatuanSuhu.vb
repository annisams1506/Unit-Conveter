Public Class SatuanSuhu
    Sub combo()
        With awal
            .Items.Add("Celcius")
            .Items.Add("Reamur")
            .Items.Add("Farenheit")
            .Items.Add("Kelvin")
            .Items.Add("Rankine")
            .Items.Add("Delisle")
            .Items.Add("Newton")
            .Items.Add("Rømer")

        End With
        With akhir
            .Items.Add("Celcius")
            .Items.Add("Reamur")
            .Items.Add("Farenheit")
            .Items.Add("Kelvin")
            .Items.Add("Rankine")
            .Items.Add("Delisle")
            .Items.Add("Newton")
            .Items.Add("Rømer")
        End With
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If input.Text = "" Then
            MsgBox("MASUKKAN ANGKA", MsgBoxStyle.Information, "INVALID")
        End If
        If awal.Text = "Celcius" And akhir.Text = "Celcius" Then
            hasil.Text = input.Text & " " & akhir.Text

        ElseIf awal.Text = "Celcius" And akhir.Text = "Reamur" Then
            hasil.Text = 4 / 5 * Val(input.Text) & " " & akhir.Text

        ElseIf awal.Text = "Celcius" And akhir.Text = "Farenheit" Then
            hasil.Text = 9 / 5 * Val(input.Text) + 32 & " " & akhir.Text

        ElseIf awal.Text = "Celcius" And akhir.Text = "Kelvin" Then
            hasil.Text = 4 / 5 * Val(input.Text) + 32 & " " & akhir.Text

        ElseIf awal.Text = "Reamur" And akhir.Text = "Reamur" Then
            hasil.Text = input.Text & " " & akhir.Text

        ElseIf awal.Text = "Reamur" And akhir.Text = "Celcius" Then
            hasil.Text = 5 / 4 * Val(input.Text) & " " & akhir.Text

        ElseIf awal.Text = "Reamur" And akhir.Text = "Farenheit" Then
            hasil.Text = 9 / 4 * Val(input.Text) + 32

        ElseIf awal.Text = "Reamur" And akhir.Text = "Kelvin" Then
            hasil.Text = 5 / 4 * Val(input.Text) + 273 & " " & akhir.Text

        ElseIf awal.Text = "Farenheit" And akhir.Text = "Farenheit" Then
            hasil.Text = input.Text & " " & akhir.Text

        ElseIf awal.Text = "Farenheit" And akhir.Text = "Celcius" Then
            hasil.Text = 5 / 9 * Val(input.Text) - 32 & " " & akhir.Text

        ElseIf awal.Text = "Farenheit" And akhir.Text = "Reamur" Then
            hasil.Text = 4 / 9 * Val(input.Text) - 32 & " " & akhir.Text

        ElseIf awal.Text = "Farenheit" And akhir.Text = "Kelvin" Then
            hasil.Text = Val((input.Text - 32) * 5 / 9) + 273 & " " & akhir.Text

        ElseIf awal.Text = "Kelvin" And akhir.Text = "Kelvin" Then
            hasil.Text = input.Text & " " & akhir.Text

        ElseIf awal.Text = "Kelvin" And akhir.Text = "Celcius" Then
            hasil.Text = Val(input.Text) - 273 & " " & akhir.Text

        ElseIf awal.Text = "Kelvin" And akhir.Text = "Reamur" Then
            hasil.Text = Val(input.Text - 273) * 4 / 5 & " " & akhir.Text

        ElseIf awal.Text = "Kelvin" And akhir.Text = "Farenheit" Then
            hasil.Text = Val((input.Text - 273) * 9 / 5) + 32 & " " & akhir.Text

        ElseIf awal.Text = "Rankine" And akhir.Text = "Rankine" Then
            hasil.Text = input.Text & " " & akhir.Text

        ElseIf awal.Text = "Rankine" And akhir.Text = "Celcius" Then
            hasil.Text = input.Text / ((18 / 100) + (27315 / 100)) & " " & akhir.Text

        ElseIf awal.Text = "Celcius" And akhir.Text = "Rankine" Then
            hasil.Text = (18 * 10) * (input.Text + (49167 / 100)) & " " & akhir.Text

        ElseIf awal.Text = "Rankine" And akhir.Text = "Farenheit" Then
            hasil.Text = input.Text - (45967 / 100) & " " & akhir.Text

        ElseIf awal.Text = "Farenheit" And akhir.Text = "Rankine" Then
            hasil.Text = input.Text + (45967 / 100) & " " & akhir.Text

        ElseIf awal.Text = "Rankine" And akhir.Text = "Kelvin" Then
            hasil.Text = input.Text / (18 / 10) & " " & akhir.Text

        ElseIf awal.Text = "Kelvin" And akhir.Text = "Rankine" Then
            hasil.Text = input.Text * (18 / 10) & " " & akhir.Text

        ElseIf awal.Text = "Rankine" And akhir.Text = "Reamur" Then
            hasil.Text = (input.Text / (18 / 10) + (27315 / 100)) * (8 / 10) & " " & akhir.Text

        ElseIf awal.Text = "Reamur" And akhir.Text = "Rankine" Then
            hasil.Text = input.Text * (225 / 100) + (49167 / 100)

        ElseIf awal.Text = "Delisle" And akhir.Text = "Delisle" Then
            hasil.Text = input.Text & " " & akhir.Text

        ElseIf awal.Text = "Delisle" And akhir.Text = "Celcius" Then
            hasil.Text = 100 - (input.Text * (2 / 3)) & " " & akhir.Text

        ElseIf awal.Text = "Delisle" And akhir.Text = "Kelvin" Then
            hasil.Text = (37315 / 100) - input.Text * (2 / 3) & "  " & akhir.Text

        ElseIf awal.Text = "Delisle" And akhir.Text = "Reamur" Then
            hasil.Text = 80 - input.Text * (8 / 15) & " " & akhir.Text

        ElseIf awal.Text = "Delisle" And akhir.Text = "Farenheit" Then
            hasil.Text = 212 - input.Text * (12 / 10) & " " & akhir.Text

        ElseIf awal.Text = "Delisle" And akhir.Text = "Rankine" Then
            hasil.Text = (67167 / 100) - input.Text * (12 / 10) & " " & akhir.Text

        ElseIf awal.Text = "Celcius" And akhir.Text = "Delisle" Then
            hasil.Text = (100 - input.Text) * (15 / 10) & " " & akhir.Text

        ElseIf awal.Text = "Farenheit" And akhir.Text = "Delisle" Then
            hasil.Text = (212 - input.Text) * (5 / 6) & " " & akhir.Text

        ElseIf awal.Text = "Kelvin" And akhir.Text = "Delisle" Then
            hasil.Text = ((37315 / 100) - input.Text) * (15 / 10) & " " & akhir.Text

        ElseIf awal.Text = "Rankine" And akhir.Text = "Delisle" Then
            hasil.Text = ((67167 / 100) - input.Text) * (5 / 6) & " " & akhir.Text

        ElseIf awal.Text = "Reamur" And akhir.Text = "Delisle" Then
            hasil.Text = (80 - input.Text) * (1875 / 1000) & " " & akhir.Text

        ElseIf awal.Text = "Rømer" And akhir.Text = "Rømer" Then
            hasil.Text = input.Text & " " & akhir.Text

        ElseIf awal.Text = "Rømer" And akhir.Text = "Kelvin" Then
            hasil.Text = (input.Text - (75 / 10)) * 40 / 21 + 273 & " " & akhir.Text

        ElseIf awal.Text = "Kelvin" And akhir.Text = "Rømer" Then
            hasil.Text = (input.Text - (75 / 10)) / 40 / 21 + 273 & " " & akhir.Text

        ElseIf awal.Text = "Rømer" And akhir.Text = "Celcius" Then
            hasil.Text = (input.Text - (75 / 10)) * 40 / 21 & " " & akhir.Text

        ElseIf awal.Text = "Celcius" And akhir.Text = "Rømer" Then
            hasil.Text = (input.Text - (75 / 10)) / 40 / 21 & " " & akhir.Text

        ElseIf awal.Text = "Rømer" And akhir.Text = "Farenheit" Then
            hasil.Text = (input.Text - (75 / 10)) * 24 / 7 + 32 & " " & akhir.Text

        ElseIf awal.Text = "Farenheit" And akhir.Text = "Rømer" Then
            hasil.Text = (input.Text - (75 / 10)) / 24 / 7 + 32 & " " & akhir.Text

        ElseIf awal.Text = "Rømer" And akhir.Text = "Rankine" Then
            hasil.Text = (input.Text - (75 / 10)) * 24 / 7 + (29167 / 100) & " " & akhir.Text

        ElseIf awal.Text = "Rankine" And akhir.Text = "Rømer" Then
            hasil.Text = (input.Text - (75 / 10)) / 24 / 7 + (29167 / 100) & " " & akhir.Text

        ElseIf awal.Text = "Rømer" And akhir.Text = "Delisle" Then
            hasil.Text = (60 - input.Text) * (20 / 7) & " " & akhir.Text

        ElseIf awal.Text = "Delisle" And akhir.Text = "Rømer" Then
            hasil.Text = (60 - input.Text) / (20 / 7) & " " & akhir.Text

        ElseIf awal.Text = "Rømer" And akhir.Text = "Newton" Then
            hasil.Text = (input.Text - (75 / 10)) * (22 / 35) & " " & akhir.Text

        ElseIf awal.Text = "Newton" And akhir.Text = "Rømer" Then
            hasil.Text = (input.Text - (75 / 10)) / (22 / 35) & " " & akhir.Text

        ElseIf awal.Text = "Rømer" And akhir.Text = "Reamur" Then
            hasil.Text = (input.Text - (75 / 10)) * 32 / 21 & " " & akhir.Text

        ElseIf awal.Text = "Reamur" And akhir.Text = "Rømer" Then
            hasil.Text = (input.Text - (75 / 10)) / (32 / 21) & " " & akhir.Text

        ElseIf awal.Text = "Newton" And akhir.Text = "Newton" Then
            hasil.Text = input.Text & " " & akhir.Text

        ElseIf awal.Text = "Newton" And akhir.Text = "Kelvin" Then
            hasil.Text = input.Text * 100 / 33 + (27315 / 100) & " " & akhir.Text

        ElseIf awal.Text = "Newton" And akhir.Text = "Celcius" Then
            hasil.Text = input.Text * 100 / 33 & " " & akhir.Text

        ElseIf awal.Text = "Newton" And akhir.Text = "Farenheit" Then
            hasil.Text = input.Text * 60 / 11 + 32 & " " & akhir.Text

        ElseIf awal.Text = "Newton" And akhir.Text = "Rankine" Then
            hasil.Text = input.Text * 60 / 11 + (49167 / 100) & " " & akhir.Text

        ElseIf awal.Text = "Newton" And akhir.Text = "Delisle" Then
            hasil.Text = (33 - input.Text) * 50 / 11 & " " & akhir.Text

        ElseIf awal.Text = "Newton" And akhir.Text = "Reamur" Then
            hasil.Text = input.Text * 80 / 33 & " " & akhir.Text

        ElseIf awal.Text = "Newton" And akhir.Text = "Rømer" Then
            hasil.Text = input.Text * 35 / 22 + (75 / 10) & " " & akhir.Text

        ElseIf MsgBox("MASUKAN SATUAN NILAI", MsgBoxStyle.Information, "INVALID") Then
        End If
    End Sub

    Private Sub Form8_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.ResizeRedraw = True
        Call combo()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        home.Show()
        Me.Close()
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        input.Text = ""
        hasil.text = ""
        Me.akhir.SelectedItem = Nothing
        Me.awal.SelectedItem = Nothing
    End Sub

    Private Sub input_KeyDown(sender As Object, e As KeyEventArgs) Handles input.KeyDown
        If e.KeyCode = Keys.Enter Then
            Button1.Show()

        End If
    End Sub

    Private Sub TextBox1_KeyPress(sender As Object, e As KeyPressEventArgs) Handles input.KeyPress
        If Not ((e.KeyChar >= "0" And e.KeyChar <= "9") Or e.KeyChar = vbBack) Then e.Handled = True
    End Sub

    Private Sub Label11_Click(sender As Object, e As EventArgs) Handles Label11.Click

    End Sub

    Private Sub SatuanSuhu_Paint(sender As Object, e As PaintEventArgs) Handles Me.Paint
        Dim d As New System.Drawing.Drawing2D.LinearGradientBrush(Me.ClientRectangle, Color.FromArgb(194, 229, 156), Color.FromArgb(100, 179, 244), Drawing2D.LinearGradientMode.Vertical)
        e.Graphics.FillRectangle(d, Me.ClientRectangle)

    End Sub
End Class