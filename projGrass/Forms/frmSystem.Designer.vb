<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmSystem
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmSystem))
        Me.cmdAccounts = New System.Windows.Forms.Button()
        Me.cmdTerminate = New System.Windows.Forms.Button()
        Me.cmdCompany = New System.Windows.Forms.Button()
        Me.cmdDatabase = New System.Windows.Forms.Button()
        Me.cmdSetPrinter = New System.Windows.Forms.Button()
        Me.cmdLogs = New System.Windows.Forms.Button()
        Me.cmdPurpose = New System.Windows.Forms.Button()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.LbClose = New System.Windows.Forms.Label()
        Me.lbTitle = New System.Windows.Forms.Label()
        Me.btnAbout = New System.Windows.Forms.Button()
        Me.Panel2.SuspendLayout()
        Me.SuspendLayout()
        '
        'cmdAccounts
        '
        Me.cmdAccounts.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.cmdAccounts.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cmdAccounts.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdAccounts.ForeColor = System.Drawing.Color.White
        Me.cmdAccounts.Image = CType(resources.GetObject("cmdAccounts.Image"), System.Drawing.Image)
        Me.cmdAccounts.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.cmdAccounts.Location = New System.Drawing.Point(6, 104)
        Me.cmdAccounts.Name = "cmdAccounts"
        Me.cmdAccounts.Size = New System.Drawing.Size(293, 59)
        Me.cmdAccounts.TabIndex = 2
        Me.cmdAccounts.Text = "           System Accounts"
        Me.cmdAccounts.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.cmdAccounts.UseVisualStyleBackColor = False
        '
        'cmdTerminate
        '
        Me.cmdTerminate.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.cmdTerminate.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cmdTerminate.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdTerminate.ForeColor = System.Drawing.Color.White
        Me.cmdTerminate.Image = CType(resources.GetObject("cmdTerminate.Image"), System.Drawing.Image)
        Me.cmdTerminate.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.cmdTerminate.Location = New System.Drawing.Point(7, 494)
        Me.cmdTerminate.Name = "cmdTerminate"
        Me.cmdTerminate.Size = New System.Drawing.Size(293, 59)
        Me.cmdTerminate.TabIndex = 7
        Me.cmdTerminate.Text = "           Terminate System"
        Me.cmdTerminate.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.cmdTerminate.UseVisualStyleBackColor = False
        '
        'cmdCompany
        '
        Me.cmdCompany.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.cmdCompany.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cmdCompany.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdCompany.ForeColor = System.Drawing.Color.White
        Me.cmdCompany.Image = CType(resources.GetObject("cmdCompany.Image"), System.Drawing.Image)
        Me.cmdCompany.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.cmdCompany.Location = New System.Drawing.Point(6, 169)
        Me.cmdCompany.Name = "cmdCompany"
        Me.cmdCompany.Size = New System.Drawing.Size(293, 59)
        Me.cmdCompany.TabIndex = 3
        Me.cmdCompany.Text = "           Units Record"
        Me.cmdCompany.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.cmdCompany.UseVisualStyleBackColor = False
        '
        'cmdDatabase
        '
        Me.cmdDatabase.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.cmdDatabase.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cmdDatabase.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdDatabase.ForeColor = System.Drawing.Color.White
        Me.cmdDatabase.Image = CType(resources.GetObject("cmdDatabase.Image"), System.Drawing.Image)
        Me.cmdDatabase.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.cmdDatabase.Location = New System.Drawing.Point(6, 39)
        Me.cmdDatabase.Name = "cmdDatabase"
        Me.cmdDatabase.Size = New System.Drawing.Size(293, 59)
        Me.cmdDatabase.TabIndex = 1
        Me.cmdDatabase.Text = "           Database Settings"
        Me.cmdDatabase.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.cmdDatabase.UseVisualStyleBackColor = False
        '
        'cmdSetPrinter
        '
        Me.cmdSetPrinter.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.cmdSetPrinter.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cmdSetPrinter.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdSetPrinter.ForeColor = System.Drawing.Color.White
        Me.cmdSetPrinter.Image = CType(resources.GetObject("cmdSetPrinter.Image"), System.Drawing.Image)
        Me.cmdSetPrinter.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.cmdSetPrinter.Location = New System.Drawing.Point(6, 299)
        Me.cmdSetPrinter.Name = "cmdSetPrinter"
        Me.cmdSetPrinter.Size = New System.Drawing.Size(293, 59)
        Me.cmdSetPrinter.TabIndex = 14
        Me.cmdSetPrinter.Text = "           Printer settings"
        Me.cmdSetPrinter.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.cmdSetPrinter.UseVisualStyleBackColor = False
        '
        'cmdLogs
        '
        Me.cmdLogs.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.cmdLogs.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cmdLogs.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdLogs.ForeColor = System.Drawing.Color.White
        Me.cmdLogs.Image = CType(resources.GetObject("cmdLogs.Image"), System.Drawing.Image)
        Me.cmdLogs.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.cmdLogs.Location = New System.Drawing.Point(6, 364)
        Me.cmdLogs.Name = "cmdLogs"
        Me.cmdLogs.Size = New System.Drawing.Size(293, 59)
        Me.cmdLogs.TabIndex = 6
        Me.cmdLogs.Text = "           Reports"
        Me.cmdLogs.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.cmdLogs.UseVisualStyleBackColor = False
        '
        'cmdPurpose
        '
        Me.cmdPurpose.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.cmdPurpose.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cmdPurpose.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdPurpose.ForeColor = System.Drawing.Color.White
        Me.cmdPurpose.Image = CType(resources.GetObject("cmdPurpose.Image"), System.Drawing.Image)
        Me.cmdPurpose.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.cmdPurpose.Location = New System.Drawing.Point(6, 234)
        Me.cmdPurpose.Name = "cmdPurpose"
        Me.cmdPurpose.Size = New System.Drawing.Size(293, 59)
        Me.cmdPurpose.TabIndex = 15
        Me.cmdPurpose.Text = "           Purpose List"
        Me.cmdPurpose.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.cmdPurpose.UseVisualStyleBackColor = False
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Panel2.Controls.Add(Me.LbClose)
        Me.Panel2.Controls.Add(Me.lbTitle)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel2.Location = New System.Drawing.Point(0, 0)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(306, 32)
        Me.Panel2.TabIndex = 122
        '
        'LbClose
        '
        Me.LbClose.Anchor = System.Windows.Forms.AnchorStyles.Right
        Me.LbClose.AutoSize = True
        Me.LbClose.BackColor = System.Drawing.Color.Transparent
        Me.LbClose.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LbClose.ForeColor = System.Drawing.Color.White
        Me.LbClose.Location = New System.Drawing.Point(285, 5)
        Me.LbClose.Name = "LbClose"
        Me.LbClose.Size = New System.Drawing.Size(17, 20)
        Me.LbClose.TabIndex = 32
        Me.LbClose.Text = "x"
        '
        'lbTitle
        '
        Me.lbTitle.AutoSize = True
        Me.lbTitle.BackColor = System.Drawing.Color.Transparent
        Me.lbTitle.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbTitle.ForeColor = System.Drawing.Color.White
        Me.lbTitle.Image = CType(resources.GetObject("lbTitle.Image"), System.Drawing.Image)
        Me.lbTitle.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.lbTitle.Location = New System.Drawing.Point(4, 8)
        Me.lbTitle.Name = "lbTitle"
        Me.lbTitle.Size = New System.Drawing.Size(180, 16)
        Me.lbTitle.TabIndex = 31
        Me.lbTitle.Text = "      System Control Panel"
        '
        'btnAbout
        '
        Me.btnAbout.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.btnAbout.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnAbout.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAbout.ForeColor = System.Drawing.Color.White
        Me.btnAbout.Image = CType(resources.GetObject("btnAbout.Image"), System.Drawing.Image)
        Me.btnAbout.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnAbout.Location = New System.Drawing.Point(7, 429)
        Me.btnAbout.Name = "btnAbout"
        Me.btnAbout.Size = New System.Drawing.Size(293, 59)
        Me.btnAbout.TabIndex = 123
        Me.btnAbout.Text = "           About"
        Me.btnAbout.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnAbout.UseVisualStyleBackColor = False
        '
        'frmSystem
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Silver
        Me.ClientSize = New System.Drawing.Size(306, 560)
        Me.ControlBox = False
        Me.Controls.Add(Me.btnAbout)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.cmdPurpose)
        Me.Controls.Add(Me.cmdSetPrinter)
        Me.Controls.Add(Me.cmdLogs)
        Me.Controls.Add(Me.cmdAccounts)
        Me.Controls.Add(Me.cmdTerminate)
        Me.Controls.Add(Me.cmdCompany)
        Me.Controls.Add(Me.cmdDatabase)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmSystem"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents cmdAccounts As System.Windows.Forms.Button
    Friend WithEvents cmdTerminate As System.Windows.Forms.Button
    Friend WithEvents cmdCompany As System.Windows.Forms.Button
    Friend WithEvents cmdDatabase As System.Windows.Forms.Button
    Friend WithEvents cmdSetPrinter As System.Windows.Forms.Button
    Friend WithEvents cmdLogs As System.Windows.Forms.Button
    Friend WithEvents cmdPurpose As System.Windows.Forms.Button
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents LbClose As System.Windows.Forms.Label
    Friend WithEvents lbTitle As System.Windows.Forms.Label
    Friend WithEvents btnAbout As System.Windows.Forms.Button
End Class
