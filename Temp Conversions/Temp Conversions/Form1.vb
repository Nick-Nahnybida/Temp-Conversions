Public Class Form1

    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        ' Clear the fahrenheit temp fields.
        txt8AM.Clear()
        txt12PM.Clear()
        txt5PM.Clear()
        lbl8AM.Text = CStr("")
        lbl12PM.Text = CStr("")
        lbl5PM.Text = CStr("")
    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        ' Close the form.
        Me.Close()
    End Sub

    Private Sub btnConvert_Click(sender As Object, e As EventArgs) Handles btnConvert.Click
        Dim x8AM, x12PM, x5PM As Double

        x8AM = CDbl((txt8AM.Text) - 32) * 0.55555555555556
        ' Display the Result
        lbl8AM.Text = CDbl(x8AM)

        x12PM = CDbl((txt12PM.Text) - 32) * 0.55555555555556
        ' Display the Result
        lbl12PM.Text = CDbl(x12PM)

        x5PM = CDbl((txt5PM.Text) - 32) * 0.55555555555556
        ' Display the Result
        lbl5PM.Text = CDbl(x5PM)
    End Sub
End Class
