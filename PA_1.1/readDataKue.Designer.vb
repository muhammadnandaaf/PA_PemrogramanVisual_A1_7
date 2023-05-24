<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class readDataKue
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
        Me.txtCari = New Guna.UI2.WinForms.Guna2TextBox()
        Me.btnCari = New Guna.UI2.WinForms.Guna2Button()
        CType(Me.DataKue, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'DataKue
        '
        Me.DataKue.BackgroundColor = System.Drawing.Color.White
        Me.DataKue.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataKue.Dock = System.Windows.Forms.DockStyle.Top
        Me.DataKue.GridColor = System.Drawing.Color.Black
        Me.DataKue.Location = New System.Drawing.Point(0, 0)
        Me.DataKue.Name = "DataKue"
        Me.DataKue.ReadOnly = True
        Me.DataKue.RowHeadersVisible = False
        Me.DataKue.RowHeadersWidth = 51
        Me.DataKue.RowTemplate.Height = 24
        Me.DataKue.Size = New System.Drawing.Size(622, 279)
        Me.DataKue.TabIndex = 1
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
        Me.txtCari.Location = New System.Drawing.Point(201, 298)
        Me.txtCari.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.txtCari.Name = "txtCari"
        Me.txtCari.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtCari.PlaceholderText = "Cari nama Kue"
        Me.txtCari.SelectedText = ""
        Me.txtCari.Size = New System.Drawing.Size(229, 48)
        Me.txtCari.TabIndex = 2
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
        Me.btnCari.Location = New System.Drawing.Point(228, 358)
        Me.btnCari.Name = "btnCari"
        Me.btnCari.Size = New System.Drawing.Size(180, 45)
        Me.btnCari.TabIndex = 3
        Me.btnCari.Text = "Cari"
        '
        'readDataKue
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(622, 440)
        Me.Controls.Add(Me.btnCari)
        Me.Controls.Add(Me.txtCari)
        Me.Controls.Add(Me.DataKue)
        Me.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.Name = "readDataKue"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "readDataKue"
        CType(Me.DataKue, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents DataKue As DataGridView
    Friend WithEvents txtCari As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents btnCari As Guna.UI2.WinForms.Guna2Button
End Class
