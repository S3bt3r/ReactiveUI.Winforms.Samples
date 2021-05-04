namespace ReactiveUI.Winforms.Samples.Routing {

	using System.Windows.Forms;
	using Splat;
	using ViewModels;
	using Views;

	public class Bootstrapper {

		public Bootstrapper() => this.ConfigureServices();

		private void ConfigureServices() {
			// Register views
			if ( Locator.CurrentMutable is null ) {
				return;
			}

			Locator.CurrentMutable.Register( () => new ShellView(), typeof( IViewFor<ShellViewModel> ) );
			Locator.CurrentMutable.Register( () => new HomeView(), typeof( IViewFor<HomeViewModel> ) );
			Locator.CurrentMutable.Register( () => new AboutView(), typeof( IViewFor<AboutViewModel> ) );
			Locator.CurrentMutable.Register( () => new ContactView(), typeof( IViewFor<ContactViewModel> ) );
		}

		public void Run() {
			// Create ShellViewModel and register as IScreen
			var viewModel = new ShellViewModel();
			Locator.CurrentMutable.RegisterConstant( viewModel, typeof( IScreen ) );

			// Resolve view for ShellViewModel
			var view = ViewLocator.Current.ResolveView( viewModel );
			if ( view != null ) {
				view.ViewModel = viewModel;

				// Run application
				Application.Run( ( Form ) view );
			}
		}

	}

}