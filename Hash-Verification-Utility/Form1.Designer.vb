<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.OpenFileDialog1 = New System.Windows.Forms.OpenFileDialog()
        Me.TextBox2 = New System.Windows.Forms.TextBox()
        Me.DomainUpDown1 = New System.Windows.Forms.DomainUpDown()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.LabelNotSafe = New System.Windows.Forms.Label()
        Me.LabelSafe = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(12, 18)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(406, 20)
        Me.TextBox1.TabIndex = 0
        Me.TextBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Button1
        '
        Me.Button1.Enabled = False
        Me.Button1.Location = New System.Drawing.Point(300, 80)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(82, 23)
        Me.Button1.TabIndex = 1
        Me.Button1.Text = "Select File"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'OpenFileDialog1
        '
        Me.OpenFileDialog1.InitialDirectory = "%UserProfile%\Downloads"
        '
        'TextBox2
        '
        Me.TextBox2.Location = New System.Drawing.Point(12, 57)
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.ReadOnly = True
        Me.TextBox2.Size = New System.Drawing.Size(406, 20)
        Me.TextBox2.TabIndex = 2
        Me.TextBox2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'DomainUpDown1
        '
        Me.DomainUpDown1.Items.Add("SHA256")
        Me.DomainUpDown1.Items.Add("MD5")
        Me.DomainUpDown1.Items.Add("SHA1")
        Me.DomainUpDown1.Location = New System.Drawing.Point(132, 83)
        Me.DomainUpDown1.Name = "DomainUpDown1"
        Me.DomainUpDown1.Size = New System.Drawing.Size(87, 20)
        Me.DomainUpDown1.TabIndex = 3
        Me.DomainUpDown1.Text = "SHA256"
        Me.DomainUpDown1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.DomainUpDown1.UpDownAlign = System.Windows.Forms.LeftRightAlignment.Left
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(48, 86)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(78, 13)
        Me.Label1.TabIndex = 4
        Me.Label1.Text = "Hash Algorithm"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(21, 42)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(118, 13)
        Me.Label2.TabIndex = 5
        Me.Label2.Text = "Generated Hash Result"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(21, 3)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(115, 13)
        Me.Label3.TabIndex = 6
        Me.Label3.Text = "Enter Verification Hash"
        '
        'LabelNotSafe
        '
        Me.LabelNotSafe.AutoSize = True
        Me.LabelNotSafe.ForeColor = System.Drawing.Color.Red
        Me.LabelNotSafe.Location = New System.Drawing.Point(115, 112)
        Me.LabelNotSafe.Name = "LabelNotSafe"
        Me.LabelNotSafe.Size = New System.Drawing.Size(200, 26)
        Me.LabelNotSafe.TabIndex = 7
        Me.LabelNotSafe.Text = "   Hashes DO NOT MATCH: WARNING!" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "File May be Compromised and NOT Safe"
        Me.LabelNotSafe.Visible = False
        '
        'LabelSafe
        '
        Me.LabelSafe.AutoSize = True
        Me.LabelSafe.ForeColor = System.Drawing.Color.Green
        Me.LabelSafe.Location = New System.Drawing.Point(110, 113)
        Me.LabelSafe.Name = "LabelSafe"
        Me.LabelSafe.Size = New System.Drawing.Size(211, 13)
        Me.LabelSafe.TabIndex = 8
        Me.LabelSafe.Text = "Hashes Match: File has not been changed."
        Me.LabelSafe.Visible = False
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(430, 159)
        Me.Controls.Add(Me.LabelSafe)
        Me.Controls.Add(Me.LabelNotSafe)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.DomainUpDown1)
        Me.Controls.Add(Me.TextBox2)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.TextBox1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "Form1"
        Me.Text = "File Hash Verification"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents Button1 As Button
    Friend WithEvents OpenFileDialog1 As OpenFileDialog
    Friend WithEvents TextBox2 As TextBox
    Friend WithEvents DomainUpDown1 As DomainUpDown
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents LabelNotSafe As Label
    Friend WithEvents LabelSafe As Label
End Class
