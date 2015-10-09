Public Class Form1

    Dim pilih As String ' untuk select case
    Dim input As Integer
    Dim angka As String

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        txtTampil.Text = "0"
    End Sub

    Private Sub btn0_Click(sender As Object, e As EventArgs) Handles btn0.Click
        If txtTampil.Text = "0" Then
            angka = "0"
        Else
            angka &= "0"
        End If
        txtTampil.Text = angka
    End Sub

    Private Sub btn1_Click(sender As Object, e As EventArgs) Handles btn1.Click
        If txtTampil.Text = "0" Then
            angka = "1"
        Else
            angka &= "1"
        End If
        txtTampil.Text = angka
    End Sub

    Private Sub btn2_Click(sender As Object, e As EventArgs) Handles btn2.Click
        If txtTampil.Text = "0" Then
            angka = "2"
        Else
            angka &= "2"
        End If
        txtTampil.Text = angka
    End Sub

    Private Sub btn3_Click(sender As Object, e As EventArgs) Handles btn3.Click
        If txtTampil.Text = "0" Then
            angka = "3"
        Else
            angka &= "3"
        End If
        txtTampil.Text = angka
    End Sub

    Private Sub btn4_Click(sender As Object, e As EventArgs) Handles btn4.Click
        If txtTampil.Text = "0" Then
            angka = "4"
        Else
            angka &= "4"
        End If
        txtTampil.Text = angka
    End Sub

    Private Sub btn5_Click(sender As Object, e As EventArgs) Handles btn5.Click
        If txtTampil.Text = "0" Then
            angka = "5"
        Else
            angka &= "5"
        End If
        txtTampil.Text = angka
    End Sub

    Private Sub btn6_Click(sender As Object, e As EventArgs) Handles btn6.Click
        If txtTampil.Text = "0" Then
            angka = "6"
        Else
            angka &= "6"
        End If
        txtTampil.Text = angka
    End Sub

    Private Sub btn7_Click(sender As Object, e As EventArgs) Handles btn7.Click
        If txtTampil.Text = "0" Then
            angka = "7"
        Else
            angka &= "7"
        End If
        txtTampil.Text = angka
    End Sub

    Private Sub btn8_Click(sender As Object, e As EventArgs) Handles btn8.Click
        If txtTampil.Text = "0" Then
            angka = "8"
        Else
            angka &= "8"
        End If
        txtTampil.Text = angka
    End Sub

    Private Sub btn9_Click(sender As Object, e As EventArgs) Handles btn9.Click
        If txtTampil.Text = "0" Then
            angka = "9"
        Else
            angka &= "9"
        End If
        txtTampil.Text = angka
    End Sub

    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        txtTampil.Text = "0"
        angka = Nothing
        Me.input = 0
    End Sub

    Private Sub btnSamaDengan_Click(sender As Object, e As EventArgs) Handles btnSamaDengan.Click
        Select Case Me.pilih
            Case "-"
                txtTampil.Text = Convert.ToString(Me.input - Convert.ToInt32(txtTampil.Text))
            Case "+"
                txtTampil.Text = Convert.ToString(Me.input + Convert.ToInt32(txtTampil.Text))
        End Select
        Me.input = 0 'meriset variabel input menjadi 0
        'Convert.ToInt32(txtTampil.Text) : angka terakhir setelah kita menekan =
    End Sub

    Private Sub btnKurang_Click(sender As Object, e As EventArgs) Handles btnKurang.Click
        Me.pilih = "-"
        If (Me.input = 0) Then
            Me.input += Convert.ToInt32(txtTampil.Text)
        Else
            Me.input -= Convert.ToInt32(txtTampil.Text)
        End If
        txtTampil.Text = Convert.ToString(Me.input)
        angka = Nothing

        'If (Me.input = 0) Then
        'Me.input += Convert.ToInt32(txtTampil.Text)
        'Jika tidak ada ini, aksi yg di lakukan penambahan
        'contoh : 0-1-2 = -3 , yg tepat 0+1-2 = -1
    End Sub

    Private Sub btnJumlah_Click(sender As Object, e As EventArgs) Handles btnJumlah.Click
        Me.pilih = "+"
        Me.input += Convert.ToInt32(txtTampil.Text)
        txtTampil.Text = Convert.ToString(Me.input)
        angka = Nothing
    End Sub

    'Me.input += Convert.ToInt32(txtTampil.Text) atau 
    'Me.input -= Convert.ToInt32(txtTampil.Text)
    'menjumlah atau mengurangi angka ketika menekan - atau + (belum menekan =)
End Class
