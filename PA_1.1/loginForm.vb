Imports Guna.UI2.WinForms
Imports MySql.Data.MySqlClient

Public Class Form1
    Private Sub btnRegis_Click(sender As Object, e As EventArgs) Handles btnRegis.Click
        regisForm.Show()
        Me.Hide()
    End Sub

    Public Property idUser As Integer
    Public Property NamaUser As String
    Private Sub btnLogin_Click(sender As Object, e As EventArgs) Handles btnLogin.Click
        Dim username As String = txtUsername.Text
        Dim password As String = txtPassword.Text
        If username = "admin" And password = "admin123" Then
            Me.Visible = False
            txtUsername.Text = ""
            txtPassword.Text = ""
            adminForm.Show()
        Else
            Call connect()
            CMD = New MySqlCommand("Select * From tbakun where username='" & username & "' and password='" & password & "'", CONN)
            RD = CMD.ExecuteReader
            RD.Read()
            If RD.HasRows Then
                idUser = RD("idUser")
                NamaUser = RD("username")
                Me.Visible = False
                userForm.lblUser.Text = username
                txtUsername.Text = ""
                txtPassword.Text = ""
                userForm.Show()
            ElseIf Not RD.HasRows Then
                RD.Close()
                MessageBox.Show("Periksa kembali username dan password", "PERINGATAN", MessageBoxButtons.OK, MessageBoxIcon.Error)
                txtUsername.Focus()
                txtUsername.Text = ""
                txtPassword.Text = ""
            End If
        End If
    End Sub

    Private Sub Guna2ControlBox1_Click(sender As Object, e As EventArgs) Handles Guna2ControlBox1.Click
        End
    End Sub
End Class
