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

namespace task9
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public class Data
    {
        public double Vel { get; set; }
        public double Dist { get; set; } 
    }

    public partial class MainWindow : Window
    {
        Data Data1;
        public MainWindow()
        {
            InitializeComponent();
            Data1 = new Data();
            this.DataContext = Data1;
        }

        private void validationError(object sender, ValidationErrorEventArgs e)
        {
            if (e.Action == ValidationErrorEventAction.Added)
            {
                /* MessageBox.Show(e.Error.ErrorContent.ToString());*/
                getTime.IsEnabled = false;
            }
            else
            {               
                getTime.IsEnabled = true;
            }
        }

        private void getTask_Click(object sender, RoutedEventArgs e)
        {
            Task taskInfo = new Task();
            taskInfo.ShowDialog();
        }

        private void getInfo_Click(object sender, RoutedEventArgs e)
        {
            Info formInfo = new Info();
            formInfo.ShowDialog();
        }

        private void getTime_Click(object sender, RoutedEventArgs e)
        {
            double V = double.Parse(Vel.Text);
            double S = double.Parse(Dist.Text);
            double T = S / V;
            MessageBox.Show(T.ToString());
        }
    }
}
