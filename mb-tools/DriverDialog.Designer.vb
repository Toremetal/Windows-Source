<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class DriverDialog
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(DriverDialog))
        Me.DriverTools = New System.Windows.Forms.GroupBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Button4 = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.DriverFolder = New System.Windows.Forms.TextBox()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.InstallDrivers = New System.Windows.Forms.CheckBox()
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.Label1 = New System.Windows.Forms.Label()
        Me.DriverTools.SuspendLayout()
        Me.SuspendLayout()
        '
        'DriverTools
        '
        Me.DriverTools.BackColor = System.Drawing.SystemColors.ControlLight
        Me.DriverTools.Controls.Add(Me.Label1)
        Me.DriverTools.Controls.Add(Me.Label3)
        Me.DriverTools.Controls.Add(Me.Button4)
        Me.DriverTools.Controls.Add(Me.Label2)
        Me.DriverTools.Controls.Add(Me.DriverFolder)
        Me.DriverTools.Controls.Add(Me.Button3)
        Me.DriverTools.Controls.Add(Me.InstallDrivers)
        Me.DriverTools.Dock = System.Windows.Forms.DockStyle.Fill
        Me.DriverTools.Location = New System.Drawing.Point(0, 0)
        Me.DriverTools.Margin = New System.Windows.Forms.Padding(5, 6, 5, 6)
        Me.DriverTools.Name = "DriverTools"
        Me.DriverTools.Padding = New System.Windows.Forms.Padding(5, 6, 5, 6)
        Me.DriverTools.Size = New System.Drawing.Size(419, 144)
        Me.DriverTools.TabIndex = 32
        Me.DriverTools.TabStop = False
        Me.DriverTools.Text = "Driver Tools"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.ForeColor = System.Drawing.SystemColors.HotTrack
        Me.Label3.Location = New System.Drawing.Point(66, 23)
        Me.Label3.Margin = New System.Windows.Forms.Padding(5, 0, 5, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(286, 15)
        Me.Label3.TabIndex = 33
        Me.Label3.Text = "Install Drivers in or Export Drivers from the Mounted Image"
        '
        'Button4
        '
        Me.Button4.Enabled = False
        Me.Button4.Location = New System.Drawing.Point(268, 45)
        Me.Button4.Margin = New System.Windows.Forms.Padding(5, 6, 5, 6)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(112, 28)
        Me.Button4.TabIndex = 34
        Me.Button4.Text = "Running System"
        Me.ToolTip1.SetToolTip(Me.Button4, "  Export Drivers from the current operating system")
        Me.Button4.UseVisualStyleBackColor = True
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(13, 86)
        Me.Label2.Margin = New System.Windows.Forms.Padding(5, 0, 5, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(336, 15)
        Me.Label2.TabIndex = 32
        Me.Label2.Text = "Drivers Install from/Export to Folder (If Blank: Desktop\OEM-Drivers)"
        Me.ToolTip1.SetToolTip(Me.Label2, "Click Me to Select Folder")
        '
        'DriverFolder
        '
        Me.DriverFolder.Cursor = System.Windows.Forms.Cursors.Hand
        Me.DriverFolder.Location = New System.Drawing.Point(10, 103)
        Me.DriverFolder.Margin = New System.Windows.Forms.Padding(5, 6, 5, 6)
        Me.DriverFolder.Name = "DriverFolder"
        Me.DriverFolder.ReadOnly = True
        Me.DriverFolder.Size = New System.Drawing.Size(399, 22)
        Me.DriverFolder.TabIndex = 31
        Me.ToolTip1.SetToolTip(Me.DriverFolder, "Click Me to Select Folder")
        '
        'Button3
        '
        Me.Button3.Enabled = False
        Me.Button3.Location = New System.Drawing.Point(111, 45)
        Me.Button3.Margin = New System.Windows.Forms.Padding(5, 6, 5, 6)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(135, 28)
        Me.Button3.TabIndex = 29
        Me.Button3.Text = "Export/Install Drivers"
        Me.ToolTip1.SetToolTip(Me.Button3, "Export or Install drivers on the Servicing Image")
        Me.Button3.UseVisualStyleBackColor = True
        '
        'InstallDrivers
        '
        Me.InstallDrivers.AutoSize = True
        Me.InstallDrivers.Location = New System.Drawing.Point(38, 49)
        Me.InstallDrivers.Margin = New System.Windows.Forms.Padding(5, 6, 5, 6)
        Me.InstallDrivers.Name = "InstallDrivers"
        Me.InstallDrivers.Size = New System.Drawing.Size(54, 19)
        Me.InstallDrivers.TabIndex = 30
        Me.InstallDrivers.Text = "Install"
        Me.ToolTip1.SetToolTip(Me.InstallDrivers, "Checked to Install Un-Checked to Export")
        Me.InstallDrivers.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Tempus Sans ITC", 6.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(121, 132)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(176, 11)
        Me.Label1.TabIndex = 33
        Me.Label1.Text = "Keep this Window Open Until the Task Completes"
        '
        'DriverDialog
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(419, 144)
        Me.Controls.Add(Me.DriverTools)
        Me.Font = New System.Drawing.Font("Tempus Sans ITC", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "DriverDialog"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "™T©ReMeTaL - ™MB-To©lB©x"
        Me.DriverTools.ResumeLayout(False)
        Me.DriverTools.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents DriverTools As GroupBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Button4 As Button
    Friend WithEvents Label2 As Label
    Friend WithEvents DriverFolder As TextBox
    Friend WithEvents Button3 As Button
    Friend WithEvents InstallDrivers As CheckBox
    Friend WithEvents ToolTip1 As ToolTip
    Friend WithEvents Label1 As Label
End Class
