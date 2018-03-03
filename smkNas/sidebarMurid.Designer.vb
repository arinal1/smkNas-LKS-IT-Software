<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class sidebarMurid
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
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.btnHasil = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.btnTes = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Label3
        '
        Me.Label3.BackColor = System.Drawing.Color.FromArgb(CType(CType(52, Byte), Integer), CType(CType(73, Byte), Integer), CType(CType(94, Byte), Integer))
        Me.Label3.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Label3.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.White
        Me.Label3.Location = New System.Drawing.Point(0, 122)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(200, 318)
        Me.Label3.TabIndex = 17
        '
        'Label4
        '
        Me.Label4.BackColor = System.Drawing.Color.FromArgb(CType(CType(44, Byte), Integer), CType(CType(62, Byte), Integer), CType(CType(80, Byte), Integer))
        Me.Label4.Dock = System.Windows.Forms.DockStyle.Top
        Me.Label4.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.White
        Me.Label4.Location = New System.Drawing.Point(0, 121)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(200, 1)
        Me.Label4.TabIndex = 18
        '
        'btnHasil
        '
        Me.btnHasil.BackColor = System.Drawing.Color.FromArgb(CType(CType(52, Byte), Integer), CType(CType(73, Byte), Integer), CType(CType(94, Byte), Integer))
        Me.btnHasil.Dock = System.Windows.Forms.DockStyle.Top
        Me.btnHasil.FlatAppearance.BorderSize = 0
        Me.btnHasil.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnHasil.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnHasil.ForeColor = System.Drawing.Color.White
        Me.btnHasil.Location = New System.Drawing.Point(0, 61)
        Me.btnHasil.Name = "btnHasil"
        Me.btnHasil.Padding = New System.Windows.Forms.Padding(20, 0, 0, 0)
        Me.btnHasil.Size = New System.Drawing.Size(200, 60)
        Me.btnHasil.TabIndex = 16
        Me.btnHasil.Text = "Lihat Hasil Tes"
        Me.btnHasil.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnHasil.UseVisualStyleBackColor = False
        '
        'Label2
        '
        Me.Label2.BackColor = System.Drawing.Color.FromArgb(CType(CType(44, Byte), Integer), CType(CType(62, Byte), Integer), CType(CType(80, Byte), Integer))
        Me.Label2.Dock = System.Windows.Forms.DockStyle.Top
        Me.Label2.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.White
        Me.Label2.Location = New System.Drawing.Point(0, 60)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(200, 1)
        Me.Label2.TabIndex = 15
        '
        'btnTes
        '
        Me.btnTes.BackColor = System.Drawing.Color.FromArgb(CType(CType(46, Byte), Integer), CType(CType(136, Byte), Integer), CType(CType(197, Byte), Integer))
        Me.btnTes.Dock = System.Windows.Forms.DockStyle.Top
        Me.btnTes.FlatAppearance.BorderSize = 0
        Me.btnTes.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnTes.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnTes.ForeColor = System.Drawing.Color.White
        Me.btnTes.Location = New System.Drawing.Point(0, 0)
        Me.btnTes.Name = "btnTes"
        Me.btnTes.Padding = New System.Windows.Forms.Padding(20, 0, 0, 0)
        Me.btnTes.Size = New System.Drawing.Size(200, 60)
        Me.btnTes.TabIndex = 14
        Me.btnTes.Text = "Mulai Tes"
        Me.btnTes.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnTes.UseVisualStyleBackColor = False
        '
        'sidebarMurid
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(200, 440)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.btnHasil)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.btnTes)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "sidebarMurid"
        Me.Text = "sidebarMurid"
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents btnHasil As Button
    Friend WithEvents Label2 As Label
    Friend WithEvents btnTes As Button
End Class
