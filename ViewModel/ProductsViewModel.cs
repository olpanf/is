using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using WpfApp7.View;
using WpfApp7.ViewModel.Helpers;

namespace WpfApp7.ViewModel
{
    public class ProductsViewModel : BindingHelper
    {
        #region Переменные
        private Page workPage { get; set; }
        public Page WorkPage { get { return workPage; } set { workPage = value; OnPropertyChanged(); } }
        #endregion

        #region Команды
        public BindableCommand OpenMilkPage { get; set; }
        public BindableCommand OpenSigaretPage { get; set; }
        public BindableCommand OpenAnimalPage { get; set; }

        #endregion

        public ProductsViewModel()
        {
            WorkPage = new Milk();

            OpenMilkPage = new BindableCommand(_ => OpenMilk());
            OpenSigaretPage = new BindableCommand(_ => OpenSigaret());
            OpenAnimalPage = new BindableCommand(_ => OpenAnimal());
        }

        public void OpenMilk()
        {
            WorkPage = new Milk();
        }

        public void OpenSigaret()
        {
            MessageBoxResult result = MessageBox.Show("Тебе есть 18?", "Подтверждение", MessageBoxButton.YesNo);

            if (result == MessageBoxResult.Yes)
            {
                WorkPage = new Sigaret();
            }
            else
            {
                MessageBox.Show("Ты что? Мой парень? Сиди тут Саша, тебе туда нельзя");
            }
        }

        public void OpenAnimal()
        {
            WorkPage = new Animal();
        }
    }
}
