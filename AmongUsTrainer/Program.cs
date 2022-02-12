using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using Memory;

namespace AmongUsTrainer
{
    internal static class Program
    {
        
        private static ProcessModule GetGameAssemblyModule(Process proc)
        {
            return proc.Modules.Cast<ProcessModule>().FirstOrDefault(procModule => procModule.ModuleName == "GameAssembly.dll");
        }
        
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        private static void Main()
        {
            var proc = Process.GetProcessesByName("Among Us")[0];
            var procModule = GetGameAssemblyModule(proc);
            var mem = new Mem();
            mem.OpenProcess(proc.Id);
            
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1(mem, procModule));
        }
    }
}