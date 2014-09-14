﻿using System;
using System.ComponentModel;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using DevExpress.Utils;
using DevExpress.XtraBars;
using DevExpress.XtraBars.Ribbon;
using DevExpress.XtraEditors;
using DevExpress.XtraGrid;
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
            // datasource add here <<<
        }

        public void groupGridFill()
        {
            groupsGridUC2.groupsGrid.Visible = false;
            groupsGridUC2.groupsGrid.DataSource = new BindingList<Group>(groupCollection.FindAllAs<Group>().ToList());
            for (int i = 0; i <= groupsGridUC2.groupsGridView.Columns.Count - 1; i++)
                groupsGridUC2.groupsGridView.Columns[i].Visible = false;
            groupsGridUC2.groupsGridView.Columns["num"].Visible = true;
            groupsGridUC2.groupsGrid.Visible = true;
        }
        public void groupEdit()
        {
            Properties.Settings.Default.formType = "edit";
            Properties.Settings.Default.groupNo = groupsGridUC2.groupsGridView.GetRowCellValue(groupsGridUC2.groupsGridView.FocusedRowHandle, "num").ToString();
            Properties.Settings.Default.groupID = groupsGridUC2.groupsGridView.GetRowCellValue(groupsGridUC2.groupsGridView.FocusedRowHandle, "_id").ToString();
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
        {
            if (ActiveControl == groupsGridUC2)
            {
                groupEdit();
            }
            else if (ActiveControl == studetsGridUC1)
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
            groupDetailShow();
        }

        public void groupDetailShow()
        {
            var q = Query.EQ("_id", ObjectId.Parse(Properties.Settings.Default.groupID));
            var resdoc = groupCollection.FindOneAs<Group>(q);

            //var data = new BindingList<Group>(groupCollection.FindAs<Group>(q).ToList());
            //foreach (var res in resdoc.days)
            //    list.Add(res.ToString());
            //detailsUC1.groupDetailGridControl.DataSource = data;

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

        public void focusBack(string num)
        {
            var rowHandle = groupsGridUC2.groupsGridView.LocateByValue("num", num);
            if (rowHandle != GridControl.InvalidRowHandle)
                groupsGridUC2.groupsGridView.FocusedRowHandle = rowHandle;
        }

        private void delButton_ItemClick(object sender, ItemClickEventArgs e)
        {
            if (ActiveControl == groupsGridUC2)
            {
                groupDel();
            }
            else if (ActiveControl == studetsGridUC1)
            {
                studentEdit();
            }
        }

        private void groupDel()
        {
            var groupNo = groupsGridUC2.groupsGridView.GetRowCellValue(groupsGridUC2.groupsGridView.FocusedRowHandle, "num").ToString();
            DialogResult myResult = XtraMessageBox.Show(@"Group " + groupNo + @" will be deleted. Is it OK?", @"Delete Confirmation", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            if (myResult == DialogResult.OK){var query = Query.EQ("_id", ObjectId.Parse(Properties.Settings.Default.groupID));
                groupCollection.Remove(query);
                groupsGridUC2.groupsGridView.FocusedRowHandle = 0; 
                groupGridFill();
            }
        }
    }
}