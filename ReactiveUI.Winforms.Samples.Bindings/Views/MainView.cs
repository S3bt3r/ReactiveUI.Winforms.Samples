using ReactiveUI.Winforms.Samples.Bindings.ViewModels;
using System.Windows.Forms;

namespace ReactiveUI.Winforms.Samples.Bindings.Views
{
    public partial class MainView : Form, IViewFor<MainViewModel>
    {
        public MainView()
        {
            InitializeComponent();

            this.OneWayBind(ViewModel, vm => vm.ApplicationTitle, v => v.Text);

            ViewModel = new MainViewModel();
        }

        public MainViewModel ViewModel { get; set; }

        object IViewFor.ViewModel
        {
            get => ViewModel;
            set => ViewModel = (MainViewModel)value;
        }
    }
}
