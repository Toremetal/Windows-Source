Public Class Form1
    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles TextBox1.TextChanged
        If Not TextBox1.Text = "" Then
            Button1.Enabled = True
        Else
            LabelNotSafe.Visible = False
            LabelSafe.Visible = False
        End If
        If Not TextBox2.Text = "" Then
            If TextBox1.Text = TextBox2.Text Then
                LabelNotSafe.Visible = False
                LabelSafe.Visible = True
            Else
                LabelNotSafe.Visible = True
                LabelSafe.Visible = False
            End If
        Else
            LabelNotSafe.Visible = False
            LabelSafe.Visible = False
        End If
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        'OpenFileDialog1.InitialDirectory = FileIO.SpecialDirectories.Desktop.Replace("Desktop", "Downloads")
        If OpenFileDialog1.ShowDialog() = DialogResult.OK Then
            Dim TmpOUTPUT As String

            Try
                Dim chk As New Process
                Dim sIm As ProcessStartInfo = chk.StartInfo
                sIm.FileName = "C:\windows\system32\cmd.exe"
                sIm.Arguments = " /c  certutil -hashfile " + Chr(34) + OpenFileDialog1.FileName + Chr(34) + " " + DomainUpDown1.Text + " & exit"
                sIm.RedirectStandardOutput = True
                sIm.UseShellExecute = False
                sIm.CreateNoWindow = True
                chk.Start()
                TmpOUTPUT = chk.StandardOutput.ReadToEnd().Replace(DomainUpDown1.Text + " hash of " + OpenFileDialog1.FileName + ":", "").Replace("CertUtil: -hashfile command completed successfully.", "").Replace(" ", "").Replace(Environment.NewLine.ToString(), "")
                'While Not chk.StandardOutput.EndOfStream()
                'TmpOUTPUT = chk.StandardOutput.ReadLine().ToString()
                'If Not TmpOUTPUT = "" And Not TmpOUTPUT = " " Then CmdOUTPUT = TmpOUTPUT + Environment.NewLine + CmdOUTPUT
                'End While
                chk.WaitForExit()
                If Not chk.ExitCode = 0 Then
                    MsgBox("An ERROR occurred")
                End If
                TextBox2.Text = TmpOUTPUT
            Catch ex As Exception
                MsgBox("An ERROR occurred")
            End Try

        End If
        'SHA256 hash of C:\Users\ToReMeTaL\Downloads\putty-64bit-0.83-installer.msi:
        '        aa8e5036d973688f1e8622fbe9ab22e037346e0def0197bf5e7cdf37da4e223d
        'CertUtil: -hashfile command completed successfully.
        '
        ' certutil -hashfile C:\Users\YourUser\Downloads\example.iso SHA256
    End Sub

    Private Sub TextBox2_TextChanged(sender As Object, e As EventArgs) Handles TextBox2.TextChanged
        If TextBox1.Text = TextBox2.Text Then
            LabelNotSafe.Visible = False
            LabelSafe.Visible = True
        Else
            LabelNotSafe.Visible = True
            LabelSafe.Visible = False
        End If
    End Sub
End Class
