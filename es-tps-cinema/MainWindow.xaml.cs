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
using System.Threading;

namespace es_tps_cinema
{
    /// <summary>
    /// Logica di interazione per MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        Thread t1;
        Thread t2;
        private bool[] postiCinema = new bool[6];
        private object x = new object();
        int posto;

        public MainWindow()
        {
            InitializeComponent();
            // Controllo se i posti sono liberi
            for (int i = 0; i < postiCinema.Length; i++)
            {
                postiCinema[i] = false;
            }
        }

        private void CassaNumero1()
        {

            lock (x)
            {
                if (postiCinema[posto] == false)
                {
                    postiCinema[posto] = true;
                }
                else
                {
                    MessageBox.Show("Il posto è già occupato");
                }
            }
        }

        private void CassaNumero2()
        {

            lock (x)
            {
                if (postiCinema[posto] == false)
                {
                    postiCinema[posto] = true;
                }
                else
                {
                    MessageBox.Show("Il posto è già occupato");
                }
            }
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            posto = 0;

            this.Dispatcher.BeginInvoke(new Action(() =>
            {
                posto = int.Parse(txtPosto.Text) - 1;
            }));

            t1 = new Thread(new ThreadStart(CassaNumero1));
            t1.Start();
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            posto = 0;

            this.Dispatcher.BeginInvoke(new Action(() =>
            {
                posto = int.Parse(txtPosto1.Text) - 1;
            }));

            t2 = new Thread(new ThreadStart(CassaNumero2));
            t2.Start();
        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {

        }
    }
}

