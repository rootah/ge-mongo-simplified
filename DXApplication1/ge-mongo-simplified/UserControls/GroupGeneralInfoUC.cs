using System;
using System.Drawing;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using DevExpress.XtraEditors.Controls;
using DevExpress.XtraLayout.Utils;
using ge_mongo_simplified.Classes;
using MongoDB.Bson;
using MongoDB.Driver;

namespace ge_mongo_simplified.UserControls
{
    public partial class GroupGeneralInfoUc : XtraUserControl
    {
        public static string connectionString = "mongodb://localhost";
        public static MongoClient client = new MongoClient(connectionString);
        public static MongoServer server = client.GetServer();
        public static MongoDatabase database = server.GetDatabase("devdb");
        public static MongoCollection collection = database.GetCollection("devgroups");

        public GroupGeneralInfoUc()
        {
            InitializeComponent();
        }

        private void cancelButt_Click(object sender, EventArgs e)
        {
            var topLevelControl = (Form) TopLevelControl;
            if (topLevelControl != null) topLevelControl.Close();
        }

        private void tagsButt_CheckedChanged(object sender, EventArgs e)
        {
            var topLevelControl = (Form) TopLevelControl;
            tagsControl.Visibility = tagsButt.Checked ? LayoutVisibility.Always : LayoutVisibility.Never;
            if (topLevelControl != null)
                topLevelControl.ClientSize = new Size(ClientSize.Width, layoutControl1.Root.MinSize.Height);
        }

        private void okButt_Click(object sender, EventArgs e)
        {
            var topLevelControl = (Form)TopLevelControl;

            var list = new BsonArray();
            foreach (CheckedListBoxItem item in daysSelector.Properties.Items)
            {
                if (item.CheckState == CheckState.Checked)
                {
                    list.Add(item.ToString());
                }
            }

            var newgroup = new Group
            {
                _id = new ObjectId(),
                num = numTE.Text,
                lvl = lvlComboBox.Text,
                duration = durationTE.Text,
                time = timeTE.Text,
                status = statusComboBox.Text,
                days = new BsonArray(list)
            };

            collection.Insert(newgroup);
            if (topLevelControl != null) topLevelControl.Close();
        }
    }
}