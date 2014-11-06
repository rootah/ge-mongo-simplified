namespace ge_mongo_simplified.UserControls
{
    partial class DocManagerUC
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
            this.documentManager1 = new DevExpress.XtraBars.Docking2010.DocumentManager(this.components);
            this.tabbedView1 = new DevExpress.XtraBars.Docking2010.Views.Tabbed.TabbedView(this.components);
            this.documentGroup1 = new DevExpress.XtraBars.Docking2010.Views.Tabbed.DocumentGroup(this.components);
            this.groupGeneralInfoUcDocument = new DevExpress.XtraBars.Docking2010.Views.Tabbed.Document(this.components);
            this.groupPaymentsInfoUCDocument = new DevExpress.XtraBars.Docking2010.Views.Tabbed.Document(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.documentManager1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tabbedView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.documentGroup1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupGeneralInfoUcDocument)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupPaymentsInfoUCDocument)).BeginInit();
            this.SuspendLayout();
            // 
            // documentManager1
            // 
            this.documentManager1.ContainerControl = this;
            this.documentManager1.View = this.tabbedView1;
            this.documentManager1.ViewCollection.AddRange(new DevExpress.XtraBars.Docking2010.Views.BaseView[] {
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
            this.groupGeneralInfoUcDocument.ControlName = "GroupGeneralInfoUc";
            this.groupGeneralInfoUcDocument.ControlTypeName = "ge_mongo_simplified.UserControls.GroupGeneralInfoUc";
            // 
            // groupPaymentsInfoUCDocument
            // 
            this.groupPaymentsInfoUCDocument.Caption = "Payments Info";
            this.groupPaymentsInfoUCDocument.ControlName = "GroupPaymentsInfoUC";
            this.groupPaymentsInfoUCDocument.ControlTypeName = "ge_mongo_simplified.UserControls.GroupPaymentsInfoUC";
            // 
            // DocManagerUC
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Name = "DocManagerUC";
            this.Size = new System.Drawing.Size(569, 377);
            ((System.ComponentModel.ISupportInitialize)(this.documentManager1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tabbedView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.documentGroup1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupGeneralInfoUcDocument)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupPaymentsInfoUCDocument)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraBars.Docking2010.DocumentManager documentManager1;
        private DevExpress.XtraBars.Docking2010.Views.Tabbed.DocumentGroup documentGroup1;
        public DevExpress.XtraBars.Docking2010.Views.Tabbed.TabbedView tabbedView1;
        public DevExpress.XtraBars.Docking2010.Views.Tabbed.Document groupGeneralInfoUcDocument;
        public DevExpress.XtraBars.Docking2010.Views.Tabbed.Document groupPaymentsInfoUCDocument;
    }
}
