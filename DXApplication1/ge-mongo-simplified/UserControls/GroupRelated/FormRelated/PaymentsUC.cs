using DevExpress.XtraEditors;

namespace ge_mongo_simplified.UserControls.GroupRelated.FormRelated
{
    public partial class GroupPaymentsInfoUC : XtraUserControl
    {
        private readonly GroupManagerUc _groupManagerUc;

        public GroupPaymentsInfoUC(GroupManagerUc groupManagerUc)
        {
            _groupManagerUc = groupManagerUc;
            InitializeComponent();
        }
    }
}
