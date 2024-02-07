using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ClientInterface
{
    internal static class Program
    {

        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        private static bool kraj = false;
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            while (!kraj)
            {
                    FormLogin formLogin = new FormLogin();
                    formLogin.ShowDialog();
                    DialogResult dialogResult = formLogin.DialogResult;
                    formLogin.Dispose();
                    if(dialogResult== DialogResult.OK)
                    {
                        Application.Run(new FormMain());
                    }else kraj = true;
            }
        }
    }
}
