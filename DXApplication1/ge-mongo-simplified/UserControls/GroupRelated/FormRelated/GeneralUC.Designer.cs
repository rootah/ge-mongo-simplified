namespace ge_mongo_simplified.UserControls.GroupRelated.FormRelated
{
    partial class GeneralUC
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
            this.groupLC = new DevExpress.XtraLayout.LayoutControl();
            this.lvlCBE = new DevExpress.XtraEditors.ComboBoxEdit();
            this.daysCBE = new DevExpress.XtraEditors.CheckedComboBoxEdit();
            this.numTE = new DevExpress.XtraEditors.TextEdit();
            this.durationCBE = new DevExpress.XtraEditors.ComboBoxEdit();
            this.timeTE = new DevExpress.XtraEditors.TextEdit();
            this.groupGeneralLC = new DevExpress.XtraLayout.LayoutControlGroup();
            this.numCI = new DevExpress.XtraLayout.LayoutControlItem();
            this.daysCI = new DevExpress.XtraLayout.LayoutControlItem();
            this.durationCI = new DevExpress.XtraLayout.LayoutControlItem();
            this.timeCI = new DevExpress.XtraLayout.LayoutControlItem();
            this.lvlCI = new DevExpress.XtraLayout.LayoutControlItem();
            this.emptySpaceItem1 = new DevExpress.XtraLayout.EmptySpaceItem();
            ((System.ComponentModel.ISupportInitialize)(this.groupLC)).BeginInit();
            this.groupLC.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.lvlCBE.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.daysCBE.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numTE.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.durationCBE.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.timeTE.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupGeneralLC)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numCI)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.daysCI)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.durationCI)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.timeCI)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lvlCI)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem1)).BeginInit();
            this.SuspendLayout();
            // 
            // groupLC
            // 
            this.groupLC.Controls.Add(this.lvlCBE);
            this.groupLC.Controls.Add(this.daysCBE);
            this.groupLC.Controls.Add(this.numTE);
            this.groupLC.Controls.Add(this.durationCBE);
            this.groupLC.Controls.Add(this.timeTE);
            this.groupLC.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupLC.Location = new System.Drawing.Point(0, 0);
            this.groupLC.Name = "groupLC";
            this.groupLC.OptionsCustomizationForm.DesignTimeCustomizationFormPositionAndSize = new System.Drawing.Rectangle(415, 163, 575, 517);
            this.groupLC.Root = this.groupGeneralLC;
            this.groupLC.ShowTemplates = true;
            this.groupLC.Size = new System.Drawing.Size(253, 138);
            this.groupLC.TabIndex = 0;
            this.groupLC.Text = "layoutControl1";
            // 
            // lvlCBE
            // 
            this.lvlCBE.EditValue = "";
            this.lvlCBE.EnterMoveNextControl = true;
            this.lvlCBE.Location = new System.Drawing.Point(93, 38);
            this.lvlCBE.Name = "lvlCBE";
            this.lvlCBE.Properties.AllowFocused = false;
            this.lvlCBE.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.lvlCBE.Properties.Items.AddRange(new object[] {
            "Beginner",
            "Elementary",
            "Pre-Intermediate",
            "Intermediate",
            "Upper-Intermediate",
            "Advanced"});
            this.lvlCBE.Properties.NullValuePromptShowForEmptyValue = true;
            this.lvlCBE.Size = new System.Drawing.Size(152, 20);
            this.lvlCBE.StyleController = this.groupLC;
            this.lvlCBE.TabIndex = 102;
            // 
            // daysCBE
            // 
            this.daysCBE.EditValue = "";
            this.daysCBE.EnterMoveNextControl = true;
            this.daysCBE.Location = new System.Drawing.Point(93, 110);
            this.daysCBE.Name = "daysCBE";
            this.daysCBE.Properties.AllowFocused = false;
            this.daysCBE.Properties.AllowMultiSelect = true;
            this.daysCBE.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.daysCBE.Properties.DropDownRows = 8;
            this.daysCBE.Properties.Items.AddRange(new DevExpress.XtraEditors.Controls.CheckedListBoxItem[] {
            new DevExpress.XtraEditors.Controls.CheckedListBoxItem("Monday", "Mon"),
            new DevExpress.XtraEditors.Controls.CheckedListBoxItem("Tuesday", "Tue"),
            new DevExpress.XtraEditors.Controls.CheckedListBoxItem("Wednesday", "Wed"),
            new DevExpress.XtraEditors.Controls.CheckedListBoxItem("Thursday", "Thu"),
            new DevExpress.XtraEditors.Controls.CheckedListBoxItem("Friday", "Fri"),
            new DevExpress.XtraEditors.Controls.CheckedListBoxItem("Saturday", "Sat")});
            this.daysCBE.Properties.PopupFormMinSize = new System.Drawing.Size(145, 0);
            this.daysCBE.Properties.PopupSizeable = false;
            this.daysCBE.Properties.SelectAllItemVisible = false;
            this.daysCBE.Properties.ShowPopupShadow = false;
            this.daysCBE.Properties.UsePopupControlMinSize = true;
            this.daysCBE.Size = new System.Drawing.Size(152, 20);
            this.daysCBE.StyleController = this.groupLC;
            this.daysCBE.TabIndex = 106;
            this.daysCBE.QueryPopUp += new System.ComponentModel.CancelEventHandler(this.daysCBE_QueryPopUp);
            // 
            // numTE
            // 
            this.numTE.EnterMoveNextControl = true;
            this.numTE.Location = new System.Drawing.Point(93, 8);
            this.numTE.Name = "numTE";
            this.numTE.Properties.Mask.EditMask = "\\d?\\d-\\d\\d";
            this.numTE.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.RegEx;
            this.numTE.Properties.Mask.ShowPlaceHolders = false;
            this.numTE.Properties.NullValuePrompt = "(!) can not be empty";
            this.numTE.Properties.NullValuePromptShowForEmptyValue = true;
            this.numTE.Properties.ValidateOnEnterKey = true;
            this.numTE.Size = new System.Drawing.Size(152, 20);
            this.numTE.StyleController = this.groupLC;
            this.numTE.TabIndex = 101;
            this.numTE.Validating += new System.ComponentModel.CancelEventHandler(this.numTE_Validating);
            // 
            // durationCBE
            // 
            this.durationCBE.EditValue = "";
            this.durationCBE.EnterMoveNextControl = true;
            this.durationCBE.Location = new System.Drawing.Point(93, 86);
            this.durationCBE.Name = "durationCBE";
            this.durationCBE.Properties.AllowFocused = false;
            this.durationCBE.Properties.AutoHeight = false;
            this.durationCBE.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.durationCBE.Properties.Items.AddRange(new object[] {
            "1 hour (60 min.)",
            "1.5 hour (90 min.)",
            "2 hour (120 min.)"});
            this.durationCBE.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor;
            this.durationCBE.Size = new System.Drawing.Size(152, 20);
            this.durationCBE.StyleController = this.groupLC;
            this.durationCBE.TabIndex = 103;
            // 
            // timeTE
            // 
            this.timeTE.EditValue = "";
            this.timeTE.EnterMoveNextControl = true;
            this.timeTE.Location = new System.Drawing.Point(93, 62);
            this.timeTE.Name = "timeTE";
            this.timeTE.Properties.DisplayFormat.FormatString = "HH:mm";
            this.timeTE.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.timeTE.Properties.EditFormat.FormatString = "HH:mm";
            this.timeTE.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.timeTE.Properties.EditValueChangedFiringMode = DevExpress.XtraEditors.Controls.EditValueChangedFiringMode.Buffered;
            this.timeTE.Properties.Mask.EditMask = "HH:mm";
            this.timeTE.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.DateTime;
            this.timeTE.Properties.Mask.UseMaskAsDisplayFormat = true;
            this.timeTE.Properties.NullValuePrompt = "class start time";
            this.timeTE.Properties.NullValuePromptShowForEmptyValue = true;
            this.timeTE.Size = new System.Drawing.Size(152, 20);
            this.timeTE.StyleController = this.groupLC;
            this.timeTE.TabIndex = 104;
            // 
            // groupGeneralLC
            // 
            this.groupGeneralLC.CustomizationFormText = "Root";
            this.groupGeneralLC.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True;
            this.groupGeneralLC.GroupBordersVisible = false;
            this.groupGeneralLC.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.numCI,
            this.daysCI,
            this.durationCI,
            this.timeCI,
            this.lvlCI,
            this.emptySpaceItem1});
            this.groupGeneralLC.Location = new System.Drawing.Point(0, 0);
            this.groupGeneralLC.Name = "groupGeneralLC";
            this.groupGeneralLC.Padding = new DevExpress.XtraLayout.Utils.Padding(6, 6, 6, 6);
            this.groupGeneralLC.Size = new System.Drawing.Size(253, 138);
            this.groupGeneralLC.Text = "groupGeneralLC";
            this.groupGeneralLC.TextVisible = false;
            // 
            // numCI
            // 
            this.numCI.Control = this.numTE;
            this.numCI.CustomizationFormText = "Group no.";
            this.numCI.Location = new System.Drawing.Point(0, 0);
            this.numCI.Name = "numCI";
            this.numCI.Size = new System.Drawing.Size(241, 24);
            this.numCI.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.SupportHorzAlignment;
            this.numCI.Text = "Group No.";
            this.numCI.TextAlignMode = DevExpress.XtraLayout.TextAlignModeItem.CustomSize;
            this.numCI.TextSize = new System.Drawing.Size(80, 13);
            this.numCI.TextToControlDistance = 5;
            // 
            // daysCI
            // 
            this.daysCI.Control = this.daysCBE;
            this.daysCI.CustomizationFormText = "Days";
            this.daysCI.Location = new System.Drawing.Point(0, 102);
            this.daysCI.Name = "daysCI";
            this.daysCI.Size = new System.Drawing.Size(241, 24);
            this.daysCI.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.SupportHorzAlignment;
            this.daysCI.Text = "Days";
            this.daysCI.TextAlignMode = DevExpress.XtraLayout.TextAlignModeItem.CustomSize;
            this.daysCI.TextSize = new System.Drawing.Size(80, 13);
            this.daysCI.TextToControlDistance = 5;
            // 
            // durationCI
            // 
            this.durationCI.Control = this.durationCBE;
            this.durationCI.CustomizationFormText = "Duration";
            this.durationCI.Location = new System.Drawing.Point(0, 78);
            this.durationCI.MaxSize = new System.Drawing.Size(0, 24);
            this.durationCI.MinSize = new System.Drawing.Size(109, 24);
            this.durationCI.Name = "durationCI";
            this.durationCI.Size = new System.Drawing.Size(241, 24);
            this.durationCI.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom;
            this.durationCI.Text = "Duration";
            this.durationCI.TextAlignMode = DevExpress.XtraLayout.TextAlignModeItem.CustomSize;
            this.durationCI.TextSize = new System.Drawing.Size(80, 13);
            this.durationCI.TextToControlDistance = 5;
            // 
            // timeCI
            // 
            this.timeCI.Control = this.timeTE;
            this.timeCI.CustomizationFormText = "Time";
            this.timeCI.Location = new System.Drawing.Point(0, 54);
            this.timeCI.Name = "timeCI";
            this.timeCI.Size = new System.Drawing.Size(241, 24);
            this.timeCI.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.SupportHorzAlignment;
            this.timeCI.Text = "Time";
            this.timeCI.TextAlignMode = DevExpress.XtraLayout.TextAlignModeItem.CustomSize;
            this.timeCI.TextSize = new System.Drawing.Size(80, 13);
            this.timeCI.TextToControlDistance = 5;
            // 
            // lvlCI
            // 
            this.lvlCI.Control = this.lvlCBE;
            this.lvlCI.CustomizationFormText = "Level";
            this.lvlCI.Location = new System.Drawing.Point(0, 30);
            this.lvlCI.Name = "lvlCI";
            this.lvlCI.Size = new System.Drawing.Size(241, 24);
            this.lvlCI.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.SupportHorzAlignment;
            this.lvlCI.Text = "Level";
            this.lvlCI.TextAlignMode = DevExpress.XtraLayout.TextAlignModeItem.CustomSize;
            this.lvlCI.TextSize = new System.Drawing.Size(80, 13);
            this.lvlCI.TextToControlDistance = 5;
            // 
            // emptySpaceItem1
            // 
            this.emptySpaceItem1.AllowHotTrack = false;
            this.emptySpaceItem1.CustomizationFormText = "emptySpaceItem1";
            this.emptySpaceItem1.Location = new System.Drawing.Point(0, 24);
            this.emptySpaceItem1.MaxSize = new System.Drawing.Size(0, 6);
            this.emptySpaceItem1.MinSize = new System.Drawing.Size(10, 6);
            this.emptySpaceItem1.Name = "emptySpaceItem1";
            this.emptySpaceItem1.Size = new System.Drawing.Size(241, 6);
            this.emptySpaceItem1.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom;
            this.emptySpaceItem1.Text = "emptySpaceItem1";
            this.emptySpaceItem1.TextSize = new System.Drawing.Size(0, 0);
            // 
            // GeneralUC
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.Controls.Add(this.groupLC);
            this.Name = "GeneralUC";
            this.Size = new System.Drawing.Size(253, 138);
            ((System.ComponentModel.ISupportInitialize)(this.groupLC)).EndInit();
            this.groupLC.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.lvlCBE.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.daysCBE.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numTE.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.durationCBE.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.timeTE.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupGeneralLC)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numCI)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.daysCI)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.durationCI)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.timeCI)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lvlCI)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        public DevExpress.XtraLayout.LayoutControl groupLC;
        private DevExpress.XtraLayout.LayoutControlItem numCI;
        private DevExpress.XtraLayout.LayoutControlItem timeCI;
        private DevExpress.XtraLayout.LayoutControlItem daysCI;
        private DevExpress.XtraLayout.LayoutControlItem durationCI;
        private DevExpress.XtraLayout.LayoutControlItem lvlCI;
        public DevExpress.XtraLayout.LayoutControlGroup groupGeneralLC;
        private DevExpress.XtraLayout.EmptySpaceItem emptySpaceItem1;
        public DevExpress.XtraEditors.TextEdit numTE;
        public DevExpress.XtraEditors.CheckedComboBoxEdit daysCBE;
        public DevExpress.XtraEditors.ComboBoxEdit durationCBE;
        public DevExpress.XtraEditors.ComboBoxEdit lvlCBE;
        public DevExpress.XtraEditors.TextEdit timeTE;
    }
}
