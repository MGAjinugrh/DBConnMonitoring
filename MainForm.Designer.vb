<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class MainForm
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.PanelControl1 = New DevExpress.XtraEditors.PanelControl()
        Me.LabelControl1 = New DevExpress.XtraEditors.LabelControl()
        Me.LayoutControl1 = New DevExpress.XtraLayout.LayoutControl()
        Me.SBExport = New DevExpress.XtraEditors.SimpleButton()
        Me.SBReset = New DevExpress.XtraEditors.SimpleButton()
        Me.SBStop = New DevExpress.XtraEditors.SimpleButton()
        Me.TESSL = New DevExpress.XtraEditors.TextEdit()
        Me.TETimeout = New DevExpress.XtraEditors.TextEdit()
        Me.TEDatabase = New DevExpress.XtraEditors.TextEdit()
        Me.TEPassword = New DevExpress.XtraEditors.TextEdit()
        Me.TEUsername = New DevExpress.XtraEditors.TextEdit()
        Me.TEBaseUrl = New DevExpress.XtraEditors.TextEdit()
        Me.TEPort = New DevExpress.XtraEditors.TextEdit()
        Me.GridControl1 = New DevExpress.XtraGrid.GridControl()
        Me.GridView1 = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.GCNumOfHit1 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GCExcTime1 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GCNumSuccess1 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GCNumFailed1 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.SBExecute = New DevExpress.XtraEditors.SimpleButton()
        Me.SPNumOfHits = New DevExpress.XtraEditors.SpinEdit()
        Me.Root = New DevExpress.XtraLayout.LayoutControlGroup()
        Me.LayoutControlItem3 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem5 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem6 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.EmptySpaceItem2 = New DevExpress.XtraLayout.EmptySpaceItem()
        Me.LayoutControlItem10 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem7 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem12 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem2 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.EmptySpaceItem1 = New DevExpress.XtraLayout.EmptySpaceItem()
        Me.LayoutControlItem11 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem1 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem4 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem8 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem9 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.EmptySpaceItem3 = New DevExpress.XtraLayout.EmptySpaceItem()
        Me.LayoutControlItem14 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.BWPing = New System.ComponentModel.BackgroundWorker()
        Me.GCEndTime1 = New DevExpress.XtraGrid.Columns.GridColumn()
        CType(Me.PanelControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanelControl1.SuspendLayout()
        CType(Me.LayoutControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.LayoutControl1.SuspendLayout()
        CType(Me.TESSL.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TETimeout.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TEDatabase.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TEPassword.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TEUsername.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TEBaseUrl.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TEPort.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SPNumOfHits.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Root, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem5, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem6, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.EmptySpaceItem2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem10, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem7, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem12, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.EmptySpaceItem1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem11, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem8, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem9, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.EmptySpaceItem3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem14, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'PanelControl1
        '
        Me.PanelControl1.Appearance.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.PanelControl1.Appearance.Options.UseBackColor = True
        Me.PanelControl1.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder
        Me.PanelControl1.Controls.Add(Me.LabelControl1)
        Me.PanelControl1.Dock = System.Windows.Forms.DockStyle.Top
        Me.PanelControl1.Location = New System.Drawing.Point(0, 0)
        Me.PanelControl1.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.PanelControl1.Name = "PanelControl1"
        Me.PanelControl1.Size = New System.Drawing.Size(914, 64)
        Me.PanelControl1.TabIndex = 0
        '
        'LabelControl1
        '
        Me.LabelControl1.Appearance.Font = New System.Drawing.Font("Segoe UI Semibold", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.LabelControl1.Appearance.ForeColor = System.Drawing.Color.White
        Me.LabelControl1.Appearance.Options.UseFont = True
        Me.LabelControl1.Appearance.Options.UseForeColor = True
        Me.LabelControl1.Location = New System.Drawing.Point(15, 11)
        Me.LabelControl1.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.LabelControl1.Name = "LabelControl1"
        Me.LabelControl1.Size = New System.Drawing.Size(239, 36)
        Me.LabelControl1.TabIndex = 0
        Me.LabelControl1.Text = "DBConn Monitoring"
        '
        'LayoutControl1
        '
        Me.LayoutControl1.Controls.Add(Me.SBExport)
        Me.LayoutControl1.Controls.Add(Me.SBReset)
        Me.LayoutControl1.Controls.Add(Me.SBStop)
        Me.LayoutControl1.Controls.Add(Me.TESSL)
        Me.LayoutControl1.Controls.Add(Me.TETimeout)
        Me.LayoutControl1.Controls.Add(Me.TEDatabase)
        Me.LayoutControl1.Controls.Add(Me.TEPassword)
        Me.LayoutControl1.Controls.Add(Me.TEUsername)
        Me.LayoutControl1.Controls.Add(Me.TEBaseUrl)
        Me.LayoutControl1.Controls.Add(Me.TEPort)
        Me.LayoutControl1.Controls.Add(Me.GridControl1)
        Me.LayoutControl1.Controls.Add(Me.SBExecute)
        Me.LayoutControl1.Controls.Add(Me.SPNumOfHits)
        Me.LayoutControl1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.LayoutControl1.Location = New System.Drawing.Point(0, 64)
        Me.LayoutControl1.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.LayoutControl1.Name = "LayoutControl1"
        Me.LayoutControl1.OptionsCustomizationForm.DesignTimeCustomizationFormPositionAndSize = New System.Drawing.Rectangle(716, 110, 650, 400)
        Me.LayoutControl1.Root = Me.Root
        Me.LayoutControl1.Size = New System.Drawing.Size(914, 536)
        Me.LayoutControl1.TabIndex = 1
        Me.LayoutControl1.Text = "LayoutControl1"
        '
        'SBExport
        '
        Me.SBExport.Location = New System.Drawing.Point(825, 491)
        Me.SBExport.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.SBExport.Name = "SBExport"
        Me.SBExport.Size = New System.Drawing.Size(76, 29)
        Me.SBExport.StyleController = Me.LayoutControl1
        Me.SBExport.TabIndex = 13
        Me.SBExport.Text = "Export"
        '
        'SBReset
        '
        Me.SBReset.Location = New System.Drawing.Point(811, 142)
        Me.SBReset.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.SBReset.Name = "SBReset"
        Me.SBReset.Size = New System.Drawing.Size(90, 27)
        Me.SBReset.StyleController = Me.LayoutControl1
        Me.SBReset.TabIndex = 11
        Me.SBReset.Text = "Reset"
        '
        'SBStop
        '
        Me.SBStop.Location = New System.Drawing.Point(811, 109)
        Me.SBStop.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.SBStop.Name = "SBStop"
        Me.SBStop.Size = New System.Drawing.Size(90, 27)
        Me.SBStop.StyleController = Me.LayoutControl1
        Me.SBStop.TabIndex = 7
        Me.SBStop.Text = "Stop"
        '
        'TESSL
        '
        Me.TESSL.EditValue = ""
        Me.TESSL.Location = New System.Drawing.Point(242, 141)
        Me.TESSL.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.TESSL.Name = "TESSL"
        Me.TESSL.Properties.NullText = "none"
        Me.TESSL.Size = New System.Drawing.Size(225, 22)
        Me.TESSL.StyleController = Me.LayoutControl1
        Me.TESSL.TabIndex = 9
        '
        'TETimeout
        '
        Me.TETimeout.EditValue = ""
        Me.TETimeout.Location = New System.Drawing.Point(471, 141)
        Me.TETimeout.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.TETimeout.Name = "TETimeout"
        Me.TETimeout.Properties.MaskSettings.Set("MaskManagerType", GetType(DevExpress.Data.Mask.RegExpMaskManager))
        Me.TETimeout.Properties.MaskSettings.Set("MaskManagerSignature", "isOptimistic=False")
        Me.TETimeout.Properties.MaskSettings.Set("mask", "\d+")
        Me.TETimeout.Properties.MaskSettings.Set("allowBlankInput", True)
        Me.TETimeout.Properties.NullText = "3600"
        Me.TETimeout.Properties.UseMaskAsDisplayFormat = True
        Me.TETimeout.Size = New System.Drawing.Size(225, 22)
        Me.TETimeout.StyleController = Me.LayoutControl1
        Me.TETimeout.TabIndex = 10
        '
        'TEDatabase
        '
        Me.TEDatabase.EditValue = ""
        Me.TEDatabase.Location = New System.Drawing.Point(13, 141)
        Me.TEDatabase.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.TEDatabase.Name = "TEDatabase"
        Me.TEDatabase.Properties.NullText = "mysql"
        Me.TEDatabase.Size = New System.Drawing.Size(225, 22)
        Me.TEDatabase.StyleController = Me.LayoutControl1
        Me.TEDatabase.TabIndex = 8
        '
        'TEPassword
        '
        Me.TEPassword.Location = New System.Drawing.Point(242, 88)
        Me.TEPassword.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.TEPassword.Name = "TEPassword"
        Me.TEPassword.Properties.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.TEPassword.Properties.UseSystemPasswordChar = True
        Me.TEPassword.Size = New System.Drawing.Size(185, 22)
        Me.TEPassword.StyleController = Me.LayoutControl1
        Me.TEPassword.TabIndex = 4
        '
        'TEUsername
        '
        Me.TEUsername.Location = New System.Drawing.Point(13, 88)
        Me.TEUsername.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.TEUsername.Name = "TEUsername"
        Me.TEUsername.Size = New System.Drawing.Size(185, 22)
        Me.TEUsername.StyleController = Me.LayoutControl1
        Me.TEUsername.TabIndex = 3
        '
        'TEBaseUrl
        '
        Me.TEBaseUrl.Location = New System.Drawing.Point(13, 35)
        Me.TEBaseUrl.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.TEBaseUrl.Name = "TEBaseUrl"
        Me.TEBaseUrl.Properties.MaskSettings.Set("MaskManagerType", GetType(DevExpress.Data.Mask.RegExpMaskManager))
        Me.TEBaseUrl.Properties.MaskSettings.Set("MaskManagerSignature", "isOptimistic=False")
        Me.TEBaseUrl.Properties.MaskSettings.Set("mask", "(([01]?[0-9]?[0-9])|(2[0-4][0-9])|(25[0-5]))\.(([01]?[0-9]?[0-9])|(2[0-4][0-9])|(" &
        "25[0-5]))\.(([01]?[0-9]?[0-9])|(2[0-4][0-9])|(25[0-5]))\.(([01]?[0-9]?[0-9])|(2[" &
        "0-4][0-9])|(25[0-5]))")
        Me.TEBaseUrl.Properties.MaskSettings.Set("allowBlankInput", True)
        Me.TEBaseUrl.Properties.UseMaskAsDisplayFormat = True
        Me.TEBaseUrl.Size = New System.Drawing.Size(185, 22)
        Me.TEBaseUrl.StyleController = Me.LayoutControl1
        Me.TEBaseUrl.TabIndex = 0
        '
        'TEPort
        '
        Me.TEPort.EditValue = ""
        Me.TEPort.Location = New System.Drawing.Point(242, 35)
        Me.TEPort.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.TEPort.Name = "TEPort"
        Me.TEPort.Properties.MaskSettings.Set("MaskManagerType", GetType(DevExpress.Data.Mask.RegExpMaskManager))
        Me.TEPort.Properties.MaskSettings.Set("MaskManagerSignature", "isOptimistic=False")
        Me.TEPort.Properties.MaskSettings.Set("mask", "\d+")
        Me.TEPort.Properties.MaskSettings.Set("allowBlankInput", True)
        Me.TEPort.Properties.MaxLength = 4
        Me.TEPort.Properties.NullText = "3306"
        Me.TEPort.Properties.UseMaskAsDisplayFormat = True
        Me.TEPort.Size = New System.Drawing.Size(87, 22)
        Me.TEPort.StyleController = Me.LayoutControl1
        Me.TEPort.TabIndex = 2
        '
        'GridControl1
        '
        Me.GridControl1.EmbeddedNavigator.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.GridControl1.Location = New System.Drawing.Point(13, 175)
        Me.GridControl1.MainView = Me.GridView1
        Me.GridControl1.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.GridControl1.Name = "GridControl1"
        Me.GridControl1.Size = New System.Drawing.Size(888, 310)
        Me.GridControl1.TabIndex = 12
        Me.GridControl1.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GridView1})
        '
        'GridView1
        '
        Me.GridView1.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.GCNumOfHit1, Me.GCExcTime1, Me.GCEndTime1, Me.GCNumSuccess1, Me.GCNumFailed1})
        Me.GridView1.DetailHeight = 467
        Me.GridView1.GridControl = Me.GridControl1
        Me.GridView1.Name = "GridView1"
        Me.GridView1.OptionsView.ShowFooter = True
        Me.GridView1.OptionsView.ShowGroupPanel = False
        Me.GridView1.ViewCaption = "SERVER-1 (Port 80)"
        '
        'GCNumOfHit1
        '
        Me.GCNumOfHit1.Caption = "#"
        Me.GCNumOfHit1.DisplayFormat.FormatString = "n0"
        Me.GCNumOfHit1.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.GCNumOfHit1.FieldName = "NumOfHit1"
        Me.GCNumOfHit1.MinWidth = 23
        Me.GCNumOfHit1.Name = "GCNumOfHit1"
        Me.GCNumOfHit1.OptionsColumn.AllowEdit = False
        Me.GCNumOfHit1.Visible = True
        Me.GCNumOfHit1.VisibleIndex = 0
        Me.GCNumOfHit1.Width = 61
        '
        'GCExcTime1
        '
        Me.GCExcTime1.Caption = "Exec Time"
        Me.GCExcTime1.FieldName = "excTime1"
        Me.GCExcTime1.MinWidth = 23
        Me.GCExcTime1.Name = "GCExcTime1"
        Me.GCExcTime1.OptionsColumn.AllowEdit = False
        Me.GCExcTime1.Visible = True
        Me.GCExcTime1.VisibleIndex = 1
        Me.GCExcTime1.Width = 624
        '
        'GCNumSuccess1
        '
        Me.GCNumSuccess1.AppearanceCell.Options.UseTextOptions = True
        Me.GCNumSuccess1.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.GCNumSuccess1.AppearanceHeader.Options.UseTextOptions = True
        Me.GCNumSuccess1.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.GCNumSuccess1.Caption = "Success Hit"
        Me.GCNumSuccess1.DisplayFormat.FormatString = "n0"
        Me.GCNumSuccess1.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.GCNumSuccess1.FieldName = "NumSuccess1"
        Me.GCNumSuccess1.MaxWidth = 74
        Me.GCNumSuccess1.MinWidth = 74
        Me.GCNumSuccess1.Name = "GCNumSuccess1"
        Me.GCNumSuccess1.OptionsColumn.AllowEdit = False
        Me.GCNumSuccess1.Summary.AddRange(New DevExpress.XtraGrid.GridSummaryItem() {New DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "NumSuccess1", "{0:n0}")})
        Me.GCNumSuccess1.Visible = True
        Me.GCNumSuccess1.VisibleIndex = 3
        Me.GCNumSuccess1.Width = 74
        '
        'GCNumFailed1
        '
        Me.GCNumFailed1.AppearanceCell.Options.UseTextOptions = True
        Me.GCNumFailed1.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.GCNumFailed1.AppearanceHeader.Options.UseTextOptions = True
        Me.GCNumFailed1.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.GCNumFailed1.Caption = "Failed Hit"
        Me.GCNumFailed1.DisplayFormat.FormatString = "n0"
        Me.GCNumFailed1.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.GCNumFailed1.FieldName = "NumFailed1"
        Me.GCNumFailed1.MaxWidth = 74
        Me.GCNumFailed1.MinWidth = 74
        Me.GCNumFailed1.Name = "GCNumFailed1"
        Me.GCNumFailed1.OptionsColumn.ReadOnly = True
        Me.GCNumFailed1.Summary.AddRange(New DevExpress.XtraGrid.GridSummaryItem() {New DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "NumFailed1", "{0:n0}")})
        Me.GCNumFailed1.Visible = True
        Me.GCNumFailed1.VisibleIndex = 4
        Me.GCNumFailed1.Width = 74
        '
        'SBExecute
        '
        Me.SBExecute.Location = New System.Drawing.Point(811, 76)
        Me.SBExecute.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.SBExecute.Name = "SBExecute"
        Me.SBExecute.Size = New System.Drawing.Size(90, 27)
        Me.SBExecute.StyleController = Me.LayoutControl1
        Me.SBExecute.TabIndex = 6
        Me.SBExecute.Text = "Execute"
        '
        'SPNumOfHits
        '
        Me.SPNumOfHits.EditValue = New Decimal(New Integer() {0, 0, 0, 0})
        Me.SPNumOfHits.Location = New System.Drawing.Point(725, 95)
        Me.SPNumOfHits.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.SPNumOfHits.Name = "SPNumOfHits"
        Me.SPNumOfHits.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.SPNumOfHits.Properties.DisplayFormat.FormatString = "n0"
        Me.SPNumOfHits.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.SPNumOfHits.Properties.IsFloatValue = False
        Me.SPNumOfHits.Properties.MaskSettings.Set("mask", "d")
        Me.SPNumOfHits.Properties.UseMaskAsDisplayFormat = True
        Me.SPNumOfHits.Size = New System.Drawing.Size(82, 24)
        Me.SPNumOfHits.StyleController = Me.LayoutControl1
        Me.SPNumOfHits.TabIndex = 5
        '
        'Root
        '
        Me.Root.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.[True]
        Me.Root.GroupBordersVisible = False
        Me.Root.Items.AddRange(New DevExpress.XtraLayout.BaseLayoutItem() {Me.LayoutControlItem3, Me.LayoutControlItem5, Me.LayoutControlItem6, Me.EmptySpaceItem2, Me.LayoutControlItem10, Me.LayoutControlItem7, Me.LayoutControlItem12, Me.LayoutControlItem2, Me.EmptySpaceItem1, Me.LayoutControlItem11, Me.LayoutControlItem1, Me.LayoutControlItem4, Me.LayoutControlItem8, Me.LayoutControlItem9, Me.EmptySpaceItem3, Me.LayoutControlItem14})
        Me.Root.Name = "Root"
        Me.Root.Size = New System.Drawing.Size(914, 536)
        Me.Root.TextVisible = False
        '
        'LayoutControlItem3
        '
        Me.LayoutControlItem3.Control = Me.GridControl1
        Me.LayoutControlItem3.Location = New System.Drawing.Point(0, 159)
        Me.LayoutControlItem3.Name = "LayoutControlItem3"
        Me.LayoutControlItem3.Size = New System.Drawing.Size(892, 316)
        Me.LayoutControlItem3.TextLocation = DevExpress.Utils.Locations.Top
        Me.LayoutControlItem3.TextSize = New System.Drawing.Size(0, 0)
        Me.LayoutControlItem3.TextVisible = False
        '
        'LayoutControlItem5
        '
        Me.LayoutControlItem5.Control = Me.TEPort
        Me.LayoutControlItem5.Location = New System.Drawing.Point(229, 0)
        Me.LayoutControlItem5.MaxSize = New System.Drawing.Size(91, 53)
        Me.LayoutControlItem5.MinSize = New System.Drawing.Size(91, 53)
        Me.LayoutControlItem5.Name = "LayoutControlItem5"
        Me.LayoutControlItem5.Size = New System.Drawing.Size(458, 53)
        Me.LayoutControlItem5.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom
        Me.LayoutControlItem5.Text = "Port (Leave blank for Default) :"
        Me.LayoutControlItem5.TextLocation = DevExpress.Utils.Locations.Top
        Me.LayoutControlItem5.TextSize = New System.Drawing.Size(211, 16)
        '
        'LayoutControlItem6
        '
        Me.LayoutControlItem6.Control = Me.TEBaseUrl
        Me.LayoutControlItem6.Location = New System.Drawing.Point(0, 0)
        Me.LayoutControlItem6.MaxSize = New System.Drawing.Size(189, 53)
        Me.LayoutControlItem6.MinSize = New System.Drawing.Size(189, 53)
        Me.LayoutControlItem6.Name = "LayoutControlItem6"
        Me.LayoutControlItem6.Size = New System.Drawing.Size(229, 53)
        Me.LayoutControlItem6.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom
        Me.LayoutControlItem6.Text = "Base Url :"
        Me.LayoutControlItem6.TextLocation = DevExpress.Utils.Locations.Top
        Me.LayoutControlItem6.TextSize = New System.Drawing.Size(211, 16)
        '
        'EmptySpaceItem2
        '
        Me.EmptySpaceItem2.AllowHotTrack = False
        Me.EmptySpaceItem2.Location = New System.Drawing.Point(687, 0)
        Me.EmptySpaceItem2.Name = "EmptySpaceItem2"
        Me.EmptySpaceItem2.Size = New System.Drawing.Size(25, 159)
        Me.EmptySpaceItem2.TextSize = New System.Drawing.Size(0, 0)
        '
        'LayoutControlItem10
        '
        Me.LayoutControlItem10.Control = Me.TESSL
        Me.LayoutControlItem10.Location = New System.Drawing.Point(229, 106)
        Me.LayoutControlItem10.MaxSize = New System.Drawing.Size(229, 53)
        Me.LayoutControlItem10.MinSize = New System.Drawing.Size(229, 53)
        Me.LayoutControlItem10.Name = "LayoutControlItem10"
        Me.LayoutControlItem10.Size = New System.Drawing.Size(229, 53)
        Me.LayoutControlItem10.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom
        Me.LayoutControlItem10.Text = "SSL Mode (Leave Blank for Default) :"
        Me.LayoutControlItem10.TextLocation = DevExpress.Utils.Locations.Top
        Me.LayoutControlItem10.TextSize = New System.Drawing.Size(211, 16)
        '
        'LayoutControlItem7
        '
        Me.LayoutControlItem7.Control = Me.TEPassword
        Me.LayoutControlItem7.Location = New System.Drawing.Point(229, 53)
        Me.LayoutControlItem7.MaxSize = New System.Drawing.Size(189, 53)
        Me.LayoutControlItem7.MinSize = New System.Drawing.Size(189, 53)
        Me.LayoutControlItem7.Name = "LayoutControlItem7"
        Me.LayoutControlItem7.Size = New System.Drawing.Size(458, 53)
        Me.LayoutControlItem7.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom
        Me.LayoutControlItem7.Text = "Password (Leave blank if empty) :"
        Me.LayoutControlItem7.TextLocation = DevExpress.Utils.Locations.Top
        Me.LayoutControlItem7.TextSize = New System.Drawing.Size(211, 16)
        '
        'LayoutControlItem12
        '
        Me.LayoutControlItem12.ContentVertAlignment = DevExpress.Utils.VertAlignment.Bottom
        Me.LayoutControlItem12.Control = Me.SBReset
        Me.LayoutControlItem12.Location = New System.Drawing.Point(798, 126)
        Me.LayoutControlItem12.Name = "LayoutControlItem12"
        Me.LayoutControlItem12.Size = New System.Drawing.Size(94, 33)
        Me.LayoutControlItem12.TextSize = New System.Drawing.Size(0, 0)
        Me.LayoutControlItem12.TextVisible = False
        '
        'LayoutControlItem2
        '
        Me.LayoutControlItem2.ContentVertAlignment = DevExpress.Utils.VertAlignment.Top
        Me.LayoutControlItem2.Control = Me.SPNumOfHits
        Me.LayoutControlItem2.Location = New System.Drawing.Point(712, 60)
        Me.LayoutControlItem2.MaxSize = New System.Drawing.Size(86, 53)
        Me.LayoutControlItem2.MinSize = New System.Drawing.Size(86, 53)
        Me.LayoutControlItem2.Name = "LayoutControlItem2"
        Me.LayoutControlItem2.Size = New System.Drawing.Size(86, 99)
        Me.LayoutControlItem2.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom
        Me.LayoutControlItem2.Text = "Number of hits:"
        Me.LayoutControlItem2.TextLocation = DevExpress.Utils.Locations.Top
        Me.LayoutControlItem2.TextSize = New System.Drawing.Size(211, 16)
        '
        'EmptySpaceItem1
        '
        Me.EmptySpaceItem1.AllowHotTrack = False
        Me.EmptySpaceItem1.Location = New System.Drawing.Point(712, 0)
        Me.EmptySpaceItem1.Name = "EmptySpaceItem1"
        Me.EmptySpaceItem1.Size = New System.Drawing.Size(180, 60)
        Me.EmptySpaceItem1.TextSize = New System.Drawing.Size(0, 0)
        '
        'LayoutControlItem11
        '
        Me.LayoutControlItem11.ContentHorzAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.LayoutControlItem11.ContentVertAlignment = DevExpress.Utils.VertAlignment.Bottom
        Me.LayoutControlItem11.Control = Me.SBStop
        Me.LayoutControlItem11.Location = New System.Drawing.Point(798, 93)
        Me.LayoutControlItem11.Name = "LayoutControlItem11"
        Me.LayoutControlItem11.Size = New System.Drawing.Size(94, 33)
        Me.LayoutControlItem11.TextSize = New System.Drawing.Size(0, 0)
        Me.LayoutControlItem11.TextVisible = False
        '
        'LayoutControlItem1
        '
        Me.LayoutControlItem1.ContentHorzAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.LayoutControlItem1.ContentVertAlignment = DevExpress.Utils.VertAlignment.Bottom
        Me.LayoutControlItem1.Control = Me.SBExecute
        Me.LayoutControlItem1.Location = New System.Drawing.Point(798, 60)
        Me.LayoutControlItem1.Name = "LayoutControlItem1"
        Me.LayoutControlItem1.Size = New System.Drawing.Size(94, 33)
        Me.LayoutControlItem1.TextSize = New System.Drawing.Size(0, 0)
        Me.LayoutControlItem1.TextVisible = False
        '
        'LayoutControlItem4
        '
        Me.LayoutControlItem4.Control = Me.TEUsername
        Me.LayoutControlItem4.Location = New System.Drawing.Point(0, 53)
        Me.LayoutControlItem4.MaxSize = New System.Drawing.Size(189, 53)
        Me.LayoutControlItem4.MinSize = New System.Drawing.Size(189, 53)
        Me.LayoutControlItem4.Name = "LayoutControlItem4"
        Me.LayoutControlItem4.Size = New System.Drawing.Size(229, 53)
        Me.LayoutControlItem4.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom
        Me.LayoutControlItem4.Text = "User (Leave blank for Default) :"
        Me.LayoutControlItem4.TextLocation = DevExpress.Utils.Locations.Top
        Me.LayoutControlItem4.TextSize = New System.Drawing.Size(211, 16)
        '
        'LayoutControlItem8
        '
        Me.LayoutControlItem8.Control = Me.TEDatabase
        Me.LayoutControlItem8.Location = New System.Drawing.Point(0, 106)
        Me.LayoutControlItem8.MaxSize = New System.Drawing.Size(229, 53)
        Me.LayoutControlItem8.MinSize = New System.Drawing.Size(229, 53)
        Me.LayoutControlItem8.Name = "LayoutControlItem8"
        Me.LayoutControlItem8.Size = New System.Drawing.Size(229, 53)
        Me.LayoutControlItem8.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom
        Me.LayoutControlItem8.Text = "Database (Leave blank for Default) :"
        Me.LayoutControlItem8.TextLocation = DevExpress.Utils.Locations.Top
        Me.LayoutControlItem8.TextSize = New System.Drawing.Size(211, 16)
        '
        'LayoutControlItem9
        '
        Me.LayoutControlItem9.Control = Me.TETimeout
        Me.LayoutControlItem9.Location = New System.Drawing.Point(458, 106)
        Me.LayoutControlItem9.MaxSize = New System.Drawing.Size(229, 53)
        Me.LayoutControlItem9.MinSize = New System.Drawing.Size(229, 53)
        Me.LayoutControlItem9.Name = "LayoutControlItem9"
        Me.LayoutControlItem9.Size = New System.Drawing.Size(229, 53)
        Me.LayoutControlItem9.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom
        Me.LayoutControlItem9.Text = "Timeout (Leave blank for default) :"
        Me.LayoutControlItem9.TextLocation = DevExpress.Utils.Locations.Top
        Me.LayoutControlItem9.TextSize = New System.Drawing.Size(211, 16)
        '
        'EmptySpaceItem3
        '
        Me.EmptySpaceItem3.AllowHotTrack = False
        Me.EmptySpaceItem3.Location = New System.Drawing.Point(0, 475)
        Me.EmptySpaceItem3.Name = "EmptySpaceItem3"
        Me.EmptySpaceItem3.Size = New System.Drawing.Size(812, 35)
        Me.EmptySpaceItem3.TextSize = New System.Drawing.Size(0, 0)
        '
        'LayoutControlItem14
        '
        Me.LayoutControlItem14.Control = Me.SBExport
        Me.LayoutControlItem14.Location = New System.Drawing.Point(812, 475)
        Me.LayoutControlItem14.MaxSize = New System.Drawing.Size(80, 35)
        Me.LayoutControlItem14.MinSize = New System.Drawing.Size(80, 35)
        Me.LayoutControlItem14.Name = "LayoutControlItem14"
        Me.LayoutControlItem14.Size = New System.Drawing.Size(80, 35)
        Me.LayoutControlItem14.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom
        Me.LayoutControlItem14.TextSize = New System.Drawing.Size(0, 0)
        Me.LayoutControlItem14.TextVisible = False
        '
        'BWPing
        '
        Me.BWPing.WorkerReportsProgress = True
        Me.BWPing.WorkerSupportsCancellation = True
        '
        'GCEndTime1
        '
        Me.GCEndTime1.Caption = "End Time"
        Me.GCEndTime1.FieldName = "endTime1"
        Me.GCEndTime1.MinWidth = 23
        Me.GCEndTime1.Name = "GCEndTime1"
        Me.GCEndTime1.OptionsColumn.AllowEdit = False
        Me.GCEndTime1.Visible = True
        Me.GCEndTime1.VisibleIndex = 2
        Me.GCEndTime1.Width = 624
        '
        'MainForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(914, 600)
        Me.Controls.Add(Me.LayoutControl1)
        Me.Controls.Add(Me.PanelControl1)
        Me.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.Name = "MainForm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "By : Muhammad Guruh Ajinugroho"
        CType(Me.PanelControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelControl1.ResumeLayout(False)
        Me.PanelControl1.PerformLayout()
        CType(Me.LayoutControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.LayoutControl1.ResumeLayout(False)
        CType(Me.TESSL.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TETimeout.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TEDatabase.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TEPassword.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TEUsername.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TEBaseUrl.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TEPort.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridControl1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SPNumOfHits.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Root, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem5, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem6, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.EmptySpaceItem2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem10, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem7, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem12, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.EmptySpaceItem1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem11, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem8, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem9, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.EmptySpaceItem3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem14, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents PanelControl1 As DevExpress.XtraEditors.PanelControl
    Friend WithEvents LabelControl1 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LayoutControl1 As DevExpress.XtraLayout.LayoutControl
    Friend WithEvents Root As DevExpress.XtraLayout.LayoutControlGroup
    Friend WithEvents GridControl1 As DevExpress.XtraGrid.GridControl
    Friend WithEvents GridView1 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents GCNumOfHit1 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GCExcTime1 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents SBExecute As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents SPNumOfHits As DevExpress.XtraEditors.SpinEdit
    Friend WithEvents LayoutControlItem2 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlItem1 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents EmptySpaceItem2 As DevExpress.XtraLayout.EmptySpaceItem
    Friend WithEvents LayoutControlItem3 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents GCNumSuccess1 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GCNumFailed1 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents TEBaseUrl As DevExpress.XtraEditors.TextEdit
    Friend WithEvents TEPort As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LayoutControlItem5 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlItem6 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents TESSL As DevExpress.XtraEditors.TextEdit
    Friend WithEvents TETimeout As DevExpress.XtraEditors.TextEdit
    Friend WithEvents TEDatabase As DevExpress.XtraEditors.TextEdit
    Friend WithEvents TEPassword As DevExpress.XtraEditors.TextEdit
    Friend WithEvents TEUsername As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LayoutControlItem9 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlItem10 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlItem4 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlItem7 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlItem8 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents SBStop As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents LayoutControlItem11 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents SBReset As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents LayoutControlItem12 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents EmptySpaceItem1 As DevExpress.XtraLayout.EmptySpaceItem
    Private WithEvents BWPing As System.ComponentModel.BackgroundWorker
    Friend WithEvents SBExport As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents EmptySpaceItem3 As DevExpress.XtraLayout.EmptySpaceItem
    Friend WithEvents LayoutControlItem14 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents GCEndTime1 As DevExpress.XtraGrid.Columns.GridColumn
End Class
