<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'Controles de la interfaz
    Friend WithEvents pnlHeader As System.Windows.Forms.Panel
    Friend WithEvents lblTitle As System.Windows.Forms.Label
    Friend WithEvents lblGroup As System.Windows.Forms.Label
    Friend WithEvents pnlSidebar As System.Windows.Forms.Panel
    Friend WithEvents btnGenerateData As System.Windows.Forms.Button
    Friend WithEvents btnStartTournament As System.Windows.Forms.Button
    Friend WithEvents lblListTitle As System.Windows.Forms.Label
    Friend WithEvents lstCountries As System.Windows.Forms.ListBox
    Friend WithEvents pnlMain As System.Windows.Forms.Panel
    Friend WithEvents lblTreeTitle As System.Windows.Forms.Label
    Friend WithEvents tvTournament As System.Windows.Forms.TreeView
    Friend WithEvents pnlLogs As System.Windows.Forms.Panel
    Friend WithEvents lblLogsTitle As System.Windows.Forms.Label
    Friend WithEvents lstLogs As System.Windows.Forms.TextBox

    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.pnlHeader = New System.Windows.Forms.Panel()
        Me.lblGroup = New System.Windows.Forms.Label()
        Me.lblTitle = New System.Windows.Forms.Label()
        Me.pnlSidebar = New System.Windows.Forms.Panel()
        Me.lstCountries = New System.Windows.Forms.ListBox()
        Me.lblListTitle = New System.Windows.Forms.Label()
        Me.btnStartTournament = New System.Windows.Forms.Button()
        Me.btnGenerateData = New System.Windows.Forms.Button()
        Me.pnlMain = New System.Windows.Forms.Panel()
        Me.tvTournament = New System.Windows.Forms.TreeView()
        Me.lblTreeTitle = New System.Windows.Forms.Label()
        Me.pnlLogs = New System.Windows.Forms.Panel()
        Me.lstLogs = New System.Windows.Forms.TextBox()
        Me.lblLogsTitle = New System.Windows.Forms.Label()
        Me.pnlHeader.SuspendLayout()
        Me.pnlSidebar.SuspendLayout()
        Me.pnlMain.SuspendLayout()
        Me.pnlLogs.SuspendLayout()
        Me.SuspendLayout()
        '
        'pnlHeader
        '
        Me.pnlHeader.BackColor = System.Drawing.Color.FromArgb(CType(CType(20, Byte), Integer), CType(CType(25, Byte), Integer), CType(CType(35, Byte), Integer))
        Me.pnlHeader.Controls.Add(Me.lblGroup)
        Me.pnlHeader.Controls.Add(Me.lblTitle)
        Me.pnlHeader.Dock = System.Windows.Forms.DockStyle.Top
        Me.pnlHeader.Location = New System.Drawing.Point(0, 0)
        Me.pnlHeader.Name = "pnlHeader"
        Me.pnlHeader.Size = New System.Drawing.Size(1288, 95)
        Me.pnlHeader.TabIndex = 0
        '
        'lblGroup
        '
        Me.lblGroup.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.lblGroup.AutoSize = True
        Me.lblGroup.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblGroup.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(215, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.lblGroup.Location = New System.Drawing.Point(454, 58)
        Me.lblGroup.Name = "lblGroup"
        Me.lblGroup.Size = New System.Drawing.Size(433, 21)
        Me.lblGroup.TabIndex = 1
        Me.lblGroup.Text = "✨ Grupo: Sarai Romero, Leo Lucas y Gimena Vargas ✨"
        Me.lblGroup.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblTitle
        '
        Me.lblTitle.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.lblTitle.AutoSize = True
        Me.lblTitle.Font = New System.Drawing.Font("Segoe UI Black", 26.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTitle.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(230, Byte), Integer), CType(CType(200, Byte), Integer))
        Me.lblTitle.Location = New System.Drawing.Point(359, 12)
        Me.lblTitle.Name = "lblTitle"
        Me.lblTitle.Size = New System.Drawing.Size(694, 47)
        Me.lblTitle.TabIndex = 0
        Me.lblTitle.Text = "🏆🏆🏆 TOURNAMENT SORT 🏆🏆🏆"
        Me.lblTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'pnlSidebar
        '
        Me.pnlSidebar.BackColor = System.Drawing.Color.FromArgb(CType(CType(30, Byte), Integer), CType(CType(35, Byte), Integer), CType(CType(45, Byte), Integer))
        Me.pnlSidebar.Controls.Add(Me.lstCountries)
        Me.pnlSidebar.Controls.Add(Me.lblListTitle)
        Me.pnlSidebar.Controls.Add(Me.btnStartTournament)
        Me.pnlSidebar.Controls.Add(Me.btnGenerateData)
        Me.pnlSidebar.Dock = System.Windows.Forms.DockStyle.Left
        Me.pnlSidebar.Location = New System.Drawing.Point(0, 95)
        Me.pnlSidebar.Name = "pnlSidebar"
        Me.pnlSidebar.Padding = New System.Windows.Forms.Padding(15, 20, 15, 15)
        Me.pnlSidebar.Size = New System.Drawing.Size(300, 575)
        Me.pnlSidebar.TabIndex = 1
        '
        'lstCountries
        '
        Me.lstCountries.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lstCountries.BackColor = System.Drawing.Color.FromArgb(CType(CType(20, Byte), Integer), CType(CType(25, Byte), Integer), CType(CType(35, Byte), Integer))
        Me.lstCountries.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lstCountries.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lstCountries.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(230, Byte), Integer), CType(CType(200, Byte), Integer))
        Me.lstCountries.FormattingEnabled = True
        Me.lstCountries.IntegralHeight = False
        Me.lstCountries.ItemHeight = 20
        Me.lstCountries.Location = New System.Drawing.Point(15, 185)
        Me.lstCountries.Name = "lstCountries"
        Me.lstCountries.Size = New System.Drawing.Size(270, 370)
        Me.lstCountries.TabIndex = 4
        '
        'lblListTitle
        '
        Me.lblListTitle.AutoSize = True
        Me.lblListTitle.Font = New System.Drawing.Font("Segoe UI Semibold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblListTitle.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(215, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.lblListTitle.Location = New System.Drawing.Point(15, 155)
        Me.lblListTitle.Name = "lblListTitle"
        Me.lblListTitle.Size = New System.Drawing.Size(269, 21)
        Me.lblListTitle.TabIndex = 2
        Me.lblListTitle.Text = "🎲🎲 PAÍSES EN DESORDEN 🎲🎲"
        '
        'btnStartTournament
        '
        Me.btnStartTournament.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(100, Byte), Integer), CType(CType(100, Byte), Integer))
        Me.btnStartTournament.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnStartTournament.Dock = System.Windows.Forms.DockStyle.Top
        Me.btnStartTournament.FlatAppearance.BorderSize = 0
        Me.btnStartTournament.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnStartTournament.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnStartTournament.ForeColor = System.Drawing.Color.White
        Me.btnStartTournament.Location = New System.Drawing.Point(15, 75)
        Me.btnStartTournament.Name = "btnStartTournament"
        Me.btnStartTournament.Size = New System.Drawing.Size(270, 55)
        Me.btnStartTournament.TabIndex = 1
        Me.btnStartTournament.Text = "¡INICIAR TORNEO!"
        Me.btnStartTournament.UseVisualStyleBackColor = False
        '
        'btnGenerateData
        '
        Me.btnGenerateData.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(150, Byte), Integer), CType(CType(200, Byte), Integer))
        Me.btnGenerateData.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnGenerateData.Dock = System.Windows.Forms.DockStyle.Top
        Me.btnGenerateData.FlatAppearance.BorderSize = 0
        Me.btnGenerateData.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnGenerateData.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnGenerateData.ForeColor = System.Drawing.Color.White
        Me.btnGenerateData.Location = New System.Drawing.Point(15, 20)
        Me.btnGenerateData.Name = "btnGenerateData"
        Me.btnGenerateData.Size = New System.Drawing.Size(270, 55)
        Me.btnGenerateData.TabIndex = 0
        Me.btnGenerateData.Text = " CARGAR PAÍSES "
        Me.btnGenerateData.UseVisualStyleBackColor = False
        '
        'pnlMain
        '
        Me.pnlMain.BackColor = System.Drawing.Color.FromArgb(CType(CType(245, Byte), Integer), CType(CType(245, Byte), Integer), CType(CType(250, Byte), Integer))
        Me.pnlMain.Controls.Add(Me.tvTournament)
        Me.pnlMain.Controls.Add(Me.lblTreeTitle)
        Me.pnlMain.Dock = System.Windows.Forms.DockStyle.Fill
        Me.pnlMain.Location = New System.Drawing.Point(300, 95)
        Me.pnlMain.Name = "pnlMain"
        Me.pnlMain.Padding = New System.Windows.Forms.Padding(20)
        Me.pnlMain.Size = New System.Drawing.Size(678, 575)
        Me.pnlMain.TabIndex = 2
        '
        'tvTournament
        '
        Me.tvTournament.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.tvTournament.BackColor = System.Drawing.Color.White
        Me.tvTournament.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.tvTournament.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tvTournament.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(100, Byte), Integer), CType(CType(150, Byte), Integer))
        Me.tvTournament.Indent = 25
        Me.tvTournament.ItemHeight = 25
        Me.tvTournament.LineColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(100, Byte), Integer), CType(CType(100, Byte), Integer))
        Me.tvTournament.Location = New System.Drawing.Point(20, 75)
        Me.tvTournament.Name = "tvTournament"
        Me.tvTournament.Size = New System.Drawing.Size(638, 475)
        Me.tvTournament.TabIndex = 4
        '
        'lblTreeTitle
        '
        Me.lblTreeTitle.AutoSize = True
        Me.lblTreeTitle.Font = New System.Drawing.Font("Segoe UI Black", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTreeTitle.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(100, Byte), Integer), CType(CType(100, Byte), Integer))
        Me.lblTreeTitle.Location = New System.Drawing.Point(154, 28)
        Me.lblTreeTitle.Name = "lblTreeTitle"
        Me.lblTreeTitle.Size = New System.Drawing.Size(266, 32)
        Me.lblTreeTitle.TabIndex = 3
        Me.lblTreeTitle.Text = "LLAVES DEL TORNEO "
        '
        'pnlLogs
        '
        Me.pnlLogs.BackColor = System.Drawing.Color.FromArgb(CType(CType(20, Byte), Integer), CType(CType(25, Byte), Integer), CType(CType(35, Byte), Integer))
        Me.pnlLogs.Controls.Add(Me.lstLogs)
        Me.pnlLogs.Controls.Add(Me.lblLogsTitle)
        Me.pnlLogs.Dock = System.Windows.Forms.DockStyle.Right
        Me.pnlLogs.Location = New System.Drawing.Point(978, 95)
        Me.pnlLogs.Name = "pnlLogs"
        Me.pnlLogs.Padding = New System.Windows.Forms.Padding(15, 20, 15, 15)
        Me.pnlLogs.Size = New System.Drawing.Size(310, 575)
        Me.pnlLogs.TabIndex = 3
        '
        'lstLogs
        '
        Me.lstLogs.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lstLogs.BackColor = System.Drawing.Color.FromArgb(CType(CType(10, Byte), Integer), CType(CType(15, Byte), Integer), CType(CType(20, Byte), Integer))
        Me.lstLogs.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lstLogs.Font = New System.Drawing.Font("Consolas", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lstLogs.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(230, Byte), Integer), CType(CType(200, Byte), Integer))
        Me.lstLogs.Location = New System.Drawing.Point(15, 75)
        Me.lstLogs.Multiline = True
        Me.lstLogs.Name = "lstLogs"
        Me.lstLogs.ReadOnly = True
        Me.lstLogs.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.lstLogs.Size = New System.Drawing.Size(283, 480)
        Me.lstLogs.TabIndex = 6
        '
        'lblLogsTitle
        '
        Me.lblLogsTitle.AutoSize = True
        Me.lblLogsTitle.Font = New System.Drawing.Font("Segoe UI Semibold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblLogsTitle.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(215, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.lblLogsTitle.Location = New System.Drawing.Point(88, 37)
        Me.lblLogsTitle.Name = "lblLogsTitle"
        Me.lblLogsTitle.Size = New System.Drawing.Size(152, 21)
        Me.lblLogsTitle.TabIndex = 5
        Me.lblLogsTitle.Text = "(CONSOLA VISUAL)"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(1288, 670)
        Me.Controls.Add(Me.pnlMain)
        Me.Controls.Add(Me.pnlLogs)
        Me.Controls.Add(Me.pnlSidebar)
        Me.Controls.Add(Me.pnlHeader)
        Me.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.MinimumSize = New System.Drawing.Size(1050, 620)
        Me.Name = "Form1"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "🏆🏆🏆 TOURNAMENT SORT - UPRIT 🏆🏆🏆"
        Me.pnlHeader.ResumeLayout(False)
        Me.pnlHeader.PerformLayout()
        Me.pnlSidebar.ResumeLayout(False)
        Me.pnlSidebar.PerformLayout()
        Me.pnlMain.ResumeLayout(False)
        Me.pnlMain.PerformLayout()
        Me.pnlLogs.ResumeLayout(False)
        Me.pnlLogs.PerformLayout()
        Me.ResumeLayout(False)

    End Sub


End Class