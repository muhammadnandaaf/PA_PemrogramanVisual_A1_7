<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class AddDataKue
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Me.TimerReduce = New System.Windows.Forms.Timer(Me.components)
        Me.TimerIncrease = New System.Windows.Forms.Timer(Me.components)
        Me.txtNamaKue = New Guna.UI2.WinForms.Guna2TextBox()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtHargaKue = New Guna.UI2.WinForms.Guna2TextBox()
        Me.comboJenis = New Guna.UI2.WinForms.Guna2ComboBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.btnSimpan = New Guna.UI2.WinForms.Guna2Button()
        Me.btnHapus = New Guna.UI2.WinForms.Guna2Button()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'TimerReduce
        '
        Me.TimerReduce.Interval = 10
        '
        'TimerIncrease
        '
        Me.TimerIncrease.Interval = 10
        '
        'txtNamaKue
        '
        Me.txtNamaKue.BorderColor = System.Drawing.Color.Black
        Me.txtNamaKue.BorderRadius = 15
        Me.txtNamaKue.BorderThickness = 2
        Me.txtNamaKue.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtNamaKue.DefaultText = ""
        Me.txtNamaKue.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.txtNamaKue.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.txtNamaKue.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtNamaKue.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtNamaKue.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtNamaKue.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.txtNamaKue.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtNamaKue.Location = New System.Drawing.Point(194, 65)
        Me.txtNamaKue.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.txtNamaKue.Name = "txtNamaKue"
        Me.txtNamaKue.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtNamaKue.PlaceholderText = "Nama "
        Me.txtNamaKue.SelectedText = ""
        Me.txtNamaKue.Size = New System.Drawing.Size(229, 48)
        Me.txtNamaKue.TabIndex = 0
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(14, Byte), Integer), CType(CType(102, Byte), Integer), CType(CType(85, Byte), Integer))
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(622, 45)
        Me.Panel1.TabIndex = 1
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(244, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(179, 28)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "Tambah Data Kue"
        '
        'txtHargaKue
        '
        Me.txtHargaKue.BorderColor = System.Drawing.Color.Black
        Me.txtHargaKue.BorderRadius = 15
        Me.txtHargaKue.BorderThickness = 2
        Me.txtHargaKue.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtHargaKue.DefaultText = ""
        Me.txtHargaKue.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.txtHargaKue.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.txtHargaKue.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtHargaKue.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtHargaKue.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtHargaKue.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.txtHargaKue.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtHargaKue.Location = New System.Drawing.Point(194, 189)
        Me.txtHargaKue.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.txtHargaKue.Name = "txtHargaKue"
        Me.txtHargaKue.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtHargaKue.PlaceholderText = "Harga"
        Me.txtHargaKue.SelectedText = ""
        Me.txtHargaKue.Size = New System.Drawing.Size(229, 48)
        Me.txtHargaKue.TabIndex = 2
        '
        'comboJenis
        '
        Me.comboJenis.BackColor = System.Drawing.Color.Transparent
        Me.comboJenis.BorderColor = System.Drawing.Color.Black
        Me.comboJenis.BorderRadius = 15
        Me.comboJenis.BorderThickness = 2
        Me.comboJenis.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed
        Me.comboJenis.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.comboJenis.FocusedColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.comboJenis.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.comboJenis.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.comboJenis.ForeColor = System.Drawing.Color.FromArgb(CType(CType(68, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(112, Byte), Integer))
        Me.comboJenis.ItemHeight = 30
        Me.comboJenis.Items.AddRange(New Object() {"Kue Kering", "Kue Basah"})
        Me.comboJenis.Location = New System.Drawing.Point(194, 133)
        Me.comboJenis.Name = "comboJenis"
        Me.comboJenis.Size = New System.Drawing.Size(229, 36)
        Me.comboJenis.TabIndex = 3
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Segoe UI Semibold", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(146, 206)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(20, 31)
        Me.Label8.TabIndex = 13
        Me.Label8.Text = ":"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Segoe UI Semibold", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(146, 138)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(20, 31)
        Me.Label7.TabIndex = 12
        Me.Label7.Text = ":"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Segoe UI Semibold", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(146, 82)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(20, 31)
        Me.Label6.TabIndex = 11
        Me.Label6.Text = ":"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Segoe UI Semibold", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(17, 206)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(123, 31)
        Me.Label5.TabIndex = 10
        Me.Label5.Text = "Harga Kue"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Segoe UI Semibold", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(17, 138)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(109, 31)
        Me.Label4.TabIndex = 9
        Me.Label4.Text = "Jenis Kue"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Segoe UI Semibold", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(17, 82)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(121, 31)
        Me.Label3.TabIndex = 8
        Me.Label3.Text = "Nama Kue"
        '
        'btnSimpan
        '
        Me.btnSimpan.Animated = True
        Me.btnSimpan.BorderRadius = 15
        Me.btnSimpan.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.btnSimpan.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.btnSimpan.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.btnSimpan.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.btnSimpan.FillColor = System.Drawing.Color.FromArgb(CType(CType(34, Byte), Integer), CType(CType(153, Byte), Integer), CType(CType(84, Byte), Integer))
        Me.btnSimpan.Font = New System.Drawing.Font("Segoe UI", 10.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSimpan.ForeColor = System.Drawing.Color.White
        Me.btnSimpan.Location = New System.Drawing.Point(122, 341)
        Me.btnSimpan.Name = "btnSimpan"
        Me.btnSimpan.Size = New System.Drawing.Size(151, 58)
        Me.btnSimpan.TabIndex = 14
        Me.btnSimpan.Text = "Simpan"
        '
        'btnHapus
        '
        Me.btnHapus.Animated = True
        Me.btnHapus.BorderRadius = 15
        Me.btnHapus.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.btnHapus.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.btnHapus.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.btnHapus.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.btnHapus.FillColor = System.Drawing.Color.FromArgb(CType(CType(34, Byte), Integer), CType(CType(153, Byte), Integer), CType(CType(84, Byte), Integer))
        Me.btnHapus.Font = New System.Drawing.Font("Segoe UI", 10.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnHapus.ForeColor = System.Drawing.Color.White
        Me.btnHapus.Location = New System.Drawing.Point(313, 341)
        Me.btnHapus.Name = "btnHapus"
        Me.btnHapus.Size = New System.Drawing.Size(151, 58)
        Me.btnHapus.TabIndex = 15
        Me.btnHapus.Text = "Hapus"
        '
        'AddDataKue
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(622, 440)
        Me.Controls.Add(Me.btnHapus)
        Me.Controls.Add(Me.btnSimpan)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.comboJenis)
        Me.Controls.Add(Me.txtHargaKue)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.txtNamaKue)
        Me.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.Name = "AddDataKue"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Add Data Kue"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents TimerReduce As Timer
    Friend WithEvents TimerIncrease As Timer
    Friend WithEvents txtNamaKue As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Label1 As Label
    Friend WithEvents txtHargaKue As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents comboJenis As Guna.UI2.WinForms.Guna2ComboBox
    Friend WithEvents Label8 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents btnSimpan As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents btnHapus As Guna.UI2.WinForms.Guna2Button
End Class
