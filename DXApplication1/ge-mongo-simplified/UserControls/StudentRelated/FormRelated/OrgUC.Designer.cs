namespace ge_mongo_simplified.UserControls.StudentRelated.FormRelated
{
    partial class OrgUC
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private static System.ComponentModel.IContainer components = null;

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
            this.orgLC = new DevExpress.XtraLayout.LayoutControl();
            this.groupCB = new DevExpress.XtraEditors.ComboBoxEdit();
            this.sourceCB = new DevExpress.XtraEditors.ComboBoxEdit();
            this.reasonTE = new DevExpress.XtraEditors.TextEdit();
            this.startDE = new DevExpress.XtraEditors.DateEdit();
            this.endDE = new DevExpress.XtraEditors.DateEdit();
            this.orgCG = new DevExpress.XtraLayout.LayoutControlGroup();
            this.sourceCI = new DevExpress.XtraLayout.LayoutControlItem();
            this.startCI = new DevExpress.XtraLayout.LayoutControlItem();
            this.endCI = new DevExpress.XtraLayout.LayoutControlItem();
            this.reasonCI = new DevExpress.XtraLayout.LayoutControlItem();
            this.groupCI = new DevExpress.XtraLayout.LayoutControlItem();
            ((System.ComponentModel.ISupportInitialize)(this.orgLC)).BeginInit();
            this.orgLC.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.groupCB.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sourceCB.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.reasonTE.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.startDE.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.startDE.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.endDE.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.endDE.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.orgCG)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sourceCI)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.startCI)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.endCI)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.reasonCI)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupCI)).BeginInit();
            this.SuspendLayout();
            // 
            // orgLC
            // 
            this.orgLC.Controls.Add(this.groupCB);
            this.orgLC.Controls.Add(this.sourceCB);
            this.orgLC.Controls.Add(this.reasonTE);
            this.orgLC.Controls.Add(this.startDE);
            this.orgLC.Controls.Add(this.endDE);
            this.orgLC.Dock = System.Windows.Forms.DockStyle.Fill;
            this.orgLC.Location = new System.Drawing.Point(0, 0);
            this.orgLC.Name = "orgLC";
            this.orgLC.OptionsCustomizationForm.DesignTimeCustomizationFormPositionAndSize = new System.Drawing.Rectangle(529, 170, 390, 350);
            this.orgLC.Root = this.orgCG;
            this.orgLC.Size = new System.Drawing.Size(260, 266);
            this.orgLC.TabIndex = 0;
            this.orgLC.Text = "layoutControl1";
            // 
            // groupCB
            // 
            this.groupCB.Location = new System.Drawing.Point(91, 8);
            this.groupCB.Name = "groupCB";
            this.groupCB.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.groupCB.Size = new System.Drawing.Size(161, 20);
            this.groupCB.StyleController = this.orgLC;
            this.groupCB.TabIndex = 9;
            // 
            // sourceCB
            // 
            this.sourceCB.Location = new System.Drawing.Point(91, 32);
            this.sourceCB.Name = "sourceCB";
            this.sourceCB.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.sourceCB.Properties.Items.AddRange(new object[] {
            "Outdoor",
            "Ads",
            "Recommendation"});
            this.sourceCB.Size = new System.Drawing.Size(161, 20);
            this.sourceCB.StyleController = this.orgLC;
            this.sourceCB.TabIndex = 5;
            // 
            // reasonTE
            // 
            this.reasonTE.Location = new System.Drawing.Point(91, 124);
            this.reasonTE.Name = "reasonTE";
            this.reasonTE.Size = new System.Drawing.Size(161, 20);
            this.reasonTE.StyleController = this.orgLC;
            this.reasonTE.TabIndex = 8;
            // 
            // startDE
            // 
            this.startDE.EditValue = null;
            this.startDE.Location = new System.Drawing.Point(91, 66);
            this.startDE.Name = "startDE";
            this.startDE.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.startDE.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.startDE.Properties.Mask.EditMask = "";
            this.startDE.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.None;
            this.startDE.Size = new System.Drawing.Size(161, 20);
            this.startDE.StyleController = this.orgLC;
            this.startDE.TabIndex = 6;
            // 
            // endDE
            // 
            this.endDE.EditValue = null;
            this.endDE.Location = new System.Drawing.Point(91, 90);
            this.endDE.Name = "endDE";
            this.endDE.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.endDE.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.endDE.Properties.Mask.EditMask = "";
            this.endDE.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.None;
            this.endDE.Size = new System.Drawing.Size(161, 20);
            this.endDE.StyleController = this.orgLC;
            this.endDE.TabIndex = 7;
            // 
            // orgCG
            // 
            this.orgCG.CustomizationFormText = "Root";
            this.orgCG.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True;
            this.orgCG.GroupBordersVisible = false;
            this.orgCG.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.sourceCI,
            this.startCI,
            this.endCI,
            this.reasonCI,
            this.groupCI});
            this.orgCG.Location = new System.Drawing.Point(0, 0);
            this.orgCG.Name = "orgCG";
            this.orgCG.Padding = new DevExpress.XtraLayout.Utils.Padding(6, 6, 6, 6);
            this.orgCG.Size = new System.Drawing.Size(260, 266);
            this.orgCG.Text = "orgCG";
            this.orgCG.TextVisible = false;
            // 
            // sourceCI
            // 
            this.sourceCI.Control = this.sourceCB;
            this.sourceCI.CustomizationFormText = "Source";
            this.sourceCI.Location = new System.Drawing.Point(0, 24);
            this.sourceCI.Name = "sourceCI";
            this.sourceCI.Size = new System.Drawing.Size(248, 34);
            this.sourceCI.Spacing = new DevExpress.XtraLayout.Utils.Padding(0, 0, 0, 10);
            this.sourceCI.Text = "Source";
            this.sourceCI.TextAlignMode = DevExpress.XtraLayout.TextAlignModeItem.CustomSize;
            this.sourceCI.TextSize = new System.Drawing.Size(80, 13);
            this.sourceCI.TextToControlDistance = 3;
            // 
            // startCI
            // 
            this.startCI.Control = this.startDE;
            this.startCI.CustomizationFormText = "Start";
            this.startCI.Location = new System.Drawing.Point(0, 58);
            this.startCI.Name = "startCI";
            this.startCI.Size = new System.Drawing.Size(248, 24);
            this.startCI.Text = "Start";
            this.startCI.TextAlignMode = DevExpress.XtraLayout.TextAlignModeItem.CustomSize;
            this.startCI.TextSize = new System.Drawing.Size(80, 13);
            this.startCI.TextToControlDistance = 3;
            // 
            // endCI
            // 
            this.endCI.Control = this.endDE;
            this.endCI.CustomizationFormText = "End";
            this.endCI.Location = new System.Drawing.Point(0, 82);
            this.endCI.Name = "endCI";
            this.endCI.Size = new System.Drawing.Size(248, 34);
            this.endCI.Spacing = new DevExpress.XtraLayout.Utils.Padding(0, 0, 0, 10);
            this.endCI.Text = "End";
            this.endCI.TextAlignMode = DevExpress.XtraLayout.TextAlignModeItem.CustomSize;
            this.endCI.TextSize = new System.Drawing.Size(80, 13);
            this.endCI.TextToControlDistance = 3;
            // 
            // reasonCI
            // 
            this.reasonCI.Control = this.reasonTE;
            this.reasonCI.CustomizationFormText = "Reason";
            this.reasonCI.Location = new System.Drawing.Point(0, 116);
            this.reasonCI.Name = "reasonCI";
            this.reasonCI.Size = new System.Drawing.Size(248, 138);
            this.reasonCI.Text = "Reason";
            this.reasonCI.TextAlignMode = DevExpress.XtraLayout.TextAlignModeItem.CustomSize;
            this.reasonCI.TextSize = new System.Drawing.Size(80, 13);
            this.reasonCI.TextToControlDistance = 3;
            // 
            // groupCI
            // 
            this.groupCI.Control = this.groupCB;
            this.groupCI.CustomizationFormText = "Group";
            this.groupCI.Location = new System.Drawing.Point(0, 0);
            this.groupCI.Name = "groupCI";
            this.groupCI.Size = new System.Drawing.Size(248, 24);
            this.groupCI.Text = "Group";
            this.groupCI.TextAlignMode = DevExpress.XtraLayout.TextAlignModeItem.CustomSize;
            this.groupCI.TextSize = new System.Drawing.Size(80, 20);
            this.groupCI.TextToControlDistance = 3;
            // 
            // OrgUC
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.orgLC);
            this.Name = "OrgUC";
            this.Size = new System.Drawing.Size(260, 266);
            ((System.ComponentModel.ISupportInitialize)(this.orgLC)).EndInit();
            this.orgLC.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.groupCB.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sourceCB.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.reasonTE.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.startDE.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.startDE.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.endDE.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.endDE.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.orgCG)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sourceCI)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.startCI)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.endCI)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.reasonCI)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupCI)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.TextEdit reasonTE;
        private DevExpress.XtraLayout.LayoutControlItem sourceCI;
        private DevExpress.XtraLayout.LayoutControlItem startCI;
        private DevExpress.XtraLayout.LayoutControlItem endCI;
        private DevExpress.XtraLayout.LayoutControlItem reasonCI;
        public DevExpress.XtraLayout.LayoutControl orgLC;
        private DevExpress.XtraEditors.DateEdit startDE;
        private DevExpress.XtraEditors.DateEdit endDE;
        public static DevExpress.XtraEditors.ComboBoxEdit groupnoCB;
        private DevExpress.XtraLayout.LayoutControlGroup orgCG;
        public DevExpress.XtraEditors.ComboBoxEdit groupCB;
        private DevExpress.XtraLayout.LayoutControlItem groupCI;
        public DevExpress.XtraEditors.ComboBoxEdit sourceCB;
    }
}
