Imports MySql.Data.MySqlClient

Public Class userForm
    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        End
    End Sub
    Private Sub btnLogout_Click(sender As Object, e As EventArgs) Handles btnLogout.Click
        Form1.Show()
        Me.Dispose()
    End Sub
    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click
        'Form ketika dibuka tidak tertumpuk
        While Me.panelBody.Controls.Count > 0
            Me.panelBody.Controls(0).Dispose()
        End While

        'buka form
        FormUserKue.TopMost = False
        FormUserKue.AutoSize = False 'With {.TopMost = False, .AutoSize = False}
        FormUserKue.WindowState = FormWindowState.Maximized
        FormUserKue.FormBorderStyle = FormBorderStyle.None
        FormUserKue.TopLevel = False
        FormUserKue.Dock = DockStyle.Fill
        Me.panelBody.Controls.Add(FormUserKue)
        FormUserKue.Show()
    End Sub


    Private Sub btnProfile_Click(sender As Object, e As EventArgs) Handles btnProfile.Click
        'Form ketika dibuka tidak tertumpuk
        While Me.panelBody.Controls.Count > 0
            Me.panelBody.Controls(0).Dispose()
        End While
        'buka form
        FormProfile.TopMost = False
        FormProfile.AutoSize = False 'With {.TopMost = False, .AutoSize = False}
        FormProfile.WindowState = FormWindowState.Maximized
        FormProfile.FormBorderStyle = FormBorderStyle.None
        FormProfile.TopLevel = False
        FormProfile.Dock = DockStyle.Fill
        Me.panelBody.Controls.Add(FormProfile)
        FormProfile.Show()
    End Sub

    Private Sub btnListOrder_Click(sender As Object, e As EventArgs) Handles btnListOrder.Click
        'Form ketika dibuka tidak tertumpuk
        While Me.panelBody.Controls.Count > 0
            Me.panelBody.Controls(0).Dispose()
        End While
        'buka form
        FormPesanan.TopMost = False
        FormPesanan.AutoSize = False 'With {.TopMost = False, .AutoSize = False}
        FormPesanan.WindowState = FormWindowState.Maximized
        FormPesanan.FormBorderStyle = FormBorderStyle.None
        FormPesanan.TopLevel = False
        FormPesanan.Dock = DockStyle.Fill
        Me.panelBody.Controls.Add(FormPesanan)
        FormPesanan.Show()
    End Sub

    Private Sub btnTransaction_Click(sender As Object, e As EventArgs) Handles btnTransaction.Click
        'Form ketika dibuka tidak tertumpuk
        While Me.panelBody.Controls.Count > 0
            Me.panelBody.Controls(0).Dispose()
        End While
        'buka form
        FormTransaksiUser.TopMost = False
        FormTransaksiUser.AutoSize = False 'With {.TopMost = False, .AutoSize = False}
        FormTransaksiUser.WindowState = FormWindowState.Maximized
        FormTransaksiUser.FormBorderStyle = FormBorderStyle.None
        FormTransaksiUser.TopLevel = False
        FormTransaksiUser.Dock = DockStyle.Fill
        Me.panelBody.Controls.Add(FormTransaksiUser)
        FormTransaksiUser.Show()
    End Sub
End Class