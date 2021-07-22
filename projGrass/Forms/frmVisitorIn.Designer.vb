<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmVisitorIn
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmVisitorIn))
        Me.PicSigna = New System.Windows.Forms.PictureBox()
        Me.PicID = New System.Windows.Forms.PictureBox()
        Me.txtKeyword = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.cmdPrint = New System.Windows.Forms.Button()
        Me.cmdSearch = New System.Windows.Forms.Button()
        Me.cboSCateg = New System.Windows.Forms.ComboBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.dtDateTo = New System.Windows.Forms.DateTimePicker()
        Me.dtDateFrm = New System.Windows.Forms.DateTimePicker()
        Me.cboREpCateg = New System.Windows.Forms.ComboBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.VisPic = New System.Windows.Forms.PictureBox()
        Me.OpenPath = New System.Windows.Forms.OpenFileDialog()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.LbClose = New System.Windows.Forms.Label()
        Me.lbTitle = New System.Windows.Forms.Label()
        Me.dgRec = New System.Windows.Forms.DataGridView()
        CType(Me.PicSigna, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PicID, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.VisPic, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel2.SuspendLayout()
        CType(Me.dgRec, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'PicSigna
        '
        Me.PicSigna.BackColor = System.Drawing.Color.Black
        Me.PicSigna.Location = New System.Drawing.Point(1005, 63)
        Me.PicSigna.Name = "PicSigna"
        Me.PicSigna.Size = New System.Drawing.Size(303, 233)
        Me.PicSigna.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PicSigna.TabIndex = 115
        Me.PicSigna.TabStop = False
        '
        'PicID
        '
        Me.PicID.BackColor = System.Drawing.Color.Gray
        Me.PicID.Image = CType(resources.GetObject("PicID.Image"), System.Drawing.Image)
        Me.PicID.Location = New System.Drawing.Point(621, 63)
        Me.PicID.Name = "PicID"
        Me.PicID.Size = New System.Drawing.Size(366, 233)
        Me.PicID.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PicID.TabIndex = 112
        Me.PicID.TabStop = False
        '
        'txtKeyword
        '
        Me.txtKeyword.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtKeyword.Location = New System.Drawing.Point(143, 217)
        Me.txtKeyword.MaxLength = 12
        Me.txtKeyword.Name = "txtKeyword"
        Me.txtKeyword.Size = New System.Drawing.Size(179, 22)
        Me.txtKeyword.TabIndex = 110
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(65, 219)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(75, 16)
        Me.Label3.TabIndex = 109
        Me.Label3.Text = "Keyword :"
        '
        'cmdPrint
        '
        Me.cmdPrint.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.cmdPrint.Cursor = System.Windows.Forms.Cursors.Default
        Me.cmdPrint.Enabled = False
        Me.cmdPrint.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.cmdPrint.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdPrint.ForeColor = System.Drawing.Color.White
        Me.cmdPrint.Image = CType(resources.GetObject("cmdPrint.Image"), System.Drawing.Image)
        Me.cmdPrint.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.cmdPrint.Location = New System.Drawing.Point(211, 254)
        Me.cmdPrint.Name = "cmdPrint"
        Me.cmdPrint.Size = New System.Drawing.Size(111, 34)
        Me.cmdPrint.TabIndex = 107
        Me.cmdPrint.Text = "&Print    "
        Me.cmdPrint.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.cmdPrint.UseVisualStyleBackColor = False
        '
        'cmdSearch
        '
        Me.cmdSearch.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.cmdSearch.Cursor = System.Windows.Forms.Cursors.Default
        Me.cmdSearch.Enabled = False
        Me.cmdSearch.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.cmdSearch.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdSearch.ForeColor = System.Drawing.Color.White
        Me.cmdSearch.Image = CType(resources.GetObject("cmdSearch.Image"), System.Drawing.Image)
        Me.cmdSearch.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.cmdSearch.Location = New System.Drawing.Point(94, 254)
        Me.cmdSearch.Name = "cmdSearch"
        Me.cmdSearch.Size = New System.Drawing.Size(111, 34)
        Me.cmdSearch.TabIndex = 106
        Me.cmdSearch.Text = "&Search   "
        Me.cmdSearch.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.cmdSearch.UseVisualStyleBackColor = False
        '
        'cboSCateg
        '
        Me.cboSCateg.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboSCateg.FormattingEnabled = True
        Me.cboSCateg.Items.AddRange(New Object() {"VisitorIdNo", "VisitorName", "ReferenceIdNo", "Floor", "UnitToVisit", "ContactPerson", "Purpose", "Tower"})
        Me.cboSCateg.Location = New System.Drawing.Point(143, 177)
        Me.cboSCateg.Name = "cboSCateg"
        Me.cboSCateg.Size = New System.Drawing.Size(179, 24)
        Me.cboSCateg.TabIndex = 99
        Me.cboSCateg.Text = "VisitorIdNo"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(16, 180)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(124, 16)
        Me.Label2.TabIndex = 98
        Me.Label2.Text = "Detail Category :"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Black
        Me.Label1.Location = New System.Drawing.Point(105, 145)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(35, 16)
        Me.Label1.TabIndex = 97
        Me.Label1.Text = "To :"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.Black
        Me.Label6.Location = New System.Drawing.Point(89, 106)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(51, 16)
        Me.Label6.TabIndex = 96
        Me.Label6.Text = "From :"
        '
        'dtDateTo
        '
        Me.dtDateTo.CustomFormat = "yyyy-MM-dd HH:mm"
        Me.dtDateTo.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtDateTo.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtDateTo.Location = New System.Drawing.Point(143, 140)
        Me.dtDateTo.Name = "dtDateTo"
        Me.dtDateTo.Size = New System.Drawing.Size(179, 24)
        Me.dtDateTo.TabIndex = 95
        '
        'dtDateFrm
        '
        Me.dtDateFrm.CustomFormat = "yyyy-MM-dd HH:mm"
        Me.dtDateFrm.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtDateFrm.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtDateFrm.Location = New System.Drawing.Point(143, 101)
        Me.dtDateFrm.Name = "dtDateFrm"
        Me.dtDateFrm.Size = New System.Drawing.Size(179, 24)
        Me.dtDateFrm.TabIndex = 94
        '
        'cboREpCateg
        '
        Me.cboREpCateg.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboREpCateg.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboREpCateg.FormattingEnabled = True
        Me.cboREpCateg.Items.AddRange(New Object() {"By Date Only", "By Visitor Details", "All"})
        Me.cboREpCateg.Location = New System.Drawing.Point(143, 64)
        Me.cboREpCateg.Name = "cboREpCateg"
        Me.cboREpCateg.Size = New System.Drawing.Size(179, 24)
        Me.cboREpCateg.TabIndex = 93
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(8, 67)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(132, 16)
        Me.Label8.TabIndex = 92
        Me.Label8.Text = "Search Category :"
        '
        'VisPic
        '
        Me.VisPic.BackColor = System.Drawing.Color.Gray
        Me.VisPic.Image = CType(resources.GetObject("VisPic.Image"), System.Drawing.Image)
        Me.VisPic.Location = New System.Drawing.Point(341, 63)
        Me.VisPic.Name = "VisPic"
        Me.VisPic.Size = New System.Drawing.Size(257, 233)
        Me.VisPic.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.VisPic.TabIndex = 0
        Me.VisPic.TabStop = False
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Panel2.Controls.Add(Me.LbClose)
        Me.Panel2.Controls.Add(Me.lbTitle)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel2.Location = New System.Drawing.Point(0, 0)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(1325, 32)
        Me.Panel2.TabIndex = 121
        '
        'LbClose
        '
        Me.LbClose.Anchor = System.Windows.Forms.AnchorStyles.Right
        Me.LbClose.AutoSize = True
        Me.LbClose.BackColor = System.Drawing.Color.Transparent
        Me.LbClose.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LbClose.ForeColor = System.Drawing.Color.White
        Me.LbClose.Location = New System.Drawing.Point(1304, 5)
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
        Me.lbTitle.Size = New System.Drawing.Size(136, 16)
        Me.lbTitle.TabIndex = 31
        Me.lbTitle.Text = "      Time In History"
        '
        'dgRec
        '
        Me.dgRec.AllowUserToAddRows = False
        Me.dgRec.AllowUserToDeleteRows = False
        Me.dgRec.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.dgRec.BackgroundColor = System.Drawing.Color.White
        Me.dgRec.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgRec.Location = New System.Drawing.Point(19, 312)
        Me.dgRec.Name = "dgRec"
        Me.dgRec.ReadOnly = True
        Me.dgRec.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.[Single]
        Me.dgRec.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgRec.ShowEditingIcon = False
        Me.dgRec.Size = New System.Drawing.Size(1289, 318)
        Me.dgRec.TabIndex = 123
        '
        'frmVisitorIn
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Silver
        Me.ClientSize = New System.Drawing.Size(1325, 657)
        Me.ControlBox = False
        Me.Controls.Add(Me.dgRec)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.PicSigna)
        Me.Controls.Add(Me.VisPic)
        Me.Controls.Add(Me.PicID)
        Me.Controls.Add(Me.txtKeyword)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.cboREpCateg)
        Me.Controls.Add(Me.dtDateFrm)
        Me.Controls.Add(Me.cmdPrint)
        Me.Controls.Add(Me.dtDateTo)
        Me.Controls.Add(Me.cmdSearch)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.cboSCateg)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Label2)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.KeyPreview = True
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmVisitorIn"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        CType(Me.PicSigna, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PicID, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.VisPic, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        CType(Me.dgRec, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents PicID As System.Windows.Forms.PictureBox
    Friend WithEvents txtKeyword As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents cmdPrint As System.Windows.Forms.Button
    Friend WithEvents cmdSearch As System.Windows.Forms.Button
    Friend WithEvents cboSCateg As System.Windows.Forms.ComboBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents dtDateTo As System.Windows.Forms.DateTimePicker
    Friend WithEvents dtDateFrm As System.Windows.Forms.DateTimePicker
    Friend WithEvents cboREpCateg As System.Windows.Forms.ComboBox
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents VisPic As System.Windows.Forms.PictureBox
    Friend WithEvents OpenPath As System.Windows.Forms.OpenFileDialog
    Friend WithEvents PicSigna As System.Windows.Forms.PictureBox
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents LbClose As System.Windows.Forms.Label
    Friend WithEvents lbTitle As System.Windows.Forms.Label
    Friend WithEvents dgRec As System.Windows.Forms.DataGridView
End Class
