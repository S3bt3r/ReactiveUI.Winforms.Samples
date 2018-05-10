using System;
using System.Windows.Forms;

namespace ReactiveUI.Winforms.Samples.Routing
{
    static class Program
    {
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            // Create and run Bootstrapper
            var bootstrapper = new Bootstrapper();
            bootstrapper.Run();            
        }
    }
}
