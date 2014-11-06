namespace ge_mongo_simplified.Forms
{
    partial class DocManagerForm
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
            this.docManagerTwoUC1 = new ge_mongo_simplified.UserControls.DocManagerTwoUC();
            this.SuspendLayout();
            // 
            // docManagerTwoUC1
            // 
            this.docManagerTwoUC1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.docManagerTwoUC1.Location = new System.Drawing.Point(0, 0);
            this.docManagerTwoUC1.Name = "docManagerTwoUC1";
            this.docManagerTwoUC1.Size = new System.Drawing.Size(301, 398);
            this.docManagerTwoUC1.TabIndex = 0;
            // 
            // DocManagerForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(301, 398);
            this.Controls.Add(this.docManagerTwoUC1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.Name = "DocManagerForm";
            this.Text = "DocManagerForm";
            this.Load += new System.EventHandler(this.DocManagerForm_Load);
            this.Resize += new System.EventHandler(this.DocManagerForm_Resize);
            this.ResumeLayout(false);

        }

        #endregion

        private UserControls.DocManagerTwoUC docManagerTwoUC1;
    }
}