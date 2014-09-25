using System.Drawing;
using DevExpress.XtraEditors;
using ge_mongo_simplified.Classes;

namespace ge_mongo_simplified.Forms
{
    public partial class StudentsForm : XtraForm
    {
        private readonly MainForm _mainForm;

        public StudentsForm(MainForm mainForm)
        {
            _mainForm = mainForm;
            InitializeComponent();
        }

        private void StudentsForm_Load(object sender, System.EventArgs e)
        {
            formResize();
            groupComboFill();
            stdMainUC1.infoCG.SelectedTabPageIndex = 0;
            if (Properties.Settings.Default.formType == "edit")
                stdMainUC1.studentEditFormFill();
        }

        public void formResize()
        {
            ClientSize = new Size(ClientSize.Width, stdMainUC1.layoutControl1.Root.MinSize.Height);
        }

        public void groupComboFill()
        {
            stdMainUC1.groupnoCB.Properties.Items.Clear();
            var groups = Mongo.groupList();
            for (var i = 0; i <= groups.Count - 1; i++)
            {
                stdMainUC1.groupnoCB.Properties.Items.Add(groups[i].num);
            }
        }

        private void StudentsForm_FormClosed(object sender, System.Windows.Forms.FormClosedEventArgs e)
        {
            _mainForm.stdGridFill();
            _mainForm.stdFocusBack();
        }
    }
}