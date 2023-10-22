Public Class satuanpanjang
    Sub combo()
        With ComboBox1
            .Items.Add("KM")
            .Items.Add("HM")
            .Items.Add("DAM")
            .Items.Add("M")
            .Items.Add("DM")
            .Items.Add("CM")
            .Items.Add("MM")
        End With
        With ComboBox2
            .Items.Add("KM")
            .Items.Add("HM")
            .Items.Add("DAM")
            .Items.Add("M")
            .Items.Add("DM")
            .Items.Add("CM")
            .Items.Add("MM")
        End With

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If TextBox1.Text = "" Then
            MsgBox("MASUKKAN ANGKA", MsgBoxStyle.Information, "INVALID")
        End If
        If ComboBox1.Text = "KM" And ComboBox2.Text = "KM" Then
            hasil.Text = TextBox1.Text & " " & ComboBox2.Text

        ElseIf ComboBox1.Text = "KM" And ComboBox2.Text = "HM" Then
            hasil.Text = TextBox1.Text * 10 & " " & ComboBox2.Text

        ElseIf ComboBox1.Text = "KM" And ComboBox2.Text = "DAM" Then
            hasil.Text = TextBox1.Text * 100 & " " & ComboBox2.Text

        ElseIf ComboBox1.Text = "KM" And ComboBox2.Text = "M" Then
            hasil.Text = TextBox1.Text * 1000 & " " & ComboBox2.Text

        ElseIf ComboBox1.Text = "KM" And ComboBox2.Text = "DM" Then
            hasil.Text = TextBox1.Text * 10000 & " " & ComboBox2.Text

        ElseIf ComboBox1.Text = "KM" And ComboBox2.Text = "CM" Then
            hasil.Text = TextBox1.Text * 100000 & " " & ComboBox2.Text

        ElseIf ComboBox1.Text = "KM" And ComboBox2.Text = "MM" Then
            hasil.Text = TextBox1.Text * 1000000 & " " & ComboBox2.Text

        ElseIf ComboBox1.Text = "HM" And ComboBox2.Text = "KM" Then
            hasil.Text = TextBox1.Text / 10 & " " & ComboBox2.Text

        ElseIf ComboBox1.Text = "HM" And ComboBox2.Text = "HM" Then
            hasil.Text = TextBox1.Text & " " & ComboBox2.Text

        ElseIf ComboBox1.Text = "HM" And ComboBox2.Text = "DAM" Then
            hasil.Text = TextBox1.Text * 10 & " " & ComboBox2.Text

        ElseIf ComboBox1.Text = "HM" And ComboBox2.Text = "M" Then
            hasil.Text = TextBox1.Text * 100 & " " & ComboBox2.Text

        ElseIf ComboBox1.Text = "HM" And ComboBox2.Text = "DM" Then
            hasil.Text = TextBox1.Text * 1000 & " " & ComboBox2.Text

        ElseIf ComboBox1.Text = "HM" And ComboBox2.Text = "CM" Then
            hasil.Text = TextBox1.Text * 10000 & " " & ComboBox2.Text

        ElseIf ComboBox1.Text = "HM" And ComboBox2.Text = "MM" Then
            hasil.Text = TextBox1.Text * 100000 & " " & ComboBox2.Text

        ElseIf ComboBox1.Text = "DAM" And ComboBox2.Text = "KM" Then
            hasil.Text = TextBox1.Text / 100 & " " & ComboBox2.Text

        ElseIf ComboBox1.Text = "DAM" And ComboBox2.Text = "HM" Then
            hasil.Text = TextBox1.Text / 10 & " " & ComboBox2.Text

        ElseIf ComboBox1.Text = "DAM" And ComboBox2.Text = "DAM" Then
            hasil.Text = TextBox1.Text & " " & ComboBox2.Text

        ElseIf ComboBox1.Text = "DAM" And ComboBox2.Text = "M" Then
            hasil.Text = TextBox1.Text * 10 & " " & ComboBox2.Text

        ElseIf ComboBox1.Text = "DAM" And ComboBox2.Text = "DM" Then
            hasil.Text = TextBox1.Text * 100 & " " & ComboBox2.Text

        ElseIf ComboBox1.Text = "DAM" And ComboBox2.Text = "CM" Then
            hasil.Text = TextBox1.Text * 1000 & " " & ComboBox2.Text

        ElseIf ComboBox1.Text = "DAM" And ComboBox2.Text = "MM" Then
            hasil.Text = TextBox1.Text * 10000 & " " & ComboBox2.Text

        ElseIf ComboBox1.Text = "M" And ComboBox2.Text = "KM" Then
            hasil.Text = TextBox1.Text / 1000 & " " & ComboBox2.Text

        ElseIf ComboBox1.Text = "M" And ComboBox2.Text = "HM" Then
            hasil.Text = TextBox1.Text / 100 & " " & ComboBox2.Text

        ElseIf ComboBox1.Text = "M" And ComboBox2.Text = "DAM" Then
            hasil.Text = TextBox1.Text / 10 & " " & ComboBox2.Text

        ElseIf ComboBox1.Text = "M" And ComboBox2.Text = "M" Then
            hasil.Text = TextBox1.Text & " " & ComboBox2.Text

        ElseIf ComboBox1.Text = "M" And ComboBox2.Text = "DM" Then
            hasil.Text = TextBox1.Text * 10 & " " & ComboBox2.Text

        ElseIf ComboBox1.Text = "M" And ComboBox2.Text = "CM" Then
            hasil.Text = TextBox1.Text * 100 & " " & ComboBox2.Text

        ElseIf ComboBox1.Text = "M" And ComboBox2.Text = "MM" Then
            hasil.Text = TextBox1.Text * 1000 & " " & ComboBox2.Text

        ElseIf ComboBox1.Text = "DM" And ComboBox2.Text = "KM" Then
            hasil.Text = TextBox1.Text / 10000 & " " & ComboBox2.Text

        ElseIf ComboBox1.Text = "DM" And ComboBox2.Text = "HM" Then
            hasil.Text = TextBox1.Text / 1000 & " " & ComboBox2.Text

        ElseIf ComboBox1.Text = "DM" And ComboBox2.Text = "DAM" Then
            hasil.Text = TextBox1.Text / 100 & " " & ComboBox2.Text

        ElseIf ComboBox1.Text = "DM" And ComboBox2.Text = "M" Then
            hasil.Text = TextBox1.Text / 10 & " " & ComboBox2.Text

        ElseIf ComboBox1.Text = "DM" And ComboBox2.Text = "DM" Then
            hasil.Text = TextBox1.Text & " " & ComboBox2.Text

        ElseIf ComboBox1.Text = "DM" And ComboBox2.Text = "CM" Then
            hasil.Text = TextBox1.Text * 10 & " " & ComboBox2.Text

        ElseIf ComboBox1.Text = "DM" And ComboBox2.Text = "MM" Then
            hasil.Text = TextBox1.Text * 100 & " " & ComboBox2.Text

        ElseIf ComboBox1.Text = "CM" And ComboBox2.Text = "KM" Then
            hasil.Text = TextBox1.Text / 1000 & " " & ComboBox2.Text

        ElseIf ComboBox1.Text = "CM" And ComboBox2.Text = "HM" Then
            hasil.Text = TextBox1.Text / 100 & " " & ComboBox2.Text

        ElseIf ComboBox1.Text = "CM" And ComboBox2.Text = "DAM" Then
            hasil.Text = TextBox1.Text / 10 & " " & ComboBox2.Text

        ElseIf ComboBox1.Text = "CM" And ComboBox2.Text = "M" Then
            hasil.Text = TextBox1.Text & " " & ComboBox2.Text

        ElseIf ComboBox1.Text = "CM" And ComboBox2.Text = "DM" Then
            hasil.Text = TextBox1.Text * 10 & " " & ComboBox2.Text

        ElseIf ComboBox1.Text = "CM" And ComboBox2.Text = "CM" Then
            hasil.Text = TextBox1.Text * 100 & " " & ComboBox2.Text

        ElseIf ComboBox1.Text = "CM" And ComboBox2.Text = "MM" Then
            hasil.Text = TextBox1.Text * 1000 & " " & ComboBox2.Text

        ElseIf ComboBox1.Text = "MM" And ComboBox2.Text = "KM" Then
            hasil.Text = TextBox1.Text / 1000000 & " " & ComboBox2.Text

        ElseIf ComboBox1.Text = "MM" And ComboBox2.Text = "HM" Then
            hasil.Text = TextBox1.Text / 100000 & " " & ComboBox2.Text

        ElseIf ComboBox1.Text = "MM" And ComboBox2.Text = "DAM" Then
            hasil.Text = TextBox1.Text / 10000 & " " & ComboBox2.Text

        ElseIf ComboBox1.Text = "MM" And ComboBox2.Text = "M" Then
            hasil.Text = TextBox1.Text / 1000 & " " & ComboBox2.Text

        ElseIf ComboBox1.Text = "MM" And ComboBox2.Text = "DM" Then
            hasil.Text = TextBox1.Text / 100 & " " & ComboBox2.Text

        ElseIf ComboBox1.Text = "MM" And ComboBox2.Text = "CM" Then
            hasil.Text = TextBox1.Text / 10 & " " & ComboBox2.Text

        ElseIf ComboBox1.Text = "MM" And ComboBox2.Text = "MM" Then
            hasil.Text = TextBox1.Text & " " & ComboBox2.Text
        ElseIf MsgBox("MASUKAN SATUAN NILAI", MsgBoxStyle.Information, "INVALID") Then
        End If
    End Sub
    Private Sub Form2_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.ResizeRedraw = True

        Call combo()
    End Sub
    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        home.Show()
        Me.Hide()
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        TextBox1.Text = ""
        hasil.Text = ""
        Me.ComboBox2.SelectedItem = Nothing
        Me.ComboBox1.SelectedItem = Nothing
    End Sub

    Private Sub TextBox1_KeyDown(sender As Object, e As KeyEventArgs) Handles TextBox1.KeyDown
        If e.KeyCode = Keys.Enter Then
            Button1.Show()

        End If
    End Sub


    Private Sub TextBox1_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TextBox1.KeyPress
        If Not ((e.KeyChar >= "0" And e.KeyChar <= "9") Or e.KeyChar = vbBack) Then e.Handled = True
    End Sub


    Private Sub Label8_Click(sender As Object, e As EventArgs) Handles Label8.Click

    End Sub

    Private Sub satuanpanjang_Paint(sender As Object, e As PaintEventArgs) Handles Me.Paint
        Dim d As New System.Drawing.Drawing2D.LinearGradientBrush(Me.ClientRectangle, Color.FromArgb(60, 59, 63), Color.FromArgb(96, 92, 60), Drawing2D.LinearGradientMode.ForwardDiagonal)
        e.Graphics.FillRectangle(d, Me.ClientRectangle)

    End Sub

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles TextBox1.TextChanged

    End Sub
End Class