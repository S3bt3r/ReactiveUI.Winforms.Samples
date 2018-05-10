using ReactiveUI.Winforms.Samples.Bindings.Views;
using System;
using System.Windows.Forms;

namespace ReactiveUI.Winforms.Samples.Bindings
{
    static class Program
    {
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new MainView());
        }
    }
}
