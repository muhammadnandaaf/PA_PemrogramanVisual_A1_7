Imports MySql.Data.MySqlClient

Public Class readDataKue
    Sub tampilDataKue()
        DA = New MySqlDataAdapter("Select * from tbkue", CONN)
        DS = New DataSet
        DS.Clear()
        DA.Fill(DS, "tbkue")
        DataKue.DataSource = DS.Tables("tbkue")
        DataKue.Refresh()
    End Sub
    Sub aturGrid()
        DataKue.Columns(0).Width = 50
        DataKue.Columns(1).Width = 180
        DataKue.Columns(2).Width = 180
        DataKue.Columns(3).Width = 225

        DataKue.Columns(0).HeaderText = "No"
        DataKue.Columns(1).HeaderText = "Nama Kue"
        DataKue.Columns(2).HeaderText = "Jenis Kue"
        DataKue.Columns(3).HeaderText = "Harga Kue"
    End Sub
    Private Sub readDataKue_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Call connect()
        Call tampilDataKue()
        Call aturGrid()
    End Sub
    'untuk cari tekan tombol
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

        FormTampilKue.lblNamaKue.Text = kue
        FormTampilKue.lblJenisKue.Text = jenisKue
        FormTampilKue.lblHargaKue.Text = harga

        FormTampilKue.Show()
    End Sub
    'untuk cari lgsg enter
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

    Private Sub DataKue_CellDoubleClick(sender As Object, e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DataKue.CellDoubleClick
        Try
            Dim kue, jenisKue As String
            Dim no, harga As Integer
            no = DataKue.CurrentRow.Cells(0).Value
            kue = DataKue.CurrentRow.Cells(1).Value
            jenisKue = DataKue.CurrentRow.Cells(2).Value
            harga = DataKue.CurrentRow.Cells(3).Value

            FormTampilKue.lblNamaKue.Text = kue
            FormTampilKue.lblJenisKue.Text = jenisKue
            FormTampilKue.lblHargaKue.Text = harga
            FormTampilKue.Show()
        Catch ex As Exception
            MsgBox("Pilih Data Yang Tersedia")
        End Try
    End Sub

End Class