namespace ge_mongo_simplified.Forms
{
    partial class NewGroupsForm
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
            this.tabbedView = new DevExpress.XtraBars.Docking2010.Views.Tabbed.TabbedView(this.components);
            this.documentGroup = new DevExpress.XtraBars.Docking2010.Views.Tabbed.DocumentGroup(this.components);
            this.groupGeneralInfoUcDocument = new DevExpress.XtraBars.Docking2010.Views.Tabbed.Document(this.components);
            this.groupPaymentsInfoUCDocument = new DevExpress.XtraBars.Docking2010.Views.Tabbed.Document(this.components);
            this.newGroupFormDM = new DevExpress.XtraBars.Docking2010.DocumentManager(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.tabbedView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.documentGroup)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupGeneralInfoUcDocument)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupPaymentsInfoUCDocument)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.newGroupFormDM)).BeginInit();
            this.SuspendLayout();
            // 
            // tabbedView
            // 
            this.tabbedView.DocumentGroupProperties.ShowDocumentSelectorButton = false;
            this.tabbedView.DocumentGroups.AddRange(new DevExpress.XtraBars.Docking2010.Views.Tabbed.DocumentGroup[] {
            this.documentGroup});
            this.tabbedView.DocumentProperties.AllowClose = false;
            this.tabbedView.DocumentProperties.AllowFloat = false;
            this.tabbedView.DocumentProperties.ShowPinButton = false;
            this.tabbedView.Documents.AddRange(new DevExpress.XtraBars.Docking2010.Views.BaseDocument[] {
            this.groupGeneralInfoUcDocument,
            this.groupPaymentsInfoUCDocument});
            this.tabbedView.QueryControl += new DevExpress.XtraBars.Docking2010.Views.QueryControlEventHandler(this.tabbedView_QueryControl);
            // 
            // documentGroup
            // 
            this.documentGroup.Items.AddRange(new DevExpress.XtraBars.Docking2010.Views.Tabbed.Document[] {
            this.groupGeneralInfoUcDocument,
            this.groupPaymentsInfoUCDocument});
            // 
            // groupGeneralInfoUcDocument
            // 
            this.groupGeneralInfoUcDocument.Caption = "Info";
            this.groupGeneralInfoUcDocument.ControlName = "GroupGeneralInfoUc";
            this.groupGeneralInfoUcDocument.ControlTypeName = "ge_mongo_simplified.UserControls.GroupGeneralInfoUc";
            // 
            // groupPaymentsInfoUCDocument
            // 
            this.groupPaymentsInfoUCDocument.Caption = "Payments";
            this.groupPaymentsInfoUCDocument.ControlName = "GroupPaymentsInfoUC";
            this.groupPaymentsInfoUCDocument.ControlTypeName = "ge_mongo_simplified.UserControls.GroupPaymentsInfoUC";
            // 
            // newGroupFormDM
            // 
            this.newGroupFormDM.ContainerControl = this;
            this.newGroupFormDM.View = this.tabbedView;
            this.newGroupFormDM.ViewCollection.AddRange(new DevExpress.XtraBars.Docking2010.Views.BaseView[] {
            this.tabbedView});
            // 
            // NewGroupsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(312, 307);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.Name = "NewGroupsForm";
            this.Text = "NewGroupsForm";
            this.Load += new System.EventHandler(this.NewGroupsForm_Load);
            this.Resize += new System.EventHandler(this.NewGroupsForm_Resize);
            ((System.ComponentModel.ISupportInitialize)(this.tabbedView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.documentGroup)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupGeneralInfoUcDocument)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupPaymentsInfoUCDocument)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.newGroupFormDM)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraBars.Docking2010.Views.Tabbed.TabbedView tabbedView;
        private DevExpress.XtraBars.Docking2010.Views.Tabbed.DocumentGroup documentGroup;
        public DevExpress.XtraBars.Docking2010.Views.Tabbed.Document groupGeneralInfoUcDocument;
        private DevExpress.XtraBars.Docking2010.Views.Tabbed.Document groupPaymentsInfoUCDocument;
        public DevExpress.XtraBars.Docking2010.DocumentManager newGroupFormDM;
    }
}