<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Login
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
        Me.PanelHeader = New System.Windows.Forms.Panel()
        Me.Title = New System.Windows.Forms.Label()
        Me.subTitle = New System.Windows.Forms.Label()
        Me.PanelWindowBar = New System.Windows.Forms.Panel()
        Me.windowBar = New System.Windows.Forms.Label()
        Me.btnClose = New System.Windows.Forms.Button()
        Me.sepBot = New System.Windows.Forms.Label()
        Me.sepTop = New System.Windows.Forms.Label()
        Me.sepLeft = New System.Windows.Forms.Label()
        Me.sepRight = New System.Windows.Forms.Label()
        Me.PanelWrapper = New System.Windows.Forms.Panel()
        Me.PanelKonten = New System.Windows.Forms.Panel()
        Me.txPassword = New System.Windows.Forms.TextBox()
        Me.txUsername = New System.Windows.Forms.TextBox()
        Me.btnDaftar = New System.Windows.Forms.Label()
        Me.lblWarn = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btnInfo = New System.Windows.Forms.Button()
        Me.btnLogin = New System.Windows.Forms.Button()
        Me.Konten = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.PesertaTableAdapter = New smkNas.smkNasDataSetTableAdapters.pesertaTableAdapter()
        Me.StaffTableAdapter = New smkNas.smkNasDataSetTableAdapters.staffTableAdapter()
        Me.PanelHeader.SuspendLayout()
        Me.PanelWindowBar.SuspendLayout()
        Me.PanelWrapper.SuspendLayout()
        Me.PanelKonten.SuspendLayout()
        Me.SuspendLayout()
        '
        'PanelHeader
        '
        Me.PanelHeader.Controls.Add(Me.Title)
        Me.PanelHeader.Controls.Add(Me.subTitle)
        Me.PanelHeader.Controls.Add(Me.PanelWindowBar)
        Me.PanelHeader.Dock = System.Windows.Forms.DockStyle.Top
        Me.PanelHeader.Location = New System.Drawing.Point(0, 0)
        Me.PanelHeader.Name = "PanelHeader"
        Me.PanelHeader.Size = New System.Drawing.Size(390, 150)
        Me.PanelHeader.TabIndex = 0
        '
        'Title
        '
        Me.Title.BackColor = System.Drawing.Color.FromArgb(CType(CType(44, Byte), Integer), CType(CType(62, Byte), Integer), CType(CType(80, Byte), Integer))
        Me.Title.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Title.Font = New System.Drawing.Font("Segoe UI", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Title.ForeColor = System.Drawing.Color.White
        Me.Title.Location = New System.Drawing.Point(0, 30)
        Me.Title.Name = "Title"
        Me.Title.Size = New System.Drawing.Size(390, 90)
        Me.Title.TabIndex = 5
        Me.Title.Text = "SMK Nasional"
        Me.Title.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'subTitle
        '
        Me.subTitle.BackColor = System.Drawing.Color.FromArgb(CType(CType(44, Byte), Integer), CType(CType(62, Byte), Integer), CType(CType(80, Byte), Integer))
        Me.subTitle.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.subTitle.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.subTitle.ForeColor = System.Drawing.Color.White
        Me.subTitle.Location = New System.Drawing.Point(0, 120)
        Me.subTitle.Name = "subTitle"
        Me.subTitle.Size = New System.Drawing.Size(390, 30)
        Me.subTitle.TabIndex = 6
        '
        'PanelWindowBar
        '
        Me.PanelWindowBar.BackColor = System.Drawing.Color.FromArgb(CType(CType(44, Byte), Integer), CType(CType(62, Byte), Integer), CType(CType(80, Byte), Integer))
        Me.PanelWindowBar.Controls.Add(Me.windowBar)
        Me.PanelWindowBar.Controls.Add(Me.btnClose)
        Me.PanelWindowBar.Dock = System.Windows.Forms.DockStyle.Top
        Me.PanelWindowBar.Location = New System.Drawing.Point(0, 0)
        Me.PanelWindowBar.Name = "PanelWindowBar"
        Me.PanelWindowBar.Size = New System.Drawing.Size(390, 30)
        Me.PanelWindowBar.TabIndex = 1
        '
        'windowBar
        '
        Me.windowBar.Dock = System.Windows.Forms.DockStyle.Fill
        Me.windowBar.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.windowBar.ForeColor = System.Drawing.Color.White
        Me.windowBar.Location = New System.Drawing.Point(0, 0)
        Me.windowBar.Name = "windowBar"
        Me.windowBar.Padding = New System.Windows.Forms.Padding(10, 0, 0, 0)
        Me.windowBar.Size = New System.Drawing.Size(360, 30)
        Me.windowBar.TabIndex = 4
        Me.windowBar.Text = "Login SMK Nasional"
        Me.windowBar.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'btnClose
        '
        Me.btnClose.BackColor = System.Drawing.Color.FromArgb(CType(CType(44, Byte), Integer), CType(CType(62, Byte), Integer), CType(CType(80, Byte), Integer))
        Me.btnClose.Dock = System.Windows.Forms.DockStyle.Right
        Me.btnClose.FlatAppearance.BorderSize = 0
        Me.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnClose.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnClose.ForeColor = System.Drawing.Color.White
        Me.btnClose.Location = New System.Drawing.Point(360, 0)
        Me.btnClose.Name = "btnClose"
        Me.btnClose.Size = New System.Drawing.Size(30, 30)
        Me.btnClose.TabIndex = 2
        Me.btnClose.Text = "x"
        Me.btnClose.UseVisualStyleBackColor = False
        '
        'sepBot
        '
        Me.sepBot.BackColor = System.Drawing.SystemColors.Control
        Me.sepBot.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.sepBot.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.sepBot.ForeColor = System.Drawing.Color.White
        Me.sepBot.Location = New System.Drawing.Point(0, 438)
        Me.sepBot.Name = "sepBot"
        Me.sepBot.Size = New System.Drawing.Size(390, 10)
        Me.sepBot.TabIndex = 7
        '
        'sepTop
        '
        Me.sepTop.BackColor = System.Drawing.SystemColors.Control
        Me.sepTop.Dock = System.Windows.Forms.DockStyle.Top
        Me.sepTop.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.sepTop.ForeColor = System.Drawing.Color.White
        Me.sepTop.Location = New System.Drawing.Point(0, 150)
        Me.sepTop.Name = "sepTop"
        Me.sepTop.Size = New System.Drawing.Size(390, 10)
        Me.sepTop.TabIndex = 8
        '
        'sepLeft
        '
        Me.sepLeft.BackColor = System.Drawing.SystemColors.Control
        Me.sepLeft.Dock = System.Windows.Forms.DockStyle.Left
        Me.sepLeft.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.sepLeft.ForeColor = System.Drawing.Color.White
        Me.sepLeft.Location = New System.Drawing.Point(0, 160)
        Me.sepLeft.Name = "sepLeft"
        Me.sepLeft.Size = New System.Drawing.Size(10, 278)
        Me.sepLeft.TabIndex = 9
        '
        'sepRight
        '
        Me.sepRight.BackColor = System.Drawing.SystemColors.Control
        Me.sepRight.Dock = System.Windows.Forms.DockStyle.Right
        Me.sepRight.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.sepRight.ForeColor = System.Drawing.Color.White
        Me.sepRight.Location = New System.Drawing.Point(380, 160)
        Me.sepRight.Name = "sepRight"
        Me.sepRight.Size = New System.Drawing.Size(10, 278)
        Me.sepRight.TabIndex = 10
        '
        'PanelWrapper
        '
        Me.PanelWrapper.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.PanelWrapper.Controls.Add(Me.PanelKonten)
        Me.PanelWrapper.Controls.Add(Me.sepRight)
        Me.PanelWrapper.Controls.Add(Me.sepLeft)
        Me.PanelWrapper.Controls.Add(Me.sepTop)
        Me.PanelWrapper.Controls.Add(Me.sepBot)
        Me.PanelWrapper.Controls.Add(Me.PanelHeader)
        Me.PanelWrapper.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PanelWrapper.Location = New System.Drawing.Point(0, 0)
        Me.PanelWrapper.Name = "PanelWrapper"
        Me.PanelWrapper.Size = New System.Drawing.Size(392, 450)
        Me.PanelWrapper.TabIndex = 12
        '
        'PanelKonten
        '
        Me.PanelKonten.Controls.Add(Me.txPassword)
        Me.PanelKonten.Controls.Add(Me.txUsername)
        Me.PanelKonten.Controls.Add(Me.btnDaftar)
        Me.PanelKonten.Controls.Add(Me.lblWarn)
        Me.PanelKonten.Controls.Add(Me.Label3)
        Me.PanelKonten.Controls.Add(Me.Label2)
        Me.PanelKonten.Controls.Add(Me.Label1)
        Me.PanelKonten.Controls.Add(Me.btnInfo)
        Me.PanelKonten.Controls.Add(Me.btnLogin)
        Me.PanelKonten.Controls.Add(Me.Konten)
        Me.PanelKonten.Controls.Add(Me.Label4)
        Me.PanelKonten.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PanelKonten.Location = New System.Drawing.Point(10, 160)
        Me.PanelKonten.Name = "PanelKonten"
        Me.PanelKonten.Size = New System.Drawing.Size(370, 278)
        Me.PanelKonten.TabIndex = 15
        '
        'txPassword
        '
        Me.txPassword.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txPassword.Location = New System.Drawing.Point(130, 99)
        Me.txPassword.Name = "txPassword"
        Me.txPassword.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.txPassword.Size = New System.Drawing.Size(200, 25)
        Me.txPassword.TabIndex = 1
        '
        'txUsername
        '
        Me.txUsername.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txUsername.Location = New System.Drawing.Point(130, 47)
        Me.txUsername.Name = "txUsername"
        Me.txUsername.Size = New System.Drawing.Size(200, 25)
        Me.txUsername.TabIndex = 0
        '
        'btnDaftar
        '
        Me.btnDaftar.AutoSize = True
        Me.btnDaftar.BackColor = System.Drawing.Color.FromArgb(CType(CType(44, Byte), Integer), CType(CType(62, Byte), Integer), CType(CType(80, Byte), Integer))
        Me.btnDaftar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnDaftar.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnDaftar.ForeColor = System.Drawing.Color.FromArgb(CType(CType(52, Byte), Integer), CType(CType(152, Byte), Integer), CType(CType(220, Byte), Integer))
        Me.btnDaftar.Location = New System.Drawing.Point(146, 252)
        Me.btnDaftar.Name = "btnDaftar"
        Me.btnDaftar.Size = New System.Drawing.Size(39, 13)
        Me.btnDaftar.TabIndex = 13
        Me.btnDaftar.Text = "Daftar"
        '
        'lblWarn
        '
        Me.lblWarn.AutoSize = True
        Me.lblWarn.BackColor = System.Drawing.Color.White
        Me.lblWarn.Font = New System.Drawing.Font("Segoe UI", 6.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblWarn.ForeColor = System.Drawing.Color.Red
        Me.lblWarn.Location = New System.Drawing.Point(51, 130)
        Me.lblWarn.Name = "lblWarn"
        Me.lblWarn.Size = New System.Drawing.Size(99, 12)
        Me.lblWarn.TabIndex = 13
        Me.lblWarn.Text = "*Mohon data dilengkapi"
        Me.lblWarn.Visible = False
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.FromArgb(CType(CType(44, Byte), Integer), CType(CType(62, Byte), Integer), CType(CType(80, Byte), Integer))
        Me.Label3.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.White
        Me.Label3.Location = New System.Drawing.Point(47, 252)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(100, 13)
        Me.Label3.TabIndex = 13
        Me.Label3.Text = "Calon siswa baru?"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.White
        Me.Label2.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(50, 102)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(64, 17)
        Me.Label2.TabIndex = 13
        Me.Label2.Text = "Password"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.White
        Me.Label1.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(50, 50)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(56, 17)
        Me.Label1.TabIndex = 13
        Me.Label1.Text = "Login ID"
        '
        'btnInfo
        '
        Me.btnInfo.BackColor = System.Drawing.Color.FromArgb(CType(CType(52, Byte), Integer), CType(CType(152, Byte), Integer), CType(CType(220, Byte), Integer))
        Me.btnInfo.FlatAppearance.BorderSize = 0
        Me.btnInfo.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnInfo.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnInfo.ForeColor = System.Drawing.Color.White
        Me.btnInfo.Location = New System.Drawing.Point(50, 170)
        Me.btnInfo.Name = "btnInfo"
        Me.btnInfo.Size = New System.Drawing.Size(100, 40)
        Me.btnInfo.TabIndex = 12
        Me.btnInfo.Text = "Info Sekolah"
        Me.btnInfo.UseVisualStyleBackColor = False
        '
        'btnLogin
        '
        Me.btnLogin.BackColor = System.Drawing.Color.FromArgb(CType(CType(52, Byte), Integer), CType(CType(152, Byte), Integer), CType(CType(220, Byte), Integer))
        Me.btnLogin.FlatAppearance.BorderSize = 0
        Me.btnLogin.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnLogin.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnLogin.ForeColor = System.Drawing.Color.White
        Me.btnLogin.Location = New System.Drawing.Point(230, 170)
        Me.btnLogin.Name = "btnLogin"
        Me.btnLogin.Size = New System.Drawing.Size(100, 40)
        Me.btnLogin.TabIndex = 2
        Me.btnLogin.Text = "Login"
        Me.btnLogin.UseVisualStyleBackColor = False
        '
        'Konten
        '
        Me.Konten.BackColor = System.Drawing.Color.White
        Me.Konten.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Konten.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Konten.ForeColor = System.Drawing.Color.White
        Me.Konten.Location = New System.Drawing.Point(0, 0)
        Me.Konten.Name = "Konten"
        Me.Konten.Size = New System.Drawing.Size(370, 238)
        Me.Konten.TabIndex = 11
        '
        'Label4
        '
        Me.Label4.BackColor = System.Drawing.Color.FromArgb(CType(CType(44, Byte), Integer), CType(CType(62, Byte), Integer), CType(CType(80, Byte), Integer))
        Me.Label4.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Label4.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.White
        Me.Label4.Location = New System.Drawing.Point(0, 238)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(370, 40)
        Me.Label4.TabIndex = 15
        '
        'PesertaTableAdapter
        '
        Me.PesertaTableAdapter.ClearBeforeFill = True
        '
        'StaffTableAdapter
        '
        Me.StaffTableAdapter.ClearBeforeFill = True
        '
        'Login
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(392, 450)
        Me.Controls.Add(Me.PanelWrapper)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "Login"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "mainForm"
        Me.PanelHeader.ResumeLayout(False)
        Me.PanelWindowBar.ResumeLayout(False)
        Me.PanelWrapper.ResumeLayout(False)
        Me.PanelKonten.ResumeLayout(False)
        Me.PanelKonten.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents PanelHeader As Panel
    Friend WithEvents Title As Label
    Friend WithEvents subTitle As Label
    Friend WithEvents PanelWindowBar As Panel
    Friend WithEvents windowBar As Label
    Friend WithEvents btnClose As Button
    Friend WithEvents sepBot As Label
    Friend WithEvents sepTop As Label
    Friend WithEvents sepLeft As Label
    Friend WithEvents sepRight As Label
    Friend WithEvents PanelWrapper As Panel
    Friend WithEvents PanelKonten As Panel
    Friend WithEvents txPassword As TextBox
    Friend WithEvents txUsername As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents btnLogin As Button
    Friend WithEvents Konten As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents btnDaftar As Label
    Friend WithEvents lblWarn As Label
    Friend WithEvents btnInfo As Button
    Friend WithEvents Label4 As Label
    Friend WithEvents PesertaTableAdapter As smkNasDataSetTableAdapters.pesertaTableAdapter
    Friend WithEvents StaffTableAdapter As smkNasDataSetTableAdapters.staffTableAdapter
End Class
