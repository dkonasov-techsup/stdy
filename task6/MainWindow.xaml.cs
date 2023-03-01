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
/*using System.Threading;*/
using System.Timers;


namespace task6
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>



    public partial class MainWindow : Window
    {
        bool bl;
        Random rnd = new Random();
        Random rnd1 = new Random();
        int x, y, dx, dy;
        private static System.Timers.Timer aTimer;

        public static void Main()
        {

        }

            public void Count(object obj)
        {
            
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {

        }

        public MainWindow()
        {
            InitializeComponent();
        }        
    }
}
