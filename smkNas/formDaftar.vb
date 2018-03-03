Public Class formDaftar
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

    Private Sub formDaftar_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'SmkNasDataSet.peserta' table. You can move, or remove it, as needed.
        Me.PesertaTableAdapter.Fill(Me.SmkNasDataSet.peserta)
        'TODO: This line of code loads data into the 'SmkNasDataSet.jurusan' table. You can move, or remove it, as needed.
        Me.JurusanTableAdapter.Fill(Me.SmkNasDataSet.jurusan)
        txNama.Clear()
        txAlamat.Clear()
        txEmail.Clear()
        cbKelamin.SelectedIndex = 0
        cbAgama.SelectedIndex = 0
        cbJurusan1.SelectedIndex = 0
        cbJurusan2.SelectedIndex = 1
        cbJurusan3.SelectedIndex = 2
        DatePicker.Value = Now()
    End Sub

    Private Sub btnUlang_Click(sender As Object, e As EventArgs) Handles btnUlang.Click
        formDaftar_Load(sender, e)
    End Sub

    Private Sub btnDaftar_Click(sender As Object, e As EventArgs) Handles btnDaftar.Click
        If txNama.Text = "" Or txAlamat.Text = "" Or txEmail.Text = "" Or cbKelamin.Text = "" Or cbAgama.Text = "" Or cbJurusan1.SelectedValue = "" Or cbJurusan2.SelectedValue = "" Or cbJurusan3.SelectedValue = "" Then
            message.pesan.Text = "Mohon data dilengkapi!!"
            message.ShowDialog()
        ElseIf cbJurusan1.SelectedIndex = cbJurusan2.SelectedIndex Or cbJurusan1.SelectedIndex = cbJurusan3.SelectedIndex Or cbJurusan2.SelectedIndex = cbJurusan3.SelectedIndex Then
            message.pesan.Text = "Mohon memilih jurusan yang berbeda!"
            message.ShowDialog()
        Else
            question.tanya.Text = "Apakah anda yakin data sudah benar?"
            question.ShowDialog()
            If question.answer Then
                Dim pass As String
                Dim s As String = "ABCDEFGHIJKLMNOPQRSTUVWXYZ0123456789"
                Dim r As New Random
                Dim sb As New System.Text.StringBuilder
                For i As Integer = 1 To 8
                    Dim idx As Integer = r.Next(0, 35)
                    sb.Append(s.Substring(idx, 1))
                Next
                pass = sb.ToString
                PesertaTableAdapter.Insert(txNama.Text, cbKelamin.Text, DatePicker.Value, txAlamat.Text, cbAgama.Text, txEmail.Text, cbJurusan1.SelectedValue.ToString, cbJurusan2.SelectedValue.ToString, cbJurusan3.SelectedValue.ToString, pass)
                infoDaftar.txNama.Text = txNama.Text
                infoDaftar.txNo.Text = PesertaTableAdapter.GetData().Rows(PesertaTableAdapter.GetData().Rows.Count - 1).Item(0).ToString
                infoDaftar.txJurusan1.Text = cbJurusan1.Text
                infoDaftar.txJurusan2.Text = cbJurusan2.Text
                infoDaftar.txJurusan3.Text = cbJurusan3.Text
                infoDaftar.txID.Text = infoDaftar.txNo.Text
                infoDaftar.txPass.Text = pass
                Me.Close()
                infoDaftar.ShowDialog()
            End If

        End If
    End Sub
End Class