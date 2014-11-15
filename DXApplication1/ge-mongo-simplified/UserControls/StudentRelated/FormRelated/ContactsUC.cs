using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;
using DevExpress.XtraBars;
using DevExpress.XtraEditors;
using DevExpress.XtraLayout.Utils;
using ge_mongo_simplified.Forms;

namespace ge_mongo_simplified.UserControls.StudentRelated.FormRelated
{
    public partial class ContactsUC : XtraUserControl
    {
        private readonly StdManagerUC _parentControl;
        public ContactsUC(StdManagerUC parentControl)
        {
            _parentControl = parentControl;
            InitializeComponent();
        }

        private void contactAddDel_BeforePopup(object sender, CancelEventArgs e)
        {
            contextRecheck();
        }

        public void contextRecheck()
        {
            homephoneCCI.Checked = homephoneCI.Visible;
            addphoneCCI.Checked = addphoneCI.Visible;
            emailCCI.Checked = emailCI.Visible;
            skypeCCI.Checked = skypeCI.Visible;
            vkCCI.Checked = vkCI.Visible;
            wappCCI.Checked = wappCI.Visible;
        }

        private void homephoneCCI_CheckedChanged(object sender, ItemClickEventArgs e)
        {
            homephoneCI.Visibility = homephoneCCI.Checked ? LayoutVisibility.Always : LayoutVisibility.Never;
        }

        private void addphoneCCI_CheckedChanged(object sender, ItemClickEventArgs e)
        {
            addphoneCI.Visibility = addphoneCCI.Checked ? LayoutVisibility.Always : LayoutVisibility.Never;
        }

        private void emailCCI_CheckedChanged(object sender, ItemClickEventArgs e)
        {
            emailCI.Visibility = emailCCI.Checked ? LayoutVisibility.Always : LayoutVisibility.Never;
            separatorVisibility();
        }

        private void skypeCCI_CheckedChanged(object sender, ItemClickEventArgs e)
        {
            skypeCI.Visibility = skypeCCI.Checked ? LayoutVisibility.Always : LayoutVisibility.Never;
            separatorVisibility();
        }

        private void vkCCI_CheckedChanged(object sender, ItemClickEventArgs e)
        {
            vkCI.Visibility = vkCCI.Checked ? LayoutVisibility.Always : LayoutVisibility.Never;
            separatorVisibility();
        }

        private void wappCCI_CheckedChanged(object sender, ItemClickEventArgs e)
        {
            wappCI.Visibility = wappCCI.Checked ? LayoutVisibility.Always : LayoutVisibility.Never;
            separatorVisibility();
        }
        private void separatorVisibility()
        {
            if (vkCI.Visible || wappCI.Visible || emailCI.Visible || skypeCI.Visible)
                spacer.Visibility = LayoutVisibility.Always;
            else spacer.Visibility = LayoutVisibility.Never;
        }


        private void mainphoneTE_EditValueChanged(object sender, System.EventArgs e)
        {
            if ((string) mainphoneTE.EditValue != string.Empty)
            {
                mainphoneCI.AppearanceItemCaption.ForeColor = SystemColors.ControlText;
                if (_parentControl != null)
                {
                    _parentControl.contactsUCDocument.Appearance.Header.ForeColor = SystemColors.ControlText;
                    _parentControl.fieldsFillCheck();
                }
            }
            else
            {
                mainphoneCI.AppearanceItemCaption.ForeColor = Color.OrangeRed;
                if (_parentControl != null)
                {
                    _parentControl.contactsUCDocument.Appearance.Header.ForeColor = Color.OrangeRed;
                    _parentControl.fieldsFillCheck();
                }  
            }
        }
    }
}
