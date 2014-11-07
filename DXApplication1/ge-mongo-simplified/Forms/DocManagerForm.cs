using System;
using System.Drawing;
using DevExpress.XtraEditors;

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
            docManagerTwoUC1.tabbedView1.Controller.Activate(docManagerTwoUC1.contactsUCDocument);
            formResize();
            DocManagerForm_Resize(null, null);
        }

        private void formResize()
        {
            docManagerTwoUC1.layoutControl1.Height = docManagerTwoUC1.layoutControl1.Root.MinSize.Height;
            Size = docManagerTwoUC1.underageCE.Checked ? new Size(Size.Width, 438) : new Size(Size.Width, 415);
        }

        private void DocManagerForm_Resize(object sender, EventArgs e)
        {
            var docsize = docManagerTwoUC1.documentManager1.ContainerControl.Height;
            var layoutControlSize = docManagerTwoUC1.layoutControlGroup1.Height;
            Text = Height.ToString() + " : " + Width.ToString() + " / " + layoutControlSize + " / " + docsize;
        }
    }
}
