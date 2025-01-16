Imports System.Runtime.InteropServices

Public Class About2
    Public opened As String = "0"
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Close()
    End Sub

    Private Sub About2_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' CVW start
        opened = "1"
        CVW()

        ' CVW topbar color
        If Form_1pad.TaskbarPanel.Visible = True Then
            Panel1.BackColor = Form_1pad.TaskbarColor
        Else

            If Form_1pad.Panel1.Visible = True Then
                Panel1.BackColor = Form_1pad.Panel1.BackColor
            Else
                CVW_res.Show()
                CVW_res.WindowState = FormWindowState.Minimized
                Button1.BackgroundImage = CVW_res.Close2.Image
                CVW_res.Close()
                Panel1.BackColor = Color.Silver
            End If
        End If
        If Panel1.BackColor = Color.Black Then
            Button1.BackgroundImage = My.Resources._2920659_White
        End If
        ' Set the title of the form.
        'Dim ApplicationTitle As String
        'If My.Application.Info.Title <> "" Then
        '   ApplicationTitle = My.Application.Info.Title
        'Else
        '   ApplicationTitle = System.IO.Path.GetFileNameWithoutExtension(My.Application.Info.AssemblyName)
        'End If
        'Me.Text = String.Format("About {0}", ApplicationTitle)
        ' Initialize all of the text displayed on the About Box.
        ' TODO: Customize the application's assembly information in the "Application" pane of the project 
        '    properties dialog (under the "Project" menu).
        If Form_1pad.About__ = "1" Then

			LabelProductName.Text = LabelProductName.Text
			LabelVersion.Text = LabelVersion.Text
		Else
            Me.LabelProductName.Text = "Product Name " + My.Application.Info.ProductName
            Me.LabelVersion.Text = "Version " & UI.ReleaseVersion
            'Me.LabelVersion.Text = String.Format("Version {0}", My.Application.Info.Version.ToString)
        End If

        Me.LabelCopyright.Text = My.Application.Info.Copyright
        Me.LabelCompanyName.Text = "Company Name " + My.Application.Info.CompanyName
        'Me.TextBoxDescription.Text = My.Application.Info.Description
        Icon = My.Resources.information_info_15651
    End Sub
    Public Sub CVW()
        Panel1.Visible = True
    End Sub
    <DllImport("user32.DLL", EntryPoint:="ReleaseCapture")>
    Private Shared Sub ReleaseCapture()
    End Sub
    <DllImport("user32.DLL", EntryPoint:="SendMessage")>
    Private Shared Sub SendMessage(ByVal hWnd As System.IntPtr, ByVal wMsg As Integer, ByVal wParam As Integer, ByVal lParam As Integer)
    End Sub

    Private Sub Panel1_MouseDown(sender As Object, e As MouseEventArgs) Handles Panel1.MouseDown
        ReleaseCapture()
        SendMessage(Me.Handle, &H112, &HF012, 0)
    End Sub

    Private Sub About2_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        opened = "0"
    End Sub
End Class