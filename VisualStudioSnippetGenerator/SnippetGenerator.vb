Imports System.IO
Imports VisualStudioSnippetGenerator.My

Public Class SnippetGenerator
    Dim appTitle = System.Reflection.Assembly.GetExecutingAssembly.GetName.Name

    ''' <summary>
    ''' tmpStr hold the current value of the text to be replaced.
    ''' </summary>
    Dim tmpStr As String

    ''' <summary>
    ''' holds the old value of the field for parsing to replace with the new value
    ''' </summary>
    Dim titleStr As String = "<Title></Title>"
    Private Sub Title_TextChanged(sender As Object, e As EventArgs) Handles Title.TextChanged
        tmpStr = "<Title>" & Title.Text & "</Title>"
        SnippetText.Text = SnippetText.Text.Replace(titleStr, tmpStr)
        titleStr = tmpStr
    End Sub

    ''' <summary>
    ''' holds the old value of the field for parsing to replace with the new value
    ''' </summary>
    Dim authorStr As String = "<Author></Author>"
    Private Sub Author_TextChanged(sender As Object, e As EventArgs) Handles Author.TextChanged
        tmpStr = "<Author>" & Author.Text & "</Author>"
        SnippetText.Text = SnippetText.Text.Replace(authorStr, tmpStr)
        authorStr = tmpStr
    End Sub

    ''' <summary>
    ''' holds the old value of the field for parsing to replace with the new value
    ''' </summary>
    Dim shortcutStr As String = "<Shortcut></Shortcut>"
    Private Sub ShortCut_TextChanged(sender As Object, e As EventArgs) Handles ShortCut.TextChanged
        tmpStr = "<Shortcut>" & ShortCut.Text & "</Shortcut>"
        SnippetText.Text = SnippetText.Text.Replace(shortcutStr, tmpStr)
        shortcutStr = tmpStr
    End Sub

    ''' <summary>
    ''' holds the old value of the field for parsing to replace with the new value
    ''' </summary>
    Dim descriptionStr As String = "<Description></Description>"
    Private Sub Description_TextChanged(sender As Object, e As EventArgs) Handles Description.TextChanged
        tmpStr = "<Description>" & Description.Text & "</Description>"
        SnippetText.Text = SnippetText.Text.Replace(descriptionStr, tmpStr)
        descriptionStr = tmpStr
    End Sub

    ''' <summary>
    ''' holds the old value of the field for parsing to replace with the new value
    ''' </summary>
    Dim snippetTypeStr As String = "<SnippetType></SnippetType>"
    Private Sub SnippetType_SelectedItemChanged(sender As Object, e As EventArgs) Handles SnippetType.SelectedItemChanged
        tmpStr = "<SnippetType>" & SnippetType.Text & "</SnippetType>"
        SnippetText.Text = SnippetText.Text.Replace(snippetTypeStr, tmpStr)
        snippetTypeStr = tmpStr
    End Sub

    ''' <summary>
    ''' holds the old value of the field for parsing to replace with the new value
    ''' </summary>
    Dim idStr As String = "<ID></ID>"
    Private Sub LiteralId_TextChanged(sender As Object, e As EventArgs) Handles LiteralId.TextChanged
        tmpStr = "<ID>" & LiteralId.Text & "</ID>"
        SnippetText.Text = SnippetText.Text.Replace(idStr, tmpStr)
        idStr = tmpStr
    End Sub

    ''' <summary>
    ''' holds the old value of the field for parsing to replace with the new value
    ''' </summary>
    Dim tooltipStr As String = "<ToolTip></ToolTip>"
    Private Sub LiteralToolTip_TextChanged(sender As Object, e As EventArgs) Handles LiteralToolTip.TextChanged
        tmpStr = "<ToolTip>" & LiteralToolTip.Text & "</ToolTip>"
        SnippetText.Text = SnippetText.Text.Replace(tooltipStr, tmpStr)
        tooltipStr = tmpStr
    End Sub

    ''' <summary>
    ''' holds the old value of the field for parsing to replace with the new value
    ''' </summary>
    Dim defaultStr As String = "<Default></Default>"
    Private Sub DefaultValue_TextChanged(sender As Object, e As EventArgs) Handles DefaultValue.TextChanged
        tmpStr = "<Default>" & DefaultValue.Text & "</Default>"
        SnippetText.Text = SnippetText.Text.Replace(defaultStr, tmpStr)
        defaultStr = tmpStr
    End Sub

    ''' <summary>
    ''' holds the old value of the field for parsing to replace with the new value
    ''' </summary>
    Dim codeLanguageStr As String = "Language=" & Chr(34) & Chr(34)
    Private Sub CodeLanguage_SelectedItemChanged(sender As Object, e As EventArgs) Handles CodeLanguage.SelectedItemChanged
        tmpStr = "Language=" & Chr(34) & CodeLanguage.Text & Chr(34)
        SnippetText.Text = SnippetText.Text.Replace(codeLanguageStr, tmpStr)
        codeLanguageStr = tmpStr
    End Sub

    ''' <summary>
    ''' holds the old value of the field for parsing to replace with the new value
    ''' </summary>
    Dim codeStr As String = "<![CDATA[]]>"
    Private Sub Code_TextChanged(sender As Object, e As EventArgs) Handles Code.TextChanged
        tmpStr = "<![CDATA[" & Code.Text & "]]>"
        SnippetText.Text = SnippetText.Text.Replace(codeStr, tmpStr)
        codeStr = tmpStr
    End Sub

    ''' <summary>
    ''' Show Help on [Click] of any label
    ''' </summary>
    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click
        MyToolTip.Visible = True
    End Sub

    ''' <summary>
    ''' Show Help on [Click] of any label
    ''' </summary>
    Private Sub Label2_Click(sender As Object, e As EventArgs) Handles Label2.Click
        MyToolTip.Visible = True
    End Sub

    ''' <summary>
    ''' Show Help on [Click] of any label
    ''' </summary>
    Private Sub Label3_Click(sender As Object, e As EventArgs) Handles Label3.Click
        MyToolTip.Visible = True
    End Sub

    ''' <summary>
    ''' Show Help on [Click] of any label
    ''' </summary>
    Private Sub Label4_Click(sender As Object, e As EventArgs) Handles Label4.Click
        MyToolTip.Visible = True
    End Sub

    ''' <summary>
    ''' Show Help on [Click] of any label
    ''' </summary>
    Private Sub Label5_Click(sender As Object, e As EventArgs) Handles Label5.Click
        MyToolTip.Visible = True
    End Sub

    ''' <summary>
    ''' Show Help on [Click] of any label
    ''' </summary>
    Private Sub Label6_Click(sender As Object, e As EventArgs) Handles Label6.Click
        MyToolTip.Visible = True
    End Sub

    ''' <summary>
    ''' Show Help on [Click] of any label
    ''' </summary>
    Private Sub Label7_Click(sender As Object, e As EventArgs) Handles Label7.Click
        MyToolTip.Visible = True
    End Sub

    ''' <summary>
    ''' Show Help on [Click] of any label
    ''' </summary>
    Private Sub Label8_Click(sender As Object, e As EventArgs) Handles Label8.Click
        MyToolTip.Visible = True
    End Sub

    ''' <summary>
    ''' Show Help on [Click] of any label
    ''' </summary>
    Private Sub Label9_Click(sender As Object, e As EventArgs) Handles Label9.Click
        MyToolTip.Visible = True
    End Sub

    ''' <summary>
    ''' Show Help on [Click] of any label
    ''' </summary>
    Private Sub Label10_Click(sender As Object, e As EventArgs) Handles Label10.Click
        MyToolTip.Visible = True
    End Sub

    ''' <summary>
    ''' Hide Help on [Click] of the tool-tip popup
    ''' </summary>
    Private Sub MyToolTip_Click(sender As Object, e As EventArgs) Handles MyToolTip.Click
        MyToolTip.Visible = False
    End Sub

    Private Sub FolderBrowserDialog1_HelpRequest(sender As Object, e As EventArgs) Handles FolderBrowserDialog1.HelpRequest
        MsgBox("Select the location to save the code snippet in.", MsgBoxStyle.MsgBoxHelp)
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If Title.Text.Length > 0 Then
            If FolderBrowserDialog1.ShowDialog() = DialogResult.OK Then
                Dim theFile As String = FolderBrowserDialog1.SelectedPath & "\" & Title.Text & ".snippet"
                Dim writeFile = True
                If FileIO.FileSystem.FileExists(theFile) Then
                    Dim theMsg = MsgBox("### File exists!!" & Environment.NewLine &
                              "Do you want to increment the file? (Yes)" & Environment.NewLine &
                              "(No) Overwrite the file" & Environment.NewLine &
                              "or (Cancel)" & Environment.NewLine &
                          theFile,
                          MsgBoxStyle.Question & MsgBoxStyle.YesNoCancel, appTitle)
                    If theMsg = MsgBoxResult.Yes Then
                        Dim curCountStr = "(1)"
                        If FileIO.FileSystem.FileExists(theFile.Replace(".snippet", curCountStr & ".snippet")) Then
                            Dim i = 2
                            While FileIO.FileSystem.FileExists(theFile.Replace(".snippet", curCountStr & ".snippet"))
                                curCountStr = "(" & i & ")"
                                i = i + 1
                            End While
                        End If
                        theFile = theFile.Replace(".snippet", curCountStr & ".snippet")
                    ElseIf theMsg = MsgBoxResult.No Then
                    ElseIf theMsg = MsgBoxResult.Cancel Then
                        writeFile = False
                    End If
                End If
                If writeFile Then
                    FileIO.FileSystem.WriteAllText(theFile, Code.Text, False)
                    If MsgBox(Title.Text & ".snippet" & " saved at" & Environment.NewLine &
                              theFile & Environment.NewLine &
                              "View in File Browser?",
                              MsgBoxStyle.Question & MsgBoxStyle.YesNo, appTitle) = MsgBoxResult.Yes Then
                        Process.Start(FolderBrowserDialog1.SelectedPath)
                    End If
                End If
            End If
        Else
            MsgBox("Please Enter a Title", MsgBoxStyle.ApplicationModal, appTitle)
        End If
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        MyToolTip.Visible = True
    End Sub

    Private Sub SnippetGenerator_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If Not My.Settings.LicenseAccepted Then
            If Dialog1.ShowDialog() = DialogResult.OK Then
                My.Settings.LicenseAccepted = True
                My.Settings.Save()
            Else
                Close()
            End If
        End If
    End Sub
End Class
