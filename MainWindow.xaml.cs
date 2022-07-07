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

namespace Knowtes.Frontend.Desktop
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            if (Properties.Settings.Default.Appearance == 0)
            {
                Background = new SolidColorBrush(Color.FromRgb(255, 255, 255));
                MessageBox.Show("Appearance is light");
            }
            else
            {
                Background = new SolidColorBrush(Color.FromRgb(100, 100, 100));
                MessageBox.Show("Appearance is dark");
            }
        }

        private void Apply_Click(object sender, RoutedEventArgs e)
        {
            if ((bool)Dark.IsChecked)
            {
                Properties.Settings.Default.Appearance = 1;
            }
            else if ((bool)Light.IsChecked)
            {
                Properties.Settings.Default.Appearance = 0;
            }

            MessageBox.Show("Перезапустите приложение для применения настроек.");

            Properties.Settings.Default.Save();
        }
    }
}
