Public Class Search_App
    Public SearchMode As String = "Form"
    Public Sub Search_Any_Form(SearchText As String)
        If SearchMode = "Form" Then
            UI.Run(SearchText)
        ElseIf SearchMode = "Apps" Then
            If SearchText = "Quick Edit" Then
                UI.Run("{C8CAFE9B-DB4C-4BDB-BECF-7A6FF4378C21}")
            ElseIf SearchText = "quick Edit" Then
                UI.Run("{C8CAFE9B-DB4C-4BDB-BECF-7A6FF4378C21}")
            ElseIf SearchText = "Quick edit" Then
                UI.Run("{C8CAFE9B-DB4C-4BDB-BECF-7A6FF4378C21}")
            ElseIf SearchText = "quick edit" Then
                UI.Run("{C8CAFE9B-DB4C-4BDB-BECF-7A6FF4378C21}")
            End If
            If SearchText = "Image Viewer" Then
                UI.Run("{52EFE40B-2FBD-4EC4-8A90-D12ACA818FD8}")
            ElseIf SearchText = "image Viewer" Then
                UI.Run("{52EFE40B-2FBD-4EC4-8A90-D12ACA818FD8}")
            ElseIf SearchText = "Image viewer" Then
                UI.Run("{52EFE40B-2FBD-4EC4-8A90-D12ACA818FD8}")
            ElseIf SearchText = "image viewer" Then
                UI.Run("{52EFE40B-2FBD-4EC4-8A90-D12ACA818FD8}")
            End If
            If SearchText = "SWStore" Then
                UI.Run("{5D5279A7-C17F-40AF-BBC3-F497DFCCA269}")
            ElseIf SearchText = "sWStore" Then
                UI.Run("{5D5279A7-C17F-40AF-BBC3-F497DFCCA269}")
            ElseIf SearchText = "SwStore" Then
                UI.Run("{5D5279A7-C17F-40AF-BBC3-F497DFCCA269}")
            ElseIf SearchText = "SWstore" Then
                UI.Run("{5D5279A7-C17F-40AF-BBC3-F497DFCCA269}")
            ElseIf SearchText = "swStore" Then
                UI.Run("{5D5279A7-C17F-40AF-BBC3-F497DFCCA269}")
            ElseIf SearchText = "Swstore" Then
                UI.Run("{5D5279A7-C17F-40AF-BBC3-F497DFCCA269}")
            ElseIf SearchText = "swstore" Then
                UI.Run("{5D5279A7-C17F-40AF-BBC3-F497DFCCA269}")
            End If
            If SearchText = "File Explorer" Then
                UI.Run("{EB9B028F-EF0E-4ADB-9E3E-53B2132F501E}")
            ElseIf SearchText = "file Explorer" Then
                UI.Run("{EB9B028F-EF0E-4ADB-9E3E-53B2132F501E}")
            ElseIf SearchText = "File explorer" Then
                UI.Run("{EB9B028F-EF0E-4ADB-9E3E-53B2132F501E}")
            ElseIf SearchText = "file explorer" Then
                UI.Run("{EB9B028F-EF0E-4ADB-9E3E-53B2132F501E}")
            End If
            If SearchText = "Settings" Then
                UI.Run("{37B42C69-B540-4D71-A1C3-D6F3FB61FAD8}")
            ElseIf SearchText = "settings" Then
                UI.Run("{37B42C69-B540-4D71-A1C3-D6F3FB61FAD8}")
            End If
            If SearchText = "GCS" Then
                UI.Run("GCS")
            ElseIf SearchText = "gCS" Then
                UI.Run("GCS")
            ElseIf SearchText = "GcS" Then
                UI.Run("GCS")
            ElseIf SearchText = "GCs" Then
                UI.Run("GCS")
            ElseIf SearchText = "gcS" Then
                UI.Run("GCS")
            ElseIf SearchText = "Gcs" Then
                UI.Run("GCS")
            ElseIf SearchText = "gcs" Then
                UI.Run("GCS")
            End If
        ElseIf SearchMode = "Web" Then
                Try
                Internetplusplus.Show()
                Internetplusplus.WebView21.Source = New Uri("https://www.google.com/search?q=" & SearchText)
            Catch ex As Exception
                Form35.Show()
                Form35.WebBrowser1.Navigate("https://www.google.com/search?q=" & SearchText)
            End Try
        End If
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        SearchMode = "Form"
        Button2.Enabled = False
        Button3.Enabled = True
        Button4.Enabled = True
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        SearchMode = "Apps"
        Button2.Enabled = True
        Button3.Enabled = False
        Button4.Enabled = True
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        SearchMode = "Web"
        Button2.Enabled = True
        Button3.Enabled = True
        Button4.Enabled = False
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Search_Any_Form(TextBox1.Text)
    End Sub

    Private Sub TextBox1_KeyDown(sender As Object, e As KeyEventArgs) Handles TextBox1.KeyDown
        If e.KeyCode = Keys.Enter Then
            Search_Any_Form(TextBox1.Text)
        End If
    End Sub

    Private Sub TextBox1_TextChanged_Old(sender As Object, e As EventArgs)
        Dim Appsonlist As String = "GCS gcs Quick Edit quick edit SWTask swtask Picture Viewer picture viewer"

        If TextBox1.Text.Contains("a") = True Then
            Button5.Visible = False
            Button6.Visible = False
            Button7.Visible = False
            Button8.Visible = False
            Button9.Visible = False
            Button10.Visible = False
            Button11.Visible = False
            Button12.Visible = True
            Button13.Visible = False
        End If
        If TextBox1.Text.Contains("b") = True Then
            Button5.Visible = False
            Button6.Visible = False
            Button7.Visible = False
            Button8.Visible = False
            Button9.Visible = False
            Button10.Visible = False
            Button11.Visible = False
            Button12.Visible = False
            Button13.Visible = False
        End If
        If TextBox1.Text.Contains("c") = True Then
            Button5.Visible = False
            Button6.Visible = True
            Button7.Visible = True
            Button8.Visible = False
            Button9.Visible = False
            Button10.Visible = True
            Button11.Visible = False
            Button12.Visible = False
            Button13.Visible = True
        End If
        If TextBox1.Text.Contains("d") = True Then
            Button5.Visible = False
            Button6.Visible = False
            Button7.Visible = True
            Button8.Visible = False
            Button9.Visible = False
            Button10.Visible = False
            Button11.Visible = False
            Button12.Visible = False
            Button13.Visible = False
        End If
        If TextBox1.Text.Contains("e") = True Then
            Button5.Visible = True
            Button6.Visible = True
            Button7.Visible = False
            Button8.Visible = True
            Button9.Visible = True
            Button10.Visible = True
            Button11.Visible = True
            Button12.Visible = False
            Button13.Visible = False
        End If
        If TextBox1.Text.Contains("f") = True Then
            Button5.Visible = True
            Button6.Visible = False
            Button7.Visible = False
            Button8.Visible = False
            Button9.Visible = False
            Button10.Visible = False
            Button11.Visible = False
            Button12.Visible = False
            Button13.Visible = False
        End If
        If TextBox1.Text.Contains("g") = True Then
            Button5.Visible = False
            Button6.Visible = False
            Button7.Visible = False
            Button8.Visible = False
            Button9.Visible = False
            Button10.Visible = False
            Button11.Visible = False
            Button12.Visible = False
            Button13.Visible = True
        End If
        If TextBox1.Text.Contains("h") = True Then
            Button5.Visible = False
            Button6.Visible = False
            Button7.Visible = False
            Button8.Visible = False
            Button9.Visible = False
            Button10.Visible = False
            Button11.Visible = False
            Button12.Visible = False
            Button13.Visible = False
        End If
        If TextBox1.Text.Contains("i") = True Then
            Button5.Visible = True
            Button6.Visible = True
            Button7.Visible = False
            Button8.Visible = False
            Button9.Visible = True
            Button10.Visible = True
            Button11.Visible = True
            Button12.Visible = False
            Button13.Visible = False
        End If
        If TextBox1.Text.Contains("j") = True Then
            Button5.Visible = False
            Button6.Visible = False
            Button7.Visible = False
            Button8.Visible = False
            Button9.Visible = False
            Button10.Visible = False
            Button11.Visible = False
            Button12.Visible = False
            Button13.Visible = False
        End If
        If TextBox1.Text.Contains("k") = True Then
            Button5.Visible = False
            Button6.Visible = True
            Button7.Visible = False
            Button8.Visible = False
            Button9.Visible = False
            Button10.Visible = False
            Button11.Visible = False
            Button12.Visible = True
            Button13.Visible = False
        End If
        If TextBox1.Text.Contains("l") = True Then
            Button5.Visible = True
            Button6.Visible = False
            Button7.Visible = False
            Button8.Visible = False
            Button9.Visible = False
            Button10.Visible = False
            Button11.Visible = False
            Button12.Visible = False
            Button13.Visible = False
        End If
        If TextBox1.Text.Contains("m") = True Then
            Button5.Visible = False
            Button6.Visible = False
            Button7.Visible = True
            Button8.Visible = False
            Button9.Visible = False
            Button10.Visible = False
            Button11.Visible = False
            Button12.Visible = False
            Button13.Visible = False
        End If
        If TextBox1.Text.Contains("n") = True Then
            Button5.Visible = False
            Button6.Visible = False
            Button7.Visible = False
            Button8.Visible = False
            Button9.Visible = True
            Button10.Visible = False
            Button11.Visible = True
            Button12.Visible = False
            Button13.Visible = False
        End If
        If TextBox1.Text.Contains("o") = True Then
            Button5.Visible = True
            Button6.Visible = False
            Button7.Visible = False
            Button8.Visible = True
            Button9.Visible = False
            Button10.Visible = False
            Button11.Visible = False
            Button12.Visible = False
            Button13.Visible = False
        End If
        If TextBox1.Text.Contains("p") = True Then
            Button5.Visible = True
            Button6.Visible = False
            Button7.Visible = False
            Button8.Visible = False
            Button9.Visible = False
            Button10.Visible = True
            Button11.Visible = False
            Button12.Visible = False
            Button13.Visible = False
        End If
        If TextBox1.Text.Contains("q") = True Then
            Button5.Visible = False
            Button6.Visible = True
            Button7.Visible = False
            Button8.Visible = False
            Button9.Visible = False
            Button10.Visible = False
            Button11.Visible = False
            Button12.Visible = False
            Button13.Visible = False
        End If
        If TextBox1.Text.Contains("r") = True Then
            Button5.Visible = True
            Button6.Visible = False
            Button7.Visible = False
            Button8.Visible = True
            Button9.Visible = False
            Button10.Visible = True
            Button11.Visible = False
            Button12.Visible = False
            Button13.Visible = False
        End If
        If TextBox1.Text.Contains("s") = True Then
            Button5.Visible = False
            Button6.Visible = False
            Button7.Visible = False
            Button8.Visible = True
            Button9.Visible = False
            Button10.Visible = False
            Button11.Visible = True
            Button12.Visible = True
            Button13.Visible = True
        End If
        If TextBox1.Text.Contains("t") = True Then
            Button5.Visible = False
            Button6.Visible = True
            Button7.Visible = False
            Button8.Visible = True
            Button9.Visible = True
            Button10.Visible = True
            Button11.Visible = True
            Button12.Visible = True
            Button13.Visible = False
        End If
        If TextBox1.Text.Contains("u") = True Then
            Button5.Visible = False
            Button6.Visible = True
            Button7.Visible = False
            Button8.Visible = False
            Button9.Visible = False
            Button10.Visible = True
            Button11.Visible = False
            Button12.Visible = False
            Button13.Visible = False
        End If
        If TextBox1.Text.Contains("w") = True Then
            Button5.Visible = False
            Button6.Visible = False
            Button7.Visible = True
            Button8.Visible = True
            Button9.Visible = False
            Button10.Visible = True
            Button11.Visible = False
            Button12.Visible = True
            Button13.Visible = False
        End If
        If TextBox1.Text.Contains("v") = True Then
            Button5.Visible = False
            Button6.Visible = False
            Button7.Visible = False
            Button8.Visible = False
            Button9.Visible = False
            Button10.Visible = False
            Button11.Visible = False
            Button12.Visible = False
            Button13.Visible = False
        End If
        If TextBox1.Text.Contains("x") = True Then
            Button5.Visible = False
            Button6.Visible = False
            Button7.Visible = False
            Button8.Visible = False
            Button9.Visible = False
            Button10.Visible = False
            Button11.Visible = False
            Button12.Visible = False
            Button13.Visible = False
        End If
        If TextBox1.Text.Contains("y") = True Then
            Button5.Visible = False
            Button6.Visible = False
            Button7.Visible = False
            Button8.Visible = False
            Button9.Visible = False
            Button10.Visible = False
            Button11.Visible = False
            Button12.Visible = False
            Button13.Visible = False
        End If
        If TextBox1.Text.Contains("z") = True Then
            Button5.Visible = False
            Button6.Visible = False
            Button7.Visible = False
            Button8.Visible = False
            Button9.Visible = False
            Button10.Visible = False
            Button11.Visible = False
            Button12.Visible = False
            Button13.Visible = False
        End If
    End Sub

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles TextBox1.TextChanged

    End Sub

    Public Sub Search_Look()

    End Sub
End Class
