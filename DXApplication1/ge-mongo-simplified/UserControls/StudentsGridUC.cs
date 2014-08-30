using DevExpress.XtraLayout.Utils;

namespace ge_mongo_simplified.UserControls
{
    public partial class StudentsGridUC : DevExpress.XtraEditors.XtraUserControl
    {
        public StudentsGridUC()
        {
            InitializeComponent();
        }

        private void searchCheckBtn_CheckedChanged(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            searchControl.Visibility = searchCheckBtn.Checked ? LayoutVisibility.Always : LayoutVisibility.Never;
        }
    }
}
