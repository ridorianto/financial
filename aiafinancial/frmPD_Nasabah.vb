Imports System.Data.Odbc
Public Class frmPD_Nasabah
    Sub isiGrid()
        ModConection.koneksi()
        da = New OdbcDataAdapter("SELECT*FROM penarikannasabah ORDER BY kd_penarikan ASC", conn)
        ds = New DataSet
        da.Fill(ds, "penarikannasabah")
        DGV.DataSource = ds.Tables("penarikannasabah")
        DGV.ReadOnly = True
    End Sub
    Sub AturGrid()
        DGV.Columns(0).Width = 90
        DGV.Columns(1).Width = 110
        DGV.Columns(2).Width = 110
        DGV.Columns(3).Width = 110
        DGV.Columns(4).Width = 150
        DGV.Columns(5).Width = 130
        DGV.Columns(6).Width = 320
        DGV.Columns(7).Width = 120


        DGV.Columns(0).HeaderText = "Kode Setor"
        DGV.Columns(1).HeaderText = "Kode Jenis Klaim"
        DGV.Columns(2).HeaderText = "Kode Jenis Penarikan"
        DGV.Columns(3).HeaderText = "No Daftar"
        DGV.Columns(4).HeaderText = "Jumlah Dana"
        DGV.Columns(5).HeaderText = "Tanggal Penarikan"
        DGV.Columns(6).HeaderText = "Keterangan"
        DGV.Columns(7).HeaderText = "Sisa Dana"
    End Sub
    Sub isiCombo()
        koneksi()
        cmd = New OdbcCommand("SELECT kd_jnsklaim From jenisklaim", conn)
        dr = cmd.ExecuteReader
        cmbKodeJenisKlaim.Items.Clear()
        cmbKodeJenisKlaim.Items.Add("")
        Do While dr.Read
            cmbKodeJenisKlaim.Items.Add(dr.Item("kd_jnsklaim"))

        Loop
        CMD.Dispose()
        dr.Close()
        Conn.Close()
    End Sub
    Sub isiCombo1()
        koneksi()
        cmd = New OdbcCommand("SELECT kd_jnspenarikan From jenispenarikan", conn)
        dr = cmd.ExecuteReader
        cmbKodeJenisPenarikan.Items.Clear()
        cmbKodeJenisPenarikan.Items.Add("")
        Do While dr.Read
            cmbKodeJenisPenarikan.Items.Add(dr.Item("kd_jnspenarikan"))

        Loop
        cmd.Dispose()
        dr.Close()
        conn.Close()
    End Sub
    Sub isiCombo2()
        koneksi()
        cmd = New OdbcCommand("SELECT no_daftar From setorannasabah", conn)
        dr = cmd.ExecuteReader
        cmbNoDaftar.Items.Clear()
        cmbNoDaftar.Items.Add("")
        Do While dr.Read
            cmbNoDaftar.Items.Add(dr.Item("no_daftar"))

        Loop
        cmd.Dispose()
        dr.Close()
        conn.Close()
    End Sub
    Sub auto()
        Try
            koneksi()
            cmd = New OdbcCommand("select max(right(kd_penarikan,3)) as jumlahku from penarikannasabah", conn)
            dr = cmd.ExecuteReader
            If dr.HasRows = True Then
                Try
                    If dr("Jumlahku") <> 0 Then
                        dr.Read()
                        txtKodePenarikan.Text = "KPDN-" & "00" & dr("Jumlahku") + 1
                    Else
                    End If
                Catch ex As Exception
                    txtKodePenarikan.Text = "KPDN-001"
                End Try
            End If
        Catch ex As Exception
            MsgBox("Proses Pembuatan Nomor Otomatis Gagal. Silakan Cek Server", vbInformation, "Cek Server")
        End Try
    End Sub
    Sub bersih()
        txtJumlahDana.Clear()
        txtKeterangan.Clear()
        txtJenisKlaim.Clear()
        txtKodePenarikan.Clear()
        txtNamaBank.Clear()
        txtNamaNasabah.Clear()
        txtNoRekening.Clear()
        txtNoPolis.Clear()
        cmbKodeJenisKlaim.Text = ""
        cmbKodeJenisPenarikan.Text = ""
        cmbNoDaftar.Text = ""
        txtsisadana.Clear()
    End Sub

    Private Sub frmPD_Nasabah_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        DateTimePicker1.Format = DateTimePickerFormat.Custom
        DateTimePicker1.CustomFormat = "yyyy/MM/dd"

        isiGrid()
        AturGrid()
        auto()
        isiCombo()
        isiCombo1()
        isiCombo2()
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        If cmbKodeJenisKlaim.Text = "" Or cmbKodeJenisPenarikan.Text = "" Or cmbNoDaftar.Text = "" Or txtNamaNasabah.Text = "" Or txtNamaBank.Text = "" Or txtNoRekening.Text = "" Or txtKeterangan.Text = "" Then
            MsgBox("Data belum lengkap !!")
            cmbKodeJenisKlaim.Focus()
        Else
            Try
                koneksi()
                Dim tanya As DialogResult
                tanya = MessageBox.Show("Data benar akan dihapus ?", "Konfirmasi", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
                If tanya = Windows.Forms.DialogResult.Yes Then
                    hapus = "DELETE FROM penarikannasabah WHERE kd_penarikan='" & txtKodePenarikan.Text & "'"
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

    Private Sub DGV_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DGV.CellContentClick
        Dim i As Integer
        i = DGV.CurrentRow.Index

        Me.txtKodePenarikan.Text = DGV.Item(0, i).Value
        Me.cmbKodeJenisKlaim.Text = DGV.Item(1, i).Value
        Me.cmbKodeJenisPenarikan.Text = DGV.Item(2, i).Value
        Me.cmbNoDaftar.Text = DGV.Item(3, i).Value
        Me.txtJumlahDana.Text = DGV.Item(4, i).Value
        Me.DateTimePicker1.Text = DGV.Item(5, i).Value.ToString
        Me.txtKeterangan.Text = DGV.Item(6, i).Value
        Me.txtsisadana.Text = DGV.Item(7, i).Value
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        If cmbKodeJenisKlaim.Text = "" Or cmbKodeJenisPenarikan.Text = "" Or cmbNoDaftar.Text = "" Or txtNamaNasabah.Text = "" Or txtNamaBank.Text = "" Or txtNoRekening.Text = "" Or txtKeterangan.Text = "" Then
            MsgBox("Data belum lengkap !!")
            cmbKodeJenisKlaim.Focus()
        Else
            Try
                koneksi()
                cmd = New OdbcCommand("SELECT * from penarikannasabah WHERE kd_penarikan= '" & txtKodePenarikan.Text & "'", conn)
                dr = cmd.ExecuteReader
                dr.Read()
                If dr.HasRows Then
                    MsgBox("Maaf, Data tersebut telah ada", MsgBoxStyle.Exclamation, "Peringatan")
                Else
                    koneksi()
                    Dim tgl As String
                    tgl = Format(DateTimePicker1.Value, "yyyy/MM/dd")

                    simpan = "INSERT INTO penarikannasabah VALUES ('" & txtKodePenarikan.Text & "','" & cmbKodeJenisKlaim.Text & "','" & cmbKodeJenisPenarikan.Text & "','" & cmbNoDaftar.Text & "','" & txtJumlahDana.Text & "','" & tgl & "','" & txtKeterangan.Text & "','" & txtsisadana.Text & "')"
                    cmd = New OdbcCommand(simpan, conn)
                    cmd.ExecuteNonQuery()

                    'ubah total dana
                    cmd = New OdbcCommand("select * from datanasabah where no_daftar='" & cmbNoDaftar.Text & "'", conn)
                    dr = cmd.ExecuteReader
                    dr.Read()
                    If dr.HasRows Then
                        Dim Kurangi As String = "update datanasabah set total_dana= '" & txtsisadana.Text & "' where no_daftar='" & cmbNoDaftar.Text & "'"
                        cmd = New OdbcCommand(Kurangi, conn)
                        cmd.ExecuteNonQuery()
                    End If
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

    Private Sub cmbKodeJenisKlaim_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmbKodeJenisKlaim.SelectedIndexChanged
        If cmbKodeJenisKlaim.Text = "" Then
            cmbKodeJenisKlaim.Text = ""
            txtJenisKlaim.Text = ""
        Else
            koneksi()
            cmd = New OdbcCommand("SELECT * FROM jenisklaim WHERE kd_jnsklaim = '" & cmbKodeJenisKlaim.Text & "'", conn)

            dr = cmd.ExecuteReader
            dr.Read()
            txtJenisKlaim.Text = dr.Item(1)
        End If
    End Sub

    Private Sub cmbNoDaftar_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmbNoDaftar.SelectedIndexChanged
        If cmbNoDaftar.Text = "" Then
            cmbNoDaftar.Text = ""
            txtNoPolis.Text = ""
            txtNamaNasabah.Text = ""
            txtNamaBank.Text = ""
            txtNoRekening.Text = ""
            txtTotalDana.Text = ""
        Else
            koneksi()
            cmd = New OdbcCommand("SELECT setorannasabah.no_daftar,datanasabah.no_polis,datanasabah.nm_nasabah,datanasabah.nm_bank,datanasabah.no_rek,datanasabah.total_dana FROM datanasabah INNER JOIN setorannasabah WHERE setorannasabah.no_daftar=datanasabah.no_daftar AND setorannasabah.no_daftar= '" & cmbNoDaftar.Text & "'", conn)

            dr = cmd.ExecuteReader
            dr.Read()
            txtNoPolis.Text = dr.Item(1)
            txtNamaNasabah.Text = dr.Item(2)
            txtNamaBank.Text = dr.Item(3)
            txtNoRekening.Text = dr.Item(4)
            txtTotalDana.Text = dr.Item(5)
        End If
    End Sub

    Private Sub cmbKodeJenisPenarikan_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmbKodeJenisPenarikan.SelectedIndexChanged
        If cmbKodeJenisPenarikan.Text = "" Then
            cmbKodeJenisPenarikan.Text = ""
            txtJenisPenarikan.Text = ""
        Else
            koneksi()
            cmd = New OdbcCommand("SELECT * FROM jenispenarikan WHERE kd_jnspenarikan = '" & cmbKodeJenisPenarikan.Text & "'", conn)

            dr = cmd.ExecuteReader
            dr.Read()
            txtJenisPenarikan.Text = dr.Item(1)
        End If
    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        If cmbKodeJenisKlaim.Text = "" Or cmbKodeJenisPenarikan.Text = "" Or cmbNoDaftar.Text = "" Or txtNamaNasabah.Text = "" Or txtNamaBank.Text = "" Or txtNoRekening.Text = "" Or txtKeterangan.Text = "" Then
            MsgBox("Data belum lengkap !!")
            cmbKodeJenisKlaim.Focus()
        Else
            Try
                koneksi()
                Dim tanya As DialogResult
                tanya = MessageBox.Show("Data benar akan diubah ?", "Konfirmasi", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
                If tanya = Windows.Forms.DialogResult.Yes Then
                    Dim tgl As String
                    tgl = Format(DateTimePicker1.Value, "yyyy/MM/dd")

                    ubah = "UPDATE penarikannasabah SET kd_jnsklaim='" & cmbKodeJenisKlaim.Text & "',kd_jnspenarikan='" & cmbKodeJenisPenarikan.Text & "',no_daftar='" & cmbNoDaftar.Text & "',jml_dana='" & txtJumlahDana.Text & "',tgl_penarikan='" & tgl & "',keterangan='" & txtKeterangan.Text & "',sisa_danaseluruh='" & txtsisadana.Text & "' WHERE kd_penarikan= '" & txtKodePenarikan.Text & "'"
                    cmd = New OdbcCommand(ubah, conn)
                    cmd.ExecuteNonQuery()

                    'ubah total dana
                    cmd = New OdbcCommand("select * from datanasabah where no_daftar='" & cmbNoDaftar.Text & "'", conn)
                    dr = cmd.ExecuteReader
                    dr.Read()
                    If dr.HasRows Then
                        Dim Kurangi As String = "update datanasabah set total_dana= '" & txtsisadana.Text & "' where no_daftar='" & cmbNoDaftar.Text & "'"
                        cmd = New OdbcCommand(Kurangi, conn)
                        cmd.ExecuteNonQuery()
                    End If
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
    Private Sub grid()
        DGV.RowsDefaultCellStyle.BackColor = Color.White
        DGV.AlternatingRowsDefaultCellStyle.BackColor = Color.AliceBlue
    End Sub
    Private Sub Button4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button4.Click
        bersih()
        auto()
        grid()
    End Sub

    Private Sub Panel1_Paint(ByVal sender As System.Object, ByVal e As System.Windows.Forms.PaintEventArgs) Handles Panel1.Paint

    End Sub

    Private Sub txtJumlahDana_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtJumlahDana.TextChanged
        txtsisadana.Text = Val(txtTotalDana.Text) - Val(txtJumlahDana.Text)
    End Sub
End Class