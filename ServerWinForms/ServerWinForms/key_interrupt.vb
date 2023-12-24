Public Class key_interrupt
    Inherits RichTextBox
    Public Key_TP = 0
    ' Задаем количество пробелов, которое будет вставляться при нажатии кнопки Tab
    Public Property countSpaces As Integer = 1

    ' Virtual Keys
    Public Enum VK
        VK_TAB = &H9
        VK_TP = &H3A
        VK_Enter = &HA
        ' ...
    End Enum

    ' Windows Messages
    Public Enum WM
        WM_CHAR = &H102
        WM_KEYDOWN = &H100
    End Enum

    Protected Overrides Sub WndProc(ByRef m As Message)



        Select Case m.Msg
            ' Поскольку первым посылается сообщение WM_KEYDOWN, то и обработка нажатия происходит здесь.
            Case WM.WM_KEYDOWN
                ' Нажата клавиша
                Select Case m.WParam
                    Case VK.VK_TAB ' Если нажата клавиша Tab, то производим необходимые действия. 
                        Dim firstPart As String = Me.Text.Substring(0, Me.SelectionStart)
                        Dim secondPart As String = Me.Text.Substring(Me.SelectionStart + Me.SelectionLength)

                        Me.Text = firstPart + Space(countSpaces) + secondPart

                        Me.SelectionStart = firstPart.Length + countSpaces + "AAA" ' Возвращаем курсор на место

                    Case VK.VK_TP
                        Key_TP = 1
                        Dim firstPart As String = Me.Text.Substring(0, Me.SelectionStart)
                        Dim secondPart As String = Me.Text.Substring(Me.SelectionStart + Me.SelectionLength)

                        Me.Text = firstPart + Space(countSpaces) + secondPart

                        Me.SelectionStart = firstPart.Length + countSpaces + "BBB" ' Возвращаем курсор на место
                    Case Else : MyBase.WndProc(m)
                End Select

            Case WM.WM_CHAR
                MessageBox.Show(m.WParam)
                ' Нажата клавиша
                Select Case m.WParam
                    ' Если нажата клавиша Tab, то ничего не делаем, потому что все уже сделали при перехвате WM.WM_KEYDOWN.
                    ' Такой порядок необходим, потому что в противном случае данные о Selection обнуляются.
                    Case VK.VK_TAB : Return
                    Case VK.VK_TP : Return

                    Case Else : MyBase.WndProc(m)
                End Select
            Case Else : MyBase.WndProc(m)
        End Select



    End Sub



End Class
