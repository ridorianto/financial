Imports System.Data.Odbc
Public Class frmNasabah
    Sub isiGrid()
        ModConection.koneksi()
        da = New OdbcDataAdapter("SELECT datanasabah.no_daftar, dataagen.nm_agen, datanasabah.no_polis, datanasabah.nm_nasabah,datanasabah.jk,datanasabah.tmpt_lahir,datanasabah.tgl_lahir,datanasabah.wrg_negara,datanasabah.status,datanasabah.pekerjaan,datanasabah.no_telp,datanasabah.penerima_faedah,jenisproduk.nm_produk,datanasabah.premi,jenispembayaran.jnspembayaran,datanasabah.dana_per_bayar,datanasabah.lama_asuransi,datanasabah.nm_bank,datanasabah.no_rek,datanasabah.alamat,datanasabah.keterangan,datanasabah.tgl_daftar,datanasabah.lama_jdnasabah,datanasabah.total_dana FROM datanasabah INNER JOIN dataagen INNER JOIN jenisproduk INNER JOIN jenispembayaran ON datanasabah.kd_agen=dataagen.kd_agen AND datanasabah.kd_produk=jenisproduk.kd_produk AND datanasabah.kd_jnspembayaran=jenispembayaran.kd_jnspembayaran ORDER BY no_daftar ASC", conn)
        ds = New DataSet
        da.Fill(ds, "datanasabah")
        da.Fill(ds, "dataagen")
        da.Fill(ds, "jenisproduk")
        da.Fill(ds, "jenispembayaran")
        DGV.DataSource = ds.Tables("datanasabah")
        DGV.DataSource = ds.Tables("dataagen")
        DGV.DataSource = ds.Tables("jenisproduk")
        DGV.DataSource = ds.Tables("jenispembayaran")
        DGV.ReadOnly = True
    End Sub
    Sub isiCombo()
        koneksi()
        cmd = New OdbcCommand("SELECT nm_agen From dataagen", conn)
        dr = cmd.ExecuteReader
        cmbNamaAgen.Items.Clear()
        cmbNamaAgen.Items.Add("")
        Do While dr.Read
            cmbNamaAgen.Items.Add(dr.Item("nm_agen"))

        Loop
        CMD.Dispose()
        dr.Close()
        Conn.Close()
    End Sub
    Sub isiCombo1()
        koneksi()
        cmd = New OdbcCommand("SELECT nm_produk From jenisproduk", conn)
        dr = cmd.ExecuteReader
        cmbNamaProduk.Items.Clear()
        cmbNamaProduk.Items.Add("")
        Do While dr.Read
            cmbNamaProduk.Items.Add(dr.Item("nm_produk"))

        Loop
        cmd.Dispose()
        dr.Close()
        conn.Close()
    End Sub
    Sub isiCombo2()
        koneksi()
        cmd = New OdbcCommand("SELECT jnspembayaran From jenispembayaran", conn)
        dr = cmd.ExecuteReader
        cmbJnsPembayaran.Items.Clear()
        cmbJnsPembayaran.Items.Add("")
        Do While dr.Read
            cmbJnsPembayaran.Items.Add(dr.Item("jnspembayaran"))

        Loop
        cmd.Dispose()
        dr.Close()
        conn.Close()
    End Sub
    
    Sub AturGrid()
        DGV.Columns(0).Width = 80
        DGV.Columns(1).Width = 150
        DGV.Columns(2).Width = 90
        DGV.Columns(3).Width = 150
        DGV.Columns(4).Width = 90
        DGV.Columns(5).Width = 90
        DGV.Columns(6).Width = 80
        DGV.Columns(7).Width = 90
        DGV.Columns(8).Width = 90
        DGV.Columns(9).Width = 150
        DGV.Columns(10).Width = 90
        DGV.Columns(11).Width = 190
        DGV.Columns(12).Width = 190
        DGV.Columns(13).Width = 80
        DGV.Columns(14).Width = 190
        DGV.Columns(15).Width = 90
        DGV.Columns(16).Width = 190
        DGV.Columns(17).Width = 100
        DGV.Columns(18).Width = 120
        DGV.Columns(19).Width = 90
        DGV.Columns(20).Width = 90
        DGV.Columns(21).Width = 90
        DGV.Columns(22).Width = 140
        DGV.Columns(23).Width = 120

        DGV.Columns(0).HeaderText = "No Daftar"
        DGV.Columns(1).HeaderText = "Nama Agen"
        DGV.Columns(2).HeaderText = "No Polis"
        DGV.Columns(3).HeaderText = "Nama Nasabah"
        DGV.Columns(4).HeaderText = "Jekel"
        DGV.Columns(5).HeaderText = "Tempat Lahir"
        DGV.Columns(6).HeaderText = "Tanggal Lahir"
        DGV.Columns(7).HeaderText = "Warga Negara"
        DGV.Columns(8).HeaderText = "Status"
        DGV.Columns(9).HeaderText = "Pekerjaan"
        DGV.Columns(10).HeaderText = "No Telpon"
        DGV.Columns(11).HeaderText = "Penerima Faedah"
        DGV.Columns(12).HeaderText = "Nama Produk"
        DGV.Columns(13).HeaderText = "Premi"
        DGV.Columns(14).HeaderText = "Jenis Pembayran"
        DGV.Columns(15).HeaderText = "Dana Per Bayar"
        DGV.Columns(16).HeaderText = "Lama Angsuran"
        DGV.Columns(17).HeaderText = "Nama Bank"
        DGV.Columns(18).HeaderText = "No Rekening"
        DGV.Columns(19).HeaderText = "Alamat"
        DGV.Columns(20).HeaderText = "Keterangan"
        DGV.Columns(21).HeaderText = "Tanggal Daftar"
        DGV.Columns(22).HeaderText = "Lama Jadi Nasabah"
        DGV.Columns(23).HeaderText = "Total Dana Seluruh"
    End Sub
    Sub auto()
        Try
            koneksi()
            cmd = New OdbcCommand("select max(right(no_daftar,3)) as jumlahku from datanasabah", conn)
            dr = cmd.ExecuteReader
            If dr.HasRows = True Then
                Try
                    If dr("Jumlahku") <> 0 Then
                        dr.Read()
                        txtNoDaftar.Text = "NDDN-" & "00" & dr("Jumlahku") + 1
                    Else
                    End If
                Catch ex As Exception
                    txtNoDaftar.Text = "NDDN-001"
                End Try
            End If
        Catch ex As Exception
            MsgBox("Proses Pembuatan Nomor Otomatis Gagal. Silakan Cek Server", vbInformation, "Cek Server")
        End Try
    End Sub
    Sub bersih()
        txtAlamat.Clear()
        txtKeterangan.Clear()
        txtLamaAngsuran.Clear()
        txtNamaBank.Clear()
        txtNamaNasabah.Clear()
        txtNoPolis.Clear()
        txtNoRekening.Clear()
        txtNoTelpon.Clear()
        txtPekerjaan.Clear()
        txtPenerimaFaedah.Clear()
        txtTempatLahir.Clear()
        txtKodeAgen.Clear()
        txtKodeProduk.Clear()
        cmbJekel.Text = ""
        cmbNamaAgen.Text = ""
        cmbNamaProduk.Text = ""
        cmbStatus.Text = ""
        cmbWargaNegara.Text = ""
        cmbJnsPembayaran.Text = ""
        txtPremi.Clear()
        txtTotalDana.Clear()
        txtDanaPerBayar.Clear()
        txtLamaNasabah.Text = ""
    End Sub
    Private Sub grid()
        DGV.RowsDefaultCellStyle.BackColor = Color.White
        DGV.AlternatingRowsDefaultCellStyle.BackColor = Color.AliceBlue
    End Sub
    Private Sub frmNasabah_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        DateTimePicker1.Format = DateTimePickerFormat.Custom
        DateTimePicker1.CustomFormat = "yyyy/MM/dd"
        DateTimePicker2.Format = DateTimePickerFormat.Custom
        DateTimePicker2.CustomFormat = "yyyy/MM/dd"
        Label26.Text = Format(Now, "dd MMM yyyy")

        grid()
        isiGrid()
        AturGrid()
        auto()
        isiCombo()
        isiCombo1()
        isiCombo2()

    End Sub

    Private Sub DGV_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DGV.CellContentClick
        Dim i As Integer
        i = DGV.CurrentRow.Index

        Me.txtNoDaftar.Text = DGV.Item(0, i).Value
        Me.cmbNamaAgen.Text = DGV.Item(1, i).Value
        Me.txtNoPolis.Text = DGV.Item(2, i).Value
        Me.txtNamaNasabah.Text = DGV.Item(3, i).Value
        Me.cmbJekel.Text = DGV.Item(4, i).Value
        Me.txtTempatLahir.Text = DGV.Item(5, i).Value
        Me.DateTimePicker1.Text = DGV.Item(6, i).Value.ToString
        Me.cmbWargaNegara.Text = DGV.Item(7, i).Value
        Me.cmbStatus.Text = DGV.Item(8, i).Value
        Me.txtPekerjaan.Text = DGV.Item(9, i).Value
        Me.txtNoTelpon.Text = DGV.Item(10, i).Value
        Me.txtPenerimaFaedah.Text = DGV.Item(11, i).Value
        Me.cmbNamaProduk.Text = DGV.Item(12, i).Value
        Me.txtPremi.Text = DGV.Item(13, i).Value
        Me.cmbJnsPembayaran.Text = DGV.Item(14, i).Value
        Me.txtDanaPerBayar.Text = DGV.Item(15, i).Value
        Me.txtLamaAngsuran.Text = DGV.Item(16, i).Value
        Me.txtNamaBank.Text = DGV.Item(17, i).Value
        Me.txtNoRekening.Text = DGV.Item(18, i).Value
        Me.txtAlamat.Text = DGV.Item(19, i).Value
        Me.txtKeterangan.Text = DGV.Item(20, i).Value
        Me.DateTimePicker2.Text = DGV.Item(21, i).Value.ToString
        Me.txtLamaNasabah.Text = DGV.Item(22, i).Value
        Me.txtTotalDana.Text = DGV.Item(23, i).Value
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        If cmbNamaAgen.Text = "" Or txtNoPolis.Text = "" Or txtNamaNasabah.Text = "" Or cmbJekel.Text = "" Or txtTempatLahir.Text = "" Or cmbWargaNegara.Text = "" Or cmbStatus.Text = "" Or txtPekerjaan.Text = "" Or txtKodeProduk.Text = "" Then
            MsgBox("Data belum lengkap !!")
            cmbNamaAgen.Focus()
        Else
            Try
                koneksi()
                cmd = New OdbcCommand("SELECT * from datanasabah WHERE no_daftar= '" & txtNoDaftar.Text & "'", conn)
                dr = cmd.ExecuteReader
                dr.Read()
                If dr.HasRows Then
                    MsgBox("Maaf, Data tersebut telah ada", MsgBoxStyle.Exclamation, "Peringatan")
                Else
                    koneksi()
                    Dim tgl1, tgl2 As String
                    tgl1 = Format(DateTimePicker1.Value, "yyyy/MM/dd")
                    tgl2 = Format(DateTimePicker2.Value, "yyyy/MM/dd")

                    simpan = "INSERT INTO datanasabah VALUES ('" & txtNoDaftar.Text & "','" & txtKodeAgen.Text & "','" & txtNoPolis.Text & "','" & txtNamaNasabah.Text & "','" & cmbJekel.Text & "','" & txtTempatLahir.Text & "','" & tgl1 & "','" & cmbWargaNegara.Text & "','" & cmbStatus.Text & "','" & txtPekerjaan.Text & "','" & txtNoTelpon.Text & "','" & txtPenerimaFaedah.Text & "','" & txtKodeProduk.Text & "','" & txtPremi.Text & "','" & txtKodeJnsPembayaran.Text & "','" & txtDanaPerBayar.Text & "','" & txtLamaAngsuran.Text & "','" & txtNamaBank.Text & "','" & txtNoRekening.Text & "','" & txtAlamat.Text & "','" & txtKeterangan.Text & "','" & tgl2 & "','" & txtLamaNasabah.Text & "','" & txtTotalDana.Text & "')"
                    cmd = New OdbcCommand(simpan, conn)
                    cmd.ExecuteNonQuery()
                    MsgBox("Data Sukses Tersimpan", MsgBoxStyle.Information, "Pesan")
                    bersih()
                    isiGrid()
                    auto()
                End If
            Catch ex As Exception
                MsgBox(ex.ToString, MsgBoxStyle.Critical, "Terjadi Kesalahan")
            End Try
        End If
    End Sub

    Private Sub cmbNamaAgen_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmbNamaAgen.SelectedIndexChanged
        If cmbNamaAgen.Text = "" Then
            cmbNamaAgen.Text = ""
            txtKodeAgen.Text = ""
        Else
            koneksi()
            cmd = New OdbcCommand("SELECT * FROM dataagen WHERE nm_agen = '" & cmbNamaAgen.Text & "'", conn)

            dr = cmd.ExecuteReader
            dr.Read()
            txtKodeAgen.Text = dr.Item(0)
        End If
    End Sub

    Private Sub cmbNamaProduk_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmbNamaProduk.SelectedIndexChanged
        If cmbNamaProduk.Text = "" Then
            cmbNamaProduk.Text = ""
            txtKodeProduk.Text = ""
        Else
            koneksi()
            cmd = New OdbcCommand("SELECT * FROM jenisproduk WHERE nm_produk = '" & cmbNamaProduk.Text & "'", conn)

            dr = cmd.ExecuteReader
            dr.Read()
            txtKodeProduk.Text = dr.Item(0)
        End If
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        If txtKodeAgen.Text = "" Or txtNoPolis.Text = "" Or txtNamaNasabah.Text = "" Or cmbJekel.Text = "" Or txtTempatLahir.Text = "" Or cmbWargaNegara.Text = "" Or cmbStatus.Text = "" Or txtPekerjaan.Text = "" Or txtKodeProduk.Text = "" Then
            MsgBox("Data belum lengkap !!")
            cmbNamaAgen.Focus()
        Else
            Try
                koneksi()
                Dim tanya As DialogResult
                tanya = MessageBox.Show("Data benar akan dihapus ?", "Konfirmasi", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
                If tanya = Windows.Forms.DialogResult.Yes Then
                    hapus = "DELETE FROM datanasabah WHERE no_daftar='" & txtNoDaftar.Text & "'"
                    cmd = New OdbcCommand(hapus, conn)
                    cmd.ExecuteNonQuery()
                    isiGrid()
                    bersih()
                    auto()
                Else
                    bersih()
                    auto()
                End If
            Catch ex As Exception
                MsgBox(ex.ToString, MsgBoxStyle.Critical, "Terjadi Kesalahan")
            End Try
        End If
    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        If txtKodeAgen.Text = "" Or txtNoPolis.Text = "" Or txtNamaNasabah.Text = "" Or cmbJekel.Text = "" Or txtTempatLahir.Text = "" Or cmbWargaNegara.Text = "" Or cmbStatus.Text = "" Or txtPekerjaan.Text = "" Or txtKodeProduk.Text = "" Then
            MsgBox("Data belum lengkap !!")
            cmbNamaAgen.Focus()
        Else
            Try
                koneksi()
                Dim tanya As DialogResult
                tanya = MessageBox.Show("Data benar akan diubah ?", "Konfirmasi", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
                If tanya = Windows.Forms.DialogResult.Yes Then
                    Dim tgl1, tgl2 As String
                    tgl1 = Format(DateTimePicker1.Value, "yyyy/MM/dd")
                    tgl2 = Format(DateTimePicker2.Value, "yyyy/MM/dd")

                    ubah = "UPDATE datanasabah SET kd_agen='" & txtKodeAgen.Text & "',no_polis='" & txtNoPolis.Text & "',nm_nasabah='" & txtNamaNasabah.Text & "',jk='" & cmbJekel.Text & "',tmpt_lahir='" & txtTempatLahir.Text & "',tgl_lahir='" & tgl1 & "',wrg_negara='" & cmbWargaNegara.Text & "',status='" & cmbStatus.Text & "',pekerjaan='" & txtPekerjaan.Text & "',no_telp='" & txtNoTelpon.Text & "',penerima_faedah='" & txtPenerimaFaedah.Text & "',kd_produk='" & txtKodeProduk.Text & "',premi='" & txtPremi.Text & "',kd_jnspembayaran='" & txtKodeJnsPembayaran.Text & "',dana_per_bayar='" & txtDanaPerBayar.Text & "',lama_asuransi='" & txtLamaAngsuran.Text & "',nm_bank='" & txtNamaBank.Text & "',no_rek='" & txtNoRekening.Text & "',alamat='" & txtAlamat.Text & "',keterangan='" & txtKeterangan.Text & "',tgl_daftar='" & tgl2 & "',lama_jdnasabah='" & txtLamaNasabah.Text & "', 	total_dana='" & txtTotalDana.Text & "' WHERE no_daftar= '" & txtNoDaftar.Text & "'"
                    cmd = New OdbcCommand(ubah, conn)
                    cmd.ExecuteNonQuery()
                    isiGrid()
                    bersih()
                    auto()
                    MsgBox("Data Telah diubah", MsgBoxStyle.Information, "Pesan")
                Else
                    bersih()
                    auto()
                End If
            Catch ex As Exception
                MsgBox(ex.ToString, MsgBoxStyle.Critical, "Terjadi Kesalahan")
            End Try
        End If
    End Sub

    Private Sub Button4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button4.Click
        bersih()
        auto()
    End Sub

    Private Sub cmbJnsPembayaran_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmbJnsPembayaran.SelectedIndexChanged
        If cmbJnsPembayaran.Text = "" Then
            cmbJnsPembayaran.Text = ""
            txtKodeJnsPembayaran.Text = ""
        Else
            koneksi()
            cmd = New OdbcCommand("SELECT * FROM jenispembayaran WHERE jnspembayaran = '" & cmbJnsPembayaran.Text & "'", conn)

            dr = cmd.ExecuteReader
            dr.Read()
            txtKodeJnsPembayaran.Text = dr.Item(0)
        End If
    End Sub

    Private Sub DateTimePicker2_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DateTimePicker2.ValueChanged
        Dim date1 As Date = Label26.Text
        Dim date2 As Date = DateTimePicker2.Value

        Dim total As Int32 = date1.Year - date2.Year

        txtLamaNasabah.Text = total

        txtTotalDana.Text = (((Val(txtDanaPerBayar.Text) * Val(txtLamaNasabah.Text)) + Val(TextBox2.Text)) - Val(TextBox1.Text))
    End Sub

    Private Sub txtNoDaftar_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtNoDaftar.TextChanged

        koneksi()
        cmd = New OdbcCommand("SELECT jml_dana FROM penarikannasabah where no_daftar='" & txtNoDaftar.Text & "'", conn)
        dr = cmd.ExecuteReader
        TextBox1.Clear()
        Do While dr.Read
            TextBox1.Text = dr.Item("jml_dana")
        Loop
        cmd.Dispose()
        dr.Close()
        conn.Close()

        koneksi()
        cmd = New OdbcCommand("SELECT jml_dana FROM setorannasabah where no_daftar='" & txtNoDaftar.Text & "'", conn)
        dr = cmd.ExecuteReader
        TextBox2.Clear()
        Do While dr.Read
            TextBox2.Text = dr.Item("jml_dana")
        Loop
        cmd.Dispose()
        dr.Close()
        conn.Close()
    End Sub
End Class