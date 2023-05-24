<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormUserKue
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.DataKue = New System.Windows.Forms.DataGridView()
        Me.DataPesanan = New System.Windows.Forms.DataGridView()
        Me.No = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Pesanan = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.jumlah = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.totalHarga = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.idKue = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.btnPesan = New Guna.UI2.WinForms.Guna2Button()
        Me.txtCari = New Guna.UI2.WinForms.Guna2TextBox()
        Me.btnCari = New Guna.UI2.WinForms.Guna2Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtHasilPesanan = New Guna.UI2.WinForms.Guna2TextBox()
        Me.btnHapusPesanan = New Guna.UI2.WinForms.Guna2Button()
        CType(Me.DataKue, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataPesanan, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'DataKue
        '
        Me.DataKue.BackgroundColor = System.Drawing.Color.White
        Me.DataKue.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataKue.GridColor = System.Drawing.Color.Black
        Me.DataKue.Location = New System.Drawing.Point(1, 42)
        Me.DataKue.Name = "DataKue"
        Me.DataKue.ReadOnly = True
        Me.DataKue.RowHeadersVisible = False
        Me.DataKue.RowHeadersWidth = 51
        Me.DataKue.RowTemplate.Height = 24
        Me.DataKue.Size = New System.Drawing.Size(620, 137)
        Me.DataKue.TabIndex = 2
        '
        'DataPesanan
        '
        Me.DataPesanan.BackgroundColor = System.Drawing.Color.White
        Me.DataPesanan.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataPesanan.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.No, Me.Pesanan, Me.jumlah, Me.totalHarga, Me.idKue})
        Me.DataPesanan.GridColor = System.Drawing.Color.Black
        Me.DataPesanan.Location = New System.Drawing.Point(1, 215)
        Me.DataPesanan.Name = "DataPesanan"
        Me.DataPesanan.RowHeadersVisible = False
        Me.DataPesanan.RowHeadersWidth = 51
        Me.DataPesanan.RowTemplate.Height = 24
        Me.DataPesanan.Size = New System.Drawing.Size(378, 225)
        Me.DataPesanan.TabIndex = 3
        '
        'No
        '
        Me.No.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None
        Me.No.HeaderText = "No"
        Me.No.MinimumWidth = 6
        Me.No.Name = "No"
        Me.No.ReadOnly = True
        Me.No.Width = 70
        '
        'Pesanan
        '
        Me.Pesanan.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None
        Me.Pesanan.HeaderText = "Pesanan"
        Me.Pesanan.MinimumWidth = 6
        Me.Pesanan.Name = "Pesanan"
        Me.Pesanan.ReadOnly = True
        Me.Pesanan.Width = 120
        '
        'jumlah
        '
        Me.jumlah.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None
        Me.jumlah.HeaderText = "Jumlah"
        Me.jumlah.MinimumWidth = 6
        Me.jumlah.Name = "jumlah"
        Me.jumlah.Width = 60
        '
        'totalHarga
        '
        Me.totalHarga.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None
        Me.totalHarga.HeaderText = "Total Harga"
        Me.totalHarga.MinimumWidth = 6
        Me.totalHarga.Name = "totalHarga"
        Me.totalHarga.ReadOnly = True
        Me.totalHarga.Width = 125
        '
        'idKue
        '
        Me.idKue.HeaderText = "Id Kue"
        Me.idKue.MinimumWidth = 6
        Me.idKue.Name = "idKue"
        Me.idKue.ReadOnly = True
        Me.idKue.Visible = False
        Me.idKue.Width = 125
        '
        'btnPesan
        '
        Me.btnPesan.Animated = True
        Me.btnPesan.BorderRadius = 15
        Me.btnPesan.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.btnPesan.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.btnPesan.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.btnPesan.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.btnPesan.FillColor = System.Drawing.Color.FromArgb(CType(CType(34, Byte), Integer), CType(CType(153, Byte), Integer), CType(CType(84, Byte), Integer))
        Me.btnPesan.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold)
        Me.btnPesan.ForeColor = System.Drawing.Color.White
        Me.btnPesan.Location = New System.Drawing.Point(392, 345)
        Me.btnPesan.Name = "btnPesan"
        Me.btnPesan.Size = New System.Drawing.Size(229, 45)
        Me.btnPesan.TabIndex = 5
        Me.btnPesan.Text = "Pesan"
        '
        'txtCari
        '
        Me.txtCari.BorderRadius = 15
        Me.txtCari.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtCari.DefaultText = ""
        Me.txtCari.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.txtCari.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.txtCari.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtCari.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtCari.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtCari.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.txtCari.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtCari.Location = New System.Drawing.Point(294, 5)
        Me.txtCari.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.txtCari.Name = "txtCari"
        Me.txtCari.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtCari.PlaceholderText = "Cari nama Kue"
        Me.txtCari.SelectedText = ""
        Me.txtCari.Size = New System.Drawing.Size(229, 30)
        Me.txtCari.TabIndex = 6
        '
        'btnCari
        '
        Me.btnCari.Animated = True
        Me.btnCari.BorderRadius = 15
        Me.btnCari.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.btnCari.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.btnCari.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.btnCari.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.btnCari.FillColor = System.Drawing.Color.FromArgb(CType(CType(34, Byte), Integer), CType(CType(153, Byte), Integer), CType(CType(84, Byte), Integer))
        Me.btnCari.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold)
        Me.btnCari.ForeColor = System.Drawing.Color.White
        Me.btnCari.Location = New System.Drawing.Point(529, 6)
        Me.btnCari.Name = "btnCari"
        Me.btnCari.Size = New System.Drawing.Size(92, 30)
        Me.btnCari.TabIndex = 7
        Me.btnCari.Text = "Cari"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Segoe UI Semibold", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(12, 187)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(65, 20)
        Me.Label1.TabIndex = 8
        Me.Label1.Text = "Pesanan"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Segoe UI Semibold", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(12, 15)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(49, 20)
        Me.Label2.TabIndex = 9
        Me.Label2.Text = "Menu"
        '
        'txtHasilPesanan
        '
        Me.txtHasilPesanan.BorderRadius = 15
        Me.txtHasilPesanan.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtHasilPesanan.DefaultText = ""
        Me.txtHasilPesanan.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.txtHasilPesanan.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.txtHasilPesanan.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtHasilPesanan.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtHasilPesanan.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtHasilPesanan.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.txtHasilPesanan.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtHasilPesanan.Location = New System.Drawing.Point(392, 215)
        Me.txtHasilPesanan.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.txtHasilPesanan.Multiline = True
        Me.txtHasilPesanan.Name = "txtHasilPesanan"
        Me.txtHasilPesanan.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtHasilPesanan.PlaceholderText = ""
        Me.txtHasilPesanan.ReadOnly = True
        Me.txtHasilPesanan.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.txtHasilPesanan.SelectedText = ""
        Me.txtHasilPesanan.Size = New System.Drawing.Size(229, 123)
        Me.txtHasilPesanan.TabIndex = 10
        '
        'btnHapusPesanan
        '
        Me.btnHapusPesanan.Animated = True
        Me.btnHapusPesanan.BorderRadius = 15
        Me.btnHapusPesanan.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.btnHapusPesanan.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.btnHapusPesanan.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.btnHapusPesanan.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.btnHapusPesanan.FillColor = System.Drawing.Color.FromArgb(CType(CType(34, Byte), Integer), CType(CType(153, Byte), Integer), CType(CType(84, Byte), Integer))
        Me.btnHapusPesanan.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold)
        Me.btnHapusPesanan.ForeColor = System.Drawing.Color.White
        Me.btnHapusPesanan.Location = New System.Drawing.Point(392, 395)
        Me.btnHapusPesanan.Name = "btnHapusPesanan"
        Me.btnHapusPesanan.Size = New System.Drawing.Size(229, 45)
        Me.btnHapusPesanan.TabIndex = 11
        Me.btnHapusPesanan.Text = "Hapus Pesanan"
        '
        'FormUserKue
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(622, 440)
        Me.Controls.Add(Me.btnHapusPesanan)
        Me.Controls.Add(Me.txtHasilPesanan)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.btnCari)
        Me.Controls.Add(Me.txtCari)
        Me.Controls.Add(Me.btnPesan)
        Me.Controls.Add(Me.DataPesanan)
        Me.Controls.Add(Me.DataKue)
        Me.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.Name = "FormUserKue"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "FormUserKue"
        CType(Me.DataKue, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataPesanan, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents DataKue As DataGridView
    Friend WithEvents DataPesanan As DataGridView
    Friend WithEvents btnPesan As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents txtCari As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents btnCari As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents txtHasilPesanan As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents btnHapusPesanan As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents No As DataGridViewTextBoxColumn
    Friend WithEvents Pesanan As DataGridViewTextBoxColumn
    Friend WithEvents jumlah As DataGridViewTextBoxColumn
    Friend WithEvents totalHarga As DataGridViewTextBoxColumn
    Friend WithEvents idKue As DataGridViewTextBoxColumn
End Class
