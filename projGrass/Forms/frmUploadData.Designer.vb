<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmUploadData
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmUploadData))
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.LbClose = New System.Windows.Forms.Label()
        Me.lbTitle = New System.Windows.Forms.Label()
        Me.pbClient = New System.Windows.Forms.PictureBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.lblClient = New System.Windows.Forms.Label()
        Me.lblIp = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.lblPort = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.chkUAcc = New System.Windows.Forms.CheckBox()
        Me.chkUnitRec = New System.Windows.Forms.CheckBox()
        Me.chkPurposeList = New System.Windows.Forms.CheckBox()
        Me.lbStat = New System.Windows.Forms.ListBox()
        Me.cmdSave = New System.Windows.Forms.Button()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.pbLoad = New System.Windows.Forms.PictureBox()
        Me.Panel2.SuspendLayout()
        CType(Me.pbClient, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        CType(Me.pbLoad, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Panel2.Controls.Add(Me.LbClose)
        Me.Panel2.Controls.Add(Me.lbTitle)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel2.Location = New System.Drawing.Point(0, 0)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(414, 32)
        Me.Panel2.TabIndex = 122
        '
        'LbClose
        '
        Me.LbClose.Anchor = System.Windows.Forms.AnchorStyles.Right
        Me.LbClose.AutoSize = True
        Me.LbClose.BackColor = System.Drawing.Color.Transparent
        Me.LbClose.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LbClose.ForeColor = System.Drawing.Color.White
        Me.LbClose.Location = New System.Drawing.Point(393, 5)
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
        Me.lbTitle.Size = New System.Drawing.Size(120, 16)
        Me.lbTitle.TabIndex = 31
        Me.lbTitle.Text = "      Upload Data"
        '
        'pbClient
        '
        Me.pbClient.Image = CType(resources.GetObject("pbClient.Image"), System.Drawing.Image)
        Me.pbClient.Location = New System.Drawing.Point(16, 59)
        Me.pbClient.Name = "pbClient"
        Me.pbClient.Size = New System.Drawing.Size(87, 87)
        Me.pbClient.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.pbClient.TabIndex = 123
        Me.pbClient.TabStop = False
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.Transparent
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.Black
        Me.Label4.Location = New System.Drawing.Point(109, 67)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(100, 16)
        Me.Label4.TabIndex = 124
        Me.Label4.Text = "Client Name :"
        '
        'lblClient
        '
        Me.lblClient.AutoSize = True
        Me.lblClient.BackColor = System.Drawing.Color.Transparent
        Me.lblClient.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblClient.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.lblClient.Location = New System.Drawing.Point(207, 68)
        Me.lblClient.Name = "lblClient"
        Me.lblClient.Size = New System.Drawing.Size(49, 16)
        Me.lblClient.TabIndex = 125
        Me.lblClient.Text = "Name"
        '
        'lblIp
        '
        Me.lblIp.AutoSize = True
        Me.lblIp.BackColor = System.Drawing.Color.Transparent
        Me.lblIp.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblIp.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.lblIp.Location = New System.Drawing.Point(207, 94)
        Me.lblIp.Name = "lblIp"
        Me.lblIp.Size = New System.Drawing.Size(116, 16)
        Me.lblIp.TabIndex = 127
        Me.lblIp.Text = "000.000.000.000"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.Black
        Me.Label3.Location = New System.Drawing.Point(118, 93)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(91, 16)
        Me.Label3.TabIndex = 126
        Me.Label3.Text = "Ip Address :"
        '
        'lblPort
        '
        Me.lblPort.AutoSize = True
        Me.lblPort.BackColor = System.Drawing.Color.Transparent
        Me.lblPort.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPort.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.lblPort.Location = New System.Drawing.Point(207, 120)
        Me.lblPort.Name = "lblPort"
        Me.lblPort.Size = New System.Drawing.Size(40, 16)
        Me.lblPort.TabIndex = 129
        Me.lblPort.Text = "0000"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.BackColor = System.Drawing.Color.Transparent
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.Black
        Me.Label6.Location = New System.Drawing.Point(165, 119)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(44, 16)
        Me.Label6.TabIndex = 128
        Me.Label6.Text = "Port :"
        '
        'chkUAcc
        '
        Me.chkUAcc.AutoSize = True
        Me.chkUAcc.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkUAcc.Location = New System.Drawing.Point(19, 34)
        Me.chkUAcc.Name = "chkUAcc"
        Me.chkUAcc.Size = New System.Drawing.Size(114, 20)
        Me.chkUAcc.TabIndex = 130
        Me.chkUAcc.Text = "User Accounts"
        Me.chkUAcc.UseVisualStyleBackColor = True
        '
        'chkUnitRec
        '
        Me.chkUnitRec.AutoSize = True
        Me.chkUnitRec.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkUnitRec.Location = New System.Drawing.Point(146, 34)
        Me.chkUnitRec.Name = "chkUnitRec"
        Me.chkUnitRec.Size = New System.Drawing.Size(105, 20)
        Me.chkUnitRec.TabIndex = 131
        Me.chkUnitRec.Text = "Units Record"
        Me.chkUnitRec.UseVisualStyleBackColor = True
        '
        'chkPurposeList
        '
        Me.chkPurposeList.AutoSize = True
        Me.chkPurposeList.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkPurposeList.Location = New System.Drawing.Point(264, 34)
        Me.chkPurposeList.Name = "chkPurposeList"
        Me.chkPurposeList.Size = New System.Drawing.Size(101, 20)
        Me.chkPurposeList.TabIndex = 132
        Me.chkPurposeList.Text = "Purpose List"
        Me.chkPurposeList.UseVisualStyleBackColor = True
        '
        'lbStat
        '
        Me.lbStat.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lbStat.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbStat.FormattingEnabled = True
        Me.lbStat.ItemHeight = 15
        Me.lbStat.Location = New System.Drawing.Point(15, 70)
        Me.lbStat.Name = "lbStat"
        Me.lbStat.Size = New System.Drawing.Size(351, 107)
        Me.lbStat.TabIndex = 133
        '
        'cmdSave
        '
        Me.cmdSave.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.cmdSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cmdSave.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdSave.ForeColor = System.Drawing.Color.White
        Me.cmdSave.Image = CType(resources.GetObject("cmdSave.Image"), System.Drawing.Image)
        Me.cmdSave.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.cmdSave.Location = New System.Drawing.Point(263, 194)
        Me.cmdSave.Name = "cmdSave"
        Me.cmdSave.Size = New System.Drawing.Size(103, 34)
        Me.cmdSave.TabIndex = 134
        Me.cmdSave.Text = "Upload"
        Me.cmdSave.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.cmdSave.UseVisualStyleBackColor = False
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.chkUAcc)
        Me.GroupBox1.Controls.Add(Me.cmdSave)
        Me.GroupBox1.Controls.Add(Me.chkUnitRec)
        Me.GroupBox1.Controls.Add(Me.lbStat)
        Me.GroupBox1.Controls.Add(Me.chkPurposeList)
        Me.GroupBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.Location = New System.Drawing.Point(16, 164)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(383, 250)
        Me.GroupBox1.TabIndex = 135
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Check the item you want to upload"
        '
        'pbLoad
        '
        Me.pbLoad.Image = CType(resources.GetObject("pbLoad.Image"), System.Drawing.Image)
        Me.pbLoad.Location = New System.Drawing.Point(49, 98)
        Me.pbLoad.Name = "pbLoad"
        Me.pbLoad.Size = New System.Drawing.Size(20, 20)
        Me.pbLoad.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.pbLoad.TabIndex = 136
        Me.pbLoad.TabStop = False
        Me.pbLoad.Visible = False
        '
        'frmUploadData
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Silver
        Me.ClientSize = New System.Drawing.Size(414, 442)
        Me.ControlBox = False
        Me.Controls.Add(Me.pbLoad)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.lblPort)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.lblIp)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.lblClient)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.pbClient)
        Me.Controls.Add(Me.Panel2)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frmUploadData"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        CType(Me.pbClient, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.pbLoad, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents LbClose As System.Windows.Forms.Label
    Friend WithEvents lbTitle As System.Windows.Forms.Label
    Friend WithEvents pbClient As System.Windows.Forms.PictureBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents lblClient As System.Windows.Forms.Label
    Friend WithEvents lblIp As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents lblPort As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents chkUAcc As System.Windows.Forms.CheckBox
    Friend WithEvents chkUnitRec As System.Windows.Forms.CheckBox
    Friend WithEvents chkPurposeList As System.Windows.Forms.CheckBox
    Friend WithEvents lbStat As System.Windows.Forms.ListBox
    Friend WithEvents cmdSave As System.Windows.Forms.Button
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents pbLoad As System.Windows.Forms.PictureBox
End Class
