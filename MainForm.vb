Public Class MainForm
    Private Sub refresh()
        TEBaseUrl.EditValue = ""
        TEPort.EditValue = ""
        TEUsername.EditValue = ""
        TEPassword.EditValue = ""
        TEDatabase.EditValue = ""
        TETimeout.EditValue = ""
        TESSL.EditValue = ""
        SPNumOfHits.EditValue = 0
        GridControl1.DataSource = Nothing
    End Sub

    Private Sub MainForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LayoutControl1.BestFit()
        refresh()
    End Sub

    Private Sub SBExecute_Click(sender As Object, e As EventArgs) Handles SBExecute.Click
        Dim tbl As New DataTable
        tbl.Columns.Add("NumOfHit1", GetType(Int32))
        tbl.Columns.Add("excTime1", GetType(String))
        tbl.Columns.Add("NumSuccess1", GetType(Int32))
        tbl.Columns.Add("NumFailed1", GetType(Int32))
        tbl.Columns("NumOfHit1").ReadOnly = False
        tbl.Columns("excTime1").ReadOnly = False
        tbl.Columns("NumSuccess1").ReadOnly = False
        tbl.Columns("NumFailed1").ReadOnly = False

        Dim row As DataRow

        Dim model As New MainModul

        If Not IsDBNull(SPNumOfHits.EditValue) Or CStr(SPNumOfHits.EditValue) <> "" Then
            For countTest As Integer = 0 To SPNumOfHits.EditValue - 1
                row = tbl.NewRow
                row("NumOfHit1") = countTest + 1
                row("excTime1") = Now
                If model.TestOpenConn(TEBaseUrl.EditValue,
                                      TEPort.EditValue,
                                   TEUsername.EditValue,
                                   TEPassword.EditValue,
                                   TEDatabase.EditValue,
                                   TESSL.EditValue,
                                   TETimeout.EditValue) Then
                    row("NumSuccess1") = 1
                    row("NumFailed1") = 0
                Else
                    row("NumSuccess1") = 0
                    row("NumFailed1") = 1
                End If
                tbl.Rows.Add(row)
                GridControl1.DataSource = tbl
                GridControl1.Refresh()
            Next
        Else
            GridControl1.DataSource = Nothing
        End If
        model = Nothing
        GridView1.BestFitColumns()
    End Sub

End Class
