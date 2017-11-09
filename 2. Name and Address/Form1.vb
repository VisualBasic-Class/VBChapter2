Public Class Form1

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles btnShowInfo.Click
        txtWolfe.Visible = True
        txtCityState.Visible = True
        txtStreetAddress.Visible = True

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Me.Close()
    End Sub

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles txtWolfe.TextChanged

    End Sub

    Private Sub TextBox2_TextChanged(sender As Object, e As EventArgs) Handles txtStreetAddress.TextChanged

    End Sub

    Private Sub TextBox3_TextChanged(sender As Object, e As EventArgs) Handles txtCityState.TextChanged

    End Sub
End Class
