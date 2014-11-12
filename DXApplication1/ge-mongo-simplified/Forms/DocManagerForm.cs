using System;
using System.Collections;
using System.Drawing;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using ge_mongo_simplified.Properties;

namespace ge_mongo_simplified.Forms
{
    public partial class DocManagerForm : XtraForm
    {
        public DocManagerForm()
        {
            InitializeComponent();
        }

        private void DocManagerForm_Load(object sender, EventArgs e)
        {
            Width = 265;
            docManagerTwoUC1.studentTabbedView.Controller.Activate(docManagerTwoUC1.contactsUCDocument);
            formResize();
        }

        private void formResize()
        {
            docManagerTwoUC1.topLC.Height = docManagerTwoUC1.topLC.Root.MinSize.Height;
            Size = docManagerTwoUC1.underageCE.Checked ? new Size(Size.Width, 438) : new Size(Size.Width, 415);
        }

        private void DocManagerForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            var arrayList = new ArrayList(docManagerTwoUC1.orgControl.sourceCB.Properties.Items);
            Settings.Default.sourceComboList.Clear();
            Settings.Default.sourceComboList = arrayList;
            Settings.Default.Save();
        }
    }
}
