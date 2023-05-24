Imports MySql.Data.MySqlClient

Public Class FormTransaksiUser
    Sub aturGridTransaksiUser()
        DataTransaksiUser.Columns(0).Width = 60
        DataTransaksiUser.Columns(1).Width = 60
        DataTransaksiUser.Columns(2).Width = 60
        DataTransaksiUser.Columns(3).Width = 155
        DataTransaksiUser.Columns(4).Width = 150
        DataTransaksiUser.Columns(5).Width = 150

        DataTransaksiUser.Columns(0).HeaderText = "ID Transaksi"
        DataTransaksiUser.Columns(1).HeaderText = "ID Pesanan"
        DataTransaksiUser.Columns(2).HeaderText = "Kode Kue"
        DataTransaksiUser.Columns(3).HeaderText = "Nama Kue"
        DataTransaksiUser.Columns(4).HeaderText = "Total Harga"
        DataTransaksiUser.Columns(5).HeaderText = "Total Bayar"
    End Sub
    Sub tampilDataTransaksiUser()
        DA = New MySqlDataAdapter("SELECT tbtransaksi.idTransaksi, tbpesanan.kueId, tbpesanan.idPesanan, tbkue.namaKue, tbpesanan.totalHarga, tbtransaksi.totalBayar FROM tbkue JOIN tbpesanan ON tbkue.idKue=tbpesanan.kueId JOIN tbtransaksi ON tbpesanan.idPesanan=tbtransaksi.idPesanan WHERE tbtransaksi.idUser = '" & Form1.idUser & "'", CONN)
        DS = New DataSet
        DS.Clear()
        DA.Fill(DS, "tbtransaksi")
        DataTransaksiUser.DataSource = DS.Tables("tbtransaksi")
        DataTransaksiUser.Refresh()
    End Sub
    Private Sub FormTransaksiUser_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Call connect()
        Call tampilDataTransaksiUser()
        Call aturGridTransaksiUser()
    End Sub

End Class