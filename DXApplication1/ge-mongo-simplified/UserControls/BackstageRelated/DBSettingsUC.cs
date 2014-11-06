using DevExpress.XtraEditors;
using DevExpress.XtraLayout.Utils;
using ge_mongo_simplified.Forms;

namespace ge_mongo_simplified.UserControls
{
    public partial class dbSettingsUC : XtraUserControl
    {
        public dbSettingsUC(MainForm mainForm)
        {
            InitializeComponent();
        }
        private void stoprecButt_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            logrecBtn.Down = false;
        }

        private void checkEdit1_CheckedChanged(object sender, System.EventArgs e)
        {
            checkEdit1.Text = checkEdit1.Checked ? @"   master" : @"";
        }
        private void checkEdit2_CheckedChanged(object sender, System.EventArgs e)
        {
            checkEdit2.Text = checkEdit2.Checked ? @"   master" : @"";
        }
    }
}