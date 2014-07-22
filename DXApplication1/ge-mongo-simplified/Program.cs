using System;
using System.Windows.Forms;
using ge_mongo_simplified.Forms;

namespace ge_mongo_simplified
{
    internal static class Program
    {
        /// <summary>
        ///     The main entry point for the application.
        /// </summary>
        [STAThread]
        private static void Main()
        {
            //Application.EnableVisualStyles();
            //Application.SetCompatibleTextRenderingDefault(true);

            //BonusSkins.Register();
            //SkinManager.EnableFormSkins();
            //UserLookAndFeel.Default.SetSkinStyle("SkinProject1"); 
            Application.Run(new MainForm());
        }
    }
}