Public Class formJokeTime

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles txtJokeTime.TextChanged

    End Sub

    Private Sub btnSure_Click(sender As Object, e As EventArgs) Handles btnSure.Click
        txtJokeTime.Visible = False

        txtJokePrompt.Visible = True

        btnSure.Visible = False

        btnShowPunchline.Visible = True
    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub btnShowPunchline_Click(sender As Object, e As EventArgs) Handles btnShowPunchline.Click
        txtPunchline.Visible = True

        btnShowPunchline.Visible = False

        btnExitApp.Visible = True
    End Sub

    Private Sub btnExitApp_Click(sender As Object, e As EventArgs) Handles btnExitApp.Click
        Me.Close()

    End Sub
End Class
