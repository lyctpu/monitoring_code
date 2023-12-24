<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class MainForm
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.ListBox1 = New System.Windows.Forms.ListBox()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.ФайлToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.СохранитьТекстToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.СохранитьВPyToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.СеансToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.НастройкиToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.СправочникToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.КонструкцииЯзыкаToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.АлгоритмыЕГЭToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.СправкаToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.CheckBox1 = New System.Windows.Forms.CheckBox()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(11, 34)
        Me.Button1.Margin = New System.Windows.Forms.Padding(4)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(100, 28)
        Me.Button1.TabIndex = 0
        Me.Button1.Text = "Старт"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'ListBox1
        '
        Me.ListBox1.AllowDrop = True
        Me.ListBox1.Dock = System.Windows.Forms.DockStyle.Right
        Me.ListBox1.FormattingEnabled = True
        Me.ListBox1.ItemHeight = 16
        Me.ListBox1.Location = New System.Drawing.Point(1027, 28)
        Me.ListBox1.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.ListBox1.Name = "ListBox1"
        Me.ListBox1.Size = New System.Drawing.Size(137, 534)
        Me.ListBox1.TabIndex = 2
        Me.ListBox1.UseWaitCursor = True
        '
        'MenuStrip1
        '
        Me.MenuStrip1.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ФайлToolStripMenuItem, Me.СеансToolStripMenuItem, Me.НастройкиToolStripMenuItem, Me.СправочникToolStripMenuItem, Me.СправкаToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Padding = New System.Windows.Forms.Padding(5, 2, 0, 2)
        Me.MenuStrip1.Size = New System.Drawing.Size(1164, 28)
        Me.MenuStrip1.TabIndex = 4
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'ФайлToolStripMenuItem
        '
        Me.ФайлToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.СохранитьТекстToolStripMenuItem, Me.СохранитьВPyToolStripMenuItem})
        Me.ФайлToolStripMenuItem.Name = "ФайлToolStripMenuItem"
        Me.ФайлToolStripMenuItem.Size = New System.Drawing.Size(59, 24)
        Me.ФайлToolStripMenuItem.Text = "Файл"
        '
        'СохранитьТекстToolStripMenuItem
        '
        Me.СохранитьТекстToolStripMenuItem.Name = "СохранитьТекстToolStripMenuItem"
        Me.СохранитьТекстToolStripMenuItem.Size = New System.Drawing.Size(243, 26)
        Me.СохранитьТекстToolStripMenuItem.Text = "Сохранить все в текст"
        '
        'СохранитьВPyToolStripMenuItem
        '
        Me.СохранитьВPyToolStripMenuItem.Name = "СохранитьВPyToolStripMenuItem"
        Me.СохранитьВPyToolStripMenuItem.Size = New System.Drawing.Size(243, 26)
        Me.СохранитьВPyToolStripMenuItem.Text = "Сохранить все в py"
        '
        'СеансToolStripMenuItem
        '
        Me.СеансToolStripMenuItem.Name = "СеансToolStripMenuItem"
        Me.СеансToolStripMenuItem.Size = New System.Drawing.Size(105, 24)
        Me.СеансToolStripMenuItem.Text = "Сообщение"
        '
        'НастройкиToolStripMenuItem
        '
        Me.НастройкиToolStripMenuItem.BackColor = System.Drawing.SystemColors.Control
        Me.НастройкиToolStripMenuItem.Name = "НастройкиToolStripMenuItem"
        Me.НастройкиToolStripMenuItem.Size = New System.Drawing.Size(98, 24)
        Me.НастройкиToolStripMenuItem.Text = "Настройки"
        '
        'СправочникToolStripMenuItem
        '
        Me.СправочникToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.КонструкцииЯзыкаToolStripMenuItem, Me.АлгоритмыЕГЭToolStripMenuItem})
        Me.СправочникToolStripMenuItem.Name = "СправочникToolStripMenuItem"
        Me.СправочникToolStripMenuItem.Size = New System.Drawing.Size(108, 24)
        Me.СправочникToolStripMenuItem.Text = "Справочник"
        '
        'КонструкцииЯзыкаToolStripMenuItem
        '
        Me.КонструкцииЯзыкаToolStripMenuItem.Name = "КонструкцииЯзыкаToolStripMenuItem"
        Me.КонструкцииЯзыкаToolStripMenuItem.Size = New System.Drawing.Size(227, 26)
        Me.КонструкцииЯзыкаToolStripMenuItem.Text = "Конструкции языка"
        '
        'АлгоритмыЕГЭToolStripMenuItem
        '
        Me.АлгоритмыЕГЭToolStripMenuItem.Name = "АлгоритмыЕГЭToolStripMenuItem"
        Me.АлгоритмыЕГЭToolStripMenuItem.Size = New System.Drawing.Size(227, 26)
        Me.АлгоритмыЕГЭToolStripMenuItem.Text = "Алгоритмы ЕГЭ"
        '
        'СправкаToolStripMenuItem
        '
        Me.СправкаToolStripMenuItem.Name = "СправкаToolStripMenuItem"
        Me.СправкаToolStripMenuItem.Size = New System.Drawing.Size(81, 24)
        Me.СправкаToolStripMenuItem.Text = "Справка"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(119, 47)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(0, 16)
        Me.Label1.TabIndex = 6
        '
        'Button2
        '
        Me.Button2.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Button2.Location = New System.Drawing.Point(1027, 0)
        Me.Button2.Margin = New System.Windows.Forms.Padding(4)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(137, 26)
        Me.Button2.TabIndex = 7
        Me.Button2.Text = "Выстроить окна"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'CheckBox1
        '
        Me.CheckBox1.AutoSize = True
        Me.CheckBox1.Location = New System.Drawing.Point(492, 4)
        Me.CheckBox1.Name = "CheckBox1"
        Me.CheckBox1.Size = New System.Drawing.Size(167, 20)
        Me.CheckBox1.TabIndex = 8
        Me.CheckBox1.Text = "Закрывать окно CMD"
        Me.CheckBox1.UseVisualStyleBackColor = True
        '
        'TextBox1
        '
        Me.TextBox1.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.TextBox1.Location = New System.Drawing.Point(0, 509)
        Me.TextBox1.Multiline = True
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.TextBox1.Size = New System.Drawing.Size(1027, 53)
        Me.TextBox1.TabIndex = 9
        '
        'MainForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoScroll = True
        Me.BackColor = System.Drawing.SystemColors.Control
        Me.ClientSize = New System.Drawing.Size(1164, 562)
        Me.Controls.Add(Me.TextBox1)
        Me.Controls.Add(Me.CheckBox1)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.ListBox1)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.MenuStrip1)
        Me.KeyPreview = True
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "MainForm"
        Me.Text = "Мониторинг активности v.0.4"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Button1 As Button
    Friend WithEvents ListBox1 As ListBox
    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents ФайлToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents СохранитьТекстToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents СохранитьВPyToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents СеансToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents НастройкиToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents Label1 As Label
    Friend WithEvents СправочникToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents КонструкцииЯзыкаToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents АлгоритмыЕГЭToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents Button2 As Button
    Friend WithEvents CheckBox1 As CheckBox
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents СправкаToolStripMenuItem As ToolStripMenuItem
End Class
