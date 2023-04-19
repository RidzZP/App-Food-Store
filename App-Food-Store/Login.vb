Imports System.Data.SqlClient
Public Class Login

    'mengosongkan texbox(field)
    Private Sub btnReset_Click(sender As Object, e As EventArgs) Handles btnReset.Click
        txtUsername.Text = ""
        txtPassword.Text = ""
    End Sub

    'fungsi login
    Private Sub btnLogin_Click(sender As Object, e As EventArgs) Handles btnLogin.Click
        connect()
        If txtUsername.Text = "" Or txtPassword.PasswordChar = "" Then
            MsgBox("Pastikan Semua Terisi")
        Else
            sql = "SELECT * FROM tb_user WHERE username = '" & txtUsername.Text & "' And password = '" & txtPassword.Text & "'"
            cmd = New SqlCommand(sql, con)
            dr = cmd.ExecuteReader
            If dr.HasRows Then
                dr.Read()
                If dr.Item("tipe_user").Equals("Admin") Then
                    'Simpan Ke Log
                    Dim waktu As DateTime = DateTime.Now
                    GlobalVariable.logUserId = dr.Item("id_user")
                    Dim aktivitas As String = "Login"
                    dr.Close()
                    Dim queryLog As String = "INSERT INTO tb_log (waktu, aktivitas, id_user) VALUES (@waktu, @aktivitas, " & GlobalVariable.logUserId & ")"
                    Using cmdLog As New SqlCommand(queryLog, con)
                        cmdLog.Parameters.AddWithValue("@waktu", waktu)
                        cmdLog.Parameters.AddWithValue("@aktivitas", aktivitas)
                        cmdLog.Parameters.AddWithValue("@id_user", GlobalVariable.logUserId)
                        cmdLog.ExecuteNonQuery()
                    End Using

                    FormLog.Show()
                    Me.Hide()
                ElseIf dr.Item("tipe_user").Equals("Gudang") Then
                    'Simpan Ke Log
                    Dim waktu As DateTime = DateTime.Now
                    GlobalVariable.logUserId = dr.Item("id_user")
                    Dim aktivitas As String = "Login"
                    dr.Close()
                    Dim queryLog As String = "INSERT INTO tb_log (waktu, aktivitas, id_user) VALUES (@waktu, @aktivitas, " & GlobalVariable.logUserId & ")"
                    Using cmdLog As New SqlCommand(queryLog, con)
                        cmdLog.Parameters.AddWithValue("@waktu", waktu)
                        cmdLog.Parameters.AddWithValue("@aktivitas", aktivitas)
                        cmdLog.Parameters.AddWithValue("@id_user", GlobalVariable.logUserId)
                        cmdLog.ExecuteNonQuery()
                    End Using

                    FormGudang.Show()
                    Me.Hide()
                ElseIf dr.Item("tipe_user").Equals("Kasir") Then
                    'Simpan Ke Log
                    Dim waktu As DateTime = DateTime.Now
                    GlobalVariable.logUserId = dr.Item("id_user")
                    Dim aktivitas As String = "Login"
                    dr.Close()
                    Dim queryLog As String = "INSERT INTO tb_log (waktu, aktivitas, id_user) VALUES (@waktu, @aktivitas, " & GlobalVariable.logUserId & ")"
                    Using cmdLog As New SqlCommand(queryLog, con)
                        cmdLog.Parameters.AddWithValue("@waktu", waktu)
                        cmdLog.Parameters.AddWithValue("@aktivitas", aktivitas)
                        cmdLog.Parameters.AddWithValue("@id_user", GlobalVariable.logUserId)
                        cmdLog.ExecuteNonQuery()
                    End Using

                    FormTransaksi.Show()
                    Me.Hide()
                Else
                    MsgBox("Username Atau Password Salah")
                    dr.Close()
                End If
            Else
                MsgBox("Username Atau Password Salah")
                dr.Close()
            End If
        End If
    End Sub

    Private Sub Login_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class
