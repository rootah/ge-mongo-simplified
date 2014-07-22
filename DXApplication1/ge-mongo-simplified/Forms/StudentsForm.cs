using DevExpress.XtraBars.Docking2010.Views;
using DevExpress.XtraEditors;
using ge_mongo_simplified.UserControls;

namespace ge_mongo_simplified.Forms
{
    public partial class StudentsForm : XtraForm
    {
        public StudentsForm(MainForm mainForm)
        {
            MainForm = mainForm;
            InitializeComponent();
        }

        public MainForm MainForm { get; set; }

        private void windowsUIView1_QueryControl(object sender, QueryControlEventArgs e)
        {
            if (e.Document == studentGeneralInfoUCDocument)
                e.Control = new StudentGeneralInfoUC(this);
            if (e.Document == studentPaymentInfoUCDocument)
                e.Control = new StudentPaymentInfoUC(this);
        }
    }
}