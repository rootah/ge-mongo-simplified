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
            this.groupGeneralInfoUc2 = new ge_mongo_simplified.UserControls.GroupGeneralInfoUc();
            this.groupGeneralInfoUc1 = new ge_mongo_simplified.UserControls.GroupGeneralInfoUc();
            this.SuspendLayout();
            // 
            // groupGeneralInfoUc2
            // 
            this.groupGeneralInfoUc2.AutoSize = true;
            this.groupGeneralInfoUc2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupGeneralInfoUc2.Location = new System.Drawing.Point(0, 0);
            this.groupGeneralInfoUc2.Name = "groupGeneralInfoUc2";
            this.groupGeneralInfoUc2.Size = new System.Drawing.Size(244, 182);
            this.groupGeneralInfoUc2.TabIndex = 1;
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
            // GroupsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(244, 182);
            this.Controls.Add(this.groupGeneralInfoUc2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.IsMdiContainer = true;
            this.LookAndFeel.SkinName = "Visual Studio 2013 Light";
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(260, 207);
            this.Name = "GroupsForm";
            this.ShowIcon = false;
            this.Text = "Group [...]";
            this.Load += new System.EventHandler(this.GroupsForm_Load);
            this.Resize += new System.EventHandler(this.GroupsForm_Resize);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private UserControls.GroupGeneralInfoUc groupGeneralInfoUc1;
        private UserControls.GroupGeneralInfoUc groupGeneralInfoUc2;
    }
}