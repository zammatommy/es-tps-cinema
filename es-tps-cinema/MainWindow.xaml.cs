﻿using System;
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
using System.Threading;

namespace es_tps_cinema
{
    /// <summary>
    /// Logica di interazione per MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private bool[] postiCinema = new bool[6];
        static int buffer = 6;
        private static object x = new object();
        
        public MainWindow()
        {
           
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Thread t1 = new Thread(new ThreadStart(CassaNumero1));
            t1.Start();
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            Thread t2 = new Thread(new ThreadStart(CassaNumero2));
            t2.Start();
        }
    }
}
