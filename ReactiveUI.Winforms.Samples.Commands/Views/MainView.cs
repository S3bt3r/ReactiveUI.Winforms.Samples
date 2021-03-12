namespace ReactiveUI.Winforms.Samples.Commands.Views
{

	using System;
	using ViewModels;
	using System.Windows.Forms;

	public partial class MainView : Form, IViewFor<MainViewModel>
    {
        public MainView()
        {
	        this.InitializeComponent();

            this.WhenActivated(d =>
            {
                // Bind properties
                d(this.OneWayBind( this.ViewModel, vm => vm.ApplicationTitle, v => v.Text));
                // Bind property for command with can execute
                d(this.Bind( this.ViewModel, vm => vm.WithCanExecuteParameter, v => v.tbWithCanExecuteParameter.Text));

                // Bind parameterless command
                d(this.BindCommand( this.ViewModel, vm => vm.ParameterlessCommand, v => v.btParameterless));
                // Bind command with parameter
                d(this.BindCommand( this.ViewModel, vm => vm.WithParameterCommand, v => v.btWithParameter, this.WhenAnyValue(v => v.tbParameter.Text)));
                // Bind command with can execute
                d(this.BindCommand( this.ViewModel, vm => vm.WithCanExecuteCommand, v => v.btWithCanExecute));
            });

            this.ViewModel = new MainViewModel();
        }
        
        public MainViewModel ViewModel { get; set; }

        Object IViewFor.ViewModel
        {
            get => this.ViewModel;
            set => this.ViewModel = (MainViewModel)value;
        }
    }
}
