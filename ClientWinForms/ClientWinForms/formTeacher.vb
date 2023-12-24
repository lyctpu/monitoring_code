Public Class formTeacher
    Private Sub formTeacher_FormClosing(sender As Object, e As EventArgs) Handles MyBase.FormClosing
        Me.Enabled = False


    End Sub

    Private Sub formTeacher_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.Enabled = True
        Me.Visible = True
    End Sub
End Class