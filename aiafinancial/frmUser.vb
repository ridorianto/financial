Imports System.Data.Odbc
Public Class frmUser
    Sub isiGrid()
        ModConection.koneksi()
        da = New OdbcDataAdapter("SELECT * from user", conn)
        ds = New DataSet
        da.Fill(ds, "user")
        DGV.DataSource = ds.Tables("user")
        DGV.ReadOnly = True
    End Sub
    Sub AturGrid()
        DGV.Columns(0).Width = 60
        DGV.Columns(1).Width = 120
        DGV.Columns(2).Width = 120
        DGV.Columns(3).Width = 85

        DGV.Columns(0).HeaderText = "Kode"
        DGV.Columns(1).HeaderText = "Username"
        DGV.Columns(2).HeaderText = "Password"
        DGV.Columns(3).HeaderText = "Level"
    End Sub
    Sub bersih()
        txtUser.Clear()
        txtPass.Clear()
        cmbLevel.Text = ""
    End Sub
    Sub auto()
        Try
            koneksi()
            cmd = New OdbcCommand("select max(right(kd_user,3)) as jumlahku from user", conn)
            dr = cmd.ExecuteReader
            If dr.HasRows = True Then
                Try
                    If dr("Jumlahku") <> 0 Then
                        dr.Read()
                        txtKodeUser.Text = "KDUA-" & "00" & dr("Jumlahku") + 1
                    Else
                    End If
                Catch ex As Exception
                    txtKodeUser.Text = "KDUA-001"
                End Try
            End If
        Catch ex As Exception
            MsgBox("Proses Pembuatan Nomor Otomatis Gagal. Silakan Cek Server", vbInformation, "Cek Server")
        End Try
    End Sub
    Private Sub Button4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button4.Click
        bersih()
        auto()
    End Sub
    Private Sub grid()
        DGV.RowsDefaultCellStyle.BackColor = Color.White
        DGV.AlternatingRowsDefaultCellStyle.BackColor = Color.AliceBlue
    End Sub
    Private Sub frmUser_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        isiGrid()
        AturGrid()
        auto()
        grid()
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        If txtUser.Text = "" Or txtPass.Text = "" Or cmbLevel.Text = "" Then
            MsgBox("Data belum lengkap !!")
            txtUser.Focus()
        Else
            Try
                koneksi()
                cmd = New OdbcCommand("SELECT * from user WHERE kd_user= '" & txtKodeUser.Text & "'", conn)
                dr = cmd.ExecuteReader
                dr.Read()
                If dr.HasRows Then
                    MsgBox("Maaf, Data dengan user tersebut telah ada", MsgBoxStyle.Exclamation, "Peringatan")
                Else
                    koneksi()
                    simpan = "INSERT INTO user VALUES ('" & txtKodeUser.Text & "','" & txtUser.Text & "','" & txtPass.Text & "','" & cmbLevel.Text & "')"
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

    Private Sub DGV_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DGV.CellContentClick
        Dim i As Integer
        i = DGV.CurrentRow.Index
        Me.txtKodeUser.Text = DGV.Item(0, i).Value
        Me.txtUser.Text = DGV.Item(1, i).Value
        Me.txtPass.Text = DGV.Item(2, i).Value
        Me.cmbLevel.Text = DGV.Item(3, i).Value
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        If txtUser.Text = "" Then
            MessageBox.Show("Data Belum Lengkap...", "informasi", MessageBoxButtons.OK)
        Else
            Try
                koneksi()
                Dim tanya As DialogResult
                tanya = MessageBox.Show("Data benar akan dihapus ?", "Konfirmasi", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
                If tanya = Windows.Forms.DialogResult.Yes Then
                    hapus = "DELETE FROM user WHERE kd_user='" & txtKodeUser.Text & "'"
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
        If txtUser.Text = "" Or cmbLevel.Text = "" Then
            MessageBox.Show("Data Belum Lengkap...", "informasi", MessageBoxButtons.OK)
        Else
            Try
                koneksi()
                Dim tanya As DialogResult
                tanya = MessageBox.Show("Data benar akan diubah ?", "Konfirmasi", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
                If tanya = Windows.Forms.DialogResult.Yes Then

                    ubah = "UPDATE user SET username='" & txtUser.Text & "',password='" & txtPass.Text & "',level='" & cmbLevel.Text & "'WHERE kd_user= '" & txtKodeUser.Text & "'"
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