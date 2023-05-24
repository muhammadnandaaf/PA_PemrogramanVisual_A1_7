Imports MySql.Data.MySqlClient

Public Class FormTampilKue
    Private Sub btnBack_Click(sender As Object, e As EventArgs) Handles btnBack.Click
        Me.Hide()
    End Sub

    Private Sub btnEdit_Click(sender As Object, e As EventArgs) Handles btnEdit.Click
        Me.Hide()
        FormEditDataKue.Show()
    End Sub

    Private Sub btnDelete_Click(sender As Object, e As EventArgs) Handles btnDelete.Click
        Try
            If MessageBox.Show("Yakin ingin menghapus data Kue '" & readDataKue.DataKue.CurrentRow.Cells(1).Value.ToString() & "' ?",
                           "", MessageBoxButtons.YesNo) = Windows.Forms.DialogResult.Yes Then
                CMD = New MySqlCommand("Delete from tbkue where idKue = '" & readDataKue.DataKue.CurrentRow.Cells(0).Value.ToString() & "'", CONN)
                CMD.ExecuteNonQuery()
                Me.Hide()
                Call readDataKue.tampilDataKue()
            End If
        Catch ex As Exception
            MsgBox("Data Kue ini Dipesan Oleh Pelanggan" & vbCrLf &
                   "Tidak dapat Dihapus")
        End Try
    End Sub




End Class