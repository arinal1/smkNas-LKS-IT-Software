<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class formUnduhSoal
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
        Me.SoalTableAdapter = New smkNas.smkNasDataSetTableAdapters.soalTableAdapter()
        Me.btnDownload = New System.Windows.Forms.Button()
        Me.btnNilai = New System.Windows.Forms.Button()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.sepTop = New System.Windows.Forms.Label()
        Me.ViewKoreksiBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.SmkNasDataSet = New smkNas.smkNasDataSet()
        Me.tabelKoreksi = New System.Windows.Forms.DataGridView()
        Me.SoalBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.cbKode = New System.Windows.Forms.ComboBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.View_KoreksiTableAdapter = New smkNas.smkNasDataSetTableAdapters.View_KoreksiTableAdapter()
        Me.Label1 = New System.Windows.Forms.Label()
        CType(Me.ViewKoreksiBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SmkNasDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.tabelKoreksi, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SoalBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'SoalTableAdapter
        '
        Me.SoalTableAdapter.ClearBeforeFill = True
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
        Me.btnDownload.TabIndex = 32
        Me.btnDownload.Text = "Download jawaban"
        Me.btnDownload.UseVisualStyleBackColor = False
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
        Me.btnNilai.TabIndex = 33
        Me.btnNilai.Text = "Penilaian"
        Me.btnNilai.UseVisualStyleBackColor = False
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
        Me.Label5.TabIndex = 31
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
        Me.Label4.TabIndex = 30
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
        Me.sepTop.TabIndex = 28
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
        'tabelKoreksi
        '
        Me.tabelKoreksi.AllowUserToAddRows = False
        Me.tabelKoreksi.AllowUserToDeleteRows = False
        Me.tabelKoreksi.AllowUserToOrderColumns = True
        Me.tabelKoreksi.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.tabelKoreksi.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.tabelKoreksi.Dock = System.Windows.Forms.DockStyle.Fill
        Me.tabelKoreksi.Location = New System.Drawing.Point(0, 65)
        Me.tabelKoreksi.Name = "tabelKoreksi"
        Me.tabelKoreksi.ReadOnly = True
        Me.tabelKoreksi.Size = New System.Drawing.Size(630, 300)
        Me.tabelKoreksi.TabIndex = 27
        '
        'SoalBindingSource
        '
        Me.SoalBindingSource.DataMember = "soal"
        Me.SoalBindingSource.DataSource = Me.SmkNasDataSet
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
        Me.cbKode.TabIndex = 26
        Me.cbKode.ValueMember = "kode_soal"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.White
        Me.Label2.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(20, 22)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(72, 17)
        Me.Label2.TabIndex = 25
        Me.Label2.Text = "Kode Ujian"
        '
        'View_KoreksiTableAdapter
        '
        Me.View_KoreksiTableAdapter.ClearBeforeFill = True
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
        Me.Label1.TabIndex = 23
        '
        'formUnduhSoal
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(630, 430)
        Me.Controls.Add(Me.tabelKoreksi)
        Me.Controls.Add(Me.btnDownload)
        Me.Controls.Add(Me.btnNilai)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.sepTop)
        Me.Controls.Add(Me.cbKode)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "formUnduhSoal"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "formUnduhSoal"
        CType(Me.ViewKoreksiBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SmkNasDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.tabelKoreksi, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SoalBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents SoalTableAdapter As smkNasDataSetTableAdapters.soalTableAdapter
    Friend WithEvents btnDownload As Button
    Friend WithEvents btnNilai As Button
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents sepTop As Label
    Friend WithEvents ViewKoreksiBindingSource As BindingSource
    Friend WithEvents SmkNasDataSet As smkNasDataSet
    Friend WithEvents tabelKoreksi As DataGridView
    Friend WithEvents SoalBindingSource As BindingSource
    Friend WithEvents cbKode As ComboBox
    Friend WithEvents Label2 As Label
    Friend WithEvents View_KoreksiTableAdapter As smkNasDataSetTableAdapters.View_KoreksiTableAdapter
    Friend WithEvents Label1 As Label
End Class
