namespace ge_mongo_simplified.UserControls
{
    partial class DetailsUC
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
            this.detailsTC = new DevExpress.XtraTab.XtraTabControl();
            this.groupTab = new DevExpress.XtraTab.XtraTabPage();
            this.groupDetailsUC2 = new ge_mongo_simplified.UserControls.GroupDetailsUC();
            this.studentTab = new DevExpress.XtraTab.XtraTabPage();
            this.layoutControlGroup1 = new DevExpress.XtraLayout.LayoutControlGroup();
            this.detailsLabel = new DevExpress.XtraLayout.SimpleLabelItem();
            this.layoutControlItem1 = new DevExpress.XtraLayout.LayoutControlItem();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).BeginInit();
            this.layoutControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.detailsTC)).BeginInit();
            this.detailsTC.SuspendLayout();
            this.groupTab.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.detailsLabel)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).BeginInit();
            this.SuspendLayout();
            // 
            // layoutControl1
            // 
            this.layoutControl1.Controls.Add(this.detailsTC);
            this.layoutControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.layoutControl1.Location = new System.Drawing.Point(0, 0);
            this.layoutControl1.Name = "layoutControl1";
            this.layoutControl1.OptionsCustomizationForm.DesignTimeCustomizationFormPositionAndSize = new System.Drawing.Rectangle(540, 123, 305, 401);
            this.layoutControl1.Root = this.layoutControlGroup1;
            this.layoutControl1.Size = new System.Drawing.Size(493, 352);
            this.layoutControl1.TabIndex = 0;
            this.layoutControl1.Text = "layoutControl1";
            // 
            // detailsTC
            // 
            this.detailsTC.Location = new System.Drawing.Point(2, 41);
            this.detailsTC.Name = "detailsTC";
            this.detailsTC.SelectedTabPage = this.groupTab;
            this.detailsTC.Size = new System.Drawing.Size(489, 304);
            this.detailsTC.TabIndex = 4;
            this.detailsTC.TabPages.AddRange(new DevExpress.XtraTab.XtraTabPage[] {
            this.groupTab,
            this.studentTab});
            this.detailsTC.SelectedPageChanged += new DevExpress.XtraTab.TabPageChangedEventHandler(this.xtraTabControl1_SelectedPageChanged);
            // 
            // groupTab
            // 
            this.groupTab.Controls.Add(this.groupDetailsUC2);
            this.groupTab.Name = "groupTab";
            this.groupTab.Size = new System.Drawing.Size(487, 302);
            this.groupTab.Text = "grp";
            // 
            // groupDetailsUC2
            // 
            this.groupDetailsUC2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupDetailsUC2.Location = new System.Drawing.Point(0, 0);
            this.groupDetailsUC2.Name = "groupDetailsUC2";
            this.groupDetailsUC2.Size = new System.Drawing.Size(487, 302);
            this.groupDetailsUC2.TabIndex = 0;
            // 
            // studentTab
            // 
            this.studentTab.Name = "studentTab";
            this.studentTab.Size = new System.Drawing.Size(487, 277);
            this.studentTab.Text = "std";
            // 
            // layoutControlGroup1
            // 
            this.layoutControlGroup1.AppearanceItemCaption.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.layoutControlGroup1.AppearanceItemCaption.Options.UseFont = true;
            this.layoutControlGroup1.CustomizationFormText = "Root";
            this.layoutControlGroup1.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True;
            this.layoutControlGroup1.GroupBordersVisible = false;
            this.layoutControlGroup1.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.detailsLabel,
            this.layoutControlItem1});
            this.layoutControlGroup1.Location = new System.Drawing.Point(0, 0);
            this.layoutControlGroup1.Name = "Root";
            this.layoutControlGroup1.Padding = new DevExpress.XtraLayout.Utils.Padding(0, 0, 5, 5);
            this.layoutControlGroup1.Size = new System.Drawing.Size(493, 352);
            this.layoutControlGroup1.Text = "Root";
            this.layoutControlGroup1.TextVisible = false;
            // 
            // detailsLabel
            // 
            this.detailsLabel.AllowHotTrack = false;
            this.detailsLabel.AppearanceItemCaption.Font = new System.Drawing.Font("Segoe UI Semilight", 12.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.detailsLabel.AppearanceItemCaption.Options.UseFont = true;
            this.detailsLabel.CustomizationFormText = "Details [ group ]";
            this.detailsLabel.Location = new System.Drawing.Point(0, 0);
            this.detailsLabel.MaxSize = new System.Drawing.Size(0, 34);
            this.detailsLabel.MinSize = new System.Drawing.Size(114, 34);
            this.detailsLabel.Name = "detailsLabel";
            this.detailsLabel.Size = new System.Drawing.Size(493, 34);
            this.detailsLabel.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom;
            this.detailsLabel.Spacing = new DevExpress.XtraLayout.Utils.Padding(3, 0, 0, 5);
            this.detailsLabel.Text = "Details [ group ]";
            this.detailsLabel.TextSize = new System.Drawing.Size(110, 21);
            // 
            // layoutControlItem1
            // 
            this.layoutControlItem1.Control = this.detailsTC;
            this.layoutControlItem1.CustomizationFormText = "layoutControlItem1";
            this.layoutControlItem1.Location = new System.Drawing.Point(0, 34);
            this.layoutControlItem1.Name = "layoutControlItem1";
            this.layoutControlItem1.Size = new System.Drawing.Size(493, 308);
            this.layoutControlItem1.Text = "layoutControlItem1";
            this.layoutControlItem1.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem1.TextToControlDistance = 0;
            this.layoutControlItem1.TextVisible = false;
            // 
            // DetailsUC
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.layoutControl1);
            this.Name = "DetailsUC";
            this.Size = new System.Drawing.Size(493, 352);
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).EndInit();
            this.layoutControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.detailsTC)).EndInit();
            this.detailsTC.ResumeLayout(false);
            this.groupTab.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.detailsLabel)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraLayout.LayoutControl layoutControl1;
        private DevExpress.XtraLayout.LayoutControlGroup layoutControlGroup1;
        private DevExpress.XtraLayout.SimpleLabelItem detailsLabel;
        private DevExpress.XtraTab.XtraTabPage groupTab;
        private DevExpress.XtraTab.XtraTabPage studentTab;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem1;
        public DevExpress.XtraTab.XtraTabControl detailsTC;
        public GroupDetailsUC groupDetailsUC2;
    }
}
