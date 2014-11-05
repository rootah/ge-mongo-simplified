﻿using System.Drawing;
using DevExpress.XtraEditors;

namespace ge_mongo_simplified.Forms
{
    public partial class GroupsForm : XtraForm
    {
        private readonly MainForm _main;
        public GroupsForm(MainForm mainForm)
        {
            InitializeComponent();
            _main = mainForm;
        }

        private void GroupsForm_Load(object sender, System.EventArgs e)
        {
            ClientSize = new Size(ClientSize.Width, groupGeneralInfoUc1.layoutControl1.Root.MinSize.Height);
            if (Properties.Settings.Default.formType == "edit")
                groupGeneralInfoUc1.groupEditFormFill();
        }

        private void GroupsForm_FormClosed(object sender, System.Windows.Forms.FormClosedEventArgs e)
        {
            _main.groupGridFill();
            _main.groupFocusBack(Properties.Settings.Default.groupID);
        }
    }
}