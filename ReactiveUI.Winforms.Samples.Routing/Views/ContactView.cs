using ReactiveUI.Winforms.Samples.Routing.ViewModels;
using System.Windows.Forms;

namespace ReactiveUI.Winforms.Samples.Routing.Views
{
    public partial class ContactView : UserControl, IViewFor<ContactViewModel>
    {
        public ContactView()
        {
            InitializeComponent();

            this.WhenActivated(d =>
            {
                d(this.OneWayBind(ViewModel, vm => vm.ViewTitle, v => v.lViewTitle.Text));
            });
        }

        public ContactViewModel ViewModel { get; set; }

        object IViewFor.ViewModel
        {
            get => ViewModel;
            set => ViewModel = (ContactViewModel)value;
        }
    }
}
