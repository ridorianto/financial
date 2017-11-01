Imports System.Data.Odbc
Public Class frmAgen
    Sub isiGrid()
        ModConection.koneksi()
        da = New OdbcDataAdapter("SELECT dataagen.kd_agen,dataagen.nm_agen,dataagen.jk,dataagen.tmpt_lahir,dataagen.tgl_lahir,dataagen.no_telp,dataagen.status,dataagen.alamat,dataagen.keterangan, datapimpinan.nm_pimpinan, dataagen.tgl_daftar FROM dataagen INNER JOIN datapimpinan ON dataagen.kd_pimpinan=datapimpinan.kd_pimpinan ORDER BY kd_agen ASC", conn)
        ds = New DataSet
        da.Fill(ds, "dataagen")
        da.Fill(ds, "datapimpinan")
        DGV.DataSource = ds.Tables("dataagen")
        DGV.DataSource = ds.Tables("datapimpinan")
        DGV.ReadOnly = True
    End Sub
    Private Sub grid()
        DGV.RowsDefaultCellStyle.BackColor = Color.White
        DGV.AlternatingRowsDefaultCellStyle.BackColor = Color.AliceBlue
    End Sub
    Sub isiCombo()
        koneksi()
        cmd = New OdbcCommand("SELECT nm_pimpinan From datapimpinan", conn)
        dr = cmd.ExecuteReader
        cmbNamaPimpinan.Items.Clear()
        Do While dr.Read
            cmbNamaPimpinan.Items.Add(dr.Item("nm_pimpinan"))

        Loop
        CMD.Dispose()
        dr.Close()
        Conn.Close()
    End Sub
    Sub AturGrid()
        DGV.Columns(0).Width = 80
        DGV.Columns(1).Width = 150
        DGV.Columns(2).Width = 90
        DGV.Columns(3).Width = 100
        DGV.Columns(4).Width = 100
        DGV.Columns(5).Width = 90
        DGV.Columns(6).Width = 80
        DGV.Columns(7).Width = 190
        DGV.Columns(8).Width = 190
        DGV.Columns(9).Width = 150
        DGV.Columns(10).Width = 120

        DGV.Columns(0).HeaderText = "Kode Agen"
        DGV.Columns(1).HeaderText = "Nama Agen"
        DGV.Columns(2).HeaderText = "Jekel"
        DGV.Columns(3).HeaderText = "Tempat Lahir"
        DGV.Columns(4).HeaderText = "Tanggal Lahir"
        DGV.Columns(5).HeaderText = "No Telepon"
        DGV.Columns(6).HeaderText = "Status"
        DGV.Columns(7).HeaderText = "Alamat"
        DGV.Columns(8).HeaderText = "Keterangan"
        DGV.Columns(9).HeaderText = "Nama Pimpinan"
        DGV.Columns(10).HeaderText = "Tanggal Daftar"
    End Sub
    Sub auto()
        Try
            koneksi()
            cmd = New OdbcCommand("select max(right(kd_agen,3)) as jumlahku from dataagen", conn)
            dr = cmd.ExecuteReader
            If dr.HasRows = True Then
                Try
                    If dr("Jumlahku") <> 0 Then
                        dr.Read()
                        txtKodeAgen.Text = "KDAA-" & "00" & dr("Jumlahku") + 1
                    Else
                    End If
                Catch ex As Exception
                    txtKodeAgen.Text = "KDAA-001"
                End Try
            End If
        Catch ex As Exception
            MsgBox("Proses Pembuatan Nomor Otomatis Gagal. Silakan Cek Server", vbInformation, "Cek Server")
        End Try
    End Sub
    Sub bersih()
        txtNamaAgen.Clear()
        txtNoTelpon.Clear()
        txtAlamat.Clear()
        txtKeterangan.Clear()
        txtTempatLahir.Clear()
        txtKodePimpinan.Clear()
        cmbJekel.Text = ""
        cmbNamaPimpinan.Text = ""
        cmbStatus.Text = ""
    End Sub
    Private Sub frmAgen_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        DateTimePicker1.Format = DateTimePickerFormat.Custom
        DateTimePicker1.CustomFormat = "yyyy/MM/dd"
        DateTimePicker2.Format = DateTimePickerFormat.Custom
        DateTimePicker2.CustomFormat = "yyyy/MM/dd"

        isiGrid()
        AturGrid()
        auto()
        isiCombo()
        grid()
    End Sub

    Private Sub Button4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button4.Click
        bersih()
        auto()
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        If txtNamaAgen.Text = "" Or txtTempatLahir.Text = "" Or txtNoTelpon.Text = "" Or txtAlamat.Text = "" Or txtKeterangan.Text = "" Or cmbJekel.Text = "" Or cmbStatus.Text = "" Or txtKodePimpinan.Text = "" Then
            MsgBox("Data belum lengkap !!")
            txtNamaAgen.Focus()
        Else
            Try
                koneksi()
                Dim tanya As DialogResult
                tanya = MessageBox.Show("Data benar akan dihapus ?", "Konfirmasi", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
                If tanya = Windows.Forms.DialogResult.Yes Then
                    hapus = "DELETE FROM dataagen WHERE kd_agen='" & txtKodeAgen.Text & "'"
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

        Me.txtKodeAgen.Text = DGV.Item(0, i).Value
        Me.txtNamaAgen.Text = DGV.Item(1, i).Value
        Me.cmbJekel.Text = DGV.Item(2, i).Value
        Me.txtTempatLahir.Text = DGV.Item(3, i).Value
        Me.DateTimePicker1.Text = DGV.Item(4, i).Value.ToString
        Me.txtNoTelpon.Text = DGV.Item(5, i).Value
        Me.cmbStatus.Text = DGV.Item(6, i).Value
        Me.txtAlamat.Text = DGV.Item(7, i).Value
        Me.txtKeterangan.Text = DGV.Item(8, i).Value
        Me.cmbNamaPimpinan.Text = DGV.Item(9, i).Value
        Me.DateTimePicker2.Text = DGV.Item(10, i).Value.ToString
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        If txtNamaAgen.Text = "" Or txtTempatLahir.Text = "" Or txtNoTelpon.Text = "" Or txtAlamat.Text = "" Or txtKeterangan.Text = "" Or cmbJekel.Text = "" Or cmbStatus.Text = "" Or cmbNamaPimpinan.Text = "" Then
            MsgBox("Data belum lengkap !!")
            txtNamaAgen.Focus()
        Else
            Try
                koneksi()
                cmd = New OdbcCommand("SELECT * from dataagen WHERE kd_agen= '" & txtKodeAgen.Text & "'", conn)
                dr = cmd.ExecuteReader
                dr.Read()
                If dr.HasRows Then
                    MsgBox("Maaf, Data tersebut telah ada", MsgBoxStyle.Exclamation, "Peringatan")
                Else
                    koneksi()
                    Dim tgl1, tgl2 As String
                    tgl1 = Format(DateTimePicker1.Value, "yyyy/MM/dd")
                    tgl2 = Format(DateTimePicker2.Value, "yyyy/MM/dd")

                    simpan = "INSERT INTO dataagen VALUES ('" & txtKodeAgen.Text & "','" & txtNamaAgen.Text & "','" & cmbJekel.Text & "','" & txtTempatLahir.Text & "','" & tgl1 & "','" & txtNoTelpon.Text & "','" & cmbStatus.Text & "','" & txtAlamat.Text & "','" & txtKeterangan.Text & "','" & txtKodePimpinan.Text & "','" & tgl2 & "')"
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

    Private Sub cmbNamaPimpinan_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmbNamaPimpinan.SelectedIndexChanged
        koneksi()
        cmd = New OdbcCommand("SELECT * FROM datapimpinan WHERE nm_pimpinan = '" & cmbNamaPimpinan.Text & "'", conn)

        dr = cmd.ExecuteReader
        dr.Read()
        txtKodePimpinan.Text = dr.Item(0)
    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        If txtNamaAgen.Text = "" Or txtTempatLahir.Text = "" Or txtNoTelpon.Text = "" Or txtAlamat.Text = "" Or txtKeterangan.Text = "" Or cmbJekel.Text = "" Or cmbStatus.Text = "" Or txtKodePimpinan.Text = "" Then
            MsgBox("Data belum lengkap !!")
            txtNamaAgen.Focus()
        Else
            Try
                koneksi()
                Dim tanya As DialogResult
                tanya = MessageBox.Show("Data benar akan diubah ?", "Konfirmasi", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
                If tanya = Windows.Forms.DialogResult.Yes Then
                    Dim tgl1, tgl2 As String
                    tgl1 = Format(DateTimePicker1.Value, "yyyy/MM/dd")
                    tgl2 = Format(DateTimePicker2.Value, "yyyy/MM/dd")

                    ubah = "UPDATE dataagen SET nm_agen='" & txtNamaAgen.Text & "',jk='" & cmbJekel.Text & "',tmpt_lahir='" & txtTempatLahir.Text & "',tgl_lahir='" & tgl1 & "',no_telp='" & txtNoTelpon.Text & "',status='" & cmbStatus.Text & "',alamat='" & txtAlamat.Text & "',keterangan='" & txtKeterangan.Text & "',kd_pimpinan='" & txtKodePimpinan.Text & "',tgl_daftar='" & tgl2 & "' WHERE kd_agen= '" & txtKodeAgen.Text & "'"
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
End Class