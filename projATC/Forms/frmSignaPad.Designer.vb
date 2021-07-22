<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmSignaPad
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmSignaPad))
        Me.functionPanel = New System.Windows.Forms.Panel()
        Me.ConfidenceBitsEnabledGroupBox = New System.Windows.Forms.GroupBox()
        Me.ConfidenceBitsDisabledRadioButton = New System.Windows.Forms.RadioButton()
        Me.ConfidenceBitsEnabledRadioButton = New System.Windows.Forms.RadioButton()
        Me.FingerDataFromGroupBox = New System.Windows.Forms.GroupBox()
        Me.FingerDataFromEventRadioButton = New System.Windows.Forms.RadioButton()
        Me.FingerDataFromHitRectRadioButton = New System.Windows.Forms.RadioButton()
        Me.DeviceIDSelectLabel = New System.Windows.Forms.Label()
        Me.DeviceIDComboBox = New System.Windows.Forms.ComboBox()
        Me.ClientModeGroupBox = New System.Windows.Forms.GroupBox()
        Me.ClientModeObserverRadioButton = New System.Windows.Forms.RadioButton()
        Me.ClientModeConsumerRadioButton = New System.Windows.Forms.RadioButton()
        Me.DeviceIDCapabilitiesFormButton = New System.Windows.Forms.Button()
        Me.mClearButton = New System.Windows.Forms.Button()
        Me.fingerPanel = New System.Windows.Forms.Panel()
        Me.panel1 = New System.Windows.Forms.Panel()
        Me.ToolStripStatusFingerCountLabel = New System.Windows.Forms.Label()
        Me.ToolStripStatusConfidenceBitsEnabledLabel = New System.Windows.Forms.Label()
        Me.ToolStripStatusUserDataLabel = New System.Windows.Forms.Label()
        Me.ToolStripStatusClientModeLabel = New System.Windows.Forms.Label()
        Me.functionPanel.SuspendLayout()
        Me.ConfidenceBitsEnabledGroupBox.SuspendLayout()
        Me.FingerDataFromGroupBox.SuspendLayout()
        Me.ClientModeGroupBox.SuspendLayout()
        Me.panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'functionPanel
        '
        Me.functionPanel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.functionPanel.Controls.Add(Me.ConfidenceBitsEnabledGroupBox)
        Me.functionPanel.Controls.Add(Me.FingerDataFromGroupBox)
        Me.functionPanel.Controls.Add(Me.DeviceIDSelectLabel)
        Me.functionPanel.Controls.Add(Me.DeviceIDComboBox)
        Me.functionPanel.Controls.Add(Me.ClientModeGroupBox)
        Me.functionPanel.Controls.Add(Me.DeviceIDCapabilitiesFormButton)
        Me.functionPanel.Controls.Add(Me.mClearButton)
        Me.functionPanel.Location = New System.Drawing.Point(709, 6)
        Me.functionPanel.Name = "functionPanel"
        Me.functionPanel.Size = New System.Drawing.Size(132, 440)
        Me.functionPanel.TabIndex = 8
        '
        'ConfidenceBitsEnabledGroupBox
        '
        Me.ConfidenceBitsEnabledGroupBox.Controls.Add(Me.ConfidenceBitsDisabledRadioButton)
        Me.ConfidenceBitsEnabledGroupBox.Controls.Add(Me.ConfidenceBitsEnabledRadioButton)
        Me.ConfidenceBitsEnabledGroupBox.Location = New System.Drawing.Point(4, 186)
        Me.ConfidenceBitsEnabledGroupBox.Name = "ConfidenceBitsEnabledGroupBox"
        Me.ConfidenceBitsEnabledGroupBox.Size = New System.Drawing.Size(120, 70)
        Me.ConfidenceBitsEnabledGroupBox.TabIndex = 6
        Me.ConfidenceBitsEnabledGroupBox.TabStop = False
        Me.ConfidenceBitsEnabledGroupBox.Text = "Confidence Bits:"
        '
        'ConfidenceBitsDisabledRadioButton
        '
        Me.ConfidenceBitsDisabledRadioButton.AutoSize = True
        Me.ConfidenceBitsDisabledRadioButton.Location = New System.Drawing.Point(12, 44)
        Me.ConfidenceBitsDisabledRadioButton.Name = "ConfidenceBitsDisabledRadioButton"
        Me.ConfidenceBitsDisabledRadioButton.Size = New System.Drawing.Size(66, 17)
        Me.ConfidenceBitsDisabledRadioButton.TabIndex = 1
        Me.ConfidenceBitsDisabledRadioButton.Text = "Disabled"
        Me.ConfidenceBitsDisabledRadioButton.UseVisualStyleBackColor = True
        '
        'ConfidenceBitsEnabledRadioButton
        '
        Me.ConfidenceBitsEnabledRadioButton.AutoSize = True
        Me.ConfidenceBitsEnabledRadioButton.Checked = True
        Me.ConfidenceBitsEnabledRadioButton.Location = New System.Drawing.Point(12, 20)
        Me.ConfidenceBitsEnabledRadioButton.Name = "ConfidenceBitsEnabledRadioButton"
        Me.ConfidenceBitsEnabledRadioButton.Size = New System.Drawing.Size(64, 17)
        Me.ConfidenceBitsEnabledRadioButton.TabIndex = 0
        Me.ConfidenceBitsEnabledRadioButton.TabStop = True
        Me.ConfidenceBitsEnabledRadioButton.Text = "Enabled"
        Me.ConfidenceBitsEnabledRadioButton.UseVisualStyleBackColor = True
        '
        'FingerDataFromGroupBox
        '
        Me.FingerDataFromGroupBox.Controls.Add(Me.FingerDataFromEventRadioButton)
        Me.FingerDataFromGroupBox.Controls.Add(Me.FingerDataFromHitRectRadioButton)
        Me.FingerDataFromGroupBox.Location = New System.Drawing.Point(4, 95)
        Me.FingerDataFromGroupBox.Name = "FingerDataFromGroupBox"
        Me.FingerDataFromGroupBox.Size = New System.Drawing.Size(120, 70)
        Me.FingerDataFromGroupBox.TabIndex = 5
        Me.FingerDataFromGroupBox.TabStop = False
        Me.FingerDataFromGroupBox.Text = "Fingerdata from:"
        '
        'FingerDataFromEventRadioButton
        '
        Me.FingerDataFromEventRadioButton.Location = New System.Drawing.Point(11, 42)
        Me.FingerDataFromEventRadioButton.Name = "FingerDataFromEventRadioButton"
        Me.FingerDataFromEventRadioButton.Size = New System.Drawing.Size(98, 18)
        Me.FingerDataFromEventRadioButton.TabIndex = 1
        Me.FingerDataFromEventRadioButton.Text = "HWND Events"
        Me.FingerDataFromEventRadioButton.UseVisualStyleBackColor = True
        '
        'FingerDataFromHitRectRadioButton
        '
        Me.FingerDataFromHitRectRadioButton.Checked = True
        Me.FingerDataFromHitRectRadioButton.Location = New System.Drawing.Point(11, 19)
        Me.FingerDataFromHitRectRadioButton.Margin = New System.Windows.Forms.Padding(1)
        Me.FingerDataFromHitRectRadioButton.Name = "FingerDataFromHitRectRadioButton"
        Me.FingerDataFromHitRectRadioButton.Size = New System.Drawing.Size(105, 19)
        Me.FingerDataFromHitRectRadioButton.TabIndex = 0
        Me.FingerDataFromHitRectRadioButton.TabStop = True
        Me.FingerDataFromHitRectRadioButton.Text = "Hitrect Callbacks"
        Me.FingerDataFromHitRectRadioButton.UseVisualStyleBackColor = True
        '
        'DeviceIDSelectLabel
        '
        Me.DeviceIDSelectLabel.Location = New System.Drawing.Point(2, 283)
        Me.DeviceIDSelectLabel.Name = "DeviceIDSelectLabel"
        Me.DeviceIDSelectLabel.Size = New System.Drawing.Size(57, 30)
        Me.DeviceIDSelectLabel.TabIndex = 4
        Me.DeviceIDSelectLabel.Text = "Select DeviceID:"
        '
        'DeviceIDComboBox
        '
        Me.DeviceIDComboBox.FormattingEnabled = True
        Me.DeviceIDComboBox.Location = New System.Drawing.Point(67, 283)
        Me.DeviceIDComboBox.Name = "DeviceIDComboBox"
        Me.DeviceIDComboBox.Size = New System.Drawing.Size(47, 21)
        Me.DeviceIDComboBox.TabIndex = 3
        '
        'ClientModeGroupBox
        '
        Me.ClientModeGroupBox.Controls.Add(Me.ClientModeObserverRadioButton)
        Me.ClientModeGroupBox.Controls.Add(Me.ClientModeConsumerRadioButton)
        Me.ClientModeGroupBox.Location = New System.Drawing.Point(4, 4)
        Me.ClientModeGroupBox.Name = "ClientModeGroupBox"
        Me.ClientModeGroupBox.Size = New System.Drawing.Size(109, 70)
        Me.ClientModeGroupBox.TabIndex = 2
        Me.ClientModeGroupBox.TabStop = False
        Me.ClientModeGroupBox.Text = "Client Mode:"
        '
        'ClientModeObserverRadioButton
        '
        Me.ClientModeObserverRadioButton.Location = New System.Drawing.Point(12, 40)
        Me.ClientModeObserverRadioButton.Name = "ClientModeObserverRadioButton"
        Me.ClientModeObserverRadioButton.Size = New System.Drawing.Size(72, 17)
        Me.ClientModeObserverRadioButton.TabIndex = 1
        Me.ClientModeObserverRadioButton.Text = "Observer"
        Me.ClientModeObserverRadioButton.UseVisualStyleBackColor = True
        '
        'ClientModeConsumerRadioButton
        '
        Me.ClientModeConsumerRadioButton.Checked = True
        Me.ClientModeConsumerRadioButton.Location = New System.Drawing.Point(12, 19)
        Me.ClientModeConsumerRadioButton.Name = "ClientModeConsumerRadioButton"
        Me.ClientModeConsumerRadioButton.Size = New System.Drawing.Size(72, 17)
        Me.ClientModeConsumerRadioButton.TabIndex = 0
        Me.ClientModeConsumerRadioButton.TabStop = True
        Me.ClientModeConsumerRadioButton.Text = "Consumer"
        Me.ClientModeConsumerRadioButton.UseVisualStyleBackColor = True
        '
        'DeviceIDCapabilitiesFormButton
        '
        Me.DeviceIDCapabilitiesFormButton.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.DeviceIDCapabilitiesFormButton.Location = New System.Drawing.Point(5, 316)
        Me.DeviceIDCapabilitiesFormButton.Name = "DeviceIDCapabilitiesFormButton"
        Me.DeviceIDCapabilitiesFormButton.Size = New System.Drawing.Size(120, 23)
        Me.DeviceIDCapabilitiesFormButton.TabIndex = 1
        Me.DeviceIDCapabilitiesFormButton.Text = "Dev Capabilities ..."
        Me.DeviceIDCapabilitiesFormButton.UseVisualStyleBackColor = True
        '
        'mClearButton
        '
        Me.mClearButton.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.mClearButton.Location = New System.Drawing.Point(4, 408)
        Me.mClearButton.Name = "mClearButton"
        Me.mClearButton.Size = New System.Drawing.Size(120, 23)
        Me.mClearButton.TabIndex = 0
        Me.mClearButton.Text = "Clear"
        Me.mClearButton.UseVisualStyleBackColor = True
        '
        'fingerPanel
        '
        Me.fingerPanel.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.fingerPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.fingerPanel.ForeColor = System.Drawing.SystemColors.MenuHighlight
        Me.fingerPanel.Location = New System.Drawing.Point(4, 40)
        Me.fingerPanel.Name = "fingerPanel"
        Me.fingerPanel.Size = New System.Drawing.Size(699, 406)
        Me.fingerPanel.TabIndex = 7
        '
        'panel1
        '
        Me.panel1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.panel1.Controls.Add(Me.ToolStripStatusFingerCountLabel)
        Me.panel1.Controls.Add(Me.ToolStripStatusConfidenceBitsEnabledLabel)
        Me.panel1.Controls.Add(Me.ToolStripStatusUserDataLabel)
        Me.panel1.Controls.Add(Me.ToolStripStatusClientModeLabel)
        Me.panel1.Location = New System.Drawing.Point(4, 6)
        Me.panel1.Name = "panel1"
        Me.panel1.Size = New System.Drawing.Size(496, 28)
        Me.panel1.TabIndex = 6
        '
        'ToolStripStatusFingerCountLabel
        '
        Me.ToolStripStatusFingerCountLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.ToolStripStatusFingerCountLabel.Location = New System.Drawing.Point(410, 3)
        Me.ToolStripStatusFingerCountLabel.Margin = New System.Windows.Forms.Padding(3)
        Me.ToolStripStatusFingerCountLabel.Name = "ToolStripStatusFingerCountLabel"
        Me.ToolStripStatusFingerCountLabel.Padding = New System.Windows.Forms.Padding(2)
        Me.ToolStripStatusFingerCountLabel.Size = New System.Drawing.Size(80, 20)
        Me.ToolStripStatusFingerCountLabel.TabIndex = 3
        Me.ToolStripStatusFingerCountLabel.Text = "#fingers:"
        Me.ToolStripStatusFingerCountLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'ToolStripStatusConfidenceBitsEnabledLabel
        '
        Me.ToolStripStatusConfidenceBitsEnabledLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.ToolStripStatusConfidenceBitsEnabledLabel.Location = New System.Drawing.Point(90, 3)
        Me.ToolStripStatusConfidenceBitsEnabledLabel.Margin = New System.Windows.Forms.Padding(3)
        Me.ToolStripStatusConfidenceBitsEnabledLabel.Name = "ToolStripStatusConfidenceBitsEnabledLabel"
        Me.ToolStripStatusConfidenceBitsEnabledLabel.Padding = New System.Windows.Forms.Padding(2)
        Me.ToolStripStatusConfidenceBitsEnabledLabel.Size = New System.Drawing.Size(108, 20)
        Me.ToolStripStatusConfidenceBitsEnabledLabel.TabIndex = 2
        Me.ToolStripStatusConfidenceBitsEnabledLabel.Text = "Conf Bits Enabled"
        Me.ToolStripStatusConfidenceBitsEnabledLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'ToolStripStatusUserDataLabel
        '
        Me.ToolStripStatusUserDataLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.ToolStripStatusUserDataLabel.Location = New System.Drawing.Point(204, 3)
        Me.ToolStripStatusUserDataLabel.Margin = New System.Windows.Forms.Padding(3)
        Me.ToolStripStatusUserDataLabel.Name = "ToolStripStatusUserDataLabel"
        Me.ToolStripStatusUserDataLabel.Padding = New System.Windows.Forms.Padding(2)
        Me.ToolStripStatusUserDataLabel.Size = New System.Drawing.Size(200, 20)
        Me.ToolStripStatusUserDataLabel.TabIndex = 1
        '
        'ToolStripStatusClientModeLabel
        '
        Me.ToolStripStatusClientModeLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.ToolStripStatusClientModeLabel.Location = New System.Drawing.Point(3, 3)
        Me.ToolStripStatusClientModeLabel.Margin = New System.Windows.Forms.Padding(3)
        Me.ToolStripStatusClientModeLabel.Name = "ToolStripStatusClientModeLabel"
        Me.ToolStripStatusClientModeLabel.Padding = New System.Windows.Forms.Padding(2)
        Me.ToolStripStatusClientModeLabel.Size = New System.Drawing.Size(80, 20)
        Me.ToolStripStatusClientModeLabel.TabIndex = 0
        Me.ToolStripStatusClientModeLabel.Text = "Consumer"
        Me.ToolStripStatusClientModeLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'frmSignaPad
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.LightSteelBlue
        Me.ClientSize = New System.Drawing.Size(845, 452)
        Me.Controls.Add(Me.functionPanel)
        Me.Controls.Add(Me.fingerPanel)
        Me.Controls.Add(Me.panel1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmSignaPad"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = " Signature Pad Settings"
        Me.functionPanel.ResumeLayout(False)
        Me.ConfidenceBitsEnabledGroupBox.ResumeLayout(False)
        Me.ConfidenceBitsEnabledGroupBox.PerformLayout()
        Me.FingerDataFromGroupBox.ResumeLayout(False)
        Me.ClientModeGroupBox.ResumeLayout(False)
        Me.panel1.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Private WithEvents functionPanel As System.Windows.Forms.Panel
    Private WithEvents ConfidenceBitsEnabledGroupBox As System.Windows.Forms.GroupBox
    Private WithEvents ConfidenceBitsDisabledRadioButton As System.Windows.Forms.RadioButton
    Private WithEvents ConfidenceBitsEnabledRadioButton As System.Windows.Forms.RadioButton
    Private WithEvents FingerDataFromGroupBox As System.Windows.Forms.GroupBox
    Private WithEvents FingerDataFromEventRadioButton As System.Windows.Forms.RadioButton
    Private WithEvents FingerDataFromHitRectRadioButton As System.Windows.Forms.RadioButton
    Private WithEvents DeviceIDSelectLabel As System.Windows.Forms.Label
    Private WithEvents DeviceIDComboBox As System.Windows.Forms.ComboBox
    Private WithEvents ClientModeGroupBox As System.Windows.Forms.GroupBox
    Private WithEvents ClientModeObserverRadioButton As System.Windows.Forms.RadioButton
    Private WithEvents ClientModeConsumerRadioButton As System.Windows.Forms.RadioButton
    Private WithEvents DeviceIDCapabilitiesFormButton As System.Windows.Forms.Button
    Private WithEvents mClearButton As System.Windows.Forms.Button
    Private WithEvents fingerPanel As System.Windows.Forms.Panel
    Private WithEvents panel1 As System.Windows.Forms.Panel
    Private WithEvents ToolStripStatusFingerCountLabel As System.Windows.Forms.Label
    Private WithEvents ToolStripStatusConfidenceBitsEnabledLabel As System.Windows.Forms.Label
    Private WithEvents ToolStripStatusUserDataLabel As System.Windows.Forms.Label
    Private WithEvents ToolStripStatusClientModeLabel As System.Windows.Forms.Label
End Class
