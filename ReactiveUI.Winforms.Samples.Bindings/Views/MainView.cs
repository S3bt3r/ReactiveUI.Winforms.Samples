namespace ReactiveUI.Winforms.Samples.Bindings.Views {

	using System;
	using System.Windows.Forms;
	using ViewModels;

	public partial class MainView : Form, IViewFor<MainViewModel> {

		public MainView() {
			this.InitializeComponent();

			var _ = this.WhenActivated( d => {
				if ( d is null ) {
					return;
				}

				if ( this.ViewModel is null ) {
					return;
				}

				// One way bind from viewmodel to view
				d( this.OneWayBind( this.ViewModel, vm => vm.ApplicationTitle, v => v.Text ) );

				// Two way bind for input (textbox) and one way bind for output (label)
				d( this.Bind( this.ViewModel, vm => vm.ValueOne, v => v.tbInputOne.Text ) );
				d( this.OneWayBind( this.ViewModel, vm => vm.ValueOne, v => v.lOutputOne.Text ) );

				// Two way bind for input (textbox) with convert and one way bind for output (label)
				d( this.Bind( this.ViewModel, vm => vm.ValueTwo, v => v.dtpInputTwo.Value, DateTime.FromFileTime, dt => dt.ToFileTime() ) );
				d( this.OneWayBind( this.ViewModel, vm => vm.ValueTwo, v => v.lOutputTwo.Text ) );
			} );

			this.ViewModel = new MainViewModel();
		}

		public MainViewModel ViewModel { get; set; }

		Object IViewFor.ViewModel {
			get => this.ViewModel;

			set => this.ViewModel = ( MainViewModel ) value;
		}

	}

}