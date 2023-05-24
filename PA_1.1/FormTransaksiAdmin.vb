Imports MySql.Data.MySqlClient

Public Class FormTransaksiAdmin
    Sub aturGridTransaksiAdmin()
        DataTransaksiAdmin.Columns(0).Width = 62
        DataTransaksiAdmin.Columns(1).Width = 62
        DataTransaksiAdmin.Columns(2).Width = 62
        DataTransaksiAdmin.Columns(3).Width = 130
        DataTransaksiAdmin.Columns(4).Width = 107
        DataTransaksiAdmin.Columns(5).Width = 107
        DataTransaksiAdmin.Columns(6).Width = 107

        DataTransaksiAdmin.Columns(0).HeaderText = "ID Transaksi"
        DataTransaksiAdmin.Columns(1).HeaderText = "ID Pesanan"
        DataTransaksiAdmin.Columns(2).HeaderText = "Kode Kue"
        DataTransaksiAdmin.Columns(3).HeaderText = "Nama Pelanggan"
        DataTransaksiAdmin.Columns(4).HeaderText = "Nama Kue"
        DataTransaksiAdmin.Columns(5).HeaderText = "Total Harga"
        DataTransaksiAdmin.Columns(6).HeaderText = "Total Bayar"
    End Sub
    Sub tampilDataTransaksiAdmin()
        DA = New MySqlDataAdapter("SELECT tbtransaksi.idTransaksi, tbpesanan.idPesanan, tbpesanan.kueId, tbakun.username, tbkue.namaKue, tbpesanan.totalHarga, tbtransaksi.totalBayar FROM tbkue JOIN tbpesanan ON tbkue.idKue=tbpesanan.kueId JOIN tbtransaksi ON tbpesanan.idPesanan=tbtransaksi.idPesanan JOIN tbakun ON tbtransaksi.idUser = tbakun.idUser", CONN)
        DS = New DataSet
        DS.Clear()
        DA.Fill(DS, "tbtransaksi")
        DataTransaksiAdmin.DataSource = DS.Tables("tbtransaksi")
        DataTransaksiAdmin.Refresh()
    End Sub
    Private Sub FormTransaksiAdmin_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Call connect()
        Call tampilDataTransaksiAdmin()
        Call aturGridTransaksiAdmin()
    End Sub
End Class