<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class mainMenu
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
        Me.PanelWrapper = New System.Windows.Forms.Panel()
        Me.PanelWrapperKonten = New System.Windows.Forms.Panel()
        Me.PanelKonten = New System.Windows.Forms.Panel()
        Me.sepRight = New System.Windows.Forms.Label()
        Me.sepLeft = New System.Windows.Forms.Label()
        Me.sepTop = New System.Windows.Forms.Label()
        Me.sepBot = New System.Windows.Forms.Label()
        Me.PanelHeader = New System.Windows.Forms.Panel()
        Me.Title = New System.Windows.Forms.Label()
        Me.subTitle = New System.Windows.Forms.Label()
        Me.PanelWindowBar = New System.Windows.Forms.Panel()
        Me.windowBar = New System.Windows.Forms.Label()
        Me.btnMinimize = New System.Windows.Forms.Button()
        Me.btnClose = New System.Windows.Forms.Button()
        Me.PanelSideBar = New System.Windows.Forms.Panel()
        Me.PanelNav = New System.Windows.Forms.Panel()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.btnLogout = New System.Windows.Forms.Button()
        Me.PanelCornerHeader = New System.Windows.Forms.Panel()
        Me.lblUser = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.PanelWrapper.SuspendLayout()
        Me.PanelWrapperKonten.SuspendLayout()
        Me.PanelHeader.SuspendLayout()
        Me.PanelWindowBar.SuspendLayout()
        Me.PanelSideBar.SuspendLayout()
        Me.PanelCornerHeader.SuspendLayout()
        Me.SuspendLayout()
        '
        'PanelWrapper
        '
        Me.PanelWrapper.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.PanelWrapper.Controls.Add(Me.PanelWrapperKonten)
        Me.PanelWrapper.Controls.Add(Me.PanelHeader)
        Me.PanelWrapper.Controls.Add(Me.PanelSideBar)
        Me.PanelWrapper.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PanelWrapper.Location = New System.Drawing.Point(0, 0)
        Me.PanelWrapper.Name = "PanelWrapper"
        Me.PanelWrapper.Size = New System.Drawing.Size(852, 602)
        Me.PanelWrapper.TabIndex = 13
        '
        'PanelWrapperKonten
        '
        Me.PanelWrapperKonten.Controls.Add(Me.PanelKonten)
        Me.PanelWrapperKonten.Controls.Add(Me.sepRight)
        Me.PanelWrapperKonten.Controls.Add(Me.sepLeft)
        Me.PanelWrapperKonten.Controls.Add(Me.sepTop)
        Me.PanelWrapperKonten.Controls.Add(Me.sepBot)
        Me.PanelWrapperKonten.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PanelWrapperKonten.Location = New System.Drawing.Point(200, 100)
        Me.PanelWrapperKonten.Name = "PanelWrapperKonten"
        Me.PanelWrapperKonten.Size = New System.Drawing.Size(650, 500)
        Me.PanelWrapperKonten.TabIndex = 15
        '
        'PanelKonten
        '
        Me.PanelKonten.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PanelKonten.Location = New System.Drawing.Point(10, 10)
        Me.PanelKonten.Name = "PanelKonten"
        Me.PanelKonten.Size = New System.Drawing.Size(630, 480)
        Me.PanelKonten.TabIndex = 16
        '
        'sepRight
        '
        Me.sepRight.BackColor = System.Drawing.SystemColors.Control
        Me.sepRight.Dock = System.Windows.Forms.DockStyle.Right
        Me.sepRight.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.sepRight.ForeColor = System.Drawing.Color.White
        Me.sepRight.Location = New System.Drawing.Point(640, 10)
        Me.sepRight.Name = "sepRight"
        Me.sepRight.Size = New System.Drawing.Size(10, 480)
        Me.sepRight.TabIndex = 10
        '
        'sepLeft
        '
        Me.sepLeft.BackColor = System.Drawing.SystemColors.Control
        Me.sepLeft.Dock = System.Windows.Forms.DockStyle.Left
        Me.sepLeft.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.sepLeft.ForeColor = System.Drawing.Color.White
        Me.sepLeft.Location = New System.Drawing.Point(0, 10)
        Me.sepLeft.Name = "sepLeft"
        Me.sepLeft.Size = New System.Drawing.Size(10, 480)
        Me.sepLeft.TabIndex = 9
        '
        'sepTop
        '
        Me.sepTop.BackColor = System.Drawing.SystemColors.Control
        Me.sepTop.Dock = System.Windows.Forms.DockStyle.Top
        Me.sepTop.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.sepTop.ForeColor = System.Drawing.Color.White
        Me.sepTop.Location = New System.Drawing.Point(0, 0)
        Me.sepTop.Name = "sepTop"
        Me.sepTop.Size = New System.Drawing.Size(650, 10)
        Me.sepTop.TabIndex = 8
        '
        'sepBot
        '
        Me.sepBot.BackColor = System.Drawing.SystemColors.Control
        Me.sepBot.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.sepBot.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.sepBot.ForeColor = System.Drawing.Color.White
        Me.sepBot.Location = New System.Drawing.Point(0, 490)
        Me.sepBot.Name = "sepBot"
        Me.sepBot.Size = New System.Drawing.Size(650, 10)
        Me.sepBot.TabIndex = 7
        '
        'PanelHeader
        '
        Me.PanelHeader.Controls.Add(Me.Title)
        Me.PanelHeader.Controls.Add(Me.subTitle)
        Me.PanelHeader.Controls.Add(Me.PanelWindowBar)
        Me.PanelHeader.Dock = System.Windows.Forms.DockStyle.Top
        Me.PanelHeader.Location = New System.Drawing.Point(200, 0)
        Me.PanelHeader.Name = "PanelHeader"
        Me.PanelHeader.Size = New System.Drawing.Size(650, 100)
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
        Me.Title.Size = New System.Drawing.Size(650, 50)
        Me.Title.TabIndex = 5
        Me.Title.Text = "Selamat datang di Menu Utama"
        Me.Title.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'subTitle
        '
        Me.subTitle.BackColor = System.Drawing.Color.FromArgb(CType(CType(44, Byte), Integer), CType(CType(62, Byte), Integer), CType(CType(80, Byte), Integer))
        Me.subTitle.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.subTitle.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.subTitle.ForeColor = System.Drawing.Color.White
        Me.subTitle.Location = New System.Drawing.Point(0, 80)
        Me.subTitle.Name = "subTitle"
        Me.subTitle.Size = New System.Drawing.Size(650, 20)
        Me.subTitle.TabIndex = 6
        '
        'PanelWindowBar
        '
        Me.PanelWindowBar.BackColor = System.Drawing.Color.FromArgb(CType(CType(44, Byte), Integer), CType(CType(62, Byte), Integer), CType(CType(80, Byte), Integer))
        Me.PanelWindowBar.Controls.Add(Me.windowBar)
        Me.PanelWindowBar.Controls.Add(Me.btnMinimize)
        Me.PanelWindowBar.Controls.Add(Me.btnClose)
        Me.PanelWindowBar.Dock = System.Windows.Forms.DockStyle.Top
        Me.PanelWindowBar.Location = New System.Drawing.Point(0, 0)
        Me.PanelWindowBar.Name = "PanelWindowBar"
        Me.PanelWindowBar.Size = New System.Drawing.Size(650, 30)
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
        Me.windowBar.Size = New System.Drawing.Size(590, 30)
        Me.windowBar.TabIndex = 4
        Me.windowBar.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'btnMinimize
        '
        Me.btnMinimize.BackColor = System.Drawing.Color.FromArgb(CType(CType(44, Byte), Integer), CType(CType(62, Byte), Integer), CType(CType(80, Byte), Integer))
        Me.btnMinimize.Dock = System.Windows.Forms.DockStyle.Right
        Me.btnMinimize.FlatAppearance.BorderSize = 0
        Me.btnMinimize.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnMinimize.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnMinimize.ForeColor = System.Drawing.Color.White
        Me.btnMinimize.Location = New System.Drawing.Point(590, 0)
        Me.btnMinimize.Name = "btnMinimize"
        Me.btnMinimize.Size = New System.Drawing.Size(30, 30)
        Me.btnMinimize.TabIndex = 3
        Me.btnMinimize.Text = "-"
        Me.btnMinimize.UseVisualStyleBackColor = False
        '
        'btnClose
        '
        Me.btnClose.BackColor = System.Drawing.Color.FromArgb(CType(CType(44, Byte), Integer), CType(CType(62, Byte), Integer), CType(CType(80, Byte), Integer))
        Me.btnClose.Dock = System.Windows.Forms.DockStyle.Right
        Me.btnClose.FlatAppearance.BorderSize = 0
        Me.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnClose.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnClose.ForeColor = System.Drawing.Color.White
        Me.btnClose.Location = New System.Drawing.Point(620, 0)
        Me.btnClose.Name = "btnClose"
        Me.btnClose.Size = New System.Drawing.Size(30, 30)
        Me.btnClose.TabIndex = 2
        Me.btnClose.Text = "x"
        Me.btnClose.UseVisualStyleBackColor = False
        '
        'PanelSideBar
        '
        Me.PanelSideBar.Controls.Add(Me.PanelNav)
        Me.PanelSideBar.Controls.Add(Me.Label5)
        Me.PanelSideBar.Controls.Add(Me.btnLogout)
        Me.PanelSideBar.Controls.Add(Me.PanelCornerHeader)
        Me.PanelSideBar.Dock = System.Windows.Forms.DockStyle.Left
        Me.PanelSideBar.Location = New System.Drawing.Point(0, 0)
        Me.PanelSideBar.Name = "PanelSideBar"
        Me.PanelSideBar.Size = New System.Drawing.Size(200, 600)
        Me.PanelSideBar.TabIndex = 12
        '
        'PanelNav
        '
        Me.PanelNav.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PanelNav.Location = New System.Drawing.Point(0, 99)
        Me.PanelNav.Name = "PanelNav"
        Me.PanelNav.Size = New System.Drawing.Size(200, 440)
        Me.PanelNav.TabIndex = 16
        '
        'Label5
        '
        Me.Label5.BackColor = System.Drawing.Color.FromArgb(CType(CType(44, Byte), Integer), CType(CType(62, Byte), Integer), CType(CType(80, Byte), Integer))
        Me.Label5.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Label5.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.White
        Me.Label5.Location = New System.Drawing.Point(0, 539)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(200, 1)
        Me.Label5.TabIndex = 15
        '
        'btnLogout
        '
        Me.btnLogout.BackColor = System.Drawing.Color.FromArgb(CType(CType(52, Byte), Integer), CType(CType(73, Byte), Integer), CType(CType(94, Byte), Integer))
        Me.btnLogout.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.btnLogout.FlatAppearance.BorderSize = 0
        Me.btnLogout.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnLogout.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnLogout.ForeColor = System.Drawing.Color.White
        Me.btnLogout.Location = New System.Drawing.Point(0, 540)
        Me.btnLogout.Name = "btnLogout"
        Me.btnLogout.Padding = New System.Windows.Forms.Padding(20, 0, 0, 0)
        Me.btnLogout.Size = New System.Drawing.Size(200, 60)
        Me.btnLogout.TabIndex = 14
        Me.btnLogout.Text = "Logout"
        Me.btnLogout.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnLogout.UseVisualStyleBackColor = False
        '
        'PanelCornerHeader
        '
        Me.PanelCornerHeader.BackColor = System.Drawing.Color.FromArgb(CType(CType(240, Byte), Integer), CType(CType(200, Byte), Integer), CType(CType(15, Byte), Integer))
        Me.PanelCornerHeader.Controls.Add(Me.lblUser)
        Me.PanelCornerHeader.Controls.Add(Me.Label1)
        Me.PanelCornerHeader.Dock = System.Windows.Forms.DockStyle.Top
        Me.PanelCornerHeader.Location = New System.Drawing.Point(0, 0)
        Me.PanelCornerHeader.Name = "PanelCornerHeader"
        Me.PanelCornerHeader.Size = New System.Drawing.Size(200, 99)
        Me.PanelCornerHeader.TabIndex = 1
        '
        'lblUser
        '
        Me.lblUser.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lblUser.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblUser.ForeColor = System.Drawing.Color.Black
        Me.lblUser.Location = New System.Drawing.Point(0, 63)
        Me.lblUser.Name = "lblUser"
        Me.lblUser.Size = New System.Drawing.Size(200, 36)
        Me.lblUser.TabIndex = 2
        Me.lblUser.Text = "Arinal  -  Peserta"
        Me.lblUser.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'Label1
        '
        Me.Label1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Label1.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Black
        Me.Label1.Location = New System.Drawing.Point(0, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Padding = New System.Windows.Forms.Padding(0, 0, 0, 10)
        Me.Label1.Size = New System.Drawing.Size(200, 63)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "SMK Nasional"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        '
        'mainMenu
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(852, 602)
        Me.Controls.Add(Me.PanelWrapper)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "mainMenu"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "mainMenu"
        Me.PanelWrapper.ResumeLayout(False)
        Me.PanelWrapperKonten.ResumeLayout(False)
        Me.PanelHeader.ResumeLayout(False)
        Me.PanelWindowBar.ResumeLayout(False)
        Me.PanelSideBar.ResumeLayout(False)
        Me.PanelCornerHeader.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents PanelWrapper As Panel
    Friend WithEvents PanelWrapperKonten As Panel
    Friend WithEvents sepRight As Label
    Friend WithEvents sepLeft As Label
    Friend WithEvents sepTop As Label
    Friend WithEvents sepBot As Label
    Friend WithEvents PanelHeader As Panel
    Friend WithEvents Title As Label
    Friend WithEvents subTitle As Label
    Friend WithEvents PanelWindowBar As Panel
    Friend WithEvents windowBar As Label
    Friend WithEvents btnMinimize As Button
    Friend WithEvents btnClose As Button
    Friend WithEvents PanelCornerHeader As Panel
    Friend WithEvents lblUser As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents PanelKonten As Panel
    Friend WithEvents PanelSideBar As Panel
    Friend WithEvents Label5 As Label
    Friend WithEvents btnLogout As Button
    Friend WithEvents PanelNav As Panel
End Class
