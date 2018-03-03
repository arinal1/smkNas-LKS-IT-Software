<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class infoSekolah
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
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(infoSekolah))
        Me.PanelWrapper = New System.Windows.Forms.Panel()
        Me.PanelKonten = New System.Windows.Forms.Panel()
        Me.btnInfo = New System.Windows.Forms.Button()
        Me.cbJurusan = New System.Windows.Forms.ComboBox()
        Me.JurusanBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.SmkNasDataSet = New smkNas.smkNasDataSet()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.info = New System.Windows.Forms.Label()
        Me.fotoBox = New System.Windows.Forms.PictureBox()
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
        Me.JurusanTableAdapter = New smkNas.smkNasDataSetTableAdapters.jurusanTableAdapter()
        Me.PanelWrapper.SuspendLayout()
        Me.PanelKonten.SuspendLayout()
        CType(Me.JurusanBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SmkNasDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.fotoBox, System.ComponentModel.ISupportInitialize).BeginInit()
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
        Me.PanelWrapper.Size = New System.Drawing.Size(402, 482)
        Me.PanelWrapper.TabIndex = 13
        '
        'PanelKonten
        '
        Me.PanelKonten.Controls.Add(Me.btnInfo)
        Me.PanelKonten.Controls.Add(Me.cbJurusan)
        Me.PanelKonten.Controls.Add(Me.Label2)
        Me.PanelKonten.Controls.Add(Me.Label1)
        Me.PanelKonten.Controls.Add(Me.info)
        Me.PanelKonten.Controls.Add(Me.fotoBox)
        Me.PanelKonten.Controls.Add(Me.Konten)
        Me.PanelKonten.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PanelKonten.Location = New System.Drawing.Point(10, 160)
        Me.PanelKonten.Name = "PanelKonten"
        Me.PanelKonten.Size = New System.Drawing.Size(380, 310)
        Me.PanelKonten.TabIndex = 15
        '
        'btnInfo
        '
        Me.btnInfo.BackColor = System.Drawing.Color.FromArgb(CType(CType(52, Byte), Integer), CType(CType(152, Byte), Integer), CType(CType(220, Byte), Integer))
        Me.btnInfo.FlatAppearance.BorderSize = 0
        Me.btnInfo.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnInfo.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnInfo.ForeColor = System.Drawing.Color.White
        Me.btnInfo.Location = New System.Drawing.Point(270, 260)
        Me.btnInfo.Name = "btnInfo"
        Me.btnInfo.Size = New System.Drawing.Size(100, 40)
        Me.btnInfo.TabIndex = 17
        Me.btnInfo.Text = "Lihat Informasi"
        Me.btnInfo.UseVisualStyleBackColor = False
        '
        'cbJurusan
        '
        Me.cbJurusan.DataSource = Me.JurusanBindingSource
        Me.cbJurusan.DisplayMember = "nama"
        Me.cbJurusan.FormattingEnabled = True
        Me.cbJurusan.Location = New System.Drawing.Point(183, 230)
        Me.cbJurusan.Name = "cbJurusan"
        Me.cbJurusan.Size = New System.Drawing.Size(187, 21)
        Me.cbJurusan.TabIndex = 16
        Me.cbJurusan.ValueMember = "deskripsi"
        '
        'JurusanBindingSource
        '
        Me.JurusanBindingSource.DataMember = "jurusan"
        Me.JurusanBindingSource.DataSource = Me.SmkNasDataSet
        '
        'SmkNasDataSet
        '
        Me.SmkNasDataSet.DataSetName = "smkNasDataSet"
        Me.SmkNasDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.White
        Me.Label2.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(55, 230)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(110, 17)
        Me.Label2.TabIndex = 15
        Me.Label2.Text = "Informasi Jurusan"
        '
        'Label1
        '
        Me.Label1.BackColor = System.Drawing.SystemColors.Control
        Me.Label1.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(10, 211)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(360, 1)
        Me.Label1.TabIndex = 14
        '
        'info
        '
        Me.info.BackColor = System.Drawing.Color.White
        Me.info.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.info.ForeColor = System.Drawing.Color.Black
        Me.info.Location = New System.Drawing.Point(180, 15)
        Me.info.Name = "info"
        Me.info.Size = New System.Drawing.Size(185, 180)
        Me.info.TabIndex = 13
        Me.info.Text = resources.GetString("info.Text")
        '
        'fotoBox
        '
        Me.fotoBox.Location = New System.Drawing.Point(15, 15)
        Me.fotoBox.Name = "fotoBox"
        Me.fotoBox.Size = New System.Drawing.Size(150, 180)
        Me.fotoBox.TabIndex = 12
        Me.fotoBox.TabStop = False
        '
        'Konten
        '
        Me.Konten.BackColor = System.Drawing.Color.White
        Me.Konten.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Konten.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Konten.ForeColor = System.Drawing.Color.White
        Me.Konten.Location = New System.Drawing.Point(0, 0)
        Me.Konten.Name = "Konten"
        Me.Konten.Size = New System.Drawing.Size(380, 310)
        Me.Konten.TabIndex = 11
        '
        'sepRight
        '
        Me.sepRight.BackColor = System.Drawing.SystemColors.Control
        Me.sepRight.Dock = System.Windows.Forms.DockStyle.Right
        Me.sepRight.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.sepRight.ForeColor = System.Drawing.Color.White
        Me.sepRight.Location = New System.Drawing.Point(390, 160)
        Me.sepRight.Name = "sepRight"
        Me.sepRight.Size = New System.Drawing.Size(10, 310)
        Me.sepRight.TabIndex = 10
        '
        'sepLeft
        '
        Me.sepLeft.BackColor = System.Drawing.SystemColors.Control
        Me.sepLeft.Dock = System.Windows.Forms.DockStyle.Left
        Me.sepLeft.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.sepLeft.ForeColor = System.Drawing.Color.White
        Me.sepLeft.Location = New System.Drawing.Point(0, 160)
        Me.sepLeft.Name = "sepLeft"
        Me.sepLeft.Size = New System.Drawing.Size(10, 310)
        Me.sepLeft.TabIndex = 9
        '
        'sepTop
        '
        Me.sepTop.BackColor = System.Drawing.SystemColors.Control
        Me.sepTop.Dock = System.Windows.Forms.DockStyle.Top
        Me.sepTop.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.sepTop.ForeColor = System.Drawing.Color.White
        Me.sepTop.Location = New System.Drawing.Point(0, 150)
        Me.sepTop.Name = "sepTop"
        Me.sepTop.Size = New System.Drawing.Size(400, 10)
        Me.sepTop.TabIndex = 8
        '
        'sepBot
        '
        Me.sepBot.BackColor = System.Drawing.SystemColors.Control
        Me.sepBot.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.sepBot.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.sepBot.ForeColor = System.Drawing.Color.White
        Me.sepBot.Location = New System.Drawing.Point(0, 470)
        Me.sepBot.Name = "sepBot"
        Me.sepBot.Size = New System.Drawing.Size(400, 10)
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
        Me.PanelHeader.Size = New System.Drawing.Size(400, 150)
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
        Me.Title.Size = New System.Drawing.Size(400, 90)
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
        Me.subTitle.Size = New System.Drawing.Size(400, 30)
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
        Me.PanelWindowBar.Size = New System.Drawing.Size(400, 30)
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
        Me.windowBar.Size = New System.Drawing.Size(370, 30)
        Me.windowBar.TabIndex = 4
        Me.windowBar.Text = "Informasi Sekolah"
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
        Me.btnClose.Location = New System.Drawing.Point(370, 0)
        Me.btnClose.Name = "btnClose"
        Me.btnClose.Size = New System.Drawing.Size(30, 30)
        Me.btnClose.TabIndex = 2
        Me.btnClose.Text = "x"
        Me.btnClose.UseVisualStyleBackColor = False
        '
        'JurusanTableAdapter
        '
        Me.JurusanTableAdapter.ClearBeforeFill = True
        '
        'infoSekolah
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(402, 482)
        Me.Controls.Add(Me.PanelWrapper)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "infoSekolah"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "infoSekolah"
        Me.PanelWrapper.ResumeLayout(False)
        Me.PanelKonten.ResumeLayout(False)
        Me.PanelKonten.PerformLayout()
        CType(Me.JurusanBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SmkNasDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.fotoBox, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelHeader.ResumeLayout(False)
        Me.PanelWindowBar.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents PanelWrapper As Panel
    Friend WithEvents PanelKonten As Panel
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
    Friend WithEvents fotoBox As PictureBox
    Friend WithEvents info As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents cbJurusan As ComboBox
    Friend WithEvents SmkNasDataSet As smkNasDataSet
    Friend WithEvents JurusanBindingSource As BindingSource
    Friend WithEvents JurusanTableAdapter As smkNasDataSetTableAdapters.jurusanTableAdapter
    Friend WithEvents btnInfo As Button
End Class
