<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class DevsCapForm
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(DevsCapForm))
        Me.DevCapsLabel = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'DevCapsLabel
        '
        Me.DevCapsLabel.Font = New System.Drawing.Font("Courier New", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DevCapsLabel.Location = New System.Drawing.Point(9, 9)
        Me.DevCapsLabel.Name = "DevCapsLabel"
        Me.DevCapsLabel.Size = New System.Drawing.Size(555, 338)
        Me.DevCapsLabel.TabIndex = 2
        Me.DevCapsLabel.Text = "label1"
        '
        'DevsCapForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(575, 359)
        Me.Controls.Add(Me.DevCapsLabel)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "DevsCapForm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = " Device Capabilities"
        Me.ResumeLayout(False)

    End Sub
    Private WithEvents DevCapsLabel As System.Windows.Forms.Label
End Class
