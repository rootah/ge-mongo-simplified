namespace ge_mongo_simplified.Forms
{
    partial class GroupsForm
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
            this.groupGeneralInfoUc1 = new ge_mongo_simplified.UserControls.GroupGeneralInfoUc();
            this.documentManager1 = new DevExpress.XtraBars.Docking2010.DocumentManager(this.components);
            this.windowsUIView1 = new DevExpress.XtraBars.Docking2010.Views.WindowsUI.WindowsUIView(this.components);
            this.flyout1 = new DevExpress.XtraBars.Docking2010.Views.WindowsUI.Flyout(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.documentManager1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.windowsUIView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.flyout1)).BeginInit();
            this.SuspendLayout();
            // 
            // groupGeneralInfoUc1
            // 
            this.groupGeneralInfoUc1.AutoSize = true;
            this.groupGeneralInfoUc1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupGeneralInfoUc1.Location = new System.Drawing.Point(0, 0);
            this.groupGeneralInfoUc1.Name = "groupGeneralInfoUc1";
            this.groupGeneralInfoUc1.Size = new System.Drawing.Size(400, 189);
            this.groupGeneralInfoUc1.TabIndex = 0;
            // 
            // documentManager1
            // 
            this.documentManager1.MdiParent = this;
            this.documentManager1.ShowThumbnailsInTaskBar = DevExpress.Utils.DefaultBoolean.False;
            this.documentManager1.View = this.windowsUIView1;
            this.documentManager1.ViewCollection.AddRange(new DevExpress.XtraBars.Docking2010.Views.BaseView[] {
            this.windowsUIView1});
            // 
            // windowsUIView1
            // 
            this.windowsUIView1.ContentContainers.AddRange(new DevExpress.XtraBars.Docking2010.Views.WindowsUI.IContentContainer[] {
            this.flyout1});
            // 
            // flyout1
            // 
            this.flyout1.Caption = "Check group no.";
            this.flyout1.FlyoutButtons = System.Windows.Forms.MessageBoxButtons.OK;
            this.flyout1.Name = "flyout1";
            // 
            // GroupsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(400, 189);
            this.ControlBox = false;
            this.Controls.Add(this.groupGeneralInfoUc1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.IsMdiContainer = true;
            this.LookAndFeel.SkinName = "Visual Studio 2013 Light";
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "GroupsForm";
            this.Text = "Group [...]";
            this.Load += new System.EventHandler(this.GroupsForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.documentManager1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.windowsUIView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.flyout1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private UserControls.GroupGeneralInfoUc groupGeneralInfoUc1;
        public DevExpress.XtraBars.Docking2010.Views.WindowsUI.WindowsUIView windowsUIView1;
        public DevExpress.XtraBars.Docking2010.DocumentManager documentManager1;
        public DevExpress.XtraBars.Docking2010.Views.WindowsUI.Flyout flyout1;
    }
}