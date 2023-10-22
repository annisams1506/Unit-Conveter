Public Class VolumeMetrKubik
    Sub combo()
        With ComboBox1
            .Items.Add("KM³")
            .Items.Add("HM³")
            .Items.Add("DAM³")
            .Items.Add("M³")
            .Items.Add("DM³")
            .Items.Add("CM³")
            .Items.Add("MM³")
        End With
        With ComboBox2
            .Items.Add("KM³")
            .Items.Add("HM³")
            .Items.Add("DAM³")
            .Items.Add("M³")
            .Items.Add("DM³")
            .Items.Add("CM³")
            .Items.Add("MM³")
        End With
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If TextBox1.Text = "" Then
            MsgBox("MASUKKAN ANGKA", MsgBoxStyle.Information, "INVALID")
        End If
        If ComboBox1.Text = "KM³" And ComboBox2.Text = "KM³" Then
            hasil.Text = TextBox1.Text & " " & ComboBox2.Text

        ElseIf ComboBox1.Text = "KM³" And ComboBox2.Text = "HM³" Then
            hasil.Text = TextBox1.Text * 10 * 10 * 10 & " " & ComboBox2.Text

        ElseIf ComboBox1.Text = "KM³" And ComboBox2.Text = "DAM³" Then
            hasil.Text = TextBox1.Text * 100 * 100 * 100 & " " & ComboBox2.Text

        ElseIf ComboBox1.Text = "KM³" And ComboBox2.Text = "M³" Then
            hasil.Text = TextBox1.Text * 1000 * 1000 * 1000 & " " & ComboBox2.Text

        ElseIf ComboBox1.Text = "KM³" And ComboBox2.Text = "DM³" Then
            hasil.Text = TextBox1.Text * 10000 * 10000 * 10000 & " " & ComboBox2.Text

        ElseIf ComboBox1.Text = "KM³" And ComboBox2.Text = "CM³" Then
            hasil.Text = TextBox1.Text * 100000 * 100000 * 100000 & " " & ComboBox2.Text

        ElseIf ComboBox1.Text = "KM³" And ComboBox2.Text = "MM³" Then
            hasil.Text = TextBox1.Text * 1000000 * 1000000 * 1000000 & " " & ComboBox2.Text

        ElseIf ComboBox1.Text = "HM³" And ComboBox2.Text = "KM³" Then
            hasil.Text = TextBox1.Text / 10 / 10 / 10 & " " & ComboBox2.Text

        ElseIf ComboBox1.Text = "HM³" And ComboBox2.Text = "HM³" Then
            hasil.Text = TextBox1.Text & " " & ComboBox2.Text

        ElseIf ComboBox1.Text = "HM³" And ComboBox2.Text = "DAM³" Then
            hasil.Text = TextBox1.Text * 10 * 10 * 10 & " " & ComboBox2.Text

        ElseIf ComboBox1.Text = "HM³" And ComboBox2.Text = "M³" Then
            hasil.Text = TextBox1.Text * 100 * 100 * 100 & " " & ComboBox2.Text

        ElseIf ComboBox1.Text = "HM³" And ComboBox2.Text = "DM³" Then
            hasil.Text = TextBox1.Text * 1000 * 1000 * 1000 & " " & ComboBox2.Text

        ElseIf ComboBox1.Text = "HM³" And ComboBox2.Text = "CM³" Then
            hasil.Text = TextBox1.Text * 10000 * 10000 * 1000 & " " & ComboBox2.Text

        ElseIf ComboBox1.Text = "HM³" And ComboBox2.Text = "MM³" Then
            hasil.Text = TextBox1.Text * 100000 * 100000 * 100000 & " " & ComboBox2.Text

        ElseIf ComboBox1.Text = "DAM³" And ComboBox2.Text = "KM³" Then
            hasil.Text = TextBox1.Text / 100 / 100 / 100 & " " & ComboBox2.Text

        ElseIf ComboBox1.Text = "DAM³" And ComboBox2.Text = "HM³" Then
            hasil.Text = TextBox1.Text / 10 / 10 / 10 & " " & ComboBox2.Text

        ElseIf ComboBox1.Text = "DAM³" And ComboBox2.Text = "DAM³" Then
            hasil.Text = TextBox1.Text & " " & ComboBox2.Text

        ElseIf ComboBox1.Text = "DAM³" And ComboBox2.Text = "M³" Then
            hasil.Text = TextBox1.Text * 10 * 10 * 10 & " " & ComboBox2.Text

        ElseIf ComboBox1.Text = "DAM³" And ComboBox2.Text = "DM³" Then
            hasil.Text = TextBox1.Text * 100 * 100 * 100 & " " & ComboBox2.Text

        ElseIf ComboBox1.Text = "DAM³" And ComboBox2.Text = "CM³" Then
            hasil.Text = TextBox1.Text * 1000 * 1000 * 1000 & " " & ComboBox2.Text

        ElseIf ComboBox1.Text = "DAM³" And ComboBox2.Text = "MM³" Then
            hasil.Text = TextBox1.Text * 10000 * 10000 * 10000 & " " & ComboBox2.Text

        ElseIf ComboBox1.Text = "M³" And ComboBox2.Text = "KM³" Then
            hasil.Text = TextBox1.Text / 1000 / 1000 / 1000 & " " & ComboBox2.Text

        ElseIf ComboBox1.Text = "M³" And ComboBox2.Text = "HM³" Then
            hasil.Text = TextBox1.Text / 100 / 100 / 100 & " " & ComboBox2.Text

        ElseIf ComboBox1.Text = "M³" And ComboBox2.Text = "DAM³" Then
            hasil.Text = TextBox1.Text / 10 / 10 / 10 & " " & ComboBox2.Text

        ElseIf ComboBox1.Text = "M³" And ComboBox2.Text = "M³" Then
            hasil.Text = TextBox1.Text & " " & ComboBox2.Text

        ElseIf ComboBox1.Text = "M³" And ComboBox2.Text = "DM³" Then
            hasil.Text = TextBox1.Text * 10 * 10 * 10 & " " & ComboBox2.Text

        ElseIf ComboBox1.Text = "M³" And ComboBox2.Text = "CM³" Then
            hasil.Text = TextBox1.Text * 100 * 100 * 100 & " " & ComboBox2.Text

        ElseIf ComboBox1.Text = "M³" And ComboBox2.Text = "MM³" Then
            hasil.Text = TextBox1.Text * 1000 * 1000 & " " & ComboBox2.Text

        ElseIf ComboBox1.Text = "DM³" And ComboBox2.Text = "KM³" Then
            hasil.Text = TextBox1.Text / 10000 / 10000 & " " & ComboBox2.Text

        ElseIf ComboBox1.Text = "DM³" And ComboBox2.Text = "HM³" Then
            hasil.Text = TextBox1.Text / 1000 / 1000 & " " & ComboBox2.Text

        ElseIf ComboBox1.Text = "DM³" And ComboBox2.Text = "DAM³" Then
            hasil.Text = TextBox1.Text / 100 / 100 / 100 & " " & ComboBox2.Text

        ElseIf ComboBox1.Text = "DM³" And ComboBox2.Text = "M³" Then
            hasil.Text = TextBox1.Text / 10 / 10 / 10 & " " & ComboBox2.Text

        ElseIf ComboBox1.Text = "DM³" And ComboBox2.Text = "DM³" Then
            hasil.Text = TextBox1.Text & " " & ComboBox2.Text

        ElseIf ComboBox1.Text = "DM³" And ComboBox2.Text = "CM³" Then
            hasil.Text = TextBox1.Text * 10 * 10 * 10 & " " & ComboBox2.Text

        ElseIf ComboBox1.Text = "DM³" And ComboBox2.Text = "MM³" Then
            hasil.Text = TextBox1.Text * 100 * 100 * 100 & " " & ComboBox2.Text

        ElseIf ComboBox1.Text = "CM³" And ComboBox2.Text = "KM³" Then
            hasil.Text = TextBox1.Text / 1000 / 1000 / 1000 & " " & ComboBox2.Text

        ElseIf ComboBox1.Text = "CM³" And ComboBox2.Text = "HM³" Then
            hasil.Text = TextBox1.Text / 100 / 100 / 100 & " " & ComboBox2.Text

        ElseIf ComboBox1.Text = "CM³" And ComboBox2.Text = "DAM³" Then
            hasil.Text = TextBox1.Text / 10 / 10 / 10 & " " & ComboBox2.Text

        ElseIf ComboBox1.Text = "CM³" And ComboBox2.Text = "M³" Then
            hasil.Text = TextBox1.Text & " " & ComboBox2.Text

        ElseIf ComboBox1.Text = "CM³" And ComboBox2.Text = "DM³" Then
            hasil.Text = TextBox1.Text * 10 * 10 * 10 & " " & ComboBox2.Text

        ElseIf ComboBox1.Text = "CM³" And ComboBox2.Text = "CM³" Then
            hasil.Text = TextBox1.Text * 100 * 100 * 100 & " " & ComboBox2.Text

        ElseIf ComboBox1.Text = "CM³" And ComboBox2.Text = "MM³" Then
            hasil.Text = TextBox1.Text * 1000 * 1000 * 1000 & " " & ComboBox2.Text

        ElseIf ComboBox1.Text = "MM³" And ComboBox2.Text = "KM³" Then
            hasil.Text = TextBox1.Text / 1000000 / 1000000 / 1000000 & " " & ComboBox2.Text

        ElseIf ComboBox1.Text = "MM³" And ComboBox2.Text = "HM³" Then
            hasil.Text = TextBox1.Text / 100000 / 100000 / 100000 & " " & ComboBox2.Text

        ElseIf ComboBox1.Text = "MM³" And ComboBox2.Text = "DAM³" Then
            hasil.Text = TextBox1.Text / 10000 / 10000 / 10000 & " " & ComboBox2.Text

        ElseIf ComboBox1.Text = "MM³" And ComboBox2.Text = "M³" Then
            hasil.Text = TextBox1.Text / 1000 / 1000 / 1000 & " " & ComboBox2.Text

        ElseIf ComboBox1.Text = "MM³" And ComboBox2.Text = "DM³" Then
            hasil.Text = TextBox1.Text / 100 / 100 / 100 & " " & ComboBox2.Text

        ElseIf ComboBox1.Text = "MM³" And ComboBox2.Text = "CM³" Then
            hasil.Text = TextBox1.Text / 10 / 10 / 10 & " " & ComboBox2.Text

        ElseIf ComboBox1.Text = "MM³" And ComboBox2.Text = "MM³" Then
            hasil.Text = TextBox1.Text & " " & ComboBox2.Text

        ElseIf MsgBox("MASUKAN SATUAN NILAI", MsgBoxStyle.Information, "INVALID") Then
        End If
    End Sub

    Private Sub Form6_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.ResizeRedraw = True
        Call combo()
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        TextBox1.Text = ""
        hasil.Text = ""
        Me.ComboBox2.SelectedItem = Nothing
        Me.ComboBox1.SelectedItem = Nothing
    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        home.Show()
        Me.Hide()
    End Sub

    Private Sub TextBox1_KeyDown(sender As Object, e As KeyEventArgs) Handles TextBox1.KeyDown
        If e.KeyCode = Keys.Enter Then
            Button1.Focus()

        End If
    End Sub
    Private Sub TextBox1_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TextBox1.KeyPress
        If Not ((e.KeyChar >= "0" And e.KeyChar <= "9") Or e.KeyChar = vbBack) Then e.Handled = True
    End Sub

    Private Sub Label10_Click(sender As Object, e As EventArgs) Handles Label10.Click

    End Sub


    Private Sub VolumeMetrKubik_Paint(sender As Object, e As PaintEventArgs) Handles Me.Paint
        Dim d As New System.Drawing.Drawing2D.LinearGradientBrush(Me.ClientRectangle, Color.FromArgb(0, 191, 143), Color.FromArgb(0, 21, 16), Drawing2D.LinearGradientMode.Vertical)
        e.Graphics.FillRectangle(d, Me.ClientRectangle)

    End Sub
   
End Class