using ReactiveUI.Winforms.Samples.Routing.ViewModels;
using System.Windows.Forms;

namespace ReactiveUI.Winforms.Samples.Routing.Views
{
    public partial class HomeView : UserControl, IViewFor<HomeViewModel>
    {
        public HomeView()
        {
            InitializeComponent();
        }

        public HomeViewModel ViewModel { get; set; }

        object IViewFor.ViewModel
        {
            get => ViewModel;
            set => ViewModel = (HomeViewModel)value;
        }       
    }
}
