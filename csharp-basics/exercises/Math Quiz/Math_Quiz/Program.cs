using System;
using System.Windows.Forms;

namespace Math_Quiz
{
    static class Program
    {
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Math_Quiz());
        }
    }
}
