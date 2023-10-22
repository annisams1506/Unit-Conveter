Public Class MU
    Dim f As Double



    Sub Combo()
        With awal
            .Items.Add("USD - (Dolar Amerika Serikat)")
            .Items.Add("AUD - (Dolar Australia)")
            .Items.Add("BRL - (Real Brasil)")
            .Items.Add("IDR - (Rupiah Indonesia)")
            .Items.Add("EUR - (Euro)")
            .Items.Add("KRW - (Won Korea)")
            .Items.Add("JPY - (Yen Jepang)")
            .Items.Add("CNY - (Yuan Tiongkok)")
            .Items.Add("MYR - (Ringgit Malaysia)")
            .Items.Add("VND - (Vietnam Dong)")
            .Items.Add("THB - (Thai Baht)")
            With akhir
                .Items.Add("USD - (Dolar Amerika Serikat)")
                .Items.Add("AUD - (Dolar Australia)")
                .Items.Add("BRL - (Real Brasil)")
                .Items.Add("IDR - (Rupiah Indonesia)")
                .Items.Add("EUR - (Euro)")
                .Items.Add("KRW - (Won Korea)")
                .Items.Add("JPY - (Yen Jepang)")
                .Items.Add("CNY - (Yuan Tiongkok)")
                .Items.Add("MYR - (Ringgit Malaysia)")
                .Items.Add("VND - (Vietnam Dong)")
                .Items.Add("THB - (Thai Baht)")
            End With
        End With
    End Sub



    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        home.Show()
        Me.Close()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If input.Text = "" Then
            MsgBox("MASUKKAN ANGKA", MsgBoxStyle.Information, "INVALID")
        End If
        If awal.Text = "USD - (Dolar Amerika Serikat)" And akhir.Text = "USD - (Dolar Amerika Serikat)" Then
            hasil.Text = "$" & " " & FormatNumber(input.Text, 2)

        ElseIf awal.Text = "USD - (Dolar Amerika Serikat)" And akhir.Text = "AUD - (Dolar Australia)" Then
            hasil.Text = "$" & " " & FormatNumber(Val(input.Text * (147 / 100)), 2)
        ElseIf awal.Text = "USD - (Dolar Amerika Serikat)" And akhir.Text = "BRL - (Real Brasil)" Then
            hasil.Text = "R$" & " " & FormatNumber(Val(input.Text * (412 / 100)), 2)

        ElseIf awal.Text = "USD - (Dolar Amerika Serikat)" And akhir.Text = "IDR - (Rupiah Indonesia)" Then
            hasil.Text = "RP" & " " & FormatNumber(Val(input.Text * (1412255 / 100)), 2)

        ElseIf awal.Text = "USD - (Dolar Amerika Serikat)" And akhir.Text = "EUR - (Euro)" Then
            hasil.Text = "€" & " " & FormatNumber(Val(input.Text / (111 / 100)), 2)

        ElseIf awal.Text = "USD - (Dolar Amerika Serikat)" And akhir.Text = "JPY - (Yen Jepang)" Then
            hasil.Text = "¥" & " " & FormatNumber(Val(input.Text * (10842 / 100)), 2)

        ElseIf awal.Text = "CNY - (Yuan Tiongkok)" And akhir.Text = "USD - (Dolar Amerika Serikat)" Then
            hasil.Text = "$" & " " & FormatNumber(Val(input.Text / (710 / 100)), 2)



        ElseIf awal.Text = "AUD - (Dolar Australia)" And akhir.Text = "JPY - (Yen Jepang)" Then
            hasil.Text = "¥" & " " & FormatNumber(Val(input.Text * (7273 / 100)), 2)

        ElseIf awal.Text = "BRL - (Real Brasil)" And akhir.Text = "JPY - (Yen Jepang)" Then
            hasil.Text = "¥" & " " & FormatNumber(Val(input.Text * (2633 / 100)), 2)

        ElseIf awal.Text = "IDR - (Rupiah Indonesia)" And akhir.Text = "JPY - (Yen Jepang)" Then
            hasil.Text = "¥" & " " & FormatNumber(Val(input.Text * (77 / 10000)), 2)

        ElseIf awal.Text = "EUR - (Euro)" And akhir.Text = "JPY - (Yen Jepang)" Then
            hasil.Text = "¥" & " " & FormatNumber(Val(input.Text * (11987 / 100)), 2)

        ElseIf awal.Text = "KRW - (Won Korea)" And akhir.Text = "JPY - (Yen Jepang)" Then
            hasil.Text = "¥" & " " & FormatNumber(Val(input.Text * (92 / 1000)), 2)

        ElseIf awal.Text = "JPY - (Yen Jepang)" And akhir.Text = "JPY - (Yen Jepang)" Then
            hasil.Text = "¥" & " " & FormatNumber(Val(input.Text), 2)

        ElseIf awal.Text = "CNY - (Yuan Tiongkok)" And akhir.Text = "JPY - (Yen Jepang)"" Then" Then
            hasil.Text = "¥" & " " & FormatNumber(Val(input.Text * (1527 / 1000)), 2)

        ElseIf awal.Text = "MYR - (Ringgit Malaysia)" And akhir.Text = "JPY - (Yen Jepang)"" Then" Then
            hasil.Text = "¥" & " " & FormatNumber(Val(input.Text * (2595 / 100)), 2)

        ElseIf awal.Text = "VND - (Vietnam Dong)" And akhir.Text = "JPY - (Yen Jepang)"" Then" Then
            hasil.Text = "¥" & " " & FormatNumber(Val(input.Text * (47 / 10000)), 2)

        ElseIf awal.Text = "THB - (Thai Baht)" And akhir.Text = "JPY - (Yen Jepang)"" Then" Then
            hasil.Text = "¥" & " " & FormatNumber(Val(input.Text * (356 / 100)), 2)


        ElseIf awal.Text = "USD - (Dolar Amerika Serikat)" And akhir.Text = "KRW - (Won Korea)" Then
            hasil.Text = "₩" & "  " & FormatNumber(Val(input.Text * (118259 / 100)), 2)

        ElseIf awal.Text = "JPY - (Yen Jepang)" And akhir.Text = "KRW - (Won Korea)" Then
            hasil.Text = "₩" & "  " & FormatNumber(Val(input.Text * (1090 / 100)), 2)

        ElseIf awal.Text = "KRW - (Won Korea)" And akhir.Text = "KRW - (Won Korea)" Then
            hasil.Text = "₩" & "  " & FormatNumber(Val(input.Text), 2)

        ElseIf awal.Text = "EUR - (Euro)" And akhir.Text = "KRW - (Won Korea)" Then
            hasil.Text = "₩" & "  " & FormatNumber(Val(input.Text * (130765 / 100)), 2)

        ElseIf awal.Text = "IDR - (Rupiah Indonesia)" And akhir.Text = "KRW - (Won Korea)" Then
            hasil.Text = "₩" & "  " & FormatNumber(Val(input.Text * (84 / 1000)), 2)

        ElseIf awal.Text = "BRL - (Real Brasil)" And akhir.Text = "KRW - (Won Korea)" Then
            hasil.Text = "₩" & "  " & FormatNumber(Val(input.Text * (28747 / 100)), 2)

        ElseIf awal.Text = "AUD - (Dolar Australia)" And akhir.Text = "KRW - (Won Korea)" Then
            hasil.Text = "₩" & "  " & FormatNumber(Val(input.Text * (80432 / 100)), 2)

        ElseIf awal.Text = "CNY - (Yuan Tiongkok)" And akhir.Text = "KRW - (Won Korea)" Then
            hasil.Text = "₩" & "  " & FormatNumber(Val(input.Text * (16654 / 100)), 2)

        ElseIf awal.Text = "MYR - (Ringgit Malaysia)" And akhir.Text = "KRW - (Won Korea)" Then
            hasil.Text = "₩" & "  " & FormatNumber(Val(input.Text * (28248 / 100)), 2)

        ElseIf awal.Text = "VND - (Vietnam Dong)" And akhir.Text = "KRW - (Won Korea)" Then
            hasil.Text = "₩" & "  " & FormatNumber(Val(input.Text * (51 / 1000)), 2)

        ElseIf awal.Text = "THB - (Thai Baht)" And akhir.Text = "KRW - (Won Korea)" Then
            hasil.Text = "₩" & "  " & FormatNumber(Val(input.Text * (3884 / 100)), 2)



        ElseIf awal.Text = "EUR - (Euro)" And akhir.Text = "EUR - (Euro)" Then
            hasil.Text = "€" & " " & FormatNumber(Val(input.Text), 2)

        ElseIf awal.Text = "JPY - (Yen Jepang)" And akhir.Text = "EUR - (Euro)" Then
            hasil.Text = "€" & " " & FormatNumber(Val(input.Text * (83 / 10000)), 2)

        ElseIf awal.Text = "KRW - (Won Korea)" And akhir.Text = "EUR - (Euro)" Then
            hasil.Text = "€" & " " & FormatNumber(Val(input.Text * (77 / 100000)), 2)

        ElseIf awal.Text = "IDR - (Rupiah Indonesia)" And akhir.Text = "EUR - (Euro)" Then
            hasil.Text = "€" & " " & FormatNumber(Val(input.Text * (64 / 1000000)), 2)

        ElseIf awal.Text = "BRL - (Real Brasil)" And akhir.Text = "EUR - (Euro)" Then
            hasil.Text = "€" & " " & FormatNumber(Val(input.Text * (22 / 100)), 2)

        ElseIf awal.Text = "AUD - (Dolar Australia)" And akhir.Text = "EUR - (Euro)" Then
            hasil.Text = "€" & " " & FormatNumber(Val(input.Text * (62 / 100)), 2)

        ElseIf awal.Text = "CNY - (Yuan Tiongkok)" And akhir.Text = "EUR - (Euro)" Then
            hasil.Text = "€" & " " & FormatNumber(Val(input.Text * (13 / 100)), 2)

        ElseIf awal.Text = "MYR - (Ringgit Malaysia)" And akhir.Text = "EUR - (Euro)" Then
            hasil.Text = "€" & " " & FormatNumber(Val(input.Text * (22 / 100)), 2)

        ElseIf awal.Text = "VND - (Vietnam Dong)" And akhir.Text = "EUR - (Euro)" Then
            hasil.Text = "€" & " " & FormatNumber(Val(input.Text * (39 / 1000000)), 2)

        ElseIf awal.Text = "THB - (Thai Baht)" And akhir.Text = "EUR - (Euro)" Then
            hasil.Text = "€" & " " & FormatNumber(Val(input.Text / (3332 / 100)), 2)



        ElseIf awal.Text = "IDR - (Rupiah Indonesia)" And akhir.Text = "IDR - (Rupiah Indonesia)" Then
            hasil.Text = "RP." & " " & FormatCurrency(input.Text)

        ElseIf awal.Text = "JPY - (Yen Jepang)" And akhir.Text = "IDR - (Rupiah Indonesia)" Then
            hasil.Text = "RP. " & " " & FormatCurrency(input.Text * (13026 / 100))

        ElseIf awal.Text = "KRW - (Won Korea)" And akhir.Text = "IDR - (Rupiah Indonesia)" Then
            hasil.Text = "RP." & " " & FormatCurrency(input.Text * (1195 / 100))

        ElseIf awal.Text = "EUR - (Euro)" And akhir.Text = "IDR - (Rupiah Indonesia)" Then
            hasil.Text = "RP." & " " & FormatCurrency(input.Text * (1562473 / 1000))

        ElseIf awal.Text = "BRL - (Real Brasil)" And akhir.Text = "IDR - (Rupiah Indonesia)" Then
            hasil.Text = "RP." & " " & FormatCurrency(input.Text * (343465 / 1000))

        ElseIf awal.Text = "AUD - (Dolar Australia)" And akhir.Text = "IDR - (Rupiah Indonesia)" Then
            hasil.Text = "RP" & " " & FormatCurrency(input.Text * (958735 / 100))

        ElseIf awal.Text = "CNY - (Yuan Tiongkok)" And akhir.Text = "IDR - (Rupiah Indonesia)" Then
            hasil.Text = "RP" & " " & FormatCurrency(input.Text * (199107 / 100))

        ElseIf awal.Text = "MYR - (Ringgit Malaysia)" And akhir.Text = "IDR - (Rupiah Indonesia)" Then
            hasil.Text = "RP. " & " " & FormatCurrency(input.Text * (337545 / 100))

        ElseIf awal.Text = "VND - (Vietnam Dong)" And akhir.Text = "IDR - (Rupiah Indonesia)" Then
            hasil.Text = "RP. " & " " & FormatCurrency(input.Text * (61 / 100))

        ElseIf awal.Text = "THB - (Thai Baht)" And akhir.Text = "IDR - (Rupiah Indonesia)" Then
            hasil.Text = "RP. " & " " & FormatCurrency(input.Text * (46341 / 100))


        ElseIf awal.Text = "BRL - (Real Brasil)" And akhir.Text = "BRL - (Real Brasil)" Then
            hasil.Text = "R$" & " " & FormatNumber(Val(input.Text), 2)

        ElseIf awal.Text = "AUD - (Dolar Australia)" And akhir.Text = "BRL - (Real Brasil)" Then
            hasil.Text = "R$" & " " & FormatNumber(Val(input.Text * (279 / 100)), 2)

        ElseIf awal.Text = "IDR - (Rupiah Indonesia)" And akhir.Text = "BRL - (Real Brasil)" Then
            hasil.Text = "R$" & " " & FormatNumber(Val(input.Text * (29 / 100000)), 2)

        ElseIf awal.Text = "EUR - (Euro)" And akhir.Text = "BRL - (Real Brasil)" Then
            hasil.Text = "R$" & " " & FormatNumber(Val(input.Text * (454 / 100)), 2)

        ElseIf awal.Text = "KRW - (Won Korea)" And akhir.Text = "BRL - (Real Brasil)" Then
            hasil.Text = "R$" & " " & FormatNumber(Val(input.Text * (34 / 10000)), 2)

        ElseIf awal.Text = "JPY - (Yen Jepang)" And akhir.Text = "BRL - (Real Brasil)" Then
            hasil.Text = "R$" & " " & FormatNumber(Val(input.Text * (38 / 1000)), 2)

        ElseIf awal.Text = "CNY - (Yuan Tiongkok)" And akhir.Text = "BRL - (Real Brasil)" Then
            hasil.Text = "R$" & " " & FormatNumber(Val(input.Text * (58 / 100)), 2)

        ElseIf awal.Text = "MYR - (Ringgit Malaysia)" And akhir.Text = "BRL - (Real Brasil)" Then
            hasil.Text = "R$" & " " & FormatNumber(Val(input.Text * (98 / 100)), 2)

        ElseIf awal.Text = "VND - (Vietnam Dong)" And akhir.Text = "BRL - (Real Brasil)" Then
            hasil.Text = "R$" & " " & FormatNumber(Val(input.Text * (18 / 100000)), 2)

        ElseIf awal.Text = "THB - (Thai Baht)" And akhir.Text = "BRL - (Real Brasil)" Then
            hasil.Text = "R$" & " " & FormatNumber(Val(input.Text * (13 / 100)), 2)


        ElseIf awal.Text = "AUD - (Dolar Australia)" And akhir.Text = "AUD - (Dolar Australia)" Then
            hasil.Text = "$" & " " & FormatCurrency(input.Text)

        ElseIf awal.Text = "BRL - (Real Brasil)" And akhir.Text = "AUD - (Dolar Australia)" Then
            hasil.Text = "$" & " " & FormatCurrency(input.Text * (36 / 100))

        ElseIf awal.Text = "IDR - (Rupiah Indonesia)" And akhir.Text = "AUD - (Dolar Australia)" Then
            hasil.Text = "$" & " " & FormatCurrency(input.Text / (959130 / 100))

        ElseIf awal.Text = "EUR - (Euro)" And akhir.Text = "AUD - (Dolar Australia)" Then
            hasil.Text = "$" & " " & FormatCurrency(input.Text * (163 / 100))

        ElseIf awal.Text = "KRW - (Won Korea)" And akhir.Text = "AUD - (Dolar Australia)" Then
            hasil.Text = "$" & " " & FormatCurrency(input.Text * (12 / 10000), )

        ElseIf awal.Text = "JPY - (Yen Jepang)" And akhir.Text = "AUD - (Dolar Australia)" Then
            hasil.Text = "$" & " " & FormatCurrency(input.Text * (14 / 1000))

        ElseIf awal.Text = "CNY - (Yuan Tiongkok)" And akhir.Text = "AUD - (Dolar Australia)" Then
            hasil.Text = "$" & " " & FormatCurrency(akhir.Text * (21 / 100))

        ElseIf awal.Text = "MYR - (Ringgit Malaysia)" And akhir.Text = "AUD - (Dolar Australia)" Then
            hasil.Text = "$" & " " & FormatCurrency(input.Text * (35 / 100))

        ElseIf awal.Text = "VND - (Vietnam Dong)" And akhir.Text = "AUD - (Dolar Australia)" Then
            hasil.Text = "$" & " " & FormatCurrency(input.Text * (63 / 1000000))

        ElseIf awal.Text = "THB - (Thai Baht)" And akhir.Text = "AUD - (Dolar Australia)" Then
            hasil.Text = "$" & " " & FormatCurrency(input.Text * (48 / 1000))


        ElseIf awal.Text = "USD - (Dolar Amerika Serikat)" And akhir.Text = "USD - (Dolar Amerika Serikat)" Then
            hasil.Text = "$" & " " & FormatNumber(Val(input.Text), 2)

        ElseIf awal.Text = "AUD - (Dolar Australia)" And akhir.Text = "USD - (Dolar Amerika Serikat)" Then
            hasil.Text = "$" & " " & FormatNumber(Val(input.Text * (68 / 100)), 2)

        ElseIf awal.Text = "BRL - (Real Brasil)" And akhir.Text = "USD - (Dolar Amerika Serikat)" Then
            hasil.Text = "$" & " " & FormatNumber(Val(input.Text * (25 / 100)), 2)

        ElseIf awal.Text = "IDR - (Rupiah Indonesia)" And akhir.Text = "USD - (Dolar Amerika Serikat)" Then
            hasil.Text = "$" & " " & FormatNumber(Val(input.Text * (71 / 1000000)), 2)

        ElseIf awal.Text = "EUR - (Euro)" And akhir.Text = "USD - (Dolar Amerika Serikat)" Then
            hasil.Text = "$" & " " & FormatNumber(Val(input.Text * (111 / 100)), 2)

        ElseIf awal.Text = "KRW - (Won Korea)" And akhir.Text = "USD - (Dolar Amerika Serikat)" Then
            hasil.Text = "$" & " " & FormatNumber(Val(input.Text * (83 / 100000)), 2)

        ElseIf awal.Text = "JPY - (Yen Jepang)" And akhir.Text = "USD - (Dolar Amerika Serikat)" Then
            hasil.Text = "$" & " " & FormatNumber(Val(input.Text * (93 / 10000)), 2)

        ElseIf awal.Text = "MYR - (Ringgit Malaysia)" And akhir.Text = "USD - (Dolar Amerika Serikat)" Then
            hasil.Text = "$" & " " & FormatNumber(Val(input.Text * (24 / 100)), 2)

        ElseIf awal.Text = "VND - (Vietnam Dong)" And akhir.Text = "USD - (Dolar Amerika Serikat)" Then
            hasil.Text = "$" & " " & FormatNumber(Val(input.Text * (43 / 1000000)), 2)

        ElseIf awal.Text = "THB - (Thai Baht)" And akhir.Text = "USD - (Dolar Amerika Serikat)" Then
            hasil.Text = "$" & " " & FormatNumber(Val(input.Text * (33 / 1000)), 2)


        ElseIf awal.Text = "CNY - (Yuan Tiongkok)" And akhir.Text = "CNY - (Yuan Tiongkok)" Then
            hasil.Text = "¥" & " " & FormatNumber(Val(input.Text), 2)

        ElseIf awal.Text = "USD - (Dolar Amerika Serikat)" And akhir.Text = "CNY - (Yuan Tiongkok)" Then
            hasil.Text = "¥" & " " & FormatNumber(Val(input.Text * (709 / 100)), 2)

        ElseIf awal.Text = "AUD - (Dolar Australia)" And akhir.Text = "CNY - (Yuan Tiongkok)" Then
            hasil.Text = "¥" & " " & FormatNumber(Val(input.Text * (481 / 100)), 2)

        ElseIf awal.Text = "BRL - (Real Brasil)" And akhir.Text = "CNY - (Yuan Tiongkok)" Then
            hasil.Text = "¥" & " " & FormatNumber(Val(input.Text * (175 / 100)), 2)

        ElseIf awal.Text = "IDR - (Rupiah Indonesia)" And akhir.Text = "CNY - (Yuan Tiongkok)" Then
            hasil.Text = "¥" & " " & FormatNumber(Val(input.Text / (198879 / 100)), 2)

        ElseIf awal.Text = "JPY - (Yen Jepang)" And akhir.Text = "CNY - (Yuan Tiongkok)" Then
            hasil.Text = "¥" & " " & FormatNumber(Val(input.Text * (67 / 1000)), 2)

        ElseIf awal.Text = "EUR - (Euro)" And akhir.Text = "CNY - (Yuan Tiongkok)" Then
            hasil.Text = "¥" & " " & FormatNumber(Val(input.Text * (783 / 100)), 2)

        ElseIf awal.Text = "KRW - (Won Korea)" And akhir.Text = "CNY - (Yuan Tiongkok)" Then
            hasil.Text = "¥" & " " & FormatNumber(Val(input.Text / (16785 / 100)), 2)

        ElseIf awal.Text = "MYR - (Ringgit Malaysia)" And akhir.Text = "CNY - (Yuan Tiongkok)" Then
            hasil.Text = "¥" & " " & FormatNumber(Val(input.Text * (170 / 100)), 2)

        ElseIf awal.Text = "VND - (Vietnam Dong)" And akhir.Text = "CNY - (Yuan Tiongkok)" Then
            hasil.Text = "¥" & " " & FormatNumber(Val(input.Text * (31 / 10000)), 2)

        ElseIf awal.Text = "THB - (Thai Baht)" And akhir.Text = "CNY - (Yuan Tiongkok)" Then
            hasil.Text = "¥" & " " & FormatNumber(Val(input.Text * (23 / 100)), 2)



        ElseIf awal.Text = "USD - (Dolar Amerika Serikat)" And akhir.Text = "MYR - (Ringgit Malaysia)" Then
            hasil.Text = "RM" & " " & FormatNumber(Val(input.Text * (420 / 100)), 2)

        ElseIf awal.Text = "AUD - (Dolar Australia)" And akhir.Text = "MYR - (Ringgit Malaysia)" Then
            hasil.Text = "RM" & " " & FormatNumber(Val(input.Text * (283 / 100)), 2)

        ElseIf awal.Text = "BRL - (Real Brasil)" And akhir.Text = "MYR - (Ringgit Malaysia)" Then
            hasil.Text = "RM" & " " & FormatNumber(Val(input.Text * (103 / 100)), 2)

        ElseIf awal.Text = "IDR - (Rupiah Indonesia)" And akhir.Text = "MYR - (Ringgit Malaysia)" Then
            hasil.Text = "RM" & " " & FormatNumber(Val(input.Text / (337540 / 100)), 2)

        ElseIf awal.Text = "EUR - (Euro)" And akhir.Text = "MYR - (Ringgit Malaysia)" Then
            hasil.Text = "RM" & " " & FormatNumber(Val(input.Text * (461 / 100)), 2)

        ElseIf awal.Text = "KRW - (Won Korea)" And akhir.Text = "MYR - (Ringgit Malaysia)" Then
            hasil.Text = "RM" & " " & FormatNumber(Val(input.Text * (35 / 10000)), 2)

        ElseIf awal.Text = "JPY - (Yen Jepang)" And akhir.Text = "MYR - (Ringgit Malaysia)" Then
            hasil.Text = "RM" & " " & FormatNumber(Val(input.Text * (39 / 1000)), 2)

        ElseIf awal.Text = "CNY - (Yuan Tiongkok)" And akhir.Text = "MYR - (Ringgit Malaysia)" Then
            hasil.Text = "RM" & " " & FormatNumber(Val(input.Text * (59 / 100)), 2)

        ElseIf awal.Text = "MYR - (Ringgit Malaysia)" And akhir.Text = "MYR - (Ringgit Malaysia)" Then
            hasil.Text = "RM" & " " & FormatNumber(Val(input.Text * (49 / 100)), 2)

        ElseIf awal.Text = "VND - (Vietnam Dong)" And akhir.Text = "MYR - (Ringgit Malaysia)" Then
            hasil.Text = "RM" & " " & FormatNumber(Val(input.Text * (18 / 100000)), 2)

        ElseIf awal.Text = "THB - (Thai Baht)" And akhir.Text = "MYR - (Ringgit Malaysia)" Then
            hasil.Text = "RM" & " " & FormatNumber(Val(input.Text * (14 / 100)), 2)


        ElseIf awal.Text = "VND - (Vietnam Dong)" And akhir.Text = "VND - (Vietnam Dong)" Then
            hasil.Text = "₫" & " " & FormatNumber(Val(input.Text), 2)

        ElseIf awal.Text = "USD - (Dolar Amerika Serikat)" And akhir.Text = "VND - (Vietnam Dong)" Then
            hasil.Text = "₫" & " " & FormatNumber(Val(input.Text * (2319665 / 100)), 2)

        ElseIf awal.Text = "AUD - (Dolar Australia)" And akhir.Text = "VND - (Vietnam Dong)" Then
            hasil.Text = "₫" & " " & FormatNumber(Val(input.Text * (1576224 / 100)), 2)

        ElseIf awal.Text = "BRL - (Real Brasil)" And akhir.Text = "VND - (Vietnam Dong)" Then
            hasil.Text = "₫" & " " & FormatNumber(Val(input.Text * (564108 / 100)), 2)

        ElseIf awal.Text = "IDR - (Rupiah Indonesia)" And akhir.Text = "VND - (Vietnam Dong)" Then
            hasil.Text = "₫" & " " & FormatNumber(Val(input.Text * (164 / 100)), 2)

        ElseIf awal.Text = "EUR - (Euro)" And akhir.Text = "VND - (Vietnam Dong)" Then
            hasil.Text = "₫" & " " & FormatNumber(Val(input.Text * (2561536 / 10)), 2)

        ElseIf awal.Text = "KRW - (Won Korea)" And akhir.Text = "VND - (Vietnam Dong)" Then
            hasil.Text = "₫" & " " & FormatNumber(Val(input.Text * (1967 / 100)), 2)

        ElseIf awal.Text = "JPY - (Yen Jepang)" And akhir.Text = "VND - (Vietnam Dong)" Then
            hasil.Text = "₫" & " " & FormatNumber(Val(input.Text * (21636 / 100)), 2)

        ElseIf awal.Text = "CNY - (Yuan Tiongkok)" And akhir.Text = "VND - (Vietnam Dong)" Then
            hasil.Text = "₫" & " " & FormatNumber(Val(input.Text * (21376 / 100)), 2)

        ElseIf awal.Text = "MYR - (Ringgit Malaysia)" And akhir.Text = "VND - (Vietnam Dong)" Then
            hasil.Text = "₫" & " " & FormatNumber(Val(input.Text * (553750 / 100)), 2)

        ElseIf awal.Text = "THB - (Thai Baht)" And akhir.Text = "VND - (Vietnam Dong)" Then
            hasil.Text = "₫" & " " & FormatNumber(Val(input.Text * (76155 / 100)), 2)


        ElseIf awal.Text = "THB - (Thai Baht)" And akhir.Text = "THB - (Thai Baht)" Then
            hasil.Text = "฿" & " " & FormatNumber(Val(input.Text), 2)

        ElseIf awal.Text = "USD - (Dolar Amerika Serikat)" And akhir.Text = "THB - (Thai Baht)" Then
            hasil.Text = "฿" & " " & FormatNumber(Val(input.Text * (3046 / 100)), 2)

        ElseIf awal.Text = "AUD - (Dolar Australia)" And akhir.Text = "THB - (Thai Baht)" Then
            hasil.Text = "฿" & " " & FormatNumber(Val(input.Text * (2069 / 100)), 2)

        ElseIf awal.Text = "BRL - (Real Brasil)" And akhir.Text = "THB - (Thai Baht)" Then
            hasil.Text = "฿" & " " & FormatNumber(Val(input.Text * (741 / 100)), 2)

        ElseIf awal.Text = "IDR - (Rupiah Indonesia)" And akhir.Text = "THB - (Thai Baht)" Then
            hasil.Text = "฿" & " " & FormatNumber(Val(input.Text * (22 / 10000)), 2)

        ElseIf awal.Text = "EUR - (Euro)" And akhir.Text = "THB - (Thai Baht)" Then
            hasil.Text = "฿" & " " & FormatNumber(Val(input.Text * (3363 / 100)), 2)

        ElseIf awal.Text = "KRW - (Won Korea)" And akhir.Text = "THB - (Thai Baht)" Then
            hasil.Text = "฿" & " " & FormatNumber(Val(input.Text * (25 / 1000)), 2)

        ElseIf awal.Text = "JPY - (Yen Jepang)" And akhir.Text = "THB - (Thai Baht)" Then
            hasil.Text = "฿" & " " & FormatNumber(Val(input.Text * (28 / 100)), 2)

        ElseIf awal.Text = "CNY - (Yuan Tiongkok)" And akhir.Text = "THB - (Thai Baht)" Then
            hasil.Text = "฿" & " " & FormatNumber(Val(input.Text * (430 / 100)), 2)

        ElseIf awal.Text = "MYR - (Ringgit Malaysia)" And akhir.Text = "THB - (Thai Baht)" Then
            hasil.Text = "฿" & " " & FormatNumber(Val(input.Text * (728 / 100)), 2)

        ElseIf awal.Text = "VND - (Vietnam Dong)" And akhir.Text = "THB - (Thai Baht)" Then
            hasil.Text = "฿" & " " & FormatNumber(Val(input.Text * (13 / 10000)), 2)


        ElseIf MsgBox("MASUKAN SATUAN NILAI", MsgBoxStyle.Information, "INVALID") Then
        End If
    End Sub

    Private Sub MataUang_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Call Combo()
        Me.ResizeRedraw = True
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        input.Text = ""
        hasil.Text = ""
        Me.awal.SelectedItem = Nothing
        Me.akhir.SelectedItem = Nothing

    End Sub

    Private Sub input_KeyDown(sender As Object, e As KeyEventArgs) Handles input.KeyDown
        If e.KeyCode = Keys.Enter Then
            awal.Focus()

        End If
    End Sub

    Private Sub input_KeyPress(sender As Object, e As KeyPressEventArgs) Handles input.KeyPress
        If Not ((e.KeyChar >= "0" And e.KeyChar <= "9") Or e.KeyChar = vbBack) Then e.Handled = True
    End Sub

    Private Sub input_TextChanged(sender As Object, e As EventArgs) Handles input.TextChanged
        If input.Text = "" Or Not IsNumeric(input.Text) Then
            Exit Sub
        End If
        f = input.Text
        input.Text = Format(Val(f), "###,###")
        input.SelectionStart = Len(input.Text)
    End Sub

    Private Sub awal_KeyDown(sender As Object, e As KeyEventArgs) Handles awal.KeyDown
        If e.KeyCode = Keys.Enter Then
            akhir.Focus()
        End If
    End Sub

    Private Sub akhir_KeyDown(sender As Object, e As KeyEventArgs) Handles akhir.KeyDown
        If e.KeyCode = Keys.Enter Then
            Button1.Focus()

        End If
    End Sub

    Private Sub MU_Paint(sender As Object, e As PaintEventArgs) Handles Me.Paint
        Dim d As New System.Drawing.Drawing2D.LinearGradientBrush(Me.ClientRectangle, Color.FromArgb(222, 97, 97), Color.FromArgb(38, 87, 235), Drawing2D.LinearGradientMode.ForwardDiagonal)
        e.Graphics.FillRectangle(d, Me.ClientRectangle)

    End Sub
End Class
