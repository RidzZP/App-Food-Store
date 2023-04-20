<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormLaporan
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim ChartArea1 As System.Windows.Forms.DataVisualization.Charting.ChartArea = New System.Windows.Forms.DataVisualization.Charting.ChartArea()
        Dim Legend1 As System.Windows.Forms.DataVisualization.Charting.Legend = New System.Windows.Forms.DataVisualization.Charting.Legend()
        Dim Series1 As System.Windows.Forms.DataVisualization.Charting.Series = New System.Windows.Forms.DataVisualization.Charting.Series()
        Me.tglAwal = New System.Windows.Forms.DateTimePicker()
        Me.FileSystemWatcher1 = New System.IO.FileSystemWatcher()
        Me.btnLaporan = New System.Windows.Forms.Button()
        Me.btnUser = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.btnFilter = New System.Windows.Forms.Button()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.btnLogout = New System.Windows.Forms.Button()
        Me.btnGenerate = New System.Windows.Forms.Button()
        Me.chartLaporan = New System.Windows.Forms.DataVisualization.Charting.Chart()
        Me.tglAkhir = New System.Windows.Forms.DateTimePicker()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.tbLaporan = New System.Windows.Forms.DataGridView()
        Me.Label2 = New System.Windows.Forms.Label()
        CType(Me.FileSystemWatcher1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        CType(Me.chartLaporan, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.tbLaporan, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'tglAwal
        '
        Me.tglAwal.Location = New System.Drawing.Point(269, 65)
        Me.tglAwal.Name = "tglAwal"
        Me.tglAwal.Size = New System.Drawing.Size(208, 20)
        Me.tglAwal.TabIndex = 82
        '
        'FileSystemWatcher1
        '
        Me.FileSystemWatcher1.EnableRaisingEvents = True
        Me.FileSystemWatcher1.SynchronizingObject = Me
        '
        'btnLaporan
        '
        Me.btnLaporan.BackColor = System.Drawing.Color.SkyBlue
        Me.btnLaporan.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnLaporan.Location = New System.Drawing.Point(32, 282)
        Me.btnLaporan.Name = "btnLaporan"
        Me.btnLaporan.Size = New System.Drawing.Size(182, 29)
        Me.btnLaporan.TabIndex = 2
        Me.btnLaporan.Text = "Kelola Laporan"
        Me.btnLaporan.UseVisualStyleBackColor = False
        '
        'btnUser
        '
        Me.btnUser.BackColor = System.Drawing.Color.SkyBlue
        Me.btnUser.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnUser.Location = New System.Drawing.Point(32, 238)
        Me.btnUser.Name = "btnUser"
        Me.btnUser.Size = New System.Drawing.Size(182, 29)
        Me.btnUser.TabIndex = 1
        Me.btnUser.Text = "Kelola User"
        Me.btnUser.UseVisualStyleBackColor = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Arial Narrow", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(83, 26)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(91, 29)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Laporan"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(266, 49)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(72, 13)
        Me.Label5.TabIndex = 81
        Me.Label5.Text = "Tanggal Awal"
        '
        'btnFilter
        '
        Me.btnFilter.BackColor = System.Drawing.Color.SkyBlue
        Me.btnFilter.Location = New System.Drawing.Point(697, 54)
        Me.btnFilter.Name = "btnFilter"
        Me.btnFilter.Size = New System.Drawing.Size(93, 40)
        Me.btnFilter.TabIndex = 79
        Me.btnFilter.Text = "Filter"
        Me.btnFilter.UseVisualStyleBackColor = False
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.SystemColors.GradientInactiveCaption
        Me.Panel1.Controls.Add(Me.btnLogout)
        Me.Panel1.Controls.Add(Me.btnLaporan)
        Me.Panel1.Controls.Add(Me.btnUser)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Location = New System.Drawing.Point(2, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(250, 451)
        Me.Panel1.TabIndex = 77
        '
        'btnLogout
        '
        Me.btnLogout.BackColor = System.Drawing.Color.SkyBlue
        Me.btnLogout.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnLogout.Location = New System.Drawing.Point(32, 328)
        Me.btnLogout.Name = "btnLogout"
        Me.btnLogout.Size = New System.Drawing.Size(182, 29)
        Me.btnLogout.TabIndex = 3
        Me.btnLogout.Text = "Logout"
        Me.btnLogout.UseVisualStyleBackColor = False
        '
        'btnGenerate
        '
        Me.btnGenerate.BackColor = System.Drawing.Color.SkyBlue
        Me.btnGenerate.Location = New System.Drawing.Point(620, 301)
        Me.btnGenerate.Name = "btnGenerate"
        Me.btnGenerate.Size = New System.Drawing.Size(93, 40)
        Me.btnGenerate.TabIndex = 86
        Me.btnGenerate.Text = "Generate"
        Me.btnGenerate.UseVisualStyleBackColor = False
        '
        'chartLaporan
        '
        ChartArea1.Name = "ChartArea1"
        Me.chartLaporan.ChartAreas.Add(ChartArea1)
        Legend1.Name = "Legend1"
        Me.chartLaporan.Legends.Add(Legend1)
        Me.chartLaporan.Location = New System.Drawing.Point(258, 256)
        Me.chartLaporan.Name = "chartLaporan"
        Series1.ChartArea = "ChartArea1"
        Series1.Legend = "Legend1"
        Series1.Name = "Series1"
        Me.chartLaporan.Series.Add(Series1)
        Me.chartLaporan.Size = New System.Drawing.Size(464, 193)
        Me.chartLaporan.TabIndex = 85
        Me.chartLaporan.Text = "chart"
        '
        'tglAkhir
        '
        Me.tglAkhir.Location = New System.Drawing.Point(483, 65)
        Me.tglAkhir.Name = "tglAkhir"
        Me.tglAkhir.Size = New System.Drawing.Size(208, 20)
        Me.tglAkhir.TabIndex = 84
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(480, 49)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(73, 13)
        Me.Label3.TabIndex = 83
        Me.Label3.Text = "Tanggal Akhir"
        '
        'tbLaporan
        '
        Me.tbLaporan.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.tbLaporan.Location = New System.Drawing.Point(258, 100)
        Me.tbLaporan.Name = "tbLaporan"
        Me.tbLaporan.Size = New System.Drawing.Size(541, 150)
        Me.tbLaporan.TabIndex = 80
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Arial Narrow", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(436, 9)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(188, 29)
        Me.Label2.TabIndex = 78
        Me.Label2.Text = "Laporan Penjualan"
        '
        'FormLaporan
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.tglAwal)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.btnFilter)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.btnGenerate)
        Me.Controls.Add(Me.chartLaporan)
        Me.Controls.Add(Me.tglAkhir)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.tbLaporan)
        Me.Controls.Add(Me.Label2)
        Me.Name = "FormLaporan"
        Me.Text = "FormTransaksi"
        CType(Me.FileSystemWatcher1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.chartLaporan, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.tbLaporan, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents tglAwal As DateTimePicker
    Friend WithEvents FileSystemWatcher1 As IO.FileSystemWatcher
    Friend WithEvents Label5 As Label
    Friend WithEvents btnFilter As Button
    Friend WithEvents Panel1 As Panel
    Friend WithEvents btnLogout As Button
    Friend WithEvents btnLaporan As Button
    Friend WithEvents btnUser As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents btnGenerate As Button
    Friend WithEvents chartLaporan As DataVisualization.Charting.Chart
    Friend WithEvents tglAkhir As DateTimePicker
    Friend WithEvents Label3 As Label
    Friend WithEvents tbLaporan As DataGridView
    Friend WithEvents Label2 As Label
End Class
