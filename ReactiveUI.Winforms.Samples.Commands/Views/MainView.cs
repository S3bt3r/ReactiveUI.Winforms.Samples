using ReactiveUI.Winforms.Samples.Commands.ViewModels;
using System.Windows.Forms;

namespace ReactiveUI.Winforms.Samples.Commands.Views
{
    public partial class MainView : Form, IViewFor<MainViewModel>
    {
        public MainView()
        {
            InitializeComponent();

            this.WhenActivated(d =>
            {
                // Bind properties
                d(this.OneWayBind(ViewModel, vm => vm.ApplicationTitle, v => v.Text));
                // Bind property for command with can execute
                d(this.Bind(ViewModel, vm => vm.WithCanExecuteParameter, v => v.tbWithCanExecuteParameter.Text));

                // Bind parameterless command
                d(this.BindCommand(ViewModel, vm => vm.ParameterlessCommand, v => v.btParameterless));
                // Bind command with parameter
                d(this.BindCommand(ViewModel, vm => vm.WithParameterCommand, v => v.btWithParameter, this.WhenAnyValue(v => v.tbParameter.Text)));
                // Bind command with can execute
                d(this.BindCommand(ViewModel, vm => vm.WithCanExecuteCommand, v => v.btWithCanExecute));
            });

            ViewModel = new MainViewModel();
        }
        
        public MainViewModel ViewModel { get; set; }

        object IViewFor.ViewModel
        {
            get => ViewModel;
            set => ViewModel = (MainViewModel)value;
        }
    }
}
