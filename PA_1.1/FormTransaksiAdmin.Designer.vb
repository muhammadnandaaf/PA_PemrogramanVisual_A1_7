<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormTransaksiAdmin
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
        Me.DataTransaksiAdmin = New System.Windows.Forms.DataGridView()
        CType(Me.DataTransaksiAdmin, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'DataTransaksiAdmin
        '
        Me.DataTransaksiAdmin.BackgroundColor = System.Drawing.Color.White
        Me.DataTransaksiAdmin.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataTransaksiAdmin.Dock = System.Windows.Forms.DockStyle.Top
        Me.DataTransaksiAdmin.GridColor = System.Drawing.Color.Black
        Me.DataTransaksiAdmin.Location = New System.Drawing.Point(0, 0)
        Me.DataTransaksiAdmin.Name = "DataTransaksiAdmin"
        Me.DataTransaksiAdmin.ReadOnly = True
        Me.DataTransaksiAdmin.RowHeadersVisible = False
        Me.DataTransaksiAdmin.RowHeadersWidth = 51
        Me.DataTransaksiAdmin.RowTemplate.Height = 24
        Me.DataTransaksiAdmin.Size = New System.Drawing.Size(622, 393)
        Me.DataTransaksiAdmin.TabIndex = 1
        '
        'FormTransaksiAdmin
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(622, 440)
        Me.Controls.Add(Me.DataTransaksiAdmin)
        Me.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.Name = "FormTransaksiAdmin"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "FormTransaksiAdmin"
        CType(Me.DataTransaksiAdmin, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents DataTransaksiAdmin As DataGridView
End Class
