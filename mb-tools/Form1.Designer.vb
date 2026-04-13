<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.FolderBrowserDialog1 = New System.Windows.Forms.FolderBrowserDialog()
        Me.OpenFileDialog1 = New System.Windows.Forms.OpenFileDialog()
        Me.Label_WimFile = New System.Windows.Forms.Label()
        Me.Label_Index = New System.Windows.Forms.Label()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.Button8 = New System.Windows.Forms.Button()
        Me.CheckBox1 = New System.Windows.Forms.CheckBox()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Button5 = New System.Windows.Forms.Button()
        Me.Button7 = New System.Windows.Forms.Button()
        Me.AttachVhdBtn = New System.Windows.Forms.Button()
        Me.SizeMB = New System.Windows.Forms.TextBox()
        Me.SizeGB = New System.Windows.Forms.TextBox()
        Me.CreateVhdBtn = New System.Windows.Forms.Button()
        Me.VHD_file = New System.Windows.Forms.TextBox()
        Me.CommitChanges = New System.Windows.Forms.CheckBox()
        Me.Button10 = New System.Windows.Forms.Button()
        Me.Button13 = New System.Windows.Forms.Button()
        Me.Used_Drives = New System.Windows.Forms.DomainUpDown()
        Me.ReScanDrives = New System.Windows.Forms.Button()
        Me.ApplyMedia = New System.Windows.Forms.Button()
        Me.CI_CheckBox = New System.Windows.Forms.CheckBox()
        Me.VERIFY_CheckBox = New System.Windows.Forms.CheckBox()
        Me.CaptureImage = New System.Windows.Forms.Button()
        Me.InternalImageName = New System.Windows.Forms.TextBox()
        Me.EA_CheckBox = New System.Windows.Forms.CheckBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Button15 = New System.Windows.Forms.Button()
        Me.CmdsOutput = New System.Windows.Forms.TextBox()
        Me.RO_CheckBox = New System.Windows.Forms.CheckBox()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.Install_Image_OnDrive = New System.Windows.Forms.CheckBox()
        Me.Has_Boot_Sector = New System.Windows.Forms.CheckBox()
        Me.BootableTargetDrive = New System.Windows.Forms.DomainUpDown()
        Me.Button19 = New System.Windows.Forms.Button()
        Me.Wim_Path = New System.Windows.Forms.TextBox()
        Me.Sdi_Path = New System.Windows.Forms.TextBox()
        Me.CheckBox2 = New System.Windows.Forms.CheckBox()
        Me.MountFolder = New System.Windows.Forms.TextBox()
        Me.WimFile = New System.Windows.Forms.TextBox()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.BackgroundWorker1 = New System.ComponentModel.BackgroundWorker()
        Me.MountingStatus = New System.Windows.Forms.Label()
        Me.LastCmd = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.UnMountingStatus = New System.Windows.Forms.Label()
        Me.LabelDriverStatus = New System.Windows.Forms.Label()
        Me.VHDTOOLS = New System.Windows.Forms.GroupBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.CreateUSB_OS = New System.Windows.Forms.Button()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.DriveImagingTools = New System.Windows.Forms.GroupBox()
        Me.Selected_Index = New System.Windows.Forms.DomainUpDown()
        Me.VersionDetails = New System.Windows.Forms.TextBox()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.ProgressBar1 = New System.Windows.Forms.ProgressBar()
        Me.Timer2 = New System.Windows.Forms.Timer(Me.components)
        Me.Boot_Tools = New System.Windows.Forms.GroupBox()
        Me.OptionGroup = New System.Windows.Forms.GroupBox()
        Me.Label18 = New System.Windows.Forms.Label()
        Me.BootDetails = New System.Windows.Forms.Label()
        Me.Boot_Menu = New System.Windows.Forms.DomainUpDown()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.Button16 = New System.Windows.Forms.Button()
        Me.GroupBox4 = New System.Windows.Forms.GroupBox()
        Me.Button20 = New System.Windows.Forms.Button()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.Button18 = New System.Windows.Forms.Button()
        Me.BackgroundWorker2 = New System.ComponentModel.BackgroundWorker()
        Me.BackgroundWorker3 = New System.ComponentModel.BackgroundWorker()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.FileToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.NewToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SaveToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.toolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.OpenToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.toolStripSeparator = New System.Windows.Forms.ToolStripSeparator()
        Me.ExitToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator2 = New System.Windows.Forms.ToolStripSeparator()
        Me.ToolsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CustomizeToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.OptionsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.BootToolsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.VMVHDToolsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ScanToolsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ReScanForDrivesToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ReScanBootEntriesToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ReScanWimInfoToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.WinPEToolsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CreateOfflineScriptsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.toolStripSeparator5 = New System.Windows.Forms.ToolStripSeparator()
        Me.HelpToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AboutToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CheckForUpdatesToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.HelpOnlineToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.FeedbackToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator3 = New System.Windows.Forms.ToolStripSeparator()
        Me.CreateShortcutToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.DesktopLinkToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.StartMenuLinkToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SaveFileDialog1 = New System.Windows.Forms.SaveFileDialog()
        Me.GroupBox5 = New System.Windows.Forms.GroupBox()
        Me.WebBrowser1 = New System.Windows.Forms.WebBrowser()
        Me.Timer3 = New System.Windows.Forms.Timer(Me.components)
        Me.Timer4 = New System.Windows.Forms.Timer(Me.components)
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.VHDTOOLS.SuspendLayout()
        Me.DriveImagingTools.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.Boot_Tools.SuspendLayout()
        Me.OptionGroup.SuspendLayout()
        Me.GroupBox4.SuspendLayout()
        Me.MenuStrip1.SuspendLayout()
        Me.GroupBox5.SuspendLayout()
        Me.SuspendLayout()
        '
        'OpenFileDialog1
        '
        Me.OpenFileDialog1.Filter = "WIM FILES|*.wim|ESD Files|*.esd"
        '
        'Label_WimFile
        '
        Me.Label_WimFile.AutoSize = True
        Me.Label_WimFile.Location = New System.Drawing.Point(179, 72)
        Me.Label_WimFile.Margin = New System.Windows.Forms.Padding(5, 0, 5, 0)
        Me.Label_WimFile.Name = "Label_WimFile"
        Me.Label_WimFile.Size = New System.Drawing.Size(212, 15)
        Me.Label_WimFile.TabIndex = 1
        Me.Label_WimFile.Text = "Windows Image Media (*.wim,*.esd)"
        Me.ToolTip1.SetToolTip(Me.Label_WimFile, "Select the Windows Image Media to Install, Service, or Export")
        '
        'Label_Index
        '
        Me.Label_Index.AutoSize = True
        Me.Label_Index.Location = New System.Drawing.Point(691, 52)
        Me.Label_Index.Margin = New System.Windows.Forms.Padding(5, 0, 5, 0)
        Me.Label_Index.Name = "Label_Index"
        Me.Label_Index.Size = New System.Drawing.Size(49, 15)
        Me.Label_Index.TabIndex = 2
        Me.Label_Index.Text = "Index #"
        '
        'Button1
        '
        Me.Button1.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.Button1.BackColor = System.Drawing.Color.Transparent
        Me.Button1.BackgroundImage = CType(resources.GetObject("Button1.BackgroundImage"), System.Drawing.Image)
        Me.Button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.Button1.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Button1.Enabled = False
        Me.Button1.FlatAppearance.BorderSize = 0
        Me.Button1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button1.Location = New System.Drawing.Point(397, 2)
        Me.Button1.Margin = New System.Windows.Forms.Padding(5, 6, 5, 6)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(58, 51)
        Me.Button1.TabIndex = 22
        Me.ToolTip1.SetToolTip(Me.Button1, "Mount the selected" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Windows Installation Media #" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "in the Image Servicing Folder")
        Me.Button1.UseVisualStyleBackColor = False
        '
        'Button8
        '
        Me.Button8.BackColor = System.Drawing.SystemColors.ControlText
        Me.Button8.FlatAppearance.BorderColor = System.Drawing.Color.Red
        Me.Button8.FlatAppearance.BorderSize = 2
        Me.Button8.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button8.Font = New System.Drawing.Font("Lucida Console", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button8.ForeColor = System.Drawing.Color.Red
        Me.Button8.Location = New System.Drawing.Point(380, 7)
        Me.Button8.Margin = New System.Windows.Forms.Padding(5, 6, 5, 6)
        Me.Button8.Name = "Button8"
        Me.Button8.Size = New System.Drawing.Size(23, 24)
        Me.Button8.TabIndex = 36
        Me.Button8.Text = "X"
        Me.ToolTip1.SetToolTip(Me.Button8, "Close this tool window")
        Me.Button8.UseVisualStyleBackColor = False
        '
        'CheckBox1
        '
        Me.CheckBox1.AutoSize = True
        Me.CheckBox1.Location = New System.Drawing.Point(51, 48)
        Me.CheckBox1.Margin = New System.Windows.Forms.Padding(5, 6, 5, 6)
        Me.CheckBox1.Name = "CheckBox1"
        Me.CheckBox1.Size = New System.Drawing.Size(300, 19)
        Me.CheckBox1.TabIndex = 45
        Me.CheckBox1.Text = "Install Windows from the *.wim file and image #"
        Me.ToolTip1.SetToolTip(Me.CheckBox1, "Install the" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "'Windows Installation Media' 'Image #'" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "on this VHD and make it boot" &
        "able.")
        Me.CheckBox1.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Button2.BackColor = System.Drawing.Color.Transparent
        Me.Button2.BackgroundImage = CType(resources.GetObject("Button2.BackgroundImage"), System.Drawing.Image)
        Me.Button2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.Button2.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Button2.Enabled = False
        Me.Button2.FlatAppearance.BorderSize = 0
        Me.Button2.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button2.Location = New System.Drawing.Point(483, 2)
        Me.Button2.Margin = New System.Windows.Forms.Padding(5, 6, 5, 6)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(58, 51)
        Me.Button2.TabIndex = 26
        Me.ToolTip1.SetToolTip(Me.Button2, "Remove the image from the mount folder Check to Save, leave Un Checked to discard" &
        " changes")
        Me.Button2.UseVisualStyleBackColor = False
        '
        'Button5
        '
        Me.Button5.BackColor = System.Drawing.Color.Transparent
        Me.Button5.BackgroundImage = CType(resources.GetObject("Button5.BackgroundImage"), System.Drawing.Image)
        Me.Button5.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Button5.FlatAppearance.BorderSize = 0
        Me.Button5.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Button5.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button5.Location = New System.Drawing.Point(59, 10)
        Me.Button5.Margin = New System.Windows.Forms.Padding(5, 6, 5, 6)
        Me.Button5.Name = "Button5"
        Me.Button5.Size = New System.Drawing.Size(44, 44)
        Me.Button5.TabIndex = 35
        Me.ToolTip1.SetToolTip(Me.Button5, "Export or Install Windows Driver Files")
        Me.Button5.UseVisualStyleBackColor = False
        '
        'Button7
        '
        Me.Button7.BackColor = System.Drawing.Color.Transparent
        Me.Button7.BackgroundImage = CType(resources.GetObject("Button7.BackgroundImage"), System.Drawing.Image)
        Me.Button7.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.Button7.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Button7.FlatAppearance.BorderSize = 0
        Me.Button7.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Button7.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button7.Font = New System.Drawing.Font("Tempus Sans ITC", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button7.ForeColor = System.Drawing.Color.Crimson
        Me.Button7.Location = New System.Drawing.Point(12, 14)
        Me.Button7.Margin = New System.Windows.Forms.Padding(5, 6, 5, 6)
        Me.Button7.Name = "Button7"
        Me.Button7.Size = New System.Drawing.Size(41, 42)
        Me.Button7.TabIndex = 36
        Me.Button7.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.ToolTip1.SetToolTip(Me.Button7, "Create or Attach Virtual Hard Disks" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Create Virtual Hard drives and" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Install Wind" &
        "ows for Virtual Machines." & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10))
        Me.Button7.UseVisualStyleBackColor = False
        '
        'AttachVhdBtn
        '
        Me.AttachVhdBtn.Enabled = False
        Me.AttachVhdBtn.Location = New System.Drawing.Point(294, 68)
        Me.AttachVhdBtn.Margin = New System.Windows.Forms.Padding(5, 6, 5, 6)
        Me.AttachVhdBtn.Name = "AttachVhdBtn"
        Me.AttachVhdBtn.Size = New System.Drawing.Size(104, 24)
        Me.AttachVhdBtn.TabIndex = 40
        Me.AttachVhdBtn.Text = "Attach VHD"
        Me.ToolTip1.SetToolTip(Me.AttachVhdBtn, "Attach the selected VHD file")
        Me.AttachVhdBtn.UseVisualStyleBackColor = True
        '
        'SizeMB
        '
        Me.SizeMB.Location = New System.Drawing.Point(299, 22)
        Me.SizeMB.Margin = New System.Windows.Forms.Padding(5, 6, 5, 6)
        Me.SizeMB.Name = "SizeMB"
        Me.SizeMB.Size = New System.Drawing.Size(65, 22)
        Me.SizeMB.TabIndex = 41
        Me.ToolTip1.SetToolTip(Me.SizeMB, "Create VHD size in MegaBytes")
        '
        'SizeGB
        '
        Me.SizeGB.Location = New System.Drawing.Point(201, 22)
        Me.SizeGB.Margin = New System.Windows.Forms.Padding(5, 6, 5, 6)
        Me.SizeGB.Name = "SizeGB"
        Me.SizeGB.Size = New System.Drawing.Size(65, 22)
        Me.SizeGB.TabIndex = 43
        Me.ToolTip1.SetToolTip(Me.SizeGB, "Create VHD size in GigaBytes")
        '
        'CreateVhdBtn
        '
        Me.CreateVhdBtn.Enabled = False
        Me.CreateVhdBtn.Location = New System.Drawing.Point(17, 18)
        Me.CreateVhdBtn.Margin = New System.Windows.Forms.Padding(5, 6, 5, 6)
        Me.CreateVhdBtn.Name = "CreateVhdBtn"
        Me.CreateVhdBtn.Size = New System.Drawing.Size(124, 24)
        Me.CreateVhdBtn.TabIndex = 39
        Me.CreateVhdBtn.Text = "Create VHD/VM"
        Me.ToolTip1.SetToolTip(Me.CreateVhdBtn, "Create a VHD file, Check Install to install Windows from the wim file")
        Me.CreateVhdBtn.UseVisualStyleBackColor = True
        '
        'VHD_file
        '
        Me.VHD_file.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.VHD_file.Location = New System.Drawing.Point(5, 94)
        Me.VHD_file.Margin = New System.Windows.Forms.Padding(5, 6, 5, 6)
        Me.VHD_file.Name = "VHD_file"
        Me.VHD_file.ReadOnly = True
        Me.VHD_file.Size = New System.Drawing.Size(401, 22)
        Me.VHD_file.TabIndex = 37
        Me.ToolTip1.SetToolTip(Me.VHD_file, "The VHD file to create or attach")
        '
        'CommitChanges
        '
        Me.CommitChanges.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.CommitChanges.AutoSize = True
        Me.CommitChanges.Location = New System.Drawing.Point(576, 29)
        Me.CommitChanges.Margin = New System.Windows.Forms.Padding(5, 6, 5, 6)
        Me.CommitChanges.Name = "CommitChanges"
        Me.CommitChanges.Size = New System.Drawing.Size(122, 19)
        Me.CommitChanges.TabIndex = 28
        Me.CommitChanges.Text = "Commit Changes"
        Me.ToolTip1.SetToolTip(Me.CommitChanges, "If Checked Commit Changes to WIM file when Dismounting" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "If NOT Checked Discards a" &
        "ny modifications made to WIM file" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & " while mounted in the 'Media Servicing Folder" &
        "'.")
        Me.CommitChanges.UseVisualStyleBackColor = True
        '
        'Button10
        '
        Me.Button10.BackColor = System.Drawing.Color.Transparent
        Me.Button10.BackgroundImage = CType(resources.GetObject("Button10.BackgroundImage"), System.Drawing.Image)
        Me.Button10.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Button10.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Button10.Enabled = False
        Me.Button10.FlatAppearance.BorderSize = 0
        Me.Button10.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Button10.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button10.Location = New System.Drawing.Point(121, 48)
        Me.Button10.Margin = New System.Windows.Forms.Padding(5, 6, 5, 6)
        Me.Button10.Name = "Button10"
        Me.Button10.Size = New System.Drawing.Size(50, 40)
        Me.Button10.TabIndex = 46
        Me.ToolTip1.SetToolTip(Me.Button10, "Display Detailed Information about the images in the WIM file")
        Me.Button10.UseVisualStyleBackColor = False
        '
        'Button13
        '
        Me.Button13.BackgroundImage = CType(resources.GetObject("Button13.BackgroundImage"), System.Drawing.Image)
        Me.Button13.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Button13.FlatAppearance.BorderSize = 0
        Me.Button13.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Button13.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button13.Location = New System.Drawing.Point(8, 12)
        Me.Button13.Margin = New System.Windows.Forms.Padding(5, 6, 5, 6)
        Me.Button13.Name = "Button13"
        Me.Button13.Size = New System.Drawing.Size(40, 40)
        Me.Button13.TabIndex = 49
        Me.ToolTip1.SetToolTip(Me.Button13, "'Media Servicing Folder' Repair Tools" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "  For Fixing Mount/Dismount Errors")
        Me.Button13.UseVisualStyleBackColor = True
        '
        'Used_Drives
        '
        Me.Used_Drives.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Used_Drives.Location = New System.Drawing.Point(457, 59)
        Me.Used_Drives.Margin = New System.Windows.Forms.Padding(5, 6, 5, 6)
        Me.Used_Drives.Name = "Used_Drives"
        Me.Used_Drives.ReadOnly = True
        Me.Used_Drives.Size = New System.Drawing.Size(42, 20)
        Me.Used_Drives.TabIndex = 50
        Me.ToolTip1.SetToolTip(Me.Used_Drives, "Target Drive to [ Create ] Windows Image Media from" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Or [ Install ] Windows Image" &
        " Media to.")
        Me.Used_Drives.UpDownAlign = System.Windows.Forms.LeftRightAlignment.Left
        '
        'ReScanDrives
        '
        Me.ReScanDrives.BackColor = System.Drawing.Color.Transparent
        Me.ReScanDrives.BackgroundImage = CType(resources.GetObject("ReScanDrives.BackgroundImage"), System.Drawing.Image)
        Me.ReScanDrives.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ReScanDrives.Cursor = System.Windows.Forms.Cursors.Hand
        Me.ReScanDrives.FlatAppearance.BorderSize = 0
        Me.ReScanDrives.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.ReScanDrives.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.ReScanDrives.Location = New System.Drawing.Point(532, 51)
        Me.ReScanDrives.Margin = New System.Windows.Forms.Padding(5, 6, 5, 6)
        Me.ReScanDrives.Name = "ReScanDrives"
        Me.ReScanDrives.Size = New System.Drawing.Size(47, 46)
        Me.ReScanDrives.TabIndex = 51
        Me.ToolTip1.SetToolTip(Me.ReScanDrives, "ReScan for used Drive Letters and" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "RePopulate the Create/Install Drives Options" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) &
        "After Creating New Partitions or VHD's")
        Me.ReScanDrives.UseVisualStyleBackColor = False
        '
        'ApplyMedia
        '
        Me.ApplyMedia.BackColor = System.Drawing.Color.Transparent
        Me.ApplyMedia.BackgroundImage = CType(resources.GetObject("ApplyMedia.BackgroundImage"), System.Drawing.Image)
        Me.ApplyMedia.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.ApplyMedia.Cursor = System.Windows.Forms.Cursors.Hand
        Me.ApplyMedia.FlatAppearance.BorderSize = 0
        Me.ApplyMedia.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.ApplyMedia.Location = New System.Drawing.Point(385, 46)
        Me.ApplyMedia.Margin = New System.Windows.Forms.Padding(5, 6, 5, 6)
        Me.ApplyMedia.Name = "ApplyMedia"
        Me.ApplyMedia.Size = New System.Drawing.Size(47, 46)
        Me.ApplyMedia.TabIndex = 52
        Me.ToolTip1.SetToolTip(Me.ApplyMedia, "Install the selected Windows Image Media on the Selected Drive")
        Me.ApplyMedia.UseVisualStyleBackColor = False
        '
        'CI_CheckBox
        '
        Me.CI_CheckBox.AutoSize = True
        Me.CI_CheckBox.CheckAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.CI_CheckBox.Location = New System.Drawing.Point(200, 21)
        Me.CI_CheckBox.Margin = New System.Windows.Forms.Padding(5, 6, 5, 6)
        Me.CI_CheckBox.Name = "CI_CheckBox"
        Me.CI_CheckBox.Size = New System.Drawing.Size(114, 19)
        Me.CI_CheckBox.TabIndex = 53
        Me.CI_CheckBox.Text = "Check Integrity"
        Me.ToolTip1.SetToolTip(Me.CI_CheckBox, "Checks for Wim file Corruption when installing")
        Me.CI_CheckBox.UseVisualStyleBackColor = True
        '
        'VERIFY_CheckBox
        '
        Me.VERIFY_CheckBox.AutoSize = True
        Me.VERIFY_CheckBox.CheckAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.VERIFY_CheckBox.Location = New System.Drawing.Point(254, 44)
        Me.VERIFY_CheckBox.Margin = New System.Windows.Forms.Padding(5, 6, 5, 6)
        Me.VERIFY_CheckBox.Name = "VERIFY_CheckBox"
        Me.VERIFY_CheckBox.Size = New System.Drawing.Size(60, 19)
        Me.VERIFY_CheckBox.TabIndex = 54
        Me.VERIFY_CheckBox.Text = "Verify"
        Me.ToolTip1.SetToolTip(Me.VERIFY_CheckBox, "Checks for file Duplication and Errors")
        Me.VERIFY_CheckBox.UseVisualStyleBackColor = True
        '
        'CaptureImage
        '
        Me.CaptureImage.BackColor = System.Drawing.Color.Transparent
        Me.CaptureImage.BackgroundImage = CType(resources.GetObject("CaptureImage.BackgroundImage"), System.Drawing.Image)
        Me.CaptureImage.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.CaptureImage.Cursor = System.Windows.Forms.Cursors.Hand
        Me.CaptureImage.FlatAppearance.BorderSize = 0
        Me.CaptureImage.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.CaptureImage.Location = New System.Drawing.Point(324, 46)
        Me.CaptureImage.Margin = New System.Windows.Forms.Padding(5, 6, 5, 6)
        Me.CaptureImage.Name = "CaptureImage"
        Me.CaptureImage.Size = New System.Drawing.Size(47, 46)
        Me.CaptureImage.TabIndex = 55
        Me.ToolTip1.SetToolTip(Me.CaptureImage, "Capture the Selected Drive to the to the selected (Windows Image Media|*.wim) fil" &
        "e name")
        Me.CaptureImage.UseVisualStyleBackColor = False
        '
        'InternalImageName
        '
        Me.InternalImageName.Location = New System.Drawing.Point(14, 36)
        Me.InternalImageName.Margin = New System.Windows.Forms.Padding(5, 6, 5, 6)
        Me.InternalImageName.Name = "InternalImageName"
        Me.InternalImageName.Size = New System.Drawing.Size(172, 22)
        Me.InternalImageName.TabIndex = 56
        Me.InternalImageName.Text = "Windows10"
        Me.InternalImageName.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.ToolTip1.SetToolTip(Me.InternalImageName, "The Image Name inside the wim file." & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "The name and description are used" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "to distin" &
        "guish between different" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "images within the file." & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10))
        '
        'EA_CheckBox
        '
        Me.EA_CheckBox.AutoSize = True
        Me.EA_CheckBox.CheckAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.EA_CheckBox.Location = New System.Drawing.Point(131, 69)
        Me.EA_CheckBox.Margin = New System.Windows.Forms.Padding(5, 6, 5, 6)
        Me.EA_CheckBox.Name = "EA_CheckBox"
        Me.EA_CheckBox.Size = New System.Drawing.Size(184, 19)
        Me.EA_CheckBox.TabIndex = 58
        Me.EA_CheckBox.Text = "Include Extended Attributes"
        Me.ToolTip1.SetToolTip(Me.EA_CheckBox, "Include Extended Attributes")
        Me.EA_CheckBox.UseVisualStyleBackColor = True
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(324, 16)
        Me.Label8.Margin = New System.Windows.Forms.Padding(5, 0, 5, 0)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(47, 30)
        Me.Label8.TabIndex = 59
        Me.Label8.Text = "Create" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Backup"
        Me.Label8.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.ToolTip1.SetToolTip(Me.Label8, "Capture the Selected Drive to the to the selected (Windows Image Media|*.wim) fil" &
        "e name")
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(385, 16)
        Me.Label9.Margin = New System.Windows.Forms.Padding(5, 0, 5, 0)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(49, 30)
        Me.Label9.TabIndex = 60
        Me.Label9.Text = "Restore" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Backup"
        Me.Label9.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.ToolTip1.SetToolTip(Me.Label9, "Install the selected Windows Image Media on the Selected Drive")
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(432, 24)
        Me.Label10.Margin = New System.Windows.Forms.Padding(5, 0, 5, 0)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(91, 30)
        Me.Label10.TabIndex = 61
        Me.Label10.Text = "Create/Restore" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Target Drive:"
        Me.Label10.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.ToolTip1.SetToolTip(Me.Label10, "Target Drive to [ Create ] Windows Image Media from" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Or [ Install ] Windows Image" &
        " Media to")
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(526, 14)
        Me.Label11.Margin = New System.Windows.Forms.Padding(5, 0, 5, 0)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(59, 30)
        Me.Label11.TabIndex = 62
        Me.Label11.Text = "Re-Scan" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Drives *:\"
        Me.Label11.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.ToolTip1.SetToolTip(Me.Label11, "ReScan for used Drive Letters and" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "RePopulate the Create/Install Drives Options" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) &
        "After Creating New Partitions or VHD's")
        '
        'Button15
        '
        Me.Button15.BackColor = System.Drawing.Color.Transparent
        Me.Button15.BackgroundImage = CType(resources.GetObject("Button15.BackgroundImage"), System.Drawing.Image)
        Me.Button15.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Button15.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Button15.FlatAppearance.BorderSize = 0
        Me.Button15.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Button15.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button15.Location = New System.Drawing.Point(64, 13)
        Me.Button15.Margin = New System.Windows.Forms.Padding(5, 6, 5, 6)
        Me.Button15.Name = "Button15"
        Me.Button15.Size = New System.Drawing.Size(47, 46)
        Me.Button15.TabIndex = 65
        Me.ToolTip1.SetToolTip(Me.Button15, "Tools Menu")
        Me.Button15.UseVisualStyleBackColor = False
        '
        'CmdsOutput
        '
        Me.CmdsOutput.BackColor = System.Drawing.SystemColors.WindowText
        Me.CmdsOutput.Cursor = System.Windows.Forms.Cursors.Hand
        Me.CmdsOutput.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.CmdsOutput.ForeColor = System.Drawing.SystemColors.Info
        Me.CmdsOutput.Location = New System.Drawing.Point(0, 298)
        Me.CmdsOutput.Margin = New System.Windows.Forms.Padding(5, 6, 5, 6)
        Me.CmdsOutput.Multiline = True
        Me.CmdsOutput.Name = "CmdsOutput"
        Me.CmdsOutput.ReadOnly = True
        Me.CmdsOutput.Size = New System.Drawing.Size(931, 25)
        Me.CmdsOutput.TabIndex = 69
        Me.CmdsOutput.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.ToolTip1.SetToolTip(Me.CmdsOutput, "Cmd Output")
        Me.CmdsOutput.WordWrap = False
        '
        'RO_CheckBox
        '
        Me.RO_CheckBox.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.RO_CheckBox.AutoSize = True
        Me.RO_CheckBox.CheckAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.RO_CheckBox.Location = New System.Drawing.Point(275, 30)
        Me.RO_CheckBox.Margin = New System.Windows.Forms.Padding(5, 6, 5, 6)
        Me.RO_CheckBox.Name = "RO_CheckBox"
        Me.RO_CheckBox.Size = New System.Drawing.Size(81, 19)
        Me.RO_CheckBox.TabIndex = 63
        Me.RO_CheckBox.Text = "ReadOnly"
        Me.ToolTip1.SetToolTip(Me.RO_CheckBox, "Mount the Image Read Only")
        Me.RO_CheckBox.UseVisualStyleBackColor = True
        '
        'GroupBox2
        '
        Me.GroupBox2.BackColor = System.Drawing.SystemColors.GradientInactiveCaption
        Me.GroupBox2.Controls.Add(Me.Label12)
        Me.GroupBox2.Controls.Add(Me.Label13)
        Me.GroupBox2.Controls.Add(Me.Button1)
        Me.GroupBox2.Controls.Add(Me.Button2)
        Me.GroupBox2.Controls.Add(Me.RO_CheckBox)
        Me.GroupBox2.Controls.Add(Me.CommitChanges)
        Me.GroupBox2.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.GroupBox2.Location = New System.Drawing.Point(0, 243)
        Me.GroupBox2.Margin = New System.Windows.Forms.Padding(5, 6, 5, 6)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Padding = New System.Windows.Forms.Padding(5, 6, 5, 6)
        Me.GroupBox2.Size = New System.Drawing.Size(931, 55)
        Me.GroupBox2.TabIndex = 70
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Media Servicing Folder"
        Me.ToolTip1.SetToolTip(Me.GroupBox2, "Select the Folder to mount the windows install media in for modification")
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(551, 7)
        Me.Label12.Margin = New System.Windows.Forms.Padding(5, 0, 5, 0)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(99, 15)
        Me.Label12.TabIndex = 71
        Me.Label12.Text = "DisMount Image"
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Location = New System.Drawing.Point(299, 7)
        Me.Label13.Margin = New System.Windows.Forms.Padding(5, 0, 5, 0)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(82, 15)
        Me.Label13.TabIndex = 72
        Me.Label13.Text = "Mount Image"
        '
        'Install_Image_OnDrive
        '
        Me.Install_Image_OnDrive.AutoSize = True
        Me.Install_Image_OnDrive.Location = New System.Drawing.Point(12, 58)
        Me.Install_Image_OnDrive.Margin = New System.Windows.Forms.Padding(5, 6, 5, 6)
        Me.Install_Image_OnDrive.Name = "Install_Image_OnDrive"
        Me.Install_Image_OnDrive.Size = New System.Drawing.Size(300, 19)
        Me.Install_Image_OnDrive.TabIndex = 47
        Me.Install_Image_OnDrive.Text = "Install Windows from the *.wim file and image #"
        Me.ToolTip1.SetToolTip(Me.Install_Image_OnDrive, "Install the" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "'Windows Installation Media' 'Image #'" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "on this Drive and make it bo" &
        "otable.")
        Me.Install_Image_OnDrive.UseVisualStyleBackColor = True
        '
        'Has_Boot_Sector
        '
        Me.Has_Boot_Sector.AutoSize = True
        Me.Has_Boot_Sector.Location = New System.Drawing.Point(38, 35)
        Me.Has_Boot_Sector.Margin = New System.Windows.Forms.Padding(5, 6, 5, 6)
        Me.Has_Boot_Sector.Name = "Has_Boot_Sector"
        Me.Has_Boot_Sector.Size = New System.Drawing.Size(249, 19)
        Me.Has_Boot_Sector.TabIndex = 48
        Me.Has_Boot_Sector.Text = "Already Has Boot Sector for BOOTMGR"
        Me.ToolTip1.SetToolTip(Me.Has_Boot_Sector, "Skip Creating the boot sector for the bootmgr." & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "If Install is not checked," & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "'Make" &
        " Drive Bootable' just marks the partition as active")
        Me.Has_Boot_Sector.UseVisualStyleBackColor = True
        '
        'BootableTargetDrive
        '
        Me.BootableTargetDrive.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BootableTargetDrive.Location = New System.Drawing.Point(241, 27)
        Me.BootableTargetDrive.Margin = New System.Windows.Forms.Padding(5, 6, 5, 6)
        Me.BootableTargetDrive.Name = "BootableTargetDrive"
        Me.BootableTargetDrive.ReadOnly = True
        Me.BootableTargetDrive.Size = New System.Drawing.Size(42, 20)
        Me.BootableTargetDrive.TabIndex = 51
        Me.ToolTip1.SetToolTip(Me.BootableTargetDrive, "Target Drive to add boot option to.")
        Me.BootableTargetDrive.UpDownAlign = System.Windows.Forms.LeftRightAlignment.Left
        '
        'Button19
        '
        Me.Button19.BackColor = System.Drawing.SystemColors.ControlText
        Me.Button19.FlatAppearance.BorderColor = System.Drawing.Color.Red
        Me.Button19.FlatAppearance.BorderSize = 2
        Me.Button19.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button19.Font = New System.Drawing.Font("Lucida Console", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button19.ForeColor = System.Drawing.Color.Red
        Me.Button19.Location = New System.Drawing.Point(608, 8)
        Me.Button19.Margin = New System.Windows.Forms.Padding(5, 6, 5, 6)
        Me.Button19.Name = "Button19"
        Me.Button19.Size = New System.Drawing.Size(23, 24)
        Me.Button19.TabIndex = 58
        Me.Button19.Text = "X"
        Me.ToolTip1.SetToolTip(Me.Button19, "Close this tool window")
        Me.Button19.UseVisualStyleBackColor = False
        '
        'Wim_Path
        '
        Me.Wim_Path.Location = New System.Drawing.Point(8, 89)
        Me.Wim_Path.Name = "Wim_Path"
        Me.Wim_Path.Size = New System.Drawing.Size(205, 22)
        Me.Wim_Path.TabIndex = 60
        Me.Wim_Path.Text = "\boot"
        Me.Wim_Path.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.ToolTip1.SetToolTip(Me.Wim_Path, "The location of the boot.wim file" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "default:  \boot\boot.wim")
        '
        'Sdi_Path
        '
        Me.Sdi_Path.Location = New System.Drawing.Point(8, 62)
        Me.Sdi_Path.Name = "Sdi_Path"
        Me.Sdi_Path.Size = New System.Drawing.Size(205, 22)
        Me.Sdi_Path.TabIndex = 61
        Me.Sdi_Path.Text = "\boot"
        Me.Sdi_Path.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.ToolTip1.SetToolTip(Me.Sdi_Path, "The location of the boot.sdi file" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "default:  \boot\boot.sdi" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10))
        '
        'CheckBox2
        '
        Me.CheckBox2.AutoSize = True
        Me.CheckBox2.Location = New System.Drawing.Point(78, 12)
        Me.CheckBox2.Margin = New System.Windows.Forms.Padding(5, 6, 5, 6)
        Me.CheckBox2.Name = "CheckBox2"
        Me.CheckBox2.Size = New System.Drawing.Size(168, 19)
        Me.CheckBox2.TabIndex = 66
        Me.CheckBox2.Text = "Only Create Boot Option"
        Me.ToolTip1.SetToolTip(Me.CheckBox2, "Skip Creating the boot sector for the bootmgr." & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Skip marking the partition as act" &
        "ive")
        Me.CheckBox2.UseVisualStyleBackColor = True
        '
        'MountFolder
        '
        Me.MountFolder.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.FileSystemDirectories
        Me.MountFolder.Cursor = System.Windows.Forms.Cursors.Hand
        Me.MountFolder.DataBindings.Add(New System.Windows.Forms.Binding("Text", Global.MB_Tools.My.MySettings.Default, "SelectedMountFolder", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged))
        Me.MountFolder.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.MountFolder.Location = New System.Drawing.Point(0, 221)
        Me.MountFolder.Margin = New System.Windows.Forms.Padding(5, 6, 5, 6)
        Me.MountFolder.Name = "MountFolder"
        Me.MountFolder.ReadOnly = True
        Me.MountFolder.Size = New System.Drawing.Size(931, 22)
        Me.MountFolder.TabIndex = 21
        Me.MountFolder.Text = Global.MB_Tools.My.MySettings.Default.SelectedMountFolder
        Me.ToolTip1.SetToolTip(Me.MountFolder, "Must be an empty directory to Mount the Windows Image Files")
        '
        'WimFile
        '
        Me.WimFile.Cursor = System.Windows.Forms.Cursors.Hand
        Me.WimFile.DataBindings.Add(New System.Windows.Forms.Binding("Text", Global.MB_Tools.My.MySettings.Default, "WindowsImageFile", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged))
        Me.WimFile.Location = New System.Drawing.Point(176, 51)
        Me.WimFile.Margin = New System.Windows.Forms.Padding(5, 6, 5, 6)
        Me.WimFile.MaximumSize = New System.Drawing.Size(816, 20)
        Me.WimFile.MinimumSize = New System.Drawing.Size(81, 20)
        Me.WimFile.Name = "WimFile"
        Me.WimFile.ReadOnly = True
        Me.WimFile.Size = New System.Drawing.Size(512, 22)
        Me.WimFile.TabIndex = 0
        Me.WimFile.Text = Global.MB_Tools.My.MySettings.Default.WindowsImageFile
        Me.ToolTip1.SetToolTip(Me.WimFile, "Select the Windows Image Media to Install, Service, or Export")
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.Button7)
        Me.GroupBox3.Controls.Add(Me.Button15)
        Me.GroupBox3.Location = New System.Drawing.Point(803, 27)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(120, 61)
        Me.GroupBox3.TabIndex = 74
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "vm/vhd | bootops"
        '
        'BackgroundWorker1
        '
        '
        'MountingStatus
        '
        Me.MountingStatus.AutoSize = True
        Me.MountingStatus.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.MountingStatus.ForeColor = System.Drawing.Color.DarkOrange
        Me.MountingStatus.Location = New System.Drawing.Point(378, 328)
        Me.MountingStatus.Margin = New System.Windows.Forms.Padding(5, 0, 5, 0)
        Me.MountingStatus.Name = "MountingStatus"
        Me.MountingStatus.Size = New System.Drawing.Size(181, 15)
        Me.MountingStatus.TabIndex = 23
        Me.MountingStatus.Text = "Mounting Image Please Wait..."
        Me.MountingStatus.Visible = False
        '
        'LastCmd
        '
        Me.LastCmd.BackColor = System.Drawing.SystemColors.GradientActiveCaption
        Me.LastCmd.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.LastCmd.Cursor = System.Windows.Forms.Cursors.Default
        Me.LastCmd.Font = New System.Drawing.Font("Lucida Console", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LastCmd.Location = New System.Drawing.Point(165, 29)
        Me.LastCmd.Margin = New System.Windows.Forms.Padding(117, 6, 5, 0)
        Me.LastCmd.MaximumSize = New System.Drawing.Size(630, 20)
        Me.LastCmd.MinimumSize = New System.Drawing.Size(0, 20)
        Me.LastCmd.Name = "LastCmd"
        Me.LastCmd.ReadOnly = True
        Me.LastCmd.Size = New System.Drawing.Size(630, 11)
        Me.LastCmd.TabIndex = 24
        '
        'Label1
        '
        Me.Label1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(130, 28)
        Me.Label1.Margin = New System.Windows.Forms.Padding(5, 0, 5, 0)
        Me.Label1.MinimumSize = New System.Drawing.Size(0, 21)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(37, 21)
        Me.Label1.TabIndex = 25
        Me.Label1.Text = "Cmd:"
        '
        'UnMountingStatus
        '
        Me.UnMountingStatus.AutoSize = True
        Me.UnMountingStatus.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.UnMountingStatus.ForeColor = System.Drawing.Color.DarkOrange
        Me.UnMountingStatus.Location = New System.Drawing.Point(369, 328)
        Me.UnMountingStatus.Margin = New System.Windows.Forms.Padding(5, 0, 5, 0)
        Me.UnMountingStatus.Name = "UnMountingStatus"
        Me.UnMountingStatus.Size = New System.Drawing.Size(203, 15)
        Me.UnMountingStatus.TabIndex = 27
        Me.UnMountingStatus.Text = "Un-Mounting Image Please Wait..."
        Me.UnMountingStatus.Visible = False
        '
        'LabelDriverStatus
        '
        Me.LabelDriverStatus.AutoSize = True
        Me.LabelDriverStatus.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.LabelDriverStatus.ForeColor = System.Drawing.Color.DarkOrange
        Me.LabelDriverStatus.Location = New System.Drawing.Point(376, 328)
        Me.LabelDriverStatus.Margin = New System.Windows.Forms.Padding(5, 0, 5, 0)
        Me.LabelDriverStatus.Name = "LabelDriverStatus"
        Me.LabelDriverStatus.Size = New System.Drawing.Size(182, 15)
        Me.LabelDriverStatus.TabIndex = 32
        Me.LabelDriverStatus.Text = "Servicing Drivers Please Wait..."
        Me.LabelDriverStatus.Visible = False
        '
        'VHDTOOLS
        '
        Me.VHDTOOLS.BackColor = System.Drawing.SystemColors.ControlLight
        Me.VHDTOOLS.Controls.Add(Me.AttachVhdBtn)
        Me.VHDTOOLS.Controls.Add(Me.CheckBox1)
        Me.VHDTOOLS.Controls.Add(Me.SizeMB)
        Me.VHDTOOLS.Controls.Add(Me.Label6)
        Me.VHDTOOLS.Controls.Add(Me.SizeGB)
        Me.VHDTOOLS.Controls.Add(Me.Label5)
        Me.VHDTOOLS.Controls.Add(Me.CreateVhdBtn)
        Me.VHDTOOLS.Controls.Add(Me.Label4)
        Me.VHDTOOLS.Controls.Add(Me.VHD_file)
        Me.VHDTOOLS.Controls.Add(Me.Button8)
        Me.VHDTOOLS.Location = New System.Drawing.Point(332, 90)
        Me.VHDTOOLS.Margin = New System.Windows.Forms.Padding(5, 6, 5, 6)
        Me.VHDTOOLS.Name = "VHDTOOLS"
        Me.VHDTOOLS.Padding = New System.Windows.Forms.Padding(5, 6, 5, 6)
        Me.VHDTOOLS.Size = New System.Drawing.Size(411, 122)
        Me.VHDTOOLS.TabIndex = 37
        Me.VHDTOOLS.TabStop = False
        Me.VHDTOOLS.Text = "Create VHD"
        Me.VHDTOOLS.Visible = False
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(271, 27)
        Me.Label6.Margin = New System.Windows.Forms.Padding(5, 0, 5, 0)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(29, 15)
        Me.Label6.TabIndex = 44
        Me.Label6.Text = "MB:"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(147, 27)
        Me.Label5.Margin = New System.Windows.Forms.Padding(5, 0, 5, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(53, 15)
        Me.Label5.TabIndex = 42
        Me.Label5.Text = "Size GB:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Label4.Location = New System.Drawing.Point(5, 79)
        Me.Label4.Margin = New System.Windows.Forms.Padding(5, 0, 5, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(164, 15)
        Me.Label4.TabIndex = 38
        Me.Label4.Text = "VHD file (Create or Attach)"
        '
        'CreateUSB_OS
        '
        Me.CreateUSB_OS.Cursor = System.Windows.Forms.Cursors.Hand
        Me.CreateUSB_OS.Location = New System.Drawing.Point(22, 20)
        Me.CreateUSB_OS.Name = "CreateUSB_OS"
        Me.CreateUSB_OS.Size = New System.Drawing.Size(131, 23)
        Me.CreateUSB_OS.TabIndex = 46
        Me.CreateUSB_OS.Text = "Make Drive Bootable"
        Me.CreateUSB_OS.UseVisualStyleBackColor = True
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(14, 21)
        Me.Label7.Margin = New System.Windows.Forms.Padding(5, 0, 5, 0)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(152, 15)
        Me.Label7.TabIndex = 57
        Me.Label7.Text = "Internal Name for Backup"
        '
        'Timer1
        '
        Me.Timer1.Enabled = True
        Me.Timer1.Interval = 1000
        '
        'DriveImagingTools
        '
        Me.DriveImagingTools.BackColor = System.Drawing.SystemColors.GradientInactiveCaption
        Me.DriveImagingTools.Controls.Add(Me.CaptureImage)
        Me.DriveImagingTools.Controls.Add(Me.Label11)
        Me.DriveImagingTools.Controls.Add(Me.Label10)
        Me.DriveImagingTools.Controls.Add(Me.ApplyMedia)
        Me.DriveImagingTools.Controls.Add(Me.Label9)
        Me.DriveImagingTools.Controls.Add(Me.ReScanDrives)
        Me.DriveImagingTools.Controls.Add(Me.Label8)
        Me.DriveImagingTools.Controls.Add(Me.Used_Drives)
        Me.DriveImagingTools.Controls.Add(Me.EA_CheckBox)
        Me.DriveImagingTools.Controls.Add(Me.Label7)
        Me.DriveImagingTools.Controls.Add(Me.InternalImageName)
        Me.DriveImagingTools.Controls.Add(Me.VERIFY_CheckBox)
        Me.DriveImagingTools.Controls.Add(Me.CI_CheckBox)
        Me.DriveImagingTools.Location = New System.Drawing.Point(332, 89)
        Me.DriveImagingTools.Margin = New System.Windows.Forms.Padding(5, 6, 5, 6)
        Me.DriveImagingTools.Name = "DriveImagingTools"
        Me.DriveImagingTools.Padding = New System.Windows.Forms.Padding(5, 6, 5, 6)
        Me.DriveImagingTools.Size = New System.Drawing.Size(590, 111)
        Me.DriveImagingTools.TabIndex = 63
        Me.DriveImagingTools.TabStop = False
        Me.DriveImagingTools.Text = "Drive Imaging"
        '
        'Selected_Index
        '
        Me.Selected_Index.Location = New System.Drawing.Point(740, 51)
        Me.Selected_Index.Margin = New System.Windows.Forms.Padding(5, 6, 5, 6)
        Me.Selected_Index.Name = "Selected_Index"
        Me.Selected_Index.ReadOnly = True
        Me.Selected_Index.Size = New System.Drawing.Size(42, 22)
        Me.Selected_Index.TabIndex = 66
        Me.Selected_Index.Text = "1"
        Me.Selected_Index.UpDownAlign = System.Windows.Forms.LeftRightAlignment.Left
        '
        'VersionDetails
        '
        Me.VersionDetails.BackColor = System.Drawing.SystemColors.ScrollBar
        Me.VersionDetails.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.VersionDetails.Dock = System.Windows.Forms.DockStyle.Fill
        Me.VersionDetails.Location = New System.Drawing.Point(5, 21)
        Me.VersionDetails.Margin = New System.Windows.Forms.Padding(5, 6, 5, 6)
        Me.VersionDetails.Multiline = True
        Me.VersionDetails.Name = "VersionDetails"
        Me.VersionDetails.ReadOnly = True
        Me.VersionDetails.Size = New System.Drawing.Size(305, 84)
        Me.VersionDetails.TabIndex = 67
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.SystemColors.GradientInactiveCaption
        Me.GroupBox1.Controls.Add(Me.VersionDetails)
        Me.GroupBox1.Location = New System.Drawing.Point(9, 89)
        Me.GroupBox1.Margin = New System.Windows.Forms.Padding(5, 6, 5, 6)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Padding = New System.Windows.Forms.Padding(5, 6, 5, 6)
        Me.GroupBox1.Size = New System.Drawing.Size(315, 111)
        Me.GroupBox1.TabIndex = 68
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "*.wim file -INFO"
        '
        'ProgressBar1
        '
        Me.ProgressBar1.BackColor = System.Drawing.SystemColors.Desktop
        Me.ProgressBar1.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.ProgressBar1.Location = New System.Drawing.Point(0, 323)
        Me.ProgressBar1.Margin = New System.Windows.Forms.Padding(5, 6, 5, 6)
        Me.ProgressBar1.Name = "ProgressBar1"
        Me.ProgressBar1.Size = New System.Drawing.Size(931, 24)
        Me.ProgressBar1.Step = 20
        Me.ProgressBar1.Style = System.Windows.Forms.ProgressBarStyle.Marquee
        Me.ProgressBar1.TabIndex = 50
        Me.ProgressBar1.UseWaitCursor = True
        Me.ProgressBar1.Value = 100
        Me.ProgressBar1.Visible = False
        '
        'Timer2
        '
        '
        'Boot_Tools
        '
        Me.Boot_Tools.BackColor = System.Drawing.Color.Chocolate
        Me.Boot_Tools.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Boot_Tools.Controls.Add(Me.OptionGroup)
        Me.Boot_Tools.Controls.Add(Me.Label18)
        Me.Boot_Tools.Controls.Add(Me.BootDetails)
        Me.Boot_Tools.Controls.Add(Me.Boot_Menu)
        Me.Boot_Tools.Controls.Add(Me.BootableTargetDrive)
        Me.Boot_Tools.Controls.Add(Me.Label14)
        Me.Boot_Tools.Controls.Add(Me.CreateUSB_OS)
        Me.Boot_Tools.Controls.Add(Me.Button16)
        Me.Boot_Tools.Controls.Add(Me.GroupBox4)
        Me.Boot_Tools.Controls.Add(Me.Button19)
        Me.Boot_Tools.Controls.Add(Me.Button18)
        Me.Boot_Tools.Location = New System.Drawing.Point(148, 42)
        Me.Boot_Tools.Name = "Boot_Tools"
        Me.Boot_Tools.Size = New System.Drawing.Size(634, 255)
        Me.Boot_Tools.TabIndex = 47
        Me.Boot_Tools.TabStop = False
        Me.Boot_Tools.Text = "Boot Tools"
        Me.Boot_Tools.Visible = False
        '
        'OptionGroup
        '
        Me.OptionGroup.Controls.Add(Me.CheckBox2)
        Me.OptionGroup.Controls.Add(Me.Install_Image_OnDrive)
        Me.OptionGroup.Controls.Add(Me.Has_Boot_Sector)
        Me.OptionGroup.Location = New System.Drawing.Point(304, 158)
        Me.OptionGroup.Name = "OptionGroup"
        Me.OptionGroup.Size = New System.Drawing.Size(324, 83)
        Me.OptionGroup.TabIndex = 70
        Me.OptionGroup.TabStop = False
        Me.OptionGroup.Text = "Options"
        '
        'Label18
        '
        Me.Label18.AutoSize = True
        Me.Label18.Font = New System.Drawing.Font("Tempus Sans ITC", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label18.Location = New System.Drawing.Point(309, 16)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(180, 17)
        Me.Label18.TabIndex = 69
        Me.Label18.Text = "Current System Boot Menu"
        '
        'BootDetails
        '
        Me.BootDetails.AutoSize = True
        Me.BootDetails.BackColor = System.Drawing.Color.OldLace
        Me.BootDetails.Location = New System.Drawing.Point(306, 65)
        Me.BootDetails.MinimumSize = New System.Drawing.Size(310, 90)
        Me.BootDetails.Name = "BootDetails"
        Me.BootDetails.Size = New System.Drawing.Size(310, 90)
        Me.BootDetails.TabIndex = 68
        '
        'Boot_Menu
        '
        Me.Boot_Menu.Location = New System.Drawing.Point(303, 37)
        Me.Boot_Menu.Name = "Boot_Menu"
        Me.Boot_Menu.Size = New System.Drawing.Size(324, 22)
        Me.Boot_Menu.TabIndex = 67
        Me.Boot_Menu.UpDownAlign = System.Windows.Forms.LeftRightAlignment.Left
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Location = New System.Drawing.Point(154, 29)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(86, 15)
        Me.Label14.TabIndex = 52
        Me.Label14.Text = "Target Drive->"
        '
        'Button16
        '
        Me.Button16.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Button16.Location = New System.Drawing.Point(19, 55)
        Me.Button16.Name = "Button16"
        Me.Button16.Size = New System.Drawing.Size(274, 23)
        Me.Button16.TabIndex = 55
        Me.Button16.Text = "Boot Target Drive from Running System"
        Me.Button16.UseVisualStyleBackColor = True
        '
        'GroupBox4
        '
        Me.GroupBox4.Controls.Add(Me.Button20)
        Me.GroupBox4.Controls.Add(Me.Label17)
        Me.GroupBox4.Controls.Add(Me.Wim_Path)
        Me.GroupBox4.Controls.Add(Me.Label16)
        Me.GroupBox4.Controls.Add(Me.Sdi_Path)
        Me.GroupBox4.Controls.Add(Me.Label15)
        Me.GroupBox4.Location = New System.Drawing.Point(12, 117)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Size = New System.Drawing.Size(288, 123)
        Me.GroupBox4.TabIndex = 65
        Me.GroupBox4.TabStop = False
        Me.GroupBox4.Text = "Windows Pre-Installation Evironment"
        '
        'Button20
        '
        Me.Button20.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Button20.Location = New System.Drawing.Point(7, 18)
        Me.Button20.Name = "Button20"
        Me.Button20.Size = New System.Drawing.Size(274, 23)
        Me.Button20.TabIndex = 59
        Me.Button20.Text = "Create a WinPE Boot Option on Target Drive"
        Me.Button20.UseVisualStyleBackColor = True
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.Location = New System.Drawing.Point(13, 44)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(263, 15)
        Me.Label17.TabIndex = 64
        Me.Label17.Text = "(No Drive Letter) File Paths [\boot\boot.sdi]"
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Location = New System.Drawing.Point(211, 92)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(65, 15)
        Me.Label16.TabIndex = 63
        Me.Label16.Text = "\boot.wim"
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Location = New System.Drawing.Point(211, 66)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(58, 15)
        Me.Label15.TabIndex = 62
        Me.Label15.Text = "\boot.sdi"
        '
        'Button18
        '
        Me.Button18.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Button18.Location = New System.Drawing.Point(19, 90)
        Me.Button18.Name = "Button18"
        Me.Button18.Size = New System.Drawing.Size(274, 23)
        Me.Button18.TabIndex = 57
        Me.Button18.Text = "Boot Running System from Target Drive"
        Me.Button18.UseVisualStyleBackColor = True
        '
        'BackgroundWorker2
        '
        '
        'BackgroundWorker3
        '
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.FileToolStripMenuItem, Me.ToolStripSeparator2, Me.ToolsToolStripMenuItem, Me.toolStripSeparator5, Me.HelpToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(931, 27)
        Me.MenuStrip1.TabIndex = 75
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'FileToolStripMenuItem
        '
        Me.FileToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.NewToolStripMenuItem, Me.SaveToolStripMenuItem, Me.toolStripSeparator1, Me.OpenToolStripMenuItem, Me.toolStripSeparator, Me.ExitToolStripMenuItem})
        Me.FileToolStripMenuItem.Name = "FileToolStripMenuItem"
        Me.FileToolStripMenuItem.Size = New System.Drawing.Size(37, 23)
        Me.FileToolStripMenuItem.Text = "&File"
        '
        'NewToolStripMenuItem
        '
        Me.NewToolStripMenuItem.Image = CType(resources.GetObject("NewToolStripMenuItem.Image"), System.Drawing.Image)
        Me.NewToolStripMenuItem.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.NewToolStripMenuItem.Name = "NewToolStripMenuItem"
        Me.NewToolStripMenuItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.N), System.Windows.Forms.Keys)
        Me.NewToolStripMenuItem.Size = New System.Drawing.Size(192, 22)
        Me.NewToolStripMenuItem.Text = "&Restore Image"
        '
        'SaveToolStripMenuItem
        '
        Me.SaveToolStripMenuItem.Image = CType(resources.GetObject("SaveToolStripMenuItem.Image"), System.Drawing.Image)
        Me.SaveToolStripMenuItem.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.SaveToolStripMenuItem.Name = "SaveToolStripMenuItem"
        Me.SaveToolStripMenuItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.S), System.Windows.Forms.Keys)
        Me.SaveToolStripMenuItem.Size = New System.Drawing.Size(192, 22)
        Me.SaveToolStripMenuItem.Text = "&Save Image"
        Me.SaveToolStripMenuItem.ToolTipText = "Select the Backup Image Filename"
        '
        'toolStripSeparator1
        '
        Me.toolStripSeparator1.Name = "toolStripSeparator1"
        Me.toolStripSeparator1.Size = New System.Drawing.Size(189, 6)
        '
        'OpenToolStripMenuItem
        '
        Me.OpenToolStripMenuItem.Image = CType(resources.GetObject("OpenToolStripMenuItem.Image"), System.Drawing.Image)
        Me.OpenToolStripMenuItem.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.OpenToolStripMenuItem.Name = "OpenToolStripMenuItem"
        Me.OpenToolStripMenuItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.O), System.Windows.Forms.Keys)
        Me.OpenToolStripMenuItem.Size = New System.Drawing.Size(192, 22)
        Me.OpenToolStripMenuItem.Text = "&Service Folder"
        '
        'toolStripSeparator
        '
        Me.toolStripSeparator.Name = "toolStripSeparator"
        Me.toolStripSeparator.Size = New System.Drawing.Size(189, 6)
        '
        'ExitToolStripMenuItem
        '
        Me.ExitToolStripMenuItem.Name = "ExitToolStripMenuItem"
        Me.ExitToolStripMenuItem.Size = New System.Drawing.Size(192, 22)
        Me.ExitToolStripMenuItem.Text = "E&xit"
        '
        'ToolStripSeparator2
        '
        Me.ToolStripSeparator2.Name = "ToolStripSeparator2"
        Me.ToolStripSeparator2.Size = New System.Drawing.Size(6, 23)
        '
        'ToolsToolStripMenuItem
        '
        Me.ToolsToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.CustomizeToolStripMenuItem, Me.OptionsToolStripMenuItem, Me.BootToolsToolStripMenuItem, Me.VMVHDToolsToolStripMenuItem, Me.ScanToolsToolStripMenuItem, Me.WinPEToolsToolStripMenuItem})
        Me.ToolsToolStripMenuItem.Name = "ToolsToolStripMenuItem"
        Me.ToolsToolStripMenuItem.Size = New System.Drawing.Size(46, 23)
        Me.ToolsToolStripMenuItem.Text = "&Tools"
        '
        'CustomizeToolStripMenuItem
        '
        Me.CustomizeToolStripMenuItem.Name = "CustomizeToolStripMenuItem"
        Me.CustomizeToolStripMenuItem.Size = New System.Drawing.Size(180, 22)
        Me.CustomizeToolStripMenuItem.Text = "&Repair Tools"
        Me.CustomizeToolStripMenuItem.ToolTipText = "'Media Servicing Folder' Repair Tools"
        '
        'OptionsToolStripMenuItem
        '
        Me.OptionsToolStripMenuItem.Name = "OptionsToolStripMenuItem"
        Me.OptionsToolStripMenuItem.Size = New System.Drawing.Size(180, 22)
        Me.OptionsToolStripMenuItem.Text = "&Driver Tools"
        Me.OptionsToolStripMenuItem.ToolTipText = "Export or Install Windows Driver Files"
        '
        'BootToolsToolStripMenuItem
        '
        Me.BootToolsToolStripMenuItem.Name = "BootToolsToolStripMenuItem"
        Me.BootToolsToolStripMenuItem.Size = New System.Drawing.Size(180, 22)
        Me.BootToolsToolStripMenuItem.Text = "Boot Tools"
        '
        'VMVHDToolsToolStripMenuItem
        '
        Me.VMVHDToolsToolStripMenuItem.Name = "VMVHDToolsToolStripMenuItem"
        Me.VMVHDToolsToolStripMenuItem.Size = New System.Drawing.Size(180, 22)
        Me.VMVHDToolsToolStripMenuItem.Text = "VM/VHD Tools"
        '
        'ScanToolsToolStripMenuItem
        '
        Me.ScanToolsToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ReScanForDrivesToolStripMenuItem, Me.ReScanBootEntriesToolStripMenuItem, Me.ReScanWimInfoToolStripMenuItem})
        Me.ScanToolsToolStripMenuItem.Name = "ScanToolsToolStripMenuItem"
        Me.ScanToolsToolStripMenuItem.Size = New System.Drawing.Size(180, 22)
        Me.ScanToolsToolStripMenuItem.Text = "Refresh Info"
        '
        'ReScanForDrivesToolStripMenuItem
        '
        Me.ReScanForDrivesToolStripMenuItem.Name = "ReScanForDrivesToolStripMenuItem"
        Me.ReScanForDrivesToolStripMenuItem.Size = New System.Drawing.Size(206, 22)
        Me.ReScanForDrivesToolStripMenuItem.Text = "Refresh Available Drives"
        '
        'ReScanBootEntriesToolStripMenuItem
        '
        Me.ReScanBootEntriesToolStripMenuItem.Name = "ReScanBootEntriesToolStripMenuItem"
        Me.ReScanBootEntriesToolStripMenuItem.Size = New System.Drawing.Size(206, 22)
        Me.ReScanBootEntriesToolStripMenuItem.Text = "Refresh Boot Entries"
        '
        'ReScanWimInfoToolStripMenuItem
        '
        Me.ReScanWimInfoToolStripMenuItem.Name = "ReScanWimInfoToolStripMenuItem"
        Me.ReScanWimInfoToolStripMenuItem.Size = New System.Drawing.Size(206, 22)
        Me.ReScanWimInfoToolStripMenuItem.Text = "Refresh Image*.Wim Info"
        '
        'WinPEToolsToolStripMenuItem
        '
        Me.WinPEToolsToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.CreateOfflineScriptsToolStripMenuItem})
        Me.WinPEToolsToolStripMenuItem.Name = "WinPEToolsToolStripMenuItem"
        Me.WinPEToolsToolStripMenuItem.Size = New System.Drawing.Size(180, 22)
        Me.WinPEToolsToolStripMenuItem.Text = "WinPE Tools"
        '
        'CreateOfflineScriptsToolStripMenuItem
        '
        Me.CreateOfflineScriptsToolStripMenuItem.Name = "CreateOfflineScriptsToolStripMenuItem"
        Me.CreateOfflineScriptsToolStripMenuItem.Size = New System.Drawing.Size(185, 22)
        Me.CreateOfflineScriptsToolStripMenuItem.Text = "Create Offline Scripts"
        Me.CreateOfflineScriptsToolStripMenuItem.ToolTipText = "Create Offline Cmd Tools in a folder created on the Desktop"
        '
        'toolStripSeparator5
        '
        Me.toolStripSeparator5.Name = "toolStripSeparator5"
        Me.toolStripSeparator5.Size = New System.Drawing.Size(6, 23)
        '
        'HelpToolStripMenuItem
        '
        Me.HelpToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.AboutToolStripMenuItem, Me.CheckForUpdatesToolStripMenuItem, Me.HelpOnlineToolStripMenuItem, Me.FeedbackToolStripMenuItem, Me.ToolStripSeparator3, Me.CreateShortcutToolStripMenuItem})
        Me.HelpToolStripMenuItem.Name = "HelpToolStripMenuItem"
        Me.HelpToolStripMenuItem.Size = New System.Drawing.Size(44, 23)
        Me.HelpToolStripMenuItem.Text = "&Help"
        '
        'AboutToolStripMenuItem
        '
        Me.AboutToolStripMenuItem.AutoToolTip = True
        Me.AboutToolStripMenuItem.Name = "AboutToolStripMenuItem"
        Me.AboutToolStripMenuItem.Size = New System.Drawing.Size(171, 22)
        Me.AboutToolStripMenuItem.Text = "&About..."
        Me.AboutToolStripMenuItem.ToolTipText = "Open the About Dialog"
        '
        'CheckForUpdatesToolStripMenuItem
        '
        Me.CheckForUpdatesToolStripMenuItem.AutoToolTip = True
        Me.CheckForUpdatesToolStripMenuItem.Name = "CheckForUpdatesToolStripMenuItem"
        Me.CheckForUpdatesToolStripMenuItem.Size = New System.Drawing.Size(171, 22)
        Me.CheckForUpdatesToolStripMenuItem.Text = "&Check for Updates"
        '
        'HelpOnlineToolStripMenuItem
        '
        Me.HelpOnlineToolStripMenuItem.AutoToolTip = True
        Me.HelpOnlineToolStripMenuItem.Name = "HelpOnlineToolStripMenuItem"
        Me.HelpOnlineToolStripMenuItem.Size = New System.Drawing.Size(171, 22)
        Me.HelpOnlineToolStripMenuItem.Text = "&Online-Support"
        '
        'FeedbackToolStripMenuItem
        '
        Me.FeedbackToolStripMenuItem.Name = "FeedbackToolStripMenuItem"
        Me.FeedbackToolStripMenuItem.Size = New System.Drawing.Size(171, 22)
        Me.FeedbackToolStripMenuItem.Text = "&feedback"
        '
        'ToolStripSeparator3
        '
        Me.ToolStripSeparator3.Name = "ToolStripSeparator3"
        Me.ToolStripSeparator3.Size = New System.Drawing.Size(168, 6)
        '
        'CreateShortcutToolStripMenuItem
        '
        Me.CreateShortcutToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.DesktopLinkToolStripMenuItem, Me.StartMenuLinkToolStripMenuItem})
        Me.CreateShortcutToolStripMenuItem.Name = "CreateShortcutToolStripMenuItem"
        Me.CreateShortcutToolStripMenuItem.Size = New System.Drawing.Size(171, 22)
        Me.CreateShortcutToolStripMenuItem.Text = "&Create Shortcut"
        '
        'DesktopLinkToolStripMenuItem
        '
        Me.DesktopLinkToolStripMenuItem.AutoToolTip = True
        Me.DesktopLinkToolStripMenuItem.Name = "DesktopLinkToolStripMenuItem"
        Me.DesktopLinkToolStripMenuItem.Size = New System.Drawing.Size(134, 22)
        Me.DesktopLinkToolStripMenuItem.Text = "Desktop"
        Me.DesktopLinkToolStripMenuItem.ToolTipText = "Create a shortcut for this app on the desktop"
        '
        'StartMenuLinkToolStripMenuItem
        '
        Me.StartMenuLinkToolStripMenuItem.AutoToolTip = True
        Me.StartMenuLinkToolStripMenuItem.Name = "StartMenuLinkToolStripMenuItem"
        Me.StartMenuLinkToolStripMenuItem.Size = New System.Drawing.Size(134, 22)
        Me.StartMenuLinkToolStripMenuItem.Text = "Start-Menu"
        Me.StartMenuLinkToolStripMenuItem.ToolTipText = "Create a shortcut for this app in the Start-Menu"
        '
        'GroupBox5
        '
        Me.GroupBox5.Controls.Add(Me.Button13)
        Me.GroupBox5.Controls.Add(Me.Button5)
        Me.GroupBox5.Location = New System.Drawing.Point(8, 30)
        Me.GroupBox5.Name = "GroupBox5"
        Me.GroupBox5.Size = New System.Drawing.Size(109, 57)
        Me.GroupBox5.TabIndex = 76
        Me.GroupBox5.TabStop = False
        Me.GroupBox5.Text = "Repair | Drivers"
        '
        'WebBrowser1
        '
        Me.WebBrowser1.AllowNavigation = False
        Me.WebBrowser1.AllowWebBrowserDrop = False
        Me.WebBrowser1.Location = New System.Drawing.Point(908, 3)
        Me.WebBrowser1.MinimumSize = New System.Drawing.Size(20, 20)
        Me.WebBrowser1.Name = "WebBrowser1"
        Me.WebBrowser1.ScrollBarsEnabled = False
        Me.WebBrowser1.Size = New System.Drawing.Size(20, 20)
        Me.WebBrowser1.TabIndex = 77
        Me.WebBrowser1.TabStop = False
        Me.WebBrowser1.Url = New System.Uri("https://www.toremetal.com/windows/mb-tools/version.txt", System.UriKind.Absolute)
        Me.WebBrowser1.Visible = False
        '
        'Timer3
        '
        Me.Timer3.Enabled = True
        Me.Timer3.Interval = 1000
        '
        'Timer4
        '
        Me.Timer4.Interval = 1000
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.SteelBlue
        Me.ClientSize = New System.Drawing.Size(931, 347)
        Me.Controls.Add(Me.WebBrowser1)
        Me.Controls.Add(Me.GroupBox5)
        Me.Controls.Add(Me.Boot_Tools)
        Me.Controls.Add(Me.VHDTOOLS)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.MountFolder)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.Button10)
        Me.Controls.Add(Me.Selected_Index)
        Me.Controls.Add(Me.DriveImagingTools)
        Me.Controls.Add(Me.LabelDriverStatus)
        Me.Controls.Add(Me.UnMountingStatus)
        Me.Controls.Add(Me.MountingStatus)
        Me.Controls.Add(Me.WimFile)
        Me.Controls.Add(Me.LastCmd)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Label_WimFile)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.Label_Index)
        Me.Controls.Add(Me.CmdsOutput)
        Me.Controls.Add(Me.ProgressBar1)
        Me.Controls.Add(Me.MenuStrip1)
        Me.Font = New System.Drawing.Font("Tempus Sans ITC", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Margin = New System.Windows.Forms.Padding(5, 6, 5, 6)
        Me.MaximizeBox = False
        Me.Name = "Form1"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "™T©ReMeTaL - ™MB-To©lB©x "
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.GroupBox3.ResumeLayout(False)
        Me.VHDTOOLS.ResumeLayout(False)
        Me.VHDTOOLS.PerformLayout()
        Me.DriveImagingTools.ResumeLayout(False)
        Me.DriveImagingTools.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.Boot_Tools.ResumeLayout(False)
        Me.Boot_Tools.PerformLayout()
        Me.OptionGroup.ResumeLayout(False)
        Me.OptionGroup.PerformLayout()
        Me.GroupBox4.ResumeLayout(False)
        Me.GroupBox4.PerformLayout()
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.GroupBox5.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents FolderBrowserDialog1 As FolderBrowserDialog
    Friend WithEvents OpenFileDialog1 As OpenFileDialog
    Friend WithEvents WimFile As TextBox
    Friend WithEvents MountFolder As TextBox
    Friend WithEvents Label_WimFile As Label
    Friend WithEvents Label_Index As Label
    Friend WithEvents Button1 As Button
    Friend WithEvents ToolTip1 As ToolTip
    Friend WithEvents BackgroundWorker1 As System.ComponentModel.BackgroundWorker
    Friend WithEvents MountingStatus As Label
    Friend WithEvents LastCmd As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Button2 As Button
    Friend WithEvents UnMountingStatus As Label
    Friend WithEvents CommitChanges As CheckBox
    Friend WithEvents LabelDriverStatus As Label
    Friend WithEvents Button5 As Button
    Friend WithEvents Button7 As Button
    Friend WithEvents VHDTOOLS As GroupBox
    Friend WithEvents Button8 As Button
    Friend WithEvents Label4 As Label
    Friend WithEvents VHD_file As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents SizeMB As TextBox
    Friend WithEvents AttachVhdBtn As Button
    Friend WithEvents CreateVhdBtn As Button
    Friend WithEvents SizeGB As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents CheckBox1 As CheckBox
    Friend WithEvents Button10 As Button
    Friend WithEvents Button13 As Button
    Friend WithEvents Used_Drives As DomainUpDown
    Friend WithEvents ReScanDrives As Button
    Friend WithEvents ApplyMedia As Button
    Friend WithEvents CI_CheckBox As CheckBox
    Friend WithEvents VERIFY_CheckBox As CheckBox
    Friend WithEvents CaptureImage As Button
    Friend WithEvents InternalImageName As TextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents EA_CheckBox As CheckBox
    Friend WithEvents Label8 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents Label11 As Label
    Friend WithEvents Timer1 As Timer
    Friend WithEvents DriveImagingTools As GroupBox
    Friend WithEvents Button15 As Button
    Friend WithEvents Selected_Index As DomainUpDown
    Friend WithEvents VersionDetails As TextBox
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents CmdsOutput As TextBox
    Friend WithEvents ProgressBar1 As ProgressBar
    Friend WithEvents Timer2 As Timer
    Friend WithEvents RO_CheckBox As CheckBox
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents Label13 As Label
    Friend WithEvents Label12 As Label
    Friend WithEvents GroupBox3 As GroupBox
    Friend WithEvents CreateUSB_OS As Button
    Friend WithEvents Boot_Tools As GroupBox
    Friend WithEvents Install_Image_OnDrive As CheckBox
    Friend WithEvents Has_Boot_Sector As CheckBox
    Friend WithEvents BootableTargetDrive As DomainUpDown
    Friend WithEvents Label14 As Label
    Friend WithEvents Button16 As Button
    Friend WithEvents Button18 As Button
    Friend WithEvents Button19 As Button
    Friend WithEvents Button20 As Button
    Friend WithEvents Label16 As Label
    Friend WithEvents Label15 As Label
    Friend WithEvents Sdi_Path As TextBox
    Friend WithEvents Wim_Path As TextBox
    Friend WithEvents GroupBox4 As GroupBox
    Friend WithEvents Label17 As Label
    Friend WithEvents CheckBox2 As CheckBox
    Friend WithEvents BackgroundWorker2 As System.ComponentModel.BackgroundWorker
    Friend WithEvents BackgroundWorker3 As System.ComponentModel.BackgroundWorker
    Friend WithEvents Boot_Menu As DomainUpDown
    Friend WithEvents BootDetails As Label
    Friend WithEvents Label18 As Label
    Friend WithEvents OptionGroup As GroupBox
    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents FileToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents NewToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents OpenToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents toolStripSeparator As ToolStripSeparator
    Friend WithEvents SaveToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents toolStripSeparator1 As ToolStripSeparator
    Friend WithEvents ExitToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ToolsToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents CustomizeToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents OptionsToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents HelpToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents BootToolsToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents WinPEToolsToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents CreateOfflineScriptsToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents VMVHDToolsToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ScanToolsToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ReScanForDrivesToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ReScanBootEntriesToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ReScanWimInfoToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents toolStripSeparator5 As ToolStripSeparator
    Friend WithEvents AboutToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents CreateShortcutToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents DesktopLinkToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents StartMenuLinkToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents SaveFileDialog1 As SaveFileDialog
    Friend WithEvents ToolStripSeparator2 As ToolStripSeparator
    Friend WithEvents GroupBox5 As GroupBox
    Friend WithEvents CheckForUpdatesToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents HelpOnlineToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents WebBrowser1 As WebBrowser
    Friend WithEvents Timer3 As Timer
    Friend WithEvents Timer4 As Timer
    Friend WithEvents FeedbackToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ToolStripSeparator3 As ToolStripSeparator
End Class
