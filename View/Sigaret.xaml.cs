using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using WpfApp7.ViewModel;

namespace WpfApp7.View
{
    /// <summary>
    /// Логика взаимодействия для Sigaret.xaml
    /// </summary>
    public partial class Sigaret : Page
    {
        public Sigaret()
        {
            InitializeComponent();
            DataContext = new ProductsOtobrViewModel(this);
        }
    }
}
