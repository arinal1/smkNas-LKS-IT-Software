Imports System.ComponentModel

Public Class sidebarGuru
    Dim tombol As Button
    Sub closeForm(formParam As Form)
        mainMenu.PanelKonten.Controls.Remove(formParam)
        formParam.Close()
    End Sub

    Sub klikButton(nav As Button, formParam As Form)
        tombol.BackColor = Color.FromArgb(52, 73, 94)
        nav.BackColor = Color.FromArgb(46, 136, 197)
        tombol = nav
        formParam.TopLevel = False
        mainMenu.PanelKonten.Controls.Add(formParam)
        formParam.Show()
    End Sub

    Private Sub btnKoreksi_Click(sender As Object, e As EventArgs) Handles btnKoreksi.Click
        closeForm(formKoreksi)
        klikButton(btnKoreksi, formKoreksi)
    End Sub

    Private Sub btnHasil_Click(sender As Object, e As EventArgs) Handles btnHasil.Click
        closeForm(formUnduhSoal)
        klikButton(btnHasil, formUnduhSoal)
    End Sub

    Private Sub sidebarGuru_Load(sender As Object, e As EventArgs) Handles Me.Load
        tombol = btnKoreksi
        btnKoreksi_Click(sender, e)
    End Sub
End Class