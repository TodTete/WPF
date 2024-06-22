using System.Collections.ObjectModel;
using System.Windows.Input;
using WpfApp1.Commands;
using WpfApp1.db;
using WpfApp1.Models;
using WpfApp1.ViewsModels;

namespace WpfApp1.ViewModels
{
    internal class UserViewModel : ViewModelBase
    {
        private readonly BD _bd;
        private ObservableCollection<UserModel> _users;
        private UserModel _user;

        public UserViewModel()
        {
            _bd = new BD();
            _user = new UserModel();
            _users = _bd.Get();
            AddCommand = new RelayCommand(ExecuteAdd, AddCanExecute);
        }

        public UserModel User
        {
            get => _user;
            set
            {
                if (_user != value)
                {
                    _user = value;
                    OnPropertyChanged(nameof(User));
                }
            }
        }

        public ObservableCollection<UserModel> Users
        {
            get => _users;
            set
            {
                if (_users != value)
                {
                    _users = value;
                    OnPropertyChanged(nameof(Users));
                }
            }
        }

        public ICommand AddCommand { get; }

        private void ExecuteAdd(object? parameter)
        {
            _bd.Add(User);
            Users = new ObservableCollection<UserModel>(_bd.Get());
        }

        private bool AddCanExecute(object? user)
        {
            return true;
        }
    }
}
