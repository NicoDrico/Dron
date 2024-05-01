using Dron.Model;
using Dron.Model.Models22;
using Dron.ViewModel.AddViewModel;
using Dron.ViewModel.EditViewModel;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;

namespace Dron.ViewModel
{
    internal class MainViewModel : NotifyPropertyChanged
    {

        #region Child
        private List<ProductsTable> _products = DataWorker.SelectAllProductsTable();
        public List<ProductsTable> Products
        {
            get { return _products; }
            set
            {
                _products = value;
                OnPropertyChanged("Products");
            }
        }

        public string _searchProductsText = "";
        public string SearchProductsText
        {
            get { return _searchProductsText; }
            set
            {
                _searchProductsText = value.Replace(" ", string.Empty);
                OnPropertyChanged("SearchProductsText");
            }
        }

        private RelayCommand _searchProductsCommand;
        public RelayCommand SearchProductsCommand
        {
            get
            {
                if (_searchProductsCommand == null)
                {
                    _searchProductsCommand = new RelayCommand((o) =>
                    {
                        if (SearchProductsText != string.Empty)
                            Products = DataWorker.SelectAllProductsTable().Where(c => $"{c.Name}{c.CategoryId}{c.Price}".ToLower().Contains(SearchProductsText.ToLower())).ToList();
                        else
                            Products = DataWorker.SelectAllProductsTable();
                    });
                }
                return _searchProductsCommand;
            }
        }

        private RelayCommand _openAddProducts;
        public RelayCommand OpenAddProducts
        {
            get
            {
                if (_openAddProducts == null)
                {
                    _openAddProducts = new RelayCommand((o) =>
                    {

                        AddProductsViewModel addProductViewModel = new AddProductsViewModel();
                        CreatedWindow.CreateWinow(addProductViewModel);

                    });
                }
                return _openAddProducts;
            }
        }

        private RelayCommand _openEditProducts;
        public RelayCommand OpenEditProducts
        {
            get
            {
                if (_openEditProducts == null)
                {

                    _openEditProducts = new RelayCommand((o) =>
                    {
                        EditProductsViewModel editProductsViewModel = new EditProductsViewModel();
                        CreatedWindow.CreateWinow(editProductsViewModel);
                    });

                }
                return _openEditProducts;
            }
        }

        private RelayCommand _openAddProductsWindow;

        private RelayCommand _openRemoveChildWindow;
        public RelayCommand OpenRemoveProducts
        {
            get
            {
                if (_openRemoveChildWindow == null)
                {
                    _openRemoveChildWindow = new RelayCommand((o) =>
                    {
                        string text = "Выберете товар";
                        List<object> list = DataWorker.SelectAllProducts().Select(x => (object)x).ToList();
                        RemoveItemViewModel removeItemViewModel = new RemoveItemViewModel(text, list, this);
                        CreatedWindow.CreateWinow(removeItemViewModel);
                    });
                }
                return _openRemoveChildWindow;
            }
        }
        #endregion

