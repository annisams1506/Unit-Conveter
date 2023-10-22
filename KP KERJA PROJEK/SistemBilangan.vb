Public Class SistemBilangan
    Sub combo()
        With awalcb
            .Items.Add("Biner")
            .Items.Add("Decimal")
            .Items.Add("Oktal")
            .Items.Add("HexaDecimal")
        End With
        With terakhircb
            .Items.Add("Biner")
            .Items.Add("Decimal")
            .Items.Add("Oktal")
            .Items.Add("HexaDecimal")
        End With
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If input.Text = "" Then
            MsgBox("MASUKKAN ANGKA", MsgBoxStyle.Information, "INVALID")
        End If
        If awalcb.Text = "Biner" And terakhircb.Text = "Biner" Then
            hasil.Text = input.Text & " " & terakhircb.Text
        ElseIf awalcb.Text = "Biner" And terakhircb.Text = "Oktal" Then
            hasil.Text = BinToOk(input.Text) & " " & terakhircb.Text
        ElseIf awalcb.Text = "Biner" And terakhircb.Text = "HexaDecimal" Then
            hasil.Text = BinToHex(input.Text) & " " & terakhircb.Text
        ElseIf awalcb.Text = "Decimal" And terakhircb.Text = "Decimal" Then
            hasil.Text = input.Text & " " & terakhircb.Text
        ElseIf awalcb.Text = "Decimal" And terakhircb.Text = "Biner" Then
            hasil.Text = DesToBin(input.Text) & " " & terakhircb.Text
        ElseIf awalcb.Text = "Decimal" And terakhircb.Text = "Oktal" Then
            hasil.Text = DesToOk(input.Text) & " " & terakhircb.Text
        ElseIf awalcb.Text = "Decimal" And terakhircb.Text = "" Then
            hasil.Text = DesToHex(input.Text) & " " & terakhircb.Text
        ElseIf awalcb.Text = "Oktal" And terakhircb.Text = "Oktal" Then
            hasil.Text = input.Text & " " & terakhircb.Text
        ElseIf awalcb.Text = "Oktal" And terakhircb.Text = "Biner" Then
            hasil.Text = OkToBin(input.Text) & " " & terakhircb.Text
        ElseIf awalcb.Text = "Oktal" And terakhircb.Text = "Decimal" Then
            hasil.Text = OkToDes(input.Text) & " " & terakhircb.Text
        ElseIf awalcb.Text = "Oktal" And terakhircb.Text = "HexaDecimal" Then
            hasil.Text = OkToHex(input.Text) & " " & terakhircb.Text
        ElseIf awalcb.Text = "HexaDecimal" And terakhircb.Text = "HexaDecimal" Then
            hasil.Text = input.Text & " " & terakhircb.Text
        ElseIf awalcb.Text = "HexaDecimal" And terakhircb.Text = "Biner" Then
            hasil.Text = HexToBin(input.Text) & " " & terakhircb.Text
        ElseIf awalcb.Text = "HexaDecimal" And terakhircb.Text = "Oktal" Then
            hasil.Text = HexToOk(input.Text) & " " & terakhircb.Text
        ElseIf awalcb.Text = "HexaDecimal" And terakhircb.Text = "Decimal" Then
            hasil.Text = HexToDes(input.Text) & " " & terakhircb.Text
        ElseIf awalcb.Text = "Biner" And terakhircb.Text = "Decimal" Then
            hasil.Text = BinToDes(input.Text) & " " & terakhircb.Text

        ElseIf MsgBox("MASUKAN SATUAN NILAI", MsgBoxStyle.Information, "INVALID") Then
        End If
        With hasil
            .SelectionStart = 0
            .SelectionLength = Len(hasil.Text)
        End With
    End Sub
    Public Function BinToDes(ByVal NBiner As String) As Long
        Dim a As Integer
        Dim b As Long
        Dim nilai As Long
        On Error GoTo ErrorHandler
        b = 1
        For a = Len(NBiner) To 1 Step -1
            If Mid(NBiner, a, 1) = "1" Then nilai = nilai + b
            b = b * 2
        Next
        BinToDes = nilai
        Exit Function
