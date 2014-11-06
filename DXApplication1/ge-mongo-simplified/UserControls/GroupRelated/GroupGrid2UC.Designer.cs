namespace ge_mongo_simplified.UserControls
{
    partial class GroupGrid2UC
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
            this.layoutControl1 = new DevExpress.XtraLayout.LayoutControl();
            this.groupTL = new DevExpress.XtraTreeList.TreeList();
            this.colNum = new DevExpress.XtraTreeList.Columns.TreeListColumn();
            this.colID = new DevExpress.XtraTreeList.Columns.TreeListColumn();
            this.layoutControlGroup1 = new DevExpress.XtraLayout.LayoutControlGroup();
            this.simpleLabelItem1 = new DevExpress.XtraLayout.SimpleLabelItem();
            this.layoutControlItem1 = new DevExpress.XtraLayout.LayoutControlItem();
            this.groupGridBM = new DevExpress.XtraBars.BarManager(this.components);
            this.barDockControlTop = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlBottom = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlLeft = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlRight = new DevExpress.XtraBars.BarDockControl();
            this.barHeaderItem1 = new DevExpress.XtraBars.BarHeaderItem();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).BeginInit();
            this.layoutControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.groupTL)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.simpleLabelItem1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupGridBM)).BeginInit();
            this.SuspendLayout();
            // 
            // layoutControl1
            // 
            this.layoutControl1.Controls.Add(this.groupTL);
            this.layoutControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.layoutControl1.Location = new System.Drawing.Point(0, 0);
            this.layoutControl1.Name = "layoutControl1";
            this.layoutControl1.OptionsCustomizationForm.DesignTimeCustomizationFormPositionAndSize = new System.Drawing.Rectangle(1110, 148, 250, 350);
            this.layoutControl1.Root = this.layoutControlGroup1;
            this.layoutControl1.Size = new System.Drawing.Size(235, 327);
            this.layoutControl1.TabIndex = 0;
            this.layoutControl1.Text = "layoutControl1";
            // 
            // groupTL
            // 
            this.groupTL.Columns.AddRange(new DevExpress.XtraTreeList.Columns.TreeListColumn[] {
            this.colNum,
            this.colID});
            this.groupTL.Font = new System.Drawing.Font("Segoe UI", 8.25F);
            this.groupTL.Location = new System.Drawing.Point(2, 39);
            this.groupTL.Name = "groupTL";
            this.groupTL.OptionsBehavior.Editable = false;
            this.groupTL.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.groupTL.OptionsView.ShowColumns = false;
            this.groupTL.OptionsView.ShowFocusedFrame = false;
            this.groupTL.OptionsView.ShowHorzLines = false;
            this.groupTL.OptionsView.ShowIndentAsRowStyle = true;
            this.groupTL.OptionsView.ShowIndicator = false;
            this.groupTL.OptionsView.ShowVertLines = false;
            this.groupTL.Size = new System.Drawing.Size(231, 281);
            this.groupTL.TabIndex = 4;
            this.groupTL.FocusedNodeChanged += new DevExpress.XtraTreeList.FocusedNodeChangedEventHandler(this.groupTL_FocusedNodeChanged);
            this.groupTL.PopupMenuShowing += new DevExpress.XtraTreeList.PopupMenuShowingEventHandler(this.groupTL_PopupMenuShowing);
            this.groupTL.DoubleClick += new System.EventHandler(this.groupTL_DoubleClick);
            // 
            // colNum
            // 
            this.colNum.Caption = "colNum";
            this.colNum.FieldName = "colNumField";
            this.colNum.MinWidth = 52;
            this.colNum.Name = "colNum";
            this.colNum.UnboundType = DevExpress.XtraTreeList.Data.UnboundColumnType.String;
            this.colNum.Visible = true;
            this.colNum.VisibleIndex = 0;
            // 
            // colID
            // 
            this.colID.Caption = "colID";
            this.colID.FieldName = "colIDField";
            this.colID.Name = "colID";
            this.colID.UnboundType = DevExpress.XtraTreeList.Data.UnboundColumnType.String;
            // 
            // layoutControlGroup1
            // 
            this.layoutControlGroup1.CustomizationFormText = "Root";
            this.layoutControlGroup1.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True;
            this.layoutControlGroup1.GroupBordersVisible = false;
            this.layoutControlGroup1.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.simpleLabelItem1,
            this.layoutControlItem1});
            this.layoutControlGroup1.Location = new System.Drawing.Point(0, 0);
            this.layoutControlGroup1.Name = "Root";
            this.layoutControlGroup1.Padding = new DevExpress.XtraLayout.Utils.Padding(0, 0, 5, 5);
            this.layoutControlGroup1.Size = new System.Drawing.Size(235, 327);
            this.layoutControlGroup1.Text = "Root";
            this.layoutControlGroup1.TextVisible = false;
            // 
            // simpleLabelItem1
            // 
            this.simpleLabelItem1.AllowHotTrack = false;
            this.simpleLabelItem1.AppearanceItemCaption.Font = new System.Drawing.Font("Segoe UI", 12.25F);
            this.simpleLabelItem1.AppearanceItemCaption.Options.UseFont = true;
            this.simpleLabelItem1.CustomizationFormText = "Groups";
            this.simpleLabelItem1.Location = new System.Drawing.Point(0, 0);
            this.simpleLabelItem1.MinSize = new System.Drawing.Size(57, 30);
            this.simpleLabelItem1.Name = "simpleLabelItem1";
            this.simpleLabelItem1.Size = new System.Drawing.Size(235, 32);
            this.simpleLabelItem1.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom;
            this.simpleLabelItem1.Spacing = new DevExpress.XtraLayout.Utils.Padding(3, 0, 0, 5);
            this.simpleLabelItem1.Text = "Groups";
            this.simpleLabelItem1.TextSize = new System.Drawing.Size(51, 21);
            // 
            // layoutControlItem1
            // 
            this.layoutControlItem1.Control = this.groupTL;
            this.layoutControlItem1.CustomizationFormText = "layoutControlItem1";
            this.layoutControlItem1.Location = new System.Drawing.Point(0, 32);
            this.layoutControlItem1.Name = "layoutControlItem1";
            this.layoutControlItem1.Size = new System.Drawing.Size(235, 285);
            this.layoutControlItem1.Text = "layoutControlItem1";
            this.layoutControlItem1.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem1.TextToControlDistance = 0;
            this.layoutControlItem1.TextVisible = false;
            // 
            // groupGridBM
            // 
            this.groupGridBM.DockControls.Add(this.barDockControlTop);
            this.groupGridBM.DockControls.Add(this.barDockControlBottom);
            this.groupGridBM.DockControls.Add(this.barDockControlLeft);
            this.groupGridBM.DockControls.Add(this.barDockControlRight);
            this.groupGridBM.Form = this;
            this.groupGridBM.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.barHeaderItem1});
            this.groupGridBM.MaxItemId = 1;
            // 
            // barDockControlTop
            // 
            this.barDockControlTop.CausesValidation = false;
            this.barDockControlTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.barDockControlTop.Location = new System.Drawing.Point(0, 0);
            this.barDockControlTop.Size = new System.Drawing.Size(235, 0);
            // 
            // barDockControlBottom
            // 
            this.barDockControlBottom.CausesValidation = false;
            this.barDockControlBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.barDockControlBottom.Location = new System.Drawing.Point(0, 327);
            this.barDockControlBottom.Size = new System.Drawing.Size(235, 0);
            // 
            // barDockControlLeft
            // 
            this.barDockControlLeft.CausesValidation = false;
            this.barDockControlLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.barDockControlLeft.Location = new System.Drawing.Point(0, 0);
            this.barDockControlLeft.Size = new System.Drawing.Size(0, 327);
            // 
            // barDockControlRight
            // 
            this.barDockControlRight.CausesValidation = false;
            this.barDockControlRight.Dock = System.Windows.Forms.DockStyle.Right;
            this.barDockControlRight.Location = new System.Drawing.Point(235, 0);
            this.barDockControlRight.Size = new System.Drawing.Size(0, 327);
            // 
            // barHeaderItem1
            // 
            this.barHeaderItem1.Caption = "...";
            this.barHeaderItem1.Id = 0;
            this.barHeaderItem1.Name = "barHeaderItem1";
            // 
            // GroupGrid2UC
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.layoutControl1);
            this.Controls.Add(this.barDockControlLeft);
            this.Controls.Add(this.barDockControlRight);
            this.Controls.Add(this.barDockControlBottom);
            this.Controls.Add(this.barDockControlTop);
            this.Name = "GroupGrid2UC";
            this.Size = new System.Drawing.Size(235, 327);
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).EndInit();
            this.layoutControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.groupTL)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.simpleLabelItem1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupGridBM)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraLayout.LayoutControl layoutControl1;
        private DevExpress.XtraLayout.LayoutControlGroup layoutControlGroup1;
        private DevExpress.XtraLayout.SimpleLabelItem simpleLabelItem1;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem1;
        public DevExpress.XtraTreeList.TreeList groupTL;
        public DevExpress.XtraTreeList.Columns.TreeListColumn colID;
        public DevExpress.XtraTreeList.Columns.TreeListColumn colNum;
        private DevExpress.XtraBars.BarManager groupGridBM;
        private DevExpress.XtraBars.BarDockControl barDockControlTop;
        private DevExpress.XtraBars.BarDockControl barDockControlBottom;
        private DevExpress.XtraBars.BarDockControl barDockControlLeft;
        private DevExpress.XtraBars.BarDockControl barDockControlRight;
        private DevExpress.XtraBars.BarHeaderItem barHeaderItem1;
    }
}
