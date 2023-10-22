Public Class SatuanDaya
    Dim a As Integer = -30

    Sub combo()
        With ComboBox1

            .Items.Add("Miliwatt")
            .Items.Add("Watt")
            .Items.Add("dBm")
            .Items.Add("dBW")
        End With
        With ComboBox2

            .Items.Add("Miliwatt")
            .Items.Add("Watt")
            .Items.Add("dBm")
            .Items.Add("dBW")
        End With
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If TextBox1.Text = "" Then
            MsgBox("MASUKKAN NILAI", MsgBoxStyle.Information, "INVALID")
        End If
        If ComboBox1.Text = "Miliwatt" And ComboBox2.Text = "Miliwatt" Then
            hasil.Text = TextBox1.Text & " " & ComboBox2.Text

        ElseIf ComboBox1.Text = "Miliwatt" And ComboBox2.Text = "Watt" Then
            hasil.Text = Val(TextBox1.Text) / 1000 & " " & ComboBox2.Text

        ElseIf ComboBox1.Text = "Miliwatt" And ComboBox2.Text = "dBm" Then
            hasil.Text = 10 * Math.Log10(Val(TextBox1.Text)) / 1 & " " & ComboBox2.Text

        ElseIf ComboBox1.Text = "Miliwatt" And ComboBox2.Text = "dBW" Then
            hasil.Text = Val(TextBox1.Text) * Int(a) & " " & ComboBox2.Text

        ElseIf ComboBox1.Text = "Watt" And ComboBox2.Text = "Watt" Then
            hasil.Text = TextBox1.Text & " " & ComboBox2.Text

        ElseIf ComboBox1.Text = "Watt" And ComboBox2.Text = "Miliwatt" Then
            hasil.Text = Val(TextBox1.Text) * 1000 & " " & ComboBox2.Text

        ElseIf ComboBox1.Text = "Watt" And ComboBox2.Text = "dBW" Then
            hasil.Text = 10 * Math.Log(Val(TextBox1.Text)) / 1 & " " & ComboBox2.Text

        ElseIf ComboBox1.Text = "Watt" And ComboBox2.Text = "dBm" Then
            hasil.Text = 10 * Math.Log10(Val(TextBox1.Text)) + 30 & " " & ComboBox2.Text

        ElseIf ComboBox1.Text = "dBm" And ComboBox2.Text = "dBm" Then
            hasil.Text = TextBox1.Text & " " & ComboBox2.Text

        ElseIf ComboBox1.Text = "dBm" And ComboBox2.Text = "Miliwatt" Then
            hasil.Text = 10 ^ (Val(TextBox1.Text)) / 10 & " " & ComboBox2.Text

        ElseIf ComboBox1.Text = "dBm" And ComboBox2.Text = "Watt" Then
            hasil.Text = 10 * Val(TextBox1.Text) / 10 & " " & ComboBox2.Text

        ElseIf ComboBox1.Text = "dBm" And ComboBox2.Text = "dBW" Then
            hasil.Text = Val(TextBox1.Text) - 30 & " " & ComboBox2.Text

        ElseIf ComboBox1.Text = "dBW" And ComboBox2.Text = "dBW" Then
            hasil.Text = TextBox1.Text & " " & ComboBox2.Text

        ElseIf ComboBox1.Text = "dBW" And ComboBox2.Text = "Miliwatt" Then
            hasil.Text = Val(TextBox1.Text) / Int(a) & " " & ComboBox2.Text

        ElseIf ComboBox1.Text = "dBW" And ComboBox2.Text = "Watt" Then
            hasil.Text = 10 * Val(TextBox1.Text) / 10 & " " & ComboBox2.Text

        ElseIf ComboBox1.Text = "dBW" And ComboBox2.Text = "dBm" Then
            hasil.Text = Val(TextBox1.Text) - 30 & " " & ComboBox2.Text

        ElseIf MsgBox("MASUKAN SATUAN NILAI", MsgBoxStyle.Information, "INVALID") Then
        End If
    End Sub

    Private Sub Form9_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.ResizeRedraw = True
        Call combo()
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        TextBox1.Text = ""
        hasil.text = ""
        Me.ComboBox2.SelectedItem = Nothing
        Me.ComboBox1.SelectedItem = Nothing
    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        home.Show()
        Me.Hide()
    End Sub

    Private Sub TextBox1_KeyDown(sender As Object, e As KeyEventArgs) Handles TextBox1.KeyDown
        If e.KeyCode = Keys.Enter Then
            ComboBox1.Focus()

        End If
    End Sub

    Private Sub TextBox1_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TextBox1.KeyPress
        If Not ((e.KeyChar >= "0" And e.KeyChar <= "9") Or e.KeyChar = vbBack) Then e.Handled = True
    End Sub


    Private Sub Label9_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub SatuanDaya_Paint(sender As Object, e As PaintEventArgs) Handles Me.Paint
        Dim d As New System.Drawing.Drawing2D.LinearGradientBrush(Me.ClientRectangle, Color.FromArgb(252, 234, 187), Color.FromArgb(248, 181, 0), Drawing2D.LinearGradientMode.ForwardDiagonal)
        e.Graphics.FillRectangle(d, Me.ClientRectangle)

    End Sub

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles TextBox1.TextChanged

    End Sub

    Private Sub ComboBox1_KeyDown(sender As Object, e As KeyEventArgs) Handles ComboBox1.KeyDown
        If e.KeyCode = Keys.Enter Then
            ComboBox2.Focus()

        End If
    End Sub

    Private Sub ComboBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBox1.SelectedIndexChanged

    End Sub

    Private Sub ComboBox2_KeyDown(sender As Object, e As KeyEventArgs) Handles ComboBox2.KeyDown
        If e.KeyCode = Keys.Enter Then
            Button1.Focus()

        End If
    End Sub

    Private Sub ComboBox2_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBox2.SelectedIndexChanged

    End Sub
End Class
