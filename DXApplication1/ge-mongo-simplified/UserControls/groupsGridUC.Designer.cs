namespace ge_mongo_simplified.UserControls
{
    partial class GroupsGridUC
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(GroupsGridUC));
            this.layoutControl1 = new DevExpress.XtraLayout.LayoutControl();
            this.groupSearchControl = new DevExpress.XtraEditors.SearchControl();
            this.groupsGrid = new DevExpress.XtraGrid.GridControl();
            this.groupsGridView = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.barManager1 = new DevExpress.XtraBars.BarManager(this.components);
            this.bar2 = new DevExpress.XtraBars.Bar();
            this.searchCheckBtn = new DevExpress.XtraBars.BarCheckItem();
            this.standaloneBarDockControl1 = new DevExpress.XtraBars.StandaloneBarDockControl();
            this.barDockControlTop = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlBottom = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlLeft = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlRight = new DevExpress.XtraBars.BarDockControl();
            this.barButtonItem1 = new DevExpress.XtraBars.BarButtonItem();
            this.repositoryItemSearchLookUpEdit1 = new DevExpress.XtraEditors.Repository.RepositoryItemSearchLookUpEdit();
            this.repositoryItemSearchLookUpEdit1View = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.layoutControlGroup1 = new DevExpress.XtraLayout.LayoutControlGroup();
            this.groupsLabel = new DevExpress.XtraLayout.SimpleLabelItem();
            this.groupsBarControl = new DevExpress.XtraLayout.LayoutControlItem();
            this.gridControl = new DevExpress.XtraLayout.LayoutControlItem();
            this.searchControl = new DevExpress.XtraLayout.LayoutControlItem();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).BeginInit();
            this.layoutControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.groupSearchControl.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupsGrid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupsGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemSearchLookUpEdit1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemSearchLookUpEdit1View)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupsLabel)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupsBarControl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.searchControl)).BeginInit();
            this.SuspendLayout();
            // 
            // layoutControl1
            // 
            this.layoutControl1.Controls.Add(this.groupSearchControl);
            this.layoutControl1.Controls.Add(this.groupsGrid);
            this.layoutControl1.Controls.Add(this.standaloneBarDockControl1);
            this.layoutControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.layoutControl1.Location = new System.Drawing.Point(0, 0);
            this.layoutControl1.Name = "layoutControl1";
            this.layoutControl1.OptionsCustomizationForm.DesignTimeCustomizationFormPositionAndSize = new System.Drawing.Rectangle(738, 208, 413, 586);
            this.layoutControl1.Root = this.layoutControlGroup1;
            this.layoutControl1.Size = new System.Drawing.Size(556, 407);
            this.layoutControl1.TabIndex = 0;
            this.layoutControl1.Text = "layoutControl1";
            // 
            // groupSearchControl
            // 
            this.groupSearchControl.Client = this.groupsGrid;
            this.groupSearchControl.Location = new System.Drawing.Point(137, 12);
            this.groupSearchControl.MenuManager = this.barManager1;
            this.groupSearchControl.Name = "groupSearchControl";
            this.groupSearchControl.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Repository.ClearButton(),
            new DevExpress.XtraEditors.Repository.SearchButton()});
            this.groupSearchControl.Properties.ShowDefaultButtonsMode = DevExpress.XtraEditors.Repository.ShowDefaultButtonsMode.AutoShowClear;
            this.groupSearchControl.Size = new System.Drawing.Size(417, 20);
            this.groupSearchControl.StyleController = this.layoutControl1;
            this.groupSearchControl.TabIndex = 7;
            // 
            // groupsGrid
            // 
            this.groupsGrid.Cursor = System.Windows.Forms.Cursors.Default;
            this.groupsGrid.Location = new System.Drawing.Point(2, 41);
            this.groupsGrid.MainView = this.groupsGridView;
            this.groupsGrid.MenuManager = this.barManager1;
            this.groupsGrid.Name = "groupsGrid";
            this.groupsGrid.Size = new System.Drawing.Size(552, 359);
            this.groupsGrid.TabIndex = 5;
            this.groupsGrid.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.groupsGridView});
            // 
            // groupsGridView
            // 
            this.groupsGridView.GridControl = this.groupsGrid;
            this.groupsGridView.Name = "groupsGridView";
            this.groupsGridView.OptionsView.ShowColumnHeaders = false;
            this.groupsGridView.OptionsView.ShowGroupPanel = false;
            this.groupsGridView.OptionsView.ShowIndicator = false;
            // 
            // barManager1
            // 
            this.barManager1.Bars.AddRange(new DevExpress.XtraBars.Bar[] {
            this.bar2});
            this.barManager1.DockControls.Add(this.barDockControlTop);
            this.barManager1.DockControls.Add(this.barDockControlBottom);
            this.barManager1.DockControls.Add(this.barDockControlLeft);
            this.barManager1.DockControls.Add(this.barDockControlRight);
            this.barManager1.DockControls.Add(this.standaloneBarDockControl1);
            this.barManager1.Form = this;
            this.barManager1.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.searchCheckBtn,
            this.barButtonItem1});
            this.barManager1.MainMenu = this.bar2;
            this.barManager1.MaxItemId = 7;
            this.barManager1.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.repositoryItemSearchLookUpEdit1});
            // 
            // bar2
            // 
            this.bar2.BarItemVertIndent = 4;
            this.bar2.BarName = "Main menu";
            this.bar2.CanDockStyle = DevExpress.XtraBars.BarCanDockStyle.Standalone;
            this.bar2.DockCol = 0;
            this.bar2.DockRow = 0;
            this.bar2.DockStyle = DevExpress.XtraBars.BarDockStyle.Standalone;
            this.bar2.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] {
            new DevExpress.XtraBars.LinkPersistInfo(this.searchCheckBtn, true)});
            this.bar2.OptionsBar.AllowQuickCustomization = false;
            this.bar2.OptionsBar.AutoPopupMode = DevExpress.XtraBars.BarAutoPopupMode.None;
            this.bar2.OptionsBar.DrawBorder = false;
            this.bar2.OptionsBar.DrawDragBorder = false;
            this.bar2.OptionsBar.RotateWhenVertical = false;
            this.bar2.StandaloneBarDockControl = this.standaloneBarDockControl1;
            this.bar2.Text = "Main menu";
            // 
            // searchCheckBtn
            // 
            this.searchCheckBtn.Border = DevExpress.XtraEditors.Controls.BorderStyles.Default;
            this.searchCheckBtn.Caption = "Search";
            this.searchCheckBtn.Id = 5;
            this.searchCheckBtn.LargeGlyph = ((System.Drawing.Image)(resources.GetObject("searchCheckBtn.LargeGlyph")));
            this.searchCheckBtn.Name = "searchCheckBtn";
            this.searchCheckBtn.CheckedChanged += new DevExpress.XtraBars.ItemClickEventHandler(this.searchCheckBtn_CheckedChanged);
            // 
            // standaloneBarDockControl1
            // 
            this.standaloneBarDockControl1.CausesValidation = false;
            this.standaloneBarDockControl1.Location = new System.Drawing.Point(69, 10);
            this.standaloneBarDockControl1.Name = "standaloneBarDockControl1";
            this.standaloneBarDockControl1.Size = new System.Drawing.Size(56, 24);
            this.standaloneBarDockControl1.Text = "standaloneBarDockControl1";
            // 
            // barDockControlTop
            // 
            this.barDockControlTop.CausesValidation = false;
            this.barDockControlTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.barDockControlTop.Location = new System.Drawing.Point(0, 0);
            this.barDockControlTop.Size = new System.Drawing.Size(556, 0);
            // 
            // barDockControlBottom
            // 
            this.barDockControlBottom.CausesValidation = false;
            this.barDockControlBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.barDockControlBottom.Location = new System.Drawing.Point(0, 407);
            this.barDockControlBottom.Size = new System.Drawing.Size(556, 0);
            // 
            // barDockControlLeft
            // 
            this.barDockControlLeft.CausesValidation = false;
            this.barDockControlLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.barDockControlLeft.Location = new System.Drawing.Point(0, 0);
            this.barDockControlLeft.Size = new System.Drawing.Size(0, 407);
            // 
            // barDockControlRight
            // 
            this.barDockControlRight.CausesValidation = false;
            this.barDockControlRight.Dock = System.Windows.Forms.DockStyle.Right;
            this.barDockControlRight.Location = new System.Drawing.Point(556, 0);
            this.barDockControlRight.Size = new System.Drawing.Size(0, 407);
            // 
            // barButtonItem1
            // 
            this.barButtonItem1.Caption = "search";
            this.barButtonItem1.Id = 6;
            this.barButtonItem1.Name = "barButtonItem1";
            // 
            // repositoryItemSearchLookUpEdit1
            // 
            this.repositoryItemSearchLookUpEdit1.AutoHeight = false;
            this.repositoryItemSearchLookUpEdit1.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.repositoryItemSearchLookUpEdit1.Name = "repositoryItemSearchLookUpEdit1";
            this.repositoryItemSearchLookUpEdit1.View = this.repositoryItemSearchLookUpEdit1View;
            // 
            // repositoryItemSearchLookUpEdit1View
            // 
            this.repositoryItemSearchLookUpEdit1View.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus;
            this.repositoryItemSearchLookUpEdit1View.Name = "repositoryItemSearchLookUpEdit1View";
            this.repositoryItemSearchLookUpEdit1View.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.repositoryItemSearchLookUpEdit1View.OptionsView.ShowGroupPanel = false;
            // 
            // layoutControlGroup1
            // 
            this.layoutControlGroup1.CustomizationFormText = "Root";
            this.layoutControlGroup1.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True;
            this.layoutControlGroup1.GroupBordersVisible = false;
            this.layoutControlGroup1.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.groupsLabel,
            this.groupsBarControl,
            this.gridControl,
            this.searchControl});
            this.layoutControlGroup1.Location = new System.Drawing.Point(0, 0);
            this.layoutControlGroup1.Name = "Root";
            this.layoutControlGroup1.Padding = new DevExpress.XtraLayout.Utils.Padding(0, 0, 5, 5);
            this.layoutControlGroup1.ShowTabPageCloseButton = true;
            this.layoutControlGroup1.Size = new System.Drawing.Size(556, 407);
            this.layoutControlGroup1.Text = "Root";
            this.layoutControlGroup1.TextVisible = false;
            // 
            // groupsLabel
            // 
            this.groupsLabel.AllowHotTrack = false;
            this.groupsLabel.AppearanceItemCaption.Font = new System.Drawing.Font("Segoe UI Semilight", 12.25F);
            this.groupsLabel.AppearanceItemCaption.Options.UseFont = true;
            this.groupsLabel.CustomizationFormText = "Groups";
            this.groupsLabel.Location = new System.Drawing.Point(0, 0);
            this.groupsLabel.MaxSize = new System.Drawing.Size(67, 30);
            this.groupsLabel.MinSize = new System.Drawing.Size(67, 30);
            this.groupsLabel.Name = "groupsLabel";
            this.groupsLabel.Size = new System.Drawing.Size(67, 34);
            this.groupsLabel.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom;
            this.groupsLabel.Spacing = new DevExpress.XtraLayout.Utils.Padding(3, 0, 0, 5);
            this.groupsLabel.Text = "Groups";
            this.groupsLabel.TextSize = new System.Drawing.Size(50, 21);
            // 
            // groupsBarControl
            // 
            this.groupsBarControl.Control = this.standaloneBarDockControl1;
            this.groupsBarControl.ControlAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            this.groupsBarControl.CustomizationFormText = "groupsBarControl";
            this.groupsBarControl.FillControlToClientArea = false;
            this.groupsBarControl.Location = new System.Drawing.Point(67, 0);
            this.groupsBarControl.MaxSize = new System.Drawing.Size(65, 34);
            this.groupsBarControl.MinSize = new System.Drawing.Size(60, 34);
            this.groupsBarControl.Name = "groupsBarControl";
            this.groupsBarControl.Size = new System.Drawing.Size(60, 34);
            this.groupsBarControl.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom;
            this.groupsBarControl.Text = "groupsBarControl";
            this.groupsBarControl.TextAlignMode = DevExpress.XtraLayout.TextAlignModeItem.AutoSize;
            this.groupsBarControl.TextSize = new System.Drawing.Size(0, 0);
            this.groupsBarControl.TextToControlDistance = 0;
            this.groupsBarControl.TextVisible = false;
            this.groupsBarControl.TrimClientAreaToControl = false;
            this.groupsBarControl.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Never;
            // 
            // gridControl
            // 
            this.gridControl.Control = this.groupsGrid;
            this.gridControl.CustomizationFormText = "gridControl";
            this.gridControl.Location = new System.Drawing.Point(0, 34);
            this.gridControl.Name = "gridControl";
            this.gridControl.Size = new System.Drawing.Size(556, 363);
            this.gridControl.Text = "gridControl";
            this.gridControl.TextSize = new System.Drawing.Size(0, 0);
            this.gridControl.TextToControlDistance = 0;
            this.gridControl.TextVisible = false;
            // 
            // searchControl
            // 
            this.searchControl.Control = this.groupSearchControl;
            this.searchControl.ControlAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            this.searchControl.CustomizationFormText = "searchControl";
            this.searchControl.FillControlToClientArea = false;
            this.searchControl.Location = new System.Drawing.Point(127, 0);
            this.searchControl.Name = "searchControl";
            this.searchControl.Padding = new DevExpress.XtraLayout.Utils.Padding(10, 2, 2, 2);
            this.searchControl.Size = new System.Drawing.Size(429, 34);
            this.searchControl.Text = "searchControl";
            this.searchControl.TextSize = new System.Drawing.Size(0, 0);
            this.searchControl.TextToControlDistance = 0;
            this.searchControl.TextVisible = false;
            this.searchControl.TrimClientAreaToControl = false;
            this.searchControl.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Never;
            // 
            // GroupsGridUC
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.layoutControl1);
            this.Controls.Add(this.barDockControlLeft);
            this.Controls.Add(this.barDockControlRight);
            this.Controls.Add(this.barDockControlBottom);
            this.Controls.Add(this.barDockControlTop);
            this.Name = "GroupsGridUC";
            this.Size = new System.Drawing.Size(556, 407);
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).EndInit();
            this.layoutControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.groupSearchControl.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupsGrid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupsGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemSearchLookUpEdit1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemSearchLookUpEdit1View)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupsLabel)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupsBarControl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.searchControl)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraLayout.LayoutControl layoutControl1;
        private DevExpress.XtraLayout.LayoutControlGroup layoutControlGroup1;
        private DevExpress.XtraLayout.SimpleLabelItem groupsLabel;
        private DevExpress.XtraBars.StandaloneBarDockControl standaloneBarDockControl1;
        private DevExpress.XtraLayout.LayoutControlItem groupsBarControl;
        private DevExpress.XtraBars.BarManager barManager1;
        private DevExpress.XtraBars.Bar bar2;
        private DevExpress.XtraBars.BarDockControl barDockControlTop;
        private DevExpress.XtraBars.BarDockControl barDockControlBottom;
        private DevExpress.XtraBars.BarDockControl barDockControlLeft;
        private DevExpress.XtraBars.BarDockControl barDockControlRight;
        private DevExpress.XtraGrid.GridControl groupsGrid;
        private DevExpress.XtraGrid.Views.Grid.GridView groupsGridView;
        private DevExpress.XtraLayout.LayoutControlItem gridControl;
        private DevExpress.XtraEditors.Repository.RepositoryItemSearchLookUpEdit repositoryItemSearchLookUpEdit1;
        private DevExpress.XtraGrid.Views.Grid.GridView repositoryItemSearchLookUpEdit1View;
        private DevExpress.XtraEditors.SearchControl groupSearchControl;
        private DevExpress.XtraBars.BarCheckItem searchCheckBtn;
        private DevExpress.XtraLayout.LayoutControlItem searchControl;
        private DevExpress.XtraBars.BarButtonItem barButtonItem1;
    }
}
