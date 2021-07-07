using ReactiveUI.Winforms.Samples.Core.Routing.ViewModels;
using System.Windows.Forms;

namespace ReactiveUI.Winforms.Samples.Core.Routing.Views
{
    public partial class AboutView : UserControl, IViewFor<AboutViewModel>
    {
        public AboutView()
        {
            InitializeComponent();

            this.WhenActivated(d =>
            {
                d(this.OneWayBind(ViewModel, vm => vm.ViewTitle, v => v.lViewTitle.Text));
            });
        }

        public AboutViewModel ViewModel { get; set; }

        object IViewFor.ViewModel
        {
            get => ViewModel;
            set => ViewModel = (AboutViewModel)value;
        }
    }
}