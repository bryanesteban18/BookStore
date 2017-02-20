<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmTitles
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
        Me.components = New System.ComponentModel.Container()
        Dim Title_idLabel As System.Windows.Forms.Label
        Dim TitleLabel As System.Windows.Forms.Label
        Dim TypeLabel As System.Windows.Forms.Label
        Dim Pub_idLabel As System.Windows.Forms.Label
        Dim PriceLabel As System.Windows.Forms.Label
        Dim AdvanceLabel As System.Windows.Forms.Label
        Dim RoyaltyLabel As System.Windows.Forms.Label
        Dim Ytd_salesLabel As System.Windows.Forms.Label
        Dim NotesLabel As System.Windows.Forms.Label
        Dim PubdateLabel As System.Windows.Forms.Label
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmTitles))
        Me.BookCollectionDataSet = New TeamGFinalProject.BookCollectionDataSet()
        Me.TitlesBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.TitlesTableAdapter = New TeamGFinalProject.BookCollectionDataSetTableAdapters.titlesTableAdapter()
        Me.TableAdapterManager = New TeamGFinalProject.BookCollectionDataSetTableAdapters.TableAdapterManager()
        Me.RoyschedTableAdapter = New TeamGFinalProject.BookCollectionDataSetTableAdapters.royschedTableAdapter()
        Me.SalesTableAdapter = New TeamGFinalProject.BookCollectionDataSetTableAdapters.salesTableAdapter()
        Me.TitleauthorTableAdapter = New TeamGFinalProject.BookCollectionDataSetTableAdapters.titleauthorTableAdapter()
        Me.TitlesBindingNavigator = New System.Windows.Forms.BindingNavigator(Me.components)
        Me.BindingNavigatorAddNewItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorCountItem = New System.Windows.Forms.ToolStripLabel()
        Me.BindingNavigatorDeleteItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorMoveFirstItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorMovePreviousItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorSeparator = New System.Windows.Forms.ToolStripSeparator()
        Me.BindingNavigatorPositionItem = New System.Windows.Forms.ToolStripTextBox()
        Me.BindingNavigatorSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.BindingNavigatorMoveNextItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorMoveLastItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorSeparator2 = New System.Windows.Forms.ToolStripSeparator()
        Me.TitlesBindingNavigatorSaveItem = New System.Windows.Forms.ToolStripButton()
        Me.TitlesDataGridView = New System.Windows.Forms.DataGridView()
        Me.DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn5 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn6 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn7 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn8 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn9 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn10 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Title_idTextBox = New System.Windows.Forms.TextBox()
        Me.TitleTextBox = New System.Windows.Forms.TextBox()
        Me.TypeTextBox = New System.Windows.Forms.TextBox()
        Me.Pub_idTextBox = New System.Windows.Forms.TextBox()
        Me.PriceTextBox = New System.Windows.Forms.TextBox()
        Me.AdvanceTextBox = New System.Windows.Forms.TextBox()
        Me.RoyaltyTextBox = New System.Windows.Forms.TextBox()
        Me.Ytd_salesTextBox = New System.Windows.Forms.TextBox()
        Me.NotesTextBox = New System.Windows.Forms.TextBox()
        Me.PubdateDateTimePicker = New System.Windows.Forms.DateTimePicker()
        Me.RoyschedBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.SalesBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.TitleauthorBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Title_idLabel = New System.Windows.Forms.Label()
        TitleLabel = New System.Windows.Forms.Label()
        TypeLabel = New System.Windows.Forms.Label()
        Pub_idLabel = New System.Windows.Forms.Label()
        PriceLabel = New System.Windows.Forms.Label()
        AdvanceLabel = New System.Windows.Forms.Label()
        RoyaltyLabel = New System.Windows.Forms.Label()
        Ytd_salesLabel = New System.Windows.Forms.Label()
        NotesLabel = New System.Windows.Forms.Label()
        PubdateLabel = New System.Windows.Forms.Label()
        CType(Me.BookCollectionDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TitlesBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TitlesBindingNavigator, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TitlesBindingNavigator.SuspendLayout()
        CType(Me.TitlesDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RoyschedBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SalesBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TitleauthorBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Title_idLabel
        '
        Title_idLabel.AutoSize = True
        Title_idLabel.Location = New System.Drawing.Point(165, 49)
        Title_idLabel.Name = "Title_idLabel"
        Title_idLabel.Size = New System.Drawing.Size(37, 13)
        Title_idLabel.TabIndex = 2
        Title_idLabel.Text = "title id:"
        '
        'TitleLabel
        '
        TitleLabel.AutoSize = True
        TitleLabel.Location = New System.Drawing.Point(176, 75)
        TitleLabel.Name = "TitleLabel"
        TitleLabel.Size = New System.Drawing.Size(26, 13)
        TitleLabel.TabIndex = 4
        TitleLabel.Text = "title:"
        '
        'TypeLabel
        '
        TypeLabel.AutoSize = True
        TypeLabel.Location = New System.Drawing.Point(172, 101)
        TypeLabel.Name = "TypeLabel"
        TypeLabel.Size = New System.Drawing.Size(30, 13)
        TypeLabel.TabIndex = 6
        TypeLabel.Text = "type:"
        '
        'Pub_idLabel
        '
        Pub_idLabel.AutoSize = True
        Pub_idLabel.Location = New System.Drawing.Point(163, 127)
        Pub_idLabel.Name = "Pub_idLabel"
        Pub_idLabel.Size = New System.Drawing.Size(39, 13)
        Pub_idLabel.TabIndex = 8
        Pub_idLabel.Text = "pub id:"
        '
        'PriceLabel
        '
        PriceLabel.AutoSize = True
        PriceLabel.Location = New System.Drawing.Point(169, 153)
        PriceLabel.Name = "PriceLabel"
        PriceLabel.Size = New System.Drawing.Size(33, 13)
        PriceLabel.TabIndex = 10
        PriceLabel.Text = "price:"
        '
        'AdvanceLabel
        '
        AdvanceLabel.AutoSize = True
        AdvanceLabel.Location = New System.Drawing.Point(393, 49)
        AdvanceLabel.Name = "AdvanceLabel"
        AdvanceLabel.Size = New System.Drawing.Size(52, 13)
        AdvanceLabel.TabIndex = 12
        AdvanceLabel.Text = "advance:"
        '
        'RoyaltyLabel
        '
        RoyaltyLabel.AutoSize = True
        RoyaltyLabel.Location = New System.Drawing.Point(405, 78)
        RoyaltyLabel.Name = "RoyaltyLabel"
        RoyaltyLabel.Size = New System.Drawing.Size(40, 13)
        RoyaltyLabel.TabIndex = 14
        RoyaltyLabel.Text = "royalty:"
        '
        'Ytd_salesLabel
        '
        Ytd_salesLabel.AutoSize = True
        Ytd_salesLabel.Location = New System.Drawing.Point(394, 104)
        Ytd_salesLabel.Name = "Ytd_salesLabel"
        Ytd_salesLabel.Size = New System.Drawing.Size(51, 13)
        Ytd_salesLabel.TabIndex = 16
        Ytd_salesLabel.Text = "ytd sales:"
        '
        'NotesLabel
        '
        NotesLabel.AutoSize = True
        NotesLabel.Location = New System.Drawing.Point(409, 130)
        NotesLabel.Name = "NotesLabel"
        NotesLabel.Size = New System.Drawing.Size(36, 13)
        NotesLabel.TabIndex = 18
        NotesLabel.Text = "notes:"
        '
        'PubdateLabel
        '
        PubdateLabel.AutoSize = True
        PubdateLabel.Location = New System.Drawing.Point(658, 53)
        PubdateLabel.Name = "PubdateLabel"
        PubdateLabel.Size = New System.Drawing.Size(49, 13)
        PubdateLabel.TabIndex = 20
        PubdateLabel.Text = "pubdate:"
        '
        'BookCollectionDataSet
        '
        Me.BookCollectionDataSet.DataSetName = "BookCollectionDataSet"
        Me.BookCollectionDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'TitlesBindingSource
        '
        Me.TitlesBindingSource.DataMember = "titles"
        Me.TitlesBindingSource.DataSource = Me.BookCollectionDataSet
        '
        'TitlesTableAdapter
        '
        Me.TitlesTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.authorsTableAdapter = Nothing
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.discountsTableAdapter = Nothing
        Me.TableAdapterManager.employeeTableAdapter = Nothing
        Me.TableAdapterManager.jobsTableAdapter = Nothing
        Me.TableAdapterManager.OrderNumbersTableAdapter = Nothing
        Me.TableAdapterManager.pub_infoTableAdapter = Nothing
        Me.TableAdapterManager.publishersTableAdapter = Nothing
        Me.TableAdapterManager.royschedTableAdapter = Me.RoyschedTableAdapter
        Me.TableAdapterManager.salesTableAdapter = Me.SalesTableAdapter
        Me.TableAdapterManager.storesTableAdapter = Nothing
        Me.TableAdapterManager.titleauthorTableAdapter = Me.TitleauthorTableAdapter
        Me.TableAdapterManager.titlesTableAdapter = Me.TitlesTableAdapter
        Me.TableAdapterManager.UpdateOrder = TeamGFinalProject.BookCollectionDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'RoyschedTableAdapter
        '
        Me.RoyschedTableAdapter.ClearBeforeFill = True
        '
        'SalesTableAdapter
        '
        Me.SalesTableAdapter.ClearBeforeFill = True
        '
        'TitleauthorTableAdapter
        '
        Me.TitleauthorTableAdapter.ClearBeforeFill = True
        '
        'TitlesBindingNavigator
        '
        Me.TitlesBindingNavigator.AddNewItem = Me.BindingNavigatorAddNewItem
        Me.TitlesBindingNavigator.BindingSource = Me.TitlesBindingSource
        Me.TitlesBindingNavigator.CountItem = Me.BindingNavigatorCountItem
        Me.TitlesBindingNavigator.DeleteItem = Me.BindingNavigatorDeleteItem
        Me.TitlesBindingNavigator.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BindingNavigatorMoveFirstItem, Me.BindingNavigatorMovePreviousItem, Me.BindingNavigatorSeparator, Me.BindingNavigatorPositionItem, Me.BindingNavigatorCountItem, Me.BindingNavigatorSeparator1, Me.BindingNavigatorMoveNextItem, Me.BindingNavigatorMoveLastItem, Me.BindingNavigatorSeparator2, Me.BindingNavigatorAddNewItem, Me.BindingNavigatorDeleteItem, Me.TitlesBindingNavigatorSaveItem})
        Me.TitlesBindingNavigator.Location = New System.Drawing.Point(0, 0)
        Me.TitlesBindingNavigator.MoveFirstItem = Me.BindingNavigatorMoveFirstItem
        Me.TitlesBindingNavigator.MoveLastItem = Me.BindingNavigatorMoveLastItem
        Me.TitlesBindingNavigator.MoveNextItem = Me.BindingNavigatorMoveNextItem
        Me.TitlesBindingNavigator.MovePreviousItem = Me.BindingNavigatorMovePreviousItem
        Me.TitlesBindingNavigator.Name = "TitlesBindingNavigator"
        Me.TitlesBindingNavigator.PositionItem = Me.BindingNavigatorPositionItem
        Me.TitlesBindingNavigator.RenderMode = System.Windows.Forms.ToolStripRenderMode.System
        Me.TitlesBindingNavigator.Size = New System.Drawing.Size(1044, 25)
        Me.TitlesBindingNavigator.TabIndex = 0
        Me.TitlesBindingNavigator.Text = "BindingNavigator1"
        '
        'BindingNavigatorAddNewItem
        '
        Me.BindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorAddNewItem.Image = CType(resources.GetObject("BindingNavigatorAddNewItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorAddNewItem.Name = "BindingNavigatorAddNewItem"
        Me.BindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorAddNewItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorAddNewItem.Text = "Add new"
        '
        'BindingNavigatorCountItem
        '
        Me.BindingNavigatorCountItem.Name = "BindingNavigatorCountItem"
        Me.BindingNavigatorCountItem.Size = New System.Drawing.Size(35, 22)
        Me.BindingNavigatorCountItem.Text = "of {0}"
        Me.BindingNavigatorCountItem.ToolTipText = "Total number of items"
        '
        'BindingNavigatorDeleteItem
        '
        Me.BindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorDeleteItem.Image = CType(resources.GetObject("BindingNavigatorDeleteItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorDeleteItem.Name = "BindingNavigatorDeleteItem"
        Me.BindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorDeleteItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorDeleteItem.Text = "Delete"
        '
        'BindingNavigatorMoveFirstItem
        '
        Me.BindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMoveFirstItem.Image = CType(resources.GetObject("BindingNavigatorMoveFirstItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMoveFirstItem.Name = "BindingNavigatorMoveFirstItem"
        Me.BindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMoveFirstItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorMoveFirstItem.Text = "Move first"
        '
        'BindingNavigatorMovePreviousItem
        '
        Me.BindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMovePreviousItem.Image = CType(resources.GetObject("BindingNavigatorMovePreviousItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMovePreviousItem.Name = "BindingNavigatorMovePreviousItem"
        Me.BindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMovePreviousItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorMovePreviousItem.Text = "Move previous"
        '
        'BindingNavigatorSeparator
        '
        Me.BindingNavigatorSeparator.Name = "BindingNavigatorSeparator"
        Me.BindingNavigatorSeparator.Size = New System.Drawing.Size(6, 25)
        '
        'BindingNavigatorPositionItem
        '
        Me.BindingNavigatorPositionItem.AccessibleName = "Position"
        Me.BindingNavigatorPositionItem.AutoSize = False
        Me.BindingNavigatorPositionItem.Name = "BindingNavigatorPositionItem"
        Me.BindingNavigatorPositionItem.Size = New System.Drawing.Size(50, 23)
        Me.BindingNavigatorPositionItem.Text = "0"
        Me.BindingNavigatorPositionItem.ToolTipText = "Current position"
        '
        'BindingNavigatorSeparator1
        '
        Me.BindingNavigatorSeparator1.Name = "BindingNavigatorSeparator1"
        Me.BindingNavigatorSeparator1.Size = New System.Drawing.Size(6, 25)
        '
        'BindingNavigatorMoveNextItem
        '
        Me.BindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMoveNextItem.Image = CType(resources.GetObject("BindingNavigatorMoveNextItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMoveNextItem.Name = "BindingNavigatorMoveNextItem"
        Me.BindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMoveNextItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorMoveNextItem.Text = "Move next"
        '
        'BindingNavigatorMoveLastItem
        '
        Me.BindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMoveLastItem.Image = CType(resources.GetObject("BindingNavigatorMoveLastItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMoveLastItem.Name = "BindingNavigatorMoveLastItem"
        Me.BindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMoveLastItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorMoveLastItem.Text = "Move last"
        '
        'BindingNavigatorSeparator2
        '
        Me.BindingNavigatorSeparator2.Name = "BindingNavigatorSeparator2"
        Me.BindingNavigatorSeparator2.Size = New System.Drawing.Size(6, 25)
        '
        'TitlesBindingNavigatorSaveItem
        '
        Me.TitlesBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.TitlesBindingNavigatorSaveItem.Image = CType(resources.GetObject("TitlesBindingNavigatorSaveItem.Image"), System.Drawing.Image)
        Me.TitlesBindingNavigatorSaveItem.Name = "TitlesBindingNavigatorSaveItem"
        Me.TitlesBindingNavigatorSaveItem.Size = New System.Drawing.Size(23, 22)
        Me.TitlesBindingNavigatorSaveItem.Text = "Save Data"
        '
        'TitlesDataGridView
        '
        Me.TitlesDataGridView.AutoGenerateColumns = False
        Me.TitlesDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.TitlesDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn1, Me.DataGridViewTextBoxColumn2, Me.DataGridViewTextBoxColumn3, Me.DataGridViewTextBoxColumn4, Me.DataGridViewTextBoxColumn5, Me.DataGridViewTextBoxColumn6, Me.DataGridViewTextBoxColumn7, Me.DataGridViewTextBoxColumn8, Me.DataGridViewTextBoxColumn9, Me.DataGridViewTextBoxColumn10})
        Me.TitlesDataGridView.DataSource = Me.TitlesBindingSource
        Me.TitlesDataGridView.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.TitlesDataGridView.Location = New System.Drawing.Point(0, 198)
        Me.TitlesDataGridView.Name = "TitlesDataGridView"
        Me.TitlesDataGridView.Size = New System.Drawing.Size(1044, 238)
        Me.TitlesDataGridView.TabIndex = 1
        '
        'DataGridViewTextBoxColumn1
        '
        Me.DataGridViewTextBoxColumn1.DataPropertyName = "title_id"
        Me.DataGridViewTextBoxColumn1.HeaderText = "title_id"
        Me.DataGridViewTextBoxColumn1.Name = "DataGridViewTextBoxColumn1"
        '
        'DataGridViewTextBoxColumn2
        '
        Me.DataGridViewTextBoxColumn2.DataPropertyName = "title"
        Me.DataGridViewTextBoxColumn2.HeaderText = "title"
        Me.DataGridViewTextBoxColumn2.Name = "DataGridViewTextBoxColumn2"
        '
        'DataGridViewTextBoxColumn3
        '
        Me.DataGridViewTextBoxColumn3.DataPropertyName = "type"
        Me.DataGridViewTextBoxColumn3.HeaderText = "type"
        Me.DataGridViewTextBoxColumn3.Name = "DataGridViewTextBoxColumn3"
        '
        'DataGridViewTextBoxColumn4
        '
        Me.DataGridViewTextBoxColumn4.DataPropertyName = "pub_id"
        Me.DataGridViewTextBoxColumn4.HeaderText = "pub_id"
        Me.DataGridViewTextBoxColumn4.Name = "DataGridViewTextBoxColumn4"
        '
        'DataGridViewTextBoxColumn5
        '
        Me.DataGridViewTextBoxColumn5.DataPropertyName = "price"
        Me.DataGridViewTextBoxColumn5.HeaderText = "price"
        Me.DataGridViewTextBoxColumn5.Name = "DataGridViewTextBoxColumn5"
        '
        'DataGridViewTextBoxColumn6
        '
        Me.DataGridViewTextBoxColumn6.DataPropertyName = "advance"
        Me.DataGridViewTextBoxColumn6.HeaderText = "advance"
        Me.DataGridViewTextBoxColumn6.Name = "DataGridViewTextBoxColumn6"
        '
        'DataGridViewTextBoxColumn7
        '
        Me.DataGridViewTextBoxColumn7.DataPropertyName = "royalty"
        Me.DataGridViewTextBoxColumn7.HeaderText = "royalty"
        Me.DataGridViewTextBoxColumn7.Name = "DataGridViewTextBoxColumn7"
        '
        'DataGridViewTextBoxColumn8
        '
        Me.DataGridViewTextBoxColumn8.DataPropertyName = "ytd_sales"
        Me.DataGridViewTextBoxColumn8.HeaderText = "ytd_sales"
        Me.DataGridViewTextBoxColumn8.Name = "DataGridViewTextBoxColumn8"
        '
        'DataGridViewTextBoxColumn9
        '
        Me.DataGridViewTextBoxColumn9.DataPropertyName = "notes"
        Me.DataGridViewTextBoxColumn9.HeaderText = "notes"
        Me.DataGridViewTextBoxColumn9.Name = "DataGridViewTextBoxColumn9"
        '
        'DataGridViewTextBoxColumn10
        '
        Me.DataGridViewTextBoxColumn10.DataPropertyName = "pubdate"
        Me.DataGridViewTextBoxColumn10.HeaderText = "pubdate"
        Me.DataGridViewTextBoxColumn10.Name = "DataGridViewTextBoxColumn10"
        '
        'Title_idTextBox
        '
        Me.Title_idTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TitlesBindingSource, "title_id", True))
        Me.Title_idTextBox.Location = New System.Drawing.Point(208, 46)
        Me.Title_idTextBox.Name = "Title_idTextBox"
        Me.Title_idTextBox.Size = New System.Drawing.Size(100, 20)
        Me.Title_idTextBox.TabIndex = 3
        '
        'TitleTextBox
        '
        Me.TitleTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TitlesBindingSource, "title", True))
        Me.TitleTextBox.Location = New System.Drawing.Point(208, 72)
        Me.TitleTextBox.Name = "TitleTextBox"
        Me.TitleTextBox.Size = New System.Drawing.Size(100, 20)
        Me.TitleTextBox.TabIndex = 5
        '
        'TypeTextBox
        '
        Me.TypeTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TitlesBindingSource, "type", True))
        Me.TypeTextBox.Location = New System.Drawing.Point(208, 98)
        Me.TypeTextBox.Name = "TypeTextBox"
        Me.TypeTextBox.Size = New System.Drawing.Size(100, 20)
        Me.TypeTextBox.TabIndex = 7
        '
        'Pub_idTextBox
        '
        Me.Pub_idTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TitlesBindingSource, "pub_id", True))
        Me.Pub_idTextBox.Location = New System.Drawing.Point(208, 124)
        Me.Pub_idTextBox.Name = "Pub_idTextBox"
        Me.Pub_idTextBox.Size = New System.Drawing.Size(100, 20)
        Me.Pub_idTextBox.TabIndex = 9
        '
        'PriceTextBox
        '
        Me.PriceTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TitlesBindingSource, "price", True))
        Me.PriceTextBox.Location = New System.Drawing.Point(208, 150)
        Me.PriceTextBox.Name = "PriceTextBox"
        Me.PriceTextBox.Size = New System.Drawing.Size(100, 20)
        Me.PriceTextBox.TabIndex = 11
        '
        'AdvanceTextBox
        '
        Me.AdvanceTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TitlesBindingSource, "advance", True))
        Me.AdvanceTextBox.Location = New System.Drawing.Point(451, 46)
        Me.AdvanceTextBox.Name = "AdvanceTextBox"
        Me.AdvanceTextBox.Size = New System.Drawing.Size(100, 20)
        Me.AdvanceTextBox.TabIndex = 13
        '
        'RoyaltyTextBox
        '
        Me.RoyaltyTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TitlesBindingSource, "royalty", True))
        Me.RoyaltyTextBox.Location = New System.Drawing.Point(451, 75)
        Me.RoyaltyTextBox.Name = "RoyaltyTextBox"
        Me.RoyaltyTextBox.Size = New System.Drawing.Size(100, 20)
        Me.RoyaltyTextBox.TabIndex = 15
        '
        'Ytd_salesTextBox
        '
        Me.Ytd_salesTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TitlesBindingSource, "ytd_sales", True))
        Me.Ytd_salesTextBox.Location = New System.Drawing.Point(451, 101)
        Me.Ytd_salesTextBox.Name = "Ytd_salesTextBox"
        Me.Ytd_salesTextBox.Size = New System.Drawing.Size(100, 20)
        Me.Ytd_salesTextBox.TabIndex = 17
        '
        'NotesTextBox
        '
        Me.NotesTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TitlesBindingSource, "notes", True))
        Me.NotesTextBox.Location = New System.Drawing.Point(451, 127)
        Me.NotesTextBox.Multiline = True
        Me.NotesTextBox.Name = "NotesTextBox"
        Me.NotesTextBox.Size = New System.Drawing.Size(200, 43)
        Me.NotesTextBox.TabIndex = 19
        '
        'PubdateDateTimePicker
        '
        Me.PubdateDateTimePicker.DataBindings.Add(New System.Windows.Forms.Binding("Value", Me.TitlesBindingSource, "pubdate", True))
        Me.PubdateDateTimePicker.Location = New System.Drawing.Point(713, 49)
        Me.PubdateDateTimePicker.Name = "PubdateDateTimePicker"
        Me.PubdateDateTimePicker.Size = New System.Drawing.Size(200, 20)
        Me.PubdateDateTimePicker.TabIndex = 21
        '
        'RoyschedBindingSource
        '
        Me.RoyschedBindingSource.DataMember = "FK__roysched__title___267ABA7A"
        Me.RoyschedBindingSource.DataSource = Me.TitlesBindingSource
        '
        'SalesBindingSource
        '
        Me.SalesBindingSource.DataMember = "FK__sales__title_id__24927208"
        Me.SalesBindingSource.DataSource = Me.TitlesBindingSource
        '
        'TitleauthorBindingSource
        '
        Me.TitleauthorBindingSource.DataMember = "FK__titleauth__title__1ED998B2"
        Me.TitleauthorBindingSource.DataSource = Me.TitlesBindingSource
        '
        'frmTitles
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1044, 436)
        Me.Controls.Add(PubdateLabel)
        Me.Controls.Add(Me.PubdateDateTimePicker)
        Me.Controls.Add(NotesLabel)
        Me.Controls.Add(Me.NotesTextBox)
        Me.Controls.Add(Ytd_salesLabel)
        Me.Controls.Add(Me.Ytd_salesTextBox)
        Me.Controls.Add(RoyaltyLabel)
        Me.Controls.Add(Me.RoyaltyTextBox)
        Me.Controls.Add(AdvanceLabel)
        Me.Controls.Add(Me.AdvanceTextBox)
        Me.Controls.Add(PriceLabel)
        Me.Controls.Add(Me.PriceTextBox)
        Me.Controls.Add(Pub_idLabel)
        Me.Controls.Add(Me.Pub_idTextBox)
        Me.Controls.Add(TypeLabel)
        Me.Controls.Add(Me.TypeTextBox)
        Me.Controls.Add(TitleLabel)
        Me.Controls.Add(Me.TitleTextBox)
        Me.Controls.Add(Title_idLabel)
        Me.Controls.Add(Me.Title_idTextBox)
        Me.Controls.Add(Me.TitlesDataGridView)
        Me.Controls.Add(Me.TitlesBindingNavigator)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.MaximizeBox = False
        Me.Name = "frmTitles"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Titles"
        CType(Me.BookCollectionDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TitlesBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TitlesBindingNavigator, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TitlesBindingNavigator.ResumeLayout(False)
        Me.TitlesBindingNavigator.PerformLayout()
        CType(Me.TitlesDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RoyschedBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SalesBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TitleauthorBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents BookCollectionDataSet As TeamGFinalProject.BookCollectionDataSet
    Friend WithEvents TitlesBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents TitlesTableAdapter As TeamGFinalProject.BookCollectionDataSetTableAdapters.titlesTableAdapter
    Friend WithEvents TableAdapterManager As TeamGFinalProject.BookCollectionDataSetTableAdapters.TableAdapterManager
    Friend WithEvents TitlesBindingNavigator As System.Windows.Forms.BindingNavigator
    Friend WithEvents BindingNavigatorAddNewItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents BindingNavigatorCountItem As System.Windows.Forms.ToolStripLabel
    Friend WithEvents BindingNavigatorDeleteItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents BindingNavigatorMoveFirstItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents BindingNavigatorMovePreviousItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents BindingNavigatorSeparator As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents BindingNavigatorPositionItem As System.Windows.Forms.ToolStripTextBox
    Friend WithEvents BindingNavigatorSeparator1 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents BindingNavigatorMoveNextItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents BindingNavigatorMoveLastItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents BindingNavigatorSeparator2 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents TitlesBindingNavigatorSaveItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents RoyschedTableAdapter As TeamGFinalProject.BookCollectionDataSetTableAdapters.royschedTableAdapter
    Friend WithEvents TitlesDataGridView As System.Windows.Forms.DataGridView
    Friend WithEvents DataGridViewTextBoxColumn1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn2 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn3 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn4 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn5 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn6 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn7 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn8 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn9 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn10 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Title_idTextBox As System.Windows.Forms.TextBox
    Friend WithEvents TitleTextBox As System.Windows.Forms.TextBox
    Friend WithEvents TypeTextBox As System.Windows.Forms.TextBox
    Friend WithEvents Pub_idTextBox As System.Windows.Forms.TextBox
    Friend WithEvents PriceTextBox As System.Windows.Forms.TextBox
    Friend WithEvents AdvanceTextBox As System.Windows.Forms.TextBox
    Friend WithEvents RoyaltyTextBox As System.Windows.Forms.TextBox
    Friend WithEvents Ytd_salesTextBox As System.Windows.Forms.TextBox
    Friend WithEvents NotesTextBox As System.Windows.Forms.TextBox
    Friend WithEvents PubdateDateTimePicker As System.Windows.Forms.DateTimePicker
    Friend WithEvents RoyschedBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents SalesTableAdapter As TeamGFinalProject.BookCollectionDataSetTableAdapters.salesTableAdapter
    Friend WithEvents SalesBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents TitleauthorTableAdapter As TeamGFinalProject.BookCollectionDataSetTableAdapters.titleauthorTableAdapter
    Friend WithEvents TitleauthorBindingSource As System.Windows.Forms.BindingSource
End Class
