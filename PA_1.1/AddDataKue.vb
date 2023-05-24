Imports System.Data.SqlClient
Imports MySql.Data.MySqlClient

Public Class AddDataKue
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

    Private Sub btnSimpan_Click(sender As Object, e As EventArgs) Handles btnSimpan.Click
        Dim namaKue As String = txtNamaKue.Text
        Dim jenisKue As String = comboJenis.Text
        Dim hargaKue As Integer = txtHargaKue.Text
        If namaKue = "" Or
                jenisKue = "" Or
                txtHargaKue.Text = "" Then
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
            'SQL Cek Duplikat
            CMD = New MySqlCommand("Select * from tbkue where namaKue='" & namaKue & "'", CONN)
            RD = CMD.ExecuteReader
            RD.Read()
            If RD.HasRows Then
                MsgBox("Nama Kue Sudah Ada, Cari Yang Lain")
            Else
                RD.Close()
                Dim cbJenis As String = comboJenis.SelectedItem.ToString()
                Dim harga As Integer = txtHargaKue.Text
                'SQL Tambah Data
                CMD = New MySqlCommand("Select * from tbkue where namaKue='" & namaKue & "'", CONN)
                RD = CMD.ExecuteReader
                RD.Read()
                RD.Close()
                If Not RD.HasRows Then
                    Dim save As String = "Insert into tbkue(namaKue, jenisKue, hargaKue) values 
                            ('" & namaKue & "', '" & cbJenis & "', '" & harga & "')"
                    CMD = New MySqlCommand(save, CONN)
                    CMD.ExecuteNonQuery()
                    MsgBox("Data Telah Disimpan", MsgBoxStyle.Information, "Perhatian")

                    'Form ketika dibuka tidak tertumpuk
                    While adminForm.panelBody.Controls.Count > 0
                        adminForm.panelBody.Controls(0).Dispose()
                    End While
                    'buka form
                    readDataKue.TopMost = False
                    readDataKue.AutoSize = False 'With {.TopMost = False, .AutoSize = False}
                    readDataKue.WindowState = FormWindowState.Maximized
                    readDataKue.FormBorderStyle = FormBorderStyle.None
                    readDataKue.TopLevel = False
                    readDataKue.Dock = DockStyle.Fill
                    adminForm.panelBody.Controls.Add(readDataKue)
                    readDataKue.Show()
                End If
                Call hapus()
            End If
        End If
    End Sub

    Private Sub btnHapus_Click(sender As Object, e As EventArgs) Handles btnHapus.Click
        Call hapus()
    End Sub

    Private Sub txtNamaKue_KeyPress(sender As Object, e As EventArgs) Handles txtNamaKue.KeyPress
        ValidasiHuruf(e)
    End Sub

    Private Sub txtHargaKue_KeyPress(sender As Object, e As EventArgs) Handles txtHargaKue.KeyPress
        ValidasiAngka(e)
    End Sub
End Class