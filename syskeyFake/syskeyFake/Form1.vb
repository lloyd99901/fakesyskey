Public Class Form1
    'Success
    'The Account Database Startup Key was changed.
    Public SCAM As Integer = 0
    Private Sub PictureBox2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox2.Click
        If SCAM = 1 Then
            MsgBox(message.Text)
            Close()
        End If
        Close()
    End Sub

    Private Sub PictureBox3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox3.Click
        If SCAM = 1 Then
            MsgBox(message.Text)
            Close()
        End If
        Close()
    End Sub

    Private Sub PictureBox4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox4.Click
        Update1.Show()
    End Sub

    Private Sub Form1_Shown(sender As Object, e As EventArgs) Handles MyBase.Shown
        Timer1.Start()
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        Me.ShowIcon = False
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.Text = "Securing the Windows Account Database"
        message.Text = "Nice Try Scammers!!!"
    End Sub

    Private Sub Form1_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        If SCAM = 1 Then
            SCAM = 0
            MsgBox(message.Text)
            Close()
        End If
    End Sub
End Class
