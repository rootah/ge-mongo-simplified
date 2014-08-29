using System.Drawing;
using DevExpress.XtraEditors;
using ge_mongo_simplified.Classes;
using ge_mongo_simplified.UserControls;
using MongoDB.Driver;

namespace ge_mongo_simplified.Forms
{
    public partial class GroupsForm : XtraForm
    {
        public GroupsForm(MainForm mainForm)
        {
            InitializeComponent();

        }

        private void GroupsForm_Load(object sender, System.EventArgs e)
        {
            ClientSize = new Size(ClientSize.Width, groupGeneralInfoUc1.layoutControl1.Root.MinSize.Height);
            if (Properties.Settings.Default.formType == "edit")
                groupGeneralInfoUc2.groupEditFormFill();}

        private void GroupsForm_Resize(object sender, System.EventArgs e)
        {
            Text = Height + @" : " + Width;}
    }
}