Public Class ContextMenu
    Private Sub RunToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles RunToolStripMenuItem.Click
        If UI.LockedMode = True Then
        Else
            UI.StartRun()
        End If
        Form_1pad.Panel2.Visible = False
        Form_1pad.Panel4.Visible = False
    End Sub

    Private Sub SettingsToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SettingsToolStripMenuItem.Click
        Form44.Show()
        Form44.TextBox1.Text = "settings"
        Form44.SEV()
        Form_1pad.Panel2.Visible = False
        Form_1pad.Panel4.Visible = False
    End Sub

    Private Sub CMDToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CMDToolStripMenuItem.Click
        If UI.LockedMode = True Then
        Else
            UI.StartCMD("New")
        End If
        Form_1pad.Panel2.Visible = False
        Form_1pad.Panel4.Visible = False
    End Sub
End Class
