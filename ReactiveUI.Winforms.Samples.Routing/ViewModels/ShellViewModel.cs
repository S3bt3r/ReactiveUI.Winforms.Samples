using System;

namespace ReactiveUI.Winforms.Samples.Routing.ViewModels
{
    public class ShellViewModel : ReactiveObject, IScreen
    {
        private string _applicationTitle;

        public ShellViewModel()
        {
            // Create router for IScreen
            Router = new RoutingState();
            // Set properties
            ApplicationTitle = "ReactiveUI Winforms Samples by Asesjix - Routing";
            // Create commands
            ShowHomeCommand = ReactiveCommand.Create(ShowHome);
            ShowReactiveUICommand = ReactiveCommand.Create(ShowReactiveUI);
            GoBackCommand = ReactiveCommand.Create(GoBack);
            // Navigate to HomeViewModel and reset NavigationStack (shows HomeView at application start)
            Router
                .NavigateAndReset
                .Execute(new HomeViewModel())
                .Subscribe();
        }

        public RoutingState Router { get; }

        public string ApplicationTitle
        {
            get => _applicationTitle;
            set => this.RaiseAndSetIfChanged(ref _applicationTitle, value);
        }

        public ReactiveCommand ShowHomeCommand { get; }
        public ReactiveCommand ShowReactiveUICommand { get; }
        public ReactiveCommand GoBackCommand { get; }

        private void ShowHome()
        {
            // Navigate to HomeViewModel 
            Router
                .Navigate
                .Execute(new HomeViewModel())
                .Subscribe();
        }

        private void ShowReactiveUI()
        {
            // Navigate to ReactiveUiViewModel 
            Router
                .Navigate
                .Execute(new ReactiveUiViewModel())
                .Subscribe();
        }

        private void GoBack()
        {
            // Navigate back in NavigationStack 
            Router
                .NavigateBack
                .Execute()
                .Subscribe();
        }
    }
}
