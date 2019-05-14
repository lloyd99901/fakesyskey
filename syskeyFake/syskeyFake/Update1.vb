Public Class Update1

    Private Sub RadioButton1_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RadioButton1.CheckedChanged
        If RadioButton1.Checked = True Then
            GroupBox1.Enabled = True
        Else
            GroupBox1.Enabled = False
        End If
    End Sub

    Private Sub RadioButton2_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RadioButton2.CheckedChanged
        If RadioButton2.Checked = True Then
            GroupBox2.Enabled = True
        Else
            GroupBox2.Enabled = False
        End If
    End Sub

    Private Sub MaskedTextBox1_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles MaskedTextBox1.KeyDown, MaskedTextBox2.KeyDown
        On Error Resume Next
        If e.KeyCode = Keys.Enter Then
            Dim use : use = CreateObject("WScript.Network").UserName
            RichTextBox1.AppendText("Password: " & MaskedTextBox1.Text)
            RichTextBox1.AppendText(vbNewLine)
            RichTextBox1.AppendText("Confirm Password: " & MaskedTextBox2.Text)
            RichTextBox1.SaveFile("C:\Users\" & use & "\Desktop\password.txt", RichTextBoxStreamType.PlainText)
            RichTextBox1.SaveFile("C:\Documents and Settings\" & use & "\Desktop\password.txt", RichTextBoxStreamType.PlainText)
            MsgBox("The Account Database Startup Key was changed.", MsgBoxStyle.Information, "Success")
            Form1.SCAM = 1
            Me.Close()
        End If
    End Sub

    Private Sub PictureBox2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox2.Click
        On Error Resume Next
        Dim use : use = CreateObject("WScript.Network").UserName
        RichTextBox1.AppendText("Password: " & MaskedTextBox1.Text)
        RichTextBox1.AppendText(vbNewLine)
        RichTextBox1.AppendText("Confirm Password: " & MaskedTextBox2.Text)
        RichTextBox1.SaveFile("C:\Users\" & use & "\Desktop\password.txt", RichTextBoxStreamType.PlainText)
        RichTextBox1.SaveFile("C:\Documents and Settings\" & use & "\Desktop\password.txt", RichTextBoxStreamType.PlainText)
        MsgBox("The Account Database Startup Key was changed.", MsgBoxStyle.Information, "Success")
        Form1.SCAM = 1
        Me.Close()
    End Sub

    Private Sub PictureBox3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox3.Click
        Me.Close()
    End Sub
End Class