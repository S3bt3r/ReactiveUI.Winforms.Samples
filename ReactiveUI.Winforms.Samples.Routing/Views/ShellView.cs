using ReactiveUI.Winforms.Samples.Routing.ViewModels;
using System.Windows.Forms;

namespace ReactiveUI.Winforms.Samples.Routing.Views
{
    public partial class ShellView : Form, IViewFor<ShellViewModel>
    {
        /*
         * To see the RoutedControlHost in the Designer you have to create it manually in the ShellView.Designer.cs
         * 
         * private void InitializeComponent()
         * {
         *      this.routedControlHost = new ReactiveUI.Winforms.RoutedControlHost();
         *      ...
         *      // 
         *      // routedControlHost
         *      // 
         *      this.routedControlHost.DefaultContent = null;
         *      this.routedControlHost.Location = new System.Drawing.Point(3, 55);
         *      this.routedControlHost.Name = "routedControlHost";
         *      this.routedControlHost.Router = null;
         *      this.routedControlHost.Size = new System.Drawing.Size(794, 392);
         *      this.routedControlHost.TabIndex = 4;
         *      this.routedControlHost.ViewLocator = null;
         *      ...
         *      // 
         *      // ShellView
         *      //
         *      ...
         *      this.Controls.Add(this.routedControlHost);
         * }
         * 
         * private RoutedControlHost routedControlHost;
         * 
         */

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
