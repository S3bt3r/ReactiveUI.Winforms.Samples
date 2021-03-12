namespace ReactiveUI.Winforms.Samples.Bindings.ViewModels
{
	using System;

	public class MainViewModel : ReactiveObject
    {
        private String _applicationTitle;
        private String _valueOne;
        private Int64 _valueTwo;

        public MainViewModel()
        {
            // Set properties
            this.ApplicationTitle = "ReactiveUI Winforms Samples by Asesjix - Bindings";
            this.ValueOne = "Type somthing";
            this.ValueTwo = DateTime.Now.Date.ToFileTime();
        }

        public String ApplicationTitle
        {
            get => this._applicationTitle;
            set => this.RaiseAndSetIfChanged(ref this._applicationTitle, value);
        }

        public String ValueOne
        {
            get => this._valueOne;
            set => this.RaiseAndSetIfChanged(ref this._valueOne, value);
        }

        public Int64 ValueTwo
        {
            get => this._valueTwo;
            set => this.RaiseAndSetIfChanged(ref this._valueTwo, value);
        }
    }
}
