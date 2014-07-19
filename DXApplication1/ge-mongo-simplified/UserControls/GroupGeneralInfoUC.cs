﻿using System;
using System.Windows.Forms;
using DevExpress.XtraLayout.Utils;

namespace ge_mongo_simplified.UserControls
{
    public partial class GroupGeneralInfoUc : DevExpress.XtraEditors.XtraUserControl
    {
        public GroupGeneralInfoUc()
        {
            InitializeComponent();
        }

        private void customtimeCheck_CheckedChanged(object sender, EventArgs e)
        {
            customtimeCG.Visibility = customtimeCheck.Checked ? LayoutVisibility.Always : LayoutVisibility.Never;}
    }
}