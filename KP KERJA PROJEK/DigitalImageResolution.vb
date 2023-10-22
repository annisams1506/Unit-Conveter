Public Class DigitalImageResolution
    Sub combo()
        With awal
            .Items.Add("Dot/Inch")
            .Items.Add("Dot/Meter")
            .Items.Add("Dot/Milimeter")
            .Items.Add("Pixel/Inch")
            With akhir
                .Items.Add("Dot/Inch")
                .Items.Add("Dot/Meter")
                .Items.Add("Dot/Milimeter")
                .Items.Add("Pixel/Inch")
            End With
        End With
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If input.Text = "" Then
            MsgBox("MASUKKAN ANGKA", MsgBoxStyle.Information, "INVALID")
        End If
        If awal.Text = "Dot/Inch" And akhir.Text = "Dot/Inch" Then
            hasil.Text = input.Text & " " & akhir.Text
        ElseIf awal.Text = "Dot/Meter" And akhir.Text = "Dot/Inch" Then
            hasil.Text = input.Text * (254 / 10000) & " " & akhir.Text
        ElseIf awal.Text = "Dot/Milimeter" And akhir.Text = "Dot/Inch" Then
            hasil.Text = input.Text * (254 / 10) & " " & akhir.Text
        ElseIf awal.Text = "Pixel/Inch" And akhir.Text = "Dot/Inch" Then
            hasil.Text = input.Text & " " & akhir.Text

        ElseIf awal.Text = "Dot/Inch" And akhir.Text = "Dot/Meter" Then
            hasil.Text = input.Text / (254 / 10000) & " " & akhir.Text
        ElseIf awal.Text = "Dot/Meter" And akhir.Text = "Dot/Meter" Then
            hasil.Text = input.Text & " " & akhir.Text
        ElseIf awal.Text = "Dot/Milimeter" And akhir.Text = "Dot/Meter" Then
            hasil.Text = input.Text * 1000 & " " & akhir.Text
        ElseIf awal.Text = "Pixel/Inch" And akhir.Text = "Dot/Meter" Then
            hasil.Text = input.Text / (254 / 10000) & " " & akhir.Text

        ElseIf awal.Text = "Dot/Inch" And akhir.Text = "Dot/Milimeter" Then
            hasil.Text = input.Text / (254 / 10) & " " & akhir.Text
        ElseIf awal.Text = "Dot/Meter" And akhir.Text = "Dot/Milimeter" Then
            hasil.Text = input.Text * (1 / 1000) & " " & akhir.Text
        ElseIf awal.Text = "Dot/Milimeter" And akhir.Text = "Dot/Milimeter" Then
            hasil.Text = input.Text & " " & akhir.Text
        ElseIf awal.Text = "Pixel/Inch" And akhir.Text = "Dot/Milimeter" Then
            hasil.Text = input.Text / (254 / 10) & " " & akhir.Text

        ElseIf awal.Text = "Dot/Inch" And akhir.Text = "Pixel/Inch" Then
            hasil.Text = input.Text & " " & akhir.Text
        ElseIf awal.Text = "Dot/Meter" And akhir.Text = "Pixel/Inch" Then
            hasil.Text = input.Text * (254 / 10000) & " " & akhir.Text
        ElseIf awal.Text = "Dot/Milimeter" And akhir.Text = "Pixel/Inch" Then
            hasil.Text = input.Text * (254 / 10) & " " & akhir.Text
        ElseIf awal.Text = "Pixel/Inch" And akhir.Text = "Pixel/Inch" Then
            hasil.Text = input.Text & " " & akhir.Text

        ElseIf MsgBox("MASUKAN SATUAN NILAI", MsgBoxStyle.Information, "INVALID") Then
        End If
    End Sub

    Private Sub DigitalImageResolution_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Call combo()
        Me.ResizeRedraw = True
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        input.Text = ""
        hasil.Text = ""
        Me.awal.SelectedItem = Nothing
        Me.akhir.SelectedItem = Nothing
    End Sub

    Private Sub input_KeyDown(sender As Object, e As KeyEventArgs) Handles input.KeyDown
        If e.KeyCode = Keys.Enter Then
            awal.Show()

        End If
    End Sub

    Private Sub input_KeyPress(sender As Object, e As KeyPressEventArgs) Handles input.KeyPress
        If Not ((e.KeyChar >= "0" And e.KeyChar <= "9") Or e.KeyChar = vbBack) Then e.Handled = True
    End Sub

   

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        home.Show()
        Me.Close()
    End Sub

    Private Sub Label5_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub DigitalImageResolution_Paint(sender As Object, e As PaintEventArgs) Handles Me.Paint
        Dim d As New System.Drawing.Drawing2D.LinearGradientBrush(Me.ClientRectangle, Color.FromArgb(255, 161, 127), Color.FromArgb(0, 34, 62), Drawing2D.LinearGradientMode.ForwardDiagonal)
        e.Graphics.FillRectangle(d, Me.ClientRectangle)
    End Sub

    Private Sub input_TextChanged(sender As Object, e As EventArgs) Handles input.TextChanged

    End Sub

    Private Sub awal_KeyDown(sender As Object, e As KeyEventArgs) Handles awal.KeyDown
        If e.KeyCode = Keys.Enter Then
            akhir.Show()

        End If
    End Sub

    Private Sub awal_SelectedIndexChanged(sender As Object, e As EventArgs) Handles awal.SelectedIndexChanged

    End Sub

    Private Sub akhir_KeyDown(sender As Object, e As KeyEventArgs) Handles akhir.KeyDown
        If e.KeyCode = Keys.Enter Then
            hasil.Show()

        End If
    End Sub

    Private Sub akhir_SelectedIndexChanged(sender As Object, e As EventArgs) Handles akhir.SelectedIndexChanged

    End Sub
End Class