using Dron.Model;
using Dron.Model.Models22;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace Dron.ViewModel
{
    class AddProductsViewModel : NotifyPropertyChanged
    {

        public List<Categories> Categories { get; set; } = DataWorker.SelectAllCategories();

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

        private int? _price;
        public int? Price
        {
            get { return _price; }
            set
            {
                _price = value;
                OnPropertyChanged("Price");
            }
        }

        private int? _categoryId;
        public int? CategoryId
        {
            get { return _categoryId; }
            set
            {
                _categoryId = value;
                OnPropertyChanged("CategoryId");
            }
        }


        private Categories _selectedCategory;
        public Categories SelectedCategory
        {
            get { return _selectedCategory; }
            set
            {
                _selectedCategory = value;
                CategoryId = _selectedCategory.Id;
                OnPropertyChanged("SelectedCategory");
            }
        }

        private RelayCommand _addProduct;
        public RelayCommand AddProduct
        {
            get
            {
                if(_addProduct == null)
                {
                    _addProduct = new RelayCommand((o) =>
                    {
                        if (DataWorker.CreateProducts(Name, CategoryId, Price) == true)
                        {
                            CreatedWindow.CreateMessageBox("Успешно");

                        }
                        else
                        {
                            CreatedWindow.CreateMessageBox("Неудача");
                        }
                    });
                }
                return _addProduct;
            }
        }

    }
}