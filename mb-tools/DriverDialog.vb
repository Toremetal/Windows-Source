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
Public Class DriverDialog

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Button3.Enabled = False
        Form1.LabelDriverStatus.Visible = True
        If Not DriverFolder.Text = "" And Not Form1.MountFolder.Text = "" Then
            If Not FileIO.FileSystem.DirectoryExists(DriverFolder.Text) Then
                FileIO.FileSystem.CreateDirectory(DriverFolder.Text)
            End If
            If InstallDrivers.Checked Then
                'Dism.exe /Image:"%IMAGEFOLDER%" /Add-Driver /Driver:"%DRIVERFOLDER%" /recurse
                Form1.currentCmd = "Dism.exe /Image:" + Chr(34) + Form1.MountFolder.Text + Chr(34) + " /Add-Driver /Driver:" + Chr(34) + DriverFolder.Text + Chr(34) + " /recurse"
            Else
                'Dism.exe /Image:"%IMAGEFOLDER%" /Export-Driver /Destination:"%DRIVERFOLDER%"
                Form1.currentCmd = "Dism.exe /Image:" + Chr(34) + Form1.MountFolder.Text + Chr(34) + " /Export-Driver /Destination:" + Chr(34) + DriverFolder.Text + Chr(34)
            End If
        End If
        If Not Form1.RunTheCmd() Then
            Form1.LastCmd.Text = "Operation Cancelled"
            Button3.Enabled = True
            Form1.LabelDriverStatus.Visible = False
        End If
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        Button4.Enabled = False
        Form1.LabelDriverStatus.Visible = True
        If Not DriverFolder.Text = "" Then
            'Dism.exe /online /export-driver /destination:"%DRIVERFOLDER%"
            If Not FileIO.FileSystem.DirectoryExists(DriverFolder.Text) Then
                FileIO.FileSystem.CreateDirectory(DriverFolder.Text)
            End If
            Form1.currentCmd = "Dism.exe /online /export-driver /destination:" + Chr(34) + DriverFolder.Text + Chr(34)
        End If
        If Not Form1.RunTheCmd() Then
            Form1.LastCmd.Text = "Operation Cancelled"
            Button4.Enabled = True
            Form1.LabelDriverStatus.Visible = False
        End If
    End Sub

    Private Sub DriverFolder_TextChanged(sender As Object, e As EventArgs) Handles DriverFolder.Click
        If Not Form1.FolderBrowserDialog1.ShowDialog = DialogResult.Cancel Then
            DriverFolder.Text = Form1.FolderBrowserDialog1.SelectedPath
        End If
    End Sub

    Private Sub Label2_Click(sender As Object, e As EventArgs) Handles Label2.Click
        If Not Form1.FolderBrowserDialog1.ShowDialog = DialogResult.Cancel Then
            DriverFolder.Text = Form1.FolderBrowserDialog1.SelectedPath
        End If
    End Sub

    Private Sub DriverDialog_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub DriverFolder_TextChanged_1(sender As Object, e As EventArgs) Handles DriverFolder.TextChanged
        If Not DriverFolder.Text = "" Then
            If Not Form1.MountFolder.Text = "" Then
                Button3.Enabled = True
                InstallDrivers.Enabled = True
            Else
                Button3.Enabled = False
                InstallDrivers.Enabled = False
            End If
            Button4.Enabled = True
        Else
            Button4.Enabled = False
            Button3.Enabled = False
            InstallDrivers.Enabled = False
        End If
        My.Settings.Save()
    End Sub
End Class
