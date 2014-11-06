using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using ge_mongo_simplified.UserControls;
using DevExpress.XtraPrinting.Export;

namespace ge_mongo_simplified.UserControls.StudentRelated.FormRelated
{
    public partial class ContactsUC : XtraUserControl
    {
        public ContactsUC()
        {
            InitializeComponent();
        }

        private void simpleButton1_Click(object sender, System.EventArgs e)
        {
            //var parentForm = (Form) TopLevelControl;
            //if (parentForm != null)
            //{
            //    var topLayoutControl = parentForm.Controls.Find("docManagerTwoUC1", true).FirstOrDefault();
            //    if (topLayoutControl != null)
            //    {
            //        var control = parentForm.Controls.Find("layoutControl1", true).FirstOrDefault() as DevExpress.XtraLayout.LayoutControl;
            //        if (control != null)
            //        {
            //            //parentForm.ClientSize = new Size(parentForm.Width, parentForm.Height + 250);
            //            control.Size = new Size(control.Width, control.Root.MinSize.Height);
            //        }
            //        //if (control != null) XtraMessageBox.Show(control.Height + " : " + control.Width);
            //        //else XtraMessageBox.Show("control is null");
            //    }
            //    else XtraMessageBox.Show("TopLayoutControl is null");
            //}
            //else XtraMessageBox.Show("Parent is null");
        }
    }
}
