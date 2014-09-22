using System;
using DevExpress.XtraTreeList.Menu;
using ge_mongo_simplified.Forms;

namespace ge_mongo_simplified.UserControls
{
    public partial class GroupGrid2UC : DevExpress.XtraEditors.XtraUserControl
    {
        public GroupGrid2UC()
        {
            InitializeComponent();
        }

        public void groupTL_FocusedNodeChanged(object sender, DevExpress.XtraTreeList.FocusedNodeChangedEventArgs e)
        {
            var parent = (MainForm)ParentForm;
            if (groupTL.FocusedNode != null)
            {
                var nodeVal = groupTL.FocusedNode.GetValue(colNum).ToString();
                if (nodeVal.Contains("All ["))
                {
                    if (parent != null)
                    {
                        parent.actButtonsDisable();
                        parent.showTotalDetail();
                    }

                }
                else if (parent != null)
                {
                    Properties.Settings.Default.groupNo =
                        groupTL.FocusedNode.GetValue(groupTL.Columns.ColumnByName("colNum")).ToString();
                    Properties.Settings.Default.groupID =
                        groupTL.FocusedNode.GetValue(groupTL.Columns.ColumnByName("colID")).ToString();
                    Properties.Settings.Default.Save();
                    parent.actButtonsEnable();
                    parent.hideTotalDetail();
                    parent.statusBarLabel = Properties.Settings.Default.groupNo + @" : " +
                                            Properties.Settings.Default.groupID;
                }
            }
        }

        private void groupTL_DoubleClick(object sender, System.EventArgs e)
        {
            var parent = (MainForm)ParentForm;
            var nodeVal = groupTL.FocusedNode.GetValue(colNum).ToString();
            if (!nodeVal.Contains("All ["))
                if (parent != null) parent.groupEdit();
        }

        private void groupTL_PopupMenuShowing(object sender, DevExpress.XtraTreeList.PopupMenuShowingEventArgs e)
        {
            var nodeVal = groupTL.FocusedNode.GetValue(colNum).ToString();
            if (!nodeVal.Contains("All ["))
            {
                if (e.Menu is TreeListNodeMenu)
                {
                    groupTL.FocusedNode = ((TreeListNodeMenu) e.Menu).Node;
                    e.Menu.Items.Add(new DevExpress.Utils.Menu.DXMenuItem("Edit", bbEdit_ItemClick));
                    e.Menu.Items.Add(new DevExpress.Utils.Menu.DXMenuItem("Add group", bbAddChild_ItemClick));
                    e.Menu.Items.Add(new DevExpress.Utils.Menu.DXMenuItem("Delete", bbDelete_ItemClick));
                }
            }
        }

        private void bbDelete_ItemClick(object sender, EventArgs e)
        {
            var parent = (MainForm)ParentForm;
            if (parent != null) parent.groupDel();
        }

        private void bbAddChild_ItemClick(object sender, EventArgs e)
        {
            var parent = (MainForm) ParentForm;
            if (parent != null) parent.newGroupButton_ItemClick(null, null);
        }

        private void bbEdit_ItemClick(object sender, EventArgs e)
        {
            var parent = (MainForm)ParentForm;
            if (parent != null) parent.groupEdit();
        }
    }
}