Imports System.Web.UI.WebControls
Imports MySql.Data.MySqlClient

Public Class FormPesanan
    Sub aturGridPesanan()
        DataOrderUser.Columns(0).Width = 60
        DataOrderUser.Columns(1).Width = 50
        DataOrderUser.Columns(2).Width = 200
        DataOrderUser.Columns(3).Width = 135
        DataOrderUser.Columns(4).Width = 190

        DataOrderUser.Columns(0).HeaderText = "Kode Pesanan"
        DataOrderUser.Columns(1).HeaderText = "Kode Kue"
        DataOrderUser.Columns(2).HeaderText = "Nama Kue"
        DataOrderUser.Columns(3).HeaderText = "Jumlah Pesanan"
        DataOrderUser.Columns(4).HeaderText = "Total Harga"
    End Sub
    Sub tampilDataPesanan()
        DA = New MySqlDataAdapter("Select idPesanan, kueId, namaKue, jumlahPesanan, totalHarga from tbpesanan where userId = '" & Form1.idUser & "'", CONN)
        DS = New DataSet
        DS.Clear()
        DA.Fill(DS, "tbpesanan")
        DataOrderUser.DataSource = DS.Tables("tbpesanan")
        DataOrderUser.Refresh()
    End Sub
    Private Sub FormPesanan_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Call connect()
        Call tampilDataPesanan()
        Call aturGridPesanan()
    End Sub

    Private Sub btnHapus_Click(sender As Object, e As EventArgs) Handles btnHapus.Click
        Try
            If DataOrderUser.SelectedRows.Count > -1 Then
                If MessageBox.Show("Yakin ingin membatalkan Pesanan '" & DataOrderUser.CurrentRow.Cells(2).Value.ToString() & "' ?",
                           "", MessageBoxButtons.YesNo) = Windows.Forms.DialogResult.Yes Then
                    CMD = New MySqlCommand("Delete from tbpesanan where idPesanan = '" & DataOrderUser.CurrentRow.Cells(0).Value.ToString() & "'", CONN)
                    CMD.ExecuteNonQuery()
                    Call tampilDataPesanan()
                End If
            End If
        Catch ex As Exception
            MsgBox("Tidak Ada Pesanan Yang Dipilih")
        End Try
    End Sub

    Private Sub btnBayar_Click(sender As Object, e As EventArgs) Handles btnBayar.Click
        FormBayarUser.Show()
    End Sub

End Class