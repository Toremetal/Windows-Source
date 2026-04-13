<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class DialogWimInfo
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(DialogWimInfo))
        Me.DialogWimInfo_TextBox = New System.Windows.Forms.TextBox()
        Me.SuspendLayout()
        '
        'DialogWimInfo_TextBox
        '
        Me.DialogWimInfo_TextBox.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.DialogWimInfo_TextBox.Cursor = System.Windows.Forms.Cursors.Default
        Me.DialogWimInfo_TextBox.Dock = System.Windows.Forms.DockStyle.Fill
        Me.DialogWimInfo_TextBox.Enabled = False
        Me.DialogWimInfo_TextBox.Location = New System.Drawing.Point(0, 0)
        Me.DialogWimInfo_TextBox.Multiline = True
        Me.DialogWimInfo_TextBox.Name = "DialogWimInfo_TextBox"
        Me.DialogWimInfo_TextBox.ReadOnly = True
        Me.DialogWimInfo_TextBox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.DialogWimInfo_TextBox.Size = New System.Drawing.Size(573, 431)
        Me.DialogWimInfo_TextBox.TabIndex = 1
        Me.DialogWimInfo_TextBox.WordWrap = False
        '
        'DialogWimInfo
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoScroll = True
        Me.ClientSize = New System.Drawing.Size(573, 431)
        Me.Controls.Add(Me.DialogWimInfo_TextBox)
        Me.ForeColor = System.Drawing.SystemColors.ControlText
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "DialogWimInfo"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "™T©ReMeTaL - ™MB-To©lB©x  (*.wim -Info)"
        Me.TopMost = True
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents DialogWimInfo_TextBox As TextBox
End Class
