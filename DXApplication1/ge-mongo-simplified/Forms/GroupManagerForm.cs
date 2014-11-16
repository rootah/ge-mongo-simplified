using System.Drawing;
using DevExpress.XtraEditors;
using ge_mongo_simplified.UserControls.GroupRelated.FormRelated;

namespace ge_mongo_simplified.Forms
{
    public partial class GroupManagerForm : XtraForm
    {
        private readonly MainForm _main;

        public GroupManagerForm(MainForm mainForm)
        {
            InitializeComponent();
            _main = mainForm;
        }

        private void GroupsManagerForm_Load(object sender, System.EventArgs e)
        {
            formResize();
            groupManagerUc1.tabbedView1.Controller.Activate(groupManagerUc1.groupGeneralInfoUcDocument);

            if (Properties.Settings.Default.formType == "edit")
                GroupManagerUc.formFill();
        }

        private void formResize()
        {
            var clientControl = GroupManagerUc.groupGeneralControl.groupLC;
            clientControl.Height = clientControl.Root.MinSize.Height;
            ClientSize = new Size(ClientSize.Width, clientControl.Height);
        }
        private void GroupsForm_FormClosed(object sender, System.Windows.Forms.FormClosedEventArgs e)
        {
            _main.groupGridFill();
            _main.groupFocusBack(Properties.Settings.Default.groupID);
        }
    }
}