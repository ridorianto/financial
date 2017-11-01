Imports System.Data.Odbc
Public Class frmK_Nasabah
    Sub isiGrid()
        ModConection.koneksi()
        da = New OdbcDataAdapter("SELECT * FROM klaimnasabah ORDER BY kd_klaim ASC", conn)
        ds = New DataSet
        da.Fill(ds, "klaimnasabah")
        DGV.DataSource = ds.Tables("klaimnasabah")
        DGV.ReadOnly = True
    End Sub

    Sub AturGrid()
        DGV.Columns(0).Width = 90
        DGV.Columns(1).Width = 120
        DGV.Columns(2).Width = 90
        DGV.Columns(3).Width = 100
        DGV.Columns(4).Width = 260



        DGV.Columns(0).HeaderText = "Kode Klaim"
        DGV.Columns(1).HeaderText = "Kode Jenis Klaim"
        DGV.Columns(2).HeaderText = "No Daftar"
        DGV.Columns(3).HeaderText = "Tanggal Klaim"
        DGV.Columns(4).HeaderText = "Keterangan"
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
        cmd = New OdbcCommand("SELECT no_daftar From datanasabah", conn)
        dr = cmd.ExecuteReader
        cmbNo_Daftar.Items.Clear()
        cmbNo_Daftar.Items.Add("")
        Do While dr.Read
            cmbNo_Daftar.Items.Add(dr.Item("no_daftar"))

        Loop
        cmd.Dispose()
        dr.Close()
        conn.Close()
    End Sub

    Sub auto()
        Try
            koneksi()
            cmd = New OdbcCommand("select max(right(kd_klaim,3)) as jumlahku from klaimnasabah", conn)
            dr = cmd.ExecuteReader
            If dr.HasRows = True Then
                Try
                    If dr("Jumlahku") <> 0 Then
                        dr.Read()
                        txtKodeKlaim.Text = "KKAN-" & "00" & dr("Jumlahku") + 1
                    Else
                    End If
                Catch ex As Exception
                    txtKodeKlaim.Text = "KKAN-001"
                End Try
            End If
        Catch ex As Exception
            MsgBox("Proses Pembuatan Nomor Otomatis Gagal. Silakan Cek Server", vbInformation, "Cek Server")
        End Try
    End Sub
    Sub bersih()
        txtKeterangan.Clear()
        txtJenisKlaim.Clear()
        txtNamaBank.Clear()
        txtNamaNasabah.Clear()
        txtNoRekening.Clear()
        txtNoPolis.Clear()
        cmbKodeJenisKlaim.Text = ""
        cmbNo_Daftar.Text = ""
    End Sub
    Private Sub grid()
        DGV.RowsDefaultCellStyle.BackColor = Color.White
        DGV.AlternatingRowsDefaultCellStyle.BackColor = Color.AliceBlue
    End Sub
    Private Sub frmK_Nasabah_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        DateTimePicker1.Format = DateTimePickerFormat.Custom
        DateTimePicker1.CustomFormat = "yyyy/MM/dd"

        isiGrid()
        grid()
        AturGrid()
        auto()
        isiCombo()
        isiCombo1()
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        If cmbKodeJenisKlaim.Text = "" Or cmbNo_Daftar.Text = "" Or txtNoPolis.Text = "" Or txtNamaNasabah.Text = "" Or txtNamaBank.Text = "" Or txtNoRekening.Text = "" Or txtKeterangan.Text = "" Then
            MsgBox("Data belum lengkap !!")
            cmbKodeJenisKlaim.Focus()
        Else
            Try
                koneksi()
                Dim tanya As DialogResult
                tanya = MessageBox.Show("Data benar akan dihapus ?", "Konfirmasi", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
                If tanya = Windows.Forms.DialogResult.Yes Then
                    hapus = "DELETE FROM klaimnasabah WHERE kd_klaim='" & txtKodeKlaim.Text & "'"
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

    Private Sub DGV_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs)
       
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        If cmbKodeJenisKlaim.Text = "" Or cmbNo_Daftar.Text = "" Or txtNoPolis.Text = "" Or txtNamaNasabah.Text = "" Or txtNamaBank.Text = "" Or txtNoRekening.Text = "" Or txtKeterangan.Text = "" Then
            MsgBox("Data belum lengkap !!")
            cmbKodeJenisKlaim.Focus()
        Else
            Try
                koneksi()
                cmd = New OdbcCommand("SELECT * from klaimnasabah WHERE kd_klaim= '" & txtKodeKlaim.Text & "'", conn)
                dr = cmd.ExecuteReader
                dr.Read()
                If dr.HasRows Then
                    MsgBox("Maaf, Data tersebut telah ada", MsgBoxStyle.Exclamation, "Peringatan")
                Else
                    koneksi()
                    Dim tgl As String
                    tgl = Format(DateTimePicker1.Value, "yyyy/MM/dd")

                    simpan = "INSERT INTO klaimnasabah VALUES ('" & txtKodeKlaim.Text & "','" & cmbKodeJenisKlaim.Text & "','" & cmbNo_Daftar.Text & "','" & tgl & "','" & txtKeterangan.Text & "')"
                    cmd = New OdbcCommand(simpan, conn)
                    cmd.ExecuteNonQuery()
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

    Private Sub cmbNoPolis_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmbNo_Daftar.SelectedIndexChanged
        If cmbNo_Daftar.Text = "" Then
            txtNoPolis.Text = ""
            txtNamaNasabah.Text = ""
            txtNamaBank.Text = ""
            txtNoRekening.Text = ""
        Else
            koneksi()
            cmd = New OdbcCommand("SELECT * FROM datanasabah WHERE no_daftar = '" & cmbNo_Daftar.Text & "'", conn)

            dr = cmd.ExecuteReader
            dr.Read()
            txtNoPolis.Text = dr.Item(2)
            txtNamaNasabah.Text = dr.Item(3)
            txtNamaBank.Text = dr.Item(14)
            txtNoRekening.Text = dr.Item(15)
        End If
    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        If cmbKodeJenisKlaim.Text = "" Or cmbNo_Daftar.Text = "" Or txtNoPolis.Text = "" Or txtNamaNasabah.Text = "" Or txtNamaBank.Text = "" Or txtNoRekening.Text = "" Or txtKeterangan.Text = "" Then
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

                    ubah = "UPDATE klaimnasabah SET kd_jnsklaim='" & cmbKodeJenisKlaim.Text & "',no_daftar='" & cmbNo_Daftar.Text & "',tgl_klaim='" & tgl & "',keterangan='" & txtKeterangan.Text & "' WHERE kd_klaim= '" & txtKodeKlaim.Text & "'"
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

    Private Sub DGV_CellContentClick_1(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DGV.CellContentClick
        Dim i As Integer
        i = DGV.CurrentRow.Index

        Me.txtKodeKlaim.Text = DGV.Item(0, i).Value
        Me.cmbKodeJenisKlaim.Text = DGV.Item(1, i).Value
        Me.cmbNo_Daftar.Text = DGV.Item(2, i).Value
        Me.DateTimePicker1.Text = DGV.Item(3, i).Value.ToString
        Me.txtKeterangan.Text = DGV.Item(4, i).Value
    End Sub
End Class