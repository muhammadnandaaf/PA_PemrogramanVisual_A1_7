<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormTransaksiUser
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
        Me.DataTransaksiUser = New System.Windows.Forms.DataGridView()
        CType(Me.DataTransaksiUser, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'DataTransaksiUser
        '
        Me.DataTransaksiUser.BackgroundColor = System.Drawing.Color.White
        Me.DataTransaksiUser.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataTransaksiUser.Dock = System.Windows.Forms.DockStyle.Fill
        Me.DataTransaksiUser.GridColor = System.Drawing.Color.Black
        Me.DataTransaksiUser.Location = New System.Drawing.Point(0, 0)
        Me.DataTransaksiUser.Name = "DataTransaksiUser"
        Me.DataTransaksiUser.ReadOnly = True
        Me.DataTransaksiUser.RowHeadersVisible = False
        Me.DataTransaksiUser.RowHeadersWidth = 51
        Me.DataTransaksiUser.RowTemplate.Height = 24
        Me.DataTransaksiUser.Size = New System.Drawing.Size(604, 393)
        Me.DataTransaksiUser.TabIndex = 0
        '
        'FormTransaksiUser
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(604, 393)
        Me.Controls.Add(Me.DataTransaksiUser)
        Me.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.Name = "FormTransaksiUser"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "FormTransaksiUser"
        CType(Me.DataTransaksiUser, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents DataTransaksiUser As DataGridView
End Class
