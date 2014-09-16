using System;
using System.ComponentModel;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using DevExpress.Utils;
using DevExpress.XtraBars;
using DevExpress.XtraBars.Ribbon;
using DevExpress.XtraEditors;
using DevExpress.XtraTreeList.Nodes;
using ge_mongo_simplified.Classes;
using ge_mongo_simplified.UserControls;
using MongoDB.Bson;
using MongoDB.Driver;
using MongoDB.Driver.Builders;

namespace ge_mongo_simplified.Forms
{
    public partial class MainForm : RibbonForm
    {
        public static string connectionString = "mongodb://localhost";
        public static MongoClient client = new MongoClient(connectionString);
        public static MongoServer server = client.GetServer();
        public static MongoDatabase database = server.GetDatabase("devdb");
        public static MongoCollection groupCollection = database.GetCollection("devgroups");
        public static MongoCollection stdCollection = database.GetCollection("devstds");

        public MainForm()
        {
            InitializeComponent();
        }

        public string statusBarLabel
        {
            get { return statusLabel.Caption; }
            set { statusLabel.Caption = value; }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            if (xtraTabControl != null) xtraTabControl.ShowTabHeader = DefaultBoolean.False;
            groupsCheckButton_DownChanged(null, null);
            detailsCheckButton_DownChanged(null, null);
            groupGridFill();
            stdGridFill();
        }

        private void newStudentButton_ItemClick(object sender, ItemClickEventArgs e)
        {
            var newStudent = new StudentsForm(this)
            {
                StartPosition = FormStartPosition.CenterParent,
                Text = @"Student [new]"
            };
            newStudent.ShowDialog();
        }

        private void newGroupButton_ItemClick(object sender, ItemClickEventArgs e)
        {
            var newGroup = new GroupsForm(this) {StartPosition = FormStartPosition.CenterParent, Text = @"Group [new]"};
            Properties.Settings.Default.formType = "new";
            Properties.Settings.Default.Save();
            newGroup.ShowDialog();
        }

        private void backstageExitButton_ItemClick(object sender, BackstageViewItemEventArgs e)
        {
            Close();
        }

        private void ribbonControl_SelectedPageChanged(object sender, EventArgs e)
        {
            xtraTabControl.SelectedTabPageIndex = ribbonControl.SelectedPage.PageIndex;
        }

        private void groupsCheckButton_DownChanged(object sender, ItemClickEventArgs e)
        {
            if (groupsCheckButton.Down)
            {
                groupstudentsdetailsSplit.PanelVisibility = SplitPanelVisibility.Both;
                groupsCheckButton.Appearance.ForeColor = Color.White;
            }
            else
            {
                groupstudentsdetailsSplit.PanelVisibility = SplitPanelVisibility.Panel2;
                groupsCheckButton.Appearance.ForeColor = SystemColors.ControlText;
            }
        }

        private void detailsCheckButton_DownChanged(object sender, ItemClickEventArgs e)
        {
            if (detailsCheckButton.Down)
            {
                studentsdetailSplit.PanelVisibility = SplitPanelVisibility.Both;
                detailsCheckButton.Appearance.ForeColor = Color.White;
            }
            else
            {
                studentsdetailSplit.PanelVisibility = SplitPanelVisibility.Panel1;
                detailsCheckButton.Appearance.ForeColor = SystemColors.ControlText;
            }
        }

        private void backstageSettingsUI_QueryControl_1(object sender, DevExpress.XtraBars.Docking2010.Views.QueryControlEventArgs e){
            if (e.Document == dbSettingsUCDocument)
                e.Control = new dbSettingsUC(this);
            if (e.Document == oddSettingsUCDocument)
                e.Control = new OddSettingsUC(this);
        }

        public void stdGridFill()
        {
            studentsGridUC1.studentsGrid.Visible = false;
            studentsGridUC1.studentsGrid.DataSource =
                new BindingList<Student>(stdCollection.FindAllAs<Student>().ToList());
            for (int i = 0; i <= studentsGridUC1.studentsGridView.Columns.Count - 1; i++)
                studentsGridUC1.studentsGridView.Columns[i].Visible = false;
            studentsGridUC1.studentsGridView.Columns["addphone"].Visible = true;
            studentsGridUC1.studentsGridView.Columns["mphone"].Visible = true;
            studentsGridUC1.studentsGridView.Columns["fullname"].Visible = true;
            studentsGridUC1.studentsGridView.Columns["fullname"].VisibleIndex = 1;

            studentsGridUC1.studentLabel.Width = studentsGridUC1.studentsGridView.Columns["fullname"].VisibleWidth + 2;
            studentsGridUC1.mainLabel.Width = studentsGridUC1.studentsGridView.Columns["mphone"].VisibleWidth - 11;
            studentsGridUC1.studentsGrid.Visible = true;
        }

        public void stdGridColumnAjust()
        {
            studentsGridUC1.studentLabel.Width = studentsGridUC1.studentsGridView.Columns["fullname"].VisibleWidth + 2;
            studentsGridUC1.mainLabel.Width = studentsGridUC1.studentsGridView.Columns["mphone"].VisibleWidth - 11;
        }

