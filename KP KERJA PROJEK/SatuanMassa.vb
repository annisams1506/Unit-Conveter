Public Class SatuanMassa
    Sub combo()
        With ComboBox1
            .Items.Add("KWINTAL")
            .Items.Add("KG")
            .Items.Add("HG/ONS")
            .Items.Add("DAG")
            .Items.Add("GR")
            .Items.Add("DG")
            .Items.Add("CG")
            .Items.Add("MG")
        End With
        With ComboBox2
            .Items.Add("KWINTAL")
            .Items.Add("KG")
            .Items.Add("HG/ONS")
            .Items.Add("DAG")
            .Items.Add("GR")
            .Items.Add("DG")
            .Items.Add("CG")
            .Items.Add("MG")
        End With
    End Sub

   

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        home.Show()
        Me.Hide()

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If TextBox1.Text = "" Then
            MsgBox("MASUKKAN ANGKA", MsgBoxStyle.Information, "INVALID")
        End If

        If ComboBox1.Text = "KWINTAL" And ComboBox2.Text = "KG" Then
            hasil.Text = TextBox1.Text * 100 & " " & ComboBox2.Text
        ElseIf ComboBox1.Text = "KWINTAL" And ComboBox2.Text = "KWINTAL" Then
            hasil.Text = TextBox1.Text & " " & ComboBox2.Text
        ElseIf ComboBox1.Text = "KWINTAL" And ComboBox2.Text = "HG/ONS" Then
            hasil.Text = TextBox1.Text * 1000 & " " & ComboBox2.Text
        ElseIf ComboBox1.Text = "KWINTAL" And ComboBox2.Text = "DAG" Then
            hasil.Text = TextBox1.Text * 10000 & " " & ComboBox2.Text
        ElseIf ComboBox1.Text = "KWINTAL" And ComboBox2.Text = "GR" Then
            hasil.Text = TextBox1.Text * 100000 & " " & ComboBox2.Text
        ElseIf ComboBox1.Text = "KWINTAL" And ComboBox2.Text = "DG" Then
            hasil.Text = TextBox1.Text * 1000000 & " " & ComboBox2.Text
        ElseIf ComboBox1.Text = "KWINTAL" And ComboBox2.Text = "CG" Then
            hasil.Text = TextBox1.Text * 10000000 & " " & ComboBox2.Text
        ElseIf ComboBox1.Text = "KWINTAL" And ComboBox2.Text = "MG" Then
            hasil.Text = TextBox1.Text * 100000000 & " " & ComboBox2.Text

        ElseIf ComboBox1.Text = "KG" And ComboBox2.Text = "KG" Then
            hasil.Text = TextBox1.Text & " " & ComboBox2.Text
        ElseIf ComboBox1.Text = "KG" And ComboBox2.Text = "HG/ONS" Then
            hasil.Text = TextBox1.Text * 10 & " " & ComboBox2.Text
        ElseIf ComboBox1.Text = "KG" And ComboBox2.Text = "DAG" Then
            hasil.Text = TextBox1.Text * 100 & " " & ComboBox2.Text
        ElseIf ComboBox1.Text = "KG" And ComboBox2.Text = "GR" Then
            hasil.Text = TextBox1.Text * 1000 & " " & ComboBox2.Text
        ElseIf ComboBox1.Text = "KG" And ComboBox2.Text = "DG" Then
            hasil.Text = TextBox1.Text * 10000 & " " & ComboBox2.Text
        ElseIf ComboBox1.Text = "KG" And ComboBox2.Text = "CG" Then
            hasil.Text = TextBox1.Text * 100000 & " " & ComboBox2.Text
        ElseIf ComboBox1.Text = "KG" And ComboBox2.Text = "MG" Then
            hasil.Text = TextBox1.Text * 1000000 & " " & ComboBox2.Text
        ElseIf ComboBox1.Text = "KG" And ComboBox2.Text = "KWINTAL" Then
            hasil.Text = TextBox1.Text / 100 & " " & ComboBox2.Text
        ElseIf ComboBox1.Text = "HG/ONS" And ComboBox2.Text = "KG" Then
            hasil.Text = TextBox1.Text / 10 & " " & ComboBox2.Text
        ElseIf ComboBox1.Text = "HG/ONS" And ComboBox2.Text = "HG/ONS" Then
            hasil.Text = TextBox1.Text & " " & ComboBox2.Text
        ElseIf ComboBox1.Text = "HG/ONS" And ComboBox2.Text = "DAG" Then
            hasil.Text = TextBox1.Text * 10 & " " & ComboBox2.Text
        ElseIf ComboBox1.Text = "HG/ONS" And ComboBox2.Text = "GR" Then
            hasil.Text = TextBox1.Text * 100 & " " & ComboBox2.Text
        ElseIf ComboBox1.Text = "HG/ONS" And ComboBox2.Text = "DG" Then
            hasil.Text = TextBox1.Text * 1000 & " " & ComboBox2.Text
        ElseIf ComboBox1.Text = "HG/ONS" And ComboBox2.Text = "CG" Then
            hasil.Text = TextBox1.Text * 10000 & " " & ComboBox2.Text
        ElseIf ComboBox1.Text = "HG/ONS" And ComboBox2.Text = "MG" Then
            hasil.Text = TextBox1.Text * 100000 & " " & ComboBox2.Text
        ElseIf ComboBox1.Text = "HG/ONS" And ComboBox2.Text = "KWINTAL" Then
            hasil.Text = TextBox1.Text / 1000 & " " & ComboBox2.Text
        ElseIf ComboBox1.Text = "DAG" And ComboBox2.Text = "KG" Then
            hasil.Text = TextBox1.Text / 100 & " " & ComboBox2.Text
        ElseIf ComboBox1.Text = "DAG" And ComboBox2.Text = "HG/ONS" Then
            hasil.Text = TextBox1.Text / 10 & " " & ComboBox2.Text
        ElseIf ComboBox1.Text = "DAG" And ComboBox2.Text = "DAG" Then
            hasil.Text = TextBox1.Text & " " & ComboBox2.Text
        ElseIf ComboBox1.Text = "DAG" And ComboBox2.Text = "GR" Then
            hasil.Text = TextBox1.Text * 10 & " " & ComboBox2.Text
        ElseIf ComboBox1.Text = "DAG" And ComboBox2.Text = "DG" Then
            hasil.Text = TextBox1.Text * 100 & " " & ComboBox2.Text
        ElseIf ComboBox1.Text = "DAG" And ComboBox2.Text = "CG" Then
            hasil.Text = TextBox1.Text * 1000 & " " & ComboBox2.Text
        ElseIf ComboBox1.Text = "DAG" And ComboBox2.Text = "MG" Then
            hasil.Text = TextBox1.Text * 10000 & " " & ComboBox2.Text
        ElseIf ComboBox1.Text = "DAG" And ComboBox2.Text = "KWINTAL" Then
            hasil.Text = TextBox1.Text / 10000 & " " & ComboBox2.Text
        ElseIf ComboBox1.Text = "GR" And ComboBox2.Text = "KG" Then
            hasil.Text = TextBox1.Text / 1000 & " " & ComboBox2.Text
        ElseIf ComboBox1.Text = "GR" And ComboBox2.Text = "HG/ONS" Then
            hasil.Text = TextBox1.Text / 100 & " " & ComboBox2.Text
        ElseIf ComboBox1.Text = "GR" And ComboBox2.Text = "DAG" Then
            hasil.Text = TextBox1.Text / 10 & " " & ComboBox2.Text
        ElseIf ComboBox1.Text = "GR" And ComboBox2.Text = "GR" Then
            hasil.Text = TextBox1.Text & " " & ComboBox2.Text
        ElseIf ComboBox1.Text = "GR" And ComboBox2.Text = "DG" Then
            hasil.Text = TextBox1.Text * 10 & " " & ComboBox2.Text
        ElseIf ComboBox1.Text = "GR" And ComboBox2.Text = "CG" Then
            hasil.Text = TextBox1.Text * 100 & " " & ComboBox2.Text
        ElseIf ComboBox1.Text = "GR" And ComboBox2.Text = "MG" Then
            hasil.Text = TextBox1.Text * 1000 & " " & ComboBox2.Text
        ElseIf ComboBox1.Text = "GR" And ComboBox2.Text = "KWINTAL" Then
            hasil.Text = TextBox1.Text / 100000 & " " & ComboBox2.Text
        ElseIf ComboBox1.Text = "DG" And ComboBox2.Text = "KG" Then
            hasil.Text = TextBox1.Text / 10000 & " " & ComboBox2.Text
        ElseIf ComboBox1.Text = "DG" And ComboBox2.Text = "HG/ONS" Then
            hasil.Text = TextBox1.Text / 1000 & " " & ComboBox2.Text
        ElseIf ComboBox1.Text = "DG" And ComboBox2.Text = "DAG" Then
            hasil.Text = TextBox1.Text / 100 & " " & ComboBox2.Text
        ElseIf ComboBox1.Text = "DG" And ComboBox2.Text = "GR" Then
            hasil.Text = TextBox1.Text / 10 & " " & ComboBox2.Text
        ElseIf ComboBox1.Text = "DG" And ComboBox2.Text = "DG" Then
            hasil.Text = TextBox1.Text & " " & ComboBox2.Text
        ElseIf ComboBox1.Text = "DG" And ComboBox2.Text = "CG" Then
            hasil.Text = TextBox1.Text * 10 & " " & ComboBox2.Text
        ElseIf ComboBox1.Text = "DG" And ComboBox2.Text = "MG" Then
            hasil.Text = TextBox1.Text * 100 & " " & ComboBox2.Text
        ElseIf ComboBox1.Text = "DG" And ComboBox2.Text = "KWINTAL" Then
            hasil.Text = TextBox1.Text / 1000000 & " " & ComboBox2.Text
        ElseIf ComboBox1.Text = "CG" And ComboBox2.Text = "KG" Then
            hasil.Text = TextBox1.Text / 1000
        ElseIf ComboBox1.Text = "CG" And ComboBox2.Text = "HG/ONS" Then
            hasil.Text = TextBox1.Text / 100 & " " & ComboBox2.Text
        ElseIf ComboBox1.Text = "CG" And ComboBox2.Text = "DAG" Then
            hasil.Text = TextBox1.Text / 10
        ElseIf ComboBox1.Text = "CG" And ComboBox2.Text = "GR" Then
            hasil.Text = TextBox1.Text & " " & ComboBox2.Text
        ElseIf ComboBox1.Text = "CG" And ComboBox2.Text = "DG" Then
            hasil.Text = TextBox1.Text * 10 & " " & ComboBox2.Text
        ElseIf ComboBox1.Text = "CG" And ComboBox2.Text = "CG" Then
            hasil.Text = TextBox1.Text * 100
        ElseIf ComboBox1.Text = "CG" And ComboBox2.Text = "MG" Then
            hasil.Text = TextBox1.Text * 1000 & " " & ComboBox2.Text
        ElseIf ComboBox1.Text = "CG" And ComboBox2.Text = "KWINTAL" Then
            hasil.Text = TextBox1.Text / 10000000 & " " & ComboBox2.Text
        ElseIf ComboBox1.Text = "MG" And ComboBox2.Text = "KG" Then
            hasil.Text = TextBox1.Text / 1000000 & " " & ComboBox2.Text
        ElseIf ComboBox1.Text = "MG" And ComboBox2.Text = "HG/ONS" Then
            hasil.Text = TextBox1.Text / 100000 & " " & ComboBox2.Text
        ElseIf ComboBox1.Text = "MG" And ComboBox2.Text = "DAG" Then
            hasil.Text = TextBox1.Text / 10000 & " " & ComboBox2.Text
        ElseIf ComboBox1.Text = "MG" And ComboBox2.Text = "GR" Then
            hasil.Text = TextBox1.Text / 1000 & " " & ComboBox2.Text
        ElseIf ComboBox1.Text = "MG" And ComboBox2.Text = "DG" Then
            hasil.Text = TextBox1.Text / 100 & " " & ComboBox2.Text
        ElseIf ComboBox1.Text = "MG" And ComboBox2.Text = "CG" Then
            hasil.Text = TextBox1.Text / 10 & " " & ComboBox2.Text
        ElseIf ComboBox1.Text = "MG" And ComboBox2.Text = "m" Then
            hasil.Text = TextBox1.Text & " " & ComboBox2.Text
        ElseIf ComboBox1.Text = "MG" And ComboBox2.Text = "KWINTAL" Then
            hasil.Text = TextBox1.Text / 100000000 & " " & ComboBox2.Text

        ElseIf MsgBox("MASUKAN SATUAN NILAI", MsgBoxStyle.Information, "INVALID") Then
        End If
    End Sub

    Private Sub Form3_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.ResizeRedraw = True
        Call combo()
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        TextBox1.Text = ""
        hasil.Text = ""
        Me.ComboBox1.SelectedItem = Nothing
        Me.ComboBox2.SelectedItem = Nothing

    End Sub

    Private Sub TextBox1_KeyDown(sender As Object, e As KeyEventArgs) Handles TextBox1.KeyDown
        If e.KeyCode = Keys.Enter Then
            Button1.Show()

        End If
    End Sub
    Private Sub TextBox1_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TextBox1.KeyPress
        If Not ((e.KeyChar >= "0" And e.KeyChar <= "9") Or e.KeyChar = vbBack) Then e.Handled = True
    End Sub

    Private Sub SatuanMassa_Paint(sender As Object, e As PaintEventArgs) Handles Me.Paint
        Dim d As New System.Drawing.Drawing2D.LinearGradientBrush(Me.ClientRectangle, Color.FromArgb(238, 156, 167), Color.FromArgb(255, 221, 225), Drawing2D.LinearGradientMode.ForwardDiagonal)
        e.Graphics.FillRectangle(d, Me.ClientRectangle)

    End Sub

    Private Sub Label6_Click(sender As Object, e As EventArgs) Handles Label6.Click

    End Sub
End Class