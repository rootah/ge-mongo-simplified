using System.Drawing;
using DevExpress.XtraEditors;

namespace ge_mongo_simplified.Forms
{
    public partial class StudentsForm : XtraForm
    {
        public StudentsForm(MainForm mainForm)
        {
            //MainForm = mainForm;
            InitializeComponent();
        }

        private void StudentsForm_Load(object sender, System.EventArgs e)
        {
            FormResize();
        }

        private void FormResize()
        {
            ClientSize = new Size(ClientSize.Width, stdMainUC1.layoutControl1.Root.MinSize.Height);
        }
    }
}