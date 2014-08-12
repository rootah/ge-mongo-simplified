using System.Drawing;
using DevExpress.XtraEditors;
using ge_mongo_simplified.Classes;
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
        }

        public void formResize()
        {
            ClientSize = new Size(ClientSize.Width, groupGeneralInfoUc1.layoutControl1.Root.MinSize.Height);
        }
    }
}