namespace ReactiveUI.Winforms.Samples.Commands.Views {

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

				// Bind properties
				d( this.OneWayBind( this.ViewModel, vm => vm.ApplicationTitle, v => v.Text ) );

				// Bind property for command with can execute
				d( this.Bind( this.ViewModel, vm => vm.WithCanExecuteParameter, v => v.tbWithCanExecuteParameter.Text ) );

				// Bind parameterless command
				d( this.BindCommand( this.ViewModel, vm => vm.ParameterlessCommand, v => v.btParameterless ) );

				// Bind command with parameter
				var anyValue = this.WhenAnyValue( v => v.tbParameter.Text );
				if ( anyValue != null ) {
					d( this.BindCommand( this.ViewModel, vm => vm.WithParameterCommand, v => v.btWithParameter, anyValue ) );
				}

				// Bind command with can execute
				d( this.BindCommand( this.ViewModel, vm => vm.WithCanExecuteCommand, v => v.btWithCanExecute ) );
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