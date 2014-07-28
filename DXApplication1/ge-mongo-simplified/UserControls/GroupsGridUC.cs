﻿using DevExpress.XtraLayout.Utils;

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
    }
}
