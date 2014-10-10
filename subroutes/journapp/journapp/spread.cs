using System;
using System.Drawing;
using DevExpress.XtraEditors;

namespace journapp
{
    public partial class spread : XtraUserControl
    {
        public spread()
        {
            InitializeComponent();
        }

        private void spreadsheetControl1_CustomDrawColumnHeader(object sender, DevExpress.XtraSpreadsheet.CustomDrawColumnHeaderEventArgs e)
        {
            e.Handled = true;
            var foreColor = Color.Blue;
            var textBounds = e.Bounds;
            var headingFont = new Font(e.Font, FontStyle.Italic);
            var settingsSheet = spreadsheetControl1.Document.Worksheets["Sheet1"];
            var text = settingsSheet.Cells[0, e.ColumnIndex].DisplayText;
            if (text == String.Empty) return;
            var formatHeaderText = new StringFormat
            {
                LineAlignment = StringAlignment.Center,
                Alignment = StringAlignment.Center,
                Trimming = StringTrimming.EllipsisCharacter
            };
            e.Graphics.DrawString(text, headingFont, e.Cache.GetSolidBrush(foreColor), textBounds, formatHeaderText);
        }
    }
}
