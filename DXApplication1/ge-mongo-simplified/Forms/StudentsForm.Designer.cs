namespace ge_mongo_simplified.Forms
{
    partial class StudentsForm
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
            this.documentManager1 = new DevExpress.XtraBars.Docking2010.DocumentManager(this.components);
            this.windowsUIView1 = new DevExpress.XtraBars.Docking2010.Views.WindowsUI.WindowsUIView(this.components);
            this.pageGroup1 = new DevExpress.XtraBars.Docking2010.Views.WindowsUI.PageGroup(this.components);
            this.studentGeneralInfoUCDocument = new DevExpress.XtraBars.Docking2010.Views.WindowsUI.Document(this.components);
            this.studentPaymentInfoUCDocument = new DevExpress.XtraBars.Docking2010.Views.WindowsUI.Document(this.components);
            this.StudentGeneralInfoUCTile = new DevExpress.XtraBars.Docking2010.Views.WindowsUI.Tile(this.components);
            this.StudentPaymentInfoUCTile = new DevExpress.XtraBars.Docking2010.Views.WindowsUI.Tile(this.components);
            this.closeAppFlyout = new DevExpress.XtraBars.Docking2010.Views.WindowsUI.Flyout(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.documentManager1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.windowsUIView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pageGroup1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.studentGeneralInfoUCDocument)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.studentPaymentInfoUCDocument)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.StudentGeneralInfoUCTile)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.StudentPaymentInfoUCTile)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.closeAppFlyout)).BeginInit();
            this.SuspendLayout();
            // 
            // documentManager1
            // 
            this.documentManager1.ContainerControl = this;
            this.documentManager1.ShowThumbnailsInTaskBar = DevExpress.Utils.DefaultBoolean.False;
            this.documentManager1.View = this.windowsUIView1;
            this.documentManager1.ViewCollection.AddRange(new DevExpress.XtraBars.Docking2010.Views.BaseView[] {
            this.windowsUIView1});
            // 
            // windowsUIView1
            // 
            this.windowsUIView1.ContentContainers.AddRange(new DevExpress.XtraBars.Docking2010.Views.WindowsUI.IContentContainer[] {
            this.pageGroup1,
            this.closeAppFlyout});
            this.windowsUIView1.Documents.AddRange(new DevExpress.XtraBars.Docking2010.Views.BaseDocument[] {
            this.studentGeneralInfoUCDocument,
            this.studentPaymentInfoUCDocument});
            this.windowsUIView1.PageGroupProperties.HeaderOffset = -30;
            this.windowsUIView1.Tiles.AddRange(new DevExpress.XtraBars.Docking2010.Views.WindowsUI.BaseTile[] {
            this.StudentGeneralInfoUCTile,
            this.StudentPaymentInfoUCTile});
            this.windowsUIView1.QueryControl += new DevExpress.XtraBars.Docking2010.Views.QueryControlEventHandler(this.windowsUIView1_QueryControl);
            // 
            // pageGroup1
            // 
            this.pageGroup1.Caption = "";
            this.pageGroup1.Items.AddRange(new DevExpress.XtraBars.Docking2010.Views.WindowsUI.Document[] {
            this.studentGeneralInfoUCDocument,
            this.studentPaymentInfoUCDocument});
            this.pageGroup1.Name = "pageGroup1";
            this.pageGroup1.Properties.SwitchDocumentAnimationMode = DevExpress.XtraBars.Docking2010.Customization.TransitionAnimation.VerticalSlide;
            // 
            // studentGeneralInfoUCDocument
            // 
            this.studentGeneralInfoUCDocument.Caption = "Info";
            this.studentGeneralInfoUCDocument.ControlName = "StudentGeneralInfoUC";
            this.studentGeneralInfoUCDocument.ControlTypeName = "ge_mongo_simplified.UserControls.StudentGeneralInfoUC";
            // 
            // studentPaymentInfoUCDocument
            // 
            this.studentPaymentInfoUCDocument.Caption = "Payment Info";
            this.studentPaymentInfoUCDocument.ControlName = "StudentPaymentInfoUC";
            this.studentPaymentInfoUCDocument.ControlTypeName = "ge_mongo_simplified.UserControls.StudentPaymentInfoUC";
            // 
            // StudentGeneralInfoUCTile
            // 
            this.StudentGeneralInfoUCTile.Document = this.studentGeneralInfoUCDocument;
            this.StudentGeneralInfoUCTile.Name = "StudentGeneralInfoUCTile";
            // 
            // StudentPaymentInfoUCTile
            // 
            this.StudentPaymentInfoUCTile.Document = this.studentPaymentInfoUCDocument;
            this.StudentPaymentInfoUCTile.Name = "StudentPaymentInfoUCTile";
            // 
            // closeAppFlyout
            // 
            this.closeAppFlyout.Document = this.studentGeneralInfoUCDocument;
            this.closeAppFlyout.Name = "closeAppFlyout";
            // 
            // StudentsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(817, 393);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.IsMdiContainer = true;
            this.Name = "StudentsForm";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Show;
            this.Text = "Student [...]";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.StudentsForm_FormClosing);
            ((System.ComponentModel.ISupportInitialize)(this.documentManager1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.windowsUIView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pageGroup1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.studentGeneralInfoUCDocument)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.studentPaymentInfoUCDocument)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.StudentGeneralInfoUCTile)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.StudentPaymentInfoUCTile)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.closeAppFlyout)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraBars.Docking2010.DocumentManager documentManager1;
        private DevExpress.XtraBars.Docking2010.Views.WindowsUI.WindowsUIView windowsUIView1;
        private DevExpress.XtraBars.Docking2010.Views.WindowsUI.Document studentGeneralInfoUCDocument;
        private DevExpress.XtraBars.Docking2010.Views.WindowsUI.Document studentPaymentInfoUCDocument;
        private DevExpress.XtraBars.Docking2010.Views.WindowsUI.Tile StudentGeneralInfoUCTile;
        private DevExpress.XtraBars.Docking2010.Views.WindowsUI.Tile StudentPaymentInfoUCTile;
        private DevExpress.XtraBars.Docking2010.Views.WindowsUI.PageGroup pageGroup1;
        private DevExpress.XtraBars.Docking2010.Views.WindowsUI.Flyout closeAppFlyout;


    }
}