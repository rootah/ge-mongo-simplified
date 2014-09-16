using ge_mongo_simplified.Forms;

namespace ge_mongo_simplified.UserControls
{
    public partial class GroupGrid2UC : DevExpress.XtraEditors.XtraUserControl
    {
        public GroupGrid2UC()
        {
            InitializeComponent();
        }

        private void groupTL_FocusedNodeChanged(object sender, DevExpress.XtraTreeList.FocusedNodeChangedEventArgs e)
        {
            var parent = (MainForm)ParentForm;
            var nodeVal = groupTL.FocusedNode.GetValue(colNum).ToString();
            if (nodeVal.Contains("All ["))
            {
                if (parent != null) parent.actButtosDisable();
            }
            else if (parent != null)
            {
                Properties.Settings.Default.groupNo =
                    groupTL.FocusedNode.GetValue(groupTL.Columns.ColumnByName("colNum")).ToString();
                Properties.Settings.Default.groupID =
                    groupTL.FocusedNode.GetValue(groupTL.Columns.ColumnByName("colID")).ToString();
                Properties.Settings.Default.Save();
                parent.actButtonsEnable();
                parent.groupDetailShow();
                parent.statusBarLabel = Properties.Settings.Default.groupNo + @" : " +
                                        Properties.Settings.Default.groupID;
            }
        }

        private void groupTL_DoubleClick(object sender, System.EventArgs e)
        {
            var parent = (MainForm)ParentForm;
            var nodeVal = groupTL.FocusedNode.GetValue(colNum).ToString();
            if (!nodeVal.Contains("All ["))
                if (parent != null) parent.groupEdit();
        }
    }
}