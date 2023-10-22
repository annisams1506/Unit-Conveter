Public Class SatuanLuasHektare
    Sub combo()
        With ComboBox1
            .Items.Add("KA")
            .Items.Add("HA")
            .Items.Add("DAA")
            .Items.Add("Are")
            .Items.Add("DA")
            .Items.Add("CA")
            .Items.Add("MA")
        End With
        With ComboBox2
            .Items.Add("KA")
            .Items.Add("HA")
            .Items.Add("DAA")
            .Items.Add("Are")
            .Items.Add("DA")
            .Items.Add("CA")
            .Items.Add("MA")
        End With
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If TextBox1.Text = "" Then
            MsgBox("MASUKKAN ANGKA", MsgBoxStyle.Information, "INVALID")
        End If
        If ComboBox1.Text = "KA" And ComboBox2.Text = "KA" Then
            hasil.Text = TextBox1.Text & " " & ComboBox2.Text

        ElseIf ComboBox1.Text = "KA" And ComboBox2.Text = "HA" Then
            hasil.Text = TextBox1.Text * 10 * 10 & " " & ComboBox2.Text

        ElseIf ComboBox1.Text = "KA" And ComboBox2.Text = "DAA" Then
            hasil.Text = TextBox1.Text * 100 * 100 & " " & ComboBox2.Text

        ElseIf ComboBox1.Text = "KA" And ComboBox2.Text = "Are" Then
            hasil.Text = TextBox1.Text * 1000 * 1000 & " " & ComboBox2.Text

        ElseIf ComboBox1.Text = "KA" And ComboBox2.Text = "DA" Then
            hasil.Text = TextBox1.Text * 10000 * 10000 & " " & ComboBox2.Text

        ElseIf ComboBox1.Text = "KA" And ComboBox2.Text = "CA" Then
            hasil.Text = TextBox1.Text * 100000 * 100000 & " " & ComboBox2.Text

        ElseIf ComboBox1.Text = "KA" And ComboBox2.Text = "MA" Then
            hasil.Text = TextBox1.Text * 1000000 * 1000000 & " " & ComboBox2.Text

        ElseIf ComboBox1.Text = "HA" And ComboBox2.Text = "KA" Then
            hasil.Text = TextBox1.Text / 10 / 10 & " " & ComboBox2.Text

        ElseIf ComboBox1.Text = "HA" And ComboBox2.Text = "HA" Then
            hasil.Text = TextBox1.Text & " " & ComboBox2.Text

        ElseIf ComboBox1.Text = "HA" And ComboBox2.Text = "DAA" Then
            hasil.Text = TextBox1.Text * 10 * 10 & " " & ComboBox2.Text

        ElseIf ComboBox1.Text = "HA" And ComboBox2.Text = "Are" Then
            hasil.Text = TextBox1.Text * 100 * 100 & " " & ComboBox2.Text
        ElseIf ComboBox1.Text = "HA" And ComboBox2.Text = "DA" Then
            hasil.Text = TextBox1.Text * 1000 * 1000 & " " & ComboBox2.Text

        ElseIf ComboBox1.Text = "HA" And ComboBox2.Text = "CA" Then
            hasil.Text = TextBox1.Text * 10000 * 10000 & " " & ComboBox2.Text

        ElseIf ComboBox1.Text = "HA" And ComboBox2.Text = "MA" Then
            hasil.Text = TextBox1.Text * 100000 * 100000 & " " & ComboBox2.Text

        ElseIf ComboBox1.Text = "DAA" And ComboBox2.Text = "KA" Then
            hasil.Text = TextBox1.Text / 100 / 100 & " " & ComboBox2.Text

        ElseIf ComboBox1.Text = "DAA" And ComboBox2.Text = "HA" Then
            hasil.Text = TextBox1.Text / 10 / 10 & " " & ComboBox2.Text

        ElseIf ComboBox1.Text = "DAA" And ComboBox2.Text = "DAA" Then
            hasil.Text = TextBox1.Text & " " & ComboBox2.Text

        ElseIf ComboBox1.Text = "DAA" And ComboBox2.Text = "Are" Then
            hasil.Text = TextBox1.Text * 10 * 10 & " " & ComboBox2.Text

        ElseIf ComboBox1.Text = "DAA" And ComboBox2.Text = "DA" Then
            hasil.Text = TextBox1.Text * 100 * 100 & " " & ComboBox2.Text

        ElseIf ComboBox1.Text = "DAA" And ComboBox2.Text = "CA" Then
            hasil.Text = TextBox1.Text * 1000 * 1000 & " " & ComboBox2.Text

        ElseIf ComboBox1.Text = "DAA" And ComboBox2.Text = "MA" Then
            hasil.Text = TextBox1.Text * 10000 * 10000 & " " & ComboBox2.Text

        ElseIf ComboBox1.Text = "Are" And ComboBox2.Text = "KA" Then
            hasil.Text = TextBox1.Text / 1000 / 1000 & " " & ComboBox2.Text

        ElseIf ComboBox1.Text = "Are" And ComboBox2.Text = "HA" Then
            hasil.Text = TextBox1.Text / 100 / 100 & " " & ComboBox2.Text

        ElseIf ComboBox1.Text = "Are" And ComboBox2.Text = "DAA" Then
            hasil.Text = TextBox1.Text / 10 / 10 & " " & ComboBox2.Text

        ElseIf ComboBox1.Text = "Are" And ComboBox2.Text = "Are" Then
            hasil.Text = TextBox1.Text & " " & ComboBox2.Text

        ElseIf ComboBox1.Text = "Are" And ComboBox2.Text = "DA" Then
            hasil.Text = TextBox1.Text * 10 * 10 & " " & ComboBox2.Text

        ElseIf ComboBox1.Text = "Are" And ComboBox2.Text = "CA" Then
            hasil.Text = TextBox1.Text * 100 * 100 & " " & ComboBox2.Text

        ElseIf ComboBox1.Text = "Are" And ComboBox2.Text = "MA" Then
            hasil.Text = TextBox1.Text * 1000 * 1000 & " " & ComboBox2.Text

        ElseIf ComboBox1.Text = "DA" And ComboBox2.Text = "KA" Then
            hasil.Text = TextBox1.Text / 10000 / 10000 & " " & ComboBox2.Text

        ElseIf ComboBox1.Text = "DA" And ComboBox2.Text = "HA" Then
            hasil.Text = TextBox1.Text / 1000 / 1000 & " " & ComboBox2.Text

        ElseIf ComboBox1.Text = "DA" And ComboBox2.Text = "DAA" Then
            hasil.Text = TextBox1.Text / 100 / 100 & " " & ComboBox2.Text

        ElseIf ComboBox1.Text = "DA" And ComboBox2.Text = "Are" Then
            hasil.Text = TextBox1.Text / 10 / 10 & " " & ComboBox2.Text

        ElseIf ComboBox1.Text = "DA" And ComboBox2.Text = "DA" Then
            hasil.Text = TextBox1.Text & " " & ComboBox2.Text

        ElseIf ComboBox1.Text = "DA" And ComboBox2.Text = "CA" Then
            hasil.Text = TextBox1.Text * 10 * 10 & " " & ComboBox2.Text

        ElseIf ComboBox1.Text = "DA" And ComboBox2.Text = "MA" Then
            hasil.Text = TextBox1.Text * 100 * 100 & " " & ComboBox2.Text

        ElseIf ComboBox1.Text = "CA" And ComboBox2.Text = "KA" Then
            hasil.Text = TextBox1.Text / 1000 / 1000 & " " & ComboBox2.Text

        ElseIf ComboBox1.Text = "CA" And ComboBox2.Text = "HA" Then
            hasil.Text = TextBox1.Text / 100 / 100 & " " & ComboBox2.Text

        ElseIf ComboBox1.Text = "CA" And ComboBox2.Text = "DAA" Then
            hasil.Text = TextBox1.Text / 10 / 10 & " " & ComboBox2.Text

        ElseIf ComboBox1.Text = "CA" And ComboBox2.Text = "Are" Then
            hasil.Text = TextBox1.Text & " " & ComboBox2.Text

        ElseIf ComboBox1.Text = "CA" And ComboBox2.Text = "DA" Then
            hasil.Text = TextBox1.Text * 10 * 10 & " " & ComboBox2.Text

        ElseIf ComboBox1.Text = "CA" And ComboBox2.Text = "CA" Then
            hasil.Text = TextBox1.Text * 100 * 100 & " " & ComboBox2.Text

        ElseIf ComboBox1.Text = "CA" And ComboBox2.Text = "MA" Then
            hasil.Text = TextBox1.Text * 1000 * 1000 & " " & ComboBox2.Text

        ElseIf ComboBox1.Text = "MA" And ComboBox2.Text = "KA" Then
            hasil.Text = TextBox1.Text / 1000000 / 1000000 & " " & ComboBox2.Text

        ElseIf ComboBox1.Text = "MA" And ComboBox2.Text = "HA" Then
            hasil.Text = TextBox1.Text / 100000 / 100000 & " " & ComboBox2.Text

        ElseIf ComboBox1.Text = "MA" And ComboBox2.Text = "DAA" Then
            hasil.Text = TextBox1.Text / 10000 / 10000 & " " & ComboBox2.Text

        ElseIf ComboBox1.Text = "MA" And ComboBox2.Text = "Are" Then
            hasil.Text = TextBox1.Text / 1000 / 1000 & " " & ComboBox2.Text

        ElseIf ComboBox1.Text = "MA" And ComboBox2.Text = "DA" Then
            hasil.Text = TextBox1.Text / 100 / 100 & " " & ComboBox2.Text

        ElseIf ComboBox1.Text = "MA" And ComboBox2.Text = "CA" Then
            hasil.Text = TextBox1.Text / 10 / 10 & " " & ComboBox2.Text

        ElseIf ComboBox1.Text = "MA" And ComboBox2.Text = "MA" Then
            hasil.Text = TextBox1.Text & " " & ComboBox2.Text
        ElseIf MsgBox("MASUKAN SATUAN NILAI DENGAN BENAR", MsgBoxStyle.Information, "INVALID") Then
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
        hasil.text = ""
        Me.ComboBox2.SelectedItem = Nothing
        Me.ComboBox1.SelectedItem = Nothing
    End Sub

    Private Sub TextBox1_KeyDown(sender As Object, e As KeyEventArgs) Handles TextBox1.KeyDown
        If e.KeyCode = Keys.Enter Then
            Button1.Focus()


        End If
    End Sub
    Private Sub TextBox1_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TextBox1.KeyPress
        If Not ((e.KeyChar >= "0" And e.KeyChar <= "9") Or e.KeyChar = vbBack) Then e.Handled = True
    End Sub

    Private Sub SatuanLuasHektare_Paint(sender As Object, e As PaintEventArgs) Handles Me.Paint
        Dim d As New System.Drawing.Drawing2D.LinearGradientBrush(Me.ClientRectangle, Color.FromArgb(221, 214, 243), Color.FromArgb(250, 172, 168), Drawing2D.LinearGradientMode.ForwardDiagonal)
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