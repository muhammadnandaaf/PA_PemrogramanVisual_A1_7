<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class userForm
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(userForm))
        Me.Guna2Elipse1 = New Guna.UI2.WinForms.Guna2Elipse(Me.components)
        Me.panelLeft = New System.Windows.Forms.Panel()
        Me.btnLogout = New Guna.UI2.WinForms.Guna2Button()
        Me.btnTransaction = New Guna.UI2.WinForms.Guna2Button()
        Me.btnListOrder = New Guna.UI2.WinForms.Guna2Button()
        Me.btnProfile = New Guna.UI2.WinForms.Guna2Button()
        Me.panelLeftTop = New System.Windows.Forms.Panel()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.panelExit = New System.Windows.Forms.Panel()
        Me.Guna2ControlBox3 = New Guna.UI2.WinForms.Guna2ControlBox()
        Me.Guna2ControlBox2 = New Guna.UI2.WinForms.Guna2ControlBox()
        Me.btnExit = New Guna.UI2.WinForms.Guna2ControlBox()
        Me.panelTop = New System.Windows.Forms.Panel()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.panelBody = New System.Windows.Forms.Panel()
        Me.lblUser = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.panelLeft.SuspendLayout()
        Me.panelLeftTop.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        Me.panelExit.SuspendLayout()
        Me.panelTop.SuspendLayout()
        Me.panelBody.SuspendLayout()
        Me.SuspendLayout()
        '
        'Guna2Elipse1
        '
        Me.Guna2Elipse1.TargetControl = Me
        '
        'panelLeft
        '
        Me.panelLeft.BackColor = System.Drawing.Color.FromArgb(CType(CType(14, Byte), Integer), CType(CType(102, Byte), Integer), CType(CType(85, Byte), Integer))
        Me.panelLeft.Controls.Add(Me.btnLogout)
        Me.panelLeft.Controls.Add(Me.btnTransaction)
        Me.panelLeft.Controls.Add(Me.btnListOrder)
        Me.panelLeft.Controls.Add(Me.btnProfile)
        Me.panelLeft.Controls.Add(Me.panelLeftTop)
        Me.panelLeft.Dock = System.Windows.Forms.DockStyle.Left
        Me.panelLeft.Location = New System.Drawing.Point(0, 0)
        Me.panelLeft.MaximumSize = New System.Drawing.Size(160, 0)
        Me.panelLeft.MinimumSize = New System.Drawing.Size(47, 0)
        Me.panelLeft.Name = "panelLeft"
        Me.panelLeft.Size = New System.Drawing.Size(160, 562)
        Me.panelLeft.TabIndex = 2
        '
        'btnLogout
        '
        Me.btnLogout.Animated = True
        Me.btnLogout.BorderColor = System.Drawing.Color.Transparent
        Me.btnLogout.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.btnLogout.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.btnLogout.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.btnLogout.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.btnLogout.Dock = System.Windows.Forms.DockStyle.Top
        Me.btnLogout.FillColor = System.Drawing.Color.Transparent
        Me.btnLogout.Font = New System.Drawing.Font("Segoe UI Semibold", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnLogout.ForeColor = System.Drawing.Color.White
        Me.btnLogout.Image = CType(resources.GetObject("btnLogout.Image"), System.Drawing.Image)
        Me.btnLogout.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left
        Me.btnLogout.ImageSize = New System.Drawing.Size(30, 30)
        Me.btnLogout.Location = New System.Drawing.Point(0, 309)
        Me.btnLogout.Name = "btnLogout"
        Me.btnLogout.Size = New System.Drawing.Size(160, 45)
        Me.btnLogout.TabIndex = 4
        Me.btnLogout.Text = "Logout"
        Me.btnLogout.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        '
        'btnTransaction
        '
        Me.btnTransaction.Animated = True
        Me.btnTransaction.BorderColor = System.Drawing.Color.Transparent
        Me.btnTransaction.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.btnTransaction.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.btnTransaction.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.btnTransaction.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.btnTransaction.Dock = System.Windows.Forms.DockStyle.Top
        Me.btnTransaction.FillColor = System.Drawing.Color.Transparent
        Me.btnTransaction.Font = New System.Drawing.Font("Segoe UI Semibold", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnTransaction.ForeColor = System.Drawing.Color.White
        Me.btnTransaction.Image = CType(resources.GetObject("btnTransaction.Image"), System.Drawing.Image)
        Me.btnTransaction.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left
        Me.btnTransaction.ImageSize = New System.Drawing.Size(30, 30)
        Me.btnTransaction.Location = New System.Drawing.Point(0, 264)
        Me.btnTransaction.Name = "btnTransaction"
        Me.btnTransaction.Size = New System.Drawing.Size(160, 45)
        Me.btnTransaction.TabIndex = 3
        Me.btnTransaction.Text = "Transaction"
        Me.btnTransaction.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        '
        'btnListOrder
        '
        Me.btnListOrder.Animated = True
        Me.btnListOrder.BorderColor = System.Drawing.Color.Transparent
        Me.btnListOrder.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.btnListOrder.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.btnListOrder.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.btnListOrder.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.btnListOrder.Dock = System.Windows.Forms.DockStyle.Top
        Me.btnListOrder.FillColor = System.Drawing.Color.Transparent
        Me.btnListOrder.Font = New System.Drawing.Font("Segoe UI Semibold", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnListOrder.ForeColor = System.Drawing.Color.White
        Me.btnListOrder.Image = CType(resources.GetObject("btnListOrder.Image"), System.Drawing.Image)
        Me.btnListOrder.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left
        Me.btnListOrder.ImageSize = New System.Drawing.Size(30, 30)
        Me.btnListOrder.Location = New System.Drawing.Point(0, 219)
        Me.btnListOrder.Name = "btnListOrder"
        Me.btnListOrder.Size = New System.Drawing.Size(160, 45)
        Me.btnListOrder.TabIndex = 2
        Me.btnListOrder.Text = "Orders"
        Me.btnListOrder.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        '
        'btnProfile
        '
        Me.btnProfile.Animated = True
        Me.btnProfile.BorderColor = System.Drawing.Color.Transparent
        Me.btnProfile.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.btnProfile.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.btnProfile.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.btnProfile.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.btnProfile.Dock = System.Windows.Forms.DockStyle.Top
        Me.btnProfile.FillColor = System.Drawing.Color.Transparent
        Me.btnProfile.Font = New System.Drawing.Font("Segoe UI Semibold", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnProfile.ForeColor = System.Drawing.Color.White
        Me.btnProfile.Image = CType(resources.GetObject("btnProfile.Image"), System.Drawing.Image)
        Me.btnProfile.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left
        Me.btnProfile.ImageSize = New System.Drawing.Size(30, 30)
        Me.btnProfile.Location = New System.Drawing.Point(0, 174)
        Me.btnProfile.Name = "btnProfile"
        Me.btnProfile.Size = New System.Drawing.Size(160, 45)
        Me.btnProfile.TabIndex = 1
        Me.btnProfile.Text = "Profile"
        Me.btnProfile.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        '
        'panelLeftTop
        '
        Me.panelLeftTop.Controls.Add(Me.PictureBox1)
        Me.panelLeftTop.Controls.Add(Me.Panel1)
        Me.panelLeftTop.Dock = System.Windows.Forms.DockStyle.Top
        Me.panelLeftTop.Location = New System.Drawing.Point(0, 0)
        Me.panelLeftTop.Name = "panelLeftTop"
        Me.panelLeftTop.Size = New System.Drawing.Size(160, 174)
        Me.panelLeftTop.TabIndex = 0
        '
        'PictureBox1
        '
        Me.PictureBox1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(0, 38)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(160, 136)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox1.TabIndex = 0
        Me.PictureBox1.TabStop = False
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(33, Byte), Integer), CType(CType(47, Byte), Integer), CType(CType(61, Byte), Integer))
        Me.Panel1.Controls.Add(Me.Label2)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(160, 38)
        Me.Panel1.TabIndex = 0
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Segoe UI", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.White
        Me.Label2.Location = New System.Drawing.Point(3, 9)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(69, 17)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Pelanggan"
        '
        'panelExit
        '
        Me.panelExit.BackColor = System.Drawing.Color.FromArgb(CType(CType(33, Byte), Integer), CType(CType(47, Byte), Integer), CType(CType(61, Byte), Integer))
        Me.panelExit.Controls.Add(Me.Guna2ControlBox3)
        Me.panelExit.Controls.Add(Me.Guna2ControlBox2)
        Me.panelExit.Controls.Add(Me.btnExit)
        Me.panelExit.Dock = System.Windows.Forms.DockStyle.Top
        Me.panelExit.Location = New System.Drawing.Point(160, 0)
        Me.panelExit.Name = "panelExit"
        Me.panelExit.Size = New System.Drawing.Size(640, 38)
        Me.panelExit.TabIndex = 3
        '
        'Guna2ControlBox3
        '
        Me.Guna2ControlBox3.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Guna2ControlBox3.ControlBoxType = Guna.UI2.WinForms.Enums.ControlBoxType.MinimizeBox
        Me.Guna2ControlBox3.FillColor = System.Drawing.Color.Transparent
        Me.Guna2ControlBox3.IconColor = System.Drawing.Color.White
        Me.Guna2ControlBox3.Location = New System.Drawing.Point(448, 0)
        Me.Guna2ControlBox3.Name = "Guna2ControlBox3"
        Me.Guna2ControlBox3.Size = New System.Drawing.Size(67, 38)
        Me.Guna2ControlBox3.TabIndex = 5
        '
        'Guna2ControlBox2
        '
        Me.Guna2ControlBox2.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Guna2ControlBox2.ControlBoxType = Guna.UI2.WinForms.Enums.ControlBoxType.MaximizeBox
        Me.Guna2ControlBox2.FillColor = System.Drawing.Color.Transparent
        Me.Guna2ControlBox2.IconColor = System.Drawing.Color.White
        Me.Guna2ControlBox2.Location = New System.Drawing.Point(511, 0)
        Me.Guna2ControlBox2.Name = "Guna2ControlBox2"
        Me.Guna2ControlBox2.Size = New System.Drawing.Size(67, 38)
        Me.Guna2ControlBox2.TabIndex = 4
        '
        'btnExit
        '
        Me.btnExit.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnExit.FillColor = System.Drawing.Color.Transparent
        Me.btnExit.IconColor = System.Drawing.Color.White
        Me.btnExit.Location = New System.Drawing.Point(573, 0)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(67, 38)
        Me.btnExit.TabIndex = 3
        '
        'panelTop
        '
        Me.panelTop.BackColor = System.Drawing.Color.FromArgb(CType(CType(25, Byte), Integer), CType(CType(111, Byte), Integer), CType(CType(61, Byte), Integer))
        Me.panelTop.Controls.Add(Me.Label1)
        Me.panelTop.Dock = System.Windows.Forms.DockStyle.Top
        Me.panelTop.Location = New System.Drawing.Point(160, 38)
        Me.panelTop.Name = "panelTop"
        Me.panelTop.Size = New System.Drawing.Size(640, 37)
        Me.panelTop.TabIndex = 4
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(233, 3)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(191, 28)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Toko Kue Enak Cuy"
        '
        'panelBody
        '
        Me.panelBody.Controls.Add(Me.lblUser)
        Me.panelBody.Controls.Add(Me.Label3)
        Me.panelBody.Dock = System.Windows.Forms.DockStyle.Fill
        Me.panelBody.Location = New System.Drawing.Point(160, 75)
        Me.panelBody.Name = "panelBody"
        Me.panelBody.Size = New System.Drawing.Size(640, 487)
        Me.panelBody.TabIndex = 5
        '
        'lblUser
        '
        Me.lblUser.AutoSize = True
        Me.lblUser.BackColor = System.Drawing.Color.Transparent
        Me.lblUser.Font = New System.Drawing.Font("Segoe UI", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblUser.ForeColor = System.Drawing.Color.Black
        Me.lblUser.Location = New System.Drawing.Point(273, 189)
        Me.lblUser.Name = "lblUser"
        Me.lblUser.Size = New System.Drawing.Size(30, 41)
        Me.lblUser.TabIndex = 2
        Me.lblUser.Text = "-"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Font = New System.Drawing.Font("Segoe UI", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.Black
        Me.Label3.Location = New System.Drawing.Point(253, 148)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(147, 41)
        Me.Label3.TabIndex = 1
        Me.Label3.Text = "Welcome"
        '
        'userForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 562)
        Me.Controls.Add(Me.panelBody)
        Me.Controls.Add(Me.panelTop)
        Me.Controls.Add(Me.panelExit)
        Me.Controls.Add(Me.panelLeft)
        Me.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.Name = "userForm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "User"
        Me.panelLeft.ResumeLayout(False)
        Me.panelLeftTop.ResumeLayout(False)
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.panelExit.ResumeLayout(False)
        Me.panelTop.ResumeLayout(False)
        Me.panelTop.PerformLayout()
        Me.panelBody.ResumeLayout(False)
        Me.panelBody.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Guna2Elipse1 As Guna.UI2.WinForms.Guna2Elipse
    Friend WithEvents panelLeft As Panel
    Friend WithEvents btnLogout As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents btnTransaction As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents btnListOrder As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents btnProfile As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents panelLeftTop As Panel
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Label2 As Label
    Friend WithEvents panelExit As Panel
    Friend WithEvents Guna2ControlBox3 As Guna.UI2.WinForms.Guna2ControlBox
    Friend WithEvents Guna2ControlBox2 As Guna.UI2.WinForms.Guna2ControlBox
    Friend WithEvents btnExit As Guna.UI2.WinForms.Guna2ControlBox
    Friend WithEvents panelTop As Panel
    Friend WithEvents Label1 As Label
    Friend WithEvents panelBody As Panel
    Friend WithEvents Label3 As Label
    Friend WithEvents lblUser As Label
End Class
