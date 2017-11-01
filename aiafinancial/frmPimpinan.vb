Imports System.Data.Odbc
Public Class frmPimpinan
    Sub isiGrid()
        ModConection.koneksi()
        da = New OdbcDataAdapter("SELECT * from datapimpinan ORDER BY kd_pimpinan ASC", conn)
        ds = New DataSet
        da.Fill(ds, "kd_pimpinan")
        DGV.DataSource = ds.Tables("kd_pimpinan")
        DGV.ReadOnly = True
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

        DGV.Columns(0).HeaderText = "Kode Pimpinan"
        DGV.Columns(1).HeaderText = "Nama Pimpinan"
        DGV.Columns(2).HeaderText = "Jekel"
        DGV.Columns(3).HeaderText = "Tempat Lahir"
        DGV.Columns(4).HeaderText = "Tanggal Lahir"
        DGV.Columns(5).HeaderText = "No Telepon"
        DGV.Columns(6).HeaderText = "Status"
        DGV.Columns(7).HeaderText = "Alamat"
        DGV.Columns(8).HeaderText = "Keterangan"
    End Sub
    Sub auto()
        Try
            koneksi()
            cmd = New OdbcCommand("select max(right(kd_pimpinan,3)) as jumlahku from datapimpinan", conn)
            dr = cmd.ExecuteReader
            If dr.HasRows = True Then
                Try
                    If dr("Jumlahku") <> 0 Then
                        dr.Read()
                        txtKodePimpinan.Text = "KDPI-" & "00" & dr("Jumlahku") + 1
                    Else
                    End If
                Catch ex As Exception
                    txtKodePimpinan.Text = "KDPI-001"
                End Try
            End If
        Catch ex As Exception
            MsgBox("Proses Pembuatan Nomor Otomatis Gagal. Silakan Cek Server", vbInformation, "Cek Server")
        End Try
    End Sub
    Sub bersih()
        txtNama.Clear()
        txtTempatLahir.Clear()
        txtNoTelpon.Clear()
        txtAlamat.Clear()
        txtKeterangan.Clear()
        cmbJekel.Text = ""
        cmbStatus.Text = ""
        auto()
    End Sub

    Private Sub grid()
        DGV.RowsDefaultCellStyle.BackColor = Color.White
        DGV.AlternatingRowsDefaultCellStyle.BackColor = Color.AliceBlue
    End Sub
    Private Sub frmPimpinan_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        DateTimePicker1.Format = DateTimePickerFormat.Custom
        DateTimePicker1.CustomFormat = "yyyy/MM/dd"
        isiGrid()
        AturGrid()
        bersih()
        auto()
        grid()
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        If txtKeterangan.Text = "" Or txtNama.Text = "" Or txtNoTelpon.Text = "" Or cmbJekel.Text = "" Or cmbStatus.Text = "" Or txtTempatLahir.Text = "Then" Then
            MessageBox.Show("Data Belum Lengkap...", "informasi", MessageBoxButtons.OK)
        Else
            Try
                koneksi()
                Dim tanya As DialogResult
                tanya = MessageBox.Show("Data benar akan dihapus ?", "Konfirmasi", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
                If tanya = Windows.Forms.DialogResult.Yes Then
                    hapus = "DELETE FROM datapimpinan WHERE kd_pimpinan='" & txtKodePimpinan.Text & "'"
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

    Private Sub Button4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button4.Click
        bersih()
        auto()
    End Sub

    Private Sub DGV_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DGV.CellContentClick
        Dim i As Integer
        i = DGV.CurrentRow.Index

        Me.txtKodePimpinan.Text = DGV.Item(0, i).Value
        Me.txtNama.Text = DGV.Item(1, i).Value
        Me.cmbJekel.Text = DGV.Item(2, i).Value
        Me.txtTempatLahir.Text = DGV.Item(3, i).Value
        Me.DateTimePicker1.Text = DGV.Item(4, i).Value.ToString
        Me.txtNoTelpon.Text = DGV.Item(5, i).Value
        Me.cmbStatus.Text = DGV.Item(6, i).Value
        Me.txtAlamat.Text = DGV.Item(7, i).Value
        Me.txtKeterangan.Text = DGV.Item(8, i).Value
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        If txtNama.Text = "" Or txtTempatLahir.Text = "" Or txtNoTelpon.Text = "" Or txtAlamat.Text = "" Or txtKeterangan.Text = "" Or cmbJekel.Text = "" Or cmbStatus.Text = "" Then
            MsgBox("Data belum lengkap !!")
            txtNama.Focus()
        Else
            Try
                koneksi()
                cmd = New OdbcCommand("SELECT * from datapimpinan WHERE kd_pimpinan= '" & txtKodePimpinan.Text & "'", conn)
                dr = cmd.ExecuteReader
                dr.Read()
                If dr.HasRows Then
                    MsgBox("Maaf, Data tersebut telah ada", MsgBoxStyle.Exclamation, "Peringatan")
                Else
                    koneksi()
                    Dim tgl As String
                    tgl = Format(DateTimePicker1.Value, "yyyy/MM/dd")

                    simpan = "INSERT INTO datapimpinan VALUES ('" & txtKodePimpinan.Text & "','" & txtNama.Text & "','" & cmbJekel.Text & "','" & txtTempatLahir.Text & "','" & tgl & "','" & txtNoTelpon.Text & "','" & cmbStatus.Text & "','" & txtAlamat.Text & "','" & txtKeterangan.Text & "')"
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

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        If txtKeterangan.Text = "" Or txtNama.Text = "" Or txtNoTelpon.Text = "" Or cmbJekel.Text = "" Or cmbStatus.Text = "" Or txtTempatLahir.Text = "Then" Then
            MessageBox.Show("Data Belum Lengkap...", "informasi", MessageBoxButtons.OK)
        Else
            Try
                koneksi()
                Dim tanya As DialogResult
                tanya = MessageBox.Show("Data benar akan diubah ?", "Konfirmasi", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
                If tanya = Windows.Forms.DialogResult.Yes Then
                    Dim tgl As String
                    tgl = Format(DateTimePicker1.Value, "yyyy/MM/dd")

                    ubah = "UPDATE datapimpinan SET nm_pimpinan='" & txtNama.Text & "',jk='" & cmbJekel.Text & "',tmpt_lahir='" & txtTempatLahir.Text & "',tgl_lahir='" & tgl & "',no_telp='" & txtNoTelpon.Text & "',status='" & cmbStatus.Text & "',alamat='" & txtAlamat.Text & "',keterangan='" & txtKeterangan.Text & "' WHERE kd_pimpinan= '" & txtKodePimpinan.Text & "'"
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

    Private Sub cmbJekel_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmbJekel.SelectedIndexChanged

    End Sub
End Class