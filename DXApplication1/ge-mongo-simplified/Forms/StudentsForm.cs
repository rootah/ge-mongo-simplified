using DevExpress.XtraBars.Docking2010.Views.WindowsUI;
using ge_mongo_simplified.UserControls;

namespace ge_mongo_simplified.Forms
{
    public partial class StudentsForm : DevExpress.XtraEditors.XtraForm
    {
        public MainForm MainForm { get; set; }

        FlyoutAction closeAppAction = new FlyoutAction()
        {
            Caption = "Confirm",
            Description = "Quit the application?"
        };

        public StudentsForm(MainForm mainForm)
        {
            MainForm = mainForm;
            InitializeComponent();
            closeAppAction.Commands.Add(FlyoutCommand.OK);
            closeAppAction.Commands.Add(FlyoutCommand.Cancel);
            closeAppFlyout.Action = closeAppAction;
        }

        private void windowsUIView1_QueryControl(object sender, DevExpress.XtraBars.Docking2010.Views.QueryControlEventArgs e)
        {
            if (e.Document == studentGeneralInfoUCDocument)
                e.Control = new StudentGeneralInfoUC(this);
            if (e.Document == studentPaymentInfoUCDocument)
                e.Control = new StudentPaymentInfoUC(this);
        }

        private void StudentsForm_FormClosing(object sender, System.Windows.Forms.FormClosingEventArgs e)
        {
            if (windowsUIView1.ShowFlyoutDialog(closeAppFlyout) != System.Windows.Forms.DialogResult.OK) e.Cancel = true;
        }
    }
}