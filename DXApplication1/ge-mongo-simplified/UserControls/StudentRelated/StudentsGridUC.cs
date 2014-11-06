using ge_mongo_simplified.Classes;
using ge_mongo_simplified.Forms;

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

        private void studentsGridView_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            var parent = (MainForm)ParentForm;
            if (studentsGridView.FocusedValue != null)
            {
                Properties.Settings.Default.stdFullname =
                    studentsGridView.GetRowCellValue(studentsGridView.FocusedRowHandle,
                        "fullname").ToString();
                Properties.Settings.Default.stdID = studentsGridView.GetRowCellValue(studentsGridView.FocusedRowHandle,
                        "_id").ToString();
                Properties.Settings.Default.Save();
                if (parent != null)
                {
                    parent.actButtonsEnable();
                    parent.studentDetailShow();
                    parent.statusBarLabel = Properties.Settings.Default.stdFullname + @" : " +
                                            Properties.Settings.Default.stdID;
                    parent.studentDetailShow();
                } 
            }
            else if (parent != null)
            {
                parent.actButtonsDisable();
                //parent.showTotalDetail();
            }
        }

        private void studentsGridView_DoubleClick(object sender, System.EventArgs e)
        {
            var parent = (MainForm)ParentForm;
            if (parent != null)
                parent.stdEdit();
        }
    }
}
