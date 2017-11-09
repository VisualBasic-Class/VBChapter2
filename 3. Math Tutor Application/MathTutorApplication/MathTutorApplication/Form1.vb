Public Class formMathTutor

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles txtMathProblem.TextChanged

    End Sub

    Private Sub TextBox1_TextChanged_1(sender As Object, e As EventArgs) Handles txtAnswer2.TextChanged

    End Sub

    Private Sub txtAnswer_TextChanged(sender As Object, e As EventArgs) Handles txtAnswer.TextChanged

    End Sub

    Private Sub btnShowAnswer_Click(sender As Object, e As EventArgs) Handles btnShowAnswer.Click
        txtAnswer.Visible = False
        txtAnswer2.Visible = True

    End Sub

    Private Sub btnExitApp_Click(sender As Object, e As EventArgs) Handles btnExitApp.Click
        Me.Close()

    End Sub
End Class
