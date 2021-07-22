<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ucClientVms
    Inherits System.Windows.Forms.UserControl

    'UserControl overrides dispose to clean up the component list.
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
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(ucClientVms))
        Me.pbClient = New System.Windows.Forms.PictureBox()
        Me.cmsCtrl = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.btnEdit = New System.Windows.Forms.ToolStripMenuItem()
        Me.btnDelete = New System.Windows.Forms.ToolStripMenuItem()
        Me.btnUpload = New System.Windows.Forms.ToolStripMenuItem()
        Me.lblClient = New System.Windows.Forms.Label()
        Me.lblStat = New System.Windows.Forms.Label()
        Me.tmePing = New System.Windows.Forms.Timer(Me.components)
        Me.bgwPing = New System.ComponentModel.BackgroundWorker()
        CType(Me.pbClient, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.cmsCtrl.SuspendLayout()
        Me.SuspendLayout()
        '
        'pbClient
        '
        Me.pbClient.Image = CType(resources.GetObject("pbClient.Image"), System.Drawing.Image)
        Me.pbClient.Location = New System.Drawing.Point(14, 0)
        Me.pbClient.Name = "pbClient"
        Me.pbClient.Size = New System.Drawing.Size(87, 87)
        Me.pbClient.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.pbClient.TabIndex = 0
        Me.pbClient.TabStop = False
        '
        'cmsCtrl
        '
        Me.cmsCtrl.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.btnEdit, Me.btnDelete, Me.btnUpload})
        Me.cmsCtrl.Name = "cmsCtrl"
        Me.cmsCtrl.Size = New System.Drawing.Size(140, 70)
        '
        'btnEdit
        '
        Me.btnEdit.Name = "btnEdit"
        Me.btnEdit.Size = New System.Drawing.Size(139, 22)
        Me.btnEdit.Text = "Edit"
        '
        'btnDelete
        '
        Me.btnDelete.Name = "btnDelete"
        Me.btnDelete.Size = New System.Drawing.Size(139, 22)
        Me.btnDelete.Text = "Delete"
        '
        'btnUpload
        '
        Me.btnUpload.Name = "btnUpload"
        Me.btnUpload.Size = New System.Drawing.Size(139, 22)
        Me.btnUpload.Text = "Upload Data"
        '
        'lblClient
        '
        Me.lblClient.Location = New System.Drawing.Point(0, 90)
        Me.lblClient.Name = "lblClient"
        Me.lblClient.Size = New System.Drawing.Size(117, 15)
        Me.lblClient.TabIndex = 7
        Me.lblClient.Text = "CLIENT"
        Me.lblClient.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblStat
        '
        Me.lblStat.ForeColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.lblStat.Location = New System.Drawing.Point(0, 106)
        Me.lblStat.Name = "lblStat"
        Me.lblStat.Size = New System.Drawing.Size(117, 15)
        Me.lblStat.TabIndex = 8
        Me.lblStat.Text = "DISCONNECTED"
        Me.lblStat.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'tmePing
        '
        '
        'bgwPing
        '
        '
        'ucClientVms
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Transparent
        Me.ContextMenuStrip = Me.cmsCtrl
        Me.Controls.Add(Me.lblStat)
        Me.Controls.Add(Me.lblClient)
        Me.Controls.Add(Me.pbClient)
        Me.Name = "ucClientVms"
        Me.Size = New System.Drawing.Size(117, 122)
        CType(Me.pbClient, System.ComponentModel.ISupportInitialize).EndInit()
        Me.cmsCtrl.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents pbClient As System.Windows.Forms.PictureBox
    Private WithEvents cmsCtrl As System.Windows.Forms.ContextMenuStrip
    Private WithEvents btnEdit As System.Windows.Forms.ToolStripMenuItem
    Private WithEvents btnDelete As System.Windows.Forms.ToolStripMenuItem
    Private WithEvents btnUpload As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents lblClient As System.Windows.Forms.Label
    Friend WithEvents lblStat As System.Windows.Forms.Label
    Friend WithEvents tmePing As System.Windows.Forms.Timer
    Friend WithEvents bgwPing As System.ComponentModel.BackgroundWorker

End Class
