namespace ReactiveUI.Winforms.Samples.Routing.Views
{
	using ViewModels;
	using System.Windows.Forms;

	using System;

	public partial class ContactView : UserControl, IViewFor<ContactViewModel>
    {
        public ContactView()
        {
	        this.InitializeComponent();

	        var _ = this.WhenActivated(d => d?.Invoke(this.OneWayBind( this.ViewModel, vm => vm.ViewTitle, v => v.lViewTitle.Text)) );
        }

        public ContactViewModel ViewModel { get; set; }

        Object IViewFor.ViewModel
        {
            get => this.ViewModel;
            set => this.ViewModel = (ContactViewModel)value;
        }
    }
}
