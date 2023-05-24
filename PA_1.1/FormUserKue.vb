Imports MySql.Data.MySqlClient

Public Class FormUserKue
    Public Sub ValidasiAngka(e As KeyPressEventArgs)
        Dim tombol As Integer = Asc(e.KeyChar)
        If Not (((tombol >= 48) And (tombol <= 57)) Or (tombol = 8)) Then
            e.Handled = True
        End If
    End Sub
    Sub aturGridDataKue()
        DataKue.Columns(0).Width = 50
        DataKue.Columns(1).Width = 180
        DataKue.Columns(2).Width = 180
        DataKue.Columns(3).Width = 190

        DataKue.Columns(0).HeaderText = "No"
        DataKue.Columns(1).HeaderText = "Nama Kue"
        DataKue.Columns(2).HeaderText = "Jenis Kue"
        DataKue.Columns(3).HeaderText = "Harga Kue"
    End Sub
    Sub tampilDataKue()
        DA = New MySqlDataAdapter("Select * from tbkue", CONN)
        DS = New DataSet
        DS.Clear()
        DA.Fill(DS, "tbkue")
        DataKue.DataSource = DS.Tables("tbkue")
        DataKue.Refresh()
    End Sub
    Private Sub FormUserKue_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Call connect()
        Call tampilDataKue()
        Call aturGridDataKue()
    End Sub

    Private Sub btnCari_Click(sender As Object, e As EventArgs) Handles btnCari.Click
        CMD = New MySqlCommand("Select * from tbkue where namaKue like '%" & txtCari.Text & "%'", CONN)
        RD = CMD.ExecuteReader
        RD.Read()

        If RD.HasRows Then
            RD.Close()
            DA = New MySqlDataAdapter("Select * from tbkue where namaKue like '%" & txtCari.Text & "%'", CONN)
            DS = New DataSet
            DA.Fill(DS, "Dapat")
            DataKue.DataSource = DS.Tables("Dapat")
        Else
            RD.Close()
            MsgBox("Nama Kue Tidak Ada")
        End If

        Dim kue, jenisKue As String
        Dim no, harga As Integer
        no = DataKue.CurrentRow.Cells(0).Value
        kue = DataKue.CurrentRow.Cells(1).Value
        jenisKue = DataKue.CurrentRow.Cells(2).Value
        harga = DataKue.CurrentRow.Cells(3).Value
    End Sub

    Private Sub txtCari_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtCari.KeyPress
        If e.KeyChar = Chr(13) Then
            CMD = New MySqlCommand("Select * from tbkue where namaKue like '%" & txtCari.Text & "%'", CONN)
            RD = CMD.ExecuteReader
            RD.Read()

            If RD.HasRows Then
                RD.Close()
                DA = New MySqlDataAdapter("Select * from tbkue where namaKue like '%" & txtCari.Text & "%'", CONN)
                DS = New DataSet
                DA.Fill(DS, "Dapat")
                DataKue.DataSource = DS.Tables("Dapat")
            Else
                RD.Close()
                MsgBox("Nama Kue Tidak Ada")
            End If
        End If
    End Sub
    Dim kodePesanan As Integer = 0
    Private Sub DataKue_CellClick(sender As Object, e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DataKue.CellClick
        Try
            Dim index, i, hargaKue, totalHarga, jumlah, idKue As Integer

            kodePesanan += 1
            i = DataKue.CurrentRow.Index
            index = e.RowIndex
            jumlah = 1
            hargaKue = DataKue.Item(3, i).Value
            idKue = DataKue.Item(0, i).Value
            totalHarga = jumlah * hargaKue

            DataPesanan.Rows.Add(kodePesanan, DataKue.Rows(index).Cells(1).Value, jumlah, totalHarga, idKue)
        Catch ex As Exception
            MsgBox("Pilih Menu Yang Ada")
        End Try
    End Sub

    Private Sub DataPesanan_CellEdit(sender As Object, e As DataGridViewCellEventArgs) Handles DataPesanan.CellEndEdit
        Try
            Dim totalHarga, jumlah As Integer
            jumlah = DataPesanan.Rows(e.RowIndex).Cells(2).Value
            totalHarga = DataPesanan.Rows(e.RowIndex).Cells(3).Value
            DataPesanan.Rows(e.RowIndex).Cells(3).Value = jumlah * totalHarga
        Catch ex As Exception
            MsgBox("Masukkan Angka")
        End Try
    End Sub

    Private Sub btnPesan_Click(sender As Object, e As EventArgs) Handles btnPesan.Click
        Try
            If DataPesanan.SelectedRows.Count > -1 Then
                Dim idPesanan As Integer = DataPesanan.Rows(idPesanan).Cells(0).Value.ToString()
                Dim namaKue As String = DataPesanan.CurrentRow.Cells(1).Value
                Dim jumlahPesanan As Integer = Convert.ToInt32(DataPesanan.CurrentRow.Cells(2).Value)
                Dim totalHarga As Integer = Convert.ToInt32(DataPesanan.CurrentRow.Cells(3).Value)
                Dim kueId As Integer = Convert.ToInt32(DataPesanan.CurrentRow.Cells(4).Value)

                'MsgBox("Data pesanan yang dipilih = '" & totalHarga & "'")

                'masukkan nilai ke textbox
                txtHasilPesanan.Text = "Nama Pemesan : " & Form1.NamaUser & vbCrLf &
                           "Nama Kue     : " & namaKue & vbCrLf &
                           "Jumlah Kue   : " & jumlahPesanan & vbCrLf &
                           "-------------------------------------" & vbCrLf &
                           "Total Bayar  : " & totalHarga


                'MsgBox("Nama Kue = " & namaKue & " " & vbCrLf &
                '      "Jumlah   = " & jumlahPesanan & " " & vbCrLf &
                '     "Harga    = " & totalHarga & " " & vbCrLf &
                '    "Id Kue   = " & kueId & " " & vbCrLf &
                '   "Id User  = " & Form1.idUser & " ")

                Try
                    'masukkan data dari datagridview ke database
                    CMD = New MySqlCommand("Select * from tbpesanan where namaKue='" & namaKue & "'", CONN)
                    RD = CMD.ExecuteReader
                    RD.Read()
                    RD.Close()
                    If Not RD.HasRows Then
                        Dim save As String = "Insert into tbpesanan(userId, kueId, namaKue, jumlahPesanan, totalHarga) values
                              ('" & Form1.idUser & "',
                               '" & kueId & "',
                               '" & namaKue & "',
                               '" & jumlahPesanan & "',
                               '" & totalHarga & "')"
                        CMD = New MySqlCommand(save, CONN)
                        CMD.ExecuteNonQuery()
                        MsgBox("Kue Telah Dipesan", MsgBoxStyle.Information, "Perhatian")
                        DataPesanan.Rows.Clear()
                    Else
                        MsgBox("Kue Gagal Dipesan")
                    End If
                Catch ex As Exception
                    MsgBox("Tidak Ada Pesanan Yang Dipilih")
                End Try
            End If
        Catch ex As Exception
            MsgBox("Tidak Ada Pesanan Yang Dipilih")
        End Try

    End Sub

    Private Sub btnHapusPesanan_Click(sender As Object, e As EventArgs) Handles btnHapusPesanan.Click
        DataPesanan.Rows.Clear()
    End Sub

    Private Sub DataPesanan_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataPesanan.CellDoubleClick
        Try
            If MessageBox.Show("Yakin ingin menghapus data Pesanan '" & DataPesanan.CurrentRow.Cells(1).Value.ToString() & "' ?",
                                       "", MessageBoxButtons.YesNo) = Windows.Forms.DialogResult.Yes Then
                Dim pilihRow As Integer = DataPesanan.CurrentRow.Index
                DataPesanan.Rows.RemoveAt(pilihRow)
            End If
        Catch ex As Exception
            MsgBox("Data Pesanan Tidak Ada")
        End Try
    End Sub
End Class