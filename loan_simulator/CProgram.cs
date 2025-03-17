using System;
using System.Windows.Forms;

namespace loan_simulator
{
    internal static class CProgram
    {
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new CMainPanel());           
        }
    }
}
