Public Class Form1

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim intCount As Integer = 0

        Do
            ListBox1.Items.Add("Hello")
            intCount += 1
        Loop While intCount < 10
    End Sub
End Class
