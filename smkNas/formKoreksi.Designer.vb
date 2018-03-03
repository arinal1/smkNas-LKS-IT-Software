<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class formKoreksi
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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.cbKode = New System.Windows.Forms.ComboBox()
        Me.tabelKoreksi = New System.Windows.Forms.DataGridView()
        Me.sepTop = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txCari = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.btnNilai = New System.Windows.Forms.Button()
        Me.btnDownload = New System.Windows.Forms.Button()
        Me.NoPesertaDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PilihanGandaDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.KodesoalDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.KodenilaiDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.FileDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ViewKoreksiBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.SmkNasDataSet = New smkNas.smkNasDataSet()
        Me.SoalBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.View_KoreksiTableAdapter = New smkNas.smkNasDataSetTableAdapters.View_KoreksiTableAdapter()
        Me.SoalTableAdapter = New smkNas.smkNasDataSetTableAdapters.soalTableAdapter()
        CType(Me.tabelKoreksi, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ViewKoreksiBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SmkNasDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SoalBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.BackColor = System.Drawing.Color.White
        Me.Label1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Label1.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(0, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(630, 60)
        Me.Label1.TabIndex = 7
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.White
        Me.Label2.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(20, 22)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(72, 17)
        Me.Label2.TabIndex = 14
        Me.Label2.Text = "Kode Ujian"
        '
        'cbKode
        '
        Me.cbKode.BackColor = System.Drawing.Color.White
        Me.cbKode.DataSource = Me.SoalBindingSource
        Me.cbKode.DisplayMember = "kode_soal"
        Me.cbKode.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbKode.FormattingEnabled = True
        Me.cbKode.Location = New System.Drawing.Point(100, 20)
        Me.cbKode.Name = "cbKode"
        Me.cbKode.Size = New System.Drawing.Size(200, 25)
        Me.cbKode.TabIndex = 16
        Me.cbKode.ValueMember = "kode_soal"
        '
        'tabelKoreksi
        '
        Me.tabelKoreksi.AllowUserToAddRows = False
        Me.tabelKoreksi.AllowUserToDeleteRows = False
        Me.tabelKoreksi.AllowUserToOrderColumns = True
        Me.tabelKoreksi.AutoGenerateColumns = False
        Me.tabelKoreksi.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.tabelKoreksi.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.tabelKoreksi.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.NoPesertaDataGridViewTextBoxColumn, Me.DataGridViewTextBoxColumn1, Me.PilihanGandaDataGridViewTextBoxColumn, Me.DataGridViewTextBoxColumn2, Me.DataGridViewTextBoxColumn3, Me.KodesoalDataGridViewTextBoxColumn, Me.KodenilaiDataGridViewTextBoxColumn, Me.FileDataGridViewTextBoxColumn})
        Me.tabelKoreksi.DataSource = Me.ViewKoreksiBindingSource
        Me.tabelKoreksi.Dock = System.Windows.Forms.DockStyle.Fill
        Me.tabelKoreksi.Location = New System.Drawing.Point(0, 65)
        Me.tabelKoreksi.Name = "tabelKoreksi"
        Me.tabelKoreksi.ReadOnly = True
        Me.tabelKoreksi.Size = New System.Drawing.Size(630, 300)
        Me.tabelKoreksi.TabIndex = 17
        '
        'sepTop
        '
        Me.sepTop.BackColor = System.Drawing.SystemColors.Control
        Me.sepTop.Dock = System.Windows.Forms.DockStyle.Top
        Me.sepTop.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.sepTop.ForeColor = System.Drawing.Color.White
        Me.sepTop.Location = New System.Drawing.Point(0, 60)
        Me.sepTop.Name = "sepTop"
        Me.sepTop.Size = New System.Drawing.Size(630, 5)
        Me.sepTop.TabIndex = 18
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.White
        Me.Label3.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(326, 23)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(78, 17)
        Me.Label3.TabIndex = 14
        Me.Label3.Text = "Cari Peserta"
        '
        'txCari
        '
        Me.txCari.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txCari.Location = New System.Drawing.Point(410, 20)
        Me.txCari.Name = "txCari"
        Me.txCari.Size = New System.Drawing.Size(200, 25)
        Me.txCari.TabIndex = 19
        '
        'Label4
        '
        Me.Label4.BackColor = System.Drawing.Color.White
        Me.Label4.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Label4.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.White
        Me.Label4.Location = New System.Drawing.Point(0, 370)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(630, 60)
        Me.Label4.TabIndex = 20
        '
        'Label5
        '
        Me.Label5.BackColor = System.Drawing.SystemColors.Control
        Me.Label5.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Label5.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.White
        Me.Label5.Location = New System.Drawing.Point(0, 365)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(630, 5)
        Me.Label5.TabIndex = 21
        '
        'btnNilai
        '
        Me.btnNilai.BackColor = System.Drawing.Color.FromArgb(CType(CType(52, Byte), Integer), CType(CType(152, Byte), Integer), CType(CType(220, Byte), Integer))
        Me.btnNilai.FlatAppearance.BorderSize = 0
        Me.btnNilai.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnNilai.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnNilai.ForeColor = System.Drawing.Color.White
        Me.btnNilai.Location = New System.Drawing.Point(483, 380)
        Me.btnNilai.Name = "btnNilai"
        Me.btnNilai.Size = New System.Drawing.Size(127, 40)
        Me.btnNilai.TabIndex = 22
        Me.btnNilai.Text = "Penilaian"
        Me.btnNilai.UseVisualStyleBackColor = False
        '
        'btnDownload
        '
        Me.btnDownload.BackColor = System.Drawing.Color.FromArgb(CType(CType(52, Byte), Integer), CType(CType(152, Byte), Integer), CType(CType(220, Byte), Integer))
        Me.btnDownload.FlatAppearance.BorderSize = 0
        Me.btnDownload.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnDownload.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnDownload.ForeColor = System.Drawing.Color.White
        Me.btnDownload.Location = New System.Drawing.Point(340, 380)
        Me.btnDownload.Name = "btnDownload"
        Me.btnDownload.Size = New System.Drawing.Size(127, 40)
        Me.btnDownload.TabIndex = 22
        Me.btnDownload.Text = "Download jawaban"
        Me.btnDownload.UseVisualStyleBackColor = False
        '
        'NoPesertaDataGridViewTextBoxColumn
        '
        Me.NoPesertaDataGridViewTextBoxColumn.DataPropertyName = "No Peserta"
        Me.NoPesertaDataGridViewTextBoxColumn.HeaderText = "No Peserta"
        Me.NoPesertaDataGridViewTextBoxColumn.Name = "NoPesertaDataGridViewTextBoxColumn"
        Me.NoPesertaDataGridViewTextBoxColumn.ReadOnly = True
        '
        'DataGridViewTextBoxColumn1
        '
        Me.DataGridViewTextBoxColumn1.DataPropertyName = "nama"
        Me.DataGridViewTextBoxColumn1.HeaderText = "Nama"
        Me.DataGridViewTextBoxColumn1.Name = "DataGridViewTextBoxColumn1"
        Me.DataGridViewTextBoxColumn1.ReadOnly = True
        '
        'PilihanGandaDataGridViewTextBoxColumn
        '
        Me.PilihanGandaDataGridViewTextBoxColumn.DataPropertyName = "Pilihan Ganda"
        Me.PilihanGandaDataGridViewTextBoxColumn.HeaderText = "Pilihan Ganda"
        Me.PilihanGandaDataGridViewTextBoxColumn.Name = "PilihanGandaDataGridViewTextBoxColumn"
        Me.PilihanGandaDataGridViewTextBoxColumn.ReadOnly = True
        '
        'DataGridViewTextBoxColumn2
        '
        Me.DataGridViewTextBoxColumn2.DataPropertyName = "essay"
        Me.DataGridViewTextBoxColumn2.HeaderText = "Essay"
        Me.DataGridViewTextBoxColumn2.Name = "DataGridViewTextBoxColumn2"
        Me.DataGridViewTextBoxColumn2.ReadOnly = True
        '
        'DataGridViewTextBoxColumn3
        '
        Me.DataGridViewTextBoxColumn3.DataPropertyName = "kasus"
        Me.DataGridViewTextBoxColumn3.HeaderText = "Kasus"
        Me.DataGridViewTextBoxColumn3.Name = "DataGridViewTextBoxColumn3"
        Me.DataGridViewTextBoxColumn3.ReadOnly = True
        '
        'KodesoalDataGridViewTextBoxColumn
        '
        Me.KodesoalDataGridViewTextBoxColumn.DataPropertyName = "kode_soal"
        Me.KodesoalDataGridViewTextBoxColumn.HeaderText = "kode_soal"
        Me.KodesoalDataGridViewTextBoxColumn.Name = "KodesoalDataGridViewTextBoxColumn"
        Me.KodesoalDataGridViewTextBoxColumn.ReadOnly = True
        Me.KodesoalDataGridViewTextBoxColumn.Visible = False
        '
        'KodenilaiDataGridViewTextBoxColumn
        '
        Me.KodenilaiDataGridViewTextBoxColumn.DataPropertyName = "kode_nilai"
        Me.KodenilaiDataGridViewTextBoxColumn.HeaderText = "kode_nilai"
        Me.KodenilaiDataGridViewTextBoxColumn.Name = "KodenilaiDataGridViewTextBoxColumn"
        Me.KodenilaiDataGridViewTextBoxColumn.ReadOnly = True
        Me.KodenilaiDataGridViewTextBoxColumn.Visible = False
        '
        'FileDataGridViewTextBoxColumn
        '
        Me.FileDataGridViewTextBoxColumn.DataPropertyName = "file"
        Me.FileDataGridViewTextBoxColumn.HeaderText = "file"
        Me.FileDataGridViewTextBoxColumn.Name = "FileDataGridViewTextBoxColumn"
        Me.FileDataGridViewTextBoxColumn.ReadOnly = True
        Me.FileDataGridViewTextBoxColumn.Visible = False
        '
        'ViewKoreksiBindingSource
        '
        Me.ViewKoreksiBindingSource.DataMember = "View_Koreksi"
        Me.ViewKoreksiBindingSource.DataSource = Me.SmkNasDataSet
        '
        'SmkNasDataSet
        '
        Me.SmkNasDataSet.DataSetName = "smkNasDataSet"
        Me.SmkNasDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'SoalBindingSource
        '
        Me.SoalBindingSource.DataMember = "soal"
        Me.SoalBindingSource.DataSource = Me.SmkNasDataSet
        '
        'View_KoreksiTableAdapter
        '
        Me.View_KoreksiTableAdapter.ClearBeforeFill = True
        '
        'SoalTableAdapter
        '
        Me.SoalTableAdapter.ClearBeforeFill = True
        '
        'formKoreksi
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.Control
        Me.ClientSize = New System.Drawing.Size(630, 430)
        Me.Controls.Add(Me.btnDownload)
        Me.Controls.Add(Me.btnNilai)
        Me.Controls.Add(Me.tabelKoreksi)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.txCari)
        Me.Controls.Add(Me.sepTop)
        Me.Controls.Add(Me.cbKode)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "formKoreksi"
        Me.Text = "formKoreksi"
        CType(Me.tabelKoreksi, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ViewKoreksiBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SmkNasDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SoalBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents cbKode As ComboBox
    Friend WithEvents tabelKoreksi As DataGridView
    Friend WithEvents sepTop As Label
    Friend WithEvents SmkNasDataSet As smkNasDataSet
    Friend WithEvents ViewKoreksiBindingSource As BindingSource
    Friend WithEvents View_KoreksiTableAdapter As smkNasDataSetTableAdapters.View_KoreksiTableAdapter
    Friend WithEvents Label3 As Label
    Friend WithEvents SoalBindingSource As BindingSource
    Friend WithEvents SoalTableAdapter As smkNasDataSetTableAdapters.soalTableAdapter
    Friend WithEvents txCari As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents btnNilai As Button
    Friend WithEvents btnDownload As Button
    Friend WithEvents NamaDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents EssayDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents KasusDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents NoPesertaDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn1 As DataGridViewTextBoxColumn
    Friend WithEvents PilihanGandaDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn2 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn3 As DataGridViewTextBoxColumn
    Friend WithEvents KodesoalDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents KodenilaiDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents FileDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
End Class
