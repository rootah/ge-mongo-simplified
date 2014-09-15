namespace ge_mongo_simplified.UserControls
{
    public partial class StudentsGridUC : DevExpress.XtraEditors.XtraUserControl
    {
        public StudentsGridUC()
        {
            InitializeComponent();
        }

        private void StudentsGridUC_Resize(object sender, System.EventArgs e)
        {
            if (studentsGridView.VisibleColumns.Count > 0){
                studentLabel.Width = studentsGridView.Columns["fullname"].VisibleWidth + 2;
                mainLabel.Width = studentsGridView.Columns["mphone"].VisibleWidth - 11;
            }
        }
    }
}
