Public Class formLatinTranslator

    Private Sub TextBox4_TextChanged(sender As Object, e As EventArgs) Handles txtDexter.TextChanged

    End Sub

    Private Sub txtMedium_TextChanged(sender As Object, e As EventArgs) Handles txtMedium.TextChanged

    End Sub

    Private Sub txtSinister_TextChanged(sender As Object, e As EventArgs) Handles txtSinister.TextChanged

    End Sub

    Private Sub TextBox3_TextChanged(sender As Object, e As EventArgs) Handles txtCenter.TextChanged

    End Sub

    Private Sub txtLatin_TextChanged(sender As Object, e As EventArgs) Handles txtLatin.TextChanged

    End Sub

    Private Sub btnShowEnglish_Click(sender As Object, e As EventArgs) Handles btnShowEnglish.Click
        txtLeft.Visible = True
        txtRight.Visible = True
        txtCenter.Visible = True

    End Sub

    Private Sub btnExitApp_Click(sender As Object, e As EventArgs) Handles btnExitApp.Click
        Me.Close()
    End Sub
End Class
