Public Class ContextMenu_Taskbar
    Private Sub RunToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles RunToolStripMenuItem.Click
        If UI.LockedMode = True Then
        Else
            UI.StartRun()
        End If

        Form_1pad.Panel2.Visible = False
        Form_1pad.Panel4.Visible = False
    End Sub

    Private Sub TaskbarToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles TaskbarToolStripMenuItem.Click
        Form44.Show()
        Form44.TextBox1.Text = "settings/taskbar-settings"
        Form44.SEV()
        Form_1pad.Panel2.Visible = False
        Form_1pad.Panel4.Visible = False
    End Sub
End Class
