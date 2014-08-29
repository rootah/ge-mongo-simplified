namespace ge_mongo_simplified.UserControls
{
    partial class GroupGeneralInfoUc
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
            this.tagsButt = new DevExpress.XtraEditors.CheckButton();
            this.tokenEdit = new DevExpress.XtraEditors.TokenEdit();
            this.lvlComboBox = new DevExpress.XtraEditors.ComboBoxEdit();
            this.statusComboBox = new DevExpress.XtraEditors.ComboBoxEdit();
            this.cancelButt = new DevExpress.XtraEditors.SimpleButton();
            this.okButt = new DevExpress.XtraEditors.SimpleButton();
            this.daysSelector = new DevExpress.XtraEditors.CheckedComboBoxEdit();
            this.numTE = new DevExpress.XtraEditors.TextEdit();
            this.durationTE = new DevExpress.XtraEditors.ComboBoxEdit();
            this.timeTE = new DevExpress.XtraEditors.TextEdit();
            this.layoutControlGroup1 = new DevExpress.XtraLayout.LayoutControlGroup();
            this.okBtn = new DevExpress.XtraLayout.LayoutControlItem();
            this.cancelBtn = new DevExpress.XtraLayout.LayoutControlItem();
            this.emptySpaceItem1 = new DevExpress.XtraLayout.EmptySpaceItem();
            this.layoutControlItem6 = new DevExpress.XtraLayout.LayoutControlItem();
            this.groupnoField = new DevExpress.XtraLayout.LayoutControlItem();
            this.daysCombo = new DevExpress.XtraLayout.LayoutControlItem();
            this.tagsControl = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem1 = new DevExpress.XtraLayout.LayoutControlItem();
            this.fixedTime = new DevExpress.XtraLayout.LayoutControlItem();
            this.simpleSeparator1 = new DevExpress.XtraLayout.SimpleSeparator();
            this.layoutControlItem2 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem3 = new DevExpress.XtraLayout.LayoutControlItem();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).BeginInit();
            this.layoutControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tokenEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lvlComboBox.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.statusComboBox.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.daysSelector.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numTE.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.durationTE.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.timeTE.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.okBtn)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cancelBtn)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupnoField)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.daysCombo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tagsControl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fixedTime)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.simpleSeparator1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem3)).BeginInit();
            this.SuspendLayout();
            // 
            // layoutControl1
            // 
            this.layoutControl1.Controls.Add(this.tagsButt);
            this.layoutControl1.Controls.Add(this.tokenEdit);
            this.layoutControl1.Controls.Add(this.lvlComboBox);
            this.layoutControl1.Controls.Add(this.statusComboBox);
            this.layoutControl1.Controls.Add(this.cancelButt);
            this.layoutControl1.Controls.Add(this.okButt);
            this.layoutControl1.Controls.Add(this.daysSelector);
            this.layoutControl1.Controls.Add(this.numTE);
            this.layoutControl1.Controls.Add(this.durationTE);
            this.layoutControl1.Controls.Add(this.timeTE);
            this.layoutControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.layoutControl1.Location = new System.Drawing.Point(0, 0);
            this.layoutControl1.Name = "layoutControl1";
            this.layoutControl1.OptionsCustomizationForm.DesignTimeCustomizationFormPositionAndSize = new System.Drawing.Rectangle(415, 163, 575, 517);
            this.layoutControl1.Root = this.layoutControlGroup1;
            this.layoutControl1.ShowTemplates = true;
            this.layoutControl1.Size = new System.Drawing.Size(253, 228);
            this.layoutControl1.TabIndex = 0;
            this.layoutControl1.Text = "layoutControl1";
            // 
            // tagsButt
            // 
            this.tagsButt.ImageLocation = DevExpress.XtraEditors.ImageLocation.MiddleLeft;
            this.tagsButt.Location = new System.Drawing.Point(5, 201);
            this.tagsButt.Name = "tagsButt";
            this.tagsButt.ShowFocusRectangle = DevExpress.Utils.DefaultBoolean.False;
            this.tagsButt.Size = new System.Drawing.Size(53, 22);
            this.tagsButt.StyleController = this.layoutControl1;
            this.tagsButt.TabIndex = 21;
            this.tagsButt.Text = "tags";
            this.tagsButt.CheckedChanged += new System.EventHandler(this.tagsButt_CheckedChanged);
            // 
            // tokenEdit
            // 
            this.tokenEdit.EditValue = "";
            this.tokenEdit.EnterMoveNextControl = true;
            this.tokenEdit.Location = new System.Drawing.Point(60, 177);
            this.tokenEdit.Name = "tokenEdit";
            this.tokenEdit.Properties.DropDownShowMode = DevExpress.XtraEditors.TokenEditDropDownShowMode.Regular;
            this.tokenEdit.Properties.EditMode = DevExpress.XtraEditors.TokenEditMode.Manual;
            this.tokenEdit.Properties.EditValueType = DevExpress.XtraEditors.Repository.EditValueTypeCollection.List;
            this.tokenEdit.Properties.ExportMode = DevExpress.XtraEditors.Repository.ExportMode.Value;
            this.tokenEdit.Properties.Separators.AddRange(new string[] {
            ",",
            ".",
            ";",
            "/"});
            this.tokenEdit.Properties.ShowDropDown = false;
            this.tokenEdit.Properties.ValidationRules = ((DevExpress.XtraEditors.TokenEditValidationRules)((DevExpress.XtraEditors.TokenEditValidationRules.ValidateOnLostFocus | DevExpress.XtraEditors.TokenEditValidationRules.ValidateOnSeparatorInput)));
            this.tokenEdit.Size = new System.Drawing.Size(188, 20);
            this.tokenEdit.StyleController = this.layoutControl1;
            this.tokenEdit.TabIndex = 107;
            this.tokenEdit.UseOptimizedRendering = true;
            this.tokenEdit.ValidateToken += new DevExpress.XtraEditors.TokenEditValidateTokenEventHandler(this.tokenEdit_ValidateToken);
            this.tokenEdit.Validated += new System.EventHandler(this.tokenEdit_Validated);
            // 
            // lvlComboBox
            // 
            this.lvlComboBox.EditValue = "";
            this.lvlComboBox.EnterMoveNextControl = true;
            this.lvlComboBox.Location = new System.Drawing.Point(60, 48);
            this.lvlComboBox.Name = "lvlComboBox";
            this.lvlComboBox.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.lvlComboBox.Properties.Items.AddRange(new object[] {
            "Beginner",
            "Elementary",
            "Pre-Intermediate",
            "Intermediate",
            "Upper-Intermediate",
            "Advanced"});
            this.lvlComboBox.Size = new System.Drawing.Size(188, 20);
            this.lvlComboBox.StyleController = this.layoutControl1;
            this.lvlComboBox.TabIndex = 102;
            this.lvlComboBox.Enter += new System.EventHandler(this.lvlComboBox_Enter);
            // 
            // statusComboBox
            // 
            this.statusComboBox.EnterMoveNextControl = true;
            this.statusComboBox.Location = new System.Drawing.Point(60, 153);
            this.statusComboBox.Name = "statusComboBox";
            this.statusComboBox.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.statusComboBox.Properties.Items.AddRange(new object[] {
            "Awaiting",
            "Active",
            "Paused",
            "Finished"});
            this.statusComboBox.Size = new System.Drawing.Size(188, 20);
            this.statusComboBox.StyleController = this.layoutControl1;
            this.statusComboBox.TabIndex = 105;
            // 
            // cancelButt
            // 
            this.cancelButt.Location = new System.Drawing.Point(175, 201);
            this.cancelButt.Name = "cancelButt";
            this.cancelButt.ShowFocusRectangle = DevExpress.Utils.DefaultBoolean.False;
            this.cancelButt.Size = new System.Drawing.Size(73, 22);
            this.cancelButt.StyleController = this.layoutControl1;
            this.cancelButt.TabIndex = 109;
            this.cancelButt.Text = "Cancel";
            this.cancelButt.Click += new System.EventHandler(this.cancelButt_Click);
            // 
            // okButt
            // 
            this.okButt.Location = new System.Drawing.Point(89, 201);
            this.okButt.Name = "okButt";
            this.okButt.ShowFocusRectangle = DevExpress.Utils.DefaultBoolean.False;
            this.okButt.Size = new System.Drawing.Size(73, 22);
            this.okButt.StyleController = this.layoutControl1;
            this.okButt.TabIndex = 108;
            this.okButt.Text = "OK";
            this.okButt.Click += new System.EventHandler(this.okButt_Click);
            // 
            // daysSelector
            // 
            this.daysSelector.EditValue = "";
            this.daysSelector.EnterMoveNextControl = true;
            this.daysSelector.Location = new System.Drawing.Point(60, 120);
            this.daysSelector.Name = "daysSelector";
            this.daysSelector.Properties.AllowMultiSelect = true;
            this.daysSelector.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.daysSelector.Properties.DropDownRows = 8;
            this.daysSelector.Properties.Items.AddRange(new DevExpress.XtraEditors.Controls.CheckedListBoxItem[] {
            new DevExpress.XtraEditors.Controls.CheckedListBoxItem("Monday", "Mon"),
            new DevExpress.XtraEditors.Controls.CheckedListBoxItem("Tuesday", "Tue"),
            new DevExpress.XtraEditors.Controls.CheckedListBoxItem("Wednesday", "Wed"),
            new DevExpress.XtraEditors.Controls.CheckedListBoxItem("Thursday", "Thu"),
            new DevExpress.XtraEditors.Controls.CheckedListBoxItem("Friday", "Fri"),
            new DevExpress.XtraEditors.Controls.CheckedListBoxItem("Saturday", "Sat")});
            this.daysSelector.Properties.SelectAllItemVisible = false;
            this.daysSelector.Size = new System.Drawing.Size(188, 20);
            this.daysSelector.StyleController = this.layoutControl1;
            this.daysSelector.TabIndex = 106;
            // 
            // numTE
            // 
            this.numTE.EnterMoveNextControl = true;
            this.numTE.Location = new System.Drawing.Point(60, 5);
            this.numTE.Name = "numTE";
            this.numTE.Properties.Mask.EditMask = "\\d?\\d-\\d\\d";
            this.numTE.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.RegEx;
            this.numTE.Properties.Mask.ShowPlaceHolders = false;
            this.numTE.Properties.ValidateOnEnterKey = true;
            this.numTE.Size = new System.Drawing.Size(188, 20);
            this.numTE.StyleController = this.layoutControl1;
            this.numTE.TabIndex = 101;
            this.numTE.Validating += new System.ComponentModel.CancelEventHandler(this.numTE_Validating);
            // 
            // durationTE
            // 
            this.durationTE.EditValue = "";
            this.durationTE.EnterMoveNextControl = true;
            this.durationTE.Location = new System.Drawing.Point(60, 96);
            this.durationTE.Name = "durationTE";
            this.durationTE.Properties.AutoHeight = false;
            this.durationTE.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.durationTE.Properties.Items.AddRange(new object[] {
            "1 hour (60 min.)",
            "1.5 hour (90 min.)",
            "2 hour (120 min.)"});
            this.durationTE.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor;
            this.durationTE.Size = new System.Drawing.Size(188, 20);
            this.durationTE.StyleController = this.layoutControl1;
            this.durationTE.TabIndex = 103;
            // 
            // timeTE
            // 
            this.timeTE.EditValue = "";
            this.timeTE.EnterMoveNextControl = true;
            this.timeTE.Location = new System.Drawing.Point(60, 72);
            this.timeTE.Name = "timeTE";
            this.timeTE.Properties.DisplayFormat.FormatString = "HH:mm";
            this.timeTE.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.timeTE.Properties.EditFormat.FormatString = "HH:mm";
            this.timeTE.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.timeTE.Properties.EditValueChangedFiringMode = DevExpress.XtraEditors.Controls.EditValueChangedFiringMode.Buffered;
            this.timeTE.Properties.Mask.EditMask = "HH:mm";
            this.timeTE.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.DateTime;
            this.timeTE.Properties.Mask.UseMaskAsDisplayFormat = true;
            this.timeTE.Size = new System.Drawing.Size(188, 20);
            this.timeTE.StyleController = this.layoutControl1;
            this.timeTE.TabIndex = 104;
            // 
            // layoutControlGroup1
            // 
            this.layoutControlGroup1.CustomizationFormText = "Root";
            this.layoutControlGroup1.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True;
            this.layoutControlGroup1.GroupBordersVisible = false;
            this.layoutControlGroup1.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.okBtn,
            this.cancelBtn,
            this.emptySpaceItem1,
            this.layoutControlItem6,
            this.groupnoField,
            this.daysCombo,
            this.tagsControl,
            this.layoutControlItem1,
            this.fixedTime,
            this.simpleSeparator1,
            this.layoutControlItem2,
            this.layoutControlItem3});
            this.layoutControlGroup1.Location = new System.Drawing.Point(0, 0);
            this.layoutControlGroup1.Name = "Root";
            this.layoutControlGroup1.Padding = new DevExpress.XtraLayout.Utils.Padding(3, 3, 3, 3);
            this.layoutControlGroup1.Size = new System.Drawing.Size(253, 228);
            this.layoutControlGroup1.Text = "Root";
            this.layoutControlGroup1.TextVisible = false;
            // 
            // okBtn
            // 
            this.okBtn.Control = this.okButt;
            this.okBtn.CustomizationFormText = "okBtn";
            this.okBtn.Location = new System.Drawing.Point(84, 196);
            this.okBtn.MaxSize = new System.Drawing.Size(77, 26);
            this.okBtn.MinSize = new System.Drawing.Size(77, 26);
            this.okBtn.Name = "okBtn";
            this.okBtn.Size = new System.Drawing.Size(77, 26);
            this.okBtn.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom;
            this.okBtn.Text = "okBtn";
            this.okBtn.TextSize = new System.Drawing.Size(0, 0);
            this.okBtn.TextToControlDistance = 0;
            this.okBtn.TextVisible = false;
            // 
            // cancelBtn
            // 
            this.cancelBtn.Control = this.cancelButt;
            this.cancelBtn.CustomizationFormText = "cancelBtn";
            this.cancelBtn.Location = new System.Drawing.Point(161, 196);
            this.cancelBtn.MaxSize = new System.Drawing.Size(86, 26);
            this.cancelBtn.MinSize = new System.Drawing.Size(86, 26);
            this.cancelBtn.Name = "cancelBtn";
            this.cancelBtn.Size = new System.Drawing.Size(86, 26);
            this.cancelBtn.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom;
            this.cancelBtn.Spacing = new DevExpress.XtraLayout.Utils.Padding(9, 0, 0, 0);
            this.cancelBtn.Text = "cancelBtn";
            this.cancelBtn.TextSize = new System.Drawing.Size(0, 0);
            this.cancelBtn.TextToControlDistance = 0;
            this.cancelBtn.TextVisible = false;
            // 
            // emptySpaceItem1
            // 
            this.emptySpaceItem1.AllowHotTrack = false;
            this.emptySpaceItem1.CustomizationFormText = "emptySpaceItem1";
            this.emptySpaceItem1.Location = new System.Drawing.Point(57, 196);
            this.emptySpaceItem1.Name = "emptySpaceItem1";
            this.emptySpaceItem1.Size = new System.Drawing.Size(27, 26);
            this.emptySpaceItem1.Text = "emptySpaceItem1";
            this.emptySpaceItem1.TextSize = new System.Drawing.Size(0, 0);
            // 
            // layoutControlItem6
            // 
            this.layoutControlItem6.Control = this.tagsButt;
            this.layoutControlItem6.CustomizationFormText = "tagsControl";
            this.layoutControlItem6.Location = new System.Drawing.Point(0, 196);
            this.layoutControlItem6.MaxSize = new System.Drawing.Size(57, 26);
            this.layoutControlItem6.MinSize = new System.Drawing.Size(57, 26);
            this.layoutControlItem6.Name = "layoutControlItem6";
            this.layoutControlItem6.Size = new System.Drawing.Size(57, 26);
            this.layoutControlItem6.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom;
            this.layoutControlItem6.Text = "layoutControlItem6";
            this.layoutControlItem6.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem6.TextToControlDistance = 0;
            this.layoutControlItem6.TextVisible = false;
            this.layoutControlItem6.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Never;
            // 
            // groupnoField
            // 
            this.groupnoField.Control = this.numTE;
            this.groupnoField.CustomizationFormText = "Group no.";
            this.groupnoField.Location = new System.Drawing.Point(0, 0);
            this.groupnoField.Name = "groupnoField";
            this.groupnoField.Size = new System.Drawing.Size(247, 24);
            this.groupnoField.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.SupportHorzAlignment;
            this.groupnoField.Text = "Group no.";
            this.groupnoField.TextAlignMode = DevExpress.XtraLayout.TextAlignModeItem.CustomSize;
            this.groupnoField.TextSize = new System.Drawing.Size(50, 13);
            this.groupnoField.TextToControlDistance = 5;
            // 
            // daysCombo
            // 
            this.daysCombo.Control = this.daysSelector;
            this.daysCombo.CustomizationFormText = "Days";
            this.daysCombo.Location = new System.Drawing.Point(0, 115);
            this.daysCombo.Name = "daysCombo";
            this.daysCombo.Size = new System.Drawing.Size(247, 33);
            this.daysCombo.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.SupportHorzAlignment;
            this.daysCombo.Spacing = new DevExpress.XtraLayout.Utils.Padding(0, 0, 0, 9);
            this.daysCombo.Text = "Days";
            this.daysCombo.TextAlignMode = DevExpress.XtraLayout.TextAlignModeItem.CustomSize;
            this.daysCombo.TextSize = new System.Drawing.Size(50, 13);
            this.daysCombo.TextToControlDistance = 5;
            // 
            // tagsControl
            // 
            this.tagsControl.Control = this.tokenEdit;
            this.tagsControl.CustomizationFormText = "Tags";
            this.tagsControl.Location = new System.Drawing.Point(0, 172);
            this.tagsControl.Name = "tagsControl";
            this.tagsControl.Size = new System.Drawing.Size(247, 24);
            this.tagsControl.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.SupportHorzAlignment;
            this.tagsControl.Text = "Tags";
            this.tagsControl.TextAlignMode = DevExpress.XtraLayout.TextAlignModeItem.CustomSize;
            this.tagsControl.TextSize = new System.Drawing.Size(50, 13);
            this.tagsControl.TextToControlDistance = 5;
            this.tagsControl.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Never;
            // 
            // layoutControlItem1
            // 
            this.layoutControlItem1.Control = this.durationTE;
            this.layoutControlItem1.CustomizationFormText = "Duration";
            this.layoutControlItem1.Location = new System.Drawing.Point(0, 91);
            this.layoutControlItem1.Name = "layoutControlItem1";
            this.layoutControlItem1.Size = new System.Drawing.Size(247, 24);
            this.layoutControlItem1.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.SupportHorzAlignment;
            this.layoutControlItem1.Text = "Duration";
            this.layoutControlItem1.TextAlignMode = DevExpress.XtraLayout.TextAlignModeItem.CustomSize;
            this.layoutControlItem1.TextSize = new System.Drawing.Size(50, 13);
            this.layoutControlItem1.TextToControlDistance = 5;
            // 
            // fixedTime
            // 
            this.fixedTime.Control = this.timeTE;
            this.fixedTime.CustomizationFormText = "Time";
            this.fixedTime.Location = new System.Drawing.Point(0, 67);
            this.fixedTime.Name = "fixedTime";
            this.fixedTime.Size = new System.Drawing.Size(247, 24);
            this.fixedTime.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.SupportHorzAlignment;
            this.fixedTime.Text = "Time";
            this.fixedTime.TextAlignMode = DevExpress.XtraLayout.TextAlignModeItem.CustomSize;
            this.fixedTime.TextSize = new System.Drawing.Size(50, 13);
            this.fixedTime.TextToControlDistance = 5;
            // 
            // simpleSeparator1
            // 
            this.simpleSeparator1.AllowHotTrack = false;
            this.simpleSeparator1.CustomizationFormText = "simpleSeparator1";
            this.simpleSeparator1.Location = new System.Drawing.Point(0, 24);
            this.simpleSeparator1.Name = "simpleSeparator1";
            this.simpleSeparator1.Size = new System.Drawing.Size(247, 19);
            this.simpleSeparator1.Spacing = new DevExpress.XtraLayout.Utils.Padding(0, 0, 9, 9);
            this.simpleSeparator1.Text = "simpleSeparator1";
            // 
            // layoutControlItem2
            // 
            this.layoutControlItem2.Control = this.statusComboBox;
            this.layoutControlItem2.CustomizationFormText = "Status";
            this.layoutControlItem2.Location = new System.Drawing.Point(0, 148);
            this.layoutControlItem2.Name = "layoutControlItem2";
            this.layoutControlItem2.Size = new System.Drawing.Size(247, 24);
            this.layoutControlItem2.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.SupportHorzAlignment;
            this.layoutControlItem2.Text = "Status";
            this.layoutControlItem2.TextAlignMode = DevExpress.XtraLayout.TextAlignModeItem.CustomSize;
            this.layoutControlItem2.TextSize = new System.Drawing.Size(50, 13);
            this.layoutControlItem2.TextToControlDistance = 5;
            this.layoutControlItem2.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Never;
            // 
            // layoutControlItem3
            // 
            this.layoutControlItem3.Control = this.lvlComboBox;
            this.layoutControlItem3.CustomizationFormText = "Level";
            this.layoutControlItem3.Location = new System.Drawing.Point(0, 43);
            this.layoutControlItem3.Name = "layoutControlItem3";
            this.layoutControlItem3.Size = new System.Drawing.Size(247, 24);
            this.layoutControlItem3.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.SupportHorzAlignment;
            this.layoutControlItem3.Text = "Level";
            this.layoutControlItem3.TextAlignMode = DevExpress.XtraLayout.TextAlignModeItem.CustomSize;
            this.layoutControlItem3.TextSize = new System.Drawing.Size(50, 13);
            this.layoutControlItem3.TextToControlDistance = 5;
            // 
            // GroupGeneralInfoUc
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.Controls.Add(this.layoutControl1);
            this.Name = "GroupGeneralInfoUc";
            this.Size = new System.Drawing.Size(253, 228);
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).EndInit();
            this.layoutControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.tokenEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lvlComboBox.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.statusComboBox.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.daysSelector.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numTE.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.durationTE.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.timeTE.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.okBtn)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cancelBtn)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupnoField)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.daysCombo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tagsControl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fixedTime)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.simpleSeparator1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem3)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.CheckedComboBoxEdit daysSelector;
        private DevExpress.XtraEditors.TextEdit numTE;
        private DevExpress.XtraLayout.EmptySpaceItem emptySpaceItem1;
        private DevExpress.XtraEditors.SimpleButton cancelButt;
        private DevExpress.XtraEditors.SimpleButton okButt;
        private DevExpress.XtraLayout.LayoutControlItem okBtn;
        private DevExpress.XtraLayout.LayoutControlItem cancelBtn;
        private DevExpress.XtraEditors.ComboBoxEdit statusComboBox;
        public DevExpress.XtraLayout.LayoutControl layoutControl1;
        private DevExpress.XtraLayout.LayoutControlGroup layoutControlGroup1;
        private DevExpress.XtraEditors.ComboBoxEdit durationTE;
        private DevExpress.XtraEditors.ComboBoxEdit lvlComboBox;
        private DevExpress.XtraEditors.TokenEdit tokenEdit;
        private DevExpress.XtraEditors.CheckButton tagsButt;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem6;
        private DevExpress.XtraLayout.LayoutControlItem groupnoField;
        private DevExpress.XtraLayout.LayoutControlItem fixedTime;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem2;
        private DevExpress.XtraLayout.LayoutControlItem daysCombo;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem1;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem3;
        private DevExpress.XtraLayout.LayoutControlItem tagsControl;
        private DevExpress.XtraLayout.SimpleSeparator simpleSeparator1;
        private DevExpress.XtraEditors.TextEdit timeTE;
    }
}
