Public Class infoJurusan
    Dim drag As Boolean = False
    Dim mouseX As Integer
    Dim mouseY As Integer

    'windowBar
    Private Sub windowBar_MouseDown(sender As Object, e As MouseEventArgs) Handles windowBar.MouseDown
        drag = True
        mouseX = Cursor.Position.X - Me.Left
        mouseY = Cursor.Position.Y - Me.Top
    End Sub

    Private Sub windowBar_MouseMove(sender As Object, e As MouseEventArgs) Handles windowBar.MouseMove
        If drag Then
            Me.Left = Cursor.Position.X - mouseX
            Me.Top = Cursor.Position.Y - mouseY
        End If
    End Sub

    Private Sub windowBar_MouseUp(sender As Object, e As MouseEventArgs) Handles windowBar.MouseUp
        drag = False
    End Sub

    Private Sub btnClose_Click(sender As Object, e As EventArgs) Handles btnClose.Click
        Me.Close()
    End Sub

    Private Sub infoJurusan_Load(sender As Object, e As EventArgs) Handles Me.Load
        Title.Text = infoSekolah.cbJurusan.Text
        info.Text = infoSekolah.cbJurusan.SelectedValue
    End Sub
End Class