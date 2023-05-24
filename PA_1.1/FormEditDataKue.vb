Imports MySql.Data.MySqlClient

Public Class FormEditDataKue
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
        txtNamaKue.Text = ""
        comboJenis.SelectedIndex = -1
        txtHargaKue.Text = ""
        txtNamaKue.Focus()
    End Sub
    Private Sub btnEdit_Click(sender As Object, e As EventArgs) Handles btnEdit.Click
        Dim namaKue As String = txtNamaKue.Text
        Dim jenisKue As String = comboJenis.Text
        Dim hargaKue As String = txtHargaKue.Text
        If namaKue = "" Or
                jenisKue = "" Or
                hargaKue = "" Then
            MessageBox.Show("Mohon isi Data yang Kosong",
                            "Something Went Wrong", MessageBoxButtons.OK,
                            MessageBoxIcon.Information)
            txtNamaKue.Focus()
        ElseIf hargaKue <= 0 Then
            MessageBox.Show("Makanan tidak gratis, Mohon isi Data yang Benar",
                            "Something Went Wrong", MessageBoxButtons.OK,
                            MessageBoxIcon.Information)
            txtNamaKue.Focus()
        Else
            connect()
            CMD = New MySqlCommand("Select * from tbkue where namaKue='" & namaKue & "'", CONN)
            RD = CMD.ExecuteReader
            RD.Read()
            RD.Close()
            If RD.HasRows Then
                MsgBox("Nama Kue Sudah Ada, Cari Yang Lain")
            Else
                Dim cbJenis As String = comboJenis.SelectedItem.ToString()
                Dim harga As Integer = txtHargaKue.Text
                Dim ubah As String = "Update tbkue set namaKue = '" & namaKue & "',
                                  jenisKue = '" & cbJenis & "', 
                                  hargaKue = '" & harga & "'
                                  where idKue = '" & readDataKue.DataKue.CurrentRow.Cells(0).Value.ToString() & "'"
                CMD = New MySqlCommand(ubah, CONN)
                CMD.ExecuteNonQuery()
                MessageBox.Show("Data Sudah Diubah", "Informasi", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Call readDataKue.tampilDataKue()
                Call hapus()
                Me.Hide()
            End If
        End If
    End Sub

    Private Sub btnBack_Click(sender As Object, e As EventArgs) Handles btnBack.Click
        FormTampilKue.Show()
        Me.Hide()
    End Sub

    Private Sub btnHome_Click(sender As Object, e As EventArgs) Handles btnHome.Click
        Me.Hide()
    End Sub

    Private Sub txtNamaKue_KeyPress(sender As Object, e As EventArgs) Handles txtNamaKue.KeyPress
        ValidasiHuruf(e)
    End Sub

    Private Sub txtHargaKue_KeyPress(sender As Object, e As EventArgs) Handles txtHargaKue.KeyPress
        ValidasiAngka(e)
    End Sub
End Class