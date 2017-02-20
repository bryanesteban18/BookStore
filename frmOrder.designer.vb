<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmOrder
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.lblStoreID = New System.Windows.Forms.Label()
        Me.cboStoreID = New System.Windows.Forms.ComboBox()
        Me.dtOrderDate = New System.Windows.Forms.DateTimePicker()
        Me.lblOrderDate = New System.Windows.Forms.Label()
        Me.lblQuantity = New System.Windows.Forms.Label()
        Me.txtQty = New System.Windows.Forms.TextBox()
        Me.lblPayTerms = New System.Windows.Forms.Label()
        Me.txtPayTerms = New System.Windows.Forms.TextBox()
        Me.lblTitleID = New System.Windows.Forms.Label()
        Me.txtTitleID = New System.Windows.Forms.TextBox()
        Me.lbItems = New System.Windows.Forms.ListBox()
        Me.btnAdd = New System.Windows.Forms.Button()
        Me.btnComplete = New System.Windows.Forms.Button()
        Me.lblSubtotal = New System.Windows.Forms.Label()
        Me.txtSubtotal = New System.Windows.Forms.TextBox()
        Me.txtTax = New System.Windows.Forms.TextBox()
        Me.lblTax = New System.Windows.Forms.Label()
        Me.txtTotal = New System.Windows.Forms.TextBox()
        Me.lblTotal = New System.Windows.Forms.Label()
        Me.btnSearch = New System.Windows.Forms.Button()
        Me.gbOrderInfo = New System.Windows.Forms.GroupBox()
        Me.lblOrderNum = New System.Windows.Forms.Label()
        Me.txtOrderNum = New System.Windows.Forms.TextBox()
        Me.gbItemInfo = New System.Windows.Forms.GroupBox()
        Me.btnRemoveItem = New System.Windows.Forms.Button()
        Me.lbSearch = New System.Windows.Forms.ListBox()
        Me.taStores = New TeamGFinalProject.BookCollectionDataSetTableAdapters.storesTableAdapter()
        Me.taTitles = New TeamGFinalProject.BookCollectionDataSetTableAdapters.titlesTableAdapter()
        Me.taSales = New TeamGFinalProject.BookCollectionDataSetTableAdapters.salesTableAdapter()
        Me.taOrderNum = New TeamGFinalProject.BookCollectionDataSetTableAdapters.OrderNumbersTableAdapter()
        Me.gbOrderInfo.SuspendLayout()
        Me.gbItemInfo.SuspendLayout()
        Me.SuspendLayout()
        '
        'lblStoreID
        '
        Me.lblStoreID.AutoSize = True
        Me.lblStoreID.Location = New System.Drawing.Point(58, 46)
        Me.lblStoreID.Name = "lblStoreID"
        Me.lblStoreID.Size = New System.Drawing.Size(49, 13)
        Me.lblStoreID.TabIndex = 2
        Me.lblStoreID.Text = "Store ID:"
        '
        'cboStoreID
        '
        Me.cboStoreID.FormattingEnabled = True
        Me.cboStoreID.Location = New System.Drawing.Point(113, 43)
        Me.cboStoreID.Name = "cboStoreID"
        Me.cboStoreID.Size = New System.Drawing.Size(121, 21)
        Me.cboStoreID.TabIndex = 3
        '
        'dtOrderDate
        '
        Me.dtOrderDate.Location = New System.Drawing.Point(113, 70)
        Me.dtOrderDate.Name = "dtOrderDate"
        Me.dtOrderDate.Size = New System.Drawing.Size(181, 20)
        Me.dtOrderDate.TabIndex = 4
        '
        'lblOrderDate
        '
        Me.lblOrderDate.AutoSize = True
        Me.lblOrderDate.Location = New System.Drawing.Point(45, 76)
        Me.lblOrderDate.Name = "lblOrderDate"
        Me.lblOrderDate.Size = New System.Drawing.Size(62, 13)
        Me.lblOrderDate.TabIndex = 5
        Me.lblOrderDate.Text = "Order Date:"
        '
        'lblQuantity
        '
        Me.lblQuantity.AutoSize = True
        Me.lblQuantity.Location = New System.Drawing.Point(30, 141)
        Me.lblQuantity.Name = "lblQuantity"
        Me.lblQuantity.Size = New System.Drawing.Size(49, 13)
        Me.lblQuantity.TabIndex = 6
        Me.lblQuantity.Text = "Quantity:"
        '
        'txtQty
        '
        Me.txtQty.Location = New System.Drawing.Point(85, 138)
        Me.txtQty.Name = "txtQty"
        Me.txtQty.Size = New System.Drawing.Size(57, 20)
        Me.txtQty.TabIndex = 7
        '
        'lblPayTerms
        '
        Me.lblPayTerms.AutoSize = True
        Me.lblPayTerms.Location = New System.Drawing.Point(47, 98)
        Me.lblPayTerms.Name = "lblPayTerms"
        Me.lblPayTerms.Size = New System.Drawing.Size(60, 13)
        Me.lblPayTerms.TabIndex = 8
        Me.lblPayTerms.Text = "Pay Terms:"
        '
        'txtPayTerms
        '
        Me.txtPayTerms.Location = New System.Drawing.Point(113, 98)
        Me.txtPayTerms.Name = "txtPayTerms"
        Me.txtPayTerms.Size = New System.Drawing.Size(57, 20)
        Me.txtPayTerms.TabIndex = 9
        '
        'lblTitleID
        '
        Me.lblTitleID.AutoSize = True
        Me.lblTitleID.Location = New System.Drawing.Point(41, 22)
        Me.lblTitleID.Name = "lblTitleID"
        Me.lblTitleID.Size = New System.Drawing.Size(44, 13)
        Me.lblTitleID.TabIndex = 10
        Me.lblTitleID.Text = "Title ID:"
        '
        'txtTitleID
        '
        Me.txtTitleID.Location = New System.Drawing.Point(91, 19)
        Me.txtTitleID.Name = "txtTitleID"
        Me.txtTitleID.Size = New System.Drawing.Size(100, 20)
        Me.txtTitleID.TabIndex = 11
        '
        'lbItems
        '
        Me.lbItems.FormattingEnabled = True
        Me.lbItems.Location = New System.Drawing.Point(13, 182)
        Me.lbItems.Name = "lbItems"
        Me.lbItems.Size = New System.Drawing.Size(132, 82)
        Me.lbItems.TabIndex = 12
        '
        'btnAdd
        '
        Me.btnAdd.Location = New System.Drawing.Point(148, 138)
        Me.btnAdd.Name = "btnAdd"
        Me.btnAdd.Size = New System.Drawing.Size(124, 20)
        Me.btnAdd.TabIndex = 13
        Me.btnAdd.Text = "Add Item to Order"
        Me.btnAdd.UseVisualStyleBackColor = True
        '
        'btnComplete
        '
        Me.btnComplete.Location = New System.Drawing.Point(183, 471)
        Me.btnComplete.Name = "btnComplete"
        Me.btnComplete.Size = New System.Drawing.Size(121, 32)
        Me.btnComplete.TabIndex = 14
        Me.btnComplete.Text = "Complete Order"
        Me.btnComplete.UseVisualStyleBackColor = True
        '
        'lblSubtotal
        '
        Me.lblSubtotal.AutoSize = True
        Me.lblSubtotal.Location = New System.Drawing.Point(32, 455)
        Me.lblSubtotal.Name = "lblSubtotal"
        Me.lblSubtotal.Size = New System.Drawing.Size(49, 13)
        Me.lblSubtotal.TabIndex = 15
        Me.lblSubtotal.Text = "Subtotal:"
        '
        'txtSubtotal
        '
        Me.txtSubtotal.Enabled = False
        Me.txtSubtotal.Location = New System.Drawing.Point(77, 452)
        Me.txtSubtotal.Name = "txtSubtotal"
        Me.txtSubtotal.Size = New System.Drawing.Size(100, 20)
        Me.txtSubtotal.TabIndex = 16
        '
        'txtTax
        '
        Me.txtTax.Enabled = False
        Me.txtTax.Location = New System.Drawing.Point(77, 478)
        Me.txtTax.Name = "txtTax"
        Me.txtTax.Size = New System.Drawing.Size(100, 20)
        Me.txtTax.TabIndex = 18
        '
        'lblTax
        '
        Me.lblTax.AutoSize = True
        Me.lblTax.Location = New System.Drawing.Point(47, 481)
        Me.lblTax.Name = "lblTax"
        Me.lblTax.Size = New System.Drawing.Size(28, 13)
        Me.lblTax.TabIndex = 17
        Me.lblTax.Text = "Tax:"
        '
        'txtTotal
        '
        Me.txtTotal.Enabled = False
        Me.txtTotal.Location = New System.Drawing.Point(77, 504)
        Me.txtTotal.Name = "txtTotal"
        Me.txtTotal.Size = New System.Drawing.Size(100, 20)
        Me.txtTotal.TabIndex = 20
        '
        'lblTotal
        '
        Me.lblTotal.AutoSize = True
        Me.lblTotal.Location = New System.Drawing.Point(43, 507)
        Me.lblTotal.Name = "lblTotal"
        Me.lblTotal.Size = New System.Drawing.Size(34, 13)
        Me.lblTotal.TabIndex = 19
        Me.lblTotal.Text = "Total:"
        '
        'btnSearch
        '
        Me.btnSearch.Location = New System.Drawing.Point(197, 19)
        Me.btnSearch.Name = "btnSearch"
        Me.btnSearch.Size = New System.Drawing.Size(64, 20)
        Me.btnSearch.TabIndex = 21
        Me.btnSearch.Text = "Search"
        Me.btnSearch.UseVisualStyleBackColor = True
        '
        'gbOrderInfo
        '
        Me.gbOrderInfo.Controls.Add(Me.lblOrderNum)
        Me.gbOrderInfo.Controls.Add(Me.txtOrderNum)
        Me.gbOrderInfo.Controls.Add(Me.lblStoreID)
        Me.gbOrderInfo.Controls.Add(Me.cboStoreID)
        Me.gbOrderInfo.Controls.Add(Me.dtOrderDate)
        Me.gbOrderInfo.Controls.Add(Me.lblOrderDate)
        Me.gbOrderInfo.Controls.Add(Me.lblPayTerms)
        Me.gbOrderInfo.Controls.Add(Me.txtPayTerms)
        Me.gbOrderInfo.Location = New System.Drawing.Point(17, 13)
        Me.gbOrderInfo.Name = "gbOrderInfo"
        Me.gbOrderInfo.Size = New System.Drawing.Size(303, 130)
        Me.gbOrderInfo.TabIndex = 22
        Me.gbOrderInfo.TabStop = False
        Me.gbOrderInfo.Text = "Order Info"
        '
        'lblOrderNum
        '
        Me.lblOrderNum.AutoSize = True
        Me.lblOrderNum.Location = New System.Drawing.Point(31, 20)
        Me.lblOrderNum.Name = "lblOrderNum"
        Me.lblOrderNum.Size = New System.Drawing.Size(76, 13)
        Me.lblOrderNum.TabIndex = 10
        Me.lblOrderNum.Text = "Order Number:"
        '
        'txtOrderNum
        '
        Me.txtOrderNum.Enabled = False
        Me.txtOrderNum.Location = New System.Drawing.Point(113, 17)
        Me.txtOrderNum.Name = "txtOrderNum"
        Me.txtOrderNum.Size = New System.Drawing.Size(121, 20)
        Me.txtOrderNum.TabIndex = 11
        '
        'gbItemInfo
        '
        Me.gbItemInfo.Controls.Add(Me.btnRemoveItem)
        Me.gbItemInfo.Controls.Add(Me.lbSearch)
        Me.gbItemInfo.Controls.Add(Me.lblQuantity)
        Me.gbItemInfo.Controls.Add(Me.txtQty)
        Me.gbItemInfo.Controls.Add(Me.btnSearch)
        Me.gbItemInfo.Controls.Add(Me.lbItems)
        Me.gbItemInfo.Controls.Add(Me.txtTitleID)
        Me.gbItemInfo.Controls.Add(Me.lblTitleID)
        Me.gbItemInfo.Controls.Add(Me.btnAdd)
        Me.gbItemInfo.Location = New System.Drawing.Point(17, 149)
        Me.gbItemInfo.Name = "gbItemInfo"
        Me.gbItemInfo.Size = New System.Drawing.Size(303, 290)
        Me.gbItemInfo.TabIndex = 23
        Me.gbItemInfo.TabStop = False
        Me.gbItemInfo.Text = "Item Info"
        '
        'btnRemoveItem
        '
        Me.btnRemoveItem.Location = New System.Drawing.Point(151, 209)
        Me.btnRemoveItem.Name = "btnRemoveItem"
        Me.btnRemoveItem.Size = New System.Drawing.Size(139, 20)
        Me.btnRemoveItem.TabIndex = 23
        Me.btnRemoveItem.Text = "Remove Item from Order"
        Me.btnRemoveItem.UseVisualStyleBackColor = True
        '
        'lbSearch
        '
        Me.lbSearch.FormattingEnabled = True
        Me.lbSearch.Location = New System.Drawing.Point(12, 49)
        Me.lbSearch.Name = "lbSearch"
        Me.lbSearch.Size = New System.Drawing.Size(282, 69)
        Me.lbSearch.TabIndex = 22
        '
        'taStores
        '
        Me.taStores.ClearBeforeFill = True
        '
        'taTitles
        '
        Me.taTitles.ClearBeforeFill = True
        '
        'taSales
        '
        Me.taSales.ClearBeforeFill = True
        '
        'taOrderNum
        '
        Me.taOrderNum.ClearBeforeFill = True
        '
        'frmOrder
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(336, 536)
        Me.Controls.Add(Me.gbItemInfo)
        Me.Controls.Add(Me.gbOrderInfo)
        Me.Controls.Add(Me.txtTotal)
        Me.Controls.Add(Me.lblTotal)
        Me.Controls.Add(Me.txtTax)
        Me.Controls.Add(Me.lblTax)
        Me.Controls.Add(Me.txtSubtotal)
        Me.Controls.Add(Me.lblSubtotal)
        Me.Controls.Add(Me.btnComplete)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.MaximizeBox = False
        Me.Name = "frmOrder"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "frmOrder"
        Me.gbOrderInfo.ResumeLayout(False)
        Me.gbOrderInfo.PerformLayout()
        Me.gbItemInfo.ResumeLayout(False)
        Me.gbItemInfo.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents taStores As TeamGFinalProject.BookCollectionDataSetTableAdapters.storesTableAdapter
    Friend WithEvents lblStoreID As System.Windows.Forms.Label
    Friend WithEvents cboStoreID As System.Windows.Forms.ComboBox
    Friend WithEvents dtOrderDate As System.Windows.Forms.DateTimePicker
    Friend WithEvents lblOrderDate As System.Windows.Forms.Label
    Friend WithEvents lblQuantity As System.Windows.Forms.Label
    Friend WithEvents txtQty As System.Windows.Forms.TextBox
    Friend WithEvents lblPayTerms As System.Windows.Forms.Label
    Friend WithEvents txtPayTerms As System.Windows.Forms.TextBox
    Friend WithEvents lblTitleID As System.Windows.Forms.Label
    Friend WithEvents txtTitleID As System.Windows.Forms.TextBox
    Friend WithEvents lbItems As System.Windows.Forms.ListBox
    Friend WithEvents btnAdd As System.Windows.Forms.Button
    Friend WithEvents btnComplete As System.Windows.Forms.Button
    Friend WithEvents lblSubtotal As System.Windows.Forms.Label
    Friend WithEvents txtSubtotal As System.Windows.Forms.TextBox
    Friend WithEvents txtTax As System.Windows.Forms.TextBox
    Friend WithEvents lblTax As System.Windows.Forms.Label
    Friend WithEvents txtTotal As System.Windows.Forms.TextBox
    Friend WithEvents lblTotal As System.Windows.Forms.Label
    Friend WithEvents btnSearch As System.Windows.Forms.Button
    Friend WithEvents gbOrderInfo As System.Windows.Forms.GroupBox
    Friend WithEvents gbItemInfo As System.Windows.Forms.GroupBox
    Friend WithEvents taTitles As TeamGFinalProject.BookCollectionDataSetTableAdapters.titlesTableAdapter
    Friend WithEvents lbSearch As System.Windows.Forms.ListBox
    Friend WithEvents taSales As TeamGFinalProject.BookCollectionDataSetTableAdapters.salesTableAdapter
    Friend WithEvents taOrderNum As TeamGFinalProject.BookCollectionDataSetTableAdapters.OrderNumbersTableAdapter
    Friend WithEvents lblOrderNum As System.Windows.Forms.Label
    Friend WithEvents txtOrderNum As System.Windows.Forms.TextBox
    Friend WithEvents btnRemoveItem As System.Windows.Forms.Button
End Class
