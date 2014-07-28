namespace ge_mongo_simplified.UserControls
{
    public partial class DetailsUC : DevExpress.XtraEditors.XtraUserControl
    {
        public DetailsUC()
        {
            InitializeComponent();
        }

        private void xtraTabControl1_SelectedPageChanged(object sender, DevExpress.XtraTab.TabPageChangedEventArgs e)
        {
            if (xtraTabControl1.SelectedTabPageIndex == 0)
                detailsLabel.Text = @"Details [group]";
            else if (xtraTabControl1.SelectedTabPageIndex == 1)
                detailsLabel.Text = @"Details [student]";
        }
    }
}
