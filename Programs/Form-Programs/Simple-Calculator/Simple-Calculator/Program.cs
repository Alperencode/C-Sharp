using System;
using System.Windows.Forms;

namespace Calculator
{
    static class Program
    {
        // Change the codes from https://github.com/petrediana/Calculator
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Calculator());
        }
    }
}