Public Class Form2
    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles TextBox1.TextChanged
        If TextBox1.Text = "" Then
            TextBox1.BackColor = Color.White
        Else
            If Not IsNumeric(TextBox1.Text) Then
                TextBox1.BackColor = Color.Yellow
            Else
                Dim num As Integer = TextBox1.Text
                Dim RealNum As Integer
                RealNum = num Mod 2
                If RealNum = 0 Then
                    TextBox1.BackColor = Color.Green
                Else
                    TextBox1.BackColor = Color.Blue
                End If
            End If
        End If

    End Sub
End Class