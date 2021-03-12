namespace ReactiveUI.Winforms.Samples.Bindings
{
	using Views;
	using System;
	using System.Windows.Forms;

	public static class Program
    {
        [STAThread]
        public static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new MainView());
        }
    }
}
