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


namespace task11
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            FontList.ItemsSource = Fonts.SystemFontFamilies.OrderBy(f => f.Source);
            FontList.SelectedIndex = 0;
            FontSizeList.ItemsSource = new List<double>() { 8, 9, 10, 11, 12, 14, 16, 18, 20, 22, 24, 26, 28, 36, 48, 72 };
            FontSizeList.SelectedIndex = 5;

        }


        private void FontList_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (FontList.SelectedItem != null)
            {
                TextArea.Selection.ApplyPropertyValue(Inline.FontFamilyProperty, FontList.SelectedItem);
            }
        }
        private void FontSizeList_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if(FontSizeList.SelectedItem is double number)
            {
                TextArea.Selection.ApplyPropertyValue(TextElement.FontSizeProperty, number);
            }
        }

        private void TextArea_SelectionChanged(object sender, RoutedEventArgs e)
        {

        }
    }
}
