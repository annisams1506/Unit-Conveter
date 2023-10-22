Public Class LuasMeterPersegi
    Sub combo()
        With ComboBox1
            .Items.Add("KM²")
            .Items.Add("HM²")
            .Items.Add("DAM²")
            .Items.Add("M²")
            .Items.Add("DM²")
            .Items.Add("CM²")
            .Items.Add("MM²")
        End With
        With ComboBox2
            .Items.Add("KM²")
            .Items.Add("HM²")
            .Items.Add("DAM²")
            .Items.Add("M²")
            .Items.Add("DM²")
            .Items.Add("CM²")
            .Items.Add("MM²")
        End With
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If TextBox1.Text = "" Then
            MsgBox("MASUKKAN ANGKA ", MsgBoxStyle.Information, "INVALID")
        End If
        If ComboBox1.Text = "KM²" And ComboBox2.Text = "KM²" Then
            hasil.Text = TextBox1.Text & " " & ComboBox2.Text

        ElseIf ComboBox1.Text = "KM²" And ComboBox2.Text = "HM²" Then
            hasil.Text = TextBox1.Text * 10 * 10 & " " & ComboBox2.Text

        ElseIf ComboBox1.Text = "KM²" And ComboBox2.Text = "DAM²" Then
            hasil.Text = TextBox1.Text * 100 * 100 & " " & ComboBox2.Text

        ElseIf ComboBox1.Text = "KM²" And ComboBox2.Text = "M²" Then
            hasil.Text = TextBox1.Text * 1000 * 1000 & " " & ComboBox2.Text

        ElseIf ComboBox1.Text = "KM²" And ComboBox2.Text = "DM²" Then
            hasil.Text = TextBox1.Text * 10000 * 10000 & " " & ComboBox2.Text

        ElseIf ComboBox1.Text = "KM²" And ComboBox2.Text = "CM²" Then
            hasil.Text = TextBox1.Text * 100000 * 100000 & " " & ComboBox2.Text

        ElseIf ComboBox1.Text = "KM²" And ComboBox2.Text = "MM²" Then
            hasil.Text = TextBox1.Text * 1000000 * 1000000 & " " & ComboBox2.Text

        ElseIf ComboBox1.Text = "HM²" And ComboBox2.Text = "KM²" Then
            hasil.Text = TextBox1.Text / 10 / 10 & " " & ComboBox2.Text

        ElseIf ComboBox1.Text = "HM²" And ComboBox2.Text = "HM²" Then
            hasil.Text = TextBox1.Text & " " & ComboBox2.Text

        ElseIf ComboBox1.Text = "HM²" And ComboBox2.Text = "DAM²" Then
            hasil.Text = TextBox1.Text * 10 * 10 & " " & ComboBox2.Text

        ElseIf ComboBox1.Text = "HM²" And ComboBox2.Text = "M²" Then
            hasil.Text = TextBox1.Text * 100 * 100 & " " & ComboBox2.Text

        ElseIf ComboBox1.Text = "HM²" And ComboBox2.Text = "DM²" Then
            hasil.Text = TextBox1.Text * 1000 * 1000 & " " & ComboBox2.Text

        ElseIf ComboBox1.Text = "HM²" And ComboBox2.Text = "CM²" Then
            hasil.Text = TextBox1.Text * 10000 * 10000 & " " & ComboBox2.Text

        ElseIf ComboBox1.Text = "HM²" And ComboBox2.Text = "MM²" Then
            hasil.Text = TextBox1.Text * 100000 * 100000 & " " & ComboBox2.Text

        ElseIf ComboBox1.Text = "DAM²" And ComboBox2.Text = "KM²" Then
            hasil.Text = TextBox1.Text / 100 / 100 & " " & ComboBox2.Text

        ElseIf ComboBox1.Text = "DAM²" And ComboBox2.Text = "HM²" Then
            hasil.Text = TextBox1.Text / 10 / 10 & " " & ComboBox2.Text

        ElseIf ComboBox1.Text = "DAM²" And ComboBox2.Text = "DAM²" Then
            hasil.Text = TextBox1.Text & " " & ComboBox2.Text

        ElseIf ComboBox1.Text = "DAM²" And ComboBox2.Text = "M²" Then
            hasil.Text = TextBox1.Text * 10 * 10 & " " & ComboBox2.Text

        ElseIf ComboBox1.Text = "DAM²" And ComboBox2.Text = "DM²" Then
            hasil.Text = TextBox1.Text * 100 * 100 & " " & ComboBox2.Text

        ElseIf ComboBox1.Text = "DAM²" And ComboBox2.Text = "CM²" Then
            hasil.Text = TextBox1.Text * 1000 * 1000 & " " & ComboBox2.Text

        ElseIf ComboBox1.Text = "DAM²" And ComboBox2.Text = "MM²" Then
            hasil.Text = TextBox1.Text * 10000 * 10000 & " " & ComboBox2.Text

        ElseIf ComboBox1.Text = "M²" And ComboBox2.Text = "KM²" Then
            hasil.Text = TextBox1.Text / 1000 / 1000 & " " & ComboBox2.Text

        ElseIf ComboBox1.Text = "M²" And ComboBox2.Text = "HM²" Then
            hasil.Text = TextBox1.Text / 100 / 100 & " " & ComboBox2.Text

        ElseIf ComboBox1.Text = "M²" And ComboBox2.Text = "DAM²" Then
            hasil.Text = TextBox1.Text / 10 / 10 & " " & ComboBox2.Text

        ElseIf ComboBox1.Text = "M²" And ComboBox2.Text = "M²" Then
            hasil.Text = TextBox1.Text & " " & ComboBox2.Text

        ElseIf ComboBox1.Text = "M²" And ComboBox2.Text = "DM²" Then
            hasil.Text = TextBox1.Text * 10 * 10 & " " & ComboBox2.Text

        ElseIf ComboBox1.Text = "M²" And ComboBox2.Text = "CM²" Then
            hasil.Text = TextBox1.Text * 100 * 100 & " " & ComboBox2.Text

        ElseIf ComboBox1.Text = "M²" And ComboBox2.Text = "MM²" Then
            hasil.Text = TextBox1.Text * 1000 * 1000 & " " & ComboBox2.Text

        ElseIf ComboBox1.Text = "DM²" And ComboBox2.Text = "KM²" Then
            hasil.Text = TextBox1.Text / 10000 / 10000 & " " & ComboBox2.Text

        ElseIf ComboBox1.Text = "DM²" And ComboBox2.Text = "HM²" Then
            hasil.Text = TextBox1.Text / 1000 / 1000 & " " & ComboBox2.Text

        ElseIf ComboBox1.Text = "DM²" And ComboBox2.Text = "DAM²" Then
            hasil.Text = TextBox1.Text / 100 / 100 & " " & ComboBox2.Text

        ElseIf ComboBox1.Text = "DM²" And ComboBox2.Text = "M²" Then
            hasil.Text = TextBox1.Text / 10 / 10 & " " & ComboBox2.Text

        ElseIf ComboBox1.Text = "DM²" And ComboBox2.Text = "DM²" Then
            hasil.Text = TextBox1.Text & " " & ComboBox2.Text

        ElseIf ComboBox1.Text = "DM²" And ComboBox2.Text = "CM²" Then
            hasil.Text = TextBox1.Text * 10 * 10 & " " & ComboBox2.Text

        ElseIf ComboBox1.Text = "DM²" And ComboBox2.Text = "MM²" Then
            hasil.Text = TextBox1.Text * 100 * 100 & " " & ComboBox2.Text

        ElseIf ComboBox1.Text = "CM²" And ComboBox2.Text = "KM²" Then
            hasil.Text = TextBox1.Text / 1000 / 1000 & " " & ComboBox2.Text

        ElseIf ComboBox1.Text = "CM²" And ComboBox2.Text = "HM²" Then
            hasil.Text = TextBox1.Text / 100 / 100 & " " & ComboBox2.Text

        ElseIf ComboBox1.Text = "CM²" And ComboBox2.Text = "DAM²" Then
            hasil.Text = TextBox1.Text / 10 / 10 & " " & ComboBox2.Text

        ElseIf ComboBox1.Text = "CM²" And ComboBox2.Text = "M²" Then
            hasil.Text = TextBox1.Text & " " & ComboBox2.Text

        ElseIf ComboBox1.Text = "CM²" And ComboBox2.Text = "DM²" Then
            hasil.Text = TextBox1.Text * 10 * 10 & " " & ComboBox2.Text

        ElseIf ComboBox1.Text = "CM²" And ComboBox2.Text = "CM²" Then
            hasil.Text = TextBox1.Text * 100 * 100 & " " & ComboBox2.Text

        ElseIf ComboBox1.Text = "CM²" And ComboBox2.Text = "MM²" Then
            hasil.Text = TextBox1.Text * 1000 * 1000 & " " & ComboBox2.Text

        ElseIf ComboBox1.Text = "MM²" And ComboBox2.Text = "KM²" Then
            hasil.Text = TextBox1.Text / 1000000 / 1000000 & " " & ComboBox2.Text

        ElseIf ComboBox1.Text = "MM²" And ComboBox2.Text = "HM²" Then
            hasil.Text = TextBox1.Text / 100000 / 100000 & " " & ComboBox2.Text

        ElseIf ComboBox1.Text = "MM²" And ComboBox2.Text = "DAM²" Then
            hasil.Text = TextBox1.Text / 10000 / 10000 & " " & ComboBox2.Text

        ElseIf ComboBox1.Text = "MM²" And ComboBox2.Text = "M²" Then
            hasil.Text = TextBox1.Text / 1000 / 1000 & " " & ComboBox2.Text

        ElseIf ComboBox1.Text = "MM²" And ComboBox2.Text = "DM²" Then
            hasil.Text = TextBox1.Text / 100 / 100 & " " & ComboBox2.Text

        ElseIf ComboBox1.Text = "MM²" And ComboBox2.Text = "CM²" Then
            hasil.Text = TextBox1.Text / 10 / 10 & " " & ComboBox2.Text

        ElseIf ComboBox1.Text = "MM²" And ComboBox2.Text = "MM²" Then
            hasil.Text = TextBox1.Text & " " & ComboBox2.Text

        ElseIf MsgBox("MASUKAN SATUAN NILAI ", MsgBoxStyle.Information, "INVALID") Then
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
        Me.ComboBox1.SelectedItem = Nothing
        Me.ComboBox2.SelectedItem = Nothing
    End Sub

    Private Sub TextBox1_KeyDown(sender As Object, e As KeyEventArgs) Handles TextBox1.KeyDown
        If e.KeyCode = Keys.Enter Then
            ComboBox1.Show()
        End If
    End Sub

    Private Sub TextBox1_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TextBox1.KeyPress
        If Not ((e.KeyChar >= "0" And e.KeyChar <= "9") Or e.KeyChar = vbBack) Then e.Handled = True
    End Sub

    Private Sub LuasMeterPersegi_Paint(sender As Object, e As PaintEventArgs) Handles Me.Paint
        Dim d As New System.Drawing.Drawing2D.LinearGradientBrush(Me.ClientRectangle, Color.FromArgb(232, 203, 192), Color.FromArgb(99, 111, 164), Drawing2D.LinearGradientMode.ForwardDiagonal)
        e.Graphics.FillRectangle(d, Me.ClientRectangle)

    End Sub

    Private Sub ComboBox1_KeyDown(sender As Object, e As KeyEventArgs) Handles ComboBox1.KeyDown
        If e.KeyCode = Keys.Enter Then
            ComboBox2.Show()

        End If
    End Sub

    Private Sub ComboBox1_KeyPress(sender As Object, e As KeyPressEventArgs) Handles ComboBox1.KeyPress

    End Sub

    Private Sub ComboBox2_KeyDown(sender As Object, e As KeyEventArgs) Handles ComboBox2.KeyDown
        If e.KeyCode = Keys.Enter Then
            Button1.Show()
        End If
    End Sub
End Class