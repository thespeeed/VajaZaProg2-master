﻿using System;
using System.Collections.Generic;
using System.Data.Entity;
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
    /// Interaction logic for Dobavitelji.xaml
    /// </summary>
    public partial class Dobavitelji : Window
    {
        CollectionViewSource dvs;
        BazaZaVajeEntities c = new BazaZaVajeEntities();
        public Dobavitelji()
        {
            InitializeComponent();
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {

            dvs = ((CollectionViewSource)(this.FindResource("dOBAVITELJViewSource")));
            c.DOBAVITELJ.Load();
            dvs.Source = c.DOBAVITELJ.Local;
            // Load data by setting the CollectionViewSource.Source property:
            // dOBAVITELJViewSource.Source = [generic data source]

        }
    }
}
