using System;
using Dron.ViewModel;
using Dron.View;
using System.Windows;
using Dron.View.AddItem;
using Dron.ViewModel.EditViewModel;
using Dron.View.EditItem;
using Dron.ViewModel.AddViewModel;

namespace Dron.Model
{
    internal static class CreatedWindow
    {
        public static void CreateMessageBox(string message)
        {
            MessageBox.Show(message);
        }

        public static void CreateWinow(object dataContext)
        {
            if (dataContext is AddProductsViewModel addProductsView)
            {
                AddProducts addProducts = new AddProducts();
                addProducts.DataContext = addProductsView;
                SettingWindow(addProducts);
            }
            else if (dataContext is EditProductsViewModel editProducts)
            {
                EditProducts edit = new EditProducts();
                edit.DataContext = editProducts;
                SettingWindow(edit);
            }
            /* else if (dataContext is AddGroupViewModel addGroupViewModel)
             {
                 AddGroup addGroup = new AddGroup();
                 addGroup.DataContext = addGroupViewModel;
                 SettingWindow(addGroup);
             }
             else if (dataContext is EditGroupViewModel editGroupViewModel)
             {
                 EditGroup editGroup = new EditGroup();
                 editGroup.DataContext = editGroupViewModel;
                 SettingWindow(editGroup);
             }

             else if(dataContext is AddOperatingScheduleViewModel addOperatingSchedule)
             {
                 AddOperatingSchedule addOperatingSchedule1 = new AddOperatingSchedule();
                 addOperatingSchedule1.DataContext = addOperatingSchedule;
                 SettingWindow(addOperatingSchedule1);
             }
             else if(dataContext is EditOperatingScheduleViewModel editOperatingScheduleViewModel)
             {
                 EditOperatingSchedule editOperatingSchedule = new EditOperatingSchedule();
                 editOperatingSchedule.DataContext = editOperatingScheduleViewModel;
                 SettingWindow(editOperatingSchedule);
             }*/
           /* else if (dataContext is AddProductsViewModel addProductsViewModel)
            {
                AddProducts addProducts = new AddProducts();
                addProducts.DataContext = addProductsViewModel;
                SettingWindow(addProducts);
            }
            else if (dataContext is EditProductsViewModel editJobTiViewModel)
            {
                EditProducts editJobtitle = new EditProducts();
                editJobtitle.DataContext = editJobTitleViewModel;
                SettingWindow(editJobtitle);
            }
            else if (dataContext is AddPersonalViewModel addPersonalViewModel)
            {
                AddPersonal addPersonal = new AddPersonal();
                addPersonal.DataContext = addPersonalViewModel;
                SettingWindow(addPersonal);
            }
            else if (dataContext is EditPersonalViewModel editPersonalViewModel)
            {
                EditPersonal editPersonal = new EditPersonal();
                editPersonal.DataContext = editPersonalViewModel;
                SettingWindow(editPersonal);
            }*/


            else if (dataContext is RemoveItemViewModel remove)
            {
                RemoveItem removeItem = new RemoveItem();
                removeItem.DataContext = remove;
                SettingWindow(removeItem);
            }
        }

        public static void CreateMainWindow(MainViewModel mainViewModel)
        {
            MainWindow mainWindow = new MainWindow();
            mainWindow.DataContext = mainViewModel;
            mainWindow.Visibility = Visibility.Visible;
            Application.Current.MainWindow = mainWindow;
        }

        private static void SettingWindow(Window window)
        {
            window.Owner = Application.Current.MainWindow;
            window.Visibility = Visibility.Visible;
            window.ShowDialog();
        }
    }
}