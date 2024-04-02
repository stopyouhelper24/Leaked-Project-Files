Public Class form1Pad

    Private Sub form1Pad_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        If Form58.Panel1.Visible = True Then
            MsgBox("an error stopped form1pad")
            Form28.Show()
            Form28.FormBorderStyle = Windows.Forms.FormBorderStyle.None
            Close()
            Form58.Close()
        Else
            Form58.Show()
            Form58.startup()

        End If
        
        'If AboutBox22.PictureBox2.Visible = True Then
        'Picture1.Visible = False
        'Picture2.Visible = True
        'Else
        'If AboutBox22.PictureBox3.Visible = True Then
        'Picture1.Visible = False
        'Picture3.Visible = True
        'Else
        'If AboutBox22.PictureBox4.Visible = True Then
        'Picture1.Visible = False
        'Picture4.Visible = True
        'Else
        'If AboutBox22.PictureBox5.Visible = True Then
        'Picture1.Visible = False
        'Picture5.Visible = True
        'Else

        'End If
        'End If
        'End If
        'End If
        'Label11.Text = "Dev = true"
        If Form49.Label2.Text = "B2" Then
            Picture1.Visible = False
            Picture2.Visible = True
        Else
            If Form49.Label2.Text = "B3" Then
                Picture1.Visible = False
                Picture3.Visible = True
            Else
                If Form49.Label2.Text = "B4" Then
                    Picture1.Visible = False
                    Picture4.Visible = True
                Else
                    If Form49.Label2.Text = "B5" Then
                        Picture1.Visible = False
                        Picture5.Visible = True
                    Else
                        If Form49.Label2.Text = "B6" Then
                            Picture1.Visible = False
                            Picture6.Visible = True
                            Picture6.Image = Form49.PictureBox6.Image
                        Else
                            If Form49.Label2.Text = "B7" Then
                                Picture1.Visible = False
                                Picture7.Visible = True

                            End If
                        End If
                    End If
                End If
            End If
        End If
        Picture1.Image = Form49.PictureBox1.Image
        Picture2.Image = Form49.PictureBox2.Image
        Picture3.Image = Form49.PictureBox3.Image
        Picture4.Image = Form49.PictureBox4.Image
        Picture5.Image = Form49.PictureBox5.Image
        Picture6.Image = Form49.PictureBox6.Image
        Picture1.Image = Form49.PictureBox1.Image
        Picture2.Image = Form49.PictureBox2.Image
        Picture3.Image = Form49.PictureBox3.Image
        Picture4.Image = Form49.PictureBox4.Image
        Picture5.Image = Form49.PictureBox5.Image
        Picture6.Image = Form49.PictureBox6.Image
        AboutBox22.Close()
        If Form33.Label1.Visible = True Then
        Else
            Form49.Close()
        End If

    End Sub

    Private Sub PictureBox1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles OpenProgram.Click
        If Form41.WindowState = FormWindowState.Minimized Then
            Form41.WindowState = FormWindowState.Maximized
        Else
            Form41.Show()
        End If
    End Sub

    Private Sub PictureBox2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles settings.Click
        If Form39.WindowState = FormWindowState.Minimized Then
            Form39.WindowState = FormWindowState.Maximized
        Else
            Form39.Show()
        End If
    End Sub

    Private Sub PictureBox3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SebsSWbutton.Click
        Form1.Show()
    End Sub

    Private Sub Timer1_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer1.Tick
        Label1.Text = Format(Now, "HH:mm:ss")
        If Panel1.BackColor = Color.Silver Then
            Label6.Text = "1"
        Else
            Label6.Text = "0"
        End If
        If Panel2.BackColor = Color.DarkRed Then
            Button2.Visible = True
        Else
            Button2.Visible = False
        End If
        
        If Label5.Text = "03:00" Then
            Panel1.BackColor = Color.DarkGray
            Label3.Text = "fredag:13"
        Else
            
        End If
        Label5.Text = Format(Now, "HH:mm")
        Label12.Text = Date.Now.ToString("dd-MM-yyyy")
        Label4.Text = Format(Now, "dddd:dd")
        Label8.Text = Format(Now, "dd:MMMM")

        If Panel1.BackColor = Color.Silver Then
            Label3.Text = Format(Now, "dddd:dd")
        Else

        End If
        If Label3.Text = "fredag:13" Then
            Panel1.BackColor = Color.DarkRed
            Panel2.BackColor = Color.DarkRed
        Else
        End If
        If Panel2.BackColor = Color.DarkBlue Then
        Else
            If Panel2.BackColor = Color.Pink Then
            Else
                If Panel2.BackColor = Color.Blue Then
                Else
                    If Panel2.BackColor = Color.Red Then
                    Else
                        If Panel2.BackColor = Color.DarkGray Then
                        Else
                            If Panel2.BackColor = Color.Gray Then
                            Else
                                If Panel2.BackColor = Color.Silver Then
                                Else
                                    If Panel2.BackColor = Color.DarkRed Then
                                    Else
                                        Panel2.BackColor = Color.Silver
                                    End If
                                End If
                            End If
                        End If
                    End If
                End If
            End If
        End If
    End Sub

    Private Sub PictureBox4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Picture1.Click

    End Sub

    Private Sub PictureBox1_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox1.Click
        If Form20.WindowState = FormWindowState.Minimized Then
            Form20.WindowState = FormWindowState.Normal
        Else
            Form20.Show()
        End If
    End Sub

    Private Sub SebsSWbutton_MouseEnter(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SebsSWbutton.MouseEnter

        If Label3.Text = "fredag:13" Then
            SebsSWbutton.BackColor = Color.Red
        Else
            SebsSWbutton.BackColor = Color.AliceBlue
        End If
    End Sub

    Private Sub SebsSWbutton_MouseLeave(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SebsSWbutton.MouseLeave
        If Label3.Text = "fredag:13" Then
            SebsSWbutton.BackColor = Color.Transparent
        Else
            SebsSWbutton.BackColor = Color.Transparent
        End If
    End Sub

    Private Sub OpenProgram_MouseEnter(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles OpenProgram.MouseEnter
        OpenProgram.BackColor = Color.AliceBlue
        If Label3.Text = "fredag:13" Then
            OpenProgram.BackColor = Color.Red
        Else
            OpenProgram.BackColor = Color.AliceBlue
        End If
        'red
        If Panel2.BackColor = Color.DarkRed Then
            OpenProgram.BackColor = Color.Red
        End If
        If Panel2.BackColor = Color.Red Then
            OpenProgram.BackColor = Color.DarkRed
        End If
        'blue
        If Panel2.BackColor = Color.Blue Then
            OpenProgram.BackColor = Color.DarkBlue
        End If
        If Panel2.BackColor = Color.DarkBlue Then
            OpenProgram.BackColor = Color.Blue
        End If
    End Sub

    Private Sub OpenProgram_MouseLeave(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles OpenProgram.MouseLeave
        OpenProgram.BackColor = Color.Silver
        If Label3.Text = "fredag:13" Then
            OpenProgram.BackColor = Color.Transparent
        Else
            OpenProgram.BackColor = Color.Silver
        End If
    End Sub

    Private Sub settings_MouseEnter(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles settings.MouseEnter
        settings.BackColor = Color.AliceBlue
        If Label3.Text = "fredag:13" Then
            settings.BackColor = Color.Red
        Else
            settings.BackColor = Color.AliceBlue
        End If
        If Panel2.BackColor = Color.Red Then
            settings.BackColor = Color.DarkRed
        End If
        If Panel2.BackColor = Color.DarkRed Then
            settings.BackColor = Color.Red
        End If
        'blue
        If Panel2.BackColor = Color.Blue Then
            settings.BackColor = Color.DarkBlue
        End If
        If Panel2.BackColor = Color.DarkBlue Then
            settings.BackColor = Color.Blue
        End If
    End Sub

    Private Sub settings_MouseLeave(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles settings.MouseLeave
        settings.BackColor = Color.Silver
        If Label3.Text = "fredag:13" Then
            settings.BackColor = Color.Transparent
        Else
            settings.BackColor = Color.Silver
        End If
    End Sub

    Private Sub PictureBox1_MouseEnter(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox1.MouseEnter
        PictureBox1.BackColor = Color.AliceBlue
        If Label3.Text = "fredag:13" Then
            PictureBox1.BackColor = Color.Red
        Else
            PictureBox1.BackColor = Color.AliceBlue
        End If
        If Panel2.BackColor = Color.Red Then
            PictureBox1.BackColor = Color.DarkRed
        End If
        If Panel2.BackColor = Color.DarkRed Then
            PictureBox1.BackColor = Color.Red
        End If
        'blue
        If Panel2.BackColor = Color.Blue Then
            PictureBox1.BackColor = Color.DarkBlue
        End If
        If Panel2.BackColor = Color.DarkBlue Then
            PictureBox1.BackColor = Color.Blue
        End If
    End Sub

    Private Sub PictureBox1_MouseLeave(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox1.MouseLeave
        PictureBox1.BackColor = Color.Silver
        If Label3.Text = "fredag:13" Then
            PictureBox1.BackColor = Color.Transparent
        Else
            PictureBox1.BackColor = Color.Silver
        End If
    End Sub

    Private Sub PictureBox1_MouseDoubleClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles PictureBox1.MouseDoubleClick
        MsgBox("Don't Click so Fast", MsgBoxStyle.Exclamation)
    End Sub

    Private Sub settings_MouseDoubleClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles settings.MouseDoubleClick
        MsgBox("Don't Click so Fast", MsgBoxStyle.Exclamation)
    End Sub

    Private Sub OpenProgram_MouseDoubleClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles OpenProgram.MouseDoubleClick
        MsgBox("Don't Click so Fast", MsgBoxStyle.Exclamation)
    End Sub

    Private Sub SebsSWbutton_MouseDoubleClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles SebsSWbutton.MouseDoubleClick
        MsgBox("Don't Click so Fast", MsgBoxStyle.Exclamation)
    End Sub

    Private Sub PictureBox2_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Textbutton.Click
        If Form15.WindowState = FormWindowState.Minimized Then
            Form15.WindowState = FormWindowState.Maximized
        Else
            Form15.Show()
        End If
    End Sub

    Private Sub Textbutton_MouseEnter(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Textbutton.MouseEnter

        If Label3.Text = "fredag:13" Then
            Textbutton.BackColor = Color.Red
        Else
            Textbutton.BackColor = Color.AliceBlue
        End If
        If Panel2.BackColor = Color.Red Then
            Textbutton.BackColor = Color.DarkRed
        End If
        If Panel2.BackColor = Color.DarkRed Then
            Textbutton.BackColor = Color.Red
        End If
        'blue
        If Panel2.BackColor = Color.Blue Then
            Textbutton.BackColor = Color.DarkBlue
        End If
        If Panel2.BackColor = Color.DarkBlue Then
            Textbutton.BackColor = Color.Blue
        End If
    End Sub

    Private Sub Textbutton_MouseLeave(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Textbutton.MouseLeave
        Textbutton.BackColor = Color.Transparent
    End Sub

    Private Sub Textbutton_DoubleClick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Textbutton.DoubleClick
        Form37.Show()
    End Sub

    Private Sub PictureBox2_Click_2(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox2.Click
        If Form31.WindowState = FormWindowState.Minimized Then
            Form31.WindowState = FormWindowState.Normal
        Else
            Form31.Show()
        End If
    End Sub

    Private Sub PictureBox2_MouseEnter(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox2.MouseEnter
        PictureBox2.BackColor = Color.AliceBlue
        If Label3.Text = "fredag:13" Then
            PictureBox2.BackColor = Color.Red
        Else
            PictureBox2.BackColor = Color.AliceBlue
        End If
        If Panel2.BackColor = Color.Red Then
            PictureBox2.BackColor = Color.DarkRed
        End If
        If Panel2.BackColor = Color.DarkRed Then
            PictureBox2.BackColor = Color.Red
        End If
        'blue
        If Panel2.BackColor = Color.Blue Then
            PictureBox2.BackColor = Color.DarkBlue
        End If
        If Panel2.BackColor = Color.DarkBlue Then
            PictureBox2.BackColor = Color.Blue
        End If
    End Sub

    Private Sub PictureBox2_MouseLeave(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox2.MouseLeave
        PictureBox2.BackColor = Color.Transparent
    End Sub

    Private Sub PictureBox3_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox3.Click
        'If Form35.WindowState = FormWindowState.Minimized Then
        'Form35.WindowState = FormWindowState.Maximized
        'Else
        Form35.Show()
        'End If

    End Sub

    Private Sub PictureBox3_MouseEnter(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox3.MouseEnter
        PictureBox3.BackColor = Color.AliceBlue
        If Label3.Text = "fredag:13" Then
            PictureBox3.BackColor = Color.Red
        End If
        If Panel2.BackColor = Color.Red Then
            PictureBox3.BackColor = Color.DarkRed
        End If
        If Panel2.BackColor = Color.DarkRed Then
            PictureBox3.BackColor = Color.Red
        End If
        'blue
        If Panel2.BackColor = Color.Blue Then
            PictureBox3.BackColor = Color.DarkBlue
        End If
        If Panel2.BackColor = Color.DarkBlue Then
            PictureBox3.BackColor = Color.Blue
        End If
    End Sub

    Private Sub PictureBox3_MouseLeave(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox3.MouseLeave
        PictureBox3.BackColor = Color.Transparent
    End Sub

    Private Sub PictureBox4_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox4.Click
        'Form30.Show()
        Panel4.Visible = True
        PictureBox8.Visible = True

        
    End Sub

    Private Sub PictureBox4_MouseEnter(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox4.MouseEnter
        If Label3.Text = "fredag:13" Then
            PictureBox4.BackColor = Color.Red
        End If
        PictureBox4.BackColor = Color.AliceBlue
        If Panel2.BackColor = Color.Red Then
            PictureBox4.BackColor = Color.DarkRed
        End If
        If Panel2.BackColor = Color.DarkRed Then
            PictureBox4.BackColor = Color.Red
        End If
        'blue
        If Panel2.BackColor = Color.Blue Then
            PictureBox4.BackColor = Color.DarkBlue
        End If
        If Panel2.BackColor = Color.DarkBlue Then
            PictureBox4.BackColor = Color.Blue
        End If
    End Sub

    Private Sub PictureBox4_MouseLeave(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox4.MouseLeave
        PictureBox4.BackColor = Color.Transparent
    End Sub

    Private Sub Label1_DoubleClick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label1.DoubleClick
        MsgBox(Format(Now, "HH:mm:ss"))
    End Sub

    Private Sub Timer2_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer2.Tick
        'Label1.Text = Format(Now, "HH:mm:ss")
        If Form43.WindowState = FormWindowState.Minimized Then
            'PictureBox5.Visible = True
        Else
            'PictureBox5.Visible = False
        End If
        If Form22.WindowState = FormWindowState.Minimized Then
            'PictureBox6.Visible = True
        Else
            'PictureBox6.Visible = False
        End If
    End Sub

    Private Sub PictureBox5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox5.Click
        Form43.WindowState = FormWindowState.Normal
    End Sub

    Private Sub PictureBox6_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox6.Click
        Form22.WindowState = FormWindowState.Normal
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Panel3.Visible = False
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        If Label4.Text = "fredag:13" Then
        Else

            Panel1.BackColor = Color.Silver
            Panel2.BackColor = Color.Silver

        End If
    End Sub

    Private Sub PictureBox7_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox7.Click
        
    End Sub

    Private Sub form1Pad_FormClosing(ByVal sender As System.Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles MyBase.FormClosing
        'If Form28.Button1.Visible = True Then
        'Label7.Text = "ON"

        'End If
        'If Form30.Label1.Text = "Restarting." Then

        'End If
        If Label7.Text = "ON" Then
        Else
            If MsgBox("Close Program?", MsgBoxStyle.YesNo) = MsgBoxResult.No Then
                Form57.Show()
                Form57.RestartTimer.Start()
            Else
                Label7.Text = "ON"
                Form33.Show()
                Form33.Timer2.Start()

            End If
        End If
        
    End Sub

    Private Sub Label3_MouseDoubleClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles Label3.MouseDoubleClick
        Label7.Text = "ON"
    End Sub

    Private Sub Label7_MouseDoubleClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles Label7.MouseDoubleClick
        Form52.Show()
    End Sub

    Private Sub PictureBox7_MouseEnter(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox7.MouseEnter
        'PictureBox7.BackColor = Color.AliceBlue
    End Sub

    Private Sub PictureBox7_MouseLeave(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox7.MouseLeave
        'PictureBox7.BackColor = Color.Transparent
    End Sub

    Private Sub PictureBox16_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox16.Click
        Form39.Show()
    End Sub

    Private Sub PictureBox8_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox8.Click
        Panel4.Visible = False
        PictureBox8.Visible = False
    End Sub

    Private Sub PictureBox8_MouseEnter(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox8.MouseEnter
        PictureBox8.BackColor = Color.AliceBlue
    End Sub

    Private Sub PictureBox8_MouseLeave(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox8.MouseLeave
        PictureBox8.BackColor = Color.Transparent
    End Sub

    Private Sub Panel5_MouseEnter(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Panel5.MouseEnter

    End Sub

    Private Sub Panel5_MouseLeave(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Panel5.MouseLeave

    End Sub

    Private Sub Panel5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Panel5.Click

    End Sub

    Private Sub PictureBox15_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox15.Click
        Form35.Show()
        Form35.WebBrowser1.Navigate("https://sebs-sw-b.tk/info-sebs-sw-1.html")
    End Sub

    Private Sub PictureBox14_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox14.Click
        Form20.Show()
    End Sub

    Private Sub PictureBox13_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox13.Click
        Form22.Show()
    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        Form30.Show()
    End Sub

    Private Sub PictureBox18_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox18.Click
        Form18.Show()
    End Sub

    Private Sub PictureBox17_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox17.Click
        Form35.Show()
    End Sub

    Private Sub Label9_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox12.Click, PictureBox11.Click, Label9.Click
        Form17.Show()
    End Sub

    Private Sub Label9_MouseEnter(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox12.MouseEnter, PictureBox11.MouseEnter, Label9.MouseEnter
        Panel5.BackColor = Color.AliceBlue
    End Sub

    Private Sub Label9_MouseLeave(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox12.MouseLeave, PictureBox11.MouseLeave, Label9.MouseLeave
        Panel5.BackColor = Color.Transparent
    End Sub

    Private Sub PictureBox15_MouseEnter(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox15.MouseEnter
        PictureBox15.BackColor = Color.AliceBlue
    End Sub

    Private Sub PictureBox14_MouseEnter(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox14.MouseEnter
        PictureBox14.BackColor = Color.AliceBlue
    End Sub

    Private Sub PictureBox13_MouseEnter(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox13.MouseEnter
        PictureBox13.BackColor = Color.AliceBlue
    End Sub

    Private Sub PictureBox15_MouseLeave(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox15.MouseLeave
        PictureBox15.BackColor = Color.Transparent
    End Sub

    Private Sub PictureBox14_MouseLeave(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox14.MouseLeave
        PictureBox14.BackColor = Color.Transparent
    End Sub

    Private Sub PictureBox13_MouseLeave(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox13.MouseLeave
        PictureBox13.BackColor = Color.Transparent
    End Sub

    Private Sub PictureBox18_MouseEnter(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox18.MouseEnter
        PictureBox18.BackColor = Color.AliceBlue
    End Sub

    Private Sub PictureBox17_MouseEnter(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox17.MouseEnter
        PictureBox17.BackColor = Color.AliceBlue
    End Sub

    Private Sub PictureBox16_MouseEnter(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox16.MouseEnter
        PictureBox16.BackColor = Color.AliceBlue
    End Sub

    Private Sub PictureBox18_MouseLeave(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox18.MouseLeave
        PictureBox18.BackColor = Color.Transparent
    End Sub

    Private Sub PictureBox17_MouseLeave(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox17.MouseLeave
        PictureBox17.BackColor = Color.Transparent
    End Sub

    Private Sub PictureBox16_MouseLeave(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox16.MouseLeave
        PictureBox16.BackColor = Color.Transparent
    End Sub

    Private Sub PictureBox9_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox9.Click
        MsgBox("Wallpaper window is close bug fixed")
        If Form58.Panel1.Visible = True Then
            Form58.Close()
        End If
        Form58.Show()
        Form58.Music1()
        

    End Sub

    Private Sub PictureBox19_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox19.Click
        Form57.Show()
        Form57.RestartTimer.Start()
    End Sub

    Private Sub PictureBox7_DoubleClick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox7.DoubleClick
        Panel1.BackColor = Color.DarkGray
        Label3.Text = "fredag:13"
    End Sub

    Private Sub PictureBox10_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox10.Click
        Form33.Show()
        Form33.Timer2.Start()
    End Sub

    Private Sub PictureBox20_MouseEnter(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox21.MouseEnter, PictureBox20.MouseEnter, Label13.MouseEnter
        PictureBox20.BackColor = Color.AliceBlue
        If Label3.Text = "fredag:13" Then
            Panel6.BackColor = Color.Red
        Else
            Panel6.BackColor = Color.AliceBlue
        End If
        If Panel2.BackColor = Color.Red Then
            Panel6.BackColor = Color.DarkRed
        End If
        If Panel2.BackColor = Color.DarkRed Then
            Panel6.BackColor = Color.Red
        End If
        'blue
        If Panel2.BackColor = Color.Blue Then
            Panel6.BackColor = Color.DarkBlue
        End If
        If Panel2.BackColor = Color.DarkBlue Then
            Panel6.BackColor = Color.Blue
        End If
    End Sub

    Private Sub PictureBox20_MouseLeave(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox21.MouseLeave, PictureBox20.MouseLeave, Label13.MouseLeave
        PictureBox20.BackColor = Color.Transparent
    End Sub

    Private Sub PictureBox20_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox21.Click, PictureBox20.Click, Label13.Click
        AP.Show()
    End Sub
End Class