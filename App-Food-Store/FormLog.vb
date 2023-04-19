Imports System.Data.SqlClient
Public Class FormLog

    'Menampilkan data ke Table dan merubah id_user menjadi username
    Sub viewtable()
        sql = "SELECT tb_log.waktu, tb_log.aktivitas, tb_user.username FROM tb_log INNER JOIN tb_user ON tb_log.id_user = tb_user.id_user"
        da = New SqlDataAdapter(sql, con)
        ds = New DataSet
        da.Fill(ds, "tb_log")
        tbLog.DataSource = ds.Tables("tb_log")
    End Sub

    'Tambahkan pada formLoad
    Private Sub FormLog_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        connect()
        viewtable()
    End Sub

    Private Sub DataGridView1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles tbLog.CellContentClick

    End Sub

    'Membuat fungsi filter data menampilkan data berdasarkan tanggal
    Private Sub btnFilter_Click(sender As Object, e As EventArgs) Handles btnFilter.Click
        Dim tanggalFilter As Date = tglFilter.Value.Date
        Dim sql As String = "SELECT tb_log.waktu, tb_log.aktivitas, tb_user.username " &
                "FROM tb_log " &
                "INNER JOIN tb_user ON tb_log.id_user = tb_user.id_user " &
                "WHERE CONVERT(date, waktu) = @tanggalFilter"
        Dim cmd As New SqlCommand(sql, con)
        cmd.Parameters.AddWithValue("@tanggalFilter", tanggalFilter)

        Dim da As New SqlDataAdapter(cmd)
        Dim ds As New DataSet
        da.Fill(ds, "tb_log")

        tbLog.DataSource = ds.Tables("tb_log")
    End Sub

    Private Sub btnLaporan_Click(sender As Object, e As EventArgs) Handles btnLaporan.Click
        FormLaporan.Show()
        Me.Hide()
    End Sub

    Private Sub btnUser_Click(sender As Object, e As EventArgs) Handles btnUser.Click
        FormUser.Show()
        Me.Hide()
    End Sub

    'fungsi logout sekaligus mengirimkan aktivitas logout pada tb_log
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
End Class