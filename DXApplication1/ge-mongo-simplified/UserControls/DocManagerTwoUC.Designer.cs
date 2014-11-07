namespace ge_mongo_simplified.UserControls
{
    partial class DocManagerTwoUC
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
            this.tabbedView1 = new DevExpress.XtraBars.Docking2010.Views.Tabbed.TabbedView();
            this.documentGroup1 = new DevExpress.XtraBars.Docking2010.Views.Tabbed.DocumentGroup();
            this.contactsUCDocument = new DevExpress.XtraBars.Docking2010.Views.Tabbed.Document();
            this.orgUCDocument = new DevExpress.XtraBars.Docking2010.Views.Tabbed.Document();
            this.paymentsUCDocument = new DevExpress.XtraBars.Docking2010.Views.Tabbed.Document();
            this.documentManager1 = new DevExpress.XtraBars.Docking2010.DocumentManager();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).BeginInit();
            this.layoutControl1.SuspendLayout();
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
            ((System.ComponentModel.ISupportInitialize)(this.tabbedView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.documentGroup1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.contactsUCDocument)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.orgUCDocument)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.paymentsUCDocument)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.documentManager1)).BeginInit();
            this.SuspendLayout();
            // 
            // layoutControl1
            // 
            this.layoutControl1.Controls.Add(this.underageCE);
            this.layoutControl1.Controls.Add(this.pnameTE);
            this.layoutControl1.Controls.Add(this.lnameTE);
            this.layoutControl1.Controls.Add(this.fnameTE);
            this.layoutControl1.Dock = System.Windows.Forms.DockStyle.Top;
            this.layoutControl1.Location = new System.Drawing.Point(0, 0);
            this.layoutControl1.Name = "layoutControl1";
            this.layoutControl1.OptionsCustomizationForm.DesignTimeCustomizationFormPositionAndSize = new System.Drawing.Rectangle(606, 179, 250, 350);
            this.layoutControl1.Root = this.layoutControlGroup1;
            this.layoutControl1.Size = new System.Drawing.Size(405, 115);
            this.layoutControl1.TabIndex = 0;
            this.layoutControl1.Text = "layoutControl1";
            // 
            // underageCE
            // 
            this.underageCE.Location = new System.Drawing.Point(322, 59);
            this.underageCE.Name = "underageCE";
            this.underageCE.Properties.AllowFocused = false;
            this.underageCE.Properties.Caption = "Underage";
            this.underageCE.Properties.CheckStyle = DevExpress.XtraEditors.Controls.CheckStyles.Radio;
            this.underageCE.Size = new System.Drawing.Size(72, 19);
            this.underageCE.StyleController = this.layoutControl1;
            this.underageCE.TabIndex = 2;
            this.underageCE.CheckedChanged += new System.EventHandler(this.underageCE_CheckedChanged);
            // 
            // pnameTE
            // 
            this.pnameTE.Location = new System.Drawing.Point(95, 82);
            this.pnameTE.Name = "pnameTE";
            this.pnameTE.Size = new System.Drawing.Size(299, 20);
            this.pnameTE.StyleController = this.layoutControl1;
            this.pnameTE.TabIndex = 3;
            // 
            // lnameTE
            // 
            this.lnameTE.Location = new System.Drawing.Point(95, 35);
            this.lnameTE.Name = "lnameTE";
            this.lnameTE.Size = new System.Drawing.Size(299, 20);
            this.lnameTE.StyleController = this.layoutControl1;
            this.lnameTE.TabIndex = 1;
            // 
            // fnameTE
            // 
            this.fnameTE.Location = new System.Drawing.Point(95, 11);
            this.fnameTE.Name = "fnameTE";
            this.fnameTE.Size = new System.Drawing.Size(299, 20);
            this.fnameTE.StyleController = this.layoutControl1;
            this.fnameTE.TabIndex = 0;
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
            // tabbedView1
            // 
            this.tabbedView1.DocumentGroupProperties.ShowDocumentSelectorButton = false;
            this.tabbedView1.DocumentGroups.AddRange(new DevExpress.XtraBars.Docking2010.Views.Tabbed.DocumentGroup[] {
            this.documentGroup1});
            this.tabbedView1.DocumentProperties.AllowClose = false;
            this.tabbedView1.Documents.AddRange(new DevExpress.XtraBars.Docking2010.Views.BaseDocument[] {
            this.contactsUCDocument,
            this.orgUCDocument,
            this.paymentsUCDocument});
            this.tabbedView1.ShowDocumentSelectorMenuOnCtrlAltDownArrow = DevExpress.Utils.DefaultBoolean.False;
            this.tabbedView1.UseDocumentSelector = DevExpress.Utils.DefaultBoolean.False;
            this.tabbedView1.UseLoadingIndicator = DevExpress.Utils.DefaultBoolean.False;
            this.tabbedView1.QueryControl += new DevExpress.XtraBars.Docking2010.Views.QueryControlEventHandler(this.tabbedView1_QueryControl);
            // 
            // documentGroup1
            // 
            this.documentGroup1.Items.AddRange(new DevExpress.XtraBars.Docking2010.Views.Tabbed.Document[] {
            this.contactsUCDocument,
            this.orgUCDocument,
            this.paymentsUCDocument});
            // 
            // contactsUCDocument
            // 
            this.contactsUCDocument.Caption = "Contacts";
            this.contactsUCDocument.ControlName = "ContactsUC";
            this.contactsUCDocument.ControlTypeName = "ge_mongo_simplified.UserControls.StudentRelated.FormRelated.ContactsUC";
            // 
            // orgUCDocument
            // 
            this.orgUCDocument.Caption = "Organizational";
            this.orgUCDocument.ControlName = "OrgUC";
            this.orgUCDocument.ControlTypeName = "ge_mongo_simplified.UserControls.StudentRelated.FormRelated.OrgUC";
            // 
            // paymentsUCDocument
            // 
            this.paymentsUCDocument.Caption = "Payments";
            this.paymentsUCDocument.ControlName = "PaymentsUC";
            this.paymentsUCDocument.ControlTypeName = "ge_mongo_simplified.UserControls.StudentRelated.FormRelated.PaymentsUC";
            // 
            // documentManager1
            // 
            this.documentManager1.ContainerControl = this;
            this.documentManager1.ShowThumbnailsInTaskBar = DevExpress.Utils.DefaultBoolean.False;
            this.documentManager1.View = this.tabbedView1;
            this.documentManager1.ViewCollection.AddRange(new DevExpress.XtraBars.Docking2010.Views.BaseView[] {
            this.tabbedView1});
            // 
            // DocManagerTwoUC
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.layoutControl1);
            this.Name = "DocManagerTwoUC";
            this.Size = new System.Drawing.Size(405, 382);
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).EndInit();
            this.layoutControl1.ResumeLayout(false);
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
            ((System.ComponentModel.ISupportInitialize)(this.tabbedView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.documentGroup1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.contactsUCDocument)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.orgUCDocument)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.paymentsUCDocument)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.documentManager1)).EndInit();
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
        private DevExpress.XtraBars.Docking2010.Views.Tabbed.DocumentGroup documentGroup1;
        private DevExpress.XtraBars.Docking2010.Views.Tabbed.Document orgUCDocument;
        private DevExpress.XtraBars.Docking2010.Views.Tabbed.Document paymentsUCDocument;
        public DevExpress.XtraBars.Docking2010.DocumentManager documentManager1;
        public DevExpress.XtraBars.Docking2010.Views.Tabbed.Document contactsUCDocument;
        public DevExpress.XtraLayout.LayoutControl layoutControl1;
        public DevExpress.XtraEditors.CheckEdit underageCE;
        public DevExpress.XtraBars.Docking2010.Views.Tabbed.TabbedView tabbedView1;
    }
}
