Imports System.Data.SqlClient
Public Class FormUser
    Sub viewtable()
        sql = "SELECT * FROM tb_user"
        da = New SqlDataAdapter(sql, con)
        ds = New DataSet
        da.Fill(ds, "tb_user")
        tbUser.DataSource = ds.Tables("tb_user")
    End Sub

    Sub kosong()
        cbTipe.Text = ""
        txtNama.Text = ""
        txtTelepon.Text = ""
        txtAlamat.Text = ""
        txtUsername.Text = ""
        txtPassword.Text = ""
    End Sub


    Private Sub FormUser_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        connect()
        viewtable()

        txtId.Visible = False
    End Sub

    Private Sub btnTambah_Click(sender As Object, e As EventArgs) Handles btnTambah.Click
        If txtNama.Text = "" Or txtTelepon.Text = "" Or txtAlamat.Text = "" Or txtUsername.Text = "" Or txtPassword.Text = "" Then
            MsgBox("Pastikan Kolom Terisi")
        Else
            sql = "INSERT INTO tb_user(tipe_user, nama, alamat, telpon, username, password) VALUES ('" & cbTipe.Text & "',
                  '" & txtNama.Text & "',
                  '" & txtAlamat.Text & "',
                  '" & txtTelepon.Text & "',
                  '" & txtUsername.Text & "',
                  '" & txtPassword.Text & "')"

            cmd = New SqlCommand(sql, con)
            cmd.ExecuteNonQuery()
            MsgBox("Data Berhasil Di Simpan")
            kosong()
            viewtable()
        End If
    End Sub

    Private Sub btnEdit_Click(sender As Object, e As EventArgs) Handles btnEdit.Click
        If txtNama.Text = "" Or txtTelepon.Text = "" Or txtAlamat.Text = "" Or txtUsername.Text = "" Or txtPassword.Text = "" Then
            MsgBox("Pastikan Kolom Terisi")
        Else
            sql = "UPDATE tb_user SET tipe_user = '" & cbTipe.Text & "',
                  nama = '" & txtNama.Text & "',
                  alamat = '" & txtAlamat.Text & "',
                  telpon = '" & txtTelepon.Text & "',
                  username = '" & txtUsername.Text & "',
                  password = '" & txtPassword.Text & "' WHERE id_user = '" & txtId.Text & "'"
            cmd = New SqlCommand(sql, con)
            cmd.ExecuteNonQuery()
            MsgBox("Data Berhasil Di Edit")
            kosong()
            viewtable()
        End If
    End Sub

    Private Sub tbUser_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles tbUser.CellContentClick
        txtId.Text = tbUser.Rows(tbUser.CurrentRow.Index).Cells(0).Value
        cbTipe.Text = tbUser.Rows(tbUser.CurrentRow.Index).Cells(1).Value
        txtNama.Text = tbUser.Rows(tbUser.CurrentRow.Index).Cells(2).Value
        txtAlamat.Text = tbUser.Rows(tbUser.CurrentRow.Index).Cells(3).Value
        txtTelepon.Text = tbUser.Rows(tbUser.CurrentRow.Index).Cells(4).Value
        txtUsername.Text = tbUser.Rows(tbUser.CurrentRow.Index).Cells(5).Value
        txtPassword.Text = tbUser.Rows(tbUser.CurrentRow.Index).Cells(6).Value

        ' set nilai combobox berdasarkan kolom yang diklik
        Dim level As String = tbUser.Rows(tbUser.CurrentRow.Index).Cells(1).Value
        cbTipe.SelectedItem = level
    End Sub

    Private Sub btnHapus_Click(sender As Object, e As EventArgs) Handles btnHapus.Click
        Dim hasil As DialogResult = MessageBox.Show("Apakah yakin ingin menghapus data ini?", "Konfirmasi Hapus", MessageBoxButtons.YesNo)
        If hasil = DialogResult.Yes Then
            If txtNama.Text = "" Or txtTelepon.Text = "" Or txtAlamat.Text = "" Or txtUsername.Text = "" Or txtPassword.Text = "" Then
                MsgBox("Pastikan Kolom Terisi")
            Else
                sql = "DELETE FROM tb_user WHERE id_user ='" & txtId.Text & "'"
                cmd = New SqlCommand(sql, con)
                cmd.ExecuteNonQuery()
                MsgBox("Data Berhasil Di Hapus")
                kosong()
                viewtable()
            End If
        End If
    End Sub

    Private Sub TextBox6_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtCari.KeyPress
        If txtCari.Text = "" Then
            viewtable()
        Else
            sql = "SELECT * FROM tb_user WHERE (nama LIKE '%" & txtCari.Text & "%')"
            da = New SqlDataAdapter(sql, con)
            ds = New DataSet
            da.Fill(ds, "tb_user")
            tbUser.DataSource = ds.Tables("tb_user")
        End If
    End Sub

    Private Sub btnLaporan_Click(sender As Object, e As EventArgs) Handles btnLaporan.Click
        FormTransaksi.Show()
        Me.Hide()
    End Sub

    Private Sub btnLogout_Click(sender As Object, e As EventArgs) Handles btnLogout.Click
        ' Simpan aktivitas logout ke database
        Dim waktu As DateTime = DateTime.Now
        Dim aktivitas As String = "Logout"
        Dim id_user As Integer = GlobalVariable.logUserId
        Dim queryLog As String = "INSERT INTO tb_log (waktu, aktivitas, id_user) VALUES (@waktu, @aktivitas, @id_user)"
        Using cmdLog As New SqlCommand(queryLog, con)
            cmdLog.Parameters.AddWithValue("@waktu", waktu)
            cmdLog.Parameters.AddWithValue("@aktivitas", aktivitas)
            cmdLog.Parameters.AddWithValue("@id_user", id_user)
            cmdLog.ExecuteNonQuery()
        End Using

        GlobalVariable.logUserId = 0

        Login.Show()
        Me.Hide()
    End Sub

    Private Sub txtCari_TextChanged(sender As Object, e As EventArgs) Handles txtCari.TextChanged

    End Sub
End Class