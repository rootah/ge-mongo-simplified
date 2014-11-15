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
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject1 = new DevExpress.Utils.SerializableAppearanceObject();
            this.orgLC = new DevExpress.XtraLayout.LayoutControl();
            this.groupCB = new DevExpress.XtraEditors.ComboBoxEdit();
            this.sourceCB = new DevExpress.XtraEditors.ComboBoxEdit();
            this.reasonTE = new DevExpress.XtraEditors.TextEdit();
            this.startDE = new DevExpress.XtraEditors.DateEdit();
            this.endDE = new DevExpress.XtraEditors.DateEdit();
            this.flyoutPanel1 = new DevExpress.Utils.FlyoutPanel();
            this.flyoutPanelControl1 = new DevExpress.Utils.FlyoutPanelControl();
            this.simpleButton1 = new DevExpress.XtraEditors.SimpleButton();
            this.textEdit1 = new DevExpress.XtraEditors.TextEdit();
            this.orgCG = new DevExpress.XtraLayout.LayoutControlGroup();
            this.sourceCI = new DevExpress.XtraLayout.LayoutControlItem();
            this.startCI = new DevExpress.XtraLayout.LayoutControlItem();
            this.endCI = new DevExpress.XtraLayout.LayoutControlItem();
            this.reasonCI = new DevExpress.XtraLayout.LayoutControlItem();
            this.groupCI = new DevExpress.XtraLayout.LayoutControlItem();
            this.emptySpaceItem1 = new DevExpress.XtraLayout.EmptySpaceItem();
            ((System.ComponentModel.ISupportInitialize)(this.orgLC)).BeginInit();
            this.orgLC.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.groupCB.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sourceCB.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.reasonTE.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.startDE.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.startDE.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.endDE.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.endDE.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.flyoutPanel1)).BeginInit();
            this.flyoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.flyoutPanelControl1)).BeginInit();
            this.flyoutPanelControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.textEdit1.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.orgCG)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sourceCI)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.startCI)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.endCI)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.reasonCI)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupCI)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem1)).BeginInit();
            this.SuspendLayout();
            // 
            // orgLC
            // 
            this.orgLC.Controls.Add(this.groupCB);
            this.orgLC.Controls.Add(this.sourceCB);
            this.orgLC.Controls.Add(this.reasonTE);
            this.orgLC.Controls.Add(this.startDE);
            this.orgLC.Controls.Add(this.endDE);
            this.orgLC.Controls.Add(this.flyoutPanel1);
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
            this.groupCB.SelectedIndexChanged += new System.EventHandler(this.groupCB_SelectedIndexChanged);
            // 
            // sourceCB
            // 
            this.sourceCB.Location = new System.Drawing.Point(91, 32);
            this.sourceCB.Name = "sourceCB";
            this.sourceCB.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo),
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Plus, "", -1, true, true, true, DevExpress.XtraEditors.ImageLocation.MiddleCenter, null, new DevExpress.Utils.KeyShortcut(System.Windows.Forms.Keys.None), serializableAppearanceObject1, "", null, null, true)});
            this.sourceCB.Properties.Items.AddRange(new object[] {
            "Outdoor",
            "Ads",
            "Recommendation"});
            this.sourceCB.Properties.ButtonClick += new DevExpress.XtraEditors.Controls.ButtonPressedEventHandler(this.sourceCB_Properties_ButtonClick);
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
            // flyoutPanel1
            // 
            this.flyoutPanel1.Controls.Add(this.flyoutPanelControl1);
            this.flyoutPanel1.Location = new System.Drawing.Point(8, 205);
            this.flyoutPanel1.Name = "flyoutPanel1";
            this.flyoutPanel1.Options.AnchorType = DevExpress.Utils.Win.PopupToolWindowAnchor.TopLeft;
            this.flyoutPanel1.Options.AnimationType = DevExpress.Utils.Win.PopupToolWindowAnimation.Fade;
            this.flyoutPanel1.Options.CloseOnOuterClick = true;
            this.flyoutPanel1.Options.HorzIndent = 90;
            this.flyoutPanel1.Options.VertIndent = 62;
            this.flyoutPanel1.OptionsButtonPanel.ButtonPanelLocation = DevExpress.Utils.FlyoutPanelButtonPanelLocation.Bottom;
            this.flyoutPanel1.OptionsButtonPanel.Buttons.AddRange(new DevExpress.XtraEditors.ButtonPanel.IBaseButton[] {
            new DevExpress.Utils.PeekFormButton()});
            this.flyoutPanel1.OwnerControl = this;
            this.flyoutPanel1.Size = new System.Drawing.Size(244, 53);
            this.flyoutPanel1.TabIndex = 1;
            // 
            // flyoutPanelControl1
            // 
            this.flyoutPanelControl1.Controls.Add(this.simpleButton1);
            this.flyoutPanelControl1.Controls.Add(this.textEdit1);
            this.flyoutPanelControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flyoutPanelControl1.FlyoutPanel = this.flyoutPanel1;
            this.flyoutPanelControl1.Location = new System.Drawing.Point(0, 0);
            this.flyoutPanelControl1.Name = "flyoutPanelControl1";
            this.flyoutPanelControl1.Size = new System.Drawing.Size(244, 53);
            this.flyoutPanelControl1.TabIndex = 0;
            // 
            // simpleButton1
            // 
            this.simpleButton1.Location = new System.Drawing.Point(184, 14);
            this.simpleButton1.Name = "simpleButton1";
            this.simpleButton1.Size = new System.Drawing.Size(46, 23);
            this.simpleButton1.TabIndex = 1;
            this.simpleButton1.Text = "add";
            // 
            // textEdit1
            // 
            this.textEdit1.Location = new System.Drawing.Point(5, 16);
            this.textEdit1.Name = "textEdit1";
            this.textEdit1.Size = new System.Drawing.Size(173, 20);
            this.textEdit1.TabIndex = 0;
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
            this.groupCI,
            this.emptySpaceItem1});
            this.orgCG.Location = new System.Drawing.Point(0, 0);
            this.orgCG.Name = "Root";
            this.orgCG.Padding = new DevExpress.XtraLayout.Utils.Padding(6, 6, 6, 6);
            this.orgCG.Size = new System.Drawing.Size(260, 266);
            this.orgCG.Text = "Root";
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
            this.reasonCI.Size = new System.Drawing.Size(248, 24);
            this.reasonCI.Text = "Reason";
            this.reasonCI.TextAlignMode = DevExpress.XtraLayout.TextAlignModeItem.CustomSize;
            this.reasonCI.TextSize = new System.Drawing.Size(80, 13);
            this.reasonCI.TextToControlDistance = 3;
            // 
            // groupCI
            // 
            this.groupCI.AppearanceItemCaption.ForeColor = System.Drawing.Color.OrangeRed;
            this.groupCI.AppearanceItemCaption.Options.UseForeColor = true;
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
            // emptySpaceItem1
            // 
            this.emptySpaceItem1.AllowHotTrack = false;
            this.emptySpaceItem1.CustomizationFormText = "emptySpaceItem1";
            this.emptySpaceItem1.Location = new System.Drawing.Point(0, 140);
            this.emptySpaceItem1.Name = "emptySpaceItem1";
            this.emptySpaceItem1.Size = new System.Drawing.Size(248, 114);
            this.emptySpaceItem1.Text = "emptySpaceItem1";
            this.emptySpaceItem1.TextSize = new System.Drawing.Size(0, 0);
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
            ((System.ComponentModel.ISupportInitialize)(this.flyoutPanel1)).EndInit();
            this.flyoutPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.flyoutPanelControl1)).EndInit();
            this.flyoutPanelControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.textEdit1.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.orgCG)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sourceCI)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.startCI)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.endCI)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.reasonCI)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupCI)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem1)).EndInit();
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
        private DevExpress.XtraLayout.EmptySpaceItem emptySpaceItem1;
        private DevExpress.Utils.FlyoutPanel flyoutPanel1;
        private DevExpress.Utils.FlyoutPanelControl flyoutPanelControl1;
        private DevExpress.XtraEditors.TextEdit textEdit1;
        private DevExpress.XtraEditors.SimpleButton simpleButton1;
    }
}
