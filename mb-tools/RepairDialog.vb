'==========================================================================
'                       Copyright(C) 2025  ™T©ReMeTaL 
'                           https://toremetal.com
'
'    This program Is free software: you can redistribute it And/Or modify
'    it under the terms Of the GNU General Public License As published by
'    the Free Software Foundation, either version 3 Of the License, Or
'    (at your option) any later version.
'
'    This program Is distributed In the hope that it will be useful,
'    but WITHOUT ANY WARRANTY; without even the implied warranty Of
'    MERCHANTABILITY Or FITNESS FOR A PARTICULAR PURPOSE.  See the
'    GNU General Public License For more details.
'
'    You should have received a copy Of the GNU General Public License
'    along with this program.  If Not, see <https://www.gnu.org/licenses/>.
'==========================================================================
Imports MB_Tools.Form1
Imports Microsoft.VisualBasic.FileIO

Public Class RepairDialog

    Private Sub ButtonRemountImage_Click(sender As Object, e As EventArgs) Handles ButtonRemountImage.Click
        ButtonRemountImage.Enabled = False
        Form1.currentCmd = "Dism.exe /Remount-Image /MountDir:" + Chr(34) + Form1.MountFolder.Text + Chr(34)
        If Not Form1.RunTheCmd() Then
            Form1.LastCmd.Text = "Operation Cancelled"
            ButtonRemountImage.Enabled = True
        End If
    End Sub

    Private Sub Button11_Click(sender As Object, e As EventArgs) Handles Button11.Click
        Button11.Enabled = False
        Form1.currentCmd = "Dism.exe /Cleanup-Mountpoints"
        If Not Form1.RunTheCmd() Then
            Form1.LastCmd.Text = "Operation Cancelled"
            Button11.Enabled = True
        End If
    End Sub

    Private Sub RepairDialog_Closing(sender As Object, e As EventArgs) Handles MyBase.Closing
        Form1.CheckButtons(APP_OPS.S_REPAIR_TOOLS)
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Button1.Enabled = False
        Dim ResetBase As String = ""
        If Reset_Base.Checked Then
            ResetBase = " /ResetBase"
        End If
        Dim OnlineSys As String
        If CheckBox2.Checked Then
            CheckBox2.Text = "Running System"
            OnlineSys = " /online"
        Else
            OnlineSys = " /image:" + Form1.MountFolder.Text
            CheckBox2.Text = "..." + Form1.MountFolder.Text.Substring(-5, Form1.MountFolder.Text.Length)
        End If
        Form1.currentCmd = "Dism.exe" + OnlineSys + " /Cleanup-Image /StartComponentCleanup" + ResetBase
        If Not Form1.RunTheCmd() Then
            Form1.LastCmd.Text = "Operation Cancelled"
            Button1.Enabled = True
        End If
    End Sub

    Private Sub CheckBox2_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox2.CheckedChanged
        If CheckBox2.Checked Then
            CheckBox2.Text = "Current System"
        Else
            CheckBox2.Text = "..." + Form1.MountFolder.Text.Substring(-5, Form1.MountFolder.Text.Length)
        End If
    End Sub

    Private Sub ResetBase_CheckedChanged(sender As Object, e As EventArgs) Handles Reset_Base.CheckedChanged

    End Sub

    Private Sub RepairDialog_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If Not Form1.MountFolder.Text = "" Then
            If Not FileIO.FileSystem.FileExists(Form1.MountFolder.Text) Then
                CheckBox2.Checked = True
                CheckBox2.Enabled = False
            End If
        End If
        If FileIO.FileSystem.FileExists("cmd-list.txt") Then
            DomainUpDown1.Items.Clear()
            Dim tFile As IO.StreamReader = FileIO.FileSystem.OpenTextFileReader(SpecialDirectories.MyDocuments + "\mb-tools\cmd-list.txt")
            Do Until (tFile.EndOfStream())
                DomainUpDown1.Items.Add(tFile.ReadLine())
            Loop
            Try
                DomainUpDown1.SelectedIndex = 0
            Catch ex As Exception

            End Try
        ElseIf FileIO.FileSystem.FileExists(SpecialDirectories.MyDocuments + "\mb-tools\cmd-list.txt") Then
            DomainUpDown1.Items.Clear()
            Dim tFile As IO.StreamReader = FileIO.FileSystem.OpenTextFileReader(SpecialDirectories.MyDocuments + "\mb-tools\cmd-list.txt")
            Do Until (tFile.EndOfStream())
                DomainUpDown1.Items.Add(tFile.ReadLine())
            Loop
            Try
                DomainUpDown1.SelectedIndex = 0
            Catch ex As Exception

            End Try
        Else
            If Not FileIO.FileSystem.DirectoryExists(SpecialDirectories.MyDocuments + "\mb-tools") Then
                Try
                    FileIO.FileSystem.CreateDirectory(SpecialDirectories.MyDocuments + "\mb-tools")
                Catch ex As Exception

                End Try
            End If
            Try
                FileIO.FileSystem.WriteAllText(SpecialDirectories.MyDocuments + "\mb-tools\cmd-list.txt", "start " + Chr(34) + "Computer Management" + Chr(34) + " compmgmt.msc" + Environment.NewLine +
                            "start " + Chr(34) + "Device Manager" + Chr(34) + " devmgmt.msc" + Environment.NewLine +
                            "start " + Chr(34) + "Disk Manager" + Chr(34) + " diskmgmt.msc" + Environment.NewLine +
                            "start " + Chr(34) + "Disk Cleanup" + Chr(34) + " cleanmgr.exe" + Environment.NewLine +
                            "start " + Chr(34) + "Disk Defrag" + Chr(34) + " dfrgui.exe" + Environment.NewLine +
                            "start " + Chr(34) + "Group Policy" + Chr(34) + " gpedit.msc" + Environment.NewLine +
                            "start " + Chr(34) + "Local Users and Groups" + Chr(34) + " lusrmgr.msc" + Environment.NewLine +
                            "start " + Chr(34) + "Local Security Policy" + Chr(34) + " secpol.msc" + Environment.NewLine +
                            "start " + Chr(34) + "User Accounts" + Chr(34) + " netplwiz.exe" + Environment.NewLine +
                            "start " + Chr(34) + "Check Disk -Scan" + Chr(34) + " /B chkdsk C: /scan>" + Chr(34) + "%USERPROFILE%\desktop\chkdsk-report.txt" + Chr(34) + Environment.NewLine +
                            "start " + Chr(34) + "Check Disk -Repair" + Chr(34) + " chkdsk C: /f /r" + Environment.NewLine +
                            "start " + Chr(34) + "Restore System Health" + Chr(34) + " /B dism.exe /online /cleanup-image /restorehealth>" + Chr(34) + "%USERPROFILE%\desktop\dism-report.txt" + Chr(34) + Environment.NewLine +
                            "start " + Chr(34) + "System File Repair" + Chr(34) + " /B sfc /scannow>" + Chr(34) + "%USERPROFILE%\desktop\sfc-report.txt" + Chr(34) + Environment.NewLine +
                            "start " + Chr(34) + "System File Repair" + Chr(34) + " /B sfc /verifyonly>" + Chr(34) + "%USERPROFILE%\desktop\sfc-report.txt" + Chr(34), False)
            Catch ex As Exception

            End Try
        End If
    End Sub

    Private Sub LinkLabel1_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LinkLabel1.LinkClicked
        LinkLabel1.Enabled = False
        Form1.currentCmd = "schtasks.exe /Run /TN " + Chr(34) + "\Microsoft\Windows\Servicing\StartComponentCleanup" + Chr(34)
        If Not Form1.RunTheCmd() Then
            Form1.LastCmd.Text = "Operation Cancelled"
            LinkLabel1.Enabled = True
        End If
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Button1.Enabled = False
        Form1.currentCmd = DomainUpDown1.Text
        If Not Form1.RunTheCmd() Then
            Form1.LastCmd.Text = "Operation Cancelled"
            Button1.Enabled = True
        End If
    End Sub

    Private Sub UnLocked_Btn_Click(sender As Object, e As EventArgs) Handles UnLocked_Btn.Click
        DomainUpDown1.ReadOnly = True
        Locked_Btn.Enabled = True
        Locked_Btn.Visible = True
        UnLocked_Btn.Enabled = False
        UnLocked_Btn.Visible = False
    End Sub

    Private Sub Locked_Btn_Click(sender As Object, e As EventArgs) Handles Locked_Btn.Click
        DomainUpDown1.ReadOnly = False
        Locked_Btn.Enabled = False
        Locked_Btn.Visible = False
        UnLocked_Btn.Enabled = True
        UnLocked_Btn.Visible = True
    End Sub

End Class