        public void groupGridFill()
        {
            var groupList = new BindingList<Group>(groupCollection.FindAllAs<Group>().ToList());
            groupGrid2UC2.groupTL.Nodes.RemoveAt(0);
            groupGrid2UC2.groupTL.BeginUnboundLoad();
            TreeListNode rootNode = groupGrid2UC2.groupTL.AppendNode(
                new object[] { "All [ " + groupList.Count + @" ] groups" }, null);
            for (int i = 0; i <= groupList.Count - 1; i++)
            {
                groupGrid2UC2.groupTL.AppendNode(new object[] { groupList[i].num, groupList[i]._id }, rootNode);

            }
            groupGrid2UC2.groupTL.EndUnboundLoad();
            groupGrid2UC2.groupTL.ExpandAll();
        }
        public void groupEdit()
        {
            Properties.Settings.Default.formType = "edit";
            Properties.Settings.Default.groupNo = groupGrid2UC2.groupTL.FocusedNode.GetValue(groupGrid2UC2.groupTL.Columns.ColumnByName("colNum")).ToString().Substring(0, 5);
            Properties.Settings.Default.groupID = groupGrid2UC2.groupTL.FocusedNode.GetValue(groupGrid2UC2.groupTL.Columns.ColumnByName("colID")).ToString();

            Properties.Settings.Default.Save();
            var newGroup = new GroupsForm(this) { StartPosition = FormStartPosition.CenterParent, Text = @"Group [" + Properties.Settings.Default.groupNo + @"]" };
            newGroup.ShowDialog();
        }

        public void studentEdit()
        {
            var newStudent = new StudentsForm(this) { StartPosition = FormStartPosition.CenterParent, Text = @"Student [edit]" };
            Properties.Settings.Default.formType = "edit";
            Properties.Settings.Default.Save();
            newStudent.ShowDialog();
        }

        public void editButton_ItemClick(object sender, ItemClickEventArgs e)
        {if (ActiveControl == groupGrid2UC2)
            {
                groupEdit();
            }
        else if (ActiveControl == studentsGridUC1)
            {
                studentEdit();
            }
        }

        private void groupstudentsdetailsSplit_Panel1_Enter(object sender, EventArgs e)
        {
            detailsUC2.detailsTC.SelectedTabPageIndex = 0;
        }

        private void barButtonItem1_ItemClick(object sender, ItemClickEventArgs e)
        {
        }

        public void groupDetailShow()
        {
            var q = Query.EQ("_id", ObjectId.Parse(Properties.Settings.Default.groupID));
            var resdoc = groupCollection.FindOneAs<Group>(q);

            if (resdoc != null)
            {
                detailsUC2.groupDetailsUC2.groupnoCI.Control.Text = resdoc.num;
                detailsUC2.groupDetailsUC2.levelCI.Control.Text = resdoc.lvl;
                detailsUC2.groupDetailsUC2.daysCI.Control.Text = resdoc.days.ToString().Replace(@"[", "").Replace(@"]", "");
                detailsUC2.groupDetailsUC2.timeCI.Control.Text = resdoc.time;
                detailsUC2.groupDetailsUC2.durationCI.Control.Text = resdoc.duration;
                detailsUC2.groupDetailsUC2.idCI.Control.Text = resdoc._id.ToString();
            }
        }
        private void studentsdetailSplit_Panel1_Enter(object sender, EventArgs e)
        {
            detailsUC2.detailsTC.SelectedTabPageIndex = 1;
        }

        private void barButtonItem2_ItemClick(object sender, ItemClickEventArgs e)
        {
            groupGridFill();
        }

        public void focusBack(string id)
        {
            groupGrid2UC2.groupTL.ExpandAll();
            groupGrid2UC2.groupTL.FocusedNode = groupGrid2UC2.groupTL.FindNodeByFieldValue("colIDField",
                ObjectId.Parse(id));
        }

        private void delButton_ItemClick(object sender, ItemClickEventArgs e)
        {
            if (ActiveControl == groupGrid2UC2)
            {
                groupDel();
            }
            else if (ActiveControl == studentsGridUC1)
            {
                studentEdit();
            }
        }

        private void groupDel()
        {
            var id = groupGrid2UC2.groupTL.FocusedNode.GetValue(groupGrid2UC2.groupTL.Columns.ColumnByName("colID")).ToString();
            var num = groupGrid2UC2.groupTL.FocusedNode.GetValue(groupGrid2UC2.groupTL.Columns.ColumnByName("colNum")).ToString();

            DialogResult myResult = XtraMessageBox.Show(@"Group " + num + @" will be deleted. Is it OK?", @"Delete Confirmation", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            if (myResult == DialogResult.OK)
            {
                var query = Query.EQ("_id", ObjectId.Parse(id));
                groupCollection.Remove(query);
                groupGridFill();
            }
        }
        public void actButtonsEnable()
        {
            delButton.Enabled = true;
            editButton.Enabled = true;
        }

        public void actButtosDisable()
        {
            delButton.Enabled = false;
            editButton.Enabled = false;
        }
    }
}