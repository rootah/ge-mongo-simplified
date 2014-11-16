namespace ge_mongo_simplified.UserControls.GroupRelated.FormRelated
{
    partial class GroupManagerUc
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
            this.groupsDM = new DevExpress.XtraBars.Docking2010.DocumentManager(this.components);
            this.tabbedView1 = new DevExpress.XtraBars.Docking2010.Views.Tabbed.TabbedView(this.components);
            this.documentGroup1 = new DevExpress.XtraBars.Docking2010.Views.Tabbed.DocumentGroup(this.components);
            this.groupGeneralInfoUcDocument = new DevExpress.XtraBars.Docking2010.Views.Tabbed.Document(this.components);
            this.groupPaymentsInfoUCDocument = new DevExpress.XtraBars.Docking2010.Views.Tabbed.Document(this.components);
            this.buttonsLC = new DevExpress.XtraLayout.LayoutControl();
            this.okButt = new DevExpress.XtraEditors.SimpleButton();
            this.cancelButt = new DevExpress.XtraEditors.SimpleButton();
            this.buttonsCG = new DevExpress.XtraLayout.LayoutControlGroup();
            this.cancelCI = new DevExpress.XtraLayout.LayoutControlItem();
            this.emptySpaceItem1 = new DevExpress.XtraLayout.EmptySpaceItem();
            this.okCI = new DevExpress.XtraLayout.LayoutControlItem();
            ((System.ComponentModel.ISupportInitialize)(this.groupsDM)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tabbedView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.documentGroup1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupGeneralInfoUcDocument)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupPaymentsInfoUCDocument)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.buttonsLC)).BeginInit();
            this.buttonsLC.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.buttonsCG)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cancelCI)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.okCI)).BeginInit();
            this.SuspendLayout();
            // 
            // groupsDM
            // 
            this.groupsDM.ContainerControl = this;
            this.groupsDM.View = this.tabbedView1;
            this.groupsDM.ViewCollection.AddRange(new DevExpress.XtraBars.Docking2010.Views.BaseView[] {
            this.tabbedView1});
            // 
            // tabbedView1
            // 
            this.tabbedView1.DocumentGroupProperties.ShowDocumentSelectorButton = false;
            this.tabbedView1.DocumentGroups.AddRange(new DevExpress.XtraBars.Docking2010.Views.Tabbed.DocumentGroup[] {
            this.documentGroup1});
            this.tabbedView1.DocumentProperties.AllowClose = false;
            this.tabbedView1.DocumentProperties.AllowDock = false;
            this.tabbedView1.DocumentProperties.AllowDockFill = false;
            this.tabbedView1.DocumentProperties.AllowFloat = false;
            this.tabbedView1.DocumentProperties.AllowFloatOnDoubleClick = false;
            this.tabbedView1.Documents.AddRange(new DevExpress.XtraBars.Docking2010.Views.BaseDocument[] {
            this.groupGeneralInfoUcDocument,
            this.groupPaymentsInfoUCDocument});
            this.tabbedView1.UseLoadingIndicator = DevExpress.Utils.DefaultBoolean.False;
            this.tabbedView1.QueryControl += new DevExpress.XtraBars.Docking2010.Views.QueryControlEventHandler(this.tabbedView1_QueryControl);
            // 
            // documentGroup1
            // 
            this.documentGroup1.Items.AddRange(new DevExpress.XtraBars.Docking2010.Views.Tabbed.Document[] {
            this.groupGeneralInfoUcDocument,
            this.groupPaymentsInfoUCDocument});
            // 
            // groupGeneralInfoUcDocument
            // 
            this.groupGeneralInfoUcDocument.Caption = "General Info";
            this.groupGeneralInfoUcDocument.ControlName = "GeneralUC";
            this.groupGeneralInfoUcDocument.ControlTypeName = "ge_mongo_simplified.UserControls.GeneralUC";
            // 
            // groupPaymentsInfoUCDocument
            // 
            this.groupPaymentsInfoUCDocument.Caption = "Payments Info";
            this.groupPaymentsInfoUCDocument.ControlName = "GroupPaymentsInfoUC";
            this.groupPaymentsInfoUCDocument.ControlTypeName = "ge_mongo_simplified.UserControls.GroupPaymentsInfoUC";
            // 
            // buttonsLC
            // 
            this.buttonsLC.Controls.Add(this.okButt);
            this.buttonsLC.Controls.Add(this.cancelButt);
            this.buttonsLC.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.buttonsLC.Location = new System.Drawing.Point(0, 348);
            this.buttonsLC.Name = "buttonsLC";
            this.buttonsLC.OptionsCustomizationForm.DesignTimeCustomizationFormPositionAndSize = new System.Drawing.Rectangle(701, 148, 314, 350);
            this.buttonsLC.Root = this.buttonsCG;
            this.buttonsLC.Size = new System.Drawing.Size(264, 29);
            this.buttonsLC.TabIndex = 1;
            this.buttonsLC.Text = "layoutControl1";
            // 
            // okButt
            // 
            this.okButt.Location = new System.Drawing.Point(100, 5);
            this.okButt.Name = "okButt";
            this.okButt.Size = new System.Drawing.Size(76, 22);
            this.okButt.StyleController = this.buttonsLC;
            this.okButt.TabIndex = 5;
            this.okButt.Text = "OK";
            this.okButt.Click += new System.EventHandler(this.okButt_Click);
            // 
            // cancelButt
            // 
            this.cancelButt.Location = new System.Drawing.Point(186, 5);
            this.cancelButt.Name = "cancelButt";
            this.cancelButt.Size = new System.Drawing.Size(76, 22);
            this.cancelButt.StyleController = this.buttonsLC;
            this.cancelButt.TabIndex = 4;
            this.cancelButt.Text = "Cancel";
            this.cancelButt.Click += new System.EventHandler(this.cancelButt_Click);
            // 
            // buttonsCG
            // 
            this.buttonsCG.CustomizationFormText = "Root";
            this.buttonsCG.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True;
            this.buttonsCG.GroupBordersVisible = false;
            this.buttonsCG.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.cancelCI,
            this.emptySpaceItem1,
            this.okCI});
            this.buttonsCG.Location = new System.Drawing.Point(0, 0);
            this.buttonsCG.Name = "Root";
            this.buttonsCG.Padding = new DevExpress.XtraLayout.Utils.Padding(0, 0, 3, 0);
            this.buttonsCG.Size = new System.Drawing.Size(264, 29);
            this.buttonsCG.Text = "Root";
            this.buttonsCG.TextVisible = false;
            // 
            // cancelCI
            // 
            this.cancelCI.Control = this.cancelButt;
            this.cancelCI.CustomizationFormText = "cancelCI";
            this.cancelCI.Location = new System.Drawing.Point(178, 0);
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
            // emptySpaceItem1
            // 
            this.emptySpaceItem1.AllowHotTrack = false;
            this.emptySpaceItem1.CustomizationFormText = "emptySpaceItem1";
            this.emptySpaceItem1.Location = new System.Drawing.Point(0, 0);
            this.emptySpaceItem1.Name = "emptySpaceItem1";
            this.emptySpaceItem1.Size = new System.Drawing.Size(98, 26);
            this.emptySpaceItem1.Text = "emptySpaceItem1";
            this.emptySpaceItem1.TextSize = new System.Drawing.Size(0, 0);
            // 
            // okCI
            // 
            this.okCI.Control = this.okButt;
            this.okCI.CustomizationFormText = "okCI";
            this.okCI.Location = new System.Drawing.Point(98, 0);
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
            // GroupManagerUc
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.buttonsLC);
            this.Name = "GroupManagerUc";
            this.Size = new System.Drawing.Size(264, 377);
            ((System.ComponentModel.ISupportInitialize)(this.groupsDM)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tabbedView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.documentGroup1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupGeneralInfoUcDocument)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupPaymentsInfoUCDocument)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.buttonsLC)).EndInit();
            this.buttonsLC.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.buttonsCG)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cancelCI)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.okCI)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraBars.Docking2010.DocumentManager groupsDM;
        private DevExpress.XtraBars.Docking2010.Views.Tabbed.DocumentGroup documentGroup1;
        public DevExpress.XtraBars.Docking2010.Views.Tabbed.TabbedView tabbedView1;
        public DevExpress.XtraBars.Docking2010.Views.Tabbed.Document groupGeneralInfoUcDocument;
        public DevExpress.XtraBars.Docking2010.Views.Tabbed.Document groupPaymentsInfoUCDocument;
        private DevExpress.XtraLayout.LayoutControl buttonsLC;
        private DevExpress.XtraLayout.LayoutControlGroup buttonsCG;
        private DevExpress.XtraEditors.SimpleButton cancelButt;
        private DevExpress.XtraLayout.LayoutControlItem cancelCI;
        private DevExpress.XtraLayout.EmptySpaceItem emptySpaceItem1;
        private DevExpress.XtraEditors.SimpleButton okButt;
        private DevExpress.XtraLayout.LayoutControlItem okCI;
    }
}
