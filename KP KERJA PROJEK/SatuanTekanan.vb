Public Class SatuanTekanan
    Dim a As Decimal = 1013 / 1000
    Dim b As Decimal = 14696 / 1000
    Dim c As Decimal = 14504 / 1000
    Dim d As Decimal = 750062 / 1000
    Dim f As Decimal = 133322 / 1000
    Dim r As Decimal = 51715 / 1000
    Dim t As Decimal = 689 / 100
    Sub combo()
        With ComboBox1
            .Items.Add("Atmosfer (atm)")
            .Items.Add("Bar")
            .Items.Add("Pascal (Pa)")
            .Items.Add("PSI (Pounds per Square Inch)")
            .Items.Add("Torr")
            With ComboBox2()
                .Items.Add("Atmosfer (atm)")
                .Items.Add("Bar")
                .Items.Add("Pascal (Pa)")
                .Items.Add("PSI (Pounds per Square Inch)")
                .Items.Add("Torr")
            End With
        End With
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If TextBox1.Text = "" Then
            MsgBox("MASUKKAN ANGKA", MsgBoxStyle.Information, "INVALID")
        End If
        If ComboBox1.Text = "Atmosfer (atm)" And ComboBox2.Text = "Atmosfer (atm)" Then
            hasil.Text = TextBox1.Text & " " & ComboBox2.Text

        ElseIf ComboBox1.Text = "Atmosfer (atm)" And ComboBox2.Text = "Bar" Then
            hasil.Text = TextBox1.Text * a & " " & ComboBox2.Text

        ElseIf ComboBox1.Text = "Atmosfer (atm)" And ComboBox2.Text = "Pascal (PA)" Then
            hasil.Text = TextBox1.Text * 101300 & " " & ComboBox2.Text

        ElseIf ComboBox1.Text = "Atmosfer (atm)" And ComboBox2.Text = "PSI (Pounds per Square Inch)" Then
            hasil.Text = TextBox1.Text * b & " " & ComboBox2.Text

        ElseIf ComboBox1.Text = "Atmosfer (atm)" And ComboBox2.Text = "Torr" Then
            hasil.Text = TextBox1.Text * 760 & " " & ComboBox2.Text

        ElseIf ComboBox1.Text = "Bar" And ComboBox2.Text = "Bar" Then
            hasil.Text = TextBox1.Text & " " & ComboBox2.Text

        ElseIf ComboBox1.Text = "Bar" And ComboBox2.Text = "Atmosfer (atm)" Then
            hasil.Text = TextBox1.Text / a & " " & ComboBox2.Text

        ElseIf ComboBox1.Text = "Bar" And ComboBox2.Text = "Pascal (Pa)" Then
            hasil.Text = TextBox1.Text * 100000 & " " & ComboBox2.Text

        ElseIf ComboBox1.Text = "Bar" And ComboBox2.Text = "PSI (Pounds per Square Inch)" Then
            hasil.Text = TextBox1.Text * c & " " & ComboBox2.Text

        ElseIf ComboBox1.Text = "Bar" And ComboBox2.Text = "Torr" Then
            hasil.Text = TextBox1.Text * d & " " & ComboBox2.Text

        ElseIf ComboBox1.Text = "Pascal (PA)" And ComboBox2.Text = "Pascal (PA)" Then
            hasil.Text = TextBox1.Text & " " & ComboBox2.Text

        ElseIf ComboBox1.Text = "Pascal (PA)" And ComboBox2.Text = "Atmosfer (atm)" Then
            hasil.Text = TextBox1.Text / 101325 & " " & ComboBox2.Text

        ElseIf ComboBox1.Text = "Pascal (PA)" And ComboBox2.Text = "Bar" Then
            hasil.Text = TextBox1.Text / 100000 & " " & ComboBox2.Text

        ElseIf ComboBox1.Text = "Pascal (PA)" And ComboBox2.Text = "PSI (Pounds per Square Inch)" Then
            hasil.Text = TextBox1.Text / t & " " & ComboBox2.Text

        ElseIf ComboBox1.Text = "Pascal (PA)" And ComboBox2.Text = "Torr" Then
            hasil.Text = TextBox1.Text / f & " " & ComboBox2.Text

        ElseIf ComboBox1.Text = "PSI (Pounds per Square Inch)" And ComboBox2.Text = "PSI (Pounds per Square Inch)" Then
            hasil.Text = TextBox1.Text & " " & ComboBox2.Text

        ElseIf ComboBox1.Text = "PSI (Pounds per Square Inch)" And ComboBox2.Text = "Atmosfer(atm)" Then
            hasil.Text = TextBox1.Text / b & " " & ComboBox2.Text

        ElseIf ComboBox1.Text = "PSI (Pounds per Square Inch)" And ComboBox2.Text = "Pascal (Pa)" Then
            hasil.Text = TextBox1.Text * t & " " & ComboBox2.Text

        ElseIf ComboBox1.Text = "PSI (Pounds per Square Inch)" And ComboBox2.Text = "Bar" Then
            hasil.Text = TextBox1.Text / c & " " & ComboBox2.Text

        ElseIf ComboBox1.Text = "PSI (Pounds per Square Inch)" And ComboBox2.Text = "Torr" Then
            hasil.Text = TextBox1.Text * r & " " & ComboBox2.Text

        ElseIf ComboBox1.Text = "Torr" And ComboBox2.Text = "Torr" Then
            hasil.Text = TextBox1.Text & " " & ComboBox2.Text

        ElseIf ComboBox1.Text = "Torr" And ComboBox2.Text = "Atmosfer (atm)" Then
            hasil.Text = TextBox1.Text / 760 & " " & ComboBox2.Text

        ElseIf ComboBox1.Text = "Torr" And ComboBox2.Text = "Pascal (Pa)" Then
            hasil.Text = TextBox1.Text * f & " " & ComboBox2.Text

        ElseIf ComboBox1.Text = "Torr" And ComboBox2.Text = "Bar" Then
            hasil.Text = TextBox1.Text / d & " " & ComboBox2.Text

        ElseIf ComboBox1.Text = "Torr" And ComboBox2.Text = "PSI (Pounds per Square Inch)" Then
            hasil.Text = TextBox1.Text / r & " " & ComboBox2.Text

        ElseIf MsgBox("MASUKKAN SATUAN NILAI", MsgBoxStyle.Information, "INVALID") Then
        End If
    End Sub


    Private Sub Form14_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Call combo()
        Me.ResizeRedraw = True
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
            Button1.Show()

        End If
    End Sub
    Private Sub TextBox1_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TextBox1.KeyPress
        If Not ((e.KeyChar >= "0" And e.KeyChar <= "9") Or e.KeyChar = vbBack) Then e.Handled = True
    End Sub

    Private Sub Label5_Click(sender As Object, e As EventArgs) Handles Label5.Click

    End Sub

    Private Sub SatuanTekanan_Paint(sender As Object, e As PaintEventArgs) Handles Me.Paint
        Dim d As New System.Drawing.Drawing2D.LinearGradientBrush(Me.ClientRectangle, Color.FromArgb(40, 60, 134), Color.FromArgb(69, 162, 71), Drawing2D.LinearGradientMode.Vertical)
        e.Graphics.FillRectangle(d, Me.ClientRectangle)

    End Sub

    
End Class