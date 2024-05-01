using Dron.Model;
using Dron.Model.Models22;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dron.ViewModel.AddViewModel
{
    internal class AddPersonalViewModel : NotifyPropertyChanged
    {
        private MainViewModel _mainViewModel;

        public AddPersonalViewModel(MainViewModel mainViewModel)
        {
            _mainViewModel = mainViewModel;
        }

        private string _firstname;
        public string Firstname
        {
            get { return _firstname; }
            set
            {
                _firstname = value;
                OnPropertyChanged("Firstname");
            }
        }

        private string _name;
        public string Name
        {
            get { return _name; }
            set
            {
                _name = value;
                OnPropertyChanged("Name");
            }
        }

        private string _surname;
        public string Surname
        {
            get { return _surname; }
            set
            {
                _surname = value;
                OnPropertyChanged("Surname");
            }
        }

        //public List<Jobs> Jobs { get; set; } = DataWorker.SelectAllJobs();

        private Jobs _selectedJobs;
        public Jobs SelectedJobs
        {
            get { return _selectedJobs; }
            set
            {
                _selectedJobs = value;
                OnPropertyChanged("SelectedJobs");
            }
        }


        private string _numberTelephone;
        public string NumberTelephone
        {
            get { return _numberTelephone; }
            set
            {
                _numberTelephone = value;
                OnPropertyChanged("NumberTelephone");
            }
        }

        private string _login;
        public string Login
        {
            get { return _login; }
            set
            {
                _login = value;
                OnPropertyChanged("Login");
            }
        }

        private string _password;
        public string Password
        {
            get { return _password; }
            set
            {
                _password = value;
                OnPropertyChanged("Password");
            }
        }

        private RelayCommand _addPersonal;

    }
}