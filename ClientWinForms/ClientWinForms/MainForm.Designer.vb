<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class MainForm
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
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
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.TextBox2 = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.ФайлToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.СохранитьВPyToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ЗапуститьВCmdToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.НастройкиToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.СерверToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ШрифтToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.АктивироватьОкноToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.СообщенияToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.СправочникToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripMenuItem2 = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripMenuItem3 = New System.Windows.Forms.ToolStripMenuItem()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.RichTextBox1 = New System.Windows.Forms.RichTextBox()
        Me.FontDialog1 = New System.Windows.Forms.FontDialog()
        Me.CheckBox1 = New System.Windows.Forms.CheckBox()
        Me.ОПрограммеToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Button1
        '
        Me.Button1.Enabled = False
        Me.Button1.Location = New System.Drawing.Point(235, 37)
        Me.Button1.Margin = New System.Windows.Forms.Padding(4)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(116, 28)
        Me.Button1.TabIndex = 0
        Me.Button1.Text = "Соединение"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'TextBox2
        '
        Me.TextBox2.Location = New System.Drawing.Point(91, 39)
        Me.TextBox2.Margin = New System.Windows.Forms.Padding(4)
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.Size = New System.Drawing.Size(132, 22)
        Me.TextBox2.TabIndex = 4
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(9, 43)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(66, 16)
        Me.Label1.TabIndex = 5
        Me.Label1.Text = "Фамилия"
        '
        'MenuStrip1
        '
        Me.MenuStrip1.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ФайлToolStripMenuItem, Me.НастройкиToolStripMenuItem, Me.СообщенияToolStripMenuItem, Me.СправочникToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Padding = New System.Windows.Forms.Padding(5, 2, 0, 2)
        Me.MenuStrip1.Size = New System.Drawing.Size(549, 28)
        Me.MenuStrip1.TabIndex = 7
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'ФайлToolStripMenuItem
        '
        Me.ФайлToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.СохранитьВPyToolStripMenuItem, Me.ЗапуститьВCmdToolStripMenuItem})
        Me.ФайлToolStripMenuItem.Name = "ФайлToolStripMenuItem"
        Me.ФайлToolStripMenuItem.Size = New System.Drawing.Size(59, 24)
        Me.ФайлToolStripMenuItem.Text = "Файл"
        '
        'СохранитьВPyToolStripMenuItem
        '
        Me.СохранитьВPyToolStripMenuItem.Name = "СохранитьВPyToolStripMenuItem"
        Me.СохранитьВPyToolStripMenuItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.S), System.Windows.Forms.Keys)
        Me.СохранитьВPyToolStripMenuItem.Size = New System.Drawing.Size(258, 26)
        Me.СохранитьВPyToolStripMenuItem.Text = "Сохранить в py"
        '
        'ЗапуститьВCmdToolStripMenuItem
        '
        Me.ЗапуститьВCmdToolStripMenuItem.Name = "ЗапуститьВCmdToolStripMenuItem"
        Me.ЗапуститьВCmdToolStripMenuItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.D), System.Windows.Forms.Keys)
        Me.ЗапуститьВCmdToolStripMenuItem.Size = New System.Drawing.Size(258, 26)
        Me.ЗапуститьВCmdToolStripMenuItem.Text = "Запустить в cmd"
        '
        'НастройкиToolStripMenuItem
        '
        Me.НастройкиToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.СерверToolStripMenuItem, Me.ШрифтToolStripMenuItem, Me.АктивироватьОкноToolStripMenuItem})
        Me.НастройкиToolStripMenuItem.Name = "НастройкиToolStripMenuItem"
        Me.НастройкиToolStripMenuItem.Size = New System.Drawing.Size(98, 24)
        Me.НастройкиToolStripMenuItem.Text = "Настройки"
        '
        'СерверToolStripMenuItem
        '
        Me.СерверToolStripMenuItem.Name = "СерверToolStripMenuItem"
        Me.СерверToolStripMenuItem.Size = New System.Drawing.Size(227, 26)
        Me.СерверToolStripMenuItem.Text = "Сервер"
        '
        'ШрифтToolStripMenuItem
        '
        Me.ШрифтToolStripMenuItem.Name = "ШрифтToolStripMenuItem"
        Me.ШрифтToolStripMenuItem.Size = New System.Drawing.Size(227, 26)
        Me.ШрифтToolStripMenuItem.Text = "Шрифт"
        '
        'АктивироватьОкноToolStripMenuItem
        '
        Me.АктивироватьОкноToolStripMenuItem.Name = "АктивироватьОкноToolStripMenuItem"
        Me.АктивироватьОкноToolStripMenuItem.Size = New System.Drawing.Size(227, 26)
        Me.АктивироватьОкноToolStripMenuItem.Text = "Активировать окно"
        '
        'СообщенияToolStripMenuItem
        '
        Me.СообщенияToolStripMenuItem.Name = "СообщенияToolStripMenuItem"
        Me.СообщенияToolStripMenuItem.Size = New System.Drawing.Size(105, 24)
        Me.СообщенияToolStripMenuItem.Text = "Сообщения"
        '
        'СправочникToolStripMenuItem
        '
        Me.СправочникToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripMenuItem1, Me.ToolStripMenuItem2, Me.ToolStripMenuItem3, Me.ОПрограммеToolStripMenuItem})
        Me.СправочникToolStripMenuItem.Name = "СправочникToolStripMenuItem"
        Me.СправочникToolStripMenuItem.Size = New System.Drawing.Size(108, 24)
        Me.СправочникToolStripMenuItem.Text = "Справочник"
        '
        'ToolStripMenuItem1
        '
        Me.ToolStripMenuItem1.Name = "ToolStripMenuItem1"
        Me.ToolStripMenuItem1.Size = New System.Drawing.Size(224, 26)
        Me.ToolStripMenuItem1.Text = "Python-code"
        '
        'ToolStripMenuItem2
        '
        Me.ToolStripMenuItem2.Name = "ToolStripMenuItem2"
        Me.ToolStripMenuItem2.Size = New System.Drawing.Size(224, 26)
        Me.ToolStripMenuItem2.Text = "Задачи ЕГЭ"
        '
        'ToolStripMenuItem3
        '
        Me.ToolStripMenuItem3.Name = "ToolStripMenuItem3"
        Me.ToolStripMenuItem3.Size = New System.Drawing.Size(224, 26)
        Me.ToolStripMenuItem3.Text = "Внешние ресурсы"
        '
        'Timer1
        '
        '
        'RichTextBox1
        '
        Me.RichTextBox1.AcceptsTab = True
        Me.RichTextBox1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.RichTextBox1.EnableAutoDragDrop = True
        Me.RichTextBox1.Font = New System.Drawing.Font("Consolas", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.RichTextBox1.Location = New System.Drawing.Point(0, 75)
        Me.RichTextBox1.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.RichTextBox1.Name = "RichTextBox1"
        Me.RichTextBox1.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.ForcedVertical
        Me.RichTextBox1.Size = New System.Drawing.Size(549, 587)
        Me.RichTextBox1.TabIndex = 9
        Me.RichTextBox1.Text = "a=0" & Global.Microsoft.VisualBasic.ChrW(10) & "print(a)"
        '
        'CheckBox1
        '
        Me.CheckBox1.AutoSize = True
        Me.CheckBox1.Location = New System.Drawing.Point(363, 42)
        Me.CheckBox1.Margin = New System.Windows.Forms.Padding(4)
        Me.CheckBox1.Name = "CheckBox1"
        Me.CheckBox1.Size = New System.Drawing.Size(163, 20)
        Me.CheckBox1.TabIndex = 11
        Me.CheckBox1.Text = "Закрывать окно cmd"
        Me.CheckBox1.UseVisualStyleBackColor = True
        '
        'ОПрограммеToolStripMenuItem
        '
        Me.ОПрограммеToolStripMenuItem.Name = "ОПрограммеToolStripMenuItem"
        Me.ОПрограммеToolStripMenuItem.Size = New System.Drawing.Size(224, 26)
        Me.ОПрограммеToolStripMenuItem.Text = "О программе"
        '
        'MainForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.Menu
        Me.ClientSize = New System.Drawing.Size(549, 662)
        Me.Controls.Add(Me.CheckBox1)
        Me.Controls.Add(Me.RichTextBox1)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.TextBox2)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.MenuStrip1)
        Me.IsMdiContainer = True
        Me.KeyPreview = True
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "MainForm"
        Me.Text = "Клиент мониторинга v.0.4"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Button1 As Button
    Friend WithEvents TextBox2 As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents НастройкиToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents Timer1 As Timer
    Friend WithEvents ФайлToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents СохранитьВPyToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ЗапуститьВCmdToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents RichTextBox1 As RichTextBox
    Friend WithEvents СправочникToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents FontDialog1 As FontDialog
    Friend WithEvents СерверToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ШрифтToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents СообщенияToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents CheckBox1 As CheckBox
    Friend WithEvents ToolStripMenuItem1 As ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem2 As ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem3 As ToolStripMenuItem
    Friend WithEvents АктивироватьОкноToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ОПрограммеToolStripMenuItem As ToolStripMenuItem
End Class
