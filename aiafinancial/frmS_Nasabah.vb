Imports System.Data.Odbc
Public Class frmS_Nasabah
    Sub isiGrid()
        ModConection.koneksi()
        da = New OdbcDataAdapter("SELECT*FROM setorannasabah ORDER BY kd_setor ASC", conn)
        ds = New DataSet
        da.Fill(ds, "setorannasabah")
        DGV.DataSource = ds.Tables("setorannasabah")
        DGV.ReadOnly = True
    End Sub
    Sub AturGrid()
        DGV.Columns(0).Width = 90
        DGV.Columns(1).Width = 100
        DGV.Columns(2).Width = 100
        DGV.Columns(3).Width = 90
        DGV.Columns(4).Width = 150
        DGV.Columns(5).Width = 90
        DGV.Columns(6).Width = 190
        DGV.Columns(7).Width = 110


        DGV.Columns(0).HeaderText = "Kode Setor"
        DGV.Columns(1).HeaderText = "Kode Jenis Klaim"
        DGV.Columns(2).HeaderText = "Kode Jenis Setor"
        DGV.Columns(3).HeaderText = "No Daftar"
        DGV.Columns(4).HeaderText = "Jumlah Dana"
        DGV.Columns(5).HeaderText = "Tanggal Setor"
        DGV.Columns(6).HeaderText = "Keterangan"
        DGV.Columns(7).HeaderText = "Jumlah Dana"
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
        cmd = New OdbcCommand("SELECT kd_jnssetor From jenissetoran", conn)
        dr = cmd.ExecuteReader
        cmbKodeJenisSetoran.Items.Clear()
        cmbKodeJenisSetoran.Items.Add("")
        Do While dr.Read
            cmbKodeJenisSetoran.Items.Add(dr.Item("kd_jnssetor"))

        Loop
        cmd.Dispose()
        dr.Close()
        conn.Close()
    End Sub
    Sub isiCombo2()
        koneksi()
        cmd = New OdbcCommand("SELECT no_daftar From datanasabah", conn)
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
            cmd = New OdbcCommand("select max(right(kd_setor,3)) as jumlahku from setorannasabah", conn)
            dr = cmd.ExecuteReader
            If dr.HasRows = True Then
                Try
                    If dr("Jumlahku") <> 0 Then
                        dr.Read()
                        txtKodeSetoran.Text = "KSNA-" & "00" & dr("Jumlahku") + 1
                    Else
                    End If
                Catch ex As Exception
                    txtKodeSetoran.Text = "KSNA-001"
                End Try
            End If
        Catch ex As Exception
            MsgBox("Proses Pembuatan Nomor Otomatis Gagal. Silakan Cek Server", vbInformation, "Cek Server")
        End Try
    End Sub
    Sub bersih()
        txtJumlahSetoran.Clear()
        txtKeterangan.Clear()
        txtJenisKlaim.Clear()
        txtJenisSetoran.Clear()
        txtJumlahSeluruh.Clear()
        txtNamaNasabah.Clear()
        txtNoRekening.Clear()
        txtNoPolis.Clear()
        cmbKodeJenisKlaim.Text = ""
        cmbKodeJenisSetoran.Text = ""
        cmbNoDaftar.Text = ""
    End Sub
    Private Sub grid()
        DGV.RowsDefaultCellStyle.BackColor = Color.White
        DGV.AlternatingRowsDefaultCellStyle.BackColor = Color.AliceBlue
    End Sub
    Private Sub frmS_Nasabah_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        DateTimePicker1.Format = DateTimePickerFormat.Custom
        DateTimePicker1.CustomFormat = "yyyy/MM/dd"

        grid()
        isiGrid()
        AturGrid()
        auto()
        isiCombo()
        isiCombo1()
        isiCombo2()
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        If cmbKodeJenisKlaim.Text = "" Or cmbKodeJenisSetoran.Text = "" Or cmbNoDaftar.Text = "" Or txtNamaNasabah.Text = "" Or txtJumlahSeluruh.Text = "" Or txtNoRekening.Text = "" Or txtKeterangan.Text = "" Then
            MsgBox("Data belum lengkap !!")
            cmbKodeJenisKlaim.Focus()
        Else
            Try
                koneksi()
                Dim tanya As DialogResult
                tanya = MessageBox.Show("Data benar akan dihapus ?", "Konfirmasi", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
                If tanya = Windows.Forms.DialogResult.Yes Then
                    hapus = "DELETE FROM setorannasabah WHERE kd_setor='" & txtKodeSetoran.Text & "'"
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

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        If cmbKodeJenisKlaim.Text = "" Or cmbKodeJenisSetoran.Text = "" Or cmbNoDaftar.Text = "" Or txtNamaNasabah.Text = "" Or txtJumlahSeluruh.Text = "" Or txtNoRekening.Text = "" Or txtKeterangan.Text = "" Then
            MsgBox("Data belum lengkap !!")
            cmbKodeJenisKlaim.Focus()
        Else
            Try
                koneksi()
                cmd = New OdbcCommand("SELECT * from setorannasabah WHERE kd_setor= '" & txtKodeSetoran.Text & "'", conn)
                dr = cmd.ExecuteReader
                dr.Read()
                If dr.HasRows Then
                    MsgBox("Maaf, Data tersebut telah ada", MsgBoxStyle.Exclamation, "Peringatan")
                Else
                    koneksi()
                    Dim tgl As String
                    tgl = Format(DateTimePicker1.Value, "yyyy/MM/dd")

                    simpan = "INSERT INTO setorannasabah VALUES ('" & txtKodeSetoran.Text & "','" & cmbKodeJenisKlaim.Text & "','" & cmbKodeJenisSetoran.Text & "','" & cmbNoDaftar.Text & "','" & txtJumlahSetoran.Text & "','" & tgl & "','" & txtKeterangan.Text & "','" & txtJumlahSeluruh.Text & "')"
                    cmd = New OdbcCommand(simpan, conn)
                    cmd.ExecuteNonQuery()

                    'ubah total dana
                    cmd = New OdbcCommand("select * from datanasabah where no_daftar='" & cmbNoDaftar.Text & "'", conn)
                    dr = cmd.ExecuteReader
                    dr.Read()
                    If dr.HasRows Then
                        Dim Kurangi As String = "update datanasabah set total_dana= '" & txtJumlahSeluruh.Text & "' where no_daftar='" & cmbNoDaftar.Text & "'"
                        cmd = New OdbcCommand(Kurangi, conn)
                        cmd.ExecuteNonQuery()
                    End If
                    isiGrid()
                    MsgBox("Data Sukses Tersimpan", MsgBoxStyle.Information, "Pesan")
                    bersih()
                    auto()
                End If
            Catch ex As Exception
                MsgBox(ex.ToString, MsgBoxStyle.Critical, "Terjadi Kesalahan")
            End Try
        End If
    End Sub

    Private Sub cmbJenisKlaim_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmbKodeJenisKlaim.SelectedIndexChanged
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

    Private Sub cmbNoPolis_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmbNoDaftar.SelectedIndexChanged
        If cmbNoDaftar.Text = "" Then
            cmbNoDaftar.Text = ""
            txtNoPolis.Text = ""
            txtNamaNasabah.Text = ""
            txtJumlahSeluruh.Text = ""
            txtNoRekening.Text = ""
            txtJumlah.Text = ""
        Else
            koneksi()
            cmd = New OdbcCommand("SELECT * FROM datanasabah WHERE no_daftar= '" & cmbNoDaftar.Text & "'", conn)

            dr = cmd.ExecuteReader
            dr.Read()
            txtNoPolis.Text = dr.Item(2)
            txtNamaNasabah.Text = dr.Item(3)
            txtNoRekening.Text = dr.Item(18)
            txtJumlah.Text = dr.Item(23)
        End If
    End Sub

    Private Sub cmbJenisSetoran_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmbKodeJenisSetoran.SelectedIndexChanged
        If cmbKodeJenisSetoran.Text = "" Then
            cmbKodeJenisSetoran.Text = ""
            txtJenisSetoran.Text = ""
        Else
            koneksi()
            cmd = New OdbcCommand("SELECT * FROM jenissetoran WHERE kd_jnssetor = '" & cmbKodeJenisSetoran.Text & "'", conn)

            dr = cmd.ExecuteReader
            dr.Read()
            txtJenisSetoran.Text = dr.Item(1)
        End If
    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        If cmbKodeJenisKlaim.Text = "" Or cmbKodeJenisSetoran.Text = "" Or cmbNoDaftar.Text = "" Or txtNamaNasabah.Text = "" Or txtJumlahSeluruh.Text = "" Or txtNoRekening.Text = "" Or txtKeterangan.Text = "" Then
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

                    ubah = "UPDATE setorannasabah SET kd_jnsklaim='" & cmbKodeJenisKlaim.Text & "',kd_jnssetor='" & cmbKodeJenisSetoran.Text & "',no_daftar='" & cmbNoDaftar.Text & "',jml_dana='" & txtJumlahSetoran.Text & "',tgl_setor='" & tgl & "',keterangan='" & txtKeterangan.Text & "',jml_danaseluruh='" & txtJumlahSeluruh.Text & "' WHERE kd_setor= '" & txtKodeSetoran.Text & "'"
                    cmd = New OdbcCommand(ubah, conn)
                    cmd.ExecuteNonQuery()

                    'ubah total dana
                    cmd = New OdbcCommand("select * from datanasabah where no_daftar='" & cmbNoDaftar.Text & "'", conn)
                    dr = cmd.ExecuteReader
                    dr.Read()
                    If dr.HasRows Then
                        Dim Kurangi As String = "update datanasabah set total_dana= '" & txtJumlahSeluruh.Text & "' where no_daftar='" & cmbNoDaftar.Text & "'"
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

    Private Sub Button4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button4.Click
        bersih()
        auto()
    End Sub

    Private Sub DGV_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DGV.CellContentClick
        Dim i As Integer
        i = DGV.CurrentRow.Index

        Me.txtKodeSetoran.Text = DGV.Item(0, i).Value
        Me.cmbKodeJenisKlaim.Text = DGV.Item(1, i).Value
        Me.cmbKodeJenisSetoran.Text = DGV.Item(2, i).Value
        Me.cmbNoDaftar.Text = DGV.Item(3, i).Value
        Me.txtJumlahSetoran.Text = DGV.Item(4, i).Value
        Me.DateTimePicker1.Text = DGV.Item(5, i).Value.ToString
        Me.txtKeterangan.Text = DGV.Item(6, i).Value
    End Sub
    Private Sub txtJumlahSetoran_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtJumlahSetoran.TextChanged
        txtJumlahSeluruh.Text = Val(txtJumlahSetoran.Text) + Val(txtJumlah.Text)
    End Sub
End Class