ErrorHandler:
        BinToDes = 0
    End Function
    Public Function DesToBin(ByVal NDecimal As Long) As String
        Dim d As Long
        Dim nilai As String
        On Error GoTo ErrorHandler
        d = (2 ^ 31) - 1
        While d > 0
            If NDecimal - d >= 0 Then
                NDecimal = NDecimal - d
                nilai = nilai & "1"
            Else
                If Val(nilai) > 0 Then nilai = nilai & "0"
            End If
            d = d / 2
        End While
        DesToBin = nilai
        Exit Function
ErrorHandler:
        DesToBin = 0
    End Function
    Public Function DesToHex(ByVal NDecimal As String) As String
        DesToHex = Hex(NDecimal)
    End Function
    Public Function HexToDes(ByVal Nhexa As String) As Long
        Dim e As Integer
        Dim nilai As Long
        Dim f As Long
        Dim CharNilai As Byte
        On Error GoTo ErrorHandler
        For e = Len(Nhexa) To 1 Step -1
            Select Case Mid(Nhexa, e, 1)
                Case "0" To "9" : CharNilai = CInt(Mid(Nhexa, e, 1))
                Case Else : CharNilai = Asc(Mid(Nhexa, e, 1)) - 55
            End Select
            nilai = nilai + ((16 ^ f) * CharNilai)
            f = f + 1
        Next e
        HexToDes = nilai
        Exit Function
ErrorHandler:
        HexToDes = 0
    End Function
    Public Function DesToOk(ByVal NDecimal As Long) As String
        DesToOk = Oct(NDecimal)
    End Function
    Public Function OkToDes(ByVal NOktal As String) As Long
        Dim g As Integer
        Dim h As Long
        Dim nilai As Long
        On Error GoTo ErrorHandler
        For g = Len(NOktal) To 1 Step -1
            nilai = nilai + (8 ^ h) * CInt(Mid(NOktal, g, 1))
            h = h + 1
        Next g
        OkToDes = nilai
        Exit Function
ErrorHandler:
        OkToDes = 0
    End Function
    Public Function BinToOk(ByVal bin As Long) As String
        BinToOk = DesToOk(BinToDes(bin))
    End Function
    Public Function BinToHex(ByVal Nbiner As Long) As String
        BinToHex = DesToHex(BinToDes(Nbiner))
    End Function
    Public Function OkToBin(ByVal NOktal As Double) As String
        OkToBin = DesToBin(OkToDes(NOktal))
    End Function
    Public Function OkToHex(ByVal NOktal As Double) As String
        OkToHex = DesToHex(OkToDes(NOktal))
    End Function
    Public Function HexToBin(ByVal NHexa As String) As String
        HexToBin = DesToBin(HexToDes(NHexa))
    End Function
    Public Function HexToOk(ByVal Nhexa As String) As Double
        HexToOk = DesToOk(HexToDes(Nhexa))
    End Function

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        input.Text = ""
        hasil.Text = ""
        Me.awalcb.SelectedItem = Nothing
        Me.terakhircb.SelectedItem = Nothing


    End Sub
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.ResizeRedraw = True
        Call combo()
    End Sub

    Private Sub input_KeyDown(sender As Object, e As KeyEventArgs) Handles input.KeyDown
        If e.KeyCode = Keys.Enter Then
            Button1.Show()

        End If
    End Sub

    Private Sub input_KeyPress(sender As Object, e As KeyPressEventArgs) Handles input.KeyPress
        If Not ((e.KeyChar >= "0" And e.KeyChar <= "9") Or e.KeyChar = vbBack) Then e.Handled = True
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        home.Show()
        Me.Close()
    End Sub

    Private Sub Label10_Click(sender As Object, e As EventArgs) Handles Label10.Click

    End Sub

    Private Sub SistemBilangan_Paint(sender As Object, e As PaintEventArgs) Handles Me.Paint
        Dim d As New System.Drawing.Drawing2D.LinearGradientBrush(Me.ClientRectangle, Color.FromArgb(102, 0, 102), Color.FromArgb(102, 102, 153), Drawing2D.LinearGradientMode.Horizontal)
        e.Graphics.FillRectangle(d, Me.ClientRectangle)

    End Sub

    Private Sub input_TextChanged(sender As Object, e As EventArgs) Handles input.TextChanged

    End Sub
End Class