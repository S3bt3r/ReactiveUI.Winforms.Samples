using ReactiveUI.Winforms.Samples.Routing.ViewModels;
using System.Windows.Forms;

namespace ReactiveUI.Winforms.Samples.Routing.Views
{
    public partial class ReactiveUiView : UserControl, IViewFor<ReactiveUiViewModel>
    {
        public ReactiveUiView()
        {
            InitializeComponent();
        }
        
        public ReactiveUiViewModel ViewModel { get; set; }

        object IViewFor.ViewModel
        {
            get => ViewModel;
            set => ViewModel = (ReactiveUiViewModel)value;
        }
    }
}
