using System.Drawing;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using ge_mongo_simplified.Classes;
using ge_mongo_simplified.UserControls;
using MongoDB.Driver;

namespace ge_mongo_simplified.Forms
{
    public partial class GroupsForm : XtraForm
    {
        private MainForm main;
        public GroupsForm(MainForm mainForm)
        {
            InitializeComponent();
            main = mainForm;
        }

        private void GroupsForm_Load(object sender, System.EventArgs e)
        {
            ClientSize = new Size(ClientSize.Width, groupGeneralInfoUc1.layoutControl1.Root.MinSize.Height);
            if (Properties.Settings.Default.formType == "edit")
                groupGeneralInfoUc2.groupEditFormFill();
        }

        private void GroupsForm_FormClosed(object sender, System.Windows.Forms.FormClosedEventArgs e)
        {
            main.groupGridFill();
            main.focusBack(Properties.Settings.Default.groupNo);
            main.groupDetailShow();
        }
    }
}