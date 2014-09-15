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
            var parent = (MainForm) ParentForm;
            var nodeVal = groupTL.FocusedNode.GetValue(colNum).ToString();
            if (nodeVal.Contains("All ["))
            {
                if (parent != null) parent.statusBarLabel = "Root node";
            }
            else if (parent != null)
            {
                parent.groupDetailShow2(nodeVal.Substring(0, 5));
                parent.statusBarLabel = nodeVal.Substring(0, 5);}

        }
    }
}
