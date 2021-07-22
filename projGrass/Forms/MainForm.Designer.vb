<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class MainForm
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
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(MainForm))
        Me.SplitContainer1 = New System.Windows.Forms.SplitContainer()
        Me.SplitContainer3 = New System.Windows.Forms.SplitContainer()
        Me.GP1 = New System.Windows.Forms.GroupBox()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.cboPurpose = New System.Windows.Forms.ComboBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.txtNotice = New System.Windows.Forms.Label()
        Me.txtVisitorID = New System.Windows.Forms.TextBox()
        Me.txtContactPerson = New System.Windows.Forms.TextBox()
        Me.txtRefIDno = New System.Windows.Forms.TextBox()
        Me.txtContact = New System.Windows.Forms.TextBox()
        Me.cboCompany = New System.Windows.Forms.ComboBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtVisitor = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.cmdSigna = New System.Windows.Forms.Button()
        Me.ToolStrip1 = New System.Windows.Forms.ToolStrip()
        Me.ToolStripLabel2 = New System.Windows.Forms.ToolStripLabel()
        Me.txtCompany = New System.Windows.Forms.ToolStripLabel()
        Me.ssd = New System.Windows.Forms.ToolStripLabel()
        Me.txtTime = New System.Windows.Forms.ToolStripLabel()
        Me.ToolStripLabel1 = New System.Windows.Forms.ToolStripLabel()
        Me.txtDate = New System.Windows.Forms.ToolStripLabel()
        Me.SplitContainer5 = New System.Windows.Forms.SplitContainer()
        Me.btnQvVisEnt = New System.Windows.Forms.Button()
        Me.cmdNewVis = New System.Windows.Forms.Button()
        Me.cmdExitTrans = New System.Windows.Forms.Button()
        Me.cmdManExit = New System.Windows.Forms.Button()
        Me.cmdCancelTrans = New System.Windows.Forms.Button()
        Me.cmdSettle = New System.Windows.Forms.Button()
        Me.SplitContainer4 = New System.Windows.Forms.SplitContainer()
        Me.ScanID = New System.Windows.Forms.PictureBox()
        Me.btnIDShot = New System.Windows.Forms.Button()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.cmdShot = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.WebCam = New System.Windows.Forms.PictureBox()
        Me.StatusStrip1 = New System.Windows.Forms.StatusStrip()
        Me.ToolStripStatusLabel1 = New System.Windows.Forms.ToolStripStatusLabel()
        Me.txtDesig = New System.Windows.Forms.ToolStripStatusLabel()
        Me.txtUser = New System.Windows.Forms.ToolStripStatusLabel()
        Me.ToolStripStatusLabel4 = New System.Windows.Forms.ToolStripStatusLabel()
        Me.ToolStripStatusLabel5 = New System.Windows.Forms.ToolStripStatusLabel()
        Me.txtDBstat = New System.Windows.Forms.ToolStripStatusLabel()
        Me.ToolStripStatusLabel6 = New System.Windows.Forms.ToolStripStatusLabel()
        Me.ToolStripStatusLabel3 = New System.Windows.Forms.ToolStripStatusLabel()
        Me.txtDbLoc = New System.Windows.Forms.ToolStripStatusLabel()
        Me.ToolStripStatusLabel2 = New System.Windows.Forms.ToolStripStatusLabel()
        Me.txtStation = New System.Windows.Forms.ToolStripStatusLabel()
        Me.tmeTime = New System.Windows.Forms.Timer(Me.components)
        Me.tmeReadText = New System.Windows.Forms.Timer(Me.components)
        Me.tmeDelImg = New System.Windows.Forms.Timer(Me.components)
        Me.tmeWebCam = New System.Windows.Forms.Timer(Me.components)
        CType(Me.SplitContainer1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SplitContainer1.Panel1.SuspendLayout()
        Me.SplitContainer1.Panel2.SuspendLayout()
        Me.SplitContainer1.SuspendLayout()
        CType(Me.SplitContainer3, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SplitContainer3.Panel1.SuspendLayout()
        Me.SplitContainer3.Panel2.SuspendLayout()
        Me.SplitContainer3.SuspendLayout()
        Me.GP1.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.ToolStrip1.SuspendLayout()
        CType(Me.SplitContainer5, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SplitContainer5.Panel1.SuspendLayout()
        Me.SplitContainer5.Panel2.SuspendLayout()
        Me.SplitContainer5.SuspendLayout()
        CType(Me.SplitContainer4, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SplitContainer4.Panel1.SuspendLayout()
        Me.SplitContainer4.Panel2.SuspendLayout()
        Me.SplitContainer4.SuspendLayout()
        CType(Me.ScanID, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.WebCam, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.StatusStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'SplitContainer1
        '
        Me.SplitContainer1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.SplitContainer1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.SplitContainer1.Location = New System.Drawing.Point(0, 0)
        Me.SplitContainer1.Name = "SplitContainer1"
        Me.SplitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal
        '
        'SplitContainer1.Panel1
        '
        Me.SplitContainer1.Panel1.Controls.Add(Me.SplitContainer3)
        Me.SplitContainer1.Panel1.Controls.Add(Me.ToolStrip1)
        '
        'SplitContainer1.Panel2
        '
        Me.SplitContainer1.Panel2.BackColor = System.Drawing.Color.White
        Me.SplitContainer1.Panel2.Controls.Add(Me.SplitContainer5)
        Me.SplitContainer1.Panel2.Controls.Add(Me.StatusStrip1)
        Me.SplitContainer1.Size = New System.Drawing.Size(1102, 763)
        Me.SplitContainer1.SplitterDistance = 406
        Me.SplitContainer1.TabIndex = 99999654
        Me.SplitContainer1.TabStop = False
        '
        'SplitContainer3
        '
        Me.SplitContainer3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.SplitContainer3.Dock = System.Windows.Forms.DockStyle.Fill
        Me.SplitContainer3.Location = New System.Drawing.Point(0, 51)
        Me.SplitContainer3.Name = "SplitContainer3"
        '
        'SplitContainer3.Panel1
        '
        Me.SplitContainer3.Panel1.BackColor = System.Drawing.Color.Silver
        Me.SplitContainer3.Panel1.Controls.Add(Me.GP1)
        '
        'SplitContainer3.Panel2
        '
        Me.SplitContainer3.Panel2.BackColor = System.Drawing.Color.Silver
        Me.SplitContainer3.Panel2.Controls.Add(Me.Label15)
        Me.SplitContainer3.Panel2.Controls.Add(Me.PictureBox1)
        Me.SplitContainer3.Panel2.Controls.Add(Me.cmdSigna)
        Me.SplitContainer3.Size = New System.Drawing.Size(1102, 355)
        Me.SplitContainer3.SplitterDistance = 651
        Me.SplitContainer3.TabIndex = 898978798
        Me.SplitContainer3.TabStop = False
        '
        'GP1
        '
        Me.GP1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GP1.BackColor = System.Drawing.Color.Transparent
        Me.GP1.Controls.Add(Me.Label14)
        Me.GP1.Controls.Add(Me.Label13)
        Me.GP1.Controls.Add(Me.Label11)
        Me.GP1.Controls.Add(Me.cboPurpose)
        Me.GP1.Controls.Add(Me.Label7)
        Me.GP1.Controls.Add(Me.txtNotice)
        Me.GP1.Controls.Add(Me.txtVisitorID)
        Me.GP1.Controls.Add(Me.txtContactPerson)
        Me.GP1.Controls.Add(Me.txtRefIDno)
        Me.GP1.Controls.Add(Me.txtContact)
        Me.GP1.Controls.Add(Me.cboCompany)
        Me.GP1.Controls.Add(Me.Label3)
        Me.GP1.Controls.Add(Me.Label2)
        Me.GP1.Controls.Add(Me.txtVisitor)
        Me.GP1.Controls.Add(Me.Label6)
        Me.GP1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GP1.Location = New System.Drawing.Point(7, 5)
        Me.GP1.Name = "GP1"
        Me.GP1.Size = New System.Drawing.Size(636, 342)
        Me.GP1.TabIndex = 4000
        Me.GP1.TabStop = False
        Me.GP1.Text = "Visitor's Information"
        '
        'Label14
        '
        Me.Label14.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.Label14.AutoSize = True
        Me.Label14.BackColor = System.Drawing.Color.Transparent
        Me.Label14.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label14.ForeColor = System.Drawing.Color.Black
        Me.Label14.Location = New System.Drawing.Point(33, 211)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(121, 16)
        Me.Label14.TabIndex = 56
        Me.Label14.Text = "Contact Person :"
        '
        'Label13
        '
        Me.Label13.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.Label13.AutoSize = True
        Me.Label13.BackColor = System.Drawing.Color.Transparent
        Me.Label13.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.ForeColor = System.Drawing.Color.Black
        Me.Label13.Location = New System.Drawing.Point(28, 176)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(126, 16)
        Me.Label13.TabIndex = 55
        Me.Label13.Text = "Contact Number :"
        '
        'Label11
        '
        Me.Label11.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.Label11.AutoSize = True
        Me.Label11.BackColor = System.Drawing.Color.Transparent
        Me.Label11.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.ForeColor = System.Drawing.Color.Black
        Me.Label11.Location = New System.Drawing.Point(36, 144)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(119, 16)
        Me.Label11.TabIndex = 54
        Me.Label11.Text = "Visitor's Ref ID :"
        '
        'cboPurpose
        '
        Me.cboPurpose.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.cboPurpose.BackColor = System.Drawing.Color.White
        Me.cboPurpose.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cboPurpose.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboPurpose.FormattingEnabled = True
        Me.cboPurpose.Location = New System.Drawing.Point(160, 281)
        Me.cboPurpose.Name = "cboPurpose"
        Me.cboPurpose.Size = New System.Drawing.Size(437, 32)
        Me.cboPurpose.TabIndex = 6
        '
        'Label7
        '
        Me.Label7.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.Label7.AutoSize = True
        Me.Label7.BackColor = System.Drawing.Color.Transparent
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.Color.Black
        Me.Label7.Location = New System.Drawing.Point(31, 288)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(123, 16)
        Me.Label7.TabIndex = 53
        Me.Label7.Text = "Purpose of visit :"
        '
        'txtNotice
        '
        Me.txtNotice.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.txtNotice.AutoSize = True
        Me.txtNotice.BackColor = System.Drawing.Color.Transparent
        Me.txtNotice.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtNotice.ForeColor = System.Drawing.Color.OrangeRed
        Me.txtNotice.Location = New System.Drawing.Point(97, 30)
        Me.txtNotice.Name = "txtNotice"
        Me.txtNotice.Size = New System.Drawing.Size(299, 16)
        Me.txtNotice.TabIndex = 51
        Me.txtNotice.Text = "* Please place the Visitor ID to ID Scanner"
        Me.txtNotice.Visible = False
        '
        'txtVisitorID
        '
        Me.txtVisitorID.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.txtVisitorID.BackColor = System.Drawing.Color.White
        Me.txtVisitorID.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtVisitorID.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtVisitorID.ForeColor = System.Drawing.Color.MediumBlue
        Me.txtVisitorID.Location = New System.Drawing.Point(160, 66)
        Me.txtVisitorID.MaxLength = 50
        Me.txtVisitorID.Name = "txtVisitorID"
        Me.txtVisitorID.Size = New System.Drawing.Size(438, 29)
        Me.txtVisitorID.TabIndex = 0
        Me.txtVisitorID.TabStop = False
        '
        'txtContactPerson
        '
        Me.txtContactPerson.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.txtContactPerson.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtContactPerson.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtContactPerson.Location = New System.Drawing.Point(160, 206)
        Me.txtContactPerson.MaxLength = 16
        Me.txtContactPerson.Name = "txtContactPerson"
        Me.txtContactPerson.Size = New System.Drawing.Size(438, 29)
        Me.txtContactPerson.TabIndex = 4
        '
        'txtRefIDno
        '
        Me.txtRefIDno.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.txtRefIDno.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtRefIDno.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtRefIDno.Location = New System.Drawing.Point(160, 136)
        Me.txtRefIDno.MaxLength = 16
        Me.txtRefIDno.Name = "txtRefIDno"
        Me.txtRefIDno.Size = New System.Drawing.Size(438, 29)
        Me.txtRefIDno.TabIndex = 2
        '
        'txtContact
        '
        Me.txtContact.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.txtContact.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtContact.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtContact.Location = New System.Drawing.Point(160, 171)
        Me.txtContact.MaxLength = 50
        Me.txtContact.Name = "txtContact"
        Me.txtContact.Size = New System.Drawing.Size(438, 29)
        Me.txtContact.TabIndex = 3
        '
        'cboCompany
        '
        Me.cboCompany.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.cboCompany.BackColor = System.Drawing.Color.White
        Me.cboCompany.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cboCompany.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboCompany.FormattingEnabled = True
        Me.cboCompany.Location = New System.Drawing.Point(160, 242)
        Me.cboCompany.Name = "cboCompany"
        Me.cboCompany.Size = New System.Drawing.Size(438, 32)
        Me.cboCompany.TabIndex = 5
        '
        'Label3
        '
        Me.Label3.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.Black
        Me.Label3.Location = New System.Drawing.Point(40, 72)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(115, 16)
        Me.Label3.TabIndex = 30
        Me.Label3.Text = "Visitor's ID No.:"
        '
        'Label2
        '
        Me.Label2.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.Black
        Me.Label2.Location = New System.Drawing.Point(33, 250)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(120, 16)
        Me.Label2.TabIndex = 29
        Me.Label2.Text = "Unit No. to visit :"
        '
        'txtVisitor
        '
        Me.txtVisitor.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.txtVisitor.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtVisitor.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtVisitor.Location = New System.Drawing.Point(160, 101)
        Me.txtVisitor.MaxLength = 50
        Me.txtVisitor.Name = "txtVisitor"
        Me.txtVisitor.Size = New System.Drawing.Size(438, 29)
        Me.txtVisitor.TabIndex = 1
        '
        'Label6
        '
        Me.Label6.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.Label6.AutoSize = True
        Me.Label6.BackColor = System.Drawing.Color.Transparent
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.Black
        Me.Label6.Location = New System.Drawing.Point(38, 109)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(117, 16)
        Me.Label6.TabIndex = 28
        Me.Label6.Text = "Visitor's Name :"
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.BackColor = System.Drawing.Color.Transparent
        Me.Label15.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label15.ForeColor = System.Drawing.Color.Black
        Me.Label15.Location = New System.Drawing.Point(4, 6)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(142, 16)
        Me.Label15.TabIndex = 36
        Me.Label15.Text = "Visitor's Signature :"
        '
        'PictureBox1
        '
        Me.PictureBox1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.PictureBox1.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.PictureBox1.Location = New System.Drawing.Point(9, 27)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(426, 279)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 35
        Me.PictureBox1.TabStop = False
        '
        'cmdSigna
        '
        Me.cmdSigna.Anchor = System.Windows.Forms.AnchorStyles.Bottom
        Me.cmdSigna.BackColor = System.Drawing.Color.White
        Me.cmdSigna.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.cmdSigna.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdSigna.ForeColor = System.Drawing.Color.Black
        Me.cmdSigna.Image = CType(resources.GetObject("cmdSigna.Image"), System.Drawing.Image)
        Me.cmdSigna.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.cmdSigna.Location = New System.Drawing.Point(164, 314)
        Me.cmdSigna.Name = "cmdSigna"
        Me.cmdSigna.Size = New System.Drawing.Size(113, 31)
        Me.cmdSigna.TabIndex = 32
        Me.cmdSigna.TabStop = False
        Me.cmdSigna.Text = "(F7) Sign"
        Me.cmdSigna.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.cmdSigna.UseVisualStyleBackColor = False
        '
        'ToolStrip1
        '
        Me.ToolStrip1.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.ToolStrip1.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden
        Me.ToolStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripLabel2, Me.txtCompany, Me.ssd, Me.txtTime, Me.ToolStripLabel1, Me.txtDate})
        Me.ToolStrip1.Location = New System.Drawing.Point(0, 0)
        Me.ToolStrip1.Name = "ToolStrip1"
        Me.ToolStrip1.Size = New System.Drawing.Size(1102, 51)
        Me.ToolStrip1.TabIndex = 0
        Me.ToolStrip1.Text = "ToolStrip1"
        '
        'ToolStripLabel2
        '
        Me.ToolStripLabel2.Name = "ToolStripLabel2"
        Me.ToolStripLabel2.Size = New System.Drawing.Size(10, 48)
        Me.ToolStripLabel2.Text = " "
        '
        'txtCompany
        '
        Me.txtCompany.Font = New System.Drawing.Font("Segoe UI", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCompany.ForeColor = System.Drawing.Color.White
        Me.txtCompany.Image = CType(resources.GetObject("txtCompany.Image"), System.Drawing.Image)
        Me.txtCompany.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.txtCompany.Name = "txtCompany"
        Me.txtCompany.Size = New System.Drawing.Size(480, 48)
        Me.txtCompany.Text = "VISITOR MANAGEMENT SYSTEM"
        '
        'ssd
        '
        Me.ssd.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right
        Me.ssd.Font = New System.Drawing.Font("Tahoma", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ssd.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.ssd.Name = "ssd"
        Me.ssd.Size = New System.Drawing.Size(18, 48)
        Me.ssd.Text = " "
        '
        'txtTime
        '
        Me.txtTime.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right
        Me.txtTime.Font = New System.Drawing.Font("Segoe UI", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtTime.ForeColor = System.Drawing.Color.White
        Me.txtTime.Image = CType(resources.GetObject("txtTime.Image"), System.Drawing.Image)
        Me.txtTime.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.txtTime.Name = "txtTime"
        Me.txtTime.Size = New System.Drawing.Size(103, 48)
        Me.txtTime.Text = "Time"
        '
        'ToolStripLabel1
        '
        Me.ToolStripLabel1.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right
        Me.ToolStripLabel1.Font = New System.Drawing.Font("Segoe UI", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ToolStripLabel1.ForeColor = System.Drawing.Color.White
        Me.ToolStripLabel1.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.ToolStripLabel1.Name = "ToolStripLabel1"
        Me.ToolStripLabel1.Size = New System.Drawing.Size(17, 48)
        Me.ToolStripLabel1.Text = " "
        '
        'txtDate
        '
        Me.txtDate.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right
        Me.txtDate.Font = New System.Drawing.Font("Segoe UI", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtDate.ForeColor = System.Drawing.Color.White
        Me.txtDate.Image = CType(resources.GetObject("txtDate.Image"), System.Drawing.Image)
        Me.txtDate.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.txtDate.Name = "txtDate"
        Me.txtDate.Size = New System.Drawing.Size(101, 48)
        Me.txtDate.Text = "Date"
        '
        'SplitContainer5
        '
        Me.SplitContainer5.BackColor = System.Drawing.Color.White
        Me.SplitContainer5.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.SplitContainer5.Dock = System.Windows.Forms.DockStyle.Fill
        Me.SplitContainer5.Location = New System.Drawing.Point(0, 0)
        Me.SplitContainer5.Name = "SplitContainer5"
        '
        'SplitContainer5.Panel1
        '
        Me.SplitContainer5.Panel1.BackColor = System.Drawing.Color.Silver
        Me.SplitContainer5.Panel1.Controls.Add(Me.btnQvVisEnt)
        Me.SplitContainer5.Panel1.Controls.Add(Me.cmdNewVis)
        Me.SplitContainer5.Panel1.Controls.Add(Me.cmdExitTrans)
        Me.SplitContainer5.Panel1.Controls.Add(Me.cmdManExit)
        Me.SplitContainer5.Panel1.Controls.Add(Me.cmdCancelTrans)
        Me.SplitContainer5.Panel1.Controls.Add(Me.cmdSettle)
        '
        'SplitContainer5.Panel2
        '
        Me.SplitContainer5.Panel2.Controls.Add(Me.SplitContainer4)
        Me.SplitContainer5.Size = New System.Drawing.Size(1102, 316)
        Me.SplitContainer5.SplitterDistance = 391
        Me.SplitContainer5.TabIndex = 45345
        Me.SplitContainer5.TabStop = False
        '
        'btnQvVisEnt
        '
        Me.btnQvVisEnt.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnQvVisEnt.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.btnQvVisEnt.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnQvVisEnt.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnQvVisEnt.ForeColor = System.Drawing.Color.White
        Me.btnQvVisEnt.Image = CType(resources.GetObject("btnQvVisEnt.Image"), System.Drawing.Image)
        Me.btnQvVisEnt.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnQvVisEnt.Location = New System.Drawing.Point(6, 211)
        Me.btnQvVisEnt.Name = "btnQvVisEnt"
        Me.btnQvVisEnt.Size = New System.Drawing.Size(377, 45)
        Me.btnQvVisEnt.TabIndex = 803
        Me.btnQvVisEnt.TabStop = False
        Me.btnQvVisEnt.Text = "(F5) Visitor Inside Quick View     "
        Me.btnQvVisEnt.UseVisualStyleBackColor = False
        '
        'cmdNewVis
        '
        Me.cmdNewVis.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cmdNewVis.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.cmdNewVis.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cmdNewVis.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdNewVis.ForeColor = System.Drawing.Color.White
        Me.cmdNewVis.Image = CType(resources.GetObject("cmdNewVis.Image"), System.Drawing.Image)
        Me.cmdNewVis.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.cmdNewVis.Location = New System.Drawing.Point(6, 7)
        Me.cmdNewVis.Name = "cmdNewVis"
        Me.cmdNewVis.Size = New System.Drawing.Size(377, 45)
        Me.cmdNewVis.TabIndex = 500
        Me.cmdNewVis.TabStop = False
        Me.cmdNewVis.Text = "(F1) New Visitor                          "
        Me.cmdNewVis.UseVisualStyleBackColor = False
        '
        'cmdExitTrans
        '
        Me.cmdExitTrans.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cmdExitTrans.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.cmdExitTrans.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cmdExitTrans.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdExitTrans.ForeColor = System.Drawing.Color.White
        Me.cmdExitTrans.Image = CType(resources.GetObject("cmdExitTrans.Image"), System.Drawing.Image)
        Me.cmdExitTrans.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.cmdExitTrans.Location = New System.Drawing.Point(6, 109)
        Me.cmdExitTrans.Name = "cmdExitTrans"
        Me.cmdExitTrans.Size = New System.Drawing.Size(377, 45)
        Me.cmdExitTrans.TabIndex = 600
        Me.cmdExitTrans.TabStop = False
        Me.cmdExitTrans.Text = "(F3) Exit Transaction                  "
        Me.cmdExitTrans.UseVisualStyleBackColor = False
        '
        'cmdManExit
        '
        Me.cmdManExit.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cmdManExit.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.cmdManExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cmdManExit.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdManExit.ForeColor = System.Drawing.Color.White
        Me.cmdManExit.Image = CType(resources.GetObject("cmdManExit.Image"), System.Drawing.Image)
        Me.cmdManExit.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.cmdManExit.Location = New System.Drawing.Point(6, 160)
        Me.cmdManExit.Name = "cmdManExit"
        Me.cmdManExit.Size = New System.Drawing.Size(377, 45)
        Me.cmdManExit.TabIndex = 802
        Me.cmdManExit.TabStop = False
        Me.cmdManExit.Text = "(F4) Lost Visitor ID                     "
        Me.cmdManExit.UseVisualStyleBackColor = False
        '
        'cmdCancelTrans
        '
        Me.cmdCancelTrans.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cmdCancelTrans.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.cmdCancelTrans.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cmdCancelTrans.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdCancelTrans.ForeColor = System.Drawing.Color.White
        Me.cmdCancelTrans.Image = CType(resources.GetObject("cmdCancelTrans.Image"), System.Drawing.Image)
        Me.cmdCancelTrans.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.cmdCancelTrans.Location = New System.Drawing.Point(6, 262)
        Me.cmdCancelTrans.Name = "cmdCancelTrans"
        Me.cmdCancelTrans.Size = New System.Drawing.Size(377, 45)
        Me.cmdCancelTrans.TabIndex = 700
        Me.cmdCancelTrans.TabStop = False
        Me.cmdCancelTrans.Text = "(F6) Cancel Transaction              "
        Me.cmdCancelTrans.UseVisualStyleBackColor = False
        '
        'cmdSettle
        '
        Me.cmdSettle.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cmdSettle.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.cmdSettle.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cmdSettle.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdSettle.ForeColor = System.Drawing.Color.White
        Me.cmdSettle.Image = CType(resources.GetObject("cmdSettle.Image"), System.Drawing.Image)
        Me.cmdSettle.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.cmdSettle.Location = New System.Drawing.Point(6, 58)
        Me.cmdSettle.Name = "cmdSettle"
        Me.cmdSettle.Size = New System.Drawing.Size(377, 45)
        Me.cmdSettle.TabIndex = 800
        Me.cmdSettle.TabStop = False
        Me.cmdSettle.Text = "(F2) Settle Transaction               "
        Me.cmdSettle.UseVisualStyleBackColor = False
        '
        'SplitContainer4
        '
        Me.SplitContainer4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.SplitContainer4.Dock = System.Windows.Forms.DockStyle.Fill
        Me.SplitContainer4.Location = New System.Drawing.Point(0, 0)
        Me.SplitContainer4.Name = "SplitContainer4"
        '
        'SplitContainer4.Panel1
        '
        Me.SplitContainer4.Panel1.BackColor = System.Drawing.Color.Silver
        Me.SplitContainer4.Panel1.Controls.Add(Me.ScanID)
        Me.SplitContainer4.Panel1.Controls.Add(Me.btnIDShot)
        Me.SplitContainer4.Panel1.Controls.Add(Me.Label4)
        '
        'SplitContainer4.Panel2
        '
        Me.SplitContainer4.Panel2.BackColor = System.Drawing.Color.Silver
        Me.SplitContainer4.Panel2.Controls.Add(Me.cmdShot)
        Me.SplitContainer4.Panel2.Controls.Add(Me.Label1)
        Me.SplitContainer4.Panel2.Controls.Add(Me.WebCam)
        Me.SplitContainer4.Size = New System.Drawing.Size(707, 316)
        Me.SplitContainer4.SplitterDistance = 391
        Me.SplitContainer4.TabIndex = 435365
        Me.SplitContainer4.TabStop = False
        '
        'ScanID
        '
        Me.ScanID.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.ScanID.BackColor = System.Drawing.Color.Gray
        Me.ScanID.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.ScanID.Image = CType(resources.GetObject("ScanID.Image"), System.Drawing.Image)
        Me.ScanID.Location = New System.Drawing.Point(5, 25)
        Me.ScanID.Name = "ScanID"
        Me.ScanID.Size = New System.Drawing.Size(379, 238)
        Me.ScanID.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.ScanID.TabIndex = 0
        Me.ScanID.TabStop = False
        '
        'btnIDShot
        '
        Me.btnIDShot.Anchor = System.Windows.Forms.AnchorStyles.Bottom
        Me.btnIDShot.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.btnIDShot.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnIDShot.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnIDShot.ForeColor = System.Drawing.Color.White
        Me.btnIDShot.Image = CType(resources.GetObject("btnIDShot.Image"), System.Drawing.Image)
        Me.btnIDShot.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnIDShot.Location = New System.Drawing.Point(117, 272)
        Me.btnIDShot.Name = "btnIDShot"
        Me.btnIDShot.Size = New System.Drawing.Size(154, 34)
        Me.btnIDShot.TabIndex = 33
        Me.btnIDShot.TabStop = False
        Me.btnIDShot.Text = "(F8) Snap Shot"
        Me.btnIDShot.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnIDShot.UseVisualStyleBackColor = False
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.Transparent
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.Black
        Me.Label4.Location = New System.Drawing.Point(3, 6)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(181, 16)
        Me.Label4.TabIndex = 32
        Me.Label4.Text = "Visitor's Surrendered ID :"
        '
        'cmdShot
        '
        Me.cmdShot.Anchor = System.Windows.Forms.AnchorStyles.Bottom
        Me.cmdShot.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.cmdShot.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.cmdShot.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdShot.ForeColor = System.Drawing.Color.White
        Me.cmdShot.Image = CType(resources.GetObject("cmdShot.Image"), System.Drawing.Image)
        Me.cmdShot.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.cmdShot.Location = New System.Drawing.Point(77, 272)
        Me.cmdShot.Name = "cmdShot"
        Me.cmdShot.Size = New System.Drawing.Size(154, 34)
        Me.cmdShot.TabIndex = 7
        Me.cmdShot.TabStop = False
        Me.cmdShot.Text = "(F9) Snap Shot"
        Me.cmdShot.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.cmdShot.UseVisualStyleBackColor = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Black
        Me.Label1.Location = New System.Drawing.Point(5, 6)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(147, 16)
        Me.Label1.TabIndex = 31
        Me.Label1.Text = "Visitor's Snap Shot :"
        '
        'WebCam
        '
        Me.WebCam.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.WebCam.BackColor = System.Drawing.Color.Gray
        Me.WebCam.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.WebCam.Image = CType(resources.GetObject("WebCam.Image"), System.Drawing.Image)
        Me.WebCam.Location = New System.Drawing.Point(6, 25)
        Me.WebCam.Name = "WebCam"
        Me.WebCam.Size = New System.Drawing.Size(296, 238)
        Me.WebCam.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.WebCam.TabIndex = 29
        Me.WebCam.TabStop = False
        '
        'StatusStrip1
        '
        Me.StatusStrip1.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.StatusStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripStatusLabel1, Me.txtDesig, Me.txtUser, Me.ToolStripStatusLabel4, Me.ToolStripStatusLabel5, Me.txtDBstat, Me.ToolStripStatusLabel6, Me.ToolStripStatusLabel3, Me.txtDbLoc, Me.ToolStripStatusLabel2, Me.txtStation})
        Me.StatusStrip1.Location = New System.Drawing.Point(0, 316)
        Me.StatusStrip1.Name = "StatusStrip1"
        Me.StatusStrip1.Size = New System.Drawing.Size(1102, 37)
        Me.StatusStrip1.TabIndex = 0
        Me.StatusStrip1.Text = "StatusStrip1"
        '
        'ToolStripStatusLabel1
        '
        Me.ToolStripStatusLabel1.Name = "ToolStripStatusLabel1"
        Me.ToolStripStatusLabel1.Size = New System.Drawing.Size(13, 32)
        Me.ToolStripStatusLabel1.Text = "  "
        '
        'txtDesig
        '
        Me.txtDesig.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtDesig.ForeColor = System.Drawing.Color.White
        Me.txtDesig.Image = CType(resources.GetObject("txtDesig.Image"), System.Drawing.Image)
        Me.txtDesig.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.txtDesig.Name = "txtDesig"
        Me.txtDesig.Size = New System.Drawing.Size(89, 32)
        Me.txtDesig.Text = "Admin :"
        '
        'txtUser
        '
        Me.txtUser.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtUser.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.txtUser.Name = "txtUser"
        Me.txtUser.Size = New System.Drawing.Size(40, 32)
        Me.txtUser.Text = "LOCK"
        '
        'ToolStripStatusLabel4
        '
        Me.ToolStripStatusLabel4.Name = "ToolStripStatusLabel4"
        Me.ToolStripStatusLabel4.Size = New System.Drawing.Size(10, 32)
        Me.ToolStripStatusLabel4.Text = " "
        '
        'ToolStripStatusLabel5
        '
        Me.ToolStripStatusLabel5.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ToolStripStatusLabel5.ForeColor = System.Drawing.Color.White
        Me.ToolStripStatusLabel5.Image = CType(resources.GetObject("ToolStripStatusLabel5.Image"), System.Drawing.Image)
        Me.ToolStripStatusLabel5.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.ToolStripStatusLabel5.Name = "ToolStripStatusLabel5"
        Me.ToolStripStatusLabel5.Size = New System.Drawing.Size(93, 32)
        Me.ToolStripStatusLabel5.Text = "Server :"
        '
        'txtDBstat
        '
        Me.txtDBstat.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtDBstat.ForeColor = System.Drawing.Color.LightCoral
        Me.txtDBstat.Name = "txtDBstat"
        Me.txtDBstat.Size = New System.Drawing.Size(95, 32)
        Me.txtDBstat.Text = "Disconnected"
        '
        'ToolStripStatusLabel6
        '
        Me.ToolStripStatusLabel6.Name = "ToolStripStatusLabel6"
        Me.ToolStripStatusLabel6.Size = New System.Drawing.Size(10, 32)
        Me.ToolStripStatusLabel6.Text = " "
        '
        'ToolStripStatusLabel3
        '
        Me.ToolStripStatusLabel3.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ToolStripStatusLabel3.ForeColor = System.Drawing.Color.White
        Me.ToolStripStatusLabel3.Image = CType(resources.GetObject("ToolStripStatusLabel3.Image"), System.Drawing.Image)
        Me.ToolStripStatusLabel3.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.ToolStripStatusLabel3.Name = "ToolStripStatusLabel3"
        Me.ToolStripStatusLabel3.Size = New System.Drawing.Size(82, 32)
        Me.ToolStripStatusLabel3.Text = "Local :"
        '
        'txtDbLoc
        '
        Me.txtDbLoc.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtDbLoc.ForeColor = System.Drawing.Color.LightCoral
        Me.txtDbLoc.Name = "txtDbLoc"
        Me.txtDbLoc.Size = New System.Drawing.Size(95, 32)
        Me.txtDbLoc.Text = "Disconnected"
        '
        'ToolStripStatusLabel2
        '
        Me.ToolStripStatusLabel2.Name = "ToolStripStatusLabel2"
        Me.ToolStripStatusLabel2.Size = New System.Drawing.Size(10, 32)
        Me.ToolStripStatusLabel2.Text = " "
        '
        'txtStation
        '
        Me.txtStation.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtStation.ForeColor = System.Drawing.Color.White
        Me.txtStation.Image = CType(resources.GetObject("txtStation.Image"), System.Drawing.Image)
        Me.txtStation.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.txtStation.Name = "txtStation"
        Me.txtStation.Size = New System.Drawing.Size(103, 32)
        Me.txtStation.Text = "Station 1 "
        '
        'tmeTime
        '
        Me.tmeTime.Enabled = True
        '
        'tmeReadText
        '
        '
        'tmeDelImg
        '
        Me.tmeDelImg.Interval = 1
        '
        'tmeWebCam
        '
        '
        'MainForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(1102, 763)
        Me.Controls.Add(Me.SplitContainer1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.KeyPreview = True
        Me.Name = "MainForm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Main Form"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.SplitContainer1.Panel1.ResumeLayout(False)
        Me.SplitContainer1.Panel1.PerformLayout()
        Me.SplitContainer1.Panel2.ResumeLayout(False)
        Me.SplitContainer1.Panel2.PerformLayout()
        CType(Me.SplitContainer1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.SplitContainer1.ResumeLayout(False)
        Me.SplitContainer3.Panel1.ResumeLayout(False)
        Me.SplitContainer3.Panel2.ResumeLayout(False)
        Me.SplitContainer3.Panel2.PerformLayout()
        CType(Me.SplitContainer3, System.ComponentModel.ISupportInitialize).EndInit()
        Me.SplitContainer3.ResumeLayout(False)
        Me.GP1.ResumeLayout(False)
        Me.GP1.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ToolStrip1.ResumeLayout(False)
        Me.ToolStrip1.PerformLayout()
        Me.SplitContainer5.Panel1.ResumeLayout(False)
        Me.SplitContainer5.Panel2.ResumeLayout(False)
        CType(Me.SplitContainer5, System.ComponentModel.ISupportInitialize).EndInit()
        Me.SplitContainer5.ResumeLayout(False)
        Me.SplitContainer4.Panel1.ResumeLayout(False)
        Me.SplitContainer4.Panel1.PerformLayout()
        Me.SplitContainer4.Panel2.ResumeLayout(False)
        Me.SplitContainer4.Panel2.PerformLayout()
        CType(Me.SplitContainer4, System.ComponentModel.ISupportInitialize).EndInit()
        Me.SplitContainer4.ResumeLayout(False)
        CType(Me.ScanID, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.WebCam, System.ComponentModel.ISupportInitialize).EndInit()
        Me.StatusStrip1.ResumeLayout(False)
        Me.StatusStrip1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents SplitContainer1 As System.Windows.Forms.SplitContainer
    Friend WithEvents ToolStrip1 As System.Windows.Forms.ToolStrip
    Friend WithEvents txtCompany As System.Windows.Forms.ToolStripLabel
    Friend WithEvents ssd As System.Windows.Forms.ToolStripLabel
    Friend WithEvents tmeTime As System.Windows.Forms.Timer
    Friend WithEvents txtTime As System.Windows.Forms.ToolStripLabel
    Friend WithEvents ToolStripLabel1 As System.Windows.Forms.ToolStripLabel
    Friend WithEvents txtDate As System.Windows.Forms.ToolStripLabel
    Friend WithEvents SplitContainer3 As System.Windows.Forms.SplitContainer
    Friend WithEvents StatusStrip1 As System.Windows.Forms.StatusStrip
    Friend WithEvents ToolStripStatusLabel1 As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents txtDesig As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents txtDBstat As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents cmdNewVis As System.Windows.Forms.Button
    Friend WithEvents cmdCancelTrans As System.Windows.Forms.Button
    Friend WithEvents cmdExitTrans As System.Windows.Forms.Button
    Friend WithEvents GP1 As System.Windows.Forms.GroupBox
    Friend WithEvents cmdShot As System.Windows.Forms.Button
    Friend WithEvents txtVisitor As System.Windows.Forms.TextBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents txtContact As System.Windows.Forms.TextBox
    Friend WithEvents cboCompany As System.Windows.Forms.ComboBox
    Friend WithEvents txtRefIDno As System.Windows.Forms.TextBox
    Friend WithEvents WebCam As System.Windows.Forms.PictureBox
    Friend WithEvents txtUser As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents ToolStripStatusLabel5 As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents txtContactPerson As System.Windows.Forms.TextBox
    Friend WithEvents txtStation As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents txtVisitorID As System.Windows.Forms.TextBox
    Friend WithEvents tmeReadText As System.Windows.Forms.Timer
    Friend WithEvents SplitContainer4 As System.Windows.Forms.SplitContainer
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents ScanID As System.Windows.Forms.PictureBox
    Friend WithEvents cmdSigna As System.Windows.Forms.Button
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents txtNotice As System.Windows.Forms.Label
    Friend WithEvents cmdSettle As System.Windows.Forms.Button
    Friend WithEvents cboPurpose As System.Windows.Forms.ComboBox
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents cmdManExit As System.Windows.Forms.Button
    Friend WithEvents tmeDelImg As System.Windows.Forms.Timer
    Friend WithEvents Label14 As System.Windows.Forms.Label
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents SplitContainer5 As System.Windows.Forms.SplitContainer
    Friend WithEvents btnIDShot As System.Windows.Forms.Button
    Friend WithEvents Label15 As System.Windows.Forms.Label
    Friend WithEvents tmeWebCam As System.Windows.Forms.Timer
    Friend WithEvents ToolStripLabel2 As System.Windows.Forms.ToolStripLabel
    Friend WithEvents ToolStripStatusLabel3 As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents txtDbLoc As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents btnQvVisEnt As System.Windows.Forms.Button
    Friend WithEvents ToolStripStatusLabel4 As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents ToolStripStatusLabel6 As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents ToolStripStatusLabel2 As System.Windows.Forms.ToolStripStatusLabel

End Class
