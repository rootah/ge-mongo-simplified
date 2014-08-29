using System.Drawing;
using System.Windows.Forms;
using DevExpress.XtraLayout.Utils;
using DevExpress.XtraGrid.Views.Grid;
using DevExpress.XtraGrid.Views.Grid.ViewInfo;
using ge_mongo_simplified.Forms;

namespace ge_mongo_simplified.UserControls
{
    public partial class GroupsGridUC : DevExpress.XtraEditors.XtraUserControl
    {
        public GroupsGridUC()
        {
            InitializeComponent();
        }

        private void searchCheckBtn_CheckedChanged(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            searchControl.Visibility = searchCheckBtn.Checked ? LayoutVisibility.Always : LayoutVisibility.Never;
        }

        private void groupsGridView_DoubleClick(object sender, System.EventArgs e)
        {
            var newGroup = new GroupsForm(new MainForm()) { StartPosition = FormStartPosition.CenterParent, Text = @"Group [edit]" };
            var view = (GridView)sender;
            var hitInfo = view.CalcHitInfo(view.GridControl.PointToClient(MousePosition));
            if (hitInfo.HitTest == GridHitTest.RowCell)
                Properties.Settings.Default.groupID = view.GetRowCellValue(hitInfo.RowHandle, "_id").ToString();
            Properties.Settings.Default.formType = "edit";
            Properties.Settings.Default.Save();
            newGroup.ShowDialog();
        }
    }
}
