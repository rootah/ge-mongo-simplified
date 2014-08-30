namespace ge_mongo_simplified.UserControls
{
    partial class StudentsGridUC
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
            this.layoutControl1 = new DevExpress.XtraLayout.LayoutControl();
            this.studentsGrid = new DevExpress.XtraGrid.GridControl();
            this.studentsGridView = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.barManager1 = new DevExpress.XtraBars.BarManager();
            this.bar2 = new DevExpress.XtraBars.Bar();
            this.searchCheckBtn = new DevExpress.XtraBars.BarCheckItem();
            this.standaloneBarDockControl1 = new DevExpress.XtraBars.StandaloneBarDockControl();
            this.barDockControlTop = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlBottom = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlLeft = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlRight = new DevExpress.XtraBars.BarDockControl();
            this.studentSearchControl = new DevExpress.XtraEditors.SearchControl();
            this.layoutControlGroup1 = new DevExpress.XtraLayout.LayoutControlGroup();
            this.simpleLabelItem1 = new DevExpress.XtraLayout.SimpleLabelItem();
            this.layoutControlItem1 = new DevExpress.XtraLayout.LayoutControlItem();
            this.searchControl = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem3 = new DevExpress.XtraLayout.LayoutControlItem();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).BeginInit();
            this.layoutControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.studentsGrid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.studentsGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.studentSearchControl.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.simpleLabelItem1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.searchControl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem3)).BeginInit();
            this.SuspendLayout();
            // 
            // layoutControl1
            // 
            this.layoutControl1.Controls.Add(this.studentsGrid);
            this.layoutControl1.Controls.Add(this.studentSearchControl);
            this.layoutControl1.Controls.Add(this.standaloneBarDockControl1);
            this.layoutControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.layoutControl1.Location = new System.Drawing.Point(0, 0);
            this.layoutControl1.Name = "layoutControl1";
            this.layoutControl1.OptionsCustomizationForm.DesignTimeCustomizationFormPositionAndSize = new System.Drawing.Rectangle(532, 148, 250, 350);
            this.layoutControl1.Root = this.layoutControlGroup1;
            this.layoutControl1.Size = new System.Drawing.Size(485, 377);
            this.layoutControl1.TabIndex = 0;
            this.layoutControl1.Text = "layoutControl1";
            // 
            // studentsGrid
            // 
            this.studentsGrid.Cursor = System.Windows.Forms.Cursors.Default;
            this.studentsGrid.Location = new System.Drawing.Point(2, 41);
            this.studentsGrid.MainView = this.studentsGridView;
            this.studentsGrid.MenuManager = this.barManager1;
            this.studentsGrid.Name = "studentsGrid";
            this.studentsGrid.Size = new System.Drawing.Size(481, 329);
            this.studentsGrid.TabIndex = 6;
            this.studentsGrid.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.studentsGridView});
            // 
            // studentsGridView
            // 
            this.studentsGridView.GridControl = this.studentsGrid;
            this.studentsGridView.Name = "studentsGridView";
            this.studentsGridView.OptionsView.ShowGroupPanel = false;
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
            this.searchCheckBtn});
            this.barManager1.MainMenu = this.bar2;
            this.barManager1.MaxItemId = 3;
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
            new DevExpress.XtraBars.LinkPersistInfo(this.searchCheckBtn)});
            this.bar2.OptionsBar.AllowQuickCustomization = false;
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
            this.searchCheckBtn.Id = 2;
            this.searchCheckBtn.Name = "searchCheckBtn";
            this.searchCheckBtn.CheckedChanged += new DevExpress.XtraBars.ItemClickEventHandler(this.searchCheckBtn_CheckedChanged);
            // 
            // standaloneBarDockControl1
            // 
            this.standaloneBarDockControl1.CausesValidation = false;
            this.standaloneBarDockControl1.Location = new System.Drawing.Point(77, 10);
            this.standaloneBarDockControl1.Name = "standaloneBarDockControl1";
            this.standaloneBarDockControl1.Size = new System.Drawing.Size(56, 24);
            this.standaloneBarDockControl1.Text = "standaloneBarDockControl1";
            // 
            // barDockControlTop
            // 
            this.barDockControlTop.CausesValidation = false;
            this.barDockControlTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.barDockControlTop.Location = new System.Drawing.Point(0, 0);
            this.barDockControlTop.Size = new System.Drawing.Size(485, 0);
            // 
            // barDockControlBottom
            // 
            this.barDockControlBottom.CausesValidation = false;
            this.barDockControlBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.barDockControlBottom.Location = new System.Drawing.Point(0, 377);
            this.barDockControlBottom.Size = new System.Drawing.Size(485, 0);
            // 
            // barDockControlLeft
            // 
            this.barDockControlLeft.CausesValidation = false;
            this.barDockControlLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.barDockControlLeft.Location = new System.Drawing.Point(0, 0);
            this.barDockControlLeft.Size = new System.Drawing.Size(0, 377);
            // 
            // barDockControlRight
            // 
            this.barDockControlRight.CausesValidation = false;
            this.barDockControlRight.Dock = System.Windows.Forms.DockStyle.Right;
            this.barDockControlRight.Location = new System.Drawing.Point(485, 0);
            this.barDockControlRight.Size = new System.Drawing.Size(0, 377);
            // 
            // studentSearchControl
            // 
            this.studentSearchControl.Location = new System.Drawing.Point(145, 12);
            this.studentSearchControl.MenuManager = this.barManager1;
            this.studentSearchControl.Name = "studentSearchControl";
            this.studentSearchControl.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Repository.ClearButton(),
            new DevExpress.XtraEditors.Repository.SearchButton()});
            this.studentSearchControl.Size = new System.Drawing.Size(338, 20);
            this.studentSearchControl.StyleController = this.layoutControl1;
            this.studentSearchControl.TabIndex = 5;
            // 
            // layoutControlGroup1
            // 
            this.layoutControlGroup1.AppearanceItemCaption.Font = new System.Drawing.Font("Segoe UI Semilight", 8.25F);
            this.layoutControlGroup1.AppearanceItemCaption.Options.UseFont = true;
            this.layoutControlGroup1.CustomizationFormText = "Root";
            this.layoutControlGroup1.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True;
            this.layoutControlGroup1.GroupBordersVisible = false;
            this.layoutControlGroup1.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.simpleLabelItem1,
            this.layoutControlItem1,
            this.searchControl,
            this.layoutControlItem3});
            this.layoutControlGroup1.Location = new System.Drawing.Point(0, 0);
            this.layoutControlGroup1.Name = "Root";
            this.layoutControlGroup1.Padding = new DevExpress.XtraLayout.Utils.Padding(0, 0, 5, 5);
            this.layoutControlGroup1.Size = new System.Drawing.Size(485, 377);
            this.layoutControlGroup1.Text = "Root";
            this.layoutControlGroup1.TextVisible = false;
            // 
            // simpleLabelItem1
            // 
            this.simpleLabelItem1.AllowHotTrack = false;
            this.simpleLabelItem1.AppearanceItemCaption.Font = new System.Drawing.Font("Segoe UI Semilight", 12.25F);
            this.simpleLabelItem1.AppearanceItemCaption.Options.UseFont = true;
            this.simpleLabelItem1.CustomizationFormText = "Students";
            this.simpleLabelItem1.Location = new System.Drawing.Point(0, 0);
            this.simpleLabelItem1.MaxSize = new System.Drawing.Size(75, 0);
            this.simpleLabelItem1.MinSize = new System.Drawing.Size(75, 34);
            this.simpleLabelItem1.Name = "simpleLabelItem1";
            this.simpleLabelItem1.Size = new System.Drawing.Size(75, 34);
            this.simpleLabelItem1.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom;
            this.simpleLabelItem1.Spacing = new DevExpress.XtraLayout.Utils.Padding(3, 0, 0, 5);
            this.simpleLabelItem1.Text = "Students";
            this.simpleLabelItem1.TextSize = new System.Drawing.Size(60, 21);
            // 
            // layoutControlItem1
            // 
            this.layoutControlItem1.Control = this.standaloneBarDockControl1;
            this.layoutControlItem1.ControlAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            this.layoutControlItem1.CustomizationFormText = "layoutControlItem1";
            this.layoutControlItem1.FillControlToClientArea = false;
            this.layoutControlItem1.Location = new System.Drawing.Point(75, 0);
            this.layoutControlItem1.MaxSize = new System.Drawing.Size(65, 0);
            this.layoutControlItem1.MinSize = new System.Drawing.Size(60, 26);
            this.layoutControlItem1.Name = "layoutControlItem1";
            this.layoutControlItem1.Size = new System.Drawing.Size(60, 34);
            this.layoutControlItem1.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom;
            this.layoutControlItem1.Text = "layoutControlItem1";
            this.layoutControlItem1.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem1.TextToControlDistance = 0;
            this.layoutControlItem1.TextVisible = false;
            this.layoutControlItem1.TrimClientAreaToControl = false;
            this.layoutControlItem1.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Never;
            // 
            // searchControl
            // 
            this.searchControl.Control = this.studentSearchControl;
            this.searchControl.ControlAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            this.searchControl.CustomizationFormText = "searchControl";
            this.searchControl.FillControlToClientArea = false;
            this.searchControl.Location = new System.Drawing.Point(135, 0);
            this.searchControl.Name = "searchControl";
            this.searchControl.Padding = new DevExpress.XtraLayout.Utils.Padding(10, 2, 2, 2);
            this.searchControl.Size = new System.Drawing.Size(350, 34);
            this.searchControl.Text = "searchControl";
            this.searchControl.TextSize = new System.Drawing.Size(0, 0);
            this.searchControl.TextToControlDistance = 0;
            this.searchControl.TextVisible = false;
            this.searchControl.TrimClientAreaToControl = false;
            this.searchControl.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Never;
            // 
            // layoutControlItem3
            // 
            this.layoutControlItem3.Control = this.studentsGrid;
            this.layoutControlItem3.CustomizationFormText = "layoutControlItem3";
            this.layoutControlItem3.Location = new System.Drawing.Point(0, 34);
            this.layoutControlItem3.Name = "layoutControlItem3";
            this.layoutControlItem3.Size = new System.Drawing.Size(485, 333);
            this.layoutControlItem3.Text = "layoutControlItem3";
            this.layoutControlItem3.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem3.TextToControlDistance = 0;
            this.layoutControlItem3.TextVisible = false;
            // 
            // StudetsGridUC
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.layoutControl1);
            this.Controls.Add(this.barDockControlLeft);
            this.Controls.Add(this.barDockControlRight);
            this.Controls.Add(this.barDockControlBottom);
            this.Controls.Add(this.barDockControlTop);
            this.Name = "StudetsGridUC";
            this.Size = new System.Drawing.Size(485, 377);
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).EndInit();
            this.layoutControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.studentsGrid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.studentsGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.studentSearchControl.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.simpleLabelItem1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.searchControl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem3)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraLayout.LayoutControl layoutControl1;
        private DevExpress.XtraLayout.LayoutControlGroup layoutControlGroup1;
        private DevExpress.XtraLayout.SimpleLabelItem simpleLabelItem1;
        private DevExpress.XtraBars.StandaloneBarDockControl standaloneBarDockControl1;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem1;
        private DevExpress.XtraBars.BarManager barManager1;
        private DevExpress.XtraBars.Bar bar2;
        private DevExpress.XtraBars.BarDockControl barDockControlTop;
        private DevExpress.XtraBars.BarDockControl barDockControlBottom;
        private DevExpress.XtraBars.BarDockControl barDockControlLeft;
        private DevExpress.XtraBars.BarDockControl barDockControlRight;
        private DevExpress.XtraBars.BarCheckItem searchCheckBtn;
        private DevExpress.XtraEditors.SearchControl studentSearchControl;
        private DevExpress.XtraLayout.LayoutControlItem searchControl;
        private DevExpress.XtraGrid.GridControl studentsGrid;
        private DevExpress.XtraGrid.Views.Grid.GridView studentsGridView;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem3;
    }
}
