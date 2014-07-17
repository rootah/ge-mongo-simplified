using ge_mongo_simplified.UserControls;

namespace ge_mongo_simplified.Forms
{
    public partial class StudentsForm : DevExpress.XtraEditors.XtraForm
    {
        public MainForm MainForm { get; set; }

        public StudentsForm(MainForm mainForm)
        {
            MainForm = mainForm;
            InitializeComponent();
        }

        private void windowsUIView1_QueryControl(object sender, DevExpress.XtraBars.Docking2010.Views.QueryControlEventArgs e)
        {
            if (e.Document == studentGeneralInfoUCDocument)
                e.Control = new StudentGeneralInfoUC(this);
            if (e.Document == studentPaymentInfoUCDocument)
                e.Control = new StudentPaymentInfoUC(this);
        }
    }
}