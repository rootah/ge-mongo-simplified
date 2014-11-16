using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;
using DevExpress.XtraEditors;

namespace ge_mongo_simplified.UserControls.GroupRelated.FormRelated
{
    public partial class GeneralUC : XtraUserControl
    {
        public GeneralUC()
        {
            InitializeComponent();
        }

/*
        private void lastActionWrite()
        {
            var topLevelControl = (Form)TopLevelControl;

            Settings.Default.lastAction = "Group [" + numTE.Text + " / " + lvlCBE.Text + " / " +
                                                     durationCBE.Text + " / " + timeTE.Text + " / " +
                                                     daysCBE.Text + "] added";

            if (topLevelControl != null) topLevelControl.Text = @"Group [" + numTE.Text + @"]";
        }
*/

        private void numTE_Validating(object sender, CancelEventArgs e)
        {
            var topLevelControl = (Form)TopLevelControl;

            if (numTE.Text == string.Empty)
            {
                numCI.AppearanceItemCaption.ForeColor = Color.OrangeRed;
                //if (topLevelControl != null) topLevelControl.Text = @"Group [.. check group no.]";
            }
            else
            {
                numCI.AppearanceItemCaption.ForeColor = SystemColors.ControlText;
                var boxText = numTE.Text;
                if (boxText != null)
                {
                    var pos = boxText.IndexOf("-", StringComparison.Ordinal);
                    if (pos == 1)
                        numTE.Text = @"0" + numTE.Text;
                    if (topLevelControl != null) topLevelControl.Text = @"Group [" + numTE.Text + @"]";
                }
            }
        }

        private void daysCBE_QueryPopUp(object sender, CancelEventArgs e)
        {
            daysCBE.Properties.PopupFormWidth = daysCBE.Width;
        }
    }
}