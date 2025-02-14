Public Class Form_1pad
    Public opened As String = "2"
    Public Usernamestring As String
    Public isDevmodeon As String
    Public InDevMode As Boolean = False
    'Public swtask2 As String = "old"
    Public internetplusplusting As String = "New"
    Public editsw_ As String = "0"
    Public SWTask_APP As String = "0"
    Public AltLib As String = "0"
    Public SearchMenu As String = "False"
    Public calc1 As String = "0"
    Public VersionofDev = "00189"
    Public About__ As String = "0"
    Public Username As String = "Admin"
    Public Password As String = ""
    Public USERCHANGE As String = "0"
    'Let none main path Icons go.
    'It's time.
    'Modren blocker (Supports Secure/Locked Mode)
    Public BlockOldModren As Boolean = True
    Public BlockNotsebsModren As Boolean = True
    Public BlockSebsModren As Boolean = False
    Public BlockThewebModren As Boolean = False
    Public BlockUsercontrolModren As Boolean = False

    'Color of Controls
    Public ButtonColor As Color = Color.Gainsboro
	Public LinkButtonColor As Color = Color.DeepSkyBlue
    'Color of Controls
    Public Appencode As String = "False"
    Public TabwithFE As String = "1"
    Public TaskbarValue As String = "1"
    Public SearchMode As String = "Show"
    '------------------------------------------- Used By Blocker
    Public Blockold = "True"
    Public Blocknotsebs = "False" 'For safe use of Sebs SW CV in Beta
    Public Blocksebs = "False"
    Public Blocktheweb = "False"
    Public Blockusercontrol = "False" 'Don't make it True. Don't PLS. I'm sorry for it.
    '------------------------------------------- Used By Blocker

    'Public d2 As Boolean = Button1.Text
    Private Sub CloseToForm1pad15ToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CloseToForm1pad15ToolStripMenuItem.Click
        form1Pad.Show()
        Close()
    End Sub

    Private Sub ToolStripMenuItem2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripMenuItem2.Click
        StartMenu.Visible = True
    End Sub

    Public Sub Panellooking()
        If Panel1.Visible = True Then

        End If
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
        'Form17.Show()
    End Sub

    Private Sub PictureBox2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox2.Click
        'Form35.Show()
        'Form19.Show()
        'Start_Form19()
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
        'Form20.Show()
    End Sub

    Private Sub PictureBox13_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox13.Click
        'Form22.Show()
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
        'Loads UI
        UI.Show()

        'Old Shit
        Panel2.BackColor = Panel1.BackColor

        'Used by Blocker
        If My.Computer.FileSystem.FileExists(My.Application.Info.DirectoryPath & "\Apps\Blocker.swfiles") Then
            Dim HomeDirandapps As String = My.Application.Info.DirectoryPath & "\Apps\"
            Dim Reader As String = ""
            Reader = My.Computer.FileSystem.ReadAllText(HomeDirandapps & "Blocker.swfiles")
            If Reader.Contains("1") = True Then
                Blockold = "True"
            End If
            If Reader.Contains("2") = True Then
                Blocknotsebs = "True"
            End If
            If Reader.Contains("3") = True Then
                Blocksebs = "True"
            End If
            If Reader.Contains("4") = True Then
                Blocktheweb = "True"
            End If
            If Reader.Contains("5") = True Then
                Blockusercontrol = "True"
            End If
        Else

        End If
        'Used by Blocker

        'Starts DevMode
        isDevmodeon = My.Settings.isdevmodeon

        'Starts Startup Audio
        If My.Computer.FileSystem.FileExists(My.Application.Info.DirectoryPath & "\Settings\StartAudio.swfiles") Then
            Dim reader As String = My.Computer.FileSystem.ReadAllText(My.Application.Info.DirectoryPath & "\Settings\StartAudio.swfiles")
            Try
                Dim b As Byte() = Convert.FromBase64String(reader)
                reader = System.Text.Encoding.UTF8.GetString(b)
            Catch ex As Exception
                UI.ErrorForm(True, ex.Message & "
" & ex.Source, True)

            End Try
            If reader = "True" Then
                My.Computer.Audio.Play(My.Resources.upupupdown3, AudioPlayMode.Background)
            Else

            End If
        End If

        'Calc
        If My.Computer.FileSystem.FileExists(My.Application.Info.DirectoryPath + "\Apps\calcp.swfiles") Then
            'calc1 = "1"
            Dim sgg As String = My.Computer.FileSystem.ReadAllText(My.Application.Info.DirectoryPath + "\Apps\calcp.swfiles")
            If sgg = "2.7.0" Then
                calc1 = "1"
            Else
                calc1 = "0"
            End If
        Else
            calc1 = "0"
        End If

        'Editswfiles
        If My.Computer.FileSystem.FileExists(My.Application.Info.DirectoryPath + "\Apps\editsw.swfiles") Then
            editsw_ = "1"
        Else
            editsw_ = "0"
        End If

        'New SWTask
        If My.Computer.FileSystem.FileExists(My.Application.Info.DirectoryPath + "\Apps\swtaskp.swfiles") Then
            SWTask_APP = "1"
        Else
            SWTask_APP = "0"
        End If

        'AltLib
        If My.Computer.FileSystem.FileExists(My.Application.Info.DirectoryPath + "\Apps\altlib.swfiles") Then
            AltLib = "1"
        Else
            AltLib = "0"
        End If

        'File Explorer Settings
        If My.Computer.FileSystem.FileExists(My.Application.Info.DirectoryPath + "\ext\settfe.swfiles") Then
            ext_mgr.fileexplorersettingstosettings = "True"
        Else
            ext_mgr.fileexplorersettingstosettings = "False"
        End If

        'Closes Form48
        Form48.Close()

        'Loads Colors to Panels
        TaskbarPanel.BackColor = Color.FromArgb(55, Color.Silver)
        TopPanel.BackColor = Color.FromArgb(55, Color.Silver)
        Panel2.BackColor = Color.FromArgb(55, Color.Silver)
        Panel4.BackColor = Color.FromArgb(65, TaskbarColor)

        'Location of Taskbar
        UI.Location_Taskbar()

        'Loads Taskbar
        TaskbarPanel.Visible = True

        'Loads Start Menu, Taskbar and UC's
        If My.Settings.StartMenuLoad = True Then
            If Blockusercontrol = "True" Then
            Else
                UI.ThemeLoader("Taskbar=2")
                UI.StartmenuLoader(StartMenuControls, False)
                UI.ThemeLoader("LoadNewUISettings=True")
                'Loads User Controls
                LoadUCs(True, True, True)
                Panel1.Visible = False
            End If

        ElseIf My.Settings.StartMenuLoad = False Then
            Panel1.Visible = True
            LoadOld()
        End If
        SSS.Start()
        'Load Picture Code
        If My.Computer.FileSystem.FileExists(My.Application.Info.DirectoryPath & "\Settings\CustomWallpaper.swfiles") Then
            Dim reader As String = My.Computer.FileSystem.ReadAllText(My.Application.Info.DirectoryPath & "\Settings\CustomWallpaper.swfiles")
            If reader.Contains(":\") = True Then
                Try
                    Picture1.Load(reader)
                    Desktopwindow.BackgroundImage = Picture1.Image
                Catch ex As Exception
                    UI.ErrorForm(False, "Failed to Load Picture", True)
                End Try
            Else
                If reader = "Wallpaper1" Then
                    Picture1.Image = My.Resources.Wallpaper_1
                    Desktopwindow.BackgroundImage = Picture1.Image
                ElseIf reader = "Wallpaper2" Then
                    Picture1.Image = My.Resources.Wallpaper_2
                    Desktopwindow.BackgroundImage = Picture1.Image
                ElseIf reader = "Wallpaper3" Then
                    Picture1.Image = My.Resources.Wallpaper_3
                    Desktopwindow.BackgroundImage = Picture1.Image
                ElseIf reader = "Wallpaper4" Then
                    Picture1.Image = My.Resources.Wallpaper_4
                    Desktopwindow.BackgroundImage = Picture1.Image
                ElseIf reader = "Wallpaper5" Then
                    Picture1.Image = My.Resources.Wallpaper_5
                    Desktopwindow.BackgroundImage = Picture1.Image
                ElseIf reader = "Wallpaper6" Then
                    Picture1.Image = My.Resources.Wallpaper_6
                    Desktopwindow.BackgroundImage = Picture1.Image
                ElseIf reader = "Wallpaper7" Then
                    Picture1.Image = My.Resources.Wallpaper_7
                    Desktopwindow.BackgroundImage = Picture1.Image
                ElseIf reader = "Wallpaper8" Then
                    Picture1.Image = My.Resources.Wallpaper_8
                    Desktopwindow.BackgroundImage = Picture1.Image
                ElseIf reader = "Wallpaper9" Then
                    Picture1.Image = My.Resources.Wallpaper_9
                    Desktopwindow.BackgroundImage = Picture1.Image
                End If
            End If


        End If

        'Backup of wallpaper
        Picture1.Image = Desktopwindow.BackgroundImage

        'Configs StartMenu/StartWindow
        If My.Computer.FileSystem.FileExists(My.Application.Info.DirectoryPath + "\Settings\Menu.swfiles") Then
            Menu_ = My.Computer.FileSystem.ReadAllText(My.Application.Info.DirectoryPath + "\Settings\Menu.swfiles")
        End If

        'If to Show Timebar
        If My.Computer.FileSystem.FileExists(My.Application.Info.DirectoryPath & "\Settings\ShowTimebar.swfiles") Then
            'Gets info from the file.
            Dim reader As String = My.Computer.FileSystem.ReadAllText(My.Application.Info.DirectoryPath & "\Settings\ShowTimebar.swfiles")
            'Finds out if the string writes is True or False 
            Try
                Dim b As Byte() = Convert.FromBase64String(reader)
                reader = System.Text.Encoding.UTF8.GetString(b)
            Catch ex As Exception
                UI.ErrorForm(True, ex.Message & "
" & ex.Source, True)

            End Try
            If reader = "True" Then
                UI.TopPanelLoad(True)
            ElseIf reader = "False" Then
                UI.TopPanelLoad(False)
            End If
        Else

        End If

        ' More Settings about File explorer
        If My.Computer.FileSystem.FileExists(My.Application.Info.DirectoryPath + "\Settings\FEwithTabs.swfiles") Then
            Dim ss As String = ""
            ss = My.Computer.FileSystem.ReadAllText(My.Application.Info.DirectoryPath + "\Settings\FEwithTabs.swfiles")
            If ss = "0" Then
                TabwithFE = "0"
            ElseIf ss = "1" Then
                TabwithFE = "1"
            End If
        Else
            TabwithFE = "0"
        End If

        'Moded Code for nothing
        If My.Computer.FileSystem.FileExists(My.Application.Info.DirectoryPath + "\DevUse\TurnOffUCs.swfiles") Then
            Dim Text_ As String = ""
            Text_ = My.Computer.FileSystem.ReadAllText(My.Application.Info.DirectoryPath + "\DevUse\TurnOffUCs.swfiles")
            If Text_ = "VkhWeWJrOW1aazF2WkdWeWJsVkRjejFVY25WbExDQlVkWEp1VDI1TmIyUmxjbTVWUTNNOVJtRnNjMlU9" Then
                UnLoadUCs(True, True, True)
                UI.ThemeLoader("Taskbar=1")
            ElseIf Text_ = "VkhWeWJrOW1aazF2WkdWeWJsVkRjejFHWVd4elpTd2dWSFZ5Yms5dVRXOWtaWEp1VlVOelBWUnlkV1U9" Then
            End If
        Else
        End If

        'Search Menu
        If My.Computer.FileSystem.FileExists(My.Application.Info.DirectoryPath + "\Settings\searchmenu.swfiles") Then
            Dim ss As String = ""
            ss = My.Computer.FileSystem.ReadAllText(My.Application.Info.DirectoryPath + "\Settings\searchmenu.swfiles")
            If ss = "False" Then
                SearchMenu = "False"
                UI.TaskbarGUI.Button2.Visible = False
            ElseIf ss = "True" Then
                SearchMenu = "True"
                UI.TaskbarGUI.Button2.Visible = True
            End If
        End If

        'Config File For User
        If My.Computer.FileSystem.FileExists(My.Application.Info.DirectoryPath + "\Settings\settings.config") Then
            Dim Text_ As String = ""
            Text_ = My.Computer.FileSystem.ReadAllText(My.Application.Info.DirectoryPath & "\Settings\settings.config")
            UI.LoadUserSettings(Username, Password, Text_)
        Else
        End If



        If My.Computer.FileSystem.FileExists("Load_LOADFIXS.swfiles") Then
            UI_Fix_36146_code_Runer.LoadAtStartSub()
        End If
    End Sub
    Public Number = "0"
	Public StartwithTab As Integer = 0
    Friend WithEvents R As System.Windows.Forms.RichTextBox
    Public Sub LoadOld()
        ' StartMenuPanel
        Me.StartMenuPanel.BackColor = System.Drawing.Color.Transparent
        Me.StartMenuPanel.Controls.Add(Me.StartMenu)
        Me.StartMenuPanel.Dock = System.Windows.Forms.DockStyle.Left
        Me.StartMenuPanel.Location = New System.Drawing.Point(0, 0)
        Me.StartMenuPanel.Name = "StartMenuPanel"
        Me.StartMenuPanel.Size = New System.Drawing.Size(671, 572)
        Me.StartMenuPanel.TabIndex = 1
        Me.StartMenuPanel.Visible = False
        Me.StartMenu.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.StartMenu.Location = New System.Drawing.Point(0, 15)
        Me.StartMenu.Name = "StartMenu"
        Me.StartMenu.Size = New System.Drawing.Size(671, 557)
    End Sub
    Public StartMenuControls As New StartMenu
    Public textedit As String = ""
    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        MsgBox(My.Computer.Info.OSFullName)
    End Sub
    'UC = User Control
    Public ContextMenu_UC As New ContextMenu
    Public ContextMenu_Taskbar_UC As New ContextMenu_Taskbar
    Public TimeBar_UC As New TimeBar

    Public Sub LoadUCs(Timebar As Boolean, ContextMenu As Boolean, ContextMenu_Taskbar As Boolean)
        If Timebar = True Then
            TopPanel.Controls.Add(TimeBar_UC)
            TimeBar_UC.Dock = DockStyle.Fill
            TimeBar_UC.BringToFront()
            TimeBar_UC.BackColor = Color.FromArgb(55, TaskbarColor)
        End If
        If ContextMenu = True Then
            Panel7.Controls.Add(ContextMenu_UC)
            ContextMenu_UC.Dock = DockStyle.Fill
            ContextMenu_UC.BringToFront()
            ContextMenu_UC.BackColor = Color.FromArgb(55, TaskbarColor)
        End If
        If ContextMenu_Taskbar = True Then
            Panel8.Controls.Add(ContextMenu_Taskbar_UC)
            ContextMenu_Taskbar_UC.Dock = DockStyle.Fill
            ContextMenu_Taskbar_UC.BringToFront()
            ContextMenu_Taskbar_UC.BackColor = Color.FromArgb(55, TaskbarColor)
        End If
    End Sub
    Public Sub UnLoadUCs(Timebar As Boolean, ContextMenu As Boolean, ContextMenu_Taskbar As Boolean)
        If Timebar = True Then
            TopPanel.Controls.Remove(TimeBar_UC)
        End If
        If ContextMenu = True Then
            Panel7.Controls.Remove(ContextMenu_UC)
        End If
        If ContextMenu_Taskbar = True Then
            Panel8.Controls.Remove(ContextMenu_Taskbar_UC)
        End If
    End Sub

    Public Network As String = "True"
	Public help As String = ""

    Private Sub Timer1_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer1.Tick
        If help = "{472-462-537}" Then
            If Form61.Button1.Visible = True Then
                Button24.Visible = True
            Else
                Button24.Visible = False
            End If
            StartMenu.BackColor = Panel1.BackColor
            Label1.Text = Format(Now, "HH:mm:ss")
            Label5.Text = Format(Now, "dd-MM-yyyy")
        End If
        If UI.BuildVersion = "00294" Then
            If VersionofDev = "00011" Then
            Else
                If Timer3.Enabled = False Then
                    Timer3.Start()
                End If
                If UI.Timer3.Enabled = False Then
                    UI.Timer3.Start()
                End If
            End If
        Else
            If Timer3.Enabled = False Then
                Timer3.Start()
            End If
            If UI.Timer3.Enabled = False Then
                UI.Timer3.Start()
            End If
        End If
        Me.BackColor = TaskbarColor
        ' Date and time
        Label3.Text = Format(Now, "HH:mm:ss")
        Label6.Text = Format(Now, "HH:mm:ss")
        Label4.Text = Format(Now, "dd-MM-yyyy")
        If StartMenu.Visible = False Then

            If help = "{472-462-537}" Then
                StartMenu.Visible = True
            End If
            'StartMenu.Visible = True
        End If
        If StartMenuPanel.Visible = True Then
            Panel2.Visible = False
        End If
    End Sub
    Public SS11 As Integer = 0
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

        Form44.Show()
        Form44.TextBox1.Text = "settings/info"
        Form44.SEV()

    End Sub

    Public Sub Reload_swtask()
        swtask.Close()
        swtask.Show()
    End Sub

    Private Sub Button6_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button6.Click
		'Form31.Show()
		'If isDevmodeon = "true" Then
		'Form39settings.Show()
		'Else
		'If My.Computer.FileSystem.FileExists("Sebastian-admin.swfiles") Then
		UI.StartFileExplorer()
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
        'cmdpad.Show()
    End Sub

    Public Sub Ssss2()
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
            Internetplusplus2.Show()
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
        Form44.Show()
        Form44.TextBox1.Text = "settings"
        Form44.SEV()
    End Sub

    Private Sub Button7_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button7.Click
        Form61.Show()
    End Sub

    Private Sub Button8_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button8.Click
        Form44.Show()
        Form44.TextBox1.Text = "settings/info"
        Form44.SEV()
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
        Form44.Show()
        Form44.TextBox1.Text = "settings"
        Form44.SEV()
        Panel2.Visible = False
    End Sub

    Private Sub LinkLabel3_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LinkLabel3.LinkClicked
        'Form21.Show()
        'cmdpad.Show()
        'cmdpad.Old_New_CMDTab = "N"
        'cmdpad.tools()
        Try
            Internetplusplus3.Show()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
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

    End Sub
    Public Sub Start_Form19()
        Dim Form19_Modded As New Internetplusplus3
        Try
            Form19_Modded.Show()
        Catch ex As Exception

            UI.ErrorForm(False, ex.Message, True)

        End Try
    End Sub

    Private Sub TextBox1_KeyDown(sender As Object, e As KeyEventArgs) Handles Søg.KeyDown
        Button15_Click(Me, e)
    End Sub

    Private Sub Timer2_Tick(sender As Object, e As EventArgs) Handles Timer2.Tick
        ProgressBar1.Increment(4)
        If ProgressBar1.Value = ProgressBar1.Maximum Then
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

    Public Sub Button13_Click(sender As Object, e As EventArgs) Handles Button13.Click
        'Form57.Show()
        'Form57.RestartTimer.Start()
    End Sub

    Private Sub Label12_Click(sender As Object, e As EventArgs) Handles Label12.Click

    End Sub

    Private Sub Panel4_MouseDown(sender As Object, e As MouseEventArgs) Handles Desktopwindow.MouseDown
        If (e.Button = MouseButtons.Right) Then
            Panel2.Visible = True
            Panel2.Location = Cursor.Position
			StartMenuPanel.Visible = False
			Panel4.Visible = False
		End If
        If (e.Button = MouseButtons.Left) Then
			Panel2.Visible = False
			Panel2.Visible = False
            Panel4.Visible = False
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
    Public Sub Søgting()
        If Søg.Text = "CMD" Then
            'Form17.Show()
            UI.StartCMD("New")
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
            Form44.Show()
            Form44.TextBox1.Text = "settings"
            Form44.SEV()
        End If
        If Søg.Text = "About" Then
            About2.Show()
        End If
        If Søg.Text = "Apps" Then
            Form55.Loadm("Apps")
        End If
        If Søg.Text = "Taskman" Then
            'Form25.Show()
            Dim no As String = "No use"
        End If
        If Søg.Text = "SWTask" Then
            UI.StartSWTask()
        End If
    End Sub

    Private Sub Button15_Click(sender As Object, e As EventArgs) Handles Button15.Click
        søgting()
    End Sub

    Public Sub Button16_Click(sender As Object, e As EventArgs) Handles Button16.Click
        Dim to_startup_form As New Form17
        to_startup_form.Show()
        to_startup_form.RichTextBox1.Text = "C:/Sebs-SW-CV/startup"
        to_startup_form.WindowState = FormWindowState.Minimized

        Timer2.Start()
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
        Panel2.Visible = False
    End Sub

    Private Sub Button19_Click(sender As Object, e As EventArgs) Handles Button19.Click
        StartMenuPanel.Visible = False
        Button19.Visible = False
        Panel2.Visible = False
    End Sub

    Private Sub Button20_Click(sender As Object, e As EventArgs) Handles Button20.Click

        If UI.OldIconSystem = "True" Then
            Try
                Internetplusplus3.Show()
            Catch ex As Exception
                Form35.Show()
            End Try
        Else
            MsgBox("CVW is too old", MsgBoxStyle.Critical)
        End If
        Panel2.Visible = False
    End Sub

    Private Sub Button21_Click(sender As Object, e As EventArgs) Handles Button21.Click
        If UI.OldIconSystem = "True" Then
            UI.StartFileExplorer()
        Else
            UI.ErrorForm(False, "CVW is too old", True)
        End If
        Panel2.Visible = False
    End Sub

    Private Sub Button22_Click(sender As Object, e As EventArgs) Handles Button22.Click
        If UI.OldIconSystem = "True" Then
            UI.StartSettings()
        Else
            Form36.Show()
            Form36.Label1.Text = "Settings"
            'Form44.TextBox1.Text = "settings"
            Form36.SEV()
        End If

        Panel2.Visible = False
    End Sub

    Private Sub Button23_Click(sender As Object, e As EventArgs) Handles Button23.Click
        '
        If UI.OldIconSystem = "True" Then
            'Form15.Show()
            Form37.Show()
        Else
            MsgBox("CVW is too old", MsgBoxStyle.Critical)
        End If

        Panel2.Visible = False
    End Sub

    Public Sub Button17_Click(sender As Object, e As EventArgs) Handles Button17.Click
        closeForm_1pad.Show()
    End Sub

    Private Sub Form_1pad_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        If TaskbarPanel.Dock = DockStyle.Top Then
            If My.Computer.FileSystem.FileExists(My.Application.Info.DirectoryPath + "\Settings\taskbarloc.swfiles") Then
                My.Computer.FileSystem.DeleteFile(My.Application.Info.DirectoryPath + "\Settings\taskbarloc.swfiles")
                My.Computer.FileSystem.WriteAllText(My.Application.Info.DirectoryPath + "\Settings\taskbarloc.swfiles", "top", False)
            Else
                My.Computer.FileSystem.WriteAllText(My.Application.Info.DirectoryPath + "\Settings\taskbarloc.swfiles", "top", False)
            End If
            'My.Computer.FileSystem.WriteAllText(My.Application.Info.DirectoryPath + "\Settings\taskbarloc.swfiles", "", False)
        ElseIf TaskbarPanel.Dock = DockStyle.Bottom Then
            If My.Computer.FileSystem.FileExists(My.Application.Info.DirectoryPath + "\Settings\taskbarloc.swfiles") Then
                My.Computer.FileSystem.DeleteFile(My.Application.Info.DirectoryPath + "\Settings\taskbarloc.swfiles")
                My.Computer.FileSystem.WriteAllText(My.Application.Info.DirectoryPath + "\Settings\taskbarloc.swfiles", "bottom", False)
            Else
                My.Computer.FileSystem.WriteAllText(My.Application.Info.DirectoryPath + "\Settings\taskbarloc.swfiles", "bottom", False)
            End If

        End If
        UI.ColorSaver(TaskbarColor)
        newui_5263.Show()
        newui_5263.Close()
        UI.Close()
    End Sub

    Private Sub Button24_Click(sender As Object, e As EventArgs) Handles Button24.Click
        Søg.Text = Søg.Text + Form61.TextBox1.Text
    End Sub

    Private Sub ToolStripMenuItem5_Click(sender As Object, e As EventArgs) Handles ToolStripMenuItem5.Click
        'Form17.Show()
        'Form17.CVW()
        UI.StartCMD("New")
    End Sub

    Private Sub Button25_Click(sender As Object, e As EventArgs) Handles Button25.Click
        editsw.Show()
    End Sub

    Private Sub SSS_Tick(sender As Object, e As EventArgs) Handles SSS.Tick
        If Panel1.Visible = True Then
            If TaskbarPanel.Visible = False Then
                ReloadTaskbar()
            End If
        Else
            If StartMenu.Visible = True Then
                UI.ErrorForm(False, " Error-Code=ERROR-LOADING-OLD-UNSUPPORTED- This is not a Stop Window
Something may be broken. This Error shows when Panel1 (Old taskbar) shows up.
This may need a reinstall, only if you see this again.", True)
            End If
        End If
    End Sub

    Private Sub _1_3()
        If Button14.Visible = False Then

        End If
    End Sub
    Public ss As String = "12"
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
    Public TaskbarColor As Color = Color.Silver
    '-----------------------------------------------------
    Public App1 As Integer = 0
	Public App2 As Integer = 0

	Public App1_ As New Point(894, 3)
	Public App2_ As New Point(966, 3)
    '-----------------------------------------------------

    Private Sub Button28_Click(sender As Object, e As EventArgs) Handles Button28.Click
        If Blocksebs = "True" Then
            If My.Settings.Safemode = True Then
                If StartMenuPanel2.Visible = True Then
                    StartMenuPanel2.Visible = False
                ElseIf StartMenuPanel2.Visible = False Then
                    StartMenuPanel.Visible = True
                    StartMenuPanel2.Visible = True
                    StartMenuPanel2.BackColor = TaskbarPanel.BackColor
                    StartMenuControls.Panel1.Visible = True
                End If
            Else
                MsgBox("Object does not Exist")
            End If
            'Opacity = 11
        Else
            If Menu_ = "0" Then


                If StartMenuPanel2.Visible = True Then
                    StartMenuPanel2.Visible = False
                ElseIf StartMenuPanel2.Visible = False Then
                    StartMenuPanel.Visible = True
                    StartMenuPanel2.Visible = True
                    StartMenuPanel2.BackColor = TaskbarPanel.BackColor
                    StartMenuControls.Panel1.Visible = True
                End If
            ElseIf Menu_ = "1" Then
                'UI.ErrorForm(True, "", False)
                Form30.Show()
                Form30.Panel4.Visible = True
            ElseIf Menu_ = "2" Then
                If StartMenuPanel2.Visible = True Then
                    StartMenuPanel2.Visible = False
                ElseIf StartMenuPanel2.Visible = False Then
                    StartMenuPanel.Visible = True
                    StartMenuPanel2.Visible = True
                    StartMenuPanel2.BackColor = TaskbarPanel.BackColor
                    StartMenuControls.Panel1.Visible = False
                End If
            ElseIf Menu_ = "3" Then
                Form30.Show()
                Form30.Panel4.Visible = False
            ElseIf Menu_ = "" Then
                Menu_ = "0"
                Button28_Click(Me, e)
            End If
        End If
        Panel2.Visible = False
        Panel4.Visible = False
    End Sub

    Private Sub Button30_Click(sender As Object, e As EventArgs) Handles Button30.Click
        UI.StartFileExplorer()
        Panel2.Visible = False
        Panel4.Visible = False
    End Sub

    Private Sub Button31_Click(sender As Object, e As EventArgs) Handles Button31.Click
        'Form44.Show()
        'Form44.Label1.Text = "Settings"
        'Form44.TextBox1.Text = "settings"
        'Form44.SEV()
        UI.Start_Form44("settings")
        Panel2.Visible = False
        Panel4.Visible = False
    End Sub

    Private Sub Button29_Click(sender As Object, e As EventArgs) Handles Button29.Click

        Try
            Internetplusplus.Show()
        Catch ex As Exception
            UI.ErrorForm(False, ex.Message, True)
        End Try
        Panel2.Visible = False
		Panel4.Visible = False
	End Sub

	Private Sub SWTaskToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SWTaskToolStripMenuItem.Click
		UI.StartSWTask()
	End Sub

	Private Sub Timer3_Tick(sender As Object, e As EventArgs) Handles Timer3.Tick
		TaskbarPanel.BackColor = Color.FromArgb(55, TaskbarColor)
        TopPanel.BackColor = Color.FromArgb(55, TaskbarColor)
        UI.TaskbarGUI.BackColor = Color.FromArgb(55, TaskbarColor)
        If StartMenuPanel.Dock = DockStyle.Right Then
            ReloadTaskbar()
        End If
        If opened = "2" Then
        Else
            opened = "2"
        End If
        If UI.opened = "0" Then

        End If
        Panel1.Visible = False
        StartMenu.Visible = False
        Panel2.BackColor = Color.FromArgb(55, TaskbarColor)
        Panel4.BackColor = Color.FromArgb(65, TaskbarColor)

        TaskbarContextMenu = TaskbarPanel.Location.X

        'LinkLabel1.LinkColor = LinkButtonColor
        'LinkLabel2.LinkColor = LinkButtonColor
        'LinkLabel3.LinkColor = LinkButtonColor
        'LinkLabel4.LinkColor = LinkButtonColor
        'LinkLabel5.LinkColor = LinkButtonColor
        'LinkLabel6.LinkColor = LinkButtonColor
        'LinkLabel7.LinkColor = LinkButtonColor
    End Sub

	Private Sub OpenCalc(sender As Object, e As EventArgs) Handles calc_app_Button.Click
		'calc.Show()
		calc_app_Button.Visible = False
	End Sub

    Private Sub OpenAppEditswfiles(sender As Object, e As EventArgs) Handles editsw_app_button.Click
        editsw.Show()
    End Sub

    '1234567890
    Public TaskbarContextMenu As Integer
    Public Sub TaskbarPanel_MouseDown(sender As Object, e As MouseEventArgs) Handles TaskbarPanel.MouseDown
        If My.Settings.Safemode = True Then
        Else
            If e.Button = MouseButtons.Right Then
                If TaskbarPanel.Dock = DockStyle.Top Then
                    Dim ss = Cursor.Position
                    ss.Offset(0, 0)
                    '0 = -174
                    Panel4.Visible = True
                    Panel4.Location = PointToScreen(ss)
                    Panel2.Visible = False
                    StartMenuPanel.Visible = False
                ElseIf TaskbarPanel.Dock = DockStyle.Bottom Then
                    Dim ss As Point = New Point(Cursor.Position.X, TaskbarPanel.Location.Y)
                    ss.Offset(0, -65)
                    '0 = -174
                    Panel4.Visible = True
                    Panel4.Location = PointToScreen(ss)
                    Panel2.Visible = False
                    StartMenuPanel.Visible = False
                End If
            Else
                Panel4.Visible = False
                Panel2.Visible = False
                StartMenuPanel.Visible = False
            End If
        End If


    End Sub

    Private Sub ContestMenuOpenToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ContestMenuOpenToolStripMenuItem.Click
        Dim f As New Form
        f.Show()
    End Sub

    Public Sub ReloadTaskbar()
        WindowState = FormWindowState.Normal
        'Location of Taskbar
        UI.Location_Taskbar()

        'Loads Saved Taskbar Color
        If My.Computer.FileSystem.FileExists(My.Application.Info.DirectoryPath & "\Settings\TaskbarColor.swfiles") Then
            UI.Colorloader()
        End If

        'Loads Taskbar
        TaskbarPanel.Visible = True
        Panel1.Visible = False

        'StartMenu
        '
        Me.StartMenu.Dock = DockStyle.None
        Me.StartMenu.Location = New System.Drawing.Point(97, 33)
        Me.StartMenu.Name = "StartMenu"
        Me.StartMenu.Size = New System.Drawing.Size(654, 557)
        Me.StartMenu.TabIndex = 2
        Me.StartMenu.Visible = False
        Me.Desktopwindow.Controls.Add(Me.StartMenu)

        'StartMenuPanel
        '
        Me.StartMenuPanel.Dock = DockStyle.None
        Me.StartMenuPanel.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom), System.Windows.Forms.AnchorStyles)
        Me.StartMenuPanel.BackColor = System.Drawing.Color.Transparent
        Me.StartMenuPanel.Controls.Add(Me.StartMenuPanel2)
        Me.StartMenuPanel.Controls.Remove(Me.StartMenu)
        Me.StartMenuPanel.Location = New System.Drawing.Point(404, 69)
        Me.StartMenuPanel.Name = "StartMenuPanel"
        Me.StartMenuPanel.Size = New System.Drawing.Size(590, 527)
        Me.StartMenuPanel.TabIndex = 1
        '
        'StartMenuPanel2
        '
        Me.StartMenuPanel2.BackColor = System.Drawing.SystemColors.Control
        Me.StartMenuPanel2.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.StartMenuPanel2.Location = New System.Drawing.Point(0, -6)
        Me.StartMenuPanel2.Name = "StartMenuPanel2"
        Me.StartMenuPanel2.Size = New System.Drawing.Size(590, 533)
        Me.StartMenuPanel2.TabIndex = 3
        Me.StartMenuPanel2.Visible = False

        'Starts Timer if Enabled = False
        If Timer3.Enabled = True Then
        Else
            Timer3.Start()
        End If

        'Loads TopPanel
        If My.Settings.TopbarLoad = True Then
            UI.TopPanelLoad(True)
        Else
            UI.TopPanelLoad(False)
        End If
        'Loads Start Menu
        If My.Settings.StartMenuLoad = True Then
            UI.StartmenuLoader(StartMenuControls, False)
        ElseIf My.Settings.StartMenuLoad = False Then
            Panel1.Show()
            'LoadOld()
        End If
        WindowState = FormWindowState.Maximized
    End Sub

    Private Sub LinkLabel6_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LinkLabel6.LinkClicked
        Form44.Show()
        Form44.TextBox1.Text = "settings/taskbar-settings"
        Form44.SEV()
    End Sub

	Private Sub LinkLabel7_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LinkLabel7.LinkClicked
		UI.StartSWTask()
	End Sub

	Private Sub ToolStripMenuItem6_Click(sender As Object, e As EventArgs) Handles ToolStripMenuItem6.Click

	End Sub

	Private Sub SWTaskToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles SWTaskToolStripMenuItem1.Click
        'swtask.Show()
        UI.StartRun()
        Panel2.Visible = False
	End Sub

	Private Sub SettingsToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SettingsToolStripMenuItem.Click
        Form44.Show()
        Form44.TextBox1.Text = "settings"
        Form44.SEV()
        Panel2.Visible = False
	End Sub

	Private Sub CMDToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CMDToolStripMenuItem.Click
        'Form17.Show()
        'Form17.CVW()
        UI.StartCMD("New")
        'cmdpad.Show()
        'cmdpad.Old_New_CMDTab = "O"
        'cmdpad.tools()
        Panel2.Visible = False
	End Sub

    Private Sub ToolStripMenuItem7_Click(sender As Object, e As EventArgs) Handles ToolStripMenuItem7.Click
        Form44.Show()
        Form44.TextBox1.Text = "settings/taskbar-settings"
        Form44.SEV()
        Panel2.Visible = False
        Panel4.Visible = False
    End Sub

    Private Sub ToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles ToolStripMenuItem1.Click
        'UI.StartSWTask()
        UI.StartRun()
        Panel2.Visible = False
        Panel4.Visible = False
    End Sub

    Private Sub Button32_Click(sender As Object, e As EventArgs) Handles Button32.Click
        A_Test_Thing.Show()
    End Sub

    Private Sub Button33_Click(sender As Object, e As EventArgs) Handles Button33.Click
        Form55.Show()
    End Sub

    Private Sub StartRunAProgramToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles StartRunAProgramToolStripMenuItem.Click
        AboutBox17.Show()
    End Sub

    Private Sub XcToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles XcToolStripMenuItem.Click
        'A_Test_Thing.Show()
    End Sub

    Public Sub TopPanel_MouseDown(sender As Object, e As MouseEventArgs) Handles TopPanel.MouseDown
        If TopPanel.Dock = DockStyle.Top Then
            If (e.Button = MouseButtons.Right) Then
                Panel2.Visible = True
                Panel2.Location = New Point(Cursor.Position.X, 48)
                StartMenuPanel.Visible = False
                Panel4.Visible = False
            End If
            If (e.Button = MouseButtons.Left) Then
                Panel2.Visible = False
                Panel2.Visible = False
                Panel4.Visible = False
                StartMenuPanel.Visible = False
            End If
        ElseIf TopPanel.Dock = DockStyle.Bottom Then
            MsgBox("Error Docking System failed to config this", MsgBoxStyle.Exclamation)
        End If


    End Sub

    Private Sub OpenCloseStartmenuToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles OpenCloseStartmenuToolStripMenuItem.Click
        If Menu_ = "0" Then
            If StartMenuPanel2.Visible = True Then
                StartMenuPanel2.Visible = False
            ElseIf StartMenuPanel2.Visible = False Then
                StartMenuPanel.Visible = True
                StartMenuPanel2.Visible = True
                StartMenuPanel2.BackColor = TaskbarPanel.BackColor
                StartMenuControls.Panel1.Visible = True
                UI.StartMenuGUI.Label1.Text = Username
            End If
        ElseIf Menu_ = "1" Then
            Form30.LoadUI("{B5A2FE71-4025-4025-9824-5D7D57803690}")
        ElseIf Menu_ = "2" Then
            If StartMenuPanel2.Visible = True Then
                StartMenuPanel2.Visible = False
            ElseIf StartMenuPanel2.Visible = False Then
                StartMenuPanel.Visible = True
                StartMenuPanel2.Visible = True
                StartMenuPanel2.BackColor = TaskbarPanel.BackColor
                StartMenuControls.Panel1.Visible = True
                UI.StartMenuGUI.Label1.Text = Username
            End If
            Menu_ = "0"
        ElseIf Menu_ = "3" Then
            Form30.LoadUI("{B5A2FE71-4025-4025-9824-5D7D57803690}")
            Menu_ = "1"
        End If
    End Sub
End Class