<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmK_Nasabah
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmK_Nasabah))
        Me.Label10 = New System.Windows.Forms.Label
        Me.Label9 = New System.Windows.Forms.Label
        Me.Label8 = New System.Windows.Forms.Label
        Me.Label7 = New System.Windows.Forms.Label
        Me.Label6 = New System.Windows.Forms.Label
        Me.cmbKodeJenisKlaim = New System.Windows.Forms.ComboBox
        Me.Label5 = New System.Windows.Forms.Label
        Me.txtKodeKlaim = New System.Windows.Forms.TextBox
        Me.Label3 = New System.Windows.Forms.Label
        Me.Label2 = New System.Windows.Forms.Label
        Me.Panel1 = New System.Windows.Forms.Panel
        Me.Label1 = New System.Windows.Forms.Label
        Me.cmbNo_Daftar = New System.Windows.Forms.ComboBox
        Me.txtNamaNasabah = New System.Windows.Forms.TextBox
        Me.txtNamaBank = New System.Windows.Forms.TextBox
        Me.DateTimePicker1 = New System.Windows.Forms.DateTimePicker
        Me.txtNoRekening = New System.Windows.Forms.TextBox
        Me.txtKeterangan = New System.Windows.Forms.TextBox
        Me.txtJenisKlaim = New System.Windows.Forms.TextBox
        Me.Label4 = New System.Windows.Forms.Label
        Me.txtNoPolis = New System.Windows.Forms.TextBox
        Me.Label11 = New System.Windows.Forms.Label
        Me.DGV = New System.Windows.Forms.DataGridView
        Me.PictureBox1 = New System.Windows.Forms.PictureBox
        Me.Button4 = New System.Windows.Forms.Button
        Me.Button3 = New System.Windows.Forms.Button
        Me.Button2 = New System.Windows.Forms.Button
        Me.Button1 = New System.Windows.Forms.Button
        Me.Panel1.SuspendLayout()
        CType(Me.DGV, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(402, 209)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(62, 13)
        Me.Label10.TabIndex = 74
        Me.Label10.Text = "Keterangan"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(402, 154)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(74, 13)
        Me.Label9.TabIndex = 73
        Me.Label9.Text = "Tanggal Klaim"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(402, 98)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(70, 13)
        Me.Label8.TabIndex = 72
        Me.Label8.Text = "No Rekening"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(9, 240)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(63, 13)
        Me.Label7.TabIndex = 70
        Me.Label7.Text = "Nama Bank"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(9, 209)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(81, 13)
        Me.Label6.TabIndex = 68
        Me.Label6.Text = "Nama Nasabah"
        '
        'cmbKodeJenisKlaim
        '
        Me.cmbKodeJenisKlaim.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbKodeJenisKlaim.FormattingEnabled = True
        Me.cmbKodeJenisKlaim.Items.AddRange(New Object() {""})
        Me.cmbKodeJenisKlaim.Location = New System.Drawing.Point(128, 124)
        Me.cmbKodeJenisKlaim.Name = "cmbKodeJenisKlaim"
        Me.cmbKodeJenisKlaim.Size = New System.Drawing.Size(155, 21)
        Me.cmbKodeJenisKlaim.TabIndex = 67
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(10, 151)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(53, 13)
        Me.Label5.TabIndex = 66
        Me.Label5.Text = "No Daftar"
        '
        'txtKodeKlaim
        '
        Me.txtKodeKlaim.Enabled = False
        Me.txtKodeKlaim.Location = New System.Drawing.Point(128, 93)
        Me.txtKodeKlaim.Multiline = True
        Me.txtKodeKlaim.Name = "txtKodeKlaim"
        Me.txtKodeKlaim.Size = New System.Drawing.Size(257, 25)
        Me.txtKodeKlaim.TabIndex = 59
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(9, 121)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(87, 13)
        Me.Label3.TabIndex = 58
        Me.Label3.Text = "Kode Jenis Klaim"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(9, 93)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(60, 13)
        Me.Label2.TabIndex = 57
        Me.Label2.Text = "Kode Klaim"
        '
        'Panel1
        '
        Me.Panel1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Panel1.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.Panel1.Controls.Add(Me.PictureBox1)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Location = New System.Drawing.Point(-2, -1)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(726, 77)
        Me.Panel1.TabIndex = 56
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Courier New", 21.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(122, 19)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(321, 33)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "FORM KLAIM NASABAH"
        '
        'cmbNo_Daftar
        '
        Me.cmbNo_Daftar.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbNo_Daftar.FormattingEnabled = True
        Me.cmbNo_Daftar.Items.AddRange(New Object() {"Pria", "Wanita"})
        Me.cmbNo_Daftar.Location = New System.Drawing.Point(128, 151)
        Me.cmbNo_Daftar.Name = "cmbNo_Daftar"
        Me.cmbNo_Daftar.Size = New System.Drawing.Size(181, 21)
        Me.cmbNo_Daftar.TabIndex = 76
        '
        'txtNamaNasabah
        '
        Me.txtNamaNasabah.Enabled = False
        Me.txtNamaNasabah.Location = New System.Drawing.Point(128, 206)
        Me.txtNamaNasabah.Multiline = True
        Me.txtNamaNasabah.Name = "txtNamaNasabah"
        Me.txtNamaNasabah.Size = New System.Drawing.Size(257, 25)
        Me.txtNamaNasabah.TabIndex = 78
        '
        'txtNamaBank
        '
        Me.txtNamaBank.Enabled = False
        Me.txtNamaBank.Location = New System.Drawing.Point(128, 237)
        Me.txtNamaBank.Multiline = True
        Me.txtNamaBank.Name = "txtNamaBank"
        Me.txtNamaBank.Size = New System.Drawing.Size(181, 25)
        Me.txtNamaBank.TabIndex = 79
        '
        'DateTimePicker1
        '
        Me.DateTimePicker1.Location = New System.Drawing.Point(482, 154)
        Me.DateTimePicker1.Name = "DateTimePicker1"
        Me.DateTimePicker1.Size = New System.Drawing.Size(200, 20)
        Me.DateTimePicker1.TabIndex = 80
        '
        'txtNoRekening
        '
        Me.txtNoRekening.Enabled = False
        Me.txtNoRekening.Location = New System.Drawing.Point(482, 90)
        Me.txtNoRekening.Multiline = True
        Me.txtNoRekening.Name = "txtNoRekening"
        Me.txtNoRekening.Size = New System.Drawing.Size(231, 25)
        Me.txtNoRekening.TabIndex = 81
        '
        'txtKeterangan
        '
        Me.txtKeterangan.Location = New System.Drawing.Point(482, 184)
        Me.txtKeterangan.Multiline = True
        Me.txtKeterangan.Name = "txtKeterangan"
        Me.txtKeterangan.Size = New System.Drawing.Size(231, 78)
        Me.txtKeterangan.TabIndex = 82
        '
        'txtJenisKlaim
        '
        Me.txtJenisKlaim.Enabled = False
        Me.txtJenisKlaim.Location = New System.Drawing.Point(351, 125)
        Me.txtJenisKlaim.Name = "txtJenisKlaim"
        Me.txtJenisKlaim.Size = New System.Drawing.Size(319, 20)
        Me.txtJenisKlaim.TabIndex = 83
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(289, 128)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(59, 13)
        Me.Label4.TabIndex = 84
        Me.Label4.Text = "Jenis Klaim"
        '
        'txtNoPolis
        '
        Me.txtNoPolis.Enabled = False
        Me.txtNoPolis.Location = New System.Drawing.Point(128, 178)
        Me.txtNoPolis.Multiline = True
        Me.txtNoPolis.Name = "txtNoPolis"
        Me.txtNoPolis.Size = New System.Drawing.Size(155, 25)
        Me.txtNoPolis.TabIndex = 87
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(9, 181)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(46, 13)
        Me.Label11.TabIndex = 86
        Me.Label11.Text = "No Polis"
        '
        'DGV
        '
        Me.DGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DGV.Location = New System.Drawing.Point(13, 314)
        Me.DGV.Name = "DGV"
        Me.DGV.Size = New System.Drawing.Size(699, 187)
        Me.DGV.TabIndex = 88
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
        'Button4
        '
        Me.Button4.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Button4.Image = Global.aiafinancial.My.Resources.Resources.refresh
        Me.Button4.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Button4.Location = New System.Drawing.Point(637, 268)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(75, 40)
        Me.Button4.TabIndex = 64
        Me.Button4.Text = "Batal"
        Me.Button4.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Button4.UseVisualStyleBackColor = True
        '
        'Button3
        '
        Me.Button3.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Button3.Image = Global.aiafinancial.My.Resources.Resources.Edit
        Me.Button3.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Button3.Location = New System.Drawing.Point(174, 268)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(75, 40)
        Me.Button3.TabIndex = 63
        Me.Button3.Text = "Ubah"
        Me.Button3.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Button3.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Button2.Image = Global.aiafinancial.My.Resources.Resources.delete
        Me.Button2.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Button2.Location = New System.Drawing.Point(92, 268)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(75, 40)
        Me.Button2.TabIndex = 62
        Me.Button2.Text = "Hapus"
        Me.Button2.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Button1
        '
        Me.Button1.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Button1.Image = Global.aiafinancial.My.Resources.Resources.add
        Me.Button1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Button1.Location = New System.Drawing.Point(12, 268)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 40)
        Me.Button1.TabIndex = 61
        Me.Button1.Text = "Simpan"
        Me.Button1.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Button1.UseVisualStyleBackColor = True
        '
        'frmK_Nasabah
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(724, 511)
        Me.Controls.Add(Me.DGV)
        Me.Controls.Add(Me.txtNoPolis)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.txtJenisKlaim)
        Me.Controls.Add(Me.txtKeterangan)
        Me.Controls.Add(Me.txtNoRekening)
        Me.Controls.Add(Me.DateTimePicker1)
        Me.Controls.Add(Me.txtNamaBank)
        Me.Controls.Add(Me.txtNamaNasabah)
        Me.Controls.Add(Me.cmbNo_Daftar)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.cmbKodeJenisKlaim)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.txtKodeKlaim)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.Button4)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Button1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow
        Me.Name = "frmK_Nasabah"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.DGV, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents cmbKodeJenisKlaim As System.Windows.Forms.ComboBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents txtKodeKlaim As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Button4 As System.Windows.Forms.Button
    Friend WithEvents Button3 As System.Windows.Forms.Button
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents cmbNo_Daftar As System.Windows.Forms.ComboBox
    Friend WithEvents txtNamaNasabah As System.Windows.Forms.TextBox
    Friend WithEvents txtNamaBank As System.Windows.Forms.TextBox
    Friend WithEvents DateTimePicker1 As System.Windows.Forms.DateTimePicker
    Friend WithEvents txtNoRekening As System.Windows.Forms.TextBox
    Friend WithEvents txtKeterangan As System.Windows.Forms.TextBox
    Friend WithEvents txtJenisKlaim As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents txtNoPolis As System.Windows.Forms.TextBox
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents DGV As System.Windows.Forms.DataGridView
End Class
