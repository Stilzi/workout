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

namespace trainer
{
    /// <summary>
    /// Логика взаимодействия для Page1.xaml
    /// </summary>
    public partial class Page1 : Page
    {
        COMPUTEREntities C = new COMPUTEREntities();
        public Page1()
        {
            InitializeComponent();

            datagrid.ItemsSource = C.MANUFACTURER.ToList();
        }
        private void w_Click(object sender, RoutedEventArgs e)
        {
            C.SaveChanges();
        }

        private void q_Click(object sender, RoutedEventArgs e)
        {
            MANUFACTURER K = (MANUFACTURER)datagrid.SelectedItem;
            C.MANUFACTURER.Remove(K);
            C.SaveChanges();
            datagrid.ItemsSource = C.MANUFACTURER.ToList();
        }

        private void e_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new Page2());
        }
    }
}
