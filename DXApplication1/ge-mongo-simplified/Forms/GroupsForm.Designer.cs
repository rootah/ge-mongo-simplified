using ge_mongo_simplified.UserControls;

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
            //this.stdMainUC1 = new ge_mongo_simplified.UserControls.StdMainUC();
            this.groupGeneralInfoUc1 = new GroupGeneralInfoUc();
            SuspendLayout();
            // 
            // GroupsForm
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(680, 311);
            FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            IsMdiContainer = true;
            LookAndFeel.SkinName = "Visual Studio 2013 Light";
            MaximizeBox = false;
            MinimizeBox = false;
            MinimumSize = new System.Drawing.Size(260, 207);
            Name = "GroupsForm";
            ShowIcon = false;
            Text = "Group [...]";
            FormClosed += new System.Windows.Forms.FormClosedEventHandler(GroupsForm_FormClosed);
            Load += new System.EventHandler(GroupsForm_Load);
            ResumeLayout(false);

        }

        #endregion

        private UserControls.GroupGeneralInfoUc groupGeneralInfoUc1;
        //private UserControls.GroupGeneralInfoUc groupGeneralInfoUc2;
    }
}