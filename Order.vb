Public Class Order
    Private OrderNum As String
    Private Quantity As Integer
    Private StoreID As String
    Private PayTerms As String
    Private TitleID As String
    Private OrderDate As Date
    Private adapter As BookCollectionDataSetTableAdapters.salesTableAdapter = New BookCollectionDataSetTableAdapters.salesTableAdapter

    Public Sub New(ByVal pQty As Integer, ByVal pStoreID As String, ByVal pPayTerms As String, ByVal ptitleId As String, ByVal pOrderDate As Date, ByVal pOrderNum As String)
        Quantity = pQty
        StoreID = pStoreID
        PayTerms = pPayTerms
        TitleID = ptitleId
        OrderDate = pOrderDate
        OrderNum = pOrderNum
    End Sub

    Public Sub insetOrder()
        Try
            adapter.Insert(StoreID, OrderNum, OrderDate, Quantity, PayTerms, TitleID)
        Catch ex As Exception
            MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub
End Class
