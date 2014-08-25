using System;
using System.Drawing;
using System.Windows.Forms;
using DevExpress.XtraLayout.Utils;

namespace ge_mongo_simplified.UserControls
{
    public partial class StdMainUC : DevExpress.XtraEditors.XtraUserControl
    {
        public StdMainUC()
        {
            InitializeComponent();
        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            var topForm = (Form) TopLevelControl;
            if (topForm != null) topForm.Close();
        }

        private void checkEdit1_CheckedChanged(object sender, EventArgs e)
        {
            var topLevelControl = (Form)TopLevelControl;
            pnameControl.Visibility = underageCE.Checked ? LayoutVisibility.Always : LayoutVisibility.Never;
            if (topLevelControl != null)
                topLevelControl.ClientSize = new Size(ClientSize.Width, layoutControl1.Root.MinSize.Height);
        }

        private void checkEdit2_CheckedChanged(object sender, EventArgs e)
        {
            if (discountCE.Checked)
                discountControl.Control.Enabled = true;
            else
            {
                discountControl.Control.Enabled = false;
                discountControl.Control.Text = string.Empty;}
        }

        private void tabbedControlGroup1_SelectedPageChanged(object sender, DevExpress.XtraLayout.LayoutTabPageChangedEventArgs e)
        {
            var topLevelControl = (Form)TopLevelControl;
            if (topLevelControl != null)
                topLevelControl.ClientSize = new Size(ClientSize.Width, layoutControl1.Root.MinSize.Height);}
    }
}
