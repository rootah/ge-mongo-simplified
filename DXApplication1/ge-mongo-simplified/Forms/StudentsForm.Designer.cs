namespace ge_mongo_simplified.Forms
{
    partial class StudentsForm
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
            this.stdMainUC1 = new ge_mongo_simplified.UserControls.StdMainUC();
            this.SuspendLayout();
            // 
            // stdMainUC1
            // 
            this.stdMainUC1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.stdMainUC1.Location = new System.Drawing.Point(0, 0);
            this.stdMainUC1.Name = "stdMainUC1";
            this.stdMainUC1.Size = new System.Drawing.Size(289, 320);
            this.stdMainUC1.TabIndex = 0;
            // 
            // StudentsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(289, 320);
            this.Controls.Add(this.stdMainUC1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "StudentsForm";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Show;
            this.Text = "Student [...]";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.StudentsForm_FormClosed);
            this.Load += new System.EventHandler(this.StudentsForm_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private UserControls.StdMainUC stdMainUC1;



    }
}