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
        private const int B = 0;
        Thread t1;
        Thread t2;
        bool[] postiCinema = new bool[6];
        object x = new object();
        int posto;
        Brush colore = Brushes.Red;
        Brush colore1 = Brushes.Transparent;

        public MainWindow()
        {
            InitializeComponent();
            SvuotaCinema();
        }

        public void CassaNumero1()
        {
            lock (x)
            {
                if (postiCinema[posto] == false)
                {

                    postiCinema[posto] = true;

                    if (posto == 0)
                    {

                        this.Dispatcher.BeginInvoke(new Action(() =>
                        {
                            lblPosto1.Background = colore;
                        }));

                    }
                    else if (posto == 1)
                    {
                        this.Dispatcher.BeginInvoke(new Action(() =>
                        {
                            lblPosto2.Background = colore;
                        }));
                    }
                    else if (posto == 2)
                    {
                        this.Dispatcher.BeginInvoke(new Action(() =>
                        {
                            lblPosto3.Background = colore;
                        }));
                    }
                    else if (posto == 3)
                    {
                        this.Dispatcher.BeginInvoke(new Action(() =>
                        {
                            lblPosto4.Background = colore;
                        }));
                    }
                    else if (posto == 4)
                    {
                        this.Dispatcher.BeginInvoke(new Action(() =>
                        {
                            lblPosto5.Background = colore;
                        }));
                    }
                    else if (posto == 5)
                    {
                        this.Dispatcher.BeginInvoke(new Action(() =>
                        {
                            lblPosto6.Background = colore;
                        }));
                    }
                }
                else
                {
                    MessageBox.Show("Il posto è già occupato");
                }
            }

        }

        public  void CassaNumero2()
        {

            lock (x)
            {
                if (postiCinema[posto] == false)
                {

                    postiCinema[posto] = true;

                    if (posto == 0)
                    {

                        this.Dispatcher.BeginInvoke(new Action(() =>
                        {
                            lblPosto1.Background = colore;
                        }));

                    }
                    else if (posto == 1)
                    {
                        this.Dispatcher.BeginInvoke(new Action(() =>
                        {
                            lblPosto2.Background = colore;
                        }));
                    }
                    else if (posto == 2)
                    {
                        this.Dispatcher.BeginInvoke(new Action(() =>
                        {
                            lblPosto3.Background = colore;
                        }));
                    }
                    else if (posto == 3)
                    {
                        this.Dispatcher.BeginInvoke(new Action(() =>
                        {
                            lblPosto4.Background = colore;
                        }));
                    }
                    else if (posto == 4)
                    {
                        this.Dispatcher.BeginInvoke(new Action(() =>
                        {
                            lblPosto5.Background = colore;
                        }));
                    }
                    else if (posto == 5)
                    {
                        this.Dispatcher.BeginInvoke(new Action(() =>
                        {
                            lblPosto6.Background = colore;
                        }));
                    }
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
                posto = int.Parse(txtPosto1.Text) - 1;
            }));

            t1 = new Thread(new ThreadStart(CassaNumero2));
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


        public void SvuotaCinema()
        {
            for (int i = 0; i < postiCinema.Length; i++)
            {
                postiCinema[i] = false;
            }

            lblPosto1.Background = colore1;
            lblPosto2.Background = colore1;
            lblPosto3.Background = colore1;
            lblPosto4.Background = colore1;
            lblPosto5.Background = colore1;
            lblPosto6.Background = colore1;
        }

        private void Button_Click_2(object sender, RoutedEventArgs e) //Svuota il cinema
        {
            SvuotaCinema();
        }

        
    }
}

