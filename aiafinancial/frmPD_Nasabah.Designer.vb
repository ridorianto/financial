<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmPD_Nasabah
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmPD_Nasabah))
        Me.Label1 = New System.Windows.Forms.Label
        Me.Label4 = New System.Windows.Forms.Label
        Me.Label11 = New System.Windows.Forms.Label
        Me.Label10 = New System.Windows.Forms.Label
        Me.DGV = New System.Windows.Forms.DataGridView
        Me.Label9 = New System.Windows.Forms.Label
        Me.Label8 = New System.Windows.Forms.Label
        Me.Label7 = New System.Windows.Forms.Label
        Me.Label6 = New System.Windows.Forms.Label
        Me.cmbKodeJenisKlaim = New System.Windows.Forms.ComboBox
        Me.Label5 = New System.Windows.Forms.Label
        Me.txtKodePenarikan = New System.Windows.Forms.TextBox
        Me.Label3 = New System.Windows.Forms.Label
        Me.Label2 = New System.Windows.Forms.Label
        Me.Panel1 = New System.Windows.Forms.Panel
        Me.PictureBox1 = New System.Windows.Forms.PictureBox
        Me.cmbKodeJenisPenarikan = New System.Windows.Forms.ComboBox
        Me.cmbNoDaftar = New System.Windows.Forms.ComboBox
        Me.txtNamaNasabah = New System.Windows.Forms.TextBox
        Me.txtNoRekening = New System.Windows.Forms.TextBox
        Me.txtJumlahDana = New System.Windows.Forms.TextBox
        Me.DateTimePicker1 = New System.Windows.Forms.DateTimePicker
        Me.txtKeterangan = New System.Windows.Forms.TextBox
        Me.txtNamaBank = New System.Windows.Forms.TextBox
        Me.txtJenisKlaim = New System.Windows.Forms.TextBox
        Me.txtJenisPenarikan = New System.Windows.Forms.TextBox
        Me.Label12 = New System.Windows.Forms.Label
        Me.Label13 = New System.Windows.Forms.Label
        Me.Label14 = New System.Windows.Forms.Label
        Me.txtNoPolis = New System.Windows.Forms.TextBox
        Me.Button4 = New System.Windows.Forms.Button
        Me.Button3 = New System.Windows.Forms.Button
        Me.Button2 = New System.Windows.Forms.Button
        Me.Button1 = New System.Windows.Forms.Button
        Me.Label15 = New System.Windows.Forms.Label
        Me.txtsisadana = New System.Windows.Forms.TextBox
        Me.txtTotalDana = New System.Windows.Forms.TextBox
        CType(Me.DGV, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Courier New", 21.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(124, 22)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(474, 33)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "FORM PENARIKAN DANA NASABAH"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(716, 124)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(97, 13)
        Me.Label4.TabIndex = 131
        Me.Label4.Text = "Tanggal Penarikan"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(716, 151)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(62, 13)
        Me.Label11.TabIndex = 132
        Me.Label11.Text = "Keterangan"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(716, 97)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(69, 13)
        Me.Label10.TabIndex = 123
        Me.Label10.Text = "Jumlah Dana"
        '
        'DGV
        '
        Me.DGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DGV.Location = New System.Drawing.Point(14, 265)
        Me.DGV.Name = "DGV"
        Me.DGV.Size = New System.Drawing.Size(1040, 197)
        Me.DGV.TabIndex = 116
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(353, 224)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(70, 13)
        Me.Label9.TabIndex = 122
        Me.Label9.Text = "No Rekening"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(353, 188)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(63, 13)
        Me.Label8.TabIndex = 121
        Me.Label8.Text = "Nama Bank"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(353, 128)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(81, 13)
        Me.Label7.TabIndex = 120
        Me.Label7.Text = "Nama Nasabah"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(353, 97)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(53, 13)
        Me.Label6.TabIndex = 119
        Me.Label6.Text = "No Daftar"
        '
        'cmbKodeJenisKlaim
        '
        Me.cmbKodeJenisKlaim.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbKodeJenisKlaim.FormattingEnabled = True
        Me.cmbKodeJenisKlaim.Items.AddRange(New Object() {"Pria", "Wanita"})
        Me.cmbKodeJenisKlaim.Location = New System.Drawing.Point(130, 125)
        Me.cmbKodeJenisKlaim.Name = "cmbKodeJenisKlaim"
        Me.cmbKodeJenisKlaim.Size = New System.Drawing.Size(145, 21)
        Me.cmbKodeJenisKlaim.TabIndex = 118
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(12, 187)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(82, 13)
        Me.Label5.TabIndex = 117
        Me.Label5.Text = "Jenis Penarikan"
        '
        'txtKodePenarikan
        '
        Me.txtKodePenarikan.Enabled = False
        Me.txtKodePenarikan.Location = New System.Drawing.Point(130, 94)
        Me.txtKodePenarikan.Multiline = True
        Me.txtKodePenarikan.Name = "txtKodePenarikan"
        Me.txtKodePenarikan.Size = New System.Drawing.Size(217, 25)
        Me.txtKodePenarikan.TabIndex = 111
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(11, 122)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(59, 13)
        Me.Label3.TabIndex = 110
        Me.Label3.Text = "Jenis Klaim"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(11, 94)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(83, 13)
        Me.Label2.TabIndex = 109
        Me.Label2.Text = "Kode Penarikan"
        '
        'Panel1
        '
        Me.Panel1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Panel1.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.Panel1.Controls.Add(Me.PictureBox1)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1067, 77)
        Me.Panel1.TabIndex = 108
        '
        'PictureBox1
        '
        Me.PictureBox1.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.PictureBox1.BackgroundImage = CType(resources.GetObject("PictureBox1.BackgroundImage"), System.Drawing.Image)
        Me.PictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.PictureBox1.Location = New System.Drawing.Point(10, 6)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(68, 60)
        Me.PictureBox1.TabIndex = 1
        Me.PictureBox1.TabStop = False
        '
        'cmbKodeJenisPenarikan
        '
        Me.cmbKodeJenisPenarikan.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbKodeJenisPenarikan.FormattingEnabled = True
        Me.cmbKodeJenisPenarikan.Items.AddRange(New Object() {"Pria", "Wanita"})
        Me.cmbKodeJenisPenarikan.Location = New System.Drawing.Point(130, 187)
        Me.cmbKodeJenisPenarikan.Name = "cmbKodeJenisPenarikan"
        Me.cmbKodeJenisPenarikan.Size = New System.Drawing.Size(145, 21)
        Me.cmbKodeJenisPenarikan.TabIndex = 135
        '
        'cmbNoDaftar
        '
        Me.cmbNoDaftar.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbNoDaftar.FormattingEnabled = True
        Me.cmbNoDaftar.Items.AddRange(New Object() {"Pria", "Wanita"})
        Me.cmbNoDaftar.Location = New System.Drawing.Point(440, 97)
        Me.cmbNoDaftar.Name = "cmbNoDaftar"
        Me.cmbNoDaftar.Size = New System.Drawing.Size(217, 21)
        Me.cmbNoDaftar.TabIndex = 136
        '
        'txtNamaNasabah
        '
        Me.txtNamaNasabah.Enabled = False
        Me.txtNamaNasabah.Location = New System.Drawing.Point(440, 123)
        Me.txtNamaNasabah.Multiline = True
        Me.txtNamaNasabah.Name = "txtNamaNasabah"
        Me.txtNamaNasabah.Size = New System.Drawing.Size(219, 25)
        Me.txtNamaNasabah.TabIndex = 138
        '
        'txtNoRekening
        '
        Me.txtNoRekening.Enabled = False
        Me.txtNoRekening.Location = New System.Drawing.Point(440, 216)
        Me.txtNoRekening.Multiline = True
        Me.txtNoRekening.Name = "txtNoRekening"
        Me.txtNoRekening.Size = New System.Drawing.Size(222, 25)
        Me.txtNoRekening.TabIndex = 139
        '
        'txtJumlahDana
        '
        Me.txtJumlahDana.Location = New System.Drawing.Point(819, 91)
        Me.txtJumlahDana.Multiline = True
        Me.txtJumlahDana.Name = "txtJumlahDana"
        Me.txtJumlahDana.Size = New System.Drawing.Size(170, 25)
        Me.txtJumlahDana.TabIndex = 140
        '
        'DateTimePicker1
        '
        Me.DateTimePicker1.Location = New System.Drawing.Point(819, 121)
        Me.DateTimePicker1.Name = "DateTimePicker1"
        Me.DateTimePicker1.Size = New System.Drawing.Size(200, 20)
        Me.DateTimePicker1.TabIndex = 141
        '
        'txtKeterangan
        '
        Me.txtKeterangan.Location = New System.Drawing.Point(819, 146)
        Me.txtKeterangan.Multiline = True
        Me.txtKeterangan.Name = "txtKeterangan"
        Me.txtKeterangan.Size = New System.Drawing.Size(235, 25)
        Me.txtKeterangan.TabIndex = 142
        '
        'txtNamaBank
        '
        Me.txtNamaBank.Enabled = False
        Me.txtNamaBank.Location = New System.Drawing.Point(440, 185)
        Me.txtNamaBank.Multiline = True
        Me.txtNamaBank.Name = "txtNamaBank"
        Me.txtNamaBank.Size = New System.Drawing.Size(242, 25)
        Me.txtNamaBank.TabIndex = 143
        '
        'txtJenisKlaim
        '
        Me.txtJenisKlaim.Enabled = False
        Me.txtJenisKlaim.Location = New System.Drawing.Point(130, 155)
        Me.txtJenisKlaim.Multiline = True
        Me.txtJenisKlaim.Name = "txtJenisKlaim"
        Me.txtJenisKlaim.Size = New System.Drawing.Size(219, 23)
        Me.txtJenisKlaim.TabIndex = 144
        '
        'txtJenisPenarikan
        '
        Me.txtJenisPenarikan.Enabled = False
        Me.txtJenisPenarikan.Location = New System.Drawing.Point(130, 218)
        Me.txtJenisPenarikan.Multiline = True
        Me.txtJenisPenarikan.Name = "txtJenisPenarikan"
        Me.txtJenisPenarikan.Size = New System.Drawing.Size(219, 24)
        Me.txtJenisPenarikan.TabIndex = 145
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(11, 155)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(59, 13)
        Me.Label12.TabIndex = 146
        Me.Label12.Text = "Jenis Klaim"
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Location = New System.Drawing.Point(11, 225)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(82, 13)
        Me.Label13.TabIndex = 147
        Me.Label13.Text = "Jenis Penarikan"
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Location = New System.Drawing.Point(353, 157)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(46, 13)
        Me.Label14.TabIndex = 120
        Me.Label14.Text = "No Polis"
        '
        'txtNoPolis
        '
        Me.txtNoPolis.Enabled = False
        Me.txtNoPolis.Location = New System.Drawing.Point(440, 154)
        Me.txtNoPolis.Multiline = True
        Me.txtNoPolis.Name = "txtNoPolis"
        Me.txtNoPolis.Size = New System.Drawing.Size(185, 25)
        Me.txtNoPolis.TabIndex = 138
        '
        'Button4
        '
        Me.Button4.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Button4.Image = Global.aiafinancial.My.Resources.Resources.refresh
        Me.Button4.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Button4.Location = New System.Drawing.Point(977, 206)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(75, 53)
        Me.Button4.TabIndex = 115
        Me.Button4.Text = "Batal"
        Me.Button4.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Button4.UseVisualStyleBackColor = True
        '
        'Button3
        '
        Me.Button3.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Button3.Image = Global.aiafinancial.My.Resources.Resources.Edit
        Me.Button3.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Button3.Location = New System.Drawing.Point(857, 206)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(75, 53)
        Me.Button3.TabIndex = 114
        Me.Button3.Text = "Update"
        Me.Button3.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Button3.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Button2.Image = Global.aiafinancial.My.Resources.Resources.delete
        Me.Button2.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Button2.Location = New System.Drawing.Point(775, 206)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(75, 53)
        Me.Button2.TabIndex = 113
        Me.Button2.Text = "Hapus"
        Me.Button2.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Button1
        '
        Me.Button1.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Button1.Image = Global.aiafinancial.My.Resources.Resources.add
        Me.Button1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Button1.Location = New System.Drawing.Point(695, 206)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 53)
        Me.Button1.TabIndex = 112
        Me.Button1.Text = "Simpan"
        Me.Button1.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Location = New System.Drawing.Point(716, 178)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(95, 13)
        Me.Label15.TabIndex = 132
        Me.Label15.Text = "Sisa Dana Seluruh"
        '
        'txtsisadana
        '
        Me.txtsisadana.Location = New System.Drawing.Point(819, 175)
        Me.txtsisadana.Multiline = True
        Me.txtsisadana.Name = "txtsisadana"
        Me.txtsisadana.Size = New System.Drawing.Size(170, 25)
        Me.txtsisadana.TabIndex = 142
        '
        'txtTotalDana
        '
        Me.txtTotalDana.Location = New System.Drawing.Point(485, 456)
        Me.txtTotalDana.Name = "txtTotalDana"
        Me.txtTotalDana.Size = New System.Drawing.Size(172, 20)
        Me.txtTotalDana.TabIndex = 148
        Me.txtTotalDana.Visible = False
        '
        'frmPD_Nasabah
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1066, 474)
        Me.Controls.Add(Me.txtTotalDana)
        Me.Controls.Add(Me.Label13)
        Me.Controls.Add(Me.Label12)
        Me.Controls.Add(Me.txtJenisPenarikan)
        Me.Controls.Add(Me.txtJenisKlaim)
        Me.Controls.Add(Me.txtNamaBank)
        Me.Controls.Add(Me.txtsisadana)
        Me.Controls.Add(Me.txtKeterangan)
        Me.Controls.Add(Me.DateTimePicker1)
        Me.Controls.Add(Me.txtJumlahDana)
        Me.Controls.Add(Me.txtNoRekening)
        Me.Controls.Add(Me.txtNoPolis)
        Me.Controls.Add(Me.txtNamaNasabah)
        Me.Controls.Add(Me.cmbNoDaftar)
        Me.Controls.Add(Me.cmbKodeJenisPenarikan)
        Me.Controls.Add(Me.Label15)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.DGV)
        Me.Controls.Add(Me.Button4)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.Label14)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.cmbKodeJenisKlaim)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.txtKodePenarikan)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Panel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow
        Me.Name = "frmPD_Nasabah"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        CType(Me.DGV, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents DGV As System.Windows.Forms.DataGridView
    Friend WithEvents Button4 As System.Windows.Forms.Button
    Friend WithEvents Button3 As System.Windows.Forms.Button
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents cmbKodeJenisKlaim As System.Windows.Forms.ComboBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents txtKodePenarikan As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents cmbKodeJenisPenarikan As System.Windows.Forms.ComboBox
    Friend WithEvents cmbNoDaftar As System.Windows.Forms.ComboBox
    Friend WithEvents txtNamaNasabah As System.Windows.Forms.TextBox
    Friend WithEvents txtNoRekening As System.Windows.Forms.TextBox
    Friend WithEvents txtJumlahDana As System.Windows.Forms.TextBox
    Friend WithEvents DateTimePicker1 As System.Windows.Forms.DateTimePicker
    Friend WithEvents txtKeterangan As System.Windows.Forms.TextBox
    Friend WithEvents txtNamaBank As System.Windows.Forms.TextBox
    Friend WithEvents txtJenisKlaim As System.Windows.Forms.TextBox
    Friend WithEvents txtJenisPenarikan As System.Windows.Forms.TextBox
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents Label14 As System.Windows.Forms.Label
    Friend WithEvents txtNoPolis As System.Windows.Forms.TextBox
    Friend WithEvents Label15 As System.Windows.Forms.Label
    Friend WithEvents txtsisadana As System.Windows.Forms.TextBox
    Friend WithEvents txtTotalDana As System.Windows.Forms.TextBox
End Class
