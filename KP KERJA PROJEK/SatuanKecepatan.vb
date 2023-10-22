Public Class SatuanKecepatan
    Dim b As Decimal = 2237 / 1000
    Dim c As Decimal = 1609 / 1000
    Dim f As Decimal = 3281 / 1000
    Dim g As Decimal = 1097 / 1000
    Dim h As Decimal = 1688 / 1000
    Dim i As Decimal = 36 / 10
    Dim k As Decimal = 1852 / 1000
    Dim j As Decimal = 1944 / 1000
    Dim d As Decimal = 1151 / 1000
    Dim a As Decimal = 1467 / 1000

    Sub combo()
        With ComboBox1
            .Items.Add("Mil/jam [mph]")
            .Items.Add("Kaki/detik [ft/s]")
            .Items.Add("Meter/detik [m/s]")
            .Items.Add("Kilometer/jam [km/h]")
            .Items.Add("Knot")
        End With
        With ComboBox2
            .Items.Add("Mil/jam [mph]")
            .Items.Add("Kaki/detik [ft/s]")
            .Items.Add("Meter/detik [m/s]")
            .Items.Add("Kilometer/jam [km/h]")
            .Items.Add("Knot")
        End With
    End Sub

    Private Sub Form16_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Call combo()
        Me.ResizeRedraw = True


    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If TextBox1.Text = "" Then
            MsgBox("MASUKKAN ANGKA", MsgBoxStyle.Information, "INVALID")
        End If
        If ComboBox1.Text = "Mil/jam [mph]" And ComboBox2.Text = "Mil/jam [mph]" Then
            hasil.Text = TextBox1.Text & " " & ComboBox2.Text

        ElseIf ComboBox1.Text = "Mil/jam [mph]" And ComboBox2.Text = "Kaki/detik [ft/s]" Then
            hasil.Text = TextBox1.Text * a & " " & ComboBox2.Text

        ElseIf ComboBox1.Text = "Mil/jam [mph]" And ComboBox2.Text = "Meter/detik [m/s]" Then
            hasil.Text = TextBox1.Text / b & " " & ComboBox2.Text

        ElseIf ComboBox1.Text = "Mil/jam [mph]" And ComboBox2.Text = "Kilometer/jam [km/h]" Then
            hasil.Text = TextBox1.Text * c & " " & ComboBox2.Text

        ElseIf ComboBox1.Text = "Mil/jam [mph]" And ComboBox2.Text = "Knot" Then
            hasil.Text = TextBox1.Text * d & " " & ComboBox2.Text

        ElseIf ComboBox1.Text = "Kaki/detik [ft/s]" And ComboBox2.Text = "Kaki/detik [ft/s]" Then
            hasil.Text = TextBox1.Text & " " & ComboBox2.Text

        ElseIf ComboBox1.Text = "Kaki/detik [ft/s]" And ComboBox2.Text = "Mil/jam [mph]" Then
            hasil.Text = TextBox1.Text / a & " " & ComboBox2.Text

        ElseIf ComboBox1.Text = "Kaki/detik [ft/s]" And ComboBox2.Text = "Meter/detik [m/s]" Then
            hasil.Text = Val(TextBox1.Text / f) & " " & ComboBox2.Text

        ElseIf ComboBox1.Text = "Kaki/detik [ft/s]" And ComboBox2.Text = "Kilometer/jam [km/h]" Then
            hasil.Text = TextBox1.Text * g & " " & ComboBox2.Text

        ElseIf ComboBox1.Text = "Kaki/detik [ft/s]" And ComboBox2.Text = "Knot" Then
            hasil.Text = TextBox1.Text / h & " " & ComboBox2.Text

        ElseIf ComboBox1.Text = "Meter/detik [m/s]" And ComboBox2.Text = "Meter/detik [m/s]" Then
            hasil.Text = TextBox1.Text & " " & ComboBox2.Text

        ElseIf ComboBox1.Text = "Meter/detik [m/s]" And ComboBox2.Text = "Mil/jam [mph]" Then
            hasil.Text = TextBox1.Text * b & " " & ComboBox2.Text

        ElseIf ComboBox1.Text = "Meter/detik [m/s]" And ComboBox2.Text = "Kaki/detik [ft/s]" Then
            hasil.Text = TextBox1.Text * f & " " & ComboBox2.Text

        ElseIf ComboBox1.Text = "Meter/detik [m/s]" And ComboBox2.Text = "Kilometer/jam [km/h]" Then
            hasil.Text = TextBox1.Text * i & " " & ComboBox2.Text

        ElseIf ComboBox1.Text = "Meter/detik [m/s]" And ComboBox2.Text = "Knot" Then
            hasil.Text = TextBox1.Text * j & " " & ComboBox2.Text

        ElseIf ComboBox1.Text = "Kilometer/jam [km/h]" And ComboBox2.Text = "Kilometer/jam [km/h]" Then
            hasil.Text = TextBox1.Text & " " & ComboBox2.Text

        ElseIf ComboBox1.Text = "Kilometer/jam [km/h]" And ComboBox2.Text = "Mil/jam [mph]" Then
            hasil.Text = TextBox1.Text / c & " " & ComboBox2.Text

        ElseIf ComboBox1.Text = "Kilometer/jam [km/h]" And ComboBox2.Text = "Meter/detik [m/s]" Then
            hasil.Text = TextBox1.Text / i & " " & ComboBox2.Text

        ElseIf ComboBox1.Text = "Kilometer/jam [km/h]" And ComboBox2.Text = "Kaki/detik [ft/s]" Then
            hasil.Text = TextBox1.Text / g & " " & ComboBox2.Text

        ElseIf ComboBox1.Text = "Kilometer/jam [km/h]" And ComboBox2.Text = "Knot" Then
            hasil.Text = TextBox1.Text / k & " " & ComboBox2.Text

        ElseIf ComboBox1.Text = "Knot" And ComboBox2.Text = "Knot" Then
            hasil.Text = TextBox1.Text & " " & ComboBox2.Text

        ElseIf ComboBox1.Text = "Knot" And ComboBox2.Text = "Mil/jam [mph]" Then
            hasil.Text = TextBox1.Text / d & " " & ComboBox2.Text

        ElseIf ComboBox1.Text = "Knot" And ComboBox2.Text = "Kaki/detik [ft/s]" Then
            hasil.Text = TextBox1.Text * h & " " & ComboBox2.Text

        ElseIf ComboBox1.Text = "Knot" And ComboBox2.Text = "Kilometer/jam [km/h]" Then
            hasil.Text = TextBox1.Text * k & " " & ComboBox2.Text

        ElseIf ComboBox1.Text = "Knot" And ComboBox2.Text = "Meter/detik [m/s]" Then
            hasil.Text = TextBox1.Text * j & " " & ComboBox2.Text

        ElseIf MsgBox("MASUKAN SATUAN NILAI", MsgBoxStyle.Information, "INVALID") Then
        End If
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        TextBox1.Text = ""
        hasil.text = ""
        Me.ComboBox2.SelectedItem = Nothing
        Me.ComboBox1.SelectedItem = Nothing
    End Sub
    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        home.Show()
        Me.Close()
    End Sub

    Private Sub TextBox1_KeyDown(sender As Object, e As KeyEventArgs) Handles TextBox1.KeyDown
        If e.KeyCode = Keys.Enter Then
            ComboBox1.Focus()
        End If
    End Sub

    Private Sub TextBox1_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TextBox1.KeyPress
        If Not ((e.KeyChar >= "0" And e.KeyChar <= "9") Or e.KeyChar = vbBack) Then e.Handled = True
    End Sub

    Private Sub SatuanKecepatan_Paint(sender As Object, e As PaintEventArgs) Handles Me.Paint
        'Warna Merah - Biru, Mode Horisontal
        Dim d As New System.Drawing.Drawing2D.LinearGradientBrush(Me.ClientRectangle, Color.SkyBlue, Color.Black, Drawing2D.LinearGradientMode.Horizontal)
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