<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmExit
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmExit))
        Me.tmeRead = New System.Windows.Forms.Timer(Me.components)
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.PicSigna = New System.Windows.Forms.PictureBox()
        Me.txtbCode = New System.Windows.Forms.TextBox()
        Me.cmdManual = New System.Windows.Forms.Button()
        Me.cmdAccept = New System.Windows.Forms.Button()
        Me.IDimage = New System.Windows.Forms.PictureBox()
        Me.Vimage = New System.Windows.Forms.PictureBox()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.txtIssuedID = New System.Windows.Forms.TextBox()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.txtTimeOut = New System.Windows.Forms.TextBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.txtTimeIn = New System.Windows.Forms.TextBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.txtPurpose = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.txtContactP = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.txtCompVisited = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txtContact = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtIDRef = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtIDtype = New System.Windows.Forms.TextBox()
        Me.txtNAme = New System.Windows.Forms.TextBox()
        Me.txtvID = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.tmeBtn = New System.Windows.Forms.Timer(Me.components)
        Me.Panel1.SuspendLayout()
        CType(Me.PicSigna, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.IDimage, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Vimage, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'tmeRead
        '
        Me.tmeRead.Enabled = True
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.SteelBlue
        Me.Panel1.Controls.Add(Me.PicSigna)
        Me.Panel1.Controls.Add(Me.txtbCode)
        Me.Panel1.Controls.Add(Me.cmdManual)
        Me.Panel1.Controls.Add(Me.cmdAccept)
        Me.Panel1.Controls.Add(Me.IDimage)
        Me.Panel1.Controls.Add(Me.Vimage)
        Me.Panel1.Controls.Add(Me.GroupBox1)
        Me.Panel1.Location = New System.Drawing.Point(5, 6)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(723, 560)
        Me.Panel1.TabIndex = 0
        '
        'PicSigna
        '
        Me.PicSigna.BackColor = System.Drawing.Color.DarkBlue
        Me.PicSigna.Location = New System.Drawing.Point(9, 245)
        Me.PicSigna.Name = "PicSigna"
        Me.PicSigna.Size = New System.Drawing.Size(228, 223)
        Me.PicSigna.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PicSigna.TabIndex = 15
        Me.PicSigna.TabStop = False
        '
        'txtbCode
        '
        Me.txtbCode.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtbCode.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtbCode.Location = New System.Drawing.Point(245, 474)
        Me.txtbCode.MaxLength = 35
        Me.txtbCode.Name = "txtbCode"
        Me.txtbCode.Size = New System.Drawing.Size(469, 24)
        Me.txtbCode.TabIndex = 14
        Me.txtbCode.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'cmdManual
        '
        Me.cmdManual.BackColor = System.Drawing.Color.White
        Me.cmdManual.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.cmdManual.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdManual.Image = CType(resources.GetObject("cmdManual.Image"), System.Drawing.Image)
        Me.cmdManual.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.cmdManual.Location = New System.Drawing.Point(245, 505)
        Me.cmdManual.Name = "cmdManual"
        Me.cmdManual.Size = New System.Drawing.Size(233, 44)
        Me.cmdManual.TabIndex = 11
        Me.cmdManual.Text = "       (F1) Manual Transaction"
        Me.cmdManual.UseVisualStyleBackColor = False
        '
        'cmdAccept
        '
        Me.cmdAccept.BackColor = System.Drawing.Color.White
        Me.cmdAccept.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.cmdAccept.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdAccept.Image = CType(resources.GetObject("cmdAccept.Image"), System.Drawing.Image)
        Me.cmdAccept.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.cmdAccept.Location = New System.Drawing.Point(484, 504)
        Me.cmdAccept.Name = "cmdAccept"
        Me.cmdAccept.Size = New System.Drawing.Size(231, 44)
        Me.cmdAccept.TabIndex = 10
        Me.cmdAccept.Text = "(Enter) Accept"
        Me.cmdAccept.UseVisualStyleBackColor = False
        '
        'IDimage
        '
        Me.IDimage.BackColor = System.Drawing.Color.DarkBlue
        Me.IDimage.Location = New System.Drawing.Point(243, 245)
        Me.IDimage.Name = "IDimage"
        Me.IDimage.Size = New System.Drawing.Size(472, 223)
        Me.IDimage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.IDimage.TabIndex = 8
        Me.IDimage.TabStop = False
        '
        'Vimage
        '
        Me.Vimage.BackColor = System.Drawing.Color.DarkBlue
        Me.Vimage.Location = New System.Drawing.Point(9, 10)
        Me.Vimage.Name = "Vimage"
        Me.Vimage.Size = New System.Drawing.Size(228, 225)
        Me.Vimage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.Vimage.TabIndex = 7
        Me.Vimage.TabStop = False
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.Color.White
        Me.GroupBox1.Controls.Add(Me.txtIssuedID)
        Me.GroupBox1.Controls.Add(Me.Label11)
        Me.GroupBox1.Controls.Add(Me.txtTimeOut)
        Me.GroupBox1.Controls.Add(Me.Label9)
        Me.GroupBox1.Controls.Add(Me.txtTimeIn)
        Me.GroupBox1.Controls.Add(Me.Label10)
        Me.GroupBox1.Controls.Add(Me.txtPurpose)
        Me.GroupBox1.Controls.Add(Me.Label8)
        Me.GroupBox1.Controls.Add(Me.txtContactP)
        Me.GroupBox1.Controls.Add(Me.Label7)
        Me.GroupBox1.Controls.Add(Me.txtCompVisited)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.txtContact)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.txtIDRef)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.txtIDtype)
        Me.GroupBox1.Controls.Add(Me.txtNAme)
        Me.GroupBox1.Controls.Add(Me.txtvID)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.Label6)
        Me.GroupBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.Location = New System.Drawing.Point(244, 10)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(470, 224)
        Me.GroupBox1.TabIndex = 6
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Visitor Information"
        '
        'txtIssuedID
        '
        Me.txtIssuedID.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.txtIssuedID.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtIssuedID.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtIssuedID.Location = New System.Drawing.Point(197, 335)
        Me.txtIssuedID.MaxLength = 30
        Me.txtIssuedID.Name = "txtIssuedID"
        Me.txtIssuedID.ReadOnly = True
        Me.txtIssuedID.Size = New System.Drawing.Size(258, 22)
        Me.txtIssuedID.TabIndex = 50
        Me.txtIssuedID.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.txtIssuedID.Visible = False
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.BackColor = System.Drawing.Color.White
        Me.Label11.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.ForeColor = System.Drawing.Color.Black
        Me.Label11.Location = New System.Drawing.Point(27, 337)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(163, 16)
        Me.Label11.TabIndex = 49
        Me.Label11.Text = "Manual ID No. Issued :"
        Me.Label11.Visible = False
        '
        'txtTimeOut
        '
        Me.txtTimeOut.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.txtTimeOut.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtTimeOut.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtTimeOut.Location = New System.Drawing.Point(179, 142)
        Me.txtTimeOut.MaxLength = 30
        Me.txtTimeOut.Name = "txtTimeOut"
        Me.txtTimeOut.ReadOnly = True
        Me.txtTimeOut.Size = New System.Drawing.Size(258, 22)
        Me.txtTimeOut.TabIndex = 48
        Me.txtTimeOut.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.BackColor = System.Drawing.Color.White
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.ForeColor = System.Drawing.Color.Black
        Me.Label9.Location = New System.Drawing.Point(94, 142)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(78, 16)
        Me.Label9.TabIndex = 47
        Me.Label9.Text = "Time Out :"
        '
        'txtTimeIn
        '
        Me.txtTimeIn.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.txtTimeIn.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtTimeIn.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtTimeIn.Location = New System.Drawing.Point(179, 102)
        Me.txtTimeIn.MaxLength = 30
        Me.txtTimeIn.Name = "txtTimeIn"
        Me.txtTimeIn.ReadOnly = True
        Me.txtTimeIn.Size = New System.Drawing.Size(258, 22)
        Me.txtTimeIn.TabIndex = 46
        Me.txtTimeIn.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.BackColor = System.Drawing.Color.White
        Me.Label10.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.ForeColor = System.Drawing.Color.Black
        Me.Label10.Location = New System.Drawing.Point(106, 104)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(67, 16)
        Me.Label10.TabIndex = 45
        Me.Label10.Text = "Time In :"
        '
        'txtPurpose
        '
        Me.txtPurpose.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.txtPurpose.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtPurpose.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtPurpose.Location = New System.Drawing.Point(197, 391)
        Me.txtPurpose.MaxLength = 30
        Me.txtPurpose.Name = "txtPurpose"
        Me.txtPurpose.ReadOnly = True
        Me.txtPurpose.Size = New System.Drawing.Size(258, 22)
        Me.txtPurpose.TabIndex = 44
        Me.txtPurpose.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.txtPurpose.Visible = False
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.BackColor = System.Drawing.Color.White
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.ForeColor = System.Drawing.Color.Black
        Me.Label8.Location = New System.Drawing.Point(117, 393)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(74, 16)
        Me.Label8.TabIndex = 43
        Me.Label8.Text = "Purpose :"
        Me.Label8.Visible = False
        '
        'txtContactP
        '
        Me.txtContactP.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.txtContactP.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtContactP.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtContactP.Location = New System.Drawing.Point(197, 363)
        Me.txtContactP.MaxLength = 30
        Me.txtContactP.Name = "txtContactP"
        Me.txtContactP.ReadOnly = True
        Me.txtContactP.Size = New System.Drawing.Size(258, 22)
        Me.txtContactP.TabIndex = 42
        Me.txtContactP.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.txtContactP.Visible = False
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.BackColor = System.Drawing.Color.White
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.Color.Black
        Me.Label7.Location = New System.Drawing.Point(70, 365)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(121, 16)
        Me.Label7.TabIndex = 41
        Me.Label7.Text = "Contact Person :"
        Me.Label7.Visible = False
        '
        'txtCompVisited
        '
        Me.txtCompVisited.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.txtCompVisited.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtCompVisited.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCompVisited.Location = New System.Drawing.Point(179, 182)
        Me.txtCompVisited.MaxLength = 30
        Me.txtCompVisited.Name = "txtCompVisited"
        Me.txtCompVisited.ReadOnly = True
        Me.txtCompVisited.Size = New System.Drawing.Size(258, 22)
        Me.txtCompVisited.TabIndex = 40
        Me.txtCompVisited.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.White
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.Black
        Me.Label4.Location = New System.Drawing.Point(40, 184)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(133, 16)
        Me.Label4.TabIndex = 39
        Me.Label4.Text = "Company Visited :"
        '
        'txtContact
        '
        Me.txtContact.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.txtContact.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtContact.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtContact.Location = New System.Drawing.Point(436, 307)
        Me.txtContact.MaxLength = 30
        Me.txtContact.Name = "txtContact"
        Me.txtContact.ReadOnly = True
        Me.txtContact.Size = New System.Drawing.Size(258, 22)
        Me.txtContact.TabIndex = 38
        Me.txtContact.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.txtContact.Visible = False
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.White
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.Black
        Me.Label2.Location = New System.Drawing.Point(334, 309)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(96, 16)
        Me.Label2.TabIndex = 37
        Me.Label2.Text = "Contact No. :"
        Me.Label2.Visible = False
        '
        'txtIDRef
        '
        Me.txtIDRef.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.txtIDRef.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtIDRef.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtIDRef.Location = New System.Drawing.Point(436, 268)
        Me.txtIDRef.MaxLength = 30
        Me.txtIDRef.Name = "txtIDRef"
        Me.txtIDRef.ReadOnly = True
        Me.txtIDRef.Size = New System.Drawing.Size(258, 22)
        Me.txtIDRef.TabIndex = 36
        Me.txtIDRef.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.txtIDRef.Visible = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.White
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Black
        Me.Label1.Location = New System.Drawing.Point(295, 270)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(135, 16)
        Me.Label1.TabIndex = 35
        Me.Label1.Text = "Reference ID No. :"
        Me.Label1.Visible = False
        '
        'txtIDtype
        '
        Me.txtIDtype.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.txtIDtype.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtIDtype.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtIDtype.Location = New System.Drawing.Point(436, 229)
        Me.txtIDtype.MaxLength = 30
        Me.txtIDtype.Name = "txtIDtype"
        Me.txtIDtype.ReadOnly = True
        Me.txtIDtype.Size = New System.Drawing.Size(258, 22)
        Me.txtIDtype.TabIndex = 34
        Me.txtIDtype.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.txtIDtype.Visible = False
        '
        'txtNAme
        '
        Me.txtNAme.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.txtNAme.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtNAme.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtNAme.Location = New System.Drawing.Point(179, 64)
        Me.txtNAme.MaxLength = 30
        Me.txtNAme.Name = "txtNAme"
        Me.txtNAme.ReadOnly = True
        Me.txtNAme.Size = New System.Drawing.Size(258, 22)
        Me.txtNAme.TabIndex = 33
        Me.txtNAme.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txtvID
        '
        Me.txtvID.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.txtvID.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtvID.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtvID.Location = New System.Drawing.Point(179, 26)
        Me.txtvID.MaxLength = 30
        Me.txtvID.Name = "txtvID"
        Me.txtvID.ReadOnly = True
        Me.txtvID.Size = New System.Drawing.Size(258, 22)
        Me.txtvID.TabIndex = 32
        Me.txtvID.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.BackColor = System.Drawing.Color.White
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.Black
        Me.Label5.Location = New System.Drawing.Point(359, 231)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(71, 16)
        Me.Label5.TabIndex = 31
        Me.Label5.Text = "ID Type :"
        Me.Label5.Visible = False
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.White
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.Black
        Me.Label3.Location = New System.Drawing.Point(68, 66)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(105, 16)
        Me.Label3.TabIndex = 29
        Me.Label3.Text = "Visitor Name :"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.BackColor = System.Drawing.Color.White
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.Black
        Me.Label6.Location = New System.Drawing.Point(94, 28)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(79, 16)
        Me.Label6.TabIndex = 27
        Me.Label6.Text = "Visitor ID :"
        '
        'tmeBtn
        '
        '
        'frmExit
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.LightSteelBlue
        Me.ClientSize = New System.Drawing.Size(734, 572)
        Me.Controls.Add(Me.Panel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmExit"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = " Exit Transaction"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.PicSigna, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.IDimage, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Vimage, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents tmeRead As System.Windows.Forms.Timer
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents cmdManual As System.Windows.Forms.Button
    Friend WithEvents cmdAccept As System.Windows.Forms.Button
    Friend WithEvents IDimage As System.Windows.Forms.PictureBox
    Friend WithEvents Vimage As System.Windows.Forms.PictureBox
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents txtPurpose As System.Windows.Forms.TextBox
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents txtContactP As System.Windows.Forms.TextBox
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents txtCompVisited As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents txtContact As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents txtIDRef As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents txtIDtype As System.Windows.Forms.TextBox
    Friend WithEvents txtNAme As System.Windows.Forms.TextBox
    Friend WithEvents txtvID As System.Windows.Forms.TextBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents txtbCode As System.Windows.Forms.TextBox
    Friend WithEvents tmeBtn As System.Windows.Forms.Timer
    Friend WithEvents txtTimeOut As System.Windows.Forms.TextBox
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents txtTimeIn As System.Windows.Forms.TextBox
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents txtIssuedID As System.Windows.Forms.TextBox
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents PicSigna As System.Windows.Forms.PictureBox
End Class
