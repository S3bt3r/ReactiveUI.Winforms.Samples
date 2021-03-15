namespace ReactiveUI.Winforms.Samples.Routing.ViewModels {

	using System;

	public class ContactViewModel : ReactiveObject, IRoutableViewModel {

		private String _viewTitle;

		public ContactViewModel() => this.ViewTitle = "Contact View";

		public String ViewTitle {
			get => this._viewTitle;

			set => this.RaiseAndSetIfChanged( ref this._viewTitle, value );
		}

		public IScreen HostScreen { get; protected set; }

		public String UrlPathSegment { get; protected set; }

	}

}