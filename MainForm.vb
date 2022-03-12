Public Class MainForm
    Private Sub MainForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LayoutControl1.BestFit()
        refresh()
    End Sub

    Private Sub SBExecute_Click(sender As Object, e As EventArgs)
    End Sub

    Private Sub refresh()
        TEBaseUrl.Text = ""
        TEPort.Text = ""
        SPNumOfHits.Value = 0
    End Sub
End Class
