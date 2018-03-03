Public Class formKoreksi
    Dim kodeNilai As Integer
    Dim pg As Integer
    Dim essay As Integer
    Dim kasus As Integer
    Dim cariNo As Boolean

    Private Sub formKoreksi_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'SmkNasDataSet.soal' table. You can move, or remove it, as needed.
        Me.SoalTableAdapter.Fill(Me.SmkNasDataSet.soal)
        'TODO: This line of code loads data into the 'SmkNasDataSet.View_Koreksi' table. You can move, or remove it, as needed.
        Me.View_KoreksiTableAdapter.Fill(Me.SmkNasDataSet.View_Koreksi)
        kodeNilai = 0
        cariNo = False
    End Sub

    Private Sub btnNilai_Click(sender As Object, e As EventArgs) Handles btnNilai.Click
        If kodeNilai = 0 Then
            message.pesan.Text = "Mohon pilih data!"
            message.ShowDialog()
        Else
            subFormKoreksi.txPg.Text = pg
            subFormKoreksi.txEssay.Text = essay
            subFormKoreksi.txKasus.Text = kasus
            subFormKoreksi.id = kodeNilai
            subFormKoreksi.ShowDialog()
            formKoreksi_Load(sender, e)
        End If
    End Sub

    Private Sub tabelKoreksi_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles tabelKoreksi.CellClick
        If e.RowIndex >= 0 Then
            kodeNilai = tabelKoreksi.Rows(e.RowIndex).Cells(6).Value
            pg = tabelKoreksi.Rows(e.RowIndex).Cells(2).Value
            essay = tabelKoreksi.Rows(e.RowIndex).Cells(3).Value
            kasus = tabelKoreksi.Rows(e.RowIndex).Cells(4).Value
        End If
    End Sub

    Private Sub cbKode_SelectedValueChanged(sender As Object, e As EventArgs) Handles cbKode.SelectedValueChanged
        cari()
    End Sub

    Private Sub txCari_TextChanged(sender As Object, e As EventArgs) Handles txCari.TextChanged
        If txCari.Text = "" Then
            Me.View_KoreksiTableAdapter.Fill(Me.SmkNasDataSet.View_Koreksi)
        Else
            cari()
        End If
    End Sub

    Sub cari()
        Dim qry As String = "%" + txCari.Text + "%"
        View_KoreksiTableAdapter.Cari(SmkNasDataSet.View_Koreksi, cbKode.SelectedValue, qry)
    End Sub
End Class