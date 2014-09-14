using System;
using System.Drawing;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using DevExpress.XtraLayout.Utils;
using ge_mongo_simplified.Classes;
using MongoDB.Bson;
using MongoDB.Driver;
using MongoDB.Driver.Builders;

namespace ge_mongo_simplified.UserControls
{
    public partial class StdMainUC : XtraUserControl
    {
        public static string connectionString = "mongodb://localhost";
        public static MongoClient client = new MongoClient(connectionString);
        public static MongoServer server = client.GetServer();
        public static MongoDatabase database = server.GetDatabase("devdb");
        public static MongoCollection collection = database.GetCollection("devstds");

        public StdMainUC()
        {
            InitializeComponent();
        }

        private void formCheck()
        {
            if (fnameTE.Text == string.Empty || lnameTE.Text == string.Empty)
            {
                XtraMessageBox.Show(@"Check names!" + Environment.NewLine + " ");
                fnameTE.Focus();
            }
            else writeResult();
        }

        private void writeResult()
        {
            var topLevelControl = (Form)TopLevelControl;
            var id = ObjectId.GenerateNewId(); 
            var newStd = new Student
            {
                _id = id,
                fname = fnameTE.Text,
                lname = lnameTE.Text,
                fullname = fnameTE.Text + @" " + lnameTE.Text,
                underage = underageCE.Checked,
                pname = pnameTE.Text,
                source = sourceCB.Text,
                mphone = mainphoneTE.Text,
                hphone = homephoneTE.Text,
                addphone = addphoneTE.Text,
                email = emailTE.Text,
                skype = skypeTE.Text,
                vk = vkTE.Text,
                watsapp = wappTE.Text,
                cost = costTE.Text,
                discount = discountTE.Text,
                groupno = groupnoCB.Text,
                isindividual = individualCE.Checked,
                
            };

            collection.Insert(newStd);
            lastActionWrite();
            if (topLevelControl != null) topLevelControl.Close();
        }
        private void lastActionWrite()
        {
            //var topLevelControl = (Form)TopLevelControl;
            Properties.Settings.Default.lastAction = "Student [" + fnameTE.Text + @" " + lnameTE.Text + "] added";
            //if (topLevelControl != null) topLevelControl.Text = @"Student [" + fnameTE.Text + @" " + lnameTE.Text + @"]";
        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            formCheck();
            //var topForm = (Form) TopLevelControl;
            //if (topForm != null) topForm.Close();
        }

        private void checkEdit1_CheckedChanged(object sender, EventArgs e)
        {
            var topLevelControl = (Form)TopLevelControl;
            pnameControl.Visibility = underageCE.Checked ? LayoutVisibility.Always : LayoutVisibility.Never;
            if (topLevelControl != null)
                topLevelControl.ClientSize = new Size(ClientSize.Width, layoutControl1.Root.MinSize.Height);
        }

        private void checkEdit2_CheckedChanged(object sender, EventArgs e)
        {
            if (discountCE.Checked)
                discountControl.Control.Enabled = true;
            else
            {
                discountControl.Control.Enabled = false;
                discountControl.Control.Text = string.Empty;}
        }

        private void tabbedControlGroup1_SelectedPageChanged(object sender, DevExpress.XtraLayout.LayoutTabPageChangedEventArgs e)
        {
            var topLevelControl = (Form)TopLevelControl;
            if (topLevelControl != null)
                topLevelControl.ClientSize = new Size(ClientSize.Width, layoutControl1.Root.MinSize.Height);}

        private void cancelButton_Click(object sender, EventArgs e)
        {
            var topLevelControl = (Form)TopLevelControl;
            if (topLevelControl != null) topLevelControl.Close();
        }
    }
}
