Imports Guna.UI2.Native.WinApi
Imports MySql.Data.MySqlClient

Public Class FormEditProfile
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
    End Sub
    Private Sub btnBack_Click(sender As Object, e As EventArgs) Handles btnBack.Click
        Me.Hide()
    End Sub

    Private Sub btnEdit_Click(sender As Object, e As EventArgs) Handles btnEdit.Click
        Dim namaProfile As String = txtUsername.Text
        Dim phone As String = txtPhone.Text
        Dim email As String = txtEmail.Text
        Dim password As String = txtPassword.Text
        If namaProfile = "" Or
                phone = "" Or
                email = "" Or
                password = "" Then
            MessageBox.Show("Mohon isi Data yang Kosong",
                            "Something Went Wrong", MessageBoxButtons.OK,
                            MessageBoxIcon.Information)
            txtUsername.Focus()
        Else
            Dim telepon As Integer = txtPhone.Text
            Dim ubah As String = "Update tbakun Set username = '" & namaProfile & "',
                                  telepon = '" & telepon & "', 
                                  email = '" & email & "',
                                  password = '" & password & "'
                                  where idUser = '" & Form1.idUser & "'"
            CMD = New MySqlCommand(ubah, CONN)
            CMD.ExecuteNonQuery()
            MessageBox.Show("Data Sudah Diubah", "Informasi", MessageBoxButtons.OK, MessageBoxIcon.Information)
            FormProfile.Refresh()
            Call hapus()
            Me.Hide()
        End If
    End Sub

    Private Sub txtPhone_KeyPress(sender As Object, e As EventArgs) Handles txtPhone.KeyPress
        ValidasiAngka(e)
    End Sub
End Class