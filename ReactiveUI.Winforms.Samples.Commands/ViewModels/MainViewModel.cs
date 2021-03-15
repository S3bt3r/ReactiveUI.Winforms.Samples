namespace ReactiveUI.Winforms.Samples.Commands.ViewModels {

	using System;
	using System.Reactive;
	using System.Reactive.Linq;
	using System.Windows;

	public class MainViewModel : ReactiveObject {

		private String _applicationTitle;

		private String _withCanExecuteParameter;

		public MainViewModel() {
			// Set properties
			this.ApplicationTitle = "ReactiveUI Winforms Samples by Asesjix - Commands";

			// Create parameterless command
			this.ParameterlessCommand = ReactiveCommand.Create( this.Parameterless );

			// Create command with parameter
			this.WithParameterCommand = ReactiveCommand.Create<String>( this.WithParameter );

			// Create command with can execute
			this.WithCanExecuteCommand = ReactiveCommand.Create( this.WithCanExecute,
				this.WhenAnyValue( vm => vm.WithCanExecuteParameter )?.Select( s => String.IsNullOrEmpty( s ) == false ) );
		}

		public String ApplicationTitle {
			get => this._applicationTitle;

			set => this.RaiseAndSetIfChanged( ref this._applicationTitle, value );
		}

		public String WithCanExecuteParameter {
			get => this._withCanExecuteParameter;

			set => this.RaiseAndSetIfChanged( ref this._withCanExecuteParameter, value );
		}

		public ReactiveCommand<Unit, Unit> ParameterlessCommand { get; }

		public ReactiveCommand<String, Unit> WithParameterCommand { get; }

		public ReactiveCommand<Unit, Unit> WithCanExecuteCommand { get; }

		private void Parameterless() => MessageBox.Show( "You pressed the button!", this.ApplicationTitle, MessageBoxButton.OK );

		private void WithParameter( String message ) => MessageBox.Show( message, this.ApplicationTitle, MessageBoxButton.OK );

		private void WithCanExecute() => MessageBox.Show( this.WithCanExecuteParameter, this.ApplicationTitle, MessageBoxButton.OK );

	}

}