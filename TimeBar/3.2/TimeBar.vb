Public Class TimeBar
    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        Label2.Text = Format(Now, "HH:mm:ss")
        Label1.Text = Format(Now, "dd-MM-yyyy")
    End Sub

    Private Sub TimeBar_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub TimeBar_MouseDown(sender As Object, e As MouseEventArgs) Handles MyBase.MouseDown
        Form_1pad.TopPanel_MouseDown(Me, e)
    End Sub
End Class
