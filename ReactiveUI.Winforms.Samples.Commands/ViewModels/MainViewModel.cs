using System.Reactive.Linq;
using System.Threading;
using System.Threading.Tasks;
using System.Windows;

namespace ReactiveUI.Winforms.Samples.Commands.ViewModels
{
    public class MainViewModel : ReactiveObject
    {
        private string _applicationTitle;
        private string _withCanExecuteParameter;

        private ObservableAsPropertyHelper<bool> _isBusy;
        public bool IsBusy => _isBusy.Value;

        public MainViewModel()
        {
            // Set properties
            ApplicationTitle = "ReactiveUI Winforms Samples by Asesjix - Commands";
            // Create parameterless command
            ParameterlessCommand = ReactiveCommand.CreateFromTask(Parameterless);

            // Create command with parameter
            WithParameterCommand = ReactiveCommand.Create<string>(WithParameter);
            // Create command with can execute
            WithCanExecuteCommand = ReactiveCommand.Create(WithCanExecute,
                this.WhenAnyValue(vm => vm.WithCanExecuteParameter).Select(s => string.IsNullOrEmpty(s) == false));

            this.WhenAnyObservable(x => x.ParameterlessCommand.IsExecuting)
                .ToProperty(this, y => y.IsBusy, out _isBusy);
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

        private async Task Parameterless()
        {
            await Task.Run(() =>
            {
                Thread.Sleep(3000);
                MessageBox.Show("You pressed the button!", ApplicationTitle, MessageBoxButton.OK);
            });
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
