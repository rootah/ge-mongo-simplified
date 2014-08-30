using DevExpress.XtraBars;
using DevExpress.XtraLayout.Utils;
using ge_mongo_simplified.Forms;

namespace ge_mongo_simplified.UserControls
{
    public partial class GroupsGridUC : DevExpress.XtraEditors.XtraUserControl
    {
        public GroupsGridUC()
        {
            InitializeComponent();}

        private void searchCheckBtn_CheckedChanged(object sender, ItemClickEventArgs e)
        {
            searchControl.Visibility = searchCheckBtn.Checked ? LayoutVisibility.Always : LayoutVisibility.Never;
        }

        private void groupsGridView_DoubleClick(object sender, System.EventArgs e)
        {
            var mainForm = (MainForm)ParentForm;
            if (mainForm != null) mainForm.groupEdit();
        }

        private void groupsGridView_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            Properties.Settings.Default.groupID =
                groupsGridView.GetRowCellValue(groupsGridView.FocusedRowHandle, "_id").ToString();
            Properties.Settings.Default.Save();

            var mainForm = (MainForm)ParentForm;
            //if (mainForm != null) mainForm.statusBarLabel = Properties.Settings.Default.groupID;
            if (mainForm != null) mainForm.groupDetailShow();
        }
    }
}
