using System;
using System.Drawing;
using System.Windows.Forms;
using DevExpress.XtraBars.Docking2010.Views;
using DevExpress.XtraEditors;
using DevExpress.XtraLayout.Utils;
using ge_mongo_simplified.Classes;

namespace ge_mongo_simplified.UserControls.StudentRelated.FormRelated
{
    public partial class StdManagerUC : XtraUserControl
    {
        public OrgUC orgControl;
        public ContactsUC contactsControl;
        public StdManagerUC()
        {
            contactsControl = new ContactsUC(this);
            orgControl = new OrgUC(this);
            InitializeComponent();
        }

        private void tabbedView1_QueryControl(object sender,
            QueryControlEventArgs e)
        {
            if (e.Document == contactsUCDocument)
                e.Control = contactsControl;
            if (e.Document == orgUCDocument)
            {
                e.Control = orgControl;
                groupListFill();
                sourceListFill();
            }
                
            if (e.Document == paymentsUCDocument)
                e.Control = new PaymentsUC();
        }

        private void groupListFill()
        {
            var groups = Mongo.groupList();
            orgControl.groupCombo.Properties.Items.Clear();

            for (var i = 0; i <= groups.Count - 1; i++)
            {
                orgControl.groupCombo.Properties.Items.Add(groups[i].num);
            }
        }

        private void sourceListFill()
        {
            if (Properties.Settings.Default.sourceComboList != null)
                orgControl.sourceCB.Properties.Items.AddRange(Properties.Settings.Default.sourceComboList);
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

        public void fieldsFillCheck()
        {
            if ((fnameTE.Text != string.Empty) &&
                 ((string) contactsControl.mainphoneTE.EditValue != string.Empty) &&
                ((string) orgControl.groupCB.EditValue != string.Empty))
                okButt.Enabled = true;
            else okButt.Enabled = false;
        }

        private void fnameTE_EditValueChanged(object sender, EventArgs e)
        {
            fnameCI.AppearanceItemCaption.ForeColor = fnameTE.Text != string.Empty ? SystemColors.ControlText : Color.OrangeRed;
            fieldsFillCheck();
        }
    }
}
