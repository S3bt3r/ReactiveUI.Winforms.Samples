using ReactiveUI.Winforms.Samples.Routing.ViewModels;
using System.Windows.Forms;

namespace ReactiveUI.Winforms.Samples.Routing.Views
{
    public partial class AboutView : UserControl, IViewFor<AboutViewModel>
    {
        public AboutView()
        {
            InitializeComponent();
        }
        
        public AboutViewModel ViewModel { get; set; }

        object IViewFor.ViewModel
        {
            get => ViewModel;
            set => ViewModel = (AboutViewModel)value;
        }
    }
}
