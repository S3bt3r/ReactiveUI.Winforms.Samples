using System;

namespace ReactiveUI.Winforms.Samples.Bindings.ViewModels
{
    public class MainViewModel : ReactiveObject
    {
        private string _applicationTitle;
        private string _valueOne;
        private long _valueTwo;

        public MainViewModel()
        {
            // Set properties
            ApplicationTitle = "ReactiveUI Winforms Samples by Asesjix - Bindings";
            ValueOne = "Type somthing";
            ValueTwo = DateTime.Now.Date.ToFileTime();
        }

        public string ApplicationTitle
        {
            get => _applicationTitle;
            set => this.RaiseAndSetIfChanged(ref _applicationTitle, value);
        }

        public string ValueOne
        {
            get => _valueOne;
            set => this.RaiseAndSetIfChanged(ref _valueOne, value);
        }

        public long ValueTwo
        {
            get => _valueTwo;
            set => this.RaiseAndSetIfChanged(ref _valueTwo, value);
        }
    }
}
