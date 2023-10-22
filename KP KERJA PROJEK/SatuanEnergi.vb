Public Class SatuanEnergi
    Dim b As Decimal = 1055056 / 1000
    Dim c As Decimal = 36 / 10
    Dim d As Decimal = 1055 / 1000
    Dim f As Decimal = 3412 / 1000
    Dim g As Decimal = 3412142 / 1000
    Dim a As Decimal = 1 / 3600000


    Sub combo()
        With ComboBox1
            .Items.Add("Joule")
            .Items.Add("KiloJoule")
            .Items.Add("Wh(Watt-hour)")
            .Items.Add("kWh(Kilowatt-hour")
            .Items.Add("BTU")
        End With
        With ComboBox2
            .Items.Add("Joule")
            .Items.Add("KiloJoule")
            .Items.Add("Wh(Watt-hour)")
            .Items.Add("kWh(Kilowatt-hour")
            .Items.Add("BTU")
        End With
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If TextBox1.Text = "" Then
            MsgBox("MASUKKAN ANGKA", MsgBoxStyle.Information, "INVALID")
        End If
        If ComboBox1.Text = "Joule" And ComboBox2.Text = "Joule" Then
            hasil.Text = TextBox1.Text & " " & ComboBox2.Text

        ElseIf ComboBox1.Text = "Joule" And ComboBox2.Text = "KiloJoule" Then
            hasil.Text = TextBox1.Text / 1000 & " " & ComboBox2.Text

        ElseIf ComboBox1.Text = "Joule" And ComboBox2.Text = "Wh(Watt-hour)" Then
            hasil.Text = TextBox1.Text / 3600 & " " & ComboBox2.Text

        ElseIf ComboBox1.Text = "Joule" And ComboBox2.Text = "kWh(Kilowatt-hour)" Then
            hasil.Text = TextBox1.Text / a & " " & ComboBox2.Text

        ElseIf ComboBox1.Text = "Joule" And ComboBox2.Text = "BTU" Then
            hasil.Text = TextBox1.Text / b & " " & ComboBox2.Text

        ElseIf ComboBox1.Text = "KiloJoule" And ComboBox2.Text = "KiloJoule" Then
            hasil.Text = TextBox1.Text & " " & ComboBox2.Text

        ElseIf ComboBox1.Text = "KiloJoule" And ComboBox2.Text = "Joule" Then
            hasil.Text = TextBox1.Text * 1000 & " " & ComboBox2.Text

        ElseIf ComboBox1.Text = "KiloJoule" And ComboBox2.Text = "Wh(Watt-hour)" Then
            hasil.Text = TextBox1.Text / c & " " & ComboBox2.Text

        ElseIf ComboBox1.Text = "KiloJoule" And ComboBox2.Text = "kWh(Kilowatt-hour)" Then
            hasil.Text = TextBox1.Text / 3600 & " " & ComboBox2.Text

        ElseIf ComboBox1.Text = "KiloJoule" And ComboBox2.Text = "BTU" Then
            hasil.Text = TextBox1.Text / d & " " & ComboBox2.Text

        ElseIf ComboBox1.Text = "Wh(Watt-hour)" And ComboBox2.Text = "Wh(Watt-hour)" Then
            hasil.Text = TextBox1.Text & " " & ComboBox2.Text

        ElseIf ComboBox1.Text = "Wh(Watt-hour)" And ComboBox2.Text = "Joule" Then
            hasil.Text = TextBox1.Text * 3600 & " " & ComboBox2.Text


        ElseIf ComboBox1.Text = "Wh(Watt-hour)" And ComboBox2.Text = "KiloJoule" Then
            hasil.Text = TextBox1.Text * c & " " & ComboBox2.Text


        ElseIf ComboBox1.Text = "Wh(Watt-hour)" And ComboBox2.Text = "kWh(Kilowatt-hour)" Then
            hasil.Text = TextBox1.Text / 1000 & " " & ComboBox2.Text


        ElseIf ComboBox1.Text = "Wh(Watt-hour)" And ComboBox2.Text = "BTU" Then
            hasil.Text = TextBox1.Text * f & " " & ComboBox2.Text


        ElseIf ComboBox1.Text = "kWh(Kilowatt-hour)" And ComboBox2.Text = "kWh(Kilowatt-hour)" Then
            hasil.Text = TextBox1.Text & " " & ComboBox2.Text
        ElseIf ComboBox1.Text = "kWh(Kilowatt-hour)" And ComboBox2.Text = "Joule" Then
            hasil.Text = TextBox1.Text * a & " " & ComboBox2.Text

        ElseIf ComboBox1.Text = "kWh(Kilowatt-hour)" And ComboBox2.Text = "KiloJoule" Then
            hasil.Text = TextBox1.Text * 3600 & " " & ComboBox2.Text

        ElseIf ComboBox1.Text = "kWh(Kilowatt-hour)" And ComboBox2.Text = "Wh(Watt-hour)" Then
            hasil.Text = TextBox1.Text * 1000 & " " & ComboBox2.Text

        ElseIf ComboBox1.Text = "kWh(Kilowatt-hour)" And ComboBox2.Text = "BTU" Then
            hasil.Text = TextBox1.Text * g & " " & ComboBox2.Text

        ElseIf ComboBox1.Text = "BTU" And ComboBox2.Text = "BTU" Then
            hasil.Text = TextBox1.Text & " " & ComboBox2.Text

        ElseIf ComboBox1.Text = "BTU" And ComboBox2.Text = "Joule" Then
            hasil.Text = TextBox1.Text * b & " " & ComboBox2.Text

        ElseIf ComboBox1.Text = "BTU" And ComboBox2.Text = "KiloJoule" Then
            hasil.Text = TextBox1.Text * d & " " & ComboBox2.Text

        ElseIf ComboBox1.Text = "BTU" And ComboBox2.Text = "Wh(Watt-hour)" Then
            hasil.Text = TextBox1.Text / f & " " & ComboBox2.Text

        ElseIf ComboBox1.Text = "BTU" And ComboBox2.Text = "kWh(Kilowatt-hour)" Then
            hasil.Text = TextBox1.Text / g & " " & ComboBox2.Text

        ElseIf MsgBox("MASUKAN SATUAN NILAI", MsgBoxStyle.Information, "INVALID") Then


        End If
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        home.Show()
        Me.Close()
    End Sub


    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        TextBox1.Text = ""
        hasil.text = ""
        Me.ComboBox1.SelectedItem = Nothing
        Me.ComboBox2.SelectedItem = Nothing
    End Sub

    Private Sub Form15_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Call combo()
        Me.ResizeRedraw = True
    End Sub

    Private Sub TextBox1_KeyDown(sender As Object, e As KeyEventArgs) Handles TextBox1.KeyDown
        If e.KeyCode = Keys.Enter Then
            ComboBox1.Focus()


        End If
    End Sub

    Private Sub TextBox1_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TextBox1.KeyPress
        If Not ((e.KeyChar >= "0" And e.KeyChar <= "9") Or e.KeyChar = vbBack) Then e.Handled = True
    End Sub

    Private Sub SatuanEnergi_Paint(sender As Object, e As PaintEventArgs) Handles Me.Paint
        Dim d As New System.Drawing.Drawing2D.LinearGradientBrush(Me.ClientRectangle, Color.FromArgb(142, 158, 171), Color.FromArgb(238, 242, 243), Drawing2D.LinearGradientMode.ForwardDiagonal)
        e.Graphics.FillRectangle(d, Me.ClientRectangle)

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