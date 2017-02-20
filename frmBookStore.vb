Public Class frmBookStore

    Private Sub mnuTitles_Click(sender As Object, e As EventArgs) Handles mnuTitles.Click
        Dim frmTitles As New frmTitles
        frmTitles.ShowDialog()
    End Sub

    Private Sub OrderToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles OrderToolStripMenuItem.Click
        Dim frmOrder As New frmOrder
        frmOrder.ShowDialog()
    End Sub

    Private Sub AuthorsToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AuthorsToolStripMenuItem.Click
        Dim frmAuthors As New frmAuthors
        frmAuthors.ShowDialog()
    End Sub

    Private Sub PublishersToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles PublishersToolStripMenuItem.Click
        Dim frmPublishers As New frmPublishers
        frmPublishers.ShowDialog()
    End Sub

    Private Sub ReportToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ReportToolStripMenuItem.Click
        Dim frmResults As New frmResults
        frmResults.ShowDialog()
    End Sub
End Class
