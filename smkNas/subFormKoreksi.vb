Public Class subFormKoreksi
    Dim drag As Boolean = False
    Dim mouseX As Integer
    Dim mouseY As Integer
    Public id As Integer

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

    Private Sub btnReset_Click(sender As Object, e As EventArgs) Handles btnReset.Click
        txPg.Clear()
        txEssay.Clear()
        txKasus.Clear()
    End Sub
    Sub banInt(e As KeyPressEventArgs)
        If Asc(e.KeyChar) <> 8 Then
            If Asc(e.KeyChar) < 48 Or Asc(e.KeyChar) > 57 Then
                e.Handled = True
            End If
        End If
    End Sub

    Private Sub txPg_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txPg.KeyPress
        banInt(e)
    End Sub

    Private Sub txEssay_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txEssay.KeyPress
        banInt(e)
    End Sub

    Private Sub txKasus_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txKasus.KeyPress
        banInt(e)
    End Sub

    Private Sub btnSimpan_Click(sender As Object, e As EventArgs) Handles btnSimpan.Click
        If txPg.Text = "" Or txEssay.Text = "" Or txKasus.Text = "" Then
            message.pesan.Text = "Mohon data dilengkapi!"
            message.ShowDialog()
        Else
            NilaiTableAdapter.edit(txPg.Text, txEssay.Text, txKasus.Text, id)
            Me.Close()
        End If
    End Sub
End Class