Public Class frmTitles

    Private Sub TitlesBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs) Handles TitlesBindingNavigatorSaveItem.Click
        Try
            Me.Validate()
            Me.TitlesBindingSource.EndEdit()
            Me.TableAdapterManager.UpdateAll(Me.BookCollectionDataSet)
        Catch ex As Exception
            MessageBox.Show(ex.ToString())
        End Try
        

    End Sub

    Private Sub frmTitles_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'BookCollectionDataSet.titleauthor' table. You can move, or remove it, as needed.
        Me.TitleauthorTableAdapter.Fill(Me.BookCollectionDataSet.titleauthor)
        'TODO: This line of code loads data into the 'BookCollectionDataSet.sales' table. You can move, or remove it, as needed.
        Me.SalesTableAdapter.Fill(Me.BookCollectionDataSet.sales)
        'TODO: This line of code loads data into the 'BookCollectionDataSet.roysched' table. You can move, or remove it, as needed.
        Me.RoyschedTableAdapter.Fill(Me.BookCollectionDataSet.roysched)
        'TODO: This line of code loads data into the 'BookCollectionDataSet.titles' table. You can move, or remove it, as needed.
        Me.TitlesTableAdapter.Fill(Me.BookCollectionDataSet.titles)

    End Sub
End Class