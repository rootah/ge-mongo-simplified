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
            if (detailsTC.SelectedTabPageIndex == 0)
                detailsLabel.Text = @"Details [group]";
            else if (detailsTC.SelectedTabPageIndex == 1)
                detailsLabel.Text = @"Details [student]";
        }
    }
}
