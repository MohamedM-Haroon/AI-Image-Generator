Imports System.ComponentModel
Imports System.Net
Imports System.Text
Public Class Form1
    'image aspect ratio
    Dim h As String = "512"
    Dim w As String = "512"
    'Image style
    Dim style As String
    'Style controller
    Dim HasStyle As Boolean = False

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Button1.Enabled = False
        BackgroundWorker1.RunWorkerAsync()
    End Sub



    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dim s As New SaveFileDialog
        s.Filter = "PNG|*.png"
        If s.ShowDialog = DialogResult.OK Then
            PictureBox1.Image.Save(s.FileName)
            MsgBox("Image saved successfuly")
        End If
    End Sub

    Private Sub BackgroundWorker1_DoWork(sender As Object, e As System.ComponentModel.DoWorkEventArgs) Handles BackgroundWorker1.DoWork
        'check if prompt textbox is empty
        If String.IsNullOrEmpty(PromptTextBox.Text) = False Then
            'create web client object
            Dim wc As New WebClient
            'add request headers
            Dim he As New WebHeaderCollection
            he.Add("User-Agent", "Mozilla/5.0 (Windows NT 10.0; Win64; x64; rv:109.0) Gecko/20100101 Firefox/117.0")
            he.Add("Content-Type", "application/json")
            wc.Headers = he
            Try
                Dim Apiresponse As String
                'Send the post request
                PictureBox1.Image = My.Resources.loading
                If HasStyle = True Then
                    Apiresponse = wc.UploadString("https://pixlr.com/api/openai/generate", "POST", "{""width"":" & w & ",""height"":" & h & ",""style"":""" & style & """,""amount"":1,""prompt"":[{""text"":""" & PromptTextBox.Text & """,""weight"":0.5},{""text"":""" & NegativePromptTextBox.Text & """,""weight"":-1}]}")
                Else
                    Apiresponse = wc.UploadString("https://pixlr.com/api/openai/generate", "POST", "{""width"":" & w & ",""height"":" & h & ",""amount"":1,""prompt"":[{""text"":""" & PromptTextBox.Text & """,""weight"":0.5},{""text"":""" & NegativePromptTextBox.Text & """,""weight"":-1}]}")
                End If

                Debug.Print(Apiresponse)
                'extracting Base64 from response
                Dim r As New RegularExpressions.Regex("(?<=base64\,)(.*?)(?=\"")")
                'convert base64 response to image and set the Picturebox image
                PictureBox1.Image = Base64ToImage(r.Match(Apiresponse).Value)

            Catch ex As Exception
                PictureBox1.Image = My.Resources.error_icon_4

                MsgBox(ex.Message)
            End Try

        Else
            MsgBox("please add prompt to generate the image you want.")
        End If

    End Sub

    Private Sub AspectRetioComboBox_SelectedIndexChanged(sender As Object, e As EventArgs) Handles AspectRetioComboBox.SelectedIndexChanged
        'manageing aspect ratio in http request


        If AspectRetioComboBox.SelectedIndex = 0 Then
            h = "512"
            w = "512"
        ElseIf AspectRetioComboBox.SelectedIndex = 1 Then
            h = "768"
            w = "512"
        Else
            h = "512"
            w = "768"
        End If
    End Sub

    Private Sub StyleComboBox_SelectedIndexChanged(sender As Object, e As EventArgs) Handles StyleComboBox.SelectedIndexChanged
        'Manageing Style in http request
        style = StyleComboBox.Text.ToLower.Replace(" ", "-")
        If StyleComboBox.SelectedIndex = 0 Or StyleComboBox.Text = "Style" Then
            HasStyle = False
        Else
            HasStyle = True
        End If
    End Sub

    Private Sub BackgroundWorker1_RunWorkerCompleted(sender As Object, e As RunWorkerCompletedEventArgs) Handles BackgroundWorker1.RunWorkerCompleted
        Button1.Enabled = True
        Button2.Enabled = True
    End Sub
End Class
