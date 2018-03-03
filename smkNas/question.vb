Public Class question
    Public answer As Boolean = False
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
        Login.Show()
    End Sub

    Private Sub btnYa_Click(sender As Object, e As EventArgs) Handles btnYa.Click
        answer = True
        Me.Close()
    End Sub

    Private Sub btnTidak_Click(sender As Object, e As EventArgs) Handles btnTidak.Click
        answer = False
        Me.Close()
    End Sub
End Class