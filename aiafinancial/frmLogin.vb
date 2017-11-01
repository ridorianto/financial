Imports System.Data.Odbc
Public Class frmLogin

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        koneksi()
        cmd = New OdbcCommand("select * from user where username='" & txtUser.Text & "' and password='" & txtPass.Text & "'", conn)
        dr = cmd.ExecuteReader
        dr.Read()
        If dr.HasRows Then
            Me.Visible = False
            frmMain.Show()
            frmMain.Label5.Text = dr.GetString(0)
            frmMain.Label6.Text = dr.GetString(3)
            If frmMain.Label6.Text <> "Admin" Then
                frmMain.DataMasterToolStripMenuItem.Visible = False
                frmMain.LaporanToolStripMenuItem.Visible = False
                frmMain.UserToolStripMenuItem.Visible = False
                frmMain.DataAgenToolStripMenuItem.Visible = False
                frmMain.DataKlaimNasabahToolStripMenuItem.Visible = False
                frmMain.DataPenarikanDanaNasabahToolStripMenuItem.Visible = False
                frmMain.DataSetoranNasabahToolStripMenuItem.Visible = False
                frmMain.TabControl1.Enabled = False
            Else
                frmMain.DataMasterToolStripMenuItem.Visible = True
                frmMain.LaporanToolStripMenuItem.Visible = True
                frmMain.UserToolStripMenuItem.Visible = True
                frmMain.DataAgenToolStripMenuItem.Visible = True
                frmMain.DataKlaimNasabahToolStripMenuItem.Visible = True
                frmMain.DataPenarikanDanaNasabahToolStripMenuItem.Visible = True
                frmMain.DataSetoranNasabahToolStripMenuItem.Visible = True
                frmMain.TabControl1.Enabled = True
               
            End If
        Else
            MsgBox("login salah, periksan kembali user name dan password")
            txtUser.Focus()
        End If
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        txtUser.Clear()
        txtPass.Clear()
    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        End
    End Sub
End Class