        /* #region Personal
         private List<PersonalTable> _personalTables = DataWorker.SelectAllPersonalTable();
         public List<PersonalTable> PersonalTables
         {
             get { return _personalTables; }
             set
             {
                 _personalTables = value;
                 OnPropertyChanged("PersonalTables");
             }
         }

         private string _searchPersonalText = "";
         public string SearchPersonalText
         {
             get { return _searchPersonalText; }
             set
             {
                 _searchPersonalText = value.Replace(" ", string.Empty);
                 OnPropertyChanged("SearchPersonalText");
             }
         }

         private RelayCommand _searchPersonalCommand;
         public RelayCommand SearchPersonalCommand
         {
             get
             {
                 if (_searchPersonalCommand == null)
                 {
                     _searchPersonalCommand = new RelayCommand((o) =>
                     {
                         if (!string.IsNullOrEmpty(SearchPersonalText))
                             PersonalTables = DataWorker.SelectAllPersonalTable().Where(c => $"{c.Firstname}{c.Name}{c.Surname}{c.NameJobTitle}{c.NameOperatingSchedule}{c.NumberOfTelephone}".ToLower().Contains(SearchPersonalText.ToLower())).ToList();
                         else
                             PersonalTables = DataWorker.SelectAllPersonalTable();
                     });
                 }
                 return _searchPersonalCommand;
             }
         }

         private RelayCommand _openAddPersonalWindow;
         public RelayCommand OpenAddPersonalWindow
         {
             get
             {
                 if (_openAddPersonalWindow == null)
                 {
                     _openAddPersonalWindow = new RelayCommand((o) =>
                     {
                         if (JobTitle.EditPersonal)
                         {
                             AddPersonalViewModel addPersonalViewModel = new AddPersonalViewModel(this);
                             CreatedWindow.CreateWinow(addPersonalViewModel);
                         }
                         else
                             CreatedWindow.CreateMessageBox("У вас нет доступа");
                     });
                 }
                 return _openAddPersonalWindow;
             }
         }

         private RelayCommand _openEditPersonalWindow;
         public RelayCommand OpenEditPersonalWindow
         {
             get
             {
                 if (_openEditPersonalWindow == null)
                 {
                     _openEditPersonalWindow = new RelayCommand((o) =>
                     {
                         if (JobTitle.EditPersonal)
                         {
                             EditPersonalViewModel editPersonalViewModel = new EditPersonalViewModel(this);
                             CreatedWindow.CreateWinow(editPersonalViewModel);
                         }
                         else
                             CreatedWindow.CreateMessageBox("У вас нет доступа");
                     });
                 }
                 return _openEditPersonalWindow;
             }
         }

         private RelayCommand _openDeletePersonalWindow;
         public RelayCommand OpenDeletePersonalWindow
         {
             get
             {
                 if (_openDeletePersonalWindow == null)
                 {
                     _openDeletePersonalWindow = new RelayCommand((o) =>
                     {
                         if (JobTitle.EditPersonal)
                         {
                             string text = "Выберете сотрудника";
                             List<object> personals = DataWorker.SelectAllPersonal().Select(x => (object)x).ToList();
                             RemoveItemViewModel removeItemViewModel = new RemoveItemViewModel(text, personals, this);
                             CreatedWindow.CreateWinow(removeItemViewModel);
                         }
                         else
                             CreatedWindow.CreateMessageBox("У вас нет доступа");
                     });
                 }
                 return _openDeletePersonalWindow;
             }
         }

         private RelayCommand _openAddOperatingScheduleWindow;
         public RelayCommand OpenAddOperatingScheduleWindow
         {
             get
             {
                 if (_openAddOperatingScheduleWindow == null)
                 {
                     _openAddOperatingScheduleWindow = new RelayCommand((o) =>
                     {
                         if (JobTitle.EditPersonal)
                         {
                             AddOperatingScheduleViewModel addOperatingScheduleViewModel = new AddOperatingScheduleViewModel();
                             CreatedWindow.CreateWinow(addOperatingScheduleViewModel);
                         }
                         else
                             CreatedWindow.CreateMessageBox("У вас нет доступа");

                     });
                 }
                 return _openAddOperatingScheduleWindow;
             }
         }

         private RelayCommand _openEditOperatingScheduleWindow;
         public RelayCommand OpenEditOperatingScheduleWindow
         {
             get
             {
                 if (_openEditOperatingScheduleWindow == null)
                 {
                     _openEditOperatingScheduleWindow = new RelayCommand((o) =>
                     {
                         if (JobTitle.EditPersonal)
                         {
                             EditOperatingScheduleViewModel editOperatingScheduleViewModel = new EditOperatingScheduleViewModel(this);
                             CreatedWindow.CreateWinow(editOperatingScheduleViewModel);
                         }
                         else
                             CreatedWindow.CreateMessageBox("У вас нет доступа");
                     });
                 }
                 return _openEditOperatingScheduleWindow;
             }
         }

         private RelayCommand _openDeleteOperatingSchedulelWindow;
         public RelayCommand OpenDeleteOperatingSchedulelWindow
         {
             get
             {
                 if (_openDeleteOperatingSchedulelWindow == null)
                 {
                     _openDeleteOperatingSchedulelWindow = new RelayCommand((o) =>
                     {
                         if (JobTitle.EditPersonal)
                         {
                             string text = "Выберете график";
                             List<object> list = DataWorker.SelectAllOperatingSchedule().Select(x => (object)x).ToList();
                             RemoveItemViewModel removeItemViewModel = new RemoveItemViewModel(text, list, this);
                             CreatedWindow.CreateWinow(removeItemViewModel);
                         }
                         else
                             CreatedWindow.CreateMessageBox("У вас нет доступа");
                     });
                 }
                 return _openDeleteOperatingSchedulelWindow;
             }
         }

         private RelayCommand _openAddJobTitleWindow;
         public RelayCommand OpenAddJobTitleWindow
         {
             get
             {
                 if (_openAddJobTitleWindow == null)
                 {
                     _openAddJobTitleWindow = new RelayCommand((o) =>
                     {
                         if (JobTitle.EditPersonal)
                         {
                             AddJobsViewModel addJobTitleViewModel = new AddJobsViewModel();
                             CreatedWindow.CreateWinow(addJobTitleViewModel);
                         }
                         else
                             CreatedWindow.CreateMessageBox("У вас нет доступа");
                     });
                 }
                 return _openAddJobTitleWindow;
             }
         }

         private RelayCommand _openEditJobTitleWindow;
         public RelayCommand OpenEditJobTitleWindow
         {
             get
             {
                 if (_openEditJobTitleWindow == null)
                 {
                     _openEditJobTitleWindow = new RelayCommand((o) =>
                     {
                         if (JobTitle.EditPersonal)
                         {
                             EditJobsViewModel editJobTitleViewModel = new EditJobsViewModel(this);
                             CreatedWindow.CreateWinow(editJobTitleViewModel);
                         }
                         else
                             CreatedWindow.CreateMessageBox("У вас нет доступа");
                     });
                 }
                 return _openEditJobTitleWindow;
             }
         }

         private RelayCommand _openDeleteJobTitlelWindow;
         public RelayCommand OpenDeleteJobTitlelWindow
         {
             get
             {
                 if (_openDeleteJobTitlelWindow == null)
                 {
                     _openDeleteJobTitlelWindow = new RelayCommand((o) =>
                     {
                         if (JobTitle.EditPersonal)
                         {
                             string text = "Выберете должность";
                             List<object> list = DataWorker.SelectAllJobTitle().Select(x => (object)x).ToList();
                             RemoveItemViewModel removeItemViewModel = new RemoveItemViewModel(text, list, this);
                             CreatedWindow.CreateWinow(removeItemViewModel);
                         }
                         else
                             CreatedWindow.CreateMessageBox("У вас нет доступа");
                     });
                 }
                 return _openDeleteJobTitlelWindow;
             }
         }
         #endregion*/
    }
}