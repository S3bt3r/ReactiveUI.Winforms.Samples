using ReactiveUI.Winforms.Samples.Core.Routing.ViewModels;
using System.Windows.Forms;

namespace ReactiveUI.Winforms.Samples.Core.Routing
{
    public partial class ShellView : Form, IViewFor<ShellViewModel>
    {
        public ShellView()
        {
            InitializeComponent();

            this.WhenActivated(b =>
            {
                // Bind router
                b(this.OneWayBind(ViewModel, vm => vm.Router, v => v.routedControlHost.Router));

                // Bind properties
                b(this.OneWayBind(ViewModel, vm => vm.ApplicationTitle, v => v.Text));

                // Bind commands
                b(this.BindCommand(ViewModel, vm => vm.ShowHomeCommand, v => v.btHome));
                b(this.BindCommand(ViewModel, vm => vm.ShowAboutCommand, v => v.btAbout));
                b(this.BindCommand(ViewModel, vm => vm.ShowContactCommand, v => v.btContact));
                b(this.BindCommand(ViewModel, vm => vm.GoBackCommand, v => v.btGoBack));
            });
        }

        public ShellViewModel ViewModel { get; set; }

        object IViewFor.ViewModel
        {
            get => ViewModel;
            set => ViewModel = (ShellViewModel)value;
        }
    }
}