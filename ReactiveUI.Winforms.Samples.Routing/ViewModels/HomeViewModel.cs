namespace ReactiveUI.Winforms.Samples.Routing.ViewModels
{
    public class HomeViewModel : ReactiveObject, IRoutableViewModel
    {
        public IScreen HostScreen { get; protected set; }
        public string UrlPathSegment { get; protected set; }        
    }
}
