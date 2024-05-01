using Dron.Model;
using Dron.Model.Models22;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dron.ViewModel.EditViewModel
{
    internal class EditJobsViewModel : NotifyPropertyChanged
    {
        private MainViewModel _mainViewModel;

        public EditJobsViewModel(MainViewModel mainViewModel)
        {
            _mainViewModel = mainViewModel;
        }

        /*private List<Jobs> _jobs = DataWorker.SelectAllJobs();
        public List<Jobs> Jobs
        {
            get {  return _jobs; }
            set
            {
                _jobs = value;
                OnPropertyChanged("Jobs");
            }
        }*/

        private Jobs _selectedJobs;


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

        private int _priceInHour;
        public int PriceInHour
        {
            get { return _priceInHour; }
            set
            {
                _priceInHour = value;
                OnPropertyChanged("PriceInHour");
            }
        }

        private bool _editChild;
        public bool EditChild
        {
            get { return _editChild; }
            set
            {
                _editChild = value;
                OnPropertyChanged("EditChild");
            }
        }

        private bool _editPersonal;
        public bool EditPersonal
        {
            get { return _editPersonal; }
            set
            {
                _editPersonal = value;
                OnPropertyChanged("EditPersonal");
            }
        }

        private bool _editAccommodation;
        public bool EditAccommodation
        {
            get { return _editAccommodation; }
            set
            {
                _editAccommodation = value;
                OnPropertyChanged("EditAccommodation");
            }
        }

        private bool _editDesease;
        public bool EditDesease
        {
            get { return _editDesease; }
            set
            {
                _editDesease = value;
                OnPropertyChanged("EditDesease");
            }
        }

        private bool _editEvent;
        public bool EditEvent
        {
            get { return _editEvent; }
            set
            {
                _editEvent = value;
                OnPropertyChanged("EditEvent");
            }
        }

        private bool _editFinance;
        public bool EditFinance
        {
            get { return _editFinance; }
            set
            {
                _editFinance = value;
                OnPropertyChanged("EditFinance");
            }
        }

        private RelayCommand _editJobs;

    }
}