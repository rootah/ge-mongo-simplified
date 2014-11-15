using System.Drawing;
using DevExpress.XtraEditors;
using ge_mongo_simplified.Properties;
using System;
using System.Windows.Forms;
using System.Collections;

namespace ge_mongo_simplified.Forms
{
    public partial class StudentManagerForm : XtraForm
    {
        private readonly MainForm _mainForm;
        public StudentManagerForm(MainForm mainForm)
        {
            _mainForm = mainForm;
            InitializeComponent();
        }

        private void StudentManagerForm_Load(object sender, EventArgs e)
        {
            Width = 265;
            StdManagerUC1.studentTabbedView.Controller.Activate(StdManagerUC1.contactsUCDocument);
            formResize();
        }

        private void formResize()
        {
            StdManagerUC1.topLC.Height = StdManagerUC1.topLC.Root.MinSize.Height;
            Size = StdManagerUC1.underageCE.Checked ? new Size(Size.Width, 438) : new Size(Size.Width, 415);
        }

        private void DocManagerForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            var arrayList = new ArrayList(StdManagerUC1.orgControl.sourceCB.Properties.Items);
            Settings.Default.sourceComboList.Clear();
            Settings.Default.sourceComboList = arrayList;
            Settings.Default.Save();
        }
    }
}
