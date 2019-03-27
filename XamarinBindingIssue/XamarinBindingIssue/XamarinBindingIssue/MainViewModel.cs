using System.Collections.Generic;
using System.ComponentModel;
using System.Runtime.CompilerServices;

namespace XamarinBindingIssue
{
    public class MainViewModel : INotifyPropertyChanged
    {
        private string name = "Bill";
        private Dictionary<string, string> errors;

        public MainViewModel()
        {
            errors = new Dictionary<string, string>
            {
                { nameof(Name), "An error" }
            };
        }

        public string Name
        {
            get => name;
            set => SetProperty(ref name, value);
        }

        public Dictionary<string, string> Errors
        {
            get => errors;
            private set => SetProperty(ref errors, value);
        }

        public event PropertyChangedEventHandler PropertyChanged;

        public void ClearErrorForPerson()
        {
            Errors = new Dictionary<string, string>();
        }

        protected bool SetProperty<T>(ref T field, T value, [CallerMemberName] string propertyName = null)
        {
            if (Equals(field, value)) { return false; }

            field = value;
            RaisePropertyChanged(propertyName);
            return true;
        }

        protected void RaisePropertyChanged([CallerMemberName] string propertyName = null)
        {
            OnPropertyChanged(new PropertyChangedEventArgs(propertyName));
        }

        protected virtual void OnPropertyChanged(PropertyChangedEventArgs e)
        {
            PropertyChanged?.Invoke(this, e);
        }
    }
}
