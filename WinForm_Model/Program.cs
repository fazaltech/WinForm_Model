using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinForm_Model
{

    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {

            Assembly thisAssem = typeof(Program).Assembly;
            AssemblyName thisAssemName = thisAssem.GetName();

            Version ver = thisAssemName.Version;

            Console.WriteLine("This is version {0} of {1}.", ver, thisAssemName.Name);

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new frmLogin());
        }
    }
}
