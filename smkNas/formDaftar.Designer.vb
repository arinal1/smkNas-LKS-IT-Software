<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class formDaftar
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
        Me.PanelWrapper = New System.Windows.Forms.Panel()
        Me.PanelKonten = New System.Windows.Forms.Panel()
        Me.btnUlang = New System.Windows.Forms.Button()
        Me.btnDaftar = New System.Windows.Forms.Button()
        Me.DatePicker = New System.Windows.Forms.DateTimePicker()
        Me.cbAgama = New System.Windows.Forms.ComboBox()
        Me.cbJurusan3 = New System.Windows.Forms.ComboBox()
        Me.JurusanBindingSource2 = New System.Windows.Forms.BindingSource(Me.components)
        Me.SmkNasDataSet = New smkNas.smkNasDataSet()
        Me.cbJurusan2 = New System.Windows.Forms.ComboBox()
        Me.JurusanBindingSource1 = New System.Windows.Forms.BindingSource(Me.components)
        Me.cbJurusan1 = New System.Windows.Forms.ComboBox()
        Me.JurusanBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.cbKelamin = New System.Windows.Forms.ComboBox()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.txEmail = New System.Windows.Forms.TextBox()
        Me.txAlamat = New System.Windows.Forms.TextBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txNama = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
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
        Me.PesertaBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.PesertaTableAdapter = New smkNas.smkNasDataSetTableAdapters.pesertaTableAdapter()
        Me.PanelWrapper.SuspendLayout()
        Me.PanelKonten.SuspendLayout()
        CType(Me.JurusanBindingSource2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SmkNasDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.JurusanBindingSource1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.JurusanBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanelHeader.SuspendLayout()
        Me.PanelWindowBar.SuspendLayout()
        CType(Me.PesertaBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
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
        Me.PanelWrapper.Size = New System.Drawing.Size(682, 530)
        Me.PanelWrapper.TabIndex = 13
        '
        'PanelKonten
        '
        Me.PanelKonten.Controls.Add(Me.btnUlang)
        Me.PanelKonten.Controls.Add(Me.btnDaftar)
        Me.PanelKonten.Controls.Add(Me.DatePicker)
        Me.PanelKonten.Controls.Add(Me.cbAgama)
        Me.PanelKonten.Controls.Add(Me.cbJurusan3)
        Me.PanelKonten.Controls.Add(Me.cbJurusan2)
        Me.PanelKonten.Controls.Add(Me.cbJurusan1)
        Me.PanelKonten.Controls.Add(Me.cbKelamin)
        Me.PanelKonten.Controls.Add(Me.Label12)
        Me.PanelKonten.Controls.Add(Me.Label11)
        Me.PanelKonten.Controls.Add(Me.txEmail)
        Me.PanelKonten.Controls.Add(Me.txAlamat)
        Me.PanelKonten.Controls.Add(Me.Label9)
        Me.PanelKonten.Controls.Add(Me.Label8)
        Me.PanelKonten.Controls.Add(Me.Label6)
        Me.PanelKonten.Controls.Add(Me.Label7)
        Me.PanelKonten.Controls.Add(Me.Label10)
        Me.PanelKonten.Controls.Add(Me.Label4)
        Me.PanelKonten.Controls.Add(Me.Label5)
        Me.PanelKonten.Controls.Add(Me.txNama)
        Me.PanelKonten.Controls.Add(Me.Label3)
        Me.PanelKonten.Controls.Add(Me.Label2)
        Me.PanelKonten.Controls.Add(Me.Label1)
        Me.PanelKonten.Controls.Add(Me.Konten)
        Me.PanelKonten.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PanelKonten.Location = New System.Drawing.Point(10, 160)
        Me.PanelKonten.Name = "PanelKonten"
        Me.PanelKonten.Size = New System.Drawing.Size(660, 358)
        Me.PanelKonten.TabIndex = 15
        '
        'btnUlang
        '
        Me.btnUlang.BackColor = System.Drawing.Color.FromArgb(CType(CType(52, Byte), Integer), CType(CType(152, Byte), Integer), CType(CType(220, Byte), Integer))
        Me.btnUlang.FlatAppearance.BorderSize = 0
        Me.btnUlang.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnUlang.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnUlang.ForeColor = System.Drawing.Color.White
        Me.btnUlang.Location = New System.Drawing.Point(421, 310)
        Me.btnUlang.Name = "btnUlang"
        Me.btnUlang.Size = New System.Drawing.Size(100, 40)
        Me.btnUlang.TabIndex = 17
        Me.btnUlang.Text = "Reset"
        Me.btnUlang.UseVisualStyleBackColor = False
        '
        'btnDaftar
        '
        Me.btnDaftar.BackColor = System.Drawing.Color.FromArgb(CType(CType(52, Byte), Integer), CType(CType(152, Byte), Integer), CType(CType(220, Byte), Integer))
        Me.btnDaftar.FlatAppearance.BorderSize = 0
        Me.btnDaftar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnDaftar.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnDaftar.ForeColor = System.Drawing.Color.White
        Me.btnDaftar.Location = New System.Drawing.Point(550, 310)
        Me.btnDaftar.Name = "btnDaftar"
        Me.btnDaftar.Size = New System.Drawing.Size(100, 40)
        Me.btnDaftar.TabIndex = 17
        Me.btnDaftar.Text = "Daftar"
        Me.btnDaftar.UseVisualStyleBackColor = False
        '
        'DatePicker
        '
        Me.DatePicker.CalendarFont = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DatePicker.Location = New System.Drawing.Point(443, 12)
        Me.DatePicker.Name = "DatePicker"
        Me.DatePicker.Size = New System.Drawing.Size(200, 20)
        Me.DatePicker.TabIndex = 16
        '
        'cbAgama
        '
        Me.cbAgama.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbAgama.FormattingEnabled = True
        Me.cbAgama.Items.AddRange(New Object() {"Islam", "Kristen", "Katholik", "Hindu", "Budha"})
        Me.cbAgama.Location = New System.Drawing.Point(443, 62)
        Me.cbAgama.Name = "cbAgama"
        Me.cbAgama.Size = New System.Drawing.Size(200, 25)
        Me.cbAgama.TabIndex = 15
        '
        'cbJurusan3
        '
        Me.cbJurusan3.DataSource = Me.JurusanBindingSource2
        Me.cbJurusan3.DisplayMember = "nama"
        Me.cbJurusan3.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbJurusan3.FormattingEnabled = True
        Me.cbJurusan3.Location = New System.Drawing.Point(443, 207)
        Me.cbJurusan3.Name = "cbJurusan3"
        Me.cbJurusan3.Size = New System.Drawing.Size(200, 25)
        Me.cbJurusan3.TabIndex = 15
        Me.cbJurusan3.ValueMember = "kode_jurusan"
        '
        'JurusanBindingSource2
        '
        Me.JurusanBindingSource2.DataMember = "jurusan"
        Me.JurusanBindingSource2.DataSource = Me.SmkNasDataSet
        '
        'SmkNasDataSet
        '
        Me.SmkNasDataSet.DataSetName = "smkNasDataSet"
        Me.SmkNasDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'cbJurusan2
        '
        Me.cbJurusan2.DataSource = Me.JurusanBindingSource1
        Me.cbJurusan2.DisplayMember = "nama"
        Me.cbJurusan2.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbJurusan2.FormattingEnabled = True
        Me.cbJurusan2.Location = New System.Drawing.Point(100, 257)
        Me.cbJurusan2.Name = "cbJurusan2"
        Me.cbJurusan2.Size = New System.Drawing.Size(200, 25)
        Me.cbJurusan2.TabIndex = 15
        Me.cbJurusan2.ValueMember = "kode_jurusan"
        '
        'JurusanBindingSource1
        '
        Me.JurusanBindingSource1.DataMember = "jurusan"
        Me.JurusanBindingSource1.DataSource = Me.SmkNasDataSet
        '
        'cbJurusan1
        '
        Me.cbJurusan1.DataSource = Me.JurusanBindingSource
        Me.cbJurusan1.DisplayMember = "nama"
        Me.cbJurusan1.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbJurusan1.FormattingEnabled = True
        Me.cbJurusan1.Location = New System.Drawing.Point(100, 207)
        Me.cbJurusan1.Name = "cbJurusan1"
        Me.cbJurusan1.Size = New System.Drawing.Size(200, 25)
        Me.cbJurusan1.TabIndex = 15
        Me.cbJurusan1.ValueMember = "kode_jurusan"
        '
        'JurusanBindingSource
        '
        Me.JurusanBindingSource.DataMember = "jurusan"
        Me.JurusanBindingSource.DataSource = Me.SmkNasDataSet
        '
        'cbKelamin
        '
        Me.cbKelamin.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbKelamin.FormattingEnabled = True
        Me.cbKelamin.Items.AddRange(New Object() {"Laki-Laki", "Perempuan"})
        Me.cbKelamin.Location = New System.Drawing.Point(100, 62)
        Me.cbKelamin.Name = "cbKelamin"
        Me.cbKelamin.Size = New System.Drawing.Size(200, 25)
        Me.cbKelamin.TabIndex = 15
        '
        'Label12
        '
        Me.Label12.BackColor = System.Drawing.SystemColors.Control
        Me.Label12.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.ForeColor = System.Drawing.Color.White
        Me.Label12.Location = New System.Drawing.Point(10, 300)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(640, 2)
        Me.Label12.TabIndex = 14
        '
        'Label11
        '
        Me.Label11.BackColor = System.Drawing.SystemColors.Control
        Me.Label11.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.ForeColor = System.Drawing.SystemColors.ControlDark
        Me.Label11.Location = New System.Drawing.Point(10, 186)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(640, 2)
        Me.Label11.TabIndex = 14
        '
        'txEmail
        '
        Me.txEmail.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txEmail.Location = New System.Drawing.Point(443, 112)
        Me.txEmail.Name = "txEmail"
        Me.txEmail.Size = New System.Drawing.Size(200, 25)
        Me.txEmail.TabIndex = 1
        '
        'txAlamat
        '
        Me.txAlamat.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txAlamat.Location = New System.Drawing.Point(100, 112)
        Me.txAlamat.Name = "txAlamat"
        Me.txAlamat.Size = New System.Drawing.Size(200, 25)
        Me.txAlamat.TabIndex = 0
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.BackColor = System.Drawing.Color.White
        Me.Label9.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(350, 210)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(63, 17)
        Me.Label9.TabIndex = 13
        Me.Label9.Text = "Jurusan 3"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.BackColor = System.Drawing.Color.White
        Me.Label8.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(10, 260)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(63, 17)
        Me.Label8.TabIndex = 13
        Me.Label8.Text = "Jurusan 2"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.BackColor = System.Drawing.Color.White
        Me.Label6.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(350, 115)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(39, 17)
        Me.Label6.TabIndex = 13
        Me.Label6.Text = "Email"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.BackColor = System.Drawing.Color.White
        Me.Label7.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(10, 210)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(63, 17)
        Me.Label7.TabIndex = 13
        Me.Label7.Text = "Jurusan 1"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.BackColor = System.Drawing.Color.White
        Me.Label10.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.ForeColor = System.Drawing.SystemColors.ControlDark
        Me.Label10.Location = New System.Drawing.Point(10, 166)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(93, 17)
        Me.Label10.TabIndex = 13
        Me.Label10.Text = "Pilihan Jurusan"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.White
        Me.Label4.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(10, 115)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(48, 17)
        Me.Label4.TabIndex = 13
        Me.Label4.Text = "Alamat"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.BackColor = System.Drawing.Color.White
        Me.Label5.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(350, 65)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(49, 17)
        Me.Label5.TabIndex = 13
        Me.Label5.Text = "Agama"
        '
        'txNama
        '
        Me.txNama.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txNama.Location = New System.Drawing.Point(100, 12)
        Me.txNama.Name = "txNama"
        Me.txNama.Size = New System.Drawing.Size(200, 25)
        Me.txNama.TabIndex = 0
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.White
        Me.Label3.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(350, 15)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(86, 17)
        Me.Label3.TabIndex = 13
        Me.Label3.Text = "Tanggal Lahir"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.White
        Me.Label2.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(10, 65)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(86, 17)
        Me.Label2.TabIndex = 13
        Me.Label2.Text = "Jenis Kelamin"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.White
        Me.Label1.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(10, 15)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(43, 17)
        Me.Label1.TabIndex = 13
        Me.Label1.Text = "Nama"
        '
        'Konten
        '
        Me.Konten.BackColor = System.Drawing.Color.White
        Me.Konten.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Konten.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Konten.ForeColor = System.Drawing.Color.White
        Me.Konten.Location = New System.Drawing.Point(0, 0)
        Me.Konten.Name = "Konten"
        Me.Konten.Size = New System.Drawing.Size(660, 358)
        Me.Konten.TabIndex = 11
        '
        'sepRight
        '
        Me.sepRight.BackColor = System.Drawing.SystemColors.Control
        Me.sepRight.Dock = System.Windows.Forms.DockStyle.Right
        Me.sepRight.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.sepRight.ForeColor = System.Drawing.Color.White
        Me.sepRight.Location = New System.Drawing.Point(670, 160)
        Me.sepRight.Name = "sepRight"
        Me.sepRight.Size = New System.Drawing.Size(10, 358)
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
        Me.sepLeft.Size = New System.Drawing.Size(10, 358)
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
        Me.sepTop.Size = New System.Drawing.Size(680, 10)
        Me.sepTop.TabIndex = 8
        '
        'sepBot
        '
        Me.sepBot.BackColor = System.Drawing.SystemColors.Control
        Me.sepBot.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.sepBot.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.sepBot.ForeColor = System.Drawing.Color.White
        Me.sepBot.Location = New System.Drawing.Point(0, 518)
        Me.sepBot.Name = "sepBot"
        Me.sepBot.Size = New System.Drawing.Size(680, 10)
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
        Me.PanelHeader.Size = New System.Drawing.Size(680, 150)
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
        Me.Title.Size = New System.Drawing.Size(680, 90)
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
        Me.subTitle.Size = New System.Drawing.Size(680, 30)
        Me.subTitle.TabIndex = 6
        Me.subTitle.Text = "Mohon Masukkan Data Anda Dengan Benar dan Lengkap"
        Me.subTitle.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'PanelWindowBar
        '
        Me.PanelWindowBar.BackColor = System.Drawing.Color.FromArgb(CType(CType(44, Byte), Integer), CType(CType(62, Byte), Integer), CType(CType(80, Byte), Integer))
        Me.PanelWindowBar.Controls.Add(Me.windowBar)
        Me.PanelWindowBar.Controls.Add(Me.btnClose)
        Me.PanelWindowBar.Dock = System.Windows.Forms.DockStyle.Top
        Me.PanelWindowBar.Location = New System.Drawing.Point(0, 0)
        Me.PanelWindowBar.Name = "PanelWindowBar"
        Me.PanelWindowBar.Size = New System.Drawing.Size(680, 30)
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
        Me.windowBar.Size = New System.Drawing.Size(650, 30)
        Me.windowBar.TabIndex = 4
        Me.windowBar.Text = "Pendaftaran Calon Siswa"
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
        Me.btnClose.Location = New System.Drawing.Point(650, 0)
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
        'PesertaBindingSource
        '
        Me.PesertaBindingSource.DataMember = "peserta"
        Me.PesertaBindingSource.DataSource = Me.SmkNasDataSet
        '
        'PesertaTableAdapter
        '
        Me.PesertaTableAdapter.ClearBeforeFill = True
        '
        'formDaftar
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(682, 530)
        Me.Controls.Add(Me.PanelWrapper)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "formDaftar"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "formDaftar"
        Me.PanelWrapper.ResumeLayout(False)
        Me.PanelKonten.ResumeLayout(False)
        Me.PanelKonten.PerformLayout()
        CType(Me.JurusanBindingSource2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SmkNasDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.JurusanBindingSource1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.JurusanBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelHeader.ResumeLayout(False)
        Me.PanelWindowBar.ResumeLayout(False)
        CType(Me.PesertaBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents PanelWrapper As Panel
    Friend WithEvents PanelKonten As Panel
    Friend WithEvents txNama As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
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
    Friend WithEvents DatePicker As DateTimePicker
    Friend WithEvents cbAgama As ComboBox
    Friend WithEvents cbKelamin As ComboBox
    Friend WithEvents Label12 As Label
    Friend WithEvents Label11 As Label
    Friend WithEvents txEmail As TextBox
    Friend WithEvents txAlamat As TextBox
    Friend WithEvents Label9 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents btnDaftar As Button
    Friend WithEvents btnUlang As Button
    Friend WithEvents cbJurusan1 As ComboBox
    Friend WithEvents SmkNasDataSet As smkNasDataSet
    Friend WithEvents JurusanBindingSource As BindingSource
    Friend WithEvents JurusanTableAdapter As smkNasDataSetTableAdapters.jurusanTableAdapter
    Friend WithEvents cbJurusan3 As ComboBox
    Friend WithEvents cbJurusan2 As ComboBox
    Friend WithEvents PesertaBindingSource As BindingSource
    Friend WithEvents PesertaTableAdapter As smkNasDataSetTableAdapters.pesertaTableAdapter
    Friend WithEvents JurusanBindingSource2 As BindingSource
    Friend WithEvents JurusanBindingSource1 As BindingSource
End Class
