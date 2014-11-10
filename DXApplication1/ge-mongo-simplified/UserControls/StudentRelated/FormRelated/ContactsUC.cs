using System.ComponentModel;
using DevExpress.XtraBars;
using DevExpress.XtraEditors;
using DevExpress.XtraLayout.Utils;

namespace ge_mongo_simplified.UserControls.StudentRelated.FormRelated
{
    public partial class ContactsUC : XtraUserControl
    {
        public ContactsUC()
        {
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
    }
}
