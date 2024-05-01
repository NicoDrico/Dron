using Dron.Model;
using Dron.Model.Models22;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dron.ViewModel
{
    internal class LoginViewModel
    {
        public string Login { get; set; }

        public string Password { get; set; }

        public delegate void CloseWindow();
        public CloseWindow Close { get; set; }

        private RelayCommand _loginCommand;


    }
}