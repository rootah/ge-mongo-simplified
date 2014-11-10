using System;
using System.Drawing;
using DevExpress.XtraBars.Docking2010;
using DevExpress.XtraBars.Docking2010.Views.Tabbed;
using DevExpress.XtraEditors;
using DevExpress.XtraLayout;
using ge_mongo_simplified.Classes;
using ge_mongo_simplified.UserControls.StudentRelated.FormRelated;

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
            //formResize();
        }

        private void formResize()
        {
            docManagerTwoUC1.topLC.Height = docManagerTwoUC1.topLC.Root.MinSize.Height;
            Size = docManagerTwoUC1.underageCE.Checked ? new Size(Size.Width, 438) : new Size(Size.Width, 415);
            groupComboFill();
        }

        public void groupComboFill()
        {

            
            //var orgdoc = docManagerTwoUC1.orgUCDocument.Control;
            //XtraMessageBox.Show(orgdoc.Name);
            //if (orgdoc != null) XtraMessageBox.Show(orgdoc);
            //docManagerTwoUC1.orgUCDocument.Control("groupnoCB").Properties.Items.Clear();
            //var groups = Mongo.groupList();
            //for (var i = 0; i <= groups.Count - 1; i++)
            //{
            //    OrgUC.groupnoCB.Properties.Items.Add(groups[i].num);
            //}
        }
    }
}
