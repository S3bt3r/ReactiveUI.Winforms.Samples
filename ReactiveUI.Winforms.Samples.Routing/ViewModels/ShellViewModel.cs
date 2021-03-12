namespace ReactiveUI.Winforms.Samples.Routing.ViewModels
{
	using System;
	using System.Reactive;

	public class ShellViewModel : ReactiveObject, IScreen
    {
        private String _applicationTitle;

        public ShellViewModel()
        {
            // Create router for IScreen
            this.Router = new RoutingState();
            // Set properties
            this.ApplicationTitle = "ReactiveUI Winforms Samples by Asesjix - Routing";
            // Create commands
            this.ShowHomeCommand = ReactiveCommand.Create( this.ShowHome);
            this.ShowAboutCommand = ReactiveCommand.Create( this.ShowAbout);
            this.ShowContactCommand = ReactiveCommand.Create( this.ShowContact);
            this.GoBackCommand = ReactiveCommand.Create( this.GoBack, this.Router.NavigateBack.CanExecute);
            // Navigate to HomeViewModel and reset NavigationStack (shows HomeView at application start)
            var _ = this.Router
                .NavigateAndReset
                .Execute(new HomeViewModel())
                .Subscribe();
        }

        public RoutingState Router { get; }

        public String ApplicationTitle
        {
            get => this._applicationTitle;
            set => this.RaiseAndSetIfChanged(ref this._applicationTitle, value);
        }

        public ReactiveCommand<Unit, Unit> ShowHomeCommand { get; }
        public ReactiveCommand<Unit, Unit> ShowAboutCommand { get; }
        public ReactiveCommand<Unit, Unit> ShowContactCommand { get; }
        public ReactiveCommand<Unit, Unit> GoBackCommand { get; }

        private void ShowHome()
        {
            // Navigate to HomeViewModel 
            var _ = this.Router
                .Navigate
                .Execute(new HomeViewModel())
                .Subscribe();
        }

        private void ShowAbout()
        {
            // Navigate to AboutViewModel 
            var _ = this.Router
                        .Navigate
                        .Execute(new AboutViewModel())
                        .Subscribe();
        }

        private void ShowContact()
        {
            // Navigate to ContactViewModel 
            var _ =   this.Router
                          .Navigate
                          .Execute(new ContactViewModel())
                          .Subscribe();
        }

        private void GoBack()
        {
            // Navigate back in NavigationStack 
            // Note: You have to check the count to prevent an ArgumentOutOfRangeException or navigate to empty
            if ( this.Router.NavigationStack.Count > 0)
            {
	            var _ =         this.Router
	                                .NavigateBack
	                                .Execute()
	                                .Subscribe();
            }
        }
    }
}
