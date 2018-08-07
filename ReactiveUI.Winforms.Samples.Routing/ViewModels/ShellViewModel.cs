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
            ShowAboutCommand = ReactiveCommand.Create(ShowAbout);
            ShowContactCommand = ReactiveCommand.Create(ShowContact);
            GoBackCommand = ReactiveCommand.Create(GoBack, Router.NavigateBack.CanExecute);
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
        public ReactiveCommand ShowAboutCommand { get; }
        public ReactiveCommand ShowContactCommand { get; }
        public ReactiveCommand GoBackCommand { get; }

        private void ShowHome()
        {
            // Navigate to HomeViewModel 
            Router
                .Navigate
                .Execute(new HomeViewModel())
                .Subscribe();
        }

        private void ShowAbout()
        {
            // Navigate to AboutViewModel 
            Router
                .Navigate
                .Execute(new AboutViewModel())
                .Subscribe();
        }

        private void ShowContact()
        {
            // Navigate to ContactViewModel 
            Router
                .Navigate
                .Execute(new ContactViewModel())
                .Subscribe();
        }

        private void GoBack()
        {
            // Navigate back in NavigationStack 
            // Note: You have to check the count to prevent an ArgumentOutOfRangeException or navigate to empty
            if (Router.NavigationStack.Count > 0)
            {
                Router
                    .NavigateBack
                    .Execute()
                    .Subscribe();
            }
        }
    }
}
