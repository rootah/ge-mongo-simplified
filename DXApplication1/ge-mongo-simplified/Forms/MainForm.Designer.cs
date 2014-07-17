namespace ge_mongo_simplified.Forms
{
    partial class MainForm
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.defaultLook = new DevExpress.LookAndFeel.DefaultLookAndFeel(this.components);
            this.ribbonControl = new DevExpress.XtraBars.Ribbon.RibbonControl();
            this.backstageView = new DevExpress.XtraBars.Ribbon.BackstageViewControl();
            this.backstageViewClientControl1 = new DevExpress.XtraBars.Ribbon.BackstageViewClientControl();
            this.backstageViewClientControl2 = new DevExpress.XtraBars.Ribbon.BackstageViewClientControl();
            this.backstagePrintTab = new DevExpress.XtraBars.Ribbon.BackstageViewTabItem();
            this.backstageSettingsTab = new DevExpress.XtraBars.Ribbon.BackstageViewTabItem();
            this.backstageViewItemSeparator1 = new DevExpress.XtraBars.Ribbon.BackstageViewItemSeparator();
            this.backstageExitButton = new DevExpress.XtraBars.Ribbon.BackstageViewButtonItem();
            this.newDropButton = new DevExpress.XtraBars.BarButtonItem();
            this.newPopup = new DevExpress.XtraBars.PopupMenu(this.components);
            this.newGroupButton = new DevExpress.XtraBars.BarButtonItem();
            this.newStudentButton = new DevExpress.XtraBars.BarButtonItem();
            this.editButton = new DevExpress.XtraBars.BarButtonItem();
            this.delButton = new DevExpress.XtraBars.BarButtonItem();
            this.filterDropButton = new DevExpress.XtraBars.BarButtonItem();
            this.filterPopup = new DevExpress.XtraBars.PopupMenu(this.components);
            this.barButtonItem5 = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonItem6 = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonItem7 = new DevExpress.XtraBars.BarButtonItem();
            this.groupsCheckButton = new DevExpress.XtraBars.BarButtonItem();
            this.detailsCheckButton = new DevExpress.XtraBars.BarButtonItem();
            this.ribbonPageCategory1 = new DevExpress.XtraBars.Ribbon.RibbonPageCategory();
            this.studentsRibbonPage = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.ribbonPageGroup1 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonPageGroup3 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonPageGroup2 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.paymentsRibbonPage = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.scheduleRibbonPage = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.repositoryItemRadioGroup1 = new DevExpress.XtraEditors.Repository.RepositoryItemRadioGroup();
            this.ribbonStatusBar1 = new DevExpress.XtraBars.Ribbon.RibbonStatusBar();
            this.xtraTabControl = new DevExpress.XtraTab.XtraTabControl();
            this.studentsTab = new DevExpress.XtraTab.XtraTabPage();
            this.splitContainerControl1 = new DevExpress.XtraEditors.SplitContainerControl();
            this.groupsGridControl = new DevExpress.XtraGrid.GridControl();
            this.groupsGridView = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.splitContainerControl2 = new DevExpress.XtraEditors.SplitContainerControl();
            this.studentsGridControl = new DevExpress.XtraGrid.GridControl();
            this.studentsGridView = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.detailsGridControl = new DevExpress.XtraGrid.GridControl();
            this.detailsGridView = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.paymentsTab = new DevExpress.XtraTab.XtraTabPage();
            this.scheduleTab = new DevExpress.XtraTab.XtraTabPage();
            ((System.ComponentModel.ISupportInitialize)(this.ribbonControl)).BeginInit();
            this.backstageView.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.newPopup)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.filterPopup)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemRadioGroup1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.xtraTabControl)).BeginInit();
            this.xtraTabControl.SuspendLayout();
            this.studentsTab.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerControl1)).BeginInit();
            this.splitContainerControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.groupsGridControl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupsGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerControl2)).BeginInit();
            this.splitContainerControl2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.studentsGridControl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.studentsGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.detailsGridControl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.detailsGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // defaultLook
            // 
            this.defaultLook.LookAndFeel.SkinName = "Office 2013 Dark Gray";
            // 
            // ribbonControl
            // 
            this.ribbonControl.ApplicationButtonDropDownControl = this.backstageView;
            this.ribbonControl.ExpandCollapseItem.Id = 0;
            this.ribbonControl.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.ribbonControl.ExpandCollapseItem,
            this.newDropButton,
            this.editButton,
            this.delButton,
            this.filterDropButton,
            this.barButtonItem5,
            this.barButtonItem6,
            this.barButtonItem7,
            this.groupsCheckButton,
            this.detailsCheckButton,
            this.newGroupButton,
            this.newStudentButton});
            this.ribbonControl.ItemsVertAlign = DevExpress.Utils.VertAlignment.Top;
            this.ribbonControl.Location = new System.Drawing.Point(0, 0);
            this.ribbonControl.MaxItemId = 14;
            this.ribbonControl.Name = "ribbonControl";
            this.ribbonControl.PageCategories.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageCategory[] {
            this.ribbonPageCategory1});
            this.ribbonControl.PageCategoryAlignment = DevExpress.XtraBars.Ribbon.RibbonPageCategoryAlignment.Right;
            this.ribbonControl.Pages.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPage[] {
            this.studentsRibbonPage,
            this.paymentsRibbonPage,
            this.scheduleRibbonPage});
            this.ribbonControl.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.repositoryItemRadioGroup1});
            this.ribbonControl.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonControlStyle.Office2013;
            this.ribbonControl.ShowFullScreenButton = DevExpress.Utils.DefaultBoolean.False;
            this.ribbonControl.ShowToolbarCustomizeItem = false;
            this.ribbonControl.Size = new System.Drawing.Size(1128, 147);
            this.ribbonControl.StatusBar = this.ribbonStatusBar1;
            this.ribbonControl.Toolbar.ShowCustomizeItem = false;
            this.ribbonControl.SelectedPageChanged += new System.EventHandler(this.ribbonControl_SelectedPageChanged);// 
            // backstageView
            // 
            this.backstageView.ColorScheme = DevExpress.XtraBars.Ribbon.RibbonControlColorScheme.Yellow;
            this.backstageView.Controls.Add(this.backstageViewClientControl1);
            this.backstageView.Controls.Add(this.backstageViewClientControl2);
            this.backstageView.Items.Add(this.backstagePrintTab);
            this.backstageView.Items.Add(this.backstageSettingsTab);
            this.backstageView.Items.Add(this.backstageViewItemSeparator1);
            this.backstageView.Items.Add(this.backstageExitButton);
            this.backstageView.Location = new System.Drawing.Point(718, 57);
            this.backstageView.Name = "backstageView";
            this.backstageView.Ribbon = this.ribbonControl;
            this.backstageView.SelectedTab = null;
            this.backstageView.Size = new System.Drawing.Size(398, 77);
            this.backstageView.TabIndex = 1;
            // 
            // backstageViewClientControl1
            // 
            this.backstageViewClientControl1.Location = new System.Drawing.Point(138, 63);
            this.backstageViewClientControl1.Name = "backstageViewClientControl1";
            this.backstageViewClientControl1.Size = new System.Drawing.Size(259, 13);
            this.backstageViewClientControl1.TabIndex = 1;
            // 
            // backstageViewClientControl2
            // 
            this.backstageViewClientControl2.Location = new System.Drawing.Point(138, 63);
            this.backstageViewClientControl2.Name = "backstageViewClientControl2";
            this.backstageViewClientControl2.Size = new System.Drawing.Size(259, 13);
            this.backstageViewClientControl2.TabIndex = 2;
            // 
            // backstagePrintTab
            // 
            this.backstagePrintTab.AllowGlyphSkinning = DevExpress.Utils.DefaultBoolean.True;
            this.backstagePrintTab.Caption = "Print";
            this.backstagePrintTab.CaptionHorizontalAlignment = DevExpress.Utils.Drawing.ItemHorizontalAlignment.Right;
            this.backstagePrintTab.ContentControl = this.backstageViewClientControl1;
            this.backstagePrintTab.Glyph = ((System.Drawing.Image)(resources.GetObject("backstagePrintTab.Glyph")));
            this.backstagePrintTab.Name = "backstagePrintTab";
            this.backstagePrintTab.Selected = false;
            // 
            // backstageSettingsTab
            // 
            this.backstageSettingsTab.AllowGlyphSkinning = DevExpress.Utils.DefaultBoolean.True;
            this.backstageSettingsTab.Caption = "Settings";
            this.backstageSettingsTab.CaptionHorizontalAlignment = DevExpress.Utils.Drawing.ItemHorizontalAlignment.Right;
            this.backstageSettingsTab.ContentControl = this.backstageViewClientControl2;
            this.backstageSettingsTab.Glyph = ((System.Drawing.Image)(resources.GetObject("backstageSettingsTab.Glyph")));
            this.backstageSettingsTab.Name = "backstageSettingsTab";
            this.backstageSettingsTab.Selected = false;
            // 
            // backstageViewItemSeparator1
            // 
            this.backstageViewItemSeparator1.Name = "backstageViewItemSeparator1";
            // 
            // backstageExitButton
            // 
            this.backstageExitButton.AllowGlyphSkinning = DevExpress.Utils.DefaultBoolean.True;
            this.backstageExitButton.Caption = "Exit";
            this.backstageExitButton.CaptionHorizontalAlignment = DevExpress.Utils.Drawing.ItemHorizontalAlignment.Right;
            this.backstageExitButton.Glyph = ((System.Drawing.Image)(resources.GetObject("backstageExitButton.Glyph")));
            this.backstageExitButton.Name = "backstageExitButton";
            this.backstageExitButton.ItemClick += new DevExpress.XtraBars.Ribbon.BackstageViewItemEventHandler(this.backstageExitButton_ItemClick);
            // 
            // newDropButton
            // 
            this.newDropButton.ActAsDropDown = true;
            this.newDropButton.ButtonStyle = DevExpress.XtraBars.BarButtonStyle.DropDown;
            this.newDropButton.Caption = "New";
            this.newDropButton.DropDownControl = this.newPopup;
            this.newDropButton.Glyph = ((System.Drawing.Image)(resources.GetObject("newDropButton.Glyph")));
            this.newDropButton.Id = 1;
            this.newDropButton.LargeGlyph = ((System.Drawing.Image)(resources.GetObject("newDropButton.LargeGlyph")));
            this.newDropButton.Name = "newDropButton";
            // 
            // newPopup
            // 
            this.newPopup.ItemLinks.Add(this.newGroupButton);
            this.newPopup.ItemLinks.Add(this.newStudentButton);
            this.newPopup.Name = "newPopup";
            this.newPopup.Ribbon = this.ribbonControl;
            // 
            // newGroupButton
            // 
            this.newGroupButton.Caption = "Group";
            this.newGroupButton.Id = 12;
            this.newGroupButton.Name = "newGroupButton";
            this.newGroupButton.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.newGroupButton_ItemClick);
            // 
            // newStudentButton
            // 
            this.newStudentButton.Caption = "Student";
            this.newStudentButton.Id = 13;
            this.newStudentButton.Name = "newStudentButton";
            this.newStudentButton.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.newStudentButton_ItemClick);
            // 
            // editButton
            // 
            this.editButton.Caption = "edit";
            this.editButton.Glyph = ((System.Drawing.Image)(resources.GetObject("editButton.Glyph")));
            this.editButton.Id = 2;
            this.editButton.LargeGlyph = ((System.Drawing.Image)(resources.GetObject("editButton.LargeGlyph")));
            this.editButton.Name = "editButton";
            this.editButton.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.SmallWithText;
            this.editButton.SmallWithTextWidth = 65;
            // 
            // delButton
            // 
            this.delButton.Caption = "delete";
            this.delButton.Glyph = ((System.Drawing.Image)(resources.GetObject("delButton.Glyph")));
            this.delButton.Id = 3;
            this.delButton.LargeGlyph = ((System.Drawing.Image)(resources.GetObject("delButton.LargeGlyph")));
            this.delButton.Name = "delButton";
            this.delButton.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.SmallWithText;
            this.delButton.SmallWithTextWidth = 65;
            // 
            // filterDropButton
            // 
            this.filterDropButton.ActAsDropDown = true;
            this.filterDropButton.ButtonStyle = DevExpress.XtraBars.BarButtonStyle.DropDown;
            this.filterDropButton.Caption = "Filter";
            this.filterDropButton.DropDownControl = this.filterPopup;
            this.filterDropButton.Glyph = ((System.Drawing.Image)(resources.GetObject("filterDropButton.Glyph")));
            this.filterDropButton.Id = 5;
            this.filterDropButton.Name = "filterDropButton";
            this.filterDropButton.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large;
            this.filterDropButton.Visibility = DevExpress.XtraBars.BarItemVisibility.Never;
            // 
            // filterPopup
            // 
            this.filterPopup.ItemLinks.Add(this.barButtonItem5);
            this.filterPopup.ItemLinks.Add(this.barButtonItem6);
            this.filterPopup.ItemLinks.Add(this.barButtonItem7);
            this.filterPopup.Name = "filterPopup";
            this.filterPopup.Ribbon = this.ribbonControl;
            // 
            // barButtonItem5
            // 
            this.barButtonItem5.ButtonStyle = DevExpress.XtraBars.BarButtonStyle.Check;
            this.barButtonItem5.Caption = "one";
            this.barButtonItem5.GroupIndex = 1;
            this.barButtonItem5.Id = 7;
            this.barButtonItem5.Name = "barButtonItem5";
            // 
            // barButtonItem6
            // 
            this.barButtonItem6.ButtonStyle = DevExpress.XtraBars.BarButtonStyle.Check;
            this.barButtonItem6.Caption = "two";
            this.barButtonItem6.GroupIndex = 1;
            this.barButtonItem6.Id = 8;
            this.barButtonItem6.Name = "barButtonItem6";
            // 
            // barButtonItem7
            // 
            this.barButtonItem7.ButtonStyle = DevExpress.XtraBars.BarButtonStyle.Check;
            this.barButtonItem7.Caption = "three";
            this.barButtonItem7.GroupIndex = 1;
            this.barButtonItem7.Id = 9;
            this.barButtonItem7.Name = "barButtonItem7";
            // 
            // groupsCheckButton
            // 
            this.groupsCheckButton.ButtonStyle = DevExpress.XtraBars.BarButtonStyle.Check;
            this.groupsCheckButton.Caption = "groups";
            this.groupsCheckButton.Down = true;
            this.groupsCheckButton.Glyph = ((System.Drawing.Image)(resources.GetObject("groupsCheckButton.Glyph")));
            this.groupsCheckButton.Id = 10;
            this.groupsCheckButton.LargeGlyph = ((System.Drawing.Image)(resources.GetObject("groupsCheckButton.LargeGlyph")));
            this.groupsCheckButton.Name = "groupsCheckButton";
            this.groupsCheckButton.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.SmallWithText;
            this.groupsCheckButton.SmallWithTextWidth = 65;
            this.groupsCheckButton.DownChanged += new DevExpress.XtraBars.ItemClickEventHandler(this.barButtonItem8_DownChanged);
            // 
            // detailsCheckButton
            // 
            this.detailsCheckButton.ButtonStyle = DevExpress.XtraBars.BarButtonStyle.Check;
            this.detailsCheckButton.Caption = "details";
            this.detailsCheckButton.Down = true;
            this.detailsCheckButton.Glyph = ((System.Drawing.Image)(resources.GetObject("detailsCheckButton.Glyph")));
            this.detailsCheckButton.Id = 11;
            this.detailsCheckButton.LargeGlyph = ((System.Drawing.Image)(resources.GetObject("detailsCheckButton.LargeGlyph")));
            this.detailsCheckButton.Name = "detailsCheckButton";
            this.detailsCheckButton.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.SmallWithText;
            this.detailsCheckButton.SmallWithTextWidth = 65;
            this.detailsCheckButton.DownChanged += new DevExpress.XtraBars.ItemClickEventHandler(this.barButtonItem9_DownChanged);
            // 
            // ribbonPageCategory1
            // 
            this.ribbonPageCategory1.AutoStretchPageHeaders = true;
            this.ribbonPageCategory1.Color = System.Drawing.SystemColors.Highlight;
            this.ribbonPageCategory1.Name = "ribbonPageCategory1";
            this.ribbonPageCategory1.Text = "Journal";
            // 
            // studentsRibbonPage
            // 
            this.studentsRibbonPage.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] {
            this.ribbonPageGroup1,
            this.ribbonPageGroup3,
            this.ribbonPageGroup2});
            this.studentsRibbonPage.Name = "studentsRibbonPage";
            this.studentsRibbonPage.Text = "Students";
            // 
            // ribbonPageGroup1
            // 
            this.ribbonPageGroup1.ItemLinks.Add(this.newDropButton);
            this.ribbonPageGroup1.ItemLinks.Add(this.editButton);
            this.ribbonPageGroup1.ItemLinks.Add(this.delButton);
            this.ribbonPageGroup1.Name = "ribbonPageGroup1";
            this.ribbonPageGroup1.ShowCaptionButton = false;
            this.ribbonPageGroup1.Text = "file";
            // 
            // ribbonPageGroup3
            // 
            this.ribbonPageGroup3.Name = "ribbonPageGroup3";
            this.ribbonPageGroup3.ShowCaptionButton = false;
            this.ribbonPageGroup3.Text = "action";
            this.ribbonPageGroup3.Visible = false;
            // 
            // ribbonPageGroup2
            // 
            this.ribbonPageGroup2.ItemLinks.Add(this.filterDropButton);
            this.ribbonPageGroup2.ItemLinks.Add(this.groupsCheckButton, true);
            this.ribbonPageGroup2.ItemLinks.Add(this.detailsCheckButton);
            this.ribbonPageGroup2.Name = "ribbonPageGroup2";
            this.ribbonPageGroup2.ShowCaptionButton = false;
            this.ribbonPageGroup2.Text = "view";
            // 
            // paymentsRibbonPage
            // 
            this.paymentsRibbonPage.Name = "paymentsRibbonPage";
            this.paymentsRibbonPage.Text = "Payments";
            // 
            // scheduleRibbonPage
            // 
            this.scheduleRibbonPage.Name = "scheduleRibbonPage";
            this.scheduleRibbonPage.Text = "Schedule";
            // 
            // repositoryItemRadioGroup1
            // 
            this.repositoryItemRadioGroup1.Name = "repositoryItemRadioGroup1";
            // 
            // ribbonStatusBar1
            // 
            this.ribbonStatusBar1.Location = new System.Drawing.Point(0, 482);
            this.ribbonStatusBar1.Name = "ribbonStatusBar1";
            this.ribbonStatusBar1.Ribbon = this.ribbonControl;
            this.ribbonStatusBar1.Size = new System.Drawing.Size(1128, 27);
            // 
            // xtraTabControl
            // 
            this.xtraTabControl.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.xtraTabControl.BorderStylePage = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.xtraTabControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.xtraTabControl.Location = new System.Drawing.Point(0, 147);
            this.xtraTabControl.LookAndFeel.Style = DevExpress.LookAndFeel.LookAndFeelStyle.Flat;
            this.xtraTabControl.LookAndFeel.UseDefaultLookAndFeel = false;
            this.xtraTabControl.Margin = new System.Windows.Forms.Padding(3, 10, 3, 3);
            this.xtraTabControl.Name = "xtraTabControl";
            this.xtraTabControl.Padding = new System.Windows.Forms.Padding(0, 10, 0, 0);
            this.xtraTabControl.SelectedTabPage = this.studentsTab;
            this.xtraTabControl.Size = new System.Drawing.Size(1128, 335);
            this.xtraTabControl.TabIndex = 3;
            this.xtraTabControl.TabPages.AddRange(new DevExpress.XtraTab.XtraTabPage[] {
            this.studentsTab,
            this.paymentsTab,
            this.scheduleTab});
            // 
            // studentsTab
            // 
            this.studentsTab.Controls.Add(this.splitContainerControl1);
            this.studentsTab.Name = "studentsTab";
            this.studentsTab.Size = new System.Drawing.Size(1128, 313);
            this.studentsTab.Text = "students";
            // 
            // splitContainerControl1
            // 
            this.splitContainerControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainerControl1.Location = new System.Drawing.Point(0, 0);
            this.splitContainerControl1.Name = "splitContainerControl1";
            this.splitContainerControl1.Panel1.Controls.Add(this.groupsGridControl);
            this.splitContainerControl1.Panel1.Text = "Panel1";
            this.splitContainerControl1.Panel2.Controls.Add(this.splitContainerControl2);
            this.splitContainerControl1.Panel2.Text = "Panel2";
            this.splitContainerControl1.Size = new System.Drawing.Size(1128, 313);
            this.splitContainerControl1.SplitterPosition = 267;
            this.splitContainerControl1.TabIndex = 0;
            this.splitContainerControl1.Text = "splitContainerControl1";
            // 
            // groupsGridControl
            // 
            this.groupsGridControl.Cursor = System.Windows.Forms.Cursors.Default;
            this.groupsGridControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupsGridControl.Location = new System.Drawing.Point(0, 0);
            this.groupsGridControl.MainView = this.groupsGridView;
            this.groupsGridControl.MenuManager = this.ribbonControl;
            this.groupsGridControl.Name = "groupsGridControl";
            this.groupsGridControl.Size = new System.Drawing.Size(267, 313);
            this.groupsGridControl.TabIndex = 2;
            this.groupsGridControl.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.groupsGridView});
            // 
            // groupsGridView
            // 
            this.groupsGridView.Appearance.GroupPanel.Options.UseForeColor = true;
            this.groupsGridView.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.groupsGridView.GridControl = this.groupsGridControl;
            this.groupsGridView.GroupPanelText = "Groups";
            this.groupsGridView.Name = "groupsGridView";
            this.groupsGridView.OptionsCustomization.AllowGroup = false;
            this.groupsGridView.OptionsView.ShowColumnHeaders = false;
            this.groupsGridView.OptionsView.ShowIndicator = false;
            // 
            // splitContainerControl2
            // 
            this.splitContainerControl2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainerControl2.FixedPanel = DevExpress.XtraEditors.SplitFixedPanel.Panel2;
            this.splitContainerControl2.Location = new System.Drawing.Point(0, 0);
            this.splitContainerControl2.Name = "splitContainerControl2";
            this.splitContainerControl2.Panel1.CaptionLocation = DevExpress.Utils.Locations.Top;
            this.splitContainerControl2.Panel1.Controls.Add(this.studentsGridControl);
            this.splitContainerControl2.Panel1.ShowCaption = true;
            this.splitContainerControl2.Panel1.Text = "Panel1";
            this.splitContainerControl2.Panel2.Controls.Add(this.detailsGridControl);
            this.splitContainerControl2.Panel2.Text = "Panel2";
            this.splitContainerControl2.Size = new System.Drawing.Size(849, 313);
            this.splitContainerControl2.SplitterPosition = 265;
            this.splitContainerControl2.TabIndex = 0;
            this.splitContainerControl2.Text = "splitContainerControl2";
            // 
            // studentsGridControl
            // 
            this.studentsGridControl.Cursor = System.Windows.Forms.Cursors.Default;
            this.studentsGridControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.studentsGridControl.Location = new System.Drawing.Point(0, 0);
            this.studentsGridControl.MainView = this.studentsGridView;
            this.studentsGridControl.MenuManager = this.ribbonControl;
            this.studentsGridControl.Name = "studentsGridControl";
            this.studentsGridControl.Size = new System.Drawing.Size(572, 313);
            this.studentsGridControl.TabIndex = 0;
            this.studentsGridControl.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.studentsGridView});
            // 
            // studentsGridView
            // 
            this.studentsGridView.Appearance.GroupPanel.Options.UseForeColor = true;
            this.studentsGridView.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.studentsGridView.GridControl = this.studentsGridControl;
            this.studentsGridView.GroupPanelText = "Students";
            this.studentsGridView.Name = "studentsGridView";
            this.studentsGridView.OptionsCustomization.AllowGroup = false;
            this.studentsGridView.OptionsView.ShowColumnHeaders = false;
            this.studentsGridView.OptionsView.ShowGroupExpandCollapseButtons = false;
            this.studentsGridView.OptionsView.ShowIndicator = false;
            this.studentsGridView.ViewCaption = "Capt";
            // 
            // detailsGridControl
            // 
            this.detailsGridControl.Cursor = System.Windows.Forms.Cursors.Default;
            this.detailsGridControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.detailsGridControl.Location = new System.Drawing.Point(0, 0);
            this.detailsGridControl.MainView = this.detailsGridView;
            this.detailsGridControl.MenuManager = this.ribbonControl;
            this.detailsGridControl.Name = "detailsGridControl";
            this.detailsGridControl.Size = new System.Drawing.Size(265, 313);
            this.detailsGridControl.TabIndex = 1;
            this.detailsGridControl.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.detailsGridView});
            // 
            // detailsGridView
            // 
            this.detailsGridView.Appearance.GroupPanel.Options.UseForeColor = true;
            this.detailsGridView.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.detailsGridView.GridControl = this.detailsGridControl;
            this.detailsGridView.GroupPanelText = "Details";
            this.detailsGridView.Name = "detailsGridView";
            this.detailsGridView.OptionsCustomization.AllowGroup = false;
            this.detailsGridView.OptionsView.ShowColumnHeaders = false;
            this.detailsGridView.OptionsView.ShowIndicator = false;
            // 
            // paymentsTab
            // 
            this.paymentsTab.Name = "paymentsTab";
            this.paymentsTab.Size = new System.Drawing.Size(1128, 313);
            this.paymentsTab.Text = "payments";
            // 
            // scheduleTab
            // 
            this.scheduleTab.Name = "scheduleTab";
            this.scheduleTab.Size = new System.Drawing.Size(1128, 313);
            this.scheduleTab.Text = "schedule";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1128, 509);
            this.Controls.Add(this.backstageView);
            this.Controls.Add(this.xtraTabControl);
            this.Controls.Add(this.ribbonStatusBar1);
            this.Controls.Add(this.ribbonControl);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "MainForm";
            this.Ribbon = this.ribbonControl;
            this.StatusBar = this.ribbonStatusBar1;
            this.Text = "ge.base [ simplified - batman edition]";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ribbonControl)).EndInit();
            this.backstageView.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.newPopup)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.filterPopup)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemRadioGroup1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.xtraTabControl)).EndInit();
            this.xtraTabControl.ResumeLayout(false);
            this.studentsTab.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerControl1)).EndInit();
            this.splitContainerControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.groupsGridControl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupsGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerControl2)).EndInit();
            this.splitContainerControl2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.studentsGridControl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.studentsGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.detailsGridControl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.detailsGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.LookAndFeel.DefaultLookAndFeel defaultLook;
        private DevExpress.XtraBars.Ribbon.RibbonControl ribbonControl;
        private DevExpress.XtraBars.Ribbon.RibbonPage studentsRibbonPage;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup1;
        private DevExpress.XtraBars.Ribbon.BackstageViewControl backstageView;
        private DevExpress.XtraBars.Ribbon.BackstageViewItemSeparator backstageViewItemSeparator1;
        private DevExpress.XtraBars.Ribbon.RibbonStatusBar ribbonStatusBar1;
        private DevExpress.XtraBars.BarButtonItem newDropButton;
        private DevExpress.XtraBars.BarButtonItem editButton;
        private DevExpress.XtraBars.BarButtonItem delButton;
        private DevExpress.XtraBars.Ribbon.RibbonPage paymentsRibbonPage;
        private DevExpress.XtraBars.Ribbon.RibbonPage scheduleRibbonPage;
        private DevExpress.XtraTab.XtraTabControl xtraTabControl;
        private DevExpress.XtraTab.XtraTabPage studentsTab;
        private DevExpress.XtraTab.XtraTabPage paymentsTab;
        private DevExpress.XtraTab.XtraTabPage scheduleTab;
        private DevExpress.XtraBars.BarButtonItem filterDropButton;
        private DevExpress.XtraBars.PopupMenu filterPopup;
        private DevExpress.XtraEditors.Repository.RepositoryItemRadioGroup repositoryItemRadioGroup1;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup2;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup3;
        private DevExpress.XtraBars.BarButtonItem barButtonItem5;
        private DevExpress.XtraBars.BarButtonItem barButtonItem6;
        private DevExpress.XtraBars.BarButtonItem barButtonItem7;
        private DevExpress.XtraBars.BarButtonItem groupsCheckButton;
        private DevExpress.XtraBars.BarButtonItem detailsCheckButton;
        private DevExpress.XtraEditors.SplitContainerControl splitContainerControl1;
        private DevExpress.XtraEditors.SplitContainerControl splitContainerControl2;
        private DevExpress.XtraGrid.GridControl studentsGridControl;
        private DevExpress.XtraGrid.Views.Grid.GridView studentsGridView;
        private DevExpress.XtraGrid.GridControl detailsGridControl;
        private DevExpress.XtraGrid.Views.Grid.GridView detailsGridView;
        private DevExpress.XtraGrid.GridControl groupsGridControl;
        private DevExpress.XtraGrid.Views.Grid.GridView groupsGridView;
        private DevExpress.XtraBars.Ribbon.RibbonPageCategory ribbonPageCategory1;
        private DevExpress.XtraBars.PopupMenu newPopup;
        private DevExpress.XtraBars.BarButtonItem newGroupButton;
        private DevExpress.XtraBars.BarButtonItem newStudentButton;
        private DevExpress.XtraBars.Ribbon.BackstageViewButtonItem backstageExitButton;
        private DevExpress.XtraBars.Ribbon.BackstageViewClientControl backstageViewClientControl1;
        private DevExpress.XtraBars.Ribbon.BackstageViewClientControl backstageViewClientControl2;
        private DevExpress.XtraBars.Ribbon.BackstageViewTabItem backstagePrintTab;
        private DevExpress.XtraBars.Ribbon.BackstageViewTabItem backstageSettingsTab;

    }
}

