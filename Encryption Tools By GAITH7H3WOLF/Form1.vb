Imports System.IO

Public Class Form1

    Private Sub GhostButton1_Click(sender As Object, e As EventArgs) Handles GhostButton1.Click
        Dim ofd As New OpenFileDialog
        ofd.Filter = "Executable|*.exe"
        If ofd.ShowDialog = Windows.Forms.DialogResult.OK Then TextBox1.Text = ofd.FileName Else TextBox1.Text = ""
    End Sub

    Private Sub GhostButton2_Click(sender As Object, e As EventArgs) Handles GhostButton2.Click
        Clipboard.Clear()
        If TextBox2.Text = "" Then
            MsgBox("No Text To Copie", MsgBoxStyle.Critical, "Information")
            Exit Sub
        End If
        Clipboard.SetText(TextBox2.Text)
        MsgBox("Copied", MsgBoxStyle.Information, "Information")
    End Sub

    Private Sub GhostButton3_Click(sender As Object, e As EventArgs) Handles GhostButton3.Click
        TextBox2.Text = ""
        TextBox2.Text = Clipboard.GetText
    End Sub

    Private Sub GhostButton5_Click(sender As Object, e As EventArgs)
        Dim ofd As New OpenFileDialog
        ofd.Filter = "Visual Basic File|*.vb*"
        If ofd.ShowDialog = Windows.Forms.DialogResult.OK Then
            TextBox2.Text = File.ReadAllText(ofd.FileName)
        End If
    End Sub

    Private Sub GhostButton4_Click(sender As Object, e As EventArgs) Handles GhostButton4.Click
        Dim sfd As New SaveFileDialog ' New SaveFileDialog to chosse the server location
        sfd.Filter = "Visual Basic File|*.vb"
        If sfd.ShowDialog = Windows.Forms.DialogResult.OK Then
            File.WriteAllText(sfd.FileName, TextBox2.Text)
            MsgBox("Saved in : " & sfd.FileName, MsgBoxStyle.Information, "Information")
        End If
    End Sub

    Private Sub GhostButton20_Click(sender As Object, e As EventArgs) Handles GhostButton20.Click
        TextBox2.Text = ""
    End Sub

    Private Sub GhostButton6_Click(sender As Object, e As EventArgs) Handles GhostButton6.Click
        If TextBox1.Text = "" Then
            MsgBox("Please Add File To Convert", MsgBoxStyle.Critical)
        Else
            Try
                TextBox2.Text = ""
                Dim gaith() As Byte = System.IO.File.ReadAllBytes(TextBox1.Text) 'compress
                TextBox2.Text = Convert.ToBase64String(gaith)
            Catch ex As Exception
            End Try
        End If
    End Sub

    Private Sub GhostButton7_Click(sender As Object, e As EventArgs) Handles GhostButton7.Click
        If TextBox1.Text = "" Then
            MsgBox("Please Add File To Convert", MsgBoxStyle.Critical)
        Else
            Try
                TextBox2.Text = ""
                Dim gaith() As Byte = Compression.Compress(System.IO.File.ReadAllBytes(TextBox1.Text)) 'compress
                TextBox2.Text = Convert.ToBase64String(gaith)
            Catch ex As Exception
            End Try
        End If
    End Sub

    Private Sub GhostButton8_Click(sender As Object, e As EventArgs) Handles GhostButton8.Click
        TextBox3.Text = GeneratePassword(True, True, False, False, RandomNumber(10, 8))
        TextBox4.Text = GeneratePassword(True, True, False, False, RandomNumber(10, 8))
    End Sub

    Private Sub GhostButton9_Click(sender As Object, e As EventArgs) Handles GhostButton9.Click
        If TextBox1.Text = "" Then
            MsgBox("Please Add File To Convert", MsgBoxStyle.Critical)
        Else
            Dim num As Long
            Dim num3 As Integer = Convert.ToInt32(NumericUpDown1.Value)
            Dim text As String = TextBox1.Text
            Dim writer As New StreamWriter((Application.StartupPath & "/tempo.tmp"))
            Dim length As Long = New FileInfo(TextBox1.Text).Length
            Dim strArray As String() = New String((CInt(length) + 1) - 1) {}
            Dim buffer As Byte() = New Byte((CInt(length) + 1) - 1) {}
            buffer = FileToByteArray(TextBox1.Text)
            length = (length - 1)
            writer.Write(String.Concat(New String() {"Public Class GAITH7H3WOLF" & vbNewLine & "Dim ", TextBox4.Text, " As String" & ChrW(13) & ChrW(10) & ChrW(13) & ChrW(10) & ChrW(13) & ChrW(10) & "Sub ", TextBox3.Text, "()" & ChrW(13) & ChrW(10)}))
            Dim num4 As Long = length
            num = 0
            Do While (num <= num4)
                strArray(CInt(num)) = Conversion.Hex(buffer(CInt(num)))
                If (strArray(CInt(num)).Length = 1) Then
                    strArray(CInt(num)) = ("0" & strArray(CInt(num)))
                End If
                num = (num + 1)
            Loop
            writer.Write((ChrW(13) & ChrW(10) & TextBox4.Text & " = """ & strArray(0)))
            Dim num5 As Long = length
            num = 1
            Do While (num <= num5)
                If ((CDbl(num) Mod (CDbl(num3) / 2)) = 0) Then
                    writer.Write(String.Concat(New String() {"""" & ChrW(13) & ChrW(10), TextBox4.Text, " = ", TextBox4.Text, " & """, strArray(CInt(num))}))
                Else
                    writer.Write(strArray(CInt(num)))
                End If
                num = (num + 1)
            Loop
            writer.Write("""" & ChrW(13) & ChrW(10) & ChrW(13) & ChrW(10) & "End Sub" & vbNewLine & "End Class")
            writer.Close()
            TextBox2.Text = File.ReadAllText(Application.StartupPath & "/tempo.tmp")
            File.Delete(Application.StartupPath & "/tempo.tmp")
        End If
    End Sub

    Private Sub GhostButton13_Click(sender As Object, e As EventArgs) Handles GhostButton13.Click
        If Radiobutton1.Checked = True Then
            TextBox2.Text = ""
            TextBox2.Text = "'Coded By GAITH7H3WOLF" & vbNewLine & vbNewLine
            TextBox2.Text += "Imports System.IO.Compression" & vbNewLine
            TextBox2.Text += "Imports System.IO" & vbNewLine & vbNewLine
            TextBox2.Text += My.Resources.CompressVB
        Else
            TextBox2.Text = ""
            TextBox2.Text += My.Resources.CompressC
        End If
    End Sub

    Private Sub GhostButton14_Click(sender As Object, e As EventArgs) Handles GhostButton14.Click
        If Radiobutton1.Checked = True Then
            TextBox2.Text = ""
            'Hex2Byte()
            TextBox2.Text = "'Coded By GAITH7H3WOLF" & vbNewLine & vbNewLine
            TextBox2.Text += Hex2ByteVB()
        Else
            TextBox2.Text = ""
            'Hex2Byte()
            TextBox2.Text = Hex2ByteC()
        End If
    End Sub

    Private Sub GhostButton15_Click(sender As Object, e As EventArgs) Handles GhostButton15.Click
        If Radiobutton1.Checked = True Then
            TextBox2.Text = ""
            TextBox2.Text = "'Coded By GAITH7H3WOLF" & vbNewLine & vbNewLine
            TextBox2.Text += My.Resources.ResWritVBCode
        Else
            TextBox2.Text = ""
            TextBox2.Text = My.Resources.ResWritCCod
        End If
    End Sub

    Private Sub GhostButton16_Click(sender As Object, e As EventArgs) Handles GhostButton16.Click
        If Radiobutton1.Checked = True Then
            TextBox2.Text = ""
            TextBox2.Text = "'Coded By GAITH7H3WOLF" & vbNewLine & vbNewLine
            TextBox2.Text = "Imports System.Runtime.InteropServices" & vbNewLine
            TextBox2.Text += ResourceWriterVB()
            Form2.Show()
        Else
            TextBox2.Text = ""
            TextBox2.Text += ResourceWriterC()
            Form2.Show()
        End If
    End Sub

    Private Sub GhostButton17_Click(sender As Object, e As EventArgs) Handles GhostButton17.Click
        If Radiobutton1.Checked = True Then
            TextBox2.Text = ""
            TextBox2.Text = JunkStringVB(NumericUpDown2.Value)
        Else
            TextBox2.Text = ""
            TextBox2.Text = JunkStringC(NumericUpDown2.Value)
        End If
    End Sub

    Private Sub GhostButton18_Click(sender As Object, e As EventArgs) Handles GhostButton18.Click
        If Radiobutton1.Checked = True Then
            TextBox2.Text = ""
            TextBox2.Text = "'Coded By GAITH7H3WOLF" & vbNewLine & vbNewLine
            TextBox2.Text += GenerateJunk(NumericUpDown3.Value)
        Else
            'TextBox2.Text = ""
            'TextBox2.Text = JunkStringC(NumericUpDown3.Value)
            MsgBox("Not Yet")
        End If
    End Sub

    Private Sub GhostButton10_Click(sender As Object, e As EventArgs) Handles GhostButton10.Click
        If Radiobutton1.Checked = True Then
            TextBox2.Text = ""
            TextBox2.Text = "'Coded By GAITH7H3WOLF" & vbNewLine & vbNewLine
            TextBox2.Text += "Imports System.Runtime.InteropServices" & vbNewLine
            TextBox2.Text &= "Imports System.Text" & vbNewLine & vbNewLine
            TextBox2.Text &= RunPE1VB()
            Form2.Show()
        Else
            TextBox2.Text = ""
            TextBox2.Text &= RunPE1C()
            Form2.Show()
        End If
    End Sub

    Private Sub GhostButton11_Click(sender As Object, e As EventArgs) Handles GhostButton11.Click
        If Radiobutton1.Checked = True Then
            TextBox2.Text = ""
            TextBox2.Text = "'Coded By GAITH7H3WOLF" & vbNewLine & vbNewLine
            TextBox2.Text = "Imports System, System.Collections.Generic " & vbNewLine
            TextBox2.Text &= "Imports System.Text, System.IO.Compression" & vbNewLine
            TextBox2.Text &= "Imports System.Reflection, System.IO" & vbNewLine & vbNewLine
            TextBox2.Text &= RunPE2VB()
            Form2.Show()
        Else
            TextBox2.Text = ""
            TextBox2.Text &= RunPE2C()
            'TextBox2.Text = My.Resources.RunPE2C
            Form2.Show()
        End If
    End Sub

    Private Sub GhostButton12_Click(sender As Object, e As EventArgs) Handles GhostButton12.Click
        If Radiobutton1.Checked = True Then
            TextBox2.Text = ""
            TextBox2.Text = "'Coded By GAITH7H3WOLF" & vbNewLine & vbNewLine
            TextBox2.Text = "Imports System.Runtime.InteropServices" & vbNewLine
            TextBox2.Text &= "Imports System.Text" & vbNewLine & vbNewLine
            TextBox2.Text &= RunPE3VB()
            Form2.Show()

        Else
            TextBox2.Text = ""
            TextBox2.Text &= RunPE3C()
            Form2.Show()
        End If
    End Sub

    Private Sub GhostButton5_Click_1(sender As Object, e As EventArgs) Handles GhostButton5.Click
        Form3.Show()
    End Sub

    Private Sub GhostButton19_Click(sender As Object, e As EventArgs) Handles GhostButton19.Click
        About.Show()
    End Sub
End Class
