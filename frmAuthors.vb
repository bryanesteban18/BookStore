Public Class frmAuthors

    Private Sub AuthorsBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs) Handles AuthorsBindingNavigatorSaveItem.Click
        Me.Validate()
        Me.AuthorsBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.BookCollectionDataSet)

    End Sub

    Private Sub Authors_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'BookCollectionDataSet.authors' table. You can move, or remove it, as needed.
        Me.AuthorsTableAdapter.Fill(Me.BookCollectionDataSet.authors)

    End Sub

  
End Class