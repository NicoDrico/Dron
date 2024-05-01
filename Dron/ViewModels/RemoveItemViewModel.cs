using Dron.Model;
using Dron.Model.Models22;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dron.ViewModel
{
    internal class RemoveItemViewModel : NotifyPropertyChanged
    {
        MainViewModel _mainViewModel;
        public RemoveItemViewModel(string text, List<object> items, MainViewModel mainViewModel)
        {
            _text = text;
            Items = items;
            _mainViewModel = mainViewModel;
        }

        private string _text;
        public string Text
        {
            get { return _text; }
            set
            {
                _text = value;
                OnPropertyChanged("Text");
            }
        }

        private List<object> _items;
        public List<object> Items
        {
            get { return _items; }
            set
            {
                _items = value;
                OnPropertyChanged("Items");
            }
        }

        private object _selectedItem;
        public object SelectedItem
        {
            get { return _selectedItem; }
            set
            {
                _selectedItem = value;
                OnPropertyChanged("SelectedItem");
            }
        }

        private RelayCommand _removeItem;

    }
}
