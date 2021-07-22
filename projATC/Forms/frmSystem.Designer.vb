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
        Me.cmdSystem = New System.Windows.Forms.Button()
        Me.cmdSetPrinter = New System.Windows.Forms.Button()
        Me.cmdLogs = New System.Windows.Forms.Button()
        Me.cmdPrinter = New System.Windows.Forms.Button()
        Me.cmdIDtype = New System.Windows.Forms.Button()
        Me.cmdPurpose = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'cmdAccounts
        '
        Me.cmdAccounts.BackColor = System.Drawing.Color.White
        Me.cmdAccounts.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cmdAccounts.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdAccounts.Image = CType(resources.GetObject("cmdAccounts.Image"), System.Drawing.Image)
        Me.cmdAccounts.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.cmdAccounts.Location = New System.Drawing.Point(6, 136)
        Me.cmdAccounts.Name = "cmdAccounts"
        Me.cmdAccounts.Size = New System.Drawing.Size(293, 59)
        Me.cmdAccounts.TabIndex = 2
        Me.cmdAccounts.Text = "           System Accounts"
        Me.cmdAccounts.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.cmdAccounts.UseVisualStyleBackColor = False
        '
        'cmdTerminate
        '
        Me.cmdTerminate.BackColor = System.Drawing.Color.White
        Me.cmdTerminate.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cmdTerminate.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdTerminate.Image = CType(resources.GetObject("cmdTerminate.Image"), System.Drawing.Image)
        Me.cmdTerminate.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.cmdTerminate.Location = New System.Drawing.Point(6, 461)
        Me.cmdTerminate.Name = "cmdTerminate"
        Me.cmdTerminate.Size = New System.Drawing.Size(293, 59)
        Me.cmdTerminate.TabIndex = 7
        Me.cmdTerminate.Text = "           Terminate System"
        Me.cmdTerminate.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.cmdTerminate.UseVisualStyleBackColor = False
        '
        'cmdCompany
        '
        Me.cmdCompany.BackColor = System.Drawing.Color.White
        Me.cmdCompany.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cmdCompany.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdCompany.Image = CType(resources.GetObject("cmdCompany.Image"), System.Drawing.Image)
        Me.cmdCompany.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.cmdCompany.Location = New System.Drawing.Point(6, 201)
        Me.cmdCompany.Name = "cmdCompany"
        Me.cmdCompany.Size = New System.Drawing.Size(293, 59)
        Me.cmdCompany.TabIndex = 3
        Me.cmdCompany.Text = "           Company Record"
        Me.cmdCompany.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.cmdCompany.UseVisualStyleBackColor = False
        '
        'cmdDatabase
        '
        Me.cmdDatabase.BackColor = System.Drawing.Color.White
        Me.cmdDatabase.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cmdDatabase.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdDatabase.Image = CType(resources.GetObject("cmdDatabase.Image"), System.Drawing.Image)
        Me.cmdDatabase.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.cmdDatabase.Location = New System.Drawing.Point(6, 71)
        Me.cmdDatabase.Name = "cmdDatabase"
        Me.cmdDatabase.Size = New System.Drawing.Size(293, 59)
        Me.cmdDatabase.TabIndex = 1
        Me.cmdDatabase.Text = "           Database Settings"
        Me.cmdDatabase.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.cmdDatabase.UseVisualStyleBackColor = False
        '
        'cmdSystem
        '
        Me.cmdSystem.BackColor = System.Drawing.Color.White
        Me.cmdSystem.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cmdSystem.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdSystem.Image = CType(resources.GetObject("cmdSystem.Image"), System.Drawing.Image)
        Me.cmdSystem.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.cmdSystem.Location = New System.Drawing.Point(6, 6)
        Me.cmdSystem.Name = "cmdSystem"
        Me.cmdSystem.Size = New System.Drawing.Size(293, 59)
        Me.cmdSystem.TabIndex = 0
        Me.cmdSystem.Text = "           System Settings"
        Me.cmdSystem.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.cmdSystem.UseVisualStyleBackColor = False
        '
        'cmdSetPrinter
        '
        Me.cmdSetPrinter.BackColor = System.Drawing.Color.White
        Me.cmdSetPrinter.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cmdSetPrinter.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdSetPrinter.Image = CType(resources.GetObject("cmdSetPrinter.Image"), System.Drawing.Image)
        Me.cmdSetPrinter.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.cmdSetPrinter.Location = New System.Drawing.Point(6, 331)
        Me.cmdSetPrinter.Name = "cmdSetPrinter"
        Me.cmdSetPrinter.Size = New System.Drawing.Size(293, 59)
        Me.cmdSetPrinter.TabIndex = 14
        Me.cmdSetPrinter.Text = "           Printer settings"
        Me.cmdSetPrinter.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.cmdSetPrinter.UseVisualStyleBackColor = False
        '
        'cmdLogs
        '
        Me.cmdLogs.BackColor = System.Drawing.Color.White
        Me.cmdLogs.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cmdLogs.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdLogs.Image = CType(resources.GetObject("cmdLogs.Image"), System.Drawing.Image)
        Me.cmdLogs.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.cmdLogs.Location = New System.Drawing.Point(6, 396)
        Me.cmdLogs.Name = "cmdLogs"
        Me.cmdLogs.Size = New System.Drawing.Size(293, 59)
        Me.cmdLogs.TabIndex = 6
        Me.cmdLogs.Text = "           Visitor Logs History"
        Me.cmdLogs.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.cmdLogs.UseVisualStyleBackColor = False
        '
        'cmdPrinter
        '
        Me.cmdPrinter.BackColor = System.Drawing.Color.White
        Me.cmdPrinter.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cmdPrinter.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdPrinter.Image = CType(resources.GetObject("cmdPrinter.Image"), System.Drawing.Image)
        Me.cmdPrinter.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.cmdPrinter.Location = New System.Drawing.Point(6, 331)
        Me.cmdPrinter.Name = "cmdPrinter"
        Me.cmdPrinter.Size = New System.Drawing.Size(293, 59)
        Me.cmdPrinter.TabIndex = 5
        Me.cmdPrinter.Text = "           Printer settings"
        Me.cmdPrinter.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.cmdPrinter.UseVisualStyleBackColor = False
        '
        'cmdIDtype
        '
        Me.cmdIDtype.BackColor = System.Drawing.Color.White
        Me.cmdIDtype.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cmdIDtype.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdIDtype.Image = CType(resources.GetObject("cmdIDtype.Image"), System.Drawing.Image)
        Me.cmdIDtype.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.cmdIDtype.Location = New System.Drawing.Point(6, 331)
        Me.cmdIDtype.Name = "cmdIDtype"
        Me.cmdIDtype.Size = New System.Drawing.Size(293, 59)
        Me.cmdIDtype.TabIndex = 4
        Me.cmdIDtype.Text = "           ID Type List"
        Me.cmdIDtype.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.cmdIDtype.UseVisualStyleBackColor = False
        Me.cmdIDtype.Visible = False
        '
        'cmdPurpose
        '
        Me.cmdPurpose.BackColor = System.Drawing.Color.White
        Me.cmdPurpose.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cmdPurpose.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdPurpose.Image = CType(resources.GetObject("cmdPurpose.Image"), System.Drawing.Image)
        Me.cmdPurpose.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.cmdPurpose.Location = New System.Drawing.Point(6, 266)
        Me.cmdPurpose.Name = "cmdPurpose"
        Me.cmdPurpose.Size = New System.Drawing.Size(293, 59)
        Me.cmdPurpose.TabIndex = 15
        Me.cmdPurpose.Text = "           Purpose List"
        Me.cmdPurpose.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.cmdPurpose.UseVisualStyleBackColor = False
        '
        'frmSystem
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.LightSteelBlue
        Me.ClientSize = New System.Drawing.Size(304, 527)
        Me.Controls.Add(Me.cmdPurpose)
        Me.Controls.Add(Me.cmdSetPrinter)
        Me.Controls.Add(Me.cmdIDtype)
        Me.Controls.Add(Me.cmdPrinter)
        Me.Controls.Add(Me.cmdLogs)
        Me.Controls.Add(Me.cmdAccounts)
        Me.Controls.Add(Me.cmdTerminate)
        Me.Controls.Add(Me.cmdCompany)
        Me.Controls.Add(Me.cmdDatabase)
        Me.Controls.Add(Me.cmdSystem)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmSystem"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = " System Settings"
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents cmdAccounts As System.Windows.Forms.Button
    Friend WithEvents cmdTerminate As System.Windows.Forms.Button
    Friend WithEvents cmdCompany As System.Windows.Forms.Button
    Friend WithEvents cmdDatabase As System.Windows.Forms.Button
    Friend WithEvents cmdSystem As System.Windows.Forms.Button
    Friend WithEvents cmdSetPrinter As System.Windows.Forms.Button
    Friend WithEvents cmdLogs As System.Windows.Forms.Button
    Friend WithEvents cmdPrinter As System.Windows.Forms.Button
    Friend WithEvents cmdIDtype As System.Windows.Forms.Button
    Friend WithEvents cmdPurpose As System.Windows.Forms.Button
End Class
