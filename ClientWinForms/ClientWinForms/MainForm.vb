Imports System.IO
Imports System.Net.Sockets
Imports System.Text
Imports System.Threading

Public Class MainForm
    Public ip As String
    Dim _client As TcpClient
    Dim login As String
    Public STR As StreamReader
    Public STW As StreamWriter
    Dim flag_act = True
    Dim port
    Dim teacherText
    Public Sub New()
        ' Этот вызов является обязательным для конструктора.
        InitializeComponent()
        port = 5432
        Timer1.Interval = 1000
    End Sub
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        'ip = Form1.TextBox1.ToString()
        If ip = "" Then
            MsgBox("Впишите ip-адрес сервера в формате xxx.xxx.xxx.xxx")
        End If
        Try
            'Dim ip As String = "127.0.0.1"
            _client = New TcpClient(ip, port)
            CheckForIllegalCrossThreadCalls = False
            Dim Stream As New Thread(AddressOf ReceiveMessages) With {
                .IsBackground = True,
                .Priority = ThreadPriority.Highest
            }
            Stream.Start()
            'Threading.ThreadPool.QueueUserWorkItem(AddressOf ReceiveMessages)
            'AcceptButton = Button2
            Button1.Enabled = False
            flag_act = True
            TextBox2.Enabled = False
            action()
            Timer1.Start()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub ReceiveMessages() 'state As Object)
        Dim text
        Try
            While True
                STR = New StreamReader(_client.GetStream())
                text = ""
                While STR.Peek() > -1
                    text = text + STR.ReadLine + vbCrLf
                End While

                If Strings.Left(text, 4) = "STOP" Then
                    RichTextBox1.Enabled = False
                    RichTextBox1.ReadOnly = True
                    Dim txt_old = RichTextBox1.Text
                    'Timer1.Stop()
                    flag_act = False
                    text = ""

                ElseIf text.Split("₽")(0) = "START" Then
                    RichTextBox1.Enabled = True
                    RichTextBox1.ReadOnly = False
                    RichTextBox1.Text = text.Split("₽")(1)
                    'Timer1.Start()
                    flag_act = True
                    text = ""
                ElseIf text.Split("₽")(0) = "START_2" Then

                    Dim texxt = text.Split("₽")(1)
                    Me.RichTextBox1.Invoke(New MethodInvoker(Function()
                                                                 teacherText = texxt
                                                                 teacherFormOpen(teacherText)
                                                             End Function))
                    text = ""
                Else
                    'richtextbox1.TextLength > 0 Then
                    RichTextBox1.Text = text
                End If
            End While
        Catch ex As Exception
            'MsgBox("Вышел")
        End Try
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs)
        Timer1.Start()
    End Sub

    Private Sub TextBox2_TextChanged(sender As Object, e As EventArgs) Handles TextBox2.TextChanged
        If TextBox2.Text <> "" Then Button1.Enabled = True
    End Sub

    Private Sub MainForm_close(sender As Object, e As EventArgs) Handles MyBase.Closing
        Try
            If Not (_client Is Nothing) Then
                _client.GetStream.Close()
                _client.Close()
            End If
        Catch ex As Exception
        End Try
    End Sub
    Public Sub Isconnect()
        If _client.Connected Then
            Button1.Enabled = False
        End If
        If Not _client.Connected Then
            Button1.Enabled = True
            Timer1.Stop()
            'MessageBox.Show("Обрыв")
        End If
    End Sub

    Private Sub MainForm_Load_1(sender As Object, e As EventArgs) Handles MyBase.Load
        ip = Form1.TextBox1.Text
    End Sub
    Public Sub action()
        login = TextBox2.Text
        Dim txt = login & "₽" & RichTextBox1.Text
        'MessageBox.Show(txt)
        Try
            STW = New StreamWriter(_client.GetStream())
            If flag_act = True Then
                STW.WriteLine(txt)
            End If

            STW.AutoFlush = True
            Dim f = 0
            'Timer1.Start()
            'Dim ns As NetworkStream = _client.GetStream()
            'ns.Write(Encoding.UTF8.GetBytes(txt), 0, txt.Length)
        Catch ex As Exception
            Timer1.Stop()
            MsgBox("Связь с сервером была потеряна")
        End Try
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        action()
        Isconnect()
    End Sub

    Private Sub richtextbox1_TextChanged(sender As Object, e As EventArgs) Handles RichTextBox1.TextChanged
        'RichTextBox1.SelectionStart = RichTextBox1.Text.Length
        'RichTextBox1.ScrollToCaret()
    End Sub

    Private Sub СохранитьВPyToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles СохранитьВPyToolStripMenuItem.Click
        Dim save As New SaveFileDialog
        save.Filter = "Файлы .py|*.py"
        If save.ShowDialog = DialogResult.Cancel Then Exit Sub ' Обезопасим себя от ошибки, если мы не нажали на ок, то диалог закроется.
        save.FileName = "file.py"
        Dim rec As New System.IO.StreamWriter(save.FileName) ' Реазилзует запись символов в файл
        rec.Write(RichTextBox1.Text) ' Записываем в файл текст
        rec.Close()
        MsgBox("Сохранился")
    End Sub

    Private Sub ЗапуститьВCmdToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ЗапуститьВCmdToolStripMenuItem.Click
        cmd()
    End Sub
    Private Sub cmd()
        Me.RichTextBox1.Invoke(New MethodInvoker(Function()
                                                     My.Computer.FileSystem.WriteAllText("file.py", RichTextBox1.Text & vbCrLf & "input('Нажмите Enter')", False)
                                                 End Function))
        'MessageBox.Show(CheckBox1.CheckState)
        If CheckBox1.CheckState = 0 Then
            Process.Start("cmd", "/k python file.py pause")
        ElseIf CheckBox1.CheckState = 1 Then

            Process.Start("cmd", "/c python file.py pause")
        End If
    End Sub

    Private Sub СерверToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles СерверToolStripMenuItem.Click
        Form1.ShowDialog()
    End Sub

    Private Sub ШрифтToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ШрифтToolStripMenuItem.Click
        'FontDialog1.ShowDialog()
        If FontDialog1.ShowDialog() = DialogResult.OK Then
            Me.RichTextBox1.Font = FontDialog1.Font
        End If

    End Sub

    Private Sub teacherFormOpen(text)
        formTeacher.Enabled = True
        formTeacher.Visible = True
        formTeacher.RichTextBox1.Text = text
    End Sub

    Private Sub СообщенияToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles СообщенияToolStripMenuItem.Click
        formTeacher.Visible = True
        formTeacher.RichTextBox1.Text = teacherText
    End Sub


    Private Sub Mainform_KeyUp(sender As Object, e As KeyEventArgs) Handles MyBase.KeyUp
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

    Private Sub ToolStripMenuItem2_Click(sender As Object, e As EventArgs) Handles ToolStripMenuItem2.Click
        EGE.Visible = True
    End Sub

    Private Sub ToolStripMenuItem3_Click(sender As Object, e As EventArgs) Handles ToolStripMenuItem3.Click
        Dim ffile = System.Text.Encoding.UTF8.GetString(My.Resources.file)

        EGE.RichTextBox1.Text = ffile
    End Sub

    Private Sub АктивироватьОкноToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles АктивироватьОкноToolStripMenuItem.Click
        RichTextBox1.Enabled = True
        RichTextBox1.ReadOnly = False
    End Sub
End Class
