using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Data;
using System.Windows.Input;
using WpfApp7.Model;
using WpfApp7.View;
using WpfApp7.ViewModel.Helpers;

namespace WpfApp7.ViewModel
{
    public class MainViewModel : BindingHelper
    {
        #region Переменные
        private AutDan admin = new AutDan();

        private string login_bx;
        private string password_bx;
        public string Login_bx { 
            get
            {
                return login_bx;
            }
            set 
            { 
                login_bx = value;
                OnPropertyChanged();
            } 
        }
        public string Password_bx 
        {
            get
            {
                return password_bx;
            }
            set
            {
                password_bx = value;
                OnPropertyChanged();
            }
        }

        public Action CloseWindow { get; set; }

        #endregion

        #region Команды
        public BindableCommand AutCommand { get; set; }
        #endregion
        public MainViewModel(Window window)
        {
            admin.Login = "admin";
            admin.Password = "admin";

            AutCommand = new BindableCommand(_ => Aut());
            CloseWindow = window.Close;
        }
        public void Aut()
        {
            if (admin.Login == Login_bx && admin.Password == Password_bx)
            {
                ProductsWindow productsWindow = new ProductsWindow();
                productsWindow.Show();
                CloseWindow?.Invoke();
            }
            else
            {
                MessageBox.Show("Неправильно введены данные");
            }
        }

    }
}
