namespace ge_mongo_simplified.UserControls
{
    partial class GroupTotalDetailsUC
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
            this.layoutControlGroup1 = new DevExpress.XtraLayout.LayoutControlGroup();
            this.emptySpaceItem1 = new DevExpress.XtraLayout.EmptySpaceItem();
            this.groupsLabel = new DevExpress.XtraEditors.LabelControl();
            this.groupsTotalCI = new DevExpress.XtraLayout.LayoutControlItem();
            this.studentsLabel = new DevExpress.XtraEditors.LabelControl();
            this.studentsTotalCI = new DevExpress.XtraLayout.LayoutControlItem();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).BeginInit();
            this.layoutControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupsTotalCI)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.studentsTotalCI)).BeginInit();
            this.SuspendLayout();
            // 
            // layoutControl1
            // 
            this.layoutControl1.Controls.Add(this.studentsLabel);
            this.layoutControl1.Controls.Add(this.groupsLabel);
            this.layoutControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.layoutControl1.Location = new System.Drawing.Point(0, 0);
            this.layoutControl1.Name = "layoutControl1";
            this.layoutControl1.OptionsCustomizationForm.DesignTimeCustomizationFormPositionAndSize = new System.Drawing.Rectangle(404, 159, 456, 539);
            this.layoutControl1.Root = this.layoutControlGroup1;
            this.layoutControl1.Size = new System.Drawing.Size(289, 243);
            this.layoutControl1.TabIndex = 0;
            this.layoutControl1.Text = "layoutControl1";
            // 
            // layoutControlGroup1
            // 
            this.layoutControlGroup1.AppearanceItemCaption.ForeColor = System.Drawing.SystemColors.GrayText;
            this.layoutControlGroup1.AppearanceItemCaption.Options.UseForeColor = true;
            this.layoutControlGroup1.CustomizationFormText = "Root";
            this.layoutControlGroup1.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True;
            this.layoutControlGroup1.GroupBordersVisible = false;
            this.layoutControlGroup1.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.emptySpaceItem1,
            this.groupsTotalCI,
            this.studentsTotalCI});
            this.layoutControlGroup1.Location = new System.Drawing.Point(0, 0);
            this.layoutControlGroup1.Name = "Root";
            this.layoutControlGroup1.OptionsItemText.TextToControlDistance = 9;
            this.layoutControlGroup1.Size = new System.Drawing.Size(289, 243);
            this.layoutControlGroup1.Text = "Root";
            this.layoutControlGroup1.TextVisible = false;
            // 
            // emptySpaceItem1
            // 
            this.emptySpaceItem1.AllowHotTrack = false;
            this.emptySpaceItem1.CustomizationFormText = "emptySpaceItem1";
            this.emptySpaceItem1.Location = new System.Drawing.Point(0, 34);
            this.emptySpaceItem1.Name = "emptySpaceItem1";
            this.emptySpaceItem1.Size = new System.Drawing.Size(269, 189);
            this.emptySpaceItem1.Text = "emptySpaceItem1";
            this.emptySpaceItem1.TextSize = new System.Drawing.Size(0, 0);
            // 
            // groupsLabel
            // 
            this.groupsLabel.Location = new System.Drawing.Point(89, 12);
            this.groupsLabel.Name = "groupsLabel";
            this.groupsLabel.Size = new System.Drawing.Size(12, 13);
            this.groupsLabel.StyleController = this.layoutControl1;
            this.groupsLabel.TabIndex = 4;
            this.groupsLabel.Text = "...";
            // 
            // groupsTotalCI
            // 
            this.groupsTotalCI.Control = this.groupsLabel;
            this.groupsTotalCI.CustomizationFormText = "layoutControlItem1";
            this.groupsTotalCI.Location = new System.Drawing.Point(0, 0);
            this.groupsTotalCI.Name = "groupsTotalCI";
            this.groupsTotalCI.Size = new System.Drawing.Size(269, 17);
            this.groupsTotalCI.Text = "Groups total";
            this.groupsTotalCI.TextSize = new System.Drawing.Size(68, 13);
            this.groupsTotalCI.TextToControlDistance = 9;
            // 
            // studentsLabel
            // 
            this.studentsLabel.Location = new System.Drawing.Point(89, 29);
            this.studentsLabel.Name = "studentsLabel";
            this.studentsLabel.Size = new System.Drawing.Size(12, 13);
            this.studentsLabel.StyleController = this.layoutControl1;
            this.studentsLabel.TabIndex = 5;
            this.studentsLabel.Text = "...";
            // 
            // studentsTotalCI
            // 
            this.studentsTotalCI.Control = this.studentsLabel;
            this.studentsTotalCI.CustomizationFormText = "Students total";
            this.studentsTotalCI.Location = new System.Drawing.Point(0, 17);
            this.studentsTotalCI.Name = "studentsTotalCI";
            this.studentsTotalCI.Size = new System.Drawing.Size(269, 17);
            this.studentsTotalCI.Text = "Students total";
            this.studentsTotalCI.TextSize = new System.Drawing.Size(68, 13);
            // 
            // GroupTotalDetailsUC
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.layoutControl1);
            this.Name = "GroupTotalDetailsUC";
            this.Size = new System.Drawing.Size(289, 243);
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).EndInit();
            this.layoutControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupsTotalCI)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.studentsTotalCI)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraLayout.LayoutControl layoutControl1;
        private DevExpress.XtraLayout.LayoutControlGroup layoutControlGroup1;
        private DevExpress.XtraLayout.EmptySpaceItem emptySpaceItem1;
        private DevExpress.XtraLayout.LayoutControlItem groupsTotalCI;
        private DevExpress.XtraLayout.LayoutControlItem studentsTotalCI;
        public DevExpress.XtraEditors.LabelControl groupsLabel;
        public DevExpress.XtraEditors.LabelControl studentsLabel;
    }
}
