<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmS_Nasabah
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmS_Nasabah))
        Me.DateTimePicker1 = New System.Windows.Forms.DateTimePicker
        Me.txtJumlahSeluruh = New System.Windows.Forms.TextBox
        Me.txtNamaNasabah = New System.Windows.Forms.TextBox
        Me.cmbNoDaftar = New System.Windows.Forms.ComboBox
        Me.cmbKodeJenisSetoran = New System.Windows.Forms.ComboBox
        Me.Label10 = New System.Windows.Forms.Label
        Me.txtNoRekening = New System.Windows.Forms.TextBox
        Me.Label9 = New System.Windows.Forms.Label
        Me.Label8 = New System.Windows.Forms.Label
        Me.Label7 = New System.Windows.Forms.Label
        Me.Label1 = New System.Windows.Forms.Label
        Me.Label6 = New System.Windows.Forms.Label
        Me.cmbKodeJenisKlaim = New System.Windows.Forms.ComboBox
        Me.Label5 = New System.Windows.Forms.Label
        Me.txtKodeSetoran = New System.Windows.Forms.TextBox
        Me.Label3 = New System.Windows.Forms.Label
        Me.Label2 = New System.Windows.Forms.Label
        Me.Panel1 = New System.Windows.Forms.Panel
        Me.PictureBox1 = New System.Windows.Forms.PictureBox
        Me.Label4 = New System.Windows.Forms.Label
        Me.Label11 = New System.Windows.Forms.Label
        Me.txtJumlahSetoran = New System.Windows.Forms.TextBox
        Me.txtKeterangan = New System.Windows.Forms.TextBox
        Me.txtJenisKlaim = New System.Windows.Forms.TextBox
        Me.txtJenisSetoran = New System.Windows.Forms.TextBox
        Me.txtNoPolis = New System.Windows.Forms.TextBox
        Me.Label12 = New System.Windows.Forms.Label
        Me.Label13 = New System.Windows.Forms.Label
        Me.Label14 = New System.Windows.Forms.Label
        Me.DGV = New System.Windows.Forms.DataGridView
        Me.Button4 = New System.Windows.Forms.Button
        Me.Button3 = New System.Windows.Forms.Button
        Me.Button2 = New System.Windows.Forms.Button
        Me.Button1 = New System.Windows.Forms.Button
        Me.txtJumlah = New System.Windows.Forms.TextBox
        Me.Panel1.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DGV, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'DateTimePicker1
        '
        Me.DateTimePicker1.Location = New System.Drawing.Point(617, 156)
        Me.DateTimePicker1.Name = "DateTimePicker1"
        Me.DateTimePicker1.Size = New System.Drawing.Size(200, 20)
        Me.DateTimePicker1.TabIndex = 102
        '
        'txtJumlahSeluruh
        '
        Me.txtJumlahSeluruh.Enabled = False
        Me.txtJumlahSeluruh.Location = New System.Drawing.Point(617, 243)
        Me.txtJumlahSeluruh.Multiline = True
        Me.txtJumlahSeluruh.Name = "txtJumlahSeluruh"
        Me.txtJumlahSeluruh.Size = New System.Drawing.Size(217, 25)
        Me.txtJumlahSeluruh.TabIndex = 101
        '
        'txtNamaNasabah
        '
        Me.txtNamaNasabah.Enabled = False
        Me.txtNamaNasabah.Location = New System.Drawing.Point(128, 236)
        Me.txtNamaNasabah.Multiline = True
        Me.txtNamaNasabah.Name = "txtNamaNasabah"
        Me.txtNamaNasabah.Size = New System.Drawing.Size(219, 25)
        Me.txtNamaNasabah.TabIndex = 100
        '
        'cmbNoDaftar
        '
        Me.cmbNoDaftar.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbNoDaftar.FormattingEnabled = True
        Me.cmbNoDaftar.Location = New System.Drawing.Point(128, 179)
        Me.cmbNoDaftar.Name = "cmbNoDaftar"
        Me.cmbNoDaftar.Size = New System.Drawing.Size(202, 21)
        Me.cmbNoDaftar.TabIndex = 99
        '
        'cmbKodeJenisSetoran
        '
        Me.cmbKodeJenisSetoran.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbKodeJenisSetoran.FormattingEnabled = True
        Me.cmbKodeJenisSetoran.Items.AddRange(New Object() {""})
        Me.cmbKodeJenisSetoran.Location = New System.Drawing.Point(128, 152)
        Me.cmbKodeJenisSetoran.Name = "cmbKodeJenisSetoran"
        Me.cmbKodeJenisSetoran.Size = New System.Drawing.Size(145, 21)
        Me.cmbKodeJenisSetoran.TabIndex = 98
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(529, 128)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(69, 13)
        Me.Label10.TabIndex = 97
        Me.Label10.Text = "Jumlah Dana"
        '
        'txtNoRekening
        '
        Me.txtNoRekening.Enabled = False
        Me.txtNoRekening.Location = New System.Drawing.Point(617, 91)
        Me.txtNoRekening.Multiline = True
        Me.txtNoRekening.Name = "txtNoRekening"
        Me.txtNoRekening.Size = New System.Drawing.Size(249, 25)
        Me.txtNoRekening.TabIndex = 103
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(529, 97)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(70, 13)
        Me.Label9.TabIndex = 96
        Me.Label9.Text = "No Rekening"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(503, 248)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(108, 13)
        Me.Label8.TabIndex = 95
        Me.Label8.Text = "Jumlah Dana Seluruh"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(9, 236)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(81, 13)
        Me.Label7.TabIndex = 94
        Me.Label7.Text = "Nama Nasabah"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Courier New", 21.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(122, 19)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(355, 33)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "FORM SETORAN NASABAH"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(10, 179)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(53, 13)
        Me.Label6.TabIndex = 93
        Me.Label6.Text = "No Daftar"
        '
        'cmbKodeJenisKlaim
        '
        Me.cmbKodeJenisKlaim.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbKodeJenisKlaim.FormattingEnabled = True
        Me.cmbKodeJenisKlaim.Location = New System.Drawing.Point(128, 125)
        Me.cmbKodeJenisKlaim.Name = "cmbKodeJenisKlaim"
        Me.cmbKodeJenisKlaim.Size = New System.Drawing.Size(145, 21)
        Me.cmbKodeJenisKlaim.TabIndex = 92
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(10, 152)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(99, 13)
        Me.Label5.TabIndex = 91
        Me.Label5.Text = "Kode Jenis Setoran"
        '
        'txtKodeSetoran
        '
        Me.txtKodeSetoran.Enabled = False
        Me.txtKodeSetoran.Location = New System.Drawing.Point(128, 94)
        Me.txtKodeSetoran.Multiline = True
        Me.txtKodeSetoran.Name = "txtKodeSetoran"
        Me.txtKodeSetoran.Size = New System.Drawing.Size(217, 25)
        Me.txtKodeSetoran.TabIndex = 85
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(9, 122)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(87, 13)
        Me.Label3.TabIndex = 84
        Me.Label3.Text = "Kode Jenis Klaim"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(9, 94)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(72, 13)
        Me.Label2.TabIndex = 83
        Me.Label2.Text = "Kode Setoran"
        '
        'Panel1
        '
        Me.Panel1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Panel1.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.Panel1.Controls.Add(Me.PictureBox1)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Location = New System.Drawing.Point(-2, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(881, 77)
        Me.Panel1.TabIndex = 82
        '
        'PictureBox1
        '
        Me.PictureBox1.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.PictureBox1.BackgroundImage = CType(resources.GetObject("PictureBox1.BackgroundImage"), System.Drawing.Image)
        Me.PictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.PictureBox1.Location = New System.Drawing.Point(8, 3)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(68, 60)
        Me.PictureBox1.TabIndex = 1
        Me.PictureBox1.TabStop = False
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(529, 162)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(86, 13)
        Me.Label4.TabIndex = 105
        Me.Label4.Text = "Tanggal Setoran"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(529, 205)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(62, 13)
        Me.Label11.TabIndex = 106
        Me.Label11.Text = "Keterangan"
        '
        'txtJumlahSetoran
        '
        Me.txtJumlahSetoran.Location = New System.Drawing.Point(617, 125)
        Me.txtJumlahSetoran.Multiline = True
        Me.txtJumlahSetoran.Name = "txtJumlahSetoran"
        Me.txtJumlahSetoran.Size = New System.Drawing.Size(249, 25)
        Me.txtJumlahSetoran.TabIndex = 107
        '
        'txtKeterangan
        '
        Me.txtKeterangan.Location = New System.Drawing.Point(617, 182)
        Me.txtKeterangan.Multiline = True
        Me.txtKeterangan.Name = "txtKeterangan"
        Me.txtKeterangan.Size = New System.Drawing.Size(249, 55)
        Me.txtKeterangan.TabIndex = 108
        '
        'txtJenisKlaim
        '
        Me.txtJenisKlaim.Enabled = False
        Me.txtJenisKlaim.Location = New System.Drawing.Point(355, 125)
        Me.txtJenisKlaim.Name = "txtJenisKlaim"
        Me.txtJenisKlaim.Size = New System.Drawing.Size(168, 20)
        Me.txtJenisKlaim.TabIndex = 109
        '
        'txtJenisSetoran
        '
        Me.txtJenisSetoran.Enabled = False
        Me.txtJenisSetoran.Location = New System.Drawing.Point(354, 153)
        Me.txtJenisSetoran.Name = "txtJenisSetoran"
        Me.txtJenisSetoran.Size = New System.Drawing.Size(169, 20)
        Me.txtJenisSetoran.TabIndex = 110
        '
        'txtNoPolis
        '
        Me.txtNoPolis.Enabled = False
        Me.txtNoPolis.Location = New System.Drawing.Point(128, 205)
        Me.txtNoPolis.Multiline = True
        Me.txtNoPolis.Name = "txtNoPolis"
        Me.txtNoPolis.Size = New System.Drawing.Size(219, 25)
        Me.txtNoPolis.TabIndex = 112
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(10, 205)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(46, 13)
        Me.Label12.TabIndex = 111
        Me.Label12.Text = "No Polis"
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Location = New System.Drawing.Point(279, 128)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(59, 13)
        Me.Label13.TabIndex = 113
        Me.Label13.Text = "Jenis Klaim"
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Location = New System.Drawing.Point(279, 156)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(71, 13)
        Me.Label14.TabIndex = 114
        Me.Label14.Text = "Jenis Setoran"
        '
        'DGV
        '
        Me.DGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DGV.Location = New System.Drawing.Point(13, 363)
        Me.DGV.Name = "DGV"
        Me.DGV.Size = New System.Drawing.Size(853, 167)
        Me.DGV.TabIndex = 116
        '
        'Button4
        '
        Me.Button4.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Button4.Image = Global.aiafinancial.My.Resources.Resources.refresh
        Me.Button4.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Button4.Location = New System.Drawing.Point(791, 312)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(75, 45)
        Me.Button4.TabIndex = 89
        Me.Button4.Text = "Batal"
        Me.Button4.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Button4.UseVisualStyleBackColor = True
        '
        'Button3
        '
        Me.Button3.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Button3.Image = Global.aiafinancial.My.Resources.Resources.Edit
        Me.Button3.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Button3.Location = New System.Drawing.Point(178, 312)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(75, 45)
        Me.Button3.TabIndex = 88
        Me.Button3.Text = "Ubah"
        Me.Button3.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Button3.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Button2.Image = Global.aiafinancial.My.Resources.Resources.delete
        Me.Button2.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Button2.Location = New System.Drawing.Point(96, 312)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(75, 45)
        Me.Button2.TabIndex = 87
        Me.Button2.Text = "Hapus"
        Me.Button2.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Button1
        '
        Me.Button1.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Button1.Image = Global.aiafinancial.My.Resources.Resources.add
        Me.Button1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Button1.Location = New System.Drawing.Point(16, 312)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 45)
        Me.Button1.TabIndex = 86
        Me.Button1.Text = "Simpan"
        Me.Button1.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Button1.UseVisualStyleBackColor = True
        '
        'txtJumlah
        '
        Me.txtJumlah.Location = New System.Drawing.Point(425, 301)
        Me.txtJumlah.Name = "txtJumlah"
        Me.txtJumlah.Size = New System.Drawing.Size(166, 20)
        Me.txtJumlah.TabIndex = 117
        Me.txtJumlah.Visible = False
        '
        'frmS_Nasabah
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(878, 545)
        Me.Controls.Add(Me.txtJumlah)
        Me.Controls.Add(Me.DGV)
        Me.Controls.Add(Me.Label14)
        Me.Controls.Add(Me.Label13)
        Me.Controls.Add(Me.txtNoPolis)
        Me.Controls.Add(Me.Label12)
        Me.Controls.Add(Me.txtJenisSetoran)
        Me.Controls.Add(Me.txtJenisKlaim)
        Me.Controls.Add(Me.txtKeterangan)
        Me.Controls.Add(Me.txtJumlahSetoran)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.DateTimePicker1)
        Me.Controls.Add(Me.txtJumlahSeluruh)
        Me.Controls.Add(Me.txtNamaNasabah)
        Me.Controls.Add(Me.cmbNoDaftar)
        Me.Controls.Add(Me.cmbKodeJenisSetoran)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.Button4)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.txtNoRekening)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.cmbKodeJenisKlaim)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.txtKodeSetoran)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Panel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow
        Me.Name = "frmS_Nasabah"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DGV, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents DateTimePicker1 As System.Windows.Forms.DateTimePicker
    Friend WithEvents txtJumlahSeluruh As System.Windows.Forms.TextBox
    Friend WithEvents txtNamaNasabah As System.Windows.Forms.TextBox
    Friend WithEvents cmbNoDaftar As System.Windows.Forms.ComboBox
    Friend WithEvents cmbKodeJenisSetoran As System.Windows.Forms.ComboBox
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents Button4 As System.Windows.Forms.Button
    Friend WithEvents Button3 As System.Windows.Forms.Button
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents txtNoRekening As System.Windows.Forms.TextBox
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents cmbKodeJenisKlaim As System.Windows.Forms.ComboBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents txtKodeSetoran As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents txtJumlahSetoran As System.Windows.Forms.TextBox
    Friend WithEvents txtKeterangan As System.Windows.Forms.TextBox
    Friend WithEvents txtJenisKlaim As System.Windows.Forms.TextBox
    Friend WithEvents txtJenisSetoran As System.Windows.Forms.TextBox
    Friend WithEvents txtNoPolis As System.Windows.Forms.TextBox
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents Label14 As System.Windows.Forms.Label
    Friend WithEvents DGV As System.Windows.Forms.DataGridView
    Friend WithEvents txtJumlah As System.Windows.Forms.TextBox
End Class
