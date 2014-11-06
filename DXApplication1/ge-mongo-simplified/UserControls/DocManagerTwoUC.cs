using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using DevExpress.XtraLayout.Utils;
using ge_mongo_simplified.UserControls.StudentRelated.FormRelated;

namespace ge_mongo_simplified.UserControls
{
    public partial class DocManagerTwoUC : XtraUserControl
    {
        public DocManagerTwoUC()
        {
            InitializeComponent();
        }

        private void tabbedView1_QueryControl(object sender,
            DevExpress.XtraBars.Docking2010.Views.QueryControlEventArgs e)
        {
            if (e.Document == contactsUCDocument)
                e.Control = new ContactsUC();
            if (e.Document == orgUCDocument)
                e.Control = new OrgUC();
            if (e.Document == paymentsUCDocument)
                e.Control = new PaymentsUC();
        }

        private void underageCE_CheckedChanged(object sender, System.EventArgs e)
        {
            layoutControl1.BeginUpdate();
            if (underageCE.Checked)
            {
                pnameCI.Visibility = LayoutVisibility.Always;
                formResize(23);
            }
            else
            {
                pnameCI.Visibility = LayoutVisibility.Never;
                formResize(-23);
            }
            layoutControl1.Size = new Size(layoutControl1.Width, layoutControl1.Root.MinSize.Height);
            layoutControl1.EndUpdate();
        }

        public void formResize(int delta)
        {
            var parentForm = (Form) TopLevelControl;
            if (parentForm != null)
            {
                parentForm.Height = parentForm.Height + delta;
            }
        }
    }
}
