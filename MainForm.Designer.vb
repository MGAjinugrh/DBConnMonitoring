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
        Me.LayoutControlItem2 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem1 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem3 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem5 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem6 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.EmptySpaceItem2 = New DevExpress.XtraLayout.EmptySpaceItem()
        CType(Me.PanelControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanelControl1.SuspendLayout()
        CType(Me.LayoutControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.LayoutControl1.SuspendLayout()
        CType(Me.TEBaseUrl.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TEPort.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SPNumOfHits.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Root, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem5, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem6, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.EmptySpaceItem2, System.ComponentModel.ISupportInitialize).BeginInit()
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
        Me.PanelControl1.Name = "PanelControl1"
        Me.PanelControl1.Size = New System.Drawing.Size(800, 48)
        Me.PanelControl1.TabIndex = 0
        '
        'LabelControl1
        '
        Me.LabelControl1.Appearance.Font = New System.Drawing.Font("Segoe UI Semibold", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.LabelControl1.Appearance.ForeColor = System.Drawing.Color.White
        Me.LabelControl1.Appearance.Options.UseFont = True
        Me.LabelControl1.Appearance.Options.UseForeColor = True
        Me.LabelControl1.Location = New System.Drawing.Point(13, 8)
        Me.LabelControl1.Name = "LabelControl1"
        Me.LabelControl1.Size = New System.Drawing.Size(192, 30)
        Me.LabelControl1.TabIndex = 0
        Me.LabelControl1.Text = "DBConn Monitoring"
        '
        'LayoutControl1
        '
        Me.LayoutControl1.Controls.Add(Me.TEBaseUrl)
        Me.LayoutControl1.Controls.Add(Me.TEPort)
        Me.LayoutControl1.Controls.Add(Me.GridControl1)
        Me.LayoutControl1.Controls.Add(Me.SBExecute)
        Me.LayoutControl1.Controls.Add(Me.SPNumOfHits)
        Me.LayoutControl1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.LayoutControl1.Location = New System.Drawing.Point(0, 48)
        Me.LayoutControl1.Name = "LayoutControl1"
        Me.LayoutControl1.OptionsCustomizationForm.DesignTimeCustomizationFormPositionAndSize = New System.Drawing.Rectangle(716, 110, 650, 400)
        Me.LayoutControl1.Root = Me.Root
        Me.LayoutControl1.Size = New System.Drawing.Size(800, 402)
        Me.LayoutControl1.TabIndex = 1
        Me.LayoutControl1.Text = "LayoutControl1"
        '
        'TEBaseUrl
        '
        Me.TEBaseUrl.Location = New System.Drawing.Point(12, 28)
        Me.TEBaseUrl.Name = "TEBaseUrl"
        Me.TEBaseUrl.Properties.MaskSettings.Set("MaskManagerType", GetType(DevExpress.Data.Mask.RegExpMaskManager))
        Me.TEBaseUrl.Properties.MaskSettings.Set("MaskManagerSignature", "isOptimistic=False")
        Me.TEBaseUrl.Properties.MaskSettings.Set("mask", "(([01]?[0-9]?[0-9])|(2[0-4][0-9])|(25[0-5]))\.(([01]?[0-9]?[0-9])|(2[0-4][0-9])|(" &
        "25[0-5]))\.(([01]?[0-9]?[0-9])|(2[0-4][0-9])|(25[0-5]))\.(([01]?[0-9]?[0-9])|(2[" &
        "0-4][0-9])|(25[0-5]))")
        Me.TEBaseUrl.Size = New System.Drawing.Size(196, 20)
        Me.TEBaseUrl.StyleController = Me.LayoutControl1
        Me.TEBaseUrl.TabIndex = 7
        '
        'TEPort
        '
        Me.TEPort.Location = New System.Drawing.Point(212, 28)
        Me.TEPort.Name = "TEPort"
        Me.TEPort.Properties.MaskSettings.Set("MaskManagerType", GetType(DevExpress.Data.Mask.RegExpMaskManager))
        Me.TEPort.Properties.MaskSettings.Set("MaskManagerSignature", "isOptimistic=False")
        Me.TEPort.Properties.MaskSettings.Set("mask", "\d+")
        Me.TEPort.Size = New System.Drawing.Size(76, 20)
        Me.TEPort.StyleController = Me.LayoutControl1
        Me.TEPort.TabIndex = 6
        '
        'GridControl1
        '
        Me.GridControl1.Location = New System.Drawing.Point(12, 52)
        Me.GridControl1.MainView = Me.GridView1
        Me.GridControl1.Name = "GridControl1"
        Me.GridControl1.Size = New System.Drawing.Size(776, 338)
        Me.GridControl1.TabIndex = 4
        Me.GridControl1.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GridView1})
        '
        'GridView1
        '
        Me.GridView1.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.GCNumOfHit1, Me.GCExcTime1, Me.GCNumSuccess1, Me.GCNumFailed1})
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
        Me.GCNumOfHit1.MaxWidth = 20
        Me.GCNumOfHit1.Name = "GCNumOfHit1"
        Me.GCNumOfHit1.Visible = True
        Me.GCNumOfHit1.VisibleIndex = 0
        Me.GCNumOfHit1.Width = 20
        '
        'GCExcTime1
        '
        Me.GCExcTime1.Caption = "Exec Time"
        Me.GCExcTime1.DisplayFormat.FormatString = "yyyy-MM-DD hh:mm:ss.FFF"
        Me.GCExcTime1.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime
        Me.GCExcTime1.FieldName = "excTime1"
        Me.GCExcTime1.Name = "GCExcTime1"
        Me.GCExcTime1.Visible = True
        Me.GCExcTime1.VisibleIndex = 1
        Me.GCExcTime1.Width = 111
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
        Me.GCNumSuccess1.MaxWidth = 65
        Me.GCNumSuccess1.MinWidth = 65
        Me.GCNumSuccess1.Name = "GCNumSuccess1"
        Me.GCNumSuccess1.Summary.AddRange(New DevExpress.XtraGrid.GridSummaryItem() {New DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "NumSuccess1", "{0:n0}")})
        Me.GCNumSuccess1.Visible = True
        Me.GCNumSuccess1.VisibleIndex = 2
        Me.GCNumSuccess1.Width = 65
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
        Me.GCNumFailed1.MaxWidth = 65
        Me.GCNumFailed1.MinWidth = 65
        Me.GCNumFailed1.Name = "GCNumFailed1"
        Me.GCNumFailed1.Summary.AddRange(New DevExpress.XtraGrid.GridSummaryItem() {New DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "NumFailed1", "{0:n0}")})
        Me.GCNumFailed1.Visible = True
        Me.GCNumFailed1.VisibleIndex = 3
        Me.GCNumFailed1.Width = 65
        '
        'SBExecute
        '
        Me.SBExecute.Location = New System.Drawing.Point(717, 12)
        Me.SBExecute.Name = "SBExecute"
        Me.SBExecute.Size = New System.Drawing.Size(71, 36)
        Me.SBExecute.StyleController = Me.LayoutControl1
        Me.SBExecute.TabIndex = 3
        Me.SBExecute.Text = "Execute"
        '
        'SPNumOfHits
        '
        Me.SPNumOfHits.EditValue = New Decimal(New Integer() {0, 0, 0, 0})
        Me.SPNumOfHits.Location = New System.Drawing.Point(642, 28)
        Me.SPNumOfHits.Name = "SPNumOfHits"
        Me.SPNumOfHits.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.SPNumOfHits.Properties.DisplayFormat.FormatString = "n0"
        Me.SPNumOfHits.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.SPNumOfHits.Size = New System.Drawing.Size(71, 20)
        Me.SPNumOfHits.StyleController = Me.LayoutControl1
        Me.SPNumOfHits.TabIndex = 0
        '
        'Root
        '
        Me.Root.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.[True]
        Me.Root.GroupBordersVisible = False
        Me.Root.Items.AddRange(New DevExpress.XtraLayout.BaseLayoutItem() {Me.LayoutControlItem2, Me.LayoutControlItem1, Me.LayoutControlItem3, Me.LayoutControlItem5, Me.LayoutControlItem6, Me.EmptySpaceItem2})
        Me.Root.Name = "Root"
        Me.Root.Size = New System.Drawing.Size(800, 402)
        Me.Root.TextVisible = False
        '
        'LayoutControlItem2
        '
        Me.LayoutControlItem2.Control = Me.SPNumOfHits
        Me.LayoutControlItem2.Location = New System.Drawing.Point(630, 0)
        Me.LayoutControlItem2.MaxSize = New System.Drawing.Size(75, 40)
        Me.LayoutControlItem2.MinSize = New System.Drawing.Size(75, 40)
        Me.LayoutControlItem2.Name = "LayoutControlItem2"
        Me.LayoutControlItem2.Size = New System.Drawing.Size(75, 40)
        Me.LayoutControlItem2.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom
        Me.LayoutControlItem2.Text = "Number of hits:"
        Me.LayoutControlItem2.TextLocation = DevExpress.Utils.Locations.Top
        Me.LayoutControlItem2.TextSize = New System.Drawing.Size(74, 13)
        '
        'LayoutControlItem1
        '
        Me.LayoutControlItem1.Control = Me.SBExecute
        Me.LayoutControlItem1.Location = New System.Drawing.Point(705, 0)
        Me.LayoutControlItem1.MaxSize = New System.Drawing.Size(75, 40)
        Me.LayoutControlItem1.MinSize = New System.Drawing.Size(75, 40)
        Me.LayoutControlItem1.Name = "LayoutControlItem1"
        Me.LayoutControlItem1.Size = New System.Drawing.Size(75, 40)
        Me.LayoutControlItem1.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom
        Me.LayoutControlItem1.TextSize = New System.Drawing.Size(0, 0)
        Me.LayoutControlItem1.TextVisible = False
        '
        'LayoutControlItem3
        '
        Me.LayoutControlItem3.Control = Me.GridControl1
        Me.LayoutControlItem3.Location = New System.Drawing.Point(0, 40)
        Me.LayoutControlItem3.Name = "LayoutControlItem3"
        Me.LayoutControlItem3.Size = New System.Drawing.Size(780, 342)
        Me.LayoutControlItem3.TextLocation = DevExpress.Utils.Locations.Top
        Me.LayoutControlItem3.TextSize = New System.Drawing.Size(0, 0)
        Me.LayoutControlItem3.TextVisible = False
        '
        'LayoutControlItem5
        '
        Me.LayoutControlItem5.Control = Me.TEPort
        Me.LayoutControlItem5.Location = New System.Drawing.Point(200, 0)
        Me.LayoutControlItem5.MaxSize = New System.Drawing.Size(80, 24)
        Me.LayoutControlItem5.MinSize = New System.Drawing.Size(80, 24)
        Me.LayoutControlItem5.Name = "LayoutControlItem5"
        Me.LayoutControlItem5.Size = New System.Drawing.Size(80, 40)
        Me.LayoutControlItem5.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom
        Me.LayoutControlItem5.Text = "Port :"
        Me.LayoutControlItem5.TextLocation = DevExpress.Utils.Locations.Top
        Me.LayoutControlItem5.TextSize = New System.Drawing.Size(74, 13)
        '
        'LayoutControlItem6
        '
        Me.LayoutControlItem6.Control = Me.TEBaseUrl
        Me.LayoutControlItem6.Location = New System.Drawing.Point(0, 0)
        Me.LayoutControlItem6.MaxSize = New System.Drawing.Size(200, 40)
        Me.LayoutControlItem6.MinSize = New System.Drawing.Size(200, 40)
        Me.LayoutControlItem6.Name = "LayoutControlItem6"
        Me.LayoutControlItem6.Size = New System.Drawing.Size(200, 40)
        Me.LayoutControlItem6.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom
        Me.LayoutControlItem6.Text = "Base Url :"
        Me.LayoutControlItem6.TextLocation = DevExpress.Utils.Locations.Top
        Me.LayoutControlItem6.TextSize = New System.Drawing.Size(74, 13)
        '
        'EmptySpaceItem2
        '
        Me.EmptySpaceItem2.AllowHotTrack = False
        Me.EmptySpaceItem2.Location = New System.Drawing.Point(280, 0)
        Me.EmptySpaceItem2.Name = "EmptySpaceItem2"
        Me.EmptySpaceItem2.Size = New System.Drawing.Size(350, 40)
        Me.EmptySpaceItem2.TextSize = New System.Drawing.Size(0, 0)
        '
        'MainForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.LayoutControl1)
        Me.Controls.Add(Me.PanelControl1)
        Me.Name = "MainForm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "By : Muhammad Guruh Ajinugroho"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        CType(Me.PanelControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelControl1.ResumeLayout(False)
        Me.PanelControl1.PerformLayout()
        CType(Me.LayoutControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.LayoutControl1.ResumeLayout(False)
        CType(Me.TEBaseUrl.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TEPort.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridControl1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SPNumOfHits.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Root, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem5, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem6, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.EmptySpaceItem2, System.ComponentModel.ISupportInitialize).EndInit()
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
End Class
