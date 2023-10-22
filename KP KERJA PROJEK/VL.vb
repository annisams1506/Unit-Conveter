Public Class VL
    Sub combo()
        With COMBOBOX1
            .Items.Add("KL")
            .Items.Add("HL")
            .Items.Add("DAL")
            .Items.Add("L")
            .Items.Add("DL")
            .Items.Add("CL")
            .Items.Add("ML")
        End With
        With COMBOBOX2
            .Items.Add("KL")
            .Items.Add("HL")
            .Items.Add("DAL")
            .Items.Add("L")
            .Items.Add("DL")
            .Items.Add("CL")
            .Items.Add("ML")
        End With
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If TextBox1.Text = "" Then
            MsgBox("MASUKKAN ANGKA", MsgBoxStyle.Information, "INVALID")
        End If
        If ComboBox1.Text = "KL" And ComboBox2.Text = "KL" Then
            hasil.Text = TextBox1.Text & " " & ComboBox2.Text

        ElseIf ComboBox1.Text = "KL" And ComboBox2.Text = "HL" Then
            hasil.Text = TextBox1.Text * 10 & " " & ComboBox2.Text

        ElseIf ComboBox1.Text = "KL" And ComboBox2.Text = "DAL" Then
            hasil.Text = TextBox1.Text * 100 & " " & ComboBox2.Text

        ElseIf ComboBox1.Text = "KL" And ComboBox2.Text = "L" Then
            hasil.Text = TextBox1.Text * 1000 & " " & ComboBox2.Text

        ElseIf ComboBox1.Text = "KL" And ComboBox2.Text = "DL" Then
            hasil.Text = TextBox1.Text * 10000 & " " & ComboBox2.Text

        ElseIf ComboBox1.Text = "KL" And ComboBox2.Text = "CL" Then
            hasil.Text = TextBox1.Text * 100000 & " " & ComboBox2.Text

        ElseIf ComboBox1.Text = "KL" And ComboBox2.Text = "LL" Then
            hasil.Text = TextBox1.Text * 1000000 & " " & ComboBox2.Text

        ElseIf ComboBox1.Text = "HL" And ComboBox2.Text = "KL" Then
            hasil.Text = TextBox1.Text / 10 & " " & ComboBox2.Text

        ElseIf ComboBox1.Text = "HL" And ComboBox2.Text = "HL" Then
            hasil.Text = TextBox1.Text & " " & ComboBox2.Text

        ElseIf ComboBox1.Text = "HL" And ComboBox2.Text = "DAL" Then
            hasil.Text = TextBox1.Text * 10 & " " & ComboBox2.Text

        ElseIf ComboBox1.Text = "HL" And ComboBox2.Text = "L" Then
            hasil.Text = TextBox1.Text * 100 & " " & ComboBox2.Text

        ElseIf ComboBox1.Text = "HL" And ComboBox2.Text = "DL" Then
            hasil.Text = TextBox1.Text * 1000 & " " & ComboBox2.Text

        ElseIf ComboBox1.Text = "HL" And ComboBox2.Text = "CL" Then
            hasil.Text = TextBox1.Text * 10000 & " " & ComboBox2.Text

        ElseIf ComboBox1.Text = "HL" And ComboBox2.Text = "LL" Then
            hasil.Text = TextBox1.Text * 100000 & " " & ComboBox2.Text

        ElseIf ComboBox1.Text = "DAL" And ComboBox2.Text = "KL" Then
            hasil.Text = TextBox1.Text / 100 & " " & ComboBox2.Text

        ElseIf ComboBox1.Text = "DAL" And ComboBox2.Text = "HL" Then
            hasil.Text = TextBox1.Text / 10 & " " & ComboBox2.Text

        ElseIf ComboBox1.Text = "DAL" And ComboBox2.Text = "DAL" Then
            hasil.Text = TextBox1.Text & " " & ComboBox2.Text

        ElseIf ComboBox1.Text = "DAL" And ComboBox2.Text = "L" Then
            hasil.Text = TextBox1.Text * 10 & " " & ComboBox2.Text

        ElseIf ComboBox1.Text = "DAL" And ComboBox2.Text = "DL" Then
            hasil.Text = TextBox1.Text * 100 & " " & ComboBox2.Text

        ElseIf ComboBox1.Text = "DAL" And ComboBox2.Text = "CL" Then
            hasil.Text = TextBox1.Text * 1000 & " " & ComboBox2.Text

        ElseIf ComboBox1.Text = "DAL" And ComboBox2.Text = "LL" Then
            hasil.Text = TextBox1.Text * 10000 & " " & ComboBox2.Text

        ElseIf ComboBox1.Text = "L" And ComboBox2.Text = "KL" Then
            hasil.Text = TextBox1.Text / 1000 & " " & ComboBox2.Text

        ElseIf ComboBox1.Text = "L" And ComboBox2.Text = "HL" Then
            hasil.Text = TextBox1.Text / 100 & " " & ComboBox2.Text

        ElseIf ComboBox1.Text = "L" And ComboBox2.Text = "DAL" Then
            hasil.Text = TextBox1.Text / 10 & " " & ComboBox2.Text

        ElseIf ComboBox1.Text = "L" And ComboBox2.Text = "L" Then
            hasil.Text = TextBox1.Text & " " & ComboBox2.Text

        ElseIf ComboBox1.Text = "L" And ComboBox2.Text = "DL" Then
            hasil.Text = TextBox1.Text * 10 & " " & ComboBox2.Text

        ElseIf ComboBox1.Text = "L" And ComboBox2.Text = "CL" Then
            hasil.Text = TextBox1.Text * 100 & " " & ComboBox2.Text

        ElseIf ComboBox1.Text = "L" And ComboBox2.Text = "LL" Then
            hasil.Text = TextBox1.Text * 1000 & " " & ComboBox2.Text

        ElseIf ComboBox1.Text = "DL" And ComboBox2.Text = "KL" Then
            hasil.Text = TextBox1.Text / 10000 & " " & ComboBox2.Text

        ElseIf ComboBox1.Text = "DL" And ComboBox2.Text = "HL" Then
            hasil.Text = TextBox1.Text / 1000 & " " & ComboBox2.Text

        ElseIf ComboBox1.Text = "DL" And ComboBox2.Text = "DAL" Then
            hasil.Text = TextBox1.Text / 100 & " " & ComboBox2.Text

        ElseIf ComboBox1.Text = "DL" And ComboBox2.Text = "L" Then
            hasil.Text = TextBox1.Text / 10 & " " & ComboBox2.Text

        ElseIf ComboBox1.Text = "DL" And ComboBox2.Text = "DL" Then
            hasil.Text = TextBox1.Text & " " & ComboBox2.Text

        ElseIf ComboBox1.Text = "DL" And ComboBox2.Text = "CL" Then
            hasil.Text = TextBox1.Text * 10 & " " & ComboBox2.Text

        ElseIf ComboBox1.Text = "DL" And ComboBox2.Text = "LL" Then
            hasil.Text = TextBox1.Text * 100 & " " & ComboBox2.Text

        ElseIf ComboBox1.Text = "CL" And ComboBox2.Text = "KL" Then
            hasil.Text = TextBox1.Text / 1000 & " " & ComboBox2.Text

        ElseIf ComboBox1.Text = "CL" And ComboBox2.Text = "HL" Then
            hasil.Text = TextBox1.Text / 100 & " " & ComboBox2.Text

        ElseIf ComboBox1.Text = "CL" And ComboBox2.Text = "DAL" Then
            hasil.Text = TextBox1.Text / 10 & " " & ComboBox2.Text

        ElseIf ComboBox1.Text = "CL" And ComboBox2.Text = "L" Then
            hasil.Text = TextBox1.Text & " " & ComboBox2.Text

        ElseIf ComboBox1.Text = "CL" And ComboBox2.Text = "DL" Then
            hasil.Text = TextBox1.Text * 10 & " " & ComboBox2.Text

        ElseIf ComboBox1.Text = "CL" And ComboBox2.Text = "CL" Then
            hasil.Text = TextBox1.Text * 100 & " " & ComboBox2.Text

        ElseIf ComboBox1.Text = "CL" And ComboBox2.Text = "LL" Then
            hasil.Text = TextBox1.Text * 1000 & " " & ComboBox2.Text

        ElseIf ComboBox1.Text = "LL" And ComboBox2.Text = "KL" Then
            hasil.Text = TextBox1.Text / 1000000 & " " & ComboBox2.Text

        ElseIf ComboBox1.Text = "LL" And ComboBox2.Text = "HL" Then
            hasil.Text = TextBox1.Text / 100000 & " " & ComboBox2.Text

        ElseIf ComboBox1.Text = "LL" And ComboBox2.Text = "DAL" Then
            hasil.Text = TextBox1.Text / 10000 & " " & ComboBox2.Text

        ElseIf ComboBox1.Text = "LL" And ComboBox2.Text = "L" Then
            hasil.Text = TextBox1.Text / 1000 & " " & ComboBox2.Text

        ElseIf ComboBox1.Text = "LL" And ComboBox2.Text = "DL" Then
            hasil.Text = TextBox1.Text / 100 & " " & ComboBox2.Text

        ElseIf ComboBox1.Text = "LL" And ComboBox2.Text = "CL" Then
            hasil.Text = TextBox1.Text / 10 & " " & ComboBox2.Text

        ElseIf ComboBox1.Text = "LL" And ComboBox2.Text = "LL" Then
            hasil.Text = TextBox1.Text & " " & ComboBox2.Text

        ElseIf MsgBox("MASUKAN SATUAN NILAI ", MsgBoxStyle.Information, "INVALD") Then
        End If
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        home.Show()
        Me.Hide()
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        Me.ComboBox2.SelectedItem = Nothing
        Me.ComboBox1.SelectedItem = Nothing
        hasil.Text = ""
        TextBox1.Text = ""
    End Sub


    Private Sub TEXTBOX1_KeyDown(sender As Object, e As KeyEventArgs) Handles TextBox1.KeyDown
        If e.KeyCode = Keys.Enter Then
            Button2.Focus()
        End If
    End Sub

    Private Sub TEXTBOX1_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TextBox1.KeyPress
        If Not ((e.KeyChar >= "0" And e.KeyChar <= "9") Or e.KeyChar = vbBack) Then e.Handled = True
    End Sub
    Private Sub VL_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.ResizeRedraw = True
        Call combo()

    End Sub

    Private Sub VL_Paint(sender As Object, e As PaintEventArgs) Handles Me.Paint
        Dim d As New System.Drawing.Drawing2D.LinearGradientBrush(Me.ClientRectangle, Color.FromArgb(207, 139, 243), Color.FromArgb(102, 102, 153), Drawing2D.LinearGradientMode.Vertical)
        e.Graphics.FillRectangle(d, Me.ClientRectangle)
    End Sub

   
End Class