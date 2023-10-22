Public Class home
    Private Sub Button1_Click_1(sender As Object, e As EventArgs) Handles Button1.Click
        satuanpanjang.Show()
        Me.Close()

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        SatuanMassa.Show()
        Me.Close()
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        SatuanWaktu.Show()
        Me.Close()

    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        SatuanDaya.Show()
        Me.Close()

    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        SatuanSuhu.Show()
        Me.Close()

    End Sub

    Private Sub Button14_Click(sender As Object, e As EventArgs) Handles Button14.Click
        UNITCONVERTERS.Show()
        Me.Hide()

    End Sub

    Private Sub Button15_Click(sender As Object, e As EventArgs) Handles Button15.Click
        SatuanFrekuensi.Show()
        Me.Hide()
    End Sub

    Private Sub Button16_Click(sender As Object, e As EventArgs)
        SatuanTekanan.Show()
        Me.Hide()

    End Sub

    Private Sub Button16_Click_1(sender As Object, e As EventArgs) Handles Button16.Click
        SatuanTekanan.Show()
        Me.Hide()

    End Sub

    Private Sub Button10_Click(sender As Object, e As EventArgs) Handles Button10.Click
        LuasMeterPersegi.Show()
        Me.Close()

    End Sub

    Private Sub Button13_Click(sender As Object, e As EventArgs) Handles Button13.Click
        VolumeMetrKubik.Show()
        Me.Close()

    End Sub

    Private Sub Button12_Click(sender As Object, e As EventArgs) Handles Button12.Click
        VL.Show()
        Me.Close()

    End Sub

    Private Sub Button11_Click(sender As Object, e As EventArgs) Handles Button11.Click
        SatuanLuasHektare.Show()
        Me.Close()

    End Sub

    Private Sub Button17_Click(sender As Object, e As EventArgs) Handles Button17.Click
        SatuanEnergi.Show()
        Me.Close()

    End Sub

    Private Sub Button18_Click(sender As Object, e As EventArgs) Handles Button18.Click
        SatuanKecepatan.Show()
        Me.Close()
    End Sub

    Private Sub Button19_Click(sender As Object, e As EventArgs)
        SistemBilangan.Show()
        Me.Close()

    End Sub

    Private Sub Button20_Click(sender As Object, e As EventArgs) Handles Button20.Click
        MU.Show()
        Me.Close()

    End Sub

    Private Sub Button21_Click(sender As Object, e As EventArgs) Handles Button21.Click
        DigitalImageResolution.Show()
        Me.Close()

    End Sub

    

    Private Sub Button23_Click(sender As Object, e As EventArgs) Handles Button23.Click
        SistemBilangan.Show()
        Me.Close()

    End Sub

    Private Sub home_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.ResizeRedraw = True

    End Sub

    Private Sub home_Paint(sender As Object, e As PaintEventArgs) Handles Me.Paint
        Dim d As New System.Drawing.Drawing2D.LinearGradientBrush(Me.ClientRectangle, Color.FromArgb(251, 194, 235), Color.FromArgb(166, 193, 238), Drawing2D.LinearGradientMode.Horizontal)
        e.Graphics.FillRectangle(d, Me.ClientRectangle)
    End Sub

    Private Sub Button9_Click(sender As Object, e As EventArgs) Handles Button9.Click

    End Sub
    Private Sub Button8_Click(sender As Object, e As EventArgs) Handles Button8.Click

    End Sub
    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click

    End Sub
    Private Sub Button7_Click(sender As Object, e As EventArgs) Handles Button7.Click

    End Sub
    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click

    End Sub
    Private Sub Label2_Click(sender As Object, e As EventArgs) Handles Label2.Click

    End Sub
End Class