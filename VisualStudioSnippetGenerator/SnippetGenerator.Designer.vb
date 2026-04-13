<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class SnippetGenerator
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(SnippetGenerator))
        Me.SnippetText = New System.Windows.Forms.TextBox()
        Me.Title = New System.Windows.Forms.TextBox()
        Me.LiteralId = New System.Windows.Forms.TextBox()
        Me.LiteralToolTip = New System.Windows.Forms.TextBox()
        Me.DefaultValue = New System.Windows.Forms.TextBox()
        Me.Code = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Author = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.ShortCut = New System.Windows.Forms.TextBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Description = New System.Windows.Forms.TextBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.CodeLanguage = New System.Windows.Forms.DomainUpDown()
        Me.MyToolTip = New System.Windows.Forms.TextBox()
        Me.SnippetType = New System.Windows.Forms.DomainUpDown()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.FolderBrowserDialog1 = New System.Windows.Forms.FolderBrowserDialog()
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.Button2 = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'SnippetText
        '
        Me.SnippetText.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.SnippetText.BackColor = System.Drawing.SystemColors.WindowText
        Me.SnippetText.Font = New System.Drawing.Font("Modern No. 20", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.SnippetText.ForeColor = System.Drawing.Color.DarkOrange
        Me.SnippetText.Location = New System.Drawing.Point(13, 6)
        Me.SnippetText.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.SnippetText.Multiline = True
        Me.SnippetText.Name = "SnippetText"
        Me.SnippetText.ReadOnly = True
        Me.SnippetText.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.SnippetText.Size = New System.Drawing.Size(577, 504)
        Me.SnippetText.TabIndex = 0
        Me.SnippetText.Text = resources.GetString("SnippetText.Text")
        Me.ToolTip1.SetToolTip(Me.SnippetText, "The Snippet to be created")
        '
        'Title
        '
        Me.Title.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Title.Location = New System.Drawing.Point(622, 11)
        Me.Title.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.Title.Name = "Title"
        Me.Title.Size = New System.Drawing.Size(116, 21)
        Me.Title.TabIndex = 1
        Me.ToolTip1.SetToolTip(Me.Title, "Title of the snippet")
        '
        'LiteralId
        '
        Me.LiteralId.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.LiteralId.Location = New System.Drawing.Point(622, 165)
        Me.LiteralId.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.LiteralId.Name = "LiteralId"
        Me.LiteralId.Size = New System.Drawing.Size(116, 21)
        Me.LiteralId.TabIndex = 2
        Me.LiteralId.Text = "href"
        Me.ToolTip1.SetToolTip(Me.LiteralId, "Literal variable id")
        '
        'LiteralToolTip
        '
        Me.LiteralToolTip.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.LiteralToolTip.Location = New System.Drawing.Point(622, 195)
        Me.LiteralToolTip.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.LiteralToolTip.Name = "LiteralToolTip"
        Me.LiteralToolTip.Size = New System.Drawing.Size(116, 21)
        Me.LiteralToolTip.TabIndex = 3
        Me.LiteralToolTip.Text = "href"
        Me.ToolTip1.SetToolTip(Me.LiteralToolTip, "Literal's Tool tip to display")
        '
        'DefaultValue
        '
        Me.DefaultValue.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.DefaultValue.Location = New System.Drawing.Point(622, 225)
        Me.DefaultValue.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.DefaultValue.Name = "DefaultValue"
        Me.DefaultValue.Size = New System.Drawing.Size(116, 21)
        Me.DefaultValue.TabIndex = 4
        Me.DefaultValue.Text = "#"
        Me.ToolTip1.SetToolTip(Me.DefaultValue, "Default value for the Literal")
        '
        'Code
        '
        Me.Code.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Code.Location = New System.Drawing.Point(622, 285)
        Me.Code.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.Code.Multiline = True
        Me.Code.Name = "Code"
        Me.Code.Size = New System.Drawing.Size(276, 219)
        Me.Code.TabIndex = 6
        Me.ToolTip1.SetToolTip(Me.Code, "The code block. Enter your code exactly" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "how you want it inserted into Visual Stu" &
        "dio")
        '
        'Label1
        '
        Me.Label1.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label1.AutoSize = True
        Me.Label1.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Label1.Location = New System.Drawing.Point(746, 14)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(32, 15)
        Me.Label1.TabIndex = 7
        Me.Label1.Text = "Title"
        '
        'Label2
        '
        Me.Label2.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label2.AutoSize = True
        Me.Label2.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Label2.Location = New System.Drawing.Point(746, 168)
        Me.Label2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(58, 15)
        Me.Label2.TabIndex = 8
        Me.Label2.Text = "Literal id"
        '
        'Label3
        '
        Me.Label3.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label3.AutoSize = True
        Me.Label3.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Label3.Location = New System.Drawing.Point(746, 198)
        Me.Label3.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(86, 15)
        Me.Label3.TabIndex = 9
        Me.Label3.Text = "Literal-tool tip"
        '
        'Label4
        '
        Me.Label4.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label4.AutoSize = True
        Me.Label4.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Label4.Location = New System.Drawing.Point(746, 228)
        Me.Label4.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(44, 15)
        Me.Label4.TabIndex = 10
        Me.Label4.Text = "default"
        '
        'Label5
        '
        Me.Label5.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label5.AutoSize = True
        Me.Label5.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Label5.Location = New System.Drawing.Point(746, 258)
        Me.Label5.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(87, 15)
        Me.Label5.TabIndex = 11
        Me.Label5.Text = "Code Language"
        '
        'Label6
        '
        Me.Label6.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label6.AutoSize = True
        Me.Label6.BackColor = System.Drawing.SystemColors.WindowText
        Me.Label6.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Label6.ForeColor = System.Drawing.Color.Lime
        Me.Label6.Location = New System.Drawing.Point(866, 286)
        Me.Label6.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(31, 15)
        Me.Label6.TabIndex = 12
        Me.Label6.Text = "Code"
        Me.ToolTip1.SetToolTip(Me.Label6, "Click me to Show help." & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "The code block. Enter your code exactly" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "how you want it " &
        "inserted into Visual Studio")
        '
        'Label7
        '
        Me.Label7.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label7.AutoSize = True
        Me.Label7.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Label7.Location = New System.Drawing.Point(746, 44)
        Me.Label7.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(45, 15)
        Me.Label7.TabIndex = 14
        Me.Label7.Text = "Author"
        '
        'Author
        '
        Me.Author.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Author.Location = New System.Drawing.Point(622, 41)
        Me.Author.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.Author.Name = "Author"
        Me.Author.Size = New System.Drawing.Size(116, 21)
        Me.Author.TabIndex = 13
        Me.ToolTip1.SetToolTip(Me.Author, "Author")
        '
        'Label8
        '
        Me.Label8.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label8.AutoSize = True
        Me.Label8.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Label8.Location = New System.Drawing.Point(746, 74)
        Me.Label8.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(48, 15)
        Me.Label8.TabIndex = 16
        Me.Label8.Text = "Shorcut"
        '
        'ShortCut
        '
        Me.ShortCut.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.ShortCut.Location = New System.Drawing.Point(622, 71)
        Me.ShortCut.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.ShortCut.Name = "ShortCut"
        Me.ShortCut.Size = New System.Drawing.Size(116, 21)
        Me.ShortCut.TabIndex = 15
        Me.ToolTip1.SetToolTip(Me.ShortCut, "Shortcut for inserting snippet")
        '
        'Label9
        '
        Me.Label9.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label9.AutoSize = True
        Me.Label9.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Label9.Location = New System.Drawing.Point(746, 104)
        Me.Label9.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(67, 15)
        Me.Label9.TabIndex = 18
        Me.Label9.Text = "Description"
        '
        'Description
        '
        Me.Description.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Description.Location = New System.Drawing.Point(622, 101)
        Me.Description.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.Description.Name = "Description"
        Me.Description.Size = New System.Drawing.Size(116, 21)
        Me.Description.TabIndex = 17
        Me.ToolTip1.SetToolTip(Me.Description, "Code Snippet Description")
        '
        'Label10
        '
        Me.Label10.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label10.AutoSize = True
        Me.Label10.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Label10.Location = New System.Drawing.Point(746, 134)
        Me.Label10.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(75, 15)
        Me.Label10.TabIndex = 20
        Me.Label10.Text = "Snippet Type"
        '
        'CodeLanguage
        '
        Me.CodeLanguage.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.CodeLanguage.Items.Add("HTML")
        Me.CodeLanguage.Items.Add("CSharp")
        Me.CodeLanguage.Items.Add("VB")
        Me.CodeLanguage.Items.Add("CPP")
        Me.CodeLanguage.Items.Add("XAML")
        Me.CodeLanguage.Items.Add("XML")
        Me.CodeLanguage.Items.Add("JavaScript")
        Me.CodeLanguage.Items.Add("TypeScript")
        Me.CodeLanguage.Items.Add("SQL")
        Me.CodeLanguage.Location = New System.Drawing.Point(622, 255)
        Me.CodeLanguage.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.CodeLanguage.Name = "CodeLanguage"
        Me.CodeLanguage.Size = New System.Drawing.Size(117, 21)
        Me.CodeLanguage.TabIndex = 21
        Me.CodeLanguage.Text = "HTML"
        Me.ToolTip1.SetToolTip(Me.CodeLanguage, "Code Snippet Language type")
        Me.CodeLanguage.UpDownAlign = System.Windows.Forms.LeftRightAlignment.Left
        '
        'MyToolTip
        '
        Me.MyToolTip.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.MyToolTip.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.MyToolTip.Cursor = System.Windows.Forms.Cursors.Hand
        Me.MyToolTip.ForeColor = System.Drawing.Color.Lime
        Me.MyToolTip.Location = New System.Drawing.Point(176, 38)
        Me.MyToolTip.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.MyToolTip.MaximumSize = New System.Drawing.Size(558, 444)
        Me.MyToolTip.MinimumSize = New System.Drawing.Size(558, 444)
        Me.MyToolTip.Multiline = True
        Me.MyToolTip.Name = "MyToolTip"
        Me.MyToolTip.ReadOnly = True
        Me.MyToolTip.Size = New System.Drawing.Size(558, 444)
        Me.MyToolTip.TabIndex = 22
        Me.MyToolTip.Text = resources.GetString("MyToolTip.Text")
        Me.ToolTip1.SetToolTip(Me.MyToolTip, "Click Me to Close")
        Me.MyToolTip.Visible = False
        '
        'SnippetType
        '
        Me.SnippetType.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.SnippetType.Items.Add("Expansion")
        Me.SnippetType.Items.Add("SurroundsWith")
        Me.SnippetType.Location = New System.Drawing.Point(622, 131)
        Me.SnippetType.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.SnippetType.Name = "SnippetType"
        Me.SnippetType.ReadOnly = True
        Me.SnippetType.Size = New System.Drawing.Size(117, 21)
        Me.SnippetType.TabIndex = 23
        Me.SnippetType.Text = "Expansion"
        Me.ToolTip1.SetToolTip(Me.SnippetType, "Snippet type")
        Me.SnippetType.UpDownAlign = System.Windows.Forms.LeftRightAlignment.Left
        '
        'Button1
        '
        Me.Button1.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Button1.BackColor = System.Drawing.Color.DimGray
        Me.Button1.BackgroundImage = CType(resources.GetObject("Button1.BackgroundImage"), System.Drawing.Image)
        Me.Button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.Button1.FlatAppearance.BorderColor = System.Drawing.SystemColors.ActiveCaption
        Me.Button1.FlatAppearance.BorderSize = 0
        Me.Button1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button1.Location = New System.Drawing.Point(818, 5)
        Me.Button1.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(88, 90)
        Me.Button1.TabIndex = 24
        Me.ToolTip1.SetToolTip(Me.Button1, "Save File")
        Me.Button1.UseVisualStyleBackColor = False
        '
        'FolderBrowserDialog1
        '
        '
        'Button2
        '
        Me.Button2.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Button2.BackgroundImage = CType(resources.GetObject("Button2.BackgroundImage"), System.Drawing.Image)
        Me.Button2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Button2.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Button2.FlatAppearance.BorderSize = 0
        Me.Button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button2.Location = New System.Drawing.Point(864, 106)
        Me.Button2.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(31, 27)
        Me.Button2.TabIndex = 25
        Me.ToolTip1.SetToolTip(Me.Button2, "Show Help")
        Me.Button2.UseVisualStyleBackColor = True
        '
        'SnippetGenerator
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.DimGray
        Me.ClientSize = New System.Drawing.Size(911, 520)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.MyToolTip)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.SnippetType)
        Me.Controls.Add(Me.CodeLanguage)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.Description)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.ShortCut)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Author)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Code)
        Me.Controls.Add(Me.DefaultValue)
        Me.Controls.Add(Me.LiteralToolTip)
        Me.Controls.Add(Me.LiteralId)
        Me.Controls.Add(Me.Title)
        Me.Controls.Add(Me.SnippetText)
        Me.Font = New System.Drawing.Font("Modern No. 20", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ForeColor = System.Drawing.Color.Aqua
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.Name = "SnippetGenerator"
        Me.Text = "Visual Studio Snippet Generator"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents SnippetText As TextBox
    Friend WithEvents Title As TextBox
    Friend WithEvents LiteralId As TextBox
    Friend WithEvents LiteralToolTip As TextBox
    Friend WithEvents DefaultValue As TextBox
    Friend WithEvents Code As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Author As TextBox
    Friend WithEvents Label8 As Label
    Friend WithEvents ShortCut As TextBox
    Friend WithEvents Label9 As Label
    Friend WithEvents Description As TextBox
    Friend WithEvents Label10 As Label
    Friend WithEvents CodeLanguage As DomainUpDown
    Friend WithEvents MyToolTip As TextBox
    Friend WithEvents SnippetType As DomainUpDown
    Friend WithEvents Button1 As Button
    Friend WithEvents FolderBrowserDialog1 As FolderBrowserDialog
    Friend WithEvents ToolTip1 As ToolTip
    Friend WithEvents Button2 As Button
End Class
