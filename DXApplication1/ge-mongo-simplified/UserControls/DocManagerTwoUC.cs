using System;
using System.Drawing;
using System.Windows.Forms;
using DevExpress.XtraBars.Docking2010.Views;
using DevExpress.XtraEditors;
using DevExpress.XtraLayout.Utils;
using ge_mongo_simplified.Classes;
using ge_mongo_simplified.UserControls.StudentRelated.FormRelated;

namespace ge_mongo_simplified.UserControls
{
    public partial class DocManagerTwoUC : XtraUserControl
    {
        readonly OrgUC _orgControl = new OrgUC(); 
        public DocManagerTwoUC()
        {
            InitializeComponent();
        }

        private void tabbedView1_QueryControl(object sender,
            QueryControlEventArgs e)
        {
            if (e.Document == contactsUCDocument)
                e.Control = new ContactsUC();
            if (e.Document == orgUCDocument)
            {
                e.Control = _orgControl;
                groupListFill();
            }
                
            if (e.Document == paymentsUCDocument)
                e.Control = new PaymentsUC();
        }

        private void groupListFill()
        {
            var groups = Mongo.groupList();
            _orgControl.groupCombo.Properties.Items.Clear();

            for (var i = 0; i <= groups.Count - 1; i++)
            {
                _orgControl.groupCombo.Properties.Items.Add(groups[i].num);
            }
            
        }
        private void underageCE_CheckedChanged(object sender, EventArgs e)
        {
            topLC.BeginUpdate();
            if (underageCE.Checked)
            {
                pnameCI.Visibility = LayoutVisibility.Always;
                formResize(23);
            }
            else
            {
                pnameCI.Visibility = LayoutVisibility.Never;
                formResize(-23);
            }
            topLC.Size = new Size(topLC.Width, topLC.Root.MinSize.Height);
            topLC.EndUpdate();
        }

        public void formResize(int delta)
        {
            var parentForm = (Form) TopLevelControl;
            if (parentForm != null)
            {
                parentForm.Height = parentForm.Height + delta;
            }
        }

        private void cancelButt_Click(object sender, EventArgs e)
        {
            var parentForm = (Form)TopLevelControl;
            if (parentForm != null)
            {
                parentForm.Close();}
        }
    }
}
