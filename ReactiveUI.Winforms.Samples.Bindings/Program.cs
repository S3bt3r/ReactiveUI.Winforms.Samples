namespace ReactiveUI.Winforms.Samples.Bindings {

	using System;
	using System.Windows.Forms;
	using Views;

	public static class Program {

		[STAThread]
		public static void Main() {
			Application.EnableVisualStyles();
			Application.SetCompatibleTextRenderingDefault( false );
			Application.Run( new MainView() );
		}

	}

}