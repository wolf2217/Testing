Public Class Form1
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim lbl As New Label
        Dim tmr As New Timer
        lbl.Text = DateTime.Now.ToLongTimeString()

    End Sub
End Class
