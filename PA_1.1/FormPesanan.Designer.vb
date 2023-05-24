<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FormPesanan
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
        Me.DataOrderUser = New System.Windows.Forms.DataGridView()
        Me.btnHapus = New Guna.UI2.WinForms.Guna2Button()
        Me.btnBayar = New Guna.UI2.WinForms.Guna2Button()
        CType(Me.DataOrderUser, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'DataOrderUser
        '
        Me.DataOrderUser.BackgroundColor = System.Drawing.Color.White
        Me.DataOrderUser.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataOrderUser.Dock = System.Windows.Forms.DockStyle.Top
        Me.DataOrderUser.GridColor = System.Drawing.Color.Black
        Me.DataOrderUser.Location = New System.Drawing.Point(0, 0)
        Me.DataOrderUser.Name = "DataOrderUser"
        Me.DataOrderUser.ReadOnly = True
        Me.DataOrderUser.RowHeadersVisible = False
        Me.DataOrderUser.RowHeadersWidth = 51
        Me.DataOrderUser.RowTemplate.Height = 24
        Me.DataOrderUser.Size = New System.Drawing.Size(604, 290)
        Me.DataOrderUser.TabIndex = 0
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
        Me.btnHapus.Location = New System.Drawing.Point(316, 323)
        Me.btnHapus.Name = "btnHapus"
        Me.btnHapus.Size = New System.Drawing.Size(151, 58)
        Me.btnHapus.TabIndex = 16
        Me.btnHapus.Text = "Hapus"
        '
        'btnBayar
        '
        Me.btnBayar.Animated = True
        Me.btnBayar.BorderRadius = 15
        Me.btnBayar.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.btnBayar.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.btnBayar.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.btnBayar.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.btnBayar.FillColor = System.Drawing.Color.FromArgb(CType(CType(34, Byte), Integer), CType(CType(153, Byte), Integer), CType(CType(84, Byte), Integer))
        Me.btnBayar.Font = New System.Drawing.Font("Segoe UI", 10.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnBayar.ForeColor = System.Drawing.Color.White
        Me.btnBayar.Location = New System.Drawing.Point(136, 323)
        Me.btnBayar.Name = "btnBayar"
        Me.btnBayar.Size = New System.Drawing.Size(151, 58)
        Me.btnBayar.TabIndex = 17
        Me.btnBayar.Text = "Bayar"
        '
        'FormPesanan
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(604, 393)
        Me.Controls.Add(Me.btnBayar)
        Me.Controls.Add(Me.btnHapus)
        Me.Controls.Add(Me.DataOrderUser)
        Me.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.Name = "FormPesanan"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "FormPesanan"
        CType(Me.DataOrderUser, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents DataOrderUser As DataGridView
    Friend WithEvents btnHapus As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents btnBayar As Guna.UI2.WinForms.Guna2Button
End Class
