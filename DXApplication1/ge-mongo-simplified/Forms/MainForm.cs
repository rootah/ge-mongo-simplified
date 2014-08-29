using System;
using System.ComponentModel;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using DevExpress.Data.PLinq.Helpers;
using DevExpress.Utils;
using DevExpress.XtraBars;
using DevExpress.XtraBars.Ribbon;
using DevExpress.XtraEditors;
using DevExpress.XtraEditors.Controls;
using ge_mongo_simplified.Classes;
using ge_mongo_simplified.UserControls;
using MongoDB.Bson;
using MongoDB.Driver;
using MongoDB.Driver.Builders;
using MongoDB.Driver.Linq;

namespace ge_mongo_simplified.Forms
{
    public partial class MainForm : RibbonForm
    {
        public static string connectionString = "mongodb://localhost";
        public static MongoClient client = new MongoClient(connectionString);
        public static MongoServer server = client.GetServer();
        public static MongoDatabase database = server.GetDatabase("devdb");
        public static MongoCollection groupCollection = database.GetCollection("devgroups");

        public MainForm()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            if (xtraTabControl != null) xtraTabControl.ShowTabHeader = DefaultBoolean.False;
            groupsCheckButton_DownChanged(null, null);
            detailsCheckButton_DownChanged(null, null);
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

        private void groupRefreshButton_ItemClick(object sender, ItemClickEventArgs e)
        {
            //var cursor = groupCollection.FindAllAs<Group>();
            //cursor.SetFields(Fields.Include("num"));
            //var gridSource = cursor.ToList();
            //groupsGridUC2.groupsGrid.DataSource = gridSource;

            groupsGridUC2.groupsGrid.Visible = false;
            groupsGridUC2.groupsGrid.DataSource = new BindingList<Group>(groupCollection.FindAllAs<Group>().ToList());
            for (int i = 0; i <= groupsGridUC2.groupsGridView.Columns.Count - 1; i++)
                groupsGridUC2.groupsGridView.Columns[i].Visible = false;
            groupsGridUC2.groupsGridView.Columns["num"].Visible = true;
            groupsGridUC2.groupsGrid.Visible = true;
        }

        private void barButtonItem1_ItemClick(object sender, ItemClickEventArgs e)
        {
            var activecontrol = this.ActiveControl.Name;
            Text = @"ge.base [ black hole sun ] + " + activecontrol.ToString();
        }

        private void editButton_ItemClick(object sender, ItemClickEventArgs e)
        {
            if (ActiveControl == groupsGridUC2)
            {
                var newGroup = new GroupsForm(this) {StartPosition = FormStartPosition.CenterParent, Text = @"Group [edit]"};
                Properties.Settings.Default.formType = "edit";
                Properties.Settings.Default.groupID = groupsGridUC2.groupsGridView.GetRowCellValue(groupsGridUC2.groupsGridView.FocusedRowHandle, "_id").ToString();
                Properties.Settings.Default.Save();
                newGroup.ShowDialog();
            }
            else if (ActiveControl == studetsGridUC1)
            {
                var newStudent = new StudentsForm(this) {StartPosition = FormStartPosition.CenterParent, Text = @"Student [edit]"};
                Properties.Settings.Default.formType = "edit";
                Properties.Settings.Default.Save();
                newStudent.ShowDialog();
            }
        }
    }
}