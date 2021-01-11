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
    /// Логика взаимодействия для Page2.xaml
    /// </summary>
    public partial class Page2 : Page
    {
        COMPUTEREntities S = new COMPUTEREntities();
        public Page2()
        {
            InitializeComponent();
        }

        private void back_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.GoBack();
        }

        private void ins_Click(object sender, RoutedEventArgs e)
        {
            MANUFACTURER D = new MANUFACTURER()
            {
                NAME = name.Text,
                ADDRESS = name2.Text,
                SPECIFICATIONSID = Convert.ToInt32(name3.Text),
                CONSIGMENTID = Convert.ToInt32(name4.Text)
            };
            S.MANUFACTURER.Add(D);
            S.SaveChanges();

        }
    }
}
