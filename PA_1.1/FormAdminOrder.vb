Imports MySql.Data.MySqlClient

Public Class FormAdminOrder
    Sub aturGridOrder()
        DataOrder.Columns(0).Width = 60
        DataOrder.Columns(1).Width = 50
        DataOrder.Columns(2).Width = 160
        DataOrder.Columns(3).Width = 180
        DataOrder.Columns(4).Width = 60
        DataOrder.Columns(5).Width = 125

        DataOrder.Columns(0).HeaderText = "Kode Pesanan"
        DataOrder.Columns(1).HeaderText = "Kode Kue"
        DataOrder.Columns(2).HeaderText = "Pelanggan"
        DataOrder.Columns(3).HeaderText = "Nama Kue"
        DataOrder.Columns(4).HeaderText = "Jumlah Order"
        DataOrder.Columns(5).HeaderText = "Total Harga"
    End Sub
    Sub tampilDataOrder()
        DA = New MySqlDataAdapter("Select tbpesanan.idPesanan, tbpesanan.kueId, tbakun.username, tbpesanan.namaKue, tbpesanan.jumlahPesanan, tbpesanan.totalHarga from tbpesanan inner join tbakun on tbpesanan.userId = tbakun.idUser ", CONN)
        DS = New DataSet
        DS.Clear()
        DA.Fill(DS, "DataOrder")
        DataOrder.DataSource = DS.Tables("DataOrder")
        DataOrder.Refresh()
    End Sub
    Private Sub FormAdminOrder_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Call connect()
        Call tampilDataOrder()
        Call aturGridOrder()
    End Sub

End Class