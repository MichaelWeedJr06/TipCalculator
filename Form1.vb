Public Class Form1
    Private Sub btnCalculateTip_Click(sender As Object, e As EventArgs) Handles btnCalculateTip.Click
        Dim Bill, TipPercent, Tip, Total As Double
        If Not Double.TryParse(txtBill.Text, Bill) Then
            MessageBox.Show("Ivalid Bill Value")
            Return
        End If
        If Not Double.TryParse(txtPercentage.Text, TipPercent) Then
            MessageBox.Show("Ivalid Percentage Value")
            Return
        End If
        Tip = Bill * (TipPercent / 100)
        Total = Tip + Bill
        lblTipp.Text = Tip.ToString("C2")
        lblTotal.Text = Total.ToString("C2")
    End Sub

    Private Sub txtBill_TextChanged(sender As Object, e As EventArgs) Handles txtBill.TextChanged
        If IsNumeric(txtBill.Text) Then
            txtBill.BackColor = Color.White
        Else
            txtBill.BackColor = Color.Red
        End If
        lblTipp.Text = ""
        lblTotal.Text = ""
    End Sub

    Private Sub txtPercentage_TextChanged(sender As Object, e As EventArgs) Handles txtPercentage.TextChanged
        If IsNumeric(txtPercentage.Text) Then
            txtPercentage.BackColor = Color.White
        Else
            txtPercentage.BackColor = Color.Red
        End If
        lblTipp.Text = ""
        lblTotal.Text = ""
    End Sub
End Class
