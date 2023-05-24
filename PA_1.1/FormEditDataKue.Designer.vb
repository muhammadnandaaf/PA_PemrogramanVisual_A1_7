<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormEditDataKue
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
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btnEdit = New Guna.UI2.WinForms.Guna2Button()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.comboJenis = New Guna.UI2.WinForms.Guna2ComboBox()
        Me.txtHargaKue = New Guna.UI2.WinForms.Guna2TextBox()
        Me.txtNamaKue = New Guna.UI2.WinForms.Guna2TextBox()
        Me.btnBack = New Guna.UI2.WinForms.Guna2Button()
        Me.btnHome = New Guna.UI2.WinForms.Guna2Button()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(14, Byte), Integer), CType(CType(102, Byte), Integer), CType(CType(85, Byte), Integer))
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(622, 45)
        Me.Panel1.TabIndex = 0
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(222, 8)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(142, 28)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "Edit Data Kue"
        '
        'btnEdit
        '
        Me.btnEdit.Animated = True
        Me.btnEdit.BorderRadius = 15
        Me.btnEdit.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.btnEdit.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.btnEdit.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.btnEdit.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.btnEdit.FillColor = System.Drawing.Color.FromArgb(CType(CType(34, Byte), Integer), CType(CType(153, Byte), Integer), CType(CType(84, Byte), Integer))
        Me.btnEdit.Font = New System.Drawing.Font("Segoe UI", 10.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnEdit.ForeColor = System.Drawing.Color.White
        Me.btnEdit.Location = New System.Drawing.Point(231, 346)
        Me.btnEdit.Name = "btnEdit"
        Me.btnEdit.Size = New System.Drawing.Size(151, 58)
        Me.btnEdit.TabIndex = 24
        Me.btnEdit.Text = "Edit"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Segoe UI Semibold", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(144, 203)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(20, 31)
        Me.Label8.TabIndex = 23
        Me.Label8.Text = ":"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Segoe UI Semibold", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(144, 135)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(20, 31)
        Me.Label7.TabIndex = 22
        Me.Label7.Text = ":"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Segoe UI Semibold", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(144, 79)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(20, 31)
        Me.Label6.TabIndex = 21
        Me.Label6.Text = ":"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Segoe UI Semibold", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(15, 203)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(123, 31)
        Me.Label5.TabIndex = 20
        Me.Label5.Text = "Harga Kue"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Segoe UI Semibold", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(15, 135)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(109, 31)
        Me.Label4.TabIndex = 19
        Me.Label4.Text = "Jenis Kue"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Segoe UI Semibold", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(15, 79)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(121, 31)
        Me.Label3.TabIndex = 18
        Me.Label3.Text = "Nama Kue"
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
        Me.comboJenis.Location = New System.Drawing.Point(192, 130)
        Me.comboJenis.Name = "comboJenis"
        Me.comboJenis.Size = New System.Drawing.Size(229, 36)
        Me.comboJenis.TabIndex = 17
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
        Me.txtHargaKue.Location = New System.Drawing.Point(192, 186)
        Me.txtHargaKue.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.txtHargaKue.Name = "txtHargaKue"
        Me.txtHargaKue.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtHargaKue.PlaceholderText = "Harga"
        Me.txtHargaKue.SelectedText = ""
        Me.txtHargaKue.Size = New System.Drawing.Size(229, 48)
        Me.txtHargaKue.TabIndex = 16
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
        Me.txtNamaKue.Location = New System.Drawing.Point(192, 62)
        Me.txtNamaKue.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.txtNamaKue.Name = "txtNamaKue"
        Me.txtNamaKue.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtNamaKue.PlaceholderText = "Nama "
        Me.txtNamaKue.SelectedText = ""
        Me.txtNamaKue.Size = New System.Drawing.Size(229, 48)
        Me.txtNamaKue.TabIndex = 15
        '
        'btnBack
        '
        Me.btnBack.Animated = True
        Me.btnBack.BorderRadius = 15
        Me.btnBack.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.btnBack.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.btnBack.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.btnBack.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.btnBack.FillColor = System.Drawing.Color.FromArgb(CType(CType(34, Byte), Integer), CType(CType(153, Byte), Integer), CType(CType(84, Byte), Integer))
        Me.btnBack.Font = New System.Drawing.Font("Segoe UI", 10.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnBack.ForeColor = System.Drawing.Color.White
        Me.btnBack.Location = New System.Drawing.Point(45, 346)
        Me.btnBack.Name = "btnBack"
        Me.btnBack.Size = New System.Drawing.Size(151, 58)
        Me.btnBack.TabIndex = 25
        Me.btnBack.Text = "Back"
        '
        'btnHome
        '
        Me.btnHome.Animated = True
        Me.btnHome.BorderRadius = 15
        Me.btnHome.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.btnHome.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.btnHome.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.btnHome.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.btnHome.FillColor = System.Drawing.Color.FromArgb(CType(CType(34, Byte), Integer), CType(CType(153, Byte), Integer), CType(CType(84, Byte), Integer))
        Me.btnHome.Font = New System.Drawing.Font("Segoe UI", 10.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnHome.ForeColor = System.Drawing.Color.White
        Me.btnHome.Location = New System.Drawing.Point(415, 346)
        Me.btnHome.Name = "btnHome"
        Me.btnHome.Size = New System.Drawing.Size(151, 58)
        Me.btnHome.TabIndex = 26
        Me.btnHome.Text = "Home"
        '
        'FormEditDataKue
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(622, 440)
        Me.Controls.Add(Me.btnHome)
        Me.Controls.Add(Me.btnBack)
        Me.Controls.Add(Me.btnEdit)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.comboJenis)
        Me.Controls.Add(Me.txtHargaKue)
        Me.Controls.Add(Me.txtNamaKue)
        Me.Controls.Add(Me.Panel1)
        Me.Font = New System.Drawing.Font("Segoe UI Semibold", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.Name = "FormEditDataKue"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "FormEditDataKue"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents Label1 As Label
    Friend WithEvents btnEdit As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents Label8 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents comboJenis As Guna.UI2.WinForms.Guna2ComboBox
    Friend WithEvents txtHargaKue As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents txtNamaKue As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents btnBack As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents btnHome As Guna.UI2.WinForms.Guna2Button
End Class
