Imports System.Data.Common
Imports MySql.Data.MySqlClient

Public Class adminForm
    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click
        'Form ketika dibuka tidak tertumpuk
        While Me.panelBody.Controls.Count > 0
            Me.panelBody.Controls(0).Dispose()
        End While
        'buka form
        readDataKue.TopMost = False
        readDataKue.AutoSize = False 'With {.TopMost = False, .AutoSize = False}
        readDataKue.WindowState = FormWindowState.Maximized
        readDataKue.FormBorderStyle = FormBorderStyle.None
        readDataKue.TopLevel = False
        readDataKue.Dock = DockStyle.Fill
        Me.panelBody.Controls.Add(readDataKue)
        readDataKue.Show()
    End Sub

    Private Sub btnAddKue_Click(sender As Object, e As EventArgs) Handles btnAddKue.Click
        'form ketika dibuka tidak tertumpuk
        While Me.panelBody.Controls.Count > 0
            Me.panelBody.Controls(0).Dispose()
        End While
        'buka form
        Dim openFrame As New AddDataKue With {.TopMost = False, .AutoSize = False}
        openFrame.WindowState = FormWindowState.Maximized
        openFrame.FormBorderStyle = FormBorderStyle.None
        openFrame.TopLevel = False
        openFrame.Dock = DockStyle.Fill
        Me.panelBody.Controls.Add(openFrame)
        openFrame.Show()
    End Sub

    Private Sub btnLogout_Click(sender As Object, e As EventArgs) Handles btnLogout.Click
        Form1.Show()
        Me.Dispose()
    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        End
    End Sub

    Private Sub btnListOrder_Click(sender As Object, e As EventArgs) Handles btnListOrder.Click
        'Form ketika dibuka tidak tertumpuk
        While Me.panelBody.Controls.Count > 0
            Me.panelBody.Controls(0).Dispose()
        End While
        'buka form
        FormAdminOrder.TopMost = False
        FormAdminOrder.AutoSize = False 'With {.TopMost = False, .AutoSize = False}
        FormAdminOrder.WindowState = FormWindowState.Maximized
        FormAdminOrder.FormBorderStyle = FormBorderStyle.None
        FormAdminOrder.TopLevel = False
        FormAdminOrder.Dock = DockStyle.Fill
        Me.panelBody.Controls.Add(FormAdminOrder)
        FormAdminOrder.Show()
    End Sub

    Private Sub btnTransaction_Click(sender As Object, e As EventArgs) Handles btnTransaction.Click
        'Form ketika dibuka tidak tertumpuk
        While Me.panelBody.Controls.Count > 0
            Me.panelBody.Controls(0).Dispose()
        End While
        'buka form
        FormTransaksiAdmin.TopMost = False
        FormTransaksiAdmin.AutoSize = False 'With {.TopMost = False, .AutoSize = False}
        FormTransaksiAdmin.WindowState = FormWindowState.Maximized
        FormTransaksiAdmin.FormBorderStyle = FormBorderStyle.None
        FormTransaksiAdmin.TopLevel = False
        FormTransaksiAdmin.Dock = DockStyle.Fill
        Me.panelBody.Controls.Add(FormTransaksiAdmin)
        FormTransaksiAdmin.Show()
    End Sub
End Class