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

        private void simpleButton1_Click(object sender, System.EventArgs e)
        {
            if (layoutControlItem2.Visibility == LayoutVisibility.Always)
                layoutControlItem2.Visibility = LayoutVisibility.Never;
            else layoutControlItem2.Visibility = LayoutVisibility.Always;
        }
    }
}