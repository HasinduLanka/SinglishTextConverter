Public Class FontCharsForm


    Private Sub LstFont_SelectedIndexChanged(sender As Object, e As EventArgs) Handles LstFont.SelectedIndexChanged
        Dim n = LstFont.SelectedIndex

        LstFont.SelectedIndex = n
        LstEn.SelectedIndex = n
    End Sub

    Private Sub LstEn_SelectedIndexChanged(sender As Object, e As EventArgs) Handles LstEn.SelectedIndexChanged
        Dim n = LstEn.SelectedIndex

        LstFont.SelectedIndex = n
        LstEn.SelectedIndex = n
    End Sub
End Class