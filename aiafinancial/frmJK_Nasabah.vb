Imports System.Data.Odbc
Public Class frmJK_Nasabah
    Sub isiGrid()
        ModConection.koneksi()
        da = New OdbcDataAdapter("SELECT * from jenisklaim ORDER BY kd_jnsklaim ASC", conn)
        ds = New DataSet
        da.Fill(ds, "jenisklaim")
        DGV.DataSource = ds.Tables("jenisklaim")
        DGV.ReadOnly = True
    End Sub
    Sub AturGrid()
        DGV.Columns(0).Width = 195
        DGV.Columns(1).Width = 195

        DGV.Columns(0).HeaderText = "Kode Jenis"
        DGV.Columns(1).HeaderText = "Jenis Klaim"
    End Sub
    Sub bersih()
        txtJenisKlaim.Clear()
    End Sub
    Sub auto()
        Try
            koneksi()
            cmd = New OdbcCommand("select max(right(kd_jnsklaim,3)) as jumlahku from jenisklaim", conn)
            dr = cmd.ExecuteReader
            If dr.HasRows = True Then
                Try
                    If dr("Jumlahku") <> 0 Then
                        dr.Read()
                        txtKodeJenisKlaim.Text = "KJKN-" & "00" & dr("Jumlahku") + 1
                    Else
                    End If
                Catch ex As Exception
                    txtKodeJenisKlaim.Text = "KJKN-001"
                End Try
            End If
        Catch ex As Exception
            MsgBox("Proses Pembuatan Nomor Otomatis Gagal. Silakan Cek Server", vbInformation, "Cek Server")
        End Try
    End Sub
    Private Sub grid()
        DGV.RowsDefaultCellStyle.BackColor = Color.White
        DGV.AlternatingRowsDefaultCellStyle.BackColor = Color.AliceBlue
    End Sub
    Private Sub frmJK_Nasabah_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        auto()
        isiGrid()
        AturGrid()
        grid()
    End Sub

    Private Sub DGV_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DGV.CellContentClick
        Dim i As Integer
        i = DGV.CurrentRow.Index
        Me.txtKodeJenisKlaim.Text = DGV.Item(0, i).Value
        Me.txtJenisKlaim.Text = DGV.Item(1, i).Value
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        If txtJenisKlaim.Text = "" Then
            MessageBox.Show("Data Belum Lengkap...", "informasi", MessageBoxButtons.OK)
        Else
            Try
                koneksi()
                Dim tanya As DialogResult
                tanya = MessageBox.Show("Data benar akan dihapus ?", "Konfirmasi", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
                If tanya = Windows.Forms.DialogResult.Yes Then
                    hapus = "DELETE FROM jenisklaim WHERE kd_jnsklaim='" & txtKodeJenisKlaim.Text & "'"
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
        If txtJenisKlaim.Text = "" Then
            MsgBox("Data belum lengkap !!")
            txtJenisKlaim.Focus()
        Else
            Try
                koneksi()
                cmd = New OdbcCommand("SELECT * from jenisklaim WHERE kd_jnsklaim= '" & txtKodeJenisKlaim.Text & "'", conn)
                dr = cmd.ExecuteReader
                dr.Read()
                If dr.HasRows Then
                    MsgBox("Maaf, Data tersebut telah ada", MsgBoxStyle.Exclamation, "Peringatan")
                Else
                    koneksi()
                    simpan = "INSERT INTO jenisklaim VALUES ('" & txtKodeJenisKlaim.Text & "','" & txtJenisKlaim.Text & "')"
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

    Private Sub Button4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button4.Click
        bersih()
        auto()
    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        If txtJenisKlaim.Text = "" Then
            MessageBox.Show("Data Belum Lengkap...", "informasi", MessageBoxButtons.OK)
        Else
            Try
                koneksi()
                Dim tanya As DialogResult
                tanya = MessageBox.Show("Data benar akan diubah ?", "Konfirmasi", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
                If tanya = Windows.Forms.DialogResult.Yes Then

                    ubah = "UPDATE jenisklaim SET jnsklaim='" & txtJenisKlaim.Text & "' WHERE kd_jnsklaim= '" & txtKodeJenisKlaim.Text & "'"
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