<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmSystemTitle
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmSystemTitle))
        Me.cboMode = New System.Windows.Forms.ComboBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.chkSigna = New System.Windows.Forms.CheckBox()
        Me.chkIdScanner = New System.Windows.Forms.CheckBox()
        Me.chkAutoNumber = New System.Windows.Forms.CheckBox()
        Me.chkWebcam = New System.Windows.Forms.CheckBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.cmdFP = New System.Windows.Forms.Button()
        Me.txtpath = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtOR = New System.Windows.Forms.NumericUpDown()
        Me.cboStation = New System.Windows.Forms.ComboBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.cmdSave = New System.Windows.Forms.Button()
        Me.FBD = New System.Windows.Forms.FolderBrowserDialog()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.LbClose = New System.Windows.Forms.Label()
        Me.lbTitle = New System.Windows.Forms.Label()
        Me.cboSetEnv = New System.Windows.Forms.ComboBox()
        Me.Label5 = New System.Windows.Forms.Label()
        CType(Me.txtOR, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel2.SuspendLayout()
        Me.SuspendLayout()
        '
        'cboMode
        '
        Me.cboMode.BackColor = System.Drawing.Color.White
        Me.cboMode.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboMode.Items.AddRange(New Object() {"MANUAL", "CARD", "BARCODE"})
        Me.cboMode.Location = New System.Drawing.Point(194, 106)
        Me.cboMode.Name = "cboMode"
        Me.cboMode.Size = New System.Drawing.Size(202, 24)
        Me.cboMode.TabIndex = 1
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Black
        Me.Label1.Location = New System.Drawing.Point(132, 109)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(55, 16)
        Me.Label1.TabIndex = 45
        Me.Label1.Text = "Mode :"
        '
        'chkSigna
        '
        Me.chkSigna.AutoSize = True
        Me.chkSigna.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkSigna.Location = New System.Drawing.Point(194, 349)
        Me.chkSigna.Name = "chkSigna"
        Me.chkSigna.Size = New System.Drawing.Size(178, 20)
        Me.chkSigna.TabIndex = 9
        Me.chkSigna.Text = "Enable Signature Pad"
        Me.chkSigna.UseVisualStyleBackColor = True
        '
        'chkIdScanner
        '
        Me.chkIdScanner.AutoSize = True
        Me.chkIdScanner.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkIdScanner.Location = New System.Drawing.Point(194, 323)
        Me.chkIdScanner.Name = "chkIdScanner"
        Me.chkIdScanner.Size = New System.Drawing.Size(156, 20)
        Me.chkIdScanner.TabIndex = 8
        Me.chkIdScanner.Text = "Enable ID Scanner"
        Me.chkIdScanner.UseVisualStyleBackColor = True
        '
        'chkAutoNumber
        '
        Me.chkAutoNumber.AutoSize = True
        Me.chkAutoNumber.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkAutoNumber.Location = New System.Drawing.Point(194, 271)
        Me.chkAutoNumber.Name = "chkAutoNumber"
        Me.chkAutoNumber.Size = New System.Drawing.Size(171, 20)
        Me.chkAutoNumber.TabIndex = 6
        Me.chkAutoNumber.Text = "Auto IDnumber Count"
        Me.chkAutoNumber.UseVisualStyleBackColor = True
        '
        'chkWebcam
        '
        Me.chkWebcam.AutoSize = True
        Me.chkWebcam.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkWebcam.Location = New System.Drawing.Point(194, 297)
        Me.chkWebcam.Name = "chkWebcam"
        Me.chkWebcam.Size = New System.Drawing.Size(147, 20)
        Me.chkWebcam.TabIndex = 7
        Me.chkWebcam.Text = "Enable Web Cam"
        Me.chkWebcam.UseVisualStyleBackColor = True
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.Black
        Me.Label3.Location = New System.Drawing.Point(15, 225)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(172, 18)
        Me.Label3.TabIndex = 39
        Me.Label3.Text = "Data Designate Path :"
        '
        'cmdFP
        '
        Me.cmdFP.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.cmdFP.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cmdFP.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdFP.ForeColor = System.Drawing.Color.White
        Me.cmdFP.Image = CType(resources.GetObject("cmdFP.Image"), System.Drawing.Image)
        Me.cmdFP.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.cmdFP.Location = New System.Drawing.Point(364, 218)
        Me.cmdFP.Name = "cmdFP"
        Me.cmdFP.Size = New System.Drawing.Size(33, 34)
        Me.cmdFP.TabIndex = 5
        Me.cmdFP.UseVisualStyleBackColor = False
        '
        'txtpath
        '
        Me.txtpath.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtpath.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtpath.Location = New System.Drawing.Point(194, 225)
        Me.txtpath.MaxLength = 150
        Me.txtpath.Name = "txtpath"
        Me.txtpath.Size = New System.Drawing.Size(164, 22)
        Me.txtpath.TabIndex = 4
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.Black
        Me.Label2.Location = New System.Drawing.Point(103, 147)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(84, 18)
        Me.Label2.TabIndex = 36
        Me.Label2.Text = "ID Count :"
        '
        'txtOR
        '
        Me.txtOR.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtOR.Location = New System.Drawing.Point(194, 145)
        Me.txtOR.Maximum = New Decimal(New Integer() {99999999, 0, 0, 0})
        Me.txtOR.Name = "txtOR"
        Me.txtOR.Size = New System.Drawing.Size(203, 24)
        Me.txtOR.TabIndex = 2
        '
        'cboStation
        '
        Me.cboStation.BackColor = System.Drawing.Color.White
        Me.cboStation.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboStation.Items.AddRange(New Object() {"Tower 1", "Tower 2", "Tower 3", "Tower 4", "Tower 5", "Tower 6", "Tower 7", "Tower 8", "Tower 9", "Tower 10"})
        Me.cboStation.Location = New System.Drawing.Point(194, 68)
        Me.cboStation.Name = "cboStation"
        Me.cboStation.Size = New System.Drawing.Size(202, 24)
        Me.cboStation.TabIndex = 0
        Me.cboStation.Text = "Tower 1"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.Transparent
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.Black
        Me.Label4.Location = New System.Drawing.Point(123, 71)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(64, 16)
        Me.Label4.TabIndex = 34
        Me.Label4.Text = "Station :"
        '
        'cmdSave
        '
        Me.cmdSave.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.cmdSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cmdSave.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdSave.ForeColor = System.Drawing.Color.White
        Me.cmdSave.Image = CType(resources.GetObject("cmdSave.Image"), System.Drawing.Image)
        Me.cmdSave.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.cmdSave.Location = New System.Drawing.Point(294, 394)
        Me.cmdSave.Name = "cmdSave"
        Me.cmdSave.Size = New System.Drawing.Size(103, 34)
        Me.cmdSave.TabIndex = 10
        Me.cmdSave.Text = "       Save"
        Me.cmdSave.UseVisualStyleBackColor = False
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Panel2.Controls.Add(Me.LbClose)
        Me.Panel2.Controls.Add(Me.lbTitle)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel2.Location = New System.Drawing.Point(0, 0)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(413, 32)
        Me.Panel2.TabIndex = 121
        '
        'LbClose
        '
        Me.LbClose.Anchor = System.Windows.Forms.AnchorStyles.Right
        Me.LbClose.AutoSize = True
        Me.LbClose.BackColor = System.Drawing.Color.Transparent
        Me.LbClose.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LbClose.ForeColor = System.Drawing.Color.White
        Me.LbClose.Location = New System.Drawing.Point(392, 5)
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
        Me.lbTitle.Size = New System.Drawing.Size(198, 16)
        Me.lbTitle.TabIndex = 31
        Me.lbTitle.Text = "      System Internal Settings"
        '
        'cboSetEnv
        '
        Me.cboSetEnv.BackColor = System.Drawing.Color.White
        Me.cboSetEnv.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboSetEnv.Items.AddRange(New Object() {"Client", "Server"})
        Me.cboSetEnv.Location = New System.Drawing.Point(194, 184)
        Me.cboSetEnv.Name = "cboSetEnv"
        Me.cboSetEnv.Size = New System.Drawing.Size(202, 24)
        Me.cboSetEnv.TabIndex = 3
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.BackColor = System.Drawing.Color.Transparent
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.Black
        Me.Label5.Location = New System.Drawing.Point(59, 187)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(128, 16)
        Me.Label5.TabIndex = 123
        Me.Label5.Text = "Set Environment :"
        '
        'frmSystemTitle
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Silver
        Me.ClientSize = New System.Drawing.Size(413, 446)
        Me.ControlBox = False
        Me.Controls.Add(Me.cboSetEnv)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.cboMode)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.txtpath)
        Me.Controls.Add(Me.chkSigna)
        Me.Controls.Add(Me.cmdSave)
        Me.Controls.Add(Me.chkIdScanner)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.chkAutoNumber)
        Me.Controls.Add(Me.cboStation)
        Me.Controls.Add(Me.chkWebcam)
        Me.Controls.Add(Me.txtOR)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.cmdFP)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmSystemTitle"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        CType(Me.txtOR, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents cmdSave As System.Windows.Forms.Button
    Friend WithEvents cboStation As System.Windows.Forms.ComboBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents txtOR As System.Windows.Forms.NumericUpDown
    Friend WithEvents txtpath As System.Windows.Forms.TextBox
    Friend WithEvents FBD As System.Windows.Forms.FolderBrowserDialog
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents cmdFP As System.Windows.Forms.Button
    Friend WithEvents chkWebcam As System.Windows.Forms.CheckBox
    Friend WithEvents chkAutoNumber As System.Windows.Forms.CheckBox
    Friend WithEvents chkIdScanner As System.Windows.Forms.CheckBox
    Friend WithEvents chkSigna As System.Windows.Forms.CheckBox
    Friend WithEvents cboMode As System.Windows.Forms.ComboBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents LbClose As System.Windows.Forms.Label
    Friend WithEvents lbTitle As System.Windows.Forms.Label
    Friend WithEvents cboSetEnv As System.Windows.Forms.ComboBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
End Class
