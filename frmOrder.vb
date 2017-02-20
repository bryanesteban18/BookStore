Public Class frmOrder
    Private dblSubtotal As Double
    Private dblTax As Double
    Private dblTotal As Double
    Private Const dbl_TAXRATE As Double = 0.065
    Private strOldOrderNum As String
    Private strNewOrderNum As String

    Private Sub frmOrder_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            Dim strStores() As DataRow = taStores.GetData.Select()

            For Each store As DataRow In strStores
                cboStoreID.Items.Add(store.Item(0))
            Next

            reloadControls()
        Catch ex As Exception
            MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
        
    End Sub

    Private Sub btnSearch_Click(sender As Object, e As EventArgs) Handles btnSearch.Click
        Try
            lbSearch.Items.Clear()
            Dim drTitles() As DataRow = taTitles.GetData.Select

            For Each title As DataRow In drTitles
                If title.Item(1).ToString().ToUpper Like ("*" & txtTitleID.Text.Replace(" ", "*") & "*").ToUpper() Then
                    lbSearch.Items.Add(title.Item(1))
                End If
            Next
        Catch ex As Exception
            MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
       
    End Sub

    Private Sub btnAdd_Click(sender As Object, e As EventArgs) Handles btnAdd.Click
        If (lbSearch.SelectedIndex = -1) Then
            MessageBox.Show("Please select title to add", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        ElseIf (txtQty.Text = String.Empty) Then
            MessageBox.Show("Please enter quantity", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Else
            Try
                Dim strTitle As String
                Dim intQty As Integer = CInt(txtQty.Text)

                For Each title As DataRow In taTitles.GetData.Select
                    If title.Item(1).Equals(lbSearch.SelectedItem) Then
                        strTitle = title.Item(0)
                        CalculateTotals(title.Item(4), intQty)
                    End If
                Next

                lbItems.Items.Add(strTitle & "," & intQty.ToString)

                txtTitleID.Clear()
                lbSearch.Items.Clear()
                txtQty.Clear()
            Catch ex As Exception
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End Try
        End If
    End Sub

    Private Sub btnComplete_Click(sender As Object, e As EventArgs) Handles btnComplete.Click
        For Each item In lbItems.Items
            Try
                Dim mItem() As String = item.ToString.Split(",")
                Dim newOrder As Order = New Order(CInt(mItem(1)), cboStoreID.SelectedItem, txtPayTerms.Text, mItem(0), dtOrderDate.Value, txtOrderNum.Text)
                newOrder.insetOrder()
            Catch ex As Exception
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End Try
            
        Next
        Try
            taOrderNum.Update(strNewOrderNum, strOldOrderNum)
        Catch ex As Exception
            MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try

        MessageBox.Show("Your order has been entered.", "Book Store", MessageBoxButtons.OK, MessageBoxIcon.Information)

        reloadControls()
    End Sub

    Private Sub btnRemoveItem_Click(sender As Object, e As EventArgs) Handles btnRemoveItem.Click
        If (lbItems.SelectedIndex = -1) Then
            MessageBox.Show("Please select item to remove", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Else
            Try
                Dim item() As String = lbItems.SelectedItem.ToString.Split(",")

                For Each title As DataRow In taTitles.GetData.Select
                    If title.Item(0).Equals(item(0)) Then
                        CalculateTotals(title.Item(4) * -1, CInt(item(1)))
                    End If
                Next

                lbItems.Items.Remove(lbItems.SelectedItem)
            Catch ex As Exception
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End Try
        End If
    End Sub

    Private Sub reloadControls()
        cboStoreID.SelectedIndex = -1
        dtOrderDate.Value = Today
        txtPayTerms.Clear()
        lbItems.Items.Clear()
        dblSubtotal = 0.0
        dblTax = 0.0
        dblTotal = 0.0
        txtSubtotal.Text = dblSubtotal.ToString("c2")
        txtTax.Text = dblTax.ToString("c2")
        txtTotal.Text = dblTotal.ToString("c2")

        Dim strOrderNum() As DataRow = taOrderNum.GetData.Select()
        strOldOrderNum = strOrderNum(0).Item(0)
        strNewOrderNum = (CInt(strOldOrderNum) + 1).ToString()
        txtOrderNum.Text = strNewOrderNum
    End Sub

    Public Sub CalculateTotals(ByVal newItem As Double, ByVal Qty As Integer)
        dblSubtotal += (newItem * Qty)
        dblTax = dblSubtotal * dbl_TAXRATE
        dblTotal = dblSubtotal + dblTax

        txtSubtotal.Text = dblSubtotal.ToString("c2")
        txtTax.Text = dblTax.ToString("c2")
        txtTotal.Text = dblTotal.ToString("c2")
    End Sub

    Private Sub gbOrderInfo_Enter(sender As Object, e As EventArgs) Handles gbOrderInfo.Enter

    End Sub
End Class