using ReactiveUI.Winforms.Samples.Commands.ViewModels;
using System.Windows.Forms;

namespace ReactiveUI.Winforms.Samples.Commands.Views
{
    public partial class ShellView : Form, IViewFor<ShellViewModel>
    {
        public ShellView()
        {
            InitializeComponent();

            // Bind properties
            this.OneWayBind(ViewModel, vm => vm.ApplicationTitle, v => v.Text);
            // Bind property for command with can execute
            this.Bind(ViewModel, vm => vm.WithCanExecuteParameter, v => v.tbWithCanExecuteParameter.Text);

            // Bind parameterless command
            this.BindCommand(ViewModel, vm => vm.ParameterlessCommand, v => v.btParameterless);            
            // Bind command with parameter
            this.BindCommand(ViewModel, vm => vm.WithParameterCommand, v => v.btWithParameter, this.WhenAnyValue(v => v.tbParameter.Text));
            // Bind command with can execute
            this.BindCommand(ViewModel, vm => vm.WithCanExecuteCommand, v => v.btWithCanExecute);

            ViewModel = new ShellViewModel();
        }
        
        public ShellViewModel ViewModel { get; set; }

        object IViewFor.ViewModel
        {
            get => ViewModel;
            set => ViewModel = (ShellViewModel)value;
        }
    }
}
