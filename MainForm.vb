Imports System.ComponentModel

Public Class MainForm

    Private tbl As DataTable
    Private stopBtnHit As Boolean
    Private threadCtrl As System.Threading.ManualResetEvent

    Private Sub clearForm()
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
        tbl = New DataTable
        tbl.Columns.Add("NumOfHit1", GetType(Int32))
        tbl.Columns.Add("excTime1", GetType(String))
        tbl.Columns.Add("NumSuccess1", GetType(Int32))
        tbl.Columns.Add("NumFailed1", GetType(Int32))
        tbl.Columns("NumOfHit1").ReadOnly = False
        tbl.Columns("excTime1").ReadOnly = False
        tbl.Columns("NumSuccess1").ReadOnly = False
        tbl.Columns("NumFailed1").ReadOnly = False
        'stopBtnHit = False
        threadCtrl = New System.Threading.ManualResetEvent(False)
        LayoutControl1.BestFit()
        clearForm()
        DevExpress.Data.CurrencyDataController.DisableThreadingProblemsDetection = True
    End Sub

    Private Sub SBExecute_Click(sender As Object, e As EventArgs) Handles SBExecute.Click

        If BWPing.IsBusy Then
            DevExpress.XtraEditors.XtraMessageBox.Show("Masih ada proses yg berjalan...", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Exit Sub
        Else
            tbl.Clear()
            threadCtrl.Set()
            BWPing.RunWorkerAsync()
        End If
    End Sub

    Private Sub BWPing_DoWork(sender As Object, e As DoWorkEventArgs) Handles BWPing.DoWork
        Dim persen As Int32
        Dim row As DataRow
        Dim model As New MainModul
        For countTest As Integer = 0 To SPNumOfHits.EditValue - 1
            threadCtrl.WaitOne()

            If BWPing.CancellationPending Then
                Exit Sub
            End If

            row = tbl.NewRow
            row("NumOfHit1") = countTest + 1
            row("excTime1") = Now.ToString("yyyy-MM-dd HH:mm:ss.fff")
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
            persen = Math.Round(((countTest + 1) * 100) / 100, 0)

            BWPing.ReportProgress(persen)
        Next
    End Sub

    Private Sub BWPing_ProgressChanged(ByVal sender As Object, ByVal e As ProgressChangedEventArgs) Handles BWPing.ProgressChanged
        GridControl1.DataSource = tbl
        LayoutControl1.BestFit()
        GridControl1.Refresh()
    End Sub

    Private Sub SBStop_Click(sender As Object, e As EventArgs) Handles SBStop.Click
        If BWPing.IsBusy Then
            threadCtrl.Reset()
            If DevExpress.XtraEditors.XtraMessageBox.Show("Stop the test?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.Yes Then
                threadCtrl.Set()
                BWPing.CancelAsync()
            Else
                threadCtrl.Set()
            End If
        End If
    End Sub

    Private Sub SBReset_Click(sender As Object, e As EventArgs) Handles SBReset.Click
        clearForm()
        LayoutControl1.BestFit()
    End Sub
End Class
