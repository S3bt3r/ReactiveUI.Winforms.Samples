namespace ReactiveUI.Winforms.Samples.Routing.ViewModels
{
    public class ContactViewModel : ReactiveObject, IRoutableViewModel
    {
        private string _viewTitle;

        public ContactViewModel()
        {
            ViewTitle = "Contact View";
        }

        public string ViewTitle
        {
            get => _viewTitle;
            set => this.RaiseAndSetIfChanged(ref _viewTitle, value);
        }

        public IScreen HostScreen { get; protected set; }
        public string UrlPathSegment { get; protected set; }        
    }
}
