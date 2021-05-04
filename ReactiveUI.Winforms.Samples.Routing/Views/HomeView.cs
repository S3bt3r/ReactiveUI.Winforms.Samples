namespace ReactiveUI.Winforms.Samples.Routing.Views {

	using System;
	using System.Windows.Forms;
	using ViewModels;

	public partial class HomeView : UserControl, IViewFor<HomeViewModel> {

		public HomeView() {
			this.InitializeComponent();

			var _ = this.WhenActivated( d => d?.Invoke( this.OneWayBind( this.ViewModel, vm => vm.ViewTitle, v => v.lViewTitle.Text ) ) );
		}

		public HomeViewModel ViewModel { get; set; }

		Object IViewFor.ViewModel {
			get => this.ViewModel;

			set => this.ViewModel = ( HomeViewModel ) value;
		}

	}

}