namespace ReactiveUI.Winforms.Samples.Routing {

	using System;
	using System.Windows.Forms;

	public static class Program {

		[STAThread]
		public static void Main() {
			Application.EnableVisualStyles();
			Application.SetCompatibleTextRenderingDefault( false );

			// Create and run Bootstrapper
			var bootstrapper = new Bootstrapper();
			bootstrapper.Run();
		}

	}

}