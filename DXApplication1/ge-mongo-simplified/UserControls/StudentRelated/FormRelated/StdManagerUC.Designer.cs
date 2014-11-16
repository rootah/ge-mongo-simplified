namespace ge_mongo_simplified.UserControls.StudentRelated.FormRelated
{
    partial class StdManagerUC
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
            this.topLC = new DevExpress.XtraLayout.LayoutControl();
            this.underageCE = new DevExpress.XtraEditors.CheckEdit();
            this.pnameTE = new DevExpress.XtraEditors.TextEdit();
            this.lnameTE = new DevExpress.XtraEditors.TextEdit();
            this.fnameTE = new DevExpress.XtraEditors.TextEdit();
            this.layoutControlGroup1 = new DevExpress.XtraLayout.LayoutControlGroup();
            this.fnameCI = new DevExpress.XtraLayout.LayoutControlItem();
            this.lnameCI = new DevExpress.XtraLayout.LayoutControlItem();
            this.pnameCI = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem4 = new DevExpress.XtraLayout.LayoutControlItem();
            this.emptySpaceItem1 = new DevExpress.XtraLayout.EmptySpaceItem();
            this.studentTabbedView = new DevExpress.XtraBars.Docking2010.Views.Tabbed.TabbedView();
            this.documentGroup1 = new DevExpress.XtraBars.Docking2010.Views.Tabbed.DocumentGroup();
            this.contactsUCDocument = new DevExpress.XtraBars.Docking2010.Views.Tabbed.Document();
            this.orgUCDocument = new DevExpress.XtraBars.Docking2010.Views.Tabbed.Document();
            this.paymentsUCDocument = new DevExpress.XtraBars.Docking2010.Views.Tabbed.Document();
            this.studentsDM = new DevExpress.XtraBars.Docking2010.DocumentManager();
            this.buttonsLC = new DevExpress.XtraLayout.LayoutControl();
            this.okButt = new DevExpress.XtraEditors.SimpleButton();
            this.cancelButt = new DevExpress.XtraEditors.SimpleButton();
            this.buttonsCG = new DevExpress.XtraLayout.LayoutControlGroup();
            this.cancelCI = new DevExpress.XtraLayout.LayoutControlItem();
            this.okCI = new DevExpress.XtraLayout.LayoutControlItem();
            this.emptySpaceItem2 = new DevExpress.XtraLayout.EmptySpaceItem();
            ((System.ComponentModel.ISupportInitialize)(this.topLC)).BeginInit();
            this.topLC.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.underageCE.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pnameTE.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lnameTE.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fnameTE.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fnameCI)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lnameCI)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pnameCI)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.studentTabbedView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.documentGroup1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.contactsUCDocument)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.orgUCDocument)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.paymentsUCDocument)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.studentsDM)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.buttonsLC)).BeginInit();
            this.buttonsLC.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.buttonsCG)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cancelCI)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.okCI)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem2)).BeginInit();
            this.SuspendLayout();
            // 
            // topLC
            // 
            this.topLC.Controls.Add(this.underageCE);
            this.topLC.Controls.Add(this.pnameTE);
            this.topLC.Controls.Add(this.lnameTE);
            this.topLC.Controls.Add(this.fnameTE);
            this.topLC.Dock = System.Windows.Forms.DockStyle.Top;
            this.topLC.Location = new System.Drawing.Point(0, 0);
            this.topLC.Name = "topLC";
            this.topLC.OptionsCustomizationForm.DesignTimeCustomizationFormPositionAndSize = new System.Drawing.Rectangle(606, 179, 250, 350);
            this.topLC.Root = this.layoutControlGroup1;
            this.topLC.Size = new System.Drawing.Size(405, 115);
            this.topLC.TabIndex = 0;
            this.topLC.Text = "layoutControl1";
            // 
            // underageCE
            // 
            this.underageCE.Location = new System.Drawing.Point(322, 59);
            this.underageCE.Name = "underageCE";
            this.underageCE.Properties.AllowFocused = false;
            this.underageCE.Properties.Caption = "Underage";
            this.underageCE.Properties.CheckStyle = DevExpress.XtraEditors.Controls.CheckStyles.Radio;
            this.underageCE.Properties.GlyphAlignment = DevExpress.Utils.HorzAlignment.Far;
            this.underageCE.Size = new System.Drawing.Size(72, 19);
            this.underageCE.StyleController = this.topLC;
            this.underageCE.TabIndex = 2;
            this.underageCE.CheckedChanged += new System.EventHandler(this.underageCE_CheckedChanged);
            // 
            // pnameTE
            // 
            this.pnameTE.Location = new System.Drawing.Point(95, 82);
            this.pnameTE.Name = "pnameTE";
            this.pnameTE.Size = new System.Drawing.Size(299, 20);
            this.pnameTE.StyleController = this.topLC;
            this.pnameTE.TabIndex = 3;
            // 
            // lnameTE
            // 
            this.lnameTE.Location = new System.Drawing.Point(95, 35);
            this.lnameTE.Name = "lnameTE";
            this.lnameTE.Size = new System.Drawing.Size(299, 20);
            this.lnameTE.StyleController = this.topLC;
            this.lnameTE.TabIndex = 1;
            // 
            // fnameTE
            // 
            this.fnameTE.EnterMoveNextControl = true;
            this.fnameTE.Location = new System.Drawing.Point(95, 11);
            this.fnameTE.Name = "fnameTE";
            this.fnameTE.Size = new System.Drawing.Size(299, 20);
            this.fnameTE.StyleController = this.topLC;
            this.fnameTE.TabIndex = 0;
            this.fnameTE.EditValueChanged += new System.EventHandler(this.fnameTE_EditValueChanged);
            // 
            // layoutControlGroup1
            // 
            this.layoutControlGroup1.CustomizationFormText = "Root";
            this.layoutControlGroup1.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True;
            this.layoutControlGroup1.GroupBordersVisible = false;
            this.layoutControlGroup1.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.fnameCI,
            this.lnameCI,
            this.pnameCI,
            this.layoutControlItem4,
            this.emptySpaceItem1});
            this.layoutControlGroup1.Location = new System.Drawing.Point(0, 0);
            this.layoutControlGroup1.Name = "Root";
            this.layoutControlGroup1.Padding = new DevExpress.XtraLayout.Utils.Padding(9, 9, 9, 9);
            this.layoutControlGroup1.Size = new System.Drawing.Size(405, 115);
            this.layoutControlGroup1.Text = "Root";
            this.layoutControlGroup1.TextVisible = false;
            // 
            // fnameCI
            // 
            this.fnameCI.AppearanceItemCaption.ForeColor = System.Drawing.Color.OrangeRed;
            this.fnameCI.AppearanceItemCaption.Options.UseForeColor = true;
            this.fnameCI.Control = this.fnameTE;
            this.fnameCI.CustomizationFormText = "First Name";
            this.fnameCI.Location = new System.Drawing.Point(0, 0);
            this.fnameCI.Name = "fnameCI";
            this.fnameCI.Size = new System.Drawing.Size(387, 24);
            this.fnameCI.Text = "First Name";
            this.fnameCI.TextAlignMode = DevExpress.XtraLayout.TextAlignModeItem.CustomSize;
            this.fnameCI.TextSize = new System.Drawing.Size(79, 13);
            this.fnameCI.TextToControlDistance = 5;
            // 
            // lnameCI
            // 
            this.lnameCI.Control = this.lnameTE;
            this.lnameCI.CustomizationFormText = "Last Name";
            this.lnameCI.Location = new System.Drawing.Point(0, 24);
            this.lnameCI.Name = "lnameCI";
            this.lnameCI.Size = new System.Drawing.Size(387, 24);
            this.lnameCI.Text = "Last Name";
            this.lnameCI.TextAlignMode = DevExpress.XtraLayout.TextAlignModeItem.CustomSize;
            this.lnameCI.TextSize = new System.Drawing.Size(79, 13);
            this.lnameCI.TextToControlDistance = 5;
            // 
            // pnameCI
            // 
            this.pnameCI.Control = this.pnameTE;
            this.pnameCI.CustomizationFormText = "Parent Name";
            this.pnameCI.Location = new System.Drawing.Point(0, 71);
            this.pnameCI.Name = "pnameCI";
            this.pnameCI.Size = new System.Drawing.Size(387, 26);
            this.pnameCI.Text = "Parent Name";
            this.pnameCI.TextAlignMode = DevExpress.XtraLayout.TextAlignModeItem.CustomSize;
            this.pnameCI.TextSize = new System.Drawing.Size(79, 13);
            this.pnameCI.TextToControlDistance = 5;
            this.pnameCI.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Never;
            // 
            // layoutControlItem4
            // 
            this.layoutControlItem4.Control = this.underageCE;
            this.layoutControlItem4.CustomizationFormText = "layoutControlItem4";
            this.layoutControlItem4.Location = new System.Drawing.Point(311, 48);
            this.layoutControlItem4.Name = "layoutControlItem4";
            this.layoutControlItem4.Size = new System.Drawing.Size(76, 23);
            this.layoutControlItem4.Text = "layoutControlItem4";
            this.layoutControlItem4.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem4.TextToControlDistance = 0;
            this.layoutControlItem4.TextVisible = false;
            // 
            // emptySpaceItem1
            // 
            this.emptySpaceItem1.AllowHotTrack = false;
            this.emptySpaceItem1.CustomizationFormText = "emptySpaceItem1";
            this.emptySpaceItem1.Location = new System.Drawing.Point(0, 48);
            this.emptySpaceItem1.Name = "emptySpaceItem1";
            this.emptySpaceItem1.Size = new System.Drawing.Size(311, 23);
            this.emptySpaceItem1.Text = "emptySpaceItem1";
            this.emptySpaceItem1.TextSize = new System.Drawing.Size(0, 0);
            // 
            // studentTabbedView
            // 
            this.studentTabbedView.DocumentGroupProperties.ShowDocumentSelectorButton = false;
            this.studentTabbedView.DocumentGroups.AddRange(new DevExpress.XtraBars.Docking2010.Views.Tabbed.DocumentGroup[] {
            this.documentGroup1});
            this.studentTabbedView.DocumentProperties.AllowClose = false;
            this.studentTabbedView.Documents.AddRange(new DevExpress.XtraBars.Docking2010.Views.BaseDocument[] {
            this.orgUCDocument,
            this.paymentsUCDocument,
            this.contactsUCDocument});
            this.studentTabbedView.ShowDocumentSelectorMenuOnCtrlAltDownArrow = DevExpress.Utils.DefaultBoolean.False;
            this.studentTabbedView.UseDocumentSelector = DevExpress.Utils.DefaultBoolean.False;
            this.studentTabbedView.UseLoadingIndicator = DevExpress.Utils.DefaultBoolean.False;
            this.studentTabbedView.QueryControl += new DevExpress.XtraBars.Docking2010.Views.QueryControlEventHandler(this.tabbedView1_QueryControl);
            // 
            // documentGroup1
            // 
            this.documentGroup1.Items.AddRange(new DevExpress.XtraBars.Docking2010.Views.Tabbed.Document[] {
            this.contactsUCDocument,
            this.orgUCDocument,
            this.paymentsUCDocument});
            this.documentGroup1.Properties.CloseTabOnMiddleClick = DevExpress.XtraTabbedMdi.CloseTabOnMiddleClick.Never;
            this.documentGroup1.Properties.ShowTabHeader = DevExpress.Utils.DefaultBoolean.True;
            // 
            // contactsUCDocument
            // 
            this.contactsUCDocument.Appearance.Header.ForeColor = System.Drawing.Color.OrangeRed;
            this.contactsUCDocument.Appearance.Header.Options.UseForeColor = true;
            this.contactsUCDocument.Appearance.HeaderActive.ForeColor = System.Drawing.Color.White;
            this.contactsUCDocument.Appearance.HeaderActive.Options.UseForeColor = true;
            this.contactsUCDocument.Appearance.HeaderSelected.ForeColor = System.Drawing.Color.White;
            this.contactsUCDocument.Appearance.HeaderSelected.Options.UseForeColor = true;
            this.contactsUCDocument.Caption = "Contacts";
            this.contactsUCDocument.ControlName = "ContactsUC";
            this.contactsUCDocument.ControlTypeName = "ge_mongo_simplified.UserControls.StudentRelated.FormRelated.ContactsUC";
            this.contactsUCDocument.FloatLocation = new System.Drawing.Point(51, 239);
            this.contactsUCDocument.FloatSize = new System.Drawing.Size(399, 211);
            this.contactsUCDocument.Tooltip = "Fill at least Main Phone No.";
            // 
            // orgUCDocument
            // 
            this.orgUCDocument.Appearance.Header.ForeColor = System.Drawing.Color.OrangeRed;
            this.orgUCDocument.Appearance.Header.Options.UseForeColor = true;
            this.orgUCDocument.Appearance.HeaderActive.ForeColor = System.Drawing.Color.White;
            this.orgUCDocument.Appearance.HeaderActive.Options.UseForeColor = true;
            this.orgUCDocument.Appearance.HeaderSelected.ForeColor = System.Drawing.Color.White;
            this.orgUCDocument.Appearance.HeaderSelected.Options.UseForeColor = true;
            this.orgUCDocument.Caption = "Organizational";
            this.orgUCDocument.ControlName = "OrgUC";
            this.orgUCDocument.ControlTypeName = "ge_mongo_simplified.UserControls.StudentRelated.FormRelated.OrgUC";
            this.orgUCDocument.Tooltip = "Fill Group No.";
            // 
            // paymentsUCDocument
            // 
            this.paymentsUCDocument.Caption = "Payments";
            this.paymentsUCDocument.ControlName = "PaymentsUC";
            this.paymentsUCDocument.ControlTypeName = "ge_mongo_simplified.UserControls.StudentRelated.FormRelated.PaymentsUC";
            // 
            // studentsDM
            // 
            this.studentsDM.ContainerControl = this;
            this.studentsDM.DocumentActivationScope = DevExpress.XtraBars.Docking2010.Views.DocumentActivationScope.AllDocuments;
            this.studentsDM.ShowThumbnailsInTaskBar = DevExpress.Utils.DefaultBoolean.False;
            this.studentsDM.View = this.studentTabbedView;
            this.studentsDM.ViewCollection.AddRange(new DevExpress.XtraBars.Docking2010.Views.BaseView[] {
            this.studentTabbedView});
            // 
            // buttonsLC
            // 
            this.buttonsLC.Controls.Add(this.okButt);
            this.buttonsLC.Controls.Add(this.cancelButt);
            this.buttonsLC.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.buttonsLC.Location = new System.Drawing.Point(0, 353);
            this.buttonsLC.Name = "buttonsLC";
            this.buttonsLC.OptionsCustomizationForm.DesignTimeCustomizationFormPositionAndSize = new System.Drawing.Rectangle(452, 153, 426, 350);
            this.buttonsLC.Root = this.buttonsCG;
            this.buttonsLC.Size = new System.Drawing.Size(405, 29);
            this.buttonsLC.TabIndex = 1;
            this.buttonsLC.Text = "layoutControl2";
            // 
            // okButt
            // 
            this.okButt.Enabled = false;
            this.okButt.Location = new System.Drawing.Point(241, 5);
            this.okButt.Name = "okButt";
            this.okButt.Size = new System.Drawing.Size(76, 22);
            this.okButt.StyleController = this.buttonsLC;
            this.okButt.TabIndex = 5;
            this.okButt.Text = "OK";
            // 
            // cancelButt
            // 
            this.cancelButt.Location = new System.Drawing.Point(327, 5);
            this.cancelButt.Name = "cancelButt";
            this.cancelButt.Size = new System.Drawing.Size(76, 22);
            this.cancelButt.StyleController = this.buttonsLC;
            this.cancelButt.TabIndex = 4;
            this.cancelButt.Text = "Cancel";
            this.cancelButt.Click += new System.EventHandler(this.cancelButt_Click);
            // 
            // buttonsCG
            // 
            this.buttonsCG.CustomizationFormText = "buttonsCG";
            this.buttonsCG.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True;
            this.buttonsCG.GroupBordersVisible = false;
            this.buttonsCG.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.cancelCI,
            this.okCI,
            this.emptySpaceItem2});
            this.buttonsCG.Location = new System.Drawing.Point(0, 0);
            this.buttonsCG.Name = "buttonsCG";
            this.buttonsCG.Padding = new DevExpress.XtraLayout.Utils.Padding(0, 0, 3, 0);
            this.buttonsCG.Size = new System.Drawing.Size(405, 29);
            this.buttonsCG.Text = "buttonsCG";
            this.buttonsCG.TextVisible = false;
            // 
            // cancelCI
            // 
            this.cancelCI.Control = this.cancelButt;
            this.cancelCI.CustomizationFormText = "cancelCI";
            this.cancelCI.Location = new System.Drawing.Point(319, 0);
            this.cancelCI.MaxSize = new System.Drawing.Size(86, 26);
            this.cancelCI.MinSize = new System.Drawing.Size(86, 26);
            this.cancelCI.Name = "cancelCI";
            this.cancelCI.Size = new System.Drawing.Size(86, 26);
            this.cancelCI.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom;
            this.cancelCI.Spacing = new DevExpress.XtraLayout.Utils.Padding(6, 0, 0, 0);
            this.cancelCI.Text = "cancelCI";
            this.cancelCI.TextSize = new System.Drawing.Size(0, 0);
            this.cancelCI.TextToControlDistance = 0;
            this.cancelCI.TextVisible = false;
            // 
            // okCI
            // 
            this.okCI.Control = this.okButt;
            this.okCI.CustomizationFormText = "okCI";
            this.okCI.Location = new System.Drawing.Point(239, 0);
            this.okCI.MaxSize = new System.Drawing.Size(80, 26);
            this.okCI.MinSize = new System.Drawing.Size(80, 26);
            this.okCI.Name = "okCI";
            this.okCI.Size = new System.Drawing.Size(80, 26);
            this.okCI.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom;
            this.okCI.Text = "okCI";
            this.okCI.TextSize = new System.Drawing.Size(0, 0);
            this.okCI.TextToControlDistance = 0;
            this.okCI.TextVisible = false;
            // 
            // emptySpaceItem2
            // 
            this.emptySpaceItem2.AllowHotTrack = false;
            this.emptySpaceItem2.CustomizationFormText = "emptySpaceItem2";
            this.emptySpaceItem2.Location = new System.Drawing.Point(0, 0);
            this.emptySpaceItem2.MaxSize = new System.Drawing.Size(0, 26);
            this.emptySpaceItem2.MinSize = new System.Drawing.Size(10, 26);
            this.emptySpaceItem2.Name = "emptySpaceItem2";
            this.emptySpaceItem2.Size = new System.Drawing.Size(239, 26);
            this.emptySpaceItem2.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom;
            this.emptySpaceItem2.Text = "emptySpaceItem2";
            this.emptySpaceItem2.TextSize = new System.Drawing.Size(0, 0);
            // 
            // StdManagerUC
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.buttonsLC);
            this.Controls.Add(this.topLC);
            this.Name = "StdManagerUC";
            this.Size = new System.Drawing.Size(405, 382);
            ((System.ComponentModel.ISupportInitialize)(this.topLC)).EndInit();
            this.topLC.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.underageCE.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pnameTE.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lnameTE.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fnameTE.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fnameCI)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lnameCI)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pnameCI)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.studentTabbedView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.documentGroup1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.contactsUCDocument)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.orgUCDocument)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.paymentsUCDocument)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.studentsDM)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.buttonsLC)).EndInit();
            this.buttonsLC.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.buttonsCG)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cancelCI)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.okCI)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private DevExpress.XtraEditors.TextEdit pnameTE;
        private DevExpress.XtraEditors.TextEdit lnameTE;
        private DevExpress.XtraEditors.TextEdit fnameTE;
        private DevExpress.XtraLayout.LayoutControlItem fnameCI;
        private DevExpress.XtraLayout.LayoutControlItem lnameCI;
        private DevExpress.XtraLayout.LayoutControlItem pnameCI;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem4;
        private DevExpress.XtraLayout.EmptySpaceItem emptySpaceItem1;
        public DevExpress.XtraLayout.LayoutControlGroup layoutControlGroup1;
        public DevExpress.XtraBars.Docking2010.DocumentManager studentsDM;
        public DevExpress.XtraLayout.LayoutControl topLC;
        public DevExpress.XtraEditors.CheckEdit underageCE;
        public DevExpress.XtraBars.Docking2010.Views.Tabbed.TabbedView studentTabbedView;
        private DevExpress.XtraLayout.LayoutControl buttonsLC;
        private DevExpress.XtraEditors.SimpleButton cancelButt;
        private DevExpress.XtraLayout.LayoutControlGroup buttonsCG;
        private DevExpress.XtraLayout.LayoutControlItem cancelCI;
        private DevExpress.XtraEditors.SimpleButton okButt;
        private DevExpress.XtraLayout.LayoutControlItem okCI;
        private DevExpress.XtraLayout.EmptySpaceItem emptySpaceItem2;
        public DevExpress.XtraBars.Docking2010.Views.Tabbed.Document orgUCDocument;
        public DevExpress.XtraBars.Docking2010.Views.Tabbed.Document paymentsUCDocument;
        public DevExpress.XtraBars.Docking2010.Views.Tabbed.DocumentGroup documentGroup1;
        public DevExpress.XtraBars.Docking2010.Views.Tabbed.Document contactsUCDocument;
    }
}
