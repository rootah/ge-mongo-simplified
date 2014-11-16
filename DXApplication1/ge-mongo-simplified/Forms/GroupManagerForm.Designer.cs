using ge_mongo_simplified.UserControls;
using ge_mongo_simplified.UserControls.GroupRelated.FormRelated;

namespace ge_mongo_simplified.Forms
{
    partial class GroupManagerForm
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
            this.groupManagerUc1 = new GroupManagerUc();
            this.SuspendLayout();
            // 
            // groupManagerUc1
            // 
            this.groupManagerUc1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupManagerUc1.Location = new System.Drawing.Point(0, 0);
            this.groupManagerUc1.Name = "groupManagerUc1";
            this.groupManagerUc1.Size = new System.Drawing.Size(252, 194);
            this.groupManagerUc1.TabIndex = 1;
            // 
            // GroupManagerForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(252, 194);
            this.Controls.Add(this.groupManagerUc1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.IsMdiContainer = true;
            this.LookAndFeel.SkinName = "Visual Studio 2013 Light";
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(268, 242);
            this.Name = "GroupManagerForm";
            this.ShowIcon = false;
            this.Text = "Group [...]";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.GroupsForm_FormClosed);
            this.Load += new System.EventHandler(this.GroupsManagerForm_Load);
            this.ResumeLayout(false);

        }

        private GroupManagerUc groupManagerUc1;

        #endregion
        //private UserControls.GeneralUC groupGeneralInfoUc2;
    }
}