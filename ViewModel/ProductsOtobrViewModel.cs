using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using WpfApp7.Model;
using WpfApp7.View;
using WpfApp7.ViewModel.Helpers;

namespace WpfApp7.ViewModel
{
    public class ProductsOtobrViewModel : BindingHelper
    {
        #region Свойства
        private ObservableCollection<Product> products { get; set; }
        public ObservableCollection<Product> Products
        {
            get { return products; }
            set { products = value; OnPropertyChanged(); }
        }
        #endregion

        private string name_one { get; set; }
        private int price_one { get; set; }
        private string name_two { get; set; }
        private int price_two { get; set; }
        private string name_three { get; set; }
        private int price_three { get; set; }

        public ProductsOtobrViewModel(Page Who)
        {
            Products = new ObservableCollection<Product>();

            switch (Who)
            {
                case Milk:
                    name_one = "Домик в деревне";
                    price_one = 90;

                    name_two = "Простоквашино";
                    price_two= 94;

                    name_three = "Бабушкино";
                    price_three = 87;

                    
                    break;
                case Sigaret:
                    name_one = "Чапмэн";
                    price_one = 230;

                    name_two = "Донской табак";
                    price_two = 120;

                    name_three = "Петр Первый";
                    price_three = 100;
                    break;
                case Animal:
                    name_one = "Капибара";
                    price_one = 500000;

                    name_two = "Муравьед";
                    price_two = 400000;

                    name_three = "Кука";
                    price_three = 999999;
                    break;
                default:
                    MessageBox.Show("Данных по продукту нет");
                    break;
            }

            Product one = new Product();
            one.Name = name_one;
            one.Price = price_one;

            Product two = new Product();
            two.Name = name_two;
            two.Price = price_two;

            Product three = new Product();
            three.Name = name_three;
            three.Price = price_three;

            Products.Add(one);
            Products.Add(two);
            Products.Add(three);
        }
    }
}
