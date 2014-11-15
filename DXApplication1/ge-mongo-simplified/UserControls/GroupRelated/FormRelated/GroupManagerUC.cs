using DevExpress.XtraBars.Docking2010.Views;
using DevExpress.XtraEditors;

namespace ge_mongo_simplified.UserControls
{
    public partial class DocManagerUC : XtraUserControl
    {
        public DocManagerUC()
        {
            InitializeComponent();
        }

        private void tabbedView1_QueryControl(object sender, QueryControlEventArgs e)
        {
            if (e.Document == groupGeneralInfoUcDocument)
                e.Control = new GroupGeneralInfoUc();
            if (e.Document == groupPaymentsInfoUCDocument)
                e.Control = new GroupPaymentsInfoUC();
        }
    }
}
