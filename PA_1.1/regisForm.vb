Imports MySql.Data.MySqlClient

Public Class regisForm
    Public Sub ValidasiHuruf(e As KeyPressEventArgs)
        Dim tombol As Integer = Asc(e.KeyChar)
        If Not (((tombol >= 65) And (tombol <= 90)) Or ((tombol >= 97) And (tombol <= 122)) Or (tombol = 8) Or (tombol = 32) Or (tombol = 46)) Then
            e.Handled = True
        End If
    End Sub

    Public Sub ValidasiAngka(e As KeyPressEventArgs)
        Dim tombol As Integer = Asc(e.KeyChar)
        If Not (((tombol >= 48) And (tombol <= 57)) Or (tombol = 8)) Then
            e.Handled = True
        End If
    End Sub

    Sub hapus()
        txtUsername.Text = ""
        txtPhone.Text = ""
        txtEmail.Text = ""
        txtPassword.Text = ""
    End Sub
    Private Sub btnLoginBack_Click(sender As Object, e As EventArgs) Handles btnLoginBack.Click
        Form1.Show()
        Me.Hide()
    End Sub

    Private Sub btnCreate_Click(sender As Object, e As EventArgs) Handles btnCreate.Click
        Call connect()
        If txtUsername.Text = "" Or
                txtPhone.Text = "" Or
                txtEmail.Text = "" Or
                txtPassword.Text = "" Then
            MsgBox("Isi Data Yang Kosong")
            txtUsername.Focus()
        Else
            CMD = New MySqlCommand("Select * from tbakun where username ='" & txtUsername.Text & "'", CONN)
            RD = CMD.ExecuteReader
            RD.Read()
            RD.Close()
            If Not RD.HasRows Then
                Dim phone As Integer = txtPhone.Text
                Dim save As String = "insert into tbakun(username,telepon,email,password) values 
                                     ('" & txtUsername.Text & "',
                                      '" & phone & "',
                                      '" & txtEmail.Text & "',
                                      '" & txtPassword.Text & "')"
                CMD = New MySqlCommand(save, CONN)
                CMD.ExecuteNonQuery()
                MsgBox("Data Telah Disimpan", MsgBoxStyle.Information, "Perhatian")
            Else
                MsgBox("Data Gagal Disimpan", MsgBoxStyle.Information, "Perhatian")
            End If
            Call hapus()
            txtUsername.Focus()
        End If
    End Sub

    Private Sub Guna2ControlBox1_Click(sender As Object, e As EventArgs) Handles Guna2ControlBox1.Click
        End
    End Sub

    Private Sub txtPhone_KeyPress(sender As Object, e As EventArgs) Handles txtPhone.KeyPress
        ValidasiAngka(e)
    End Sub

End Class