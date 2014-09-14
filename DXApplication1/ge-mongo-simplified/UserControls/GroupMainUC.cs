using System;
using System.ComponentModel;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Windows.Forms;
using DevExpress.Utils;
using DevExpress.XtraEditors;
using DevExpress.XtraEditors.Controls;
using DevExpress.XtraLayout.Utils;
using DevExpress.XtraNavBar;
using ge_mongo_simplified.Classes;
using ge_mongo_simplified.Forms;
using MongoDB.Bson;
using MongoDB.Driver;
using MongoDB.Driver.Builders;

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

        public void groupEditFormFill()
        {
            var list = new BindingList<string>();
            var q = Query.EQ("_id", ObjectId.Parse(Properties.Settings.Default.groupID));
            var resdoc = collection.FindOneAs<Group>(q);
            foreach (var res in resdoc.days)
                list.Add(res.ToString());

            numTE.Text = resdoc.num;
            lvlComboBox.Text = resdoc.lvl;
            timeTE.Text = resdoc.time;
            durationTE.Text = resdoc.duration;

            for (int count = 0; count < daysSelector.Properties.Items.Count; count++)
            {
                if (list.Contains(daysSelector.Properties.Items[count].ToString()))
                {
                    daysSelector.Properties.Items[count].CheckState = CheckState.Checked;
                }
            }
        }
        private void cancelButt_Click(object sender, EventArgs e)
        {
            Properties.Settings.Default.groupNo = numTE.Text;
            Properties.Settings.Default.Save();
            var topLevelControl = (Form)TopLevelControl;
            if (topLevelControl != null) topLevelControl.Close();
        }

        private void tagsButt_CheckedChanged(object sender, EventArgs e)
        {
            var topLevelControl = (Form)TopLevelControl;
            tagsControl.Visibility = tagsButt.Checked ? LayoutVisibility.Always : LayoutVisibility.Never;
            if (topLevelControl != null)
                topLevelControl.ClientSize = new Size(ClientSize.Width, layoutControl1.Root.MinSize.Height);
        }

        private void formCheck()
        {
            if (numTE.Text == string.Empty)
            {
                XtraMessageBox.Show(@"Check group number!" + Environment.NewLine + " ");
                numTE.Focus();
            }
            else formCheckStageTwo();
        }

        private void formCheckStageTwo()
        {
            Properties.Settings.Default.groupNo = numTE.Text;
            Properties.Settings.Default.Save();
            if (Properties.Settings.Default.formType == "edit")
                groupUpdate();
            else writeResult();
        }

        private void okButt_Click(object sender, EventArgs e)
        {
            formCheck();
        }

        private void groupUpdate()
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

            database.GetCollection<Group>("devgroups").Update(
                Query.EQ("_id", ObjectId.Parse(Properties.Settings.Default.groupID)),
                MongoDB.Driver.Builders.Update
                    .Set("num", numTE.Text)
                    .Set("lvl", lvlComboBox.Text)
                    .Set("duration", durationTE.Text)
                    .Set("time", timeTE.Text)
                    .Set("status", statusComboBox.Text)
                    .Set("days", new BsonArray(list)
                    ));

            Properties.Settings.Default.groupNo = numTE.Text;
            Properties.Settings.Default.Save();
            if (topLevelControl != null) topLevelControl.Close();
        }

        private void writeResult()
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
            // MainForm Details renew
            Properties.Settings.Default.groupID = newgroup._id.ToString();
            Properties.Settings.Default.groupNo = newgroup.num;
            Properties.Settings.Default.Save();
            lastActionWrite();
            if (topLevelControl != null) topLevelControl.Close();
        }
        private void lvlComboBox_Enter(object sender, EventArgs e)
        {
            if (lvlComboBox.SelectedItem.ToString() == string.Empty)
            lvlComboBox.EditValue = lvlComboBox.Properties.Items[0].ToString();
        }

        private void lastActionWrite()
        {
            var topLevelControl = (Form)TopLevelControl;

            Properties.Settings.Default.lastAction = "Group [" + numTE.Text + " / " + lvlComboBox.Text + " / " +
                                                     durationTE.Text + " / " + timeTE.Text + " / " +
                                                     daysSelector.Text + "] added";

            if (topLevelControl != null) topLevelControl.Text = @"Group [" + numTE.Text + @"]";
        }

        private void numTE_Validating(object sender, System.ComponentModel.CancelEventArgs e)
        {
            var topLevelControl = (Form)TopLevelControl;

            if (numTE.Text == string.Empty)
            {
                groupnoField.AppearanceItemCaption.ForeColor = Color.Red;
                if (topLevelControl != null) topLevelControl.Text = @"Group [.. check group no.]";
            }
            else
            {
                groupnoField.AppearanceItemCaption.ForeColor = SystemColors.ControlText;
                var boxText = numTE.Text;
                if (boxText != null)
                {
                    var pos = boxText.IndexOf("-", StringComparison.Ordinal);
                    if (pos == 1)
                        numTE.Text = @"0" + numTE.Text;
                    if (topLevelControl != null) topLevelControl.Text = @"Group [" + numTE.Text + @"]";
                }
            }
            
            //    dxErrorProvider1.SetError(numTE, "Field cannot be empty", ErrorType.User1);
            //else dxErrorProvider1.SetError(numTE, "");
        }

        private void tokenEdit_ValidateToken(object sender, TokenEditValidateTokenEventArgs e)
        {
            e.IsValid = true;
            
            //tokenEdit.Validate();
        }

        private void tokenEdit_Validated(object sender, EventArgs e)
        {
            //string mystring = tokenEdit.Text;
            //string output = mystring.Remove(mystring.Length - 1, 1);

            //tokenEdit.Text = output;
        }
    }
}