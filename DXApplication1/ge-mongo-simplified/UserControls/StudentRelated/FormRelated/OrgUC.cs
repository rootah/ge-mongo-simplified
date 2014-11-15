using DevExpress.XtraEditors;
using System.Drawing;

namespace ge_mongo_simplified.UserControls.StudentRelated.FormRelated
{
    public partial class OrgUC : XtraUserControl
    {
        private readonly StdManagerUC _parentControl;
        public OrgUC(StdManagerUC parentControl)
        {
            _parentControl = parentControl;
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

        private void groupCB_SelectedIndexChanged(object sender, System.EventArgs e)
        {
            if ((string) groupCB.EditValue != string.Empty)
            {
                groupCI.AppearanceItemCaption.ForeColor = SystemColors.ControlText;
                if (_parentControl == null) return;
                _parentControl.orgUCDocument.Appearance.Header.ForeColor = SystemColors.ControlText;
                _parentControl.fieldsFillCheck();
            }
            else
            {
                groupCI.AppearanceItemCaption.ForeColor = Color.OrangeRed;
                if (_parentControl == null) return;
                _parentControl.orgUCDocument.Appearance.Header.ForeColor = Color.OrangeRed;
                _parentControl.fieldsFillCheck();
            }
        }
    }
}
