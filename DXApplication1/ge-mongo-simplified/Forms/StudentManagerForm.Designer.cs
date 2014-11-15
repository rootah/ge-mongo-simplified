namespace ge_mongo_simplified.Forms
{
    partial class StudentManagerForm
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
            this.StdManagerUC1 = new UserControls.StdManagerUC();
            this.SuspendLayout();
            // 
            // StdManagerUC1
            // 
            this.StdManagerUC1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.StdManagerUC1.Location = new System.Drawing.Point(0, 0);
            this.StdManagerUC1.Name = "StdManagerUC1";
            this.StdManagerUC1.Size = new System.Drawing.Size(252, 342);
            this.StdManagerUC1.TabIndex = 0;
            // 
            // StudentManagerForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(252, 342);
            this.Controls.Add(this.StdManagerUC1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "StudentManagerForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Student manager";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.DocManagerForm_FormClosing);
            this.Load += new System.EventHandler(this.StudentManagerForm_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private UserControls.StdManagerUC StdManagerUC1;
    }
}