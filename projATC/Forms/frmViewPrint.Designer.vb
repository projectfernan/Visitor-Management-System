<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmViewPrint
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmViewPrint))
        Me.crtPreview = New CrystalDecisions.Windows.Forms.CrystalReportViewer
        Me.SuspendLayout()
        '
        'crtPreview
        '
        Me.crtPreview.ActiveViewIndex = -1
        Me.crtPreview.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.crtPreview.Dock = System.Windows.Forms.DockStyle.Fill
        Me.crtPreview.Location = New System.Drawing.Point(0, 0)
        Me.crtPreview.Name = "crtPreview"
        Me.crtPreview.SelectionFormula = ""
        Me.crtPreview.Size = New System.Drawing.Size(838, 488)
        Me.crtPreview.TabIndex = 0
        Me.crtPreview.ViewTimeSelectionFormula = ""
        '
        'frmViewPrint
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(838, 488)
        Me.Controls.Add(Me.crtPreview)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frmViewPrint"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = " Print Visitor Logs Report"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents crtPreview As CrystalDecisions.Windows.Forms.CrystalReportViewer
End Class
