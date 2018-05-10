using System.Reactive.Linq;
using System.Windows;

namespace ReactiveUI.Winforms.Samples.Commands.ViewModels
{
    public class MainViewModel : ReactiveObject
    {
        private string _applicationTitle;
        private string _withCanExecuteParameter;

        public MainViewModel()
        {
            // Set properties
            ApplicationTitle = "ReactiveUI Winforms Samples by Asesjix - Commands";
            // Create parameterless command
            ParameterlessCommand = ReactiveCommand.Create(Parameterless);
            // Create command with parameter
            WithParameterCommand = ReactiveCommand.Create<string>(WithParameter);
            // Create command with can execute
            WithCanExecuteCommand = ReactiveCommand.Create(WithCanExecute, 
                this.WhenAnyValue(vm => vm.WithCanExecuteParameter).Select(s => string.IsNullOrEmpty(s) == false));
        }

        public string ApplicationTitle
        {
            get => _applicationTitle;
            set => this.RaiseAndSetIfChanged(ref _applicationTitle, value);
        }

        public string WithCanExecuteParameter
        {
            get => _withCanExecuteParameter;
            set => this.RaiseAndSetIfChanged(ref _withCanExecuteParameter, value);
        }

        public ReactiveCommand ParameterlessCommand { get; }
        public ReactiveCommand WithParameterCommand { get; }
        public ReactiveCommand WithCanExecuteCommand { get; }

        private void Parameterless()
        {
            MessageBox.Show("You pressed the button!", ApplicationTitle, MessageBoxButton.OK);
        }

        private void WithParameter(string message)
        {
            MessageBox.Show(message, ApplicationTitle, MessageBoxButton.OK);
        }

        private void WithCanExecute()
        {
            MessageBox.Show(WithCanExecuteParameter, ApplicationTitle, MessageBoxButton.OK);
        }
    }
}
