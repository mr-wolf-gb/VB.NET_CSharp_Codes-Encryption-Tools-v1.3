Imports System.IO

Public Class Form3

    Private Sub GhostButton1_Click(sender As Object, e As EventArgs) Handles GhostButton1.Click
        Dim ofd As New OpenFileDialog
        ofd.Filter = "Visual Basic File|*.vb"
        If ofd.ShowDialog = Windows.Forms.DialogResult.OK Then
            TextBox1.Text = ofd.FileName
            If GhostButton3.Text = "Edit" Then
                TextBox2.Text = File.ReadAllText(TextBox1.Text)
                Exit Sub
            End If
            If GhostButton3.Text = "Save Change" Then
                TextBox3.Text = File.ReadAllText(TextBox1.Text)
                Exit Sub
            End If
        Else
            TextBox1.Text = ""
        End If
    End Sub

    Private Sub GhostButton3_Click(sender As Object, e As EventArgs) Handles GhostButton3.Click
        If GhostButton3.Text = "Edit" Then
            TextBox3.Text = TextBox2.Text
            TextBox3.Show()
            GhostButton3.Text = "Save Change"
            Exit Sub
        End If
        If GhostButton3.Text = "Save Change" Then
            TextBox2.Text = TextBox3.Text
            TextBox3.Hide()
            GhostButton3.Text = "Edit"
            Exit Sub
        End If
    End Sub

    Private Sub Form3_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        TextBox3.Hide()
    End Sub

    Private Sub GhostButton2_Click(sender As Object, e As EventArgs) Handles GhostButton2.Click
        If GhostButton3.Text = "Save Change" Then
            TextBox2.Text = TextBox3.Text
            GhostButton3.Text = "Edit"
            TextBox3.Hide()
        End If
        If TextBox2.Text = "" Then Exit Sub
        Dim cc As String = "'//////////////////// Coded By GAITH7H3WOLF ////////////////////" & vbNewLine
        cc += "'-----------------------------------------------------------------------" & vbNewLine

        Dim StrTemp As String = TextBox2.Text

        If TextBox2.Text.Contains("System.Windows.Forms") Then
        Else
            cc += "Imports System.Windows.Forms" & vbNewLine
        End If
        If TextBox2.Text.Contains("System.Diagnostics") Then
        Else
            cc += "Imports System.Diagnostics" & vbNewLine
        End If
        If TextBox2.Text.Contains("System.Text") Then
        Else
            cc += "Imports System.Text" & vbNewLine
        End If
        If TextBox2.Text.Contains("System.IO") Then
        Else
            cc += "Imports System.IO" & vbNewLine
        End If
        If TextBox2.Text.Contains("System.IO.Compression") Then
        Else
            cc += "Imports System.IO.Compression" & vbNewLine
        End If
        If TextBox2.Text.Contains("System.Collections.Generic") Then
        Else
            cc += "Imports System.Collections.Generic" & vbNewLine
        End If
        If TextBox2.Text.Contains("System.Runtime.InteropServices") Then
        Else
            cc += "Imports System.Runtime.InteropServices" & vbNewLine
        End If
        If TextBox2.Text.Contains("Microsoft.VisualBasic") Then
        Else
            cc += "Imports Microsoft.VisualBasic" & vbNewLine
        End If
        If TextBox2.Text.Contains("Import System,") Or TextBox2.Text.Contains("System,") Then
        Else
            cc += "Imports System" & vbNewLine & vbNewLine
        End If

        TextBox2.Text = ""
        TextBox2.Text = cc
        TextBox2.Text += StrTemp

        Try
            Dim sfd As New SaveFileDialog ' New SaveFileDialog to chosse the server location
            sfd.Filter = "Executable|*.exe"
            If sfd.ShowDialog = Windows.Forms.DialogResult.OK Then
                iCompiler.GenerateExecutable(sfd.FileName, TextBox2.Text, "") ' Compile the source using CodeDom
                MsgBox("File Compiled in : " & sfd.FileName, MsgBoxStyle.Information, "Coded By GAITH7H3WOLF")
            Else : Exit Sub
            End If
        Catch ex As Exception
        End Try
    End Sub
End Class