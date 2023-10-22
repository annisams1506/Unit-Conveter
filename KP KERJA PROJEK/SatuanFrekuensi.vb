Public Class SatuanFrekuensi
    Sub combo()
        With ComboBox1
            .Items.Add("Hertz")
            .Items.Add("Kilohertz")
            .Items.Add("Megahertz")
            .Items.Add("Gigahertz")
        End With
        With ComboBox2()
            .Items.Add("Hertz")
            .Items.Add("Kilohertz")
            .Items.Add("Megahertz")
            .Items.Add("Gigahertz")
        End With
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If TextBox1.Text = "" Then
            MsgBox("MASUKKAN ANGKA", MsgBoxStyle.Information, "INVALID")
        End If
        If ComboBox1.Text = "Hertz" And ComboBox2.Text = "Hertz" Then
            hasil.Text = TextBox1.Text & " " & ComboBox2.Text

        ElseIf ComboBox1.Text = "Hertz" And ComboBox2.Text = "Kilohertz" Then
            hasil.Text = Val(TextBox1.Text) / 1000 & " " & ComboBox2.Text

        ElseIf ComboBox1.Text = "Hertz" And ComboBox2.Text = "Megahertz" Then
            hasil.Text = Val(TextBox1.Text) / 1000000 & " " & ComboBox2.Text

        ElseIf ComboBox1.Text = "Hertz" And ComboBox2.Text = "Gigahertz" Then
            hasil.Text = Val(TextBox1.Text) / 1000000000 & " " & ComboBox2.Text

        ElseIf ComboBox1.Text = "Kilohertz" And ComboBox2.Text = "Kilohertz" Then
            hasil.Text = TextBox1.Text & " " & ComboBox2.Text

        ElseIf ComboBox1.Text = "Kilohertz" And ComboBox2.Text = "Hertz" Then
            hasil.Text = Val(TextBox1.Text) * 1000 & " " & ComboBox2.Text

        ElseIf ComboBox1.Text = "Kilohertz" And ComboBox2.Text = "Megahertz" Then
            hasil.Text = Val(TextBox1.Text) / 1000 & " " & ComboBox2.Text

        ElseIf ComboBox1.Text = "Kilohertz" And ComboBox2.Text = "Gigahertz" Then
            hasil.Text = Val(TextBox1.Text) / 1000000 & " " & ComboBox2.Text

        ElseIf ComboBox1.Text = "Megahertz" And ComboBox2.Text = "Megahertz" Then
            hasil.Text = TextBox1.Text & " " & ComboBox2.Text

        ElseIf ComboBox1.Text = "Megahertz" And ComboBox2.Text = "Hertz" Then
            hasil.Text = Val(TextBox1.Text) * 1000000 & " " & ComboBox2.Text

        ElseIf ComboBox1.Text = "Megahertz" And ComboBox2.Text = "Kilohertz" Then
            hasil.Text = Val(TextBox1.Text) * 1000 & " " & ComboBox2.Text

        ElseIf ComboBox1.Text = "Megahertz" And ComboBox2.Text = "Gigahertz" Then
            hasil.Text = Val(TextBox1.Text) / 1000 & " " & ComboBox2.Text

        ElseIf ComboBox1.Text = "Gigahertz" And ComboBox2.Text = "Gigahertz" Then
            hasil.Text = TextBox1.Text & " " & ComboBox2.Text

        ElseIf ComboBox1.Text = "Gigahertz" And ComboBox2.Text = "Hertz" Then
            hasil.Text = Val(TextBox1.Text) * 10 ^ 9 & " " & ComboBox2.Text

        ElseIf ComboBox1.Text = "Gigahertz" And ComboBox2.Text = "Megahertz" Then
            hasil.Text = Val(TextBox1.Text) * 1000 & " " & ComboBox2.Text

        ElseIf ComboBox1.Text = "Gigahertz" And ComboBox2.Text = "Kilohertz" Then
            hasil.Text = Val(TextBox1.Text) * 1000000 & " " & ComboBox2.Text
        ElseIf MsgBox("MASUKAN SATUAN NILAI", MsgBoxStyle.Information, "INVALID") Then
        End If
    End Sub

    Private Sub Form11_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Call combo()
        Me.ResizeRedraw = True
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        home.Show()
        Me.Close()

    End Sub

  
    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        TextBox1.Text = ""
        hasil.text = ""
        Me.ComboBox2.SelectedItem = Nothing
        Me.ComboBox1.SelectedItem = Nothing
    End Sub

    Private Sub TextBox1_KeyDown(sender As Object, e As KeyEventArgs) Handles TextBox1.KeyDown
        If e.KeyCode = Keys.Enter Then
            ComboBox1.Focus()

        End If
    End Sub
    Private Sub TextBox1_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TextBox1.KeyPress
        If Not ((e.KeyChar >= "0" And e.KeyChar <= "9") Or e.KeyChar = vbBack) Then e.Handled = True
    End Sub

    Private Sub SatuanFrekuensi_Paint(sender As Object, e As PaintEventArgs) Handles Me.Paint
        Dim d As New System.Drawing.Drawing2D.LinearGradientBrush(Me.ClientRectangle, Color.FromArgb(83, 105, 118), Color.FromArgb(41, 46, 73), Drawing2D.LinearGradientMode.ForwardDiagonal)
        e.Graphics.FillRectangle(d, Me.ClientRectangle)

    End Sub

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles TextBox1.TextChanged

    End Sub
  

    Private Sub ComboBox1_KeyDown(sender As Object, e As KeyEventArgs) Handles ComboBox1.KeyDown
        If e.KeyCode = Keys.Enter Then
            ComboBox2.Focus()
        End If
    End Sub

    Private Sub ComboBox2_KeyDown(sender As Object, e As KeyEventArgs) Handles ComboBox2.KeyDown
        If e.KeyCode = Keys.Enter Then
            Button1.Focus()

        End If
    End Sub
End Class