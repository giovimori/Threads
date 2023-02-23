using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
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

namespace morelli.giovanni._4h.threads
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window

    {
        int _count = 0;
        const int N_Giri = 1000;

        public MainWindow()
        {
            InitializeComponent();
        }

        private void bntGo_Click(object sender, RoutedEventArgs e)
        {
            Thread t = new Thread(Incrementa);
            t.Start();
        }

        void Incrementa()
        {
            for(int x=0; x < N_Giri; x++)
            {
                _count++;
                Dispatcher.Invoke(
                    () =>
                    {
                       txtCounter1.Text = _count.ToString();
                    }

                );
                Thread.Sleep(100);
            }
        }
    }
}
