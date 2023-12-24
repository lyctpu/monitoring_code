Imports System.CodeDom.Compiler
Imports System.IO
Imports System.Net
Imports System.Net.Sockets
Imports System.Threading

Public Class MainForm
    Dim _server As TcpListener
    Dim _listOfClients As New List(Of TcpClient)
    Dim ip As String
    Dim port As Integer
    Dim el(50) As RichTextBox
    Dim login(50) As String
    Dim lbl(50) As Label
    Dim el_temp(50)
    Dim lbl_temp(50)
    Dim login_temp(50)
    Dim listbox_temp(50)
    Dim flag_list_replace(50) As Boolean
    Public flag_attent(50) As Integer
    Const height = 200
    Public status = 0
    Public status2 = 0
    Dim i = 0
    Dim texts = ""
    Dim ii = 0
    Dim x = 40
    Dim y = 70
    Dim flag_TAB = 0

    Public Sub New()
        ' Этот вызов является обязательным для конструктора.
        InitializeComponent()
        Dim localIP As IPAddress() = Dns.GetHostAddresses(Dns.GetHostName)
        For Each address As IPAddress In localIP
            If address.AddressFamily = AddressFamily.InterNetwork Then
                Form3.TextBox1.Text = address.ToString()
            End If
        Next
        ip = Form3.TextBox1.Text
        port = Form3.TextBox2.Text
        For Each flag In flag_attent
            flag = 0
        Next
    End Sub
    Structure Coordinates
        Dim X As Integer
        Dim Y As Integer
    End Structure

    Function Set_xy(pos_i) As Coordinates
        Dim XY As New Coordinates
        Dim x_delta = 310
        Dim y_delta = 220
        If pos_i / 4 <= 1 Then
            XY.X = 40 + (pos_i - 1) * x_delta
            XY.Y = 70
        ElseIf pos_i / 4 <= 2 Then
            XY.X = 40 + (pos_i - 5) * x_delta
            XY.Y = 70 + y_delta
        ElseIf pos_i / 4 <= 3 Then
            XY.X = 40 + (pos_i - 9) * x_delta
            XY.Y = 70 + 2 * y_delta
        ElseIf pos_i / 4 <= 4 Then
            XY.X = 40 + (pos_i - 13) * x_delta
            XY.Y = 70 + 3 * y_delta
        End If
        Return XY
    End Function
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Try
            _server = New TcpListener(IPAddress.Any, Integer.Parse(port))
            _server.Start()
            Label1.Text = "Connected"
            Threading.ThreadPool.QueueUserWorkItem(AddressOf NewClient)
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Public Sub NewClient(state As Object)
        Dim client As TcpClient = _server.AcceptTcpClient()
        Dim STR As StreamReader
        Dim STW As StreamWriter
        Dim textt As String
        Dim txt As String
        Dim num = 0
        Dim pos_i
        Try
            _listOfClients.Add(client)
            'i += 1
            For c = 1 To 50
                If Not (el(c) Is Nothing) Then
                Else
                    pos_i = c
                    Exit For
                End If
            Next

            'pos_i = i
            Me.ListBox1.Invoke(New MethodInvoker(Function()

                                                     'MessageBox.Show("форма" & i)
                                                     el(pos_i) = New RichTextBox
                                                     Dim new_x = Set_xy(pos_i).X
                                                     Dim new_y = Set_xy(pos_i).Y
                                                     With el(pos_i)
                                                         .Location = New Point(new_x, new_y)
                                                         .Height = height
                                                         .Width = 300
                                                         .Multiline = True
                                                         .AcceptsTab = True
                                                         .Font = New System.Drawing.Font("Consolas", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
                                                         .ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.ForcedVertical
                                                         .Visible = True
                                                     End With
                                                     Me.Controls.Add(el(pos_i))
                                                     el_temp(pos_i) = el(pos_i)
                                                     AddHandler el(pos_i).DoubleClick, AddressOf el_click
                                                     AddHandler el(pos_i).MouseDown, AddressOf el_MouseDown
                                                     'Dim labels As New Label()
                                                     lbl(pos_i) = New Label
                                                     'MessageBox.Show("label" & i)
                                                     With lbl(pos_i)
                                                         .Location = New Point(new_x, new_y - 15)
                                                         .Text = login(pos_i) 'pos_i
                                                         .Name = $"lbl{pos_i}"
                                                         .AutoSize = True
                                                         .Visible = True
                                                     End With
                                                     Me.Controls.Add(lbl(pos_i))
                                                     lbl_temp(pos_i) = lbl(pos_i)
                                                     AddHandler lbl(pos_i).Click, AddressOf lbl_click
                                                     'MessageBox.Show(i)
                                                 End Function))
            'Threading.ThreadPool.QueueUserWorkItem(AddressOf NewClient)
            Dim Stream As New Thread(AddressOf NewClient) With {
                .IsBackground = True
            }
            'Stream.Priority = ThreadPriority.Highest
            Stream.Start()

            While True
                'If Not client.Connected Then
                '    MessageBox.Show("Отвал")
                '    Me.ListBox1.Invoke(New MethodInvoker(Function()
                '                                             el(pos_i).Visible = False
                '                                             lbl(pos_i).Visible = False
                '                                             TextBox1.Text += login(pos_i) & " отвалился" & vbCrLf
                '                                         End Function))
                '    el(pos_i) = Nothing
                '    lbl(pos_i) = Nothing

                'End If


                'Me.el(pos_i).Invoke(New MethodInvoker(Function()
                'el(pos_i).Text = el(pos_i).Text + (pos_i + 1).ToString
                'End Function))
                'Dim ns As NetworkStream = client.GetStream()
                'Dim toReceive(100000) As Byte
                'ns.Read(toReceive, 0, toReceive.Length)
                'Dim txt As String = Encoding.UTF8.GetString(toReceive)

                txt = ""
                If flag_attent(pos_i) = 0 Then
                    STR = New StreamReader(client.GetStream())
                    While STR.Peek() > -1
                        txt = txt + STR.ReadLine + vbCrLf
                    End While

                    If Not (txt.Split("₽")(0).ToString = "") Then
                        login(pos_i) = txt.Split("₽")(0).ToString
                        login_temp(pos_i) = login(pos_i)
                    End If

                    Dim st = 0
                    'MessageBox.Show(num)
                    Me.ListBox1.Invoke(New MethodInvoker(Function()
                                                             For ii = 0 To ListBox1.Items.Count - 1
                                                                 If Me.ListBox1.Items(ii).ToString = login(pos_i) Then
                                                                     st = 1
                                                                 End If
                                                             Next
                                                             If st = 0 Then
                                                                 Me.ListBox1.Items.Add(login(pos_i))
                                                                 listbox_temp(pos_i) = login(pos_i)
                                                             End If

                                                             Me.el(pos_i).Text = txt.Split("₽")(1)
                                                             Me.lbl(pos_i).Text = login(pos_i)

                                                         End Function))
                End If
                If flag_attent(pos_i) = 1 Then
                    textt = "STOP"
                    STW = New StreamWriter(client.GetStream())
                    STW.WriteLine(textt)
                    STW.AutoFlush = True
                    Me.ListBox1.Invoke(New MethodInvoker(Function()
                                                             Me.lbl(pos_i).BackColor = System.Drawing.Color.Red
                                                         End Function))
                    flag_attent(pos_i) = 3
                    textt = ""
                    'Me.lbl(pos_i).Invoke(New MethodInvoker(Function()
                    'MessageBox.Show($"Вы нажали на {clickedLabel.Name}")
                End If

                If flag_attent(pos_i) = 2 Then
                    'MessageBox.Show(flag_attent)
                    Me.ListBox1.Invoke(New MethodInvoker(Function()
                                                             If Form1.Visible Then
                                                                 textt = "START_2" & "₽" & Form1.RichTextBox1.Text
                                                             Else
                                                                 textt = "START" & "₽" & el(pos_i).Text
                                                             End If
                                                             Me.lbl(pos_i).BackColor = System.Drawing.SystemColors.Control
                                                         End Function))
                    STW = New StreamWriter(client.GetStream())
                    STW.WriteLine(textt)
                    STW.AutoFlush = True
                    flag_attent(pos_i) = 0
                    textt = ""
                    'Me.lbl(pos_i).Invoke(New MethodInvoker(Function()
                    'MessageBox.Show($"Вы нажали на {clickedLabel.Name}")
                End If
                'text = "STOP"
                'For Each c As TcpClient In _listOfClients

                'Dim nns As NetworkStream = c.GetStream()
                'STW = New StreamWriter(client.GetStream())
                'STW.WriteLine(text)

                'STW.AutoFlush = True
                'nns.Write(Encoding.UTF8.GetBytes(txt), 0, txt.Length)
                If flag_list_replace(pos_i) = True Then
                    Me.ListBox1.Invoke(New MethodInvoker(Function()
                                                             flag_list_replace(pos_i) = False
                                                             For inde = 1 To ListBox1.Items.Count
                                                                 If ListBox1.Items(inde) = login(pos_i) Then
                                                                     el(inde) = el_temp(pos_i)
                                                                     lbl(inde) = lbl_temp(pos_i)
                                                                     login(inde) = login_temp(pos_i)
                                                                     pos_i = inde
                                                                     el(pos_i).Location = New Point(Set_xy(pos_i).X, Set_xy(pos_i).Y)
                                                                     lbl(pos_i).Location = New Point(Set_xy(pos_i).X, Set_xy(pos_i).Y - 15)
                                                                     lbl(pos_i).Name = $"lbl{pos_i}"
                                                                 End If
                                                             Next
                                                         End Function))
                End If
            End While

        Catch ex As Exception
            If _listOfClients.Contains(client) Then
                _listOfClients.Remove(client)
                Me.ListBox1.Invoke(New MethodInvoker(Function()
                                                         el(pos_i).Visible = False
                                                         lbl(pos_i).Visible = False
                                                         TextBox1.Text += login_temp(pos_i) & " отвалился" & vbCrLf
                                                         For ii = 0 To ListBox1.Items.Count - 1
                                                             If Me.ListBox1.Items(ii).ToString = login(pos_i) Then
                                                                 ListBox1.Items.RemoveAt(ii)
                                                                 Exit For
                                                             End If
                                                         Next
                                                     End Function))

                el(pos_i) = Nothing
                lbl(pos_i) = Nothing
            End If
            login(pos_i) = Nothing
        End Try
    End Sub
    Private Sub el_MouseDown(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs)
        If e.Button = Windows.Forms.MouseButtons.Right Then
            Dim Stream_cmd As New Thread(AddressOf cmd) With {
                .IsBackground = False
            }
            Stream_cmd.Start(sender)
        End If
    End Sub
    Public Sub lbl_click(sender As Object, e As EventArgs)
        'MessageBox.Show(sender.name.Split("l")(2))
        Dim ind = Integer.Parse(sender.name.Split("l")(2)) '"lbl{pos_i}"
        If flag_attent(ind) = 0 Then
            flag_attent(ind) = 1
        End If

        If flag_attent(ind) = 3 Then
            flag_attent(ind) = 2
        End If
        'Dim clickedLabel = DirectCast(sender, Control)
        'MessageBox.Show($"Вы нажали на {clickedLabel.Name}")
        'Dim text = "STOP"
        'For Each c In _listOfClients
        'MessageBox.Show(c.ToString)
        'Next c
        'STW = New StreamWriter(client.GetStream())
        'STW.WriteLine(text)
    End Sub
    Private Sub НастройкиToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles НастройкиToolStripMenuItem.Click
        Form3.ShowDialog()
    End Sub



    Private Sub MainForm_Load_1(sender As Object, e As EventArgs) Handles MyBase.Load
        ListBox1.Items.Add("Начало")
    End Sub

    Public Sub el_click(sender As Object, e As EventArgs)
        'Dim clickedLabel = DirectCast(sender, Control)
        'sender.SelectionStart = sender.Text.Length
        'sender.ScrollToCaret()
        sender.AutoSize = False
        If sender.Height = 500 Then
            sender.Height = height
        Else
            sender.Height = 500
        End If
    End Sub

    Private Sub ListBox1_MouseDown(sender As Object, e As MouseEventArgs) Handles ListBox1.MouseDown
        If Me.GetItemIndex(e.Location) <> -1 Then
            Me.ListBox1.DoDragDrop(Me.ListBox1.Items, DragDropEffects.Move)
        End If
    End Sub
    Private Function GetItemIndex(ByVal location As Point) As Integer
        Dim itemindex As Integer = -1
        For index As Integer = 0 To Me.ListBox1.Items.Count - 1
            If Me.ListBox1.GetItemRectangle(index).Contains(location) Then
                itemindex = index
                Exit For
            End If
        Next
        Return itemindex
    End Function
    Private Sub ListBox1_DragEnter(sender As Object, e As DragEventArgs) Handles ListBox1.DragEnter
        Dim mouselocation As Point = Me.ListBox1.PointToClient(New Point(e.X, e.Y))
        If Me.GetItemIndex(mouselocation) = Me.ListBox1.SelectedIndex Then
            e.Effect = DragDropEffects.Move
        Else
            e.Effect = DragDropEffects.Move
        End If
    End Sub
    Private Sub ListBox1_DragDrop(sender As Object, e As DragEventArgs) Handles ListBox1.DragDrop
        Dim selectedindex As Integer = Me.ListBox1.SelectedIndex
        Dim dropindex As Integer = Me.GetItemIndex(Me.ListBox1.PointToClient(New Point(e.X, e.Y)))
        If dropindex > selectedindex Then
            dropindex -= 1
        End If

        Dim selecteditem As Object = Me.ListBox1.SelectedItem
        Me.ListBox1.Items.Remove(selecteditem)
        If dropindex = -1 Then
            Me.ListBox1.Items.Add(selecteditem)
        Else
            ListBox1.Items.Insert(dropindex, selecteditem)

        End If
        Me.ListBox1.SelectedItem = selecteditem
    End Sub
    Private Sub ДемонстрацияВсемToolStripMenuItem_Click(sender As Object, e As EventArgs)
        Form1.Visible = True
    End Sub

    Private Sub MainForm_KeyUp(sender As Object, e As KeyEventArgs) Handles MyBase.KeyUp

        If Strings.Right(sender.Text, 1) = ":" Then
            sender.Text = sender.Text + vbCrLf + vbTab
            flag_TAB += 1
            sender.SelectionStart = sender.SelectionStart + sender.TextLength
        End If
    End Sub

    Private Sub ЗапуститьToolStripMenuItem_Click(sender As Object, e As EventArgs)
        Dim Stream_cmd As New Thread(AddressOf cmd) With {
            .IsBackground = False
        }
        'Stream.Priority = ThreadPriority.Highest
        Stream_cmd.Start()
    End Sub

    Private Sub cmd(sender As Object)
        Me.Invoke(New MethodInvoker(Function()
                                        My.Computer.FileSystem.WriteAllText("file.py", sender.Text & vbCrLf & "input('Нажмите Enter')", False)
                                    End Function))

        If CheckBox1.CheckState = 0 Then
            Process.Start("cmd", "/k python file.py pause")
        ElseIf CheckBox1.CheckState = 1 Then
            Process.Start("cmd", "/c python file.py pause")
        End If
        'Dim startInfo As New ProcessStartInfo With {
        '.FileName = Environment.GetEnvironmentVariable("ComSpec"),
        '.Arguments = "/c python file.py",
        '.CreateNoWindow = False}
        'Process.Start(startInfo).WaitForExit()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        For ind = 1 To el.GetUpperBound(0)
            el_temp(ind) = el(ind)
            lbl_temp(ind) = lbl(ind)
            login_temp(ind) = login(ind)
        Next

        For ind = 1 To flag_list_replace.getupperbound(0)
            If el(ind) IsNot Nothing Then
                If listbox_temp(ind) <> ListBox1.Items(ind) Then
                    flag_list_replace(ind) = True
                End If
                listbox_temp(ind) = ListBox1.Items(ind)
            End If
        Next
    End Sub

    Private Sub СправкаToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles СправкаToolStripMenuItem.Click
        Form2.ShowDialog()
    End Sub

    Private Sub ЗапуститьToolStripMenuItem_Click_1(sender As Object, e As EventArgs)

    End Sub

    Private Sub СохранитьВPyToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles СохранитьВPyToolStripMenuItem.Click
        For ii = 1 To ListBox1.Items.Count - 1
            Me.Invoke(New MethodInvoker(Function()
                                            texts += "def f" & ii & "():" & vbCrLf & el(ii).Text & vbCrLf
                                        End Function))
        Next

        Me.Invoke(New MethodInvoker(Function()
                                        My.Computer.FileSystem.WriteAllText("class_listing_" & DateAndTime.DateString & ".py", texts, False)
                                    End Function))

    End Sub

    Private Sub СохранитьТекстToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles СохранитьТекстToolStripMenuItem.Click
        For ii = 1 To ListBox1.Items.Count - 1
            Me.Invoke(New MethodInvoker(Function()
                                            texts += "Ученик " & ii & ":" & vbCrLf & el(ii).Text & vbCrLf
                                        End Function))
        Next

        Me.Invoke(New MethodInvoker(Function()
                                        My.Computer.FileSystem.WriteAllText("class_text_" & DateAndTime.DateString & ".txt", texts, False)
                                    End Function))
    End Sub

    Private Sub СеансToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles СеансToolStripMenuItem.Click
        Form1.Visible = True
    End Sub
End Class