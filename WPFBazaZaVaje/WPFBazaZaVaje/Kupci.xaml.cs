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
using System.Windows.Shapes;

namespace WPFBazaZaVaje
{
    /// <summary>
    /// Interaction logic for Kupci.xaml
    /// </summary>
    public partial class Kupci : Window
    {
        CollectionViewSource cvs;
        public Kupci()
        {
            InitializeComponent();
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            BazaZaVajeEntities c = new BazaZaVajeEntities();
            var x = (from a in c.KUPEC
                    select a).ToList();
            cvs = (CollectionViewSource)FindResource("cvs");
            cvs.Source = x;
        }
    }
}
