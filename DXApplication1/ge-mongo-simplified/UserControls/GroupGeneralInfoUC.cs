using System;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using DevExpress.Utils;
using DevExpress.XtraEditors;
using DevExpress.XtraEditors.Controls;
using DevExpress.XtraEditors.DXErrorProvider;
using DevExpress.XtraLayout.Utils;
using ge_mongo_simplified.Classes;
using ge_mongo_simplified.Forms;
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
        //public Image icon = Properties.Resources.errIcoLeft;


        public GroupGeneralInfoUc()
        {
            InitializeComponent();
            //DXErrorProvider.GetErrorIcon += new GetErrorIconEventHandler(DXErrorProvider_GetErrorIcon);
        }

        //void DXErrorProvider_GetErrorIcon(GetErrorIconEventArgs e)
        //{
        //    if (e.ErrorType == ErrorType.User1)
        //    {
        //        e.ErrorIcon = icon;
        //    }
        //}
        private void cancelButt_Click(object sender, EventArgs e)
        {
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
            else writeResult();
        }

        private void okButt_Click(object sender, EventArgs e)
        {
            formCheck();
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
            if (topLevelControl != null) topLevelControl.Close();
        }
        private void lvlComboBox_Enter(object sender, EventArgs e)
        {
            if (lvlComboBox.SelectedItem.ToString() == string.Empty)
            lvlComboBox.EditValue = lvlComboBox.Properties.Items[0].ToString();
        }


        private void numTE_Validating(object sender, System.ComponentModel.CancelEventArgs e)
        {
            if (numTE.Text == string.Empty)
                groupnoField.AppearanceItemCaption.ForeColor = Color.Red;
            else groupnoField.AppearanceItemCaption.ForeColor = SystemColors.ControlText;//    dxErrorProvider1.SetError(numTE, "Field cannot be empty", ErrorType.User1);
            //else dxErrorProvider1.SetError(numTE, "");
        }

        private void numTE_Leave(object sender, EventArgs e)
        {
            var boxText = numTE.Text;
            if (boxText != null)
            {
                var pos = boxText.IndexOf("-", System.StringComparison.Ordinal);
                if (pos == 1)
                    numTE.Text = @"0" + numTE.Text;
            }
        }
    }
}