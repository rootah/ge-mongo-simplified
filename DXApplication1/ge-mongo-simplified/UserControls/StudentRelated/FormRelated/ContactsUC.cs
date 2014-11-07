using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using DevExpress.XtraLayout.Utils;
using ge_mongo_simplified.UserControls;
using DevExpress.XtraPrinting.Export;

namespace ge_mongo_simplified.UserControls.StudentRelated.FormRelated
{
    public partial class ContactsUC : XtraUserControl
    {
        public ContactsUC()
        {
            InitializeComponent();
        }

        private void simpleButton1_Click(object sender, System.EventArgs e)
        {
            //var parentForm = (Form) TopLevelControl;
            //if (parentForm != null)
            //{
            //    var topLayoutControl = parentForm.Controls.Find("docManagerTwoUC1", true).FirstOrDefault();
            //    if (topLayoutControl != null)
            //    {
            //        var control = parentForm.Controls.Find("layoutControl1", true).FirstOrDefault() as DevExpress.XtraLayout.LayoutControl;
            //        if (control != null)
            //        {
            //            //parentForm.ClientSize = new Size(parentForm.Width, parentForm.Height + 250);
            //            control.Size = new Size(control.Width, control.Root.MinSize.Height);
            //        }
            //        //if (control != null) XtraMessageBox.Show(control.Height + " : " + control.Width);
            //        //else XtraMessageBox.Show("control is null");
            //    }
            //    else XtraMessageBox.Show("TopLayoutControl is null");
            //}
            //else XtraMessageBox.Show("Parent is null");
        }

        private void contactAddDel_BeforePopup(object sender, System.ComponentModel.CancelEventArgs e)
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

        private void homephoneCCI_CheckedChanged(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            homephoneCI.Visibility = homephoneCCI.Checked ? LayoutVisibility.Always : LayoutVisibility.Never;
        }

        private void addphoneCCI_CheckedChanged(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            addphoneCI.Visibility = addphoneCCI.Checked ? LayoutVisibility.Always : LayoutVisibility.Never;
        }

        private void emailCCI_CheckedChanged(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            emailCI.Visibility = emailCCI.Checked ? LayoutVisibility.Always : LayoutVisibility.Never;
            separatorVisibility();
        }

        private void skypeCCI_CheckedChanged(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            skypeCI.Visibility = skypeCCI.Checked ? LayoutVisibility.Always : LayoutVisibility.Never;
            separatorVisibility();
        }

        private void vkCCI_CheckedChanged(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            vkCI.Visibility = vkCCI.Checked ? LayoutVisibility.Always : LayoutVisibility.Never;
            separatorVisibility();
        }

        private void wappCCI_CheckedChanged(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
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
