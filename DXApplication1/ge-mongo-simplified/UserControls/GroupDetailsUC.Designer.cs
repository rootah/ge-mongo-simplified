namespace ge_mongo_simplified.UserControls
{
    partial class GroupDetailsUC
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
            this.idLabel = new DevExpress.XtraEditors.LabelControl();
            this.durationLabel = new DevExpress.XtraEditors.LabelControl();
            this.daysLabel = new DevExpress.XtraEditors.LabelControl();
            this.timeLabel = new DevExpress.XtraEditors.LabelControl();
            this.levelLabel = new DevExpress.XtraEditors.LabelControl();
            this.groupnoLabel = new DevExpress.XtraEditors.LabelControl();
            this.layoutControlGroup1 = new DevExpress.XtraLayout.LayoutControlGroup();
            this.emptySpaceItem1 = new DevExpress.XtraLayout.EmptySpaceItem();
            this.groupnoCI = new DevExpress.XtraLayout.LayoutControlItem();
            this.levelCI = new DevExpress.XtraLayout.LayoutControlItem();
            this.timeCI = new DevExpress.XtraLayout.LayoutControlItem();
            this.durationCI = new DevExpress.XtraLayout.LayoutControlItem();
            this.daysCI = new DevExpress.XtraLayout.LayoutControlItem();
            this.simpleSeparator1 = new DevExpress.XtraLayout.SimpleSeparator();
            this.idCI = new DevExpress.XtraLayout.LayoutControlItem();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).BeginInit();
            this.layoutControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupnoCI)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.levelCI)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.timeCI)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.durationCI)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.daysCI)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.simpleSeparator1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.idCI)).BeginInit();
            this.SuspendLayout();
            // 
            // layoutControl1
            // 
            this.layoutControl1.Controls.Add(this.idLabel);
            this.layoutControl1.Controls.Add(this.durationLabel);
            this.layoutControl1.Controls.Add(this.daysLabel);
            this.layoutControl1.Controls.Add(this.timeLabel);
            this.layoutControl1.Controls.Add(this.levelLabel);
            this.layoutControl1.Controls.Add(this.groupnoLabel);
            this.layoutControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.layoutControl1.Location = new System.Drawing.Point(0, 0);
            this.layoutControl1.Name = "layoutControl1";
            this.layoutControl1.OptionsCustomizationForm.DesignTimeCustomizationFormPositionAndSize = new System.Drawing.Rectangle(537, 150, 452, 351);
            this.layoutControl1.Root = this.layoutControlGroup1;
            this.layoutControl1.Size = new System.Drawing.Size(372, 327);
            this.layoutControl1.TabIndex = 0;
            this.layoutControl1.Text = "layoutControl1";
            // 
            // idLabel
            // 
            this.idLabel.Location = new System.Drawing.Point(64, 108);
            this.idLabel.Name = "idLabel";
            this.idLabel.Size = new System.Drawing.Size(12, 13);
            this.idLabel.StyleController = this.layoutControl1;
            this.idLabel.TabIndex = 9;
            this.idLabel.Text = "...";
            // 
            // durationLabel
            // 
            this.durationLabel.Location = new System.Drawing.Point(64, 80);
            this.durationLabel.Name = "durationLabel";
            this.durationLabel.Size = new System.Drawing.Size(12, 13);
            this.durationLabel.StyleController = this.layoutControl1;
            this.durationLabel.TabIndex = 8;
            this.durationLabel.Text = "...";
            // 
            // daysLabel
            // 
            this.daysLabel.Location = new System.Drawing.Point(64, 46);
            this.daysLabel.Name = "daysLabel";
            this.daysLabel.Size = new System.Drawing.Size(12, 13);
            this.daysLabel.StyleController = this.layoutControl1;
            this.daysLabel.TabIndex = 7;
            this.daysLabel.Text = "...";
            // 
            // timeLabel
            // 
            this.timeLabel.Location = new System.Drawing.Point(64, 63);
            this.timeLabel.Name = "timeLabel";
            this.timeLabel.Size = new System.Drawing.Size(12, 13);
            this.timeLabel.StyleController = this.layoutControl1;
            this.timeLabel.TabIndex = 6;
            this.timeLabel.Text = "...";
            // 
            // levelLabel
            // 
            this.levelLabel.Location = new System.Drawing.Point(64, 29);
            this.levelLabel.Name = "levelLabel";
            this.levelLabel.Size = new System.Drawing.Size(12, 13);
            this.levelLabel.StyleController = this.layoutControl1;
            this.levelLabel.TabIndex = 5;
            this.levelLabel.Text = "...";
            // 
            // groupnoLabel
            // 
            this.groupnoLabel.Location = new System.Drawing.Point(64, 12);
            this.groupnoLabel.Name = "groupnoLabel";
            this.groupnoLabel.Size = new System.Drawing.Size(12, 13);
            this.groupnoLabel.StyleController = this.layoutControl1;
            this.groupnoLabel.TabIndex = 4;
            this.groupnoLabel.Text = "...";
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
            this.groupnoCI,
            this.levelCI,
            this.timeCI,
            this.durationCI,
            this.daysCI,
            this.simpleSeparator1,
            this.idCI});
            this.layoutControlGroup1.Location = new System.Drawing.Point(0, 0);
            this.layoutControlGroup1.Name = "Root";
            this.layoutControlGroup1.OptionsItemText.TextToControlDistance = 9;
            this.layoutControlGroup1.Size = new System.Drawing.Size(372, 327);
            this.layoutControlGroup1.Text = "Root";
            this.layoutControlGroup1.TextVisible = false;
            // 
            // emptySpaceItem1
            // 
            this.emptySpaceItem1.AllowHotTrack = false;
            this.emptySpaceItem1.CustomizationFormText = "emptySpaceItem1";
            this.emptySpaceItem1.Location = new System.Drawing.Point(0, 113);
            this.emptySpaceItem1.Name = "emptySpaceItem1";
            this.emptySpaceItem1.Size = new System.Drawing.Size(352, 194);
            this.emptySpaceItem1.Text = "emptySpaceItem1";
            this.emptySpaceItem1.TextSize = new System.Drawing.Size(0, 0);
            // 
            // groupnoCI
            // 
            this.groupnoCI.Control = this.groupnoLabel;
            this.groupnoCI.CustomizationFormText = "Group #";
            this.groupnoCI.Location = new System.Drawing.Point(0, 0);
            this.groupnoCI.Name = "groupnoCI";
            this.groupnoCI.Size = new System.Drawing.Size(352, 17);
            this.groupnoCI.Text = "Group #";
            this.groupnoCI.TextSize = new System.Drawing.Size(43, 13);
            // 
            // levelCI
            // 
            this.levelCI.Control = this.levelLabel;
            this.levelCI.CustomizationFormText = "Level";
            this.levelCI.Location = new System.Drawing.Point(0, 17);
            this.levelCI.Name = "levelCI";
            this.levelCI.Size = new System.Drawing.Size(352, 17);
            this.levelCI.Text = "Level";
            this.levelCI.TextSize = new System.Drawing.Size(43, 13);
            // 
            // timeCI
            // 
            this.timeCI.Control = this.timeLabel;
            this.timeCI.CustomizationFormText = "Time";
            this.timeCI.Location = new System.Drawing.Point(0, 51);
            this.timeCI.Name = "timeCI";
            this.timeCI.Size = new System.Drawing.Size(352, 17);
            this.timeCI.Text = "Time";
            this.timeCI.TextSize = new System.Drawing.Size(43, 13);
            // 
            // durationCI
            // 
            this.durationCI.Control = this.durationLabel;
            this.durationCI.CustomizationFormText = "Duration";
            this.durationCI.Location = new System.Drawing.Point(0, 68);
            this.durationCI.Name = "durationCI";
            this.durationCI.Size = new System.Drawing.Size(352, 17);
            this.durationCI.Text = "Duration";
            this.durationCI.TextSize = new System.Drawing.Size(43, 13);
            // 
            // daysCI
            // 
            this.daysCI.Control = this.daysLabel;
            this.daysCI.CustomizationFormText = "Days";
            this.daysCI.Location = new System.Drawing.Point(0, 34);
            this.daysCI.Name = "daysCI";
            this.daysCI.Size = new System.Drawing.Size(352, 17);
            this.daysCI.Text = "Days";
            this.daysCI.TextSize = new System.Drawing.Size(43, 13);
            // 
            // simpleSeparator1
            // 
            this.simpleSeparator1.AllowHotTrack = false;
            this.simpleSeparator1.CustomizationFormText = "simpleSeparator1";
            this.simpleSeparator1.Location = new System.Drawing.Point(0, 85);
            this.simpleSeparator1.Name = "simpleSeparator1";
            this.simpleSeparator1.Size = new System.Drawing.Size(352, 11);
            this.simpleSeparator1.Spacing = new DevExpress.XtraLayout.Utils.Padding(0, 0, 5, 5);
            this.simpleSeparator1.Text = "simpleSeparator1";
            // 
            // idCI
            // 
            this.idCI.Control = this.idLabel;
            this.idCI.CustomizationFormText = "Group ID";
            this.idCI.Location = new System.Drawing.Point(0, 96);
            this.idCI.Name = "idCI";
            this.idCI.Size = new System.Drawing.Size(352, 17);
            this.idCI.Text = "Group ID";
            this.idCI.TextSize = new System.Drawing.Size(43, 13);
            // 
            // GroupDetailsUC
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.layoutControl1);
            this.Name = "GroupDetailsUC";
            this.Size = new System.Drawing.Size(372, 327);
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).EndInit();
            this.layoutControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupnoCI)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.levelCI)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.timeCI)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.durationCI)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.daysCI)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.simpleSeparator1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.idCI)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraLayout.EmptySpaceItem emptySpaceItem1;
        private DevExpress.XtraEditors.LabelControl levelLabel;
        private DevExpress.XtraEditors.LabelControl groupnoLabel;
        private DevExpress.XtraEditors.LabelControl timeLabel;
        private DevExpress.XtraEditors.LabelControl daysLabel;
        private DevExpress.XtraEditors.LabelControl durationLabel;
        private DevExpress.XtraLayout.LayoutControl layoutControl1;
        private DevExpress.XtraLayout.LayoutControlGroup layoutControlGroup1;
        public DevExpress.XtraLayout.LayoutControlItem groupnoCI;
        public DevExpress.XtraLayout.LayoutControlItem levelCI;
        public DevExpress.XtraLayout.LayoutControlItem timeCI;
        public DevExpress.XtraLayout.LayoutControlItem daysCI;
        public DevExpress.XtraLayout.LayoutControlItem durationCI;
        private DevExpress.XtraEditors.LabelControl idLabel;
        private DevExpress.XtraLayout.SimpleSeparator simpleSeparator1;
        public DevExpress.XtraLayout.LayoutControlItem idCI;
    }
}
