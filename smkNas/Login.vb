Public Class Login
    Public id As String
    Public pass As String
    Public role As Integer

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

    Private Sub Login_Load(sender As Object, e As EventArgs) Handles Me.Load
        txUsername.Clear()
        txPassword.Clear()
        txUsername.Select()
    End Sub

    Private Sub btnLogin_Click(sender As Object, e As EventArgs) Handles btnLogin.Click
        If txUsername.Text = "" Or txPassword.Text = "" Then
            lblWarn.Visible = True
        Else
            lblWarn.Visible = False
            If PesertaTableAdapter.login(txUsername.Text, txPassword.Text).Rows.Count = 0 Then
                If StaffTableAdapter.Login(txUsername.Text, txPassword.Text).Rows.Count = 0 Then
                    MsgBox("Login gagal!")
                Else
                    Dim dt As New smkNasDataSet.staffDataTable
                    dt = StaffTableAdapter.Login(txUsername.Text, txPassword.Text)
                    id = dt.Rows(0).Item(0)
                    pass = dt.Rows(0).Item("password")
                    role = dt.Rows(0).Item("role")
                    Me.Hide()
                    mainMenu.ShowDialog()
                    If mainMenu.logout = False Then
                        Me.Close()
                    Else
                        Login_Load(sender, e)
                    End If
                End If
            Else
                Dim dt As New smkNasDataSet.pesertaDataTable
                dt = PesertaTableAdapter.login(txUsername.Text, txPassword.Text)
                id = dt.Rows(0).Item(0)
                pass = dt.Rows(0).Item("password")
                role = 3
                Me.Hide()
                mainMenu.ShowDialog()
                If mainMenu.logout = False Then
                    Me.Close()
                Else
                    Login_Load(sender, e)
                End If
            End If
        End If
    End Sub

    Private Sub btnInfo_Click(sender As Object, e As EventArgs) Handles btnInfo.Click
        infoSekolah.ShowDialog()
        txUsername.Focus()
    End Sub

    Private Sub btnDaftar_Click(sender As Object, e As EventArgs) Handles btnDaftar.Click
        Me.Hide()
        formDaftar.ShowDialog()
    End Sub

    Private Sub txUsername_KeyDown(sender As Object, e As KeyEventArgs) Handles txUsername.KeyDown
        If e.KeyCode = Keys.Enter Then
            txPassword.Focus()
        End If
    End Sub

    Private Sub txPassword_KeyDown(sender As Object, e As KeyEventArgs) Handles txPassword.KeyDown
        If e.KeyCode = Keys.Enter Then
            btnLogin_Click(sender, e)
        End If
    End Sub

    Sub banInt(e As KeyPressEventArgs)
        If Asc(e.KeyChar) <> 8 Then
            If Asc(e.KeyChar) < 48 Or Asc(e.KeyChar) > 57 Then
                e.Handled = True
            End If
        End If
    End Sub

    Private Sub txUsername_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txUsername.KeyPress
        banInt(e)
    End Sub

End Class