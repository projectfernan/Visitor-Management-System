<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmManExit
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmManExit))
        Me.PicID = New System.Windows.Forms.PictureBox()
        Me.txtKeyword = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.cmdSearch = New System.Windows.Forms.Button()
        Me.cboSCateg = New System.Windows.Forms.ComboBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.lstList = New System.Windows.Forms.ListView()
        Me.VisPic = New System.Windows.Forms.PictureBox()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.LbClose = New System.Windows.Forms.Label()
        Me.lbTitle = New System.Windows.Forms.Label()
        Me.cmdAccept = New System.Windows.Forms.Button()
        CType(Me.PicID, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.VisPic, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel2.SuspendLayout()
        Me.SuspendLayout()
        '
        'PicID
        '
        Me.PicID.BackColor = System.Drawing.Color.Black
        Me.PicID.Location = New System.Drawing.Point(252, 149)
        Me.PicID.Name = "PicID"
        Me.PicID.Size = New System.Drawing.Size(340, 200)
        Me.PicID.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PicID.TabIndex = 112
        Me.PicID.TabStop = False
        '
        'txtKeyword
        '
        Me.txtKeyword.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtKeyword.Location = New System.Drawing.Point(140, 106)
        Me.txtKeyword.MaxLength = 12
        Me.txtKeyword.Name = "txtKeyword"
        Me.txtKeyword.Size = New System.Drawing.Size(321, 22)
        Me.txtKeyword.TabIndex = 0
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(62, 108)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(75, 16)
        Me.Label3.TabIndex = 109
        Me.Label3.Text = "Keyword :"
        '
        'cmdSearch
        '
        Me.cmdSearch.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.cmdSearch.Cursor = System.Windows.Forms.Cursors.Default
        Me.cmdSearch.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cmdSearch.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdSearch.ForeColor = System.Drawing.Color.White
        Me.cmdSearch.Image = CType(resources.GetObject("cmdSearch.Image"), System.Drawing.Image)
        Me.cmdSearch.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.cmdSearch.Location = New System.Drawing.Point(472, 81)
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
        Me.cboSCateg.Items.AddRange(New Object() {"VisitorIdNo", "VisitorName", "ReferenceIDno", "ContactPerson", "UnitToVisit", "Purpose"})
        Me.cboSCateg.Location = New System.Drawing.Point(140, 69)
        Me.cboSCateg.Name = "cboSCateg"
        Me.cboSCateg.Size = New System.Drawing.Size(321, 24)
        Me.cboSCateg.TabIndex = 99
        Me.cboSCateg.Text = "VisitorIdNo"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(13, 72)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(124, 16)
        Me.Label2.TabIndex = 98
        Me.Label2.Text = "Detail Category :"
        '
        'lstList
        '
        Me.lstList.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lstList.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lstList.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lstList.ForeColor = System.Drawing.Color.Black
        Me.lstList.FullRowSelect = True
        Me.lstList.GridLines = True
        Me.lstList.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable
        Me.lstList.Location = New System.Drawing.Point(16, 365)
        Me.lstList.Name = "lstList"
        Me.lstList.Size = New System.Drawing.Size(576, 246)
        Me.lstList.TabIndex = 7
        Me.lstList.UseCompatibleStateImageBehavior = False
        Me.lstList.View = System.Windows.Forms.View.Details
        '
        'VisPic
        '
        Me.VisPic.BackColor = System.Drawing.Color.Black
        Me.VisPic.Location = New System.Drawing.Point(16, 149)
        Me.VisPic.Name = "VisPic"
        Me.VisPic.Size = New System.Drawing.Size(216, 200)
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
        Me.Panel2.Size = New System.Drawing.Size(609, 32)
        Me.Panel2.TabIndex = 120
        '
        'LbClose
        '
        Me.LbClose.Anchor = System.Windows.Forms.AnchorStyles.Right
        Me.LbClose.AutoSize = True
        Me.LbClose.BackColor = System.Drawing.Color.Transparent
        Me.LbClose.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LbClose.ForeColor = System.Drawing.Color.White
        Me.LbClose.Location = New System.Drawing.Point(588, 5)
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
        Me.lbTitle.Size = New System.Drawing.Size(128, 16)
        Me.lbTitle.TabIndex = 31
        Me.lbTitle.Text = "      Lost Visitor ID"
        '
        'cmdAccept
        '
        Me.cmdAccept.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.cmdAccept.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.cmdAccept.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdAccept.ForeColor = System.Drawing.Color.White
        Me.cmdAccept.Image = CType(resources.GetObject("cmdAccept.Image"), System.Drawing.Image)
        Me.cmdAccept.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.cmdAccept.Location = New System.Drawing.Point(361, 625)
        Me.cmdAccept.Name = "cmdAccept"
        Me.cmdAccept.Size = New System.Drawing.Size(231, 44)
        Me.cmdAccept.TabIndex = 121
        Me.cmdAccept.Text = " Verify"
        Me.cmdAccept.UseVisualStyleBackColor = False
        '
        'frmManExit
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Silver
        Me.ClientSize = New System.Drawing.Size(609, 688)
        Me.ControlBox = False
        Me.Controls.Add(Me.cmdAccept)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.PicID)
        Me.Controls.Add(Me.VisPic)
        Me.Controls.Add(Me.txtKeyword)
        Me.Controls.Add(Me.lstList)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.cmdSearch)
        Me.Controls.Add(Me.cboSCateg)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.KeyPreview = True
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmManExit"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        CType(Me.PicID, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.VisPic, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents PicID As System.Windows.Forms.PictureBox
    Friend WithEvents txtKeyword As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents cmdSearch As System.Windows.Forms.Button
    Friend WithEvents cboSCateg As System.Windows.Forms.ComboBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents lstList As System.Windows.Forms.ListView
    Friend WithEvents VisPic As System.Windows.Forms.PictureBox
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents LbClose As System.Windows.Forms.Label
    Friend WithEvents lbTitle As System.Windows.Forms.Label
    Friend WithEvents cmdAccept As System.Windows.Forms.Button
End Class
