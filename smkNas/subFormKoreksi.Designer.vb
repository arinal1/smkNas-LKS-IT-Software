<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class subFormKoreksi
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
        Me.PanelKonten = New System.Windows.Forms.Panel()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.txKasus = New System.Windows.Forms.TextBox()
        Me.txEssay = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txPg = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btnReset = New System.Windows.Forms.Button()
        Me.btnSimpan = New System.Windows.Forms.Button()
        Me.Konten = New System.Windows.Forms.Label()
        Me.sepRight = New System.Windows.Forms.Label()
        Me.sepLeft = New System.Windows.Forms.Label()
        Me.sepTop = New System.Windows.Forms.Label()
        Me.sepBot = New System.Windows.Forms.Label()
        Me.PanelHeader = New System.Windows.Forms.Panel()
        Me.Title = New System.Windows.Forms.Label()
        Me.subTitle = New System.Windows.Forms.Label()
        Me.PanelWindowBar = New System.Windows.Forms.Panel()
        Me.windowBar = New System.Windows.Forms.Label()
        Me.btnClose = New System.Windows.Forms.Button()
        Me.NilaiTableAdapter = New smkNas.smkNasDataSetTableAdapters.nilaiTableAdapter()
        Me.PanelWrapper.SuspendLayout()
        Me.PanelKonten.SuspendLayout()
        Me.PanelHeader.SuspendLayout()
        Me.PanelWindowBar.SuspendLayout()
        Me.SuspendLayout()
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
        Me.PanelWrapper.Size = New System.Drawing.Size(382, 380)
        Me.PanelWrapper.TabIndex = 13
        '
        'PanelKonten
        '
        Me.PanelKonten.Controls.Add(Me.Label11)
        Me.PanelKonten.Controls.Add(Me.txKasus)
        Me.PanelKonten.Controls.Add(Me.txEssay)
        Me.PanelKonten.Controls.Add(Me.Label3)
        Me.PanelKonten.Controls.Add(Me.txPg)
        Me.PanelKonten.Controls.Add(Me.Label2)
        Me.PanelKonten.Controls.Add(Me.Label1)
        Me.PanelKonten.Controls.Add(Me.btnReset)
        Me.PanelKonten.Controls.Add(Me.btnSimpan)
        Me.PanelKonten.Controls.Add(Me.Konten)
        Me.PanelKonten.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PanelKonten.Location = New System.Drawing.Point(10, 110)
        Me.PanelKonten.Name = "PanelKonten"
        Me.PanelKonten.Size = New System.Drawing.Size(360, 258)
        Me.PanelKonten.TabIndex = 15
        '
        'Label11
        '
        Me.Label11.BackColor = System.Drawing.SystemColors.Control
        Me.Label11.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.ForeColor = System.Drawing.SystemColors.ControlDark
        Me.Label11.Location = New System.Drawing.Point(40, 196)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(280, 2)
        Me.Label11.TabIndex = 15
        '
        'txKasus
        '
        Me.txKasus.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txKasus.Location = New System.Drawing.Point(120, 132)
        Me.txKasus.Name = "txKasus"
        Me.txKasus.Size = New System.Drawing.Size(200, 25)
        Me.txKasus.TabIndex = 1
        '
        'txEssay
        '
        Me.txEssay.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txEssay.Location = New System.Drawing.Point(120, 82)
        Me.txEssay.Name = "txEssay"
        Me.txEssay.Size = New System.Drawing.Size(200, 25)
        Me.txEssay.TabIndex = 1
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.White
        Me.Label3.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(40, 135)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(42, 17)
        Me.Label3.TabIndex = 13
        Me.Label3.Text = "Kasus"
        '
        'txPg
        '
        Me.txPg.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txPg.Location = New System.Drawing.Point(120, 32)
        Me.txPg.Name = "txPg"
        Me.txPg.Size = New System.Drawing.Size(200, 25)
        Me.txPg.TabIndex = 0
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.White
        Me.Label2.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(40, 85)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(40, 17)
        Me.Label2.TabIndex = 13
        Me.Label2.Text = "Essay"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.White
        Me.Label1.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(40, 35)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(43, 17)
        Me.Label1.TabIndex = 13
        Me.Label1.Text = "Pilgan"
        '
        'btnReset
        '
        Me.btnReset.BackColor = System.Drawing.Color.FromArgb(CType(CType(52, Byte), Integer), CType(CType(152, Byte), Integer), CType(CType(220, Byte), Integer))
        Me.btnReset.FlatAppearance.BorderSize = 0
        Me.btnReset.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnReset.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnReset.ForeColor = System.Drawing.Color.White
        Me.btnReset.Location = New System.Drawing.Point(43, 210)
        Me.btnReset.Name = "btnReset"
        Me.btnReset.Size = New System.Drawing.Size(100, 40)
        Me.btnReset.TabIndex = 12
        Me.btnReset.Text = "Reset"
        Me.btnReset.UseVisualStyleBackColor = False
        '
        'btnSimpan
        '
        Me.btnSimpan.BackColor = System.Drawing.Color.FromArgb(CType(CType(52, Byte), Integer), CType(CType(152, Byte), Integer), CType(CType(220, Byte), Integer))
        Me.btnSimpan.FlatAppearance.BorderSize = 0
        Me.btnSimpan.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnSimpan.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSimpan.ForeColor = System.Drawing.Color.White
        Me.btnSimpan.Location = New System.Drawing.Point(220, 210)
        Me.btnSimpan.Name = "btnSimpan"
        Me.btnSimpan.Size = New System.Drawing.Size(100, 40)
        Me.btnSimpan.TabIndex = 2
        Me.btnSimpan.Text = "Simpan"
        Me.btnSimpan.UseVisualStyleBackColor = False
        '
        'Konten
        '
        Me.Konten.BackColor = System.Drawing.Color.White
        Me.Konten.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Konten.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Konten.ForeColor = System.Drawing.Color.White
        Me.Konten.Location = New System.Drawing.Point(0, 0)
        Me.Konten.Name = "Konten"
        Me.Konten.Size = New System.Drawing.Size(360, 258)
        Me.Konten.TabIndex = 11
        '
        'sepRight
        '
        Me.sepRight.BackColor = System.Drawing.SystemColors.Control
        Me.sepRight.Dock = System.Windows.Forms.DockStyle.Right
        Me.sepRight.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.sepRight.ForeColor = System.Drawing.Color.White
        Me.sepRight.Location = New System.Drawing.Point(370, 110)
        Me.sepRight.Name = "sepRight"
        Me.sepRight.Size = New System.Drawing.Size(10, 258)
        Me.sepRight.TabIndex = 10
        '
        'sepLeft
        '
        Me.sepLeft.BackColor = System.Drawing.SystemColors.Control
        Me.sepLeft.Dock = System.Windows.Forms.DockStyle.Left
        Me.sepLeft.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.sepLeft.ForeColor = System.Drawing.Color.White
        Me.sepLeft.Location = New System.Drawing.Point(0, 110)
        Me.sepLeft.Name = "sepLeft"
        Me.sepLeft.Size = New System.Drawing.Size(10, 258)
        Me.sepLeft.TabIndex = 9
        '
        'sepTop
        '
        Me.sepTop.BackColor = System.Drawing.SystemColors.Control
        Me.sepTop.Dock = System.Windows.Forms.DockStyle.Top
        Me.sepTop.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.sepTop.ForeColor = System.Drawing.Color.White
        Me.sepTop.Location = New System.Drawing.Point(0, 100)
        Me.sepTop.Name = "sepTop"
        Me.sepTop.Size = New System.Drawing.Size(380, 10)
        Me.sepTop.TabIndex = 8
        '
        'sepBot
        '
        Me.sepBot.BackColor = System.Drawing.SystemColors.Control
        Me.sepBot.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.sepBot.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.sepBot.ForeColor = System.Drawing.Color.White
        Me.sepBot.Location = New System.Drawing.Point(0, 368)
        Me.sepBot.Name = "sepBot"
        Me.sepBot.Size = New System.Drawing.Size(380, 10)
        Me.sepBot.TabIndex = 7
        '
        'PanelHeader
        '
        Me.PanelHeader.Controls.Add(Me.Title)
        Me.PanelHeader.Controls.Add(Me.subTitle)
        Me.PanelHeader.Controls.Add(Me.PanelWindowBar)
        Me.PanelHeader.Dock = System.Windows.Forms.DockStyle.Top
        Me.PanelHeader.Location = New System.Drawing.Point(0, 0)
        Me.PanelHeader.Name = "PanelHeader"
        Me.PanelHeader.Size = New System.Drawing.Size(380, 100)
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
        Me.Title.Size = New System.Drawing.Size(380, 40)
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
        Me.subTitle.Location = New System.Drawing.Point(0, 70)
        Me.subTitle.Name = "subTitle"
        Me.subTitle.Size = New System.Drawing.Size(380, 30)
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
        Me.PanelWindowBar.Size = New System.Drawing.Size(380, 30)
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
        Me.windowBar.Size = New System.Drawing.Size(350, 30)
        Me.windowBar.TabIndex = 4
        Me.windowBar.Text = "Penilaian Peserta"
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
        Me.btnClose.Location = New System.Drawing.Point(350, 0)
        Me.btnClose.Name = "btnClose"
        Me.btnClose.Size = New System.Drawing.Size(30, 30)
        Me.btnClose.TabIndex = 2
        Me.btnClose.Text = "x"
        Me.btnClose.UseVisualStyleBackColor = False
        '
        'NilaiTableAdapter
        '
        Me.NilaiTableAdapter.ClearBeforeFill = True
        '
        'subFormKoreksi
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(382, 380)
        Me.Controls.Add(Me.PanelWrapper)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "subFormKoreksi"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "subFormKoreksi"
        Me.PanelWrapper.ResumeLayout(False)
        Me.PanelKonten.ResumeLayout(False)
        Me.PanelKonten.PerformLayout()
        Me.PanelHeader.ResumeLayout(False)
        Me.PanelWindowBar.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents PanelWrapper As Panel
    Friend WithEvents PanelKonten As Panel
    Friend WithEvents txKasus As TextBox
    Friend WithEvents txEssay As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents txPg As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents btnReset As Button
    Friend WithEvents btnSimpan As Button
    Friend WithEvents Konten As Label
    Friend WithEvents sepRight As Label
    Friend WithEvents sepLeft As Label
    Friend WithEvents sepTop As Label
    Friend WithEvents sepBot As Label
    Friend WithEvents PanelHeader As Panel
    Friend WithEvents Title As Label
    Friend WithEvents subTitle As Label
    Friend WithEvents PanelWindowBar As Panel
    Friend WithEvents windowBar As Label
    Friend WithEvents btnClose As Button
    Friend WithEvents Label11 As Label
    Friend WithEvents NilaiTableAdapter As smkNasDataSetTableAdapters.nilaiTableAdapter
End Class
