Imports System.Threading


Public Class Form1
    Dim old_enter_pos
    Dim count
    Private Sub Button1_Click() Handles Button1.Click
        For i = 0 To MainForm.flag_attent.GetUpperBound(0)
            MainForm.flag_attent(i) = 2
        Next
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.FormClosing
        Me.Visible = False
    End Sub

    Private Sub Form1_KeyUp(sender As Object, e As KeyEventArgs) Handles MyBase.KeyUp
        'MessageBox.Show(RichTextBox1.SelectionStart)
        'If e.KeyCode = Keys. Then
        'MessageBox.Show(Asc(":"))
        'Dim position = RichTextBox1.SelectionStart
        If Strings.Right(RichTextBox1.Text, 1) = ":" Then
            RichTextBox1.Text = RichTextBox1.Text + vbLf + vbTab
            RichTextBox1.SelectionStart = RichTextBox1.SelectionStart + RichTextBox1.TextLength
        ElseIf Strings.Right(RichTextBox1.Text, 1) = "&" Then
            'MessageBox.Show(lines(lines.GetUpperBound(0)))
            '(Asc(vbLf)) 10
        ElseIf Not (RichTextBox1.SelectionStart) = 0 Then
            If Asc(Strings.Right(RichTextBox1.Text, 1)) = 10 Then
                Try
                    'Dim enter_pos = RichTextBox1.SelectionStart
                    'old_enter_pos = enter_pos + 1
                    'Dim delta_enter_pos = enter_pos - old_enter_pos

                    Dim lines = RichTextBox1.Lines
                    Dim line_string = lines(lines.GetUpperBound(0) - 1)

                    For i = 0 To Len(line_string) - 1
                        'MessageBox.Show(Asc(line_string(i)))
                        If Asc(line_string(i)) = 9 Then
                            RichTextBox1.Text = RichTextBox1.Text + vbTab
                            RichTextBox1.SelectionStart = RichTextBox1.SelectionStart + RichTextBox1.TextLength
                        End If
                    Next
                Catch ex As Exception

                End Try

            End If
        End If

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dim Stream_cmd As New Thread(AddressOf cmd)
        Stream_cmd.IsBackground = False
        'Stream.Priority = ThreadPriority.Highest
        Stream_cmd.Start()
    End Sub
    Private Sub cmd()
        Me.RichTextBox1.Invoke(New MethodInvoker(Function()
                                                     My.Computer.FileSystem.WriteAllText("file.py", RichTextBox1.Text & vbCrLf & "input('Нажмите Enter')", False)
                                                 End Function))
        Dim startInfo As New ProcessStartInfo With {
    .FileName = Environment.GetEnvironmentVariable("ComSpec"),
    .Arguments = "/k python file.py pause",
    .CreateNoWindow = True}
        Process.Start(startInfo).WaitForExit()
    End Sub

    Private Sub RichTextBox1_KeyDown(sender As Object, e As KeyEventArgs) Handles RichTextBox1.KeyDown

        If e.Control Then
            If e.KeyCode = Keys.S Then

                Button1_Click()
            End If
        End If

    End Sub

    Private Sub Button1_MouseHover(sender As Object, e As EventArgs) Handles Button1.MouseHover
        ToolTip1.SetToolTip(Button1, "Ctrl+S")
    End Sub
End Class