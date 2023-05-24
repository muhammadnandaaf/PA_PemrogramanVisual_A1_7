Imports Microsoft.VisualBasic.ApplicationServices
Imports System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel
Imports MySql.Data.MySqlClient
Imports System.Web.UI.WebControls

Public Class FormProfile
    Sub tampilProfile()
        DA = New MySqlDataAdapter("Select * from tbakun where idUser = '" & Form1.idUser & "' ", CONN)
        DS = New DataSet
        DS.Clear()
        DA.Fill(DS, "tbakun")
        lblUsername.Refresh()
        lblPhone.Refresh()
        lblEmail.Refresh()
        Me.Refresh()
    End Sub
    Private Sub FormProfile_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Call connect()
        Me.Refresh()
        'SQL CEK PROFILE
        CMD = New MySqlCommand("Select * from tbakun where idUser = '" & Form1.idUser & "' ", CONN)
        RD = CMD.ExecuteReader
        RD.Read()
        If RD.HasRows Then
            lblUsername.Text = RD("username")
            lblPhone.Text = RD("telepon")
            lblEmail.Text = RD("email")
            lblidUser.Text = Form1.idUser
            RD.Close()
        Else
            MsgBox("Gagal Ini Atau Gada nama nya")
        End If

    End Sub

    Private Sub btnEdit_Click(sender As Object, e As EventArgs) Handles btnEdit.Click
        FormEditProfile.Show()
    End Sub
End Class