using System.Drawing;
using DevExpress.XtraEditors;
using ge_mongo_simplified.UserControls;

namespace ge_mongo_simplified.Forms
{
    public partial class NewGroupsForm : XtraForm
    {
        public NewGroupsForm(MainForm mainForm)
        {
            InitializeComponent();
        }

        private void NewGroupsForm_Load(object sender, System.EventArgs e)
        {
            tabbedView.Controller.Activate(groupGeneralInfoUcDocument);
            Size = new Size(250, 290);
            //ClientSize = new Size(ClientSize.Width, groupGeneralInfoUc.);
            //ClientSize = new Size(ClientSize.Width, groupGeneralInfoUcDocument.Manager.ClientControl.MinimumSize.Height);
            //if (Properties.Settings.Default.formType == "edit")
            //    groupGeneralInfoUc1.groupEditFormFill();
        }

        private void tabbedView_QueryControl(object sender, DevExpress.XtraBars.Docking2010.Views.QueryControlEventArgs e)
        {
            if (e.Document == groupGeneralInfoUcDocument)
                e.Control = new GroupGeneralInfoUc();
            if (e.Document == groupPaymentsInfoUCDocument)
                e.Control = new GroupPaymentsInfoUC();
        }

        private void NewGroupsForm_Resize(object sender, System.EventArgs e)
        {
            Text = "[" + this.Height + " : " + this.Width + "]";
        }
    }
}
