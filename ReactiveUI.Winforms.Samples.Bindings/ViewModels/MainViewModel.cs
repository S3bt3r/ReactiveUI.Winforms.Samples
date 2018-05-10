namespace ReactiveUI.Winforms.Samples.Bindings.ViewModels
{
    public class MainViewModel : ReactiveObject
    {
        private string _applicationTitle;

        public MainViewModel()
        {
            // Set properties
            ApplicationTitle = "ReactiveUI Winforms Samples by Asesjix - Bindings";
        }

        public string ApplicationTitle
        {
            get => _applicationTitle;
            set => this.RaiseAndSetIfChanged(ref _applicationTitle, value);
        }
    }
}
