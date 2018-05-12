using ReactiveUI.Winforms.Samples.Bindings.ViewModels;
using System;
using System.Windows.Forms;

namespace ReactiveUI.Winforms.Samples.Bindings.Views
{
    public partial class MainView : Form, IViewFor<MainViewModel>
    {
        public MainView()
        {
            InitializeComponent();

            this.WhenActivated(d =>
            {
                // One way bind from viewmodel to view
                d(this.OneWayBind(ViewModel, vm => vm.ApplicationTitle, v => v.Text));

                // Two way bind for input (textbox) and one way bind for output (label)
                d(this.Bind(ViewModel, vm => vm.ValueOne, v => v.tbInputOne.Text));
                d(this.OneWayBind(ViewModel, vm => vm.ValueOne, v => v.lOutputOne.Text));

                // Two way bind for input (textbox) with convert and one way bind for output (label)
                d(this.Bind(ViewModel, vm => vm.ValueTwo, v => v.dtpInputTwo.Value, t => DateTime.FromFileTime(t), dt => dt.ToFileTime()));
                d(this.OneWayBind(ViewModel, vm => vm.ValueTwo, v => v.lOutputTwo.Text));
            });

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
