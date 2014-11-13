using DevExpress.XtraEditors;
using DevExpress.XtraLayout.Utils;

namespace ge_mongo_simplified.UserControls.StudentRelated.FormRelated
{
    public partial class OrgUC : XtraUserControl
    {
        public OrgUC()
        {
            InitializeComponent();
        }

        public ComboBoxEdit groupCombo
        {
            get { return groupCB; }
        }

        private void sourceCB_Properties_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            if (e.Button == sourceCB.Properties.Buttons[1])
            {
                flyoutPanel1.Visible = false;
                flyoutPanel1.ShowPopup();
                flyoutPanel1.Visible = true;
            }
        }
    }
}
