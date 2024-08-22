Public Class Form_1pad
    Public opened As String = "0"
    Public Usernamestring As String
    Public isDevmodeon As String
    Public swtask2 As String = "old"
    Public Path As String
    Public videoplay As String = ""
    'Public d2 As Boolean = Button1.Text
    Private Sub CloseToForm1pad15ToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CloseToForm1pad15ToolStripMenuItem.Click
        form1Pad.Show()
        Close()
    End Sub

    Private Sub ToolStripMenuItem2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripMenuItem2.Click
        StartMenu.Visible = True
    End Sub

    Private Sub ToolStripMenuItem3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripMenuItem3.Click
        StartMenu.Visible = False
    End Sub

    Private Sub ToolStripMenuItem4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripMenuItem4.Click

        If MenuStrip1.Visible = True Then
            MenuStrip1.Visible = False
            StartMenu.Visible = False
        Else
            MenuStrip1.Visible = True
            StartMenu.Visible = False
        End If
        'StartMenu.Visible = True
    End Sub

    Private Sub StartMenu_VisibleChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles StartMenu.VisibleChanged
        Button1.Text = My.Computer.Info.OSFullName
    End Sub

    Private Sub PictureBox4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox4.Click
        Form17.Show()
    End Sub

    Private Sub PictureBox2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox2.Click
        'Form35.Show()
        'Form19.Show()
        Start_Form19()
    End Sub

    Private Sub PictureBox3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles startbutton1.Click
        StartMenuPanel.Visible = True
        startbutton2.Visible = True
    End Sub

    Private Sub PictureBox5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles startbutton2.Click
        StartMenuPanel.Visible = False
        startbutton2.Visible = False
    End Sub

    Private Sub PictureBox15_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox15.Click
        'Form35.Show()
        'Form35.WebBrowser1.Navigate("https://sebs-sw-b.tk/info-sebs-sw-1.html")
    End Sub

    Private Sub PictureBox14_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox14.Click
        Form20.Show()
    End Sub

    Private Sub PictureBox13_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox13.Click
        Form22.Show()
    End Sub

    Private Sub PictureBox9_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox9.Click
        'Form60.Show()
    End Sub

    Private Sub Label9_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox12.Click, PictureBox11.Click, Label9.Click
        Form17.Show()
        Form17.CVW()
    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        Form30.Show()
    End Sub

    Private Sub PictureBox18_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox18.Click
        Form31.Show()
    End Sub

    Private Sub OpenProgram_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles OpenProgram.Click
        Form41.Show()
    End Sub

    Private Sub Settings_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles settings.Click
        'Form21.Show()
        Form39settings.Show()
        Panel2.Visible = False
    End Sub

    Private Sub PictureBox5_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox5.Click
        'Form20.Show()
        'Panel2.Visible = False
    End Sub

    Private Sub PictureBox3_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox3.Click
        Form31.Show()
        Panel2.Visible = False
    End Sub

    Private Sub PictureBox10_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox10.Click
        'Form33.Show()
        'Form33.Timer2.Start()
        End
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        form1Pad.Show()
        Close()
    End Sub

    Private Sub Textbutton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Textbutton.Click
        Form15.Show()
        Panel2.Visible = False
    End Sub

    Private Sub PictureBox16_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub
    Public SSSSS As String
    Public Menu_ As String
    Private Sub Form_1pad_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        UI.Show()
        If My.Settings.RunUINow = True Then
        Else
            UI.Close()
        End If
        'WASD.Show()
        Path = My.Application.Info.DirectoryPath.ToString
        isDevmodeon = My.Settings.isdevmodeon
        If My.Computer.FileSystem.FileExists(My.Application.Info.DirectoryPath + "\Menu.swfiles") Then
            Menu_ = My.Computer.FileSystem.ReadAllText(My.Application.Info.DirectoryPath + "\Menu.swfiles")
        End If
        If SSSSS IsNot My.Computer.Name Then
            'MsgBox("")
        Else
            SSSSS = My.Computer.Name
            MsgBox(SSSSS)
            MsgBox(My.User.Name)
            SSSSS = My.User.Name
            MsgBox(Replace(SSSSS, My.Computer.Name + "\", ""))
        End If
        'easycode.Start_up_load()
        Panel2.BackColor = Panel1.BackColor
        'Picture1.Visible = True
        If My.Computer.FileSystem.FileExists("start.explorer.swfiles") Then
            regeditsw.Show()
            regeditsw.Timer1.Start()
            regeditsw.Label1.Text = "start.explorer.swfiles"
            regeditsw.RichTextBox1.Text = My.Computer.FileSystem.ReadAllText("start.explorer.swfiles")

            If regeditsw.RichTextBox1.Text = "Start_old_explorer = true" Then
                Form1.Show()
            End If
        End If
        isDevmodeon = My.Settings.isdevmodeon
        If My.Computer.FileSystem.FileExists("color.swfiles") Then
            regeditsw.Show()
            regeditsw.RichTextBox1.Text = My.Computer.FileSystem.ReadAllText("color.swfiles")
            If regeditsw.RichTextBox1.Text = "Color = 1" Then
                Panel1.BackColor = Color.Blue
            End If
            If regeditsw.RichTextBox1.Text = "Color = 2" Then
                Panel1.BackColor = Color.DarkBlue
            End If
            If regeditsw.RichTextBox1.Text = "Color = 3" Then
                Panel1.BackColor = Color.Red
            End If
            If regeditsw.RichTextBox1.Text = "Color = 4" Then
                Panel1.BackColor = Color.DarkRed
            End If
            If regeditsw.RichTextBox1.Text = "Color = 5" Then
                Panel1.BackColor = Color.Orange
            End If
            If regeditsw.RichTextBox1.Text = "Color = 6" Then
                Panel1.BackColor = Color.DarkOrange
            End If
            If regeditsw.RichTextBox1.Text = "Color = 7" Then
                Panel1.BackColor = Color.Black
            End If
            If regeditsw.RichTextBox1.Text = "Color = 8" Then
                Panel1.BackColor = Color.White
            End If
            If regeditsw.RichTextBox1.Text = "Color = 9" Then
                Panel1.BackColor = Color.Gray
            End If
            If regeditsw.RichTextBox1.Text = "Color = 10" Then
                Panel1.BackColor = Color.DarkGray
            End If
            If regeditsw.RichTextBox1.Text = "Color = 11" Then
                Panel1.BackColor = Color.DeepPink
            End If
            regeditsw.RichTextBox1.Text = "Color = 1"
            'regeditsw.RichTextBox1.BackColor = regeditsw.RichTextBox1.Text
        End If

        isDevmodeon = My.Settings.isdevmodeon
        'Try
        'Form58.Show()
        'Form58.startup()
        'Catch ex As Exception
        'MsgBox(ex)
        'MsgBox("The Beta 2 has Stopped Working")
        'MsgBox("Closing Beta 2")
        'End Try
        If My.Computer.FileSystem.FileExists(My.Application.Info.DirectoryPath + "\Apps\editsw.swfiles") Then

            Button25.Visible = True

        End If
        If Form58.Panel1.Visible = True Then
            My.Computer.Audio.Play(My.Resources.error_2_36058, AudioPlayMode.Background)
            MsgBox("an error stopped form1pad")
            Form28.Show()
            Form28.FormBorderStyle = Windows.Forms.FormBorderStyle.None
            Close()
            Form58.Close()

        Else
            If My.Computer.FileSystem.FileExists("Interop.WMPLib.dll") Then
                If My.Computer.FileSystem.FileExists("Interop.SHDocVw.dll") Then
                    If My.Computer.FileSystem.FileExists("AxInterop.WMPLib.dll") Then
                        Try
                            Form58.Show()
                            Form58.startup2()
                        Catch ex As Exception
                            'MsgBox(ex)
                        End Try
                    End If
                End If
            End If
        End If
        isDevmodeon = My.Settings.isdevmodeon

        If My.Computer.FileSystem.FileExists("Username.swfiles") Then
            Dim _1_ As String = ""
            _1_ = My.Computer.FileSystem.ReadAllText("Username.swfiles")
            If Form48.TextBox1.Text = _1_ Then
                Label12.Text = _1_
            End If
        End If
        If My.Computer.FileSystem.FileExists(My.Application.Info.DirectoryPath + "\Apps\TextEditor.swfiles") Then
            textedit = "New"
        Else
            textedit = "Old"
        End If
        If My.Computer.FileSystem.FileExists(My.Application.Info.DirectoryPath + "\Apps\SWTask.swfiles") Then
            swtask2 = "New"
        Else
            swtask2 = "Old"
        End If
        'If Form48.Dontclose = "1" Then

        'Else
        Form48.Close()
        'End If

        isDevmodeon = My.Settings.isdevmodeon
        If My.Computer.FileSystem.FileExists(My.Application.Info.DirectoryPath + "\taskbarloc.swfiles") Then
            Dim ss As String = ""
            ss = My.Computer.FileSystem.ReadAllText(My.Application.Info.DirectoryPath + "\taskbarloc.swfiles")
            If ss = "top" Then
                Panel1.Dock = DockStyle.Top
                StartMenu.Dock = DockStyle.Top
            ElseIf ss = "bottom" Then
                Panel1.Dock = DockStyle.Bottom
                StartMenu.Dock = DockStyle.Bottom
            End If
        End If
    End Sub
    Public textedit As String = ""
    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        MsgBox(My.Computer.Info.OSFullName)
    End Sub

    Private Sub Timer1_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer1.Tick
        'If 
        If Form61.Button1.Visible = True Then
            Button24.Visible = True
        Else
            Button24.Visible = False
        End If
        StartMenu.BackColor = Panel1.BackColor
        Me.BackColor = Panel1.BackColor
        'Label1.Text = Date.Now.ToString("dd-MM-yyyy")
        Label1.Text = Format(Now, "HH:mm:ss")
        Label5.Text = Format(Now, "dd-MM-yyyy")
        If StartMenu.Visible = False Then
            StartMenu.Visible = True
        End If
        If StartMenuPanel.Visible = True Then
            Panel2.Visible = False
        End If
        If Label2.Text = "Dev = true" Then
            Button16.Enabled = False
        End If
        If UI.Panel1.Visible = True Then
        Else
            If Form48.Panel1.Visible = True Then
            Else
                Form28.Show()
                Form28.Label2.Visible = True
                Form28.Label2.Text = "UI mgr Killed | You did it"
            End If

        End If
    End Sub

    Private Sub Button4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button4.Click
        Form21.Show()
    End Sub

    Private Sub PictureBox17_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        'Form35.Show()
        Start_Form19()
    End Sub

    Private Sub Button5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        'Form35.Show()
    End Sub

    Private Sub Button7_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Form61.Show()
    End Sub

    Private Sub Button8_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        'Form22.Show()
        'If isDevmodeon = "true" Then
        'Form39settings.Show()
        'Else
        'If My.Computer.FileSystem.FileExists("Sebastian-admin.swfiles") Then
        Form36.Show()
        Form36.TextBox1.Text = "settings/info"
        Form36.SEV()
        '   Else
        'Form39settings.Show()
        '    End If
        'End If
    End Sub

    Public Sub reload_swtask()
        swtask.Close()
        swtask.Show()
    End Sub

    Private Sub Button6_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button6.Click
        'Form31.Show()
        'If isDevmodeon = "true" Then
        'Form39settings.Show()
        'Else
        'If My.Computer.FileSystem.FileExists("Sebastian-admin.swfiles") Then
        Form36.Show()
        Form36.TextBox1.Text = "C:/"
        Form36.SEV()
        '    Else
        'Form39settings.Show()
        'End If
        'End If
    End Sub

    Private Sub Button9_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button9.Click
        Form17.Show()
        Form17.CVW()
    End Sub

    Private Sub Button11_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button11.Click
        Form17.Show()
        Form17.CVW()
    End Sub

    Public Sub ssss2()
        Dim str As String
        str = Form32.Label2.Text
        If str.Contains("WebView2") = True Then
            Form32.Label2.Text = ""
        Else
            MsgBox("The String does not Contains() 'Webview2'")
        End If
    End Sub

    Private Sub Button5_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button5.Click
        'Form35.Show()
        'Start_Form19()

        Try
            Internetplusplus.Show()
        Catch ex As Exception
            'Dim ex As String = "Der opstod en fejl under oprettelsen af formularen. Se Exception.InnerException for at få flere oplysninger. Fejlen er: Filen eller assemblyen 'Microsoft.Web.WebView2.WinForms, Version=1.0.1264.42, Culture=neutral, PublicKeyToken=2a8ab48044d2601e' eller en af dens afhængigheder kunne ikke indlæses. Den angivne fil blev ikke fundet."
            Form32.Show()
            Form32.Label2.Visible = True
            Form32.Label2.Text = ex.Message
            If Form32.Label2.Text.Length > 50 Then
                ssss2()
            End If
            'Form15.Show()
            'Form15.TextBox1.Text = ex.Message
        End Try


    End Sub

    Private Sub Button10_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button10.Click
        'Form21.Show()
        'Form39settings.Show()
        'If isDevmodeon = "true" Then
        'Form39settings.Show()
        'Else
        'If My.Computer.FileSystem.FileExists("Sebastian-admin.swfiles") Then
        Form36.Show()
        Form36.TextBox1.Text = "settings"
        Form36.SEV()
        '    Else
        'Form39settings.Show()
        'End If
        'End If
    End Sub

    Private Sub Button7_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button7.Click
        Form61.Show()
    End Sub

    Private Sub Button8_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button8.Click
        'Form22.Show()
        'If isDevmodeon = "true" Then
        'Form39settings.Show()
        'Else
        'If My.Computer.FileSystem.FileExists("Sebastian-admin.swfiles") Then
        Form36.Show()
        Form36.TextBox1.Text = "settings/info"
        Form36.SEV()
        '    Else
        'Form39settings.Show()
        'End If
        'End If
        'Form39settings.Show()
        'Form39settings.openChildForm(New Form22)
    End Sub

    Private Sub Button12_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button12.Click
        Form30.Show()

        'Form30.BackColor = Panel1.BackColor
        'Form30.BackColor = Panel1.BackColor
        'Form30.BackColor = Panel1.BackColor
        'Form30.BackColor = Panel1.BackColor
        'Form30.BackColor = Panel1.BackColor
    End Sub

    Private Sub Picture1_MouseDown(sender As Object, e As MouseEventArgs) Handles Picture1.MouseDown
        If (e.Button = MouseButtons.Right) Then
            Panel2.Visible = True
            Panel2.Location = Cursor.Position
            StartMenuPanel.Visible = False
        End If
        If (e.Button = MouseButtons.Left) Then
            Panel2.Visible = False
            StartMenuPanel.Visible = False
        End If
    End Sub

    Private Sub LinkLabel1_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LinkLabel1.LinkClicked
        swtask.Show()
        Panel2.Visible = False
    End Sub

    Private Sub LinkLabel2_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LinkLabel2.LinkClicked
        Form36.Show()
        Form36.TextBox1.Text = "settings"
        Form36.SEV()
        Panel2.Visible = False
    End Sub

    Private Sub LinkLabel3_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LinkLabel3.LinkClicked
        Form21.Show()
        Panel2.Visible = False
    End Sub

    Private Sub LinkLabel4_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LinkLabel4.LinkClicked
        Form61.Show()
        Panel2.Visible = False
    End Sub

    Private Sub LinkLabel5_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LinkLabel5.LinkClicked
        Form17.Show()
        Form17.CVW()
        Panel2.Visible = False
    End Sub

    Private Sub Button12_MouseDown(sender As Object, e As MouseEventArgs) Handles Button12.MouseDown
        If (e.Button = MouseButtons.Right) Then
            Form30.Show()
        End If
    End Sub

    Private Sub PictureBox6_Click(sender As Object, e As EventArgs) Handles PictureBox6.Click
        'Form33.Show()
    End Sub
    Public Sub Start_Form19()
        'If My.Computer.FileSystem.DirectoryExists("Sebs SW.exe.WebView2") Then
        'If My.Computer.FileSystem.DirectoryExists("runtimes") Then
        'If My.Computer.FileSystem.FileExists("Microsoft.Web.WebView2.Core.dll") Then
        'If My.Computer.FileSystem.FileExists("Microsoft.Web.WebView2.WinForms.dll") Then
        'If My.Computer.FileSystem.FileExists("Microsoft.Web.WebView2.Wpf.dll") Then
        Dim Form19_Modded As New Internetplusplus
        Try
            Form19_Modded.Show()
        Catch ex As Exception
            Form32.Show()
            Form32.Label2.Text = ex.Message
        End Try

        '                Else
        'MsgBox("You Need Microsoft.Web.WebView2.Wpf.dll File")

        'End If
        'Else
        'MsgBox("You Need Microsoft.Web.WebView2.WinForms.dll File")

        'End If
        'Else
        'MsgBox("You Need Microsoft.Web.WebView2.Core.dll File")

        'End If
        'Else
        'MsgBox("You Need runtimes Directory")

        'End If
        'Else
        'MsgBox("You Need Sebs SW.exe.WebView2 Directory")

        'End If
    End Sub

    Private Sub TextBox1_KeyDown(sender As Object, e As KeyEventArgs) Handles Søg.KeyDown
        Button15_Click(Me, e)
    End Sub

    Private Sub Timer2_Tick(sender As Object, e As EventArgs) Handles Timer2.Tick
        ProgressBar1.Increment(4)
        If ProgressBar1.Value = ProgressBar1.Maximum Then
            'Form17.Close()
            Me.Close()
        End If
    End Sub

    Private Sub PictureBox20_Click(sender As Object, e As EventArgs) Handles PictureBox20.Click
        AP.Show()
    End Sub

    Private Sub Label13_Click(sender As Object, e As EventArgs) Handles Label13.Click

    End Sub

    Private Sub PictureBox21_Click(sender As Object, e As EventArgs) Handles PictureBox21.Click

    End Sub

    Private Sub PictureBox20_MouseEnter(sender As Object, e As EventArgs) Handles PictureBox21.MouseEnter, PictureBox20.MouseEnter, Label13.MouseEnter
        AP.Show()
    End Sub

    Private Sub PictureBox20_MouseLeave(sender As Object, e As EventArgs) Handles PictureBox21.MouseLeave, PictureBox20.MouseLeave, Label13.MouseLeave

    End Sub

    Private Sub Button13_Click(sender As Object, e As EventArgs) Handles Button13.Click
        Form57.Show()
        Form57.RestartTimer.Start()
    End Sub

    Private Sub Label12_Click(sender As Object, e As EventArgs) Handles Label12.Click

    End Sub

    Private Sub Panel4_MouseDown(sender As Object, e As MouseEventArgs) Handles Desktopwindow.MouseDown
        If (e.Button = MouseButtons.Right) Then
            Panel2.Visible = True
            Panel2.Location = Cursor.Position
            StartMenuPanel.Visible = False
        End If
        If (e.Button = MouseButtons.Left) Then
            Panel2.Visible = False
            'StartMenu.Visible = False
            StartMenuPanel.Visible = False
        End If
    End Sub

    Private Sub StartMenuPanel_MouseDown(sender As Object, e As MouseEventArgs) Handles StartMenuPanel.MouseDown
        If (e.Button = MouseButtons.Left) Then
            Panel2.Visible = False
            StartMenuPanel.Visible = False
        End If
        If (e.Button = MouseButtons.Right) Then
            Panel2.Visible = True
            Panel2.Location = Cursor.Position
            StartMenuPanel.Visible = False
        End If
    End Sub

    Private Sub Button14_Click(sender As Object, e As EventArgs) Handles Button14.Click
        AP.Show()
        Panel2.Visible = False
    End Sub

    Private Sub Button15_Click(sender As Object, e As EventArgs) Handles Button15.Click
        If Søg.Text = "CMD" Then
            Form17.Show()
        End If
        If Søg.Text = "Picviewer" Then
            Form40.Show()
        End If
        If Søg.Text = "Run" Then
            AboutBox17.Show()
        End If
        If Søg.Text = "Internet++" Then
            Try
                Internetplusplus.Show()
            Catch ex As Exception
                Form35.Show()
            End Try
        End If
        If Søg.Text = "Settings" Then
            Form36.Show()
            Form36.TextBox1.Text = "settings"
            Form36.SEV()
        End If
        If Søg.Text = "About" Then
            About2.Show()
        End If
        If Søg.Text = "Apps" Then
            Form55.Show()
        End If
        If Søg.Text = "Taskman" Then
            'Form25.Show()
            Dim no As String = "No use"
        End If
        If Søg.Text = "SWTask" Then
            swtask.Show()
        End If
    End Sub

    Public Sub Button16_Click(sender As Object, e As EventArgs) Handles Button16.Click
        Dim to_startup_form As New Form17
        to_startup_form.Show()
        to_startup_form.RichTextBox1.Text = "C:/Sebs-SW-CV/startup"
        to_startup_form.WindowState = FormWindowState.Minimized

        Timer2.Start()
        'Dim f As New Aboutbeta
        'Aboutbeta.Show()
        'Aboutbeta.Close()
        'f.Show()
        'f.Close()
        'f.Show()
        'f.Close()
        'f.Show()
        'f.Close()
        'Form17.Close()
        'Close()
    End Sub

    Private Sub Button18_Click(sender As Object, e As EventArgs) Handles Button18.Click
        If Menu_ = "0" Then
            If StartMenuPanel.Visible = True Then
                StartMenuPanel.Visible = False
            ElseIf StartMenuPanel.Visible = False Then
                StartMenuPanel.Visible = True
            End If
        ElseIf Menu_ = "1" Then
            Form30.Show()
        End If
        'startbutton2.Visible = True
        'Button19.Visible = True
        Panel2.Visible = False
    End Sub

    Private Sub Button19_Click(sender As Object, e As EventArgs) Handles Button19.Click
        StartMenuPanel.Visible = False
        'startbutton2.Visible = False
        Button19.Visible = False
        Panel2.Visible = False
    End Sub

    Private Sub Button20_Click(sender As Object, e As EventArgs) Handles Button20.Click
        'Internetplusplusstarter.Show()
        'Form35.Show()
        Try
            Internetplusplus.Show()
        Catch ex As Exception
            Form35.Show()
        End Try
        Panel2.Visible = False
    End Sub

    Private Sub Button21_Click(sender As Object, e As EventArgs) Handles Button21.Click
        'If isDevmodeon = "true" Then
        'Form31.Show()
        'Else
        'If My.Computer.FileSystem.FileExists("Sebastian-admin.swfiles") Then
        Form36.Show()
        Form36.PictureBox1.Image = Button21.BackgroundImage
        Form36.Label1.Text = "File Explorer"
        Form36.TextBox1.Text = "C:/"
        Form36.SEV()
        '    Else
        'Form31.Show()
        'End If
        'End If

        Panel2.Visible = False
    End Sub

    Private Sub Button22_Click(sender As Object, e As EventArgs) Handles Button22.Click
        'If isDevmodeon = "true" Then
        'Form39settings.Show()
        'Else
        'If My.Computer.FileSystem.FileExists("Sebastian-admin.swfiles") Then
        Form36.Show()
        Form36.Label1.Text = "Settings"

        Form36.TextBox1.Text = "settings"
        Form36.SEV()
        '    Else
        'Form39settings.Show()
        'End If
        'End If

        Panel2.Visible = False
    End Sub

    Private Sub Button23_Click(sender As Object, e As EventArgs) Handles Button23.Click
        Form15.Show()
        'Programtab.Show()
        Panel2.Visible = False
    End Sub

    Private Sub Button17_Click(sender As Object, e As EventArgs) Handles Button17.Click
        closeForm_1pad.Show()
    End Sub

    Private Sub Form_1pad_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        If Panel1.Dock = DockStyle.Top Then
            If My.Computer.FileSystem.FileExists(My.Application.Info.DirectoryPath + "\taskbarloc.swfiles") Then
                My.Computer.FileSystem.DeleteFile(My.Application.Info.DirectoryPath + "\taskbarloc.swfiles")
                My.Computer.FileSystem.WriteAllText(My.Application.Info.DirectoryPath + "\taskbarloc.swfiles", "top", False)
            Else
                My.Computer.FileSystem.WriteAllText(My.Application.Info.DirectoryPath + "\taskbarloc.swfiles", "top", False)
            End If
            'My.Computer.FileSystem.WriteAllText(My.Application.Info.DirectoryPath + "\taskbarloc.swfiles", "", False)
        ElseIf Panel1.Dock = DockStyle.Bottom Then
            If My.Computer.FileSystem.FileExists(My.Application.Info.DirectoryPath + "\taskbarloc.swfiles") Then
                My.Computer.FileSystem.DeleteFile(My.Application.Info.DirectoryPath + "\taskbarloc.swfiles")
                My.Computer.FileSystem.WriteAllText(My.Application.Info.DirectoryPath + "\taskbarloc.swfiles", "bottom", False)
            Else
                My.Computer.FileSystem.WriteAllText(My.Application.Info.DirectoryPath + "\taskbarloc.swfiles", "bottom", False)
            End If

        End If
        newui_5263.Show()
        newui_5263.Close()
        UI.Close()
    End Sub

    Private Sub Button24_Click(sender As Object, e As EventArgs) Handles Button24.Click
        Søg.Text = Søg.Text + Form61.TextBox1.Text
    End Sub

    Private Sub ToolStripMenuItem5_Click(sender As Object, e As EventArgs) Handles ToolStripMenuItem5.Click
        Form17.Show()
        Form17.CVW()
    End Sub

    Private Sub Button25_Click(sender As Object, e As EventArgs) Handles Button25.Click
        editsw.Show()
    End Sub

    Private Sub SSS_Tick(sender As Object, e As EventArgs) Handles SSS.Tick
        If Button14.Visible = False Then
            If Button25.Visible = False Then
            Else
                Dim ss = Button14.Location
                Button25.Location = Button14.Location
                Button14.Location = ss
            End If
        Else 'If Button25.Visible = False Then
            If Button25.Visible = False Then
                If Button14.Visible = False Then
                Else
                    Dim ss = Button25.Location
                    Button14.Location = Button25.Location
                    Button25.Location = ss
                    '_1_3()
                End If

            Else
            End If
        End If
        'If Button25.Visible = False Then

        'End If
    End Sub
    Private Sub _1_3()
        If Button14.Visible = False Then

        End If
    End Sub
    Public ss As String = "12" ''''''''
    Private Sub Button26_Click(sender As Object, e As EventArgs) Handles Button26.Click
        Form40.Show()
        Panel2.Visible = False
    End Sub

    Private Sub Button27_Click(sender As Object, e As EventArgs) Handles Button27.Click
        Try
            Form64.Show()
        Catch ex As Exception

        End Try
    End Sub
End Class