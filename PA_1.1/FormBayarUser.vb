Imports MySql.Data.MySqlClient

Public Class FormBayarUser
    Public Sub ValidasiAngka(e As KeyPressEventArgs)
        Dim tombol As Integer = Asc(e.KeyChar)
        If Not (((tombol >= 48) And (tombol <= 57)) Or (tombol = 8)) Then
            e.Handled = True
        End If
    End Sub
    Private Sub btnBayar_Click(sender As Object, e As EventArgs) Handles btnBayar.Click
        Try
            Dim idPesanan As Integer = Convert.ToInt32(FormPesanan.DataOrderUser.CurrentRow.Cells(0).Value)
            Dim totalBayar As Integer = txtBayarKue.Text
            If totalBayar < FormPesanan.DataOrderUser.CurrentRow.Cells(4).Value Then
                MsgBox("Pembayaran Kurang Tolong Dilunaskan" & vbCrLf &
                       "Sebanyak = '" & FormPesanan.DataOrderUser.CurrentRow.Cells(4).Value & "'")
            Else
                Try
                    'masukkan data dari datagridview ke database
                    CMD = New MySqlCommand("Select * from tbtransaksi where totalBayar='" & totalBayar & "'", CONN)
                    RD = CMD.ExecuteReader
                    RD.Read()
                    RD.Close()
                    If Not RD.HasRows Then
                        Dim save As String = "Insert into tbtransaksi (idPesanan, idUser, totalBayar) values
                        ('" & idPesanan & "',
                         '" & Form1.idUser & "',
                         '" & totalBayar & "')"
                        CMD = New MySqlCommand(save, CONN)
                        CMD.ExecuteNonQuery()
                        MsgBox("Pembayaran Berhasil", MsgBoxStyle.Information, "Perhatian")
                        'Form ketika dibuka tidak tertumpuk
                        While userForm.panelBody.Controls.Count > 0
                            userForm.panelBody.Controls(0).Dispose()
                        End While
                        'buka form
                        FormTransaksiUser.TopMost = False
                        FormTransaksiUser.AutoSize = False 'With {.TopMost = False, .AutoSize = False}
                        FormTransaksiUser.WindowState = FormWindowState.Maximized
                        FormTransaksiUser.FormBorderStyle = FormBorderStyle.None
                        FormTransaksiUser.TopLevel = False
                        FormTransaksiUser.Dock = DockStyle.Fill
                        userForm.panelBody.Controls.Add(FormTransaksiUser)
                        FormTransaksiUser.Show()
                    Else
                        MsgBox("Pembayaran Gagal")
                    End If
                Catch ex As Exception
                    MsgBox("Fungsi SQL Gagal Dijalankan")
                End Try
            End If
        Catch ex As Exception
            MsgBox("Isi Data Yang Kosong")
        End Try

    End Sub

    Private Sub btnBack_Click(sender As Object, e As EventArgs) Handles btnBack.Click
        Me.Hide()
    End Sub
    Private Sub txtBayarKue_KeyPress(sender As Object, e As EventArgs) Handles txtBayarKue.KeyPress
        ValidasiAngka(e)
    End Sub

End Class