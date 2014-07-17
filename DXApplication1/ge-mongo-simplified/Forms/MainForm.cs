using System;
using System.Windows.Forms;
using DevExpress.Utils;
using DevExpress.XtraBars.Ribbon;
using DevExpress.XtraEditors;

namespace ge_mongo_simplified.Forms
{
    public partial class MainForm : RibbonForm
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            if (xtraTabControl != null) xtraTabControl.ShowTabHeader = DefaultBoolean.False;
        }

        private void barButtonItem8_DownChanged(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            splitContainerControl1.PanelVisibility = groupsCheckButton.Down ? SplitPanelVisibility.Both : SplitPanelVisibility.Panel2;
        }

        private void barButtonItem9_DownChanged(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            splitContainerControl2.PanelVisibility = detailsCheckButton.Down
                ? SplitPanelVisibility.Both
                : SplitPanelVisibility.Panel1;
        }

        private void newStudentButton_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            var newStudent = new StudentsForm(this)
            {
                StartPosition = FormStartPosition.CenterParent,
                Text = @"Student [new]"
            };
            newStudent.ShowDialog();
        }

        private void newGroupButton_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            var newGroup = new GroupsForm(this) {StartPosition = FormStartPosition.CenterParent, Text = @"Group [new]"};
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
    }
}