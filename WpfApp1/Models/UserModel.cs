using System.ComponentModel;

namespace WpfApp1.Models
{
    public class UserModel : INotifyPropertyChanged
    {
        private int _id;
        private string _name;
        private string _surnames;
        private string _email;
        private string _password;

        public UserModel()
        {
            _name = string.Empty;
            _surnames = string.Empty;
            _email = string.Empty;
            _password = string.Empty;
        }

        public string Name
        {
            get => _name;
            set
            {
                if (_name != value)
                {
                    _name = value;
                    OnPropertyChanged(nameof(Name));
                }
            }
        }

        public string Surnames
        {
            get => _surnames;
            set
            {
                if (_surnames != value)
                {
                    _surnames = value;
                    OnPropertyChanged(nameof(Surnames));
                }
            }
        }

        public string Email
        {
            get => _email;
            set
            {
                if (_email != value)
                {
                    _email = value;
                    OnPropertyChanged(nameof(Email));
                }
            }
        }

        public string Password
        {
            get => _password;
            set
            {
                if (_password != value)
                {
                    _password = value;
                    OnPropertyChanged(nameof(Password));
                }
            }
        }

        public int Id
        {
            get => _id;
            set
            {
                if (_id != value)
                {
                    _id = value;
                    OnPropertyChanged(nameof(Id));
                }
            }
        }

        public event PropertyChangedEventHandler? PropertyChanged;

        protected virtual void OnPropertyChanged(string propertyName)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}
