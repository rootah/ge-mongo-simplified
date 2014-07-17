using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using ge_mongo_simplified.Forms;

namespace ge_mongo_simplified.UserControls
{
    public partial class StudentGeneralInfoUC : DevExpress.XtraEditors.XtraUserControl
    {
        public StudentGeneralInfoUC(StudentsForm studentsForm)
        {
            InitializeComponent();
        }
    }
}
