using System;
using System.ComponentModel;
using System.Windows.Forms;
using DevExpress.XtraBars.Docking2010.Views;
using DevExpress.XtraEditors;
using ge_mongo_simplified.Classes;
using ge_mongo_simplified.Properties;

namespace ge_mongo_simplified.UserControls.GroupRelated.FormRelated
{
    public partial class GroupManagerUc : XtraUserControl
    {
        public static GeneralUC groupGeneralControl;
        public GroupPaymentsInfoUC groupPaymentsControl;
        public GroupManagerUc()
        {
            groupGeneralControl = new GeneralUC();
            groupPaymentsControl = new GroupPaymentsInfoUC(this);
            InitializeComponent();
        }

        private void tabbedView1_QueryControl(object sender, QueryControlEventArgs e)
        {
            if (e.Document == groupGeneralInfoUcDocument)
                e.Control = groupGeneralControl;
            if (e.Document == groupPaymentsInfoUCDocument)
                e.Control = groupPaymentsControl;
        }

        public static void formFill()
        {
            var list = new BindingList<string>();
            var groupDoc = Mongo.getGroupDocument(Settings.Default.groupID);
            foreach (var res in groupDoc.days)
                list.Add(res.ToString());

            groupGeneralControl.numTE.Text = groupDoc.num;
            groupGeneralControl.lvlCBE.Text = groupDoc.lvl;
            groupGeneralControl.timeTE.Text = groupDoc.time;
            groupGeneralControl.durationCBE.Text = groupDoc.duration;

            for (var count = 0; count < groupGeneralControl.daysCBE.Properties.Items.Count; count++)
            {
                if (list.Contains(groupGeneralControl.daysCBE.Properties.Items[count].ToString()))
                {
                    groupGeneralControl.daysCBE.Properties.Items[count].CheckState = CheckState.Checked;
                }
            }
        }
        private void cancelButt_Click(object sender, EventArgs e)
        {
            var parentForm = (Form)TopLevelControl;
            if (parentForm != null)
            {
                parentForm.Close();
            }
        }

        private void formCheck()
        {
            if (groupGeneralControl.numTE.Text == string.Empty)
            {
                XtraMessageBox.Show(@"Check group number!" + Environment.NewLine + " ");
                groupGeneralControl.numTE.Focus();
            }
            if (Settings.Default.formType == "edit") Mongo.groupUpdate(groupGeneralControl);
            else Mongo.groupInsert(groupGeneralControl);
        }

        private void okButt_Click(object sender, EventArgs e)
        {
            formCheck();
        }
    }
}
