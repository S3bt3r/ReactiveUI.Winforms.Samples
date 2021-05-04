namespace ReactiveUI.Winforms.Samples.Routing.Views {

	using System;
	using System.Windows.Forms;
	using ViewModels;

	public partial class ShellView : Form, IViewFor<ShellViewModel> {

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

		public ShellView() {
			this.InitializeComponent();

			var _ = this.WhenActivated( action => {
				if ( action is null ) {
					return;
				}

				if ( this.ViewModel is null ) {
					return;
				}

				// Bind router
				action( this.OneWayBind( this.ViewModel, vm => vm.Router, v => v.routedControlHost.Router ) );

				// Bind properties
				action( this.OneWayBind( this.ViewModel, vm => vm.ApplicationTitle, v => v.Text ) );

				// Bind commands
				action( this.BindCommand( this.ViewModel, vm => vm.ShowHomeCommand, v => v.btHome ) );
				action( this.BindCommand( this.ViewModel, vm => vm.ShowAboutCommand, v => v.btAbout ) );
				action( this.BindCommand( this.ViewModel, vm => vm.ShowContactCommand, v => v.btContact ) );
				action( this.BindCommand( this.ViewModel, vm => vm.GoBackCommand, v => v.btGoBack ) );
			} );
		}

		public ShellViewModel ViewModel { get; set; }

		Object IViewFor.ViewModel {
			get => this.ViewModel;

			set => this.ViewModel = ( ShellViewModel ) value;
		}

	}

}