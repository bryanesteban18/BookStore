Public Class frmPublishers

    Private Sub PublishersBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs) Handles PublishersBindingNavigatorSaveItem.Click
        Me.Validate()
        Me.PublishersBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.BookCollectionDataSet)

    End Sub

    Private Sub frmPublishers_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'BookCollectionDataSet.publishers' table. You can move, or remove it, as needed.
        Me.PublishersTableAdapter.Fill(Me.BookCollectionDataSet.publishers)

    End Sub
End Class