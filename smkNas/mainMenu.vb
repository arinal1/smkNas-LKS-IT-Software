Public Class mainMenu
    Dim drag As Boolean = False
    Dim mouseX As Integer
    Dim mouseY As Integer
    Public logout As Boolean
    Dim sideBarForm As Form

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
        logout = False
        Me.Close()
    End Sub

    Private Sub btnMinimize_Click(sender As Object, e As EventArgs) Handles btnMinimize.Click
        Me.WindowState = FormWindowState.Minimized
    End Sub

    'logout
    Private Sub btnLogout_Click(sender As Object, e As EventArgs) Handles btnLogout.Click
        sideBarForm.Close()
        PanelNav.Controls.Clear()
        PanelKonten.Controls.Clear()
        logout = True
        Login.Show()
        Me.Close()
    End Sub

    'menu
    Private Sub mainMenu_Load(sender As Object, e As EventArgs) Handles Me.Load
        leveling()
    End Sub

    Sub leveling()
        If Login.role = 1 Then
            sideBarForm = sidebarGuru
        ElseIf Login.role = 2 Then
            sideBarForm = sidebarMurid
        Else
            sideBarForm = sidebarAdmin
        End If
        chooseSidebar()
    End Sub

    Sub chooseSidebar()
        sideBarForm.TopLevel = False
        PanelNav.Controls.Add(sideBarForm)
        sideBarForm.Show()
    End Sub
End Class