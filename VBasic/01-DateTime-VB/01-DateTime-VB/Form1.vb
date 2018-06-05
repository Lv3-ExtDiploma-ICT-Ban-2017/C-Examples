Public Class Form1
    Private Sub btnStart_Click(sender As Object, e As EventArgs) Handles btnStart.Click
        Dim today As Date
        Dim todayTime As DateTime
        Dim time As TimeSpan
        today = DateAndTime.Now.Date
        todayTime = DateAndTime.Now.ToString("HH:mm:s")

        lblOutput.Text = "Today's date is: " + today
    End Sub
End Class
